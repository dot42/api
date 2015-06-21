// Copyright (C) 2014 dot42
//
// Original filename: DateTime.cs
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
using System.Globalization;
using System.Text;
using Dot42.Internal;
using Java.Text;
using Java.Util;
using Calendar = Java.Util.Calendar;

namespace System
{
    public struct DateTime : System.IComparable<DateTime>
	{
        /// <summary>
        /// The value of this constant is equivalent to 23:59:59.9999999, December 31, 9999, exactly one 100-nanosecond tick before 00:00:00, January 1, 10000.
        /// </summary>
        public static readonly DateTime MaxValue = new DateTime(MaxTicks);
        /// <summary>
        /// The value of this constant is equivalent to 00:00:00.0000000, January 1, 0001.
        /// </summary>
        public static readonly DateTime MinValue = new DateTime(MinTicks);

        internal const long MinTicks = 0L;
        internal const long MaxTicks = 3155378975999999999L;

        // milliseconds between 01.01.0001,00:00:00.000 (Microsoft baseline) and 01.01.1970,00:00:00.000 (Java baseline)
	    internal const long EraDifferenceInMs = 62135596800000L;
        internal const long MinValueJavaMillies = -62135769600000; // I have no idea why this is different from -EraDifferenceInMs. Who stole the two days?

	    private const int MonthOffset = 1;
	    private const int YearOffset = 1900;
	    private const int MillisecondsPerMinute = 60000;

	    private readonly long ticks;
	    private readonly DateTimeKind kind;

        // Implementation Note:
        // Java's Date represents milliseconds from the epoch in GMT/UT time, it has no timezone attached.
        // BLC's  DateTime represents (?) from the epoch either in UTC, localtime, or unspecified.
        //
        // A perfect emulation of BCL's DateTime with Java's pre-v8 Date/Calendar implementation 
        // can not be achieved.



        public DateTime(long ticks)
            :this(ticks, DateTimeKind.Unspecified)
        {
        }

	    public DateTime(long ticks, DateTimeKind kind)
	    {
            CheckMinMaxTicks(ticks);
	        this.ticks = ticks;
	        this.kind = kind;
	    }

        public DateTime(int year, int month, int day)
            :this(year, month, day, 0, 0, 0, 0)
        {
        }

        
        //public DateTime(int year, int month, int day, Calendar calendar) { }
        
        public DateTime(int year, int month, int day, int hour, int minute, int second)
            : this(year, month, day, hour, minute, second, 0)
        {
        }
       
        //public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar) { }
        
        public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
            : this(year, month, day, hour, minute, second, 0, kind)
        {
        }

        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
            : this(year, month, day, hour, minute, second, millisecond, DateTimeKind.Unspecified, false)
        {
        }

        //public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
            : this(year, month, day, hour, minute, second, millisecond, kind, true)
        {
        }

        private DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind, bool useSpecifiedKind)
        {
            //special handling for DateTime.MinValue, since it would produce an underflow (for some reason not entirely clear to me)
            if (year == 1 && month == 1 && day == 1 && hour == 0 && minute == 0 && second == 0 && millisecond == 0)
            {
                this.ticks = 0L;
                this.kind = kind;
            }
            else
            {
                // TODO: think about using Date.UTC when appropriate.
                var dateTime = FromDate(new Java.Util.Date(year - YearOffset, month - MonthOffset, day, hour, minute, second), DateTimeKind.Unspecified);
                this.ticks = dateTime.Ticks + TimeSpan.TicksPerMillisecond * millisecond;
                CheckMinMaxTicks(ticks);
                this.kind = useSpecifiedKind ? kind : dateTime.Kind;
            }
        }

        //public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind) { }

        private static void CheckMinMaxTicks(long ticks)
        {
            if (ticks < MinTicks ) throw new ArgumentOutOfRangeException("DateTime may not be less that MinValue");
            if (ticks > MaxTicks ) throw new ArgumentOutOfRangeException("DateTime may not be greater that MaxValue");
        }

        public DateTimeKind Kind { get { return kind; } }

        public long Ticks { get { return ticks; } }

        public DateTime Date
        {
            get
            {
                return new DateTime(this.Year, this.Month, this.Day, 0, 0, 0, this.Kind);
            }
        }

        public int Day { get { return GetCalendar().Get(Calendar.DATE); } }

