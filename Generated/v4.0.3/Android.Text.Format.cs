#pragma warning disable 1717
namespace Android.Text.Format
{
		/// <java-name>
		/// android/text/format/DateFormat
		/// </java-name>
		[Dot42.DexImport("android/text/format/DateFormat", AccessFlags = 33)]
		public partial class DateFormat
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// QUOTE
				/// </java-name>
				[Dot42.DexImport("QUOTE", "C", AccessFlags = 25)]
				public const char QUOTE = '\'';
				/// <java-name>
				/// AM_PM
				/// </java-name>
				[Dot42.DexImport("AM_PM", "C", AccessFlags = 25)]
				public const char AM_PM = 'a';
				/// <java-name>
				/// CAPITAL_AM_PM
				/// </java-name>
				[Dot42.DexImport("CAPITAL_AM_PM", "C", AccessFlags = 25)]
				public const char CAPITAL_AM_PM = 'A';
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "C", AccessFlags = 25)]
				public const char DATE = 'd';
				/// <java-name>
				/// DAY
				/// </java-name>
				[Dot42.DexImport("DAY", "C", AccessFlags = 25)]
				public const char DAY = 'E';
				/// <java-name>
				/// HOUR
				/// </java-name>
				[Dot42.DexImport("HOUR", "C", AccessFlags = 25)]
				public const char HOUR = 'h';
				/// <java-name>
				/// HOUR_OF_DAY
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY", "C", AccessFlags = 25)]
				public const char HOUR_OF_DAY = 'k';
				/// <java-name>
				/// MINUTE
				/// </java-name>
				[Dot42.DexImport("MINUTE", "C", AccessFlags = 25)]
				public const char MINUTE = 'm';
				/// <java-name>
				/// MONTH
				/// </java-name>
				[Dot42.DexImport("MONTH", "C", AccessFlags = 25)]
				public const char MONTH = 'M';
				/// <java-name>
				/// SECONDS
				/// </java-name>
				[Dot42.DexImport("SECONDS", "C", AccessFlags = 25)]
				public const char SECONDS = 's';
				/// <java-name>
				/// TIME_ZONE
				/// </java-name>
				[Dot42.DexImport("TIME_ZONE", "C", AccessFlags = 25)]
				public const char TIME_ZONE = 'z';
				/// <java-name>
				/// YEAR
				/// </java-name>
				[Dot42.DexImport("YEAR", "C", AccessFlags = 25)]
				public const char YEAR = 'y';
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// is24HourFormat
				/// </java-name>
				[Dot42.DexImport("is24HourFormat", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool Is24HourFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTimeFormat
				/// </java-name>
				[Dot42.DexImport("getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetTimeFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getDateFormat
				/// </java-name>
				[Dot42.DexImport("getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getLongDateFormat
				/// </java-name>
				[Dot42.DexImport("getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetLongDateFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getMediumDateFormat
				/// </java-name>
				[Dot42.DexImport("getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetMediumDateFormat(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getDateFormatOrder
				/// </java-name>
				[Dot42.DexImport("getDateFormatOrder", "(Landroid/content/Context;)[C", AccessFlags = 25)]
				public static char[] GetDateFormatOrder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;", AccessFlags = 25)]
				public static global::Java.Lang.ICharSequence Format(global::Java.Lang.ICharSequence charSequence, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;", AccessFlags = 25)]
				public static global::Java.Lang.ICharSequence Format(global::Java.Lang.ICharSequence charSequence, global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;", AccessFlags = 25)]
				public static global::Java.Lang.ICharSequence Format(global::Java.Lang.ICharSequence charSequence, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

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
				/// <java-name>
				/// sameYearTable
				/// </java-name>
				[Dot42.DexImport("sameYearTable", "[I", AccessFlags = 25)]
				public static readonly int[] SameYearTable;
				/// <java-name>
				/// sameMonthTable
				/// </java-name>
				[Dot42.DexImport("sameMonthTable", "[I", AccessFlags = 25)]
				public static readonly int[] SameMonthTable;
				/// <java-name>
				/// LENGTH_LONG
				/// </java-name>
				[Dot42.DexImport("LENGTH_LONG", "I", AccessFlags = 25)]
				public const int LENGTH_LONG = 10;
				/// <java-name>
				/// LENGTH_MEDIUM
				/// </java-name>
				[Dot42.DexImport("LENGTH_MEDIUM", "I", AccessFlags = 25)]
				public const int LENGTH_MEDIUM = 20;
				/// <java-name>
				/// LENGTH_SHORT
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORT", "I", AccessFlags = 25)]
				public const int LENGTH_SHORT = 30;
				/// <java-name>
				/// LENGTH_SHORTER
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORTER", "I", AccessFlags = 25)]
				public const int LENGTH_SHORTER = 40;
				/// <java-name>
				/// LENGTH_SHORTEST
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORTEST", "I", AccessFlags = 25)]
				public const int LENGTH_SHORTEST = 50;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDayOfWeekString
				/// </java-name>
				[Dot42.DexImport("getDayOfWeekString", "(II)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetDayOfWeekString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAMPMString
				/// </java-name>
				[Dot42.DexImport("getAMPMString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAMPMString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMonthString
				/// </java-name>
				[Dot42.DexImport("getMonthString", "(II)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetMonthString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(J)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(long int64) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(JJJI)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(long int64, long int641, long int642, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getRelativeDateTimeString
				/// </java-name>
				[Dot42.DexImport("getRelativeDateTimeString", "(Landroid/content/Context;JJJI)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeDateTimeString(global::Android.Content.Context context, long int64, long int641, long int642, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// formatElapsedTime
				/// </java-name>
				[Dot42.DexImport("formatElapsedTime", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatElapsedTime(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatElapsedTime
				/// </java-name>
				[Dot42.DexImport("formatElapsedTime", "(Ljava/lang/StringBuilder;J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatElapsedTime(global::System.Text.StringBuilder stringBuilder, long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatSameDayTime
				/// </java-name>
				[Dot42.DexImport("formatSameDayTime", "(JJII)Ljava/lang/CharSequence;", AccessFlags = 25)]
				public static global::Java.Lang.ICharSequence FormatSameDayTime(long int64, long int641, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// isToday
				/// </java-name>
				[Dot42.DexImport("isToday", "(J)Z", AccessFlags = 9)]
				public static bool IsToday(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// formatDateRange
				/// </java-name>
				[Dot42.DexImport("formatDateRange", "(Landroid/content/Context;JJI)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDateRange(global::Android.Content.Context context, long int64, long int641, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatDateRange
				/// </java-name>
				[Dot42.DexImport("formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJI)Ljava/util/Formatter;", AccessFlags = 9)]
				public static global::Java.Util.Formatter FormatDateRange(global::Android.Content.Context context, global::Java.Util.Formatter formatter, long int64, long int641, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <java-name>
				/// formatDateRange
				/// </java-name>
				[Dot42.DexImport("formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJILjava/lang/String;)Ljava/util/F" +
    "ormatter;", AccessFlags = 9)]
				public static global::Java.Util.Formatter FormatDateRange(global::Android.Content.Context context, global::Java.Util.Formatter formatter, long int64, long int641, int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <java-name>
				/// formatDateTime
				/// </java-name>
				[Dot42.DexImport("formatDateTime", "(Landroid/content/Context;JI)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDateTime(global::Android.Content.Context context, long int64, int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getRelativeTimeSpanString
				/// </java-name>
				[Dot42.DexImport("getRelativeTimeSpanString", "(Landroid/content/Context;J)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetRelativeTimeSpanString(global::Android.Content.Context context, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

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

				/// <java-name>
				/// formatFileSize
				/// </java-name>
				[Dot42.DexImport("formatFileSize", "(Landroid/content/Context;J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatFileSize(global::Android.Content.Context context, long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatShortFileSize
				/// </java-name>
				[Dot42.DexImport("formatShortFileSize", "(Landroid/content/Context;J)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatShortFileSize(global::Android.Content.Context context, long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatIpAddress
				/// </java-name>
				[Dot42.DexImport("formatIpAddress", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatIpAddress(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

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
				/// <java-name>
				/// EPOCH_JULIAN_DAY
				/// </java-name>
				[Dot42.DexImport("EPOCH_JULIAN_DAY", "I", AccessFlags = 25)]
				public const int EPOCH_JULIAN_DAY = 2440588;
				/// <java-name>
				/// MONDAY_BEFORE_JULIAN_EPOCH
				/// </java-name>
				[Dot42.DexImport("MONDAY_BEFORE_JULIAN_EPOCH", "I", AccessFlags = 25)]
				public const int MONDAY_BEFORE_JULIAN_EPOCH = 2440585;
				/// <java-name>
				/// allDay
				/// </java-name>
				[Dot42.DexImport("allDay", "Z", AccessFlags = 1)]
				public bool AllDay;
				/// <java-name>
				/// second
				/// </java-name>
				[Dot42.DexImport("second", "I", AccessFlags = 1)]
				public int Second;
				/// <java-name>
				/// minute
				/// </java-name>
				[Dot42.DexImport("minute", "I", AccessFlags = 1)]
				public int Minute;
				/// <java-name>
				/// hour
				/// </java-name>
				[Dot42.DexImport("hour", "I", AccessFlags = 1)]
				public int Hour;
				/// <java-name>
				/// monthDay
				/// </java-name>
				[Dot42.DexImport("monthDay", "I", AccessFlags = 1)]
				public int MonthDay;
				/// <java-name>
				/// month
				/// </java-name>
				[Dot42.DexImport("month", "I", AccessFlags = 1)]
				public int Month;
				/// <java-name>
				/// year
				/// </java-name>
				[Dot42.DexImport("year", "I", AccessFlags = 1)]
				public int Year;
				/// <java-name>
				/// weekDay
				/// </java-name>
				[Dot42.DexImport("weekDay", "I", AccessFlags = 1)]
				public int WeekDay;
				/// <java-name>
				/// yearDay
				/// </java-name>
				[Dot42.DexImport("yearDay", "I", AccessFlags = 1)]
				public int YearDay;
				/// <java-name>
				/// isDst
				/// </java-name>
				[Dot42.DexImport("isDst", "I", AccessFlags = 1)]
				public int IsDst;
				/// <java-name>
				/// gmtoff
				/// </java-name>
				[Dot42.DexImport("gmtoff", "J", AccessFlags = 1)]
				public long Gmtoff;
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
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Time(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Time() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/text/format/Time;)V", AccessFlags = 1)]
				public Time(global::Android.Text.Format.Time time) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "(Z)J", AccessFlags = 257)]
				public virtual long Normalize(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// switchTimezone
				/// </java-name>
				[Dot42.DexImport("switchTimezone", "(Ljava/lang/String;)V", AccessFlags = 257)]
				public virtual void SwitchTimezone(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActualMaximum
				/// </java-name>
				[Dot42.DexImport("getActualMaximum", "(I)I", AccessFlags = 1)]
				public virtual int GetActualMaximum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Clear(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I", AccessFlags = 9)]
				public static int Compare(global::Android.Text.Format.Time time, global::Android.Text.Format.Time time1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Format(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 257)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parse3339
				/// </java-name>
				[Dot42.DexImport("parse3339", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Parse3339(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setToNow
				/// </java-name>
				[Dot42.DexImport("setToNow", "()V", AccessFlags = 257)]
				public virtual void SetToNow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toMillis
				/// </java-name>
				[Dot42.DexImport("toMillis", "(Z)J", AccessFlags = 257)]
				public virtual long ToMillis(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(J)V", AccessFlags = 257)]
				public virtual void Set(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format2445
				/// </java-name>
				[Dot42.DexImport("format2445", "()Ljava/lang/String;", AccessFlags = 257)]
				public virtual string Format2445() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/text/format/Time;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Text.Format.Time time) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIIIII)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(III)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Landroid/text/format/Time;)Z", AccessFlags = 1)]
				public virtual bool Before(global::Android.Text.Format.Time time) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Landroid/text/format/Time;)Z", AccessFlags = 1)]
				public virtual bool After(global::Android.Text.Format.Time time) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// format3339
				/// </java-name>
				[Dot42.DexImport("format3339", "(Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Format3339(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isEpoch
				/// </java-name>
				[Dot42.DexImport("isEpoch", "(Landroid/text/format/Time;)Z", AccessFlags = 9)]
				public static bool IsEpoch(global::Android.Text.Format.Time time) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getJulianDay
				/// </java-name>
				[Dot42.DexImport("getJulianDay", "(JJ)I", AccessFlags = 9)]
				public static int GetJulianDay(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setJulianDay
				/// </java-name>
				[Dot42.DexImport("setJulianDay", "(I)J", AccessFlags = 1)]
				public virtual long SetJulianDay(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getWeeksSinceEpochFromJulianDay
				/// </java-name>
				[Dot42.DexImport("getWeeksSinceEpochFromJulianDay", "(II)I", AccessFlags = 9)]
				public static int GetWeeksSinceEpochFromJulianDay(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getJulianMondayFromWeeksSinceEpoch
				/// </java-name>
				[Dot42.DexImport("getJulianMondayFromWeeksSinceEpoch", "(I)I", AccessFlags = 9)]
				public static int GetJulianMondayFromWeeksSinceEpoch(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCurrentTimezone
				/// </java-name>
				public static string CurrentTimezone
				{
						[Dot42.DexImport("getCurrentTimezone", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getWeekNumber
				/// </java-name>
				public virtual int WeekNumber
				{
						[Dot42.DexImport("getWeekNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

