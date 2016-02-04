// Copyright (C) 2014 dot42
//
// Original filename: Single.cs
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

using Dot42;
using Dot42.Internal;
using Java.Lang;

namespace System
{
	partial struct Single
	{
        public const float MinValue = -3.40282347E+38f;

        public static bool IsNegativeInfinity(float value)
	    {
	        return (value == NegativeInfinity); 
	    }

	    public static bool IsPositiveInfinity(float value)
	    {
	        return (value == PositiveInfinity); 
	    }

        public static float Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        public static bool TryParse(string s, out float result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch (NumberFormatException)
            {
                result = 0f;
                return false;
            }
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format(this, provider);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format)
        {
            return NumberFormatter.Format(format, this, null);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, this, provider);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public bool Equals(float other)
        {
            return other == this;
        }

    }
}