        public DayOfWeek DayOfWeek
        {
            get
            {
                switch (GetCalendar().Get(Calendar.DAY_OF_WEEK))
                {
                    case Java.Util.Calendar.SUNDAY:
                        return System.DayOfWeek.Sunday;

                    case Java.Util.Calendar.MONDAY:
                        return System.DayOfWeek.Monday;

                    case Java.Util.Calendar.TUESDAY:
                        return System.DayOfWeek.Tuesday;

                    case Java.Util.Calendar.WEDNESDAY:
                        return System.DayOfWeek.Wednesday;

                    case Java.Util.Calendar.THURSDAY:
                        return System.DayOfWeek.Thursday;

                    case Java.Util.Calendar.FRIDAY:
                        return System.DayOfWeek.Friday;

                    case Java.Util.Calendar.SATURDAY:
                        return System.DayOfWeek.Saturday;
                };

                return System.DayOfWeek.Sunday;
            }
        }
        
        public int DayOfYear { get { return GetCalendar().Get(Calendar.DAY_OF_YEAR); } }

        public int Hour { get { return GetCalendar().Get(Calendar.HOUR_OF_DAY); } }

        public int Millisecond { get { return GetCalendar().Get(Calendar.MILLISECOND); } }

        public int Minute { get { return GetCalendar().Get(Calendar.MINUTE); } }

        public int Month { get { return GetCalendar().Get(Calendar.MONTH) + MonthOffset; } }
       
        public static DateTime Now { get { return FromDate(new Java.Util.Date(), DateTimeKind.Local); } }

        public int Second { get { return GetCalendar().Get(Calendar.SECOND); } }

        public TimeSpan TimeOfDay { get { return new TimeSpan(Day, Hour, Minute, Second); } }
       
        public static DateTime Today { get {  return Now.Date; } }

        public static DateTime UtcNow { get { return Now.ToUniversalTime(); } }

        public int Year { get { return GetCalendar().Get(Calendar.YEAR); } }

        public DateTime Add(TimeSpan value)
        {
            return new DateTime(this.Ticks + value.Ticks, this.Kind);
        }

        public DateTime AddDays(double value)
        {
            return AddTicks((long)(value * TimeSpan.TicksPerDay));
        }

        public DateTime AddHours(double value)
        {
            return AddTicks((long)(value * TimeSpan.TicksPerHour));
        }

        public DateTime AddMilliseconds(double value)
        {
            return AddTicks((long)(value * TimeSpan.TicksPerMillisecond));       
        }

        public DateTime AddMinutes(double value)
        {
            return AddTicks((long)(value * TimeSpan.TicksPerMillisecond));      
        }

        public DateTime AddSeconds(double value)
        {
            return AddTicks((long)(value * TimeSpan.TicksPerSecond));   
        }

        public DateTime AddTicks(long value)
        {
            return new DateTime(this.Ticks + value, this.Kind);
        }
      
        public DateTime AddYears(int value)
        {
            var calender = GetCalendar();
            calender.Add(Calendar.YEAR, value);
            return FromDate(calender.Time, Kind);
        }

        public DateTime AddMonths(int months)
        {
            var calender = GetCalendar();
            calender.Add(Calendar.MONTH, months);
            return FromDate(calender.Time, Kind);
        }

	    public static int DaysInMonth(int year, int month)
	    {
            // Create a calendar object and set year and month
            Calendar mycal = new Java.Util.GregorianCalendar(year, month - MonthOffset, 1);

            // Get the number of days in that month
            return  mycal.GetActualMaximum(Calendar.DAY_OF_MONTH);         
	    }

        //
        // Summary:
        //     Compares two instances of System.DateTime and returns an integer that indicates
        //     whether the first instance is earlier than, the same as, or later than the
        //     second instance.
        //
        // Parameters:
        //   t1:
        //     The first object to compare.
        //
        //   t2:
        //     The second object to compare.
        //
        // Returns:
        //     A signed number indicating the relative values of t1 and t2.Value Type Condition
        //     Less than zero t1 is earlier than t2. Zero t1 is the same as t2. Greater
        //     than zero t1 is later than t2.
        public static int Compare(DateTime t1, DateTime t2)
        {
            if (t1.Ticks < t2.Ticks)
                return -1;
            else if (t1.Ticks > t2.Ticks)
                return 1;
            else
                return 0;
        }
        //
        // Summary:
        //     Compares the value of this instance to a specified System.DateTime value
        //     and returns an integer that indicates whether this instance is earlier than,
        //     the same as, or later than the specified System.DateTime value.
        //
        // Parameters:
        //   value:
        //     The object to compare to the current instance.
        //
        // Returns:
        //     A signed number indicating the relative values of this instance and the value
        //     parameter.Value Description Less than zero This instance is earlier than
        //     value. Zero This instance is the same as value. Greater than zero This instance
        //     is later than value.
        public int CompareTo(DateTime value)
        {
            return Compare(this, value);
        }
        //
        // Summary:
        //     Compares the value of this instance to a specified object that contains a
        //     specified System.DateTime value, and returns an integer that indicates whether
        //     this instance is earlier than, the same as, or later than the specified System.DateTime
        //     value.
        //
        // Parameters:
        //   value:
        //     A boxed object to compare, or null.
        //
        // Returns:
        //     A signed number indicating the relative values of this instance and value.Value
        //     Description Less than zero This instance is earlier than value. Zero This
        //     instance is the same as value. Greater than zero This instance is later than
        //     value, or value is null.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     value is not a System.DateTime.
        //public int CompareTo(object value)
        //{
        //    if (value == null)
        //        return 1;

