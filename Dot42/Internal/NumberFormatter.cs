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


namespace Dot42.Internal
{
	internal static class NumberFormatter
	{
	    internal static string Format(int value, IFormatProvider provider)
	    {
	        return NumberFormat.GetIntegerInstance().Format((long) value);
	    }

	    internal static string Format(long value, IFormatProvider provider)
        {
            return NumberFormat.GetIntegerInstance().Format(value);
        }

	    internal static string Format(float value, IFormatProvider provider)
        {
            return NumberFormat.GetInstance().Format((double) value);
        }

	    internal static string Format(double value, IFormatProvider provider)
        {
            return NumberFormat.GetInstance().Format(value);
        }

        internal static string Format(string format, int value, IFormatProvider provider)
        {
            return GetFormat(format).Format((long)value);
        }

        internal static string Format(string format, long value, IFormatProvider provider)
        {
            return GetFormat(format).Format(value);
        }

        internal static string Format(string format, float value, IFormatProvider provider)
        {
            return GetFormat(format).Format((double)value);
        }

        internal static string Format(string format, double value, IFormatProvider provider)
        {
            return GetFormat(format).Format(value);
        }

        private static NumberFormat GetFormat(string format)
        {
            if (format == null)
                return NumberFormat.GetInstance();
            if (format.Length >= 1)
            {
                switch (char.ToUpper(format[0]))
                {
                    case 'C':
                        return NumberFormat.GetCurrencyInstance();
                    case 'D':
                        if(format.Length == 1) return NumberFormat.GetIntegerInstance();
                        int decimalCount;
                        if( int.TryParse(format.JavaSubstring(1), out decimalCount))
                        {
                            var builder = new StringBuilder();
                            for(int i=0; i<decimalCount; i++) builder.Append( '0' );
                            //TODO: builder.Append( '0', decimalCount);
                            return new DecimalFormat(builder.ToString());
                        }
                        break;
                    case 'E':
                    case 'F':
                    case 'G':
                    case 'N':
                    case 'R':
                        return NumberFormat.GetNumberInstance();
                    case 'P':
                        return NumberFormat.GetPercentInstance();
                    case 'X':
                        if (format.Length == 1) return new HexFormat(8, char.IsUpper(format[0]));
                        int numDigits;
                        if (int.TryParse(format.JavaSubstring(1), out numDigits))
                        {
                            return new HexFormat(numDigits, char.IsUpper(format[0]));
                        }
                        break;
                }
            }
            return new DecimalFormat(format);
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
                if (upperCase) l_hex = l_hex.ToUpper();
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
    }
}

