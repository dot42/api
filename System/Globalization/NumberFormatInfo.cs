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
using Java.Util;

namespace System.Globalization
{
	public sealed class NumberFormatInfo : IFormatProvider
	{
	    private readonly Locale _locale;

        internal NumberFormat JavaNumberFormat { get { return _decimals; } }

	    private int[] currencyGroupSizes;
        private int[] numberGroupSizes;
        private int[] percentGroupSizes;
	    private DecimalFormat _decimals;
	    private NumberFormat _currency;
	    private NumberFormat _percent;

	    public NumberFormatInfo() :this(CultureInfo.CurrentCulture.Locale)
        { 
        }

	    internal NumberFormatInfo(Locale locale)
	    {
	        _locale = locale;

	        _decimals = (DecimalFormat) NumberFormat.GetNumberInstance(locale);
           
	        _currency = NumberFormat.GetCurrencyInstance(locale);
	        _percent = NumberFormat.GetPercentInstance(locale);

	        currencyGroupSizes = new[] { _currency.Currency.DefaultFractionDigits };
            numberGroupSizes = new[] { _decimals.GroupingSize };
            percentGroupSizes = new[] { _percent.MaximumFractionDigits };
        }

        public static NumberFormatInfo GetInstance(IFormatProvider provider)
        {
            return new NumberFormatInfo(provider.ToLocale());
        }

        public static NumberFormatInfo InvariantInfo
        {
            get
            {
                return new NumberFormatInfo(CultureInfo.InvariantCulture.Locale);
            }
        }

	    public string CurrencySymbol
	    {
            get { return _currency.Currency.Symbol; }
	    }

	    public string CurrencyDecimalSeparator
	    {
            get { return _decimals.DecimalFormatSymbols.MonetaryDecimalSeparator.ToString(); }
	        set { if(value != ".") throw new NotSupportedException(); }
	    }

	    public string CurrencyGroupSeparator
	    {
            get { return ""; }
            set { if (value != "") throw new NotSupportedException(); }
	    }

        public string NumberDecimalSeparator
        {
            get { return _decimals.DecimalFormatSymbols.DecimalSeparator.ToString(); }
            set { if (value != ".") throw new NotSupportedException(); }
        }

        public string NumberGroupSeparator
        {
            get { return _decimals.DecimalFormatSymbols.GroupingSeparator.ToString(); }
            set { if (value != "") throw new NotSupportedException(); }
        }

        public int[] NumberGroupSizes { get { return numberGroupSizes; } }
        internal int[] RawNumberGroupSizes { get { return numberGroupSizes; } }

        public int NumberPositivePattern { get; set; }
        public int NumberNegativePattern { get; set; }
        public int NumberDecimalDigits { get { return 2; } }

	    public string PercentSymbol
	    {
            get { return _decimals.DecimalFormatSymbols.Percent.ToString(); }
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
            get { return NumberDecimalSeparator; }
            set { if (value != ".") throw new NotSupportedException(); }
        }

        public int CurrencyPositivePattern { get; set; }
        public int CurrencyNegativePattern { get; set; }
        public int CurrencyDecimalDigits { get { return 2; } }

        public int[] CurrencyGroupSizes { get { return currencyGroupSizes; } }
        internal int[] RawCurrencyGroupSizes { get { return currencyGroupSizes; } }

        public string NegativeSign { get { return "-"; } }
        public string PositiveSign { get { return string.Empty; } }

        public string NaNSymbol { get { return _decimals.DecimalFormatSymbols.NaN; } }
        public string PositiveInfinitySymbol { get { return "+INF"; } }
        public string NegativeInfinitySymbol { get { return "-INF"; } }

        public string PerMilleSymbol { get { return _decimals.DecimalFormatSymbols.PerMill.ToString(); } }

        public bool IsReadOnly { get { return true; } }

	    public Locale Locale { get { return _locale; } }

	    /// <summary>
	    /// Returns an object that provides formatting services for the specified type.
	    /// </summary>
	    public object GetFormat(Type formatType)
	    {
            if (formatType == typeof (ICustomFormatter))
            {
                return new CustomFormatter();
            }

	        return null; // let the caller handle everything.
            //throw new NotImplementedException("System.Globalization.NumberFormatInfo.GetFormat: " + formatType.FullName);
	    }

        private class CustomFormatter: ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (arg is int) return NumberFormatter.Format(format, (int)arg, formatProvider);
                if (arg is long) return NumberFormatter.Format(format, (long)arg, formatProvider);
                if (arg is float) return NumberFormatter.Format(format, (float)arg, formatProvider);
                if (arg is double) return NumberFormatter.Format(format, (double)arg, formatProvider);

                return null; // let the caller handle the formatting.
                //throw new NotImplementedException("System.Globalization.NumberFormatInfo.CustomFormatter.Format");
            }
        }
	}
}

