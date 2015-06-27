// Copyright (C) 2014 dot42
//
// Original filename: NumberFormatter.cs
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
using System.Globalization;
using Java.Text;

namespace Dot42.Internal
{
    [IncludeType]
	internal static class NumberFormatter
	{
	    internal static string Format(int value, IFormatProvider provider)
	    {
	        return Format(null, value, provider);
	    }

	    internal static string Format(long value, IFormatProvider provider)
        {
            return Format(null, value, provider);
        }

	    internal static string Format(float value, IFormatProvider provider)
	    {
	        return Format(null, value, provider);
	    }

	    internal static string Format(double value, IFormatProvider provider)
        {
            return Format(null, value, provider);
        }

        // no sure why the renamer does not cover this case.
        internal static string FormatULong(ulong value, IFormatProvider provider) 
        {
            // TODO: this does not work with values where the highest bit is set, except fox hex
            return Format(null, (long)value, provider);
        }

        // no sure why the renamer does not cover this case.
        internal static string FormatULong(string format, ulong value, IFormatProvider provider) 
	    {
            // TODO: this does not work with values where the highest bit is set, except fox hex
            return Format(format, (long)value, provider);
	    }

        [Inline]
        private static bool IsDefaultFormat(string format)
        {
            return format == null || format.Length == 0 || (format.Length == 1 && (format[0]) == 'G' || format[0] == 'g');
        }

        internal static string Format(string format, int value, IFormatProvider provider)
        {
            bool isDefaultFormat = IsDefaultFormat(format);
            if (isDefaultFormat/* && provider == CultureInfo.InvariantCulture*/)
                return int.ToString(value);

             NumberFormat f;

            //if (isDefaultFormat)
            //{
            //    f = NumberFormatFactory.GetFormat("0", provider);
            //}
            //else
            {
                f = NetFormatStringToJavaNumberFormat(format, provider, typeof (int));
            }
                
            return f.Format((long)value);
        }

        internal static string Format(string format, long value, IFormatProvider provider)
        {
            bool isDefaultFormat = IsDefaultFormat(format);
            if (isDefaultFormat/* && provider == CultureInfo.InvariantCulture*/) 
                return long.ToString(value);

            NumberFormat f;

            //if (isDefaultFormat)
            //{
            //    f = NumberFormatFactory.GetFormat("0", provider);
            //}
            //else
            {
                f = NetFormatStringToJavaNumberFormat(format, provider, typeof (long));
            }
                
            return f.Format(value);
        }

        internal static string Format(string format, float value, IFormatProvider provider)
        {
            NumberFormat f;

            bool isDefaultFormat = IsDefaultFormat(format);
            //if (isDefaultFormat && provider == CultureInfo.InvariantCulture) // can't use the fast path, see below
            //    return float.ToString(value);

            var dbl = (double)value;

            if (isDefaultFormat)
            {
#if ANDROID_10P
                f = Net_G_FormatStringToJavaNumberFormat(format, provider, Math.GetExponent(value), 7);
#else
                f = NetFormatStringToJavaNumberFormat(format, provider, typeof(float));
#endif
            }
            else if (format.StartsWith("R") || format.StartsWith("r"))
            {
#if ANDROID_10P
                f = Net_G_FormatStringToJavaNumberFormat(format, provider, Math.GetExponent(value), 7);
                var tmp = f.Format((double)value);
                if (f.Parse(tmp).FloatValue() == value)
                    return tmp;
                f = Net_G_FormatStringToJavaNumberFormat(format, provider, Math.GetExponent(value), 9);
#else
                f = NumberFormatFactory.GetScientificFormat("0.#######", provider);
                var tmp = f.Format(value);
                if (f.Parse(tmp).FloatValue() == value)
                    return tmp;
                f = NumberFormatFactory.GetScientificFormat("0.#########", provider);
#endif
            }
            else
            {
                f = NetFormatStringToJavaNumberFormat(format, provider, typeof (float));
            }
            return f.Format(dbl);
        }

        internal static string Format(string format, double value, IFormatProvider provider)
        {
            bool isDefaultFormat = IsDefaultFormat(format);
            //if (isDefaultFormat && provider == CultureInfo.InvariantCulture) // can't use the fast path, see below
            //    return float.ToString(value);

            NumberFormat f;

            if (isDefaultFormat)
            {
#if ANDROID_10P
                f = Net_G_FormatStringToJavaNumberFormat(format, provider, Math.GetExponent(value), 15);
#else
                f = NetFormatStringToJavaNumberFormat(format, provider, typeof(double));
#endif
            }
            else if (format.StartsWith("R") || format.StartsWith("r"))
            {
#if ANDROID_10P
                f = Net_G_FormatStringToJavaNumberFormat(format, provider, Math.GetExponent(value), 15);
                var tmp = f.Format(value);
                if (f.Parse(tmp).DoubleValue() == value)
                    return tmp;
                f = Net_G_FormatStringToJavaNumberFormat(format, provider, Math.GetExponent(value), 17);
#else
                f = NumberFormatFactory.GetScientificFormat("0.###############", provider);
                var tmp = f.Format(value);
                if (f.Parse(tmp).DoubleValue() == value)
                    return tmp;
                f = NumberFormatFactory.GetScientificFormat("0.#################", provider);
#endif
            }
            else
            {
                f = NetFormatStringToJavaNumberFormat(format, provider, typeof (double));
            }
            return f.Format(value);
        }

