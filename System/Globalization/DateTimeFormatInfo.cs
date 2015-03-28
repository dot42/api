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

using Dot42;
using Java.Text;
using Locale = Java.Util.Locale;

namespace System.Globalization
{
	public sealed class DateTimeFormatInfo : IFormatProvider
	{
	    public Locale Locale { get; set; }
	    private readonly DateFormat dateFormat;

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

	    internal DateTimeFormatInfo(DateFormat dateFormat, Java.Util.Locale locale)
	    {
	        Locale = locale;
	        this.dateFormat = dateFormat;

            amDesignator = "AM";
            pmDesignator = "PM";
            dateSeparator = "/";
            timeSeparator = ":";
            shortDatePattern = "MM/dd/yyyy";
            longDatePattern = "dddd, dd MMMM yyyy";
            shortTimePattern = "HH:mm";
            longTimePattern = "HH:mm:ss";
            monthDayPattern = "MMMM dd";
            yearMonthPattern = "yyyy MMMM";
	    }

        public string AMDesignator
        {
            get
            {
                return amDesignator;
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
                return fullDateTimePattern ?? (longDatePattern + " " + longTimePattern);
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

