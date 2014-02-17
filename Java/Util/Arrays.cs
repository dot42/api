// Copyright (C) 2014 dot42
//
// Original filename: Arrays.cs
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
using System;
using Java.Lang;

namespace Java.Util
{
    partial class Arrays
	{
        public static int BinarySearch(bool[] array, bool value)
        {
            var len = array.Length;
            for (var i = 0; i < len; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        /// <java-name>
        /// fill
        /// </java-name>
        [Dot42.DexImport("fill", "([SS)V", AccessFlags = 9)]
        public static void Fill(ushort[] array, ushort value)
        {
        }

        /// <java-name>
        /// fill
        /// </java-name>
        [Dot42.DexImport("fill", "([SIIS)V", AccessFlags = 9)]
        public static void Fill(ushort[] array, int start, int end, ushort value)
        {
        }

        /// <java-name>
        /// fill
        /// </java-name>
        [Dot42.DexImport("fill", "([II)V", AccessFlags = 9)]
        public static void Fill(uint[] array, uint value)
        {
        }

        /// <java-name>
        /// fill
        /// </java-name>
        [Dot42.DexImport("fill", "([IIII)V", AccessFlags = 9)]
        public static void Fill(uint[] array, int start, int end, uint value)
        {
        }

        /// <java-name>
        /// fill
        /// </java-name>
        [Dot42.DexImport("fill", "([JJ)V", AccessFlags = 9)]
        public static void Fill(ulong[] array, ulong value)
        {
        }

        /// <java-name>
        /// fill
        /// </java-name>
        [Dot42.DexImport("fill", "([JIIJ)V", AccessFlags = 9)]
        public static void Fill(ulong[] array, int start, int end, ulong int641)
        {
        }

#if !ANDROID_9P
        /// <summary>
        /// Copies newLength elements from original into a new array. 
        /// If newLength is greater than original.length, the result is padded with the value '\\u0000'.
        /// </summary>
        internal static T[] CopyOf<T>(T[] original, int newLength)
        {
            if (original == null) throw new ArgumentNullException("Original may not be null");
            if (newLength < 0) throw new NegativeArraySizeException();

            var minLength = newLength;

            var result = new T[newLength];
            if (newLength > original.Length)
            {
                for (int i = original.Length; i < newLength; i++)
                {
                    result[i] = default(T);
                }
                minLength = original.Length;
            }

            for (var i = 0; i < minLength; i++)
            {
                result[i] = original[i];
            }

            return result;
        }

        /// <summary>
        /// Copies newLength elements from original into a new array. 
        /// If newLength is greater than original.length, the result is padded with the value '\\u0000'.
        /// </summary>
        internal static char[] CopyOf(char[] original, int newLength)
        {
            if(original == null) throw new ArgumentNullException("Original may not be null");
            if (newLength < 0) throw new NegativeArraySizeException();

            var minLength = newLength;

            var result = new char[newLength];
            if (newLength > original.Length)
            {
                Fill(result, original.Length, newLength, '\u0000');
                minLength = original.Length;
            }

            for (var i = 0; i < minLength; i++)
            {
                result[i] = original[i];
            }

            return result;
        }

        /// <summary>
        /// Copies newLength elements from original into a new array. 
        /// If newLength is greater than original.length, the result is padded with the value (byte)0.
        /// </summary>
        internal static byte[] CopyOf(byte[] original, int newLength)
        {
            if (original == null) throw new ArgumentNullException("Original may not be null");
            if (newLength < 0) throw new NegativeArraySizeException();

            var minLength = newLength;

            var result = new byte[newLength];
            if (newLength > original.Length)
            {
                Fill(result, original.Length, newLength, 0);
                minLength = original.Length;
            }

            for (var i = 0; i < minLength; i++)
            {
                result[i] = original[i];
            }

            return result;
        }
#endif

	}
}

