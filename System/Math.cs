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
using Java.Math;
using Java.Text;

namespace System
{
    partial class Math
    {
        [Inline]
        public static sbyte Abs(sbyte value)
        {
            if (value == sbyte.MinValue)
                throw new OverflowException();
            return (value < 0 ? (sbyte)-value : value);
        }

        [Inline]
        public static short Abs(short value)
        {
            if (value == short.MinValue)
                throw new OverflowException();
            return (value < 0 ? (short)-value : value);
        }

        [Inline]
        public static int Abs(int value)
        {
            if (value == int.MinValue)
                throw new OverflowException();
            return (value < 0 ? -value : value);
        }

        //[Inline]
        public static long Abs(long value)
        {
            if (value == long.MinValue)
                throw new OverflowException();
            return (value < 0 ? -value : value);
        }

        [Inline]
        public static decimal Abs(decimal value)
        {
            return value.Abs();
        }

        [Inline]
        public static double Abs(double value)
        {
            return JavaAbs(value);
        }

        [Inline]
        public static float Abs(float value)
        {
            // not sure why this is required, but it makes monos math test happy.
            if (value == float.MinValue) 
                return float.MaxValue;

            return JavaAbs(value);
        }

        [Inline]
        public static decimal Ceiling(decimal value)
        {
            return decimal.Ceiling(value);
        }

        public static decimal Max(decimal a, decimal b)
        {
            return a > b ? a : b;
        }

