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
        private readonly Locale locale;

        internal Locale Locale
        {
            get { return locale; }
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        private CultureInfo(Locale locale)
        {
            this.locale = locale;
        }

        public CultureInfo(string locale)
        {
            this.locale = new Locale(locale);
        }

        public static CultureInfo CurrentCulture
        {
            get { return new CultureInfo(Locale.Default); }
        }

        public static CultureInfo InvariantCulture
        {
            get
            {
#if ANDROID_9P
                return new CultureInfo(Locale.ROOT);
#else
                return new CultureInfo(Locale.Default);
#endif
            }
        }

        internal DateFormat JavaDateFormat
        {
            get { return DateFormat.GetDateTimeInstance(DateFormat.DEFAULT, DateFormat.DEFAULT, locale); }
        }

        public virtual DateTimeFormatInfo DateTimeFormat
        {
            get { return new DateTimeFormatInfo(JavaDateFormat); }
        }

        internal Java.Text.NumberFormat JavaNumberFormat
        {
            get { return Java.Text.NumberFormat.GetNumberInstance(locale); }
        }

        public virtual NumberFormatInfo NumberFormat
        {
            get { return new NumberFormatInfo(JavaNumberFormat); }
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

            throw new NotImplementedException("System.Globalization.CultureInfo.GetFormat: " + formatType.FullName);
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

                throw new NotImplementedException("System.Globalization.CultureInfo.CustomFormatter.Format");
            }
        }
	}
}

