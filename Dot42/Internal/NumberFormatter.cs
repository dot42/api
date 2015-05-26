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
using Java.Lang;
using Java.Text;
using System.Globalization;


namespace Dot42.Internal
{
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

        internal static string Format(string format, int value, IFormatProvider provider)
        {
            if (null == format || format == "G" || format == "g")
                return GetDecimalFormat("0", provider).Format((long)value);
            return GetFormat(format, provider, typeof(int)).Format((long)value);
        }

        internal static string Format(string format, long value, IFormatProvider provider)
        {
            if (null == format || format == "G" || format == "g")
                return GetDecimalFormat("0", provider).Format(value);
            return GetFormat(format, provider, typeof(long)).Format(value);
        }

        internal static string Format(string format, float value, IFormatProvider provider)
        {
            NumberFormat f;

            var dbl = (double)value;

            if (format == null || format.StartsWith("G") || format.StartsWith("g"))
            {
#if ANDROID_10P
                f = GetGFormat(format, provider, Math.GetExponent(value), 7);
#else
                f = GetFormat(format, provider, typeof(float));
#endif
            }
            else if (format.StartsWith("R") || format.StartsWith("r"))
            {
#if ANDROID_10P
                f = GetGFormat(format, provider, Math.GetExponent(value), 7);
                var tmp = f.Format((double)value);
                if (f.Parse(tmp).FloatValue() == value)
                    return tmp;
                f = GetGFormat(format, provider, Math.GetExponent(value), 9);
#else
                var locale = provider.ToLocale();
                f = new ScientificFormat("0.#######", locale);
                var tmp = f.Format((float)value);
                if (f.Parse(tmp).FloatValue() == value)
                    return tmp;
                f = new ScientificFormat("0.#########", locale); 
#endif
            }
            else
            {
                f = GetFormat(format, provider, typeof (float));
            }
            return f.Format(dbl);
        }

        internal static string Format(string format, double value, IFormatProvider provider)
        {
            NumberFormat f;

            if (format == null || format.StartsWith("G") || format.StartsWith("g"))
            {
#if ANDROID_10P
                f = GetGFormat(format, provider, Math.GetExponent(value), 15);
#else
                f = GetFormat(format, provider, typeof(float));
#endif
            }
            else if (format.StartsWith("R") || format.StartsWith("r"))
            {
#if ANDROID_10P
                f = GetGFormat(format, provider, Math.GetExponent(value), 15);
                var tmp = f.Format(value);
                if (f.Parse(tmp).DoubleValue() == value)
                    return tmp;
                f = GetGFormat(format, provider, Math.GetExponent(value), 17);
#else
                var locale = provider.ToLocale();
                f = new ScientificFormat("0.###############", locale);
                var tmp = f.Format(value);
                if (f.Parse(tmp).DoubleValue() == value)
                    return tmp;
                f = new ScientificFormat("0.#################", locale); 
#endif
            }
            else
            {
                f = GetFormat(format, provider, typeof (double));
            }
            return f.Format(value);
        }

	    private static NumberFormat GetGFormat(string format, IFormatProvider provider, int exp, int maxPrecision)
	    {
	        int decimalCount;
	        if (format == null || !int.TryParse(format.JavaSubstring(1), out decimalCount))
	            decimalCount = maxPrecision;

	        bool isLowerCase = format != null && format[0] == 'g';

	        if (exp > -5 && exp < 15)
	        {
	            if (decimalCount == 0)
	                return GetDecimalFormat("0", provider);
                if (decimalCount == 7)
                    return GetDecimalFormat("0.#######", provider);
                if (decimalCount == 9)
                    return GetDecimalFormat("0.#########", provider);
                if (decimalCount == 15)
                    return GetDecimalFormat("0.###############", provider);
                if (decimalCount == 17)
                    return GetDecimalFormat("0.#################", provider);
                return GetDecimalFormat("0." + new string('#', decimalCount), provider);
	        }
            
            if (decimalCount == 0)
                return new ScientificFormat(isLowerCase ? "0e0" : "0E0", provider.ToLocale());
            if (decimalCount == 7)
                return new ScientificFormat(isLowerCase ? "0.#######e0" : "0.#######E0", provider.ToLocale());
            if (decimalCount == 15)
                return new ScientificFormat(isLowerCase ? "0.###############e0" : "0.###############E0", provider.ToLocale());

            return new ScientificFormat("0." + new string('#', decimalCount) + (isLowerCase ? "e0" : "E0"), provider.ToLocale());
	    }

