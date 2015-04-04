// Copyright (C) 2014 dot42
//
// Original filename: Int32.cs
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
using Dot42.Internal;
using Java.Lang;

namespace System
{
    partial struct Int32: IFormattable
	{
        public int CompareTo(int value)
        {
            return CompareTo((int?)value);
        }

        public int CompareTo(object value)
        {
            if (value == null) return +1;

            if (value.JavaGetClass() != TypeHelper.IntegerType()) 
                throw new ArgumentException("value is not an Int32");

            return CompareTo((int?)value); 
        }

        public static int Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        public static int Parse(string s, NumberStyles style)
        {
            if ((style & NumberStyles.HexNumber) != 0)
                return JavaParse(s, 16);
            return Parse(s);
        }

        public static int Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            if ((style & NumberStyles.HexNumber) != 0)
                return JavaParse(s, 16);
            return Parse(s);
        }

        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format(IntValue(), provider);
        }

        public string ToString(string format)
        {
            return NumberFormatter.Format(format, IntValue(), null);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, IntValue(), provider);
        }

        /// <summary>
        /// Parse the given string into an integer value.
        /// </summary>
        public static int Parse(string s)
        {
            return JavaParse(s.Trim().TrimStart('+'));
        }

        /// <summary>
        /// Try to parse the given string into an integer value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, out int result)
        {
            return TryParse(s, NumberStyles.Any, null, out result);
        }

        /// <summary>
        /// Try to parse the given string into an integer value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result)
        {
            try
            {
                result = Parse(s, style);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        /// <summary>
        /// Get the TypeCode for this double
        /// </summary>
        public TypeCode GetTypeCode()
        {
            return TypeCode.Int32;
        }
    }
}