        [CLSCompliant(false)]
        public static uint Max(uint val1, uint val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        [CLSCompliant(false)]
        public static ulong Max(ulong val1, ulong val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        [Inline]
        public static byte Max(byte val1, byte val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        [Inline]
        public static decimal Min(decimal a, decimal b)
        {
            return a < b ? a : b;
        }

        [CLSCompliant(false)]
        public static uint Min(uint val1, uint val2)
        {
            return val1 < val2 ? val1 : val2;
        }

        [CLSCompliant(false)]
        public static ulong Min(ulong val1, ulong val2)
        {
            return val1 < val2 ? val1 : val2;
        }

        public static byte Min(byte val1, byte val2)
        {
            return val1 < val2 ? val1 : val2;
        }
        
        [Inline]
        public static decimal Round(decimal value)
        {
            return Decimal.Round(value);
        }

        [Inline]
        public static decimal Round(decimal value, int decimals)
        {
            return Decimal.Round(value, decimals);
        }

        [Inline]
        public static decimal Round(decimal value, MidpointRounding midpointRounding)
        {
            return Decimal.Round(value, midpointRounding);
        }

        [Inline]
        public static decimal Round(decimal value, int decimals, MidpointRounding midpointRounding)
        {
            return Decimal.Round(value, decimals, midpointRounding);
        }

        [Inline]
	    public static double Round(double value, MidpointRounding midpointRounding)
	    {
	        return Round(value, 0, midpointRounding);
	    }

        [Inline]
        public static double Round(double value, int digits)
        {
            return Round(value, digits, MidpointRounding.ToEven);
        }

        [Inline]
        public static double Round(double value)
        {
            return Round(value, 0, MidpointRounding.ToEven);
        }

        public static double Round(double value, int decimals, MidpointRounding midpointRounding)
	    {
	        if (decimals < 0 && decimals > 17)
	            throw new ArgumentException();

            // ReSharper disable once EqualExpressionComparison
            if (value != value /* double.IsNaN(value): not a typo: avoids a method call overhead */ 
                || value == 0 
                || value == Double.MaxValue 
                || value == Double.MinValue 
                || double.IsInfinity(value))
	            return value;
            
	        if (decimals == 0)
	        {
                if (midpointRounding == MidpointRounding.AwayFromZero)
                {
                    return value < 0 ? Ceiling(value - 0.5) : Floor(value + 0.5);    
                }

                return Rint(value);
	        }

            // take the jump seat if nothing to do.
            var floor = Math.Floor(value);
            if (floor == value)
                return value;

            double round = TryRoundDoubleQuick(value, decimals, midpointRounding);

	        if (!double.IsNaN(round))
	        {
	            return round;
	        }
	        
	        // Use the fallback for corner cases.
            return SlowAndPainfulRoundDoubleFallback(value, decimals, midpointRounding);
	    }

        private const double RoundSafetyFactor = 2d;
        private static double[] RoundPower10Double;

	    private static double TryRoundDoubleQuick(double value, int decimals, MidpointRounding midpointRounding)
	    {
            // Try a fast round based on ideas from: http://www.coderanch.com/t/582520/java/java/fast-method.

            // The problem is that when we multiply by a power of ten we might - due to inherent double
            // inaccuaracy - end up with a value that rounds differently to what we expect.
            // Therefore we round two values just slighly larger/smaller that the value
            // we try to round. If the results are equal, we're done. If they are not, 
            // we fail with double.NaN.

	        if (RoundPower10Double == null) // can't use static initializer in a framework extension class.
	            RoundPower10Double = new[] {1E0, 1E1, 1E2, 1E3, 1E4, 1E5, 1E6, 1E7, 1E8, 1E9, 1E10, 1E11, 1E12, 1E13, 1E14, 1E15};

	        var factor = RoundPower10Double[decimals];
	        double y = value*factor;
	        var threshold = Math.Ulp(y) * RoundSafetyFactor;

	        double d1, d2;

	        if (midpointRounding == MidpointRounding.AwayFromZero)
	        {
	            if (y < 0)
	            {
	                y -= 0.5;
	                d1 = Math.Ceiling(y + threshold);
	                d2 = Math.Ceiling(y - threshold);
	            }
	            else
	            {
	                y += 0.5;
	                d1 = Math.Floor(y + threshold);
	                d2 = Math.Floor(y - threshold);
	            }
	        }
	        else
	        {
	            d1 = Math.Rint(y + threshold);
	            d2 = Math.Rint(y - threshold);
	        }

	        if (d1 == d2)
	        {
	            return d1/factor;
	        }
	        
            return double.NaN;
	    }

#if ANDROID_10P // NOT using BigDecimal, because BigDecimal is a BigPerformanceKiller.
	    private static DecimalFormat[] RoundDoubleDecimalFormatsCeiling;
        private static DecimalFormat[] RoundDoubleDecimalFormatsEven;
	    
        private static double SlowAndPainfulRoundDoubleFallback(double value, int decimals, MidpointRounding midpointRounding)
	    {
	        DecimalFormat df;
	        if (midpointRounding == MidpointRounding.AwayFromZero)
	        {
                // can't use static initializer in a framework extension class.
                if (RoundDoubleDecimalFormatsCeiling == null) RoundDoubleDecimalFormatsCeiling = new DecimalFormat[17];
	            df = RoundDoubleDecimalFormatsCeiling[decimals];
	            if (df == null)
	            {
	                df = decimals == 0 ? new DecimalFormat("#") : new DecimalFormat("#." + new string('#', decimals));
	                df.RoundingMode = RoundingMode.HALF_UP;
	                RoundDoubleDecimalFormatsCeiling[decimals] = df;
	            }
	        }
	        else
	        {
                // can't use static initializer in a framework extension class.
                if(RoundDoubleDecimalFormatsEven == null) RoundDoubleDecimalFormatsEven = new DecimalFormat[17];
	            df = RoundDoubleDecimalFormatsEven[decimals];
	            if (df == null)
	            {
	                df = decimals == 0 ? new DecimalFormat("#") : new DecimalFormat("#." + new string('#', decimals));
	                df.RoundingMode = RoundingMode.HALF_EVEN;
	                RoundDoubleDecimalFormatsEven[decimals] = df;
	            }
	        }

	        return df.Parse(df.Format(value)).DoubleValue();
	    }
#else   // TODO: I believe this might not 100% the .NET equivalent. Check with MathTest_Mono.cs again.
        public static double SlowAndPainfulRoundDoubleFallback(double value, int decimals, MidpointRounding midpointRounding)
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

            var bigDecimal = new Java.Math.BigDecimal(value); // <-- this line might be problematic, as rounding errors may occur when not using the string constructor.
            bigDecimal = bigDecimal.SetScale(decimals, roundingMode);

            return bigDecimal.DoubleValue();
        }
#endif

        /// <summary>
        ///  <para>Returns the closest double approximation of the result of raising <c>x </c> to the power of <c>y </c> . </para> <para>Special cases:  <ul> <li> <para> <c>pow((anything), +0.0) = 1.0 </c>  </para></li> <li> <para> <c>pow((anything), -0.0) = 1.0 </c>  </para></li> <li> <para> <c>pow(x, 1.0) = x </c>  </para></li> <li> <para> <c>pow((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>pow(NaN, (anything except 0)) = NaN </c>  </para></li> <li> <para> <c>pow(+/-(|x| &gt; 1), +infinity) = +infinity </c>  </para></li> <li> <para> <c>pow(+/-(|x| &gt; 1), -infinity) = +0.0 </c>  </para></li> <li> <para> <c>pow(+/-(|x| &lt; 1), +infinity) = +0.0 </c>  </para></li> <li> <para> <c>pow(+/-(|x| &lt; 1), -infinity) = +infinity </c>  </para></li> <li> <para> <c>pow(+/-1.0 , +infinity) = NaN </c>  </para></li> <li> <para> <c>pow(+/-1.0 , -infinity) = NaN </c>  </para></li> <li> <para> <c>pow(+0.0, (+anything except 0, NaN)) = +0.0 </c>  </para></li> <li> <para> <c>pow(-0.0, (+anything except 0, NaN, odd integer)) = +0.0 </c>  </para></li> <li> <para> <c>pow(+0.0, (-anything except 0, NaN)) = +infinity </c>  </para></li> <li> <para> <c>pow(-0.0, (-anything except 0, NAN, odd integer)) </c> <c>= </c>  <c>+infinity </c>  </para></li> <li> <para> <c>pow(-0.0, (odd integer)) = -pow( +0 , (odd integer) ) </c>  </para></li> <li> <para> <c>pow(+infinity, (+anything except 0, NaN)) = +infinity </c>  </para></li> <li> <para> <c>pow(+infinity, (-anything except 0, NaN)) = +0.0 </c>  </para></li> <li> <para> <c>pow(-infinity, (anything)) = -pow(0, (-anything)) </c>  </para></li> <li> <para> <c>pow((-anything), (integer)) </c> <c>= </c> <c>pow(-1,(integer))*pow(+anything,integer)  </c>  </para></li> <li> <para> <c>pow((-anything except 0 and inf), (non-integer)) = NAN </c>  </para></li></ul></para> <para></para>        
        /// </summary>
        /// <returns>
        ///  <para> <c>x </c> to the power of <c>y </c> . </para>
        /// </returns>
        /// <java-name>
        /// pow
        /// </java-name>
        [DexImport("pow", "(DD)D", AccessFlags = 265, IgnoreFromJava = true)]
        public static double Pow(double x, double y) 
        {
            // TODO: make compatible with .NET semantics for the corner cases (infinitiy et al.)
            return default(double);
        }

	    public static double Truncate(double value)
	    {
	        return value < 0 ? Ceiling(value) : Floor(value);
	    }

	    [Inline]
        public static decimal Truncate(decimal value)
        {
            return decimal.Truncate(value);
        }

        public static double Log(double a, double newBase)
        {
            if (a == double.NegativeInfinity || newBase == double.NegativeInfinity)
                return double.NaN;

            if (newBase == E) return Log(a);
            if (newBase == 10) return Log10(a);
            
            var logNewBase = Log(newBase);
            
            if (logNewBase == 0)
                return double.NaN;

            return Log(a)/logNewBase;
        }

        [Inline]
        public static int Sign(double value)
        {
            return (int) Signum(value);
        }

        [Inline]
        public static int Sign(decimal value)
        {
            return value.Sign();
        }

        public static int Sign(int value)
        {
            return value == 0 ? 0 : value < 0 ? -1 : 1;
        }

        public static int Sign(long value)
        {
            // This could be implemeted as a dex-native call
            return value == 0 ? 0 : value < 0 ? -1 : 1;
        }


    }
}

