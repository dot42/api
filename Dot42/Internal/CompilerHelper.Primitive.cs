// Copyright (C) 2014 dot42
//
// Original filename: CompilerHelper.cs
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

namespace Dot42.Internal
{
    [Include]
	internal static partial class CompilerHelper
	{
        [Include]
        public static int GetHashCode(long longValue)
        {
            return (int) (longValue >> 32) ^ (int) longValue;
        }

        [Include]
        public static int GetHashCode(double doubleValue)
        {
            long longValue = Double.DoubleToLongBits(doubleValue);
            return (int)(longValue >> 32) ^ (int)longValue;
        }

        [Include]
        public static int GetHashCode(float floatValue)
        {
            return Single.FloatToIntBits(floatValue);
        }

        [Include]
        public static int GetHashCode(bool boolValue)
        {
            return boolValue ? 1231 : 1237;
        }
    }
}

