// Copyright (C) 2014 dot42
//
// Original filename: UInt64.cs
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
using System.Globalization;
using Dot42;
using Dot42.Internal;
using Java.Lang;

namespace System
{
    [DexImport("java/lang/Long", IgnoreFromJava = true, Priority = 1)]
    partial struct UInt64: IFormattable
	{
	    public const ulong MaxValue = 0xFFFFFFFFFFFFFFFF;
        public const ulong MinValue = 0;

        public static ulong Parse(string s)
        {
            var value = long.Parse(s);
            if (value < 0L) 
                throw new OverflowException();
            return (ulong) value;
        }

        public static ulong Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        public static ulong Parse(string s, NumberStyles style)
        {
            long value;

            if ((style & NumberStyles.AllowHexSpecifier) != 0)
                value = long.Parse(s, 16);
            else
                value = long.Parse(s);

            if (value < 0L)
                throw new OverflowException();

            return (ulong)value;
        }

        public static bool TryParse(string s, out ulong result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
            catch (NumberFormatException)
            {
                result = 0;
                return false;
            }
        }

        [DexImport("longValue", "()J", AccessFlags = 1)]
        internal long LongValue() /* Keep internal to avoid verify error */ 
        {
            return default(long);
        }

        public string ToString(IFormatProvider provider)
        {
            // Note: this obviously does not work for values with the highest bit set.
            return NumberFormatter.Format(LongValue(), provider);
        }

        public string ToString(string format)
        {
            // Note: this obviously does not work for values with the highest bit set.
            return NumberFormatter.Format(format, LongValue(), null);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            // Note: this obviously does not work for values with the highest bit set.
            return NumberFormatter.Format(format, LongValue(), provider);
        }

        public int CompareTo(ulong o)
        {
            return this < o ? -1
                 : this > o ? 1
                 : 0;
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
        public bool Equals(ulong other)
        {
            return other == this;
        }

    }
}

