// Copyright (C) 2014 dot42
//
// Original filename: Double.cs
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

namespace System
{
	partial struct Double
	{
        public const double MinValue = -1.7976931348623157E+308;

        public static bool IsNegativeInfinity(double value)
        {
            return (value == NegativeInfinity);
        }

        public static bool IsPositiveInfinity(double value)
        {
            return (value == PositiveInfinity);
        }

        public int CompareTo(double value)
        {
            if(IsNaN())  
            {
                return value.IsNaN()? 0: -1;
            }

            if (value.IsNaN()) return 1;

            return CompareTo((double?)value);
        }

        public int CompareTo(object value)
        {
            if (value == null) return +1;
            if(!(value is double)) throw new ArgumentException("value is not a double");

            return CompareTo((double)value);
        }

	    /// <summary>
	    /// Try to parse the given string into a double value.
	    /// </summary>
	    /// <returns>True on success, false otherwise</returns>
	    public static bool TryParse(string s, out double result)
	    {
	        return TryParse(s, NumberStyles.Any, null, out result);
	    }

	    /// <summary>
        /// Try to parse the given string into a double value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
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

        /// <summary>
        /// Parses this provided string into a double
        /// </summary>
        /// <returns></returns>
        public static double Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format(DoubleValue(), provider);
        }

        public string ToString(string format)
        {
            return NumberFormatter.Format(format, DoubleValue(), null);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, DoubleValue(), provider);
        }

        /// <summary>
        /// Get the TypeCode for this double
        /// </summary>
        public TypeCode GetTypeCode()
        {
            return TypeCode.Double;
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public bool Equals(double other)
        {
            return other == this;
        }
    }
}

