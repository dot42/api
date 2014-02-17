// Copyright (C) 2014 dot42
//
// Original filename: Java.Text.cs
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
namespace Java.Text
{
		/// <summary>
		/// <para>Formats or parses dates and times.</para><para>This class provides factories for obtaining instances configured for a specific locale. The most common subclass is SimpleDateFormat.</para><para><h4>Sample Code</h4></para><para>This code: <pre>
		///    DateFormat[] formats = new DateFormat[] {
		///      DateFormat.getDateInstance(),
		///      DateFormat.getDateTimeInstance(),
		///      DateFormat.getTimeInstance(),
		///    };
		///    for (DateFormat df : formats) {
		///      System.out.println(df.format(new Date(0)));
		///      df.setTimeZone(TimeZone.getTimeZone("UTC"));
		///      System.out.println(df.format(new Date(0)));
		///    }
		///    </pre></para><para>Produces this output when run on an <c> en_US </c> device in the America/Los_Angeles time zone: <pre>
		///    Dec 31, 1969
		///    Jan 1, 1970
		///    Dec 31, 1969 4:00:00 PM
		///    Jan 1, 1970 12:00:00 AM
		///    4:00:00 PM
		///    12:00:00 AM
		///    </pre> And will produce similarly appropriate localized human-readable output on any user's system. Notice how the same point in time when formatted can appear to be a different time when rendered for a different time zone. This is one reason why formatting should be left until the data will only be presented to a human. Machines should interchange "Unix time" integers. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/DateFormat
		/// </java-name>
		[Dot42.DexImport("java/text/DateFormat", AccessFlags = 1057)]
		public abstract partial class DateFormat : global::Java.Text.Format
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The calendar that this <c> DateFormat </c> uses to format a number representing a date. </para>        
				/// </summary>
				/// <java-name>
				/// calendar
				/// </java-name>
				[Dot42.DexImport("calendar", "Ljava/util/Calendar;", AccessFlags = 4)]
				protected internal global::Java.Util.Calendar Calendar;
				/// <summary>
				/// <para>The number format used to format a number. </para>        
				/// </summary>
				/// <java-name>
				/// numberFormat
				/// </java-name>
				[Dot42.DexImport("numberFormat", "Ljava/text/NumberFormat;", AccessFlags = 4)]
				protected internal global::Java.Text.NumberFormat NumberFormat;
				/// <summary>
				/// <para>The format style constant defining the default format style. The default is MEDIUM. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
				public const int DEFAULT = 2;
				/// <summary>
				/// <para>The format style constant defining the full style. </para>        
				/// </summary>
				/// <java-name>
				/// FULL
				/// </java-name>
				[Dot42.DexImport("FULL", "I", AccessFlags = 25)]
				public const int FULL = 0;
				/// <summary>
				/// <para>The format style constant defining the long style. </para>        
				/// </summary>
				/// <java-name>
				/// LONG
				/// </java-name>
				[Dot42.DexImport("LONG", "I", AccessFlags = 25)]
				public const int LONG = 1;
				/// <summary>
				/// <para>The format style constant defining the medium style. </para>        
				/// </summary>
				/// <java-name>
				/// MEDIUM
				/// </java-name>
				[Dot42.DexImport("MEDIUM", "I", AccessFlags = 25)]
				public const int MEDIUM = 2;
				/// <summary>
				/// <para>The format style constant defining the short style. </para>        
				/// </summary>
				/// <java-name>
				/// SHORT
				/// </java-name>
				[Dot42.DexImport("SHORT", "I", AccessFlags = 25)]
				public const int SHORT = 3;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'G' field alignment, corresponds to the Calendar#ERA field. </para>        
				/// </summary>
				/// <java-name>
				/// ERA_FIELD
				/// </java-name>
				[Dot42.DexImport("ERA_FIELD", "I", AccessFlags = 25)]
				public const int ERA_FIELD = 0;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'y' field alignment, corresponds to the Calendar#YEAR field. </para>        
				/// </summary>
				/// <java-name>
				/// YEAR_FIELD
				/// </java-name>
				[Dot42.DexImport("YEAR_FIELD", "I", AccessFlags = 25)]
				public const int YEAR_FIELD = 1;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'M' field alignment, corresponds to the Calendar#MONTH field. </para>        
				/// </summary>
				/// <java-name>
				/// MONTH_FIELD
				/// </java-name>
				[Dot42.DexImport("MONTH_FIELD", "I", AccessFlags = 25)]
				public const int MONTH_FIELD = 2;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'd' field alignment, corresponds to the Calendar#DATE field. </para>        
				/// </summary>
				/// <java-name>
				/// DATE_FIELD
				/// </java-name>
				[Dot42.DexImport("DATE_FIELD", "I", AccessFlags = 25)]
				public const int DATE_FIELD = 3;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'k' field alignment, corresponds to the Calendar#HOUR_OF_DAY field. <c> HOUR_OF_DAY1_FIELD </c> is used for the one-based 24-hour clock. For example, 23:59 + 01:00 results in 24:59. </para>        
				/// </summary>
				/// <java-name>
				/// HOUR_OF_DAY1_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY1_FIELD", "I", AccessFlags = 25)]
				public const int HOUR_OF_DAY1_FIELD = 4;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'H' field alignment, corresponds to the Calendar#HOUR_OF_DAY field. <c> HOUR_OF_DAY0_FIELD </c> is used for the zero-based 24-hour clock. For example, 23:59 + 01:00 results in 00:59. </para>        
				/// </summary>
				/// <java-name>
				/// HOUR_OF_DAY0_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY0_FIELD", "I", AccessFlags = 25)]
				public const int HOUR_OF_DAY0_FIELD = 5;
				/// <summary>
				/// <para>FieldPosition selector for 'm' field alignment, corresponds to the Calendar#MINUTE field. </para>        
				/// </summary>
				/// <java-name>
				/// MINUTE_FIELD
				/// </java-name>
				[Dot42.DexImport("MINUTE_FIELD", "I", AccessFlags = 25)]
				public const int MINUTE_FIELD = 6;
				/// <summary>
				/// <para>FieldPosition selector for 's' field alignment, corresponds to the Calendar#SECOND field. </para>        
				/// </summary>
				/// <java-name>
				/// SECOND_FIELD
				/// </java-name>
				[Dot42.DexImport("SECOND_FIELD", "I", AccessFlags = 25)]
				public const int SECOND_FIELD = 7;
				/// <summary>
				/// <para>FieldPosition selector for 'S' field alignment, corresponds to the Calendar#MILLISECOND field. </para>        
				/// </summary>
				/// <java-name>
				/// MILLISECOND_FIELD
				/// </java-name>
				[Dot42.DexImport("MILLISECOND_FIELD", "I", AccessFlags = 25)]
				public const int MILLISECOND_FIELD = 8;
				/// <summary>
				/// <para>FieldPosition selector for 'E' field alignment, corresponds to the Calendar#DAY_OF_WEEK field. </para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_WEEK_FIELD
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK_FIELD", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK_FIELD = 9;
				/// <summary>
				/// <para>FieldPosition selector for 'D' field alignment, corresponds to the Calendar#DAY_OF_YEAR field. </para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_YEAR_FIELD
				/// </java-name>
				[Dot42.DexImport("DAY_OF_YEAR_FIELD", "I", AccessFlags = 25)]
				public const int DAY_OF_YEAR_FIELD = 10;
				/// <summary>
				/// <para>FieldPosition selector for 'F' field alignment, corresponds to the Calendar#DAY_OF_WEEK_IN_MONTH field. </para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_WEEK_IN_MONTH_FIELD
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK_IN_MONTH_FIELD", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK_IN_MONTH_FIELD = 11;
				/// <summary>
				/// <para>FieldPosition selector for 'w' field alignment, corresponds to the Calendar#WEEK_OF_YEAR field. </para>        
				/// </summary>
				/// <java-name>
				/// WEEK_OF_YEAR_FIELD
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_YEAR_FIELD", "I", AccessFlags = 25)]
				public const int WEEK_OF_YEAR_FIELD = 12;
				/// <summary>
				/// <para>FieldPosition selector for 'W' field alignment, corresponds to the Calendar#WEEK_OF_MONTH field. </para>        
				/// </summary>
				/// <java-name>
				/// WEEK_OF_MONTH_FIELD
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_MONTH_FIELD", "I", AccessFlags = 25)]
				public const int WEEK_OF_MONTH_FIELD = 13;
				/// <summary>
				/// <para>FieldPosition selector for 'a' field alignment, corresponds to the Calendar#AM_PM field. </para>        
				/// </summary>
				/// <java-name>
				/// AM_PM_FIELD
				/// </java-name>
				[Dot42.DexImport("AM_PM_FIELD", "I", AccessFlags = 25)]
				public const int AM_PM_FIELD = 14;
				/// <summary>
				/// <para>FieldPosition selector for 'h' field alignment, corresponding to the Calendar#HOUR field. </para>        
				/// </summary>
				/// <java-name>
				/// HOUR1_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR1_FIELD", "I", AccessFlags = 25)]
				public const int HOUR1_FIELD = 15;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'K' field alignment, corresponding to the Calendar#HOUR field. </para>        
				/// </summary>
				/// <java-name>
				/// HOUR0_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR0_FIELD", "I", AccessFlags = 25)]
				public const int HOUR0_FIELD = 16;
				/// <summary>
				/// <para>The <c> FieldPosition </c> selector for 'z' field alignment, corresponds to the Calendar#ZONE_OFFSET and Calendar#DST_OFFSET fields. </para>        
				/// </summary>
				/// <java-name>
				/// TIMEZONE_FIELD
				/// </java-name>
				[Dot42.DexImport("TIMEZONE_FIELD", "I", AccessFlags = 25)]
				public const int TIMEZONE_FIELD = 17;
				/// <summary>
				/// <para>Constructs a new instance of <c> DateFormat </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DateFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new instance of <c> DateFormat </c> with the same properties. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares this date format with the specified object and indicates if they are equal.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is a <c> DateFormat </c> object and it has the same properties as this date format; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 17)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				/// <para>Formats the specified date using the rules of this date format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Date;)Ljava/lang/String;", AccessFlags = 17)]
				public string Format(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/Str" +
    "ingBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer Format(global::Java.Util.Date date, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> DateFormat </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <summary>
				/// <para>Returns the calendar used by this <c> DateFormat </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the calendar used by this date format. </para>
				/// </returns>
				/// <java-name>
				/// getCalendar
				/// </java-name>
				[Dot42.DexImport("getCalendar", "()Ljava/util/Calendar;", AccessFlags = 1)]
				public virtual global::Java.Util.Calendar GetCalendar() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates in the DEFAULT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the default style and locale. </para>
				/// </returns>
				/// <java-name>
				/// getDateInstance
				/// </java-name>
				[Dot42.DexImport("getDateInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates in the specified style for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for <c> style </c> and the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getDateInstance
				/// </java-name>
				[Dot42.DexImport("getDateInstance", "(I)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateInstance(int style) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates in the specified style for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for <c> style </c> and <c> locale </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDateInstance
				/// </java-name>
				[Dot42.DexImport("getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateInstance(int style, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates and time values in the DEFAULT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the default style and locale. </para>
				/// </returns>
				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				[Dot42.DexImport("getDateTimeInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateTimeInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing of both dates and time values in the manner appropriate for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for <c> dateStyle </c> , <c> timeStyle </c> and the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				[Dot42.DexImport("getDateTimeInstance", "(II)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateTimeInstance(int dateStyle, int timeStyle) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates and time values in the specified styles for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for <c> dateStyle </c> , <c> timeStyle </c> and <c> locale </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				[Dot42.DexImport("getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateTimeInstance(int dateStyle, int timeStyle, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates and times in the SHORT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the SHORT style and default locale. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns the <c> NumberFormat </c> used by this <c> DateFormat </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> NumberFormat </c> used by this date format. </para>
				/// </returns>
				/// <java-name>
				/// getNumberFormat
				/// </java-name>
				[Dot42.DexImport("getNumberFormat", "()Ljava/text/NumberFormat;", AccessFlags = 1)]
				public virtual global::Java.Text.NumberFormat GetNumberFormat() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing time values in the DEFAULT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the default style and locale. </para>
				/// </returns>
				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				[Dot42.DexImport("getTimeInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetTimeInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing time values in the specified style for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for <c> style </c> and the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				[Dot42.DexImport("getTimeInstance", "(I)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetTimeInstance(int style) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing time values in the specified style for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for <c> style </c> and <c> locale </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				[Dot42.DexImport("getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetTimeInstance(int style, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <summary>
				/// <para>Returns the time zone of this date format's calendar.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time zone of the calendar used by this date format. </para>
				/// </returns>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "()Ljava/util/TimeZone;", AccessFlags = 1)]
				public virtual global::Java.Util.TimeZone GetTimeZone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether the calendar used by this date format is lenient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the calendar is lenient; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLenient
				/// </java-name>
				[Dot42.DexImport("isLenient", "()Z", AccessFlags = 1)]
				public virtual bool IsLenient() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Parses a date from the specified string using the rules of this date format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Date </c> resulting from the parsing. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Parses a date from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c>       ParsePosition </c> is set to the index where the error occurred. </para><para>By default, parsing is lenient: If the input is not in the form used by this object's format method but can still be parsed as a date, then the parse succeeds. Clients may insist on strict adherence to the format by calling <c> setLenient(false) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the date resulting from the parse, or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", AccessFlags = 1025)]
				public abstract global::Java.Util.Date Parse(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses a date from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred. </para><para>By default, parsing is lenient: If the input is not in the form used by this object's format method but can still be parsed as a date, then the parse succeeds. Clients may insist on strict adherence to the format by calling <c> setLenient(false) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the date resulting from the parsing, or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object ParseObject(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets the calendar used by this date format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCalendar
				/// </java-name>
				[Dot42.DexImport("setCalendar", "(Ljava/util/Calendar;)V", AccessFlags = 1)]
				public virtual void SetCalendar(global::Java.Util.Calendar cal) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies whether or not date/time parsing shall be lenient. With lenient parsing, the parser may use heuristics to interpret inputs that do not precisely match this object's format. With strict parsing, inputs must match this object's format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLenient
				/// </java-name>
				[Dot42.DexImport("setLenient", "(Z)V", AccessFlags = 1)]
				public virtual void SetLenient(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the <c> NumberFormat </c> used by this date format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNumberFormat
				/// </java-name>
				[Dot42.DexImport("setNumberFormat", "(Ljava/text/NumberFormat;)V", AccessFlags = 1)]
				public virtual void SetNumberFormat(global::Java.Text.NumberFormat format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the time zone of the calendar used by this date format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeZone
				/// </java-name>
				[Dot42.DexImport("setTimeZone", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
				public virtual void SetTimeZone(global::Java.Util.TimeZone timezone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> DateFormat </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates in the DEFAULT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the default style and locale. </para>
				/// </returns>
				/// <java-name>
				/// getDateInstance
				/// </java-name>
				public static global::Java.Text.DateFormat DateInstance
				{
				[Dot42.DexImport("getDateInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return GetDateInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates and time values in the DEFAULT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the default style and locale. </para>
				/// </returns>
				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				public static global::Java.Text.DateFormat DateTimeInstance
				{
				[Dot42.DexImport("getDateTimeInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return GetDateTimeInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing dates and times in the SHORT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the SHORT style and default locale. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.DateFormat Instance
				{
				[Dot42.DexImport("getInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> DateFormat </c> instance for formatting and parsing time values in the DEFAULT style for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormat </c> instance for the default style and locale. </para>
				/// </returns>
				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				public static global::Java.Text.DateFormat TimeInstance
				{
				[Dot42.DexImport("getTimeInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return GetTimeInstance(); }
				}

				/// <summary>
				/// <para>Returns the time zone of this date format's calendar.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time zone of the calendar used by this date format. </para>
				/// </returns>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				public global::Java.Util.TimeZone TimeZone
				{
				[Dot42.DexImport("getTimeZone", "()Ljava/util/TimeZone;", AccessFlags = 1)]
						get{ return GetTimeZone(); }
				[Dot42.DexImport("setTimeZone", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
						set{ SetTimeZone(value); }
				}

				/// <summary>
				/// <para>The instances of this inner class are used as attribute keys and values in <c> AttributedCharacterIterator </c> that the SimpleDateFormat#formatToCharacterIterator(Object) method returns. </para><para>There is no public constructor in this class, the only instances are the constants defined here. </para>    
				/// </summary>
				/// <java-name>
				/// java/text/DateFormat$Field
				/// </java-name>
				[Dot42.DexImport("java/text/DateFormat$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.Format.Field
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Marks the era part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// ERA
						/// </java-name>
						[Dot42.DexImport("ERA", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field ERA;
						/// <summary>
						/// <para>Marks the year part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// YEAR
						/// </java-name>
						[Dot42.DexImport("YEAR", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field YEAR;
						/// <summary>
						/// <para>Marks the month part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// MONTH
						/// </java-name>
						[Dot42.DexImport("MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field MONTH;
						/// <summary>
						/// <para>Marks the hour of the day part of a date (0-11). </para>        
						/// </summary>
						/// <java-name>
						/// HOUR_OF_DAY0
						/// </java-name>
						[Dot42.DexImport("HOUR_OF_DAY0", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR_OF_DAY0;
						/// <summary>
						/// <para>Marks the hour of the day part of a date (1-12). </para>        
						/// </summary>
						/// <java-name>
						/// HOUR_OF_DAY1
						/// </java-name>
						[Dot42.DexImport("HOUR_OF_DAY1", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR_OF_DAY1;
						/// <summary>
						/// <para>Marks the minute part of a time. </para>        
						/// </summary>
						/// <java-name>
						/// MINUTE
						/// </java-name>
						[Dot42.DexImport("MINUTE", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field MINUTE;
						/// <summary>
						/// <para>Marks the second part of a time. </para>        
						/// </summary>
						/// <java-name>
						/// SECOND
						/// </java-name>
						[Dot42.DexImport("SECOND", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field SECOND;
						/// <summary>
						/// <para>Marks the millisecond part of a time. </para>        
						/// </summary>
						/// <java-name>
						/// MILLISECOND
						/// </java-name>
						[Dot42.DexImport("MILLISECOND", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field MILLISECOND;
						/// <summary>
						/// <para>Marks the day of the week part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// DAY_OF_WEEK
						/// </java-name>
						[Dot42.DexImport("DAY_OF_WEEK", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_WEEK;
						/// <summary>
						/// <para>Marks the day of the month part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// DAY_OF_MONTH
						/// </java-name>
						[Dot42.DexImport("DAY_OF_MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_MONTH;
						/// <summary>
						/// <para>Marks the day of the year part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// DAY_OF_YEAR
						/// </java-name>
						[Dot42.DexImport("DAY_OF_YEAR", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_YEAR;
						/// <summary>
						/// <para>Marks the day of the week in the month part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// DAY_OF_WEEK_IN_MONTH
						/// </java-name>
						[Dot42.DexImport("DAY_OF_WEEK_IN_MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_WEEK_IN_MONTH;
						/// <summary>
						/// <para>Marks the week of the year part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// WEEK_OF_YEAR
						/// </java-name>
						[Dot42.DexImport("WEEK_OF_YEAR", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field WEEK_OF_YEAR;
						/// <summary>
						/// <para>Marks the week of the month part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// WEEK_OF_MONTH
						/// </java-name>
						[Dot42.DexImport("WEEK_OF_MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field WEEK_OF_MONTH;
						/// <summary>
						/// <para>Marks the time indicator part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// AM_PM
						/// </java-name>
						[Dot42.DexImport("AM_PM", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field AM_PM;
						/// <summary>
						/// <para>Marks the hour part of a date (0-11). </para>        
						/// </summary>
						/// <java-name>
						/// HOUR0
						/// </java-name>
						[Dot42.DexImport("HOUR0", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR0;
						/// <summary>
						/// <para>Marks the hour part of a date (1-12). </para>        
						/// </summary>
						/// <java-name>
						/// HOUR1
						/// </java-name>
						[Dot42.DexImport("HOUR1", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR1;
						/// <summary>
						/// <para>Marks the time zone part of a date. </para>        
						/// </summary>
						/// <java-name>
						/// TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("TIME_ZONE", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field TIME_ZONE;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
						protected internal Field(string @string, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the Calendar field that this field represents.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the calendar field. </para>
						/// </returns>
						/// <java-name>
						/// getCalendarField
						/// </java-name>
						[Dot42.DexImport("getCalendarField", "()I", AccessFlags = 1)]
						public virtual int GetCalendarField() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the <c> DateFormat.Field </c> instance for the given calendar field.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the <c> DateFormat.Field </c> corresponding to <c> calendarField </c> . </para>
						/// </returns>
						/// <java-name>
						/// ofCalendarField
						/// </java-name>
						[Dot42.DexImport("ofCalendarField", "(I)Ljava/text/DateFormat$Field;", AccessFlags = 9)]
						public static Field OfCalendarField(int calendarField) /* MethodBuilder.Create */ 
						{
								return default(Field);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns the Calendar field that this field represents.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the calendar field. </para>
						/// </returns>
						/// <java-name>
						/// getCalendarField
						/// </java-name>
						public int CalendarField
						{
						[Dot42.DexImport("getCalendarField", "()I", AccessFlags = 1)]
								get{ return GetCalendarField(); }
						}

				}

		}

		/// <summary>
		/// <para>Tracks the current position in a parsed string. In case of an error the error index can be set to the position where the error occurred without having to change the parse position. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/ParsePosition
		/// </java-name>
		[Dot42.DexImport("java/text/ParsePosition", AccessFlags = 33)]
		public partial class ParsePosition
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> ParsePosition </c> with the specified index.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ParsePosition(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the specified object to this <c> ParsePosition </c> and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> ParsePosition </c> and it must have the same index and error index.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> ParsePosition </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the index at which the parse could not continue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the parse error or -1 if there is no error. </para>
				/// </returns>
				/// <java-name>
				/// getErrorIndex
				/// </java-name>
				[Dot42.DexImport("getErrorIndex", "()I", AccessFlags = 1)]
				public virtual int GetErrorIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the current parse position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current position. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public virtual int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the index at which the parse could not continue.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorIndex
				/// </java-name>
				[Dot42.DexImport("setErrorIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetErrorIndex(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the current parse position.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIndex
				/// </java-name>
				[Dot42.DexImport("setIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetIndex(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the string representation of this parse position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this parse position. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParsePosition() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the index at which the parse could not continue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the parse error or -1 if there is no error. </para>
				/// </returns>
				/// <java-name>
				/// getErrorIndex
				/// </java-name>
				public int ErrorIndex
				{
				[Dot42.DexImport("getErrorIndex", "()I", AccessFlags = 1)]
						get{ return GetErrorIndex(); }
				[Dot42.DexImport("setErrorIndex", "(I)V", AccessFlags = 1)]
						set{ SetErrorIndex(value); }
				}

				/// <summary>
				/// <para>Returns the current parse position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current position. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				[Dot42.DexImport("setIndex", "(I)V", AccessFlags = 1)]
						set{ SetIndex(value); }
				}

		}

		/// <summary>
		/// <para>Formats and parses dates in a locale-sensitive manner. Formatting turns a Date into a String, and parsing turns a <c> String </c> into a <c> Date </c> .</para><para><h4>Time Pattern Syntax</h4></para><para>You can supply a Unicode  pattern describing what strings are produced/accepted, but almost all callers should use DateFormat#getDateInstance, DateFormat#getDateTimeInstance, or DateFormat#getTimeInstance to get a ready-made instance suitable for the user's locale.</para><para>The main reason you'd create an instance this class directly is because you need to format/parse a specific machine-readable format, in which case you almost certainly want to explicitly ask for Locale#US to ensure that you get ASCII digits (rather than, say, Arabic digits). (See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".) The most useful non-localized pattern is <c> "yyyy-MM-dd HH:mm:ss.SSSZ" </c> , which corresponds to the ISO 8601 international standard date format.</para><para>To specify the time format, use a <b>time pattern</b> string. In this string, any character from <c> 'A' </c> to <c> 'Z' </c> or <c> 'a' </c> to <c> 'z' </c> is treated specially. All other characters are passed through verbatim. The interpretation of each of the ASCII letters is given in the table below. ASCII letters not appearing in the table are reserved for future use, and it is an error to attempt to use them.</para><para>The number of consecutive copies (the "count") of a pattern character further influences the format, as shown in the table. For fields of kind "number", the count is the minimum number of digits; shorter values are zero-padded to the given width and longer values overflow it.</para><para><table><row><entry><para><b>Symbol</b> </para></entry><entry><para><b>Meaning</b> </para></entry><entry><para><b>Kind</b> </para></entry><entry><para><b>Example</b>  </para></entry></row><row><entry><para><c> D </c>  </para></entry><entry><para>day in year </para></entry><entry><para>(Number) </para></entry><entry><para>189  </para></entry></row><row><entry><para><c> E </c>  </para></entry><entry><para>day of week </para></entry><entry><para>(Text) </para></entry><entry><para><c> E </c> /<c> EE </c> /<c> EEE </c> :Tue, <c> EEEE </c> :Tuesday, <c> EEEEE </c> :T  </para></entry></row><row><entry><para><c> F </c>  </para></entry><entry><para>day of week in month </para></entry><entry><para>(Number) </para></entry><entry><para>2 <b>(2nd Wed in July)</b>  </para></entry></row><row><entry><para><c> G </c>  </para></entry><entry><para>era designator </para></entry><entry><para>(Text) </para></entry><entry><para>AD  </para></entry></row><row><entry><para><c> H </c>  </para></entry><entry><para>hour in day (0-23) </para></entry><entry><para>(Number) </para></entry><entry><para>0  </para></entry></row><row><entry><para><c> K </c>  </para></entry><entry><para>hour in am/pm (0-11) </para></entry><entry><para>(Number) </para></entry><entry><para>0  </para></entry></row><row><entry><para><c> L </c>  </para></entry><entry><para>stand-alone month </para></entry><entry><para>(Text) </para></entry><entry><para><c> L </c> :1 <c> LL </c> :01 <c> LLL </c> :Jan <c> LLLL </c> :January <c> LLLLL </c> :J  </para></entry></row><row><entry><para><c> M </c>  </para></entry><entry><para>month in year </para></entry><entry><para>(Text) </para></entry><entry><para><c> M </c> :1 <c> MM </c> :01 <c> MMM </c> :Jan <c> MMMM </c> :January <c> MMMMM </c> :J  </para></entry></row><row><entry><para><c> S </c>  </para></entry><entry><para>fractional seconds </para></entry><entry><para>(Number) </para></entry><entry><para>978  </para></entry></row><row><entry><para><c> W </c>  </para></entry><entry><para>week in month </para></entry><entry><para>(Number) </para></entry><entry><para>2  </para></entry></row><row><entry><para><c> Z </c>  </para></entry><entry><para>time zone (RFC 822) </para></entry><entry><para>(Time Zone) </para></entry><entry><para><c> Z </c> /<c> ZZ </c> /<c> ZZZ </c> :-0800 <c> ZZZZ </c> :GMT-08:00 <c> ZZZZZ </c> :-08:00  </para></entry></row><row><entry><para><c> a </c>  </para></entry><entry><para>am/pm marker </para></entry><entry><para>(Text) </para></entry><entry><para>PM  </para></entry></row><row><entry><para><c> c </c>  </para></entry><entry><para>stand-alone day of week </para></entry><entry><para>(Text) </para></entry><entry><para><c> c </c> /<c> cc </c> /<c> ccc </c> :Tue, <c> cccc </c> :Tuesday, <c> ccccc </c> :T  </para></entry></row><row><entry><para><c> d </c>  </para></entry><entry><para>day in month </para></entry><entry><para>(Number) </para></entry><entry><para>10  </para></entry></row><row><entry><para><c> h </c>  </para></entry><entry><para>hour in am/pm (1-12) </para></entry><entry><para>(Number) </para></entry><entry><para>12  </para></entry></row><row><entry><para><c> k </c>  </para></entry><entry><para>hour in day (1-24) </para></entry><entry><para>(Number) </para></entry><entry><para>24  </para></entry></row><row><entry><para><c> m </c>  </para></entry><entry><para>minute in hour </para></entry><entry><para>(Number) </para></entry><entry><para>30  </para></entry></row><row><entry><para><c> s </c>  </para></entry><entry><para>second in minute </para></entry><entry><para>(Number) </para></entry><entry><para>55  </para></entry></row><row><entry><para><c> w </c>  </para></entry><entry><para>week in year </para></entry><entry><para>(Number) </para></entry><entry><para>27  </para></entry></row><row><entry><para><c> y </c>  </para></entry><entry><para>year </para></entry><entry><para>(Number) </para></entry><entry><para><c> yy </c> :10 <c> y </c> /<c> yyy </c> /<c> yyyy </c> :2010  </para></entry></row><row><entry><para><c> z </c>  </para></entry><entry><para>time zone </para></entry><entry><para>(Time Zone) </para></entry><entry><para><c> z </c> /<c> zz </c> /<c> zzz </c> :PST <c> ZZZZ </c> :Pacific Standard Time  </para></entry></row><row><entry><para><c> ' </c>  </para></entry><entry><para>escape for text </para></entry><entry><para>(Delimiter) </para></entry><entry><para><c> 'Date=' </c> :Date=  </para></entry></row><row><entry><para><c> '' </c>  </para></entry><entry><para>single quote </para></entry><entry><para>(Literal) </para></entry><entry><para><c> 'o''clock' </c> :o'clock  </para></entry></row></table></para><para>Fractional seconds are handled specially: they're zero-padded on the <b>right</b>.</para><para>The two pattern characters <c> L </c> and <c> c </c> are ICU-compatible extensions, not available in the RI or in Android before Android 2.3 "Gingerbread" (API level 9). These extensions are necessary for correct localization in languages such as Russian that distinguish between, say, "June" and "June 2010".</para><para>When two numeric fields are directly adjacent with no intervening delimiter characters, they constitute a run of adjacent numeric fields. Such runs are parsed specially. For example, the format "HHmmss" parses the input text "123456" to 12:34:56, parses the input text "12345" to 1:23:45, and fails to parse "1234". In other words, the leftmost field of the run is flexible, while the others keep a fixed width. If the parse fails anywhere in the run, then the leftmost field is shortened by one character, and the entire run is parsed again. This is repeated until either the parse succeeds or the leftmost field is one character in length. If the parse still fails at that point, the parse of the run fails.</para><para>See set2DigitYearStart for more about handling two-digit years.</para><para><h4>Sample Code</h4></para><para>If you're formatting for human use, you should use an instance returned from DateFormat as described above. This code: <pre>
		///    DateFormat[] formats = new DateFormat[] {
		///      DateFormat.getDateInstance(),
		///      DateFormat.getDateTimeInstance(),
		///      DateFormat.getTimeInstance(),
		///    };
		///    for (DateFormat df : formats) {
		///      System.out.println(df.format(new Date(0)));
		///    }
		///    </pre></para><para>Produces this output when run on an <c> en_US </c> device in the America/Los_Angeles time zone: <pre>
		///    Dec 31, 1969
		///    Dec 31, 1969 4:00:00 PM
		///    4:00:00 PM
		///    </pre> And will produce similarly appropriate localized human-readable output on any user's system.</para><para>If you're formatting for machine use, consider this code: <pre>
		///    String[] formats = new String[] {
		///      "yyyy-MM-dd",
		///      "yyyy-MM-dd HH:mm",
		///      "yyyy-MM-dd HH:mmZ",
		///      "yyyy-MM-dd HH:mm:ss.SSSZ",
		///      "yyyy-MM-dd'T'HH:mm:ss.SSSZ",
		///    };
		///    for (String format : formats) {
		///      SimpleDateFormat sdf = new SimpleDateFormat(format, Locale.US);
		///      System.out.format("%30s %s\n", format, sdf.format(new Date(0)));
		///      sdf.setTimeZone(TimeZone.getTimeZone("UTC"));
		///      System.out.format("%30s %s\n", format, sdf.format(new Date(0)));
		///    }
		///    </pre></para><para>Which produces this output when run in the America/Los_Angeles time zone: <pre>
		///                        yyyy-MM-dd 1969-12-31
		///                        yyyy-MM-dd 1970-01-01
		///                  yyyy-MM-dd HH:mm 1969-12-31 16:00
		///                  yyyy-MM-dd HH:mm 1970-01-01 00:00
		///                 yyyy-MM-dd HH:mmZ 1969-12-31 16:00-0800
		///                 yyyy-MM-dd HH:mmZ 1970-01-01 00:00+0000
		///          yyyy-MM-dd HH:mm:ss.SSSZ 1969-12-31 16:00:00.000-0800
		///          yyyy-MM-dd HH:mm:ss.SSSZ 1970-01-01 00:00:00.000+0000
		///        yyyy-MM-dd'T'HH:mm:ss.SSSZ 1969-12-31T16:00:00.000-0800
		///        yyyy-MM-dd'T'HH:mm:ss.SSSZ 1970-01-01T00:00:00.000+0000
		///    </pre></para><para>As this example shows, each <c> SimpleDateFormat </c> instance has a TimeZone. This is because it's called upon to format instances of <c> Date </c> , which represents an absolute time in UTC. That is, <c> Date </c> does not carry time zone information. By default, <c> SimpleDateFormat </c> will use the system's default time zone. This is appropriate for human-readable output (for which, see the previous sample instead), but generally inappropriate for machine-readable output, where ambiguity is a problem. Note that in this example, the output that included a time but no time zone cannot be parsed back into the original <c> Date </c> . For this reason it is almost always necessary and desirable to include the timezone in the output. It may also be desirable to set the formatter's time zone to UTC (to ease comparison, or to make logs more readable, for example). It is often best to avoid formatting completely when writing dates/times in machine-readable form. Simply sending the "Unix time" as a <c> long </c> or as the string corresponding to the long is cheaper and unambiguous, and can be formatted any way the recipient deems appropriate.</para><para><h4>Synchronization</h4></para><para><c> SimpleDateFormat </c> is not thread-safe. Users should create a separate instance for each thread.</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.util.Date </para><simplesectsep></simplesectsep><para>java.util.TimeZone </para><simplesectsep></simplesectsep><para>java.text.DateFormat </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/SimpleDateFormat
		/// </java-name>
		[Dot42.DexImport("java/text/SimpleDateFormat", AccessFlags = 33)]
		public partial class SimpleDateFormat : global::Java.Text.DateFormat
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> SimpleDateFormat </c> for formatting and parsing dates and times in the <c> SHORT </c> style for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SimpleDateFormat() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SimpleDateFormat(string locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V", AccessFlags = 1)]
				public SimpleDateFormat(string @string, global::Java.Text.DateFormatSymbols dateFormatSymbols) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public SimpleDateFormat(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the pattern of this simple date format to the specified pattern which uses localized pattern characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("applyLocalizedPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyLocalizedPattern(string template) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the pattern of this simple date format to the specified pattern which uses non-localized pattern characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string template) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> SimpleDateFormat </c> with the same pattern and properties as this simple date format. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object with this simple date format and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> SimpleDateFormat </c> and have the same <c> DateFormat </c> properties, pattern, <c> DateFormatSymbols </c> and creation year.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this simple date format; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Formats the specified object using the rules of this simple date format and returns an <c> AttributedCharacterIterator </c> with the formatted date and attributes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> AttributedCharacterIterator </c> with the formatted date and attributes. </para>
				/// </returns>
				/// <java-name>
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public override global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <summary>
				/// <para>Formats the specified date as a string using the pattern of this date format and appends the string to the specified string buffer. </para><para>If the <c> field </c> member of <c> field </c> contains a value specifying a format field, then its <c> beginIndex </c> and <c> endIndex </c> members will be updated with the position of the first occurrence of this field in the formatted text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string buffer. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/Str" +
    "ingBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(global::Java.Util.Date date, global::Java.Lang.StringBuffer buffer, global::Java.Text.FieldPosition fieldPos) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				/// <para>Returns the date which is the start of the one hundred year period for two-digit year values. See set2DigitYearStart for details. </para>        
				/// </summary>
				/// <java-name>
				/// get2DigitYearStart
				/// </java-name>
				[Dot42.DexImport("get2DigitYearStart", "()Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date Get2DigitYearStart() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Returns the <c> DateFormatSymbols </c> used by this simple date format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormatSymbols </c> object. </para>
				/// </returns>
				/// <java-name>
				/// getDateFormatSymbols
				/// </java-name>
				[Dot42.DexImport("getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;", AccessFlags = 1)]
				public virtual global::Java.Text.DateFormatSymbols GetDateFormatSymbols() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormatSymbols);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses a date from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c>       ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the date resulting from the parse, or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", AccessFlags = 1)]
				public override global::Java.Util.Date Parse(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Sets the date which is the start of the one hundred year period for two-digit year values.</para><para>When parsing a date string using the abbreviated year pattern <c> yy </c> , <c>       SimpleDateFormat </c> must interpret the abbreviated year relative to some century. It does this by adjusting dates to be within 80 years before and 20 years after the time the <c> SimpleDateFormat </c> instance was created. For example, using a pattern of <c> MM/dd/yy </c> , an instance created on Jan 1, 1997 would interpret the string <c> "01/11/12" </c> as Jan 11, 2012 but interpret the string <c> "05/04/64" </c> as May 4, 1964. During parsing, only strings consisting of exactly two digits, as defined by java.lang.Character#isDigit(char), will be parsed into the default century. Any other numeric string, such as a one digit string, a three or more digit string, or a two digit string that isn't all digits (for example, <c> "-1" </c> ), is interpreted literally. So using the same pattern, both <c> "01/02/3" </c> and <c> "01/02/003" </c> are parsed as Jan 2, 3 AD. Similarly, <c> "01/02/-3" </c> is parsed as Jan 2, 4 BC.</para><para>If the year pattern does not have exactly two 'y' characters, the year is interpreted literally, regardless of the number of digits. So using the pattern <c> MM/dd/yyyy </c> , <c> "01/11/12" </c> is parsed as Jan 11, 12 A.D. </para>        
				/// </summary>
				/// <java-name>
				/// set2DigitYearStart
				/// </java-name>
				[Dot42.DexImport("set2DigitYearStart", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void Set2DigitYearStart(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the <c> DateFormatSymbols </c> used by this simple date format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDateFormatSymbols
				/// </java-name>
				[Dot42.DexImport("setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V", AccessFlags = 1)]
				public virtual void SetDateFormatSymbols(global::Java.Text.DateFormatSymbols value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the pattern of this simple date format using localized pattern characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the localized pattern. </para>
				/// </returns>
				/// <java-name>
				/// toLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("toLocalizedPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToLocalizedPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the pattern of this simple date format using non-localized pattern characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the non-localized pattern. </para>
				/// </returns>
				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the date which is the start of the one hundred year period for two-digit year values. See set2DigitYearStart for details. </para>        
				/// </summary>
				/// <java-name>
				/// get2DigitYearStart
				/// </java-name>
				public global::Java.Util.Date _2DigitYearStart
				{
				[Dot42.DexImport("get2DigitYearStart", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return Get2DigitYearStart(); }
				[Dot42.DexImport("set2DigitYearStart", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ Set2DigitYearStart(value); }
				}

				/// <summary>
				/// <para>Returns the <c> DateFormatSymbols </c> used by this simple date format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> DateFormatSymbols </c> object. </para>
				/// </returns>
				/// <java-name>
				/// getDateFormatSymbols
				/// </java-name>
				public global::Java.Text.DateFormatSymbols DateFormatSymbols
				{
				[Dot42.DexImport("getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;", AccessFlags = 1)]
						get{ return GetDateFormatSymbols(); }
				[Dot42.DexImport("setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V", AccessFlags = 1)]
						set{ SetDateFormatSymbols(value); }
				}

		}

		/// <summary>
		/// <para>Performs locale-sensitive string comparison. A concrete subclass, RuleBasedCollator, allows customization of the collation ordering by the use of rule sets. </para><para>Following the 's specifications for the , there are 4 different levels of strength used in comparisons: <ul><li><para>PRIMARY strength: Typically, this is used to denote differences between base characters (for example, "a" &lt; "b"). It is the strongest difference. For example, dictionaries are divided into different sections by base character. </para></li><li><para>SECONDARY strength: Accents in the characters are considered secondary differences (for example, "as" &lt; "&amp;agrave;s" &lt; "at"). Other differences between letters can also be considered secondary differences, depending on the language. A secondary difference is ignored when there is a primary difference anywhere in the strings. </para></li><li><para>TERTIARY strength: Upper and lower case differences in characters are distinguished at tertiary strength (for example, "ao" &lt; "Ao" &lt; "a&amp;ograve;"). In addition, a variant of a letter differs from the base form on the tertiary strength (such as "A" and "&amp;#9398;"). Another example is the difference between large and small Kana. A tertiary difference is ignored when there is a primary or secondary difference anywhere in the strings. </para></li><li><para>IDENTICAL strength: When all other strengths are equal, the IDENTICAL strength is used as a tiebreaker. The Unicode code point values of the NFD form of each string are compared, just in case there is no difference. For example, Hebrew cantellation marks are only distinguished at this strength. This strength should be used sparingly, as only code point value differences between two strings are an extremely rare occurrence. Using this strength substantially decreases the performance for both comparison and collation key generation APIs. This strength also increases the size of the collation key. </para></li></ul></para><para>This <c> Collator </c> deals only with two decomposition modes, the canonical decomposition mode and one that does not use any decomposition. The compatibility decomposition mode <c> java.text.Collator.FULL_DECOMPOSITION </c> is not supported here. If the canonical decomposition mode is set, <c> Collator </c> handles un-normalized text properly, producing the same results as if the text were normalized in NFD. If canonical decomposition is turned off, it is the user's responsibility to ensure that all text is already in the appropriate form before performing a comparison or before getting a CollationKey. </para><para><b>Examples:</b> <blockquote><para></para><para><pre>
		///    // Get the Collator for US English and set its strength to PRIMARY
		///    Collator usCollator = Collator.getInstance(Locale.US);
		///    usCollator.setStrength(Collator.PRIMARY);
		///    if (usCollator.compare("abc", "ABC") == 0) {
		///        System.out.println("Strings are equivalent");
		///    }
		///    </pre></para><para></para></blockquote></para><para>The following example shows how to compare two strings using the collator for the default locale. <blockquote><para></para><para><pre>
		///    // Compare two strings in the default locale
		///    Collator myCollator = Collator.getInstance();
		///    myCollator.setDecomposition(Collator.NO_DECOMPOSITION);
		///    if (myCollator.compare("", "a") != 0) {
		///        System.out.println(" is not equal to a without decomposition");
		///        myCollator.setDecomposition(Collator.CANONICAL_DECOMPOSITION);
		///        if (myCollator.compare("", "a") != 0) {
		///            System.out.println("Error:  should be equal to a with decomposition");
		///        } else {
		///            System.out.println(" is equal to a with decomposition");
		///        }
		///    } else {
		///        System.out.println("Error:  should be not equal to a without decomposition");
		///    }
		///    </pre></para><para></para></blockquote></para><para><para>RuleBasedCollator </para><simplesectsep></simplesectsep><para>CollationKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/Collator
		/// </java-name>
		[Dot42.DexImport("java/text/Collator", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Ljava/lang/Object;>;Ljava/lang/Cloneable;" +
    "")]
		public abstract partial class Collator : global::Java.Util.IComparator<object>, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant used to specify the decomposition rule. </para>        
				/// </summary>
				/// <java-name>
				/// NO_DECOMPOSITION
				/// </java-name>
				[Dot42.DexImport("NO_DECOMPOSITION", "I", AccessFlags = 25)]
				public const int NO_DECOMPOSITION = 0;
				/// <summary>
				/// <para>Constant used to specify the decomposition rule. </para>        
				/// </summary>
				/// <java-name>
				/// CANONICAL_DECOMPOSITION
				/// </java-name>
				[Dot42.DexImport("CANONICAL_DECOMPOSITION", "I", AccessFlags = 25)]
				public const int CANONICAL_DECOMPOSITION = 1;
				/// <summary>
				/// <para>Constant used to specify the decomposition rule. This value for decomposition is not supported. </para>        
				/// </summary>
				/// <java-name>
				/// FULL_DECOMPOSITION
				/// </java-name>
				[Dot42.DexImport("FULL_DECOMPOSITION", "I", AccessFlags = 25)]
				public const int FULL_DECOMPOSITION = 2;
				/// <summary>
				/// <para>Constant used to specify the collation strength. </para>        
				/// </summary>
				/// <java-name>
				/// PRIMARY
				/// </java-name>
				[Dot42.DexImport("PRIMARY", "I", AccessFlags = 25)]
				public const int PRIMARY = 0;
				/// <summary>
				/// <para>Constant used to specify the collation strength. </para>        
				/// </summary>
				/// <java-name>
				/// SECONDARY
				/// </java-name>
				[Dot42.DexImport("SECONDARY", "I", AccessFlags = 25)]
				public const int SECONDARY = 1;
				/// <summary>
				/// <para>Constant used to specify the collation strength. </para>        
				/// </summary>
				/// <java-name>
				/// TERTIARY
				/// </java-name>
				[Dot42.DexImport("TERTIARY", "I", AccessFlags = 25)]
				public const int TERTIARY = 2;
				/// <summary>
				/// <para>Constant used to specify the collation strength. </para>        
				/// </summary>
				/// <java-name>
				/// IDENTICAL
				/// </java-name>
				[Dot42.DexImport("IDENTICAL", "I", AccessFlags = 25)]
				public const int IDENTICAL = 3;
				/// <summary>
				/// <para>Constructs a new <c> Collator </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Collator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new collator with the same decomposition mode and strength value as this collator.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this collator. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int Compare(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int Compare(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares this collator with the specified object and indicates if they are equal.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is a <c> Collator </c> object and it has the same strength and decomposition values as this collator; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares two strings using the collation rules to determine if they are equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> string1 </c> and <c> string2 </c> are equal using the collation rules, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Equals(string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> Collator </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <summary>
				/// <para>Returns a CollationKey for the specified string for this collator with the current decomposition rule and strength value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collation key for <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCollationKey
				/// </java-name>
				[Dot42.DexImport("getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", AccessFlags = 1025)]
				public abstract global::Java.Text.CollationKey GetCollationKey(string @string) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the decomposition rule for this collator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the decomposition rule, either <c> NO_DECOMPOSITION </c> or <c> CANONICAL_DECOMPOSITION </c> . <c> FULL_DECOMPOSITION </c> is not supported. </para>
				/// </returns>
				/// <java-name>
				/// getDecomposition
				/// </java-name>
				[Dot42.DexImport("getDecomposition", "()I", AccessFlags = 1)]
				public virtual int GetDecomposition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a <c> Collator </c> instance which is appropriate for the user's default <c> Locale </c> . See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Ljava/text/Collator;", AccessFlags = 9)]
				public static global::Java.Text.Collator GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Collator);
				}

				/// <summary>
				/// <para>Returns a <c> Collator </c> instance which is appropriate for <c> locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;", AccessFlags = 9)]
				public static global::Java.Text.Collator GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Collator);
				}

				/// <summary>
				/// <para>Returns the strength value for this collator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the strength value, either PRIMARY, SECONDARY, TERTIARY or IDENTICAL. </para>
				/// </returns>
				/// <java-name>
				/// getStrength
				/// </java-name>
				[Dot42.DexImport("getStrength", "()I", AccessFlags = 1)]
				public virtual int GetStrength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the decomposition rule for this collator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDecomposition
				/// </java-name>
				[Dot42.DexImport("setDecomposition", "(I)V", AccessFlags = 1)]
				public virtual void SetDecomposition(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the strength value for this collator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStrength
				/// </java-name>
				[Dot42.DexImport("setStrength", "(I)V", AccessFlags = 1)]
				public virtual void SetStrength(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> Collator </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns the decomposition rule for this collator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the decomposition rule, either <c> NO_DECOMPOSITION </c> or <c> CANONICAL_DECOMPOSITION </c> . <c> FULL_DECOMPOSITION </c> is not supported. </para>
				/// </returns>
				/// <java-name>
				/// getDecomposition
				/// </java-name>
				public int Decomposition
				{
				[Dot42.DexImport("getDecomposition", "()I", AccessFlags = 1)]
						get{ return GetDecomposition(); }
				[Dot42.DexImport("setDecomposition", "(I)V", AccessFlags = 1)]
						set{ SetDecomposition(value); }
				}

				/// <summary>
				/// <para>Returns a <c> Collator </c> instance which is appropriate for the user's default <c> Locale </c> . See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.Collator Instance
				{
				[Dot42.DexImport("getInstance", "()Ljava/text/Collator;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Returns the strength value for this collator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the strength value, either PRIMARY, SECONDARY, TERTIARY or IDENTICAL. </para>
				/// </returns>
				/// <java-name>
				/// getStrength
				/// </java-name>
				public int Strength
				{
				[Dot42.DexImport("getStrength", "()I", AccessFlags = 1)]
						get{ return GetStrength(); }
				[Dot42.DexImport("setStrength", "(I)V", AccessFlags = 1)]
						set{ SetStrength(value); }
				}

		}

		/// <summary>
		/// <para>Identifies fields in formatted strings. If a <c> FieldPosition </c> is passed to the format method with such a parameter, then the indices will be set to the start and end indices of the field in the formatted string. </para><para>A <c> FieldPosition </c> can be created by using the integer constants in the various format classes (for example <c> NumberFormat.INTEGER_FIELD </c> ) or one of the fields of type <c> Format.Field </c> . </para><para>If more than one field information is needed, the method NumberFormat#formatToCharacterIterator(Object) should be used. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/FieldPosition
		/// </java-name>
		[Dot42.DexImport("java/text/FieldPosition", AccessFlags = 33)]
		public partial class FieldPosition
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> FieldPosition </c> for the specified field.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public FieldPosition(int field) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> FieldPosition </c> for the specified field.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/text/Format$Field;)V", AccessFlags = 1)]
				public FieldPosition(global::Java.Text.Format.Field field) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> FieldPosition </c> for the specified <c> Field </c> attribute and field id.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/text/Format$Field;I)V", AccessFlags = 1)]
				public FieldPosition(global::Java.Text.Format.Field attribute, int field) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the specified object to this field position and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> FieldPosition </c> with the same field, begin index and end index.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this field position; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the index of the beginning of the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first index of the field. </para>
				/// </returns>
				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1)]
				public virtual int GetBeginIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the index one past the end of the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one past the index of the last character in the field. </para>
				/// </returns>
				/// <java-name>
				/// getEndIndex
				/// </java-name>
				[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1)]
				public virtual int GetEndIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the field which is being identified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field constant. </para>
				/// </returns>
				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "()I", AccessFlags = 1)]
				public virtual int GetField() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the attribute which is being identified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field. </para>
				/// </returns>
				/// <java-name>
				/// getFieldAttribute
				/// </java-name>
				[Dot42.DexImport("getFieldAttribute", "()Ljava/text/Format$Field;", AccessFlags = 1)]
				public virtual global::Java.Text.Format.Field GetFieldAttribute() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Format.Field);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the index of the beginning of the field.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBeginIndex
				/// </java-name>
				[Dot42.DexImport("setBeginIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetBeginIndex(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the index of the end of the field.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEndIndex
				/// </java-name>
				[Dot42.DexImport("setEndIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetEndIndex(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the string representation of this field position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this field position. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FieldPosition() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the index of the beginning of the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first index of the field. </para>
				/// </returns>
				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				public int BeginIndex
				{
				[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1)]
						get{ return GetBeginIndex(); }
				[Dot42.DexImport("setBeginIndex", "(I)V", AccessFlags = 1)]
						set{ SetBeginIndex(value); }
				}

				/// <summary>
				/// <para>Returns the index one past the end of the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one past the index of the last character in the field. </para>
				/// </returns>
				/// <java-name>
				/// getEndIndex
				/// </java-name>
				public int EndIndex
				{
				[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1)]
						get{ return GetEndIndex(); }
				[Dot42.DexImport("setEndIndex", "(I)V", AccessFlags = 1)]
						set{ SetEndIndex(value); }
				}

				/// <summary>
				/// <para>Returns the field which is being identified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field constant. </para>
				/// </returns>
				/// <java-name>
				/// getField
				/// </java-name>
				public int Field
				{
				[Dot42.DexImport("getField", "()I", AccessFlags = 1)]
						get{ return GetField(); }
				}

				/// <summary>
				/// <para>Returns the attribute which is being identified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field. </para>
				/// </returns>
				/// <java-name>
				/// getFieldAttribute
				/// </java-name>
				public global::Java.Text.Format.Field FieldAttribute
				{
				[Dot42.DexImport("getFieldAttribute", "()Ljava/text/Format$Field;", AccessFlags = 1)]
						get{ return GetFieldAttribute(); }
				}

		}

		/// <summary>
		/// <para>An implementation of CharacterIterator for strings. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/StringCharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/StringCharacterIterator", AccessFlags = 49)]
		public sealed partial class StringCharacterIterator : global::Java.Text.ICharacterIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> StringCharacterIterator </c> on the specified string. The begin and current indices are set to the beginning of the string, the end index is set to the length of the string.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringCharacterIterator(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> StringCharacterIterator </c> on the specified string with the current index set to the specified value. The begin index is set to the beginning of the string, the end index is set to the length of the string.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public StringCharacterIterator(string value, int location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> StringCharacterIterator </c> on the specified string with the begin, end and current index set to the specified values.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;III)V", AccessFlags = 1)]
				public StringCharacterIterator(string value, int start, int end, int location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> StringCharacterIterator </c> with the same source string, begin, end, and current index as this iterator.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this iterator. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the character at the current index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current character, or <c> DONE </c> if the current index is past the end. </para>
				/// </returns>
				/// <java-name>
				/// current
				/// </java-name>
				[Dot42.DexImport("current", "()C", AccessFlags = 1)]
				public char Current() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Compares the specified object with this <c> StringCharacterIterator </c> and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> StringCharacterIterator </c> that iterates over the same sequence of characters with the same index.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> StringCharacterIterator </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the current position to the begin index and returns the character at the new position in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the begin index or <c> DONE </c> if the begin index is equal to the end index. </para>
				/// </returns>
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()C", AccessFlags = 1)]
				public char First() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the begin index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first character of the iteration. </para>
				/// </returns>
				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1)]
				public int GetBeginIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the end index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index one past the last character of the iteration. </para>
				/// </returns>
				/// <java-name>
				/// getEndIndex
				/// </java-name>
				[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1)]
				public int GetEndIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the current index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current index. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the current position to the end index - 1 and returns the character at the new position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character before the end index or <c> DONE </c> if the begin index is equal to the end index. </para>
				/// </returns>
				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()C", AccessFlags = 1)]
				public char Last() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Increments the current index and returns the character at the new index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the next index, or <c> DONE </c> if the next index would be past the end. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()C", AccessFlags = 1)]
				public char Next() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Decrements the current index and returns the character at the new index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the previous index, or <c> DONE </c> if the previous index would be past the beginning. </para>
				/// </returns>
				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()C", AccessFlags = 1)]
				public char Previous() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Sets the current index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the new index, or <c> DONE </c> if <c> location </c> is set to the end index. </para>
				/// </returns>
				/// <java-name>
				/// setIndex
				/// </java-name>
				[Dot42.DexImport("setIndex", "(I)C", AccessFlags = 1)]
				public char SetIndex(int location) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Sets the source string to iterate over. The begin and end positions are set to the start and end of this string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetText(string value) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringCharacterIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the begin index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first character of the iteration. </para>
				/// </returns>
				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				public int BeginIndex
				{
				[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1)]
						get{ return GetBeginIndex(); }
				}

				/// <summary>
				/// <para>Returns the end index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index one past the last character of the iteration. </para>
				/// </returns>
				/// <java-name>
				/// getEndIndex
				/// </java-name>
				public int EndIndex
				{
				[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1)]
						get{ return GetEndIndex(); }
				}

				/// <summary>
				/// <para>Returns the current index in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current index. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				}

		}

		/// <summary>
		/// <para>Implements the .</para><para>Use a <c> Bidi </c> object to get the information on the position reordering of a bidirectional text, such as Arabic or Hebrew. The natural display ordering of horizontal text in these languages is from right to left, while they order numbers from left to right.</para><para>If the text contains multiple runs, the information of each run can be obtained from the run index. The level of any particular run indicates the direction of the text as well as the nesting level. Left-to-right runs have even levels while right-to-left runs have odd levels. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/Bidi
		/// </java-name>
		[Dot42.DexImport("java/text/Bidi", AccessFlags = 49)]
		public sealed partial class Bidi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant that indicates the default base level. If there is no strong character, then set the paragraph level to 0 (left-to-right). </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_DEFAULT_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_DEFAULT_LEFT_TO_RIGHT", "I", AccessFlags = 25)]
				public const int DIRECTION_DEFAULT_LEFT_TO_RIGHT = -2;
				/// <summary>
				/// <para>Constant that indicates the default base level. If there is no strong character, then set the paragraph level to 1 (right-to-left). </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_DEFAULT_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_DEFAULT_RIGHT_TO_LEFT", "I", AccessFlags = 25)]
				public const int DIRECTION_DEFAULT_RIGHT_TO_LEFT = -1;
				/// <summary>
				/// <para>Constant that specifies the default base level as 0 (left-to-right). </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_LEFT_TO_RIGHT", "I", AccessFlags = 25)]
				public const int DIRECTION_LEFT_TO_RIGHT = 0;
				/// <summary>
				/// <para>Constant that specifies the default base level as 1 (right-to-left). </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_RIGHT_TO_LEFT", "I", AccessFlags = 25)]
				public const int DIRECTION_RIGHT_TO_LEFT = 1;
				/// <summary>
				/// <para>Creates a <c> Bidi </c> object from the <c>       AttributedCharacterIterator </c> of a paragraph text. The RUN_DIRECTION attribute determines the base direction of the bidirectional text. If it is not specified explicitly, the algorithm uses DIRECTION_DEFAULT_LEFT_TO_RIGHT by default. The BIDI_EMBEDDING attribute specifies the level of embedding for each character. Values between -1 and -62 denote overrides at the level's absolute value, values from 1 to 62 indicate embeddings, and the 0 value indicates the level is calculated by the algorithm automatically. For the character with no BIDI_EMBEDDING attribute or with a improper attribute value, such as a <c> null </c> value, the algorithm treats its embedding level as 0. The NUMERIC_SHAPING attribute specifies the instance of NumericShaper used to convert European digits to other decimal digits before performing the bidi algorithm.</para><para><para>java.awt.font.TextAttribute::BIDI_EMBEDDING </para><simplesectsep></simplesectsep><para>java.awt.font.TextAttribute::NUMERIC_SHAPING </para><simplesectsep></simplesectsep><para>java.awt.font.TextAttribute::RUN_DIRECTION </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;)V", AccessFlags = 1)]
				public Bidi(global::Java.Text.IAttributedCharacterIterator paragraph) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Bidi </c> object.</para><para><para>DIRECTION_LEFT_TO_RIGHT </para><simplesectsep></simplesectsep><para>DIRECTION_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_DEFAULT_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_DEFAULT_LEFT_TO_RIGHT </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([CI[BIII)V", AccessFlags = 1)]
				public Bidi(char[] text, int textStart, sbyte[] embeddings, int embStart, int paragraphLength, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Bidi </c> object.</para><para><para>DIRECTION_LEFT_TO_RIGHT </para><simplesectsep></simplesectsep><para>DIRECTION_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_DEFAULT_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_DEFAULT_LEFT_TO_RIGHT </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([CI[BIII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Bidi(char[] text, int textStart, byte[] embeddings, int embStart, int paragraphLength, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Bidi </c> object.</para><para><para>DIRECTION_LEFT_TO_RIGHT </para><simplesectsep></simplesectsep><para>DIRECTION_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_DEFAULT_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_DEFAULT_LEFT_TO_RIGHT </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public Bidi(string paragraph, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the base level is from left to right.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the base level is from left to right. </para>
				/// </returns>
				/// <java-name>
				/// baseIsLeftToRight
				/// </java-name>
				[Dot42.DexImport("baseIsLeftToRight", "()Z", AccessFlags = 1)]
				public bool BaseIsLeftToRight() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Creates a new <c> Bidi </c> object containing the information of one line from this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new line Bidi object. In this new object, the indices will range from 0 to (limit - start - 1). </para>
				/// </returns>
				/// <java-name>
				/// createLineBidi
				/// </java-name>
				[Dot42.DexImport("createLineBidi", "(II)Ljava/text/Bidi;", AccessFlags = 1)]
				public global::Java.Text.Bidi CreateLineBidi(int lineStart, int lineLimit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Bidi);
				}

				/// <summary>
				/// <para>Returns the base level.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base level. </para>
				/// </returns>
				/// <java-name>
				/// getBaseLevel
				/// </java-name>
				[Dot42.DexImport("getBaseLevel", "()I", AccessFlags = 1)]
				public int GetBaseLevel() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the length of the text in the <c> Bidi </c> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the level of a specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the level. </para>
				/// </returns>
				/// <java-name>
				/// getLevelAt
				/// </java-name>
				[Dot42.DexImport("getLevelAt", "(I)I", AccessFlags = 1)]
				public int GetLevelAt(int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of runs in the bidirectional text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of runs, at least 1. </para>
				/// </returns>
				/// <java-name>
				/// getRunCount
				/// </java-name>
				[Dot42.DexImport("getRunCount", "()I", AccessFlags = 1)]
				public int GetRunCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the level of the specified run.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the level of the run. </para>
				/// </returns>
				/// <java-name>
				/// getRunLevel
				/// </java-name>
				[Dot42.DexImport("getRunLevel", "(I)I", AccessFlags = 1)]
				public int GetRunLevel(int run) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the limit offset of the specified run.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the limit offset of the run. </para>
				/// </returns>
				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "(I)I", AccessFlags = 1)]
				public int GetRunLimit(int run) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the start offset of the specified run.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the start offset of the run. </para>
				/// </returns>
				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "(I)I", AccessFlags = 1)]
				public int GetRunStart(int run) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether the text is from left to right, that is, both the base direction and the text direction is from left to right.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the text is from left to right; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLeftToRight
				/// </java-name>
				[Dot42.DexImport("isLeftToRight", "()Z", AccessFlags = 1)]
				public bool IsLeftToRight() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the text direction is mixed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the text direction is mixed; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isMixed
				/// </java-name>
				[Dot42.DexImport("isMixed", "()Z", AccessFlags = 1)]
				public bool IsMixed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the text is from right to left, that is, both the base direction and the text direction is from right to left.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the text is from right to left; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRightToLeft
				/// </java-name>
				[Dot42.DexImport("isRightToLeft", "()Z", AccessFlags = 1)]
				public bool IsRightToLeft() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Reorders a range of objects according to their specified levels. This is a convenience function that does not use a <c> Bidi </c> object. The range of objects at <c> index </c> from <c> objectStart </c> to <c>       objectStart + count </c> will be reordered according to the range of levels at <c> index </c> from <c> levelStart </c> to <c> levelStart + count </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// reorderVisually
				/// </java-name>
				[Dot42.DexImport("reorderVisually", "([BI[Ljava/lang/Object;II)V", AccessFlags = 9)]
				public static void ReorderVisually(sbyte[] levels, int levelStart, object[] objects, int objectStart, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reorders a range of objects according to their specified levels. This is a convenience function that does not use a <c> Bidi </c> object. The range of objects at <c> index </c> from <c> objectStart </c> to <c>       objectStart + count </c> will be reordered according to the range of levels at <c> index </c> from <c> levelStart </c> to <c> levelStart + count </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// reorderVisually
				/// </java-name>
				[Dot42.DexImport("reorderVisually", "([BI[Ljava/lang/Object;II)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void ReorderVisually(byte[] levels, int levelStart, object[] objects, int objectStart, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether a range of characters of a text requires a <c> Bidi </c> object to display properly.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the range of characters requires a <c> Bidi </c> object; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// requiresBidi
				/// </java-name>
				[Dot42.DexImport("requiresBidi", "([CII)Z", AccessFlags = 9)]
				public static bool RequiresBidi(char[] text, int start, int limit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Bidi() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the base level.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base level. </para>
				/// </returns>
				/// <java-name>
				/// getBaseLevel
				/// </java-name>
				public int BaseLevel
				{
				[Dot42.DexImport("getBaseLevel", "()I", AccessFlags = 1)]
						get{ return GetBaseLevel(); }
				}

				/// <summary>
				/// <para>Returns the length of the text in the <c> Bidi </c> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				}

				/// <summary>
				/// <para>Returns the number of runs in the bidirectional text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of runs, at least 1. </para>
				/// </returns>
				/// <java-name>
				/// getRunCount
				/// </java-name>
				public int RunCount
				{
				[Dot42.DexImport("getRunCount", "()I", AccessFlags = 1)]
						get{ return GetRunCount(); }
				}

		}

		/// <summary>
		/// <para>A concrete implementation class for <c> Collation </c> . </para><para><c> RuleBasedCollator </c> has the following restrictions for efficiency (other subclasses may be used for more complex languages): <ol><li><para>If a French secondary ordering is specified it applies to the whole collator object. </para></li><li><para>All non-mentioned Unicode characters are at the end of the collation order. </para></li><li><para>If a character is not located in the <c> RuleBasedCollator </c> , the default Unicode Collation Algorithm (UCA) rule-based table is automatically searched as a backup. </para></li></ol></para><para>The collation table is composed of a list of collation rules, where each rule is of three forms: <blockquote><para><pre>
		///    &lt;modifier&gt;
		///    &lt;relation&gt; &lt;text-argument&gt;
		///    &lt;reset&gt; &lt;text-argument&gt;
		///    </pre> </para></blockquote></para><para>The rule elements are defined as follows: <ul><li><para><b>Modifier</b>: There is a single modifier which is used to specify that all accents (secondary differences) are backwards: <ul><li><para>'@' : Indicates that accents are sorted backwards, as in French. </para></li></ul></para></li><li><para><b>Relation</b>: The relations are the following: <ul><li><para>'&lt;' : Greater, as a letter difference (primary) </para></li><li><para>';' : Greater, as an accent difference (secondary) </para></li><li><para>',' : Greater, as a case difference (tertiary) </para></li><li><para>'=' : Equal </para></li></ul></para></li><li><para><b>Text-Argument</b>: A text-argument is any sequence of characters, excluding special characters (that is, common whitespace characters [0009-000D, 0020] and rule syntax characters [0021-002F, 003A-0040, 005B-0060, 007B-007E]). If those characters are desired, you can put them in single quotes (for example, use '&amp;' for ampersand). Note that unquoted white space characters are ignored; for example, <c> b c </c> is treated as <c> bc </c> . </para></li><li><para><b>Reset</b>: There is a single reset which is used primarily for contractions and expansions, but which can also be used to add a modification at the end of a set of rules: <ul><li><para>'&amp;' : Indicates that the next rule follows the position to where the reset text-argument would be sorted. </para></li></ul></para></li></ul></para><para>This sounds more complicated than it is in practice. For example, the following are equivalent ways of expressing the same thing: <blockquote><para></para><para><pre>
		///    a &lt; b &lt; c
		///    a &lt; b &amp; b &lt; c
		///    a &lt; c &amp; a &lt; b
		///    </pre></para><para></para></blockquote></para><para>Notice that the order is important, as the subsequent item goes immediately after the text-argument. The following are not equivalent: <blockquote><para></para><para><pre>
		///    a &lt; b &amp; a &lt; c
		///    a &lt; c &amp; a &lt; b
		///    </pre></para><para></para></blockquote></para><para>Either the text-argument must already be present in the sequence, or some initial substring of the text-argument must be present. For example <c> "a &lt; b &amp; ae &lt; e" </c> is valid since "a" is present in the sequence before "ae" is reset. In this latter case, "ae" is not entered and treated as a single character; instead, "e" is sorted as if it were expanded to two characters: "a" followed by an "e". This difference appears in natural languages: in traditional Spanish "ch" is treated as if it contracts to a single character (expressed as <c> "c &lt; ch &lt; d" </c> ), while in traditional German a-umlaut is treated as if it expands to two characters (expressed as <c> "a,A &lt; b,B  ... &amp; ae;\u00e3 &amp; AE;\u00c3" </c> , where  and  are the escape sequences for a-umlaut). <h4>Ignorable Characters</h4></para><para>For ignorable characters, the first rule must start with a relation (the examples we have used above are really fragments; <c> "a &lt; b" </c> really should be <c> "&lt; a &lt; b" </c> ). If, however, the first relation is not <c> "&lt;" </c> , then all text-arguments up to the first <c> "&lt;" </c> are ignorable. For example, <c> ", - &lt; a &lt; b" </c> makes <c> "-" </c> an ignorable character. <h4>Normalization and Accents</h4></para><para><c> RuleBasedCollator </c> automatically processes its rule table to include both pre-composed and combining-character versions of accented characters. Even if the provided rule string contains only base characters and separate combining accent characters, the pre-composed accented characters matching all canonical combinations of characters from the rule string will be entered in the table. </para><para>This allows you to use a RuleBasedCollator to compare accented strings even when the collator is set to NO_DECOMPOSITION. However, if the strings to be collated contain combining sequences that may not be in canonical order, you should set the collator to CANONICAL_DECOMPOSITION to enable sorting of combining sequences. For more information, see . <h4>Errors</h4></para><para>The following rules are not valid: <ul><li><para>A text-argument contains unquoted punctuation symbols, for example <c> "a &lt; b-c &lt; d" </c> . </para></li><li><para>A relation or reset character is not followed by a text-argument, for example <c> "a &lt; , b" </c> . </para></li><li><para>A reset where the text-argument (or an initial substring of the text-argument) is not already in the sequence or allocated in the default UCA table, for example <c> "a &lt; b &amp; e &lt; f" </c> . </para></li></ul></para><para>If you produce one of these errors, <c> RuleBasedCollator </c> throws a <c> ParseException </c> . <h4>Examples</h4></para><para>Normally, to create a rule-based collator object, you will use <c> Collator </c> 's factory method <c> getInstance </c> . However, to create a rule-based collator object with specialized rules tailored to your needs, you construct the <c> RuleBasedCollator </c> with the rules contained in a <c> String </c> object. For example: <blockquote><para></para><para><pre>
		///    String Simple = "&lt; a &lt; b &lt; c &lt; d";
		///    RuleBasedCollator mySimple = new RuleBasedCollator(Simple);
		///    </pre></para><para></para></blockquote></para><para>Or: <blockquote><para></para><para><pre>
		///    String Norwegian = "&lt; a,A&lt; b,B&lt; c,C&lt; d,D&lt; e,E&lt; f,F&lt; g,G&lt; h,H&lt; i,I"<ul>
		/// <li><para>"&lt; j,J&lt; k,K&lt; l,L&lt; m,M&lt; n,N&lt; o,O&lt; p,P&lt; q,Q&lt; r,R"</para></li><li><para>"&lt; s,S&lt; t,T&lt; u,U&lt; v,V&lt; w,W&lt; x,X&lt; y,Y&lt; z,Z"</para></li><li><para>"&lt; \u00E5=a\u030A,\u00C5=A\u030A"</para></li><li><para>";aa,AA&lt; \u00E6,\u00C6&lt; \u00F8,\u00D8";
		///    RuleBasedCollator myNorwegian = new RuleBasedCollator(Norwegian);
		///    </para></li></ul>
		/// 
		/// 
		///    </pre></para></blockquote></para><para><pre>
		///    Combining  Collator 
		/// 
		///  s is as simple as concatenating strings. Here is
		///    an example that combines two  Collator 
		/// 
		///  s from two different locales:
		///    <blockquote><para></para><para><pre>
		///    // Create an en_US Collator object
		///    RuleBasedCollator en_USCollator = (RuleBasedCollator)Collator
		///            .getInstance(new Locale("en", "US", ""));
		/// 
		///    // Create a da_DK Collator object
		///    RuleBasedCollator da_DKCollator = (RuleBasedCollator)Collator
		///            .getInstance(new Locale("da", "DK", ""));
		/// 
		///    // Combine the two collators
		///    // First, get the collation rules from en_USCollator
		///    String en_USRules = en_USCollator.getRules();
		/// 
		///    // Second, get the collation rules from da_DKCollator
		///    String da_DKRules = da_DKCollator.getRules();
		/// 
		///    RuleBasedCollator newCollator = new RuleBasedCollator(en_USRules + da_DKRules);
		///    // newCollator has the combined rules
		///    </pre></para><para></para></blockquote>
		/// 
		/// 
		///    The next example shows to make changes on an existing table to create a new
		///     Collator 
		/// 
		///   object. For example, add  "&amp; C &lt; ch, cH, Ch, CH" 
		/// 
		///   to
		///    the  en_USCollator 
		/// 
		///   object to create your own:
		///    <blockquote><para></para><para><pre>
		///    // Create a new Collator object with additional rules
		///    String addRules = "&amp; C &lt; ch, cH, Ch, CH";
		/// 
		///    RuleBasedCollator myCollator = new RuleBasedCollator(en_USCollator + addRules);
		///    // myCollator contains the new rules
		///    </pre></para><para></para></blockquote>
		/// 
		/// 
		///    The following example demonstrates how to change the order of non-spacing
		///    accents:
		///    <blockquote><para></para><para><pre>
		///    // old rule
		///    String oldRules = "= \u00a8 ; \u00af ; \u00bf" + "&lt; a , A ; ae, AE ; \u00e6 , \u00c6"<ul>
		/// <li><para>"&lt; b , B &lt; c, C &lt; e, E &amp; C &lt; d, D";</para></li></ul>
		/// 
		/// 
		///    // change the order of accent characters
		///    String addOn = "&amp; \u00bf ; \u00af ; \u00a8;";
		/// 
		///    RuleBasedCollator myCollator = new RuleBasedCollator(oldRules + addOn);
		///    </pre></para><para></para></blockquote>
		/// 
		/// 
		///    The last example shows how to put new primary ordering in before the default
		///    setting. For example, in the Japanese  Collator 
		/// 
		///  , you can either sort
		///    English characters before or after Japanese characters:
		///    <blockquote><para></para><para><pre>
		///    // get en_US Collator rules
		///    RuleBasedCollator en_USCollator = (RuleBasedCollator)
		///        Collator.getInstance(Locale.US);
		/// 
		///    // add a few Japanese character to sort before English characters
		///    // suppose the last character before the first base letter 'a' in
		///    // the English collation rule is 
		///    String jaString = "&amp; \u30A2 , \u30FC &lt; \u30C8";
		/// 
		///    RuleBasedCollator myJapaneseCollator =
		///        new RuleBasedCollator(en_USCollator.getRules() + jaString);
		///    </pre></para><para></para></blockquote></pre></para>    
		/// </summary>
		/// <java-name>
		/// java/text/RuleBasedCollator
		/// </java-name>
		[Dot42.DexImport("java/text/RuleBasedCollator", AccessFlags = 33)]
		public partial class RuleBasedCollator : global::Java.Text.Collator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RuleBasedCollator(string wrapper) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a <c> CollationElementIterator </c> for the given <c> CharacterIterator </c> . The source iterator's integrity will be preserved since a new copy will be created for use.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> CollationElementIterator </c> for <c> source </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCollationElementIterator
				/// </java-name>
				[Dot42.DexImport("getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.CollationElementIterator GetCollationElementIterator(global::Java.Text.ICharacterIterator source) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.CollationElementIterator);
				}

				/// <summary>
				/// <para>Obtains a <c> CollationElementIterator </c> for the given <c> CharacterIterator </c> . The source iterator's integrity will be preserved since a new copy will be created for use.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> CollationElementIterator </c> for <c> source </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCollationElementIterator
				/// </java-name>
				[Dot42.DexImport("getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.CollationElementIterator GetCollationElementIterator(string source) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.CollationElementIterator);
				}

				/// <summary>
				/// <para>Returns the collation rules of this collator. These <c> rules </c> can be fed into the <c> RuleBasedCollator(String) </c> constructor. </para><para>Note that the <c> rules </c> are actually interpreted as a delta to the standard Unicode Collation Algorithm (UCA). Hence, an empty <c> rules </c> string results in the default UCA rules being applied. This differs slightly from other implementations which work with full <c> rules </c> specifications and may result in different behavior.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collation rules. </para>
				/// </returns>
				/// <java-name>
				/// getRules
				/// </java-name>
				[Dot42.DexImport("getRules", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetRules() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a new collator with the same collation rules, decomposition mode and strength value as this collator.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this collator. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the <c> source </c> text to the <c> target </c> text according to the collation rules, strength and decomposition mode for this <c> RuleBasedCollator </c> . See the <c> Collator </c> class description for an example of use. </para><para>General recommendation: If comparisons are to be done with the same strings multiple times, it is more efficient to generate <c> CollationKey </c> objects for the strings and use <c> CollationKey.compareTo(CollationKey) </c> for the comparisons. If each string is compared to only once, using <c> RuleBasedCollator.compare(String, String) </c> has better performance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an integer which may be a negative value, zero, or else a positive value depending on whether <c> source </c> is less than, equivalent to, or greater than <c> target </c> . </para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Compare(string source, string target) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the <c> CollationKey </c> for the given source text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> CollationKey </c> for the given source text. </para>
				/// </returns>
				/// <java-name>
				/// getCollationKey
				/// </java-name>
				[Dot42.DexImport("getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", AccessFlags = 1)]
				public override global::Java.Text.CollationKey GetCollationKey(string source) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.CollationKey);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified object with this <c> RuleBasedCollator </c> and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> Collator </c> with the same collation rules and the same attributes.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> RuleBasedCollator </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RuleBasedCollator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the collation rules of this collator. These <c> rules </c> can be fed into the <c> RuleBasedCollator(String) </c> constructor. </para><para>Note that the <c> rules </c> are actually interpreted as a delta to the standard Unicode Collation Algorithm (UCA). Hence, an empty <c> rules </c> string results in the default UCA rules being applied. This differs slightly from other implementations which work with full <c> rules </c> specifications and may result in different behavior.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collation rules. </para>
				/// </returns>
				/// <java-name>
				/// getRules
				/// </java-name>
				public string Rules
				{
				[Dot42.DexImport("getRules", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRules(); }
				}

		}

		/// <summary>
		/// <para>Represents a string under the rules of a specific <c> Collator </c> object. Comparing two <c> CollationKey </c> instances returns the relative order of the strings they represent. </para><para>Since the rule set of collators can differ, the sort orders of the same string under two different <c> Collator </c> instances might differ. Hence comparing collation keys generated from different <c> Collator </c> instances can give incorrect results. </para><para>Both the method <c> CollationKey.compareTo(CollationKey) </c> and the method <c> Collator.compare(String, String) </c> compares two strings and returns their relative order. The performance characteristics of these two approaches can differ. </para><para>During the construction of a <c> CollationKey </c> , the entire source string is examined and processed into a series of bits terminated by a null, that are stored in the <c> CollationKey </c> . When <c> CollationKey.compareTo(CollationKey) </c> executes, it performs bitwise comparison on the bit sequences. This can incur startup cost when creating the <c> CollationKey </c> , but once the key is created, binary comparisons are fast. This approach is recommended when the same strings are to be compared over and over again. </para><para>On the other hand, implementations of <c> Collator.compare(String, String) </c> can examine and process the strings only until the first characters differ in order. This approach is recommended if the strings are to be compared only once. </para><para>The following example shows how collation keys can be used to sort a list of strings: <blockquote><para></para><para><pre>
		///    // Create an array of CollationKeys for the Strings to be sorted.
		///    Collator myCollator = Collator.getInstance();
		///    CollationKey[] keys = new CollationKey[3];
		///    keys[0] = myCollator.getCollationKey("Tom");
		///    keys[1] = myCollator.getCollationKey("Dick");
		///    keys[2] = myCollator.getCollationKey("Harry");
		///    sort(keys);
		///    <br></br>
		/// 
		///    //...
		///    <br></br>
		/// 
		///    // Inside body of sort routine, compare keys this way
		///    if( keys[i].compareTo( keys[j] ) &gt; 0 )
		///       // swap keys[i] and keys[j]
		///    <br></br>
		/// 
		///    //...
		///    <br></br>
		/// 
		///    // Finally, when we've returned from sort.
		///    System.out.println(keys[0].getSourceString());
		///    System.out.println(keys[1].getSourceString());
		///    System.out.println(keys[2].getSourceString());
		///    </pre></para><para></para></blockquote></para><para><para>Collator </para><simplesectsep></simplesectsep><para>RuleBasedCollator </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/CollationKey
		/// </java-name>
		[Dot42.DexImport("java/text/CollationKey", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/text/CollationKey;>;")]
		public abstract partial class CollationKey : global::System.IComparable<global::Java.Text.CollationKey>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal CollationKey(string source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this collation key to the given collation key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this key is less than <c> value </c> , 0 if they are equal, and a positive value if this key is greater. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/text/CollationKey;)I", AccessFlags = 1025)]
				public virtual int CompareTo(global::Java.Text.CollationKey value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the string from which this collation key was created.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the source string of this collation key. </para>
				/// </returns>
				/// <java-name>
				/// getSourceString
				/// </java-name>
				[Dot42.DexImport("getSourceString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSourceString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns this collation key as a byte array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of bytes. </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaToByteArray() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns this collation key as a byte array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of bytes. </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] ToByteArray() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares this collation key to the given collation key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this key is less than <c> value </c> , 0 if they are equal, and a positive value if this key is greater. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I", AccessFlags = 4161)]
				public virtual int CompareTo(object value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CollationKey() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the string from which this collation key was created.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the source string of this collation key. </para>
				/// </returns>
				/// <java-name>
				/// getSourceString
				/// </java-name>
				public string SourceString
				{
				[Dot42.DexImport("getSourceString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSourceString(); }
				}

		}

		/// <summary>
		/// <para>An interface for the bidirectional iteration over a group of characters. The iteration starts at the begin index in the group of characters and continues to one index before the end index. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/CharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/CharacterIterator", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICharacterIteratorConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constant which indicates that there is no character at the current index. </para>        
				/// </summary>
				/// <java-name>
				/// DONE
				/// </java-name>
				[Dot42.DexImport("DONE", "C", AccessFlags = 25)]
				public const char DONE = '￿';
		}

		/// <summary>
		/// <para>An interface for the bidirectional iteration over a group of characters. The iteration starts at the begin index in the group of characters and continues to one index before the end index. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/CharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/CharacterIterator", AccessFlags = 1537)]
		public partial interface ICharacterIterator : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns a new <c> CharacterIterator </c> with the same properties.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this character iterator.</para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the character at the current index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current character, or <c> DONE </c> if the current index is past the beginning or end of the sequence. </para>
				/// </returns>
				/// <java-name>
				/// current
				/// </java-name>
				[Dot42.DexImport("current", "()C", AccessFlags = 1025)]
				char Current() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the current position to the begin index and returns the character at the new position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the begin index. </para>
				/// </returns>
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()C", AccessFlags = 1025)]
				char First() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the begin index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first character of the iteration. </para>
				/// </returns>
				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1025)]
				int GetBeginIndex() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the end index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index one past the last character of the iteration. </para>
				/// </returns>
				/// <java-name>
				/// getEndIndex
				/// </java-name>
				[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1025)]
				int GetEndIndex() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current index. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1025)]
				int GetIndex() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the current position to the end index - 1 and returns the character at the new position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character before the end index. </para>
				/// </returns>
				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()C", AccessFlags = 1025)]
				char Last() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Increments the current index and returns the character at the new index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the next index, or <c> DONE </c> if the next index would be past the end. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()C", AccessFlags = 1025)]
				char Next() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Decrements the current index and returns the character at the new index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the previous index, or <c> DONE </c> if the previous index would be past the beginning. </para>
				/// </returns>
				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()C", AccessFlags = 1025)]
				char Previous() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the current index to a new position and returns the character at the new index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the new index, or <c> DONE </c> if the index is past the end. </para>
				/// </returns>
				/// <java-name>
				/// setIndex
				/// </java-name>
				[Dot42.DexImport("setIndex", "(I)C", AccessFlags = 1025)]
				char SetIndex(int location) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Encapsulates localized date-time formatting data, such as the names of the months, the names of the days of the week, and the time zone data. <c> DateFormat </c> and <c> SimpleDateFormat </c> both use <c> DateFormatSymbols </c> to encapsulate this information.</para><para>Typically you shouldn't use <c> DateFormatSymbols </c> directly. Rather, you are encouraged to create a date/time formatter with the <c> DateFormat </c> class's factory methods: <c> getTimeInstance </c> , <c> getDateInstance </c> , or <c> getDateTimeInstance </c> . These methods automatically create a <c> DateFormatSymbols </c> for the formatter so that you don't have to. After the formatter is created, you may modify its format pattern using the <c> setPattern </c> method. For more information about creating formatters using <c> DateFormat </c> 's factory methods, see DateFormat.</para><para>Direct use of <c> DateFormatSymbols </c> is likely to be less efficient because the implementation cannot make assumptions about user-supplied/user-modifiable data to the same extent that it can with its own built-in data.</para><para><para>DateFormat </para><simplesectsep></simplesectsep><para>SimpleDateFormat </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/DateFormatSymbols
		/// </java-name>
		[Dot42.DexImport("java/text/DateFormatSymbols", AccessFlags = 33)]
		public partial class DateFormatSymbols : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> DateFormatSymbols </c> instance containing the symbols for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateFormatSymbols() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> DateFormatSymbols </c> instance containing the symbols for the specified locale.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public DateFormatSymbols(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> DateFormatSymbols </c> instance for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> DateFormatSymbols </c> </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Ljava/text/DateFormatSymbols;", AccessFlags = 25)]
				public static global::Java.Text.DateFormatSymbols GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormatSymbols);
				}

				/// <summary>
				/// <para>Returns a new <c> DateFormatSymbols </c> for the given locale.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> DateFormatSymbols </c> </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;", AccessFlags = 25)]
				public static global::Java.Text.DateFormatSymbols GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormatSymbols);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> DateFormatSymbols </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares this object with the specified object and indicates if they are equal.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is an instance of <c> DateFormatSymbols </c> and has the same symbols as this object, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the array of strings which represent AM and PM. Use the java.util.Calendar constants <c> Calendar.AM </c> and <c> Calendar.PM </c> as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getAmPmStrings
				/// </java-name>
				[Dot42.DexImport("getAmPmStrings", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetAmPmStrings() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the array of strings which represent BC and AD. Use the java.util.Calendar constants <c> GregorianCalendar.BC </c> and <c> GregorianCalendar.AD </c> as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getEras
				/// </java-name>
				[Dot42.DexImport("getEras", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetEras() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the pattern characters used by SimpleDateFormat to specify date and time fields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string containing the pattern characters. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPatternChars
				/// </java-name>
				[Dot42.DexImport("getLocalPatternChars", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocalPatternChars() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the array of strings containing the full names of the months. Use the java.util.Calendar constants <c> Calendar.JANUARY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getMonths
				/// </java-name>
				[Dot42.DexImport("getMonths", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetMonths() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the array of strings containing the abbreviated names of the months. Use the java.util.Calendar constants <c> Calendar.JANUARY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getShortMonths
				/// </java-name>
				[Dot42.DexImport("getShortMonths", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetShortMonths() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the array of strings containing the abbreviated names of the days of the week. Use the java.util.Calendar constants <c> Calendar.SUNDAY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getShortWeekdays
				/// </java-name>
				[Dot42.DexImport("getShortWeekdays", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetShortWeekdays() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the array of strings containing the full names of the days of the week. Use the java.util.Calendar constants <c> Calendar.SUNDAY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getWeekdays
				/// </java-name>
				[Dot42.DexImport("getWeekdays", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetWeekdays() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the two-dimensional array of strings containing localized names for time zones. Each row is an array of five strings: <ul><li><para>The time zone ID, for example "America/Los_Angeles". This is not localized, and is used as a key into the table. </para></li><li><para>The long display name, for example "Pacific Standard Time". </para></li><li><para>The short display name, for example "PST". </para></li><li><para>The long display name for DST, for example "Pacific Daylight Time". This is the non-DST long name for zones that have never had DST, for example "Central Standard Time" for "Canada/Saskatchewan". </para></li><li><para>The short display name for DST, for example "PDT". This is the non-DST short name for zones that have never had DST, for example "CST" for "Canada/Saskatchewan". </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getZoneStrings
				/// </java-name>
				[Dot42.DexImport("getZoneStrings", "()[[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[][] GetZoneStrings() /* MethodBuilder.Create */ 
				{
						return default(string[][]);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the array of strings which represent AM and PM. Use the java.util.Calendar constants <c> Calendar.AM </c> and <c> Calendar.PM </c> as indices for the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAmPmStrings
				/// </java-name>
				[Dot42.DexImport("setAmPmStrings", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAmPmStrings(string[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the array of Strings which represent BC and AD. Use the java.util.Calendar constants <c> GregorianCalendar.BC </c> and <c> GregorianCalendar.AD </c> as indices for the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEras
				/// </java-name>
				[Dot42.DexImport("setEras", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEras(string[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the pattern characters used by SimpleDateFormat to specify date and time fields.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLocalPatternChars
				/// </java-name>
				[Dot42.DexImport("setLocalPatternChars", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetLocalPatternChars(string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the array of strings containing the full names of the months. Use the java.util.Calendar constants <c> Calendar.JANUARY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMonths
				/// </java-name>
				[Dot42.DexImport("setMonths", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetMonths(string[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the array of strings containing the abbreviated names of the months. Use the java.util.Calendar constants <c> Calendar.JANUARY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setShortMonths
				/// </java-name>
				[Dot42.DexImport("setShortMonths", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetShortMonths(string[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the array of strings containing the abbreviated names of the days of the week. Use the java.util.Calendar constants <c> Calendar.SUNDAY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setShortWeekdays
				/// </java-name>
				[Dot42.DexImport("setShortWeekdays", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetShortWeekdays(string[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the array of strings containing the full names of the days of the week. Use the java.util.Calendar constants <c> Calendar.SUNDAY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWeekdays
				/// </java-name>
				[Dot42.DexImport("setWeekdays", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetWeekdays(string[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the two-dimensional array of strings containing localized names for time zones. See getZoneStrings for details. </para>        
				/// </summary>
				/// <java-name>
				/// setZoneStrings
				/// </java-name>
				[Dot42.DexImport("setZoneStrings", "([[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetZoneStrings(string[][] zoneStrings) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> DateFormatSymbols </c> instance for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> DateFormatSymbols </c> </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.DateFormatSymbols Instance
				{
				[Dot42.DexImport("getInstance", "()Ljava/text/DateFormatSymbols;", AccessFlags = 25)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> DateFormatSymbols </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns the array of strings which represent AM and PM. Use the java.util.Calendar constants <c> Calendar.AM </c> and <c> Calendar.PM </c> as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getAmPmStrings
				/// </java-name>
				public string[] AmPmStrings
				{
				[Dot42.DexImport("getAmPmStrings", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAmPmStrings(); }
				[Dot42.DexImport("setAmPmStrings", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetAmPmStrings(value); }
				}

				/// <summary>
				/// <para>Returns the array of strings which represent BC and AD. Use the java.util.Calendar constants <c> GregorianCalendar.BC </c> and <c> GregorianCalendar.AD </c> as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getEras
				/// </java-name>
				public string[] Eras
				{
				[Dot42.DexImport("getEras", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEras(); }
				[Dot42.DexImport("setEras", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetEras(value); }
				}

				/// <summary>
				/// <para>Returns the pattern characters used by SimpleDateFormat to specify date and time fields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string containing the pattern characters. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPatternChars
				/// </java-name>
				public string LocalPatternChars
				{
				[Dot42.DexImport("getLocalPatternChars", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocalPatternChars(); }
				[Dot42.DexImport("setLocalPatternChars", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetLocalPatternChars(value); }
				}

				/// <summary>
				/// <para>Returns the array of strings containing the full names of the months. Use the java.util.Calendar constants <c> Calendar.JANUARY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getMonths
				/// </java-name>
				public string[] Months
				{
				[Dot42.DexImport("getMonths", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMonths(); }
				[Dot42.DexImport("setMonths", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetMonths(value); }
				}

				/// <summary>
				/// <para>Returns the array of strings containing the abbreviated names of the months. Use the java.util.Calendar constants <c> Calendar.JANUARY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getShortMonths
				/// </java-name>
				public string[] ShortMonths
				{
				[Dot42.DexImport("getShortMonths", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetShortMonths(); }
				[Dot42.DexImport("setShortMonths", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetShortMonths(value); }
				}

				/// <summary>
				/// <para>Returns the array of strings containing the abbreviated names of the days of the week. Use the java.util.Calendar constants <c> Calendar.SUNDAY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getShortWeekdays
				/// </java-name>
				public string[] ShortWeekdays
				{
				[Dot42.DexImport("getShortWeekdays", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetShortWeekdays(); }
				[Dot42.DexImport("setShortWeekdays", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetShortWeekdays(value); }
				}

				/// <summary>
				/// <para>Returns the array of strings containing the full names of the days of the week. Use the java.util.Calendar constants <c> Calendar.SUNDAY </c> etc. as indices for the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of strings. </para>
				/// </returns>
				/// <java-name>
				/// getWeekdays
				/// </java-name>
				public string[] Weekdays
				{
				[Dot42.DexImport("getWeekdays", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetWeekdays(); }
				[Dot42.DexImport("setWeekdays", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetWeekdays(value); }
				}

				/// <summary>
				/// <para>Returns the two-dimensional array of strings containing localized names for time zones. Each row is an array of five strings: <ul><li><para>The time zone ID, for example "America/Los_Angeles". This is not localized, and is used as a key into the table. </para></li><li><para>The long display name, for example "Pacific Standard Time". </para></li><li><para>The short display name, for example "PST". </para></li><li><para>The long display name for DST, for example "Pacific Daylight Time". This is the non-DST long name for zones that have never had DST, for example "Central Standard Time" for "Canada/Saskatchewan". </para></li><li><para>The short display name for DST, for example "PDT". This is the non-DST short name for zones that have never had DST, for example "CST" for "Canada/Saskatchewan". </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getZoneStrings
				/// </java-name>
				public string[][] ZoneStrings
				{
				[Dot42.DexImport("getZoneStrings", "()[[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetZoneStrings(); }
				[Dot42.DexImport("setZoneStrings", "([[Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetZoneStrings(value); }
				}

		}

		/// <summary>
		/// <para>Encapsulates the set of symbols (such as the decimal separator, the grouping separator, and so on) needed by <c> DecimalFormat </c> to format numbers. <c> DecimalFormat </c> internally creates an instance of <c> DecimalFormatSymbols </c> from its locale data. If you need to change any of these symbols, you can get the <c> DecimalFormatSymbols </c> object from your <c> DecimalFormat </c> and modify it.</para><para><para>java.util.Locale </para><simplesectsep></simplesectsep><para>DecimalFormat </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/DecimalFormatSymbols
		/// </java-name>
		[Dot42.DexImport("java/text/DecimalFormatSymbols", AccessFlags = 33)]
		public partial class DecimalFormatSymbols : global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> DecimalFormatSymbols </c> containing the symbols for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". Best practice is to create a <c> DecimalFormat </c> and then to get the <c> DecimalFormatSymbols </c> from that object by calling DecimalFormat#getDecimalFormatSymbols(). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DecimalFormatSymbols() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new DecimalFormatSymbols containing the symbols for the specified Locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". Best practice is to create a <c> DecimalFormat </c> and then to get the <c> DecimalFormatSymbols </c> from that object by calling DecimalFormat#getDecimalFormatSymbols().</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public DecimalFormatSymbols(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> DecimalFormatSymbols </c> instance for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> DecimalFormatSymbols </c> </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Ljava/text/DecimalFormatSymbols;", AccessFlags = 9)]
				public static global::Java.Text.DecimalFormatSymbols GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DecimalFormatSymbols);
				}

				/// <summary>
				/// <para>Returns a new <c> DecimalFormatSymbols </c> for the given locale.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> DecimalFormatSymbols </c> </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;", AccessFlags = 9)]
				public static global::Java.Text.DecimalFormatSymbols GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DecimalFormatSymbols);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> DecimalFormatSymbols </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object to this <c> DecimalFormatSymbols </c> and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> DecimalFormatSymbols </c> and contain the same symbols.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> DecimalFormatSymbols </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the currency. </para><para><c> null </c> is returned if <c> setInternationalCurrencySymbol() </c> has been previously called with a value that is not a valid ISO 4217 currency code. </para><para><para>setCurrency(Currency) </para><simplesectsep></simplesectsep><para>setInternationalCurrencySymbol(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency that was set in the constructor or by calling <c> setCurrency() </c> or <c> setInternationalCurrencySymbol() </c> , or <c> null </c> if an invalid currency was set. </para>
				/// </returns>
				/// <java-name>
				/// getCurrency
				/// </java-name>
				[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
				public virtual global::Java.Util.Currency GetCurrency() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <summary>
				/// <para>Returns the international currency symbol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the international currency symbol as string. </para>
				/// </returns>
				/// <java-name>
				/// getInternationalCurrencySymbol
				/// </java-name>
				[Dot42.DexImport("getInternationalCurrencySymbol", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInternationalCurrencySymbol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the currency symbol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency symbol as string. </para>
				/// </returns>
				/// <java-name>
				/// getCurrencySymbol
				/// </java-name>
				[Dot42.DexImport("getCurrencySymbol", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCurrencySymbol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the character which represents the decimal point in a number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the decimal separator character. </para>
				/// </returns>
				/// <java-name>
				/// getDecimalSeparator
				/// </java-name>
				[Dot42.DexImport("getDecimalSeparator", "()C", AccessFlags = 1)]
				public virtual char GetDecimalSeparator() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the character which represents a single digit in a format pattern.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the digit pattern character. </para>
				/// </returns>
				/// <java-name>
				/// getDigit
				/// </java-name>
				[Dot42.DexImport("getDigit", "()C", AccessFlags = 1)]
				public virtual char GetDigit() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the character used as the thousands separator in a number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thousands separator character. </para>
				/// </returns>
				/// <java-name>
				/// getGroupingSeparator
				/// </java-name>
				[Dot42.DexImport("getGroupingSeparator", "()C", AccessFlags = 1)]
				public virtual char GetGroupingSeparator() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the string which represents infinity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the infinity symbol as a string. </para>
				/// </returns>
				/// <java-name>
				/// getInfinity
				/// </java-name>
				[Dot42.DexImport("getInfinity", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInfinity() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the minus sign character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minus sign as a character. </para>
				/// </returns>
				/// <java-name>
				/// getMinusSign
				/// </java-name>
				[Dot42.DexImport("getMinusSign", "()C", AccessFlags = 1)]
				public virtual char GetMinusSign() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the character which represents the decimal point in a monetary value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the monetary decimal point as a character. </para>
				/// </returns>
				/// <java-name>
				/// getMonetaryDecimalSeparator
				/// </java-name>
				[Dot42.DexImport("getMonetaryDecimalSeparator", "()C", AccessFlags = 1)]
				public virtual char GetMonetaryDecimalSeparator() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the string which represents NaN.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the symbol NaN as a string. </para>
				/// </returns>
				/// <java-name>
				/// getNaN
				/// </java-name>
				[Dot42.DexImport("getNaN", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNaN() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the character which separates the positive and negative patterns in a format pattern.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pattern separator character. </para>
				/// </returns>
				/// <java-name>
				/// getPatternSeparator
				/// </java-name>
				[Dot42.DexImport("getPatternSeparator", "()C", AccessFlags = 1)]
				public virtual char GetPatternSeparator() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the percent character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the percent character. </para>
				/// </returns>
				/// <java-name>
				/// getPercent
				/// </java-name>
				[Dot42.DexImport("getPercent", "()C", AccessFlags = 1)]
				public virtual char GetPercent() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the per mill sign character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the per mill sign character. </para>
				/// </returns>
				/// <java-name>
				/// getPerMill
				/// </java-name>
				[Dot42.DexImport("getPerMill", "()C", AccessFlags = 1)]
				public virtual char GetPerMill() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the character which represents zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zero character. </para>
				/// </returns>
				/// <java-name>
				/// getZeroDigit
				/// </java-name>
				[Dot42.DexImport("getZeroDigit", "()C", AccessFlags = 1)]
				public virtual char GetZeroDigit() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getExponentSeparator
				/// </java-name>
				[Dot42.DexImport("getExponentSeparator", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetExponentSeparator() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the currency. </para><para>The international currency symbol and the currency symbol are updated, but the min and max number of fraction digits stays the same. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrency
				/// </java-name>
				[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
				public virtual void SetCurrency(global::Java.Util.Currency currency) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the international currency symbol. </para><para>The currency and currency symbol are also updated if <c> value </c> is a valid ISO4217 currency code. </para><para>The min and max number of fraction digits stay the same.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInternationalCurrencySymbol
				/// </java-name>
				[Dot42.DexImport("setInternationalCurrencySymbol", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetInternationalCurrencySymbol(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the currency symbol.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrencySymbol
				/// </java-name>
				[Dot42.DexImport("setCurrencySymbol", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCurrencySymbol(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the character which represents the decimal point in a number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDecimalSeparator
				/// </java-name>
				[Dot42.DexImport("setDecimalSeparator", "(C)V", AccessFlags = 1)]
				public virtual void SetDecimalSeparator(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the character which represents a single digit in a format pattern.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDigit
				/// </java-name>
				[Dot42.DexImport("setDigit", "(C)V", AccessFlags = 1)]
				public virtual void SetDigit(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the character used as the thousands separator in a number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupingSeparator
				/// </java-name>
				[Dot42.DexImport("setGroupingSeparator", "(C)V", AccessFlags = 1)]
				public virtual void SetGroupingSeparator(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the string which represents infinity.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInfinity
				/// </java-name>
				[Dot42.DexImport("setInfinity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetInfinity(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the minus sign character.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinusSign
				/// </java-name>
				[Dot42.DexImport("setMinusSign", "(C)V", AccessFlags = 1)]
				public virtual void SetMinusSign(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the character which represents the decimal point in a monetary value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMonetaryDecimalSeparator
				/// </java-name>
				[Dot42.DexImport("setMonetaryDecimalSeparator", "(C)V", AccessFlags = 1)]
				public virtual void SetMonetaryDecimalSeparator(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the string which represents NaN.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNaN
				/// </java-name>
				[Dot42.DexImport("setNaN", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetNaN(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the character which separates the positive and negative patterns in a format pattern.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPatternSeparator
				/// </java-name>
				[Dot42.DexImport("setPatternSeparator", "(C)V", AccessFlags = 1)]
				public virtual void SetPatternSeparator(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the percent character.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPercent
				/// </java-name>
				[Dot42.DexImport("setPercent", "(C)V", AccessFlags = 1)]
				public virtual void SetPercent(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the per mill sign character.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPerMill
				/// </java-name>
				[Dot42.DexImport("setPerMill", "(C)V", AccessFlags = 1)]
				public virtual void SetPerMill(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the character which represents zero.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setZeroDigit
				/// </java-name>
				[Dot42.DexImport("setZeroDigit", "(C)V", AccessFlags = 1)]
				public virtual void SetZeroDigit(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the string used to separate mantissa and exponent. Typically "E", as in "1.2E3". <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setExponentSeparator
				/// </java-name>
				[Dot42.DexImport("setExponentSeparator", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetExponentSeparator(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> DecimalFormatSymbols </c> instance for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> DecimalFormatSymbols </c> </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.DecimalFormatSymbols Instance
				{
				[Dot42.DexImport("getInstance", "()Ljava/text/DecimalFormatSymbols;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> DecimalFormatSymbols </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns the currency. </para><para><c> null </c> is returned if <c> setInternationalCurrencySymbol() </c> has been previously called with a value that is not a valid ISO 4217 currency code. </para><para><para>setCurrency(Currency) </para><simplesectsep></simplesectsep><para>setInternationalCurrencySymbol(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency that was set in the constructor or by calling <c> setCurrency() </c> or <c> setInternationalCurrencySymbol() </c> , or <c> null </c> if an invalid currency was set. </para>
				/// </returns>
				/// <java-name>
				/// getCurrency
				/// </java-name>
				public global::Java.Util.Currency Currency
				{
				[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
						get{ return GetCurrency(); }
				[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
						set{ SetCurrency(value); }
				}

				/// <summary>
				/// <para>Returns the international currency symbol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the international currency symbol as string. </para>
				/// </returns>
				/// <java-name>
				/// getInternationalCurrencySymbol
				/// </java-name>
				public string InternationalCurrencySymbol
				{
				[Dot42.DexImport("getInternationalCurrencySymbol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInternationalCurrencySymbol(); }
				[Dot42.DexImport("setInternationalCurrencySymbol", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetInternationalCurrencySymbol(value); }
				}

				/// <summary>
				/// <para>Returns the currency symbol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency symbol as string. </para>
				/// </returns>
				/// <java-name>
				/// getCurrencySymbol
				/// </java-name>
				public string CurrencySymbol
				{
				[Dot42.DexImport("getCurrencySymbol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCurrencySymbol(); }
				[Dot42.DexImport("setCurrencySymbol", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCurrencySymbol(value); }
				}

				/// <summary>
				/// <para>Returns the character which represents the decimal point in a number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the decimal separator character. </para>
				/// </returns>
				/// <java-name>
				/// getDecimalSeparator
				/// </java-name>
				public char DecimalSeparator
				{
				[Dot42.DexImport("getDecimalSeparator", "()C", AccessFlags = 1)]
						get{ return GetDecimalSeparator(); }
				[Dot42.DexImport("setDecimalSeparator", "(C)V", AccessFlags = 1)]
						set{ SetDecimalSeparator(value); }
				}

				/// <summary>
				/// <para>Returns the character which represents a single digit in a format pattern.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the digit pattern character. </para>
				/// </returns>
				/// <java-name>
				/// getDigit
				/// </java-name>
				public char Digit
				{
				[Dot42.DexImport("getDigit", "()C", AccessFlags = 1)]
						get{ return GetDigit(); }
				[Dot42.DexImport("setDigit", "(C)V", AccessFlags = 1)]
						set{ SetDigit(value); }
				}

				/// <summary>
				/// <para>Returns the character used as the thousands separator in a number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thousands separator character. </para>
				/// </returns>
				/// <java-name>
				/// getGroupingSeparator
				/// </java-name>
				public char GroupingSeparator
				{
				[Dot42.DexImport("getGroupingSeparator", "()C", AccessFlags = 1)]
						get{ return GetGroupingSeparator(); }
				[Dot42.DexImport("setGroupingSeparator", "(C)V", AccessFlags = 1)]
						set{ SetGroupingSeparator(value); }
				}

				/// <summary>
				/// <para>Returns the string which represents infinity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the infinity symbol as a string. </para>
				/// </returns>
				/// <java-name>
				/// getInfinity
				/// </java-name>
				public string Infinity
				{
				[Dot42.DexImport("getInfinity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInfinity(); }
				[Dot42.DexImport("setInfinity", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetInfinity(value); }
				}

				/// <summary>
				/// <para>Returns the minus sign character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minus sign as a character. </para>
				/// </returns>
				/// <java-name>
				/// getMinusSign
				/// </java-name>
				public char MinusSign
				{
				[Dot42.DexImport("getMinusSign", "()C", AccessFlags = 1)]
						get{ return GetMinusSign(); }
				[Dot42.DexImport("setMinusSign", "(C)V", AccessFlags = 1)]
						set{ SetMinusSign(value); }
				}

				/// <summary>
				/// <para>Returns the character which represents the decimal point in a monetary value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the monetary decimal point as a character. </para>
				/// </returns>
				/// <java-name>
				/// getMonetaryDecimalSeparator
				/// </java-name>
				public char MonetaryDecimalSeparator
				{
				[Dot42.DexImport("getMonetaryDecimalSeparator", "()C", AccessFlags = 1)]
						get{ return GetMonetaryDecimalSeparator(); }
				[Dot42.DexImport("setMonetaryDecimalSeparator", "(C)V", AccessFlags = 1)]
						set{ SetMonetaryDecimalSeparator(value); }
				}

				/// <summary>
				/// <para>Returns the string which represents NaN.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the symbol NaN as a string. </para>
				/// </returns>
				/// <java-name>
				/// getNaN
				/// </java-name>
				public string NaN
				{
				[Dot42.DexImport("getNaN", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNaN(); }
				[Dot42.DexImport("setNaN", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetNaN(value); }
				}

				/// <summary>
				/// <para>Returns the character which separates the positive and negative patterns in a format pattern.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pattern separator character. </para>
				/// </returns>
				/// <java-name>
				/// getPatternSeparator
				/// </java-name>
				public char PatternSeparator
				{
				[Dot42.DexImport("getPatternSeparator", "()C", AccessFlags = 1)]
						get{ return GetPatternSeparator(); }
				[Dot42.DexImport("setPatternSeparator", "(C)V", AccessFlags = 1)]
						set{ SetPatternSeparator(value); }
				}

				/// <summary>
				/// <para>Returns the percent character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the percent character. </para>
				/// </returns>
				/// <java-name>
				/// getPercent
				/// </java-name>
				public char Percent
				{
				[Dot42.DexImport("getPercent", "()C", AccessFlags = 1)]
						get{ return GetPercent(); }
				[Dot42.DexImport("setPercent", "(C)V", AccessFlags = 1)]
						set{ SetPercent(value); }
				}

				/// <summary>
				/// <para>Returns the per mill sign character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the per mill sign character. </para>
				/// </returns>
				/// <java-name>
				/// getPerMill
				/// </java-name>
				public char PerMill
				{
				[Dot42.DexImport("getPerMill", "()C", AccessFlags = 1)]
						get{ return GetPerMill(); }
				[Dot42.DexImport("setPerMill", "(C)V", AccessFlags = 1)]
						set{ SetPerMill(value); }
				}

				/// <summary>
				/// <para>Returns the character which represents zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zero character. </para>
				/// </returns>
				/// <java-name>
				/// getZeroDigit
				/// </java-name>
				public char ZeroDigit
				{
				[Dot42.DexImport("getZeroDigit", "()C", AccessFlags = 1)]
						get{ return GetZeroDigit(); }
				[Dot42.DexImport("setZeroDigit", "(C)V", AccessFlags = 1)]
						set{ SetZeroDigit(value); }
				}

				/// <java-name>
				/// getExponentSeparator
				/// </java-name>
				public string ExponentSeparator
				{
				[Dot42.DexImport("getExponentSeparator", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetExponentSeparator(); }
				[Dot42.DexImport("setExponentSeparator", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetExponentSeparator(value); }
				}

		}

		/// <summary>
		/// <para>Produces concatenated messages in language-neutral way. New code should probably use java.util.Formatter instead. </para><para><c> MessageFormat </c> takes a set of objects, formats them and then inserts the formatted strings into the pattern at the appropriate places. </para><para><b>Note:</b> <c> MessageFormat </c> differs from the other <c> Format </c> classes in that you create a <c> MessageFormat </c> object with one of its constructors (not with a <c> getInstance </c> style factory method). The factory methods aren't necessary because <c> MessageFormat </c> itself doesn't implement locale-specific behavior. Any locale-specific behavior is defined by the pattern that you provide as well as the subformats used for inserted arguments.</para><para><h4>Patterns and their interpretation</h4></para><para><c> MessageFormat </c> uses patterns of the following form: <blockquote><para></para><para><pre>
		///    <b>MessageFormatPattern:</b>
		///            <b>String</b>
		///            <b>MessageFormatPattern</b> <b>FormatElement</b> <b>String</b>
		///    <b>FormatElement:</b>
		///            { <b>ArgumentIndex</b> }
		///            { <b>ArgumentIndex</b> , <b>FormatType</b> }
		///            { <b>ArgumentIndex</b> , <b>FormatType</b> , <b>FormatStyle</b> }
		///    <b>FormatType: one of </b>
		///            number date time choice
		///    <b>FormatStyle:</b>
		///            short
		///            medium
		///            long
		///            full
		///            integer
		///            currency
		///            percent
		///            <b>SubformatPattern</b>
		///    <b>String:</b>
		///            <b>StringPart&lt;sub&gt;opt&lt;/sub&gt;</b>
		///            <b>String</b> <b>StringPart</b>
		///    <b>StringPart:</b>
		///            ''
		///            ' <b>QuotedString</b> '
		///            <b>UnquotedString</b>
		///    <b>SubformatPattern:</b>
		///            <b>SubformatPatternPart&lt;sub&gt;opt&lt;/sub&gt;</b>
		///            <b>SubformatPattern</b> <b>SubformatPatternPart</b>
		///    <b>SubFormatPatternPart:</b>
		///            ' <b>QuotedPattern</b> '
		///            <b>UnquotedPattern</b>
		///    </pre></para><para></para></blockquote></para><para>Within a <b>String</b>, <c> "''" </c> represents a single quote. A <b>QuotedString</b> can contain arbitrary characters except single quotes; the surrounding single quotes are removed. An <b>UnquotedString</b> can contain arbitrary characters except single quotes and left curly brackets. Thus, a string that should result in the formatted message "'{0}'" can be written as <c> "'''{'0}''" </c> or <c> "'''{0}'''" </c> . </para><para>Within a <b>SubformatPattern</b>, different rules apply. A <b>QuotedPattern</b> can contain arbitrary characters except single quotes, but the surrounding single quotes are <b>not</b> removed, so they may be interpreted by the subformat. For example, <c> "{1,number,$'#',##}" </c> will produce a number format with the hash-sign quoted, with a result such as: "$#31,45". An <b>UnquotedPattern</b> can contain arbitrary characters except single quotes, but curly braces within it must be balanced. For example, <c> "ab {0} de" </c> and <c> "ab ' </c> ' de"} are valid subformat   patterns, but {@code "ab {0'}' de"} and {@code "ab } de"} are not. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/MessageFormat
		/// </java-name>
		[Dot42.DexImport("java/text/MessageFormat", AccessFlags = 33)]
		public partial class MessageFormat : global::Java.Text.Format
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> MessageFormat </c> using the specified pattern and <c> locale </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public MessageFormat(string template, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> MessageFormat </c> using the specified pattern and the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MessageFormat(string template) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes this <c> MessageFormat </c> to use the specified pattern.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string template) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new instance of <c> MessageFormat </c> with the same pattern and formats as this <c> MessageFormat </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> MessageFormat </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object to this <c> MessageFormat </c> and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> MessageFormat </c> and have the same pattern.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> MessageFormat </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Formats the specified object using the rules of this message format and returns an <c> AttributedCharacterIterator </c> with the formatted message and attributes. The <c> AttributedCharacterIterator </c> returned also includes the attributes from the formats of this message format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> AttributedCharacterIterator </c> with the formatted message and attributes. </para>
				/// </returns>
				/// <java-name>
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public override global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/" +
    "StringBuffer;", AccessFlags = 17)]
				public global::Java.Lang.StringBuffer Format(object[] @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 17)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				/// <para>Formats the supplied objects using the specified message format pattern.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted result. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 137)]
				public static string Format(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Format </c> instances used by this message format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of <c> Format </c> instances. </para>
				/// </returns>
				/// <java-name>
				/// getFormats
				/// </java-name>
				[Dot42.DexImport("getFormats", "()[Ljava/text/Format;", AccessFlags = 1)]
				public virtual global::Java.Text.Format[] GetFormats() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Format[]);
				}

				/// <summary>
				/// <para>Returns the formats used for each argument index. If an argument is placed more than once in the pattern string, then this returns the format of the last one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of formats, ordered by argument index. </para>
				/// </returns>
				/// <java-name>
				/// getFormatsByArgumentIndex
				/// </java-name>
				[Dot42.DexImport("getFormatsByArgumentIndex", "()[Ljava/text/Format;", AccessFlags = 1)]
				public virtual global::Java.Text.Format[] GetFormatsByArgumentIndex() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Format[]);
				}

				/// <summary>
				/// <para>Sets the format used for the argument at index <c> argIndex </c> to <c> format </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFormatByArgumentIndex
				/// </java-name>
				[Dot42.DexImport("setFormatByArgumentIndex", "(ILjava/text/Format;)V", AccessFlags = 1)]
				public virtual void SetFormatByArgumentIndex(int argIndex, global::Java.Text.Format format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the formats used for each argument. The <c> formats </c> array elements should be in the order of the argument indices.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFormatsByArgumentIndex
				/// </java-name>
				[Dot42.DexImport("setFormatsByArgumentIndex", "([Ljava/text/Format;)V", AccessFlags = 1)]
				public virtual void SetFormatsByArgumentIndex(global::Java.Text.Format[] formats) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the locale used when creating formats.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale used to create formats. </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the message arguments from the specified string using the rules of this message format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of <c> Object </c> arguments resulting from the parse. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				/// <para>Parses the message argument from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of objects resulting from the parse, or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] Parse(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				/// <para>Parses the message argument from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of objects resulting from the parse, or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object ParseObject(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets the specified format used by this message format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFormat
				/// </java-name>
				[Dot42.DexImport("setFormat", "(ILjava/text/Format;)V", AccessFlags = 1)]
				public virtual void SetFormat(int offset, global::Java.Text.Format format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the formats used by this message format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFormats
				/// </java-name>
				[Dot42.DexImport("setFormats", "([Ljava/text/Format;)V", AccessFlags = 1)]
				public virtual void SetFormats(global::Java.Text.Format[] formats) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the locale to use when creating <c> Format </c> instances. Changing the locale may change the behavior of <c> applyPattern </c> , <c> toPattern </c> , <c> format </c> and <c> formatToCharacterIterator </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the pattern of this message format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pattern. </para>
				/// </returns>
				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MessageFormat() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Format </c> instances used by this message format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of <c> Format </c> instances. </para>
				/// </returns>
				/// <java-name>
				/// getFormats
				/// </java-name>
				public global::Java.Text.Format[] Formats
				{
				[Dot42.DexImport("getFormats", "()[Ljava/text/Format;", AccessFlags = 1)]
						get{ return GetFormats(); }
				[Dot42.DexImport("setFormats", "([Ljava/text/Format;)V", AccessFlags = 1)]
						set{ SetFormats(value); }
				}

				/// <summary>
				/// <para>Returns the formats used for each argument index. If an argument is placed more than once in the pattern string, then this returns the format of the last one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of formats, ordered by argument index. </para>
				/// </returns>
				/// <java-name>
				/// getFormatsByArgumentIndex
				/// </java-name>
				public global::Java.Text.Format[] FormatsByArgumentIndex
				{
				[Dot42.DexImport("getFormatsByArgumentIndex", "()[Ljava/text/Format;", AccessFlags = 1)]
						get{ return GetFormatsByArgumentIndex(); }
				[Dot42.DexImport("setFormatsByArgumentIndex", "([Ljava/text/Format;)V", AccessFlags = 1)]
						set{ SetFormatsByArgumentIndex(value); }
				}

				/// <summary>
				/// <para>Returns the locale used when creating formats.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale used to create formats. </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLocale(); }
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
						set{ SetLocale(value); }
				}

				/// <summary>
				/// <para>The instances of this inner class are used as attribute keys in <c> AttributedCharacterIterator </c> that the MessageFormat#formatToCharacterIterator(Object) method returns. </para><para>There is no public constructor in this class, the only instances are the constants defined here. </para>    
				/// </summary>
				/// <java-name>
				/// java/text/MessageFormat$Field
				/// </java-name>
				[Dot42.DexImport("java/text/MessageFormat$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.Format.Field
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>This constant stands for the message argument. </para>        
						/// </summary>
						/// <java-name>
						/// ARGUMENT
						/// </java-name>
						[Dot42.DexImport("ARGUMENT", "Ljava/text/MessageFormat$Field;", AccessFlags = 25)]
						public static readonly Field ARGUMENT;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Field(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Thrown when the string being parsed is not in the correct form. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/ParseException
		/// </java-name>
		[Dot42.DexImport("java/text/ParseException", AccessFlags = 33)]
		public partial class ParseException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this class with its stack trace, detail message and the location of the error filled in.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public ParseException(string detailMessage, int location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the index at which this parse exception occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the location of this exception in the parsed string. </para>
				/// </returns>
				/// <java-name>
				/// getErrorOffset
				/// </java-name>
				[Dot42.DexImport("getErrorOffset", "()I", AccessFlags = 1)]
				public virtual int GetErrorOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParseException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the index at which this parse exception occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the location of this exception in the parsed string. </para>
				/// </returns>
				/// <java-name>
				/// getErrorOffset
				/// </java-name>
				public int ErrorOffset
				{
				[Dot42.DexImport("getErrorOffset", "()I", AccessFlags = 1)]
						get{ return GetErrorOffset(); }
				}

		}

		/// <summary>
		/// <para>Provides normalization functions according to . Normalization can decompose and compose characters for equivalency checking.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/Normalizer
		/// </java-name>
		[Dot42.DexImport("java/text/Normalizer", AccessFlags = 49)]
		public sealed partial class Normalizer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Normalizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Check whether the given character sequence <code>src</code> is normalized according to the normalization method <code>form</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if normalized according to <code>form</code> </para>
				/// </returns>
				/// <java-name>
				/// isNormalized
				/// </java-name>
				[Dot42.DexImport("isNormalized", "(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Z", AccessFlags = 9)]
				public static bool IsNormalized(global::Java.Lang.ICharSequence src, global::Java.Text.Normalizer.Form form) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Normalize the character sequence <code>src</code> according to the normalization method <code>form</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>string normalized according to <code>form</code> </para>
				/// </returns>
				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Normalize(global::Java.Lang.ICharSequence src, global::Java.Text.Normalizer.Form form) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// java/text/Normalizer$Form
				/// </java-name>
				[Dot42.DexImport("java/text/Normalizer$Form", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/text/Normalizer$Form;>;")]
				public sealed class Form
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NFC
						/// </java-name>
						[Dot42.DexImport("NFC", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFC;
						/// <java-name>
						/// NFD
						/// </java-name>
						[Dot42.DexImport("NFD", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFD;
						/// <java-name>
						/// NFKC
						/// </java-name>
						[Dot42.DexImport("NFKC", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFKC;
						/// <java-name>
						/// NFKD
						/// </java-name>
						[Dot42.DexImport("NFKD", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFKD;
						private Form() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>The abstract base class for all number formats. This class provides the interface for formatting and parsing numbers. <c> NumberFormat </c> also provides methods for determining which locales have number formats, and what their names are. </para><para><c> NumberFormat </c> helps you to format and parse numbers for any locale. Your code can be completely independent of the locale conventions for decimal points, thousands-separators, or even the particular decimal digits used, or whether the number format is even decimal. </para><para>To format a number for the current locale, use one of the factory class methods: <blockquote><para></para><para><pre>
		///    myString = NumberFormat.getInstance().format(myNumber);
		///    </pre></para><para></para></blockquote></para><para>If you are formatting multiple numbers, it is more efficient to get the format and use it multiple times so that the system doesn't have to fetch the information about the local language and country conventions multiple times. <blockquote><para></para><para><pre>
		///    NumberFormat nf = NumberFormat.getInstance();
		///    for (int i = 0; i &lt; a.length; ++i) {
		///        output.println(nf.format(myNumber[i]) + "; ");
		///    }
		///    </pre></para><para></para></blockquote></para><para>To format a number for a different locale, specify it in the call to <c> getInstance </c> . <blockquote><para></para><para><pre>
		///    NumberFormat nf = NumberFormat.getInstance(Locale.FRENCH);
		///    </pre></para><para></para></blockquote></para><para>You can also use a <c> NumberFormat </c> to parse numbers: <blockquote><para></para><para><pre>
		///    myNumber = nf.parse(myString);
		///    </pre></para><para></para></blockquote></para><para>Use <c> #getInstance </c> or <c> #getNumberInstance </c> to get the default number format. Use getIntegerInstance to get an integer number format, getCurrencyInstance to get the currency number format, and getPercentInstance to get a format for displaying percentages.</para><para>You can also control the display of numbers with methods such as <c> setMinimumFractionDigits </c> . If you want even more control over the format or parsing, or want to give your users more control, you can try casting the <c> NumberFormat </c> you get from the factory methods to a <c> DecimalFormat </c> . This will work for the vast majority of locales; just remember to put it in a <c> try </c> block in case you encounter an unusual one. </para><para><c> NumberFormat </c> is designed such that some controls work for formatting and others work for parsing. For example, <c> setParseIntegerOnly </c> only affects parsing: If set to <c> true </c> , "3456.78" is parsed as 3456 (and leaves the parse position just after '6'); if set to <c> false </c> , "3456.78" is parsed as 3456.78 (and leaves the parse position just after '8'). This is independent of formatting. </para><para>You can also use forms of the <c> parse </c> and <c> format </c> methods with <c> ParsePosition </c> and <c> FieldPosition </c> to allow you to: <ul><li><para>progressively parse through pieces of a string; </para></li><li><para>align the decimal point and other areas. </para></li></ul>For example, you can align numbers in two ways: <ol><li><para>If you are using a monospaced font with spacing for alignment, you can pass the <c> FieldPosition </c> in your format call, with <c> field </c> = <c> INTEGER_FIELD </c> . On output, <c> getEndIndex </c> will be set to the offset between the last character of the integer and the decimal. Add (desiredSpaceCount - getEndIndex) spaces to the front of the string. </para></li><li><para>If you are using proportional fonts, instead of padding with spaces, measure the width of the string in pixels from the start to <c> getEndIndex </c> . Then move the pen by (desiredPixelWidth - widthToAlignmentPoint) before drawing the text. This also works where there is no decimal but possibly additional characters before or after the number, for example with parentheses in negative numbers: "(12)" for -12. </para></li></ol><h4>Synchronization</h4></para><para>Number formats are generally not synchronized. It is recommended to create separate format instances for each thread. If multiple threads access a format concurrently, it must be synchronized externally. </para><para><h4>DecimalFormat</h4></para><para><c> DecimalFormat </c> is the concrete implementation of <c> NumberFormat </c> , and the <c> NumberFormat </c> API is essentially an abstraction of <c> DecimalFormat's </c> API. Refer to <c> DecimalFormat </c> for more information about this API.</para><para><para>DecimalFormat </para><simplesectsep></simplesectsep><para>java.text.ChoiceFormat </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/NumberFormat
		/// </java-name>
		[Dot42.DexImport("java/text/NumberFormat", AccessFlags = 1057)]
		public abstract partial class NumberFormat : global::Java.Text.Format
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Field constant identifying the integer part of a number. </para>        
				/// </summary>
				/// <java-name>
				/// INTEGER_FIELD
				/// </java-name>
				[Dot42.DexImport("INTEGER_FIELD", "I", AccessFlags = 25)]
				public const int INTEGER_FIELD = 0;
				/// <summary>
				/// <para>Field constant identifying the fractional part of a number. </para>        
				/// </summary>
				/// <java-name>
				/// FRACTION_FIELD
				/// </java-name>
				[Dot42.DexImport("FRACTION_FIELD", "I", AccessFlags = 25)]
				public const int FRACTION_FIELD = 1;
				/// <summary>
				/// <para>Used by subclasses. This was public in Java 5. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal NumberFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> NumberFormat </c> with the same properties. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object to this number format and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> NumberFormat </c> with the same pattern and properties.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this number format; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(D)Ljava/lang/String;", AccessFlags = 17)]
				public string Format(double @double) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer Format(double @double, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(J)Ljava/lang/String;", AccessFlags = 17)]
				public string Format(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer Format(long int64, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> NumberFormat </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <summary>
				/// <para>Returns the currency used by this number format. </para><para>This implementation throws <c> UnsupportedOperationException </c> , concrete subclasses should override this method if they support currency formatting. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency that was set in getInstance() or in setCurrency(), or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCurrency
				/// </java-name>
				[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
				public virtual global::Java.Util.Currency GetCurrency() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing currency values for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling currency values. </para>
				/// </returns>
				/// <java-name>
				/// getCurrencyInstance
				/// </java-name>
				[Dot42.DexImport("getCurrencyInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
				public static global::Java.Text.NumberFormat GetCurrencyInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing currency values for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling currency values. </para>
				/// </returns>
				/// <java-name>
				/// getCurrencyInstance
				/// </java-name>
				[Dot42.DexImport("getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetCurrencyInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing integers for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling integers. </para>
				/// </returns>
				/// <java-name>
				/// getIntegerInstance
				/// </java-name>
				[Dot42.DexImport("getIntegerInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
				public static global::Java.Text.NumberFormat GetIntegerInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing integers for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling integers. </para>
				/// </returns>
				/// <java-name>
				/// getIntegerInstance
				/// </java-name>
				[Dot42.DexImport("getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetIntegerInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing numbers for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling <c> Number </c> objects. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
				public static global::Java.Text.NumberFormat GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing numbers for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling <c> Number </c> objects. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns the maximum number of fraction digits that are printed when formatting. If the maximum is less than the number of fraction digits, the least significant digits are truncated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of fraction digits. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumFractionDigits
				/// </java-name>
				[Dot42.DexImport("getMaximumFractionDigits", "()I", AccessFlags = 1)]
				public virtual int GetMaximumFractionDigits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the maximum number of integer digits that are printed when formatting. If the maximum is less than the number of integer digits, the most significant digits are truncated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of integer digits. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumIntegerDigits
				/// </java-name>
				[Dot42.DexImport("getMaximumIntegerDigits", "()I", AccessFlags = 1)]
				public virtual int GetMaximumIntegerDigits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum number of fraction digits that are printed when formatting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum number of fraction digits. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumFractionDigits
				/// </java-name>
				[Dot42.DexImport("getMinimumFractionDigits", "()I", AccessFlags = 1)]
				public virtual int GetMinimumFractionDigits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum number of integer digits that are printed when formatting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum number of integer digits. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumIntegerDigits
				/// </java-name>
				[Dot42.DexImport("getMinimumIntegerDigits", "()I", AccessFlags = 1)]
				public virtual int GetMinimumIntegerDigits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing numbers for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling <c> Number </c> objects. </para>
				/// </returns>
				/// <java-name>
				/// getNumberInstance
				/// </java-name>
				[Dot42.DexImport("getNumberInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
				public static global::Java.Text.NumberFormat GetNumberInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing numbers for the specified locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling <c> Number </c> objects. </para>
				/// </returns>
				/// <java-name>
				/// getNumberInstance
				/// </java-name>
				[Dot42.DexImport("getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetNumberInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing percentage values for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para>The <c> NumberFormat </c> returned by this method should only be used to format floating-point numbers typically between 0 and 1 (with 1 being 100%). A value such as 0.53 will be treated as 53%, but 53.0 (or the integer 53) will be treated as 5,300%, which is rarely what you intended. </para>        
				/// </summary>
				/// <java-name>
				/// getPercentInstance
				/// </java-name>
				[Dot42.DexImport("getPercentInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
				public static global::Java.Text.NumberFormat GetPercentInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing percentage values for the given <c> locale </c> .</para><para>The <c> NumberFormat </c> returned by this method should only be used to format floating-point numbers typically between 0 and 1 (with 1 being 100%). A value such as 0.53 will be treated as 53%, but 53.0 (or the integer 53) will be treated as 5,300%, which is rarely what you intended. </para>        
				/// </summary>
				/// <java-name>
				/// getPercentInstance
				/// </java-name>
				[Dot42.DexImport("getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetPercentInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this number format formats and parses numbers using a grouping separator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if a grouping separator is used; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isGroupingUsed
				/// </java-name>
				[Dot42.DexImport("isGroupingUsed", "()Z", AccessFlags = 1)]
				public virtual bool IsGroupingUsed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this number format only parses integer numbers. Parsing stops if a decimal separator is encountered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this number format only parses integers, <c> false </c> if if parsese integers as well as fractions. </para>
				/// </returns>
				/// <java-name>
				/// isParseIntegerOnly
				/// </java-name>
				[Dot42.DexImport("isParseIntegerOnly", "()Z", AccessFlags = 1)]
				public virtual bool IsParseIntegerOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Parses a <c> Number </c> from the specified string using the rules of this number format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Number </c> resulting from the parsing. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/lang/Number;", AccessFlags = 1)]
				public virtual global::Java.Lang.Number Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Number);
				}

				/// <summary>
				/// <para>Parses a <c> Number </c> from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Number </c> resulting from the parse or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", AccessFlags = 1025)]
				public abstract global::Java.Lang.Number Parse(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object resulting from the parse or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 17)]
				public override object ParseObject(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets the currency used by this number format when formatting currency values. The min and max fraction digits remain the same. </para><para>This implementation throws <c> UnsupportedOperationException </c> , concrete subclasses should override this method if they support currency formatting.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrency
				/// </java-name>
				[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
				public virtual void SetCurrency(global::Java.Util.Currency currency) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether this number format formats and parses numbers using a grouping separator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupingUsed
				/// </java-name>
				[Dot42.DexImport("setGroupingUsed", "(Z)V", AccessFlags = 1)]
				public virtual void SetGroupingUsed(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the maximum number of fraction digits that are printed when formatting. If the maximum is less than the number of fraction digits, the least significant digits are truncated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaximumFractionDigits
				/// </java-name>
				[Dot42.DexImport("setMaximumFractionDigits", "(I)V", AccessFlags = 1)]
				public virtual void SetMaximumFractionDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the new maximum count of integer digits that are printed when formatting. If the maximum is less than the number of integer digits, the most significant digits are truncated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaximumIntegerDigits
				/// </java-name>
				[Dot42.DexImport("setMaximumIntegerDigits", "(I)V", AccessFlags = 1)]
				public virtual void SetMaximumIntegerDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the minimum number of fraction digits that are printed when formatting.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinimumFractionDigits
				/// </java-name>
				[Dot42.DexImport("setMinimumFractionDigits", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimumFractionDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the minimum number of integer digits that are printed when formatting.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinimumIntegerDigits
				/// </java-name>
				[Dot42.DexImport("setMinimumIntegerDigits", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimumIntegerDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies if this number format should parse numbers only as integers or else as any kind of number. If this method is called with a <c> true </c> value then subsequent parsing attempts will stop if a decimal separator is encountered.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParseIntegerOnly
				/// </java-name>
				[Dot42.DexImport("setParseIntegerOnly", "(Z)V", AccessFlags = 1)]
				public virtual void SetParseIntegerOnly(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> RoundingMode </c> used by this <c> NumberFormat </c> . The default implementation in <c> NumberFormat </c> throws <c> UnsupportedOperationException </c> . Subclasses for which a rounding mode is meaningful are expected to override this method. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
				public virtual global::Java.Math.RoundingMode GetRoundingMode() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode);
				}

				/// <summary>
				/// <para>Sets the <c> RoundingMode </c> used by this <c> NumberFormat </c> . The default implementation in <c> NumberFormat </c> throws <c> UnsupportedOperationException </c> . Subclasses for which a rounding mode is meaningful are expected to override this method. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setRoundingMode
				/// </java-name>
				[Dot42.DexImport("setRoundingMode", "(Ljava/math/RoundingMode;)V", AccessFlags = 1)]
				public virtual void SetRoundingMode(global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> NumberFormat </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns the currency used by this number format. </para><para>This implementation throws <c> UnsupportedOperationException </c> , concrete subclasses should override this method if they support currency formatting. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency that was set in getInstance() or in setCurrency(), or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCurrency
				/// </java-name>
				public global::Java.Util.Currency Currency
				{
				[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
						get{ return GetCurrency(); }
				[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
						set{ SetCurrency(value); }
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing currency values for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling currency values. </para>
				/// </returns>
				/// <java-name>
				/// getCurrencyInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat CurrencyInstance
				{
				[Dot42.DexImport("getCurrencyInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return GetCurrencyInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing integers for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling integers. </para>
				/// </returns>
				/// <java-name>
				/// getIntegerInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat IntegerInstance
				{
				[Dot42.DexImport("getIntegerInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return GetIntegerInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing numbers for the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling <c> Number </c> objects. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat Instance
				{
				[Dot42.DexImport("getInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Returns the maximum number of fraction digits that are printed when formatting. If the maximum is less than the number of fraction digits, the least significant digits are truncated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of fraction digits. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumFractionDigits
				/// </java-name>
				public int MaximumFractionDigits
				{
				[Dot42.DexImport("getMaximumFractionDigits", "()I", AccessFlags = 1)]
						get{ return GetMaximumFractionDigits(); }
				[Dot42.DexImport("setMaximumFractionDigits", "(I)V", AccessFlags = 1)]
						set{ SetMaximumFractionDigits(value); }
				}

				/// <summary>
				/// <para>Returns the maximum number of integer digits that are printed when formatting. If the maximum is less than the number of integer digits, the most significant digits are truncated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of integer digits. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumIntegerDigits
				/// </java-name>
				public int MaximumIntegerDigits
				{
				[Dot42.DexImport("getMaximumIntegerDigits", "()I", AccessFlags = 1)]
						get{ return GetMaximumIntegerDigits(); }
				[Dot42.DexImport("setMaximumIntegerDigits", "(I)V", AccessFlags = 1)]
						set{ SetMaximumIntegerDigits(value); }
				}

				/// <summary>
				/// <para>Returns the minimum number of fraction digits that are printed when formatting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum number of fraction digits. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumFractionDigits
				/// </java-name>
				public int MinimumFractionDigits
				{
				[Dot42.DexImport("getMinimumFractionDigits", "()I", AccessFlags = 1)]
						get{ return GetMinimumFractionDigits(); }
				[Dot42.DexImport("setMinimumFractionDigits", "(I)V", AccessFlags = 1)]
						set{ SetMinimumFractionDigits(value); }
				}

				/// <summary>
				/// <para>Returns the minimum number of integer digits that are printed when formatting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum number of integer digits. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumIntegerDigits
				/// </java-name>
				public int MinimumIntegerDigits
				{
				[Dot42.DexImport("getMinimumIntegerDigits", "()I", AccessFlags = 1)]
						get{ return GetMinimumIntegerDigits(); }
				[Dot42.DexImport("setMinimumIntegerDigits", "(I)V", AccessFlags = 1)]
						set{ SetMinimumIntegerDigits(value); }
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing numbers for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> NumberFormat </c> for handling <c> Number </c> objects. </para>
				/// </returns>
				/// <java-name>
				/// getNumberInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat NumberInstance
				{
				[Dot42.DexImport("getNumberInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return GetNumberInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> NumberFormat </c> for formatting and parsing percentage values for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para>The <c> NumberFormat </c> returned by this method should only be used to format floating-point numbers typically between 0 and 1 (with 1 being 100%). A value such as 0.53 will be treated as 53%, but 53.0 (or the integer 53) will be treated as 5,300%, which is rarely what you intended. </para>        
				/// </summary>
				/// <java-name>
				/// getPercentInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat PercentInstance
				{
				[Dot42.DexImport("getPercentInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return GetPercentInstance(); }
				}

				/// <summary>
				/// <para>Returns the <c> RoundingMode </c> used by this <c> NumberFormat </c> . The default implementation in <c> NumberFormat </c> throws <c> UnsupportedOperationException </c> . Subclasses for which a rounding mode is meaningful are expected to override this method. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public global::Java.Math.RoundingMode RoundingMode
				{
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return GetRoundingMode(); }
				[Dot42.DexImport("setRoundingMode", "(Ljava/math/RoundingMode;)V", AccessFlags = 1)]
						set{ SetRoundingMode(value); }
				}

				/// <summary>
				/// <para>The instances of this inner class are used as attribute keys and values in <c> AttributedCharacterIterator </c> that the NumberFormat#formatToCharacterIterator(Object) method returns. </para><para>There is no public constructor in this class, the only instances are the constants defined here. </para>    
				/// </summary>
				/// <java-name>
				/// java/text/NumberFormat$Field
				/// </java-name>
				[Dot42.DexImport("java/text/NumberFormat$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.Format.Field
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>This constant stands for the number sign. </para>        
						/// </summary>
						/// <java-name>
						/// SIGN
						/// </java-name>
						[Dot42.DexImport("SIGN", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field SIGN;
						/// <summary>
						/// <para>This constant stands for the integer part of the number. </para>        
						/// </summary>
						/// <java-name>
						/// INTEGER
						/// </java-name>
						[Dot42.DexImport("INTEGER", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field INTEGER;
						/// <summary>
						/// <para>This constant stands for the fraction part of the number. </para>        
						/// </summary>
						/// <java-name>
						/// FRACTION
						/// </java-name>
						[Dot42.DexImport("FRACTION", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field FRACTION;
						/// <summary>
						/// <para>This constant stands for the exponent part of the number. </para>        
						/// </summary>
						/// <java-name>
						/// EXPONENT
						/// </java-name>
						[Dot42.DexImport("EXPONENT", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field EXPONENT;
						/// <summary>
						/// <para>This constant stands for the exponent sign symbol. </para>        
						/// </summary>
						/// <java-name>
						/// EXPONENT_SIGN
						/// </java-name>
						[Dot42.DexImport("EXPONENT_SIGN", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field EXPONENT_SIGN;
						/// <summary>
						/// <para>This constant stands for the exponent symbol. </para>        
						/// </summary>
						/// <java-name>
						/// EXPONENT_SYMBOL
						/// </java-name>
						[Dot42.DexImport("EXPONENT_SYMBOL", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field EXPONENT_SYMBOL;
						/// <summary>
						/// <para>This constant stands for the decimal separator. </para>        
						/// </summary>
						/// <java-name>
						/// DECIMAL_SEPARATOR
						/// </java-name>
						[Dot42.DexImport("DECIMAL_SEPARATOR", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field DECIMAL_SEPARATOR;
						/// <summary>
						/// <para>This constant stands for the grouping separator. </para>        
						/// </summary>
						/// <java-name>
						/// GROUPING_SEPARATOR
						/// </java-name>
						[Dot42.DexImport("GROUPING_SEPARATOR", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field GROUPING_SEPARATOR;
						/// <summary>
						/// <para>This constant stands for the percent symbol. </para>        
						/// </summary>
						/// <java-name>
						/// PERCENT
						/// </java-name>
						[Dot42.DexImport("PERCENT", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field PERCENT;
						/// <summary>
						/// <para>This constant stands for the permille symbol. </para>        
						/// </summary>
						/// <java-name>
						/// PERMILLE
						/// </java-name>
						[Dot42.DexImport("PERMILLE", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field PERMILLE;
						/// <summary>
						/// <para>This constant stands for the currency symbol. </para>        
						/// </summary>
						/// <java-name>
						/// CURRENCY
						/// </java-name>
						[Dot42.DexImport("CURRENCY", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field CURRENCY;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Field(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Locates boundaries in text. This class defines a protocol for objects that break up a piece of natural-language text according to a set of criteria. Instances or subclasses of <c> BreakIterator </c> can be provided, for example, to break a piece of text into words, sentences, or logical characters according to the conventions of some language or group of languages. We provide four built-in types of <c> BreakIterator </c> : <ul><li><para>getSentenceInstance() returns a <c> BreakIterator </c> that locates boundaries between sentences. This is useful for triple-click selection, for example. </para></li><li><para>getWordInstance() returns a <c> BreakIterator </c> that locates boundaries between words. This is useful for double-click selection or "find   whole words" searches. This type of <c> BreakIterator </c> makes sure there is a boundary position at the beginning and end of each legal word (numbers count as words, too). Whitespace and punctuation are kept separate from real words. </para></li><li><para><c> getLineInstance() </c> returns a <c> BreakIterator </c> that locates positions where it is legal for a text editor to wrap lines. This is similar to word breaking, but not the same: punctuation and whitespace are generally kept with words (you don't want a line to start with whitespace, for example), and some special characters can force a position to be considered a line break position or prevent a position from being a line break position. </para></li><li><para><c> getCharacterInstance() </c> returns a <c> BreakIterator </c> that locates boundaries between logical characters. Because of the structure of the Unicode encoding, a logical character may be stored internally as more than one Unicode code point. (A with an umlaut may be stored as an a followed by a separate combining umlaut character, for example, but the user still thinks of it as one character.) This iterator allows various processes (especially text editors) to treat as characters the units of text that a user would think of as characters, rather than the units of text that the computer sees as "characters". </para></li></ul><c> BreakIterator </c> 's interface follows an "iterator" model (hence the name), meaning it has a concept of a "current position" and methods like <c> first() </c> , <c> last() </c> , <c> next() </c> , and <c> previous() </c> that update the current position. All <c> BreakIterator </c> s uphold the following invariants: <ul><li><para>The beginning and end of the text are always treated as boundary positions. </para></li><li><para>The current position of the iterator is always a boundary position (random- access methods move the iterator to the nearest boundary position before or after the specified position, not <b>to</b> the specified position). </para></li><li><para><c> DONE </c> is used as a flag to indicate when iteration has stopped. <c> DONE </c> is only returned when the current position is the end of the text and the user calls <c> next() </c> , or when the current position is the beginning of the text and the user calls <c> previous() </c> . </para></li><li><para>Break positions are numbered by the positions of the characters that follow them. Thus, under normal circumstances, the position before the first character is 0, the position after the first character is 1, and the position after the last character is 1 plus the length of the string. </para></li><li><para>The client can change the position of an iterator, or the text it analyzes, at will, but cannot change the behavior. If the user wants different behavior, he must instantiate a new iterator. </para></li></ul></para><para><c> BreakIterator </c> accesses the text it analyzes through a CharacterIterator, which makes it possible to use <c>   BreakIterator </c> to analyze text in any text-storage vehicle that provides a <c> CharacterIterator </c> interface. </para><para><b>Note:</b> Some types of <c> BreakIterator </c> can take a long time to create, and instances of <c> BreakIterator </c> are not currently cached by the system. For optimal performance, keep instances of <c> BreakIterator </c> around as long as it makes sense. For example, when word-wrapping a document, don't create and destroy a new <c> BreakIterator </c> for each line. Create one break iterator for the whole document (or whatever stretch of text you're wrapping) and use it to do the whole job of wrapping the text. </para><para><b>Examples</b>: </para><para>Creating and using text boundaries: <blockquote><para></para><para><pre>
		///    public static void main(String args[]) {
		///        if (args.length == 1) {
		///            String stringToExamine = args[0];
		///            //print each word in order
		///            BreakIterator boundary = BreakIterator.getWordInstance();
		///            boundary.setText(stringToExamine);
		///            printEachForward(boundary, stringToExamine);
		///            //print each sentence in reverse order
		///            boundary = BreakIterator.getSentenceInstance(Locale.US);
		///            boundary.setText(stringToExamine);
		///            printEachBackward(boundary, stringToExamine);
		///            printFirst(boundary, stringToExamine);
		///            printLast(boundary, stringToExamine);
		///        }
		///    }
		///    </pre></para><para></para></blockquote></para><para>Print each element in order: <blockquote><para></para><para><pre>
		///    public static void printEachForward(BreakIterator boundary, String source) {
		///        int start = boundary.first();
		///        for (int end = boundary.next(); end != BreakIterator.DONE; start = end, end = boundary.next()) {
		///            System.out.println(source.substring(start, end));
		///        }
		///    }
		///    </pre></para><para></para></blockquote></para><para>Print each element in reverse order: <blockquote><para></para><para><pre>
		///    public static void printEachBackward(BreakIterator boundary, String source) {
		///        int end = boundary.last();
		///        for (int start = boundary.previous(); start != BreakIterator.DONE; end = start, start = boundary
		///                .previous()) {
		///            System.out.println(source.substring(start, end));
		///        }
		///    }
		///    </pre></para><para></para></blockquote></para><para>Print the first element: <blockquote><para></para><para><pre>
		///    public static void printFirst(BreakIterator boundary, String source) {
		///        int start = boundary.first();
		///        int end = boundary.next();
		///        System.out.println(source.substring(start, end));
		///    }
		///    </pre></para><para></para></blockquote></para><para>Print the last element: <blockquote><para></para><para><pre>
		///    public static void printLast(BreakIterator boundary, String source) {
		///        int end = boundary.last();
		///        int start = boundary.previous();
		///        System.out.println(source.substring(start, end));
		///    }
		///    </pre></para><para></para></blockquote></para><para>Print the element at a specified position: <blockquote><para></para><para><pre>
		///    public static void printAt(BreakIterator boundary, int pos, String source) {
		///        int end = boundary.following(pos);
		///        int start = boundary.previous();
		///        System.out.println(source.substring(start, end));
		///    }
		///    </pre></para><para></para></blockquote></para><para>Find the next word: <blockquote><para></para><para><pre>
		///    public static int nextWordStartAfter(int pos, String text) {
		///        BreakIterator wb = BreakIterator.getWordInstance();
		///        wb.setText(text);
		///        int last = wb.following(pos);
		///        int current = wb.next();
		///        while (current != BreakIterator.DONE) {
		///            for (int p = last; p &lt; current; p++) {
		///                if (Character.isLetter(text.charAt(p)))
		///                    return last;
		///            }
		///            last = current;
		///            current = wb.next();
		///        }
		///        return BreakIterator.DONE;
		///    }
		///    </pre></para><para></para></blockquote></para><para>The iterator returned by <c> BreakIterator.getWordInstance() </c> is unique in that the break positions it returns don't represent both the start and end of the thing being iterated over. That is, a sentence-break iterator returns breaks that each represent the end of one sentence and the beginning of the next. With the word-break iterator, the characters between two boundaries might be a word, or they might be the punctuation or whitespace between two words. The above code uses a simple heuristic to determine which boundary is the beginning of a word: If the characters between this boundary and the next boundary include at least one letter (this can be an alphabetical letter, a CJK ideograph, a Hangul syllable, a Kana character, etc.), then the text between this boundary and the next is a word; otherwise, it's the material between words.)</para><para><para>CharacterIterator </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/BreakIterator
		/// </java-name>
		[Dot42.DexImport("java/text/BreakIterator", AccessFlags = 1057)]
		public abstract partial class BreakIterator : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This constant is returned by iterate methods like <c> previous() </c> or <c> next() </c> if they have returned all valid boundaries. </para>        
				/// </summary>
				/// <java-name>
				/// DONE
				/// </java-name>
				[Dot42.DexImport("DONE", "I", AccessFlags = 25)]
				public const int DONE = -1;
				/// <summary>
				/// <para>Default constructor, for use by subclasses. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal BreakIterator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> BreakIterator </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over characters using the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getCharacterInstance
				/// </java-name>
				[Dot42.DexImport("getCharacterInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetCharacterInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over characters using the given locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the given locale. </para>
				/// </returns>
				/// <java-name>
				/// getCharacterInstance
				/// </java-name>
				[Dot42.DexImport("getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetCharacterInstance(global::Java.Util.Locale where) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of {<c> BreakIterator </c> to iterate over line breaks using the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getLineInstance
				/// </java-name>
				[Dot42.DexImport("getLineInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetLineInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over line breaks using the given locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the given locale. </para>
				/// </returns>
				/// <java-name>
				/// getLineInstance
				/// </java-name>
				[Dot42.DexImport("getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetLineInstance(global::Java.Util.Locale where) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over sentence-breaks using the default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getSentenceInstance
				/// </java-name>
				[Dot42.DexImport("getSentenceInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetSentenceInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over sentence-breaks using the given locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the given locale. </para>
				/// </returns>
				/// <java-name>
				/// getSentenceInstance
				/// </java-name>
				[Dot42.DexImport("getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetSentenceInstance(global::Java.Util.Locale where) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over word-breaks using the default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getWordInstance
				/// </java-name>
				[Dot42.DexImport("getWordInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetWordInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over word-breaks using the given locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the given locale. </para>
				/// </returns>
				/// <java-name>
				/// getWordInstance
				/// </java-name>
				[Dot42.DexImport("getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetWordInstance(global::Java.Util.Locale where) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <summary>
				/// <para>Indicates whether the given offset is a boundary position. If this method returns true, the current iteration position is set to the given position; if the function returns false, the current iteration position is set as though following(int) had been called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given offset is a boundary position; <c>               false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isBoundary
				/// </java-name>
				[Dot42.DexImport("isBoundary", "(I)Z", AccessFlags = 1)]
				public virtual bool IsBoundary(int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the position of last boundary preceding the given offset, and sets the current position to the returned value, or <c> DONE </c> if the given offset specifies the starting position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of the last boundary preceding the given offset. </para>
				/// </returns>
				/// <java-name>
				/// preceding
				/// </java-name>
				[Dot42.DexImport("preceding", "(I)I", AccessFlags = 1)]
				public virtual int Preceding(int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the new text to be analyzed by the given <c> CharacterIterator </c> . The position will be reset to the beginning of the new text, and other status information of this iterator will be kept.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetText(string newText) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this iterator's current position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this iterator's current position. </para>
				/// </returns>
				/// <java-name>
				/// current
				/// </java-name>
				[Dot42.DexImport("current", "()I", AccessFlags = 1025)]
				public abstract int Current() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets this iterator's current position to the first boundary and returns that position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of the first boundary. </para>
				/// </returns>
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()I", AccessFlags = 1025)]
				public abstract int First() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the position of the first boundary to the one following the given offset and returns this position. Returns <c> DONE </c> if there is no boundary after the given offset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of the first boundary following the given offset. </para>
				/// </returns>
				/// <java-name>
				/// following
				/// </java-name>
				[Dot42.DexImport("following", "(I)I", AccessFlags = 1025)]
				public abstract int Following(int offset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> CharacterIterator </c> which represents the text being analyzed. Please note that the returned value is probably the internal iterator used by this object. If the invoker wants to modify the status of the returned iterator, it is recommended to first create a clone of the iterator returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> CharacterIterator </c> which represents the text being analyzed. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/text/CharacterIterator;", AccessFlags = 1025)]
				public abstract global::Java.Text.ICharacterIterator GetText() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets this iterator's current position to the last boundary and returns that position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of last boundary. </para>
				/// </returns>
				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()I", AccessFlags = 1025)]
				public abstract int Last() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets this iterator's current position to the next boundary after the current position, and returns this position. Returns <c> DONE </c> if no boundary was found after the current position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of last boundary. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()I", AccessFlags = 1025)]
				public abstract int Next() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets this iterator's current position to the next boundary after the given position, and returns that position. Returns <c> DONE </c> if no boundary was found after the given position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of last boundary. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)I", AccessFlags = 1025)]
				public abstract int Next(int n) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets this iterator's current position to the previous boundary before the current position and returns that position. Returns <c> DONE </c> if no boundary was found before the current position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of last boundary. </para>
				/// </returns>
				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()I", AccessFlags = 1025)]
				public abstract int Previous() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the new text to be analyzed by the given <c> CharacterIterator </c> . The position will be reset to the beginning of the new text, and other status information of this iterator will be kept.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/text/CharacterIterator;)V", AccessFlags = 1025)]
				public abstract void SetText(global::Java.Text.ICharacterIterator newText) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a copy of this iterator. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> BreakIterator </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over characters using the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getCharacterInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator CharacterInstance
				{
				[Dot42.DexImport("getCharacterInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return GetCharacterInstance(); }
				}

				/// <summary>
				/// <para>Returns a new instance of {<c> BreakIterator </c> to iterate over line breaks using the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getLineInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator LineInstance
				{
				[Dot42.DexImport("getLineInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return GetLineInstance(); }
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over sentence-breaks using the default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getSentenceInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator SentenceInstance
				{
				[Dot42.DexImport("getSentenceInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return GetSentenceInstance(); }
				}

				/// <summary>
				/// <para>Returns a new instance of <c> BreakIterator </c> to iterate over word-breaks using the default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of <c> BreakIterator </c> using the default locale. </para>
				/// </returns>
				/// <java-name>
				/// getWordInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator WordInstance
				{
				[Dot42.DexImport("getWordInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return GetWordInstance(); }
				}

				/// <summary>
				/// <para>Returns a <c> CharacterIterator </c> which represents the text being analyzed. Please note that the returned value is probably the internal iterator used by this object. If the invoker wants to modify the status of the returned iterator, it is recommended to first create a clone of the iterator returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> CharacterIterator </c> which represents the text being analyzed. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Text.ICharacterIterator Text
				{
				[Dot42.DexImport("getText", "()Ljava/text/CharacterIterator;", AccessFlags = 1025)]
						get{ return GetText(); }
				[Dot42.DexImport("setText", "(Ljava/text/CharacterIterator;)V", AccessFlags = 1025)]
						set{ SetText(value); }
				}

		}

		/// <summary>
		/// <para>Extends the CharacterIterator interface, adding support for iterating over attributes and not only characters. An <c> AttributedCharacterIterator </c> also allows the user to find runs and their limits. Runs are defined as ranges of characters that all have the same attributes with the same values. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/AttributedCharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/AttributedCharacterIterator", AccessFlags = 1537)]
		public partial interface IAttributedCharacterIterator : global::Java.Text.ICharacterIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns a set of attributes present in the <c>       AttributedCharacterIterator </c> . An empty set is returned if no attributes were defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of attribute keys; may be empty. </para>
				/// </returns>
				/// <java-name>
				/// getAllAttributeKeys
				/// </java-name>
				[Dot42.DexImport("getAllAttributeKeys", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/text/AttributedCharacterIterator$Attribute;>;")]
				global::Java.Util.ISet<global::Java.Text.IAttributedCharacterIterator_Attribute> GetAllAttributeKeys() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the value stored in the attribute for the current character. If the attribute was not defined then <c> null </c> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the requested attribute for the current character or <c> null </c> if it was not defined. </para>
				/// </returns>
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetAttribute(global::Java.Text.IAttributedCharacterIterator_Attribute attribute) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a map of all attributes of the current character. If no attributes were defined for the current character then an empty map is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a map of all attributes for the current character or an empty map. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Obje" +
    "ct;>;")]
				global::Java.Util.IMap<global::Java.Text.IAttributedCharacterIterator_Attribute, object> GetAttributes() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the last character in the run having the same attributes as the current character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last character of the current run. </para>
				/// </returns>
				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "()I", AccessFlags = 1025)]
				int GetRunLimit() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the last character in the run that has the same attribute value for the given attribute as the current character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last character of the current run. </para>
				/// </returns>
				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", AccessFlags = 1025)]
				int GetRunLimit(global::Java.Text.IAttributedCharacterIterator_Attribute attribute) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the last character in the run that has the same attribute value for the given attribute as the current character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last character of the current run. </para>
				/// </returns>
				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "(Ljava/util/Set;)I", AccessFlags = 1025, Signature = "(Ljava/util/Set<+Ljava/text/AttributedCharacterIterator$Attribute;>;)I")]
				int GetRunLimit(global::Java.Util.ISet<global::Java.Text.IAttributedCharacterIterator_Attribute> attribute) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the first character in the run that has the same attributes as the current character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last character of the current run. </para>
				/// </returns>
				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "()I", AccessFlags = 1025)]
				int GetRunStart() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the first character in the run that has the same attribute value for the given attribute as the current character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last character of the current run. </para>
				/// </returns>
				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", AccessFlags = 1025)]
				int GetRunStart(global::Java.Text.IAttributedCharacterIterator_Attribute attribute) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the first character in the run that has the same attribute value for the given attribute as the current character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last character of the current run. </para>
				/// </returns>
				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "(Ljava/util/Set;)I", AccessFlags = 1025, Signature = "(Ljava/util/Set<+Ljava/text/AttributedCharacterIterator$Attribute;>;)I")]
				int GetRunStart(global::Java.Util.ISet<global::Java.Text.IAttributedCharacterIterator_Attribute> attribute) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Defines keys for text attributes. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/AttributedCharacterIterator$Attribute
		/// </java-name>
		[Dot42.DexImport("java/text/AttributedCharacterIterator$Attribute", AccessFlags = 9)]
		public partial class IAttributedCharacterIterator_Attribute : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This attribute marks segments from an input method. Most input methods create these segments for words.</para><para>The value objects are of the type <c> Annotation </c> which contain <c> null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_SEGMENT
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_SEGMENT", "Ljava/text/AttributedCharacterIterator$Attribute;", AccessFlags = 25)]
				public static readonly global::Java.Text.IAttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT;
				/// <summary>
				/// <para>The attribute describing the language of a character. The value objects are of type <c> Locale </c> or a subtype of it. </para>        
				/// </summary>
				/// <java-name>
				/// LANGUAGE
				/// </java-name>
				[Dot42.DexImport("LANGUAGE", "Ljava/text/AttributedCharacterIterator$Attribute;", AccessFlags = 25)]
				public static readonly global::Java.Text.IAttributedCharacterIterator_Attribute LANGUAGE;
				/// <summary>
				/// <para>For languages that have different reading directions of text (like Japanese), this attribute allows to define which reading should be used. The value objects are of type <c> Annotation </c> which contain a <c> String </c> . </para>        
				/// </summary>
				/// <java-name>
				/// READING
				/// </java-name>
				[Dot42.DexImport("READING", "Ljava/text/AttributedCharacterIterator$Attribute;", AccessFlags = 25)]
				public static readonly global::Java.Text.IAttributedCharacterIterator_Attribute READING;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal IAttributedCharacterIterator_Attribute(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this attribute with the specified object. Checks if both objects are the same instance. It is defined final so all subclasses have the same behavior for this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the object passed is equal to this instance; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the name of this attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this attribute. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Calculates the hash code for objects of type <c> Attribute </c> . It is defined final so all sub types calculate their hash code identically.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code for this instance of <c> Attribute </c> . </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Resolves a deserialized instance to the correct constant attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Attribute </c> this instance represents. </para>
				/// </returns>
				/// <java-name>
				/// readResolve
				/// </java-name>
				[Dot42.DexImport("readResolve", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReadResolve() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the name of the class followed by a "(", the name of the attribute, and a ")".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representing this instance. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IAttributedCharacterIterator_Attribute() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this attribute. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				protected internal string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 4)]
						get{ return GetName(); }
				}

		}

		/// <summary>
		/// <para>A concrete subclass of NumberFormat that formats decimal numbers. It has a variety of features designed to make it possible to parse and format numbers in any locale, including support for Western, Arabic, or Indic digits. It also supports different flavors of numbers, including integers ("123"), fixed-point numbers ("123.4"), scientific notation ("1.23E4"), percentages ("12%"), and currency amounts ("$123"). All of these flavors can be easily localized. </para><para><b>This is an enhanced version of <c> DecimalFormat </c> that is based on the standard version in the RI. New or changed functionality is labeled <b>&lt;font color="red"&gt;NEW&lt;/font&gt;</b>.</b> </para><para>To obtain a NumberFormat for a specific locale (including the default locale), call one of <c> NumberFormat </c> 's factory methods such as <c> NumberFormat.getInstance </c> . Do not call the <c> DecimalFormat </c> constructors directly, unless you know what you are doing, since the NumberFormat factory methods may return subclasses other than <c> DecimalFormat </c> . If you need to customize the format object, do something like this: <blockquote><para></para><para><pre>
		///    NumberFormat f = NumberFormat.getInstance(loc);
		///    if (f instanceof DecimalFormat) {
		///        ((DecimalFormat)f).setDecimalSeparatorAlwaysShown(true);
		///    }
		///    </pre></para><para></para></blockquote></para><para><h4>Patterns</h4></para><para>A <c> DecimalFormat </c> consists of a <b>pattern</b> and a set of <b>symbols</b>. The pattern may be set directly using applyPattern(String), or indirectly using other API methods which manipulate aspects of the pattern, such as the minimum number of integer digits. The symbols are stored in a DecimalFormatSymbols object. When using the NumberFormat factory methods, the pattern and symbols are read from ICU's locale data. <h4>Special Pattern Characters</h4></para><para>Many characters in a pattern are taken literally; they are matched during parsing and are written out unchanged during formatting. On the other hand, special characters stand for other characters, strings, or classes of characters. For example, the '#' character is replaced by a localized digit. Often the replacement character is the same as the pattern character; in the U.S. locale, the ',' grouping character is replaced by ','. However, the replacement is still happening, and if the symbols are modified, the grouping character changes. Some special characters affect the behavior of the formatter by their presence; for example, if the percent character is seen, then the value is multiplied by 100 before being displayed. </para><para>To insert a special character in a pattern as a literal, that is, without any special meaning, the character must be quoted. There are some exceptions to this which are noted below. </para><para>The characters listed here are used in non-localized patterns. Localized patterns use the corresponding characters taken from this formatter's DecimalFormatSymbols object instead, and these characters lose their special status. Two exceptions are the currency sign and quote, which are not localized. <blockquote><para><table><row><entry><para>Symbol </para></entry><entry><para>Location </para></entry><entry><para>Localized? </para></entry><entry><para>Meaning  </para></entry></row><row><entry><para><c> 0 </c>  </para></entry><entry><para>Number </para></entry><entry><para>Yes </para></entry><entry><para>Digit.  </para></entry></row><row><entry><para><c> @</c>  </para></entry><entry><para>Number </para></entry><entry><para>No </para></entry><entry><para><b>&lt;font color="red"&gt;NEW&lt;/font&gt; </b> Significant digit.  </para></entry></row><row><entry><para><c> # </c>  </para></entry><entry><para>Number </para></entry><entry><para>Yes </para></entry><entry><para>Digit, leading zeroes are not shown.  </para></entry></row><row><entry><para><c> . </c>  </para></entry><entry><para>Number </para></entry><entry><para>Yes </para></entry><entry><para>Decimal separator or monetary decimal separator.  </para></entry></row><row><entry><para><c> - </c>  </para></entry><entry><para>Number </para></entry><entry><para>Yes </para></entry><entry><para>Minus sign.  </para></entry></row><row><entry><para><c> , </c>  </para></entry><entry><para>Number </para></entry><entry><para>Yes </para></entry><entry><para>Grouping separator.  </para></entry></row><row><entry><para><c> E </c>  </para></entry><entry><para>Number </para></entry><entry><para>Yes </para></entry><entry><para>Separates mantissa and exponent in scientific notation. <b>Does not need to be quoted in prefix or suffix.</b>  </para></entry></row><row><entry><para><c> + </c>  </para></entry><entry><para>Exponent </para></entry><entry><para>Yes </para></entry><entry><para><b>&lt;font color="red"&gt;NEW&lt;/font&gt; </b> Prefix positive exponents with localized plus sign. <b>Does not need to be quoted in prefix or suffix.</b>  </para></entry></row><row><entry><para><c> ; </c>  </para></entry><entry><para>Subpattern boundary </para></entry><entry><para>Yes </para></entry><entry><para>Separates positive and negative subpatterns.  </para></entry></row><row><entry><para><c> % </c>  </para></entry><entry><para>Prefix or suffix </para></entry><entry><para>Yes </para></entry><entry><para>Multiply by 100 and show as percentage.  </para></entry></row><row><entry><para><c> \u2030 </c> (<c> \u005Cu2030 </c> ) </para></entry><entry><para>Prefix or suffix </para></entry><entry><para>Yes </para></entry><entry><para>Multiply by 1000 and show as per mille.  </para></entry></row><row><entry><para><c> \u00A4 </c> (<c> \u005Cu00A4 </c> ) </para></entry><entry><para>Prefix or suffix </para></entry><entry><para>No </para></entry><entry><para>Currency sign, replaced by currency symbol. If doubled, replaced by international currency symbol. If present in a pattern, the monetary decimal separator is used instead of the decimal separator.  </para></entry></row><row><entry><para><c> ' </c>  </para></entry><entry><para>Prefix or suffix </para></entry><entry><para>No </para></entry><entry><para>Used to quote special characters in a prefix or suffix, for example, <c> "'#'#" </c> formats 123 to <c> "#123" </c> . To create a single quote itself, use two in a row: <c> "# o''clock" </c> .  </para></entry></row><row><entry><para><c> * </c>  </para></entry><entry><para>Prefix or suffix boundary </para></entry><entry><para>Yes </para></entry><entry><para><b>&lt;font color="red"&gt;NEW&lt;/font&gt; </b> Pad escape, precedes pad character.   </para></entry></row></table></para></blockquote></para><para>A <c> DecimalFormat </c> pattern contains a positive and negative subpattern, for example, "#,##0.00;(#,##0.00)". Each subpattern has a prefix, a numeric part and a suffix. If there is no explicit negative subpattern, the negative subpattern is the localized minus sign prefixed to the positive subpattern. That is, "0.00" alone is equivalent to "0.00;-0.00". If there is an explicit negative subpattern, it serves only to specify the negative prefix and suffix; the number of digits, minimal digits, and other characteristics are ignored in the negative subpattern. This means that "#,##0.0#;(#)" produces precisely the same result as "#,##0.0#;(#,##0.0#)". </para><para>The prefixes, suffixes, and various symbols used for infinity, digits, thousands separators, decimal separators, etc. may be set to arbitrary values, and they will appear properly during formatting. However, care must be taken that the symbols and strings do not conflict, or parsing will be unreliable. For example, either the positive and negative prefixes or the suffixes must be distinct for parse to be able to distinguish positive from negative values. Another example is that the decimal separator and thousands separator should be distinct characters, or parsing will be impossible. </para><para>The <b>grouping separator</b> is a character that separates clusters of integer digits to make large numbers more legible. It is commonly used for thousands, but in some locales it separates ten-thousands. The <b>grouping size</b> is the number of digits between the grouping separators, such as 3 for "100,000,000" or 4 for "1 0000 0000". There are actually two different grouping sizes: One used for the least significant integer digits, the <b>primary grouping size</b>, and one used for all others, the <b>secondary grouping size</b>. In most locales these are the same, but sometimes they are different. For example, if the primary grouping interval is 3, and the secondary is 2, then this corresponds to the pattern "#,##,##0", and the number 123456789 is formatted as "12,34,56,789". If a pattern contains multiple grouping separators, the interval between the last one and the end of the integer defines the primary grouping size, and the interval between the last two defines the secondary grouping size. All others are ignored, so "#,##,###,####", "###,###,####" and "##,#,###,####" produce the same result. </para><para>Illegal patterns, such as "#.#.#" or "#.###,###", will cause <c> DecimalFormat </c> to throw an IllegalArgumentException with a message that describes the problem. <h4>Pattern BNF</h4></para><para><pre>
		///    pattern    := subpattern (';' subpattern)?
		///    subpattern := prefix? number exponent? suffix?
		///    number     := (integer ('.' fraction)?) | sigDigits
		///    prefix     := '\u0000'..'\uFFFD' - specialCharacters
		///    suffix     := '\u0000'..'\uFFFD' - specialCharacters
		///    integer    := '#'* '0'* '0'
		///    fraction   := '0'* '#'*
		///    sigDigits  := '#'* '@' '@'* '#'*
		///    exponent   := 'E' '+'? '0'* '0'
		///    padSpec    := '*' padChar
		///    padChar    := '\u0000'..'\uFFFD' - quote
		/// 
		///    Notation:
		///      X*       0 or more instances of X
		///      X?       0 or 1 instances of X
		///      X|Y      either X or Y
		///      C..D     any character from C up to D, inclusive
		///      S-T      characters in S, except those in T
		///    </pre></para><para>The first subpattern is for positive numbers. The second (optional) subpattern is for negative numbers. </para><para>Not indicated in the BNF syntax above: <ul><li><para>The grouping separator ',' can occur inside the integer and sigDigits elements, between any two pattern characters of that element, as long as the integer or sigDigits element is not followed by the exponent element. </para></li><li><para>&lt;font color="red"&gt;<b>NEW</b> &lt;/font&gt; Two grouping intervals are recognized: The one between the decimal point and the first grouping symbol and the one between the first and second grouping symbols. These intervals are identical in most locales, but in some locales they differ. For example, the pattern "#,##,###" formats the number 123456789 as "12,34,56,789". </para></li><li><para><b>&lt;font color="red"&gt;NEW&lt;/font&gt; </b> The pad specifier <c> padSpec </c> may appear before the prefix, after the prefix, before the suffix, after the suffix or not at all. </para></li></ul><h4>Parsing</h4></para><para><c> DecimalFormat </c> parses all Unicode characters that represent decimal digits, as defined by Character#digit(int, int). In addition, <c> DecimalFormat </c> also recognizes as digits the ten consecutive characters starting with the localized zero digit defined in the DecimalFormatSymbols object. During formatting, the DecimalFormatSymbols-based digits are written out. </para><para>During parsing, grouping separators are ignored. </para><para>If parse(String, ParsePosition) fails to parse a string, it returns <c> null </c> and leaves the parse position unchanged. <h4>Formatting</h4></para><para>Formatting is guided by several parameters, all of which can be specified either using a pattern or using the API. The following description applies to formats that do not use  or . <ul><li><para>If the number of actual integer digits exceeds the <b>maximum integer digits</b>, then only the least significant digits are shown. For example, 1997 is formatted as "97" if maximum integer digits is set to 2. </para></li><li><para>If the number of actual integer digits is less than the <b>minimum integer digits</b>, then leading zeros are added. For example, 1997 is formatted as "01997" if minimum integer digits is set to 5. </para></li><li><para>If the number of actual fraction digits exceeds the <b>maximum fraction digits</b>, then half-even rounding is performed to the maximum fraction digits. For example, 0.125 is formatted as "0.12" if the maximum fraction digits is 2. </para></li><li><para>If the number of actual fraction digits is less than the <b>minimum fraction digits</b>, then trailing zeros are added. For example, 0.125 is formatted as "0.1250" if the minimum fraction digits is set to 4. </para></li><li><para>Trailing fractional zeros are not displayed if they occur <b>j</b> positions after the decimal, where <b>j</b> is less than the maximum fraction digits. For example, 0.10004 is formatted as "0.1" if the maximum fraction digits is four or less. </para></li></ul></para><para><b>Special Values</b> </para><para><c> NaN </c> is represented as a single character, typically <c> \u005cuFFFD </c> . This character is determined by the DecimalFormatSymbols object. This is the only value for which the prefixes and suffixes are not used. </para><para>Infinity is represented as a single character, typically <c> \u005cu221E </c> , with the positive or negative prefixes and suffixes applied. The infinity character is determined by the DecimalFormatSymbols object.  <h4>Scientific Notation</h4></para><para>Numbers in scientific notation are expressed as the product of a mantissa and a power of ten, for example, 1234 can be expressed as 1.234 x 10<span>3</span>. The mantissa is typically in the half-open interval [1.0, 10.0) or sometimes [0.0, 1.0), but it does not need to be. <c> DecimalFormat </c> supports arbitrary mantissas. <c> DecimalFormat </c> can be instructed to use scientific notation through the API or through the pattern. In a pattern, the exponent character immediately followed by one or more digit characters indicates scientific notation. Example: "0.###E0" formats the number 1234 as "1.234E3". <ul><li><para>The number of digit characters after the exponent character gives the minimum exponent digit count. There is no maximum. Negative exponents are formatted using the localized minus sign, <b>not</b> the prefix and suffix from the pattern. This allows patterns such as "0.###E0 m/s". To prefix positive exponents with a localized plus sign, specify '+' between the exponent and the digits: "0.###E+0" will produce formats "1E+1", "1E+0", "1E-1", etc. (In localized patterns, use the localized plus sign rather than '+'.) </para></li><li><para>The minimum number of integer digits is achieved by adjusting the exponent. Example: 0.00123 formatted with "00.###E0" yields "12.3E-4". This only happens if there is no maximum number of integer digits. If there is a maximum, then the minimum number of integer digits is fixed at one. </para></li><li><para>The maximum number of integer digits, if present, specifies the exponent grouping. The most common use of this is to generate <b>engineering notation</b>, in which the exponent is a multiple of three, e.g., "##0.###E0". The number 12345 is formatted using "##0.###E0" as "12.345E3". </para></li><li><para>When using scientific notation, the formatter controls the digit counts using significant digits logic. The maximum number of significant digits limits the total number of integer and fraction digits that will be shown in the mantissa; it does not affect parsing. For example, 12345 formatted with "##0.##E0" is "12.3E3". See the section on significant digits for more details. </para></li><li><para>The number of significant digits shown is determined as follows: If no significant digits are used in the pattern then the minimum number of significant digits shown is one, the maximum number of significant digits shown is the sum of the <b>minimum integer</b> and <b>maximum fraction</b> digits, and it is unaffected by the maximum integer digits. If this sum is zero, then all significant digits are shown. If significant digits are used in the pattern then the number of integer digits is fixed at one and there is no exponent grouping. </para></li><li><para>Exponential patterns may not contain grouping separators. </para></li></ul> <h4><b>NEW </b> Significant Digits</h4></para><para><c> DecimalFormat </c> has two ways of controlling how many digits are shown: (a) significant digit counts or (b) integer and fraction digit counts. Integer and fraction digit counts are described above. When a formatter uses significant digits counts, the number of integer and fraction digits is not specified directly, and the formatter settings for these counts are ignored. Instead, the formatter uses as many integer and fraction digits as required to display the specified number of significant digits. <h5>Examples:</h5></para><para><blockquote><para><table><row><entry><para>Pattern </para></entry><entry><para>Minimum significant digits </para></entry><entry><para>Maximum significant digits </para></entry><entry><para>Number </para></entry><entry><para>Output of format()  </para></entry></row><row><entry><para><c> @@@</c> </para></entry><entry><para>3 </para></entry><entry><para>3 </para></entry><entry><para>12345 </para></entry><entry><para><c> 12300 </c>   </para></entry></row><row><entry><para><c> @@@</c>  </para></entry><entry><para>3 </para></entry><entry><para>3 </para></entry><entry><para>0.12345 </para></entry><entry><para><c> 0.123 </c>   </para></entry></row><row><entry><para><c> @@## </c>  </para></entry><entry><para>2 </para></entry><entry><para>4 </para></entry><entry><para>3.14159 </para></entry><entry><para><c> 3.142 </c>   </para></entry></row><row><entry><para><c> @@## </c>  </para></entry><entry><para>2 </para></entry><entry><para>4 </para></entry><entry><para>1.23004 </para></entry><entry><para><c> 1.23 </c>   </para></entry></row></table></para></blockquote><ul><li><para>Significant digit counts may be expressed using patterns that specify a minimum and maximum number of significant digits. These are indicated by the <c> '@' </c> and <c> '#' </c> characters. The minimum number of significant digits is the number of <c> '@' </c> characters. The maximum number of significant digits is the number of <c> '@' </c> characters plus the number of <c> '#' </c> characters following on the right. For example, the pattern <c> "@@@" </c> indicates exactly 3 significant digits. The pattern <c> "@##" </c> indicates from 1 to 3 significant digits. Trailing zero digits to the right of the decimal separator are suppressed after the minimum number of significant digits have been shown. For example, the pattern <c> "@##" </c> formats the number 0.1203 as <c> "0.12" </c> . </para></li><li><para>If a pattern uses significant digits, it may not contain a decimal separator, nor the <c> '0' </c> pattern character. Patterns such as <c> "@00" </c> or <c> "@.###" </c> are disallowed. </para></li><li><para>Any number of <c> '#' </c> characters may be prepended to the left of the leftmost <c> '@' </c> character. These have no effect on the minimum and maximum significant digit counts, but may be used to position grouping separators. For example, <c> "#,#@#" </c> indicates a minimum of one significant digit, a maximum of two significant digits, and a grouping size of three. </para></li><li><para>In order to enable significant digits formatting, use a pattern containing the <c> '@' </c> pattern character. </para></li><li><para>In order to disable significant digits formatting, use a pattern that does not contain the <c> '@' </c> pattern character. </para></li><li><para>The number of significant digits has no effect on parsing. </para></li><li><para>Significant digits may be used together with exponential notation. Such patterns are equivalent to a normal exponential pattern with a minimum and maximum integer digit count of one, a minimum fraction digit count of the number of '@' characters in the pattern - 1, and a maximum fraction digit count of the number of '@' and '#' characters in the pattern - 1. For example, the pattern <c> "@@###E0" </c> is equivalent to <c> "0.0###E0" </c> . </para></li><li><para>If significant digits are in use then the integer and fraction digit counts, as set via the API, are ignored. </para></li></ul><h4><b>NEW </b> Padding</h4></para><para><c> DecimalFormat </c> supports padding the result of <c> format </c> to a specific width. Padding may be specified either through the API or through the pattern syntax. In a pattern, the pad escape character followed by a single pad character causes padding to be parsed and formatted. The pad escape character is '*' in unlocalized patterns. For example, <c> "$*x#,##0.00" </c> formats 123 to <c> "$xx123.00" </c> , and 1234 to <c> "$1,234.00" </c> . <ul><li><para>When padding is in effect, the width of the positive subpattern, including prefix and suffix, determines the format width. For example, in the pattern <c> "* #0 o''clock" </c> , the format width is 10. </para></li><li><para>The width is counted in 16-bit code units (Java <c> char </c> s). </para></li><li><para>Some parameters which usually do not matter have meaning when padding is used, because the pattern width is significant with padding. In the pattern "*&lt;h2&gt;,##,#,##0.##", the format width is 14. The initial characters "##,##," do not affect the grouping size or maximum integer digits, but they do affect the format width. </para></li><li><para>Padding may be inserted at one of four locations: before the prefix, after the prefix, before the suffix or after the suffix. If padding is specified in any other location, applyPattern throws an IllegalArgumentException. If there is no prefix, before the prefix and after the prefix are equivalent, likewise for the suffix. </para></li><li><para>When specified in a pattern, the 16-bit <c> char </c> immediately following the pad escape is the pad character. This may be any character, including a special pattern character. That is, the pad escape <b>escapes</b> the following character. If there is no character after the pad escape, then the pattern is illegal. </para></li></ul><h4>Synchronization</h4></para><para><c> DecimalFormat </c> objects are not synchronized. Multiple threads should not access one formatter concurrently.</para><para><para>Format </para><simplesectsep></simplesectsep><para>NumberFormat </para></para>    
		/// </summary>
		/// <java-name>
		/// java/text/DecimalFormat
		/// </java-name>
		[Dot42.DexImport("java/text/DecimalFormat", AccessFlags = 33)]
		public partial class DecimalFormat : global::Java.Text.NumberFormat
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> DecimalFormat </c> for formatting and parsing numbers for the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DecimalFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> DecimalFormat </c> using the specified non-localized pattern and the <c> DecimalFormatSymbols </c> for the user's default Locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DecimalFormat(string pattern) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V", AccessFlags = 1)]
				public DecimalFormat(string @string, global::Java.Text.DecimalFormatSymbols decimalFormatSymbols) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the pattern of this decimal format to the specified pattern which uses localized pattern characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("applyLocalizedPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyLocalizedPattern(string pattern) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the pattern of this decimal format to the specified pattern which uses non-localized pattern characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string pattern) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new instance of <c> DecimalFormat </c> with the same pattern and properties. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object to this decimal format and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> DecimalFormat </c> with the same pattern and properties.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this decimal format; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Formats the specified object using the rules of this decimal format and returns an <c> AttributedCharacterIterator </c> with the formatted number and attributes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an AttributedCharacterIterator with the formatted number and attributes. </para>
				/// </returns>
				/// <java-name>
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public override global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(double @double, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(long int64, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 17)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				/// <para>Returns the <c> DecimalFormatSymbols </c> used by this decimal format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the <c> DecimalFormatSymbols </c> used by this decimal format. </para>
				/// </returns>
				/// <java-name>
				/// getDecimalFormatSymbols
				/// </java-name>
				[Dot42.DexImport("getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;", AccessFlags = 1)]
				public virtual global::Java.Text.DecimalFormatSymbols GetDecimalFormatSymbols() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DecimalFormatSymbols);
				}

				/// <summary>
				/// <para>Returns the currency used by this decimal format.</para><para><para>DecimalFormatSymbols::getCurrency() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency used by this decimal format. </para>
				/// </returns>
				/// <java-name>
				/// getCurrency
				/// </java-name>
				[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
				public override global::Java.Util.Currency GetCurrency() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <summary>
				/// <para>Returns the number of digits grouped together by the grouping separator. This only allows to get the primary grouping size. There is no API to get the secondary grouping size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of digits grouped together. </para>
				/// </returns>
				/// <java-name>
				/// getGroupingSize
				/// </java-name>
				[Dot42.DexImport("getGroupingSize", "()I", AccessFlags = 1)]
				public virtual int GetGroupingSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the multiplier which is applied to the number before formatting or after parsing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the multiplier. </para>
				/// </returns>
				/// <java-name>
				/// getMultiplier
				/// </java-name>
				[Dot42.DexImport("getMultiplier", "()I", AccessFlags = 1)]
				public virtual int GetMultiplier() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the prefix which is formatted or parsed before a negative number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the negative prefix. </para>
				/// </returns>
				/// <java-name>
				/// getNegativePrefix
				/// </java-name>
				[Dot42.DexImport("getNegativePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNegativePrefix() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the suffix which is formatted or parsed after a negative number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the negative suffix. </para>
				/// </returns>
				/// <java-name>
				/// getNegativeSuffix
				/// </java-name>
				[Dot42.DexImport("getNegativeSuffix", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNegativeSuffix() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the prefix which is formatted or parsed before a positive number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the positive prefix. </para>
				/// </returns>
				/// <java-name>
				/// getPositivePrefix
				/// </java-name>
				[Dot42.DexImport("getPositivePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPositivePrefix() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the suffix which is formatted or parsed after a positive number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the positive suffix. </para>
				/// </returns>
				/// <java-name>
				/// getPositiveSuffix
				/// </java-name>
				[Dot42.DexImport("getPositiveSuffix", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPositiveSuffix() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether the decimal separator is shown when there are no fractional digits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the decimal separator should always be formatted; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDecimalSeparatorAlwaysShown
				/// </java-name>
				[Dot42.DexImport("isDecimalSeparatorAlwaysShown", "()Z", AccessFlags = 1)]
				public virtual bool IsDecimalSeparatorAlwaysShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>This value indicates whether the return object of the parse operation is of type <c> BigDecimal </c> . This value defaults to <c> false </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if parse always returns <c> BigDecimals </c> , <c> false </c> if the type of the result is <c> Long </c> or <c> Double </c> . </para>
				/// </returns>
				/// <java-name>
				/// isParseBigDecimal
				/// </java-name>
				[Dot42.DexImport("isParseBigDecimal", "()Z", AccessFlags = 1)]
				public virtual bool IsParseBigDecimal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the flag that indicates whether numbers will be parsed as integers. When this decimal format is used for parsing and this value is set to <c> true </c> , then the resulting numbers will be of type <c> java.lang.Integer </c> . Special cases are NaN, positive and negative infinity, which are still returned as <c> java.lang.Double </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParseIntegerOnly
				/// </java-name>
				[Dot42.DexImport("setParseIntegerOnly", "(Z)V", AccessFlags = 1)]
				public override void SetParseIntegerOnly(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether parsing with this decimal format will only return numbers of type <c> java.lang.Integer </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> DecimalFormat </c> 's parse method only returns <c> java.lang.Integer </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isParseIntegerOnly
				/// </java-name>
				[Dot42.DexImport("isParseIntegerOnly", "()Z", AccessFlags = 1)]
				public override bool IsParseIntegerOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Parses a <c> Long </c> or <c> Double </c> from the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Long </c> or <c> Double </c> resulting from the parse or <c> null </c> if there is an error. The result will be a <c> Long </c> if the parsed number is an integer in the range of a long, otherwise the result is a <c> Double </c> . If <c> isParseBigDecimal </c> is <c> true </c> then it returns the result as a <c> BigDecimal </c> . </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", AccessFlags = 1)]
				public override global::Java.Lang.Number Parse(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Number);
				}

				/// <summary>
				/// <para>Sets the <c> DecimalFormatSymbols </c> used by this decimal format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDecimalFormatSymbols
				/// </java-name>
				[Dot42.DexImport("setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V", AccessFlags = 1)]
				public virtual void SetDecimalFormatSymbols(global::Java.Text.DecimalFormatSymbols value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the currency used by this decimal format. The min and max fraction digits remain the same.</para><para><para>DecimalFormatSymbols::setCurrency(Currency) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrency
				/// </java-name>
				[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
				public override void SetCurrency(global::Java.Util.Currency currency) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether the decimal separator is shown when there are no fractional digits.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDecimalSeparatorAlwaysShown
				/// </java-name>
				[Dot42.DexImport("setDecimalSeparatorAlwaysShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetDecimalSeparatorAlwaysShown(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the number of digits grouped together by the grouping separator. This only allows to set the primary grouping size; the secondary grouping size can only be set with a pattern.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupingSize
				/// </java-name>
				[Dot42.DexImport("setGroupingSize", "(I)V", AccessFlags = 1)]
				public virtual void SetGroupingSize(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether or not grouping will be used in this format. Grouping affects both parsing and formatting.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupingUsed
				/// </java-name>
				[Dot42.DexImport("setGroupingUsed", "(Z)V", AccessFlags = 1)]
				public override void SetGroupingUsed(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether grouping will be used in this format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if grouping is used; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isGroupingUsed
				/// </java-name>
				[Dot42.DexImport("isGroupingUsed", "()Z", AccessFlags = 1)]
				public override bool IsGroupingUsed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the maximum number of digits after the decimal point. If the value passed is negative then it is replaced by 0. Regardless of this setting, no more than 340 digits will be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaximumFractionDigits
				/// </java-name>
				[Dot42.DexImport("setMaximumFractionDigits", "(I)V", AccessFlags = 1)]
				public override void SetMaximumFractionDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the maximum number of digits before the decimal point. If the value passed is negative then it is replaced by 0. Regardless of this setting, no more than 309 digits will be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaximumIntegerDigits
				/// </java-name>
				[Dot42.DexImport("setMaximumIntegerDigits", "(I)V", AccessFlags = 1)]
				public override void SetMaximumIntegerDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the minimum number of digits after the decimal point. If the value passed is negative then it is replaced by 0. Regardless of this setting, no more than 340 digits will be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinimumFractionDigits
				/// </java-name>
				[Dot42.DexImport("setMinimumFractionDigits", "(I)V", AccessFlags = 1)]
				public override void SetMinimumFractionDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the minimum number of digits before the decimal point. If the value passed is negative then it is replaced by 0. Regardless of this setting, no more than 309 digits will be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinimumIntegerDigits
				/// </java-name>
				[Dot42.DexImport("setMinimumIntegerDigits", "(I)V", AccessFlags = 1)]
				public override void SetMinimumIntegerDigits(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the multiplier which is applied to the number before formatting or after parsing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMultiplier
				/// </java-name>
				[Dot42.DexImport("setMultiplier", "(I)V", AccessFlags = 1)]
				public virtual void SetMultiplier(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the prefix which is formatted or parsed before a negative number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNegativePrefix
				/// </java-name>
				[Dot42.DexImport("setNegativePrefix", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetNegativePrefix(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the suffix which is formatted or parsed after a negative number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNegativeSuffix
				/// </java-name>
				[Dot42.DexImport("setNegativeSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetNegativeSuffix(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the prefix which is formatted or parsed before a positive number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPositivePrefix
				/// </java-name>
				[Dot42.DexImport("setPositivePrefix", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPositivePrefix(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the suffix which is formatted or parsed after a positive number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPositiveSuffix
				/// </java-name>
				[Dot42.DexImport("setPositiveSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPositiveSuffix(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the behavior of the parse method. If set to <c> true </c> then all the returned objects will be of type <c> BigDecimal </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParseBigDecimal
				/// </java-name>
				[Dot42.DexImport("setParseBigDecimal", "(Z)V", AccessFlags = 1)]
				public virtual void SetParseBigDecimal(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the pattern of this decimal format using localized pattern characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the localized pattern. </para>
				/// </returns>
				/// <java-name>
				/// toLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("toLocalizedPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToLocalizedPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the pattern of this decimal format using non-localized pattern characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the non-localized pattern. </para>
				/// </returns>
				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> RoundingMode </c> used by this <c> NumberFormat </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
				public override global::Java.Math.RoundingMode GetRoundingMode() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode);
				}

				/// <summary>
				/// <para>Sets the <c> RoundingMode </c> used by this <c> NumberFormat </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setRoundingMode
				/// </java-name>
				[Dot42.DexImport("setRoundingMode", "(Ljava/math/RoundingMode;)V", AccessFlags = 1)]
				public override void SetRoundingMode(global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> DecimalFormatSymbols </c> used by this decimal format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the <c> DecimalFormatSymbols </c> used by this decimal format. </para>
				/// </returns>
				/// <java-name>
				/// getDecimalFormatSymbols
				/// </java-name>
				public global::Java.Text.DecimalFormatSymbols DecimalFormatSymbols
				{
				[Dot42.DexImport("getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;", AccessFlags = 1)]
						get{ return GetDecimalFormatSymbols(); }
				[Dot42.DexImport("setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V", AccessFlags = 1)]
						set{ SetDecimalFormatSymbols(value); }
				}

				/// <summary>
				/// <para>Returns the currency used by this decimal format.</para><para><para>DecimalFormatSymbols::getCurrency() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currency used by this decimal format. </para>
				/// </returns>
				/// <java-name>
				/// getCurrency
				/// </java-name>
				public global::Java.Util.Currency Currency
				{
				[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
						get{ return GetCurrency(); }
				[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
						set{ SetCurrency(value); }
				}

				/// <summary>
				/// <para>Returns the number of digits grouped together by the grouping separator. This only allows to get the primary grouping size. There is no API to get the secondary grouping size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of digits grouped together. </para>
				/// </returns>
				/// <java-name>
				/// getGroupingSize
				/// </java-name>
				public int GroupingSize
				{
				[Dot42.DexImport("getGroupingSize", "()I", AccessFlags = 1)]
						get{ return GetGroupingSize(); }
				[Dot42.DexImport("setGroupingSize", "(I)V", AccessFlags = 1)]
						set{ SetGroupingSize(value); }
				}

				/// <summary>
				/// <para>Returns the multiplier which is applied to the number before formatting or after parsing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the multiplier. </para>
				/// </returns>
				/// <java-name>
				/// getMultiplier
				/// </java-name>
				public int Multiplier
				{
				[Dot42.DexImport("getMultiplier", "()I", AccessFlags = 1)]
						get{ return GetMultiplier(); }
				[Dot42.DexImport("setMultiplier", "(I)V", AccessFlags = 1)]
						set{ SetMultiplier(value); }
				}

				/// <summary>
				/// <para>Returns the prefix which is formatted or parsed before a negative number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the negative prefix. </para>
				/// </returns>
				/// <java-name>
				/// getNegativePrefix
				/// </java-name>
				public string NegativePrefix
				{
				[Dot42.DexImport("getNegativePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNegativePrefix(); }
				[Dot42.DexImport("setNegativePrefix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetNegativePrefix(value); }
				}

				/// <summary>
				/// <para>Returns the suffix which is formatted or parsed after a negative number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the negative suffix. </para>
				/// </returns>
				/// <java-name>
				/// getNegativeSuffix
				/// </java-name>
				public string NegativeSuffix
				{
				[Dot42.DexImport("getNegativeSuffix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNegativeSuffix(); }
				[Dot42.DexImport("setNegativeSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetNegativeSuffix(value); }
				}

				/// <summary>
				/// <para>Returns the prefix which is formatted or parsed before a positive number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the positive prefix. </para>
				/// </returns>
				/// <java-name>
				/// getPositivePrefix
				/// </java-name>
				public string PositivePrefix
				{
				[Dot42.DexImport("getPositivePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPositivePrefix(); }
				[Dot42.DexImport("setPositivePrefix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPositivePrefix(value); }
				}

				/// <summary>
				/// <para>Returns the suffix which is formatted or parsed after a positive number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the positive suffix. </para>
				/// </returns>
				/// <java-name>
				/// getPositiveSuffix
				/// </java-name>
				public string PositiveSuffix
				{
				[Dot42.DexImport("getPositiveSuffix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPositiveSuffix(); }
				[Dot42.DexImport("setPositiveSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPositiveSuffix(value); }
				}

				/// <summary>
				/// <para>Returns the <c> RoundingMode </c> used by this <c> NumberFormat </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public global::Java.Math.RoundingMode RoundingMode
				{
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return GetRoundingMode(); }
				[Dot42.DexImport("setRoundingMode", "(Ljava/math/RoundingMode;)V", AccessFlags = 1)]
						set{ SetRoundingMode(value); }
				}

		}

		/// <summary>
		/// <para>Wrapper for a text attribute value which represents an annotation. An annotation has two special aspects: <ol><li><para>it is connected to a range of main text; if this range or the main text is changed then the annotation becomes invalid, </para></li><li><para>it can not be joined with adjacent annotations even if the text attribute value is the same. </para></li></ol></para><para>By wrapping text attribute values into an <c> Annotation </c> , these aspects will be taken into account when handling annotation text and the corresponding main text. </para><para>Note: There is no semantic connection between this annotation class and the <c> java.lang.annotation </c> package. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/Annotation
		/// </java-name>
		[Dot42.DexImport("java/text/Annotation", AccessFlags = 33)]
		public partial class Annotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> Annotation </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public Annotation(object attribute) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the value of this annotation. The value may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of this annotation or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetValue() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns this annotation in string representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this annotation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Annotation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the value of this annotation. The value may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of this annotation or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				public object Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetValue(); }
				}

		}

		/// <summary>
		/// <para>The base class for all formats. </para><para>This is an abstract base class which specifies the protocol for classes which convert other objects or values, such as numeric values and dates, and their string representations. In some cases these representations may be localized or contain localized characters or strings. For example, a numeric formatter such as <c> DecimalFormat </c> may convert a numeric value such as 12345 to the string "$12,345". It may also parse the string back into a numeric value. A date and time formatter like <c> SimpleDateFormat </c> may represent a specific date, encoded numerically, as a string such as "Wednesday, February   26, 1997 AD". </para><para>Many of the concrete subclasses of <c> Format </c> employ the notion of a pattern. A pattern is a string representation of the rules which govern the conversion between values and strings. For example, a <c> DecimalFormat </c> object may be associated with the pattern "$#,##0.00;($#,##0.00)", which is a common US English format for currency values, yielding strings such as "$1,234.45" for 1234.45, and "($987.65)" for -987.6543. The specific syntax of a pattern is defined by each subclass. Even though many subclasses use patterns, the notion of a pattern is not inherent to <c> Format </c> classes in general, and is not part of the explicit base class protocol. </para><para>Two complex formatting classes are worth mentioning: <c> MessageFormat </c> and <c> ChoiceFormat </c> . <c> ChoiceFormat </c> is a subclass of <c> NumberFormat </c> which allows the user to format different number ranges as strings. For instance, 0 may be represented as "no files", 1 as "one   file", and any number greater than 1 as "many files". <c> MessageFormat </c> is a formatter which utilizes other <c> Format </c> objects to format a string containing multiple values. For instance, a <c> MessageFormat </c> object might produce the string "There are no files on the disk MyDisk on February   27, 1997." given the arguments 0, "MyDisk", and the date value of 2/27/97. See the ChoiceFormat and MessageFormat descriptions for further information. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/Format
		/// </java-name>
		[Dot42.DexImport("java/text/Format", AccessFlags = 1057)]
		public abstract partial class Format : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used by subclasses. This was public in Java 5. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Format() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of this <c> Format </c> instance.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this format.</para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Formats the specified object using the rules of this format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 17)]
				public string JavaFormat(object @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Appends the specified object to the specified string buffer using the rules of this format. </para><para><c> field </c> is an input/output parameter. If its <c> field </c> member contains an enum value specifying a field on input, then its <c> beginIndex </c> and <c> endIndex </c> members will be updated with the text offset of the first occurrence of this field in the formatted text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string buffer. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer buffer, global::Java.Text.FieldPosition field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats the specified object using the rules of this format and returns an <c> AttributedCharacterIterator </c> with the formatted string and no attributes. </para><para>Subclasses should return an <c> AttributedCharacterIterator </c> with the appropriate attributes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> AttributedCharacterIterator </c> with the formatted object and attributes. </para>
				/// </returns>
				/// <java-name>
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <summary>
				/// <para>Parses the specified string using the rules of this format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object resulting from the parse. </para>
				/// </returns>
				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object ParseObject(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Parses the specified string starting at the index specified by <c> position </c> . If the string is successfully parsed then the index of the <c> ParsePosition </c> is updated to the index following the parsed text. On error, the index is unchanged and the error index of <c> ParsePosition </c> is set to the index where the error occurred.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object resulting from the parse or <c> null </c> if there is an error. </para>
				/// </returns>
				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object ParseObject(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inner class used to represent <c> Format </c> attributes in the <c> AttributedCharacterIterator </c> that the <c> formatToCharacterIterator() </c> method returns in <c> Format </c> subclasses. </para>    
				/// </summary>
				/// <java-name>
				/// java/text/Format$Field
				/// </java-name>
				[Dot42.DexImport("java/text/Format$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.IAttributedCharacterIterator_Attribute
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Field(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Holds a string with attributes describing the characters of this string. </para>    
		/// </summary>
		/// <java-name>
		/// java/text/AttributedString
		/// </java-name>
		[Dot42.DexImport("java/text/AttributedString", AccessFlags = 33)]
		public partial class AttributedString
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> AttributedString </c> from an <c>       AttributedCharacterIterator </c> , which represents attributed text.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;)V", AccessFlags = 1)]
				public AttributedString(global::Java.Text.IAttributedCharacterIterator iterator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an <c> AttributedString </c> from a range of the text contained in the specified <c> AttributedCharacterIterator </c> , starting at <c>       start </c> and ending at <c> end </c> . All attributes will be copied to this attributed string.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;II)V", AccessFlags = 1)]
				public AttributedString(global::Java.Text.IAttributedCharacterIterator iterator, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;II[Ljava/text/AttributedCharacterIterator" +
    "$Attribute;)V", AccessFlags = 1)]
				public AttributedString(global::Java.Text.IAttributedCharacterIterator iterator, int start, int end, global::Java.Text.IAttributedCharacterIterator_Attribute[] attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an <c> AttributedString </c> from an <c>       AttributedCharacterIterator </c> , which represents attributed text.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AttributedString(string iterator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an <c> AttributedString </c> from the given text and the attributes. The whole text has the given attributes applied.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<+Ljava/text/AttributedCharacterIterator$Attribu" +
    "te;*>;)V")]
				public AttributedString(string value, global::Java.Util.IMap<global::Java.Text.IAttributedCharacterIterator_Attribute, object> attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Applies a given attribute to this string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void AddAttribute(global::Java.Text.IAttributedCharacterIterator_Attribute attribute, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Applies a given attribute to the given range of this string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void AddAttribute(global::Java.Text.IAttributedCharacterIterator_Attribute attribute, object value, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Applies a given set of attributes to the given range of the string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addAttributes
				/// </java-name>
				[Dot42.DexImport("addAttributes", "(Ljava/util/Map;II)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+Ljava/text/AttributedCharacterIterator$Attribute;*>;II)V")]
				public virtual void AddAttributes(global::Java.Util.IMap<global::Java.Text.IAttributedCharacterIterator_Attribute, object> attributes, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an <c> AttributedCharacterIterator </c> that gives access to the complete content of this attributed string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly created <c> AttributedCharacterIterator </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIterator
				/// </java-name>
				[Dot42.DexImport("getIterator", "()Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator GetIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <summary>
				/// <para>Returns an <c> AttributedCharacterIterator </c> that gives access to the complete content of this attributed string. Only attributes contained in <c> attributes </c> are available from this iterator if they are defined for this text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly created <c> AttributedCharacterIterator </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIterator
				/// </java-name>
				[Dot42.DexImport("getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacte" +
    "rIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator GetIterator(global::Java.Text.IAttributedCharacterIterator_Attribute[] attributes) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <summary>
				/// <para>Returns an <c> AttributedCharacterIterator </c> that gives access to the contents of this attributed string starting at index <c> start </c> up to index <c> end </c> . Only attributes contained in <c> attributes </c> are available from this iterator if they are defined for this text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly created <c> AttributedCharacterIterator </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIterator
				/// </java-name>
				[Dot42.DexImport("getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;II)Ljava/text/AttributedCharac" +
    "terIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator GetIterator(global::Java.Text.IAttributedCharacterIterator_Attribute[] attributes, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AttributedString() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns an <c> AttributedCharacterIterator </c> that gives access to the complete content of this attributed string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly created <c> AttributedCharacterIterator </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIterator
				/// </java-name>
				public global::Java.Text.IAttributedCharacterIterator Iterator
				{
				[Dot42.DexImport("getIterator", "()Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
						get{ return GetIterator(); }
				}

		}

		/// <summary>
		/// <para>Created by a <c> RuleBasedCollator </c> to iterate through a string. The result of each iteration is a 32-bit collation element that defines the ordering priority of the next character or sequence of characters in the source string. </para><para>For illustration, consider the following in Spanish: </para><para>"ca": the first collation element is collation_element('c') and second collation element is collation_element('a'). </para><para>Since "ch" in Spanish sorts as one entity, the example below returns one collation element for the two characters 'c' and 'h': </para><para>"cha": the first collation element is collation_element('ch') and the second one is collation_element('a'). </para><para>In German, since the character '&amp;#92;u0086' is a composed character of 'a' and 'e', the iterator returns two collation elements for the single character '&amp;#92;u0086': </para><para>"&amp;#92;u0086b": the first collation element is collation_element('a'), the second one is collation_element('e'), and the third collation element is collation_element('b'). </para>    
		/// </summary>
		/// <java-name>
		/// java/text/CollationElementIterator
		/// </java-name>
		[Dot42.DexImport("java/text/CollationElementIterator", AccessFlags = 49)]
		public sealed partial class CollationElementIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This constant is returned by the iterator in the methods <c> next() </c> and <c> previous() </c> when the end or the beginning of the source string has been reached, and there are no more valid collation elements to return. </para>        
				/// </summary>
				/// <java-name>
				/// NULLORDER
				/// </java-name>
				[Dot42.DexImport("NULLORDER", "I", AccessFlags = 25)]
				public const int NULLORDER = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CollationElementIterator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the maximum length of any expansion sequence that ends with the specified collation element. Returns <c> 1 </c> if there is no expansion with this collation element as the last element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum length of any expansion sequence ending with the specified collation element. </para>
				/// </returns>
				/// <java-name>
				/// getMaxExpansion
				/// </java-name>
				[Dot42.DexImport("getMaxExpansion", "(I)I", AccessFlags = 1)]
				public int GetMaxExpansion(int order) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the character offset in the source string corresponding to the next collation element. This value could be any of: <ul><li><para>The index of the first character in the source string that matches the value of the next collation element. This means that if <c> setOffset(offset) </c> sets the index in the middle of a contraction, <c> getOffset() </c> returns the index of the first character in the contraction, which may not be equal to the original offset that was set. Hence calling <c> getOffset() </c> immediately after <c> setOffset(offset) </c> does not guarantee that the original offset set will be returned. </para></li><li><para>If normalization is on, the index of the immediate subsequent character, or composite character with the first character, having a combining class of 0. </para></li><li><para>The length of the source string, if iteration has reached the end.  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The position of the collation element in the source string that will be returned by the next invocation of the next() method. </para>
				/// </returns>
				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
				public int GetOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the next collation element in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next collation element or <c> NULLORDER </c> if the end of the iteration has been reached. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()I", AccessFlags = 1)]
				public int Next() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the previous collation element in the source string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous collation element, or <c> NULLORDER </c> when the start of the iteration has been reached. </para>
				/// </returns>
				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()I", AccessFlags = 1)]
				public int Previous() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the primary order of the specified collation element, i.e. the first 16 bits. This value is unsigned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element's 16 bit primary order. </para>
				/// </returns>
				/// <java-name>
				/// primaryOrder
				/// </java-name>
				[Dot42.DexImport("primaryOrder", "(I)I", AccessFlags = 25)]
				public static int PrimaryOrder(int order) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Repositions the cursor to point at the first element of the current string. The next call to next() or previous() will return the first and last collation element in the string, respectively. </para><para>If the <c> RuleBasedCollator </c> used by this iterator has had its attributes changed, calling <c> reset() </c> reinitializes the iterator to use the new attributes. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the secondary order of the specified collation element, i.e. the 16th to 23th bits, inclusive. This value is unsigned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 8 bit secondary order of the element. </para>
				/// </returns>
				/// <java-name>
				/// secondaryOrder
				/// </java-name>
				[Dot42.DexImport("secondaryOrder", "(I)S", AccessFlags = 25)]
				public static short SecondaryOrder(int order) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Points the iterator at the collation element associated with the character in the source string which is found at the supplied offset. After this call completes, an invocation of the next() method will return this collation element. </para><para>If <c> newOffset </c> corresponds to a character which is part of a sequence that maps to a single collation element then the iterator is adjusted to the start of that sequence. As a result of this, any subsequent call made to <c> getOffset() </c> may not return the same value set by this method. </para><para>If the decomposition mode is on, and offset is in the middle of a decomposable range of source text, the iterator may not return a correct result for the next forwards or backwards iteration. The user must ensure that the offset is not in the middle of a decomposable range.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOffset
				/// </java-name>
				[Dot42.DexImport("setOffset", "(I)V", AccessFlags = 1)]
				public void SetOffset(int newOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a new source string iterator for iteration, and resets the offset to the beginning of the text.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/text/CharacterIterator;)V", AccessFlags = 1)]
				public void SetText(global::Java.Text.ICharacterIterator source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a new source string iterator for iteration, and resets the offset to the beginning of the text.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetText(string source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the tertiary order of the specified collation element, i.e. the last 8 bits. This value is unsigned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 8 bit tertiary order of the element. </para>
				/// </returns>
				/// <java-name>
				/// tertiaryOrder
				/// </java-name>
				[Dot42.DexImport("tertiaryOrder", "(I)S", AccessFlags = 25)]
				public static short TertiaryOrder(int order) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Obtains the character offset in the source string corresponding to the next collation element. This value could be any of: <ul><li><para>The index of the first character in the source string that matches the value of the next collation element. This means that if <c> setOffset(offset) </c> sets the index in the middle of a contraction, <c> getOffset() </c> returns the index of the first character in the contraction, which may not be equal to the original offset that was set. Hence calling <c> getOffset() </c> immediately after <c> setOffset(offset) </c> does not guarantee that the original offset set will be returned. </para></li><li><para>If normalization is on, the index of the immediate subsequent character, or composite character with the first character, having a combining class of 0. </para></li><li><para>The length of the source string, if iteration has reached the end.  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The position of the collation element in the source string that will be returned by the next invocation of the next() method. </para>
				/// </returns>
				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return GetOffset(); }
				[Dot42.DexImport("setOffset", "(I)V", AccessFlags = 1)]
						set{ SetOffset(value); }
				}

		}

		/// <summary>
		/// <para>Returns a fixed string based on a numeric value. The class can be used in conjunction with the MessageFormat class to handle plurals in messages. <c> ChoiceFormat </c> enables users to attach a format to a range of numbers. The choice is specified with an ascending list of doubles, where each item specifies a half-open interval up to the next item as in the following: X matches j if and only if <c> limit[j] &lt;= X &lt; limit[j+1] </c> . </para><para>If there is no match, then either the first or last index is used. The first or last index is used depending on whether the number is too low or too high. The length of the format array must be the same as the length of the limits array. <h5>Examples:</h5></para><para><blockquote><para></para><para><pre>
		///    double[] limits = {1, 2, 3, 4, 5, 6, 7};
		///    String[] fmts = {"Sun", "Mon", "Tue", "Wed", "Thur", "Fri", "Sat"};
		/// 
		///    double[] limits2 = {0, 1, ChoiceFormat.nextDouble(1)};
		///    String[] fmts2 = {"no files", "one file", "many files"};
		///    </pre> </para></blockquote></para><para>ChoiceFormat.nextDouble(double) allows to get the double following the one passed to the method. This is used to create half open intervals. </para><para><c> ChoiceFormat </c> objects also may be converted to and from patterns. The conversion can be done programmatically, as in the example above, or by using a pattern like the following: <blockquote><para></para><para><pre>
		///    "1#Sun|2#Mon|3#Tue|4#Wed|5#Thur|6#Fri|7#Sat"
		///    "0#are no files|1#is one file|1&amp;lt;are many files"
		///    </pre></para><para></para></blockquote></para><para>where: <ul><li><para>&lt;number&gt;"#"&lt;/number&gt; specifies an inclusive limit value; </para></li><li><para>&lt;number&gt;"&lt;"&lt;/number&gt; specifies an exclusive limit value. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/text/ChoiceFormat
		/// </java-name>
		[Dot42.DexImport("java/text/ChoiceFormat", AccessFlags = 33)]
		public partial class ChoiceFormat : global::Java.Text.NumberFormat
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> ChoiceFormat </c> with the specified double values and associated strings. When calling format with a double value <c> d </c> , then the element <c> i </c> in <c> formats </c> is selected where <c> i </c> fulfills <c> limits[i] &lt;= d &lt; limits[i+1] </c> . </para><para>The length of the <c> limits </c> and <c> formats </c> arrays must be the same.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([D[Ljava/lang/String;)V", AccessFlags = 1)]
				public ChoiceFormat(double[] limits, string[] formats) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ChoiceFormat </c> with the strings and limits parsed from the specified pattern.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ChoiceFormat(string template) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parses the pattern to determine new strings and ranges for this <c> ChoiceFormat </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string template) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new instance of <c> ChoiceFormat </c> with the same ranges and strings as this <c> ChoiceFormat </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> ChoiceFormat </c> .</para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object with this <c> ChoiceFormat </c> . The object must be an instance of <c> ChoiceFormat </c> and have the same limits and formats to be equal to this instance.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this instance; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(double @double, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(long int64, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				/// <para>Returns the strings associated with the ranges of this <c>       ChoiceFormat </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of format strings. </para>
				/// </returns>
				/// <java-name>
				/// getFormats
				/// </java-name>
				[Dot42.DexImport("getFormats", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] GetFormats() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				/// <para>Returns the limits of this <c> ChoiceFormat </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of doubles which make up the limits of this <c>               ChoiceFormat </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLimits
				/// </java-name>
				[Dot42.DexImport("getLimits", "()[D", AccessFlags = 1)]
				public virtual double[] GetLimits() /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. Objects which are equal return the same value for this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash.</para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the double value which is closest to the specified double but larger.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next larger double value. </para>
				/// </returns>
				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "(D)D", AccessFlags = 25)]
				public static double NextDouble(double value) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the double value which is closest to the specified double but either larger or smaller as specified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next larger or smaller double value. </para>
				/// </returns>
				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "(DZ)D", AccessFlags = 9)]
				public static double NextDouble(double value, bool increment) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Parses a double from the specified string starting at the index specified by <c> position </c> . The string is compared to the strings of this <c> ChoiceFormat </c> and if a match occurs then the lower bound of the corresponding range in the limits array is returned. If the string is successfully parsed then the index of the <c> ParsePosition </c> passed to this method is updated to the index following the parsed text. </para><para>If one of the format strings of this <c> ChoiceFormat </c> instance is found in <c> string </c> starting at <c> position.getIndex() </c> then <ul><li><para>the index in <c> position </c> is set to the index following the parsed text; </para></li><li><para>the Double corresponding to the format string is returned. </para></li></ul></para><para>If none of the format strings is found in <c> string </c> then <ul><li><para>the error index in <c> position </c> is set to the current index in <c> position </c> ; </para></li><li><para>Double.NaN is returned. </para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para>a Double resulting from the parse, or Double.NaN if there is an error </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", AccessFlags = 1)]
				public override global::Java.Lang.Number Parse(string @string, global::Java.Text.ParsePosition position) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Number);
				}

				/// <summary>
				/// <para>Returns the double value which is closest to the specified double but smaller.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next smaller double value. </para>
				/// </returns>
				/// <java-name>
				/// previousDouble
				/// </java-name>
				[Dot42.DexImport("previousDouble", "(D)D", AccessFlags = 25)]
				public static double PreviousDouble(double value) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Sets the double values and associated strings of this ChoiceFormat. When calling format with a double value <c> d </c> , then the element <c> i </c> in <c> formats </c> is selected where <c> i </c> fulfills <c> limits[i] &lt;= d &lt; limits[i+1] </c> . </para><para>The length of the <c> limits </c> and <c> formats </c> arrays must be the same.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChoices
				/// </java-name>
				[Dot42.DexImport("setChoices", "([D[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetChoices(double[] limits, string[] formats) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the pattern of this <c> ChoiceFormat </c> which specifies the ranges and their associated strings.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pattern. </para>
				/// </returns>
				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ChoiceFormat() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the strings associated with the ranges of this <c>       ChoiceFormat </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of format strings. </para>
				/// </returns>
				/// <java-name>
				/// getFormats
				/// </java-name>
				public object[] Formats
				{
				[Dot42.DexImport("getFormats", "()[Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetFormats(); }
				}

				/// <summary>
				/// <para>Returns the limits of this <c> ChoiceFormat </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of doubles which make up the limits of this <c>               ChoiceFormat </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLimits
				/// </java-name>
				public double[] Limits
				{
				[Dot42.DexImport("getLimits", "()[D", AccessFlags = 1)]
						get{ return GetLimits(); }
				}

		}

}


