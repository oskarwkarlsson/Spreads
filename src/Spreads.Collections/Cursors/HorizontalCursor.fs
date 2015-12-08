﻿namespace Spreads

open System
open System.Linq
open System.Collections
open System.Collections.Generic
open System.Diagnostics
open System.Runtime.InteropServices
open System.Runtime.CompilerServices
open System.Threading.Tasks

open Spreads
open Spreads.Collections


type internal HorizontalCursor<'K,'V,'State,'V2>
  (
    cursorFactory:Func<ICursor<'K,'V>>,
    stateCreator:Func<ICursor<'K,'V>, KVP<'K,'V>, KVP<bool,'State>>, // Factory if state needs its own cursor
    stateFoldNext:Func<'State, KVP<'K,'V>, KVP<bool,'State>>,
    stateFoldPrevious:Func<'State, KVP<'K,'V>, KVP<bool,'State>>,
    stateMapper:Func<'State,'V2>,
    isContinuous:bool // stateCreator could be able to create state at any point. If isContinuous = true but stateCreator returns false, we fail
  ) =
  inherit Series<'K,'V2>()
  let cursor = cursorFactory.Invoke()
  let mutable okState = Unchecked.defaultof<KVP<bool,'State>>
  let clearState() = 
    match box okState.Value with
    | :? IDisposable as disp -> disp.Dispose()
    | _ -> ()
    okState <- Unchecked.defaultof<KVP<bool,'State>>


  let threadId = Environment.CurrentManagedThreadId
  [<DefaultValueAttribute>]
  val mutable started : bool
  override this.GetCursor() =
    this.started <- true
    let cursor = if not this.started && threadId = Environment.CurrentManagedThreadId then this else this.Clone()
    cursor.started <- true
    cursor :> ICursor<'K,'V2>

  member this.Clone() = new HorizontalCursor<'K,'V,'State,'V2>((fun _ -> cursor.Clone()), stateCreator, stateFoldNext, stateFoldPrevious, stateMapper, isContinuous)


  member this.CurrentValue 
    with get() =
      if okState.Key then stateMapper.Invoke(okState.Value)
      else Unchecked.defaultof<'V2>

  member this.Current with get () = KVP(cursor.CurrentKey, this.CurrentValue)
  member val CurrentBatch = Unchecked.defaultof<IReadOnlyOrderedMap<'K,'V2>> with get


  member this.Reset() = 
    clearState()
    cursor.Reset()

  member this.Dispose() =
    clearState()
    cursor.Dispose()


  member this.MoveFirst(): bool =
    if okState.Key then clearState() // we are moving from a valid state to new state, must clear existing state
    if cursor.MoveFirst() then
