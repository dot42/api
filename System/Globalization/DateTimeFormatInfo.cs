// Copyright (C) 2014 dot42
//
// Original filename: DateTimeFormatInfo.cs
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

using System.Text;
using Dot42;
using Dot42.Internal;
using Java.Text;
using Locale = Java.Util.Locale;

namespace System.Globalization
{
	public sealed class DateTimeFormatInfo : IFormatProvider
	{
	    private readonly bool _isInvariant;
	    public Locale Locale { get; set; }

        private string amDesignator;
        private string pmDesignator;
        private string dateSeparator;
        private string timeSeparator;
        private string shortDatePattern;
        private string longDatePattern;
        private string shortTimePattern;
        private string longTimePattern;
        private string monthDayPattern;
        private string yearMonthPattern;
        private string fullDateTimePattern;

        private string javaShortDatePattern;
        private string javaLongDatePattern;
        private string javaShortTimePattern;
        private string javaLongTimePattern;
        private string javaFullDateTimePattern;
        private string javaFullDateTimePattern2;


	    private const string InvariantJavaLongDatePattern = "EEEE, dd MMMM yyyy";
        private const string InvariantJavaShortDatePattern = "MM/dd/yyyy";

        private const string InvariantJavaLongTimePattern = "HH:mm:ss";
        private const string InvariantJavaShortTimePattern = "HH:mm";

        private const string DefaultAM = "AM";
        private const string DefaultPM = "PM";
        private const string DefaultDateSeparator = "/";
        private const string DefaultTimeSeparator = ":";

	    internal DateTimeFormatInfo(Java.Util.Locale locale, bool isInvariant = false)
	    {
	        _isInvariant = isInvariant;
	        Locale = locale;

            monthDayPattern = "MMMM dd";
            yearMonthPattern = "yyyy MMMM";
	    }

        public string AMDesignator
        {
            get
            {
                if (amDesignator == null) InitializeSymbols();
                return amDesignator ;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                amDesignator = value;
            }
        }

	    public string PMDesignator
        {
            get
            {
                if (pmDesignator == null) InitializeSymbols();
                return pmDesignator;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                pmDesignator = value;
            }
        }

        public string DateSeparator
        {
            get
            {
                if (dateSeparator == null) InitializeSymbols();
                return dateSeparator;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                dateSeparator = value;
            }
        }

        public string TimeSeparator
        {
            get
            {
                if (timeSeparator == null) InitializeSymbols();
                return timeSeparator;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                timeSeparator = value;
            }
        }

        public string LongDatePattern
        {
            get
            {
                return longDatePattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                longDatePattern = value;
            }
        }

	    public string ShortDatePattern
        {
            get
            {
                return shortDatePattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                shortDatePattern = value;
            }
        }

        public string LongTimePattern
        {
            get
            {
                return longTimePattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                longTimePattern = value;
            }
        }

        public string ShortTimePattern
        {
            get
            {
                return shortTimePattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                shortTimePattern = value;
            }
        }

        public string MonthDayPattern
        {
            get
            {
                return monthDayPattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                monthDayPattern = value;
            }
        }

        public string YearMonthPattern
        {
            get
            {
                return yearMonthPattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                yearMonthPattern = value;
            }
        }

        public string FullDateTimePattern
        {
            get
            {
                return fullDateTimePattern;
            }
            set
            {
                //if (IsReadOnly) throw new InvalidOperationException(MSG_READONLY);
                if (value == null) throw new ArgumentNullException();
                fullDateTimePattern = value;
            }
        }

        public string RFC1123Pattern
        {
            get
            {
                return "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
            }
        }

        internal string RoundtripPattern
        {
            get
            {
                return "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";
            }
        }

        public string SortableDateTimePattern
        {
            get
            {
                return "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
            }
        }

        public string UniversalSortableDateTimePattern
        {
            get
            {
                return "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";
            }
        }

        public static DateTimeFormatInfo InvariantInfo
        {
            get
            {
                return CultureInfo.InvariantCulture.DateTimeFormat;
            }
        }

        public static DateTimeFormatInfo CurrentInfo
        {
            get
            {
                return CultureInfo.CurrentCulture.DateTimeFormat;
            }
        }

        private string GetInvariantJavaPattern(int date, int time)
        {
            if (time == -1)
                return date == DateFormat.SHORT ? InvariantJavaShortDatePattern : InvariantJavaLongDatePattern;
            if (date == -1)
                return time == DateFormat.SHORT ? InvariantJavaShortTimePattern : InvariantJavaLongTimePattern;

            return (date == DateFormat.SHORT ? InvariantJavaShortDatePattern : InvariantJavaLongDatePattern)
                 + " "
                 + (time == DateFormat.SHORT ? InvariantJavaShortTimePattern : InvariantJavaLongTimePattern);
        }

        internal string GetJavaPattern(int date, int time)
        {
            if(_isInvariant)
                return GetInvariantJavaPattern(date, time);

            var dateFormat = CreateDateFormat(date, time);

            var sdf = dateFormat as SimpleDateFormat;
            if (sdf == null) 
                return GetInvariantJavaPattern(date, time);

            var pattern = sdf.ToPattern();
            return pattern;
        }

	    internal DateFormat CreateDateFormat(int date, int time)
        {
            if (_isInvariant)
                return new SimpleDateFormat(GetInvariantJavaPattern(date, time), Locale);

            DateFormat f;
            if (time == -1)
                f = DateFormat.GetDateInstance(date, Locale);
            else if (date == -1)
                f = DateFormat.GetTimeInstance(time, Locale);
            else
                f = DateFormat.GetDateTimeInstance(date, time, Locale);

	        if (date == DateFormat.SHORT)
	        {
	            // Java appears to default to two digits for the year where .NET defaults to four.
                // We fall back to SimpleDateFormat if possible, and replace the pattern chars.
                var sdf = f as SimpleDateFormat;
                if (sdf != null) 
                {
                    string pattern = sdf.ToPattern();
                    if (!pattern.Contains("yyy"))
                    {
                        pattern = pattern.Replace("yy", "yyyy");
                        return new SimpleDateFormat(pattern, Locale);
                    }
                }
	        }

	        return f;
        }

        private void InitializeSymbols()
        {
#if ANDROID_9P
            var f = DateFormatSymbols.GetInstance(Locale);
            amDesignator = f.AmPmStrings[Java.Util.Calendar.AM];
            pmDesignator = f.AmPmStrings[Java.Util.Calendar.PM];
#else
            amDesignator = DefaultAM;
            pmDesignator = DefaultPM;
#endif
            // TODO how to get date and time separators?
            dateSeparator = DefaultDateSeparator;
            timeSeparator = DefaultTimeSeparator;
        }

	    /// <summary>
	    /// Returns an object that provides formatting services for the specified type.
	    /// </summary>
	    public object GetFormat(Type formatType)
	    {
	        if (formatType == typeof (DateTimeFormatInfo))
	            return this;
	        return null;
	    }
	}
}

