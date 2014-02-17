// Copyright (C) 2014 dot42
//
// Original filename: Buffer.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Runtime.InteropServices;
using Dot42;
using Java.Nio;

namespace System 
{
	[ComVisible (true)]
	public static class Buffer {

		public static int ByteLength (Array array)
		{
			if (array == null)throw new ArgumentNullException ("array");

            if (array.Length == 0) return 0;

		    var type = array.GetType().GetElementType();

            if (!type.IsPrimitive)throw new ArgumentException ("Object must be an array of primitives.");

            return array.Length * NumberOfBytesForPrimitiveType (type);
		}

        /*
		public static byte GetByte (Array array, int index)
		{
			if (index < 0 || index >= ByteLength (array))
				throw new ArgumentOutOfRangeException ("index", "Value must be non-negative and less than the size of the collection."));

			return ...;
		}
        */

        /*
		public static void SetByte (Array array, int index, byte value)
		{
			if (index < 0 || index >= ByteLength (array))
				throw new ArgumentOutOfRangeException ("index", "Value must be non-negative and less than the size of the collection."));

			//
		}
        */

        /// <summary>
        /// Copies a specified number of bytes from a source array starting at a particular offset to 
        /// a destination array starting at a particular offset.
        /// </summary>
        /// <param name="src">The source buffer.</param>
        /// <param name="srcOffset">The byte offset into src.</param>
        /// <param name="dst">The destination buffer.</param>
        /// <param name="dstOffset">The byte offset into dst.</param>
        /// <param name="count">The number of bytes to copy.</param>
		public static void BlockCopy (Array src, int srcOffset, Array dst, int dstOffset, int count)
		{
			if (src == null)
				throw new ArgumentNullException ("src");

			if (dst == null)
				throw new ArgumentNullException ("dst");

			if (srcOffset < 0)
				throw new ArgumentOutOfRangeException ("srcOffset", "Non-negative number required.");

			if (dstOffset < 0)
				throw new ArgumentOutOfRangeException ("dstOffset", "Non-negative number required.");

			if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "Non-negative number required.");

            if (count == 0) return;

            var srcType = src.GetType().GetElementType();
            if (!srcType.IsPrimitive) throw new ArgumentException("Source object must be an array of primitives.");

            var srcStartIndex = 0;
            var srcBytesForPrimitiveType = NumberOfBytesForPrimitiveType(srcType);

            if (srcOffset != 0)
            {
                if (srcOffset % srcBytesForPrimitiveType != 0) throw new ArgumentOutOfRangeException( "srcOffset", "Should be a multiple of " + srcBytesForPrimitiveType.ToString());
                srcStartIndex = srcOffset/srcBytesForPrimitiveType;
            }

            if (count % srcBytesForPrimitiveType != 0) throw new ArgumentOutOfRangeException( "count", "Should be a multiple of " + srcBytesForPrimitiveType.ToString());
            var srcIndexLength = count/srcBytesForPrimitiveType;

            if (src.Length < (long)srcStartIndex + srcIndexLength) throw new ArgumentException("count", "src buffer (as of srcOffset) to small for count");

            var dstType = dst.GetType().GetElementType();
            if (!dstType.IsPrimitive) throw new ArgumentException("Destination object must be an array of primitives.");

            var dstStartIndex = 0;
            var dstBytesForPrimitiveType = NumberOfBytesForPrimitiveType(dstType);

            if (dstOffset != 0)
            {
                if (dstOffset % dstBytesForPrimitiveType != 0) throw new ArgumentOutOfRangeException("dstOffset", "Should be a multiple of " + dstBytesForPrimitiveType.ToString());
                dstStartIndex = dstOffset / dstBytesForPrimitiveType;
            }

            if (count % dstBytesForPrimitiveType != 0) throw new ArgumentOutOfRangeException("count", "Should be a multiple of " + dstBytesForPrimitiveType.ToString());
            var dstIndexLength = count / dstBytesForPrimitiveType;

            if (dst.Length < (long)dstStartIndex + dstIndexLength) throw new ArgumentException("count", "dst buffer (as of dstOffset) to small for count");

            var byteBuffer = CreateByteBuffer(src, srcType, srcStartIndex, srcIndexLength, dst, dstType, dstStartIndex, dstIndexLength);
            OutputBuffer(byteBuffer, dst, dstType, dstStartIndex, dstIndexLength); 
        }