        //    if (!(value is System.DateTime))
        //        throw new ArgumentException("Value is not a System.DateTime");

        //    return Compare(this, (DateTime)value);
        //}
        //
        // Summary:
        //     Returns the number of days in the specified month and year.
        //
        // Parameters:
        //   year:
        //     The year.
        //
        //   month:
        //     The month (a number ranging from 1 to 12).
        //
        // Returns:
        //     The number of days in month for the specified year.For example, if month
        //     equals 2 for February, the return value is 28 or 29 depending upon whether
        //     year is a leap year.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     month is less than 1 or greater than 12.-or-year is less than 1 or greater
        //     than 9999.
        //public static int DaysInMonth(int year, int month);
        //
        // Summary:
        //     Returns a value indicating whether the value of this instance is equal to
        //     the value of the specified System.DateTime instance.
        //
        // Parameters:
        //   value:
        //     The object to compare to this instance.
        //
        // Returns:
        //     true if the value parameter equals the value of this instance; otherwise,
        //     false.
        public bool Equals(DateTime value)
        {
            return value.Ticks == this.Ticks;
        }
        //
        // Summary:
        //     Returns a value indicating whether this instance is equal to a specified
        //     object.
        //
        // Parameters:
        //   value:
        //     The object to compare to this instance.
        //
        // Returns:
        //     true if value is an instance of System.DateTime and equals the value of this
        //     instance; otherwise, false.
        public override bool Equals(object value)
        {
            if (!(value is System.DateTime))
                return false;

            return Equals((System.DateTime)value);
        }
        //
        // Summary:
        //     Returns a value indicating whether two System.DateTime instances have the
        //     same date and time value.
        //
        // Parameters:
        //   t1:
        //     The first object to compare.
        //
        //   t2:
        //     The second object to compare.
        //
        // Returns:
        //     true if the two values are equal; otherwise, false.
        public static bool Equals(DateTime t1, DateTime t2)
        {
            return t1.Ticks == t2.Ticks;
        }

        //
        // Summary:
        //     Returns the hash code for this instance.
        //
        // Returns:
        //     A 32-bit signed integer hash code.
        public override int GetHashCode()
        {
            return ticks.GetHashCode();
        }

        public static bool operator ==(DateTime d1, DateTime d2)
        {
            return Equals(d1, d2);
        }

        public static bool operator !=(DateTime d1, DateTime d2)
        {
            return !Equals(d1, d2);
        }

        public static DateTime operator +(DateTime d, TimeSpan t)
        {
            var result = new DateTime(d.Ticks, d.Kind);
            result.Add(t);
            return result;
        }

        public static bool operator >(DateTime t1, DateTime t2)
        {
            return t1.Ticks > t2.Ticks;
        }

        public static bool operator >=(DateTime t1, DateTime t2)
        {
            return t1.Ticks >= t2.Ticks;
        }

        public static bool operator <(DateTime t1, DateTime t2)
        {
            return t1.Ticks < t2.Ticks;
        }

        public static bool operator <=(DateTime t1, DateTime t2)
        {
            return t1.Ticks <= t2.Ticks;
        }

        public static TimeSpan operator -(DateTime d1, DateTime d2)
        {
            return d1.Subtract(d2);
        }

        public static DateTime operator -(DateTime d, TimeSpan t)
        {
            return d.Subtract(t);
        }

