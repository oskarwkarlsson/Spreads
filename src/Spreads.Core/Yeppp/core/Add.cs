// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.


using System.Runtime.InteropServices;
using System.Security;
using Bootstrap;

namespace Spreads.Yeppp
{

    /// <summary>Basic arithmetic operations</summary>
    public partial class Core
	{
        internal static ABI ABI { get; set; }
        static Core()
	    {
            ABI = Yeppp.Library.ABI;
        }

		/// <summary>Adds corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V8sV8s_V8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, sbyte[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (sbyte* sum = &sumArray[sumOffset])
					{
						Add_V8sV8s_V8s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V8sV8s_V16s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, short[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (short* sum = &sumArray[sumOffset])
					{
						Add_V8sV8s_V16s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two unsigned 8-bit integer arrays. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V8uV8u_V16u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, ushort[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (byte* y = &yArray[yOffset])
				{
					fixed (ushort* sum = &sumArray[sumOffset])
					{
						Add_V8uV8u_V16u(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V16sV16s_V16s(short[] xArray, int xOffset, short[] yArray, int yOffset, short[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (short* sum = &sumArray[sumOffset])
					{
						Add_V16sV16s_V16s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V16sV16s_V32s(short[] xArray, int xOffset, short[] yArray, int yOffset, int[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (int* sum = &sumArray[sumOffset])
					{
						Add_V16sV16s_V32s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two unsigned 16-bit integer arrays. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V16uV16u_V32u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, uint[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (ushort* y = &yArray[yOffset])
				{
					fixed (uint* sum = &sumArray[sumOffset])
					{
						Add_V16uV16u_V32u(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32sV32s_V32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (int* sum = &sumArray[sumOffset])
					{
						Add_V32sV32s_V32s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32sV32s_V64s(int[] xArray, int xOffset, int[] yArray, int yOffset, long[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (long* sum = &sumArray[sumOffset])
					{
						Add_V32sV32s_V64s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two unsigned 32-bit integer arrays. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32uV32u_V64u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, ulong[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					fixed (ulong* sum = &sumArray[sumOffset])
					{
						Add_V32uV32u_V64u(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 64-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V64sV64s_V64s(long[] xArray, int xOffset, long[] yArray, int yOffset, long[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					fixed (long* sum = &sumArray[sumOffset])
					{
						Add_V64sV64s_V64s(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two single precision (32-bit) floating-point arrays. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32fV32f_V32f(float[] xArray, int xOffset, float[] yArray, int yOffset, float[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					fixed (float* sum = &sumArray[sumOffset])
					{
						Add_V32fV32f_V32f(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds corresponding elements in two double precision (64-bit) floating-point arrays. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V64fV64f_V64f(double[] xArray, int xOffset, double[] yArray, int yOffset, double[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					fixed (double* sum = &sumArray[sumOffset])
					{
						Add_V64fV64f_V64f(x, y, sum, length);
					}
				}
			}
		}


		/// <summary>Adds a constant to signed 8-bit integer array elements. Produces an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V8sS8s_V8s(sbyte[] xArray, int xOffset, sbyte y, sbyte[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* sum = &sumArray[sumOffset])
				{
					Add_V8sS8s_V8s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 8-bit integer array elements. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V8sS8s_V16s(sbyte[] xArray, int xOffset, sbyte y, short[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (short* sum = &sumArray[sumOffset])
				{
					Add_V8sS8s_V16s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to unsigned 8-bit integer array elements. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V8uS8u_V16u(byte[] xArray, int xOffset, byte y, ushort[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (ushort* sum = &sumArray[sumOffset])
				{
					Add_V8uS8u_V16u(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 16-bit integer array elements. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V16sS16s_V16s(short[] xArray, int xOffset, short y, short[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* sum = &sumArray[sumOffset])
				{
					Add_V16sS16s_V16s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 16-bit integer array elements. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V16sS16s_V32s(short[] xArray, int xOffset, short y, int[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (int* sum = &sumArray[sumOffset])
				{
					Add_V16sS16s_V32s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to unsigned 16-bit integer array elements. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V16uS16u_V32u(ushort[] xArray, int xOffset, ushort y, uint[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (uint* sum = &sumArray[sumOffset])
				{
					Add_V16uS16u_V32u(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 32-bit integer array elements. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32sS32s_V32s(int[] xArray, int xOffset, int y, int[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* sum = &sumArray[sumOffset])
				{
					Add_V32sS32s_V32s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to unsigned 32-bit integer array elements. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32uS32u_V64u(uint[] xArray, int xOffset, uint y, ulong[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (ulong* sum = &sumArray[sumOffset])
				{
					Add_V32uS32u_V64u(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 32-bit integer array elements. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32sS32s_V64s(int[] xArray, int xOffset, int y, long[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (long* sum = &sumArray[sumOffset])
				{
					Add_V32sS32s_V64s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 64-bit integer array elements. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V64sS64s_V64s(long[] xArray, int xOffset, long y, long[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* sum = &sumArray[sumOffset])
				{
					Add_V64sS64s_V64s(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to single precision (32-bit) floating-point array elements. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V32fS32f_V32f(float[] xArray, int xOffset, float y, float[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* sum = &sumArray[sumOffset])
				{
					Add_V32fS32f_V32f(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds a constant to double precision (64-bit) floating-point array elements. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or sumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or sumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, sumOffset is negative, sumOffset + length exceeds the length of sumArray, or length is negative.</exception>
		public static unsafe void Add_V64fS64f_V64f(double[] xArray, int xOffset, double y, double[] sumArray, int sumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (sumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (sumOffset + length > sumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* sum = &sumArray[sumOffset])
				{
					Add_V64fS64f_V64f(x, y, sum, length);
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Add_IV8sV8s_IV8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					Add_IV8sV8s_IV8s(x, y, length);
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Add_IV16sV16s_IV16s(short[] xArray, int xOffset, short[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					Add_IV16sV16s_IV16s(x, y, length);
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Add_IV32sV32s_IV32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					Add_IV32sV32s_IV32s(x, y, length);
				}
			}
		}


		/// <summary>Adds corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Add_IV64sV64s_IV64s(long[] xArray, int xOffset, long[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					Add_IV64sV64s_IV64s(x, y, length);
				}
			}
		}


		/// <summary>Adds corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Add_IV32fV32f_IV32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					Add_IV32fV32f_IV32f(x, y, length);
				}
			}
		}


		/// <summary>Adds corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Add_IV64fV64f_IV64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					Add_IV64fV64f_IV64f(x, y, length);
				}
			}
		}


		/// <summary>Adds a constant to signed 8-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Add_IV8sS8s_IV8s(sbyte[] xArray, int xOffset, sbyte y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				Add_IV8sS8s_IV8s(x, y, length);
			}
		}


		/// <summary>Adds a constant to signed 16-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Add_IV16sS16s_IV16s(short[] xArray, int xOffset, short y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				Add_IV16sS16s_IV16s(x, y, length);
			}
		}


		/// <summary>Adds a constant to signed 32-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Add_IV32sS32s_IV32s(int[] xArray, int xOffset, int y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				Add_IV32sS32s_IV32s(x, y, length);
			}
		}


		/// <summary>Adds a constant to signed 64-bit integer array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Add_IV64sS64s_IV64s(long[] xArray, int xOffset, long y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				Add_IV64sS64s_IV64s(x, y, length);
			}
		}


		/// <summary>Adds a constant to single precision (32-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Add_IV32fS32f_IV32f(float[] xArray, int xOffset, float y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				Add_IV32fS32f_IV32f(x, y, length);
			}
		}


		/// <summary>Adds a constant to double precision (64-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Add_IV64fS64f_IV64f(double[] xArray, int xOffset, double y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				Add_IV64fS64f_IV64f(x, y, length);
			}
		}


		/// <summary>Adds corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 8-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 8-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V8sV8s_V8s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 8-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 8-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V8sV8s_V16s(sbyte* x, sbyte* y, short* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V8sV8s_V16s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two unsigned 8-bit integer arrays. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of unsigned 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of unsigned 8-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V8uV8u_V16u(byte* x, byte* y, ushort* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V8uV8u_V16u(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 16-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V16sV16s_V16s(short* x, short* y, short* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V16sV16s_V16s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 16-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 16-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V16sV16s_V32s(short* x, short* y, int* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V16sV16s_V32s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two unsigned 16-bit integer arrays. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of unsigned 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of unsigned 16-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V16uV16u_V32u(ushort* x, ushort* y, uint* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V16uV16u_V32u(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 32-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32sV32s_V32s(int* x, int* y, int* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32sV32s_V32s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 32-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 32-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32sV32s_V64s(int* x, int* y, long* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32sV32s_V64s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two unsigned 32-bit integer arrays. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of unsigned 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of unsigned 32-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32uV32u_V64u(uint* x, uint* y, ulong* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32uV32u_V64u(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 64-bit integer arrays. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the first addend array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 64-bit integer elements.</param>
		/// <param name="sum">Pointer to the summand array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V64sV64s_V64s(long* x, long* y, long* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V64sV64s_V64s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two single precision (32-bit) floating-point arrays. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the first addend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second addend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="sum">Pointer to the summand array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32fV32f_V32f(float* x, float* y, float* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32fV32f_V32f(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two double precision (64-bit) floating-point arrays. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the first addend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second addend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="sum">Pointer to the summand array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and sum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V64fV64f_V64f(double* x, double* y, double* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V64fV64f_V64f(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 8-bit integer array elements. Produces an array of signed 8-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V8sS8s_V8s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 8-bit integer array elements. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V8sS8s_V16s(sbyte* x, sbyte y, short* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V8sS8s_V16s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to unsigned 8-bit integer array elements. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of unsigned 8-bit integer elements.</param>
		/// <param name="y">The unsigned 8-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V8uS8u_V16u(byte* x, byte y, ushort* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V8uS8u_V16u(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 16-bit integer array elements. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V16sS16s_V16s(short* x, short y, short* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V16sS16s_V16s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 16-bit integer array elements. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V16sS16s_V32s(short* x, short y, int* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V16sS16s_V32s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to unsigned 16-bit integer array elements. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of unsigned 16-bit integer elements.</param>
		/// <param name="y">The unsigned 16-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V16uS16u_V32u(ushort* x, ushort y, uint* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V16uS16u_V32u(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 32-bit integer array elements. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32sS32s_V32s(int* x, int y, int* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32sS32s_V32s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to unsigned 32-bit integer array elements. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of unsigned 32-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32uS32u_V64u(uint* x, uint y, ulong* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32uS32u_V64u(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 32-bit integer array elements. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32sS32s_V64s(int* x, int y, long* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32sS32s_V64s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 64-bit integer array elements. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the addend array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 64-bit integer constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V64sS64s_V64s(long* x, long y, long* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V64sS64s_V64s(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to single precision (32-bit) floating-point array elements. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the addend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V32fS32f_V32f(float* x, float y, float* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V32fS32f_V32f(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to double precision (64-bit) floating-point array elements. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the addend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant to be added.</param>
		/// <param name="sum">Pointer to the summand array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and sum.</param>
		/// <exception cref="System.NullReferenceException">If x or sum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or sum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_V64fS64f_V64f(double* x, double y, double* sum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_V64fS64f_V64f(x, y, sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first addend array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV8sV8s_IV8s(sbyte* x, sbyte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV8sV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first addend array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV16sV16s_IV16s(short* x, short* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV16sV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first addend array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV32sV32s_IV32s(int* x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV32sV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first addend array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second addend array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV64sV64s_IV64s(long* x, long* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV64sV64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first addend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second addend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV32fV32f_IV32f(float* x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV32fV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first addend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second addend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV64fV64f_IV64f(double* x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV64fV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 8-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the addend array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be added.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV8sS8s_IV8s(sbyte* x, sbyte y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV8sS8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 16-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the addend array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be added.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV16sS16s_IV16s(short* x, short y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV16sS16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 32-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the addend array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be added.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV32sS32s_IV32s(int* x, int y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV32sS32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to signed 64-bit integer array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the addend array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 64-bit integer constant to be added.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV64sS64s_IV64s(long* x, long y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV64sS64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to single precision (32-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the addend array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant to be added.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV32fS32f_IV32f(float* x, float y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV32fS32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Adds a constant to double precision (64-bit) floating-point array elements and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the addend array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant to be added.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Add_IV64fS64f_IV64f(double* x, double y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Add_IV64fS64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V8sV8s_V8s")]
		internal static unsafe extern Status yepCore_Add_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V8sV8s_V16s")]
        internal static unsafe extern Status yepCore_Add_V8sV8s_V16s(sbyte* x, sbyte* y, short* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V8uV8u_V16u")]
        internal static unsafe extern Status yepCore_Add_V8uV8u_V16u(byte* x, byte* y, ushort* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V16sV16s_V16s")]
        internal static unsafe extern Status yepCore_Add_V16sV16s_V16s(short* x, short* y, short* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V16sV16s_V32s")]
        internal static unsafe extern Status yepCore_Add_V16sV16s_V32s(short* x, short* y, int* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V16uV16u_V32u")]
        internal static unsafe extern Status yepCore_Add_V16uV16u_V32u(ushort* x, ushort* y, uint* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32sV32s_V32s")]
        internal static unsafe extern Status yepCore_Add_V32sV32s_V32s(int* x, int* y, int* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32sV32s_V64s")]
        internal static unsafe extern Status yepCore_Add_V32sV32s_V64s(int* x, int* y, long* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32uV32u_V64u")]
		internal static unsafe extern Status yepCore_Add_V32uV32u_V64u(uint* x, uint* y, ulong* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V64sV64s_V64s")]
		internal static unsafe extern Status yepCore_Add_V64sV64s_V64s(long* x, long* y, long* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32fV32f_V32f")]
		internal static unsafe extern Status yepCore_Add_V32fV32f_V32f(float* x, float* y, float* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V64fV64f_V64f")]
		internal static unsafe extern Status yepCore_Add_V64fV64f_V64f(double* x, double* y, double* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V8sS8s_V8s")]
		internal static unsafe extern Status yepCore_Add_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V8sS8s_V16s")]
		internal static unsafe extern Status yepCore_Add_V8sS8s_V16s(sbyte* x, sbyte y, short* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V8uS8u_V16u")]
		internal static unsafe extern Status yepCore_Add_V8uS8u_V16u(byte* x, byte y, ushort* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V16sS16s_V16s")]
		internal static unsafe extern Status yepCore_Add_V16sS16s_V16s(short* x, short y, short* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V16sS16s_V32s")]
		internal static unsafe extern Status yepCore_Add_V16sS16s_V32s(short* x, short y, int* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V16uS16u_V32u")]
		internal static unsafe extern Status yepCore_Add_V16uS16u_V32u(ushort* x, ushort y, uint* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32sS32s_V32s")]
		internal static unsafe extern Status yepCore_Add_V32sS32s_V32s(int* x, int y, int* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32uS32u_V64u")]
		internal static unsafe extern Status yepCore_Add_V32uS32u_V64u(uint* x, uint y, ulong* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32sS32s_V64s")]
		internal static unsafe extern Status yepCore_Add_V32sS32s_V64s(int* x, int y, long* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V64sS64s_V64s")]
		internal static unsafe extern Status yepCore_Add_V64sS64s_V64s(long* x, long y, long* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V32fS32f_V32f")]
        internal static unsafe extern Status yepCore_Add_V32fS32f_V32f(float* x, float y, float* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_V64fS64f_V64f")]
		internal static unsafe extern Status yepCore_Add_V64fS64f_V64f(double* x, double y, double* sum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV8sV8s_IV8s")]
		internal static unsafe extern Status yepCore_Add_IV8sV8s_IV8s(sbyte* x, sbyte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV16sV16s_IV16s")]
		internal static unsafe extern Status yepCore_Add_IV16sV16s_IV16s(short* x, short* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV32sV32s_IV32s")]
		internal static unsafe extern Status yepCore_Add_IV32sV32s_IV32s(int* x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV64sV64s_IV64s")]
		internal static unsafe extern Status yepCore_Add_IV64sV64s_IV64s(long* x, long* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV32fV32f_IV32f")]
		internal static unsafe extern Status yepCore_Add_IV32fV32f_IV32f(float* x, float* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV64fV64f_IV64f")]
		internal static unsafe extern Status yepCore_Add_IV64fV64f_IV64f(double* x, double* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV8sS8s_IV8s")]
		internal static unsafe extern Status yepCore_Add_IV8sS8s_IV8s(sbyte* x, sbyte y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV16sS16s_IV16s")]
		internal static unsafe extern Status yepCore_Add_IV16sS16s_IV16s(short* x, short y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV32sS32s_IV32s")]
		internal static unsafe extern Status yepCore_Add_IV32sS32s_IV32s(int* x, int y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV64sS64s_IV64s")]
		internal static unsafe extern Status yepCore_Add_IV64sS64s_IV64s(long* x, long y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV32fS32f_IV32f")]
		internal static unsafe extern Status yepCore_Add_IV32fS32f_IV32f(float* x, float y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Add_IV64fS64f_IV64f")]
		internal static unsafe extern Status yepCore_Add_IV64fS64f_IV64f(double* x, double y, System.UIntPtr length);

	}

}
