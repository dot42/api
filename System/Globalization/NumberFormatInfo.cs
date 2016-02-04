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
using Java.Text;
using Java.Util;

namespace System.Globalization
{
	public sealed class NumberFormatInfo : IFormatProvider
	{
	    private readonly Locale _locale;

        private readonly NumberFormat _numbers;
	    private readonly DecimalFormat _decimals;
        private readonly DecimalFormat _currency;
        private readonly DecimalFormat _percent;

        private readonly DecimalFormatSymbols _symbols;

	    public NumberFormatInfo() :this(CultureInfo.CurrentCulture.Locale)
        { 
        }

	    internal NumberFormatInfo(Locale locale)
	    {
	        _locale = locale;

	        _numbers = NumberFormat.GetNumberInstance(locale);

            _symbols = new DecimalFormatSymbols(locale) { Infinity = "Infinity" };
	        
            _decimals = _numbers as DecimalFormat ?? new DecimalFormat();
            _decimals.DecimalFormatSymbols = _symbols;

            _currency =  NumberFormat.GetCurrencyInstance(locale) as DecimalFormat ?? _decimals;
            _percent = NumberFormat.GetPercentInstance(locale) as DecimalFormat ?? _decimals;
        }

        internal NumberFormat JavaNumberFormat { get { return _numbers; } }

        public static NumberFormatInfo GetInstance(IFormatProvider provider)
        {
            return new NumberFormatInfo(provider.ToLocale());
        }

        public static NumberFormatInfo InvariantInfo
        {
            get { return CultureInfo.InvariantCulture.NumberFormat; }
        }

        public static NumberFormatInfo CurrentInfo
        {
            get { return CultureInfo.CurrentCulture.NumberFormat; }
        }

	    public string CurrencySymbol
	    {
            get { return _symbols.CurrencySymbol; }
	    }

	    public string CurrencyDecimalSeparator
	    {
            get { return _symbols.MonetaryDecimalSeparator.ToString(); }
            set { if (value != CurrencyDecimalSeparator) throw new NotSupportedException(); }
	    }

	    public string CurrencyGroupSeparator
	    {
            get { return _currency.DecimalFormatSymbols.GroupingSeparator.ToString(); }
            set { if (value != CurrencyGroupSeparator) throw new NotSupportedException(); }
	    }

        public string NumberDecimalSeparator
        {
            get { return _symbols.DecimalSeparator.ToString(); }
            set { if (value != NumberDecimalSeparator) throw new NotSupportedException(); }
        }

        public string NumberGroupSeparator
        {
            get { return _symbols.GroupingSeparator.ToString(); }
            set { if (value != NumberGroupSeparator) throw new NotSupportedException(); }
        }

        public int[] NumberGroupSizes { get { return new [] {_decimals.GroupingSize}; } }

        public int NumberPositivePattern { get; set; }
        public int NumberNegativePattern { get; set; }
        public int NumberDecimalDigits { get { return 2; } }

	    public string PercentSymbol
	    {
            get { return _symbols.Percent.ToString(); }
	    }

        public string PercentGroupSeparator
	    {
            get { return _percent.DecimalFormatSymbols.GroupingSeparator.ToString(); }
            set { if (value != PercentGroupSeparator) throw new NotSupportedException(); }
	    }

        public int[] PercentGroupSizes { get { return new[] { _percent.GroupingSize } ; } }

        public int PercentPositivePattern { get; set; }
        public int PercentNegativePattern { get; set; }
        public int PercentDecimalDigits { get { return 2; } }

        public string PercentDecimalSeparator
        {
            get { return _percent.DecimalFormatSymbols.DecimalSeparator.ToString(); }
            set { if (value != ".") throw new NotSupportedException(); }
        }

        public int CurrencyPositivePattern { get; set; }
        public int CurrencyNegativePattern { get; set; }
        public int CurrencyDecimalDigits { get { return _currency.Currency.DefaultFractionDigits; } }

        public int[] CurrencyGroupSizes { get { return new [] {_currency.GroupingSize }; } }

        public string NegativeSign { get { return "-"; } }
        public string PositiveSign { get { return string.Empty; } }

        public string NaNSymbol { get { return _symbols.NaN; } }
        public string PositiveInfinitySymbol { get { return "+" + _symbols.Infinity; } }
        public string NegativeInfinitySymbol { get { return "-" + _symbols.Infinity; } }

        public string PerMilleSymbol { get { return _symbols.PerMill.ToString(); } }

        public bool IsReadOnly { get { return true; } }

	    public Locale Locale { get { return _locale; } }

	    /// <summary>
	    /// Returns an object that provides formatting services for the specified type.
	    /// </summary>
	    public object GetFormat(Type formatType)
	    {
            if (formatType == typeof (ICustomFormatter))
            {
                return CultureInfo.DefaultCustomFormatter;
            }
            if (formatType == typeof(NumberFormatInfo))
            {
                return this;
            }

	        return null; // let the caller handle everything.
            //throw new NotImplementedException("System.Globalization.NumberFormatInfo.GetFormat: " + formatType.FullName);
	    }
	}
}