        //
        // Summary:
        //     Deserializes a 64-bit binary value and recreates an original serialized System.DateTime
        //     object.
        //
        // Parameters:
        //   dateData:
        //     A 64-bit signed integer that encodes the System.DateTime.Kind property in
        //     a 2-bit field and the System.DateTime.Ticks property in a 62-bit field.
        //
        // Returns:
        //     An object that is equivalent to the System.DateTime object that was serialized
        //     by the System.DateTime.ToBinary() method.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     dateData is less than System.DateTime.MinValue or greater than System.DateTime.MaxValue.
        //public static DateTime FromBinary(long dateData);
        //
        // Summary:
        //     Converts the specified Windows file time to an equivalent local time.
        //
        // Parameters:
        //   fileTime:
        //     A Windows file time expressed in ticks.
        //
        // Returns:
        //     An object that represents the local time equivalent of the date and time
        //     represented by the fileTime parameter.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     fileTime is less than 0 or represents a time greater than System.DateTime.MaxValue.
        //public static DateTime FromFileTime(long fileTime);
        //
        // Summary:
        //     Converts the specified Windows file time to an equivalent UTC time.
        //
        // Parameters:
        //   fileTime:
        //     A Windows file time expressed in ticks.
        //
        // Returns:
        //     An object that represents the UTC time equivalent of the date and time represented
        //     by the fileTime parameter.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     fileTime is less than 0 or represents a time greater than System.DateTime.MaxValue.
        //public static DateTime FromFileTimeUtc(long fileTime);
        //
        // Summary:
        //     Returns a System.DateTime equivalent to the specified OLE Automation Date.
        //
        // Parameters:
        //   d:
        //     An OLE Automation Date value.
        //
        // Returns:
        //     An object that represents the same date and time as d.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     The date is not a valid OLE Automation Date value.
        //public static DateTime FromOADate(double d);
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the standard date and time format specifiers.
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with one of the standard date and time format specifiers.
        //public string[] GetDateTimeFormats();
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the specified standard date and time format specifier.
        //
        // Parameters:
        //   format:
        //     A standard date and time format string (see Remarks).
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with the format standard date and time format specifier.
        //
        // Exceptions:
        //   System.FormatException:
        //     format is not a valid standard date and time format specifier character.
        //public string[] GetDateTimeFormats(char format);
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the standard date and time format specifiers and the specified culture-specific
        //     formatting information.
        //
        // Parameters:
        //   provider:
        //     An object that supplies culture-specific formatting information about this
        //     instance.
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with one of the standard date and time format specifiers.
        //public string[] GetDateTimeFormats(IFormatProvider provider);
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the specified standard date and time format specifier and culture-specific
        //     formatting information.
        //
        // Parameters:
        //   format:
        //     A date and time format string (see Remarks).
        //
        //   provider:
        //     An object that supplies culture-specific formatting information about this
        //     instance.
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with one of the standard date and time format specifiers.
        //
        // Exceptions:
        //   System.FormatException:
        //     format is not a valid standard date and time format specifier character.
        //public string[] GetDateTimeFormats(char format, IFormatProvider provider);
        //
        // Summary:
        //     Returns the hash code for this instance.
        //
        // Returns:
        //     A 32-bit signed integer hash code.
        //public override int GetHashCode();
        //
        // Summary:
        //     Returns the System.TypeCode for value type System.DateTime.
        //
        // Returns:
        //     The enumerated constant, System.TypeCode.DateTime.
        //public TypeCode GetTypeCode();
        //
        // Summary:
        //     Indicates whether this instance of System.DateTime is within the daylight
        //     saving time range for the current time zone.
        //
        // Returns:
        //     true if System.DateTime.Kind is System.DateTimeKind.Local or System.DateTimeKind.Unspecified
        //     and the value of this instance of System.DateTime is within the daylight
        //     saving time range for the current time zone. false if System.DateTime.Kind
        //     is System.DateTimeKind.Utc.
        //public bool IsDaylightSavingTime()
        //{
            //var calender = GetCalender();
            //return calender
        //}
        //
        // Summary:
        //     Returns an indication whether the specified year is a leap year.
        //
        // Parameters:
        //   year:
        //     A 4-digit year.
        //
        // Returns:
        //     true if year is a leap year; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     year is less than 1 or greater than 9999.
        public static bool IsLeapYear(int year)
        {
            var calender = new Java.Util.GregorianCalendar();
            return calender.IsLeapYear(year);
        }

        /// <summary>
        /// Parse the given date/time string into a DateTime.
        /// </summary>
        public static DateTime Parse(string value)
        {
            return Parse(value, null, DateTimeStyles.None);
        }

        /// <summary>
        /// Parse the given date/time string into a DateTime.
        /// </summary>
        public static DateTime Parse(string value, IFormatProvider provider)
        {
            return Parse(value, provider, DateTimeStyles.None);
        }

