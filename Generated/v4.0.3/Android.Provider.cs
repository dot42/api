#pragma warning disable 1717
namespace Android.Provider
{
		/// <java-name>
		/// android/provider/BaseColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/BaseColumns", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IBaseColumnsConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// _ID
				/// </java-name>
				[Dot42.DexImport("_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string _ID = "_id";
				/// <java-name>
				/// _COUNT
				/// </java-name>
				[Dot42.DexImport("_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string _COUNT = "_count";
		}

		/// <java-name>
		/// android/provider/BaseColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/BaseColumns", AccessFlags = 1537)]
		public partial interface IBaseColumns
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/provider/AlarmClock
		/// </java-name>
		[Dot42.DexImport("android/provider/AlarmClock", AccessFlags = 49)]
		public sealed partial class AlarmClock
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_SET_ALARM
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SET_ALARM = "android.intent.action.SET_ALARM";
				/// <java-name>
				/// EXTRA_MESSAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_MESSAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MESSAGE = "android.intent.extra.alarm.MESSAGE";
				/// <java-name>
				/// EXTRA_HOUR
				/// </java-name>
				[Dot42.DexImport("EXTRA_HOUR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_HOUR = "android.intent.extra.alarm.HOUR";
				/// <java-name>
				/// EXTRA_MINUTES
				/// </java-name>
				[Dot42.DexImport("EXTRA_MINUTES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MINUTES = "android.intent.extra.alarm.MINUTES";
				/// <java-name>
				/// EXTRA_SKIP_UI
				/// </java-name>
				[Dot42.DexImport("EXTRA_SKIP_UI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SKIP_UI = "android.intent.extra.alarm.SKIP_UI";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AlarmClock() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/provider/CalendarContract
		/// </java-name>
		[Dot42.DexImport("android/provider/CalendarContract", AccessFlags = 49)]
		public sealed partial class CalendarContract
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_EVENT_REMINDER
				/// </java-name>
				[Dot42.DexImport("ACTION_EVENT_REMINDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EVENT_REMINDER = "android.intent.action.EVENT_REMINDER";
				/// <java-name>
				/// EXTRA_EVENT_BEGIN_TIME
				/// </java-name>
				[Dot42.DexImport("EXTRA_EVENT_BEGIN_TIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EVENT_BEGIN_TIME = "beginTime";
				/// <java-name>
				/// EXTRA_EVENT_END_TIME
				/// </java-name>
				[Dot42.DexImport("EXTRA_EVENT_END_TIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EVENT_END_TIME = "endTime";
				/// <java-name>
				/// EXTRA_EVENT_ALL_DAY
				/// </java-name>
				[Dot42.DexImport("EXTRA_EVENT_ALL_DAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EVENT_ALL_DAY = "allDay";
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "com.android.calendar";
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				/// <java-name>
				/// CALLER_IS_SYNCADAPTER
				/// </java-name>
				[Dot42.DexImport("CALLER_IS_SYNCADAPTER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CALLER_IS_SYNCADAPTER = "caller_is_syncadapter";
				/// <java-name>
				/// ACCOUNT_TYPE_LOCAL
				/// </java-name>
				[Dot42.DexImport("ACCOUNT_TYPE_LOCAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCOUNT_TYPE_LOCAL = "LOCAL";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CalendarContract() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$SyncState
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$SyncState", AccessFlags = 25)]
				public sealed partial class SyncState : global::Android.Provider.SyncStateContract.IColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SyncState() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$ExtendedProperties
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$ExtendedProperties", AccessFlags = 25)]
				public sealed partial class ExtendedProperties : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.IExtendedPropertiesColumns, global::Android.Provider.CalendarContract.IEventsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal ExtendedProperties() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$ExtendedPropertiesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$ExtendedPropertiesColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IExtendedPropertiesColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EVENT_ID
						/// </java-name>
						[Dot42.DexImport("EVENT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_ID = "event_id";
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
				}

				/// <java-name>
				/// android/provider/CalendarContract$ExtendedPropertiesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$ExtendedPropertiesColumns", AccessFlags = 1548)]
				protected internal partial interface IExtendedPropertiesColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$Colors
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$Colors", AccessFlags = 25)]
				public sealed partial class Colors : global::Android.Provider.CalendarContract.IColorsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Colors() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$ColorsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$ColorsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IColorsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// COLOR_TYPE
						/// </java-name>
						[Dot42.DexImport("COLOR_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COLOR_TYPE = "color_type";
						/// <java-name>
						/// TYPE_CALENDAR
						/// </java-name>
						[Dot42.DexImport("TYPE_CALENDAR", "I", AccessFlags = 25)]
						public const int TYPE_CALENDAR = 0;
						/// <java-name>
						/// TYPE_EVENT
						/// </java-name>
						[Dot42.DexImport("TYPE_EVENT", "I", AccessFlags = 25)]
						public const int TYPE_EVENT = 1;
						/// <java-name>
						/// COLOR_KEY
						/// </java-name>
						[Dot42.DexImport("COLOR_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COLOR_KEY = "color_index";
						/// <java-name>
						/// COLOR
						/// </java-name>
						[Dot42.DexImport("COLOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COLOR = "color";
				}

				/// <java-name>
				/// android/provider/CalendarContract$ColorsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$ColorsColumns", AccessFlags = 1548)]
				protected internal partial interface IColorsColumns : global::Android.Provider.SyncStateContract.IColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarAlerts
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarAlerts", AccessFlags = 25)]
				public sealed partial class CalendarAlerts : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.ICalendarAlertsColumns, global::Android.Provider.CalendarContract.IEventsColumns, global::Android.Provider.CalendarContract.ICalendarColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_URI_BY_INSTANCE
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI_BY_INSTANCE", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI_BY_INSTANCE;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CalendarAlerts() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarAlertsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarAlertsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ICalendarAlertsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EVENT_ID
						/// </java-name>
						[Dot42.DexImport("EVENT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_ID = "event_id";
						/// <java-name>
						/// BEGIN
						/// </java-name>
						[Dot42.DexImport("BEGIN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BEGIN = "begin";
						/// <java-name>
						/// END
						/// </java-name>
						[Dot42.DexImport("END", "Ljava/lang/String;", AccessFlags = 25)]
						public const string END = "end";
						/// <java-name>
						/// ALARM_TIME
						/// </java-name>
						[Dot42.DexImport("ALARM_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALARM_TIME = "alarmTime";
						/// <java-name>
						/// CREATION_TIME
						/// </java-name>
						[Dot42.DexImport("CREATION_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CREATION_TIME = "creationTime";
						/// <java-name>
						/// RECEIVED_TIME
						/// </java-name>
						[Dot42.DexImport("RECEIVED_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RECEIVED_TIME = "receivedTime";
						/// <java-name>
						/// NOTIFY_TIME
						/// </java-name>
						[Dot42.DexImport("NOTIFY_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTIFY_TIME = "notifyTime";
						/// <java-name>
						/// STATE
						/// </java-name>
						[Dot42.DexImport("STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATE = "state";
						/// <java-name>
						/// STATE_SCHEDULED
						/// </java-name>
						[Dot42.DexImport("STATE_SCHEDULED", "I", AccessFlags = 25)]
						public const int STATE_SCHEDULED = 0;
						/// <java-name>
						/// STATE_FIRED
						/// </java-name>
						[Dot42.DexImport("STATE_FIRED", "I", AccessFlags = 25)]
						public const int STATE_FIRED = 1;
						/// <java-name>
						/// STATE_DISMISSED
						/// </java-name>
						[Dot42.DexImport("STATE_DISMISSED", "I", AccessFlags = 25)]
						public const int STATE_DISMISSED = 2;
						/// <java-name>
						/// MINUTES
						/// </java-name>
						[Dot42.DexImport("MINUTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MINUTES = "minutes";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "begin ASC,title ASC";
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarAlertsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarAlertsColumns", AccessFlags = 1548)]
				protected internal partial interface ICalendarAlertsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$Reminders
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$Reminders", AccessFlags = 25)]
				public sealed partial class Reminders : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.IRemindersColumns, global::Android.Provider.CalendarContract.IEventsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Reminders() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Landroid/content/ContentResolver;J[Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 25)]
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, long int64, string[] @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$RemindersColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$RemindersColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IRemindersColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EVENT_ID
						/// </java-name>
						[Dot42.DexImport("EVENT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_ID = "event_id";
						/// <java-name>
						/// MINUTES
						/// </java-name>
						[Dot42.DexImport("MINUTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MINUTES = "minutes";
						/// <java-name>
						/// MINUTES_DEFAULT
						/// </java-name>
						[Dot42.DexImport("MINUTES_DEFAULT", "I", AccessFlags = 25)]
						public const int MINUTES_DEFAULT = -1;
						/// <java-name>
						/// METHOD
						/// </java-name>
						[Dot42.DexImport("METHOD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string METHOD = "method";
						/// <java-name>
						/// METHOD_DEFAULT
						/// </java-name>
						[Dot42.DexImport("METHOD_DEFAULT", "I", AccessFlags = 25)]
						public const int METHOD_DEFAULT = 0;
						/// <java-name>
						/// METHOD_ALERT
						/// </java-name>
						[Dot42.DexImport("METHOD_ALERT", "I", AccessFlags = 25)]
						public const int METHOD_ALERT = 1;
						/// <java-name>
						/// METHOD_EMAIL
						/// </java-name>
						[Dot42.DexImport("METHOD_EMAIL", "I", AccessFlags = 25)]
						public const int METHOD_EMAIL = 2;
						/// <java-name>
						/// METHOD_SMS
						/// </java-name>
						[Dot42.DexImport("METHOD_SMS", "I", AccessFlags = 25)]
						public const int METHOD_SMS = 3;
				}

				/// <java-name>
				/// android/provider/CalendarContract$RemindersColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$RemindersColumns", AccessFlags = 1548)]
				protected internal partial interface IRemindersColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$EventDays
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$EventDays", AccessFlags = 25)]
				public sealed partial class EventDays : global::Android.Provider.CalendarContract.IEventDaysColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal EventDays() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Landroid/content/ContentResolver;II[Ljava/lang/String;)Landroid/database/Cursor;" +
    "", AccessFlags = 25)]
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, int int32, int int321, string[] @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$EventDaysColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$EventDaysColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IEventDaysColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// STARTDAY
						/// </java-name>
						[Dot42.DexImport("STARTDAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STARTDAY = "startDay";
						/// <java-name>
						/// ENDDAY
						/// </java-name>
						[Dot42.DexImport("ENDDAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ENDDAY = "endDay";
				}

				/// <java-name>
				/// android/provider/CalendarContract$EventDaysColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$EventDaysColumns", AccessFlags = 1548)]
				protected internal partial interface IEventDaysColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarCache
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarCache", AccessFlags = 25)]
				public sealed partial class CalendarCache : global::Android.Provider.CalendarContract.ICalendarCacheColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// URI
						/// </java-name>
						[Dot42.DexImport("URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri URI;
						/// <java-name>
						/// KEY_TIMEZONE_TYPE
						/// </java-name>
						[Dot42.DexImport("KEY_TIMEZONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_TIMEZONE_TYPE = "timezoneType";
						/// <java-name>
						/// KEY_TIMEZONE_INSTANCES
						/// </java-name>
						[Dot42.DexImport("KEY_TIMEZONE_INSTANCES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_TIMEZONE_INSTANCES = "timezoneInstances";
						/// <java-name>
						/// KEY_TIMEZONE_INSTANCES_PREVIOUS
						/// </java-name>
						[Dot42.DexImport("KEY_TIMEZONE_INSTANCES_PREVIOUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_TIMEZONE_INSTANCES_PREVIOUS = "timezoneInstancesPrevious";
						/// <java-name>
						/// TIMEZONE_TYPE_AUTO
						/// </java-name>
						[Dot42.DexImport("TIMEZONE_TYPE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMEZONE_TYPE_AUTO = "auto";
						/// <java-name>
						/// TIMEZONE_TYPE_HOME
						/// </java-name>
						[Dot42.DexImport("TIMEZONE_TYPE_HOME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMEZONE_TYPE_HOME = "home";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CalendarCache() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarCacheColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarCacheColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ICalendarCacheColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// KEY
						/// </java-name>
						[Dot42.DexImport("KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY = "key";
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarCacheColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarCacheColumns", AccessFlags = 1548)]
				protected internal partial interface ICalendarCacheColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$Instances
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$Instances", AccessFlags = 25)]
				public sealed partial class Instances : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.IEventsColumns, global::Android.Provider.CalendarContract.ICalendarColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_BY_DAY_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_BY_DAY_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_BY_DAY_URI;
						/// <java-name>
						/// CONTENT_SEARCH_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_SEARCH_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_SEARCH_URI;
						/// <java-name>
						/// CONTENT_SEARCH_BY_DAY_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_SEARCH_BY_DAY_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_SEARCH_BY_DAY_URI;
						/// <java-name>
						/// BEGIN
						/// </java-name>
						[Dot42.DexImport("BEGIN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BEGIN = "begin";
						/// <java-name>
						/// END
						/// </java-name>
						[Dot42.DexImport("END", "Ljava/lang/String;", AccessFlags = 25)]
						public const string END = "end";
						/// <java-name>
						/// EVENT_ID
						/// </java-name>
						[Dot42.DexImport("EVENT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_ID = "event_id";
						/// <java-name>
						/// START_DAY
						/// </java-name>
						[Dot42.DexImport("START_DAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string START_DAY = "startDay";
						/// <java-name>
						/// END_DAY
						/// </java-name>
						[Dot42.DexImport("END_DAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string END_DAY = "endDay";
						/// <java-name>
						/// START_MINUTE
						/// </java-name>
						[Dot42.DexImport("START_MINUTE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string START_MINUTE = "startMinute";
						/// <java-name>
						/// END_MINUTE
						/// </java-name>
						[Dot42.DexImport("END_MINUTE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string END_MINUTE = "endMinute";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Instances() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Landroid/content/ContentResolver;[Ljava/lang/String;JJ)Landroid/database/Cursor;" +
    "", AccessFlags = 25)]
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, string[] @string, long int64, long int641) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Landroid/content/ContentResolver;[Ljava/lang/String;JJLjava/lang/String;)Landroi" +
    "d/database/Cursor;", AccessFlags = 25)]
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, string[] @string, long int64, long int641, string string1) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$Events
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$Events", AccessFlags = 25)]
				public sealed partial class Events : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.ISyncColumns, global::Android.Provider.CalendarContract.IEventsColumns, global::Android.Provider.CalendarContract.ICalendarColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_EXCEPTION_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_EXCEPTION_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_EXCEPTION_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Events() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$EventsEntity
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$EventsEntity", AccessFlags = 25)]
				public sealed partial class EventsEntity : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.ISyncColumns, global::Android.Provider.CalendarContract.IEventsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal EventsEntity() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newEntityIterator
						/// </java-name>
						[Dot42.DexImport("newEntityIterator", "(Landroid/database/Cursor;Landroid/content/ContentResolver;)Landroid/content/Enti" +
    "tyIterator;", AccessFlags = 9)]
						public static global::Android.Content.IEntityIterator NewEntityIterator(global::Android.Database.ICursor cursor, global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.IEntityIterator);
						}

						/// <java-name>
						/// newEntityIterator
						/// </java-name>
						[Dot42.DexImport("newEntityIterator", "(Landroid/database/Cursor;Landroid/content/ContentProviderClient;)Landroid/conten" +
    "t/EntityIterator;", AccessFlags = 9)]
						public static global::Android.Content.IEntityIterator NewEntityIterator(global::Android.Database.ICursor cursor, global::Android.Content.ContentProviderClient contentProviderClient) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.IEntityIterator);
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$EventsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$EventsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IEventsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CALENDAR_ID
						/// </java-name>
						[Dot42.DexImport("CALENDAR_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_ID = "calendar_id";
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <java-name>
						/// DESCRIPTION
						/// </java-name>
						[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DESCRIPTION = "description";
						/// <java-name>
						/// EVENT_LOCATION
						/// </java-name>
						[Dot42.DexImport("EVENT_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_LOCATION = "eventLocation";
						/// <java-name>
						/// EVENT_COLOR
						/// </java-name>
						[Dot42.DexImport("EVENT_COLOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_COLOR = "eventColor";
						/// <java-name>
						/// EVENT_COLOR_KEY
						/// </java-name>
						[Dot42.DexImport("EVENT_COLOR_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_COLOR_KEY = "eventColor_index";
						/// <java-name>
						/// STATUS
						/// </java-name>
						[Dot42.DexImport("STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS = "eventStatus";
						/// <java-name>
						/// STATUS_TENTATIVE
						/// </java-name>
						[Dot42.DexImport("STATUS_TENTATIVE", "I", AccessFlags = 25)]
						public const int STATUS_TENTATIVE = 0;
						/// <java-name>
						/// STATUS_CONFIRMED
						/// </java-name>
						[Dot42.DexImport("STATUS_CONFIRMED", "I", AccessFlags = 25)]
						public const int STATUS_CONFIRMED = 1;
						/// <java-name>
						/// STATUS_CANCELED
						/// </java-name>
						[Dot42.DexImport("STATUS_CANCELED", "I", AccessFlags = 25)]
						public const int STATUS_CANCELED = 2;
						/// <java-name>
						/// SELF_ATTENDEE_STATUS
						/// </java-name>
						[Dot42.DexImport("SELF_ATTENDEE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SELF_ATTENDEE_STATUS = "selfAttendeeStatus";
						/// <java-name>
						/// SYNC_DATA1
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA1 = "sync_data1";
						/// <java-name>
						/// SYNC_DATA2
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA2 = "sync_data2";
						/// <java-name>
						/// SYNC_DATA3
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA3 = "sync_data3";
						/// <java-name>
						/// SYNC_DATA4
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA4 = "sync_data4";
						/// <java-name>
						/// SYNC_DATA5
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA5", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA5 = "sync_data5";
						/// <java-name>
						/// SYNC_DATA6
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA6", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA6 = "sync_data6";
						/// <java-name>
						/// SYNC_DATA7
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA7", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA7 = "sync_data7";
						/// <java-name>
						/// SYNC_DATA8
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA8", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA8 = "sync_data8";
						/// <java-name>
						/// SYNC_DATA9
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA9", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA9 = "sync_data9";
						/// <java-name>
						/// SYNC_DATA10
						/// </java-name>
						[Dot42.DexImport("SYNC_DATA10", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_DATA10 = "sync_data10";
						/// <java-name>
						/// LAST_SYNCED
						/// </java-name>
						[Dot42.DexImport("LAST_SYNCED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LAST_SYNCED = "lastSynced";
						/// <java-name>
						/// DTSTART
						/// </java-name>
						[Dot42.DexImport("DTSTART", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DTSTART = "dtstart";
						/// <java-name>
						/// DTEND
						/// </java-name>
						[Dot42.DexImport("DTEND", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DTEND = "dtend";
						/// <java-name>
						/// DURATION
						/// </java-name>
						[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DURATION = "duration";
						/// <java-name>
						/// EVENT_TIMEZONE
						/// </java-name>
						[Dot42.DexImport("EVENT_TIMEZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_TIMEZONE = "eventTimezone";
						/// <java-name>
						/// EVENT_END_TIMEZONE
						/// </java-name>
						[Dot42.DexImport("EVENT_END_TIMEZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_END_TIMEZONE = "eventEndTimezone";
						/// <java-name>
						/// ALL_DAY
						/// </java-name>
						[Dot42.DexImport("ALL_DAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALL_DAY = "allDay";
						/// <java-name>
						/// ACCESS_LEVEL
						/// </java-name>
						[Dot42.DexImport("ACCESS_LEVEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_LEVEL = "accessLevel";
						/// <java-name>
						/// ACCESS_DEFAULT
						/// </java-name>
						[Dot42.DexImport("ACCESS_DEFAULT", "I", AccessFlags = 25)]
						public const int ACCESS_DEFAULT = 0;
						/// <java-name>
						/// ACCESS_CONFIDENTIAL
						/// </java-name>
						[Dot42.DexImport("ACCESS_CONFIDENTIAL", "I", AccessFlags = 25)]
						public const int ACCESS_CONFIDENTIAL = 1;
						/// <java-name>
						/// ACCESS_PRIVATE
						/// </java-name>
						[Dot42.DexImport("ACCESS_PRIVATE", "I", AccessFlags = 25)]
						public const int ACCESS_PRIVATE = 2;
						/// <java-name>
						/// ACCESS_PUBLIC
						/// </java-name>
						[Dot42.DexImport("ACCESS_PUBLIC", "I", AccessFlags = 25)]
						public const int ACCESS_PUBLIC = 3;
						/// <java-name>
						/// AVAILABILITY
						/// </java-name>
						[Dot42.DexImport("AVAILABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AVAILABILITY = "availability";
						/// <java-name>
						/// AVAILABILITY_BUSY
						/// </java-name>
						[Dot42.DexImport("AVAILABILITY_BUSY", "I", AccessFlags = 25)]
						public const int AVAILABILITY_BUSY = 0;
						/// <java-name>
						/// AVAILABILITY_FREE
						/// </java-name>
						[Dot42.DexImport("AVAILABILITY_FREE", "I", AccessFlags = 25)]
						public const int AVAILABILITY_FREE = 1;
						/// <java-name>
						/// AVAILABILITY_TENTATIVE
						/// </java-name>
						[Dot42.DexImport("AVAILABILITY_TENTATIVE", "I", AccessFlags = 25)]
						public const int AVAILABILITY_TENTATIVE = 2;
						/// <java-name>
						/// HAS_ALARM
						/// </java-name>
						[Dot42.DexImport("HAS_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAS_ALARM = "hasAlarm";
						/// <java-name>
						/// HAS_EXTENDED_PROPERTIES
						/// </java-name>
						[Dot42.DexImport("HAS_EXTENDED_PROPERTIES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAS_EXTENDED_PROPERTIES = "hasExtendedProperties";
						/// <java-name>
						/// RRULE
						/// </java-name>
						[Dot42.DexImport("RRULE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RRULE = "rrule";
						/// <java-name>
						/// RDATE
						/// </java-name>
						[Dot42.DexImport("RDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RDATE = "rdate";
						/// <java-name>
						/// EXRULE
						/// </java-name>
						[Dot42.DexImport("EXRULE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXRULE = "exrule";
						/// <java-name>
						/// EXDATE
						/// </java-name>
						[Dot42.DexImport("EXDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXDATE = "exdate";
						/// <java-name>
						/// ORIGINAL_ID
						/// </java-name>
						[Dot42.DexImport("ORIGINAL_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ORIGINAL_ID = "original_id";
						/// <java-name>
						/// ORIGINAL_SYNC_ID
						/// </java-name>
						[Dot42.DexImport("ORIGINAL_SYNC_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ORIGINAL_SYNC_ID = "original_sync_id";
						/// <java-name>
						/// ORIGINAL_INSTANCE_TIME
						/// </java-name>
						[Dot42.DexImport("ORIGINAL_INSTANCE_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ORIGINAL_INSTANCE_TIME = "originalInstanceTime";
						/// <java-name>
						/// ORIGINAL_ALL_DAY
						/// </java-name>
						[Dot42.DexImport("ORIGINAL_ALL_DAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ORIGINAL_ALL_DAY = "originalAllDay";
						/// <java-name>
						/// LAST_DATE
						/// </java-name>
						[Dot42.DexImport("LAST_DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LAST_DATE = "lastDate";
						/// <java-name>
						/// HAS_ATTENDEE_DATA
						/// </java-name>
						[Dot42.DexImport("HAS_ATTENDEE_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAS_ATTENDEE_DATA = "hasAttendeeData";
						/// <java-name>
						/// GUESTS_CAN_MODIFY
						/// </java-name>
						[Dot42.DexImport("GUESTS_CAN_MODIFY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GUESTS_CAN_MODIFY = "guestsCanModify";
						/// <java-name>
						/// GUESTS_CAN_INVITE_OTHERS
						/// </java-name>
						[Dot42.DexImport("GUESTS_CAN_INVITE_OTHERS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GUESTS_CAN_INVITE_OTHERS = "guestsCanInviteOthers";
						/// <java-name>
						/// GUESTS_CAN_SEE_GUESTS
						/// </java-name>
						[Dot42.DexImport("GUESTS_CAN_SEE_GUESTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GUESTS_CAN_SEE_GUESTS = "guestsCanSeeGuests";
						/// <java-name>
						/// ORGANIZER
						/// </java-name>
						[Dot42.DexImport("ORGANIZER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ORGANIZER = "organizer";
						/// <java-name>
						/// CAN_INVITE_OTHERS
						/// </java-name>
						[Dot42.DexImport("CAN_INVITE_OTHERS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAN_INVITE_OTHERS = "canInviteOthers";
				}

				/// <java-name>
				/// android/provider/CalendarContract$EventsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$EventsColumns", AccessFlags = 1548)]
				protected internal partial interface IEventsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$Attendees
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$Attendees", AccessFlags = 25)]
				public sealed partial class Attendees : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.IAttendeesColumns, global::Android.Provider.CalendarContract.IEventsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Attendees() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Landroid/content/ContentResolver;J[Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 25)]
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, long int64, string[] @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$AttendeesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$AttendeesColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IAttendeesColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EVENT_ID
						/// </java-name>
						[Dot42.DexImport("EVENT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EVENT_ID = "event_id";
						/// <java-name>
						/// ATTENDEE_NAME
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTENDEE_NAME = "attendeeName";
						/// <java-name>
						/// ATTENDEE_EMAIL
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTENDEE_EMAIL = "attendeeEmail";
						/// <java-name>
						/// ATTENDEE_RELATIONSHIP
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_RELATIONSHIP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTENDEE_RELATIONSHIP = "attendeeRelationship";
						/// <java-name>
						/// RELATIONSHIP_NONE
						/// </java-name>
						[Dot42.DexImport("RELATIONSHIP_NONE", "I", AccessFlags = 25)]
						public const int RELATIONSHIP_NONE = 0;
						/// <java-name>
						/// RELATIONSHIP_ATTENDEE
						/// </java-name>
						[Dot42.DexImport("RELATIONSHIP_ATTENDEE", "I", AccessFlags = 25)]
						public const int RELATIONSHIP_ATTENDEE = 1;
						/// <java-name>
						/// RELATIONSHIP_ORGANIZER
						/// </java-name>
						[Dot42.DexImport("RELATIONSHIP_ORGANIZER", "I", AccessFlags = 25)]
						public const int RELATIONSHIP_ORGANIZER = 2;
						/// <java-name>
						/// RELATIONSHIP_PERFORMER
						/// </java-name>
						[Dot42.DexImport("RELATIONSHIP_PERFORMER", "I", AccessFlags = 25)]
						public const int RELATIONSHIP_PERFORMER = 3;
						/// <java-name>
						/// RELATIONSHIP_SPEAKER
						/// </java-name>
						[Dot42.DexImport("RELATIONSHIP_SPEAKER", "I", AccessFlags = 25)]
						public const int RELATIONSHIP_SPEAKER = 4;
						/// <java-name>
						/// ATTENDEE_TYPE
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTENDEE_TYPE = "attendeeType";
						/// <java-name>
						/// TYPE_NONE
						/// </java-name>
						[Dot42.DexImport("TYPE_NONE", "I", AccessFlags = 25)]
						public const int TYPE_NONE = 0;
						/// <java-name>
						/// TYPE_REQUIRED
						/// </java-name>
						[Dot42.DexImport("TYPE_REQUIRED", "I", AccessFlags = 25)]
						public const int TYPE_REQUIRED = 1;
						/// <java-name>
						/// TYPE_OPTIONAL
						/// </java-name>
						[Dot42.DexImport("TYPE_OPTIONAL", "I", AccessFlags = 25)]
						public const int TYPE_OPTIONAL = 2;
						/// <java-name>
						/// TYPE_RESOURCE
						/// </java-name>
						[Dot42.DexImport("TYPE_RESOURCE", "I", AccessFlags = 25)]
						public const int TYPE_RESOURCE = 3;
						/// <java-name>
						/// ATTENDEE_STATUS
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTENDEE_STATUS = "attendeeStatus";
						/// <java-name>
						/// ATTENDEE_STATUS_NONE
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_STATUS_NONE", "I", AccessFlags = 25)]
						public const int ATTENDEE_STATUS_NONE = 0;
						/// <java-name>
						/// ATTENDEE_STATUS_ACCEPTED
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_STATUS_ACCEPTED", "I", AccessFlags = 25)]
						public const int ATTENDEE_STATUS_ACCEPTED = 1;
						/// <java-name>
						/// ATTENDEE_STATUS_DECLINED
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_STATUS_DECLINED", "I", AccessFlags = 25)]
						public const int ATTENDEE_STATUS_DECLINED = 2;
						/// <java-name>
						/// ATTENDEE_STATUS_INVITED
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_STATUS_INVITED", "I", AccessFlags = 25)]
						public const int ATTENDEE_STATUS_INVITED = 3;
						/// <java-name>
						/// ATTENDEE_STATUS_TENTATIVE
						/// </java-name>
						[Dot42.DexImport("ATTENDEE_STATUS_TENTATIVE", "I", AccessFlags = 25)]
						public const int ATTENDEE_STATUS_TENTATIVE = 4;
				}

				/// <java-name>
				/// android/provider/CalendarContract$AttendeesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$AttendeesColumns", AccessFlags = 1548)]
				protected internal partial interface IAttendeesColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$Calendars
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$Calendars", AccessFlags = 25)]
				public sealed partial class Calendars : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.ISyncColumns, global::Android.Provider.CalendarContract.ICalendarColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "calendar_displayName";
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <java-name>
						/// CALENDAR_LOCATION
						/// </java-name>
						[Dot42.DexImport("CALENDAR_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_LOCATION = "calendar_location";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Calendars() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarEntity
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarEntity", AccessFlags = 25)]
				public sealed partial class CalendarEntity : global::Android.Provider.IBaseColumns, global::Android.Provider.CalendarContract.ISyncColumns, global::Android.Provider.CalendarContract.ICalendarColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CalendarEntity() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newEntityIterator
						/// </java-name>
						[Dot42.DexImport("newEntityIterator", "(Landroid/database/Cursor;)Landroid/content/EntityIterator;", AccessFlags = 9)]
						public static global::Android.Content.IEntityIterator NewEntityIterator(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.IEntityIterator);
						}

				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ICalendarColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CALENDAR_COLOR
						/// </java-name>
						[Dot42.DexImport("CALENDAR_COLOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_COLOR = "calendar_color";
						/// <java-name>
						/// CALENDAR_COLOR_KEY
						/// </java-name>
						[Dot42.DexImport("CALENDAR_COLOR_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_COLOR_KEY = "calendar_color_index";
						/// <java-name>
						/// CALENDAR_DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("CALENDAR_DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_DISPLAY_NAME = "calendar_displayName";
						/// <java-name>
						/// CALENDAR_ACCESS_LEVEL
						/// </java-name>
						[Dot42.DexImport("CALENDAR_ACCESS_LEVEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_ACCESS_LEVEL = "calendar_access_level";
						/// <java-name>
						/// CAL_ACCESS_NONE
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_NONE", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_NONE = 0;
						/// <java-name>
						/// CAL_ACCESS_FREEBUSY
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_FREEBUSY", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_FREEBUSY = 100;
						/// <java-name>
						/// CAL_ACCESS_READ
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_READ", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_READ = 200;
						/// <java-name>
						/// CAL_ACCESS_RESPOND
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_RESPOND", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_RESPOND = 300;
						/// <java-name>
						/// CAL_ACCESS_OVERRIDE
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_OVERRIDE", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_OVERRIDE = 400;
						/// <java-name>
						/// CAL_ACCESS_CONTRIBUTOR
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_CONTRIBUTOR", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_CONTRIBUTOR = 500;
						/// <java-name>
						/// CAL_ACCESS_EDITOR
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_EDITOR", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_EDITOR = 600;
						/// <java-name>
						/// CAL_ACCESS_OWNER
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_OWNER", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_OWNER = 700;
						/// <java-name>
						/// CAL_ACCESS_ROOT
						/// </java-name>
						[Dot42.DexImport("CAL_ACCESS_ROOT", "I", AccessFlags = 25)]
						public const int CAL_ACCESS_ROOT = 800;
						/// <java-name>
						/// VISIBLE
						/// </java-name>
						[Dot42.DexImport("VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VISIBLE = "visible";
						/// <java-name>
						/// CALENDAR_TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("CALENDAR_TIME_ZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALENDAR_TIME_ZONE = "calendar_timezone";
						/// <java-name>
						/// SYNC_EVENTS
						/// </java-name>
						[Dot42.DexImport("SYNC_EVENTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_EVENTS = "sync_events";
						/// <java-name>
						/// OWNER_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("OWNER_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string OWNER_ACCOUNT = "ownerAccount";
						/// <java-name>
						/// CAN_ORGANIZER_RESPOND
						/// </java-name>
						[Dot42.DexImport("CAN_ORGANIZER_RESPOND", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAN_ORGANIZER_RESPOND = "canOrganizerRespond";
						/// <java-name>
						/// CAN_MODIFY_TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("CAN_MODIFY_TIME_ZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAN_MODIFY_TIME_ZONE = "canModifyTimeZone";
						/// <java-name>
						/// MAX_REMINDERS
						/// </java-name>
						[Dot42.DexImport("MAX_REMINDERS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MAX_REMINDERS = "maxReminders";
						/// <java-name>
						/// ALLOWED_REMINDERS
						/// </java-name>
						[Dot42.DexImport("ALLOWED_REMINDERS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOWED_REMINDERS = "allowedReminders";
						/// <java-name>
						/// ALLOWED_AVAILABILITY
						/// </java-name>
						[Dot42.DexImport("ALLOWED_AVAILABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOWED_AVAILABILITY = "allowedAvailability";
						/// <java-name>
						/// ALLOWED_ATTENDEE_TYPES
						/// </java-name>
						[Dot42.DexImport("ALLOWED_ATTENDEE_TYPES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOWED_ATTENDEE_TYPES = "allowedAttendeeTypes";
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarColumns", AccessFlags = 1548)]
				protected internal partial interface ICalendarColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$SyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$SyncColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISyncColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <java-name>
						/// _SYNC_ID
						/// </java-name>
						[Dot42.DexImport("_SYNC_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string _SYNC_ID = "_sync_id";
						/// <java-name>
						/// DIRTY
						/// </java-name>
						[Dot42.DexImport("DIRTY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIRTY = "dirty";
						/// <java-name>
						/// DELETED
						/// </java-name>
						[Dot42.DexImport("DELETED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETED = "deleted";
						/// <java-name>
						/// CAN_PARTIALLY_UPDATE
						/// </java-name>
						[Dot42.DexImport("CAN_PARTIALLY_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAN_PARTIALLY_UPDATE = "canPartiallyUpdate";
				}

				/// <java-name>
				/// android/provider/CalendarContract$SyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$SyncColumns", AccessFlags = 1548)]
				protected internal partial interface ISyncColumns : global::Android.Provider.CalendarContract.ICalendarSyncColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarSyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarSyncColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ICalendarSyncColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CAL_SYNC1
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC1 = "cal_sync1";
						/// <java-name>
						/// CAL_SYNC2
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC2 = "cal_sync2";
						/// <java-name>
						/// CAL_SYNC3
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC3 = "cal_sync3";
						/// <java-name>
						/// CAL_SYNC4
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC4 = "cal_sync4";
						/// <java-name>
						/// CAL_SYNC5
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC5", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC5 = "cal_sync5";
						/// <java-name>
						/// CAL_SYNC6
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC6", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC6 = "cal_sync6";
						/// <java-name>
						/// CAL_SYNC7
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC7", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC7 = "cal_sync7";
						/// <java-name>
						/// CAL_SYNC8
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC8", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC8 = "cal_sync8";
						/// <java-name>
						/// CAL_SYNC9
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC9", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC9 = "cal_sync9";
						/// <java-name>
						/// CAL_SYNC10
						/// </java-name>
						[Dot42.DexImport("CAL_SYNC10", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAL_SYNC10 = "cal_sync10";
				}

				/// <java-name>
				/// android/provider/CalendarContract$CalendarSyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/CalendarContract$CalendarSyncColumns", AccessFlags = 1548)]
				protected internal partial interface ICalendarSyncColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <java-name>
		/// android/provider/ContactsContract
		/// </java-name>
		[Dot42.DexImport("android/provider/ContactsContract", AccessFlags = 49)]
		public sealed partial class ContactsContract
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "com.android.contacts";
				/// <java-name>
				/// AUTHORITY_URI
				/// </java-name>
				[Dot42.DexImport("AUTHORITY_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri AUTHORITY_URI;
				/// <java-name>
				/// CALLER_IS_SYNCADAPTER
				/// </java-name>
				[Dot42.DexImport("CALLER_IS_SYNCADAPTER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CALLER_IS_SYNCADAPTER = "caller_is_syncadapter";
				/// <java-name>
				/// DIRECTORY_PARAM_KEY
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_PARAM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DIRECTORY_PARAM_KEY = "directory";
				/// <java-name>
				/// LIMIT_PARAM_KEY
				/// </java-name>
				[Dot42.DexImport("LIMIT_PARAM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LIMIT_PARAM_KEY = "limit";
				/// <java-name>
				/// PRIMARY_ACCOUNT_NAME
				/// </java-name>
				[Dot42.DexImport("PRIMARY_ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PRIMARY_ACCOUNT_NAME = "name_for_primary_account";
				/// <java-name>
				/// PRIMARY_ACCOUNT_TYPE
				/// </java-name>
				[Dot42.DexImport("PRIMARY_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PRIMARY_ACCOUNT_TYPE = "type_for_primary_account";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContactsContract() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isProfileId
				/// </java-name>
				[Dot42.DexImport("isProfileId", "(J)Z", AccessFlags = 9)]
				public static bool IsProfileId(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// android/provider/ContactsContract$Intents
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Intents", AccessFlags = 25)]
				public sealed partial class Intents
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SEARCH_SUGGESTION_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED";
						/// <java-name>
						/// SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED";
						/// <java-name>
						/// SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED";
						/// <java-name>
						/// ATTACH_IMAGE
						/// </java-name>
						[Dot42.DexImport("ATTACH_IMAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTACH_IMAGE = "com.android.contacts.action.ATTACH_IMAGE";
						/// <java-name>
						/// INVITE_CONTACT
						/// </java-name>
						[Dot42.DexImport("INVITE_CONTACT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INVITE_CONTACT = "com.android.contacts.action.INVITE_CONTACT";
						/// <java-name>
						/// SHOW_OR_CREATE_CONTACT
						/// </java-name>
						[Dot42.DexImport("SHOW_OR_CREATE_CONTACT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_OR_CREATE_CONTACT = "com.android.contacts.action.SHOW_OR_CREATE_CONTACT";
						/// <java-name>
						/// EXTRA_FORCE_CREATE
						/// </java-name>
						[Dot42.DexImport("EXTRA_FORCE_CREATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_FORCE_CREATE = "com.android.contacts.action.FORCE_CREATE";
						/// <java-name>
						/// EXTRA_CREATE_DESCRIPTION
						/// </java-name>
						[Dot42.DexImport("EXTRA_CREATE_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CREATE_DESCRIPTION = "com.android.contacts.action.CREATE_DESCRIPTION";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Intents() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// android/provider/ContactsContract$Intents$Insert
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Intents$Insert", AccessFlags = 25)]
						public sealed partial class Insert
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// ACTION
								/// </java-name>
								[Dot42.DexImport("ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ACTION = "android.intent.action.INSERT";
								/// <java-name>
								/// FULL_MODE
								/// </java-name>
								[Dot42.DexImport("FULL_MODE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FULL_MODE = "full_mode";
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
								/// <java-name>
								/// PHONETIC_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_NAME = "phonetic_name";
								/// <java-name>
								/// COMPANY
								/// </java-name>
								[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPANY = "company";
								/// <java-name>
								/// JOB_TITLE
								/// </java-name>
								[Dot42.DexImport("JOB_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string JOB_TITLE = "job_title";
								/// <java-name>
								/// NOTES
								/// </java-name>
								[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NOTES = "notes";
								/// <java-name>
								/// PHONE
								/// </java-name>
								[Dot42.DexImport("PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE = "phone";
								/// <java-name>
								/// PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_TYPE = "phone_type";
								/// <java-name>
								/// PHONE_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("PHONE_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_ISPRIMARY = "phone_isprimary";
								/// <java-name>
								/// SECONDARY_PHONE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE = "secondary_phone";
								/// <java-name>
								/// SECONDARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE_TYPE = "secondary_phone_type";
								/// <java-name>
								/// TERTIARY_PHONE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE = "tertiary_phone";
								/// <java-name>
								/// TERTIARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE_TYPE = "tertiary_phone_type";
								/// <java-name>
								/// EMAIL
								/// </java-name>
								[Dot42.DexImport("EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL = "email";
								/// <java-name>
								/// EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_TYPE = "email_type";
								/// <java-name>
								/// EMAIL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("EMAIL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_ISPRIMARY = "email_isprimary";
								/// <java-name>
								/// SECONDARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL = "secondary_email";
								/// <java-name>
								/// SECONDARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL_TYPE = "secondary_email_type";
								/// <java-name>
								/// TERTIARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL = "tertiary_email";
								/// <java-name>
								/// TERTIARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL_TYPE = "tertiary_email_type";
								/// <java-name>
								/// POSTAL
								/// </java-name>
								[Dot42.DexImport("POSTAL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL = "postal";
								/// <java-name>
								/// POSTAL_TYPE
								/// </java-name>
								[Dot42.DexImport("POSTAL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_TYPE = "postal_type";
								/// <java-name>
								/// POSTAL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("POSTAL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_ISPRIMARY = "postal_isprimary";
								/// <java-name>
								/// IM_HANDLE
								/// </java-name>
								[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_HANDLE = "im_handle";
								/// <java-name>
								/// IM_PROTOCOL
								/// </java-name>
								[Dot42.DexImport("IM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_PROTOCOL = "im_protocol";
								/// <java-name>
								/// IM_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("IM_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_ISPRIMARY = "im_isprimary";
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "data";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Insert() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$DisplayPhoto
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DisplayPhoto", AccessFlags = 25)]
				public sealed partial class DisplayPhoto
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_MAX_DIMENSIONS_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_MAX_DIMENSIONS_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_MAX_DIMENSIONS_URI;
						/// <java-name>
						/// DISPLAY_MAX_DIM
						/// </java-name>
						[Dot42.DexImport("DISPLAY_MAX_DIM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_MAX_DIM = "display_max_dim";
						/// <java-name>
						/// THUMBNAIL_MAX_DIM
						/// </java-name>
						[Dot42.DexImport("THUMBNAIL_MAX_DIM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string THUMBNAIL_MAX_DIM = "thumbnail_max_dim";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal DisplayPhoto() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$QuickContact
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$QuickContact", AccessFlags = 25)]
				public sealed partial class QuickContact
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MODE_SMALL
						/// </java-name>
						[Dot42.DexImport("MODE_SMALL", "I", AccessFlags = 25)]
						public const int MODE_SMALL = 1;
						/// <java-name>
						/// MODE_MEDIUM
						/// </java-name>
						[Dot42.DexImport("MODE_MEDIUM", "I", AccessFlags = 25)]
						public const int MODE_MEDIUM = 2;
						/// <java-name>
						/// MODE_LARGE
						/// </java-name>
						[Dot42.DexImport("MODE_LARGE", "I", AccessFlags = 25)]
						public const int MODE_LARGE = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public QuickContact() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// showQuickContact
						/// </java-name>
						[Dot42.DexImport("showQuickContact", "(Landroid/content/Context;Landroid/view/View;Landroid/net/Uri;I[Ljava/lang/String" +
    ";)V", AccessFlags = 9)]
						public static void ShowQuickContact(global::Android.Content.Context context, global::Android.View.View view, global::Android.Net.Uri uri, int int32, string[] @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// showQuickContact
						/// </java-name>
						[Dot42.DexImport("showQuickContact", "(Landroid/content/Context;Landroid/graphics/Rect;Landroid/net/Uri;I[Ljava/lang/St" +
    "ring;)V", AccessFlags = 9)]
						public static void ShowQuickContact(global::Android.Content.Context context, global::Android.Graphics.Rect rect, global::Android.Net.Uri uri, int int32, string[] @string) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$DataUsageFeedback
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DataUsageFeedback", AccessFlags = 25)]
				public sealed partial class DataUsageFeedback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FEEDBACK_URI
						/// </java-name>
						[Dot42.DexImport("FEEDBACK_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri FEEDBACK_URI;
						/// <java-name>
						/// USAGE_TYPE
						/// </java-name>
						[Dot42.DexImport("USAGE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USAGE_TYPE = "type";
						/// <java-name>
						/// USAGE_TYPE_CALL
						/// </java-name>
						[Dot42.DexImport("USAGE_TYPE_CALL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USAGE_TYPE_CALL = "call";
						/// <java-name>
						/// USAGE_TYPE_LONG_TEXT
						/// </java-name>
						[Dot42.DexImport("USAGE_TYPE_LONG_TEXT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USAGE_TYPE_LONG_TEXT = "long_text";
						/// <java-name>
						/// USAGE_TYPE_SHORT_TEXT
						/// </java-name>
						[Dot42.DexImport("USAGE_TYPE_SHORT_TEXT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USAGE_TYPE_SHORT_TEXT = "short_text";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public DataUsageFeedback() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$Settings
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Settings", AccessFlags = 25)]
				public sealed partial class Settings : global::Android.Provider.ContactsContract.ISettingsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/setting";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/setting";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Settings() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SettingsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISettingsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <java-name>
						/// DATA_SET
						/// </java-name>
						[Dot42.DexImport("DATA_SET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_SET = "data_set";
						/// <java-name>
						/// SHOULD_SYNC
						/// </java-name>
						[Dot42.DexImport("SHOULD_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOULD_SYNC = "should_sync";
						/// <java-name>
						/// UNGROUPED_VISIBLE
						/// </java-name>
						[Dot42.DexImport("UNGROUPED_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNGROUPED_VISIBLE = "ungrouped_visible";
						/// <java-name>
						/// ANY_UNSYNCED
						/// </java-name>
						[Dot42.DexImport("ANY_UNSYNCED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANY_UNSYNCED = "any_unsynced";
						/// <java-name>
						/// UNGROUPED_COUNT
						/// </java-name>
						[Dot42.DexImport("UNGROUPED_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNGROUPED_COUNT = "summ_count";
						/// <java-name>
						/// UNGROUPED_WITH_PHONES
						/// </java-name>
						[Dot42.DexImport("UNGROUPED_WITH_PHONES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNGROUPED_WITH_PHONES = "summ_phones";
				}

				/// <java-name>
				/// android/provider/ContactsContract$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SettingsColumns", AccessFlags = 1548)]
				protected internal partial interface ISettingsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$AggregationExceptions
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$AggregationExceptions", AccessFlags = 25)]
				public sealed partial class AggregationExceptions : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/aggregation_exception";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/aggregation_exception";
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <java-name>
						/// TYPE_AUTOMATIC
						/// </java-name>
						[Dot42.DexImport("TYPE_AUTOMATIC", "I", AccessFlags = 25)]
						public const int TYPE_AUTOMATIC = 0;
						/// <java-name>
						/// TYPE_KEEP_TOGETHER
						/// </java-name>
						[Dot42.DexImport("TYPE_KEEP_TOGETHER", "I", AccessFlags = 25)]
						public const int TYPE_KEEP_TOGETHER = 1;
						/// <java-name>
						/// TYPE_KEEP_SEPARATE
						/// </java-name>
						[Dot42.DexImport("TYPE_KEEP_SEPARATE", "I", AccessFlags = 25)]
						public const int TYPE_KEEP_SEPARATE = 2;
						/// <java-name>
						/// RAW_CONTACT_ID1
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_ID1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_ID1 = "raw_contact_id1";
						/// <java-name>
						/// RAW_CONTACT_ID2
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_ID2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_ID2 = "raw_contact_id2";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal AggregationExceptions() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$Groups
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Groups", AccessFlags = 25)]
				public sealed partial class Groups : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IGroupsColumns, global::Android.Provider.ContactsContract.ISyncColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_SUMMARY_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_SUMMARY_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_SUMMARY_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/group";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/group";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Groups() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newEntityIterator
						/// </java-name>
						[Dot42.DexImport("newEntityIterator", "(Landroid/database/Cursor;)Landroid/content/EntityIterator;", AccessFlags = 9)]
						public static global::Android.Content.IEntityIterator NewEntityIterator(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.IEntityIterator);
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$GroupsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IGroupsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DATA_SET
						/// </java-name>
						[Dot42.DexImport("DATA_SET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_SET = "data_set";
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <java-name>
						/// NOTES
						/// </java-name>
						[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTES = "notes";
						/// <java-name>
						/// SYSTEM_ID
						/// </java-name>
						[Dot42.DexImport("SYSTEM_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYSTEM_ID = "system_id";
						/// <java-name>
						/// SUMMARY_COUNT
						/// </java-name>
						[Dot42.DexImport("SUMMARY_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SUMMARY_COUNT = "summ_count";
						/// <java-name>
						/// SUMMARY_WITH_PHONES
						/// </java-name>
						[Dot42.DexImport("SUMMARY_WITH_PHONES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SUMMARY_WITH_PHONES = "summ_phones";
						/// <java-name>
						/// GROUP_VISIBLE
						/// </java-name>
						[Dot42.DexImport("GROUP_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_VISIBLE = "group_visible";
						/// <java-name>
						/// DELETED
						/// </java-name>
						[Dot42.DexImport("DELETED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETED = "deleted";
						/// <java-name>
						/// SHOULD_SYNC
						/// </java-name>
						[Dot42.DexImport("SHOULD_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOULD_SYNC = "should_sync";
						/// <java-name>
						/// AUTO_ADD
						/// </java-name>
						[Dot42.DexImport("AUTO_ADD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTO_ADD = "auto_add";
						/// <java-name>
						/// FAVORITES
						/// </java-name>
						[Dot42.DexImport("FAVORITES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FAVORITES = "favorites";
						/// <java-name>
						/// GROUP_IS_READ_ONLY
						/// </java-name>
						[Dot42.DexImport("GROUP_IS_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_IS_READ_ONLY = "group_is_read_only";
				}

				/// <java-name>
				/// android/provider/ContactsContract$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$GroupsColumns", AccessFlags = 1548)]
				protected internal partial interface IGroupsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$CommonDataKinds
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds", AccessFlags = 25)]
				public sealed partial class CommonDataKinds
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CommonDataKinds() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Identity
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Identity", AccessFlags = 25)]
						public sealed partial class Identity : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/identity";
								/// <java-name>
								/// IDENTITY
								/// </java-name>
								[Dot42.DexImport("IDENTITY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IDENTITY = "data1";
								/// <java-name>
								/// NAMESPACE
								/// </java-name>
								[Dot42.DexImport("NAMESPACE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAMESPACE = "data2";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Identity() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$SipAddress
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$SipAddress", AccessFlags = 25)]
						public sealed partial class SipAddress : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/sip_address";
								/// <java-name>
								/// TYPE_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
								public const int TYPE_HOME = 1;
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 2;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 3;
								/// <java-name>
								/// SIP_ADDRESS
								/// </java-name>
								[Dot42.DexImport("SIP_ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SIP_ADDRESS = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal SipAddress() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Website
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Website", AccessFlags = 25)]
						public sealed partial class Website : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/website";
								/// <java-name>
								/// TYPE_HOMEPAGE
								/// </java-name>
								[Dot42.DexImport("TYPE_HOMEPAGE", "I", AccessFlags = 25)]
								public const int TYPE_HOMEPAGE = 1;
								/// <java-name>
								/// TYPE_BLOG
								/// </java-name>
								[Dot42.DexImport("TYPE_BLOG", "I", AccessFlags = 25)]
								public const int TYPE_BLOG = 2;
								/// <java-name>
								/// TYPE_PROFILE
								/// </java-name>
								[Dot42.DexImport("TYPE_PROFILE", "I", AccessFlags = 25)]
								public const int TYPE_PROFILE = 3;
								/// <java-name>
								/// TYPE_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
								public const int TYPE_HOME = 4;
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 5;
								/// <java-name>
								/// TYPE_FTP
								/// </java-name>
								[Dot42.DexImport("TYPE_FTP", "I", AccessFlags = 25)]
								public const int TYPE_FTP = 6;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 7;
								/// <java-name>
								/// URL
								/// </java-name>
								[Dot42.DexImport("URL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string URL = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Website() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$GroupMembership
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$GroupMembership", AccessFlags = 25)]
						public sealed partial class GroupMembership : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/group_membership";
								/// <java-name>
								/// GROUP_ROW_ID
								/// </java-name>
								[Dot42.DexImport("GROUP_ROW_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GROUP_ROW_ID = "data1";
								/// <java-name>
								/// GROUP_SOURCE_ID
								/// </java-name>
								[Dot42.DexImport("GROUP_SOURCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GROUP_SOURCE_ID = "group_sourceid";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal GroupMembership() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Note
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Note", AccessFlags = 25)]
						public sealed partial class Note : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/note";
								/// <java-name>
								/// NOTE
								/// </java-name>
								[Dot42.DexImport("NOTE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NOTE = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Note() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Photo
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Photo", AccessFlags = 25)]
						public sealed partial class Photo : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/photo";
								/// <java-name>
								/// PHOTO_FILE_ID
								/// </java-name>
								[Dot42.DexImport("PHOTO_FILE_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHOTO_FILE_ID = "data14";
								/// <java-name>
								/// PHOTO
								/// </java-name>
								[Dot42.DexImport("PHOTO", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHOTO = "data15";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Photo() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Event
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Event", AccessFlags = 25)]
						public sealed partial class Event : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact_event";
								/// <java-name>
								/// TYPE_ANNIVERSARY
								/// </java-name>
								[Dot42.DexImport("TYPE_ANNIVERSARY", "I", AccessFlags = 25)]
								public const int TYPE_ANNIVERSARY = 1;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 2;
								/// <java-name>
								/// TYPE_BIRTHDAY
								/// </java-name>
								[Dot42.DexImport("TYPE_BIRTHDAY", "I", AccessFlags = 25)]
								public const int TYPE_BIRTHDAY = 3;
								/// <java-name>
								/// START_DATE
								/// </java-name>
								[Dot42.DexImport("START_DATE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string START_DATE = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Event() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeResource
								/// </java-name>
								[Dot42.DexImport("getTypeResource", "(Ljava/lang/Integer;)I", AccessFlags = 9)]
								public static int GetTypeResource(int? int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Relation
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Relation", AccessFlags = 25)]
						public sealed partial class Relation : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/relation";
								/// <java-name>
								/// TYPE_ASSISTANT
								/// </java-name>
								[Dot42.DexImport("TYPE_ASSISTANT", "I", AccessFlags = 25)]
								public const int TYPE_ASSISTANT = 1;
								/// <java-name>
								/// TYPE_BROTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_BROTHER", "I", AccessFlags = 25)]
								public const int TYPE_BROTHER = 2;
								/// <java-name>
								/// TYPE_CHILD
								/// </java-name>
								[Dot42.DexImport("TYPE_CHILD", "I", AccessFlags = 25)]
								public const int TYPE_CHILD = 3;
								/// <java-name>
								/// TYPE_DOMESTIC_PARTNER
								/// </java-name>
								[Dot42.DexImport("TYPE_DOMESTIC_PARTNER", "I", AccessFlags = 25)]
								public const int TYPE_DOMESTIC_PARTNER = 4;
								/// <java-name>
								/// TYPE_FATHER
								/// </java-name>
								[Dot42.DexImport("TYPE_FATHER", "I", AccessFlags = 25)]
								public const int TYPE_FATHER = 5;
								/// <java-name>
								/// TYPE_FRIEND
								/// </java-name>
								[Dot42.DexImport("TYPE_FRIEND", "I", AccessFlags = 25)]
								public const int TYPE_FRIEND = 6;
								/// <java-name>
								/// TYPE_MANAGER
								/// </java-name>
								[Dot42.DexImport("TYPE_MANAGER", "I", AccessFlags = 25)]
								public const int TYPE_MANAGER = 7;
								/// <java-name>
								/// TYPE_MOTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_MOTHER", "I", AccessFlags = 25)]
								public const int TYPE_MOTHER = 8;
								/// <java-name>
								/// TYPE_PARENT
								/// </java-name>
								[Dot42.DexImport("TYPE_PARENT", "I", AccessFlags = 25)]
								public const int TYPE_PARENT = 9;
								/// <java-name>
								/// TYPE_PARTNER
								/// </java-name>
								[Dot42.DexImport("TYPE_PARTNER", "I", AccessFlags = 25)]
								public const int TYPE_PARTNER = 10;
								/// <java-name>
								/// TYPE_REFERRED_BY
								/// </java-name>
								[Dot42.DexImport("TYPE_REFERRED_BY", "I", AccessFlags = 25)]
								public const int TYPE_REFERRED_BY = 11;
								/// <java-name>
								/// TYPE_RELATIVE
								/// </java-name>
								[Dot42.DexImport("TYPE_RELATIVE", "I", AccessFlags = 25)]
								public const int TYPE_RELATIVE = 12;
								/// <java-name>
								/// TYPE_SISTER
								/// </java-name>
								[Dot42.DexImport("TYPE_SISTER", "I", AccessFlags = 25)]
								public const int TYPE_SISTER = 13;
								/// <java-name>
								/// TYPE_SPOUSE
								/// </java-name>
								[Dot42.DexImport("TYPE_SPOUSE", "I", AccessFlags = 25)]
								public const int TYPE_SPOUSE = 14;
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Relation() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Organization
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Organization", AccessFlags = 25)]
						public sealed partial class Organization : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/organization";
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 1;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 2;
								/// <java-name>
								/// COMPANY
								/// </java-name>
								[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPANY = "data1";
								/// <java-name>
								/// TITLE
								/// </java-name>
								[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE = "data4";
								/// <java-name>
								/// DEPARTMENT
								/// </java-name>
								[Dot42.DexImport("DEPARTMENT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEPARTMENT = "data5";
								/// <java-name>
								/// JOB_DESCRIPTION
								/// </java-name>
								[Dot42.DexImport("JOB_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string JOB_DESCRIPTION = "data6";
								/// <java-name>
								/// SYMBOL
								/// </java-name>
								[Dot42.DexImport("SYMBOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SYMBOL = "data7";
								/// <java-name>
								/// PHONETIC_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_NAME = "data8";
								/// <java-name>
								/// OFFICE_LOCATION
								/// </java-name>
								[Dot42.DexImport("OFFICE_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string OFFICE_LOCATION = "data9";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Organization() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Im
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Im", AccessFlags = 25)]
						public sealed partial class Im : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/im";
								/// <java-name>
								/// TYPE_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
								public const int TYPE_HOME = 1;
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 2;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 3;
								/// <java-name>
								/// PROTOCOL
								/// </java-name>
								[Dot42.DexImport("PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PROTOCOL = "data5";
								/// <java-name>
								/// CUSTOM_PROTOCOL
								/// </java-name>
								[Dot42.DexImport("CUSTOM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CUSTOM_PROTOCOL = "data6";
								/// <java-name>
								/// PROTOCOL_CUSTOM
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_CUSTOM", "I", AccessFlags = 25)]
								public const int PROTOCOL_CUSTOM = -1;
								/// <java-name>
								/// PROTOCOL_AIM
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_AIM", "I", AccessFlags = 25)]
								public const int PROTOCOL_AIM = 0;
								/// <java-name>
								/// PROTOCOL_MSN
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_MSN", "I", AccessFlags = 25)]
								public const int PROTOCOL_MSN = 1;
								/// <java-name>
								/// PROTOCOL_YAHOO
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_YAHOO", "I", AccessFlags = 25)]
								public const int PROTOCOL_YAHOO = 2;
								/// <java-name>
								/// PROTOCOL_SKYPE
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_SKYPE", "I", AccessFlags = 25)]
								public const int PROTOCOL_SKYPE = 3;
								/// <java-name>
								/// PROTOCOL_QQ
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_QQ", "I", AccessFlags = 25)]
								public const int PROTOCOL_QQ = 4;
								/// <java-name>
								/// PROTOCOL_GOOGLE_TALK
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_GOOGLE_TALK", "I", AccessFlags = 25)]
								public const int PROTOCOL_GOOGLE_TALK = 5;
								/// <java-name>
								/// PROTOCOL_ICQ
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_ICQ", "I", AccessFlags = 25)]
								public const int PROTOCOL_ICQ = 6;
								/// <java-name>
								/// PROTOCOL_JABBER
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_JABBER", "I", AccessFlags = 25)]
								public const int PROTOCOL_JABBER = 7;
								/// <java-name>
								/// PROTOCOL_NETMEETING
								/// </java-name>
								[Dot42.DexImport("PROTOCOL_NETMEETING", "I", AccessFlags = 25)]
								public const int PROTOCOL_NETMEETING = 8;
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Im() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

								/// <java-name>
								/// getProtocolLabelResource
								/// </java-name>
								[Dot42.DexImport("getProtocolLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetProtocolLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getProtocolLabel
								/// </java-name>
								[Dot42.DexImport("getProtocolLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetProtocolLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$StructuredPostal
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$StructuredPostal", AccessFlags = 25)]
						public sealed partial class StructuredPostal : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/postal-address_v2";
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/postal-address_v2";
								/// <java-name>
								/// CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_URI;
								/// <java-name>
								/// TYPE_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
								public const int TYPE_HOME = 1;
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 2;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 3;
								/// <java-name>
								/// FORMATTED_ADDRESS
								/// </java-name>
								[Dot42.DexImport("FORMATTED_ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FORMATTED_ADDRESS = "data1";
								/// <java-name>
								/// STREET
								/// </java-name>
								[Dot42.DexImport("STREET", "Ljava/lang/String;", AccessFlags = 25)]
								public const string STREET = "data4";
								/// <java-name>
								/// POBOX
								/// </java-name>
								[Dot42.DexImport("POBOX", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POBOX = "data5";
								/// <java-name>
								/// NEIGHBORHOOD
								/// </java-name>
								[Dot42.DexImport("NEIGHBORHOOD", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NEIGHBORHOOD = "data6";
								/// <java-name>
								/// CITY
								/// </java-name>
								[Dot42.DexImport("CITY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CITY = "data7";
								/// <java-name>
								/// REGION
								/// </java-name>
								[Dot42.DexImport("REGION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string REGION = "data8";
								/// <java-name>
								/// POSTCODE
								/// </java-name>
								[Dot42.DexImport("POSTCODE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTCODE = "data9";
								/// <java-name>
								/// COUNTRY
								/// </java-name>
								[Dot42.DexImport("COUNTRY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COUNTRY = "data10";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal StructuredPostal() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Email
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Email", AccessFlags = 25)]
						public sealed partial class Email : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/email_v2";
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/email_v2";
								/// <java-name>
								/// CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_URI;
								/// <java-name>
								/// CONTENT_LOOKUP_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_LOOKUP_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_LOOKUP_URI;
								/// <java-name>
								/// CONTENT_FILTER_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
								/// <java-name>
								/// ADDRESS
								/// </java-name>
								[Dot42.DexImport("ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ADDRESS = "data1";
								/// <java-name>
								/// TYPE_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
								public const int TYPE_HOME = 1;
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 2;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 3;
								/// <java-name>
								/// TYPE_MOBILE
								/// </java-name>
								[Dot42.DexImport("TYPE_MOBILE", "I", AccessFlags = 25)]
								public const int TYPE_MOBILE = 4;
								/// <java-name>
								/// DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DISPLAY_NAME = "data4";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Email() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Phone
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Phone", AccessFlags = 25)]
						public sealed partial class Phone : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/phone_v2";
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/phone_v2";
								/// <java-name>
								/// CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_URI;
								/// <java-name>
								/// CONTENT_FILTER_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
								/// <java-name>
								/// TYPE_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
								public const int TYPE_HOME = 1;
								/// <java-name>
								/// TYPE_MOBILE
								/// </java-name>
								[Dot42.DexImport("TYPE_MOBILE", "I", AccessFlags = 25)]
								public const int TYPE_MOBILE = 2;
								/// <java-name>
								/// TYPE_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
								public const int TYPE_WORK = 3;
								/// <java-name>
								/// TYPE_FAX_WORK
								/// </java-name>
								[Dot42.DexImport("TYPE_FAX_WORK", "I", AccessFlags = 25)]
								public const int TYPE_FAX_WORK = 4;
								/// <java-name>
								/// TYPE_FAX_HOME
								/// </java-name>
								[Dot42.DexImport("TYPE_FAX_HOME", "I", AccessFlags = 25)]
								public const int TYPE_FAX_HOME = 5;
								/// <java-name>
								/// TYPE_PAGER
								/// </java-name>
								[Dot42.DexImport("TYPE_PAGER", "I", AccessFlags = 25)]
								public const int TYPE_PAGER = 6;
								/// <java-name>
								/// TYPE_OTHER
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
								public const int TYPE_OTHER = 7;
								/// <java-name>
								/// TYPE_CALLBACK
								/// </java-name>
								[Dot42.DexImport("TYPE_CALLBACK", "I", AccessFlags = 25)]
								public const int TYPE_CALLBACK = 8;
								/// <java-name>
								/// TYPE_CAR
								/// </java-name>
								[Dot42.DexImport("TYPE_CAR", "I", AccessFlags = 25)]
								public const int TYPE_CAR = 9;
								/// <java-name>
								/// TYPE_COMPANY_MAIN
								/// </java-name>
								[Dot42.DexImport("TYPE_COMPANY_MAIN", "I", AccessFlags = 25)]
								public const int TYPE_COMPANY_MAIN = 10;
								/// <java-name>
								/// TYPE_ISDN
								/// </java-name>
								[Dot42.DexImport("TYPE_ISDN", "I", AccessFlags = 25)]
								public const int TYPE_ISDN = 11;
								/// <java-name>
								/// TYPE_MAIN
								/// </java-name>
								[Dot42.DexImport("TYPE_MAIN", "I", AccessFlags = 25)]
								public const int TYPE_MAIN = 12;
								/// <java-name>
								/// TYPE_OTHER_FAX
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER_FAX", "I", AccessFlags = 25)]
								public const int TYPE_OTHER_FAX = 13;
								/// <java-name>
								/// TYPE_RADIO
								/// </java-name>
								[Dot42.DexImport("TYPE_RADIO", "I", AccessFlags = 25)]
								public const int TYPE_RADIO = 14;
								/// <java-name>
								/// TYPE_TELEX
								/// </java-name>
								[Dot42.DexImport("TYPE_TELEX", "I", AccessFlags = 25)]
								public const int TYPE_TELEX = 15;
								/// <java-name>
								/// TYPE_TTY_TDD
								/// </java-name>
								[Dot42.DexImport("TYPE_TTY_TDD", "I", AccessFlags = 25)]
								public const int TYPE_TTY_TDD = 16;
								/// <java-name>
								/// TYPE_WORK_MOBILE
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK_MOBILE", "I", AccessFlags = 25)]
								public const int TYPE_WORK_MOBILE = 17;
								/// <java-name>
								/// TYPE_WORK_PAGER
								/// </java-name>
								[Dot42.DexImport("TYPE_WORK_PAGER", "I", AccessFlags = 25)]
								public const int TYPE_WORK_PAGER = 18;
								/// <java-name>
								/// TYPE_ASSISTANT
								/// </java-name>
								[Dot42.DexImport("TYPE_ASSISTANT", "I", AccessFlags = 25)]
								public const int TYPE_ASSISTANT = 19;
								/// <java-name>
								/// TYPE_MMS
								/// </java-name>
								[Dot42.DexImport("TYPE_MMS", "I", AccessFlags = 25)]
								public const int TYPE_MMS = 20;
								/// <java-name>
								/// NUMBER
								/// </java-name>
								[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Phone() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int int32) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources resources, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Nickname
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Nickname", AccessFlags = 25)]
						public sealed partial class Nickname : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/nickname";
								/// <java-name>
								/// TYPE_DEFAULT
								/// </java-name>
								[Dot42.DexImport("TYPE_DEFAULT", "I", AccessFlags = 25)]
								public const int TYPE_DEFAULT = 1;
								/// <java-name>
								/// TYPE_OTHER_NAME
								/// </java-name>
								[Dot42.DexImport("TYPE_OTHER_NAME", "I", AccessFlags = 25)]
								public const int TYPE_OTHER_NAME = 2;
								/// <java-name>
								/// TYPE_MAIDEN_NAME
								/// </java-name>
								[Dot42.DexImport("TYPE_MAIDEN_NAME", "I", AccessFlags = 25)]
								public const int TYPE_MAIDEN_NAME = 3;
								/// <java-name>
								/// TYPE_MAINDEN_NAME
								/// </java-name>
								[Dot42.DexImport("TYPE_MAINDEN_NAME", "I", AccessFlags = 25)]
								public const int TYPE_MAINDEN_NAME = 3;
								/// <java-name>
								/// TYPE_SHORT_NAME
								/// </java-name>
								[Dot42.DexImport("TYPE_SHORT_NAME", "I", AccessFlags = 25)]
								public const int TYPE_SHORT_NAME = 4;
								/// <java-name>
								/// TYPE_INITIALS
								/// </java-name>
								[Dot42.DexImport("TYPE_INITIALS", "I", AccessFlags = 25)]
								public const int TYPE_INITIALS = 5;
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Nickname() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$StructuredName
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$StructuredName", AccessFlags = 25)]
						public sealed partial class StructuredName : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/name";
								/// <java-name>
								/// DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DISPLAY_NAME = "data1";
								/// <java-name>
								/// GIVEN_NAME
								/// </java-name>
								[Dot42.DexImport("GIVEN_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GIVEN_NAME = "data2";
								/// <java-name>
								/// FAMILY_NAME
								/// </java-name>
								[Dot42.DexImport("FAMILY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FAMILY_NAME = "data3";
								/// <java-name>
								/// PREFIX
								/// </java-name>
								[Dot42.DexImport("PREFIX", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PREFIX = "data4";
								/// <java-name>
								/// MIDDLE_NAME
								/// </java-name>
								[Dot42.DexImport("MIDDLE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MIDDLE_NAME = "data5";
								/// <java-name>
								/// SUFFIX
								/// </java-name>
								[Dot42.DexImport("SUFFIX", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SUFFIX = "data6";
								/// <java-name>
								/// PHONETIC_GIVEN_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_GIVEN_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_GIVEN_NAME = "data7";
								/// <java-name>
								/// PHONETIC_MIDDLE_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_MIDDLE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_MIDDLE_NAME = "data8";
								/// <java-name>
								/// PHONETIC_FAMILY_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_FAMILY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_FAMILY_NAME = "data9";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal StructuredName() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$CommonColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$CommonColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
						public static partial class ICommonColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "data1";
								/// <java-name>
								/// TYPE
								/// </java-name>
								[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TYPE = "data2";
								/// <java-name>
								/// LABEL
								/// </java-name>
								[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LABEL = "data3";
						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$CommonColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$CommonColumns", AccessFlags = 1548)]
						protected internal partial interface ICommonColumns : global::Android.Provider.ContactsContract.CommonDataKinds.IBaseTypes
 /* scope: __dot42__ */ 
						{
						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$BaseTypes
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$BaseTypes", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IBaseTypesConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// TYPE_CUSTOM
								/// </java-name>
								[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
								public const int TYPE_CUSTOM = 0;
						}

						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$BaseTypes
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$BaseTypes", AccessFlags = 1545)]
						public partial interface IBaseTypes
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$Presence
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Presence", AccessFlags = 25)]
				public sealed partial class Presence : global::Android.Provider.ContactsContract.StatusUpdates
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Presence() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$StatusUpdates
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StatusUpdates", AccessFlags = 9)]
				public partial class StatusUpdates : global::Android.Provider.ContactsContract.IStatusColumns, global::Android.Provider.ContactsContract.IPresenceColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// PROFILE_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("PROFILE_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri PROFILE_CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/status-update";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/status-update";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal StatusUpdates() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getPresenceIconResourceId
						/// </java-name>
						[Dot42.DexImport("getPresenceIconResourceId", "(I)I", AccessFlags = 25)]
						public static int GetPresenceIconResourceId(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getPresencePrecedence
						/// </java-name>
						[Dot42.DexImport("getPresencePrecedence", "(I)I", AccessFlags = 25)]
						public static int GetPresencePrecedence(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PresenceColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPresenceColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DATA_ID
						/// </java-name>
						[Dot42.DexImport("DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ID = "presence_data_id";
						/// <java-name>
						/// PROTOCOL
						/// </java-name>
						[Dot42.DexImport("PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROTOCOL = "protocol";
						/// <java-name>
						/// CUSTOM_PROTOCOL
						/// </java-name>
						[Dot42.DexImport("CUSTOM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CUSTOM_PROTOCOL = "custom_protocol";
						/// <java-name>
						/// IM_HANDLE
						/// </java-name>
						[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_HANDLE = "im_handle";
						/// <java-name>
						/// IM_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("IM_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_ACCOUNT = "im_account";
				}

				/// <java-name>
				/// android/provider/ContactsContract$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PresenceColumns", AccessFlags = 1548)]
				protected internal partial interface IPresenceColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$PhoneLookup
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneLookup", AccessFlags = 25)]
				public sealed partial class PhoneLookup : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IPhoneLookupColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal PhoneLookup() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$PhoneLookupColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneLookupColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhoneLookupColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
				}

				/// <java-name>
				/// android/provider/ContactsContract$PhoneLookupColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneLookupColumns", AccessFlags = 1548)]
				protected internal partial interface IPhoneLookupColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$RawContactsEntity
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContactsEntity", AccessFlags = 25)]
				public sealed partial class RawContactsEntity : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns, global::Android.Provider.ContactsContract.IRawContactsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// PROFILE_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("PROFILE_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri PROFILE_CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/raw_contact_entity";
						/// <java-name>
						/// DATA_ID
						/// </java-name>
						[Dot42.DexImport("DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ID = "data_id";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal RawContactsEntity() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$Data
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Data", AccessFlags = 25)]
				public sealed partial class Data : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/data";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Data() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getContactLookupUri
						/// </java-name>
						[Dot42.DexImport("getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetContactLookupUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$DataColumnsWithJoins
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DataColumnsWithJoins", AccessFlags = 1548)]
				protected internal partial interface IDataColumnsWithJoins : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns, global::Android.Provider.ContactsContract.IStatusColumns, global::Android.Provider.ContactsContract.IRawContactsColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$DataColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DataColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IDataColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MIMETYPE
						/// </java-name>
						[Dot42.DexImport("MIMETYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MIMETYPE = "mimetype";
						/// <java-name>
						/// RAW_CONTACT_ID
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_ID = "raw_contact_id";
						/// <java-name>
						/// IS_PRIMARY
						/// </java-name>
						[Dot42.DexImport("IS_PRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IS_PRIMARY = "is_primary";
						/// <java-name>
						/// IS_SUPER_PRIMARY
						/// </java-name>
						[Dot42.DexImport("IS_SUPER_PRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IS_SUPER_PRIMARY = "is_super_primary";
						/// <java-name>
						/// IS_READ_ONLY
						/// </java-name>
						[Dot42.DexImport("IS_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IS_READ_ONLY = "is_read_only";
						/// <java-name>
						/// DATA_VERSION
						/// </java-name>
						[Dot42.DexImport("DATA_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_VERSION = "data_version";
						/// <java-name>
						/// DATA1
						/// </java-name>
						[Dot42.DexImport("DATA1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA1 = "data1";
						/// <java-name>
						/// DATA2
						/// </java-name>
						[Dot42.DexImport("DATA2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA2 = "data2";
						/// <java-name>
						/// DATA3
						/// </java-name>
						[Dot42.DexImport("DATA3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA3 = "data3";
						/// <java-name>
						/// DATA4
						/// </java-name>
						[Dot42.DexImport("DATA4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA4 = "data4";
						/// <java-name>
						/// DATA5
						/// </java-name>
						[Dot42.DexImport("DATA5", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA5 = "data5";
						/// <java-name>
						/// DATA6
						/// </java-name>
						[Dot42.DexImport("DATA6", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA6 = "data6";
						/// <java-name>
						/// DATA7
						/// </java-name>
						[Dot42.DexImport("DATA7", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA7 = "data7";
						/// <java-name>
						/// DATA8
						/// </java-name>
						[Dot42.DexImport("DATA8", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA8 = "data8";
						/// <java-name>
						/// DATA9
						/// </java-name>
						[Dot42.DexImport("DATA9", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA9 = "data9";
						/// <java-name>
						/// DATA10
						/// </java-name>
						[Dot42.DexImport("DATA10", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA10 = "data10";
						/// <java-name>
						/// DATA11
						/// </java-name>
						[Dot42.DexImport("DATA11", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA11 = "data11";
						/// <java-name>
						/// DATA12
						/// </java-name>
						[Dot42.DexImport("DATA12", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA12 = "data12";
						/// <java-name>
						/// DATA13
						/// </java-name>
						[Dot42.DexImport("DATA13", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA13 = "data13";
						/// <java-name>
						/// DATA14
						/// </java-name>
						[Dot42.DexImport("DATA14", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA14 = "data14";
						/// <java-name>
						/// DATA15
						/// </java-name>
						[Dot42.DexImport("DATA15", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA15 = "data15";
						/// <java-name>
						/// SYNC1
						/// </java-name>
						[Dot42.DexImport("SYNC1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC1 = "data_sync1";
						/// <java-name>
						/// SYNC2
						/// </java-name>
						[Dot42.DexImport("SYNC2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC2 = "data_sync2";
						/// <java-name>
						/// SYNC3
						/// </java-name>
						[Dot42.DexImport("SYNC3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC3 = "data_sync3";
						/// <java-name>
						/// SYNC4
						/// </java-name>
						[Dot42.DexImport("SYNC4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC4 = "data_sync4";
				}

				/// <java-name>
				/// android/provider/ContactsContract$DataColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DataColumns", AccessFlags = 1548)]
				protected internal partial interface IDataColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$StreamItemPhotosColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StreamItemPhotosColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IStreamItemPhotosColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// STREAM_ITEM_ID
						/// </java-name>
						[Dot42.DexImport("STREAM_ITEM_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STREAM_ITEM_ID = "stream_item_id";
						/// <java-name>
						/// SORT_INDEX
						/// </java-name>
						[Dot42.DexImport("SORT_INDEX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SORT_INDEX = "sort_index";
						/// <java-name>
						/// PHOTO_FILE_ID
						/// </java-name>
						[Dot42.DexImport("PHOTO_FILE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_FILE_ID = "photo_file_id";
						/// <java-name>
						/// PHOTO_URI
						/// </java-name>
						[Dot42.DexImport("PHOTO_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_URI = "photo_uri";
						/// <java-name>
						/// SYNC1
						/// </java-name>
						[Dot42.DexImport("SYNC1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC1 = "stream_item_photo_sync1";
						/// <java-name>
						/// SYNC2
						/// </java-name>
						[Dot42.DexImport("SYNC2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC2 = "stream_item_photo_sync2";
						/// <java-name>
						/// SYNC3
						/// </java-name>
						[Dot42.DexImport("SYNC3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC3 = "stream_item_photo_sync3";
						/// <java-name>
						/// SYNC4
						/// </java-name>
						[Dot42.DexImport("SYNC4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC4 = "stream_item_photo_sync4";
				}

				/// <java-name>
				/// android/provider/ContactsContract$StreamItemPhotosColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StreamItemPhotosColumns", AccessFlags = 1548)]
				protected internal partial interface IStreamItemPhotosColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$StreamItemPhotos
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StreamItemPhotos", AccessFlags = 25)]
				public sealed partial class StreamItemPhotos : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IStreamItemPhotosColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PHOTO
						/// </java-name>
						[Dot42.DexImport("PHOTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO = "photo";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal StreamItemPhotos() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$StreamItemsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StreamItemsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IStreamItemsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTACT_ID
						/// </java-name>
						[Dot42.DexImport("CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_ID = "contact_id";
						/// <java-name>
						/// CONTACT_LOOKUP_KEY
						/// </java-name>
						[Dot42.DexImport("CONTACT_LOOKUP_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_LOOKUP_KEY = "contact_lookup";
						/// <java-name>
						/// RAW_CONTACT_ID
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_ID = "raw_contact_id";
						/// <java-name>
						/// RES_PACKAGE
						/// </java-name>
						[Dot42.DexImport("RES_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RES_PACKAGE = "res_package";
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <java-name>
						/// DATA_SET
						/// </java-name>
						[Dot42.DexImport("DATA_SET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_SET = "data_set";
						/// <java-name>
						/// RAW_CONTACT_SOURCE_ID
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_SOURCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_SOURCE_ID = "raw_contact_source_id";
						/// <java-name>
						/// RES_ICON
						/// </java-name>
						[Dot42.DexImport("RES_ICON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RES_ICON = "icon";
						/// <java-name>
						/// RES_LABEL
						/// </java-name>
						[Dot42.DexImport("RES_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RES_LABEL = "label";
						/// <java-name>
						/// TEXT
						/// </java-name>
						[Dot42.DexImport("TEXT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT = "text";
						/// <java-name>
						/// TIMESTAMP
						/// </java-name>
						[Dot42.DexImport("TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMESTAMP = "timestamp";
						/// <java-name>
						/// COMMENTS
						/// </java-name>
						[Dot42.DexImport("COMMENTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COMMENTS = "comments";
						/// <java-name>
						/// SYNC1
						/// </java-name>
						[Dot42.DexImport("SYNC1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC1 = "stream_item_sync1";
						/// <java-name>
						/// SYNC2
						/// </java-name>
						[Dot42.DexImport("SYNC2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC2 = "stream_item_sync2";
						/// <java-name>
						/// SYNC3
						/// </java-name>
						[Dot42.DexImport("SYNC3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC3 = "stream_item_sync3";
						/// <java-name>
						/// SYNC4
						/// </java-name>
						[Dot42.DexImport("SYNC4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC4 = "stream_item_sync4";
				}

				/// <java-name>
				/// android/provider/ContactsContract$StreamItemsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StreamItemsColumns", AccessFlags = 1548)]
				protected internal partial interface IStreamItemsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$StreamItems
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StreamItems", AccessFlags = 25)]
				public sealed partial class StreamItems : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IStreamItemsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_PHOTO_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_PHOTO_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_PHOTO_URI;
						/// <java-name>
						/// CONTENT_LIMIT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_LIMIT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_LIMIT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/stream_item";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/stream_item";
						/// <java-name>
						/// MAX_ITEMS
						/// </java-name>
						[Dot42.DexImport("MAX_ITEMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MAX_ITEMS = "max_items";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal StreamItems() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// android/provider/ContactsContract$StreamItems$StreamItemPhotos
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$StreamItems$StreamItemPhotos", AccessFlags = 25)]
						public sealed partial class StreamItemPhotos : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IStreamItemPhotosColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "photo";
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/stream_item_photo";
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/stream_item_photo";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal StreamItemPhotos() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$StatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StatusColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IStatusColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PRESENCE
						/// </java-name>
						[Dot42.DexImport("PRESENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE = "mode";
						/// <java-name>
						/// PRESENCE_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_STATUS = "mode";
						/// <java-name>
						/// OFFLINE
						/// </java-name>
						[Dot42.DexImport("OFFLINE", "I", AccessFlags = 25)]
						public const int OFFLINE = 0;
						/// <java-name>
						/// INVISIBLE
						/// </java-name>
						[Dot42.DexImport("INVISIBLE", "I", AccessFlags = 25)]
						public const int INVISIBLE = 1;
						/// <java-name>
						/// AWAY
						/// </java-name>
						[Dot42.DexImport("AWAY", "I", AccessFlags = 25)]
						public const int AWAY = 2;
						/// <java-name>
						/// IDLE
						/// </java-name>
						[Dot42.DexImport("IDLE", "I", AccessFlags = 25)]
						public const int IDLE = 3;
						/// <java-name>
						/// DO_NOT_DISTURB
						/// </java-name>
						[Dot42.DexImport("DO_NOT_DISTURB", "I", AccessFlags = 25)]
						public const int DO_NOT_DISTURB = 4;
						/// <java-name>
						/// AVAILABLE
						/// </java-name>
						[Dot42.DexImport("AVAILABLE", "I", AccessFlags = 25)]
						public const int AVAILABLE = 5;
						/// <java-name>
						/// STATUS
						/// </java-name>
						[Dot42.DexImport("STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS = "status";
						/// <java-name>
						/// PRESENCE_CUSTOM_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_CUSTOM_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_CUSTOM_STATUS = "status";
						/// <java-name>
						/// STATUS_TIMESTAMP
						/// </java-name>
						[Dot42.DexImport("STATUS_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_TIMESTAMP = "status_ts";
						/// <java-name>
						/// STATUS_RES_PACKAGE
						/// </java-name>
						[Dot42.DexImport("STATUS_RES_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_RES_PACKAGE = "status_res_package";
						/// <java-name>
						/// STATUS_LABEL
						/// </java-name>
						[Dot42.DexImport("STATUS_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_LABEL = "status_label";
						/// <java-name>
						/// STATUS_ICON
						/// </java-name>
						[Dot42.DexImport("STATUS_ICON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_ICON = "status_icon";
						/// <java-name>
						/// CHAT_CAPABILITY
						/// </java-name>
						[Dot42.DexImport("CHAT_CAPABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHAT_CAPABILITY = "chat_capability";
						/// <java-name>
						/// CAPABILITY_HAS_VOICE
						/// </java-name>
						[Dot42.DexImport("CAPABILITY_HAS_VOICE", "I", AccessFlags = 25)]
						public const int CAPABILITY_HAS_VOICE = 1;
						/// <java-name>
						/// CAPABILITY_HAS_VIDEO
						/// </java-name>
						[Dot42.DexImport("CAPABILITY_HAS_VIDEO", "I", AccessFlags = 25)]
						public const int CAPABILITY_HAS_VIDEO = 2;
						/// <java-name>
						/// CAPABILITY_HAS_CAMERA
						/// </java-name>
						[Dot42.DexImport("CAPABILITY_HAS_CAMERA", "I", AccessFlags = 25)]
						public const int CAPABILITY_HAS_CAMERA = 4;
				}

				/// <java-name>
				/// android/provider/ContactsContract$StatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StatusColumns", AccessFlags = 1548)]
				protected internal partial interface IStatusColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$RawContacts
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContacts", AccessFlags = 25)]
				public sealed partial class RawContacts : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IRawContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.ISyncColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/raw_contact";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/raw_contact";
						/// <java-name>
						/// AGGREGATION_MODE_DEFAULT
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_DEFAULT", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_DEFAULT = 0;
						/// <java-name>
						/// AGGREGATION_MODE_IMMEDIATE
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_IMMEDIATE", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_IMMEDIATE = 1;
						/// <java-name>
						/// AGGREGATION_MODE_SUSPENDED
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_SUSPENDED", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_SUSPENDED = 2;
						/// <java-name>
						/// AGGREGATION_MODE_DISABLED
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_DISABLED", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_DISABLED = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal RawContacts() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getContactLookupUri
						/// </java-name>
						[Dot42.DexImport("getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetContactLookupUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// newEntityIterator
						/// </java-name>
						[Dot42.DexImport("newEntityIterator", "(Landroid/database/Cursor;)Landroid/content/EntityIterator;", AccessFlags = 9)]
						public static global::Android.Content.IEntityIterator NewEntityIterator(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.IEntityIterator);
						}

						/// <java-name>
						/// android/provider/ContactsContract$RawContacts$DisplayPhoto
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$RawContacts$DisplayPhoto", AccessFlags = 25)]
						public sealed partial class DisplayPhoto
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "display_photo";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal DisplayPhoto() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$RawContacts$StreamItems
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$RawContacts$StreamItems", AccessFlags = 25)]
						public sealed partial class StreamItems : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IStreamItemsColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "stream_items";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal StreamItems() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$RawContacts$Entity
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$RawContacts$Entity", AccessFlags = 25)]
						public sealed partial class Entity : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "entity";
								/// <java-name>
								/// DATA_ID
								/// </java-name>
								[Dot42.DexImport("DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA_ID = "data_id";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Entity() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$RawContacts$Data
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$RawContacts$Data", AccessFlags = 25)]
						public sealed partial class Data : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "data";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Data() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$RawContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContactsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IRawContactsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTACT_ID
						/// </java-name>
						[Dot42.DexImport("CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_ID = "contact_id";
						/// <java-name>
						/// DATA_SET
						/// </java-name>
						[Dot42.DexImport("DATA_SET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_SET = "data_set";
						/// <java-name>
						/// AGGREGATION_MODE
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AGGREGATION_MODE = "aggregation_mode";
						/// <java-name>
						/// DELETED
						/// </java-name>
						[Dot42.DexImport("DELETED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETED = "deleted";
						/// <java-name>
						/// RAW_CONTACT_IS_READ_ONLY
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_IS_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_IS_READ_ONLY = "raw_contact_is_read_only";
						/// <java-name>
						/// RAW_CONTACT_IS_USER_PROFILE
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_IS_USER_PROFILE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_IS_USER_PROFILE = "raw_contact_is_user_profile";
				}

				/// <java-name>
				/// android/provider/ContactsContract$RawContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContactsColumns", AccessFlags = 1548)]
				protected internal partial interface IRawContactsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$Profile
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Profile", AccessFlags = 25)]
				public sealed partial class Profile : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_VCARD_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_VCARD_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_VCARD_URI;
						/// <java-name>
						/// CONTENT_RAW_CONTACTS_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_RAW_CONTACTS_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_RAW_CONTACTS_URI;
						/// <java-name>
						/// MIN_ID
						/// </java-name>
						[Dot42.DexImport("MIN_ID", "J", AccessFlags = 25)]
						public const long MIN_ID = 9223372034707292160;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Profile() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$Contacts
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Contacts", AccessFlags = 9)]
				public partial class Contacts : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_LOOKUP_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_LOOKUP_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_LOOKUP_URI;
						/// <java-name>
						/// CONTENT_VCARD_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_VCARD_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_VCARD_URI;
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						/// <java-name>
						/// CONTENT_STREQUENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_STREQUENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_STREQUENT_URI;
						/// <java-name>
						/// CONTENT_STREQUENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_STREQUENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_STREQUENT_FILTER_URI;
						/// <java-name>
						/// CONTENT_GROUP_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_GROUP_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_GROUP_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact";
						/// <java-name>
						/// CONTENT_VCARD_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_VCARD_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_VCARD_TYPE = "text/x-vcard";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Contacts() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getLookupUri
						/// </java-name>
						[Dot42.DexImport("getLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetLookupUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// getLookupUri
						/// </java-name>
						[Dot42.DexImport("getLookupUri", "(JLjava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetLookupUri(long int64, string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// lookupContact
						/// </java-name>
						[Dot42.DexImport("lookupContact", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri LookupContact(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// markAsContacted
						/// </java-name>
						[Dot42.DexImport("markAsContacted", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
						public static void MarkAsContacted(global::Android.Content.ContentResolver contentResolver, long int64) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// openContactPhotoInputStream
						/// </java-name>
						[Dot42.DexImport("openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;Z)Ljava/io/InputStream;", AccessFlags = 9)]
						public static global::Java.Io.InputStream OpenContactPhotoInputStream(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.InputStream);
						}

						/// <java-name>
						/// openContactPhotoInputStream
						/// </java-name>
						[Dot42.DexImport("openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;", AccessFlags = 9)]
						public static global::Java.Io.InputStream OpenContactPhotoInputStream(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.InputStream);
						}

						/// <java-name>
						/// android/provider/ContactsContract$Contacts$Photo
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$Photo", AccessFlags = 25)]
						public sealed partial class Photo : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "photo";
								/// <java-name>
								/// DISPLAY_PHOTO
								/// </java-name>
								[Dot42.DexImport("DISPLAY_PHOTO", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DISPLAY_PHOTO = "display_photo";
								/// <java-name>
								/// PHOTO_FILE_ID
								/// </java-name>
								[Dot42.DexImport("PHOTO_FILE_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHOTO_FILE_ID = "data14";
								/// <java-name>
								/// PHOTO
								/// </java-name>
								[Dot42.DexImport("PHOTO", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHOTO = "data15";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Photo() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$Contacts$AggregationSuggestions
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$AggregationSuggestions", AccessFlags = 25)]
						public sealed partial class AggregationSuggestions : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "suggestions";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal AggregationSuggestions() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$Contacts$StreamItems
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$StreamItems", AccessFlags = 25)]
						public sealed partial class StreamItems : global::Android.Provider.ContactsContract.IStreamItemsColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "stream_items";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal StreamItems() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$Contacts$Entity
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$Entity", AccessFlags = 25)]
						public sealed partial class Entity : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.IRawContactsColumns, global::Android.Provider.ContactsContract.IBaseSyncColumns, global::Android.Provider.ContactsContract.ISyncColumns, global::Android.Provider.ContactsContract.IDataColumns, global::Android.Provider.ContactsContract.IStatusColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "entities";
								/// <java-name>
								/// RAW_CONTACT_ID
								/// </java-name>
								[Dot42.DexImport("RAW_CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string RAW_CONTACT_ID = "raw_contact_id";
								/// <java-name>
								/// DATA_ID
								/// </java-name>
								[Dot42.DexImport("DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA_ID = "data_id";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Entity() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/ContactsContract$Contacts$Data
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$Data", AccessFlags = 25)]
						public sealed partial class Data : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "data";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Data() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactNameColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactNameColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactNameColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DISPLAY_NAME_SOURCE
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME_SOURCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME_SOURCE = "display_name_source";
						/// <java-name>
						/// DISPLAY_NAME_PRIMARY
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME_PRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME_PRIMARY = "display_name";
						/// <java-name>
						/// DISPLAY_NAME_ALTERNATIVE
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME_ALTERNATIVE = "display_name_alt";
						/// <java-name>
						/// PHONETIC_NAME_STYLE
						/// </java-name>
						[Dot42.DexImport("PHONETIC_NAME_STYLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONETIC_NAME_STYLE = "phonetic_name_style";
						/// <java-name>
						/// PHONETIC_NAME
						/// </java-name>
						[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONETIC_NAME = "phonetic_name";
						/// <java-name>
						/// SORT_KEY_PRIMARY
						/// </java-name>
						[Dot42.DexImport("SORT_KEY_PRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SORT_KEY_PRIMARY = "sort_key";
						/// <java-name>
						/// SORT_KEY_ALTERNATIVE
						/// </java-name>
						[Dot42.DexImport("SORT_KEY_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SORT_KEY_ALTERNATIVE = "sort_key_alt";
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactNameColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactNameColumns", AccessFlags = 1548)]
				protected internal partial interface IContactNameColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$DisplayNameSources
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DisplayNameSources", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IDisplayNameSourcesConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNDEFINED
						/// </java-name>
						[Dot42.DexImport("UNDEFINED", "I", AccessFlags = 25)]
						public const int UNDEFINED = 0;
						/// <java-name>
						/// EMAIL
						/// </java-name>
						[Dot42.DexImport("EMAIL", "I", AccessFlags = 25)]
						public const int EMAIL = 10;
						/// <java-name>
						/// PHONE
						/// </java-name>
						[Dot42.DexImport("PHONE", "I", AccessFlags = 25)]
						public const int PHONE = 20;
						/// <java-name>
						/// ORGANIZATION
						/// </java-name>
						[Dot42.DexImport("ORGANIZATION", "I", AccessFlags = 25)]
						public const int ORGANIZATION = 30;
						/// <java-name>
						/// NICKNAME
						/// </java-name>
						[Dot42.DexImport("NICKNAME", "I", AccessFlags = 25)]
						public const int NICKNAME = 35;
						/// <java-name>
						/// STRUCTURED_NAME
						/// </java-name>
						[Dot42.DexImport("STRUCTURED_NAME", "I", AccessFlags = 25)]
						public const int STRUCTURED_NAME = 40;
				}

				/// <java-name>
				/// android/provider/ContactsContract$DisplayNameSources
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DisplayNameSources", AccessFlags = 1545)]
				public partial interface IDisplayNameSources
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$PhoneticNameStyle
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneticNameStyle", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhoneticNameStyleConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNDEFINED
						/// </java-name>
						[Dot42.DexImport("UNDEFINED", "I", AccessFlags = 25)]
						public const int UNDEFINED = 0;
						/// <java-name>
						/// PINYIN
						/// </java-name>
						[Dot42.DexImport("PINYIN", "I", AccessFlags = 25)]
						public const int PINYIN = 3;
						/// <java-name>
						/// JAPANESE
						/// </java-name>
						[Dot42.DexImport("JAPANESE", "I", AccessFlags = 25)]
						public const int JAPANESE = 4;
						/// <java-name>
						/// KOREAN
						/// </java-name>
						[Dot42.DexImport("KOREAN", "I", AccessFlags = 25)]
						public const int KOREAN = 5;
				}

				/// <java-name>
				/// android/provider/ContactsContract$PhoneticNameStyle
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneticNameStyle", AccessFlags = 1545)]
				public partial interface IPhoneticNameStyle
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$FullNameStyle
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$FullNameStyle", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IFullNameStyleConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNDEFINED
						/// </java-name>
						[Dot42.DexImport("UNDEFINED", "I", AccessFlags = 25)]
						public const int UNDEFINED = 0;
						/// <java-name>
						/// WESTERN
						/// </java-name>
						[Dot42.DexImport("WESTERN", "I", AccessFlags = 25)]
						public const int WESTERN = 1;
						/// <java-name>
						/// CJK
						/// </java-name>
						[Dot42.DexImport("CJK", "I", AccessFlags = 25)]
						public const int CJK = 2;
						/// <java-name>
						/// CHINESE
						/// </java-name>
						[Dot42.DexImport("CHINESE", "I", AccessFlags = 25)]
						public const int CHINESE = 3;
						/// <java-name>
						/// JAPANESE
						/// </java-name>
						[Dot42.DexImport("JAPANESE", "I", AccessFlags = 25)]
						public const int JAPANESE = 4;
						/// <java-name>
						/// KOREAN
						/// </java-name>
						[Dot42.DexImport("KOREAN", "I", AccessFlags = 25)]
						public const int KOREAN = 5;
				}

				/// <java-name>
				/// android/provider/ContactsContract$FullNameStyle
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$FullNameStyle", AccessFlags = 1545)]
				public partial interface IFullNameStyle
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactStatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactStatusColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactStatusColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTACT_PRESENCE
						/// </java-name>
						[Dot42.DexImport("CONTACT_PRESENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_PRESENCE = "contact_presence";
						/// <java-name>
						/// CONTACT_CHAT_CAPABILITY
						/// </java-name>
						[Dot42.DexImport("CONTACT_CHAT_CAPABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_CHAT_CAPABILITY = "contact_chat_capability";
						/// <java-name>
						/// CONTACT_STATUS
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS = "contact_status";
						/// <java-name>
						/// CONTACT_STATUS_TIMESTAMP
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_TIMESTAMP = "contact_status_ts";
						/// <java-name>
						/// CONTACT_STATUS_RES_PACKAGE
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_RES_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_RES_PACKAGE = "contact_status_res_package";
						/// <java-name>
						/// CONTACT_STATUS_LABEL
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_LABEL = "contact_status_label";
						/// <java-name>
						/// CONTACT_STATUS_ICON
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_ICON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_ICON = "contact_status_icon";
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactStatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactStatusColumns", AccessFlags = 1548)]
				protected internal partial interface IContactStatusColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "display_name";
						/// <java-name>
						/// PHOTO_ID
						/// </java-name>
						[Dot42.DexImport("PHOTO_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_ID = "photo_id";
						/// <java-name>
						/// PHOTO_FILE_ID
						/// </java-name>
						[Dot42.DexImport("PHOTO_FILE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_FILE_ID = "photo_file_id";
						/// <java-name>
						/// PHOTO_URI
						/// </java-name>
						[Dot42.DexImport("PHOTO_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_URI = "photo_uri";
						/// <java-name>
						/// PHOTO_THUMBNAIL_URI
						/// </java-name>
						[Dot42.DexImport("PHOTO_THUMBNAIL_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_THUMBNAIL_URI = "photo_thumb_uri";
						/// <java-name>
						/// IN_VISIBLE_GROUP
						/// </java-name>
						[Dot42.DexImport("IN_VISIBLE_GROUP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IN_VISIBLE_GROUP = "in_visible_group";
						/// <java-name>
						/// IS_USER_PROFILE
						/// </java-name>
						[Dot42.DexImport("IS_USER_PROFILE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IS_USER_PROFILE = "is_user_profile";
						/// <java-name>
						/// HAS_PHONE_NUMBER
						/// </java-name>
						[Dot42.DexImport("HAS_PHONE_NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAS_PHONE_NUMBER = "has_phone_number";
						/// <java-name>
						/// LOOKUP_KEY
						/// </java-name>
						[Dot42.DexImport("LOOKUP_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOOKUP_KEY = "lookup";
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactsColumns", AccessFlags = 1548)]
				protected internal partial interface IContactsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactOptionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactOptionsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactOptionsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// TIMES_CONTACTED
						/// </java-name>
						[Dot42.DexImport("TIMES_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMES_CONTACTED = "times_contacted";
						/// <java-name>
						/// LAST_TIME_CONTACTED
						/// </java-name>
						[Dot42.DexImport("LAST_TIME_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LAST_TIME_CONTACTED = "last_time_contacted";
						/// <java-name>
						/// STARRED
						/// </java-name>
						[Dot42.DexImport("STARRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STARRED = "starred";
						/// <java-name>
						/// CUSTOM_RINGTONE
						/// </java-name>
						[Dot42.DexImport("CUSTOM_RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CUSTOM_RINGTONE = "custom_ringtone";
						/// <java-name>
						/// SEND_TO_VOICEMAIL
						/// </java-name>
						[Dot42.DexImport("SEND_TO_VOICEMAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEND_TO_VOICEMAIL = "send_to_voicemail";
				}

				/// <java-name>
				/// android/provider/ContactsContract$ContactOptionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactOptionsColumns", AccessFlags = 1548)]
				protected internal partial interface IContactOptionsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$SyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SyncColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISyncColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <java-name>
						/// SOURCE_ID
						/// </java-name>
						[Dot42.DexImport("SOURCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOURCE_ID = "sourceid";
						/// <java-name>
						/// VERSION
						/// </java-name>
						[Dot42.DexImport("VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VERSION = "version";
						/// <java-name>
						/// DIRTY
						/// </java-name>
						[Dot42.DexImport("DIRTY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIRTY = "dirty";
				}

				/// <java-name>
				/// android/provider/ContactsContract$SyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SyncColumns", AccessFlags = 1548)]
				protected internal partial interface ISyncColumns : global::Android.Provider.ContactsContract.IBaseSyncColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$BaseSyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$BaseSyncColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IBaseSyncColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SYNC1
						/// </java-name>
						[Dot42.DexImport("SYNC1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC1 = "sync1";
						/// <java-name>
						/// SYNC2
						/// </java-name>
						[Dot42.DexImport("SYNC2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC2 = "sync2";
						/// <java-name>
						/// SYNC3
						/// </java-name>
						[Dot42.DexImport("SYNC3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC3 = "sync3";
						/// <java-name>
						/// SYNC4
						/// </java-name>
						[Dot42.DexImport("SYNC4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC4 = "sync4";
				}

				/// <java-name>
				/// android/provider/ContactsContract$BaseSyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$BaseSyncColumns", AccessFlags = 1548)]
				protected internal partial interface IBaseSyncColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/ContactsContract$ProfileSyncState
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ProfileSyncState", AccessFlags = 25)]
				public sealed partial class ProfileSyncState : global::Android.Provider.SyncStateContract.IColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "syncstate";
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal ProfileSyncState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B", AccessFlags = 9)]
						public static sbyte[] JavaGet(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B", AccessFlags = 9, IgnoreFromJava = true)]
						public static byte[] Get(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(byte[]);
						}

						/// <java-name>
						/// getWithUri
						/// </java-name>
						[Dot42.DexImport("getWithUri", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/" +
    "Pair;", AccessFlags = 9, Signature = "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/" +
    "Pair<Landroid/net/Uri;[B>;")]
						public static global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]> GetWithUri(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]>);
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V", AccessFlags = 9)]
						public static void Set(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Set(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$SyncState
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SyncState", AccessFlags = 25)]
				public sealed partial class SyncState : global::Android.Provider.SyncStateContract.IColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "syncstate";
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SyncState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B", AccessFlags = 9)]
						public static sbyte[] JavaGet(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B", AccessFlags = 9, IgnoreFromJava = true)]
						public static byte[] Get(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(byte[]);
						}

						/// <java-name>
						/// getWithUri
						/// </java-name>
						[Dot42.DexImport("getWithUri", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/" +
    "Pair;", AccessFlags = 9, Signature = "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/" +
    "Pair<Landroid/net/Uri;[B>;")]
						public static global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]> GetWithUri(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]>);
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V", AccessFlags = 9)]
						public static void Set(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Set(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

				}

				/// <java-name>
				/// android/provider/ContactsContract$Directory
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Directory", AccessFlags = 25)]
				public sealed partial class Directory : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact_directories";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact_directory";
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "J", AccessFlags = 25)]
						public const long DEFAULT = 0;
						/// <java-name>
						/// LOCAL_INVISIBLE
						/// </java-name>
						[Dot42.DexImport("LOCAL_INVISIBLE", "J", AccessFlags = 25)]
						public const long LOCAL_INVISIBLE = 1;
						/// <java-name>
						/// PACKAGE_NAME
						/// </java-name>
						[Dot42.DexImport("PACKAGE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PACKAGE_NAME = "packageName";
						/// <java-name>
						/// TYPE_RESOURCE_ID
						/// </java-name>
						[Dot42.DexImport("TYPE_RESOURCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE_RESOURCE_ID = "typeResourceId";
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "displayName";
						/// <java-name>
						/// DIRECTORY_AUTHORITY
						/// </java-name>
						[Dot42.DexImport("DIRECTORY_AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIRECTORY_AUTHORITY = "authority";
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "accountType";
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "accountName";
						/// <java-name>
						/// EXPORT_SUPPORT
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXPORT_SUPPORT = "exportSupport";
						/// <java-name>
						/// EXPORT_SUPPORT_NONE
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT_NONE", "I", AccessFlags = 25)]
						public const int EXPORT_SUPPORT_NONE = 0;
						/// <java-name>
						/// EXPORT_SUPPORT_SAME_ACCOUNT_ONLY
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT_SAME_ACCOUNT_ONLY", "I", AccessFlags = 25)]
						public const int EXPORT_SUPPORT_SAME_ACCOUNT_ONLY = 1;
						/// <java-name>
						/// EXPORT_SUPPORT_ANY_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT_ANY_ACCOUNT", "I", AccessFlags = 25)]
						public const int EXPORT_SUPPORT_ANY_ACCOUNT = 2;
						/// <java-name>
						/// SHORTCUT_SUPPORT
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHORTCUT_SUPPORT = "shortcutSupport";
						/// <java-name>
						/// SHORTCUT_SUPPORT_NONE
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT_NONE", "I", AccessFlags = 25)]
						public const int SHORTCUT_SUPPORT_NONE = 0;
						/// <java-name>
						/// SHORTCUT_SUPPORT_DATA_ITEMS_ONLY
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT_DATA_ITEMS_ONLY", "I", AccessFlags = 25)]
						public const int SHORTCUT_SUPPORT_DATA_ITEMS_ONLY = 1;
						/// <java-name>
						/// SHORTCUT_SUPPORT_FULL
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT_FULL", "I", AccessFlags = 25)]
						public const int SHORTCUT_SUPPORT_FULL = 2;
						/// <java-name>
						/// PHOTO_SUPPORT
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_SUPPORT = "photoSupport";
						/// <java-name>
						/// PHOTO_SUPPORT_NONE
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_NONE", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_NONE = 0;
						/// <java-name>
						/// PHOTO_SUPPORT_THUMBNAIL_ONLY
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_THUMBNAIL_ONLY", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_THUMBNAIL_ONLY = 1;
						/// <java-name>
						/// PHOTO_SUPPORT_FULL_SIZE_ONLY
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_FULL_SIZE_ONLY", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_FULL_SIZE_ONLY = 2;
						/// <java-name>
						/// PHOTO_SUPPORT_FULL
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_FULL", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_FULL = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Directory() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// notifyDirectoryChange
						/// </java-name>
						[Dot42.DexImport("notifyDirectoryChange", "(Landroid/content/ContentResolver;)V", AccessFlags = 9)]
						public static void NotifyDirectoryChange(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/provider/CallLog
		/// </java-name>
		[Dot42.DexImport("android/provider/CallLog", AccessFlags = 33)]
		public partial class CallLog
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "call_log";
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CallLog() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/CallLog$Calls
				/// </java-name>
				[Dot42.DexImport("android/provider/CallLog$Calls", AccessFlags = 9)]
				public partial class Calls : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "date DESC";
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/calls";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/calls";
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <java-name>
						/// INCOMING_TYPE
						/// </java-name>
						[Dot42.DexImport("INCOMING_TYPE", "I", AccessFlags = 25)]
						public const int INCOMING_TYPE = 1;
						/// <java-name>
						/// OUTGOING_TYPE
						/// </java-name>
						[Dot42.DexImport("OUTGOING_TYPE", "I", AccessFlags = 25)]
						public const int OUTGOING_TYPE = 2;
						/// <java-name>
						/// MISSED_TYPE
						/// </java-name>
						[Dot42.DexImport("MISSED_TYPE", "I", AccessFlags = 25)]
						public const int MISSED_TYPE = 3;
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <java-name>
						/// DATE
						/// </java-name>
						[Dot42.DexImport("DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE = "date";
						/// <java-name>
						/// DURATION
						/// </java-name>
						[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DURATION = "duration";
						/// <java-name>
						/// NEW
						/// </java-name>
						[Dot42.DexImport("NEW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NEW = "new";
						/// <java-name>
						/// CACHED_NAME
						/// </java-name>
						[Dot42.DexImport("CACHED_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CACHED_NAME = "name";
						/// <java-name>
						/// CACHED_NUMBER_TYPE
						/// </java-name>
						[Dot42.DexImport("CACHED_NUMBER_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CACHED_NUMBER_TYPE = "numbertype";
						/// <java-name>
						/// CACHED_NUMBER_LABEL
						/// </java-name>
						[Dot42.DexImport("CACHED_NUMBER_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CACHED_NUMBER_LABEL = "numberlabel";
						/// <java-name>
						/// IS_READ
						/// </java-name>
						[Dot42.DexImport("IS_READ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IS_READ = "is_read";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Calls() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getLastOutgoingCall
						/// </java-name>
						[Dot42.DexImport("getLastOutgoingCall", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 9)]
						public static string GetLastOutgoingCall(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <java-name>
		/// android/provider/LiveFolders
		/// </java-name>
		[Dot42.DexImport("android/provider/LiveFolders", AccessFlags = 49)]
		public sealed partial class LiveFolders : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NAME
				/// </java-name>
				[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NAME = "name";
				/// <java-name>
				/// DESCRIPTION
				/// </java-name>
				[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DESCRIPTION = "description";
				/// <java-name>
				/// INTENT
				/// </java-name>
				[Dot42.DexImport("INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT = "intent";
				/// <java-name>
				/// ICON_BITMAP
				/// </java-name>
				[Dot42.DexImport("ICON_BITMAP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ICON_BITMAP = "icon_bitmap";
				/// <java-name>
				/// ICON_PACKAGE
				/// </java-name>
				[Dot42.DexImport("ICON_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ICON_PACKAGE = "icon_package";
				/// <java-name>
				/// ICON_RESOURCE
				/// </java-name>
				[Dot42.DexImport("ICON_RESOURCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ICON_RESOURCE = "icon_resource";
				/// <java-name>
				/// DISPLAY_MODE_GRID
				/// </java-name>
				[Dot42.DexImport("DISPLAY_MODE_GRID", "I", AccessFlags = 25)]
				public const int DISPLAY_MODE_GRID = 1;
				/// <java-name>
				/// DISPLAY_MODE_LIST
				/// </java-name>
				[Dot42.DexImport("DISPLAY_MODE_LIST", "I", AccessFlags = 25)]
				public const int DISPLAY_MODE_LIST = 2;
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_NAME = "android.intent.extra.livefolder.NAME";
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_ICON
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_ICON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_ICON = "android.intent.extra.livefolder.ICON";
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_DISPLAY_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_DISPLAY_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_DISPLAY_MODE = "android.intent.extra.livefolder.DISPLAY_MODE";
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_BASE_INTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_BASE_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_BASE_INTENT = "android.intent.extra.livefolder.BASE_INTENT";
				/// <java-name>
				/// ACTION_CREATE_LIVE_FOLDER
				/// </java-name>
				[Dot42.DexImport("ACTION_CREATE_LIVE_FOLDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CREATE_LIVE_FOLDER = "android.intent.action.CREATE_LIVE_FOLDER";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LiveFolders() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/provider/VoicemailContract
		/// </java-name>
		[Dot42.DexImport("android/provider/VoicemailContract", AccessFlags = 33)]
		public partial class VoicemailContract
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "com.android.voicemail";
				/// <java-name>
				/// PARAM_KEY_SOURCE_PACKAGE
				/// </java-name>
				[Dot42.DexImport("PARAM_KEY_SOURCE_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PARAM_KEY_SOURCE_PACKAGE = "source_package";
				/// <java-name>
				/// ACTION_NEW_VOICEMAIL
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_VOICEMAIL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_VOICEMAIL = "android.intent.action.NEW_VOICEMAIL";
				/// <java-name>
				/// ACTION_FETCH_VOICEMAIL
				/// </java-name>
				[Dot42.DexImport("ACTION_FETCH_VOICEMAIL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_FETCH_VOICEMAIL = "android.intent.action.FETCH_VOICEMAIL";
				/// <java-name>
				/// EXTRA_SELF_CHANGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SELF_CHANGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SELF_CHANGE = "com.android.voicemail.extra.SELF_CHANGE";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal VoicemailContract() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/VoicemailContract$Status
				/// </java-name>
				[Dot42.DexImport("android/provider/VoicemailContract$Status", AccessFlags = 25)]
				public sealed partial class Status : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// DIR_TYPE
						/// </java-name>
						[Dot42.DexImport("DIR_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIR_TYPE = "vnd.android.cursor.dir/voicemail.source.status";
						/// <java-name>
						/// ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ITEM_TYPE = "vnd.android.cursor.item/voicemail.source.status";
						/// <java-name>
						/// SOURCE_PACKAGE
						/// </java-name>
						[Dot42.DexImport("SOURCE_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOURCE_PACKAGE = "source_package";
						/// <java-name>
						/// SETTINGS_URI
						/// </java-name>
						[Dot42.DexImport("SETTINGS_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETTINGS_URI = "settings_uri";
						/// <java-name>
						/// VOICEMAIL_ACCESS_URI
						/// </java-name>
						[Dot42.DexImport("VOICEMAIL_ACCESS_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOICEMAIL_ACCESS_URI = "voicemail_access_uri";
						/// <java-name>
						/// CONFIGURATION_STATE
						/// </java-name>
						[Dot42.DexImport("CONFIGURATION_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONFIGURATION_STATE = "configuration_state";
						/// <java-name>
						/// CONFIGURATION_STATE_OK
						/// </java-name>
						[Dot42.DexImport("CONFIGURATION_STATE_OK", "I", AccessFlags = 25)]
						public const int CONFIGURATION_STATE_OK = 0;
						/// <java-name>
						/// CONFIGURATION_STATE_NOT_CONFIGURED
						/// </java-name>
						[Dot42.DexImport("CONFIGURATION_STATE_NOT_CONFIGURED", "I", AccessFlags = 25)]
						public const int CONFIGURATION_STATE_NOT_CONFIGURED = 1;
						/// <java-name>
						/// CONFIGURATION_STATE_CAN_BE_CONFIGURED
						/// </java-name>
						[Dot42.DexImport("CONFIGURATION_STATE_CAN_BE_CONFIGURED", "I", AccessFlags = 25)]
						public const int CONFIGURATION_STATE_CAN_BE_CONFIGURED = 2;
						/// <java-name>
						/// DATA_CHANNEL_STATE
						/// </java-name>
						[Dot42.DexImport("DATA_CHANNEL_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_CHANNEL_STATE = "data_channel_state";
						/// <java-name>
						/// DATA_CHANNEL_STATE_OK
						/// </java-name>
						[Dot42.DexImport("DATA_CHANNEL_STATE_OK", "I", AccessFlags = 25)]
						public const int DATA_CHANNEL_STATE_OK = 0;
						/// <java-name>
						/// DATA_CHANNEL_STATE_NO_CONNECTION
						/// </java-name>
						[Dot42.DexImport("DATA_CHANNEL_STATE_NO_CONNECTION", "I", AccessFlags = 25)]
						public const int DATA_CHANNEL_STATE_NO_CONNECTION = 1;
						/// <java-name>
						/// NOTIFICATION_CHANNEL_STATE
						/// </java-name>
						[Dot42.DexImport("NOTIFICATION_CHANNEL_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTIFICATION_CHANNEL_STATE = "notification_channel_state";
						/// <java-name>
						/// NOTIFICATION_CHANNEL_STATE_OK
						/// </java-name>
						[Dot42.DexImport("NOTIFICATION_CHANNEL_STATE_OK", "I", AccessFlags = 25)]
						public const int NOTIFICATION_CHANNEL_STATE_OK = 0;
						/// <java-name>
						/// NOTIFICATION_CHANNEL_STATE_NO_CONNECTION
						/// </java-name>
						[Dot42.DexImport("NOTIFICATION_CHANNEL_STATE_NO_CONNECTION", "I", AccessFlags = 25)]
						public const int NOTIFICATION_CHANNEL_STATE_NO_CONNECTION = 1;
						/// <java-name>
						/// NOTIFICATION_CHANNEL_STATE_MESSAGE_WAITING
						/// </java-name>
						[Dot42.DexImport("NOTIFICATION_CHANNEL_STATE_MESSAGE_WAITING", "I", AccessFlags = 25)]
						public const int NOTIFICATION_CHANNEL_STATE_MESSAGE_WAITING = 2;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Status() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// buildSourceUri
						/// </java-name>
						[Dot42.DexImport("buildSourceUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri BuildSourceUri(string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

				}

				/// <java-name>
				/// android/provider/VoicemailContract$Voicemails
				/// </java-name>
				[Dot42.DexImport("android/provider/VoicemailContract$Voicemails", AccessFlags = 25)]
				public sealed partial class Voicemails : global::Android.Provider.IBaseColumns, global::Android.Provider.IOpenableColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// DIR_TYPE
						/// </java-name>
						[Dot42.DexImport("DIR_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIR_TYPE = "vnd.android.cursor.dir/voicemails";
						/// <java-name>
						/// ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ITEM_TYPE = "vnd.android.cursor.item/voicemail";
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <java-name>
						/// DATE
						/// </java-name>
						[Dot42.DexImport("DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE = "date";
						/// <java-name>
						/// DURATION
						/// </java-name>
						[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DURATION = "duration";
						/// <java-name>
						/// IS_READ
						/// </java-name>
						[Dot42.DexImport("IS_READ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IS_READ = "is_read";
						/// <java-name>
						/// SOURCE_PACKAGE
						/// </java-name>
						[Dot42.DexImport("SOURCE_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOURCE_PACKAGE = "source_package";
						/// <java-name>
						/// SOURCE_DATA
						/// </java-name>
						[Dot42.DexImport("SOURCE_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOURCE_DATA = "source_data";
						/// <java-name>
						/// HAS_CONTENT
						/// </java-name>
						[Dot42.DexImport("HAS_CONTENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAS_CONTENT = "has_content";
						/// <java-name>
						/// MIME_TYPE
						/// </java-name>
						[Dot42.DexImport("MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MIME_TYPE = "mime_type";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Voicemails() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// buildSourceUri
						/// </java-name>
						[Dot42.DexImport("buildSourceUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri BuildSourceUri(string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

				}

		}

		/// <java-name>
		/// android/provider/SearchRecentSuggestions
		/// </java-name>
		[Dot42.DexImport("android/provider/SearchRecentSuggestions", AccessFlags = 33)]
		public partial class SearchRecentSuggestions
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// QUERIES_PROJECTION_1LINE
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_1LINE", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] QUERIES_PROJECTION_1LINE;
				/// <java-name>
				/// QUERIES_PROJECTION_2LINE
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_2LINE", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] QUERIES_PROJECTION_2LINE;
				/// <java-name>
				/// QUERIES_PROJECTION_DATE_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_DATE_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_DATE_INDEX = 1;
				/// <java-name>
				/// QUERIES_PROJECTION_QUERY_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_QUERY_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_QUERY_INDEX = 2;
				/// <java-name>
				/// QUERIES_PROJECTION_DISPLAY1_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_DISPLAY1_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_DISPLAY1_INDEX = 3;
				/// <java-name>
				/// QUERIES_PROJECTION_DISPLAY2_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_DISPLAY2_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_DISPLAY2_INDEX = 4;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SearchRecentSuggestions(global::Android.Content.Context context, string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveRecentQuery
				/// </java-name>
				[Dot42.DexImport("saveRecentQuery", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SaveRecentQuery(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearHistory
				/// </java-name>
				[Dot42.DexImport("clearHistory", "()V", AccessFlags = 1)]
				public virtual void ClearHistory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// truncateHistory
				/// </java-name>
				[Dot42.DexImport("truncateHistory", "(Landroid/content/ContentResolver;I)V", AccessFlags = 4)]
				protected internal virtual void TruncateHistory(global::Android.Content.ContentResolver contentResolver, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SearchRecentSuggestions() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/provider/MediaStore
		/// </java-name>
		[Dot42.DexImport("android/provider/MediaStore", AccessFlags = 49)]
		public sealed partial class MediaStore
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "media";
				/// <java-name>
				/// INTENT_ACTION_MUSIC_PLAYER
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_MUSIC_PLAYER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_MUSIC_PLAYER = "android.intent.action.MUSIC_PLAYER";
				/// <java-name>
				/// INTENT_ACTION_MEDIA_SEARCH
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_MEDIA_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_MEDIA_SEARCH = "android.intent.action.MEDIA_SEARCH";
				/// <java-name>
				/// INTENT_ACTION_MEDIA_PLAY_FROM_SEARCH
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_MEDIA_PLAY_FROM_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_MEDIA_PLAY_FROM_SEARCH = "android.media.action.MEDIA_PLAY_FROM_SEARCH";
				/// <java-name>
				/// EXTRA_MEDIA_ARTIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_ARTIST = "android.intent.extra.artist";
				/// <java-name>
				/// EXTRA_MEDIA_ALBUM
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_ALBUM = "android.intent.extra.album";
				/// <java-name>
				/// EXTRA_MEDIA_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_TITLE = "android.intent.extra.title";
				/// <java-name>
				/// EXTRA_MEDIA_FOCUS
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_FOCUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_FOCUS = "android.intent.extra.focus";
				/// <java-name>
				/// EXTRA_SCREEN_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCREEN_ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCREEN_ORIENTATION = "android.intent.extra.screenOrientation";
				/// <java-name>
				/// EXTRA_FULL_SCREEN
				/// </java-name>
				[Dot42.DexImport("EXTRA_FULL_SCREEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_FULL_SCREEN = "android.intent.extra.fullScreen";
				/// <java-name>
				/// EXTRA_SHOW_ACTION_ICONS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_ACTION_ICONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_ACTION_ICONS = "android.intent.extra.showActionIcons";
				/// <java-name>
				/// EXTRA_FINISH_ON_COMPLETION
				/// </java-name>
				[Dot42.DexImport("EXTRA_FINISH_ON_COMPLETION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_FINISH_ON_COMPLETION = "android.intent.extra.finishOnCompletion";
				/// <java-name>
				/// INTENT_ACTION_STILL_IMAGE_CAMERA
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_STILL_IMAGE_CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_STILL_IMAGE_CAMERA = "android.media.action.STILL_IMAGE_CAMERA";
				/// <java-name>
				/// INTENT_ACTION_VIDEO_CAMERA
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_VIDEO_CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_VIDEO_CAMERA = "android.media.action.VIDEO_CAMERA";
				/// <java-name>
				/// ACTION_IMAGE_CAPTURE
				/// </java-name>
				[Dot42.DexImport("ACTION_IMAGE_CAPTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_IMAGE_CAPTURE = "android.media.action.IMAGE_CAPTURE";
				/// <java-name>
				/// ACTION_VIDEO_CAPTURE
				/// </java-name>
				[Dot42.DexImport("ACTION_VIDEO_CAPTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VIDEO_CAPTURE = "android.media.action.VIDEO_CAPTURE";
				/// <java-name>
				/// EXTRA_VIDEO_QUALITY
				/// </java-name>
				[Dot42.DexImport("EXTRA_VIDEO_QUALITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VIDEO_QUALITY = "android.intent.extra.videoQuality";
				/// <java-name>
				/// EXTRA_SIZE_LIMIT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SIZE_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SIZE_LIMIT = "android.intent.extra.sizeLimit";
				/// <java-name>
				/// EXTRA_DURATION_LIMIT
				/// </java-name>
				[Dot42.DexImport("EXTRA_DURATION_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DURATION_LIMIT = "android.intent.extra.durationLimit";
				/// <java-name>
				/// EXTRA_OUTPUT
				/// </java-name>
				[Dot42.DexImport("EXTRA_OUTPUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_OUTPUT = "output";
				/// <java-name>
				/// UNKNOWN_STRING
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_STRING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNKNOWN_STRING = "<unknown>";
				/// <java-name>
				/// MEDIA_SCANNER_VOLUME
				/// </java-name>
				[Dot42.DexImport("MEDIA_SCANNER_VOLUME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_SCANNER_VOLUME = "volume";
				/// <java-name>
				/// MEDIA_IGNORE_FILENAME
				/// </java-name>
				[Dot42.DexImport("MEDIA_IGNORE_FILENAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_IGNORE_FILENAME = ".nomedia";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaStore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMediaScannerUri
				/// </java-name>
				[Dot42.DexImport("getMediaScannerUri", "()Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetMediaScannerUri() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetVersion(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMediaScannerUri
				/// </java-name>
				public static global::Android.Net.Uri MediaScannerUri
				{
				[Dot42.DexImport("getMediaScannerUri", "()Landroid/net/Uri;", AccessFlags = 9)]
						get{ return GetMediaScannerUri(); }
				}

				/// <java-name>
				/// android/provider/MediaStore$Video
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$Video", AccessFlags = 25)]
				public sealed partial class Video
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "_display_name";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Video() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/d" +
    "atabase/Cursor;", AccessFlags = 25)]
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, string[] @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

						/// <java-name>
						/// android/provider/MediaStore$Video$Thumbnails
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Video$Thumbnails", AccessFlags = 9)]
						public partial class Thumbnails : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "video_id ASC";
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "_data";
								/// <java-name>
								/// VIDEO_ID
								/// </java-name>
								[Dot42.DexImport("VIDEO_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string VIDEO_ID = "video_id";
								/// <java-name>
								/// KIND
								/// </java-name>
								[Dot42.DexImport("KIND", "Ljava/lang/String;", AccessFlags = 25)]
								public const string KIND = "kind";
								/// <java-name>
								/// MINI_KIND
								/// </java-name>
								[Dot42.DexImport("MINI_KIND", "I", AccessFlags = 25)]
								public const int MINI_KIND = 1;
								/// <java-name>
								/// FULL_SCREEN_KIND
								/// </java-name>
								[Dot42.DexImport("FULL_SCREEN_KIND", "I", AccessFlags = 25)]
								public const int FULL_SCREEN_KIND = 2;
								/// <java-name>
								/// MICRO_KIND
								/// </java-name>
								[Dot42.DexImport("MICRO_KIND", "I", AccessFlags = 25)]
								public const int MICRO_KIND = 3;
								/// <java-name>
								/// WIDTH
								/// </java-name>
								[Dot42.DexImport("WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
								public const string WIDTH = "width";
								/// <java-name>
								/// HEIGHT
								/// </java-name>
								[Dot42.DexImport("HEIGHT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string HEIGHT = "height";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Thumbnails() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver contentResolver, long int64) /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Land" +
    "roid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver contentResolver, long int64, int int32, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Lan" +
    "droid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver contentResolver, long int64, long int641, int int32, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver contentResolver, long int64, long int641) /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Video$Media
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Video$Media", AccessFlags = 25)]
						public sealed partial class Media : global::Android.Provider.MediaStore.Video.IVideoColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/video";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "title";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Media() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Video$VideoColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Video$VideoColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IVideoColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// DURATION
								/// </java-name>
								[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DURATION = "duration";
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <java-name>
								/// ALBUM
								/// </java-name>
								[Dot42.DexImport("ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM = "album";
								/// <java-name>
								/// RESOLUTION
								/// </java-name>
								[Dot42.DexImport("RESOLUTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string RESOLUTION = "resolution";
								/// <java-name>
								/// DESCRIPTION
								/// </java-name>
								[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DESCRIPTION = "description";
								/// <java-name>
								/// IS_PRIVATE
								/// </java-name>
								[Dot42.DexImport("IS_PRIVATE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_PRIVATE = "isprivate";
								/// <java-name>
								/// TAGS
								/// </java-name>
								[Dot42.DexImport("TAGS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TAGS = "tags";
								/// <java-name>
								/// CATEGORY
								/// </java-name>
								[Dot42.DexImport("CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CATEGORY = "category";
								/// <java-name>
								/// LANGUAGE
								/// </java-name>
								[Dot42.DexImport("LANGUAGE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LANGUAGE = "language";
								/// <java-name>
								/// LATITUDE
								/// </java-name>
								[Dot42.DexImport("LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LATITUDE = "latitude";
								/// <java-name>
								/// LONGITUDE
								/// </java-name>
								[Dot42.DexImport("LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LONGITUDE = "longitude";
								/// <java-name>
								/// DATE_TAKEN
								/// </java-name>
								[Dot42.DexImport("DATE_TAKEN", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_TAKEN = "datetaken";
								/// <java-name>
								/// MINI_THUMB_MAGIC
								/// </java-name>
								[Dot42.DexImport("MINI_THUMB_MAGIC", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MINI_THUMB_MAGIC = "mini_thumb_magic";
								/// <java-name>
								/// BUCKET_ID
								/// </java-name>
								[Dot42.DexImport("BUCKET_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_ID = "bucket_id";
								/// <java-name>
								/// BUCKET_DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("BUCKET_DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_DISPLAY_NAME = "bucket_display_name";
								/// <java-name>
								/// BOOKMARK
								/// </java-name>
								[Dot42.DexImport("BOOKMARK", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BOOKMARK = "bookmark";
						}

						/// <java-name>
						/// android/provider/MediaStore$Video$VideoColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Video$VideoColumns", AccessFlags = 1545)]
						public partial interface IVideoColumns : global::Android.Provider.MediaStore.IMediaColumns
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/MediaStore$Audio
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$Audio", AccessFlags = 25)]
				public sealed partial class Audio
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Audio() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// keyFor
						/// </java-name>
						[Dot42.DexImport("keyFor", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
						public static string KeyFor(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$Albums
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Albums", AccessFlags = 25)]
						public sealed partial class Albums : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IAlbumColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/albums";
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/album";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "album_key";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Albums() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$AlbumColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AlbumColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IAlbumColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// ALBUM_ID
								/// </java-name>
								[Dot42.DexImport("ALBUM_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_ID = "album_id";
								/// <java-name>
								/// ALBUM
								/// </java-name>
								[Dot42.DexImport("ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM = "album";
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <java-name>
								/// NUMBER_OF_SONGS
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_SONGS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_SONGS = "numsongs";
								/// <java-name>
								/// NUMBER_OF_SONGS_FOR_ARTIST
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_SONGS_FOR_ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_SONGS_FOR_ARTIST = "numsongs_by_artist";
								/// <java-name>
								/// FIRST_YEAR
								/// </java-name>
								[Dot42.DexImport("FIRST_YEAR", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FIRST_YEAR = "minyear";
								/// <java-name>
								/// LAST_YEAR
								/// </java-name>
								[Dot42.DexImport("LAST_YEAR", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LAST_YEAR = "maxyear";
								/// <java-name>
								/// ALBUM_KEY
								/// </java-name>
								[Dot42.DexImport("ALBUM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_KEY = "album_key";
								/// <java-name>
								/// ALBUM_ART
								/// </java-name>
								[Dot42.DexImport("ALBUM_ART", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_ART = "album_art";
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$AlbumColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AlbumColumns", AccessFlags = 1545)]
						public partial interface IAlbumColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$Artists
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Artists", AccessFlags = 25)]
						public sealed partial class Artists : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IArtistColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/artists";
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/artist";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "artist_key";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Artists() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <java-name>
								/// android/provider/MediaStore$Audio$Artists$Albums
								/// </java-name>
								[Dot42.DexImport("android/provider/MediaStore$Audio$Artists$Albums", AccessFlags = 25)]
								public sealed partial class Albums : global::Android.Provider.MediaStore.Audio.IAlbumColumns
 /* scope: __dot42__ */ 
								{
										[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
										public Albums() /* MethodBuilder.Create */ 
										{
										}

										/// <java-name>
										/// getContentUri
										/// </java-name>
										[Dot42.DexImport("getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;", AccessFlags = 25)]
										public static global::Android.Net.Uri GetContentUri(string @string, long int64) /* MethodBuilder.Create */ 
										{
												return default(global::Android.Net.Uri);
										}

								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$ArtistColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$ArtistColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IArtistColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <java-name>
								/// ARTIST_KEY
								/// </java-name>
								[Dot42.DexImport("ARTIST_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST_KEY = "artist_key";
								/// <java-name>
								/// NUMBER_OF_ALBUMS
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_ALBUMS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_ALBUMS = "number_of_albums";
								/// <java-name>
								/// NUMBER_OF_TRACKS
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_TRACKS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_TRACKS = "number_of_tracks";
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$ArtistColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$ArtistColumns", AccessFlags = 1545)]
						public partial interface IArtistColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$Playlists
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Playlists", AccessFlags = 25)]
						public sealed partial class Playlists : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IPlaylistsColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/playlist";
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/playlist";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "name";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Playlists() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <java-name>
								/// android/provider/MediaStore$Audio$Playlists$Members
								/// </java-name>
								[Dot42.DexImport("android/provider/MediaStore$Audio$Playlists$Members", AccessFlags = 25)]
								public sealed partial class Members : global::Android.Provider.MediaStore.Audio.IAudioColumns
 /* scope: __dot42__ */ 
								{
										/// <java-name>
										/// _ID
										/// </java-name>
										[Dot42.DexImport("_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string _ID = "_id";
										/// <java-name>
										/// CONTENT_DIRECTORY
										/// </java-name>
										[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
										public const string CONTENT_DIRECTORY = "members";
										/// <java-name>
										/// AUDIO_ID
										/// </java-name>
										[Dot42.DexImport("AUDIO_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string AUDIO_ID = "audio_id";
										/// <java-name>
										/// PLAYLIST_ID
										/// </java-name>
										[Dot42.DexImport("PLAYLIST_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string PLAYLIST_ID = "playlist_id";
										/// <java-name>
										/// PLAY_ORDER
										/// </java-name>
										[Dot42.DexImport("PLAY_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
										public const string PLAY_ORDER = "play_order";
										/// <java-name>
										/// DEFAULT_SORT_ORDER
										/// </java-name>
										[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
										public const string DEFAULT_SORT_ORDER = "play_order";
										[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
										public Members() /* MethodBuilder.Create */ 
										{
										}

										/// <java-name>
										/// getContentUri
										/// </java-name>
										[Dot42.DexImport("getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;", AccessFlags = 25)]
										public static global::Android.Net.Uri GetContentUri(string @string, long int64) /* MethodBuilder.Create */ 
										{
												return default(global::Android.Net.Uri);
										}

										/// <java-name>
										/// moveItem
										/// </java-name>
										[Dot42.DexImport("moveItem", "(Landroid/content/ContentResolver;JII)Z", AccessFlags = 25)]
										public static bool MoveItem(global::Android.Content.ContentResolver contentResolver, long int64, int int32, int int321) /* MethodBuilder.Create */ 
										{
												return default(bool);
										}

								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$PlaylistsColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$PlaylistsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IPlaylistsColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "_data";
								/// <java-name>
								/// DATE_ADDED
								/// </java-name>
								[Dot42.DexImport("DATE_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_ADDED = "date_added";
								/// <java-name>
								/// DATE_MODIFIED
								/// </java-name>
								[Dot42.DexImport("DATE_MODIFIED", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_MODIFIED = "date_modified";
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$PlaylistsColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$PlaylistsColumns", AccessFlags = 1545)]
						public partial interface IPlaylistsColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$Genres
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Genres", AccessFlags = 25)]
						public sealed partial class Genres : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IGenresColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/genre";
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/genre";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "name";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Genres() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <java-name>
								/// getContentUriForAudioId
								/// </java-name>
								[Dot42.DexImport("getContentUriForAudioId", "(Ljava/lang/String;I)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUriForAudioId(string @string, int int32) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <java-name>
								/// android/provider/MediaStore$Audio$Genres$Members
								/// </java-name>
								[Dot42.DexImport("android/provider/MediaStore$Audio$Genres$Members", AccessFlags = 25)]
								public sealed partial class Members : global::Android.Provider.MediaStore.Audio.IAudioColumns
 /* scope: __dot42__ */ 
								{
										/// <java-name>
										/// CONTENT_DIRECTORY
										/// </java-name>
										[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
										public const string CONTENT_DIRECTORY = "members";
										/// <java-name>
										/// DEFAULT_SORT_ORDER
										/// </java-name>
										[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
										public const string DEFAULT_SORT_ORDER = "title_key";
										/// <java-name>
										/// AUDIO_ID
										/// </java-name>
										[Dot42.DexImport("AUDIO_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string AUDIO_ID = "audio_id";
										/// <java-name>
										/// GENRE_ID
										/// </java-name>
										[Dot42.DexImport("GENRE_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string GENRE_ID = "genre_id";
										[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
										public Members() /* MethodBuilder.Create */ 
										{
										}

										/// <java-name>
										/// getContentUri
										/// </java-name>
										[Dot42.DexImport("getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;", AccessFlags = 25)]
										public static global::Android.Net.Uri GetContentUri(string @string, long int64) /* MethodBuilder.Create */ 
										{
												return default(global::Android.Net.Uri);
										}

								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$GenresColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$GenresColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IGenresColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$GenresColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$GenresColumns", AccessFlags = 1545)]
						public partial interface IGenresColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$Media
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Media", AccessFlags = 25)]
						public sealed partial class Media : global::Android.Provider.MediaStore.Audio.IAudioColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/audio";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "title_key";
								/// <java-name>
								/// RECORD_SOUND_ACTION
								/// </java-name>
								[Dot42.DexImport("RECORD_SOUND_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string RECORD_SOUND_ACTION = "android.provider.MediaStore.RECORD_SOUND";
								/// <java-name>
								/// EXTRA_MAX_BYTES
								/// </java-name>
								[Dot42.DexImport("EXTRA_MAX_BYTES", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EXTRA_MAX_BYTES = "android.provider.MediaStore.extra.MAX_BYTES";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Media() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <java-name>
								/// getContentUriForPath
								/// </java-name>
								[Dot42.DexImport("getContentUriForPath", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUriForPath(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$AudioColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AudioColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IAudioColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// TITLE_KEY
								/// </java-name>
								[Dot42.DexImport("TITLE_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE_KEY = "title_key";
								/// <java-name>
								/// DURATION
								/// </java-name>
								[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DURATION = "duration";
								/// <java-name>
								/// BOOKMARK
								/// </java-name>
								[Dot42.DexImport("BOOKMARK", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BOOKMARK = "bookmark";
								/// <java-name>
								/// ARTIST_ID
								/// </java-name>
								[Dot42.DexImport("ARTIST_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST_ID = "artist_id";
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <java-name>
								/// ARTIST_KEY
								/// </java-name>
								[Dot42.DexImport("ARTIST_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST_KEY = "artist_key";
								/// <java-name>
								/// COMPOSER
								/// </java-name>
								[Dot42.DexImport("COMPOSER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPOSER = "composer";
								/// <java-name>
								/// ALBUM_ID
								/// </java-name>
								[Dot42.DexImport("ALBUM_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_ID = "album_id";
								/// <java-name>
								/// ALBUM
								/// </java-name>
								[Dot42.DexImport("ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM = "album";
								/// <java-name>
								/// ALBUM_KEY
								/// </java-name>
								[Dot42.DexImport("ALBUM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_KEY = "album_key";
								/// <java-name>
								/// TRACK
								/// </java-name>
								[Dot42.DexImport("TRACK", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TRACK = "track";
								/// <java-name>
								/// YEAR
								/// </java-name>
								[Dot42.DexImport("YEAR", "Ljava/lang/String;", AccessFlags = 25)]
								public const string YEAR = "year";
								/// <java-name>
								/// IS_MUSIC
								/// </java-name>
								[Dot42.DexImport("IS_MUSIC", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_MUSIC = "is_music";
								/// <java-name>
								/// IS_PODCAST
								/// </java-name>
								[Dot42.DexImport("IS_PODCAST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_PODCAST = "is_podcast";
								/// <java-name>
								/// IS_RINGTONE
								/// </java-name>
								[Dot42.DexImport("IS_RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_RINGTONE = "is_ringtone";
								/// <java-name>
								/// IS_ALARM
								/// </java-name>
								[Dot42.DexImport("IS_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_ALARM = "is_alarm";
								/// <java-name>
								/// IS_NOTIFICATION
								/// </java-name>
								[Dot42.DexImport("IS_NOTIFICATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_NOTIFICATION = "is_notification";
						}

						/// <java-name>
						/// android/provider/MediaStore$Audio$AudioColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AudioColumns", AccessFlags = 1545)]
						public partial interface IAudioColumns : global::Android.Provider.MediaStore.IMediaColumns
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/MediaStore$Images
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$Images", AccessFlags = 25)]
				public sealed partial class Images
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Images() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// android/provider/MediaStore$Images$Thumbnails
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Images$Thumbnails", AccessFlags = 9)]
						public partial class Thumbnails : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "image_id ASC";
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "_data";
								/// <java-name>
								/// IMAGE_ID
								/// </java-name>
								[Dot42.DexImport("IMAGE_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IMAGE_ID = "image_id";
								/// <java-name>
								/// KIND
								/// </java-name>
								[Dot42.DexImport("KIND", "Ljava/lang/String;", AccessFlags = 25)]
								public const string KIND = "kind";
								/// <java-name>
								/// MINI_KIND
								/// </java-name>
								[Dot42.DexImport("MINI_KIND", "I", AccessFlags = 25)]
								public const int MINI_KIND = 1;
								/// <java-name>
								/// FULL_SCREEN_KIND
								/// </java-name>
								[Dot42.DexImport("FULL_SCREEN_KIND", "I", AccessFlags = 25)]
								public const int FULL_SCREEN_KIND = 2;
								/// <java-name>
								/// MICRO_KIND
								/// </java-name>
								[Dot42.DexImport("MICRO_KIND", "I", AccessFlags = 25)]
								public const int MICRO_KIND = 3;
								/// <java-name>
								/// THUMB_DATA
								/// </java-name>
								[Dot42.DexImport("THUMB_DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string THUMB_DATA = "thumb_data";
								/// <java-name>
								/// WIDTH
								/// </java-name>
								[Dot42.DexImport("WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
								public const string WIDTH = "width";
								/// <java-name>
								/// HEIGHT
								/// </java-name>
								[Dot42.DexImport("HEIGHT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string HEIGHT = "height";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Thumbnails() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// query
								/// </java-name>
								[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/d" +
    "atabase/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, string[] @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// queryMiniThumbnails
								/// </java-name>
								[Dot42.DexImport("queryMiniThumbnails", "(Landroid/content/ContentResolver;Landroid/net/Uri;I[Ljava/lang/String;)Landroid/" +
    "database/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor QueryMiniThumbnails(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, int int32, string[] @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// queryMiniThumbnail
								/// </java-name>
								[Dot42.DexImport("queryMiniThumbnail", "(Landroid/content/ContentResolver;JI[Ljava/lang/String;)Landroid/database/Cursor;" +
    "", AccessFlags = 25)]
								public static global::Android.Database.ICursor QueryMiniThumbnail(global::Android.Content.ContentResolver contentResolver, long int64, int int32, string[] @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver contentResolver, long int64) /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Land" +
    "roid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver contentResolver, long int64, int int32, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver contentResolver, long int64, long int641) /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Lan" +
    "droid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver contentResolver, long int64, long int641, int int32, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Images$Media
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Images$Media", AccessFlags = 25)]
						public sealed partial class Media : global::Android.Provider.MediaStore.Images.IImageColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/image";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "bucket_display_name";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Media() /* MethodBuilder.Create */ 
								{
								}

								/// <java-name>
								/// query
								/// </java-name>
								[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/d" +
    "atabase/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, string[] @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// query
								/// </java-name>
								[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/" +
    "String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, string[] @string, string string1, string string2) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// query
								/// </java-name>
								[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/" +
    "String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// getBitmap
								/// </java-name>
								[Dot42.DexImport("getBitmap", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/graphics/Bitmap;", AccessFlags = 25)]
								public static global::Android.Graphics.Bitmap GetBitmap(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <java-name>
								/// insertImage
								/// </java-name>
								[Dot42.DexImport("insertImage", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/" +
    "String;)Ljava/lang/String;", AccessFlags = 25)]
								public static string InsertImage(global::Android.Content.ContentResolver contentResolver, string @string, string string1, string string2) /* MethodBuilder.Create */ 
								{
										return default(string);
								}

								/// <java-name>
								/// insertImage
								/// </java-name>
								[Dot42.DexImport("insertImage", "(Landroid/content/ContentResolver;Landroid/graphics/Bitmap;Ljava/lang/String;Ljav" +
    "a/lang/String;)Ljava/lang/String;", AccessFlags = 25)]
								public static string InsertImage(global::Android.Content.ContentResolver contentResolver, global::Android.Graphics.Bitmap bitmap, string @string, string string1) /* MethodBuilder.Create */ 
								{
										return default(string);
								}

								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <java-name>
						/// android/provider/MediaStore$Images$ImageColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Images$ImageColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IImageColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// DESCRIPTION
								/// </java-name>
								[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DESCRIPTION = "description";
								/// <java-name>
								/// PICASA_ID
								/// </java-name>
								[Dot42.DexImport("PICASA_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PICASA_ID = "picasa_id";
								/// <java-name>
								/// IS_PRIVATE
								/// </java-name>
								[Dot42.DexImport("IS_PRIVATE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_PRIVATE = "isprivate";
								/// <java-name>
								/// LATITUDE
								/// </java-name>
								[Dot42.DexImport("LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LATITUDE = "latitude";
								/// <java-name>
								/// LONGITUDE
								/// </java-name>
								[Dot42.DexImport("LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LONGITUDE = "longitude";
								/// <java-name>
								/// DATE_TAKEN
								/// </java-name>
								[Dot42.DexImport("DATE_TAKEN", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_TAKEN = "datetaken";
								/// <java-name>
								/// ORIENTATION
								/// </java-name>
								[Dot42.DexImport("ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ORIENTATION = "orientation";
								/// <java-name>
								/// MINI_THUMB_MAGIC
								/// </java-name>
								[Dot42.DexImport("MINI_THUMB_MAGIC", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MINI_THUMB_MAGIC = "mini_thumb_magic";
								/// <java-name>
								/// BUCKET_ID
								/// </java-name>
								[Dot42.DexImport("BUCKET_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_ID = "bucket_id";
								/// <java-name>
								/// BUCKET_DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("BUCKET_DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_DISPLAY_NAME = "bucket_display_name";
						}

						/// <java-name>
						/// android/provider/MediaStore$Images$ImageColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Images$ImageColumns", AccessFlags = 1545)]
						public partial interface IImageColumns : global::Android.Provider.MediaStore.IMediaColumns
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/MediaStore$Files
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$Files", AccessFlags = 25)]
				public sealed partial class Files
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Files() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getContentUri
						/// </java-name>
						[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetContentUri(string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// getContentUri
						/// </java-name>
						[Dot42.DexImport("getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;", AccessFlags = 25)]
						public static global::Android.Net.Uri GetContentUri(string @string, long int64) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// android/provider/MediaStore$Files$FileColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Files$FileColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IFileColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// PARENT
								/// </java-name>
								[Dot42.DexImport("PARENT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PARENT = "parent";
								/// <java-name>
								/// MIME_TYPE
								/// </java-name>
								[Dot42.DexImport("MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MIME_TYPE = "mime_type";
								/// <java-name>
								/// TITLE
								/// </java-name>
								[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE = "title";
								/// <java-name>
								/// MEDIA_TYPE
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MEDIA_TYPE = "media_type";
								/// <java-name>
								/// MEDIA_TYPE_NONE
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_NONE", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_NONE = 0;
								/// <java-name>
								/// MEDIA_TYPE_IMAGE
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_IMAGE", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_IMAGE = 1;
								/// <java-name>
								/// MEDIA_TYPE_AUDIO
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_AUDIO", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_AUDIO = 2;
								/// <java-name>
								/// MEDIA_TYPE_VIDEO
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_VIDEO", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_VIDEO = 3;
								/// <java-name>
								/// MEDIA_TYPE_PLAYLIST
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_PLAYLIST", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_PLAYLIST = 4;
						}

						/// <java-name>
						/// android/provider/MediaStore$Files$FileColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Files$FileColumns", AccessFlags = 1545)]
						public partial interface IFileColumns : global::Android.Provider.MediaStore.IMediaColumns
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/MediaStore$MediaColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$MediaColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IMediaColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "_data";
						/// <java-name>
						/// SIZE
						/// </java-name>
						[Dot42.DexImport("SIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SIZE = "_size";
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "_display_name";
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <java-name>
						/// DATE_ADDED
						/// </java-name>
						[Dot42.DexImport("DATE_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE_ADDED = "date_added";
						/// <java-name>
						/// DATE_MODIFIED
						/// </java-name>
						[Dot42.DexImport("DATE_MODIFIED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE_MODIFIED = "date_modified";
						/// <java-name>
						/// MIME_TYPE
						/// </java-name>
						[Dot42.DexImport("MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MIME_TYPE = "mime_type";
				}

				/// <java-name>
				/// android/provider/MediaStore$MediaColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$MediaColumns", AccessFlags = 1545)]
				public partial interface IMediaColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <java-name>
		/// android/provider/Contacts
		/// </java-name>
		[Dot42.DexImport("android/provider/Contacts", AccessFlags = 33)]
		public partial class Contacts
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "contacts";
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				/// <java-name>
				/// KIND_EMAIL
				/// </java-name>
				[Dot42.DexImport("KIND_EMAIL", "I", AccessFlags = 25)]
				public const int KIND_EMAIL = 1;
				/// <java-name>
				/// KIND_POSTAL
				/// </java-name>
				[Dot42.DexImport("KIND_POSTAL", "I", AccessFlags = 25)]
				public const int KIND_POSTAL = 2;
				/// <java-name>
				/// KIND_IM
				/// </java-name>
				[Dot42.DexImport("KIND_IM", "I", AccessFlags = 25)]
				public const int KIND_IM = 3;
				/// <java-name>
				/// KIND_ORGANIZATION
				/// </java-name>
				[Dot42.DexImport("KIND_ORGANIZATION", "I", AccessFlags = 25)]
				public const int KIND_ORGANIZATION = 4;
				/// <java-name>
				/// KIND_PHONE
				/// </java-name>
				[Dot42.DexImport("KIND_PHONE", "I", AccessFlags = 25)]
				public const int KIND_PHONE = 5;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Contacts() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$Intents
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Intents", AccessFlags = 25)]
				public sealed partial class Intents
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SEARCH_SUGGESTION_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED";
						/// <java-name>
						/// SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED";
						/// <java-name>
						/// SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED";
						/// <java-name>
						/// ATTACH_IMAGE
						/// </java-name>
						[Dot42.DexImport("ATTACH_IMAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTACH_IMAGE = "com.android.contacts.action.ATTACH_IMAGE";
						/// <java-name>
						/// SHOW_OR_CREATE_CONTACT
						/// </java-name>
						[Dot42.DexImport("SHOW_OR_CREATE_CONTACT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_OR_CREATE_CONTACT = "com.android.contacts.action.SHOW_OR_CREATE_CONTACT";
						/// <java-name>
						/// EXTRA_FORCE_CREATE
						/// </java-name>
						[Dot42.DexImport("EXTRA_FORCE_CREATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_FORCE_CREATE = "com.android.contacts.action.FORCE_CREATE";
						/// <java-name>
						/// EXTRA_CREATE_DESCRIPTION
						/// </java-name>
						[Dot42.DexImport("EXTRA_CREATE_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CREATE_DESCRIPTION = "com.android.contacts.action.CREATE_DESCRIPTION";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Intents() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// android/provider/Contacts$Intents$Insert
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$Intents$Insert", AccessFlags = 25)]
						public sealed partial class Insert
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// ACTION
								/// </java-name>
								[Dot42.DexImport("ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ACTION = "android.intent.action.INSERT";
								/// <java-name>
								/// FULL_MODE
								/// </java-name>
								[Dot42.DexImport("FULL_MODE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FULL_MODE = "full_mode";
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
								/// <java-name>
								/// PHONETIC_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_NAME = "phonetic_name";
								/// <java-name>
								/// COMPANY
								/// </java-name>
								[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPANY = "company";
								/// <java-name>
								/// JOB_TITLE
								/// </java-name>
								[Dot42.DexImport("JOB_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string JOB_TITLE = "job_title";
								/// <java-name>
								/// NOTES
								/// </java-name>
								[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NOTES = "notes";
								/// <java-name>
								/// PHONE
								/// </java-name>
								[Dot42.DexImport("PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE = "phone";
								/// <java-name>
								/// PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_TYPE = "phone_type";
								/// <java-name>
								/// PHONE_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("PHONE_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_ISPRIMARY = "phone_isprimary";
								/// <java-name>
								/// SECONDARY_PHONE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE = "secondary_phone";
								/// <java-name>
								/// SECONDARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE_TYPE = "secondary_phone_type";
								/// <java-name>
								/// TERTIARY_PHONE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE = "tertiary_phone";
								/// <java-name>
								/// TERTIARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE_TYPE = "tertiary_phone_type";
								/// <java-name>
								/// EMAIL
								/// </java-name>
								[Dot42.DexImport("EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL = "email";
								/// <java-name>
								/// EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_TYPE = "email_type";
								/// <java-name>
								/// EMAIL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("EMAIL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_ISPRIMARY = "email_isprimary";
								/// <java-name>
								/// SECONDARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL = "secondary_email";
								/// <java-name>
								/// SECONDARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL_TYPE = "secondary_email_type";
								/// <java-name>
								/// TERTIARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL = "tertiary_email";
								/// <java-name>
								/// TERTIARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL_TYPE = "tertiary_email_type";
								/// <java-name>
								/// POSTAL
								/// </java-name>
								[Dot42.DexImport("POSTAL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL = "postal";
								/// <java-name>
								/// POSTAL_TYPE
								/// </java-name>
								[Dot42.DexImport("POSTAL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_TYPE = "postal_type";
								/// <java-name>
								/// POSTAL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("POSTAL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_ISPRIMARY = "postal_isprimary";
								/// <java-name>
								/// IM_HANDLE
								/// </java-name>
								[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_HANDLE = "im_handle";
								/// <java-name>
								/// IM_PROTOCOL
								/// </java-name>
								[Dot42.DexImport("IM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_PROTOCOL = "im_protocol";
								/// <java-name>
								/// IM_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("IM_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_ISPRIMARY = "im_isprimary";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Insert() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/Contacts$Intents$UI
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$Intents$UI", AccessFlags = 25)]
						public sealed partial class UI
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// LIST_DEFAULT
								/// </java-name>
								[Dot42.DexImport("LIST_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_DEFAULT = "com.android.contacts.action.LIST_DEFAULT";
								/// <java-name>
								/// LIST_GROUP_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_GROUP_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_GROUP_ACTION = "com.android.contacts.action.LIST_GROUP";
								/// <java-name>
								/// GROUP_NAME_EXTRA_KEY
								/// </java-name>
								[Dot42.DexImport("GROUP_NAME_EXTRA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GROUP_NAME_EXTRA_KEY = "com.android.contacts.extra.GROUP";
								/// <java-name>
								/// LIST_ALL_CONTACTS_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_ALL_CONTACTS_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_ALL_CONTACTS_ACTION = "com.android.contacts.action.LIST_ALL_CONTACTS";
								/// <java-name>
								/// LIST_CONTACTS_WITH_PHONES_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_CONTACTS_WITH_PHONES_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_CONTACTS_WITH_PHONES_ACTION = "com.android.contacts.action.LIST_CONTACTS_WITH_PHONES";
								/// <java-name>
								/// LIST_STARRED_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_STARRED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_STARRED_ACTION = "com.android.contacts.action.LIST_STARRED";
								/// <java-name>
								/// LIST_FREQUENT_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_FREQUENT_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_FREQUENT_ACTION = "com.android.contacts.action.LIST_FREQUENT";
								/// <java-name>
								/// LIST_STREQUENT_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_STREQUENT_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_STREQUENT_ACTION = "com.android.contacts.action.LIST_STREQUENT";
								/// <java-name>
								/// TITLE_EXTRA_KEY
								/// </java-name>
								[Dot42.DexImport("TITLE_EXTRA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE_EXTRA_KEY = "com.android.contacts.extra.TITLE_EXTRA";
								/// <java-name>
								/// FILTER_CONTACTS_ACTION
								/// </java-name>
								[Dot42.DexImport("FILTER_CONTACTS_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FILTER_CONTACTS_ACTION = "com.android.contacts.action.FILTER_CONTACTS";
								/// <java-name>
								/// FILTER_TEXT_EXTRA_KEY
								/// </java-name>
								[Dot42.DexImport("FILTER_TEXT_EXTRA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FILTER_TEXT_EXTRA_KEY = "com.android.contacts.extra.FILTER_TEXT";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public UI() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/provider/Contacts$Extensions
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Extensions", AccessFlags = 25)]
				public sealed partial class Extensions : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IExtensionsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact_extensions";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact_extensions";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "person, name ASC";
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Extensions() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Contacts$ExtensionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ExtensionsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IExtensionsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
				}

				/// <java-name>
				/// android/provider/Contacts$ExtensionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ExtensionsColumns", AccessFlags = 1545)]
				public partial interface IExtensionsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$Photos
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Photos", AccessFlags = 25)]
				public sealed partial class Photos : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPhotosColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "photo";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "person ASC";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Photos() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Contacts$PhotosColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhotosColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhotosColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LOCAL_VERSION
						/// </java-name>
						[Dot42.DexImport("LOCAL_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCAL_VERSION = "local_version";
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						/// <java-name>
						/// DOWNLOAD_REQUIRED
						/// </java-name>
						[Dot42.DexImport("DOWNLOAD_REQUIRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DOWNLOAD_REQUIRED = "download_required";
						/// <java-name>
						/// EXISTS_ON_SERVER
						/// </java-name>
						[Dot42.DexImport("EXISTS_ON_SERVER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXISTS_ON_SERVER = "exists_on_server";
						/// <java-name>
						/// SYNC_ERROR
						/// </java-name>
						[Dot42.DexImport("SYNC_ERROR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_ERROR = "sync_error";
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "data";
				}

				/// <java-name>
				/// android/provider/Contacts$PhotosColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhotosColumns", AccessFlags = 1545)]
				public partial interface IPhotosColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$Organizations
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Organizations", AccessFlags = 25)]
				public sealed partial class Organizations : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IOrganizationColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "organizations";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "company, title, isprimary ASC";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Organizations() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

				}

				/// <java-name>
				/// android/provider/Contacts$OrganizationColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$OrganizationColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IOrganizationColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <java-name>
						/// TYPE_CUSTOM
						/// </java-name>
						[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
						public const int TYPE_CUSTOM = 0;
						/// <java-name>
						/// TYPE_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
						public const int TYPE_WORK = 1;
						/// <java-name>
						/// TYPE_OTHER
						/// </java-name>
						[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
						public const int TYPE_OTHER = 2;
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
						/// <java-name>
						/// COMPANY
						/// </java-name>
						[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COMPANY = "company";
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						/// <java-name>
						/// ISPRIMARY
						/// </java-name>
						[Dot42.DexImport("ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ISPRIMARY = "isprimary";
				}

				/// <java-name>
				/// android/provider/Contacts$OrganizationColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$OrganizationColumns", AccessFlags = 1545)]
				public partial interface IOrganizationColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PresenceColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPresenceColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PRIORITY
						/// </java-name>
						[Dot42.DexImport("PRIORITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIORITY = "priority";
						/// <java-name>
						/// PRESENCE_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_STATUS = "mode";
						/// <java-name>
						/// OFFLINE
						/// </java-name>
						[Dot42.DexImport("OFFLINE", "I", AccessFlags = 25)]
						public const int OFFLINE = 0;
						/// <java-name>
						/// INVISIBLE
						/// </java-name>
						[Dot42.DexImport("INVISIBLE", "I", AccessFlags = 25)]
						public const int INVISIBLE = 1;
						/// <java-name>
						/// AWAY
						/// </java-name>
						[Dot42.DexImport("AWAY", "I", AccessFlags = 25)]
						public const int AWAY = 2;
						/// <java-name>
						/// IDLE
						/// </java-name>
						[Dot42.DexImport("IDLE", "I", AccessFlags = 25)]
						public const int IDLE = 3;
						/// <java-name>
						/// DO_NOT_DISTURB
						/// </java-name>
						[Dot42.DexImport("DO_NOT_DISTURB", "I", AccessFlags = 25)]
						public const int DO_NOT_DISTURB = 4;
						/// <java-name>
						/// AVAILABLE
						/// </java-name>
						[Dot42.DexImport("AVAILABLE", "I", AccessFlags = 25)]
						public const int AVAILABLE = 5;
						/// <java-name>
						/// PRESENCE_CUSTOM_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_CUSTOM_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_CUSTOM_STATUS = "status";
						/// <java-name>
						/// IM_PROTOCOL
						/// </java-name>
						[Dot42.DexImport("IM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_PROTOCOL = "im_protocol";
						/// <java-name>
						/// IM_HANDLE
						/// </java-name>
						[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_HANDLE = "im_handle";
						/// <java-name>
						/// IM_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("IM_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_ACCOUNT = "im_account";
				}

				/// <java-name>
				/// android/provider/Contacts$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PresenceColumns", AccessFlags = 1545)]
				public partial interface IPresenceColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$ContactMethods
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ContactMethods", AccessFlags = 25)]
				public sealed partial class ContactMethods : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IContactMethodsColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// POSTAL_LOCATION_LATITUDE
						/// </java-name>
						[Dot42.DexImport("POSTAL_LOCATION_LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string POSTAL_LOCATION_LATITUDE = "data";
						/// <java-name>
						/// POSTAL_LOCATION_LONGITUDE
						/// </java-name>
						[Dot42.DexImport("POSTAL_LOCATION_LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string POSTAL_LOCATION_LONGITUDE = "aux_data";
						/// <java-name>
						/// PROTOCOL_AIM
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_AIM", "I", AccessFlags = 25)]
						public const int PROTOCOL_AIM = 0;
						/// <java-name>
						/// PROTOCOL_MSN
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_MSN", "I", AccessFlags = 25)]
						public const int PROTOCOL_MSN = 1;
						/// <java-name>
						/// PROTOCOL_YAHOO
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_YAHOO", "I", AccessFlags = 25)]
						public const int PROTOCOL_YAHOO = 2;
						/// <java-name>
						/// PROTOCOL_SKYPE
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_SKYPE", "I", AccessFlags = 25)]
						public const int PROTOCOL_SKYPE = 3;
						/// <java-name>
						/// PROTOCOL_QQ
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_QQ", "I", AccessFlags = 25)]
						public const int PROTOCOL_QQ = 4;
						/// <java-name>
						/// PROTOCOL_GOOGLE_TALK
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_GOOGLE_TALK", "I", AccessFlags = 25)]
						public const int PROTOCOL_GOOGLE_TALK = 5;
						/// <java-name>
						/// PROTOCOL_ICQ
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_ICQ", "I", AccessFlags = 25)]
						public const int PROTOCOL_ICQ = 6;
						/// <java-name>
						/// PROTOCOL_JABBER
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_JABBER", "I", AccessFlags = 25)]
						public const int PROTOCOL_JABBER = 7;
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_EMAIL_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_EMAIL_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_EMAIL_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact-methods";
						/// <java-name>
						/// CONTENT_EMAIL_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_EMAIL_TYPE = "vnd.android.cursor.dir/email";
						/// <java-name>
						/// CONTENT_POSTAL_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_POSTAL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_POSTAL_TYPE = "vnd.android.cursor.dir/postal-address";
						/// <java-name>
						/// CONTENT_EMAIL_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_EMAIL_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_EMAIL_ITEM_TYPE = "vnd.android.cursor.item/email";
						/// <java-name>
						/// CONTENT_POSTAL_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_POSTAL_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_POSTAL_ITEM_TYPE = "vnd.android.cursor.item/postal-address";
						/// <java-name>
						/// CONTENT_IM_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_IM_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_IM_ITEM_TYPE = "vnd.android.cursor.item/jabber-im";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal ContactMethods() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// encodePredefinedImProtocol
						/// </java-name>
						[Dot42.DexImport("encodePredefinedImProtocol", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string EncodePredefinedImProtocol(int int32) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// encodeCustomImProtocol
						/// </java-name>
						[Dot42.DexImport("encodeCustomImProtocol", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
						public static string EncodeCustomImProtocol(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// decodeImProtocol
						/// </java-name>
						[Dot42.DexImport("decodeImProtocol", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 9)]
						public static object DecodeImProtocol(string @string) /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;IILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int int32, int int321, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// addPostalLocation
						/// </java-name>
						[Dot42.DexImport("addPostalLocation", "(Landroid/content/Context;JDD)V", AccessFlags = 1)]
						public void AddPostalLocation(global::Android.Content.Context context, long int64, double @double, double double1) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Contacts$ContactMethodsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ContactMethodsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactMethodsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// KIND
						/// </java-name>
						[Dot42.DexImport("KIND", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KIND = "kind";
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <java-name>
						/// TYPE_CUSTOM
						/// </java-name>
						[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
						public const int TYPE_CUSTOM = 0;
						/// <java-name>
						/// TYPE_HOME
						/// </java-name>
						[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
						public const int TYPE_HOME = 1;
						/// <java-name>
						/// TYPE_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
						public const int TYPE_WORK = 2;
						/// <java-name>
						/// TYPE_OTHER
						/// </java-name>
						[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
						public const int TYPE_OTHER = 3;
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "data";
						/// <java-name>
						/// AUX_DATA
						/// </java-name>
						[Dot42.DexImport("AUX_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUX_DATA = "aux_data";
						/// <java-name>
						/// ISPRIMARY
						/// </java-name>
						[Dot42.DexImport("ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ISPRIMARY = "isprimary";
				}

				/// <java-name>
				/// android/provider/Contacts$ContactMethodsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ContactMethodsColumns", AccessFlags = 1545)]
				public partial interface IContactMethodsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$GroupMembership
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$GroupMembership", AccessFlags = 25)]
				public sealed partial class GroupMembership : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IGroupsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// RAW_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("RAW_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri RAW_CONTENT_URI;
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "groupmembership";
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contactsgroupmembership";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contactsgroupmembership";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "group_id ASC";
						/// <java-name>
						/// GROUP_ID
						/// </java-name>
						[Dot42.DexImport("GROUP_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_ID = "group_id";
						/// <java-name>
						/// GROUP_SYNC_ID
						/// </java-name>
						[Dot42.DexImport("GROUP_SYNC_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_SYNC_ID = "group_sync_id";
						/// <java-name>
						/// GROUP_SYNC_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("GROUP_SYNC_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_SYNC_ACCOUNT = "group_sync_account";
						/// <java-name>
						/// GROUP_SYNC_ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("GROUP_SYNC_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_SYNC_ACCOUNT_TYPE = "group_sync_account_type";
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal GroupMembership() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Contacts$Phones
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Phones", AccessFlags = 25)]
				public sealed partial class Phones : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPhonesColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_FILTER_URL
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URL", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URL;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/phone";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/phone";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Phones() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljav" +
    "a/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int int32, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence[] charSequence1) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

				}

				/// <java-name>
				/// android/provider/Contacts$PhonesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhonesColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhonesColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <java-name>
						/// TYPE_CUSTOM
						/// </java-name>
						[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
						public const int TYPE_CUSTOM = 0;
						/// <java-name>
						/// TYPE_HOME
						/// </java-name>
						[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
						public const int TYPE_HOME = 1;
						/// <java-name>
						/// TYPE_MOBILE
						/// </java-name>
						[Dot42.DexImport("TYPE_MOBILE", "I", AccessFlags = 25)]
						public const int TYPE_MOBILE = 2;
						/// <java-name>
						/// TYPE_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
						public const int TYPE_WORK = 3;
						/// <java-name>
						/// TYPE_FAX_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_FAX_WORK", "I", AccessFlags = 25)]
						public const int TYPE_FAX_WORK = 4;
						/// <java-name>
						/// TYPE_FAX_HOME
						/// </java-name>
						[Dot42.DexImport("TYPE_FAX_HOME", "I", AccessFlags = 25)]
						public const int TYPE_FAX_HOME = 5;
						/// <java-name>
						/// TYPE_PAGER
						/// </java-name>
						[Dot42.DexImport("TYPE_PAGER", "I", AccessFlags = 25)]
						public const int TYPE_PAGER = 6;
						/// <java-name>
						/// TYPE_OTHER
						/// </java-name>
						[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
						public const int TYPE_OTHER = 7;
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <java-name>
						/// NUMBER_KEY
						/// </java-name>
						[Dot42.DexImport("NUMBER_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER_KEY = "number_key";
						/// <java-name>
						/// ISPRIMARY
						/// </java-name>
						[Dot42.DexImport("ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ISPRIMARY = "isprimary";
				}

				/// <java-name>
				/// android/provider/Contacts$PhonesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhonesColumns", AccessFlags = 1545)]
				public partial interface IPhonesColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$Groups
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Groups", AccessFlags = 25)]
				public sealed partial class Groups : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IGroupsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// DELETED_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("DELETED_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DELETED_CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contactsgroup";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contactsgroup";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <java-name>
						/// GROUP_ANDROID_STARRED
						/// </java-name>
						[Dot42.DexImport("GROUP_ANDROID_STARRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_ANDROID_STARRED = "Starred in Android";
						/// <java-name>
						/// GROUP_MY_CONTACTS
						/// </java-name>
						[Dot42.DexImport("GROUP_MY_CONTACTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_MY_CONTACTS = "Contacts";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Groups() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Contacts$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$GroupsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IGroupsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <java-name>
						/// NOTES
						/// </java-name>
						[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTES = "notes";
						/// <java-name>
						/// SHOULD_SYNC
						/// </java-name>
						[Dot42.DexImport("SHOULD_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOULD_SYNC = "should_sync";
						/// <java-name>
						/// SYSTEM_ID
						/// </java-name>
						[Dot42.DexImport("SYSTEM_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYSTEM_ID = "system_id";
				}

				/// <java-name>
				/// android/provider/Contacts$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$GroupsColumns", AccessFlags = 1545)]
				public partial interface IGroupsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$People
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$People", AccessFlags = 25)]
				public sealed partial class People : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPeopleColumns, global::Android.Provider.Contacts.IPhonesColumns, global::Android.Provider.Contacts.IPresenceColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						/// <java-name>
						/// DELETED_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("DELETED_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DELETED_CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/person";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/person";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <java-name>
						/// PRIMARY_PHONE_ID
						/// </java-name>
						[Dot42.DexImport("PRIMARY_PHONE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIMARY_PHONE_ID = "primary_phone";
						/// <java-name>
						/// PRIMARY_EMAIL_ID
						/// </java-name>
						[Dot42.DexImport("PRIMARY_EMAIL_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIMARY_EMAIL_ID = "primary_email";
						/// <java-name>
						/// PRIMARY_ORGANIZATION_ID
						/// </java-name>
						[Dot42.DexImport("PRIMARY_ORGANIZATION_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIMARY_ORGANIZATION_ID = "primary_organization";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal People() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// markAsContacted
						/// </java-name>
						[Dot42.DexImport("markAsContacted", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
						public static void MarkAsContacted(global::Android.Content.ContentResolver contentResolver, long int64) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// addToMyContactsGroup
						/// </java-name>
						[Dot42.DexImport("addToMyContactsGroup", "(Landroid/content/ContentResolver;J)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri AddToMyContactsGroup(global::Android.Content.ContentResolver contentResolver, long int64) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// addToGroup
						/// </java-name>
						[Dot42.DexImport("addToGroup", "(Landroid/content/ContentResolver;JLjava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri AddToGroup(global::Android.Content.ContentResolver contentResolver, long int64, string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// addToGroup
						/// </java-name>
						[Dot42.DexImport("addToGroup", "(Landroid/content/ContentResolver;JJ)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri AddToGroup(global::Android.Content.ContentResolver contentResolver, long int64, long int641) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// createPersonInMyContactsGroup
						/// </java-name>
						[Dot42.DexImport("createPersonInMyContactsGroup", "(Landroid/content/ContentResolver;Landroid/content/ContentValues;)Landroid/net/Ur" +
    "i;", AccessFlags = 9)]
						public static global::Android.Net.Uri CreatePersonInMyContactsGroup(global::Android.Content.ContentResolver contentResolver, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// queryGroups
						/// </java-name>
						[Dot42.DexImport("queryGroups", "(Landroid/content/ContentResolver;J)Landroid/database/Cursor;", AccessFlags = 9)]
						public static global::Android.Database.ICursor QueryGroups(global::Android.Content.ContentResolver contentResolver, long int64) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

						/// <java-name>
						/// setPhotoData
						/// </java-name>
						[Dot42.DexImport("setPhotoData", "(Landroid/content/ContentResolver;Landroid/net/Uri;[B)V", AccessFlags = 9)]
						public static void SetPhotoData(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setPhotoData
						/// </java-name>
						[Dot42.DexImport("setPhotoData", "(Landroid/content/ContentResolver;Landroid/net/Uri;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void SetPhotoData(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// openContactPhotoInputStream
						/// </java-name>
						[Dot42.DexImport("openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;", AccessFlags = 9)]
						public static global::Java.Io.InputStream OpenContactPhotoInputStream(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.InputStream);
						}

						/// <java-name>
						/// loadContactPhoto
						/// </java-name>
						[Dot42.DexImport("loadContactPhoto", "(Landroid/content/Context;Landroid/net/Uri;ILandroid/graphics/BitmapFactory$Optio" +
    "ns;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
						public static global::Android.Graphics.Bitmap LoadContactPhoto(global::Android.Content.Context context, global::Android.Net.Uri uri, int int32, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Bitmap);
						}

						/// <java-name>
						/// android/provider/Contacts$People$Extensions
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$People$Extensions", AccessFlags = 9)]
						public partial class Extensions : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IExtensionsColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "extensions";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "name ASC";
								/// <java-name>
								/// PERSON_ID
								/// </java-name>
								[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PERSON_ID = "person";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Extensions() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/Contacts$People$ContactMethods
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$People$ContactMethods", AccessFlags = 25)]
						public sealed partial class ContactMethods : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IContactMethodsColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "contact_methods";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "data ASC";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal ContactMethods() /* MethodBuilder.Create */ 
								{
								}

						}

						/// <java-name>
						/// android/provider/Contacts$People$Phones
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$People$Phones", AccessFlags = 25)]
						public sealed partial class Phones : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPhonesColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "phones";
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "number ASC";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Phones() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/provider/Contacts$PeopleColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PeopleColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPeopleColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <java-name>
						/// PHONETIC_NAME
						/// </java-name>
						[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONETIC_NAME = "phonetic_name";
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "display_name";
						/// <java-name>
						/// NOTES
						/// </java-name>
						[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTES = "notes";
						/// <java-name>
						/// TIMES_CONTACTED
						/// </java-name>
						[Dot42.DexImport("TIMES_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMES_CONTACTED = "times_contacted";
						/// <java-name>
						/// LAST_TIME_CONTACTED
						/// </java-name>
						[Dot42.DexImport("LAST_TIME_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LAST_TIME_CONTACTED = "last_time_contacted";
						/// <java-name>
						/// CUSTOM_RINGTONE
						/// </java-name>
						[Dot42.DexImport("CUSTOM_RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CUSTOM_RINGTONE = "custom_ringtone";
						/// <java-name>
						/// SEND_TO_VOICEMAIL
						/// </java-name>
						[Dot42.DexImport("SEND_TO_VOICEMAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEND_TO_VOICEMAIL = "send_to_voicemail";
						/// <java-name>
						/// STARRED
						/// </java-name>
						[Dot42.DexImport("STARRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STARRED = "starred";
						/// <java-name>
						/// PHOTO_VERSION
						/// </java-name>
						[Dot42.DexImport("PHOTO_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_VERSION = "photo_version";
				}

				/// <java-name>
				/// android/provider/Contacts$PeopleColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PeopleColumns", AccessFlags = 1545)]
				public partial interface IPeopleColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// android/provider/Contacts$Settings
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Settings", AccessFlags = 25)]
				public sealed partial class Settings : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.ISettingsColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "settings";
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "key ASC";
						/// <java-name>
						/// SYNC_EVERYTHING
						/// </java-name>
						[Dot42.DexImport("SYNC_EVERYTHING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_EVERYTHING = "syncEverything";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Settings() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getSetting
						/// </java-name>
						[Dot42.DexImport("getSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Ljava/lang" +
    "/String;", AccessFlags = 9)]
						public static string GetSetting(global::Android.Content.ContentResolver contentResolver, string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// setSetting
						/// </java-name>
						[Dot42.DexImport("setSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/" +
    "String;)V", AccessFlags = 9)]
						public static void SetSetting(global::Android.Content.ContentResolver contentResolver, string @string, string string1, string string2) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Contacts$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$SettingsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISettingsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// _SYNC_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("_SYNC_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string _SYNC_ACCOUNT = "_sync_account";
						/// <java-name>
						/// _SYNC_ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("_SYNC_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string _SYNC_ACCOUNT_TYPE = "_sync_account_type";
						/// <java-name>
						/// KEY
						/// </java-name>
						[Dot42.DexImport("KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY = "key";
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
				}

				/// <java-name>
				/// android/provider/Contacts$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$SettingsColumns", AccessFlags = 1545)]
				public partial interface ISettingsColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <java-name>
		/// android/provider/OpenableColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/OpenableColumns", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IOpenableColumnsConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DISPLAY_NAME
				/// </java-name>
				[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DISPLAY_NAME = "_display_name";
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SIZE = "_size";
		}

		/// <java-name>
		/// android/provider/OpenableColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/OpenableColumns", AccessFlags = 1537)]
		public partial interface IOpenableColumns
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/provider/Settings
		/// </java-name>
		[Dot42.DexImport("android/provider/Settings", AccessFlags = 49)]
		public sealed partial class Settings
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SETTINGS = "android.settings.SETTINGS";
				/// <java-name>
				/// ACTION_APN_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APN_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APN_SETTINGS = "android.settings.APN_SETTINGS";
				/// <java-name>
				/// ACTION_LOCATION_SOURCE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCATION_SOURCE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCATION_SOURCE_SETTINGS = "android.settings.LOCATION_SOURCE_SETTINGS";
				/// <java-name>
				/// ACTION_WIRELESS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_WIRELESS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WIRELESS_SETTINGS = "android.settings.WIRELESS_SETTINGS";
				/// <java-name>
				/// ACTION_AIRPLANE_MODE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_AIRPLANE_MODE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AIRPLANE_MODE_SETTINGS = "android.settings.AIRPLANE_MODE_SETTINGS";
				/// <java-name>
				/// ACTION_ACCESSIBILITY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_ACCESSIBILITY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACCESSIBILITY_SETTINGS = "android.settings.ACCESSIBILITY_SETTINGS";
				/// <java-name>
				/// ACTION_SECURITY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SECURITY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SECURITY_SETTINGS = "android.settings.SECURITY_SETTINGS";
				/// <java-name>
				/// ACTION_PRIVACY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_PRIVACY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PRIVACY_SETTINGS = "android.settings.PRIVACY_SETTINGS";
				/// <java-name>
				/// ACTION_WIFI_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_WIFI_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WIFI_SETTINGS = "android.settings.WIFI_SETTINGS";
				/// <java-name>
				/// ACTION_WIFI_IP_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_WIFI_IP_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WIFI_IP_SETTINGS = "android.settings.WIFI_IP_SETTINGS";
				/// <java-name>
				/// ACTION_BLUETOOTH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_BLUETOOTH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BLUETOOTH_SETTINGS = "android.settings.BLUETOOTH_SETTINGS";
				/// <java-name>
				/// ACTION_DATE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DATE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DATE_SETTINGS = "android.settings.DATE_SETTINGS";
				/// <java-name>
				/// ACTION_SOUND_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SOUND_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SOUND_SETTINGS = "android.settings.SOUND_SETTINGS";
				/// <java-name>
				/// ACTION_DISPLAY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DISPLAY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISPLAY_SETTINGS = "android.settings.DISPLAY_SETTINGS";
				/// <java-name>
				/// ACTION_LOCALE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCALE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCALE_SETTINGS = "android.settings.LOCALE_SETTINGS";
				/// <java-name>
				/// ACTION_INPUT_METHOD_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_INPUT_METHOD_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INPUT_METHOD_SETTINGS = "android.settings.INPUT_METHOD_SETTINGS";
				/// <java-name>
				/// ACTION_INPUT_METHOD_SUBTYPE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_INPUT_METHOD_SUBTYPE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INPUT_METHOD_SUBTYPE_SETTINGS = "android.settings.INPUT_METHOD_SUBTYPE_SETTINGS";
				/// <java-name>
				/// ACTION_USER_DICTIONARY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_USER_DICTIONARY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USER_DICTIONARY_SETTINGS = "android.settings.USER_DICTIONARY_SETTINGS";
				/// <java-name>
				/// ACTION_APPLICATION_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APPLICATION_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPLICATION_SETTINGS = "android.settings.APPLICATION_SETTINGS";
				/// <java-name>
				/// ACTION_APPLICATION_DEVELOPMENT_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APPLICATION_DEVELOPMENT_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPLICATION_DEVELOPMENT_SETTINGS = "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
				/// <java-name>
				/// ACTION_QUICK_LAUNCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_QUICK_LAUNCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_QUICK_LAUNCH_SETTINGS = "android.settings.QUICK_LAUNCH_SETTINGS";
				/// <java-name>
				/// ACTION_MANAGE_APPLICATIONS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_APPLICATIONS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_APPLICATIONS_SETTINGS = "android.settings.MANAGE_APPLICATIONS_SETTINGS";
				/// <java-name>
				/// ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS = "android.settings.MANAGE_ALL_APPLICATIONS_SETTINGS";
				/// <java-name>
				/// ACTION_APPLICATION_DETAILS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APPLICATION_DETAILS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPLICATION_DETAILS_SETTINGS = "android.settings.APPLICATION_DETAILS_SETTINGS";
				/// <java-name>
				/// ACTION_SYNC_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SYNC_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SYNC_SETTINGS = "android.settings.SYNC_SETTINGS";
				/// <java-name>
				/// ACTION_ADD_ACCOUNT
				/// </java-name>
				[Dot42.DexImport("ACTION_ADD_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ADD_ACCOUNT = "android.settings.ADD_ACCOUNT_SETTINGS";
				/// <java-name>
				/// ACTION_NETWORK_OPERATOR_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_NETWORK_OPERATOR_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NETWORK_OPERATOR_SETTINGS = "android.settings.NETWORK_OPERATOR_SETTINGS";
				/// <java-name>
				/// ACTION_DATA_ROAMING_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DATA_ROAMING_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DATA_ROAMING_SETTINGS = "android.settings.DATA_ROAMING_SETTINGS";
				/// <java-name>
				/// ACTION_INTERNAL_STORAGE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_INTERNAL_STORAGE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INTERNAL_STORAGE_SETTINGS = "android.settings.INTERNAL_STORAGE_SETTINGS";
				/// <java-name>
				/// ACTION_MEMORY_CARD_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_MEMORY_CARD_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEMORY_CARD_SETTINGS = "android.settings.MEMORY_CARD_SETTINGS";
				/// <java-name>
				/// ACTION_SEARCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SEARCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEARCH_SETTINGS = "android.search.action.SEARCH_SETTINGS";
				/// <java-name>
				/// ACTION_DEVICE_INFO_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_INFO_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_INFO_SETTINGS = "android.settings.DEVICE_INFO_SETTINGS";
				/// <java-name>
				/// ACTION_NFCSHARING_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_NFCSHARING_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NFCSHARING_SETTINGS = "android.settings.NFCSHARING_SETTINGS";
				/// <java-name>
				/// EXTRA_AUTHORITIES
				/// </java-name>
				[Dot42.DexImport("EXTRA_AUTHORITIES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_AUTHORITIES = "authorities";
				/// <java-name>
				/// EXTRA_INPUT_METHOD_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_INPUT_METHOD_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INPUT_METHOD_ID = "input_method_id";
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "settings";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Settings() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/Settings$Secure
				/// </java-name>
				[Dot42.DexImport("android/provider/Settings$Secure", AccessFlags = 25)]
				public sealed partial class Secure : global::Android.Provider.Settings.NameValueTable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SYS_PROP_SETTING_VERSION
						/// </java-name>
						[Dot42.DexImport("SYS_PROP_SETTING_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYS_PROP_SETTING_VERSION = "sys.settings_secure_version";
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// ADB_ENABLED
						/// </java-name>
						[Dot42.DexImport("ADB_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ADB_ENABLED = "adb_enabled";
						/// <java-name>
						/// ALLOW_MOCK_LOCATION
						/// </java-name>
						[Dot42.DexImport("ALLOW_MOCK_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOW_MOCK_LOCATION = "mock_location";
						/// <java-name>
						/// ANDROID_ID
						/// </java-name>
						[Dot42.DexImport("ANDROID_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANDROID_ID = "android_id";
						/// <java-name>
						/// BLUETOOTH_ON
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_ON = "bluetooth_on";
						/// <java-name>
						/// DATA_ROAMING
						/// </java-name>
						[Dot42.DexImport("DATA_ROAMING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ROAMING = "data_roaming";
						/// <java-name>
						/// DEFAULT_INPUT_METHOD
						/// </java-name>
						[Dot42.DexImport("DEFAULT_INPUT_METHOD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_INPUT_METHOD = "default_input_method";
						/// <java-name>
						/// SELECTED_INPUT_METHOD_SUBTYPE
						/// </java-name>
						[Dot42.DexImport("SELECTED_INPUT_METHOD_SUBTYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SELECTED_INPUT_METHOD_SUBTYPE = "selected_input_method_subtype";
						/// <java-name>
						/// INPUT_METHOD_SELECTOR_VISIBILITY
						/// </java-name>
						[Dot42.DexImport("INPUT_METHOD_SELECTOR_VISIBILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INPUT_METHOD_SELECTOR_VISIBILITY = "input_method_selector_visibility";
						/// <java-name>
						/// DEVICE_PROVISIONED
						/// </java-name>
						[Dot42.DexImport("DEVICE_PROVISIONED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEVICE_PROVISIONED = "device_provisioned";
						/// <java-name>
						/// ENABLED_INPUT_METHODS
						/// </java-name>
						[Dot42.DexImport("ENABLED_INPUT_METHODS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ENABLED_INPUT_METHODS = "enabled_input_methods";
						/// <java-name>
						/// HTTP_PROXY
						/// </java-name>
						[Dot42.DexImport("HTTP_PROXY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HTTP_PROXY = "http_proxy";
						/// <java-name>
						/// INSTALL_NON_MARKET_APPS
						/// </java-name>
						[Dot42.DexImport("INSTALL_NON_MARKET_APPS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INSTALL_NON_MARKET_APPS = "install_non_market_apps";
						/// <java-name>
						/// LOCATION_PROVIDERS_ALLOWED
						/// </java-name>
						[Dot42.DexImport("LOCATION_PROVIDERS_ALLOWED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCATION_PROVIDERS_ALLOWED = "location_providers_allowed";
						/// <java-name>
						/// LOCK_PATTERN_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_ENABLED = "lock_pattern_autolock";
						/// <java-name>
						/// LOCK_PATTERN_VISIBLE
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_VISIBLE = "lock_pattern_visible_pattern";
						/// <java-name>
						/// LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED = "lock_pattern_tactile_feedback_enabled";
						/// <java-name>
						/// LOGGING_ID
						/// </java-name>
						[Dot42.DexImport("LOGGING_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOGGING_ID = "logging_id";
						/// <java-name>
						/// NETWORK_PREFERENCE
						/// </java-name>
						[Dot42.DexImport("NETWORK_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NETWORK_PREFERENCE = "network_preference";
						/// <java-name>
						/// PARENTAL_CONTROL_ENABLED
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_ENABLED = "parental_control_enabled";
						/// <java-name>
						/// PARENTAL_CONTROL_LAST_UPDATE
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_LAST_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_LAST_UPDATE = "parental_control_last_update";
						/// <java-name>
						/// PARENTAL_CONTROL_REDIRECT_URL
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_REDIRECT_URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_REDIRECT_URL = "parental_control_redirect_url";
						/// <java-name>
						/// SETTINGS_CLASSNAME
						/// </java-name>
						[Dot42.DexImport("SETTINGS_CLASSNAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETTINGS_CLASSNAME = "settings_classname";
						/// <java-name>
						/// USB_MASS_STORAGE_ENABLED
						/// </java-name>
						[Dot42.DexImport("USB_MASS_STORAGE_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USB_MASS_STORAGE_ENABLED = "usb_mass_storage_enabled";
						/// <java-name>
						/// USE_GOOGLE_MAIL
						/// </java-name>
						[Dot42.DexImport("USE_GOOGLE_MAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USE_GOOGLE_MAIL = "use_google_mail";
						/// <java-name>
						/// ACCESSIBILITY_ENABLED
						/// </java-name>
						[Dot42.DexImport("ACCESSIBILITY_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESSIBILITY_ENABLED = "accessibility_enabled";
						/// <java-name>
						/// TOUCH_EXPLORATION_ENABLED
						/// </java-name>
						[Dot42.DexImport("TOUCH_EXPLORATION_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TOUCH_EXPLORATION_ENABLED = "touch_exploration_enabled";
						/// <java-name>
						/// ENABLED_ACCESSIBILITY_SERVICES
						/// </java-name>
						[Dot42.DexImport("ENABLED_ACCESSIBILITY_SERVICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ENABLED_ACCESSIBILITY_SERVICES = "enabled_accessibility_services";
						/// <java-name>
						/// ACCESSIBILITY_SPEAK_PASSWORD
						/// </java-name>
						[Dot42.DexImport("ACCESSIBILITY_SPEAK_PASSWORD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESSIBILITY_SPEAK_PASSWORD = "speak_password";
						/// <java-name>
						/// TTS_USE_DEFAULTS
						/// </java-name>
						[Dot42.DexImport("TTS_USE_DEFAULTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_USE_DEFAULTS = "tts_use_defaults";
						/// <java-name>
						/// TTS_DEFAULT_RATE
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_RATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_RATE = "tts_default_rate";
						/// <java-name>
						/// TTS_DEFAULT_PITCH
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_PITCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_PITCH = "tts_default_pitch";
						/// <java-name>
						/// TTS_DEFAULT_SYNTH
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_SYNTH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_SYNTH = "tts_default_synth";
						/// <java-name>
						/// TTS_DEFAULT_LANG
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_LANG", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_LANG = "tts_default_lang";
						/// <java-name>
						/// TTS_DEFAULT_COUNTRY
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_COUNTRY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_COUNTRY = "tts_default_country";
						/// <java-name>
						/// TTS_DEFAULT_VARIANT
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_VARIANT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_VARIANT = "tts_default_variant";
						/// <java-name>
						/// TTS_ENABLED_PLUGINS
						/// </java-name>
						[Dot42.DexImport("TTS_ENABLED_PLUGINS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_ENABLED_PLUGINS = "tts_enabled_plugins";
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON = "wifi_networks_available_notification_on";
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY = "wifi_networks_available_repeat_delay";
						/// <java-name>
						/// WIFI_NUM_OPEN_NETWORKS_KEPT
						/// </java-name>
						[Dot42.DexImport("WIFI_NUM_OPEN_NETWORKS_KEPT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NUM_OPEN_NETWORKS_KEPT = "wifi_num_open_networks_kept";
						/// <java-name>
						/// WIFI_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_ON = "wifi_on";
						/// <java-name>
						/// WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE = "wifi_watchdog_acceptable_packet_loss_percentage";
						/// <java-name>
						/// WIFI_WATCHDOG_AP_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_AP_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_AP_COUNT = "wifi_watchdog_ap_count";
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS = "wifi_watchdog_background_check_delay_ms";
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED = "wifi_watchdog_background_check_enabled";
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS = "wifi_watchdog_background_check_timeout_ms";
						/// <java-name>
						/// WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT = "wifi_watchdog_initial_ignored_ping_count";
						/// <java-name>
						/// WIFI_WATCHDOG_MAX_AP_CHECKS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_MAX_AP_CHECKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_MAX_AP_CHECKS = "wifi_watchdog_max_ap_checks";
						/// <java-name>
						/// WIFI_WATCHDOG_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ON = "wifi_watchdog_on";
						/// <java-name>
						/// WIFI_WATCHDOG_WATCH_LIST
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_WATCH_LIST", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_WATCH_LIST = "wifi_watchdog_watch_list";
						/// <java-name>
						/// WIFI_WATCHDOG_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_COUNT = "wifi_watchdog_ping_count";
						/// <java-name>
						/// WIFI_WATCHDOG_PING_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_DELAY_MS = "wifi_watchdog_ping_delay_ms";
						/// <java-name>
						/// WIFI_WATCHDOG_PING_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_TIMEOUT_MS = "wifi_watchdog_ping_timeout_ms";
						/// <java-name>
						/// WIFI_MAX_DHCP_RETRY_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_MAX_DHCP_RETRY_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MAX_DHCP_RETRY_COUNT = "wifi_max_dhcp_retry_count";
						/// <java-name>
						/// WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS = "wifi_mobile_data_transition_wakelock_timeout_ms";
						/// <java-name>
						/// BACKGROUND_DATA
						/// </java-name>
						[Dot42.DexImport("BACKGROUND_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BACKGROUND_DATA = "background_data";
						/// <java-name>
						/// ALLOWED_GEOLOCATION_ORIGINS
						/// </java-name>
						[Dot42.DexImport("ALLOWED_GEOLOCATION_ORIGINS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOWED_GEOLOCATION_ORIGINS = "allowed_geolocation_origins";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Secure() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getString
						/// </java-name>
						[Dot42.DexImport("getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 41)]
						public static string GetString(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// putString
						/// </java-name>
						[Dot42.DexImport("putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
						public static bool PutString(global::Android.Content.ContentResolver contentResolver, string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getUriFor
						/// </java-name>
						[Dot42.DexImport("getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetUriFor(string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver contentResolver, string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// putInt
						/// </java-name>
						[Dot42.DexImport("putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z", AccessFlags = 9)]
						public static bool PutInt(global::Android.Content.ContentResolver contentResolver, string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver contentResolver, string @string, long int64) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// putLong
						/// </java-name>
						[Dot42.DexImport("putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z", AccessFlags = 9)]
						public static bool PutLong(global::Android.Content.ContentResolver contentResolver, string @string, long int64) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver contentResolver, string @string, float single) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// putFloat
						/// </java-name>
						[Dot42.DexImport("putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z", AccessFlags = 9)]
						public static bool PutFloat(global::Android.Content.ContentResolver contentResolver, string @string, float single) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// isLocationProviderEnabled
						/// </java-name>
						[Dot42.DexImport("isLocationProviderEnabled", "(Landroid/content/ContentResolver;Ljava/lang/String;)Z", AccessFlags = 25)]
						public static bool IsLocationProviderEnabled(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// setLocationProviderEnabled
						/// </java-name>
						[Dot42.DexImport("setLocationProviderEnabled", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V", AccessFlags = 25)]
						public static void SetLocationProviderEnabled(global::Android.Content.ContentResolver contentResolver, string @string, bool boolean) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Settings$System
				/// </java-name>
				[Dot42.DexImport("android/provider/Settings$System", AccessFlags = 25)]
				public sealed partial class System : global::Android.Provider.Settings.NameValueTable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SYS_PROP_SETTING_VERSION
						/// </java-name>
						[Dot42.DexImport("SYS_PROP_SETTING_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYS_PROP_SETTING_VERSION = "sys.settings_system_version";
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// STAY_ON_WHILE_PLUGGED_IN
						/// </java-name>
						[Dot42.DexImport("STAY_ON_WHILE_PLUGGED_IN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STAY_ON_WHILE_PLUGGED_IN = "stay_on_while_plugged_in";
						/// <java-name>
						/// END_BUTTON_BEHAVIOR
						/// </java-name>
						[Dot42.DexImport("END_BUTTON_BEHAVIOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string END_BUTTON_BEHAVIOR = "end_button_behavior";
						/// <java-name>
						/// AIRPLANE_MODE_ON
						/// </java-name>
						[Dot42.DexImport("AIRPLANE_MODE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AIRPLANE_MODE_ON = "airplane_mode_on";
						/// <java-name>
						/// RADIO_BLUETOOTH
						/// </java-name>
						[Dot42.DexImport("RADIO_BLUETOOTH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_BLUETOOTH = "bluetooth";
						/// <java-name>
						/// RADIO_WIFI
						/// </java-name>
						[Dot42.DexImport("RADIO_WIFI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_WIFI = "wifi";
						/// <java-name>
						/// RADIO_CELL
						/// </java-name>
						[Dot42.DexImport("RADIO_CELL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_CELL = "cell";
						/// <java-name>
						/// RADIO_NFC
						/// </java-name>
						[Dot42.DexImport("RADIO_NFC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_NFC = "nfc";
						/// <java-name>
						/// AIRPLANE_MODE_RADIOS
						/// </java-name>
						[Dot42.DexImport("AIRPLANE_MODE_RADIOS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AIRPLANE_MODE_RADIOS = "airplane_mode_radios";
						/// <java-name>
						/// WIFI_SLEEP_POLICY
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_SLEEP_POLICY = "wifi_sleep_policy";
						/// <java-name>
						/// WIFI_SLEEP_POLICY_DEFAULT
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY_DEFAULT", "I", AccessFlags = 25)]
						public const int WIFI_SLEEP_POLICY_DEFAULT = 0;
						/// <java-name>
						/// WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED", "I", AccessFlags = 25)]
						public const int WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED = 1;
						/// <java-name>
						/// WIFI_SLEEP_POLICY_NEVER
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY_NEVER", "I", AccessFlags = 25)]
						public const int WIFI_SLEEP_POLICY_NEVER = 2;
						/// <java-name>
						/// WIFI_USE_STATIC_IP
						/// </java-name>
						[Dot42.DexImport("WIFI_USE_STATIC_IP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_USE_STATIC_IP = "wifi_use_static_ip";
						/// <java-name>
						/// WIFI_STATIC_IP
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_IP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_IP = "wifi_static_ip";
						/// <java-name>
						/// WIFI_STATIC_GATEWAY
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_GATEWAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_GATEWAY = "wifi_static_gateway";
						/// <java-name>
						/// WIFI_STATIC_NETMASK
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_NETMASK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_NETMASK = "wifi_static_netmask";
						/// <java-name>
						/// WIFI_STATIC_DNS1
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_DNS1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_DNS1 = "wifi_static_dns1";
						/// <java-name>
						/// WIFI_STATIC_DNS2
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_DNS2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_DNS2 = "wifi_static_dns2";
						/// <java-name>
						/// BLUETOOTH_DISCOVERABILITY
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_DISCOVERABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_DISCOVERABILITY = "bluetooth_discoverability";
						/// <java-name>
						/// BLUETOOTH_DISCOVERABILITY_TIMEOUT
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_DISCOVERABILITY_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_DISCOVERABILITY_TIMEOUT = "bluetooth_discoverability_timeout";
						/// <java-name>
						/// LOCK_PATTERN_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_ENABLED = "lock_pattern_autolock";
						/// <java-name>
						/// LOCK_PATTERN_VISIBLE
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_VISIBLE = "lock_pattern_visible_pattern";
						/// <java-name>
						/// LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED = "lock_pattern_tactile_feedback_enabled";
						/// <java-name>
						/// NEXT_ALARM_FORMATTED
						/// </java-name>
						[Dot42.DexImport("NEXT_ALARM_FORMATTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NEXT_ALARM_FORMATTED = "next_alarm_formatted";
						/// <java-name>
						/// FONT_SCALE
						/// </java-name>
						[Dot42.DexImport("FONT_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FONT_SCALE = "font_scale";
						/// <java-name>
						/// DEBUG_APP
						/// </java-name>
						[Dot42.DexImport("DEBUG_APP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEBUG_APP = "debug_app";
						/// <java-name>
						/// WAIT_FOR_DEBUGGER
						/// </java-name>
						[Dot42.DexImport("WAIT_FOR_DEBUGGER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WAIT_FOR_DEBUGGER = "wait_for_debugger";
						/// <java-name>
						/// DIM_SCREEN
						/// </java-name>
						[Dot42.DexImport("DIM_SCREEN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIM_SCREEN = "dim_screen";
						/// <java-name>
						/// SCREEN_OFF_TIMEOUT
						/// </java-name>
						[Dot42.DexImport("SCREEN_OFF_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCREEN_OFF_TIMEOUT = "screen_off_timeout";
						/// <java-name>
						/// SCREEN_BRIGHTNESS
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCREEN_BRIGHTNESS = "screen_brightness";
						/// <java-name>
						/// SCREEN_BRIGHTNESS_MODE
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS_MODE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCREEN_BRIGHTNESS_MODE = "screen_brightness_mode";
						/// <java-name>
						/// SCREEN_BRIGHTNESS_MODE_MANUAL
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS_MODE_MANUAL", "I", AccessFlags = 25)]
						public const int SCREEN_BRIGHTNESS_MODE_MANUAL = 0;
						/// <java-name>
						/// SCREEN_BRIGHTNESS_MODE_AUTOMATIC
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS_MODE_AUTOMATIC", "I", AccessFlags = 25)]
						public const int SCREEN_BRIGHTNESS_MODE_AUTOMATIC = 1;
						/// <java-name>
						/// SHOW_PROCESSES
						/// </java-name>
						[Dot42.DexImport("SHOW_PROCESSES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_PROCESSES = "show_processes";
						/// <java-name>
						/// ALWAYS_FINISH_ACTIVITIES
						/// </java-name>
						[Dot42.DexImport("ALWAYS_FINISH_ACTIVITIES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALWAYS_FINISH_ACTIVITIES = "always_finish_activities";
						/// <java-name>
						/// MODE_RINGER
						/// </java-name>
						[Dot42.DexImport("MODE_RINGER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODE_RINGER = "mode_ringer";
						/// <java-name>
						/// MODE_RINGER_STREAMS_AFFECTED
						/// </java-name>
						[Dot42.DexImport("MODE_RINGER_STREAMS_AFFECTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODE_RINGER_STREAMS_AFFECTED = "mode_ringer_streams_affected";
						/// <java-name>
						/// MUTE_STREAMS_AFFECTED
						/// </java-name>
						[Dot42.DexImport("MUTE_STREAMS_AFFECTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MUTE_STREAMS_AFFECTED = "mute_streams_affected";
						/// <java-name>
						/// VIBRATE_ON
						/// </java-name>
						[Dot42.DexImport("VIBRATE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VIBRATE_ON = "vibrate_on";
						/// <java-name>
						/// VOLUME_RING
						/// </java-name>
						[Dot42.DexImport("VOLUME_RING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_RING = "volume_ring";
						/// <java-name>
						/// VOLUME_SYSTEM
						/// </java-name>
						[Dot42.DexImport("VOLUME_SYSTEM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_SYSTEM = "volume_system";
						/// <java-name>
						/// VOLUME_VOICE
						/// </java-name>
						[Dot42.DexImport("VOLUME_VOICE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_VOICE = "volume_voice";
						/// <java-name>
						/// VOLUME_MUSIC
						/// </java-name>
						[Dot42.DexImport("VOLUME_MUSIC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_MUSIC = "volume_music";
						/// <java-name>
						/// VOLUME_ALARM
						/// </java-name>
						[Dot42.DexImport("VOLUME_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_ALARM = "volume_alarm";
						/// <java-name>
						/// VOLUME_NOTIFICATION
						/// </java-name>
						[Dot42.DexImport("VOLUME_NOTIFICATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_NOTIFICATION = "volume_notification";
						/// <java-name>
						/// VOLUME_BLUETOOTH_SCO
						/// </java-name>
						[Dot42.DexImport("VOLUME_BLUETOOTH_SCO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_BLUETOOTH_SCO = "volume_bluetooth_sco";
						/// <java-name>
						/// VOLUME_SETTINGS
						/// </java-name>
						[Dot42.DexImport("VOLUME_SETTINGS", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] VOLUME_SETTINGS;
						/// <java-name>
						/// APPEND_FOR_LAST_AUDIBLE
						/// </java-name>
						[Dot42.DexImport("APPEND_FOR_LAST_AUDIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string APPEND_FOR_LAST_AUDIBLE = "_last_audible";
						/// <java-name>
						/// RINGTONE
						/// </java-name>
						[Dot42.DexImport("RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RINGTONE = "ringtone";
						/// <java-name>
						/// DEFAULT_RINGTONE_URI
						/// </java-name>
						[Dot42.DexImport("DEFAULT_RINGTONE_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DEFAULT_RINGTONE_URI;
						/// <java-name>
						/// NOTIFICATION_SOUND
						/// </java-name>
						[Dot42.DexImport("NOTIFICATION_SOUND", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTIFICATION_SOUND = "notification_sound";
						/// <java-name>
						/// DEFAULT_NOTIFICATION_URI
						/// </java-name>
						[Dot42.DexImport("DEFAULT_NOTIFICATION_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DEFAULT_NOTIFICATION_URI;
						/// <java-name>
						/// ALARM_ALERT
						/// </java-name>
						[Dot42.DexImport("ALARM_ALERT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALARM_ALERT = "alarm_alert";
						/// <java-name>
						/// DEFAULT_ALARM_ALERT_URI
						/// </java-name>
						[Dot42.DexImport("DEFAULT_ALARM_ALERT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DEFAULT_ALARM_ALERT_URI;
						/// <java-name>
						/// TEXT_AUTO_REPLACE
						/// </java-name>
						[Dot42.DexImport("TEXT_AUTO_REPLACE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_AUTO_REPLACE = "auto_replace";
						/// <java-name>
						/// TEXT_AUTO_CAPS
						/// </java-name>
						[Dot42.DexImport("TEXT_AUTO_CAPS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_AUTO_CAPS = "auto_caps";
						/// <java-name>
						/// TEXT_AUTO_PUNCTUATE
						/// </java-name>
						[Dot42.DexImport("TEXT_AUTO_PUNCTUATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_AUTO_PUNCTUATE = "auto_punctuate";
						/// <java-name>
						/// TEXT_SHOW_PASSWORD
						/// </java-name>
						[Dot42.DexImport("TEXT_SHOW_PASSWORD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_SHOW_PASSWORD = "show_password";
						/// <java-name>
						/// SHOW_GTALK_SERVICE_STATUS
						/// </java-name>
						[Dot42.DexImport("SHOW_GTALK_SERVICE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_GTALK_SERVICE_STATUS = "SHOW_GTALK_SERVICE_STATUS";
						/// <java-name>
						/// WALLPAPER_ACTIVITY
						/// </java-name>
						[Dot42.DexImport("WALLPAPER_ACTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WALLPAPER_ACTIVITY = "wallpaper_activity";
						/// <java-name>
						/// AUTO_TIME
						/// </java-name>
						[Dot42.DexImport("AUTO_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTO_TIME = "auto_time";
						/// <java-name>
						/// AUTO_TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("AUTO_TIME_ZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTO_TIME_ZONE = "auto_time_zone";
						/// <java-name>
						/// TIME_12_24
						/// </java-name>
						[Dot42.DexImport("TIME_12_24", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIME_12_24 = "time_12_24";
						/// <java-name>
						/// DATE_FORMAT
						/// </java-name>
						[Dot42.DexImport("DATE_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE_FORMAT = "date_format";
						/// <java-name>
						/// SETUP_WIZARD_HAS_RUN
						/// </java-name>
						[Dot42.DexImport("SETUP_WIZARD_HAS_RUN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETUP_WIZARD_HAS_RUN = "setup_wizard_has_run";
						/// <java-name>
						/// WINDOW_ANIMATION_SCALE
						/// </java-name>
						[Dot42.DexImport("WINDOW_ANIMATION_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WINDOW_ANIMATION_SCALE = "window_animation_scale";
						/// <java-name>
						/// TRANSITION_ANIMATION_SCALE
						/// </java-name>
						[Dot42.DexImport("TRANSITION_ANIMATION_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TRANSITION_ANIMATION_SCALE = "transition_animation_scale";
						/// <java-name>
						/// ACCELEROMETER_ROTATION
						/// </java-name>
						[Dot42.DexImport("ACCELEROMETER_ROTATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCELEROMETER_ROTATION = "accelerometer_rotation";
						/// <java-name>
						/// USER_ROTATION
						/// </java-name>
						[Dot42.DexImport("USER_ROTATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USER_ROTATION = "user_rotation";
						/// <java-name>
						/// DTMF_TONE_WHEN_DIALING
						/// </java-name>
						[Dot42.DexImport("DTMF_TONE_WHEN_DIALING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DTMF_TONE_WHEN_DIALING = "dtmf_tone";
						/// <java-name>
						/// SOUND_EFFECTS_ENABLED
						/// </java-name>
						[Dot42.DexImport("SOUND_EFFECTS_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOUND_EFFECTS_ENABLED = "sound_effects_enabled";
						/// <java-name>
						/// HAPTIC_FEEDBACK_ENABLED
						/// </java-name>
						[Dot42.DexImport("HAPTIC_FEEDBACK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAPTIC_FEEDBACK_ENABLED = "haptic_feedback_enabled";
						/// <java-name>
						/// SHOW_WEB_SUGGESTIONS
						/// </java-name>
						[Dot42.DexImport("SHOW_WEB_SUGGESTIONS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_WEB_SUGGESTIONS = "show_web_suggestions";
						/// <java-name>
						/// ADB_ENABLED
						/// </java-name>
						[Dot42.DexImport("ADB_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ADB_ENABLED = "adb_enabled";
						/// <java-name>
						/// ANDROID_ID
						/// </java-name>
						[Dot42.DexImport("ANDROID_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANDROID_ID = "android_id";
						/// <java-name>
						/// BLUETOOTH_ON
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_ON = "bluetooth_on";
						/// <java-name>
						/// DATA_ROAMING
						/// </java-name>
						[Dot42.DexImport("DATA_ROAMING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ROAMING = "data_roaming";
						/// <java-name>
						/// DEVICE_PROVISIONED
						/// </java-name>
						[Dot42.DexImport("DEVICE_PROVISIONED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEVICE_PROVISIONED = "device_provisioned";
						/// <java-name>
						/// HTTP_PROXY
						/// </java-name>
						[Dot42.DexImport("HTTP_PROXY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HTTP_PROXY = "http_proxy";
						/// <java-name>
						/// INSTALL_NON_MARKET_APPS
						/// </java-name>
						[Dot42.DexImport("INSTALL_NON_MARKET_APPS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INSTALL_NON_MARKET_APPS = "install_non_market_apps";
						/// <java-name>
						/// LOCATION_PROVIDERS_ALLOWED
						/// </java-name>
						[Dot42.DexImport("LOCATION_PROVIDERS_ALLOWED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCATION_PROVIDERS_ALLOWED = "location_providers_allowed";
						/// <java-name>
						/// LOGGING_ID
						/// </java-name>
						[Dot42.DexImport("LOGGING_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOGGING_ID = "logging_id";
						/// <java-name>
						/// NETWORK_PREFERENCE
						/// </java-name>
						[Dot42.DexImport("NETWORK_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NETWORK_PREFERENCE = "network_preference";
						/// <java-name>
						/// PARENTAL_CONTROL_ENABLED
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_ENABLED = "parental_control_enabled";
						/// <java-name>
						/// PARENTAL_CONTROL_LAST_UPDATE
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_LAST_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_LAST_UPDATE = "parental_control_last_update";
						/// <java-name>
						/// PARENTAL_CONTROL_REDIRECT_URL
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_REDIRECT_URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_REDIRECT_URL = "parental_control_redirect_url";
						/// <java-name>
						/// SETTINGS_CLASSNAME
						/// </java-name>
						[Dot42.DexImport("SETTINGS_CLASSNAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETTINGS_CLASSNAME = "settings_classname";
						/// <java-name>
						/// USB_MASS_STORAGE_ENABLED
						/// </java-name>
						[Dot42.DexImport("USB_MASS_STORAGE_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USB_MASS_STORAGE_ENABLED = "usb_mass_storage_enabled";
						/// <java-name>
						/// USE_GOOGLE_MAIL
						/// </java-name>
						[Dot42.DexImport("USE_GOOGLE_MAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USE_GOOGLE_MAIL = "use_google_mail";
						/// <java-name>
						/// WIFI_MAX_DHCP_RETRY_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_MAX_DHCP_RETRY_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MAX_DHCP_RETRY_COUNT = "wifi_max_dhcp_retry_count";
						/// <java-name>
						/// WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS = "wifi_mobile_data_transition_wakelock_timeout_ms";
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON = "wifi_networks_available_notification_on";
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY = "wifi_networks_available_repeat_delay";
						/// <java-name>
						/// WIFI_NUM_OPEN_NETWORKS_KEPT
						/// </java-name>
						[Dot42.DexImport("WIFI_NUM_OPEN_NETWORKS_KEPT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NUM_OPEN_NETWORKS_KEPT = "wifi_num_open_networks_kept";
						/// <java-name>
						/// WIFI_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_ON = "wifi_on";
						/// <java-name>
						/// WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE = "wifi_watchdog_acceptable_packet_loss_percentage";
						/// <java-name>
						/// WIFI_WATCHDOG_AP_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_AP_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_AP_COUNT = "wifi_watchdog_ap_count";
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS = "wifi_watchdog_background_check_delay_ms";
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED = "wifi_watchdog_background_check_enabled";
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS = "wifi_watchdog_background_check_timeout_ms";
						/// <java-name>
						/// WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT = "wifi_watchdog_initial_ignored_ping_count";
						/// <java-name>
						/// WIFI_WATCHDOG_MAX_AP_CHECKS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_MAX_AP_CHECKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_MAX_AP_CHECKS = "wifi_watchdog_max_ap_checks";
						/// <java-name>
						/// WIFI_WATCHDOG_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ON = "wifi_watchdog_on";
						/// <java-name>
						/// WIFI_WATCHDOG_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_COUNT = "wifi_watchdog_ping_count";
						/// <java-name>
						/// WIFI_WATCHDOG_PING_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_DELAY_MS = "wifi_watchdog_ping_delay_ms";
						/// <java-name>
						/// WIFI_WATCHDOG_PING_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_TIMEOUT_MS = "wifi_watchdog_ping_timeout_ms";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public System() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getString
						/// </java-name>
						[Dot42.DexImport("getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 41)]
						public static string GetString(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// putString
						/// </java-name>
						[Dot42.DexImport("putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
						public static bool PutString(global::Android.Content.ContentResolver contentResolver, string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getUriFor
						/// </java-name>
						[Dot42.DexImport("getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetUriFor(string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver contentResolver, string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// putInt
						/// </java-name>
						[Dot42.DexImport("putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z", AccessFlags = 9)]
						public static bool PutInt(global::Android.Content.ContentResolver contentResolver, string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver contentResolver, string @string, long int64) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// putLong
						/// </java-name>
						[Dot42.DexImport("putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z", AccessFlags = 9)]
						public static bool PutLong(global::Android.Content.ContentResolver contentResolver, string @string, long int64) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver contentResolver, string @string, float single) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// putFloat
						/// </java-name>
						[Dot42.DexImport("putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z", AccessFlags = 9)]
						public static bool PutFloat(global::Android.Content.ContentResolver contentResolver, string @string, float single) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getConfiguration
						/// </java-name>
						[Dot42.DexImport("getConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)V", AccessFlags = 9)]
						public static void GetConfiguration(global::Android.Content.ContentResolver contentResolver, global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// putConfiguration
						/// </java-name>
						[Dot42.DexImport("putConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)Z", AccessFlags = 9)]
						public static bool PutConfiguration(global::Android.Content.ContentResolver contentResolver, global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getShowGTalkServiceStatus
						/// </java-name>
						[Dot42.DexImport("getShowGTalkServiceStatus", "(Landroid/content/ContentResolver;)Z", AccessFlags = 9)]
						public static bool GetShowGTalkServiceStatus(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// setShowGTalkServiceStatus
						/// </java-name>
						[Dot42.DexImport("setShowGTalkServiceStatus", "(Landroid/content/ContentResolver;Z)V", AccessFlags = 9)]
						public static void SetShowGTalkServiceStatus(global::Android.Content.ContentResolver contentResolver, bool boolean) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Settings$NameValueTable
				/// </java-name>
				[Dot42.DexImport("android/provider/Settings$NameValueTable", AccessFlags = 9)]
				public partial class NameValueTable : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public NameValueTable() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// putString
						/// </java-name>
						[Dot42.DexImport("putString", "(Landroid/content/ContentResolver;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/S" +
    "tring;)Z", AccessFlags = 12)]
						protected internal static bool PutString(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri, string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getUriFor
						/// </java-name>
						[Dot42.DexImport("getUriFor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetUriFor(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

				}

				/// <java-name>
				/// android/provider/Settings$SettingNotFoundException
				/// </java-name>
				[Dot42.DexImport("android/provider/Settings$SettingNotFoundException", AccessFlags = 9)]
				public partial class SettingNotFoundException : global::Android.Util.AndroidException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public SettingNotFoundException(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SettingNotFoundException() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/provider/UserDictionary
		/// </java-name>
		[Dot42.DexImport("android/provider/UserDictionary", AccessFlags = 33)]
		public partial class UserDictionary
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "user_dictionary";
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UserDictionary() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/UserDictionary$Words
				/// </java-name>
				[Dot42.DexImport("android/provider/UserDictionary$Words", AccessFlags = 9)]
				public partial class Words : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/vnd.google.userword";
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/vnd.google.userword";
						/// <java-name>
						/// _ID
						/// </java-name>
						[Dot42.DexImport("_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string _ID = "_id";
						/// <java-name>
						/// WORD
						/// </java-name>
						[Dot42.DexImport("WORD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WORD = "word";
						/// <java-name>
						/// FREQUENCY
						/// </java-name>
						[Dot42.DexImport("FREQUENCY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FREQUENCY = "frequency";
						/// <java-name>
						/// LOCALE
						/// </java-name>
						[Dot42.DexImport("LOCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCALE = "locale";
						/// <java-name>
						/// APP_ID
						/// </java-name>
						[Dot42.DexImport("APP_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string APP_ID = "appid";
						/// <java-name>
						/// LOCALE_TYPE_ALL
						/// </java-name>
						[Dot42.DexImport("LOCALE_TYPE_ALL", "I", AccessFlags = 25)]
						public const int LOCALE_TYPE_ALL = 0;
						/// <java-name>
						/// LOCALE_TYPE_CURRENT
						/// </java-name>
						[Dot42.DexImport("LOCALE_TYPE_CURRENT", "I", AccessFlags = 25)]
						public const int LOCALE_TYPE_CURRENT = 1;
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "frequency DESC";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Words() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// addWord
						/// </java-name>
						[Dot42.DexImport("addWord", "(Landroid/content/Context;Ljava/lang/String;II)V", AccessFlags = 9)]
						public static void AddWord(global::Android.Content.Context context, string @string, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/provider/Browser
		/// </java-name>
		[Dot42.DexImport("android/provider/Browser", AccessFlags = 33)]
		public partial class Browser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BOOKMARKS_URI
				/// </java-name>
				[Dot42.DexImport("BOOKMARKS_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri BOOKMARKS_URI;
				/// <java-name>
				/// INITIAL_ZOOM_LEVEL
				/// </java-name>
				[Dot42.DexImport("INITIAL_ZOOM_LEVEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INITIAL_ZOOM_LEVEL = "browser.initialZoomLevel";
				/// <java-name>
				/// EXTRA_APPLICATION_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPLICATION_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPLICATION_ID = "com.android.browser.application_id";
				/// <java-name>
				/// EXTRA_HEADERS
				/// </java-name>
				[Dot42.DexImport("EXTRA_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_HEADERS = "com.android.browser.headers";
				/// <java-name>
				/// HISTORY_PROJECTION
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] HISTORY_PROJECTION;
				/// <java-name>
				/// HISTORY_PROJECTION_ID_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_ID_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_ID_INDEX = 0;
				/// <java-name>
				/// HISTORY_PROJECTION_URL_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_URL_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_URL_INDEX = 1;
				/// <java-name>
				/// HISTORY_PROJECTION_VISITS_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_VISITS_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_VISITS_INDEX = 2;
				/// <java-name>
				/// HISTORY_PROJECTION_DATE_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_DATE_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_DATE_INDEX = 3;
				/// <java-name>
				/// HISTORY_PROJECTION_BOOKMARK_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_BOOKMARK_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_BOOKMARK_INDEX = 4;
				/// <java-name>
				/// HISTORY_PROJECTION_TITLE_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_TITLE_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_TITLE_INDEX = 5;
				/// <java-name>
				/// HISTORY_PROJECTION_FAVICON_INDEX
				/// </java-name>
				[Dot42.DexImport("HISTORY_PROJECTION_FAVICON_INDEX", "I", AccessFlags = 25)]
				public const int HISTORY_PROJECTION_FAVICON_INDEX = 6;
				/// <java-name>
				/// TRUNCATE_HISTORY_PROJECTION
				/// </java-name>
				[Dot42.DexImport("TRUNCATE_HISTORY_PROJECTION", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] TRUNCATE_HISTORY_PROJECTION;
				/// <java-name>
				/// TRUNCATE_HISTORY_PROJECTION_ID_INDEX
				/// </java-name>
				[Dot42.DexImport("TRUNCATE_HISTORY_PROJECTION_ID_INDEX", "I", AccessFlags = 25)]
				public const int TRUNCATE_HISTORY_PROJECTION_ID_INDEX = 0;
				/// <java-name>
				/// TRUNCATE_N_OLDEST
				/// </java-name>
				[Dot42.DexImport("TRUNCATE_N_OLDEST", "I", AccessFlags = 25)]
				public const int TRUNCATE_N_OLDEST = 5;
				/// <java-name>
				/// SEARCHES_URI
				/// </java-name>
				[Dot42.DexImport("SEARCHES_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri SEARCHES_URI;
				/// <java-name>
				/// SEARCHES_PROJECTION
				/// </java-name>
				[Dot42.DexImport("SEARCHES_PROJECTION", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] SEARCHES_PROJECTION;
				/// <java-name>
				/// SEARCHES_PROJECTION_SEARCH_INDEX
				/// </java-name>
				[Dot42.DexImport("SEARCHES_PROJECTION_SEARCH_INDEX", "I", AccessFlags = 25)]
				public const int SEARCHES_PROJECTION_SEARCH_INDEX = 1;
				/// <java-name>
				/// SEARCHES_PROJECTION_DATE_INDEX
				/// </java-name>
				[Dot42.DexImport("SEARCHES_PROJECTION_DATE_INDEX", "I", AccessFlags = 25)]
				public const int SEARCHES_PROJECTION_DATE_INDEX = 2;
				/// <java-name>
				/// EXTRA_CREATE_NEW_TAB
				/// </java-name>
				[Dot42.DexImport("EXTRA_CREATE_NEW_TAB", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CREATE_NEW_TAB = "create_new_tab";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Browser() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveBookmark
				/// </java-name>
				[Dot42.DexImport("saveBookmark", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void SaveBookmark(global::Android.Content.Context context, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendString
				/// </java-name>
				[Dot42.DexImport("sendString", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void SendString(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllBookmarks
				/// </java-name>
				[Dot42.DexImport("getAllBookmarks", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;", AccessFlags = 25)]
				public static global::Android.Database.ICursor GetAllBookmarks(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// getAllVisitedUrls
				/// </java-name>
				[Dot42.DexImport("getAllVisitedUrls", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;", AccessFlags = 25)]
				public static global::Android.Database.ICursor GetAllVisitedUrls(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// updateVisitedHistory
				/// </java-name>
				[Dot42.DexImport("updateVisitedHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V", AccessFlags = 25)]
				public static void UpdateVisitedHistory(global::Android.Content.ContentResolver contentResolver, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// truncateHistory
				/// </java-name>
				[Dot42.DexImport("truncateHistory", "(Landroid/content/ContentResolver;)V", AccessFlags = 25)]
				public static void TruncateHistory(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// canClearHistory
				/// </java-name>
				[Dot42.DexImport("canClearHistory", "(Landroid/content/ContentResolver;)Z", AccessFlags = 25)]
				public static bool CanClearHistory(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearHistory
				/// </java-name>
				[Dot42.DexImport("clearHistory", "(Landroid/content/ContentResolver;)V", AccessFlags = 25)]
				public static void ClearHistory(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteHistoryTimeFrame
				/// </java-name>
				[Dot42.DexImport("deleteHistoryTimeFrame", "(Landroid/content/ContentResolver;JJ)V", AccessFlags = 25)]
				public static void DeleteHistoryTimeFrame(global::Android.Content.ContentResolver contentResolver, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteFromHistory
				/// </java-name>
				[Dot42.DexImport("deleteFromHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void DeleteFromHistory(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSearchUrl
				/// </java-name>
				[Dot42.DexImport("addSearchUrl", "(Landroid/content/ContentResolver;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void AddSearchUrl(global::Android.Content.ContentResolver contentResolver, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearSearches
				/// </java-name>
				[Dot42.DexImport("clearSearches", "(Landroid/content/ContentResolver;)V", AccessFlags = 25)]
				public static void ClearSearches(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestAllIcons
				/// </java-name>
				[Dot42.DexImport("requestAllIcons", "(Landroid/content/ContentResolver;Ljava/lang/String;Landroid/webkit/WebIconDataba" +
    "se$IconListener;)V", AccessFlags = 25)]
				public static void RequestAllIcons(global::Android.Content.ContentResolver contentResolver, string @string, global::Android.Webkit.WebIconDatabase.IIconListener iconListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/Browser$SearchColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Browser$SearchColumns", AccessFlags = 9)]
				public partial class SearchColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// URL
						/// </java-name>
						[Dot42.DexImport("URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string URL = "url";
						/// <java-name>
						/// SEARCH
						/// </java-name>
						[Dot42.DexImport("SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH = "search";
						/// <java-name>
						/// DATE
						/// </java-name>
						[Dot42.DexImport("DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE = "date";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SearchColumns() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/Browser$BookmarkColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Browser$BookmarkColumns", AccessFlags = 9)]
				public partial class BookmarkColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// URL
						/// </java-name>
						[Dot42.DexImport("URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string URL = "url";
						/// <java-name>
						/// VISITS
						/// </java-name>
						[Dot42.DexImport("VISITS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VISITS = "visits";
						/// <java-name>
						/// DATE
						/// </java-name>
						[Dot42.DexImport("DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE = "date";
						/// <java-name>
						/// BOOKMARK
						/// </java-name>
						[Dot42.DexImport("BOOKMARK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BOOKMARK = "bookmark";
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <java-name>
						/// CREATED
						/// </java-name>
						[Dot42.DexImport("CREATED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CREATED = "created";
						/// <java-name>
						/// FAVICON
						/// </java-name>
						[Dot42.DexImport("FAVICON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FAVICON = "favicon";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public BookmarkColumns() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/provider/SyncStateContract
		/// </java-name>
		[Dot42.DexImport("android/provider/SyncStateContract", AccessFlags = 33)]
		public partial class SyncStateContract
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SyncStateContract() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/provider/SyncStateContract$Helpers
				/// </java-name>
				[Dot42.DexImport("android/provider/SyncStateContract$Helpers", AccessFlags = 25)]
				public sealed partial class Helpers
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Helpers() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)[B", AccessFlags = 9)]
						public static sbyte[] JavaGet(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)[B", AccessFlags = 9, IgnoreFromJava = true)]
						public static byte[] Get(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(byte[]);
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)V", AccessFlags = 9)]
						public static void Set(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Set(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// insert
						/// </java-name>
						[Dot42.DexImport("insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri Insert(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// insert
						/// </java-name>
						[Dot42.DexImport("insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)Landroid/net/Uri;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Net.Uri Insert(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// update
						/// </java-name>
						[Dot42.DexImport("update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V", AccessFlags = 9)]
						public static void Update(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// update
						/// </java-name>
						[Dot42.DexImport("update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Update(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getWithUri
						/// </java-name>
						[Dot42.DexImport("getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)Landroid/util/Pair;", AccessFlags = 9, Signature = "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)Landroid/util/Pair<Landroid/net/Uri;[B>;")]
						public static global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]> GetWithUri(global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Net.Uri uri, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]>);
						}

						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOp" +
    "eration;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Net.Uri uri, global::Android.Accounts.Account account, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOp" +
    "eration;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Net.Uri uri, global::Android.Accounts.Account account, byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <java-name>
						/// newUpdateOperation
						/// </java-name>
						[Dot42.DexImport("newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewUpdateOperation(global::Android.Net.Uri uri, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <java-name>
						/// newUpdateOperation
						/// </java-name>
						[Dot42.DexImport("newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewUpdateOperation(global::Android.Net.Uri uri, byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

				}

				/// <java-name>
				/// android/provider/SyncStateContract$Constants
				/// </java-name>
				[Dot42.DexImport("android/provider/SyncStateContract$Constants", AccessFlags = 9)]
				public partial class Constants : global::Android.Provider.SyncStateContract.IColumns
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "syncstate";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Constants() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/provider/SyncStateContract$Columns
				/// </java-name>
				[Dot42.DexImport("android/provider/SyncStateContract$Columns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "data";
				}

				/// <java-name>
				/// android/provider/SyncStateContract$Columns
				/// </java-name>
				[Dot42.DexImport("android/provider/SyncStateContract$Columns", AccessFlags = 1545)]
				public partial interface IColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
				}

		}

}

