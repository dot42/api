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
            return provider.ToJavaNumberFormat().Format((long)value);
	    }

	    internal static string Format(long value, IFormatProvider provider)
        {
            return provider.ToJavaNumberFormat().Format(value);
        }

	    internal static string Format(float value, IFormatProvider provider)
        {
            return provider.ToJavaNumberFormat().Format((double)value);
        }

	    internal static string Format(double value, IFormatProvider provider)
        {
            return provider.ToJavaNumberFormat().Format(value);
        }

        internal static string Format(string format, int value, IFormatProvider provider)
        {
            if (null == format)
                return GetDecimalFormat("0", provider).Format((long)value);
            return GetFormat(format, provider).Format((long)value);
        }

        internal static string Format(string format, long value, IFormatProvider provider)
        {
            if (null == format)
                return GetDecimalFormat("0", provider).Format(value);
            return GetFormat(format, provider).Format(value);
        }

        internal static string Format(string format, float value, IFormatProvider provider)
        {
            if (null == format)
                return GetDecimalFormat("0.################", provider).Format((double)value);
            return GetFormat(format, provider).Format((double)value);
        }

        internal static string Format(string format, double value, IFormatProvider provider)
        {
            if (null == format)
                return GetDecimalFormat("0.################", provider).Format(value);
            return GetFormat(format, provider).Format(value);
        }

	    private static NumberFormat GetFormat(string format, IFormatProvider provider)
	    {
	        if (format == null)
	            return provider.ToJavaNumberFormat();

            var locale = provider.ToLocale();

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
                    case 'G':
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

            var decf = (DecimalFormat)NumberFormat.GetNumberInstance(locale);
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

