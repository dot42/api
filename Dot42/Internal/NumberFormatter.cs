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
using System.Text;
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
            // Dot42 has problems with double-inlinings, therefore we do not use string.IsNullOrEmpty
            return format == null || format.Length == 0 || (format.Length == 1 && (format[0]) == 'G' || format[0] == 'g');
        }

        internal static string Format(string format, int value, IFormatProvider provider)
        {
            bool isDefaultFormat = IsDefaultFormat(format);
            if (isDefaultFormat/* && provider == CultureInfo.InvariantCulture*/)
                return int.ToString(value);

            NumberFormat f = NetFormatStringToJavaNumberFormat(format, provider, typeof (int));
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
	        int decimalCount = -1;

	        bool isEmptyFormat = string.IsNullOrEmpty(format);

	        if (!isEmptyFormat)     decimalCount = FormatHelper.ParseDecimal(format, 1, format.Length);
            if(decimalCount == -1)  decimalCount = maxPrecision;

	        if (exp > -5 && exp < 15)
	        {
                return NumberFormatFactory.GetDecimalFormat(decimalCount, provider);
	        }
	        else
	        {
                bool isUpperCase = isEmptyFormat || format[0] != 'g';
                return NumberFormatFactory.GetScientificFormat(decimalCount, isUpperCase, provider);
	        }
	    }

	    private static NumberFormat NetFormatStringToJavaNumberFormat(string format, IFormatProvider provider, Type type)
	    {
	        if (format == null)
	            format = "G";

	        const int notSpecified = -2;
            int precision = notSpecified;

	        if (format.Length > 1)
	            precision = FormatHelper.ParseDecimal(format, 1, format.Length);

            if (format.Length >= 1)
            {
                switch (format[0])
                {
                    case 'c':
                    case 'C':
                        {
                            string javaFormat;
                            NumberFormat nf = NumberFormatFactory.GetCurrencyFormat(provider);
                            if (precision == notSpecified)
                            {
                                javaFormat = "0.00";
                            }
                            else
                            {
                                if (precision == 0)
                                    javaFormat = "0";
                                else if (precision > 0)
                                {
                                    javaFormat = "0." + new string('0', precision);
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
                    case 'd':
                    case 'D':
                        {
                            if (precision == notSpecified)
                            {
                                return NumberFormatFactory.GetDecimalFormat("0", provider);
                            }

                            if (precision >= 0)
                            {
                                var javaFormat = 0 == precision ? "0" : new string('0', precision);
                                return NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                            }
                        }
                        break;
                    case 'e':
                    case 'E':
                        {
                            if (precision == notSpecified)
                                return NumberFormatFactory.GetScientificFormat("0.000000E000", provider);

                            if (precision >= 0)
                            {
                                string javaFormat = "0." + new string('0', precision);
                                if (0 == precision)
                                    javaFormat = "0";
                                return NumberFormatFactory.GetScientificFormat(javaFormat + "E000", provider);
                            }
                        }
                        break;
                    case 'f':
                    case 'F':
                    case 'p':
                    case 'P':
                        {
                            string javaFormat;
                            if (precision == notSpecified)
                            {
                                javaFormat = "0.00";
                            }
                            else
                            {
                                if (0 == precision)
                                    javaFormat = "0";
                                else if (precision > 0)
                                {
                                    javaFormat = "0." + new string('0', precision);
                                }
                                else
                                {
                                    if (format[0] == 'P')
                                        return NumberFormatFactory.GetFormat(format + " %", provider);
                                    else
                                        return NumberFormatFactory.GetFormat(format, provider);
                                }
                            }

                            if (format[0] == 'P')
                                return NumberFormatFactory.GetDecimalFormat(javaFormat + " %", provider);

                            return NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                        }
                    case 'r':
                    case 'R':
                    {
                        return NumberFormatFactory.GetDecimalFormat("0.################################", provider);
                    }
                    case 'g':
                    case 'G':
                        return NumberFormatFactory.GetFormat(provider);
                    case 'n':
                    case 'N':
                        {
                            if (precision == notSpecified)
                                return NumberFormatFactory.GetDecimalFormat("#,##0.00", provider);
                            if (precision >= 0)
                            {
                                string javaFormat = "#,##0." + new string('0', precision);
                                if (0 == precision)
                                    javaFormat = "#,##0";
                                return NumberFormatFactory.GetDecimalFormat(javaFormat, provider);
                            }
                        }
                        break;
                    case 'x':
                    case 'X':
                        if (precision == notSpecified)
                            precision = 8;
                         return NumberFormatFactory.GetHexFormat(precision, isuppercase: format[0] == 'X');
                }
            }

	        return NumberFormatFactory.GetFormat(format, provider);
        }
    }
}

