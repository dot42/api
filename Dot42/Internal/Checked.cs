// Copyright (C) 2014 dot42
//
// Original filename: Checked.cs
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
    /// <summary>
    /// Arithmetic operations with overflow check
    /// </summary>
	internal static class Checked
	{
        /// <summary>
        /// Add with overflow check
        /// </summary>
        public static int Add(int a, int b)
        {
            var result = a + b;
            if ((a > 0) && (b > 0))
            {
                if (result < 0)
                    throw new OverflowException();
            }
            else if ((a < 0) && (b < 0))
            {
                if (result > 0)
                    throw new OverflowException();
            }
            return result;
        }

        /// <summary>
        /// Add with overflow check
        /// </summary>
        public static long Add(long a, long b)
        {
            var result = a + b;
            if ((a > 0) && (b > 0))
            {
                if (result < 0)
                    throw new OverflowException();
            }
            else if ((a < 0) && (b < 0))
            {
                if (result > 0)
                    throw new OverflowException();
            }
            return result;
        }

        /// <summary>
        /// Multiply with overflow check
        /// </summary>
        public static int Mul(int a, int b)
        {
            if ((a == 0) || (b == 0)) return 0;
            var result = a * b;
            if ((a > 0) && (b > 0)) 
            {
                // P * P is positive
                if ((result < 0) || (result < a) || (result < b))
                    throw new OverflowException();
            }
            else if ((a < 0) && (b < 0))
            {
                // N * N is positive
                if ((result < 0) || (result < -a) || (result < -b))
                    throw new OverflowException();
            }
            else if ((a < 0) && (b > 0))
            {
                // N * P is negative
                if ((result > 0) || (result > a) || (result > -b))
                    throw new OverflowException();
            }
            else if ((a > 0) && (b < 0))
            {
                // P * N is negative
                if ((result > 0) || (result > b) || (result < -a))
                    throw new OverflowException();
            }
            return result;
        }

        /// <summary>
        /// Multiply with overflow check
        /// </summary>
        public static long Mul(long a, long b)
        {
            if ((a == 0) || (b == 0)) return 0L;
            var result = a * b;
            if ((a > 0) && (b > 0))
            {
                // P * P is positive
                if ((result < 0) || (result < a) || (result < b))
                    throw new OverflowException();
            }
            else if ((a < 0) && (b < 0))
            {
                // N * N is positive
                if ((result < 0) || (result < -a) || (result < -b))
                    throw new OverflowException();
            }
            else if ((a < 0) && (b > 0))
            {
                // N * P is negative
                if ((result > 0) || (result > a) || (result > -b))
                    throw new OverflowException();
            }
            else if ((a > 0) && (b < 0))
            {
                // P * N is negative
                if ((result > 0) || (result > b) || (result < -a))
                    throw new OverflowException();
            }
            return result;
        }

        /// <summary>
        /// Substract with overflow check
        /// </summary>
        public static int Sub(int a, int b)
        {
            var result = a - b;
            if ((a < 0) && (b > 0))
            {
                // N - P is always negative
                if (result > 0)
                    throw new OverflowException();
            }
            else if ((a > 0) && (b < 0))
            {
                // P - N is always positive
                if (result < 0)
                    throw new OverflowException();
            }
            return result;
        }

        /// <summary>
        /// Substract with overflow check
        /// </summary>
        public static long Sub(long a, long b)
        {
            var result = a - b;
            if ((a < 0) && (b > 0))
            {
                // N - P is always negative
                if (result > 0)
                    throw new OverflowException();
            }
            else if ((a > 0) && (b < 0))
            {
                // P - N is always positive
                if (result < 0)
                    throw new OverflowException();
            }
            return result;
        }
    }
}

