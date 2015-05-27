// Copyright (C) 2014 dot42
//
// Original filename: CultureInfo.cs
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

using System.Runtime.InteropServices;
using Dot42.Internal;
using Java.Text;
using Java.Util;

namespace System.Globalization
{
    [SerializableAttribute]
    [ComVisible(true)]
	public class CultureInfo : IFormatProvider
    {
        private readonly Locale _locale;
        private readonly LazyAndWeak<NumberFormatInfo> _numberFormat;
        private readonly LazyAndWeak<DateTimeFormatInfo > _dateTimeFormat;

        private static readonly Lazy<CultureInfo> CachedInvariantCulture;
        private static readonly Lazy<CultureInfo> CachedCurrentCulture;

        internal Locale Locale
        {
            get { return _locale; }
        }

        static CultureInfo ()
        {
            Locale invariantLocale;

#if ANDROID_9P
            invariantLocale = Locale.US; // US comes much closer to CultureInfo.InvariantCulture 
                                         // than Locale.ROOT, when it comes to Date/Time formatting.
#else
            // TODO: check if this actually exists. else change back to Locale.Default.
            invariantLocale = Locale.US;
#endif
            CachedInvariantCulture = new Lazy<CultureInfo>(() => new CultureInfo(invariantLocale));
            CachedCurrentCulture = new Lazy<CultureInfo>(() => new CultureInfo(Locale.Default));
            
        }
        /// <summary>
        /// Default ctor
        /// </summary>
        private CultureInfo(Locale locale)
        {
            this._locale = locale;
            _numberFormat = new LazyAndWeak<NumberFormatInfo>(()=>new NumberFormatInfo(locale));
            _dateTimeFormat = new LazyAndWeak<DateTimeFormatInfo>(() => new DateTimeFormatInfo(JavaDateFormat, locale));

        }

        public CultureInfo(string locale) : this(new Locale(locale))
        {
        }

        public static CultureInfo CurrentCulture
        {
            get { return CachedCurrentCulture.Value; } 
        }

        public static CultureInfo CurrentUICulture
        {
            get { return CachedCurrentCulture.Value; }
        }

        public static CultureInfo InvariantCulture
        {
            get { return CachedInvariantCulture.Value; } 
        }

        internal DateFormat JavaDateFormat
        {
            get { return DateFormat.GetDateTimeInstance(DateFormat.DEFAULT, DateFormat.DEFAULT, _locale); }
        }

        public virtual DateTimeFormatInfo DateTimeFormat
        {
            get { return _dateTimeFormat.Value; }
        }

        internal Java.Text.NumberFormat JavaNumberFormat
        {
            get { return _numberFormat.Value.JavaNumberFormat; }
        }

        public virtual NumberFormatInfo NumberFormat
        {
            get { return _numberFormat.Value; }
        }

        public bool IsReadOnly { get { return true; } }

        public override string ToString()
        {
            return _locale.ToString(); //.Replace('_', '-');
        }

        /// <summary>
        /// Returns an object that provides formatting services for the specified type.
        /// </summary>
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return new CustomFormatter();
            }
            if (formatType == typeof(NumberFormatInfo))
            {
                return NumberFormat;
            }

            if (formatType == typeof(DateTimeFormatInfo))
            {
                return DateTimeFormat;
            }

            return null; // not supported.
            //throw new NotImplementedException("System.Globalization.CultureInfo.GetFormat: " + formatType.FullName);
        }

        private class CustomFormatter : ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (arg is int) return NumberFormatter.Format(format, (int)arg, formatProvider);
                if (arg is long) return NumberFormatter.Format(format, (long)arg, formatProvider);
                if (arg is float) return NumberFormatter.Format(format, (float)arg, formatProvider);
                if (arg is double) return NumberFormatter.Format(format, (double)arg, formatProvider);
                if (arg is string) return null; //should be handled by caller.

                return null; // should be handled by caller.
                //throw new NotImplementedException("System.Globalization.CultureInfo.CustomFormatter.Format");
            }
        }
	}

    internal static class FormatProviderExtensions
    {
        public static Locale ToLocale(this IFormatProvider provider)
        {
            var cultureInfo = provider as CultureInfo;
            if (cultureInfo != null) return cultureInfo.Locale;

            var dateTime = provider as DateTimeFormatInfo;
            if (dateTime != null) return dateTime.Locale;

            var numberFormat = provider as NumberFormatInfo;
            if (numberFormat != null) return numberFormat.Locale;
            
            return Locale.Default;
        }

        public static CultureInfo ToCultureInfo(this IFormatProvider provider)
        {
            var cultureInfo = provider as CultureInfo;
            return cultureInfo ?? CultureInfo.CurrentCulture;

        }

        public static bool IsInvariantCulture(this IFormatProvider provider)
        {
            var cultureInfo = provider as CultureInfo;
            return cultureInfo != null && cultureInfo == CultureInfo.InvariantCulture;
        }

        public static NumberFormatInfo ToNumberFormatInfo(this IFormatProvider provider)
        {
            var numberFormat = provider as NumberFormatInfo;
            if (numberFormat != null) return numberFormat;

            var cultureInfo = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            return cultureInfo.NumberFormat;
        }

        internal static NumberFormat ToJavaNumberFormat(this IFormatProvider provider)
        {
            var numberFormat = provider as NumberFormatInfo;
            if (numberFormat != null) return numberFormat.JavaNumberFormat;

            var cultureInfo = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            return cultureInfo.NumberFormat.JavaNumberFormat;
        }


    }
}