        /// <summary>
        /// Parse the given date/time string into a DateTime.
        /// </summary>
        public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTimeParsing.Parse(s, provider, style);
        }

        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified culture-specific format information and formatting
        //     style.
        //
        // Parameters:
        //   s:
        //     A string containing a date and time to convert.
        //
        //   provider:
        //     An object that supplies culture-specific formatting information about s.
        //
        //   styles:
        //     A bitwise combination of the enumeration values that indicates the style
        //     elements that can be present in s for the parse operation to succeed and
        //     that defines how to interpret the parsed date in relation to the current
        //     time zone or the current date. A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        // Returns:
        //     An object that is equivalent to the date and time contained in s, as specified
        //     by provider and styles.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     s is null.
        //
        //   System.FormatException:
        //     s does not contain a valid string representation of a date and time.
        //
        //   System.ArgumentException:
        //     styles contains an invalid combination of System.Globalization.DateTimeStyles
        //     values. For example, both System.Globalization.DateTimeStyles.AssumeLocal
        //     and System.Globalization.DateTimeStyles.AssumeUniversal.
        //public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified format and culture-specific format information.
        //     The format of the string representation must match the specified format exactly.
        //
        // Parameters:
        //   s:
        //     A string that contains a date and time to convert.
        //
        //   format:
        //     A format specifier that defines the required format of s.
        //
        //   provider:
        //     An object that supplies culture-specific format information about s.
        //
        // Returns:
        //     An object that is equivalent to the date and time contained in s, as specified
        //     by format and provider.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     s or format is null.
        //
        //   System.FormatException:
        //     s or format is an empty string. -or- s does not contain a date and time that
        //     corresponds to the pattern specified in format. -or-The hour component and
        //     the AM/PM designator in s do not agree.
        public static DateTime ParseExact(string s, string format, IFormatProvider provider)
        {
            return ParseExact(s, format, provider, DateTimeStyles.None);
        }

	    public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
	    {
	        return DateTimeParsing.ParseExact(s, format, provider, style);
	    }

        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified format, culture-specific format information,
        //     and style. The format of the string representation must match the specified
        //     format exactly or an exception is thrown.
        //
        // Parameters:
        //   s:
        //     A string containing a date and time to convert.
        //
        //   format:
        //     A format specifier that defines the required format of s.
        //
        //   provider:
        //     An object that supplies culture-specific formatting information about s.
        //
        //   style:
        //     A bitwise combination of the enumeration values that provides additional
        //     information about s, about style elements that may be present in s, or about
        //     the conversion from s to a System.DateTime value. A typical value to specify
        //     is System.Globalization.DateTimeStyles.None.
        //
        // Returns:
        //     An object that is equivalent to the date and time contained in s, as specified
        //     by format, provider, and style.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     s or format is null.
        //
        //   System.FormatException:
        //     s or format is an empty string. -or- s does not contain a date and time that
        //     corresponds to the pattern specified in format. -or-The hour component and
        //     the AM/PM designator in s do not agree.
        //
        //   System.ArgumentException:
        //     style contains an invalid combination of System.Globalization.DateTimeStyles
        //     values. For example, both System.Globalization.DateTimeStyles.AssumeLocal
        //     and System.Globalization.DateTimeStyles.AssumeUniversal.
        //public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);
        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified array of formats, culture-specific format
        //     information, and style. The format of the string representation must match
        //     at least one of the specified formats exactly or an exception is thrown.
        //
        // Parameters:
        //   s:
        //     A string containing one or more dates and times to convert.
        //
        //   formats:
        //     An array of allowable formats of s.
        //
        //   provider:
        //     An object that supplies culture-specific format information about s.
        //
        //   style:
        //     A bitwise combination of enumeration values that indicates the permitted
        //     format of s. A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        // Returns:
        //     An object that is equivalent to the date and time contained in s, as specified
        //     by formats, provider, and style.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     s or formats is null.
        //
        //   System.FormatException:
        //     s is an empty string. -or- an element of formats is an empty string. -or-
        //     s does not contain a date and time that corresponds to any element of formats.
        //     -or-The hour component and the AM/PM designator in s do not agree.
        //
        //   System.ArgumentException:
        //     style contains an invalid combination of System.Globalization.DateTimeStyles
        //     values. For example, both System.Globalization.DateTimeStyles.AssumeLocal
        //     and System.Globalization.DateTimeStyles.AssumeUniversal.
        //public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);
        //
        // Summary:
        //     Creates a new System.DateTime object that has the same number of ticks as
        //     the specified System.DateTime, but is designated as either local time, Coordinated
        //     Universal Time (UTC), or neither, as indicated by the specified System.DateTimeKind
        //     value.
        //
        // Parameters:
        //   value:
        //     A date and time.
        //
        //   kind:
        //     One of the enumeration values that indicates whether the new object represents
        //     local time, UTC, or neither.
        //
        // Returns:
        //     A new object that has the same number of ticks as the object represented
        //     by the value parameter and the System.DateTimeKind value specified by the
        //     kind parameter.
        public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
        {
            return new DateTime(value.Ticks, kind);
        }
        //
        // Summary:
        //     Subtracts the specified date and time from this instance.
        //
        // Parameters:
        //   value:
        //     The date and time value to subtract.
        //
        // Returns:
        //     A time interval that is equal to the date and time represented by this instance
        //     minus the date and time represented by value.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     The result is less than System.DateTime.MinValue or greater than System.DateTime.MaxValue.
        public TimeSpan Subtract(DateTime value)
        {
            return new TimeSpan(Ticks) - new TimeSpan(value.Ticks);
        }
        //
        // Summary:
        //     Subtracts the specified duration from this instance.
        //
        // Parameters:
        //   value:
        //     The time interval to subtract.
        //
        // Returns:
        //     An object that is equal to the date and time represented by this instance
        //     minus the time interval represented by value.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     The result is less than System.DateTime.MinValue or greater than System.DateTime.MaxValue.
        public DateTime Subtract(TimeSpan value)
        {
            long newticks;

            newticks = Ticks - value.Ticks;

            if (newticks < 0 || newticks > MaxValue.Ticks) throw new ArgumentOutOfRangeException();

            return new DateTime(newticks, Kind);
        }
        //
        // Summary:
        //     Serializes the current System.DateTime object to a 64-bit binary value that
        //     subsequently can be used to recreate the System.DateTime object.
        //
        // Returns:
        //     A 64-bit signed integer that encodes the System.DateTime.Kind and System.DateTime.Ticks
        //     properties.
        //public long ToBinary();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to a Windows file
        //     time.
        //
        // Returns:
        //     The value of the current System.DateTime object expressed as a Windows file
        //     time.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     The resulting file time would represent a date and time before 12:00 midnight
        //     January 1, 1601 C.E. UTC.
        //public long ToFileTime();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to a Windows file
        //     time.
        //
        // Returns:
        //     The value of the current System.DateTime object expressed as a Windows file
        //     time.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     The resulting file time would represent a date and time before 12:00 midnight
        //     January 1, 1601 C.E. UTC.
        //public long ToFileTimeUtc();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to local time.
        //
        // Returns:
        //     An object whose System.DateTime.Kind property is System.DateTimeKind.Local,
        //     and whose value is the local time equivalent to the value of the current
        //     System.DateTime object, or System.DateTime.MaxValue if the converted value
        //     is too large to be represented by a System.DateTime object, or System.DateTime.MinValue
        //     if the converted value is too small to be represented as a System.DateTime
        //     object.
        public DateTime ToLocalTime()
        {
            if (Kind == DateTimeKind.Local)
                return this;

            var utcOffset = TimeZoneInfo.Local.GetUtcOffset(ticks);

            if (utcOffset.Ticks > 0)
            {
                if (MaxValue - utcOffset < this)
                    return SpecifyKind(MaxValue, DateTimeKind.Local);
            }
            else if (utcOffset.Ticks < 0)
            {
                if (Ticks + utcOffset.Ticks < MinValue.Ticks)
                    return SpecifyKind(MinValue, DateTimeKind.Local);
            }

            return new DateTime(ticks + utcOffset.Ticks, DateTimeKind.Local);
        }

        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent
        //     long date string representation.
        //
        // Returns:
        //     A string that contains the long date string representation of the current
        //     System.DateTime object.
        public string ToLongDateString()
        {
            return ToString("D");
        }
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent
        //     long time string representation.
        //
        // Returns:
        //     A string that contains the long time string representation of the current
        //     System.DateTime object.
        public string ToLongTimeString()
        {
            return ToString("T");
        }
        //
        // Summary:
        //     Converts the value of this instance to the equivalent OLE Automation date.
        //
        // Returns:
        //     A double-precision floating-point number that contains an OLE Automation
        //     date equivalent to the value of this instance.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The value of this instance cannot be represented as an OLE Automation Date.
        //public double ToOADate();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent
        //     short date string representation.
        //
        // Returns:
        //     A string that contains the short date string representation of the current
        //     System.DateTime object.
        public string ToShortDateString()
        {
            return ToString("d");
        }
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent
        //     short time string representation.
        //
        // Returns:
        //     A string that contains the short time string representation of the current
        //     System.DateTime object.
	    public string ToShortTimeString()
	    {
            return ToString("t");
	    }

	    //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent
        //     string representation using the specified format.
        //
        // Parameters:
        //   format:
        //     A standard or custom date and time format string (see Remarks).
        //
        // Returns:
        //     A string representation of value of the current System.DateTime object as
        //     specified by format.
        //
        // Exceptions:
        //   System.FormatException:
        //     The length of format is 1, and it is not one of the format specifier characters
        //     defined for System.Globalization.DateTimeFormatInfo.-or- format does not
        //     contain a valid custom format pattern.
        //
        //   System.ArgumentOutOfRangeException:
        //     The date and time is outside the range of dates supported by the calendar
        //     used by the current culture.
        public string ToString(string format)
        {
            return ToString(format, DateTimeFormatInfo.CurrentInfo);
        }
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent
        //     string representation using the specified format and culture-specific format
        //     information.
        //
        // Parameters:
        //   format:
        //     A standard or custom date and time format string.
        //
        //   provider:
        //     An object that supplies culture-specific formatting information.
        //
        // Returns:
        //     A string representation of value of the current System.DateTime object as
        //     specified by format and provider.
        //
        // Exceptions:
        //   System.FormatException:
        //     The length of format is 1, and it is not one of the format specifier characters
        //     defined for System.Globalization.DateTimeFormatInfo.-or- format does not
        //     contain a valid custom format pattern.
        //
        //   System.ArgumentOutOfRangeException:
        //     The date and time is outside the range of dates supported by the calendar
        //     used by provider.
        public string ToString(string format, IFormatProvider provider)
        {
            var f = DateFormatFactory.GetFormat(format, Kind, provider);
            f.Format.TimeZone = Kind == DateTimeKind.Utc 
                                ? Java.Util.TimeZone.GetTimeZone("UTC") 
                                : Java.Util.TimeZone.Default;
            return f.Format.Format(ToDate());
        }

        public override string ToString()
        {
            return ToString("G", null);
        }

        public string ToString(IFormatProvider provider)
        {
            return ToString("G", provider);
        }

        //
        // Summary:
        //     Converts the value of the current System.DateTime object to Coordinated Universal
        //     Time (UTC).
        //
        // Returns:
        //     An object whose System.DateTime.Kind property is System.DateTimeKind.Utc,
        //     and whose value is the UTC equivalent to the value of the current System.DateTime
        //     object, or System.DateTime.MaxValue if the converted value is too large to
        //     be represented by a System.DateTime object, or System.DateTime.MinValue if
        //     the converted value is too small to be represented by a System.DateTime object.
        public DateTime ToUniversalTime()
        {
            if (Kind == DateTimeKind.Utc)
                return this;

            var offset = TimeZoneInfo.Local.GetUtcOffset(ticks);

            if (offset.Ticks < 0)
            {
                if (MaxValue + offset < this)
                    return SpecifyKind(MaxValue, DateTimeKind.Utc);
            }
            else if (offset.Ticks > 0)
            {
                if (MinValue + offset > this)
                    return SpecifyKind(MinValue, DateTimeKind.Utc);
            }

            return new DateTime(ticks - offset.Ticks, DateTimeKind.Utc);
        }


        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent and returns a value that indicates whether the conversion succeeded.
        //
        // Parameters:
        //   s:
        //     A string containing a date and time to convert.
        //
        //   result:
        //     When this method returns, contains the System.DateTime value equivalent to
        //     the date and time contained in s, if the conversion succeeded, or System.DateTime.MinValue
        //     if the conversion failed. The conversion fails if the s parameter is null,
        //     is an empty string (""), or does not contain a valid string representation
        //     of a date and time. This parameter is passed uninitialized.
        //
        // Returns:
        //     true if the s parameter was converted successfully; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentOutOfRangeException:
        //     The date is in Japanese Emperor Year (Wareki) format and the year is out
        //     of range.
        public static bool TryParse(string s, out DateTime result)
        {
            return TryParse(s, null, DateTimeStyles.None, out result);
        }

        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles style, out DateTime result)
        {
            try
            {
                result = Parse(s, provider, style);
                return true;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch(FormatException)
            {
                throw;
            }
            catch(Exception)
            {
                result = MinValue;
                return false;
            }
        }

        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified culture-specific format information and formatting
        //     style, and returns a value that indicates whether the conversion succeeded.
        //
        // Parameters:
        //   s:
        //     A string containing a date and time to convert.
        //
        //   provider:
        //     An object that supplies culture-specific formatting information about s.
        //
        //   styles:
        //     A bitwise combination of enumeration values that defines how to interpret
        //     the parsed date in relation to the current time zone or the current date.
        //     A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        //   result:
        //     When this method returns, contains the System.DateTime value equivalent to
        //     the date and time contained in s, if the conversion succeeded, or System.DateTime.MinValue
        //     if the conversion failed. The conversion fails if the s parameter is null,
        //     is an empty string (""), or does not contain a valid string representation
        //     of a date and time. This parameter is passed uninitialized.
        //
        // Returns:
        //     true if the s parameter was converted successfully; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     styles is not a valid System.Globalization.DateTimeStyles value.-or-styles
        //     contains an invalid combination of System.Globalization.DateTimeStyles values
        //     (for example, both System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal).
        //
        //   System.ArgumentOutOfRangeException:
        //     The date is in Japanese Emperor Year (Wareki) format and the year is out
        //     of range.
        //
        //   System.NotSupportedException:
        //     provider is a neutral culture and cannot be used in a parsing operation.
        //public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified format, culture-specific format information,
        //     and style. The format of the string representation must match the specified
        //     format exactly. The method returns a value that indicates whether the conversion
        //     succeeded.
        //
        // Parameters:
        //   s:
        //     A string containing a date and time to convert.
        //
        //   format:
        //     The required format of s.
        //
        //   provider:
        //     An object that supplies culture-specific formatting information about s.
        //
        //   style:
        //     A bitwise combination of one or more enumeration values that indicate the
        //     permitted format of s.
        //
        //   result:
        //     When this method returns, contains the System.DateTime value equivalent to
        //     the date and time contained in s, if the conversion succeeded, or System.DateTime.MinValue
        //     if the conversion failed. The conversion fails if either the s or format
        //     parameter is null, is an empty string, or does not contain a date and time
        //     that correspond to the pattern specified in format. This parameter is passed
        //     uninitialized.
        //
        // Returns:
        //     true if s was converted successfully; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     styles is not a valid System.Globalization.DateTimeStyles value.-or-styles
        //     contains an invalid combination of System.Globalization.DateTimeStyles values
        //     (for example, both System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal).
	    public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
	    {
            try
            {
                result = ParseExact(s, format, provider, style);
                return true;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (FormatException)
            {
                throw;
            }
            catch(Exception ex)
            {
                result = MinValue;
                return false;
            }
	    }
        //
        // Summary:
        //     Converts the specified string representation of a date and time to its System.DateTime
        //     equivalent using the specified array of formats, culture-specific format
        //     information, and style. The format of the string representation must match
        //     at least one of the specified formats exactly. The method returns a value
        //     that indicates whether the conversion succeeded.
        //
        // Parameters:
        //   s:
        //     A string containing one or more dates and times to convert.
        //
        //   formats:
        //     An array of allowable formats of s.
        //
        //   provider:
        //     An object that supplies culture-specific format information about s.
        //
        //   style:
        //     A bitwise combination of enumeration values that indicates the permitted
        //     format of s. A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        //   result:
        //     When this method returns, contains the System.DateTime value equivalent to
        //     the date and time contained in s, if the conversion succeeded, or System.DateTime.MinValue
        //     if the conversion failed. The conversion fails if s or formats is null, s
        //     or an element of formats is an empty string, or the format of s is not exactly
        //     as specified by at least one of the format patterns in formats. This parameter
        //     is passed uninitialized.
        //
        // Returns:
        //     true if the s parameter was converted successfully; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     styles is not a valid System.Globalization.DateTimeStyles value.-or-styles
        //     contains an invalid combination of System.Globalization.DateTimeStyles values
        //     (for example, both System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal).
        //public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);

        /// <summary>
        /// Convert from DateTime to java Date.
        /// </summary>
        public Java.Util.Date ToDate()
        {
            long millis;

            // special handling for DateTime.MinValue, to avoid incorrect calculations
            // due to subtle differences in how dates are calculates in Java and C# (which
            // I don't entirely understand)

            if (ticks == 0)
            {
                millis = MinValueJavaMillies;
            }
            else
            {
                millis = (ticks/TimeSpan.TicksPerMillisecond) - EraDifferenceInMs;
            }
            long offsetInMs = (long)0;

            if (kind != DateTimeKind.Utc)
                offsetInMs = JavaGetOffsetInMs(millis);

            return new Date(millis - offsetInMs);
        }

        private Java.Util.Calendar GetCalendar()
        {
            var calender = new Java.Util.GregorianCalendar();

            if (ticks == 0)
            {
                // always use UTC for DateTime.MinValue, is this correct?
                calender.TimeZone = Java.Util.TimeZone.GetTimeZone("UTC");
                calender.TimeInMillis = MinValueJavaMillies;
            }
            else
            {
                var millis = (ticks/TimeSpan.TicksPerMillisecond) - EraDifferenceInMs;
                long offsetInMs = (long) 0;

                if (kind != DateTimeKind.Utc)
                {
                    offsetInMs = JavaGetOffsetInMs(millis);
                    calender.TimeZone = (Java.Util.TimeZone.Default);
                }
                else
                {
                    calender.TimeZone = (Java.Util.TimeZone.GetTimeZone("UTC"));
                }

                calender.TimeInMillis = (millis - offsetInMs);
            }
            return calender;
        }

        private static long JavaGetOffsetInMs(long millies)
        {
            return (long)Java.Util.TimeZone.Default.GetOffset(millies);
        }

        /// <summary>
        /// Convert from java based date to DateTime.
        /// </summary>
        public static DateTime FromDate(Date value, DateTimeKind kind)
        {
            return FromDate(value.Time, kind);
        }

        /// <summary>
        /// Convert from java based date to DateTime.
        /// </summary>value
        /// <param name="millis">milliseconds since Jan 1, 1970, midnight GMT</param>
        public static DateTime FromDate(long millis, DateTimeKind kind)
        {
            long offsetInMs = 0L;

            if (kind != DateTimeKind.Utc)
                offsetInMs = JavaGetOffsetInMs(millis);

            var ticks = ((millis + offsetInMs) + EraDifferenceInMs) * TimeSpan.TicksPerMillisecond;
            return new DateTime(ticks, kind);
        }
    }
}

