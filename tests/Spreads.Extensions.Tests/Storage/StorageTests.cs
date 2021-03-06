﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.


using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;
using NUnit.Framework;
using Spreads.Collections;
using Spreads.DataTypes;
using Spreads.Storage;

namespace Spreads.Extensions.Tests.Storage {

    [TestFixture, Ignore]
    public class StorageTests {


        [Test, Ignore]
        public void CouldCreateSeriesStorage() {
            var folder = Bootstrap.Bootstrapper.Instance.DataFolder;
            Console.WriteLine(folder);
            var storage = SeriesStorage.GetDefault("storage_test.db");
            storage.GetPersistentOrderedMap<int, int>("int_map");

            Assert.Throws(typeof(ArgumentException), () => {
                try {
                    var map = storage.GetPersistentOrderedMap<int, double>("int_map");
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    throw;
                }
            });
        }


        [Test, Ignore]
        public void CouldCRUDSeriesStorage() {
            var storage = new SeriesStorage("Filename=../benchmark.db"); // SeriesStorage.Default;
            var timeseries = storage.GetPersistentOrderedMap<DateTime, Price>("test_timeseries").Result;

            Console.WriteLine(storage.Connection.DataSource);
            

            if (!timeseries.IsEmpty) {
                // Remove all values
                timeseries.RemoveMany(timeseries.First.Key, Lookup.GE);
            }

            var sw = new Stopwatch();
            var count = 10000000L;
            Console.WriteLine($"Count: {count}");
            var start = DateTime.UtcNow;
            Console.WriteLine($"Started at: {start}");
            var date = DateTime.UtcNow.Date;
            var rng = new Random();
            sw.Start();
            var sum0 = 0.0M;
            for (long i = 0; i < count; i++) {
                var value = new Price(Math.Round(i + rng.NextDouble(), 2), 2);
                sum0 += value;
                timeseries.Add(date, value);
                date = date.AddTicks(rng.Next(1, 100));
                if (i % 1000000 == 0) {
                    var msec = (DateTime.UtcNow - start).TotalMilliseconds;
                    var mops = i * 0.001 / msec;
                    Console.WriteLine($"Wrote: {i} - {Math.Round((i * 1.0) / (count * 1.0), 4) * 100.0}% in {msec / 1000} sec, Mops: {mops}");
                }
            }
            timeseries.Flush();
            Console.WriteLine($"Wrote: {count} - 100%");
            Console.WriteLine($"Finished at: {DateTime.UtcNow}");
            sw.Stop();
            Console.WriteLine($"Writes, Mops: {count * 0.001 / sw.ElapsedMilliseconds}");


            sw.Restart();
            var sum = 0.0M;
            var storage2 = new SeriesStorage("Filename=../benchmark.db"); // $"Filename={Path.Combine(Bootstrap.Bootstrapper.Instance.DataFolder, "default.db")}");
            var timeseries2 = storage2.GetPersistentOrderedMap<DateTime, Price>("test_timeseries").Result;
            foreach (var kvp in timeseries2) {
                sum += kvp.Value;
            }
            Assert.IsTrue(sum > 0);
            Assert.AreEqual(sum0, sum);
            sw.Stop();
            Console.WriteLine($"Reads, Mops: {count * 0.001 / sw.ElapsedMilliseconds}");

            var _connection =
                new SqliteConnection("Filename=../benchmark.db");
            //$"Filename={Path.Combine(Bootstrap.Bootstrapper.Instance.DataFolder, "default.db")}");

            var sqlCount = _connection.ExecuteScalar<long>($"SELECT sum(count) FROM {storage.ChunkTableName} where id = (SELECT id from {storage.IdTableName} where TextId = 'test_timeseries'); ");
            Console.WriteLine($"Count in SQLite: {sqlCount}");
            Assert.AreEqual(count, sqlCount);
            var sqlSize = _connection.ExecuteScalar<long>($"SELECT sum(length(ChunkValue)) FROM {storage.ChunkTableName} where id = (SELECT id from {storage.IdTableName} where TextId = 'test_timeseries'); ");
            Console.WriteLine($"Memory size: {count * 16L}; SQLite net blob size: {sqlSize}; comp ratio: {Math.Round(count * 16.0 / sqlSize * 1.0, 2)}");

        }


        [Test]
        public void CouldAddValuesByKey() {
            var repo = new SeriesStorage(SeriesStorage.GetDefaultConnectionString("../StorageTests.db"));
            var series = repo.GetPersistentOrderedMap<DateTime, decimal>("test_series_CouldAddValuesByKey").Result;
            var test2 = series.Map(x => (double)x);
            series.RemoveAll();
            //series.RemoveMany(DateTime.Today.AddHours(-6), Lookup.GE);
            for (int i = 0; i < 10; i++) {
                series.Add(DateTime.Today.AddMinutes(i), i);
            }
            series.Flush();
            for (int i = 10; i < 100; i++) {
                series[DateTime.Today.AddMinutes(i)] = i;
            }
            series.Flush();
            series[DateTime.Today.AddMinutes(100)] = 100;
            Console.WriteLine(test2.Last.Key + " " + test2.Last.Key);
            series[DateTime.Today.AddMinutes(1000)] = 1000;
        }

        [Test]
        public void CouldWriteToStorage() {
            var repo = new SeriesStorage(SeriesStorage.GetDefaultConnectionString("../StorageTests.db"));
            var test = new SortedMap<DateTime, double>();
            for (int i = 0; i < 10; i++) {
                test.Add(DateTime.UtcNow.Date.AddSeconds(i), i);
            }
            test.Complete();
            foreach (var kvp in test.Map(x => (decimal)x)) {
                Console.WriteLine($"{kvp.Key} - {kvp.Key.Kind} - {kvp.Value}");
            }

            var storageSeries = repo.GetPersistentOrderedMap<DateTime, decimal>("test_series_CouldWriteToStorage").Result;
            var test2 = storageSeries.ToSortedMap();
            foreach (var kvp in test2) {
                Console.WriteLine($"{kvp.Key} - {kvp.Key.Kind} - {kvp.Value}");
            }
            storageSeries.Append(test.Map(x => (decimal)x), AppendOption.RequireEqualOverlap);
            storageSeries.Flush();
        }
    }
}