	    private static NumberFormat GetFormat(string format, IFormatProvider provider, Type type)
	    {
	        if (format == null)
	            format = "G";

            var locale = provider.ToLocale();
	        DecimalFormat decf;

            if (format.Length >= 1)
            {
                switch (char.ToUpper(format[0]))
                {
                    case 'C':
                        {
                            string javaFormat;
                            NumberFormat nf = NumberFormat.GetCurrencyInstance(locale);
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

                            DecimalFormat f = (DecimalFormat)NumberFormat.GetNumberInstance(locale);
                            f.ApplyPattern(javaFormat);
                            return f;
                        }
                    case 'D':
                        {
                            if (format.Length == 1)
                            {
                                return GetDecimalFormat("0", provider);
                            }
                            else
                            {
                                int decimalCount;
                                if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                                {
                                    string javaFormat = new string('0', decimalCount);
                                    if (0 == decimalCount)
                                        javaFormat = "0";

                                    return GetDecimalFormat(javaFormat, provider);
                                }
                            }
                        }
                        break;
                    case 'E':
                        {
                            if (format.Length == 1)
                                return new ScientificFormat("0.000000E000", locale);
                            int decimalCount;
                            if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                            {
                                string javaFormat = "0." + new string('0', decimalCount);
                                if (0 == decimalCount)
                                    javaFormat = "0";
                                return new ScientificFormat(javaFormat + "E000", locale);
                            }
                        }
                        break;
                    case 'G':
                    case 'g':
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
                                    //javaFormat = format;
                                    var f = (DecimalFormat)NumberFormat.GetNumberInstance(locale);
                                    if ('P' == char.ToUpper(format[0]))
                                        f.ApplyLocalizedPattern(format + " %");
                                    else
                                        f.ApplyLocalizedPattern(format);
                                    return f;
                                }
                            }

                            if ('P' == char.ToUpper(format[0]))
                                return GetDecimalFormat(javaFormat + " %", provider);

                            return GetDecimalFormat(javaFormat, provider);
                        }
                    case 'R':
                        {
                        return GetDecimalFormat("0.################################", provider);
                        }
                    case 'N':
                        {
                            if (format.Length == 1)
                                return GetDecimalFormat("#,##0.00", provider);
                            int decimalCount;
                            if (int.TryParse(format.JavaSubstring(1), out decimalCount))
                            {
                                string javaFormat = "#,##0." + new string('0', decimalCount);
                                if (0 == decimalCount)
                                    javaFormat = "#,##0";
                                return GetDecimalFormat(javaFormat, provider);
                            }
                        }
                        break;
                    case 'X':
                        if (format.Length == 1)
                            return new HexFormat(8, char.IsUpper(format[0]));
                        int numDigits;
                        if (int.TryParse(format.JavaSubstring(1), out numDigits))
                        {
                            return new HexFormat(numDigits, char.IsUpper(format[0]));
                        }
                        break;
                }
            }

            decf = (DecimalFormat)NumberFormat.GetNumberInstance(locale);
            decf.ApplyLocalizedPattern(format);
            return decf;
        }

        private static NumberFormat GetDecimalFormat(string format, IFormatProvider provider)
        {
            var locale = provider.ToLocale();
            
            DecimalFormatSymbols symbols = new DecimalFormatSymbols(locale) {Infinity = "Infinity"};
            DecimalFormat f = new DecimalFormat(format,symbols);
            
            return f;
        }


        private class HexFormat : NumberFormat
        {
            private readonly int numDigits;
            private readonly bool upperCase;

            public HexFormat(int numDigits, bool upperCase)
            {
                this.numDigits = numDigits;
                this.upperCase = upperCase;
            }

            public override StringBuffer Format(double @double, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                return Format((long) @double, stringBuffer, fieldPosition);
            }

            public override StringBuffer Format(long value, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                var l_hex = Int64.ToHexString(value);
                if (upperCase)
                    l_hex = l_hex.ToUpper();
                int l_pad = numDigits - l_hex.Length;
                l_pad = (0 < l_pad) ? l_pad : 0;

                var l_extended = new StringBuffer();
                for (int i = 0; i < l_pad; i++)
                {
                    l_extended.Append('0');
                }
                l_extended.Append(l_hex);

                return l_extended;
            }

            public override Number Parse(string @string, ParsePosition position)
            {
                return null;
            }
        }

        private class ScientificFormat : DecimalFormat
        {
            private DecimalFormat f;
            public ScientificFormat(string format, Java.Util.Locale locale)
            {
                f = (DecimalFormat)NumberFormat.GetNumberInstance(locale);
                f.ApplyPattern(format);
            }

            public override StringBuffer Format(double @double, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                return CheckForPositiveExponent(f.Format(@double, stringBuffer, fieldPosition));
            }

            public override StringBuffer Format(long value, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                return CheckForPositiveExponent(f.Format(value, stringBuffer, fieldPosition));
            }

            private StringBuffer CheckForPositiveExponent(StringBuffer number)
            {
                int i = number.IndexOf("E");
                if ((i > -1) && (-1 == number.IndexOf("E-")))
                {
                    return number.Insert(i + 1, "+");
                }

                return number;
            }
        }
    }
}

