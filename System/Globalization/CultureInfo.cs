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
        private readonly Lazy<NumberFormatInfo> _numberFormat;

        private static readonly Lazy<CultureInfo> _invariantCulture;

        internal Locale Locale
        {
            get { return _locale; }
        }

        static CultureInfo ()
        {
            Locale invariantLocale;

#if ANDROID_9P
            invariantLocale = Locale.ROOT;
#else
            // TODO: check if this actually exists. else change back to Locale.Default.
            invariantLocale = Locale.US; 
#endif
            _invariantCulture = new Lazy<CultureInfo>(() => new CultureInfo(invariantLocale));
            
        }
        /// <summary>
        /// Default ctor
        /// </summary>
        private CultureInfo(Locale locale)
        {
            this._locale = locale;
            _numberFormat = new Lazy<NumberFormatInfo>(()=>new NumberFormatInfo(locale));

        }

        public CultureInfo(string locale) : this(new Locale(locale))
        {
        }

        public static CultureInfo CurrentCulture
        {
            get { return new CultureInfo(Java.Util.Locale.Default); } 
        }

        public static CultureInfo InvariantCulture
        {
            get { return _invariantCulture.Value; } 
        }

        internal DateFormat JavaDateFormat
        {
            get { return DateFormat.GetDateTimeInstance(DateFormat.DEFAULT, DateFormat.DEFAULT, _locale); }
        }

        public virtual DateTimeFormatInfo DateTimeFormat
        {
            get { return new DateTimeFormatInfo(JavaDateFormat); }
        }

        internal Java.Text.NumberFormat JavaNumberFormat
        {
            get { return Java.Text.NumberFormat.GetNumberInstance(_locale); }
        }

        public virtual NumberFormatInfo NumberFormat
        {
            get { return _numberFormat.Value; }
        }

        public bool IsReadOnly { get { return true; } }

        /// <summary>
        /// Returns an object that provides formatting services for the specified type.
        /// </summary>
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return new CustomFormatter();
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
            var locale = cultureInfo == null ? Locale.Default : cultureInfo.Locale;
            if (locale == null) locale = Locale.Default;
            return locale;
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
            var cultureInfo = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            return cultureInfo.NumberFormat;
        }


    }
}

