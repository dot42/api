// Copyright (C) 2014 dot42
//
// Original filename: Android.Text.Format.cs
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
#pragma warning disable 1717
namespace Android.Text.Format
{
		/// <summary>
		/// <para>An alternative to the java.util.Calendar and java.util.GregorianCalendar classes. An instance of the Time class represents a moment in time, specified with second precision. It is modelled after struct tm, and in fact, uses struct tm to implement most of the functionality. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/format/Time
		/// </java-name>
		[Dot42.DexImport("android/text/format/Time", AccessFlags = 33)]
		public partial class Time
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TIMEZONE_UTC
				/// </java-name>
				[Dot42.DexImport("TIMEZONE_UTC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TIMEZONE_UTC = "UTC";
				/// <summary>
				/// <para>The Julian day of the epoch, that is, January 1, 1970 on the Gregorian calendar. </para>        
				/// </summary>
				/// <java-name>
				/// EPOCH_JULIAN_DAY
				/// </java-name>
				[Dot42.DexImport("EPOCH_JULIAN_DAY", "I", AccessFlags = 25)]
				public const int EPOCH_JULIAN_DAY = 2440588;
				/// <summary>
				/// <para>The Julian day of the Monday in the week of the epoch, December 29, 1969 on the Gregorian calendar. </para>        
				/// </summary>
				/// <java-name>
				/// MONDAY_BEFORE_JULIAN_EPOCH
				/// </java-name>
				[Dot42.DexImport("MONDAY_BEFORE_JULIAN_EPOCH", "I", AccessFlags = 25)]
				public const int MONDAY_BEFORE_JULIAN_EPOCH = 2440585;
				/// <summary>
				/// <para>True if this is an allDay event. The hour, minute, second fields are all zero, and the date is displayed the same in all time zones. </para>        
				/// </summary>
				/// <java-name>
				/// allDay
				/// </java-name>
				[Dot42.DexImport("allDay", "Z", AccessFlags = 1)]
				public bool AllDay;
				/// <summary>
				/// <para>Seconds [0-61] (2 leap seconds allowed) </para>        
				/// </summary>
				/// <java-name>
				/// second
				/// </java-name>
				[Dot42.DexImport("second", "I", AccessFlags = 1)]
				public int Second;
				/// <summary>
				/// <para>Minute [0-59] </para>        
				/// </summary>
				/// <java-name>
				/// minute
				/// </java-name>
				[Dot42.DexImport("minute", "I", AccessFlags = 1)]
				public int Minute;
				/// <summary>
				/// <para>Hour of day [0-23] </para>        
				/// </summary>
				/// <java-name>
				/// hour
				/// </java-name>
				[Dot42.DexImport("hour", "I", AccessFlags = 1)]
				public int Hour;
				/// <summary>
				/// <para>Day of month [1-31] </para>        
				/// </summary>
				/// <java-name>
				/// monthDay
				/// </java-name>
				[Dot42.DexImport("monthDay", "I", AccessFlags = 1)]
				public int MonthDay;
				/// <summary>
				/// <para>Month [0-11] </para>        
				/// </summary>
				/// <java-name>
				/// month
				/// </java-name>
				[Dot42.DexImport("month", "I", AccessFlags = 1)]
				public int Month;
				/// <summary>
				/// <para>Year. For example, 1970. </para>        
				/// </summary>
				/// <java-name>
				/// year
				/// </java-name>
				[Dot42.DexImport("year", "I", AccessFlags = 1)]
				public int Year;
				/// <summary>
				/// <para>Day of week [0-6] </para>        
				/// </summary>
				/// <java-name>
				/// weekDay
				/// </java-name>
				[Dot42.DexImport("weekDay", "I", AccessFlags = 1)]
				public int WeekDay;
				/// <summary>
				/// <para>Day of year [0-365] </para>        
				/// </summary>
				/// <java-name>
				/// yearDay
				/// </java-name>
				[Dot42.DexImport("yearDay", "I", AccessFlags = 1)]
				public int YearDay;
				/// <summary>
				/// <para>This time is in daylight savings time. One of: <ul><li><para><b>positive</b> - in dst </para></li><li><para><b>0</b> - not in dst </para></li><li><para><b>negative</b> - unknown </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// isDst
				/// </java-name>
				[Dot42.DexImport("isDst", "I", AccessFlags = 1)]
				public int IsDst;
				/// <summary>
				/// <para>Offset from UTC (in seconds). </para>        
				/// </summary>
				/// <java-name>
				/// gmtoff
				/// </java-name>
				[Dot42.DexImport("gmtoff", "J", AccessFlags = 1)]
				public long Gmtoff;
				/// <summary>
				/// <para>The timezone for this Time. Should not be null. </para>        
				/// </summary>
				/// <java-name>
				/// timezone
				/// </java-name>
				[Dot42.DexImport("timezone", "Ljava/lang/String;", AccessFlags = 1)]
				public string Timezone;
				/// <java-name>
				/// SECOND
				/// </java-name>
				[Dot42.DexImport("SECOND", "I", AccessFlags = 25)]
				public const int SECOND = 1;
				/// <java-name>
				/// MINUTE
				/// </java-name>
				[Dot42.DexImport("MINUTE", "I", AccessFlags = 25)]
				public const int MINUTE = 2;
				/// <java-name>
				/// HOUR
				/// </java-name>
				[Dot42.DexImport("HOUR", "I", AccessFlags = 25)]
				public const int HOUR = 3;
				/// <java-name>
				/// MONTH_DAY
				/// </java-name>
				[Dot42.DexImport("MONTH_DAY", "I", AccessFlags = 25)]
				public const int MONTH_DAY = 4;
				/// <java-name>
				/// MONTH
				/// </java-name>
				[Dot42.DexImport("MONTH", "I", AccessFlags = 25)]
				public const int MONTH = 5;
				/// <java-name>
				/// YEAR
				/// </java-name>
				[Dot42.DexImport("YEAR", "I", AccessFlags = 25)]
				public const int YEAR = 6;
				/// <java-name>
				/// WEEK_DAY
				/// </java-name>
				[Dot42.DexImport("WEEK_DAY", "I", AccessFlags = 25)]
				public const int WEEK_DAY = 7;
				/// <java-name>
				/// YEAR_DAY
				/// </java-name>
				[Dot42.DexImport("YEAR_DAY", "I", AccessFlags = 25)]
				public const int YEAR_DAY = 8;
				/// <java-name>
				/// WEEK_NUM
				/// </java-name>
				[Dot42.DexImport("WEEK_NUM", "I", AccessFlags = 25)]
				public const int WEEK_NUM = 9;
				/// <java-name>
				/// SUNDAY
				/// </java-name>
				[Dot42.DexImport("SUNDAY", "I", AccessFlags = 25)]
				public const int SUNDAY = 0;
				/// <java-name>
				/// MONDAY
				/// </java-name>
				[Dot42.DexImport("MONDAY", "I", AccessFlags = 25)]
				public const int MONDAY = 1;
				/// <java-name>
				/// TUESDAY
				/// </java-name>
				[Dot42.DexImport("TUESDAY", "I", AccessFlags = 25)]
				public const int TUESDAY = 2;
				/// <java-name>
				/// WEDNESDAY
				/// </java-name>
				[Dot42.DexImport("WEDNESDAY", "I", AccessFlags = 25)]
				public const int WEDNESDAY = 3;
				/// <java-name>
				/// THURSDAY
				/// </java-name>
				[Dot42.DexImport("THURSDAY", "I", AccessFlags = 25)]
				public const int THURSDAY = 4;
				/// <java-name>
				/// FRIDAY
				/// </java-name>
				[Dot42.DexImport("FRIDAY", "I", AccessFlags = 25)]
				public const int FRIDAY = 5;
				/// <java-name>
				/// SATURDAY
				/// </java-name>
				[Dot42.DexImport("SATURDAY", "I", AccessFlags = 25)]
				public const int SATURDAY = 6;
				/// <summary>
				/// <para>A copy constructor. Construct a Time object by copying the given Time object. No normalization occurs.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Time(string other) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a Time object in the default timezone. The time is initialized to Jan 1, 1970. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Time() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A copy constructor. Construct a Time object by copying the given Time object. No normalization occurs.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/text/format/Time;)V", AccessFlags = 1)]
				public Time(global::Android.Text.Format.Time other) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Ensures the values in each field are in range. For example if the current value of this calendar is March 32, normalize() will convert it to April 1. It also fills in weekDay, yearDay, isDst and gmtoff.</para><para>If "ignoreDst" is true, then this method sets the "isDst" field to -1 (the "unknown" value) before normalizing. It then computes the correct value for "isDst".</para><para>See toMillis(boolean) for more information about when to use <code>true</code> or <code>false</code> for "ignoreDst".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the UTC milliseconds since the epoch </para>
				/// </returns>
				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "(Z)J", AccessFlags = 257)]
				public virtual long Normalize(bool ignoreDst) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Convert this time object so the time represented remains the same, but is instead located in a different timezone. This method automatically calls normalize() in some cases </para>        
				/// </summary>
				/// <java-name>
				/// switchTimezone
				/// </java-name>
				[Dot42.DexImport("switchTimezone", "(Ljava/lang/String;)V", AccessFlags = 257)]
				public virtual void SwitchTimezone(string timezone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the maximum possible value for the given field given the value of the other fields. Requires that it be normalized for MONTH_DAY and YEAR_DAY. </para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum value for the field. </para>
				/// </returns>
				/// <java-name>
				/// getActualMaximum
				/// </java-name>
				[Dot42.DexImport("getActualMaximum", "(I)I", AccessFlags = 1)]
				public virtual int GetActualMaximum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Clears all values, setting the timezone to the given timezone. Sets isDst to a negative value to mean "unknown". </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Clear(string timezone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compare two <c> Time </c> objects and return a negative number if <c>       a </c> is less than <c> b </c> , a positive number if <c> a </c> is greater than <c> b </c> , or 0 if they are equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative result if <c> a </c> is earlier, a positive result if <c> a </c> is earlier, or 0 if they are equal. </para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I", AccessFlags = 9)]
				public static int Compare(global::Android.Text.Format.Time a, global::Android.Text.Format.Time b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Print the current value given the format string provided. See man strftime for what means what. The final string must be less than 256 characters. </para>        
				/// </summary>
				/// <returns>
				/// <para>a String containing the current time expressed in the current locale. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Format(string format) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the current time in YYYYMMDDTHHMMSS&lt;tz&gt; format </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 257)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses a date-time string in either the RFC 2445 format or an abbreviated format that does not include the "time" field. For example, all of the following strings are valid:</para><para><ul><li><para>"20081013T160000Z" </para></li><li><para>"20081013T160000" </para></li><li><para>"20081013" </para></li></ul></para><para>Returns whether or not the time is in UTC (ends with Z). If the string ends with "Z" then the timezone is set to UTC. If the date-time string included only a date and no time field, then the <code>allDay</code> field of this Time class is set to true and the <code>hour</code>, <code>minute</code>, and <code>second</code> fields are set to zero; otherwise (a time field was included in the date-time string) <code>allDay</code> is set to false. The fields <code>weekDay</code>, <code>yearDay</code>, and <code>gmtoff</code> are always set to zero, and the field <code>isDst</code> is set to -1 (unknown). To set those fields, call normalize(boolean) after parsing.</para><para>To parse a date-time string and convert it to UTC milliseconds, do something like this:</para><para><pre>
				///          Time time = new Time();
				///          String date = "20081013T160000Z";
				///          time.parse(date);
				///          long millis = time.normalize(false);
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the resulting time value is in UTC time </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Parse(string s) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Parse a time in RFC 3339 format. This method also parses simple dates (that is, strings that contain no time or time offset). For example, all of the following strings are valid:</para><para><ul><li><para>"2008-10-13T16:00:00.000Z" </para></li><li><para>"2008-10-13T16:00:00.000+07:00" </para></li><li><para>"2008-10-13T16:00:00.000-07:00" </para></li><li><para>"2008-10-13" </para></li></ul></para><para>If the string contains a time and time offset, then the time offset will be used to convert the time value to UTC. </para><para>If the given string contains just a date (with no time field), then the allDay field is set to true and the hour, minute, and second fields are set to zero. </para><para>Returns true if the resulting time value is in UTC time. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the resulting time value is in UTC time </para>
				/// </returns>
				/// <java-name>
				/// parse3339
				/// </java-name>
				[Dot42.DexImport("parse3339", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Parse3339(string s) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the timezone string that is currently set for the device. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentTimezone
				/// </java-name>
				[Dot42.DexImport("getCurrentTimezone", "()Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCurrentTimezone() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the time of the given Time object to the current time. </para>        
				/// </summary>
				/// <java-name>
				/// setToNow
				/// </java-name>
				[Dot42.DexImport("setToNow", "()V", AccessFlags = 257)]
				public virtual void SetToNow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts this time to milliseconds. Suitable for interacting with the standard java libraries. The time is in UTC milliseconds since the epoch. This does an implicit normalization to compute the milliseconds but does <b>not</b> change any of the fields in this Time object. If you want to normalize the fields in this Time object and also get the milliseconds then use normalize(boolean).</para><para>If "ignoreDst" is false, then this method uses the current setting of the "isDst" field and will adjust the returned time if the "isDst" field is wrong for the given time. See the sample code below for an example of this.</para><para>If "ignoreDst" is true, then this method ignores the current setting of the "isDst" field in this Time object and will instead figure out the correct value of "isDst" (as best it can) from the fields in this Time object. The only case where this method cannot figure out the correct value of the "isDst" field is when the time is inherently ambiguous because it falls in the hour that is repeated when switching from Daylight-Saving Time to Standard Time.</para><para>Here is an example where <code>toMillis(true)</code> adjusts the time, assuming that DST changes at 2am on Sunday, Nov 4, 2007.</para><para><pre>
				///        Time time = new Time();
				///        time.set(4, 10, 2007);  // set the date to Nov 4, 2007, 12am
				///        time.normalize();       // this sets isDst = 1
				///        time.monthDay += 1;     // changes the date to Nov 5, 2007, 12am
				///        millis = time.toMillis(false);   // millis is Nov 4, 2007, 11pm
				///        millis = time.toMillis(true);    // millis is Nov 5, 2007, 12am
				///        </pre></para><para>To avoid this problem, use <code>toMillis(true)</code> after adding or subtracting days or explicitly setting the "monthDay" field. On the other hand, if you are adding or subtracting hours or minutes, then you should use <code>toMillis(false)</code>.</para><para>You should also use <code>toMillis(false)</code> if you want to read back the same milliseconds that you set with set(long) or set(Time) or after parsing a date string. </para>        
				/// </summary>
				/// <java-name>
				/// toMillis
				/// </java-name>
				[Dot42.DexImport("toMillis", "(Z)J", AccessFlags = 257)]
				public virtual long ToMillis(bool ignoreDst) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Copy the value of that to this Time object. No normalization happens. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(J)V", AccessFlags = 257)]
				public virtual void Set(long that) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Format according to RFC 2445 DATETIME type.</para><para>The same as format("%Y%m%dT%H%M%S"). </para>        
				/// </summary>
				/// <java-name>
				/// format2445
				/// </java-name>
				[Dot42.DexImport("format2445", "()Ljava/lang/String;", AccessFlags = 257)]
				public virtual string Format2445() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Copy the value of that to this Time object. No normalization happens. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/text/format/Time;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Text.Format.Time that) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the fields. Sets weekDay, yearDay and gmtoff to 0, and isDst to -1. Call normalize(boolean) if you need those. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIIIII)V", AccessFlags = 1)]
				public virtual void Set(int second, int minute, int hour, int monthDay, int month, int year) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the date from the given fields. Also sets allDay to true. Sets weekDay, yearDay and gmtoff to 0, and isDst to -1. Call normalize(boolean) if you need those.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(III)V", AccessFlags = 1)]
				public virtual void Set(int monthDay, int month, int year) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if the time represented by this Time object occurs before the given time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this time is less than the given time </para>
				/// </returns>
				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Landroid/text/format/Time;)Z", AccessFlags = 1)]
				public virtual bool Before(global::Android.Text.Format.Time that) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the time represented by this Time object occurs after the given time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this time is greater than the given time </para>
				/// </returns>
				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Landroid/text/format/Time;)Z", AccessFlags = 1)]
				public virtual bool After(global::Android.Text.Format.Time that) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the week number according to ISO 8601. The current Time object must already be normalized because this method uses the yearDay and weekDay fields.</para><para>In IS0 8601, weeks start on Monday. The first week of the year (week 1) is defined by ISO 8601 as the first week with four or more of its days in the starting year. Or equivalently, the week containing January 4. Or equivalently, the week with the year's first Thursday in it. </para><para>The week number can be calculated by counting Thursdays. Week N contains the Nth Thursday of the year. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ISO week number. </para>
				/// </returns>
				/// <java-name>
				/// getWeekNumber
				/// </java-name>
				[Dot42.DexImport("getWeekNumber", "()I", AccessFlags = 1)]
				public virtual int GetWeekNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a string in the RFC 3339 format. </para><para>If allDay is true, expresses the time as Y-M-D</para><para>Otherwise, if the timezone is UTC, expresses the time as Y-M-D-T-H-M-S UTC</para><para>Otherwise the time is expressed the time as Y-M-D-T-H-M-S +- GMT</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>string in the RFC 3339 format. </para>
				/// </returns>
				/// <java-name>
				/// format3339
				/// </java-name>
				[Dot42.DexImport("format3339", "(Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Format3339(bool allDay) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns true if the day of the given time is the epoch on the Julian Calendar (January 1, 1970 on the Gregorian calendar).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if epoch. </para>
				/// </returns>
				/// <java-name>
				/// isEpoch
				/// </java-name>
				[Dot42.DexImport("isEpoch", "(Landroid/text/format/Time;)Z", AccessFlags = 9)]
				public static bool IsEpoch(global::Android.Text.Format.Time time) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the Julian day number, given the UTC milliseconds and the offset (in seconds) from UTC. The Julian day for a given date will be the same for every timezone. For example, the Julian day for July 1, 2008 is 2454649. This is the same value no matter what timezone is being used. The Julian day is useful for testing if two events occur on the same day and for determining the relative time of an event from the present ("yesterday", "3 days ago", etc.).</para><para>Use toMillis(boolean) to get the milliseconds.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Julian day </para>
				/// </returns>
				/// <java-name>
				/// getJulianDay
				/// </java-name>
				[Dot42.DexImport("getJulianDay", "(JJ)I", AccessFlags = 9)]
				public static int GetJulianDay(long millis, long gmtoff) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the time from the given Julian day number, which must be based on the same timezone that is set in this Time object. The "gmtoff" field need not be initialized because the given Julian day may have a different GMT offset than whatever is currently stored in this Time object anyway. After this method returns all the fields will be normalized and the time will be set to 12am at the beginning of the given Julian day. </para><para>The only exception to this is if 12am does not exist for that day because of daylight saving time. For example, Cairo, Eqypt moves time ahead one hour at 12am on April 25, 2008 and there are a few other places that also change daylight saving time at 12am. In those cases, the time will be set to 1am. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the UTC milliseconds for the beginning of the Julian day </para>
				/// </returns>
				/// <java-name>
				/// setJulianDay
				/// </java-name>
				[Dot42.DexImport("setJulianDay", "(I)J", AccessFlags = 1)]
				public virtual long SetJulianDay(int julianDay) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the week since EPOCH_JULIAN_DAY (Jan 1, 1970) adjusted for first day of week. This takes a julian day and the week start day and calculates which week since EPOCH_JULIAN_DAY that day occurs in, starting at 0. <b>Do not</b> use this to compute the ISO week number for the year.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Weeks since the epoch </para>
				/// </returns>
				/// <java-name>
				/// getWeeksSinceEpochFromJulianDay
				/// </java-name>
				[Dot42.DexImport("getWeeksSinceEpochFromJulianDay", "(II)I", AccessFlags = 9)]
				public static int GetWeeksSinceEpochFromJulianDay(int julianDay, int firstDayOfWeek) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Takes a number of weeks since the epoch and calculates the Julian day of the Monday for that week. This assumes that the week containing the EPOCH_JULIAN_DAY is considered week 0. It returns the Julian day for the Monday week weeks after the Monday of the week containing the epoch.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The julian day for the Monday of the given week since the epoch </para>
				/// </returns>
				/// <java-name>
				/// getJulianMondayFromWeeksSinceEpoch
				/// </java-name>
				[Dot42.DexImport("getJulianMondayFromWeeksSinceEpoch", "(I)I", AccessFlags = 9)]
				public static int GetJulianMondayFromWeeksSinceEpoch(int week) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the timezone string that is currently set for the device. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentTimezone
				/// </java-name>
				public static string CurrentTimezone
				{
				[Dot42.DexImport("getCurrentTimezone", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return GetCurrentTimezone(); }
				}

				/// <summary>
				/// <para>Computes the week number according to ISO 8601. The current Time object must already be normalized because this method uses the yearDay and weekDay fields.</para><para>In IS0 8601, weeks start on Monday. The first week of the year (week 1) is defined by ISO 8601 as the first week with four or more of its days in the starting year. Or equivalently, the week containing January 4. Or equivalently, the week with the year's first Thursday in it. </para><para>The week number can be calculated by counting Thursdays. Week N contains the Nth Thursday of the year. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ISO week number. </para>
				/// </returns>
				/// <java-name>
				/// getWeekNumber
				/// </java-name>
				public int WeekNumber
				{
				[Dot42.DexImport("getWeekNumber", "()I", AccessFlags = 1)]
						get{ return GetWeekNumber(); }
				}

		}

		/// <summary>
		/// <para>Utility class for producing strings with formatted date/time.</para><para>Most callers should avoid supplying their own format strings to this class' <c> format </c> methods and rely on the correctly localized ones supplied by the system. This class' factory methods return appropriately-localized java.text.DateFormat instances, suitable for both formatting and parsing dates. For the canonical documentation of format strings, see java.text.SimpleDateFormat.</para><para>In cases where the system does not provide a suitable pattern, this class offers the getBestDateTimePattern method.</para><para>The <c> format </c> methods in this class implement a subset of Unicode  patterns. The subset currently supported by this class includes the following format characters: <c> acdEHhLKkLMmsyz </c> . Up to API level 17, only <c> adEhkMmszy </c> were supported. Note that this class incorrectly implements <c> k </c> as if it were <c> H </c> for backwards compatibility.</para><para>See java.text.SimpleDateFormat for more documentation about patterns, or if you need a more complete or correct implementation. Note that the non-<c> format </c> methods in this class are implemented by <c> SimpleDateFormat </c> . </para>    
		/// </summary>
		/// <java-name>
		/// android/text/format/DateFormat
		/// </java-name>
		[Dot42.DexImport("android/text/format/DateFormat", AccessFlags = 33)]
		public partial class DateFormat
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> ' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// QUOTE
				/// </java-name>
				[Dot42.DexImport("QUOTE", "C", AccessFlags = 25)]
				public const char QUOTE = '\'';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'a' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// AM_PM
				/// </java-name>
				[Dot42.DexImport("AM_PM", "C", AccessFlags = 25)]
				public const char AM_PM = 'a';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'a' </c> instead; 'A' was always equivalent to 'a'. </para>        
				/// </summary>
				/// <java-name>
				/// CAPITAL_AM_PM
				/// </java-name>
				[Dot42.DexImport("CAPITAL_AM_PM", "C", AccessFlags = 25)]
				public const char CAPITAL_AM_PM = 'A';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'd' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "C", AccessFlags = 25)]
				public const char DATE = 'd';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'E' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// DAY
				/// </java-name>
				[Dot42.DexImport("DAY", "C", AccessFlags = 25)]
				public const char DAY = 'E';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'h' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// HOUR
				/// </java-name>
				[Dot42.DexImport("HOUR", "C", AccessFlags = 25)]
				public const char HOUR = 'h';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'H' </c> (for compatibility with SimpleDateFormat and Unicode) or <c> 'k' </c> (for compatibility with Android releases up to and including Jelly Bean MR-1) instead. Note that the two are incompatible. </para>        
				/// </summary>
				/// <java-name>
				/// HOUR_OF_DAY
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY", "C", AccessFlags = 25)]
				public const char HOUR_OF_DAY = 'k';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'm' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// MINUTE
				/// </java-name>
				[Dot42.DexImport("MINUTE", "C", AccessFlags = 25)]
				public const char MINUTE = 'm';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'M' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// MONTH
				/// </java-name>
				[Dot42.DexImport("MONTH", "C", AccessFlags = 25)]
				public const char MONTH = 'M';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'L' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// STANDALONE_MONTH
				/// </java-name>
				[Dot42.DexImport("STANDALONE_MONTH", "C", AccessFlags = 25)]
				public const char STANDALONE_MONTH = 'L';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 's' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// SECONDS
				/// </java-name>
				[Dot42.DexImport("SECONDS", "C", AccessFlags = 25)]
				public const char SECONDS = 's';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'z' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// TIME_ZONE
				/// </java-name>
				[Dot42.DexImport("TIME_ZONE", "C", AccessFlags = 25)]
				public const char TIME_ZONE = 'z';
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use a literal</para></xrefdescription></xrefsect><c> 'y' </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// YEAR
				/// </java-name>
				[Dot42.DexImport("YEAR", "C", AccessFlags = 25)]
				public const char YEAR = 'y';
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if user preference is set to 24-hour format. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if 24 hour time format is selected, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// is24HourFormat
				/// </java-name>
				[Dot42.DexImport("is24HourFormat", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool Is24HourFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a java.text.DateFormat object that can format the time according to the current locale and the user's 12-/24-hour clock preference. </para>        
				/// </summary>
				/// <returns>
				/// <para>the java.text.DateFormat object that properly formats the time. </para>
				/// </returns>
				/// <java-name>
				/// getTimeFormat
				/// </java-name>
				[Dot42.DexImport("getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 9)]
				public static global::Java.Text.DateFormat GetTimeFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a java.text.DateFormat object that can format the date in short form (such as 12/31/1999) according to the current locale and the user's date-order preference. </para>        
				/// </summary>
				/// <returns>
				/// <para>the java.text.DateFormat object that properly formats the date. </para>
				/// </returns>
				/// <java-name>
				/// getDateFormat
				/// </java-name>
				[Dot42.DexImport("getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 9)]
				public static global::Java.Text.DateFormat GetDateFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a java.text.DateFormat object that can format the date in long form (such as <c> Monday, January 3, 2000 </c> ) for the current locale. </para>        
				/// </summary>
				/// <returns>
				/// <para>the java.text.DateFormat object that formats the date in long form. </para>
				/// </returns>
				/// <java-name>
				/// getLongDateFormat
				/// </java-name>
				[Dot42.DexImport("getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 9)]
				public static global::Java.Text.DateFormat GetLongDateFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a java.text.DateFormat object that can format the date in medium form (such as <c> Jan 3, 2000 </c> ) for the current locale. </para>        
				/// </summary>
				/// <returns>
				/// <para>the java.text.DateFormat object that formats the date in long form. </para>
				/// </returns>
				/// <java-name>
				/// getMediumDateFormat
				/// </java-name>
				[Dot42.DexImport("getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 9)]
				public static global::Java.Text.DateFormat GetMediumDateFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Gets the current date format stored as a char array. The array will contain 3 elements (DATE, MONTH, and YEAR) in the order specified by the user's format preference. Note that this order is <b>only</b> appropriate for all-numeric dates; spelled-out (MEDIUM and LONG) dates will generally contain other punctuation, spaces, or words, not just the day, month, and year, and not necessarily in the same order returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getDateFormatOrder
				/// </java-name>
				[Dot42.DexImport("getDateFormatOrder", "(Landroid/content/Context;)[C", AccessFlags = 9)]
				public static char[] GetDateFormatOrder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Format(global::Java.Lang.ICharSequence charSequence, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Format(global::Java.Lang.ICharSequence charSequence, global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Format(global::Java.Lang.ICharSequence charSequence, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

		/// <summary>
		/// <para>Utility class to aid in formatting common values that are not covered by the java.util.Formatter class in java.util </para>    
		/// </summary>
		/// <java-name>
		/// android/text/format/Formatter
		/// </java-name>
		[Dot42.DexImport("android/text/format/Formatter", AccessFlags = 49)]
		public sealed partial class Formatter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Formatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Formats a content size to be in the form of bytes, kilobytes, megabytes, etc</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>formatted string with the number </para>
				/// </returns>
				/// <java-name>
				/// formatFileSize
				/// </java-name>
				[Dot42.DexImport("formatFileSize", "(Landroid/content/Context;J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatFileSize(global::Android.Content.Context context, long number) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Like formatFileSize, but trying to generate shorter numbers (showing fewer digits of precision). </para>        
				/// </summary>
				/// <java-name>
				/// formatShortFileSize
				/// </java-name>
				[Dot42.DexImport("formatShortFileSize", "(Landroid/content/Context;J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatShortFileSize(global::Android.Content.Context context, long number) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string in the canonical IPv4 format ###.###.###.### from a packed integer containing the IP address. The IPv4 address is expected to be in little-endian format (LSB first). That is, 0x01020304 will return "4.3.2.1".</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.net.InetAddress#getHostAddress(), which supports both IPv4 and IPv6 addresses. This method does not support IPv6 addresses. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// formatIpAddress
				/// </java-name>
				[Dot42.DexImport("formatIpAddress", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatIpAddress(int ipv4Address) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>This class contains various date-related utilities for creating text for things like elapsed time and date ranges, strings for days of the week and months, and AM/PM text etc. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/format/DateUtils
		/// </java-name>
		[Dot42.DexImport("android/text/format/DateUtils", AccessFlags = 33)]
		public partial class DateUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SECOND_IN_MILLIS
				/// </java-name>
				[Dot42.DexImport("SECOND_IN_MILLIS", "J", AccessFlags = 25)]
				public const long SECOND_IN_MILLIS = 1000;
				/// <java-name>
				/// MINUTE_IN_MILLIS
				/// </java-name>
				[Dot42.DexImport("MINUTE_IN_MILLIS", "J", AccessFlags = 25)]
				public const long MINUTE_IN_MILLIS = 60000;
				/// <java-name>
				/// HOUR_IN_MILLIS
				/// </java-name>
				[Dot42.DexImport("HOUR_IN_MILLIS", "J", AccessFlags = 25)]
				public const long HOUR_IN_MILLIS = 3600000;
				/// <java-name>
				/// DAY_IN_MILLIS
				/// </java-name>
				[Dot42.DexImport("DAY_IN_MILLIS", "J", AccessFlags = 25)]
				public const long DAY_IN_MILLIS = 86400000;
				/// <java-name>
				/// WEEK_IN_MILLIS
				/// </java-name>
				[Dot42.DexImport("WEEK_IN_MILLIS", "J", AccessFlags = 25)]
				public const long WEEK_IN_MILLIS = 604800000;
				/// <summary>
				/// <para>This constant is actually the length of 364 days, not of a year! </para>        
				/// </summary>
				/// <java-name>
				/// YEAR_IN_MILLIS
				/// </java-name>
				[Dot42.DexImport("YEAR_IN_MILLIS", "J", AccessFlags = 25)]
				public const long YEAR_IN_MILLIS = 31449600000;
				/// <java-name>
				/// FORMAT_SHOW_TIME
				/// </java-name>
				[Dot42.DexImport("FORMAT_SHOW_TIME", "I", AccessFlags = 25)]
				public const int FORMAT_SHOW_TIME = 1;
				/// <java-name>
				/// FORMAT_SHOW_WEEKDAY
				/// </java-name>
				[Dot42.DexImport("FORMAT_SHOW_WEEKDAY", "I", AccessFlags = 25)]
				public const int FORMAT_SHOW_WEEKDAY = 2;
				/// <java-name>
				/// FORMAT_SHOW_YEAR
				/// </java-name>
				[Dot42.DexImport("FORMAT_SHOW_YEAR", "I", AccessFlags = 25)]
				public const int FORMAT_SHOW_YEAR = 4;
				/// <java-name>
				/// FORMAT_NO_YEAR
				/// </java-name>
				[Dot42.DexImport("FORMAT_NO_YEAR", "I", AccessFlags = 25)]
				public const int FORMAT_NO_YEAR = 8;
				/// <java-name>
				/// FORMAT_SHOW_DATE
				/// </java-name>
				[Dot42.DexImport("FORMAT_SHOW_DATE", "I", AccessFlags = 25)]
				public const int FORMAT_SHOW_DATE = 16;
				/// <java-name>
				/// FORMAT_NO_MONTH_DAY
				/// </java-name>
				[Dot42.DexImport("FORMAT_NO_MONTH_DAY", "I", AccessFlags = 25)]
				public const int FORMAT_NO_MONTH_DAY = 32;
				/// <java-name>
				/// FORMAT_12HOUR
				/// </java-name>
				[Dot42.DexImport("FORMAT_12HOUR", "I", AccessFlags = 25)]
				public const int FORMAT_12HOUR = 64;
				/// <java-name>
				/// FORMAT_24HOUR
				/// </java-name>
				[Dot42.DexImport("FORMAT_24HOUR", "I", AccessFlags = 25)]
				public const int FORMAT_24HOUR = 128;
				/// <java-name>
				/// FORMAT_CAP_AMPM
				/// </java-name>
				[Dot42.DexImport("FORMAT_CAP_AMPM", "I", AccessFlags = 25)]
				public const int FORMAT_CAP_AMPM = 256;
				/// <java-name>
				/// FORMAT_NO_NOON
				/// </java-name>
				[Dot42.DexImport("FORMAT_NO_NOON", "I", AccessFlags = 25)]
				public const int FORMAT_NO_NOON = 512;
				/// <java-name>
				/// FORMAT_CAP_NOON
				/// </java-name>
				[Dot42.DexImport("FORMAT_CAP_NOON", "I", AccessFlags = 25)]
				public const int FORMAT_CAP_NOON = 1024;
				/// <java-name>
				/// FORMAT_NO_MIDNIGHT
				/// </java-name>
				[Dot42.DexImport("FORMAT_NO_MIDNIGHT", "I", AccessFlags = 25)]
				public const int FORMAT_NO_MIDNIGHT = 2048;
				/// <java-name>
				/// FORMAT_CAP_MIDNIGHT
				/// </java-name>
				[Dot42.DexImport("FORMAT_CAP_MIDNIGHT", "I", AccessFlags = 25)]
				public const int FORMAT_CAP_MIDNIGHT = 4096;
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use formatDateRange and pass in Time.TIMEZONE_UTC for the timeZone instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UTC
				/// </java-name>
				[Dot42.DexImport("FORMAT_UTC", "I", AccessFlags = 25)]
				public const int FORMAT_UTC = 8192;
				/// <java-name>
				/// FORMAT_ABBREV_TIME
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABBREV_TIME", "I", AccessFlags = 25)]
				public const int FORMAT_ABBREV_TIME = 16384;
				/// <java-name>
				/// FORMAT_ABBREV_WEEKDAY
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABBREV_WEEKDAY", "I", AccessFlags = 25)]
				public const int FORMAT_ABBREV_WEEKDAY = 32768;
				/// <java-name>
				/// FORMAT_ABBREV_MONTH
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABBREV_MONTH", "I", AccessFlags = 25)]
				public const int FORMAT_ABBREV_MONTH = 65536;
				/// <java-name>
				/// FORMAT_NUMERIC_DATE
				/// </java-name>
				[Dot42.DexImport("FORMAT_NUMERIC_DATE", "I", AccessFlags = 25)]
				public const int FORMAT_NUMERIC_DATE = 131072;
				/// <java-name>
				/// FORMAT_ABBREV_RELATIVE
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABBREV_RELATIVE", "I", AccessFlags = 25)]
				public const int FORMAT_ABBREV_RELATIVE = 262144;
				/// <java-name>
				/// FORMAT_ABBREV_ALL
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABBREV_ALL", "I", AccessFlags = 25)]
				public const int FORMAT_ABBREV_ALL = 524288;
				/// <java-name>
				/// FORMAT_CAP_NOON_MIDNIGHT
				/// </java-name>
				[Dot42.DexImport("FORMAT_CAP_NOON_MIDNIGHT", "I", AccessFlags = 25)]
				public const int FORMAT_CAP_NOON_MIDNIGHT = 5120;
				/// <java-name>
				/// FORMAT_NO_NOON_MIDNIGHT
				/// </java-name>
				[Dot42.DexImport("FORMAT_NO_NOON_MIDNIGHT", "I", AccessFlags = 25)]
				public const int FORMAT_NO_NOON_MIDNIGHT = 2560;
				/// <summary>
				/// <para>This is not actually the preferred 24-hour date format in all locales. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// HOUR_MINUTE_24
				/// </java-name>
				[Dot42.DexImport("HOUR_MINUTE_24", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HOUR_MINUTE_24 = "%H:%M";
				/// <java-name>
				/// MONTH_FORMAT
				/// </java-name>
				[Dot42.DexImport("MONTH_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MONTH_FORMAT = "%B";
				/// <summary>
				/// <para>This is not actually a useful month name in all locales. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ABBREV_MONTH_FORMAT
				/// </java-name>
				[Dot42.DexImport("ABBREV_MONTH_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ABBREV_MONTH_FORMAT = "%b";
				/// <java-name>
				/// NUMERIC_MONTH_FORMAT
				/// </java-name>
				[Dot42.DexImport("NUMERIC_MONTH_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NUMERIC_MONTH_FORMAT = "%m";
				/// <java-name>
				/// MONTH_DAY_FORMAT
				/// </java-name>
				[Dot42.DexImport("MONTH_DAY_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MONTH_DAY_FORMAT = "%-d";
				/// <java-name>
				/// YEAR_FORMAT
				/// </java-name>
				[Dot42.DexImport("YEAR_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string YEAR_FORMAT = "%Y";
				/// <java-name>
				/// YEAR_FORMAT_TWO_DIGITS
				/// </java-name>
				[Dot42.DexImport("YEAR_FORMAT_TWO_DIGITS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string YEAR_FORMAT_TWO_DIGITS = "%g";
				/// <java-name>
				/// WEEKDAY_FORMAT
				/// </java-name>
				[Dot42.DexImport("WEEKDAY_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WEEKDAY_FORMAT = "%A";
				/// <java-name>
				/// ABBREV_WEEKDAY_FORMAT
				/// </java-name>
				[Dot42.DexImport("ABBREV_WEEKDAY_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ABBREV_WEEKDAY_FORMAT = "%a";
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// sameYearTable
				/// </java-name>
				[Dot42.DexImport("sameYearTable", "[I", AccessFlags = 25)]
				public static readonly int[] SameYearTable;
				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// sameMonthTable
				/// </java-name>
				[Dot42.DexImport("sameMonthTable", "[I", AccessFlags = 25)]
				public static readonly int[] SameMonthTable;
				/// <summary>
				/// <para>Request the full spelled-out name. For use with the 'abbrev' parameter of getDayOfWeekString and getMonthString.</para><para>e.g. "Sunday" or "January" <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_LONG
				/// </java-name>
				[Dot42.DexImport("LENGTH_LONG", "I", AccessFlags = 25)]
				public const int LENGTH_LONG = 10;
				/// <summary>
				/// <para>Request an abbreviated version of the name. For use with the 'abbrev' parameter of getDayOfWeekString and getMonthString.</para><para>e.g. "Sun" or "Jan" <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_MEDIUM
				/// </java-name>
				[Dot42.DexImport("LENGTH_MEDIUM", "I", AccessFlags = 25)]
				public const int LENGTH_MEDIUM = 20;
				/// <summary>
				/// <para>Request a shorter abbreviated version of the name. For use with the 'abbrev' parameter of getDayOfWeekString and getMonthString.  </para><para>e.g. "Su" or "Jan" </para><para>In most languages, the results returned for LENGTH_SHORT will be the same as the results returned for LENGTH_MEDIUM. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_SHORT
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORT", "I", AccessFlags = 25)]
				public const int LENGTH_SHORT = 30;
				/// <summary>
				/// <para>Request an even shorter abbreviated version of the name. Do not use this. Currently this will always return the same result as LENGTH_SHORT. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_SHORTER
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORTER", "I", AccessFlags = 25)]
				public const int LENGTH_SHORTER = 40;
				/// <summary>
				/// <para>Request an even shorter abbreviated version of the name. For use with the 'abbrev' parameter of getDayOfWeekString and getMonthString.  </para><para>e.g. "S", "T", "T" or "J" </para><para>In some languages, the results returned for LENGTH_SHORTEST will be the same as the results returned for LENGTH_SHORT. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_SHORTEST
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORTEST", "I", AccessFlags = 25)]
				public const int LENGTH_SHORTEST = 50;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a string for the day of the week. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getDayOfWeekString
				/// </java-name>
				[Dot42.DexImport("getDayOfWeekString", "(II)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetDayOfWeekString(int dayOfWeek, int abbrev) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return a localized string for AM or PM. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>Localized version of "AM" or "PM". </para>
				/// </returns>
				/// <java-name>
				/// getAMPMString
				/// </java-name>
				[Dot42.DexImport("getAMPMString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAMPMString(int ampm) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return a localized string for the month of the year. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use java.text.SimpleDateFormat instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>Localized month of the year. </para>
				/// </returns>
				/// <java-name>
				/// getMonthString
				/// </java-name>
				[Dot42.DexImport("getMonthString", "(II)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetMonthString(int month, int abbrev) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string describing the elapsed time since startTime. <para>getRelativeTimeSpanString(long, long, long) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a String object containing the elapsed time. </para>
				/// </returns>
				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(J)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(long startTime) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(JJJ)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(long int64, long int641, long int642) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Returns a string describing 'time' as a time relative to 'now'. </para><para>Time spans in the past are formatted like "42 minutes ago". Time spans in the future are formatted like "in 42 minutes". </para><para>Can use FORMAT_ABBREV_RELATIVE flag to use abbreviated relative times, like "42 mins ago".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(JJJI)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(long time, long now, long minResolution, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Return string describing the elapsed time since startTime formatted like "[relative time/date], [time]". </para><para>Example output strings for the US date format. <ul><li><para>3 mins ago, 10:15 AM </para></li><li><para>yesterday, 12:20 PM </para></li><li><para>Dec 12, 4:12 AM </para></li><li><para>11/14/2007, 8:20 AM </para></li></ul></para><para></para>        
				/// </summary>
				/// <java-name>
				/// getRelativeDateTimeString
				/// </java-name>
				[Dot42.DexImport("getRelativeDateTimeString", "(Landroid/content/Context;JJJI)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeDateTimeString(global::Android.Content.Context c, long time, long minResolution, long transitionResolution, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Formats an elapsed time in the form "MM:SS" or "H:MM:SS" for display on the call-in-progress screen. </para>        
				/// </summary>
				/// <java-name>
				/// formatElapsedTime
				/// </java-name>
				[Dot42.DexImport("formatElapsedTime", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatElapsedTime(long elapsedSeconds) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats an elapsed time in a format like "MM:SS" or "H:MM:SS" (using a form suited to the current locale), similar to that used on the call-in-progress screen.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// formatElapsedTime
				/// </java-name>
				[Dot42.DexImport("formatElapsedTime", "(Ljava/lang/StringBuilder;J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatElapsedTime(global::System.Text.StringBuilder recycle, long elapsedSeconds) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Format a date / time such that if the then is on the same day as now, it shows just the time and if it's a different day, it shows just the date.</para><para>The parameters dateFormat and timeFormat should each be one of java.text.DateFormat#DEFAULT, java.text.DateFormat#FULL, java.text.DateFormat#LONG, java.text.DateFormat#MEDIUM or java.text.DateFormat#SHORT</para><para></para>        
				/// </summary>
				/// <java-name>
				/// formatSameDayTime
				/// </java-name>
				[Dot42.DexImport("formatSameDayTime", "(JJII)Ljava/lang/CharSequence;", AccessFlags = 25)]
				public static global::Java.Lang.ICharSequence FormatSameDayTime(long then, long now, int dateStyle, int timeStyle) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the supplied when is today else false </para>
				/// </returns>
				/// <java-name>
				/// isToday
				/// </java-name>
				[Dot42.DexImport("isToday", "(J)Z", AccessFlags = 9)]
				public static bool IsToday(long when) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Formats a date or a time range according to the local conventions. </para><para>Note that this is a convenience method. Using it involves creating an internal java.util.Formatter instance on-the-fly, which is somewhat costly in terms of memory and time. This is probably acceptable if you use the method only rarely, but if you rely on it for formatting a large number of dates, consider creating and reusing your own java.util.Formatter instance and use the version of formatDateRange that takes a java.util.Formatter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string containing the formatted date/time range. </para>
				/// </returns>
				/// <java-name>
				/// formatDateRange
				/// </java-name>
				[Dot42.DexImport("formatDateRange", "(Landroid/content/Context;JJI)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDateRange(global::Android.Content.Context context, long startMillis, long endMillis, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats a date or a time range according to the local conventions. </para><para>Note that this is a convenience method for formatting the date or time range in the local time zone. If you want to specify the time zone please use formatDateRange.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string containing the formatted date/time range. </para>
				/// </returns>
				/// <java-name>
				/// formatDateRange
				/// </java-name>
				[Dot42.DexImport("formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJI)Ljava/util/Formatter;", AccessFlags = 9)]
				public static global::Java.Util.Formatter FormatDateRange(global::Android.Content.Context context, global::Java.Util.Formatter formatter, long startMillis, long endMillis, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <summary>
				/// <para>Formats a date or a time range according to the local conventions.</para><para>Example output strings (date formats in these examples are shown using the US date format convention but that may change depending on the local settings): <ul><li><para>10:15am </para></li><li><para>3:00pm - 4:00pm </para></li><li><para>3pm - 4pm </para></li><li><para>3PM - 4PM </para></li><li><para>08:00 - 17:00 </para></li><li><para>Oct 9 </para></li><li><para>Tue, Oct 9 </para></li><li><para>October 9, 2007 </para></li><li><para>Oct 9 - 10 </para></li><li><para>Oct 9 - 10, 2007 </para></li><li><para>Oct 28 - Nov 3, 2007 </para></li><li><para>Dec 31, 2007 - Jan 1, 2008 </para></li><li><para>Oct 9, 8:00am - Oct 10, 5:00pm </para></li><li><para>12/31/2007 - 01/01/2008 </para></li></ul></para><para>The flags argument is a bitmask of options from the following list:</para><para><ul><li><para>FORMAT_SHOW_TIME </para></li><li><para>FORMAT_SHOW_WEEKDAY </para></li><li><para>FORMAT_SHOW_YEAR </para></li><li><para>FORMAT_NO_YEAR </para></li><li><para>FORMAT_SHOW_DATE </para></li><li><para>FORMAT_NO_MONTH_DAY </para></li><li><para>FORMAT_12HOUR </para></li><li><para>FORMAT_24HOUR </para></li><li><para>FORMAT_CAP_AMPM </para></li><li><para>FORMAT_NO_NOON </para></li><li><para>FORMAT_CAP_NOON </para></li><li><para>FORMAT_NO_MIDNIGHT </para></li><li><para>FORMAT_CAP_MIDNIGHT </para></li><li><para>FORMAT_UTC </para></li><li><para>FORMAT_ABBREV_TIME </para></li><li><para>FORMAT_ABBREV_WEEKDAY </para></li><li><para>FORMAT_ABBREV_MONTH </para></li><li><para>FORMAT_ABBREV_ALL </para></li><li><para>FORMAT_NUMERIC_DATE </para></li></ul></para><para>If FORMAT_SHOW_TIME is set, the time is shown as part of the date range. If the start and end time are the same, then just the start time is shown.</para><para>If FORMAT_SHOW_WEEKDAY is set, then the weekday is shown.</para><para>If FORMAT_SHOW_YEAR is set, then the year is always shown. If FORMAT_NO_YEAR is set, then the year is not shown. If neither FORMAT_SHOW_YEAR nor FORMAT_NO_YEAR are set, then the year is shown only if it is different from the current year, or if the start and end dates fall on different years. If both are set, FORMAT_SHOW_YEAR takes precedence.</para><para>Normally the date is shown unless the start and end day are the same. If FORMAT_SHOW_DATE is set, then the date is always shown, even for same day ranges.</para><para>If FORMAT_NO_MONTH_DAY is set, then if the date is shown, just the month name will be shown, not the day of the month. For example, "January, 2008" instead of "January 6 - 12, 2008".</para><para>If FORMAT_CAP_AMPM is set and 12-hour time is used, then the "AM" and "PM" are capitalized. You should not use this flag because in some locales these terms cannot be capitalized, and in many others it doesn't make sense to do so even though it is possible.</para><para>If FORMAT_NO_NOON is set and 12-hour time is used, then "12pm" is shown instead of "noon".</para><para>If FORMAT_CAP_NOON is set and 12-hour time is used, then "Noon" is shown instead of "noon". You should probably not use this flag because in many locales it will not make sense to capitalize the term.</para><para>If FORMAT_NO_MIDNIGHT is set and 12-hour time is used, then "12am" is shown instead of "midnight".</para><para>If FORMAT_CAP_MIDNIGHT is set and 12-hour time is used, then "Midnight" is shown instead of "midnight". You should probably not use this flag because in many locales it will not make sense to capitalize the term.</para><para>If FORMAT_12HOUR is set and the time is shown, then the time is shown in the 12-hour time format. You should not normally set this. Instead, let the time format be chosen automatically according to the system settings. If both FORMAT_12HOUR and FORMAT_24HOUR are set, then FORMAT_24HOUR takes precedence.</para><para>If FORMAT_24HOUR is set and the time is shown, then the time is shown in the 24-hour time format. You should not normally set this. Instead, let the time format be chosen automatically according to the system settings. If both FORMAT_12HOUR and FORMAT_24HOUR are set, then FORMAT_24HOUR takes precedence.</para><para>If FORMAT_UTC is set, then the UTC time zone is used for the start and end milliseconds unless a time zone is specified. If a time zone is specified it will be used regardless of the FORMAT_UTC flag.</para><para>If FORMAT_ABBREV_TIME is set and 12-hour time format is used, then the start and end times (if shown) are abbreviated by not showing the minutes if they are zero. For example, instead of "3:00pm" the time would be abbreviated to "3pm".</para><para>If FORMAT_ABBREV_WEEKDAY is set, then the weekday (if shown) is abbreviated to a 3-letter string.</para><para>If FORMAT_ABBREV_MONTH is set, then the month (if shown) is abbreviated to a 3-letter string.</para><para>If FORMAT_ABBREV_ALL is set, then the weekday and the month (if shown) are abbreviated to 3-letter strings.</para><para>If FORMAT_NUMERIC_DATE is set, then the date is shown in numeric format instead of using the name of the month. For example, "12/31/2008" instead of "December 31, 2008".</para><para>If the end date ends at 12:00am at the beginning of a day, it is formatted as the end of the previous day in two scenarios: <ul><li><para>For single day events. This results in "8pm - midnight" instead of "Nov 10, 8pm - Nov 11, 12am". </para></li><li><para>When the time is not displayed. This results in "Nov 10 - 11" for an event with a start date of Nov 10 and an end date of Nov 12 at 00:00. </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatter with the formatted date/time range appended to the string buffer. </para>
				/// </returns>
				/// <java-name>
				/// formatDateRange
				/// </java-name>
				[Dot42.DexImport("formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJILjava/lang/String;)Ljava/util/F" +
    "ormatter;", AccessFlags = 9)]
				public static global::Java.Util.Formatter FormatDateRange(global::Android.Content.Context context, global::Java.Util.Formatter formatter, long startMillis, long endMillis, int flags, string timeZone) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <summary>
				/// <para>Formats a date or a time according to the local conventions. There are lots of options that allow the caller to control, for example, if the time is shown, if the day of the week is shown, if the month name is abbreviated, if noon is shown instead of 12pm, and so on. For the complete list of options, see the documentation for formatDateRange. </para><para>Example output strings (date formats in these examples are shown using the US date format convention but that may change depending on the local settings): <ul><li><para>10:15am </para></li><li><para>3:00pm </para></li><li><para>3pm </para></li><li><para>3PM </para></li><li><para>08:00 </para></li><li><para>17:00 </para></li><li><para>noon </para></li><li><para>Noon </para></li><li><para>midnight </para></li><li><para>Midnight </para></li><li><para>Oct 31 </para></li><li><para>Oct 31, 2007 </para></li><li><para>October 31, 2007 </para></li><li><para>10am, Oct 31 </para></li><li><para>17:00, Oct 31 </para></li><li><para>Wed </para></li><li><para>Wednesday </para></li><li><para>10am, Wed, Oct 31 </para></li><li><para>Wed, Oct 31 </para></li><li><para>Wednesday, Oct 31 </para></li><li><para>Wed, Oct 31, 2007 </para></li><li><para>Wed, October 31 </para></li><li><para>10/31/2007 </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string containing the formatted date/time. </para>
				/// </returns>
				/// <java-name>
				/// formatDateTime
				/// </java-name>
				[Dot42.DexImport("formatDateTime", "(Landroid/content/Context;JI)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDateTime(global::Android.Content.Context context, long millis, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(Landroid/content/Context;JZ)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(global::Android.Content.Context context, long int64, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Convenience function to return relative time string without preposition. <para>getRelativeTimeSpanString(Context, long, boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>CharSequence containing relative time. </para>
				/// </returns>
				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(Landroid/content/Context;J)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(global::Android.Content.Context c, long millis) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

}