#if PRERELEASE
      let before = cursor.CurrentKey
      okState <- stateCreator.Invoke(cursor, cursor.Current)
      if cursor.Comparer.Compare(before, cursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
      okState <- stateCreator.Invoke(cursor, cursor.Current)
#endif
      if okState.Key then
        true
      else
        let mutable found = false
        while not found && cursor.MoveNext() do
#if PRERELEASE
          let before = cursor.CurrentKey
          okState <- stateCreator.Invoke(cursor, cursor.Current)
          if cursor.Comparer.Compare(before, cursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
          okState <- stateCreator.Invoke(cursor, cursor.Current)
#endif
          found <- okState.Key
        if found then true 
        else false
    else false

  member this.MoveNext(): bool =
      if okState.Key then
        let mutable found = false
        while not found && cursor.MoveNext() do 
          okState <- stateFoldNext.Invoke(okState.Value, cursor.Current)
          found <- okState.Key
        if found then true 
        else false
      else this.MoveFirst()


  member this.MoveLast(): bool =
    if okState.Key then clearState() // we are moving from a valid state to new state, must clear existing state
    if cursor.MoveLast() then
#if PRERELEASE
      let before = cursor.CurrentKey
      okState <- stateCreator.Invoke(cursor, cursor.Current)
      if cursor.Comparer.Compare(before, cursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
      okState <- stateCreator.Invoke(cursor, cursor.Current)
#endif
      if okState.Key then
        true
      else
        let mutable found = false
        while not found && cursor.MovePrevious() do
#if PRERELEASE
          let before = cursor.CurrentKey
          okState <- stateCreator.Invoke(cursor, cursor.Current)
          if cursor.Comparer.Compare(before, cursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
          okState <- stateCreator.Invoke(cursor, cursor.Current)
#endif
          found <- okState.Key
        if found then true 
        else false
    else false

  member this.MovePrevious(): bool =
      if okState.Key then
        let mutable found = false
        while not found && cursor.MovePrevious() do 
          okState <- stateFoldPrevious.Invoke(okState.Value, cursor.Current)
          found <- okState.Key
        if found then true 
        else false
      else this.MoveLast()

  member this.MoveAt(index: 'K, direction: Lookup): bool = 
    if this.InputCursor.MoveAt(index, direction) then
#if PRERELEASE
      let before = this.InputCursor.CurrentKey
      let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
      if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
      let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
#endif
      if ok then
        this.CurrentKey <- this.InputCursor.CurrentKey
        //this.CurrentValue <- this.EvaluateState(state)
        hasValidState <- true
        true
      else
        match direction with
        | Lookup.EQ -> false
        | Lookup.GE | Lookup.GT ->
          let mutable found = false
          while not found && this.InputCursor.MoveNext() do
#if PRERELEASE
            let before = this.InputCursor.CurrentKey
            let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
            if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
            let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
#endif
            if ok then
              found <- true
              this.CurrentKey <- this.InputCursor.CurrentKey
              //this.CurrentValue <- this.EvaluateState(state)
          if found then 
            hasValidState <- true
            true
          else false
        | Lookup.LE | Lookup.LT ->
          let mutable found = false
          while not found && this.InputCursor.MovePrevious() do
#if PRERELEASE
            let before = this.InputCursor.CurrentKey
            let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
            if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
#else
            let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
#endif
            if ok then
              found <- true
              this.CurrentKey <- this.InputCursor.CurrentKey
              //this.CurrentValue <- this.EvaluateState(state)
          if found then 
            hasValidState <- true
            true 
          else false
        | _ -> failwith "wrong lookup value"
    else false
      
    
    
//  member this.MoveLastOld(): bool = 
//    if this.InputCursor.MoveLast() then
//#if PRERELEASE
//      let before = this.InputCursor.CurrentKey
//      let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
//      if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
//#else
//      let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
//#endif
//      if ok then
//        this.CurrentKey <- this.InputCursor.CurrentKey
//        //this.CurrentValue <- this.EvaluateState(state)
//        hasValidState <- true
//        true
//      else
//        let mutable found = false
//        while not found && this.InputCursor.MovePrevious() do
//#if PRERELEASE
//          let before = this.InputCursor.CurrentKey
//          let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
//          if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
//#else
//          let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
//#endif
//          if ok then
//            found <- true
//            this.CurrentKey <- this.InputCursor.CurrentKey
//            //this.CurrentValue <- this.EvaluateState(state)
//        if found then 
//          hasValidState <- true
//          true
//        else false
//    else false

//  member this.MovePrevious(): bool = 
//    if hasValidState then
//      let mutable found = false
//      while not found && this.InputCursor.MovePrevious() do
//#if PRERELEASE
//        let before = this.InputCursor.CurrentKey
//        let ok = this.TryUpdateStatePrevious(this.InputCursor.Current, &state)
//        if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
//#else
//        let ok = this.TryUpdateStatePrevious(this.InputCursor.Current, &state)
//#endif
//        if ok then 
//          found <- true
//          this.CurrentKey <- this.InputCursor.CurrentKey
//          //this.CurrentValue <- this.EvaluateState(state)
//      if found then 
//        hasValidState <- true
//        true 
//      else false
//    else (this :> ICursor<'K,'V2>).MoveLast()

  // TODO! this is first draft. At least do via rec function, later implement all binds in C#
  member this.MoveNext(cancellationToken: Threading.CancellationToken): Task<bool> =
    task {
      if hasValidState then
        let mutable found = false
        let mutable moved = false
        if this.InputCursor.MoveNext() then moved <- true
        else
          let! moved' = this.InputCursor.MoveNext(cancellationToken)
          moved <- moved'
        while not found && moved do
          let ok = this.TryUpdateStateNext(this.InputCursor.Current, &state)
          if ok then
            found <- true
            this.CurrentKey <- this.InputCursor.CurrentKey
          else
            if this.InputCursor.MoveNext() then moved <- true
            else
              let! moved' = this.InputCursor.MoveNext(cancellationToken)
              moved <- moved'
        if found then 
          return true 
        else return false
      else
        let mutable found = false
        let mutable moved = false
        if this.InputCursor.MoveNext() then moved <- true
        else
          let! moved' = this.InputCursor.MoveNext(cancellationToken)
          moved <- moved'
        while not found && moved do
          let ok = this.TryCreateState(this.InputCursor.CurrentKey, &state)
          if ok then
            found <- true
            this.CurrentKey <- this.InputCursor.CurrentKey
            //this.CurrentValue <- this.EvaluateState(state)
            hasValidState <- true
          else
            if this.InputCursor.MoveNext() then moved <- true
            else
              let! moved' = this.InputCursor.MoveNext(cancellationToken)
              moved <- moved'
        if found then 
          //hasInitializedValue <- true
          return true 
        else return false
    }


  member this.TryGetValueChecked(key: 'K, [<Out>] value: byref<'V2>): bool = 
    let mutable v = Unchecked.defaultof<'V2>
    let before = this.InputCursor.CurrentKey
    let ok = this.TryGetValue(key, &v)
    if cursor.Comparer.Compare(before, this.InputCursor.CurrentKey) <> 0 then 
      raise (InvalidOperationException("CursorBind's TryGetValue implementation must not move InputCursor"))
    value <- v
    ok


  interface IEnumerator<KVP<'K,'V2>> with
    member this.Reset() = this.Reset()
    member this.MoveNext(): bool = this.MoveNext()
    member this.Current with get(): KVP<'K, 'V2> = KVP(cursor.CurrentKey, this.CurrentValue)
    member this.Current with get(): obj = KVP(cursor.CurrentKey, this.CurrentValue) :> obj 
    member x.Dispose(): unit = x.Dispose()

  interface ICursor<'K,'V2> with
    member this.Comparer with get() = cursor.Comparer
    member this.CurrentBatch: IReadOnlyOrderedMap<'K,'V2> = this.CurrentBatch
    member this.CurrentKey: 'K = cursor.CurrentKey
    member this.CurrentValue: 'V2 = this.CurrentValue
    member this.IsContinuous: bool = isContinuous
    member this.MoveAt(index: 'K, direction: Lookup): bool = this.MoveAt(index, direction) 
    member this.MoveFirst(): bool = this.MoveFirst()
    member this.MoveLast(): bool = this.MoveLast()
    member this.MovePrevious(): bool = this.MovePrevious()
    
    member this.MoveNext(cancellationToken: Threading.CancellationToken): Task<bool> = this.MoveNext(cancellationToken)
    member this.MoveNextBatch(cancellationToken: Threading.CancellationToken): Task<bool> = failwith "TODO Not implemented yet"
    
    //member this.IsBatch with get() = this.IsBatch
    member this.Source: ISeries<'K,'V2> = this :> ISeries<'K,'V2>
    member this.TryGetValue(key: 'K, [<Out>] value: byref<'V2>): bool =  
#if PRERELEASE
      this.TryGetValueChecked(key, &value)
#else
      this.TryGetValue(key, &value)
#endif
    member this.Clone() = this.Clone() :> ICursor<'K,'V2>


  interface ICanMapSeriesValues<'K,'V2> with
    member this.Map<'V3>(f2:Func<'V2,'V3>): Series<'K,'V3> = 
      let func = CoreUtils.CombineMaps(stateMapper, f2)
      new HorizontalCursor<'K,'V,'State,'V3>((fun _ -> cursor.Clone()), stateCreator, stateFoldNext, stateFoldPrevious, func, isContinuous) :> Series<'K,'V3>