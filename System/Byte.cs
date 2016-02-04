// Copyright (C) 2014 dot42
//
// Original filename: Byte.cs
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
using System.ComponentModel;
using System.Globalization;
using Dot42;
using Dot42.Internal;

namespace System
{
    /// <summary>
    /// Unsigned 8-bit integer.
    /// </summary>
    [DexImport("java/lang/Byte", IgnoreFromJava = true, Priority = 1)]
    partial struct Byte
	{
        public const byte MaxValue = 255;
        public const byte MinValue = 0;

        /// <summary>
        /// <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>the primitive int value of this object. </para>
        /// </returns>
        /// <java-name>
        /// intValue
        /// </java-name>
        [Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int _IntValue() // Keep this name different from the same method in SByte.
        {
            return default(int);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format((int)this, provider);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format)
        {
            return NumberFormatter.Format(format, (int)this, null);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, (int)this, provider);
        }

        public static byte Parse(string s)
        {
            var value = int.Parse(s);
            if ((value < MinValue) || (value > MaxValue))
                throw new OverflowException();
            return (byte) value;
        }

        public static byte Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return Parse(s);
        }


        /// <summary>
        /// Try to parse the given string into a byte value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, out byte result)
        {
            return TryParse(s, NumberStyles.Any, null, out result);
        }

        /// <summary>
        /// Try to parse the given string into a byte value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        public int CompareTo(byte o)
        {
            return (_IntValue() & 255).CompareTo(o._IntValue() & 255);
        }

        [Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
        public bool Equals(object @object) /* MethodBuilder.Create */
        {
            return default(bool);
        }

        [Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
        public int GetHashCode() /* MethodBuilder.Create */
        {
            return default(int);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public bool Equals(byte other)
        {
            return other == this;
        }

    }
}

