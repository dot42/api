// Copyright (C) 2014 dot42
//
// Original filename: Random.cs
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
namespace System
{
	partial class Random
	{
        /// <summary>
        /// Initialize with given state.
        /// </summary>
        public Random(int seed) : this((long) seed)
        {            
        }

        /// <summary>
        /// Returns a nonnegative random number.
        /// </summary>
        public virtual int Next()
        {
            return Math.Abs(NextInt());
        }

        /// <summary>
        /// Returns a nonnegative random number less than the specified maximum.
        /// </summary>
        [Dot42.DexImport("nextInt", "(I)I")]
        public virtual int Next(int x)
        {
            return NextInt(x);
        }

        /// <summary>
        /// Returns a nonnegative random number less than the specified maximum.
        /// </summary>
        public virtual int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException("Min value is greater than max value.");

            // special case: a difference of one (or less) will always return the minimum
            // e.g. -1,-1 or -1,0 will always return -1
            var diff = maxValue - minValue;
            if (diff <= 1)
                return minValue;
            return Next(diff) + minValue;
        }
    }
}

