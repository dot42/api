// Copyright (C) 2014 dot42
//
// Original filename: Math.cs
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

namespace System
{
	partial class Math
	{
        public static decimal Abs(decimal value)
        {
            if (value < 0) decimal.Negate(value);
            return value;
        }

        public static decimal Ceiling(decimal value)
        {
            // TODO
            return value;
        }

        public static decimal Max(decimal a, decimal b)
        {
            return a > b ? a : b;
        }

        [CLSCompliantAttribute(false)]
        public static uint Max(uint val1, uint val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        public static byte Max(byte val1, byte val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        public static decimal Min(decimal a, decimal b)
        {
            return a < b ? a : b;
        }

        [CLSCompliantAttribute(false)]
        public static uint Min(uint val1, uint val2)
        {
            return val1 < val2 ? val1 : val2;
        }

        public static byte Min(byte val1, byte val2)
        {
            return val1 < val2 ? val1 : val2;
        }

        public static decimal Round(decimal value)
        {
            throw new NotImplementedException("System.Math.Round");
        }

        public static decimal Round(decimal value, MidpointRounding midpointRounding)
        {
            throw new NotImplementedException("System.Math.Round");
        }

	    public static double Round(double value, MidpointRounding midpointRounding)
	    {
	        return Round(value, 0, midpointRounding);
	    }

        public static double Round(double value, int digits)
        {
            return Round(value, digits, MidpointRounding.ToEven);
        }

	    public static double Round(double value, int decimals, MidpointRounding midpointRounding)
        {
            var roundingMode = Java.Math.RoundingMode.UNNECESSARY;
            switch (midpointRounding)
            {
                case MidpointRounding.AwayFromZero:
                    roundingMode = Java.Math.RoundingMode.HALF_UP;
                    break;

                case MidpointRounding.ToEven:
                    roundingMode = Java.Math.RoundingMode.HALF_EVEN;
                    break;
            }

            var bigDecimal = new Java.Math.BigDecimal(value);
            bigDecimal = bigDecimal.SetScale(decimals, roundingMode);

            return bigDecimal.DoubleValue();
        }

        public static double Log(double a, double newBase)
        {
            if (newBase == E) return Log(a);
            if (newBase == 10) return Log10(a);

            throw new NotImplementedException("System.Math.Log");
        }

        [Inline]
        public static int Sign(double value)
        {
            return (int) Signum(value);
        }


    }
}

