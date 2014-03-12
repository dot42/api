// Copyright (C) 2014 dot42
//
// Original filename: BitConverter.cs
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
using Java.Lang;
using Java.Nio;

namespace System
{
    public static class BitConverter
    {
        private static ByteBuffer GetReversedBuffer(byte[] value, int startIndex, int length)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            if (startIndex < 0 || (startIndex > value.Length - 1))
                throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");

            if (length < 0 || (startIndex + length > value.Length ))
                throw new ArgumentException("length", "Index was out of range. Collection does not contain enough data to process the request.");

            byte[] newArray = new byte[length];
            for (int i = 0 ; i < length ; i++)
            {
                newArray[i] = value[startIndex + length - i - 1];
            }

            return ByteBuffer.Wrap(newArray, 0, length);
        }

        public static bool IsLittleEndian
        {
            get { return ByteOrder.NativeOrder() == ByteOrder.LITTLE_ENDIAN; }
        }

        public static long DoubleToInt64Bits(double value)
        {
            return double.DoubleToLongBits(value);
        }

        public static double Int64BitsToDouble(long value)
        {
            byte[] b = BitConverter.GetBytes(value);
            return BitConverter.ToDouble(b, 0);
        }

        public static byte[] GetBytes(bool value)
        {
            return new[] { (byte)(value ? 1 : 0) };
        }

        public static byte[] GetBytes(char value)
        {
            var buf = ByteBuffer.Allocate(2).Order(ByteOrder.NativeOrder());
            buf.PutChar(value);
            return buf.ToByteArray();
        }

        public static byte[] GetBytes(short value)
        {
            var buf = ByteBuffer.Allocate(2).Order(ByteOrder.NativeOrder());
            buf.PutShort(value);
            return buf.ToByteArray();
        }

        public static byte[] GetBytes(int value)
        {
            var buf = ByteBuffer.Allocate(4).Order(ByteOrder.NativeOrder());
            buf.PutInt(value);
            return buf.ToByteArray();
        }

        public static byte[] GetBytes(float value)
        {
            var buf = ByteBuffer.Allocate(4).Order(ByteOrder.NativeOrder());
            buf.PutFloat(value);
            return buf.ToByteArray();
        }

        public static byte[] GetBytes(long value)
        {
            var buf = ByteBuffer.Allocate(8).Order(ByteOrder.NativeOrder());
            buf.PutLong(value);
            return buf.ToByteArray();
        }

        public static byte[] GetBytes(double value)
        {
            var buf = ByteBuffer.Allocate(8).Order(ByteOrder.NativeOrder());
            buf.PutDouble(value);
            return buf.ToByteArray();
        }

        public static bool ToBoolean(byte[] value, int startIndex)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            if (startIndex < 0 || (startIndex > value.Length - 1))
                throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");

            return value[startIndex] != 0;
        }

        public static char ToChar(byte[] value, int startIndex)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            if (startIndex < 0 || (startIndex > value.Length - 1))
                throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");

            return (char)(value[startIndex]);
        }

        public static short ToInt16(byte[] value, int startIndex)
        {
            var buf = GetReversedBuffer(value, startIndex, 2);
            return buf.GetShort();
        }

        public static int ToInt32(byte[] value, int startIndex)
        {
            var buf = GetReversedBuffer(value, startIndex, 4);
            return buf.GetInt();
        }

        public static long ToInt64(byte[] value, int startIndex)
        {
            var buf = GetReversedBuffer(value, startIndex, 8);
            return buf.GetLong();
        }

        public static ushort ToUInt16(byte[] value, int startIndex)
        {
            return (ushort)(((int) ToInt16(value, startIndex)) & 0xFFFF);
        }

        public static uint ToUInt32(byte[] value, int startIndex)
        {
            return (uint)(((long)ToInt32(value, startIndex)) & 0xFFFFFFFF);
        }

        public static ulong ToUInt64(byte[] value, int startIndex)
        {
            return (ulong)(ToInt64(value, startIndex));
        }

        public static double ToDouble(byte[] value, int startIndex)
        {
            var buf = GetReversedBuffer(value, startIndex, 8);
            return buf.GetDouble();
        }

        public static float ToSingle(byte[] value, int startIndex)
        {
            var buf = GetReversedBuffer(value, startIndex, 4);
            return buf.GetFloat();
        }

        /// <summary>
        /// Convert the numeric value of each array element to a hex string divided by '-'.
        /// </summary>
        public static string ToString(byte[] value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            return ToString(value, 0, value.Length);
        }

        /// <summary>
        /// Convert the numeric value of each array element to a hex string divided by '-'.
        /// </summary>
        public static string ToString(byte[] value, int startIndex)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            return ToString(value, startIndex, value.Length - startIndex);
        }

        /// <summary>
        /// Convert the numeric value of each array element to a hex string divided by '-'.
        /// </summary>
        public static string ToString(byte[] value, int startIndex, int length)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            if ((startIndex < 0) || (startIndex >= value.Length))
                throw new ArgumentOutOfRangeException("index");
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            if (startIndex + length > value.Length)
                throw new ArgumentException("length");
            var buffer = new StringBuffer();
            for (var i = 0; i < length; i++)
            {
                if (i > 0)
                    buffer.Append('-');
                var hex = int.ToHexString((int) value[startIndex + i]).ToUpper();
                if (hex.Length == 1)
                    buffer.Append('0');
                buffer.Append(hex);
            }
            return buffer.ToString();
        }
    }
}