        private static ByteBuffer CreateByteBuffer(Array src, Type srcType, int srcStartIndex, int srcIndexLength, Array dst, Type dstType, int dstStartIndex, int dstIndexLength)
        {
            ByteBuffer buffer = null;

            if (dstType == typeof (byte))
            {
                buffer = ByteBuffer.Wrap((byte[])dst, dstStartIndex, dstIndexLength);
            }
            else if (srcType == typeof (byte))
            {
                buffer = ByteBuffer.Wrap((byte[])src, srcStartIndex, srcIndexLength);
            }
            else
            {
                var numberOfBytes = src.Length * NumberOfBytesForPrimitiveType(srcType);
                buffer = ByteBuffer.Allocate(numberOfBytes);
            }

            buffer.Order(ByteOrder.NativeOrder());

            if (srcType == typeof(byte))
            {
                if (dstType == typeof (byte))
                {
                    //both source and dest are bytes, we wrapped the dest, so copy the source into it (for as many bytes as needed).
                    buffer.Put((byte[])src, srcStartIndex, srcIndexLength);
                }
            }
            else if (srcType == typeof(bool))
            {
                for (var i = 0; i < srcIndexLength; i++)
                {
                    if ((bool)src[srcStartIndex + i])
                        buffer.Put((byte)1);
                    else
                        buffer.Put((byte)0);
                }
            }
            else if (srcType == typeof(char))
            {
                var charBuffer = buffer.AsCharBuffer();
                charBuffer.Put((char[])src, srcStartIndex, srcIndexLength);
            }
            else if (srcType == typeof(short))
            {
                var shortBuffer = buffer.AsShortBuffer();
                shortBuffer.Put((short[])src, srcStartIndex, srcIndexLength);
            }
            else if (srcType == typeof(float))
            {
                var floatBuffer = buffer.AsFloatBuffer();
                floatBuffer.Put((float[])src, srcStartIndex, srcIndexLength);
            }
            else if (srcType == typeof(int))
            {
                var intBuffer = buffer.AsIntBuffer();
                intBuffer.Put((int[])src, srcStartIndex, srcIndexLength);
            }
            else if (srcType == typeof(double))
            {
                var doubleBuffer = buffer.AsDoubleBuffer();
                doubleBuffer.Put((double[])src, srcStartIndex, srcIndexLength);
            }
            else if (srcType == typeof(long))
            {
                var longBuffer = buffer.AsLongBuffer();
                longBuffer.Put((long[])src, srcStartIndex, srcIndexLength);
            }
            else
            {
                throw new NotImplementedException("System.Buffer.CreateByteBuffer");
            }

            return buffer;
        }

        private static void OutputBuffer(ByteBuffer byteBuffer, Array dst, Type dstType, int dstStartIndex, int dstIndexLength)
        {
            if (dstType == typeof(bool))
            {
                for (var i = 0; i < dstIndexLength; i++)
                {
                    dst[dstStartIndex + i] = byteBuffer.Get(i) == 1;
                }
            }
            else if (dstType == typeof(byte))
            {
                //nothing to do, the dst array is wrapped already.
            }
            else if (dstType == typeof(char))
            {
                var charBuffer = byteBuffer.AsCharBuffer();
                charBuffer.Get((char[])dst, dstStartIndex, dstIndexLength);
            }
            else if (dstType == typeof(short))
            {
                var shortBuffer = byteBuffer.AsShortBuffer();
                shortBuffer.Get((short[])dst, dstStartIndex, dstIndexLength);
            }
            else if (dstType == typeof(float))
            {
                var floatBuffer = byteBuffer.AsFloatBuffer();
                floatBuffer.Get((float[])dst, dstStartIndex, dstIndexLength);
            }
            else if (dstType == typeof(int))
            {
                var intBuffer = byteBuffer.AsIntBuffer();
                intBuffer.Get((int[])dst, dstStartIndex, dstIndexLength);
            }
            else if (dstType == typeof(double))
            {
                var doubleBuffer = byteBuffer.AsDoubleBuffer();
                doubleBuffer.Get((double[])dst, dstStartIndex, dstIndexLength);
            }
            else if (dstType == typeof(long))
            {
                var longBuffer = byteBuffer.AsLongBuffer();
                longBuffer.Get((long[])dst, dstStartIndex, dstIndexLength);
            }
            else
            {
                throw new NotImplementedException("System.Buffer.OutputBuffer");
            } 
        }

        private static int NumberOfBytesForPrimitiveType(Type type)
        {
            if (type == typeof (bool)) return 1;
            if (type == typeof(byte)) return 1;
            //if (type == typeof(sbyte)) return 1;
            
            if (type == typeof(char)) return 2;
            if (type == typeof(short)) return 2;
            //if (type == typeof(ushort)) return 2;
            
            if (type == typeof(float)) return 4;
            if (type == typeof(int)) return 4;
            //if (type == typeof(uint)) return 4;
            
            if (type == typeof(double)) return 8;
            if (type == typeof(long)) return 8;
            //if (type == typeof(ulong)) return 8;
            
            //if (type == typeof(decimal)) return 16;

            throw new NotImplementedException("System.Buffer.NumberOfBytesForPrimitiveType");
            //TODO: struct
            //TODO: enum
        }
	}
}