	    private static NumberFormat Net_G_FormatStringToJavaNumberFormat(string format, IFormatProvider provider, int exp, int maxPrecision)
	    {
	        int decimalCount;

	        if (format == null || !int.TryParse(format.JavaSubstring(1), out decimalCount))
	            decimalCount = maxPrecision;

	        bool isLowerCase = format != null && format[0] == 'g';

	        if (exp > -5 && exp < 15)
	        {
	            if (decimalCount == 0)
	                return NumberFormatFactory.GetDecimalFormat("0", provider);
                if (decimalCount == 7)
                    return NumberFormatFactory.GetDecimalFormat("0.#######", provider);
                if (decimalCount == 9)
                    return NumberFormatFactory.GetDecimalFormat("0.#########", provider);
                if (decimalCount == 15)
                    return NumberFormatFactory.GetDecimalFormat("0.###############", provider);
                if (decimalCount == 17)
                    return NumberFormatFactory.GetDecimalFormat("0.#################", provider);
                return NumberFormatFactory.GetDecimalFormat("0." + new string('#', decimalCount), provider);
	        }
            
            if (decimalCount == 0)
                return NumberFormatFactory.GetScientificFormat(isLowerCase ? "0e0" : "0E0", provider);
            if (decimalCount == 7)
                return NumberFormatFactory.GetScientificFormat(isLowerCase ? "0.#######e0" : "0.#######E0", provider);
            if (decimalCount == 15)
                return NumberFormatFactory.GetScientificFormat(isLowerCase ? "0.###############e0" : "0.###############E0", provider);

            return NumberFormatFactory.GetScientificFormat("0." + new string('#', decimalCount) + (isLowerCase ? "e0" : "E0"), provider);
	    }

	    private static NumberFormat NetFormatStringToJavaNumberFormat(string format, IFormatProvider provider, Type type)
	    {
	        if (format == null)
	            format = "G";

            if (format.Length >= 1)
            {
                switch (char.ToUpper(format[0]))
                {
                    case 'C':
                        {
                            string javaFormat;
                            NumberFormat nf = NumberFormatFactory.GetCurrencyFormat(provider);
                            if (format.Length == 1)
                            {
                                javaFormat = "0.00";
                            }
                            else
                            {
                                int decimalCount;
                                if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                                {
                                    javaFormat = "0." + new string('0', decimalCount);
                                    if (0 == decimalCount)
                                        javaFormat = "0";
                                }
                                else
                                {
                                    javaFormat = format;
                                }
                            }

                            if (nf.IsGroupingUsed)
                                javaFormat = "#,##" + javaFormat;

                            javaFormat = nf.Currency.Symbol + javaFormat;

                            var f = NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                            //DecimalFormat f = (DecimalFormat)NumberFormat.GetNumberInstance(locale);
                            //f.ApplyPattern(javaFormat);
                            return f;
                        }
                    case 'D':
                        {
                            if (format.Length == 1)
                            {
                                return NumberFormatFactory.GetDecimalFormat("0", provider);
                            }
                            
                            int decimalCount;
                            if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                            {
                                var javaFormat = 0 == decimalCount ? "0" : new string('0', decimalCount);
                                return NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                            }
                        }
                        break;
                    case 'E':
                        {
                            if (format.Length == 1)
                                return NumberFormatFactory.GetScientificFormat("0.000000E000", provider);
                            int decimalCount;
                            if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                            {
                                string javaFormat = "0." + new string('0', decimalCount);
                                if (0 == decimalCount)
                                    javaFormat = "0";
                                return NumberFormatFactory.GetScientificFormat(javaFormat + "E000", provider);
                            }
                        }
                        break;
                    case 'F':
                    case 'P':
                        {
                            string javaFormat;
                            if (format.Length == 1)
                            {
                                javaFormat = "0.00";
                            }
                            else
                            {
                                int decimalCount;
                                if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                                {
                                    javaFormat = "0." + new string('0', decimalCount);
                                    if (0 == decimalCount)
                                        javaFormat = "0";
                                }
                                else
                                {
                                    if ('P' == char.ToUpper(format[0]))
                                        return NumberFormatFactory.GetFormat(format + " %", provider);
                                    else
                                        return NumberFormatFactory.GetFormat(format, provider);
                                }
                            }

                            if ('P' == char.ToUpper(format[0]))
                                return NumberFormatFactory.GetDecimalFormat(javaFormat + " %", provider);

                            return NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                        }

                    case 'R':
                    {
                        return NumberFormatFactory.GetDecimalFormat("0.################################", provider);
                    }
                    case 'G':
                    case 'g':
                        return NumberFormatFactory.GetFormat(provider);
                    case 'N':
                        {
                            if (format.Length == 1)
                                return NumberFormatFactory.GetDecimalFormat("#,##0.00", provider);
                            int decimalCount;
                            if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                            {
                                string javaFormat = "#,##0." + new string('0', decimalCount);
                                if (0 == decimalCount)
                                    javaFormat = "#,##0";
                                return NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                            }
                        }
                        break;
                    case 'X':
                        if (format.Length == 1)
                            return NumberFormatFactory.GetHexFormat(8, char.IsUpper(format[0]));
                        
                            int numDigits;
                        if (int.TryParse(format.JavaSubstring(1), out numDigits))
                            return NumberFormatFactory.GetHexFormat(numDigits, char.IsUpper(format[0]));
                        break;
                }
            }

            return NumberFormatFactory.GetFormat(format, provider);
        }
    }
}

