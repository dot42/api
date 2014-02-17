// Copyright (C) 2014 dot42
//
// Original filename: NumberFormatInfo.cs
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
using Dot42.Internal;
using Java.Text;

namespace System.Globalization
{
	public sealed class NumberFormatInfo : IFormatProvider
	{
	    private readonly NumberFormat numberFormat;
	    private int[] currencyGroupSizes;
        private int[] numberGroupSizes;
        private int[] percentGroupSizes;

        public NumberFormatInfo()
            :this(CultureInfo.CurrentCulture.JavaNumberFormat)
        { 
        }

	    internal NumberFormatInfo(NumberFormat numberFormat)
	    {
	        this.numberFormat = numberFormat;
            currencyGroupSizes = new[] { 3 };
            numberGroupSizes = new[] { 3 };
            percentGroupSizes = new[] { 3 };
        }

        public static NumberFormatInfo GetInstance(IFormatProvider provider)
        {
            throw new NotImplementedException("System.Globalization.NumberFormatInfo.GetInstance");
        }

        public static NumberFormatInfo InvariantInfo
        {
            get
            {
                return new NumberFormatInfo(CultureInfo.InvariantCulture.JavaNumberFormat);
            }
        }

	    public string CurrencySymbol
	    {
            get { return numberFormat.Currency.GetSymbol(); }
	    }

	    public string CurrencyDecimalSeparator
	    {
            get { return "."; }
	        set { if(value != ".") throw new NotSupportedException(); }
	    }

	    public string CurrencyGroupSeparator
	    {
            get { return ""; }
            set { if (value != "") throw new NotSupportedException(); }
	    }

        public string NumberDecimalSeparator
        {
            get { return "."; }
            set { if (value != ".") throw new NotSupportedException(); }
        }

        public string NumberGroupSeparator
        {
            get { return ""; }
            set { if (value != "") throw new NotSupportedException(); }
        }

        public int[] NumberGroupSizes { get { return numberGroupSizes; } }
        internal int[] RawNumberGroupSizes { get { return numberGroupSizes; } }

        public int NumberPositivePattern { get; set; }
        public int NumberNegativePattern { get; set; }
        public int NumberDecimalDigits { get { return 2; } }

	    public string PercentSymbol
	    {
            get { return "%"; }
	    }

        public string PercentGroupSeparator
        {
            get { return ""; }
            set { if (value != "") throw new NotSupportedException(); }
        }

        public int[] PercentGroupSizes { get { return percentGroupSizes; } }
        internal int[] RawPercentGroupSizes { get { return percentGroupSizes; } }

        public int PercentPositivePattern { get; set; }
        public int PercentNegativePattern { get; set; }
        public int PercentDecimalDigits { get { return 2; } }

        public string PercentDecimalSeparator
        {
            get { return "."; }
            set { if (value != ".") throw new NotSupportedException(); }
        }

        public int CurrencyPositivePattern { get; set; }
        public int CurrencyNegativePattern { get; set; }
        public int CurrencyDecimalDigits { get { return 2; } }

        public int[] CurrencyGroupSizes { get { return currencyGroupSizes; } }
        internal int[] RawCurrencyGroupSizes { get { return currencyGroupSizes; } }

        public string NegativeSign { get { return "-"; } }
        public string PositiveSign { get { return string.Empty; } }

        public string NaNSymbol { get { return "NaN"; } }
        public string PositiveInfinitySymbol { get { return "+INF"; } }
        public string NegativeInfinitySymbol { get { return "-INF"; } }

        public string PerMilleSymbol { get { return ""; } }

        public bool IsReadOnly { get { return true; } }

	    /// <summary>
	    /// Returns an object that provides formatting services for the specified type.
	    /// </summary>
	    public object GetFormat(Type formatType)
	    {
            if (formatType == typeof (ICustomFormatter))
            {
                return new CustomFormatter();
            }

            throw new NotImplementedException("System.Globalization.NumberFormatInfo.GetFormat: " + formatType.FullName);
	    }

        private class CustomFormatter: ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (arg is int) return NumberFormatter.Format(format, (int)arg, formatProvider);
                if (arg is long) return NumberFormatter.Format(format, (long)arg, formatProvider);
                if (arg is float) return NumberFormatter.Format(format, (float)arg, formatProvider);
                if (arg is double) return NumberFormatter.Format(format, (double)arg, formatProvider);
                throw new NotImplementedException("System.Globalization.NumberFormatInfo.CustomFormatter.Format");
            }
        }
	}
}

