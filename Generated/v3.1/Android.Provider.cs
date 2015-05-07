#pragma warning disable 1717
namespace Android.Provider
{
		/// <summary>
		///  <para>The AlarmClock provider contains an Intent action and extras that can be used to start an Activity to set a new alarm or timer in an alarm clock application.</para> <para>Applications that wish to receive the ACTION_SET_ALARM and ACTION_SET_TIMER Intents should create an activity to handle the Intent that requires the permission com.android.alarm.permission.SET_ALARM. Applications that wish to create a new alarm or timer should use Context.startActivity() so that the user has the option of choosing which alarm clock application to use. </para>    
		/// </summary>
		/// <java-name>
		/// android/provider/AlarmClock
		/// </java-name>
		[Dot42.DexImport("android/provider/AlarmClock", AccessFlags = 49)]
		public sealed partial class AlarmClock
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Activity Action: Set an alarm. </para> <para>Activates an existing alarm or creates a new one. </para> <para>This action requests an alarm to be set for a given time of day. If no time of day is specified, an implementation should start an activity that is capable of setting an alarm (EXTRA_SKIP_UI is ignored in this case). If a time of day is specified, and EXTRA_SKIP_UI is <c>true </c> , and the alarm is not repeating, the implementation should remove this alarm after it has been dismissed. If an identical alarm exists matching all parameters, the implementation may re-use it instead of creating a new one (in this case, the alarm should not be removed after dismissal).</para> <para>This action always enables the alarm. </para> <para> <h3>Request parameters</h3></para> <para> <ul> <li> <para>EXTRA_HOUR  <b>(optional)</b>: The hour of the alarm being set. </para></li> <li> <para>EXTRA_MINUTES  <b>(optional)</b>: The minutes of the alarm being set. </para></li> <li> <para>EXTRA_DAYS  <b>(optional)</b>: Weekdays for repeating alarm. </para></li> <li> <para>EXTRA_MESSAGE  <b>(optional)</b>: A custom message for the alarm. </para></li> <li> <para>EXTRA_RINGTONE  <b>(optional)</b>: A ringtone to play with this alarm. </para></li> <li> <para>EXTRA_VIBRATE  <b>(optional)</b>: Whether or not to activate the device vibrator for this alarm. </para></li> <li> <para>EXTRA_SKIP_UI  <b>(optional)</b>: Whether or not to display an activity for setting this alarm. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SET_ALARM
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SET_ALARM = "android.intent.action.SET_ALARM";
				/// <summary>
				///  <para>Bundle extra: A custom message for the alarm or timer. </para> <para>Used by ACTION_SET_ALARM and ACTION_SET_TIMER. </para> <para>The value is a String. </para> <para> <para>ACTION_SET_ALARM </para> <para>ACTION_SET_TIMER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MESSAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_MESSAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MESSAGE = "android.intent.extra.alarm.MESSAGE";
				/// <summary>
				///  <para>Bundle extra: The hour of the alarm. </para> <para>Used by ACTION_SET_ALARM. </para> <para>This extra is optional. If not provided, an implementation should open an activity that allows a user to set an alarm with user provided time. </para> <para>The value is an Integer and ranges from 0 to 23. </para> <para> <para>ACTION_SET_ALARM </para> <para>EXTRA_MINUTES </para> <para>EXTRA_DAYS </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_HOUR
				/// </java-name>
				[Dot42.DexImport("EXTRA_HOUR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_HOUR = "android.intent.extra.alarm.HOUR";
				/// <summary>
				///  <para>Bundle extra: The minutes of the alarm. </para> <para>Used by ACTION_SET_ALARM. </para> <para>The value is an Integer and ranges from 0 to 59. If not provided, it defaults to 0. </para> <para> <para>ACTION_SET_ALARM </para> <para>EXTRA_HOUR </para> <para>EXTRA_DAYS </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MINUTES
				/// </java-name>
				[Dot42.DexImport("EXTRA_MINUTES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MINUTES = "android.intent.extra.alarm.MINUTES";
				/// <summary>
				///  <para>Bundle extra: Whether or not to display an activity after performing the action. </para> <para>Used by ACTION_SET_ALARM and ACTION_SET_TIMER. </para> <para>If true, the application is asked to bypass any intermediate UI. If false, the application may display intermediate UI like a confirmation dialog or settings. </para> <para>The value is a Boolean. The default is <c>false </c> . </para> <para> <para>ACTION_SET_ALARM </para> <para>ACTION_SET_TIMER </para></para>        
				/// </summary>
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
		/// android/provider/Browser
		/// </java-name>
		[Dot42.DexImport("android/provider/Browser", AccessFlags = 33)]
		public partial class Browser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A table containing both bookmarks and history items. The columns of the table are defined in BookmarkColumns. Reading this table requires the android.Manifest.permission#READ_HISTORY_BOOKMARKS permission and writing to it requires the android.Manifest.permission#WRITE_HISTORY_BOOKMARKS permission. </para>        
				/// </summary>
				/// <java-name>
				/// BOOKMARKS_URI
				/// </java-name>
				[Dot42.DexImport("BOOKMARKS_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri BOOKMARKS_URI;
				/// <summary>
				///  <para>The name of extra data when starting Browser with ACTION_VIEW or ACTION_SEARCH intent. </para> <para>The value should be an integer between 0 and 1000. If not set or set to 0, the Browser will use default. If set to 100, the Browser will start with 100%. </para>        
				/// </summary>
				/// <java-name>
				/// INITIAL_ZOOM_LEVEL
				/// </java-name>
				[Dot42.DexImport("INITIAL_ZOOM_LEVEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INITIAL_ZOOM_LEVEL = "browser.initialZoomLevel";
				/// <summary>
				///  <para>The name of the extra data when starting the Browser from another application. </para> <para>The value is a unique identification string that will be used to identify the calling application. The Browser will attempt to reuse the same window each time the application launches the Browser with the same identifier. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPLICATION_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPLICATION_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPLICATION_ID = "com.android.browser.application_id";
				/// <summary>
				///  <para>The name of the extra data in the VIEW intent. The data are key/value pairs in the format of Bundle. They will be sent in the HTTP request headers for the provided url. The keys can't be the standard HTTP headers as they are set by the WebView. The url's schema must be http(s). </para>        
				/// </summary>
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
				/// <summary>
				///  <para>A table containing a log of browser searches. The columns of the table are defined in SearchColumns. Reading this table requires the android.Manifest.permission#READ_HISTORY_BOOKMARKS permission and writing to it requires the android.Manifest.permission#WRITE_HISTORY_BOOKMARKS permission. </para>        
				/// </summary>
				/// <java-name>
				/// SEARCHES_URI
				/// </java-name>
				[Dot42.DexImport("SEARCHES_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri SEARCHES_URI;
				/// <summary>
				///  <para>A projection of SEARCHES_URI that contains SearchColumns#_ID, SearchColumns#SEARCH, and SearchColumns#DATE. </para>        
				/// </summary>
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
				/// <summary>
				///  <para>Boolean extra passed along with an Intent to a browser, specifying that a new tab be created. Overrides EXTRA_APPLICATION_ID; if both are set, a new tab will be used, rather than using the same one. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CREATE_NEW_TAB
				/// </java-name>
				[Dot42.DexImport("EXTRA_CREATE_NEW_TAB", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CREATE_NEW_TAB = "create_new_tab";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Browser() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Open an activity to save a bookmark. Launch with a title and/or a url, both of which can be edited by the user before saving.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// saveBookmark
				/// </java-name>
				[Dot42.DexImport("saveBookmark", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void SaveBookmark(global::Android.Content.Context c, string title, string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends the given string using an Intent with Intent#ACTION_SEND and a mime type of text/plain. The string is put into Intent#EXTRA_TEXT.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendString
				/// </java-name>
				[Dot42.DexImport("sendString", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void SendString(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a cursor pointing to a list of all the bookmarks. The cursor will have a single column, BookmarkColumns#URL. </para> <para>Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAllBookmarks
				/// </java-name>
				[Dot42.DexImport("getAllBookmarks", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;", AccessFlags = 25)]
				public static global::Android.Database.ICursor GetAllBookmarks(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Return a cursor pointing to a list of all visited site urls. The cursor will have a single column, BookmarkColumns#URL. </para> <para>Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAllVisitedUrls
				/// </java-name>
				[Dot42.DexImport("getAllVisitedUrls", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;", AccessFlags = 25)]
				public static global::Android.Database.ICursor GetAllVisitedUrls(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Update the visited history to acknowledge that a site has been visited. Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// updateVisitedHistory
				/// </java-name>
				[Dot42.DexImport("updateVisitedHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V", AccessFlags = 25)]
				public static void UpdateVisitedHistory(global::Android.Content.ContentResolver cr, string url, bool real) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If there are more than MAX_HISTORY_COUNT non-bookmark history items in the bookmark/history table, delete TRUNCATE_N_OLDEST of them. This is used to keep our history table to a reasonable size. Note: it does not prune bookmarks. If the user wants 1000 bookmarks, the user gets 1000 bookmarks. Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// truncateHistory
				/// </java-name>
				[Dot42.DexImport("truncateHistory", "(Landroid/content/ContentResolver;)V", AccessFlags = 25)]
				public static void TruncateHistory(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether there is any history to clear. Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <returns>
				///  <para>boolean True if the history can be cleared. </para>
				/// </returns>
				/// <java-name>
				/// canClearHistory
				/// </java-name>
				[Dot42.DexImport("canClearHistory", "(Landroid/content/ContentResolver;)Z", AccessFlags = 25)]
				public static bool CanClearHistory(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Delete all entries from the bookmarks/history table which are not bookmarks. Also set all visited bookmarks to unvisited. Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// clearHistory
				/// </java-name>
				[Dot42.DexImport("clearHistory", "(Landroid/content/ContentResolver;)V", AccessFlags = 25)]
				public static void ClearHistory(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Delete all history items from begin to end. Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// deleteHistoryTimeFrame
				/// </java-name>
				[Dot42.DexImport("deleteHistoryTimeFrame", "(Landroid/content/ContentResolver;JJ)V", AccessFlags = 25)]
				public static void DeleteHistoryTimeFrame(global::Android.Content.ContentResolver cr, long begin, long end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a specific url from the history database. Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// deleteFromHistory
				/// </java-name>
				[Dot42.DexImport("deleteFromHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void DeleteFromHistory(global::Android.Content.ContentResolver cr, string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a search string to the searches database. Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// addSearchUrl
				/// </java-name>
				[Dot42.DexImport("addSearchUrl", "(Landroid/content/ContentResolver;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void AddSearchUrl(global::Android.Content.ContentResolver cr, string search) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove all searches from the search database. Requires android.Manifest.permission#WRITE_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// clearSearches
				/// </java-name>
				[Dot42.DexImport("clearSearches", "(Landroid/content/ContentResolver;)V", AccessFlags = 25)]
				public static void ClearSearches(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request all icons from the database. This call must either be called in the main thread or have had Looper.prepare() invoked in the calling thread. Requires android.Manifest.permission#READ_HISTORY_BOOKMARKS </para>        
				/// </summary>
				/// <java-name>
				/// requestAllIcons
				/// </java-name>
				[Dot42.DexImport("requestAllIcons", "(Landroid/content/ContentResolver;Ljava/lang/String;Landroid/webkit/WebIconDataba" +
    "se$IconListener;)V", AccessFlags = 25)]
				public static void RequestAllIcons(global::Android.Content.ContentResolver cr, string where, global::Android.Webkit.WebIconDatabase.IIconListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Column definitions for the search history table, available at SEARCHES_URI. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Browser$SearchColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Browser$SearchColumns", AccessFlags = 9)]
				public partial class SearchColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// URL
						/// </java-name>
						[Dot42.DexImport("URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string URL = "url";
						/// <summary>
						///  <para>The user entered search term. </para>        
						/// </summary>
						/// <java-name>
						/// SEARCH
						/// </java-name>
						[Dot42.DexImport("SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH = "search";
						/// <summary>
						///  <para>The date the search was performed, in milliseconds since the epoch. </para> <para>Type: NUMBER (date in milliseconds since January 1, 1970)</para>        
						/// </summary>
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

				/// <summary>
				///  <para>Column definitions for the mixed bookmark and history items available at BOOKMARKS_URI. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Browser$BookmarkColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Browser$BookmarkColumns", AccessFlags = 9)]
				public partial class BookmarkColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The URL of the bookmark or history item. </para> <para>Type: TEXT (URL)</para>        
						/// </summary>
						/// <java-name>
						/// URL
						/// </java-name>
						[Dot42.DexImport("URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string URL = "url";
						/// <summary>
						///  <para>The number of time the item has been visited. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// VISITS
						/// </java-name>
						[Dot42.DexImport("VISITS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VISITS = "visits";
						/// <summary>
						///  <para>The date the item was last visited, in milliseconds since the epoch. </para> <para>Type: NUMBER (date in milliseconds since January 1, 1970)</para>        
						/// </summary>
						/// <java-name>
						/// DATE
						/// </java-name>
						[Dot42.DexImport("DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE = "date";
						/// <summary>
						///  <para>Flag indicating that an item is a bookmark. A value of 1 indicates a bookmark, a value of 0 indicates a history item. </para> <para>Type: INTEGER (boolean)</para>        
						/// </summary>
						/// <java-name>
						/// BOOKMARK
						/// </java-name>
						[Dot42.DexImport("BOOKMARK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BOOKMARK = "bookmark";
						/// <summary>
						///  <para>The user visible title of the bookmark or history item. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <summary>
						///  <para>The date the item created, in milliseconds since the epoch. </para> <para>Type: NUMBER (date in milliseconds since January 1, 1970)</para>        
						/// </summary>
						/// <java-name>
						/// CREATED
						/// </java-name>
						[Dot42.DexImport("CREATED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CREATED = "created";
						/// <summary>
						///  <para>The favicon of the bookmark. Must decode via BitmapFactory#decodeByteArray. </para> <para>Type: BLOB (image)</para>        
						/// </summary>
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

		/// <summary>
		///  <para>The CallLog provider contains information about placed and received calls. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>The content:// style URL for this provider </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CallLog() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Contains the recent calls. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/CallLog$Calls
				/// </java-name>
				[Dot42.DexImport("android/provider/CallLog$Calls", AccessFlags = 9)]
				public partial class Calls : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URL for filtering this table on phone numbers </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						/// <summary>
						///  <para>The default sort order for this table </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "date DESC";
						/// <summary>
						///  <para>The MIME type of CONTENT_URI and CONTENT_FILTER_URI providing a directory of calls. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/calls";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI sub-directory of a single call. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/calls";
						/// <summary>
						///  <para>The type of the call (incoming, outgoing or missed). </para> <para>Type: INTEGER (int)</para>        
						/// </summary>
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <summary>
						///  <para>Call log type for incoming calls. </para>        
						/// </summary>
						/// <java-name>
						/// INCOMING_TYPE
						/// </java-name>
						[Dot42.DexImport("INCOMING_TYPE", "I", AccessFlags = 25)]
						public const int INCOMING_TYPE = 1;
						/// <summary>
						///  <para>Call log type for outgoing calls. </para>        
						/// </summary>
						/// <java-name>
						/// OUTGOING_TYPE
						/// </java-name>
						[Dot42.DexImport("OUTGOING_TYPE", "I", AccessFlags = 25)]
						public const int OUTGOING_TYPE = 2;
						/// <summary>
						///  <para>Call log type for missed calls. </para>        
						/// </summary>
						/// <java-name>
						/// MISSED_TYPE
						/// </java-name>
						[Dot42.DexImport("MISSED_TYPE", "I", AccessFlags = 25)]
						public const int MISSED_TYPE = 3;
						/// <summary>
						///  <para>The phone number as the user entered it. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <summary>
						///  <para>The date the call occured, in milliseconds since the epoch </para> <para>Type: INTEGER (long)</para>        
						/// </summary>
						/// <java-name>
						/// DATE
						/// </java-name>
						[Dot42.DexImport("DATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE = "date";
						/// <summary>
						///  <para>The duration of the call in seconds </para> <para>Type: INTEGER (long)</para>        
						/// </summary>
						/// <java-name>
						/// DURATION
						/// </java-name>
						[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DURATION = "duration";
						/// <summary>
						///  <para>Whether or not the call has been acknowledged </para> <para>Type: INTEGER (boolean)</para>        
						/// </summary>
						/// <java-name>
						/// NEW
						/// </java-name>
						[Dot42.DexImport("NEW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NEW = "new";
						/// <summary>
						///  <para>The cached name associated with the phone number, if it exists. This value is not guaranteed to be current, if the contact information associated with this number has changed. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// CACHED_NAME
						/// </java-name>
						[Dot42.DexImport("CACHED_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CACHED_NAME = "name";
						/// <summary>
						///  <para>The cached number type (Home, Work, etc) associated with the phone number, if it exists. This value is not guaranteed to be current, if the contact information associated with this number has changed. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// CACHED_NUMBER_TYPE
						/// </java-name>
						[Dot42.DexImport("CACHED_NUMBER_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CACHED_NUMBER_TYPE = "numbertype";
						/// <summary>
						///  <para>The cached number label, for a custom number type, associated with the phone number, if it exists. This value is not guaranteed to be current, if the contact information associated with this number has changed. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// CACHED_NUMBER_LABEL
						/// </java-name>
						[Dot42.DexImport("CACHED_NUMBER_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CACHED_NUMBER_LABEL = "numberlabel";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Calls() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Query the call log database for the last dialed number. </para>        
						/// </summary>
						/// <returns>
						///  <para>The last phone number dialed (outgoing) or an empty string if none exist yet. </para>
						/// </returns>
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

		/// <summary>
		///  <para>The Contacts provider stores all information about contacts.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The APIs have been superseded by ContactsContract. The newer APIs allow access multiple accounts and support aggregation of similar contacts. These APIs continue to work but will only return data for the first Google account created, which matches the original behavior. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/provider/Contacts
		/// </java-name>
		[Dot42.DexImport("android/provider/Contacts", AccessFlags = 33)]
		public partial class Contacts
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "contacts";
				/// <summary>
				///  <para>The content:// style URL for this provider  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				/// <summary>
				///  <para>Signifies an email address row that is stored in the ContactMethods table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// KIND_EMAIL
				/// </java-name>
				[Dot42.DexImport("KIND_EMAIL", "I", AccessFlags = 25)]
				public const int KIND_EMAIL = 1;
				/// <summary>
				///  <para>Signifies a postal address row that is stored in the ContactMethods table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// KIND_POSTAL
				/// </java-name>
				[Dot42.DexImport("KIND_POSTAL", "I", AccessFlags = 25)]
				public const int KIND_POSTAL = 2;
				/// <summary>
				///  <para>Signifies an IM address row that is stored in the ContactMethods table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// KIND_IM
				/// </java-name>
				[Dot42.DexImport("KIND_IM", "I", AccessFlags = 25)]
				public const int KIND_IM = 3;
				/// <summary>
				///  <para>Signifies an Organization row that is stored in the Organizations table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// KIND_ORGANIZATION
				/// </java-name>
				[Dot42.DexImport("KIND_ORGANIZATION", "I", AccessFlags = 25)]
				public const int KIND_ORGANIZATION = 4;
				/// <summary>
				///  <para>Signifies a Phone row that is stored in the Phones table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// KIND_PHONE
				/// </java-name>
				[Dot42.DexImport("KIND_PHONE", "I", AccessFlags = 25)]
				public const int KIND_PHONE = 5;
				/// <summary>
				///  <para>no public constructor since this is a utility class </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Contacts() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Contains helper classes used to create or manage Intents that involve contacts.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Intents
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Intents", AccessFlags = 25)]
				public sealed partial class Intents
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This is the intent that is fired when a search suggestion is clicked on.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SEARCH_SUGGESTION_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED";
						/// <summary>
						///  <para>This is the intent that is fired when a search suggestion for dialing a number is clicked on.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED";
						/// <summary>
						///  <para>This is the intent that is fired when a search suggestion for creating a contact is clicked on.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED";
						/// <summary>
						///  <para>Starts an Activity that lets the user pick a contact to attach an image to. After picking the contact it launches the image cropper in face detection mode.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ATTACH_IMAGE
						/// </java-name>
						[Dot42.DexImport("ATTACH_IMAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTACH_IMAGE = "com.android.contacts.action.ATTACH_IMAGE";
						/// <summary>
						///  <para>Takes as input a data URI with a mailto: or tel: scheme. If a single contact exists with the given data it will be shown. If no contact exists, a dialog will ask the user if they want to create a new contact with the provided details filled in. If multiple contacts share the data the user will be prompted to pick which contact they want to view. </para> <para>For  <code>mailto:</code> URIs, the scheme specific portion must be a raw email address, such as one built using Uri#fromParts(String, String, String). </para> <para>For  <code>tel:</code> URIs, the scheme specific portion is compared to existing numbers using the standard caller ID lookup algorithm. The number must be properly encoded, for example using Uri#fromParts(String, String, String). </para> <para>Any extras from the Insert class will be passed along to the create activity if there are no contacts to show. </para> <para>Passing true for the EXTRA_FORCE_CREATE extra will skip prompting the user when the contact doesn't exist.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SHOW_OR_CREATE_CONTACT
						/// </java-name>
						[Dot42.DexImport("SHOW_OR_CREATE_CONTACT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_OR_CREATE_CONTACT = "com.android.contacts.action.SHOW_OR_CREATE_CONTACT";
						/// <summary>
						///  <para>Used with SHOW_OR_CREATE_CONTACT to force creating a new contact if no matching contact found. Otherwise, default behavior is to prompt user with dialog before creating. </para> <para>Type: BOOLEAN  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_FORCE_CREATE
						/// </java-name>
						[Dot42.DexImport("EXTRA_FORCE_CREATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_FORCE_CREATE = "com.android.contacts.action.FORCE_CREATE";
						/// <summary>
						///  <para>Used with SHOW_OR_CREATE_CONTACT to specify an exact description to be shown when prompting user about creating a new contact. </para> <para>Type: STRING  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_CREATE_DESCRIPTION
						/// </java-name>
						[Dot42.DexImport("EXTRA_CREATE_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CREATE_DESCRIPTION = "com.android.contacts.action.CREATE_DESCRIPTION";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Intents() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Convenience class that contains string constants used to create contact Intents.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/Contacts$Intents$Insert
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$Intents$Insert", AccessFlags = 25)]
						public sealed partial class Insert
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The action code to use when adding a contact  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// ACTION
								/// </java-name>
								[Dot42.DexImport("ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ACTION = "android.intent.action.INSERT";
								/// <summary>
								///  <para>If present, forces a bypass of quick insert mode.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// FULL_MODE
								/// </java-name>
								[Dot42.DexImport("FULL_MODE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FULL_MODE = "full_mode";
								/// <summary>
								///  <para>The extra field for the contact name. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
								/// <summary>
								///  <para>The extra field for the contact phonetic name. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// PHONETIC_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_NAME = "phonetic_name";
								/// <summary>
								///  <para>The extra field for the contact company. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// COMPANY
								/// </java-name>
								[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPANY = "company";
								/// <summary>
								///  <para>The extra field for the contact job title. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// JOB_TITLE
								/// </java-name>
								[Dot42.DexImport("JOB_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string JOB_TITLE = "job_title";
								/// <summary>
								///  <para>The extra field for the contact notes. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// NOTES
								/// </java-name>
								[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NOTES = "notes";
								/// <summary>
								///  <para>The extra field for the contact phone number. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// PHONE
								/// </java-name>
								[Dot42.DexImport("PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE = "phone";
								/// <summary>
								///  <para>The extra field for the contact phone number type. </para> <para>Type: Either an integer value from PhonesColumns, or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_TYPE = "phone_type";
								/// <summary>
								///  <para>The extra field for the phone isprimary flag. </para> <para>Type: boolean</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// PHONE_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("PHONE_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_ISPRIMARY = "phone_isprimary";
								/// <summary>
								///  <para>The extra field for an optional second contact phone number. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_PHONE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE = "secondary_phone";
								/// <summary>
								///  <para>The extra field for an optional second contact phone number type. </para> <para>Type: Either an integer value from PhonesColumns, or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE_TYPE = "secondary_phone_type";
								/// <summary>
								///  <para>The extra field for an optional third contact phone number. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_PHONE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE = "tertiary_phone";
								/// <summary>
								///  <para>The extra field for an optional third contact phone number type. </para> <para>Type: Either an integer value from PhonesColumns, or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE_TYPE = "tertiary_phone_type";
								/// <summary>
								///  <para>The extra field for the contact email address. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// EMAIL
								/// </java-name>
								[Dot42.DexImport("EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL = "email";
								/// <summary>
								///  <para>The extra field for the contact email type. </para> <para>Type: Either an integer value from ContactMethodsColumns or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_TYPE = "email_type";
								/// <summary>
								///  <para>The extra field for the email isprimary flag. </para> <para>Type: boolean</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// EMAIL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("EMAIL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_ISPRIMARY = "email_isprimary";
								/// <summary>
								///  <para>The extra field for an optional second contact email address. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL = "secondary_email";
								/// <summary>
								///  <para>The extra field for an optional second contact email type. </para> <para>Type: Either an integer value from ContactMethodsColumns or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL_TYPE = "secondary_email_type";
								/// <summary>
								///  <para>The extra field for an optional third contact email address. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL = "tertiary_email";
								/// <summary>
								///  <para>The extra field for an optional third contact email type. </para> <para>Type: Either an integer value from ContactMethodsColumns or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL_TYPE = "tertiary_email_type";
								/// <summary>
								///  <para>The extra field for the contact postal address. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// POSTAL
								/// </java-name>
								[Dot42.DexImport("POSTAL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL = "postal";
								/// <summary>
								///  <para>The extra field for the contact postal address type. </para> <para>Type: Either an integer value from ContactMethodsColumns or a string specifying a custom label.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// POSTAL_TYPE
								/// </java-name>
								[Dot42.DexImport("POSTAL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_TYPE = "postal_type";
								/// <summary>
								///  <para>The extra field for the postal isprimary flag. </para> <para>Type: boolean</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// POSTAL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("POSTAL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_ISPRIMARY = "postal_isprimary";
								/// <summary>
								///  <para>The extra field for an IM handle. </para> <para>Type: String</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// IM_HANDLE
								/// </java-name>
								[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_HANDLE = "im_handle";
								/// <summary>
								///  <para>The extra field for the IM protocol </para> <para>Type: the result of Contacts.ContactMethods#encodePredefinedImProtocol or Contacts.ContactMethods#encodeCustomImProtocol.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// IM_PROTOCOL
								/// </java-name>
								[Dot42.DexImport("IM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_PROTOCOL = "im_protocol";
								/// <summary>
								///  <para>The extra field for the IM isprimary flag. </para> <para>Type: boolean</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
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

						/// <summary>
						///  <para>Intents related to the Contacts app UI.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/Contacts$Intents$UI
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$Intents$UI", AccessFlags = 25)]
						public sealed partial class UI
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The action for the default contacts list tab.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_DEFAULT
								/// </java-name>
								[Dot42.DexImport("LIST_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_DEFAULT = "com.android.contacts.action.LIST_DEFAULT";
								/// <summary>
								///  <para>The action for the contacts list tab.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_GROUP_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_GROUP_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_GROUP_ACTION = "com.android.contacts.action.LIST_GROUP";
								/// <summary>
								///  <para>When in LIST_GROUP_ACTION mode, this is the group to display.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// GROUP_NAME_EXTRA_KEY
								/// </java-name>
								[Dot42.DexImport("GROUP_NAME_EXTRA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GROUP_NAME_EXTRA_KEY = "com.android.contacts.extra.GROUP";
								/// <summary>
								///  <para>The action for the all contacts list tab.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_ALL_CONTACTS_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_ALL_CONTACTS_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_ALL_CONTACTS_ACTION = "com.android.contacts.action.LIST_ALL_CONTACTS";
								/// <summary>
								///  <para>The action for the contacts with phone numbers list tab.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_CONTACTS_WITH_PHONES_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_CONTACTS_WITH_PHONES_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_CONTACTS_WITH_PHONES_ACTION = "com.android.contacts.action.LIST_CONTACTS_WITH_PHONES";
								/// <summary>
								///  <para>The action for the starred contacts list tab.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_STARRED_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_STARRED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_STARRED_ACTION = "com.android.contacts.action.LIST_STARRED";
								/// <summary>
								///  <para>The action for the frequent contacts list tab.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_FREQUENT_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_FREQUENT_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_FREQUENT_ACTION = "com.android.contacts.action.LIST_FREQUENT";
								/// <summary>
								///  <para>The action for the "strequent" contacts list tab. It first lists the starred contacts in alphabetical order and then the frequent contacts in descending order of the number of times they have been contacted.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// LIST_STREQUENT_ACTION
								/// </java-name>
								[Dot42.DexImport("LIST_STREQUENT_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LIST_STREQUENT_ACTION = "com.android.contacts.action.LIST_STREQUENT";
								/// <summary>
								///  <para>A key for to be used as an intent extra to set the activity title to a custom String value.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// TITLE_EXTRA_KEY
								/// </java-name>
								[Dot42.DexImport("TITLE_EXTRA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE_EXTRA_KEY = "com.android.contacts.extra.TITLE_EXTRA";
								/// <summary>
								///  <para>Activity Action: Display a filtered list of contacts </para> <para>Input: Extra field FILTER_TEXT_EXTRA_KEY is the text to use for filtering </para> <para>Output: Nothing.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// FILTER_CONTACTS_ACTION
								/// </java-name>
								[Dot42.DexImport("FILTER_CONTACTS_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FILTER_CONTACTS_ACTION = "com.android.contacts.action.FILTER_CONTACTS";
								/// <summary>
								///  <para>Used as an int extra field in FILTER_CONTACTS_ACTION intents to supply the text on which to filter.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
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

				/// <summary>
				///  <para>The extensions for a person  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Extensions
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Extensions", AccessFlags = 25)]
				public sealed partial class Extensions : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IExtensionsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of phones.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact_extensions";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single phone.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact_extensions";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "person, name ASC";
						/// <summary>
						///  <para>The ID of the person this phone number is assigned to. </para> <para>Type: INTEGER (long)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
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

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$ExtensionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ExtensionsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IExtensionsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The name of this extension. May not be null. There may be at most one row for each name. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <summary>
						///  <para>The value of this extension. May not be null. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$ExtensionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ExtensionsColumns", AccessFlags = 1545)]
				public partial interface IExtensionsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>The photos over all of the people  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Photos
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Photos", AccessFlags = 25)]
				public sealed partial class Photos : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPhotosColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "photo";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
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

				/// <summary>
				///  <para>Columns from the Photos table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PhotosColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhotosColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhotosColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The _SYNC_VERSION of the photo that was last downloaded </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCAL_VERSION
						/// </java-name>
						[Dot42.DexImport("LOCAL_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCAL_VERSION = "local_version";
						/// <summary>
						///  <para>The person this photo is associated with. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						/// <summary>
						///  <para>non-zero if a download is required and the photo isn't marked as a bad resource. You must specify this in the columns in order to use it in the where clause. </para> <para>Type: INTEGER(boolean)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DOWNLOAD_REQUIRED
						/// </java-name>
						[Dot42.DexImport("DOWNLOAD_REQUIRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DOWNLOAD_REQUIRED = "download_required";
						/// <summary>
						///  <para>non-zero if this photo is known to exist on the server </para> <para>Type: INTEGER(boolean)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXISTS_ON_SERVER
						/// </java-name>
						[Dot42.DexImport("EXISTS_ON_SERVER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXISTS_ON_SERVER = "exists_on_server";
						/// <summary>
						///  <para>Contains the description of the upload or download error from the previous attempt. If null then the previous attempt succeeded. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SYNC_ERROR
						/// </java-name>
						[Dot42.DexImport("SYNC_ERROR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_ERROR = "sync_error";
						/// <summary>
						///  <para>The image data, or null if there is no image. </para> <para>Type: BLOB</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "data";
				}

				/// <summary>
				///  <para>Columns from the Photos table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PhotosColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhotosColumns", AccessFlags = 1545)]
				public partial interface IPhotosColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>A sub directory of a single person that contains all of their Phones.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Organizations
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Organizations", AccessFlags = 25)]
				public sealed partial class Organizations : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IOrganizationColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "organizations";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "company, title, isprimary ASC";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Organizations() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

				}

				/// <summary>
				///  <para>Columns from the Organizations table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$OrganizationColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$OrganizationColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IOrganizationColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The type of the organizations. </para> <para>Type: INTEGER (one of the constants below)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_CUSTOM
						/// </java-name>
						[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
						public const int TYPE_CUSTOM = 0;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
						public const int TYPE_WORK = 1;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_OTHER
						/// </java-name>
						[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
						public const int TYPE_OTHER = 2;
						/// <summary>
						///  <para>The user provided label, only used if TYPE is TYPE_CUSTOM. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
						/// <summary>
						///  <para>The name of the company for this organization. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// COMPANY
						/// </java-name>
						[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COMPANY = "company";
						/// <summary>
						///  <para>The title within this organization. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <summary>
						///  <para>The person this organization is tied to. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						/// <summary>
						///  <para>Whether this is the primary organization </para> <para>Type: INTEGER (if set, non-0 means true)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ISPRIMARY
						/// </java-name>
						[Dot42.DexImport("ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ISPRIMARY = "isprimary";
				}

				/// <summary>
				///  <para>Columns from the Organizations table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$OrganizationColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$OrganizationColumns", AccessFlags = 1545)]
				public partial interface IOrganizationColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>The IM presence columns with some contacts specific columns mixed in.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PresenceColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPresenceColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The priority, an integer, used by XMPP presence </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// PRIORITY
						/// </java-name>
						[Dot42.DexImport("PRIORITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIORITY = "priority";
						/// <summary>
						///  <para>The server defined status. </para> <para>Type: INTEGER (one of the values below)</para>        
						/// </summary>
						/// <java-name>
						/// PRESENCE_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_STATUS = "mode";
						/// <summary>
						///  <para>Presence Status definition </para>        
						/// </summary>
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
						/// <summary>
						///  <para>The user defined status line. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// PRESENCE_CUSTOM_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_CUSTOM_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_CUSTOM_STATUS = "status";
						/// <summary>
						///  <para>The IM service the presence is coming from. Formatted using either Contacts.ContactMethods#encodePredefinedImProtocol or Contacts.ContactMethods#encodeCustomImProtocol. </para> <para>Type: STRING</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// IM_PROTOCOL
						/// </java-name>
						[Dot42.DexImport("IM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_PROTOCOL = "im_protocol";
						/// <summary>
						///  <para>The IM handle the presence item is for. The handle is scoped to the IM_PROTOCOL. </para> <para>Type: STRING</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// IM_HANDLE
						/// </java-name>
						[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_HANDLE = "im_handle";
						/// <summary>
						///  <para>The IM account for the local user that the presence data came from. </para> <para>Type: STRING</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// IM_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("IM_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_ACCOUNT = "im_account";
				}

				/// <summary>
				///  <para>The IM presence columns with some contacts specific columns mixed in.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PresenceColumns", AccessFlags = 1545)]
				public partial interface IPresenceColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>This table stores all non-phone contact methods and a reference to the person that the contact method belongs to.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$ContactMethods
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ContactMethods", AccessFlags = 25)]
				public sealed partial class ContactMethods : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IContactMethodsColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The column with latitude data for postal locations </para> <para>Type: REAL</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// POSTAL_LOCATION_LATITUDE
						/// </java-name>
						[Dot42.DexImport("POSTAL_LOCATION_LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string POSTAL_LOCATION_LATITUDE = "data";
						/// <summary>
						///  <para>The column with longitude data for postal locations </para> <para>Type: REAL</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// POSTAL_LOCATION_LONGITUDE
						/// </java-name>
						[Dot42.DexImport("POSTAL_LOCATION_LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string POSTAL_LOCATION_LONGITUDE = "aux_data";
						/// <summary>
						///  <para>The predefined IM protocol types. The protocol can either be non-present, one of these types, or a free-form string. These cases are encoded in the AUX_DATA column as: <ul> <li> <para>null</para></li> <li> <para>pre:&lt;an integer, one of the protocols below&gt;</para></li> <li> <para>custom:  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_AIM
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_AIM", "I", AccessFlags = 25)]
						public const int PROTOCOL_AIM = 0;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_MSN
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_MSN", "I", AccessFlags = 25)]
						public const int PROTOCOL_MSN = 1;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_YAHOO
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_YAHOO", "I", AccessFlags = 25)]
						public const int PROTOCOL_YAHOO = 2;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_SKYPE
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_SKYPE", "I", AccessFlags = 25)]
						public const int PROTOCOL_SKYPE = 3;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_QQ
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_QQ", "I", AccessFlags = 25)]
						public const int PROTOCOL_QQ = 4;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_GOOGLE_TALK
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_GOOGLE_TALK", "I", AccessFlags = 25)]
						public const int PROTOCOL_GOOGLE_TALK = 5;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_ICQ
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_ICQ", "I", AccessFlags = 25)]
						public const int PROTOCOL_ICQ = 6;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL_JABBER
						/// </java-name>
						[Dot42.DexImport("PROTOCOL_JABBER", "I", AccessFlags = 25)]
						public const int PROTOCOL_JABBER = 7;
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URL for sub-directory of e-mail addresses.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_EMAIL_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_EMAIL_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_EMAIL_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract phones. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact-methods";
						/// <summary>
						///  <para>The MIME type of a CONTENT_EMAIL_URI sub-directory of multiple Contacts#KIND_EMAIL entries.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_EMAIL_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_EMAIL_TYPE = "vnd.android.cursor.dir/email";
						/// <summary>
						///  <para>The MIME type of a CONTENT_EMAIL_URI sub-directory of multiple Contacts#KIND_POSTAL entries.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_POSTAL_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_POSTAL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_POSTAL_TYPE = "vnd.android.cursor.dir/postal-address";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI sub-directory of a single Contacts#KIND_EMAIL entry.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_EMAIL_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_EMAIL_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_EMAIL_ITEM_TYPE = "vnd.android.cursor.item/email";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI sub-directory of a single Contacts#KIND_POSTAL entry.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_POSTAL_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_POSTAL_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_POSTAL_ITEM_TYPE = "vnd.android.cursor.item/postal-address";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI sub-directory of a single Contacts#KIND_IM entry.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_IM_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_IM_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_IM_ITEM_TYPE = "vnd.android.cursor.item/jabber-im";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <summary>
						///  <para>The ID of the person this contact method is assigned to. </para> <para>Type: INTEGER (long)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal ContactMethods() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// encodePredefinedImProtocol
						/// </java-name>
						[Dot42.DexImport("encodePredefinedImProtocol", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string EncodePredefinedImProtocol(int protocol) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// encodeCustomImProtocol
						/// </java-name>
						[Dot42.DexImport("encodeCustomImProtocol", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
						public static string EncodeCustomImProtocol(string protocolString) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// decodeImProtocol
						/// </java-name>
						[Dot42.DexImport("decodeImProtocol", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 9)]
						public static object DecodeImProtocol(string encodedString) /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;IILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int kind, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <summary>
						///  <para>Add a longitude and latitude location to a postal address.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// addPostalLocation
						/// </java-name>
						[Dot42.DexImport("addPostalLocation", "(Landroid/content/Context;JDD)V", AccessFlags = 1)]
						public void AddPostalLocation(global::Android.Content.Context context, long postalId, double latitude, double longitude) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Columns from the ContactMethods table that other tables join into themseleves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$ContactMethodsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ContactMethodsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactMethodsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The kind of the the contact method. For example, email address, postal address, etc. </para> <para>Type: INTEGER (one of the values below)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// KIND
						/// </java-name>
						[Dot42.DexImport("KIND", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KIND = "kind";
						/// <summary>
						///  <para>The type of the contact method, must be one of the types below. </para> <para>Type: INTEGER (one of the values below)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_CUSTOM
						/// </java-name>
						[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
						public const int TYPE_CUSTOM = 0;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_HOME
						/// </java-name>
						[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
						public const int TYPE_HOME = 1;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
						public const int TYPE_WORK = 2;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_OTHER
						/// </java-name>
						[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
						public const int TYPE_OTHER = 3;
						/// <summary>
						///  <para>The user defined label for the the contact method. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
						/// <summary>
						///  <para>The data for the contact method. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "data";
						/// <summary>
						///  <para>Auxiliary data for the contact method. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// AUX_DATA
						/// </java-name>
						[Dot42.DexImport("AUX_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUX_DATA = "aux_data";
						/// <summary>
						///  <para>Whether this is the primary organization </para> <para>Type: INTEGER (if set, non-0 means true)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ISPRIMARY
						/// </java-name>
						[Dot42.DexImport("ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ISPRIMARY = "isprimary";
				}

				/// <summary>
				///  <para>Columns from the ContactMethods table that other tables join into themseleves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$ContactMethodsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$ContactMethodsColumns", AccessFlags = 1545)]
				public partial interface IContactMethodsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$GroupMembership
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$GroupMembership", AccessFlags = 25)]
				public sealed partial class GroupMembership : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IGroupsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// RAW_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("RAW_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri RAW_CONTENT_URI;
						/// <summary>
						///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "groupmembership";
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of all person groups.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contactsgroupmembership";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single person group.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contactsgroupmembership";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "group_id ASC";
						/// <summary>
						///  <para>The row id of the accounts group. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// GROUP_ID
						/// </java-name>
						[Dot42.DexImport("GROUP_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_ID = "group_id";
						/// <summary>
						///  <para>The sync id of the group. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// GROUP_SYNC_ID
						/// </java-name>
						[Dot42.DexImport("GROUP_SYNC_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_SYNC_ID = "group_sync_id";
						/// <summary>
						///  <para>The account of the group. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// GROUP_SYNC_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("GROUP_SYNC_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_SYNC_ACCOUNT = "group_sync_account";
						/// <summary>
						///  <para>The account type of the group. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// GROUP_SYNC_ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("GROUP_SYNC_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_SYNC_ACCOUNT_TYPE = "group_sync_account_type";
						/// <summary>
						///  <para>The row id of the person. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
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

				/// <summary>
				///  <para>This table stores phone numbers and a reference to the person that the contact method belongs to. Phone numbers are stored separately from other contact methods to make caller ID lookup more efficient.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Phones
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Phones", AccessFlags = 25)]
				public sealed partial class Phones : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPhonesColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URL for filtering phone numbers  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_FILTER_URL
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URL", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URL;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of phones.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/phone";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single phone.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/phone";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <summary>
						///  <para>The ID of the person this phone number is assigned to. </para> <para>Type: INTEGER (long)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PERSON_ID
						/// </java-name>
						[Dot42.DexImport("PERSON_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSON_ID = "person";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Phones() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljav" +
    "a/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int type, global::Java.Lang.ICharSequence label, global::Java.Lang.ICharSequence[] labelArray) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getDisplayLabel
						/// </java-name>
						[Dot42.DexImport("getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 25)]
						public static global::Java.Lang.ICharSequence GetDisplayLabel(global::Android.Content.Context context, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

				}

				/// <summary>
				///  <para>Columns from the Phones table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PhonesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhonesColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhonesColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The type of the the phone number. </para> <para>Type: INTEGER (one of the constants below)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_CUSTOM
						/// </java-name>
						[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
						public const int TYPE_CUSTOM = 0;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_HOME
						/// </java-name>
						[Dot42.DexImport("TYPE_HOME", "I", AccessFlags = 25)]
						public const int TYPE_HOME = 1;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_MOBILE
						/// </java-name>
						[Dot42.DexImport("TYPE_MOBILE", "I", AccessFlags = 25)]
						public const int TYPE_MOBILE = 2;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_WORK", "I", AccessFlags = 25)]
						public const int TYPE_WORK = 3;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_FAX_WORK
						/// </java-name>
						[Dot42.DexImport("TYPE_FAX_WORK", "I", AccessFlags = 25)]
						public const int TYPE_FAX_WORK = 4;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_FAX_HOME
						/// </java-name>
						[Dot42.DexImport("TYPE_FAX_HOME", "I", AccessFlags = 25)]
						public const int TYPE_FAX_HOME = 5;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_PAGER
						/// </java-name>
						[Dot42.DexImport("TYPE_PAGER", "I", AccessFlags = 25)]
						public const int TYPE_PAGER = 6;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TYPE_OTHER
						/// </java-name>
						[Dot42.DexImport("TYPE_OTHER", "I", AccessFlags = 25)]
						public const int TYPE_OTHER = 7;
						/// <summary>
						///  <para>The user provided label for the phone number, only used if TYPE is TYPE_CUSTOM. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
						/// <summary>
						///  <para>The phone number as the user entered it. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <summary>
						///  <para>The normalized phone number </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NUMBER_KEY
						/// </java-name>
						[Dot42.DexImport("NUMBER_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER_KEY = "number_key";
						/// <summary>
						///  <para>Whether this is the primary phone number </para> <para>Type: INTEGER (if set, non-0 means true)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ISPRIMARY
						/// </java-name>
						[Dot42.DexImport("ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ISPRIMARY = "isprimary";
				}

				/// <summary>
				///  <para>Columns from the Phones table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PhonesColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PhonesColumns", AccessFlags = 1545)]
				public partial interface IPhonesColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>This table contains the groups for an account.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Groups
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Groups", AccessFlags = 25)]
				public sealed partial class Groups : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IGroupsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URL for the table that holds the deleted groups.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DELETED_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("DELETED_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DELETED_CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of groups.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contactsgroup";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single group.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contactsgroup";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// GROUP_ANDROID_STARRED
						/// </java-name>
						[Dot42.DexImport("GROUP_ANDROID_STARRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_ANDROID_STARRED = "Starred in Android";
						/// <summary>
						///  <para>The "My Contacts" system group.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
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

				/// <summary>
				///  <para>Columns from the groups table.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$GroupsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IGroupsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The group name. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <summary>
						///  <para>Notes about the group. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NOTES
						/// </java-name>
						[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTES = "notes";
						/// <summary>
						///  <para>Whether this group should be synced if the SYNC_EVERYTHING settings is false for this group's account. </para> <para>Type: INTEGER (boolean)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SHOULD_SYNC
						/// </java-name>
						[Dot42.DexImport("SHOULD_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOULD_SYNC = "should_sync";
						/// <summary>
						///  <para>The ID of this group if it is a System Group, null otherwise. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SYSTEM_ID
						/// </java-name>
						[Dot42.DexImport("SYSTEM_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYSTEM_ID = "system_id";
				}

				/// <summary>
				///  <para>Columns from the groups table.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$GroupsColumns", AccessFlags = 1545)]
				public partial interface IGroupsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>This table contains people.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$People
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$People", AccessFlags = 25)]
				public sealed partial class People : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPeopleColumns, global::Android.Provider.Contacts.IPhonesColumns, global::Android.Provider.Contacts.IPresenceColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URL for filtering people by name. The filter argument should be passed as an additional path segment after this URI.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						/// <summary>
						///  <para>The content:// style URL for the table that holds the deleted contacts.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DELETED_CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("DELETED_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DELETED_CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of people.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/person";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single person.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/person";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "name ASC";
						/// <summary>
						///  <para>The ID of the persons preferred phone number. </para> <para>Type: INTEGER (foreign key to phones table on the _ID field)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PRIMARY_PHONE_ID
						/// </java-name>
						[Dot42.DexImport("PRIMARY_PHONE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIMARY_PHONE_ID = "primary_phone";
						/// <summary>
						///  <para>The ID of the persons preferred email. </para> <para>Type: INTEGER (foreign key to contact_methods table on the _ID field)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PRIMARY_EMAIL_ID
						/// </java-name>
						[Dot42.DexImport("PRIMARY_EMAIL_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIMARY_EMAIL_ID = "primary_email";
						/// <summary>
						///  <para>The ID of the persons preferred organization. </para> <para>Type: INTEGER (foreign key to organizations table on the _ID field)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PRIMARY_ORGANIZATION_ID
						/// </java-name>
						[Dot42.DexImport("PRIMARY_ORGANIZATION_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRIMARY_ORGANIZATION_ID = "primary_organization";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal People() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Mark a person as having been contacted.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// markAsContacted
						/// </java-name>
						[Dot42.DexImport("markAsContacted", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
						public static void MarkAsContacted(global::Android.Content.ContentResolver resolver, long personId) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Adds a person to the My Contacts group.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>the URI of the group membership row </para>
						/// </returns>
						/// <java-name>
						/// addToMyContactsGroup
						/// </java-name>
						[Dot42.DexImport("addToMyContactsGroup", "(Landroid/content/ContentResolver;J)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri AddToMyContactsGroup(global::Android.Content.ContentResolver resolver, long personId) /* MethodBuilder.Create */ 
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

						/// <summary>
						///  <para>Creates a new contacts and adds it to the "My Contacts" group.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>the URI of the contact, or null if the operation fails </para>
						/// </returns>
						/// <java-name>
						/// createPersonInMyContactsGroup
						/// </java-name>
						[Dot42.DexImport("createPersonInMyContactsGroup", "(Landroid/content/ContentResolver;Landroid/content/ContentValues;)Landroid/net/Ur" +
    "i;", AccessFlags = 9)]
						public static global::Android.Net.Uri CreatePersonInMyContactsGroup(global::Android.Content.ContentResolver resolver, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// queryGroups
						/// </java-name>
						[Dot42.DexImport("queryGroups", "(Landroid/content/ContentResolver;J)Landroid/database/Cursor;", AccessFlags = 9)]
						public static global::Android.Database.ICursor QueryGroups(global::Android.Content.ContentResolver resolver, long person) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

						/// <summary>
						///  <para>Set the photo for this person. data may be null  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setPhotoData
						/// </java-name>
						[Dot42.DexImport("setPhotoData", "(Landroid/content/ContentResolver;Landroid/net/Uri;[B)V", AccessFlags = 9)]
						public static void SetPhotoData(global::Android.Content.ContentResolver cr, global::Android.Net.Uri person, sbyte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Set the photo for this person. data may be null  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setPhotoData
						/// </java-name>
						[Dot42.DexImport("setPhotoData", "(Landroid/content/ContentResolver;Landroid/net/Uri;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void SetPhotoData(global::Android.Content.ContentResolver cr, global::Android.Net.Uri person, byte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Opens an InputStream for the person's photo and returns the photo as a Bitmap. If the person's photo isn't present returns the placeholderImageResource instead.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// openContactPhotoInputStream
						/// </java-name>
						[Dot42.DexImport("openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;", AccessFlags = 9)]
						public static global::Java.IO.InputStream OpenContactPhotoInputStream(global::Android.Content.ContentResolver cr, global::Android.Net.Uri person) /* MethodBuilder.Create */ 
						{
								return default(global::Java.IO.InputStream);
						}

						/// <summary>
						///  <para>Opens an InputStream for the person's photo and returns the photo as a Bitmap. If the person's photo isn't present returns the placeholderImageResource instead.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// loadContactPhoto
						/// </java-name>
						[Dot42.DexImport("loadContactPhoto", "(Landroid/content/Context;Landroid/net/Uri;ILandroid/graphics/BitmapFactory$Optio" +
    "ns;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
						public static global::Android.Graphics.Bitmap LoadContactPhoto(global::Android.Content.Context context, global::Android.Net.Uri person, int placeholderImageResource, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Bitmap);
						}

						/// <summary>
						///  <para>The extensions for a person  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/Contacts$People$Extensions
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$People$Extensions", AccessFlags = 9)]
						public partial class Extensions : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IExtensionsColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "extensions";
								/// <summary>
								///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "name ASC";
								/// <summary>
								///  <para>The ID of the person this phone number is assigned to. </para> <para>Type: INTEGER (long)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
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

						/// <summary>
						///  <para>A subdirectory of a single person that contains all of their ContactMethods.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/Contacts$People$ContactMethods
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$People$ContactMethods", AccessFlags = 25)]
						public sealed partial class ContactMethods : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IContactMethodsColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "contact_methods";
								/// <summary>
								///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
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

						/// <summary>
						///  <para>A sub directory of a single person that contains all of their Phones.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/Contacts$People$Phones
						/// </java-name>
						[Dot42.DexImport("android/provider/Contacts$People$Phones", AccessFlags = 25)]
						public sealed partial class Phones : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.IPhonesColumns, global::Android.Provider.Contacts.IPeopleColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "phones";
								/// <summary>
								///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
								/// </summary>
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

				/// <summary>
				///  <para>Columns from the People table that other tables join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PeopleColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PeopleColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPeopleColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The person's name. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NAME
						/// </java-name>
						[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NAME = "name";
						/// <summary>
						///  <para>Phonetic equivalent of the person's name, in a locale-dependent character set (e.g. hiragana for Japanese). Used for pronunciation and/or collation in some languages. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PHONETIC_NAME
						/// </java-name>
						[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONETIC_NAME = "phonetic_name";
						/// <summary>
						///  <para>The display name. If name is not null name, else if number is not null number, else if email is not null email. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "display_name";
						/// <summary>
						///  <para>Notes about the person. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NOTES
						/// </java-name>
						[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTES = "notes";
						/// <summary>
						///  <para>The number of times a person has been contacted </para> <para>Type: INTEGER</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TIMES_CONTACTED
						/// </java-name>
						[Dot42.DexImport("TIMES_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMES_CONTACTED = "times_contacted";
						/// <summary>
						///  <para>The last time a person was contacted. </para> <para>Type: INTEGER</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LAST_TIME_CONTACTED
						/// </java-name>
						[Dot42.DexImport("LAST_TIME_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LAST_TIME_CONTACTED = "last_time_contacted";
						/// <summary>
						///  <para>A custom ringtone associated with a person. Not always present. </para> <para>Type: TEXT (URI to the ringtone)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CUSTOM_RINGTONE
						/// </java-name>
						[Dot42.DexImport("CUSTOM_RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CUSTOM_RINGTONE = "custom_ringtone";
						/// <summary>
						///  <para>Whether the person should always be sent to voicemail. Not always present. </para> <para>Type: INTEGER (0 for false, 1 for true)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SEND_TO_VOICEMAIL
						/// </java-name>
						[Dot42.DexImport("SEND_TO_VOICEMAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEND_TO_VOICEMAIL = "send_to_voicemail";
						/// <summary>
						///  <para>Is the contact starred? </para> <para>Type: INTEGER (boolean)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// STARRED
						/// </java-name>
						[Dot42.DexImport("STARRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STARRED = "starred";
						/// <summary>
						///  <para>The server version of the photo </para> <para>Type: TEXT (the version number portion of the photo URI)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_VERSION
						/// </java-name>
						[Dot42.DexImport("PHOTO_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_VERSION = "photo_version";
				}

				/// <summary>
				///  <para>Columns from the People table that other tables join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$PeopleColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$PeopleColumns", AccessFlags = 1545)]
				public partial interface IPeopleColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>The settings over all of the people  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$Settings
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$Settings", AccessFlags = 25)]
				public sealed partial class Settings : global::Android.Provider.IBaseColumns, global::Android.Provider.Contacts.ISettingsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The directory twig for this sub-table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_DIRECTORY = "settings";
						/// <summary>
						///  <para>The default sort order for this table  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "key ASC";
						/// <summary>
						///  <para>A setting that is used to indicate if we should sync down all groups for the specified account. For this setting the _SYNC_ACCOUNT column must be set. If this isn't set then we will only sync the groups whose SHOULD_SYNC column is set to true. </para> <para>This is a boolean setting. It is true if it is set and it is anything other than the emptry string or "0".  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SYNC_EVERYTHING
						/// </java-name>
						[Dot42.DexImport("SYNC_EVERYTHING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC_EVERYTHING = "syncEverything";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Settings() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getSetting
						/// </java-name>
						[Dot42.DexImport("getSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Ljava/lang" +
    "/String;", AccessFlags = 9)]
						public static string GetSetting(global::Android.Content.ContentResolver cr, string account, string key) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setSetting
						/// </java-name>
						[Dot42.DexImport("setSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/" +
    "String;)V", AccessFlags = 9)]
						public static void SetSetting(global::Android.Content.ContentResolver cr, string account, string key, string value) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Columns from the Settings table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$SettingsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISettingsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The _SYNC_ACCOUNT to which this setting corresponds. This may be null. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// _SYNC_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("_SYNC_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string _SYNC_ACCOUNT = "_sync_account";
						/// <summary>
						///  <para>The _SYNC_ACCOUNT_TYPE to which this setting corresponds. This may be null. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// _SYNC_ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("_SYNC_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string _SYNC_ACCOUNT_TYPE = "_sync_account_type";
						/// <summary>
						///  <para>The key of this setting. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// KEY
						/// </java-name>
						[Dot42.DexImport("KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY = "key";
						/// <summary>
						///  <para>The value of this setting. </para> <para>Type: TEXT</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// VALUE
						/// </java-name>
						[Dot42.DexImport("VALUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VALUE = "value";
				}

				/// <summary>
				///  <para>Columns from the Settings table that other columns join into themselves.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>see android.provider.ContactsContract </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/Contacts$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/Contacts$SettingsColumns", AccessFlags = 1545)]
				public partial interface ISettingsColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <summary>
		///  <para>The contract between the contacts provider and applications. Contains definitions for the supported URIs and columns. These APIs supersede Contacts. </para> <para> <h3>Overview</h3></para> <para>ContactsContract defines an extensible database of contact-related information. Contact information is stored in a three-tier data model: </para> <para> <ul> <li> <para>A row in the Data table can store any kind of personal data, such as a phone number or email addresses. The set of data kinds that can be stored in this table is open-ended. There is a predefined set of common kinds, but any application can add its own data kinds.  </para></li> <li> <para>A row in the RawContacts table represents a set of data describing a person and associated with a single account (for example, one of the user's Gmail accounts).  </para></li> <li> <para>A row in the Contacts table represents an aggregate of one or more RawContacts presumably describing the same person. When data in or associated with the RawContacts table is changed, the affected aggregate contacts are updated as necessary.  </para></li></ul></para> <para>Other tables include: </para> <para> <ul> <li> <para>Groups, which contains information about raw contact groups such as Gmail contact groups. The current API does not support the notion of groups spanning multiple accounts.  </para></li> <li> <para>StatusUpdates, which contains social status updates including IM availability.  </para></li> <li> <para>AggregationExceptions, which is used for manual aggregation and disaggregation of raw contacts  </para></li> <li> <para>Settings, which contains visibility and sync settings for accounts and groups.  </para></li> <li> <para>SyncState, which contains free-form data maintained on behalf of sync adapters  </para></li> <li> <para>PhoneLookup, which is used for quick caller-ID lookup </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/provider/ContactsContract
		/// </java-name>
		[Dot42.DexImport("android/provider/ContactsContract", AccessFlags = 49)]
		public sealed partial class ContactsContract
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The authority for the contacts provider </para>        
				/// </summary>
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "com.android.contacts";
				/// <summary>
				///  <para>A content:// style uri to the authority for the contacts provider </para>        
				/// </summary>
				/// <java-name>
				/// AUTHORITY_URI
				/// </java-name>
				[Dot42.DexImport("AUTHORITY_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri AUTHORITY_URI;
				/// <summary>
				///  <para>An optional URI parameter for insert, update, or delete queries that allows the caller to specify that it is a sync adapter. The default value is false. If true RawContacts#DIRTY is not automatically set and the "syncToNetwork" parameter is set to false when calling ContentResolver#notifyChange(android.net.Uri, android.database.ContentObserver, boolean). This prevents an unnecessary extra synchronization, see the discussion of the delete operation in RawContacts. </para>        
				/// </summary>
				/// <java-name>
				/// CALLER_IS_SYNCADAPTER
				/// </java-name>
				[Dot42.DexImport("CALLER_IS_SYNCADAPTER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CALLER_IS_SYNCADAPTER = "caller_is_syncadapter";
				/// <summary>
				///  <para>Query parameter that should be used by the client to access a specific Directory. The parameter value should be the _ID of the corresponding directory, e.g.  <c>content://com.android.contacts/data/emails/filter/acme?directory=3 </c> </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_PARAM_KEY
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_PARAM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DIRECTORY_PARAM_KEY = "directory";
				/// <summary>
				///  <para>A query parameter that limits the number of results returned. The parameter value should be an integer. </para>        
				/// </summary>
				/// <java-name>
				/// LIMIT_PARAM_KEY
				/// </java-name>
				[Dot42.DexImport("LIMIT_PARAM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LIMIT_PARAM_KEY = "limit";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContactsContract() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Contains helper classes used to create or manage Intents that involve contacts. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$Intents
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Intents", AccessFlags = 25)]
				public sealed partial class Intents
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This is the intent that is fired when a search suggestion is clicked on. </para>        
						/// </summary>
						/// <java-name>
						/// SEARCH_SUGGESTION_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED";
						/// <summary>
						///  <para>This is the intent that is fired when a search suggestion for dialing a number is clicked on. </para>        
						/// </summary>
						/// <java-name>
						/// SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED";
						/// <summary>
						///  <para>This is the intent that is fired when a search suggestion for creating a contact is clicked on. </para>        
						/// </summary>
						/// <java-name>
						/// SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
						/// </java-name>
						[Dot42.DexImport("SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED = "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED";
						/// <summary>
						///  <para>Starts an Activity that lets the user pick a contact to attach an image to. After picking the contact it launches the image cropper in face detection mode. </para>        
						/// </summary>
						/// <java-name>
						/// ATTACH_IMAGE
						/// </java-name>
						[Dot42.DexImport("ATTACH_IMAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ATTACH_IMAGE = "com.android.contacts.action.ATTACH_IMAGE";
						/// <summary>
						///  <para>Takes as input a data URI with a mailto: or tel: scheme. If a single contact exists with the given data it will be shown. If no contact exists, a dialog will ask the user if they want to create a new contact with the provided details filled in. If multiple contacts share the data the user will be prompted to pick which contact they want to view. </para> <para>For  <code>mailto:</code> URIs, the scheme specific portion must be a raw email address, such as one built using Uri#fromParts(String, String, String). </para> <para>For  <code>tel:</code> URIs, the scheme specific portion is compared to existing numbers using the standard caller ID lookup algorithm. The number must be properly encoded, for example using Uri#fromParts(String, String, String). </para> <para>Any extras from the Insert class will be passed along to the create activity if there are no contacts to show. </para> <para>Passing true for the EXTRA_FORCE_CREATE extra will skip prompting the user when the contact doesn't exist. </para>        
						/// </summary>
						/// <java-name>
						/// SHOW_OR_CREATE_CONTACT
						/// </java-name>
						[Dot42.DexImport("SHOW_OR_CREATE_CONTACT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_OR_CREATE_CONTACT = "com.android.contacts.action.SHOW_OR_CREATE_CONTACT";
						/// <summary>
						///  <para>Used with SHOW_OR_CREATE_CONTACT to force creating a new contact if no matching contact found. Otherwise, default behavior is to prompt user with dialog before creating. </para> <para>Type: BOOLEAN </para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_FORCE_CREATE
						/// </java-name>
						[Dot42.DexImport("EXTRA_FORCE_CREATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_FORCE_CREATE = "com.android.contacts.action.FORCE_CREATE";
						/// <summary>
						///  <para>Used with SHOW_OR_CREATE_CONTACT to specify an exact description to be shown when prompting user about creating a new contact. </para> <para>Type: STRING </para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_CREATE_DESCRIPTION
						/// </java-name>
						[Dot42.DexImport("EXTRA_CREATE_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CREATE_DESCRIPTION = "com.android.contacts.action.CREATE_DESCRIPTION";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Intents() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Convenience class that contains string constants used to create contact Intents. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$Intents$Insert
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Intents$Insert", AccessFlags = 25)]
						public sealed partial class Insert
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The action code to use when adding a contact </para>        
								/// </summary>
								/// <java-name>
								/// ACTION
								/// </java-name>
								[Dot42.DexImport("ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ACTION = "android.intent.action.INSERT";
								/// <summary>
								///  <para>If present, forces a bypass of quick insert mode. </para>        
								/// </summary>
								/// <java-name>
								/// FULL_MODE
								/// </java-name>
								[Dot42.DexImport("FULL_MODE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FULL_MODE = "full_mode";
								/// <summary>
								///  <para>The extra field for the contact name. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
								/// <summary>
								///  <para>The extra field for the contact phonetic name. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// PHONETIC_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_NAME = "phonetic_name";
								/// <summary>
								///  <para>The extra field for the contact company. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// COMPANY
								/// </java-name>
								[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPANY = "company";
								/// <summary>
								///  <para>The extra field for the contact job title. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// JOB_TITLE
								/// </java-name>
								[Dot42.DexImport("JOB_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string JOB_TITLE = "job_title";
								/// <summary>
								///  <para>The extra field for the contact notes. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// NOTES
								/// </java-name>
								[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NOTES = "notes";
								/// <summary>
								///  <para>The extra field for the contact phone number. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// PHONE
								/// </java-name>
								[Dot42.DexImport("PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE = "phone";
								/// <summary>
								///  <para>The extra field for the contact phone number type. </para> <para>Type: Either an integer value from CommonDataKinds.Phone, or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_TYPE = "phone_type";
								/// <summary>
								///  <para>The extra field for the phone isprimary flag. </para> <para>Type: boolean</para>        
								/// </summary>
								/// <java-name>
								/// PHONE_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("PHONE_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONE_ISPRIMARY = "phone_isprimary";
								/// <summary>
								///  <para>The extra field for an optional second contact phone number. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_PHONE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE = "secondary_phone";
								/// <summary>
								///  <para>The extra field for an optional second contact phone number type. </para> <para>Type: Either an integer value from CommonDataKinds.Phone, or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_PHONE_TYPE = "secondary_phone_type";
								/// <summary>
								///  <para>The extra field for an optional third contact phone number. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_PHONE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE = "tertiary_phone";
								/// <summary>
								///  <para>The extra field for an optional third contact phone number type. </para> <para>Type: Either an integer value from CommonDataKinds.Phone, or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_PHONE_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_PHONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_PHONE_TYPE = "tertiary_phone_type";
								/// <summary>
								///  <para>The extra field for the contact email address. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// EMAIL
								/// </java-name>
								[Dot42.DexImport("EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL = "email";
								/// <summary>
								///  <para>The extra field for the contact email type. </para> <para>Type: Either an integer value from CommonDataKinds.Email or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_TYPE = "email_type";
								/// <summary>
								///  <para>The extra field for the email isprimary flag. </para> <para>Type: boolean</para>        
								/// </summary>
								/// <java-name>
								/// EMAIL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("EMAIL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EMAIL_ISPRIMARY = "email_isprimary";
								/// <summary>
								///  <para>The extra field for an optional second contact email address. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL = "secondary_email";
								/// <summary>
								///  <para>The extra field for an optional second contact email type. </para> <para>Type: Either an integer value from CommonDataKinds.Email or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// SECONDARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("SECONDARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SECONDARY_EMAIL_TYPE = "secondary_email_type";
								/// <summary>
								///  <para>The extra field for an optional third contact email address. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_EMAIL
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL = "tertiary_email";
								/// <summary>
								///  <para>The extra field for an optional third contact email type. </para> <para>Type: Either an integer value from CommonDataKinds.Email or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// TERTIARY_EMAIL_TYPE
								/// </java-name>
								[Dot42.DexImport("TERTIARY_EMAIL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TERTIARY_EMAIL_TYPE = "tertiary_email_type";
								/// <summary>
								///  <para>The extra field for the contact postal address. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// POSTAL
								/// </java-name>
								[Dot42.DexImport("POSTAL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL = "postal";
								/// <summary>
								///  <para>The extra field for the contact postal address type. </para> <para>Type: Either an integer value from CommonDataKinds.StructuredPostal or a string specifying a custom label.</para>        
								/// </summary>
								/// <java-name>
								/// POSTAL_TYPE
								/// </java-name>
								[Dot42.DexImport("POSTAL_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_TYPE = "postal_type";
								/// <summary>
								///  <para>The extra field for the postal isprimary flag. </para> <para>Type: boolean</para>        
								/// </summary>
								/// <java-name>
								/// POSTAL_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("POSTAL_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTAL_ISPRIMARY = "postal_isprimary";
								/// <summary>
								///  <para>The extra field for an IM handle. </para> <para>Type: String</para>        
								/// </summary>
								/// <java-name>
								/// IM_HANDLE
								/// </java-name>
								[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_HANDLE = "im_handle";
								/// <summary>
								///  <para>The extra field for the IM protocol </para>        
								/// </summary>
								/// <java-name>
								/// IM_PROTOCOL
								/// </java-name>
								[Dot42.DexImport("IM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_PROTOCOL = "im_protocol";
								/// <summary>
								///  <para>The extra field for the IM isprimary flag. </para> <para>Type: boolean</para>        
								/// </summary>
								/// <java-name>
								/// IM_ISPRIMARY
								/// </java-name>
								[Dot42.DexImport("IM_ISPRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IM_ISPRIMARY = "im_isprimary";
								/// <summary>
								///  <para>The extra field that allows the client to supply multiple rows of arbitrary data for a single contact created using the Intent#ACTION_INSERT or edited using Intent#ACTION_EDIT. It is an ArrayList of ContentValues, one per data row. Supplying this extra is similar to inserting multiple rows into the Data table, except the user gets a chance to see and edit them before saving. Each ContentValues object must have a value for Data#MIMETYPE. If supplied values are not visible in the editor UI, they will be dropped. Duplicate data will dropped. Some fields like Email.TYPE may be automatically adjusted to comply with the constraints of the specific account type. For example, an Exchange contact can only have one phone numbers of type Home, so the contact editor may choose a different type for this phone number to avoid dropping the valueable part of the row, which is the phone number. </para> <para>Example:  <pre>
								///  ArrayList&lt;ContentValues&gt; data = new ArrayList&lt;ContentValues&gt;();</pre></para> <para> <pre> ContentValues row1 = new ContentValues();
								///  row1.put(Data.MIMETYPE, Organization.CONTENT_ITEM_TYPE);
								///  row1.put(Organization.COMPANY, "Android");
								///  data.add(row1);</pre></para> <para> <pre> ContentValues row2 = new ContentValues();
								///  row2.put(Data.MIMETYPE, Email.CONTENT_ITEM_TYPE);
								///  row2.put(Email.TYPE, Email.TYPE_CUSTOM);
								///  row2.put(Email.LABEL, "Green Bot");
								///  row2.put(Email.ADDRESS, "android@android.com");
								///  data.add(row2);</pre></para> <para> <pre> Intent intent = new Intent(Intent.ACTION_INSERT, Contacts.CONTENT_URI);
								///  intent.putParcelableArrayListExtra(Insert.DATA, data);</pre></para> <para> <pre> startActivity(intent);
								/// </pre> </para>        
								/// </summary>
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

				/// <summary>
				///  <para>Helper methods to display QuickContact dialogs that allow users to pivot on a specific Contacts entry. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$QuickContact
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$QuickContact", AccessFlags = 25)]
				public sealed partial class QuickContact
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Small QuickContact mode, usually presented with minimal actions. </para>        
						/// </summary>
						/// <java-name>
						/// MODE_SMALL
						/// </java-name>
						[Dot42.DexImport("MODE_SMALL", "I", AccessFlags = 25)]
						public const int MODE_SMALL = 1;
						/// <summary>
						///  <para>Medium QuickContact mode, includes actions and light summary describing the Contacts entry being shown. This may include social status and presence details. </para>        
						/// </summary>
						/// <java-name>
						/// MODE_MEDIUM
						/// </java-name>
						[Dot42.DexImport("MODE_MEDIUM", "I", AccessFlags = 25)]
						public const int MODE_MEDIUM = 2;
						/// <summary>
						///  <para>Large QuickContact mode, includes actions and larger, card-like summary of the Contacts entry being shown. This may include detailed information, such as a photo. </para>        
						/// </summary>
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
						public static void ShowQuickContact(global::Android.Content.Context context, global::Android.Views.View view, global::Android.Net.Uri uri, int int32, string[] @string) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Contacts-specific settings for various Account's. </para> <para> <h2>Columns</h2></para> <para> <table> <row> <entry> <para>Settings  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>ACCOUNT_NAME </para></entry> <entry> <para>read/write-once </para></entry> <entry> <para>The name of the account instance to which this row belongs.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>ACCOUNT_TYPE </para></entry> <entry> <para>read/write-once </para></entry> <entry> <para>The type of account to which this row belongs, which when paired with ACCOUNT_NAME identifies a specific account.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SHOULD_SYNC </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Depending on the mode defined by the sync-adapter, this flag controls the top-level sync behavior for this data source.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>UNGROUPED_VISIBLE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Flag indicating if contacts without any CommonDataKinds.GroupMembership entries should be visible in any user interface.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>ANY_UNSYNCED </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Read-only flag indicating if this SHOULD_SYNC or any Groups#SHOULD_SYNC under this account have been marked as unsynced.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>UNGROUPED_COUNT </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Read-only count of Contacts from a specific source that have no CommonDataKinds.GroupMembership entries.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>UNGROUPED_WITH_PHONES </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Read-only count of Contacts from a specific source that have no CommonDataKinds.GroupMembership entries, and also have phone numbers.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$Settings
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Settings", AccessFlags = 25)]
				public sealed partial class Settings : global::Android.Provider.ContactsContract.ISettingsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME-type of CONTENT_URI providing a directory of settings. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/setting";
						/// <summary>
						///  <para>The MIME-type of CONTENT_URI providing a single setting. </para>        
						/// </summary>
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

				/// <summary>
				///  <para> <para>Settings </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SettingsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISettingsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The name of the account instance to which this row belongs. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <summary>
						///  <para>The type of account to which this row belongs, which when paired with ACCOUNT_NAME identifies a specific account. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <summary>
						///  <para>Depending on the mode defined by the sync-adapter, this flag controls the top-level sync behavior for this data source. </para> <para>Type: INTEGER (boolean) </para>        
						/// </summary>
						/// <java-name>
						/// SHOULD_SYNC
						/// </java-name>
						[Dot42.DexImport("SHOULD_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOULD_SYNC = "should_sync";
						/// <summary>
						///  <para>Flag indicating if contacts without any CommonDataKinds.GroupMembership entries should be visible in any user interface. </para> <para>Type: INTEGER (boolean) </para>        
						/// </summary>
						/// <java-name>
						/// UNGROUPED_VISIBLE
						/// </java-name>
						[Dot42.DexImport("UNGROUPED_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNGROUPED_VISIBLE = "ungrouped_visible";
						/// <summary>
						///  <para>Read-only flag indicating if this SHOULD_SYNC or any Groups#SHOULD_SYNC under this account have been marked as unsynced. </para>        
						/// </summary>
						/// <java-name>
						/// ANY_UNSYNCED
						/// </java-name>
						[Dot42.DexImport("ANY_UNSYNCED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANY_UNSYNCED = "any_unsynced";
						/// <summary>
						///  <para>Read-only count of Contacts from a specific source that have no CommonDataKinds.GroupMembership entries. </para> <para>Type: INTEGER </para>        
						/// </summary>
						/// <java-name>
						/// UNGROUPED_COUNT
						/// </java-name>
						[Dot42.DexImport("UNGROUPED_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNGROUPED_COUNT = "summ_count";
						/// <summary>
						///  <para>Read-only count of Contacts from a specific source that have no CommonDataKinds.GroupMembership entries, and also have phone numbers. </para> <para>Type: INTEGER </para>        
						/// </summary>
						/// <java-name>
						/// UNGROUPED_WITH_PHONES
						/// </java-name>
						[Dot42.DexImport("UNGROUPED_WITH_PHONES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNGROUPED_WITH_PHONES = "summ_phones";
				}

				/// <summary>
				///  <para> <para>Settings </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$SettingsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SettingsColumns", AccessFlags = 1548)]
				protected internal partial interface ISettingsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Constants for the contact aggregation exceptions table, which contains aggregation rules overriding those used by automatic aggregation. This type only supports query and update. Neither insert nor delete are supported. </para> <para> <h2>Columns</h2></para> <para> <table> <row> <entry> <para>AggregationExceptions  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The type of exception: TYPE_KEEP_TOGETHER, TYPE_KEEP_SEPARATE or TYPE_AUTOMATIC.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>RAW_CONTACT_ID1 </para></entry> <entry> <para>read/write </para></entry> <entry> <para>A reference to the RawContacts#_ID of the raw contact that the rule applies to.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>RAW_CONTACT_ID2 </para></entry> <entry> <para>read/write </para></entry> <entry> <para>A reference to the other RawContacts#_ID of the raw contact that the rule applies to.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$AggregationExceptions
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$AggregationExceptions", AccessFlags = 25)]
				public sealed partial class AggregationExceptions : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of data. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/aggregation_exception";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of an aggregation exception </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/aggregation_exception";
						/// <summary>
						///  <para>The type of exception: TYPE_KEEP_TOGETHER, TYPE_KEEP_SEPARATE or TYPE_AUTOMATIC.</para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <summary>
						///  <para>Allows the provider to automatically decide whether the specified raw contacts should be included in the same aggregate contact or not. </para>        
						/// </summary>
						/// <java-name>
						/// TYPE_AUTOMATIC
						/// </java-name>
						[Dot42.DexImport("TYPE_AUTOMATIC", "I", AccessFlags = 25)]
						public const int TYPE_AUTOMATIC = 0;
						/// <summary>
						///  <para>Makes sure that the specified raw contacts are included in the same aggregate contact. </para>        
						/// </summary>
						/// <java-name>
						/// TYPE_KEEP_TOGETHER
						/// </java-name>
						[Dot42.DexImport("TYPE_KEEP_TOGETHER", "I", AccessFlags = 25)]
						public const int TYPE_KEEP_TOGETHER = 1;
						/// <summary>
						///  <para>Makes sure that the specified raw contacts are NOT included in the same aggregate contact. </para>        
						/// </summary>
						/// <java-name>
						/// TYPE_KEEP_SEPARATE
						/// </java-name>
						[Dot42.DexImport("TYPE_KEEP_SEPARATE", "I", AccessFlags = 25)]
						public const int TYPE_KEEP_SEPARATE = 2;
						/// <summary>
						///  <para>A reference to the RawContacts#_ID of the raw contact that the rule applies to. </para>        
						/// </summary>
						/// <java-name>
						/// RAW_CONTACT_ID1
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_ID1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_ID1 = "raw_contact_id1";
						/// <summary>
						///  <para>A reference to the other RawContacts#_ID of the raw contact that the rule applies to. </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Constants for the groups table. Only per-account groups are supported.  <h2>Columns</h2></para> <para> <table> <row> <entry> <para>Groups  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Row ID. Sync adapter should try to preserve row IDs during updates. In other words, it would be a really bad idea to delete and reinsert a group. A sync adapter should always do an update instead.  # </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DATA_SET </para></entry> <entry> <para>read/write-once </para></entry> <entry> <para></para> <para>The data set within the account that this group belongs to. This allows multiple sync adapters for the same account type to distinguish between each others' group data. The combination of ACCOUNT_TYPE, ACCOUNT_NAME, and DATA_SET identifies a set of data that is associated with a single sync adapter. </para> <para></para> <para>This is empty by default, and is completely optional. It only needs to be populated if multiple sync adapters are entering distinct data for the same account type and account name. </para> <para></para> <para>It should be set at the time the group is inserted and never changed afterwards. </para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>TITLE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The display title of this group.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NOTES </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Notes about the group.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SYSTEM_ID </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The ID of this group if it is a System Group, i.e. a group that has a special meaning to the sync adapter, null otherwise.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SUMMARY_COUNT </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The total number of Contacts that have CommonDataKinds.GroupMembership in this group. Read-only value that is only present when querying Groups#CONTENT_SUMMARY_URI.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SUMMARY_WITH_PHONES </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The total number of Contacts that have both CommonDataKinds.GroupMembership in this group, and also have phone numbers. Read-only value that is only present when querying Groups#CONTENT_SUMMARY_URI.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>GROUP_VISIBLE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Flag indicating if the contacts belonging to this group should be visible in any user interface. Allowed values: 0 and 1.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>DELETED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The "deleted" flag: "0" by default, "1" if the row has been marked for deletion. When android.content.ContentResolver#delete is called on a group, it is marked for deletion. The sync adaptor deletes the group on the server and then calls ContactResolver.delete once more, this time setting the the ContactsContract#CALLER_IS_SYNCADAPTER query parameter to finalize the data removal.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SHOULD_SYNC </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Whether this group should be synced if the SYNC_EVERYTHING settings is false for this group's account.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$Groups
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Groups", AccessFlags = 25)]
				public sealed partial class Groups : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IGroupsColumns, global::Android.Provider.ContactsContract.ISyncColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The content:// style URI for this table joined with details data from ContactsContract.Data. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_SUMMARY_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_SUMMARY_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_SUMMARY_URI;
						/// <summary>
						///  <para>The MIME type of a directory of groups. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/group";
						/// <summary>
						///  <para>The MIME type of a single group. </para>        
						/// </summary>
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

				/// <summary>
				///  <para> <para>Groups </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$GroupsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IGroupsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The display title of this group. </para> <para>Type: TEXT </para>        
						/// </summary>
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <summary>
						///  <para>Notes about the group. </para> <para>Type: TEXT </para>        
						/// </summary>
						/// <java-name>
						/// NOTES
						/// </java-name>
						[Dot42.DexImport("NOTES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTES = "notes";
						/// <summary>
						///  <para>The ID of this group if it is a System Group, i.e. a group that has a special meaning to the sync adapter, null otherwise. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// SYSTEM_ID
						/// </java-name>
						[Dot42.DexImport("SYSTEM_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYSTEM_ID = "system_id";
						/// <summary>
						///  <para>The total number of Contacts that have CommonDataKinds.GroupMembership in this group. Read-only value that is only present when querying Groups#CONTENT_SUMMARY_URI. </para> <para>Type: INTEGER </para>        
						/// </summary>
						/// <java-name>
						/// SUMMARY_COUNT
						/// </java-name>
						[Dot42.DexImport("SUMMARY_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SUMMARY_COUNT = "summ_count";
						/// <summary>
						///  <para>The total number of Contacts that have both CommonDataKinds.GroupMembership in this group, and also have phone numbers. Read-only value that is only present when querying Groups#CONTENT_SUMMARY_URI. </para> <para>Type: INTEGER </para>        
						/// </summary>
						/// <java-name>
						/// SUMMARY_WITH_PHONES
						/// </java-name>
						[Dot42.DexImport("SUMMARY_WITH_PHONES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SUMMARY_WITH_PHONES = "summ_phones";
						/// <summary>
						///  <para>Flag indicating if the contacts belonging to this group should be visible in any user interface. </para> <para>Type: INTEGER (boolean) </para>        
						/// </summary>
						/// <java-name>
						/// GROUP_VISIBLE
						/// </java-name>
						[Dot42.DexImport("GROUP_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_VISIBLE = "group_visible";
						/// <summary>
						///  <para>The "deleted" flag: "0" by default, "1" if the row has been marked for deletion. When android.content.ContentResolver#delete is called on a group, it is marked for deletion. The sync adaptor deletes the group on the server and then calls ContactResolver.delete once more, this time setting the the ContactsContract#CALLER_IS_SYNCADAPTER query parameter to finalize the data removal. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// DELETED
						/// </java-name>
						[Dot42.DexImport("DELETED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETED = "deleted";
						/// <summary>
						///  <para>Whether this group should be synced if the SYNC_EVERYTHING settings is false for this group's account. </para> <para>Type: INTEGER (boolean) </para>        
						/// </summary>
						/// <java-name>
						/// SHOULD_SYNC
						/// </java-name>
						[Dot42.DexImport("SHOULD_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOULD_SYNC = "should_sync";
						/// <summary>
						///  <para>Any newly created contacts will automatically be added to groups that have this flag set to true. </para> <para>Type: INTEGER (boolean) </para>        
						/// </summary>
						/// <java-name>
						/// AUTO_ADD
						/// </java-name>
						[Dot42.DexImport("AUTO_ADD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTO_ADD = "auto_add";
						/// <summary>
						///  <para>When a contacts is marked as a favorites it will be automatically added to the groups that have this flag set, and when it is removed from favorites it will be removed from these groups. </para> <para>Type: INTEGER (boolean) </para>        
						/// </summary>
						/// <java-name>
						/// FAVORITES
						/// </java-name>
						[Dot42.DexImport("FAVORITES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FAVORITES = "favorites";
						/// <summary>
						///  <para>The "read-only" flag: "0" by default, "1" if the row cannot be modified or deleted except by a sync adapter. See ContactsContract#CALLER_IS_SYNCADAPTER. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// GROUP_IS_READ_ONLY
						/// </java-name>
						[Dot42.DexImport("GROUP_IS_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GROUP_IS_READ_ONLY = "group_is_read_only";
				}

				/// <summary>
				///  <para> <para>Groups </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$GroupsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$GroupsColumns", AccessFlags = 1548)]
				protected internal partial interface IGroupsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Container for definitions of common data types stored in the ContactsContract.Data table. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>A data kind representing a SIP address for the contact. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SIP_ADDRESS </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_HOME </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_OTHER </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$SipAddress
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$SipAddress", AccessFlags = 25)]
						public sealed partial class SipAddress : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The SIP address. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// SIP_ADDRESS
								/// </java-name>
								[Dot42.DexImport("SIP_ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SIP_ADDRESS = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal SipAddress() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing a website related to the contact. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>URL </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_HOMEPAGE </para></li> <li> <para>TYPE_BLOG </para></li> <li> <para>TYPE_PROFILE </para></li> <li> <para>TYPE_HOME </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_FTP </para></li> <li> <para>TYPE_OTHER </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Website
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Website", AccessFlags = 25)]
						public sealed partial class Website : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The website URL string. </para> <para>Type: TEXT</para>        
								/// </summary>
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

						/// <summary>
						///  <para>Group Membership. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>GROUP_ROW_ID </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>GROUP_SOURCE_ID </para></entry> <entry> <para>none </para></entry> <entry> <para></para> <para>The sourceid of the group that this group membership refers to. Exactly one of this or GROUP_ROW_ID must be set when inserting a row. </para> <para></para> <para>If this field is specified, the provider will first try to look up a group with this Groups.SOURCE_ID. If such a group is found, it will use the corresponding row id. If the group is not found, it will create one.   </para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$GroupMembership
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$GroupMembership", AccessFlags = 25)]
						public sealed partial class GroupMembership : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/group_membership";
								/// <summary>
								///  <para>The row id of the group that this group membership refers to. Exactly one of this or GROUP_SOURCE_ID must be set when inserting a row. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// GROUP_ROW_ID
								/// </java-name>
								[Dot42.DexImport("GROUP_ROW_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GROUP_ROW_ID = "data1";
								/// <summary>
								///  <para>The sourceid of the group that this group membership refers to. Exactly one of this or GROUP_ROW_ID must be set when inserting a row. </para> <para>Type: TEXT</para>        
								/// </summary>
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

						/// <summary>
						///  <para>Notes about the contact. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NOTE </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Note
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Note", AccessFlags = 25)]
						public sealed partial class Note : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/note";
								/// <summary>
								///  <para>The note text. </para> <para>Type: TEXT</para>        
								/// </summary>
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

						/// <summary>
						///  <para>A data kind representing a photo for the contact. </para> <para>Some sync adapters will choose to download photos in a separate pass. A common pattern is to use columns ContactsContract.Data#SYNC1 through ContactsContract.Data#SYNC4 to store temporary data, e.g. the image URL or ID, state of download, server-side version of the image. It is allowed for the PHOTO to be null. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>NUMBER </para></entry> <entry> <para>PHOTO_FILE_ID </para></entry> <entry> <para>DATA14 </para></entry> <entry> <para>ID of the hi-res photo file.  </para></entry></row> <row> <entry> <para>BLOB </para></entry> <entry> <para>PHOTO </para></entry> <entry> <para>DATA15 </para></entry> <entry> <para>By convention, binary data is stored in DATA15. The thumbnail of the photo is stored in this column.  </para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Photo
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Photo", AccessFlags = 25)]
						public sealed partial class Photo : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/photo";
								/// <summary>
								///  <para>Thumbnail photo of the raw contact. This is the raw bytes of an image that could be inflated using android.graphics.BitmapFactory. </para> <para>Type: BLOB </para>        
								/// </summary>
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

						/// <summary>
						///  <para>A data kind representing an event. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>START_DATE </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_ANNIVERSARY </para></li> <li> <para>TYPE_OTHER </para></li> <li> <para>TYPE_BIRTHDAY </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Event
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Event", AccessFlags = 25)]
						public sealed partial class Event : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The event start date as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// START_DATE
								/// </java-name>
								[Dot42.DexImport("START_DATE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string START_DATE = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Event() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeResource
								/// </java-name>
								[Dot42.DexImport("getTypeResource", "(Ljava/lang/Integer;)I", AccessFlags = 9)]
								public static int GetTypeResource(int? type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

						}

						/// <summary>
						///  <para>A data kind representing a relation. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NAME </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_ASSISTANT </para></li> <li> <para>TYPE_BROTHER </para></li> <li> <para>TYPE_CHILD </para></li> <li> <para>TYPE_DOMESTIC_PARTNER </para></li> <li> <para>TYPE_FATHER </para></li> <li> <para>TYPE_FRIEND </para></li> <li> <para>TYPE_MANAGER </para></li> <li> <para>TYPE_MOTHER </para></li> <li> <para>TYPE_PARENT </para></li> <li> <para>TYPE_PARTNER </para></li> <li> <para>TYPE_REFERRED_BY </para></li> <li> <para>TYPE_RELATIVE </para></li> <li> <para>TYPE_SISTER </para></li> <li> <para>TYPE_SPOUSE </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Relation
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Relation", AccessFlags = 25)]
						public sealed partial class Relation : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The name of the relative as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Relation() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing an organization. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>COMPANY </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_OTHER </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>TITLE </para></entry> <entry> <para>DATA4 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DEPARTMENT </para></entry> <entry> <para>DATA5 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>JOB_DESCRIPTION </para></entry> <entry> <para>DATA6 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SYMBOL </para></entry> <entry> <para>DATA7 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PHONETIC_NAME </para></entry> <entry> <para>DATA8 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>OFFICE_LOCATION </para></entry> <entry> <para>DATA9 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PHONETIC_NAME_STYLE </para></entry> <entry> <para>DATA10 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Organization
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Organization", AccessFlags = 25)]
						public sealed partial class Organization : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The company as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// COMPANY
								/// </java-name>
								[Dot42.DexImport("COMPANY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPANY = "data1";
								/// <summary>
								///  <para>The position title at this company as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// TITLE
								/// </java-name>
								[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE = "data4";
								/// <summary>
								///  <para>The department at this company as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// DEPARTMENT
								/// </java-name>
								[Dot42.DexImport("DEPARTMENT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEPARTMENT = "data5";
								/// <summary>
								///  <para>The job description at this company as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// JOB_DESCRIPTION
								/// </java-name>
								[Dot42.DexImport("JOB_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string JOB_DESCRIPTION = "data6";
								/// <summary>
								///  <para>The symbol of this company as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// SYMBOL
								/// </java-name>
								[Dot42.DexImport("SYMBOL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SYMBOL = "data7";
								/// <summary>
								///  <para>The phonetic name of this company as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// PHONETIC_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_NAME = "data8";
								/// <summary>
								///  <para>The office location of this organization. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// OFFICE_LOCATION
								/// </java-name>
								[Dot42.DexImport("OFFICE_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string OFFICE_LOCATION = "data9";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Organization() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing an IM address </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DATA </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_HOME </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_OTHER </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PROTOCOL </para></entry> <entry> <para>DATA5 </para></entry> <entry> <para></para> <para>Allowed values:  <ul> <li> <para>PROTOCOL_CUSTOM. Also provide the actual protocol name as CUSTOM_PROTOCOL. </para></li> <li> <para>PROTOCOL_AIM </para></li> <li> <para>PROTOCOL_MSN </para></li> <li> <para>PROTOCOL_YAHOO </para></li> <li> <para>PROTOCOL_SKYPE </para></li> <li> <para>PROTOCOL_QQ </para></li> <li> <para>PROTOCOL_GOOGLE_TALK </para></li> <li> <para>PROTOCOL_ICQ </para></li> <li> <para>PROTOCOL_JABBER </para></li> <li> <para>PROTOCOL_NETMEETING </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CUSTOM_PROTOCOL </para></entry> <entry> <para>DATA6 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Im
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Im", AccessFlags = 25)]
						public sealed partial class Im : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>This column should be populated with one of the defined constants, e.g. PROTOCOL_YAHOO. If the value of this column is PROTOCOL_CUSTOM, the CUSTOM_PROTOCOL should contain the name of the custom protocol. </para>        
								/// </summary>
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

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given PROTOCOL. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getProtocolLabelResource
								/// </java-name>
								[Dot42.DexImport("getProtocolLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetProtocolLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given protocol, possibly substituting the given CUSTOM_PROTOCOL value for PROTOCOL_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getProtocolLabel
								/// </java-name>
								[Dot42.DexImport("getProtocolLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetProtocolLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing a postal addresses. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>FORMATTED_ADDRESS </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_HOME </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_OTHER </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>STREET </para></entry> <entry> <para>DATA4 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>POBOX </para></entry> <entry> <para>DATA5 </para></entry> <entry> <para>Post Office Box number  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NEIGHBORHOOD </para></entry> <entry> <para>DATA6 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CITY </para></entry> <entry> <para>DATA7 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>REGION </para></entry> <entry> <para>DATA8 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>POSTCODE </para></entry> <entry> <para>DATA9 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>COUNTRY </para></entry> <entry> <para>DATA10 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$StructuredPostal
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$StructuredPostal", AccessFlags = 25)]
						public sealed partial class StructuredPostal : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/postal-address_v2";
								/// <summary>
								///  <para>The MIME type of CONTENT_URI providing a directory of postal addresses. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/postal-address_v2";
								/// <summary>
								///  <para>The content:// style URI for all data records of the StructuredPostal#CONTENT_ITEM_TYPE MIME type. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The full, unstructured postal address.  <b>This field must be consistent with any structured data.</b> </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// FORMATTED_ADDRESS
								/// </java-name>
								[Dot42.DexImport("FORMATTED_ADDRESS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FORMATTED_ADDRESS = "data1";
								/// <summary>
								///  <para>Can be street, avenue, road, etc. This element also includes the house number and room/apartment/flat/floor number. </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// STREET
								/// </java-name>
								[Dot42.DexImport("STREET", "Ljava/lang/String;", AccessFlags = 25)]
								public const string STREET = "data4";
								/// <summary>
								///  <para>Covers actual P.O. boxes, drawers, locked bags, etc. This is usually but not always mutually exclusive with street. </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// POBOX
								/// </java-name>
								[Dot42.DexImport("POBOX", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POBOX = "data5";
								/// <summary>
								///  <para>This is used to disambiguate a street address when a city contains more than one street with the same name, or to specify a small place whose mail is routed through a larger postal town. In China it could be a county or a minor city. </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// NEIGHBORHOOD
								/// </java-name>
								[Dot42.DexImport("NEIGHBORHOOD", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NEIGHBORHOOD = "data6";
								/// <summary>
								///  <para>Can be city, village, town, borough, etc. This is the postal town and not necessarily the place of residence or place of business. </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// CITY
								/// </java-name>
								[Dot42.DexImport("CITY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CITY = "data7";
								/// <summary>
								///  <para>A state, province, county (in Ireland), Land (in Germany), departement (in France), etc. </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// REGION
								/// </java-name>
								[Dot42.DexImport("REGION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string REGION = "data8";
								/// <summary>
								///  <para>Postal code. Usually country-wide, but sometimes specific to the city (e.g. "2" in "Dublin 2, Ireland" addresses). </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// POSTCODE
								/// </java-name>
								[Dot42.DexImport("POSTCODE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string POSTCODE = "data9";
								/// <summary>
								///  <para>The name or code of the country. </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// COUNTRY
								/// </java-name>
								[Dot42.DexImport("COUNTRY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COUNTRY = "data10";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal StructuredPostal() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing an email address. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>ADDRESS </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para>Email address itself.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_HOME </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_OTHER </para></li> <li> <para>TYPE_MOBILE </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Email
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Email", AccessFlags = 25)]
						public sealed partial class Email : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/email_v2";
								/// <summary>
								///  <para>The MIME type of CONTENT_URI providing a directory of email addresses. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/email_v2";
								/// <summary>
								///  <para>The content:// style URI for all data records of the CONTENT_ITEM_TYPE MIME type, combined with the associated raw contact and aggregate contact data. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URL for looking up data rows by email address. The lookup argument, an email address, should be passed as an additional path segment after this URI. </para> <para>Example:  <pre>
								/// Uri uri = Uri.withAppendedPath(Email.CONTENT_LOOKUP_URI, Uri.encode(email));
								/// Cursor c = getContentResolver().query(uri,
								///          new String[]{Email.CONTACT_ID, Email.DISPLAY_NAME, Email.DATA},
								///          null, null, null);
								/// </pre> </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_LOOKUP_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_LOOKUP_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_LOOKUP_URI;
								/// <summary>
								///  <para>The content:// style URL for email lookup using a filter. The filter returns records of MIME type CONTENT_ITEM_TYPE. The filter is applied to display names as well as email addresses. The filter argument should be passed as an additional path segment after this URI. </para> <para>The query in the following example will return "Robert Parr (bob@incredibles.com)" as well as "Bob Parr (incredible@android.com)".  <pre>
								/// Uri uri = Uri.withAppendedPath(Email.CONTENT_LOOKUP_URI, Uri.encode("bob"));
								/// Cursor c = getContentResolver().query(uri,
								///          new String[]{Email.DISPLAY_NAME, Email.DATA},
								///          null, null, null);
								/// </pre> </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_FILTER_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
								/// <summary>
								///  <para>The email address. </para> <para>Type: TEXT</para>        
								/// </summary>
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
								/// <summary>
								///  <para>The display name for the email address </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DISPLAY_NAME = "data4";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Email() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing a telephone number. </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type </para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NUMBER </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_HOME </para></li> <li> <para>TYPE_MOBILE </para></li> <li> <para>TYPE_WORK </para></li> <li> <para>TYPE_FAX_WORK </para></li> <li> <para>TYPE_FAX_HOME </para></li> <li> <para>TYPE_PAGER </para></li> <li> <para>TYPE_OTHER </para></li> <li> <para>TYPE_CALLBACK </para></li> <li> <para>TYPE_CAR </para></li> <li> <para>TYPE_COMPANY_MAIN </para></li> <li> <para>TYPE_ISDN </para></li> <li> <para>TYPE_MAIN </para></li> <li> <para>TYPE_OTHER_FAX </para></li> <li> <para>TYPE_RADIO </para></li> <li> <para>TYPE_TELEX </para></li> <li> <para>TYPE_TTY_TDD </para></li> <li> <para>TYPE_WORK_MOBILE </para></li> <li> <para>TYPE_WORK_PAGER </para></li> <li> <para>TYPE_ASSISTANT </para></li> <li> <para>TYPE_MMS </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Phone
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Phone", AccessFlags = 25)]
						public sealed partial class Phone : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/phone_v2";
								/// <summary>
								///  <para>The MIME type of CONTENT_URI providing a directory of phones. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/phone_v2";
								/// <summary>
								///  <para>The content:// style URI for all data records of the CONTENT_ITEM_TYPE MIME type, combined with the associated raw contact and aggregate contact data. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URL for phone lookup using a filter. The filter returns records of MIME type CONTENT_ITEM_TYPE. The filter is applied to display names as well as phone numbers. The filter argument should be passed as an additional path segment after this URI. </para>        
								/// </summary>
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
								/// <summary>
								///  <para>The phone number as the user entered it. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// NUMBER
								/// </java-name>
								[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER = "data1";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
								internal Phone() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Return the string resource that best describes the given TYPE. Will always return a valid resource. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabelResource
								/// </java-name>
								[Dot42.DexImport("getTypeLabelResource", "(I)I", AccessFlags = 25)]
								public static int GetTypeLabelResource(int type) /* MethodBuilder.Create */ 
								{
										return default(int);
								}

								/// <summary>
								///  <para>Return a CharSequence that best describes the given type, possibly substituting the given LABEL value for TYPE_CUSTOM. </para>        
								/// </summary>
								/// <java-name>
								/// getTypeLabel
								/// </java-name>
								[Dot42.DexImport("getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence" +
    ";", AccessFlags = 25)]
								public static global::Java.Lang.ICharSequence GetTypeLabel(global::Android.Content.Res.Resources res, int type, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
								{
										return default(global::Java.Lang.ICharSequence);
								}

						}

						/// <summary>
						///  <para>A data kind representing the contact's nickname. For example, for Bob Parr ("Mr. Incredible"):  <pre>
						/// ArrayList&lt;ContentProviderOperation&gt; ops =
						///          new ArrayList&lt;ContentProviderOperation&gt;();</pre></para> <para> <pre>ops.add(ContentProviderOperation.newInsert(Data.CONTENT_URI)
						///          .withValue(Data.RAW_CONTACT_ID, rawContactId)
						///          .withValue(Data.MIMETYPE, StructuredName.CONTENT_ITEM_TYPE)
						///          .withValue(StructuredName.DISPLAY_NAME, "Bob Parr")
						///          .build());</pre></para> <para> <pre>ops.add(ContentProviderOperation.newInsert(Data.CONTENT_URI)
						///          .withValue(Data.RAW_CONTACT_ID, rawContactId)
						///          .withValue(Data.MIMETYPE, Nickname.CONTENT_ITEM_TYPE)
						///          .withValue(Nickname.NAME, "Mr. Incredible")
						///          .withValue(Nickname.TYPE, Nickname.TYPE_CUSTOM)
						///          .withValue(Nickname.LABEL, "Superhero")
						///          .build());</pre></para> <para> <pre>getContentResolver().applyBatch(ContactsContract.AUTHORITY, ops);
						/// </pre> </para> <para>You can use all columns defined for ContactsContract.Data as well as the following aliases. </para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type</para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NAME </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para>Allowed values are: </para> <para> <ul> <li> <para>TYPE_CUSTOM. Put the actual type in LABEL. </para></li> <li> <para>TYPE_DEFAULT </para></li> <li> <para>TYPE_OTHER_NAME </para></li> <li> <para>TYPE_MAIDEN_NAME </para></li> <li> <para>TYPE_SHORT_NAME </para></li> <li> <para>TYPE_INITIALS </para></li></ul></para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$Nickname
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$Nickname", AccessFlags = 25)]
						public sealed partial class Nickname : global::Android.Provider.ContactsContract.IDataColumnsWithJoins, global::Android.Provider.ContactsContract.CommonDataKinds.ICommonColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
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
								/// <summary>
								///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use TYPE_MAIDEN_NAME instead. </para></xrefdescription></xrefsect></para>        
								/// </summary>
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
								/// <summary>
								///  <para>The name itself </para>        
								/// </summary>
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

						/// <summary>
						///  <para>A data kind representing the contact's proper name. You can use all columns defined for ContactsContract.Data as well as the following aliases.</para> <para> <h2>Column aliases</h2></para> <para> <table> <row> <entry> <para>Type</para></entry> <entry> <para>Alias</para></entry> <entry> <para>Data column  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DISPLAY_NAME </para></entry> <entry> <para>DATA1 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>GIVEN_NAME </para></entry> <entry> <para>DATA2 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>FAMILY_NAME </para></entry> <entry> <para>DATA3 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PREFIX </para></entry> <entry> <para>DATA4 </para></entry> <entry> <para>Common prefixes in English names are "Mr", "Ms", "Dr" etc.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>MIDDLE_NAME </para></entry> <entry> <para>DATA5 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SUFFIX </para></entry> <entry> <para>DATA6 </para></entry> <entry> <para>Common suffixes in English names are "Sr", "Jr", "III" etc.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PHONETIC_GIVEN_NAME </para></entry> <entry> <para>DATA7 </para></entry> <entry> <para>Used for phonetic spelling of the name, e.g. Pinyin, Katakana, Hiragana  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PHONETIC_MIDDLE_NAME </para></entry> <entry> <para>DATA8 </para></entry> <entry> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>PHONETIC_FAMILY_NAME </para></entry> <entry> <para>DATA9 </para></entry> <entry> <para></para></entry></row></table></para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$StructuredName
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$StructuredName", AccessFlags = 25)]
						public sealed partial class StructuredName : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>MIME type used when storing this in data table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_ITEM_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/name";
								/// <summary>
								///  <para>The name that should be used to display the contact.  <b>Unstructured component of the name should be consistent with its structured representation.</b> </para> <para>Type: TEXT </para>        
								/// </summary>
								/// <java-name>
								/// DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DISPLAY_NAME = "data1";
								/// <summary>
								///  <para>The given name for the contact. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// GIVEN_NAME
								/// </java-name>
								[Dot42.DexImport("GIVEN_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string GIVEN_NAME = "data2";
								/// <summary>
								///  <para>The family name for the contact. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// FAMILY_NAME
								/// </java-name>
								[Dot42.DexImport("FAMILY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FAMILY_NAME = "data3";
								/// <summary>
								///  <para>The contact's honorific prefix, e.g. "Sir" </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// PREFIX
								/// </java-name>
								[Dot42.DexImport("PREFIX", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PREFIX = "data4";
								/// <summary>
								///  <para>The contact's middle name </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// MIDDLE_NAME
								/// </java-name>
								[Dot42.DexImport("MIDDLE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MIDDLE_NAME = "data5";
								/// <summary>
								///  <para>The contact's honorific suffix, e.g. "Jr" </para>        
								/// </summary>
								/// <java-name>
								/// SUFFIX
								/// </java-name>
								[Dot42.DexImport("SUFFIX", "Ljava/lang/String;", AccessFlags = 25)]
								public const string SUFFIX = "data6";
								/// <summary>
								///  <para>The phonetic version of the given name for the contact. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// PHONETIC_GIVEN_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_GIVEN_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_GIVEN_NAME = "data7";
								/// <summary>
								///  <para>The phonetic version of the additional name for the contact. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// PHONETIC_MIDDLE_NAME
								/// </java-name>
								[Dot42.DexImport("PHONETIC_MIDDLE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PHONETIC_MIDDLE_NAME = "data8";
								/// <summary>
								///  <para>The phonetic version of the family name for the contact. </para> <para>Type: TEXT</para>        
								/// </summary>
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

						/// <summary>
						///  <para>Columns common across the specific types. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$CommonColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$CommonColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
						public static partial class ICommonColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The data for the contact method. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "data1";
								/// <summary>
								///  <para>The type of data, for example Home or Work. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// TYPE
								/// </java-name>
								[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TYPE = "data2";
								/// <summary>
								///  <para>The user defined label for the the contact method. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// LABEL
								/// </java-name>
								[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LABEL = "data3";
						}

						/// <summary>
						///  <para>Columns common across the specific types. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$CommonColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$CommonColumns", AccessFlags = 1548)]
						protected internal partial interface ICommonColumns : global::Android.Provider.ContactsContract.CommonDataKinds.IBaseTypes
 /* scope: __dot42__ */ 
						{
						}

						/// <summary>
						///  <para>The base types that all "Typed" data kinds support. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$BaseTypes
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$BaseTypes", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IBaseTypesConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>A custom type. The custom label should be supplied by user. </para>        
								/// </summary>
								/// <java-name>
								/// TYPE_CUSTOM
								/// </java-name>
								[Dot42.DexImport("TYPE_CUSTOM", "I", AccessFlags = 25)]
								public const int TYPE_CUSTOM = 0;
						}

						/// <summary>
						///  <para>The base types that all "Typed" data kinds support. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$CommonDataKinds$BaseTypes
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$CommonDataKinds$BaseTypes", AccessFlags = 1545)]
						public partial interface IBaseTypes
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This old name was never meant to be made public. Do not use. </para></xrefdescription></xrefsect></para>    
				/// </summary>
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

				/// <summary>
				///  <para>A status update is linked to a ContactsContract.Data row and captures the user's latest status update via the corresponding source, e.g. "Having lunch" via "Google Talk". </para> <para>There are two ways a status update can be inserted: by explicitly linking it to a Data row using DATA_ID or indirectly linking it to a data row using a combination of PROTOCOL (or CUSTOM_PROTOCOL) and IM_HANDLE. There is no difference between insert and update, you can use either. </para> <para>Inserting or updating a status update for the user's profile requires either using the DATA_ID to identify the data row to attach the update to, or StatusUpdates#PROFILE_CONTENT_URI to ensure that the change is scoped to the profile. </para> <para>You cannot use ContentResolver#update to change a status, but ContentResolver#insert will replace the latests status if it already exists. </para> <para>Use ContentResolver#bulkInsert(Uri, ContentValues[]) to insert/update statuses for multiple contacts at once. </para> <para> <h3>Columns</h3></para> <para> <table> <row> <entry> <para>StatusUpdates  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>DATA_ID </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Reference to the Data#_ID entry that owns this presence. If this field is  <b>not</b> specified, the provider will attempt to find a data row that matches the PROTOCOL (or CUSTOM_PROTOCOL) and IM_HANDLE columns.   </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>PROTOCOL </para></entry> <entry> <para>read/write </para></entry> <entry> <para>See CommonDataKinds.Im for a list of defined protocol constants.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CUSTOM_PROTOCOL </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Name of the custom protocol. Should be supplied along with the PROTOCOL value ContactsContract.CommonDataKinds.Im#PROTOCOL_CUSTOM. Should be null or omitted if PROTOCOL value is not ContactsContract.CommonDataKinds.Im#PROTOCOL_CUSTOM.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>IM_HANDLE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The IM handle the presence item is for. The handle is scoped to PROTOCOL.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>IM_ACCOUNT </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The IM account for the local user that the presence data came from.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>PRESENCE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Contact IM presence status. The allowed values are: </para> <para> <ul> <li> <para>OFFLINE </para></li> <li> <para>INVISIBLE </para></li> <li> <para>AWAY </para></li> <li> <para>IDLE </para></li> <li> <para>DO_NOT_DISTURB </para></li> <li> <para>AVAILABLE </para></li></ul></para> <para></para> <para>Since presence status is inherently volatile, the content provider may choose not to store this field in long-term storage. </para> <para></para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>CHAT_CAPABILITY </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Contact IM chat compatibility value. The allowed values combinations of the following flags. If None of these flags is set, the device can only do text messaging. </para> <para> <ul> <li> <para>CAPABILITY_HAS_VIDEO </para></li> <li> <para>CAPABILITY_HAS_VOICE </para></li> <li> <para>CAPABILITY_HAS_CAMERA </para></li></ul></para> <para></para> <para>Since chat compatibility is inherently volatile as the contact's availability moves from one device to another, the content provider may choose not to store this field in long-term storage. </para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>STATUS </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Contact's latest status update, e.g. "having toast for breakfast"  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>STATUS_TIMESTAMP </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The absolute time in milliseconds when the status was entered by the user. If this value is not provided, the provider will follow this logic: if there was no prior status update, the value will be left as null. If there was a prior status update, the provider will default this field to the current time.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>STATUS_RES_PACKAGE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The package containing resources for this status: label and icon.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>STATUS_LABEL </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The resource ID of the label describing the source of contact status, e.g. "Google Talk". This resource is scoped by the STATUS_RES_PACKAGE.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>STATUS_ICON </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The resource ID of the icon for the source of contact status. This resource is scoped by the STATUS_RES_PACKAGE.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$StatusUpdates
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StatusUpdates", AccessFlags = 9)]
				public partial class StatusUpdates : global::Android.Provider.ContactsContract.IStatusColumns, global::Android.Provider.ContactsContract.IPresenceColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of status update details. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/status-update";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single status update detail. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/status-update";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal StatusUpdates() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Gets the resource ID for the proper presence icon.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the resource ID for the proper presence icon </para>
						/// </returns>
						/// <java-name>
						/// getPresenceIconResourceId
						/// </java-name>
						[Dot42.DexImport("getPresenceIconResourceId", "(I)I", AccessFlags = 25)]
						public static int GetPresenceIconResourceId(int status) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Returns the precedence of the status code the higher number being the higher precedence.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>An integer representing the precedence, 0 being the lowest. </para>
						/// </returns>
						/// <java-name>
						/// getPresencePrecedence
						/// </java-name>
						[Dot42.DexImport("getPresencePrecedence", "(I)I", AccessFlags = 25)]
						public static int GetPresencePrecedence(int status) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

				}

				/// <summary>
				///  <para>Additional data mixed in with StatusColumns to link back to specific ContactsContract.Data#_ID entries.</para> <para> <para>StatusUpdates </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PresenceColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPresenceColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Reference to the Data#_ID entry that owns this presence. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// DATA_ID
						/// </java-name>
						[Dot42.DexImport("DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ID = "presence_data_id";
						/// <summary>
						///  <para>See CommonDataKinds.Im for a list of defined protocol constants. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// PROTOCOL
						/// </java-name>
						[Dot42.DexImport("PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROTOCOL = "protocol";
						/// <summary>
						///  <para>Name of the custom protocol. Should be supplied along with the PROTOCOL value ContactsContract.CommonDataKinds.Im#PROTOCOL_CUSTOM. Should be null or omitted if PROTOCOL value is not ContactsContract.CommonDataKinds.Im#PROTOCOL_CUSTOM.</para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// CUSTOM_PROTOCOL
						/// </java-name>
						[Dot42.DexImport("CUSTOM_PROTOCOL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CUSTOM_PROTOCOL = "custom_protocol";
						/// <summary>
						///  <para>The IM handle the presence item is for. The handle is scoped to PROTOCOL. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// IM_HANDLE
						/// </java-name>
						[Dot42.DexImport("IM_HANDLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_HANDLE = "im_handle";
						/// <summary>
						///  <para>The IM account for the local user that the presence data came from. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// IM_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("IM_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IM_ACCOUNT = "im_account";
				}

				/// <summary>
				///  <para>Additional data mixed in with StatusColumns to link back to specific ContactsContract.Data#_ID entries.</para> <para> <para>StatusUpdates </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$PresenceColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PresenceColumns", AccessFlags = 1548)]
				protected internal partial interface IPresenceColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>A table that represents the result of looking up a phone number, for example for caller ID. To perform a lookup you must append the number you want to find to CONTENT_FILTER_URI. This query is highly optimized.  <pre>
				/// Uri uri = Uri.withAppendedPath(PhoneLookup.CONTENT_FILTER_URI, Uri.encode(phoneNumber));
				/// resolver.query(uri, new String[]{PhoneLookup.DISPLAY_NAME,...
				/// </pre></para> <para> <h3>Columns</h3></para> <para> <table> <row> <entry> <para>PhoneLookup  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>NUMBER </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Phone number.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>TYPE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Phone number type. See CommonDataKinds.Phone.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LABEL </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Custom label for the phone number. See CommonDataKinds.Phone.  </para></entry></row></table></para> <para>Columns from the Contacts table are also available through a join. </para> <para> <table> <row> <entry> <para>Join with Contacts  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Contact ID.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LOOKUP_KEY </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DISPLAY_NAME </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>PHOTO_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>IN_VISIBLE_GROUP </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>HAS_PHONE_NUMBER </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TIMES_CONTACTED </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>LAST_TIME_CONTACTED </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>STARRED </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CUSTOM_RINGTONE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SEND_TO_VOICEMAIL </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Contacts.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$PhoneLookup
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneLookup", AccessFlags = 25)]
				public sealed partial class PhoneLookup : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IPhoneLookupColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table. Append the phone number you want to lookup to this URI and query it to perform a lookup. For example:  <pre>
						/// Uri lookupUri = Uri.withAppendedPath(PhoneLookup.CONTENT_FILTER_URI,
						///         Uri.encode(phoneNumber));
						/// </pre> </para>        
						/// </summary>
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

				/// <summary>
				///  <para> <para>PhoneLookup </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$PhoneLookupColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneLookupColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPhoneLookupColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The phone number as the user entered it. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// NUMBER
						/// </java-name>
						[Dot42.DexImport("NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NUMBER = "number";
						/// <summary>
						///  <para>The type of phone number, for example Home or Work. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// TYPE
						/// </java-name>
						[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE = "type";
						/// <summary>
						///  <para>The user defined label for the phone number. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// LABEL
						/// </java-name>
						[Dot42.DexImport("LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LABEL = "label";
				}

				/// <summary>
				///  <para> <para>PhoneLookup </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$PhoneLookupColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneLookupColumns", AccessFlags = 1548)]
				protected internal partial interface IPhoneLookupColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Constants for the raw contacts entities table, which can be thought of as an outer join of the raw_contacts table with the data table. It is a strictly read-only table. </para> <para>If a raw contact has data rows, the RawContactsEntity cursor will contain a one row for each data row. If the raw contact has no data rows, the cursor will still contain one row with the raw contact-level information and nulls for data columns.</para> <para> <pre>
				/// Uri entityUri = ContentUris.withAppendedId(RawContactsEntity.CONTENT_URI, rawContactId);
				/// Cursor c = getContentResolver().query(entityUri,
				///          new String[]{
				///              RawContactsEntity.SOURCE_ID,
				///              RawContactsEntity.DATA_ID,
				///              RawContactsEntity.MIMETYPE,
				///              RawContactsEntity.DATA1
				///          }, null, null, null);
				/// try {
				///     while (c.moveToNext()) {
				///         String sourceId = c.getString(0);
				///         if (!c.isNull(1)) {
				///             String mimeType = c.getString(2);
				///             String data = c.getString(3);
				///             ...
				///         }
				///     }
				/// } finally {
				///     c.close();
				/// }
				/// </pre></para> <para> <h3>Columns</h3></para> <para>RawContactsEntity has a combination of RawContact and Data columns.</para> <para> <table> <row> <entry> <para>RawContacts  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Raw contact row ID. See RawContacts.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>CONTACT_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See RawContacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>AGGREGATION_MODE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See RawContacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>DELETED </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See RawContacts.  </para></entry></row></table></para> <para> <table> <row> <entry> <para>Data  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>DATA_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Data row ID. It will be null if the raw contact has no data rows.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>MIMETYPE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Data.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>IS_PRIMARY </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Data.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>IS_SUPER_PRIMARY </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Data.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>DATA_VERSION </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Data.  </para></entry></row> <row> <entry> <para>Any type </para></entry> <entry> <para>DATA1 <br></br> DATA2 <br></br> DATA3 <br></br> DATA4 <br></br> DATA5 <br></br> DATA6 <br></br> DATA7 <br></br> DATA8 <br></br> DATA9 <br></br> DATA10 <br></br> DATA11 <br></br> DATA12 <br></br> DATA13 <br></br> DATA14 <br></br> DATA15  </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Data.  </para></entry></row> <row> <entry> <para>Any type </para></entry> <entry> <para>SYNC1 <br></br> SYNC2 <br></br> SYNC3 <br></br> SYNC4  </para></entry> <entry> <para>read-only </para></entry> <entry> <para>See ContactsContract.Data.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$RawContactsEntity
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContactsEntity", AccessFlags = 25)]
				public sealed partial class RawContactsEntity : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns, global::Android.Provider.ContactsContract.IRawContactsColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of raw contact entities. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/raw_contact_entity";
						/// <summary>
						///  <para>The ID of the data column. The value will be null if this raw contact has no data rows. </para> <para>Type: INTEGER</para>        
						/// </summary>
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

				/// <summary>
				///  <para>Constants for the stream_item_photos table, which contains photos associated with social stream updates. </para> <para>Access to social stream photos requires additional permissions beyond the read/write contact permissions required by the provider. Querying for social stream photos requires android.permission.READ_SOCIAL_STREAM permission, and inserting or updating social stream photos requires android.permission.WRITE_SOCIAL_STREAM permission. </para> <para> <h3>Account check</h3></para> <para>The content URIs to the insert, update and delete operations are required to have the account information matching that of the owning raw contact as query parameters, namely RawContacts#ACCOUNT_TYPE and RawContacts#ACCOUNT_NAME. RawContacts#DATA_SET isn't required. </para> <para> <h3>Operations</h3></para> <para>The record will contain both a StreamItemPhotos#PHOTO_FILE_ID and a StreamItemPhotos#PHOTO_URI. The StreamItemPhotos#PHOTO_FILE_ID can be used in conjunction with the ContactsContract.DisplayPhoto API to retrieve photo content, or you can open the StreamItemPhotos#PHOTO_URI as an asset file, as follows:  <pre>
				///    public InputStream openDisplayPhoto(String photoUri) {
				///        try {
				///            AssetFileDescriptor fd = getContentResolver().openAssetFileDescriptor(photoUri, "r");
				///            return fd.createInputStream();
				///        } catch (IOException e) {
				///            return null;
				///        }
				///    }
				///     <pre>
				///    
				///    </pre></pre></para> <para> <pre> <pre>
				///  */
				/// public static final class StreamItemPhotos implements BaseColumns, StreamItemPhotosColumns {
				///     /**
				///        No public constructor since this is a utility class
				///      */
				///     private StreamItemPhotos() {
				///     }</pre></pre></para> <para> <pre> <pre>    /**
				///        </pre></pre></para> <para> <pre> <pre>
				///        The binary representation of the photo.  Any size photo can be inserted;
				///        the provider will resize it appropriately for storage and display.
				///        </pre></pre></para> <para> <pre> <pre>
				///        </pre></pre></para> <para> <pre> <pre>
				///        This is only intended for use when inserting or updating a stream item photo.
				///        To retrieve the photo that was stored, open StreamItemPhotos#PHOTO_URI
				///        as an asset file.
				///        </pre></pre></para> <para> <pre> <pre>
				///        </pre></pre></para> <para> <pre> <pre>Type: BLOB</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String PHOTO = "photo";
				/// }</pre></pre></para> <para> <pre> <pre>/**
				///    Columns in the StreamItemPhotos table.</pre></pre></para> <para> <pre> <pre>    <para>ContactsContract.StreamItemPhotos
				///  */
				/// protected interface StreamItemPhotosColumns {
				///     /**
				///        A reference to the StreamItems#_ID this photo is associated with.
				///        </para>
				/// Type: NUMBER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String STREAM_ITEM_ID = "stream_item_id";</pre></pre></para> <para> <pre> <pre>    /**
				///        An integer to use for sort order for photos in the stream item.  If not
				///        specified, the StreamItemPhotos#_ID will be used for sorting.
				///        </pre></pre></para> <para> <pre> <pre>Type: NUMBER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String SORT_INDEX = "sort_index";</pre></pre></para> <para> <pre> <pre>    /**
				///        Photo file ID for the photo.
				///        See ContactsContract.DisplayPhoto.
				///        </pre></pre></para> <para> <pre> <pre>Type: NUMBER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String PHOTO_FILE_ID = "photo_file_id";</pre></pre></para> <para> <pre> <pre>    /**
				///        URI for retrieving the photo content, automatically populated.  Callers
				///        may retrieve the photo content by opening this URI as an asset file.
				///        </pre></pre></para> <para> <pre> <pre>Type: TEXT</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String PHOTO_URI = "photo_uri";</pre></pre></para> <para> <pre> <pre>    /** Generic column for use by sync adapters. */
				///     public static final String SYNC1 = "stream_item_photo_sync1";
				///     /** Generic column for use by sync adapters. */
				///     public static final String SYNC2 = "stream_item_photo_sync2";
				///     /** Generic column for use by sync adapters. */
				///     public static final String SYNC3 = "stream_item_photo_sync3";
				///     /** Generic column for use by sync adapters. */
				///     public static final String SYNC4 = "stream_item_photo_sync4";
				/// }</pre></pre></para> <para> <pre> <pre>/**
				///    </pre></pre></para> <para> <pre> <pre>
				///    Constants for the photo files table, which tracks metadata for hi-res photos
				///    stored in the file system.
				///    </pre></pre></para> <para> <pre> <pre></pre></pre></para> <para> <pre> <pre>   
				///  */
				/// public static final class PhotoFiles implements BaseColumns, PhotoFilesColumns {
				///     /**
				///        No public constructor since this is a utility class
				///      */
				///     private PhotoFiles() {
				///     }
				/// }</pre></pre></para> <para> <pre> <pre>/**
				///    Columns in the PhotoFiles table.</pre></pre></para> <para> <pre> <pre>    <para>ContactsContract.PhotoFiles</para>
				/// */
				/// protected interface PhotoFilesColumns {</pre></pre></para> <para> <pre> <pre>    /**
				///        The height, in pixels, of the photo this entry is associated with.
				///        </pre></pre></para> <para> <pre> <pre>Type: NUMBER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String HEIGHT = "height";</pre></pre></para> <para> <pre> <pre>    /**
				///        The width, in pixels, of the photo this entry is associated with.
				///        </pre></pre></para> <para> <pre> <pre>Type: NUMBER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String WIDTH = "width";</pre></pre></para> <para> <pre> <pre>    /**
				///        The size, in bytes, of the photo stored on disk.
				///        </pre></pre></para> <para> <pre> <pre>Type: NUMBER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String FILESIZE = "filesize";
				/// }</pre></pre></para> <para> <pre> <pre>/**
				///    Columns in the Data table.</pre></pre></para> <para> <pre> <pre>    <para>ContactsContract.Data
				///  */
				/// protected interface DataColumns {
				///     /**
				///        The package name to use when creating Resources objects for
				///        this data row. This value is only designed for use when building user
				///        interfaces, and should not be used to infer the owner.</para>
				/// */
				///     public static final String RES_PACKAGE = "res_package";</pre></pre></para> <para> <pre> <pre>    /**
				///        The MIME type of the item represented by this row.
				///      */
				///     public static final String MIMETYPE = "mimetype";</pre></pre></para> <para> <pre> <pre>    /**
				///        A reference to the RawContacts#_ID
				///        that this data belongs to.
				///      */
				///     public static final String RAW_CONTACT_ID = "raw_contact_id";</pre></pre></para> <para> <pre> <pre>    /**
				///        Whether this is the primary entry of its kind for the raw contact it belongs to.
				///        </pre></pre></para> <para> <pre> <pre>Type: INTEGER (if set, non-0 means true)</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String IS_PRIMARY = "is_primary";</pre></pre></para> <para> <pre> <pre>    /**
				///        Whether this is the primary entry of its kind for the aggregate
				///        contact it belongs to. Any data record that is "super primary" must
				///        also be "primary".
				///        </pre></pre></para> <para> <pre> <pre>Type: INTEGER (if set, non-0 means true)</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String IS_SUPER_PRIMARY = "is_super_primary";</pre></pre></para> <para> <pre> <pre>    /**
				///        The "read-only" flag: "0" by default, "1" if the row cannot be modified or
				///        deleted except by a sync adapter.  See ContactsContract#CALLER_IS_SYNCADAPTER.
				///        </pre></pre></para> <para> <pre> <pre>Type: INTEGER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String IS_READ_ONLY = "is_read_only";</pre></pre></para> <para> <pre> <pre>    /**
				///        The version of this data record. This is a read-only value. The data column is
				///        guaranteed to not change without the version going up. This value is monotonically
				///        increasing.
				///        </pre></pre></para> <para> <pre> <pre>Type: INTEGER</pre></pre></para> <para> <pre> <pre>
				///      */
				///     public static final String DATA_VERSION = "data_version";</pre></pre></para> <para> <pre> <pre>    /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA1 = "data1";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA2 = "data2";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA3 = "data3";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA4 = "data4";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA5 = "data5";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA6 = "data6";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA7 = "data7";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA8 = "data8";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA9 = "data9";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA10 = "data10";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA11 = "data11";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA12 = "data12";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA13 = "data13";
				///     /** Generic data column, the meaning is MIMETYPE specific */
				///     public static final String DATA14 = "data14";
				///     /**
				///        Generic data column, the meaning is MIMETYPE specific. By convention,
				///        this field is used to store BLOBs (binary data).
				///      */
				///     public static final String DATA15 = "data15";</pre></pre></para> <para> <pre> <pre>    /** Generic column for use by sync adapters. */
				///     public static final String SYNC1 = "data_sync1";
				///     /** Generic column for use by sync adapters. */
				///     public static final String SYNC2 = "data_sync2";
				///     /** Generic column for use by sync adapters. */
				///     public static final String SYNC3 = "data_sync3";
				///     /** Generic column for use by sync adapters. */
				///     public static final String SYNC4 = "data_sync4";
				/// }</pre></pre></para> <para> <pre> <pre>/**
				///    Columns in the Data_Usage_Stat table
				///  */
				/// protected interface DataUsageStatColumns {
				///     /** The last time (in milliseconds) this Data was used. */
				///     public static final String LAST_TIME_USED = "last_time_used";</pre></pre></para> <para> <pre> <pre>    /** The number of times the referenced Data has been used. */
				///     public static final String TIMES_USED = "times_used";
				/// }</pre></pre></para> <para> <pre> <pre>/**
				///    Combines all columns returned by ContactsContract.Data table queries.</pre></pre></para> <para> <pre> <pre>    <para>ContactsContract.Data
				///  */
				/// protected interface DataColumnsWithJoins extends BaseColumns, DataColumns, StatusColumns,
				///         RawContactsColumns, ContactsColumns, ContactNameColumns, ContactOptionsColumns,
				///         ContactStatusColumns, DataUsageStatColumns {
				/// }</para>
				/// /**
				///    </pre></pre></para> <para> <pre> <pre>
				///    Constants for the data table, which contains data points tied to a raw
				///    contact.  Each row of the data table is typically used to store a single
				///    piece of contact
				///    information (such as a phone number) and its
				///    associated metadata (such as whether it is a work or home number).
				///    </pre></pre></para> <para> <pre> <pre>
				///     <h3>Data kinds</h3>
				/// </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    Data is a generic table that can hold any kind of contact data.
				///    The kind of data stored in a given row is specified by the row's
				///    MIMETYPE value, which determines the meaning of the
				///    generic columns DATA1 through
				///    DATA15.
				///    For example, if the data kind is
				///    Phone.CONTENT_ITEM_TYPE, then the column
				///    DATA1 stores the
				///    phone number, but if the data kind is
				///    Email.CONTENT_ITEM_TYPE, then DATA1
				///    stores the email address.
				///    Sync adapters and applications can introduce their own data kinds.
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    ContactsContract defines a small number of pre-defined data kinds, e.g.
				///    CommonDataKinds.Phone, CommonDataKinds.Email etc. As a
				///    convenience, these classes define data kind specific aliases for DATA1 etc.
				///    For example, Phone.NUMBER is the same as
				///    Data.DATA1.
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    DATA1 is an indexed column and should be used for the data element that is
				///    expected to be most frequently used in query selections. For example, in the
				///    case of a row representing email addresses DATA1 should probably
				///    be used for the email address itself, while DATA2 etc can be
				///    used for auxiliary information like type of email address.
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    By convention, DATA15 is used for storing BLOBs (binary data).
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    The sync adapter for a given account type must correctly handle every data type
				///    used in the corresponding raw contacts.  Otherwise it could result in lost or
				///    corrupted data.
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    Similarly, you should refrain from introducing new kinds of data for an other
				///    party's account types. For example, if you add a data row for
				///    "favorite song" to a raw contact owned by a Google account, it will not
				///    get synced to the server, because the Google sync adapter does not know
				///    how to handle this data kind. Thus new data kinds are typically
				///    introduced along with new account types, i.e. new sync adapters.
				///    </pre></pre></para> <para> <pre> <pre>
				///     <h3>Batch operations</h3>
				/// </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    Data rows can be inserted/updated/deleted using the traditional
				///    ContentResolver#insert, ContentResolver#update and
				///    ContentResolver#delete methods, however the newer mechanism based
				///    on a batch of ContentProviderOperation will prove to be a better
				///    choice in almost all cases. All operations in a batch are executed in a
				///    single transaction, which ensures that the phone-side and server-side
				///    state of a raw contact are always consistent. Also, the batch-based
				///    approach is far more efficient: not only are the database operations
				///    faster when executed in a single transaction, but also sending a batch of
				///    commands to the content provider saves a lot of time on context switching
				///    between your process and the process in which the content provider runs.
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    The flip side of using batched operations is that a large batch may lock
				///    up the database for a long time preventing other applications from
				///    accessing data and potentially causing ANRs ("Application Not Responding"
				///    dialogs.)
				///    </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    To avoid such lockups of the database, make sure to insert "yield points"
				///    in the batch. A yield point indicates to the content provider that before
				///    executing the next operation it can commit the changes that have already
				///    been made, yield to other requests, open another transaction and continue
				///    processing operations. A yield point will not automatically commit the
				///    transaction, but only if there is another request waiting on the
				///    database. Normally a sync adapter should insert a yield point at the
				///    beginning of each raw contact operation sequence in the batch. See
				///    ContentProviderOperation.Builder#withYieldAllowed(boolean).
				///    </pre></pre></para> <para> <pre> <pre>
				///     <h3>Operations</h3>
				/// </pre></pre></para> <para> <pre> <pre>
				///    
				///  <h2>Columns</h2>
				/// </pre></pre></para> <para> <pre> <pre>
				///    </pre></pre></para> <para> <pre> <pre>
				///    Many columns are available via a Data#CONTENT_URI query.  For best performance you
				///    should explicitly specify a projection to only those columns that you need.
				///    </pre></pre></para> <para> <pre> <pre>
				///     <table> <row>
				///  <entry> <para>Data
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>_ID
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>Row ID. Sync adapter should try to preserve row IDs during updates. In other words,
				///    it would be a bad idea to delete and reinsert a data row. A sync adapter should
				///    always do an update instead.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>MIMETYPE
				///    </para></entry> <entry> <para>read/write-once
				///    </para></entry> <entry> <para></para> <para>The MIME type of the item represented by this row. Examples of common
				///    MIME types are:
				///     <ul>
				///  <li>
				///  <para>StructuredName.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Phone.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Email.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Photo.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Organization.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Im.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Nickname.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Note.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>StructuredPostal.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>GroupMembership.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Website.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Event.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>Relation.CONTENT_ITEM_TYPE
				///    </para></li>
				///  <li>
				///  <para>SipAddress.CONTENT_ITEM_TYPE
				///    </para></li>
				/// </ul>
				/// </para> <para></para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>RAW_CONTACT_ID
				///    </para></entry> <entry> <para>read/write-once
				///    </para></entry> <entry> <para>The id of the row in the RawContacts table that this data belongs to.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>IS_PRIMARY
				///    </para></entry> <entry> <para>read/write
				///    </para></entry> <entry> <para>Whether this is the primary entry of its kind for the raw contact it belongs to.
				///    "1" if true, "0" if false.
				///    
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>IS_SUPER_PRIMARY
				///    </para></entry> <entry> <para>read/write
				///    </para></entry> <entry> <para>Whether this is the primary entry of its kind for the aggregate
				///    contact it belongs to. Any data record that is "super primary" must
				///    also be "primary".  For example, the super-primary entry may be
				///    interpreted as the default contact value of its kind (for example,
				///    the default phone number to use for the contact).
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>DATA_VERSION
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>The version of this data record. Whenever the data row changes
				///    the version goes up. This value is monotonically increasing.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>Any type
				///    </para></entry> <entry> <para>DATA1 <br></br>
				/// 
				///    DATA2 <br></br>
				/// 
				///    DATA3 <br></br>
				/// 
				///    DATA4 <br></br>
				/// 
				///    DATA5 <br></br>
				/// 
				///    DATA6 <br></br>
				/// 
				///    DATA7 <br></br>
				/// 
				///    DATA8 <br></br>
				/// 
				///    DATA9 <br></br>
				/// 
				///    DATA10 <br></br>
				/// 
				///    DATA11 <br></br>
				/// 
				///    DATA12 <br></br>
				/// 
				///    DATA13 <br></br>
				/// 
				///    DATA14 <br></br>
				/// 
				///    DATA15
				///    
				///    </para></entry> <entry> <para>read/write
				///    </para></entry> <entry> <para></para> <para>Generic data columns.  The meaning of each column is determined by the
				///    MIMETYPE.  By convention, DATA15 is used for storing
				///    BLOBs (binary data).
				///    </para> <para></para> <para>Data columns whose meaning is not explicitly defined for a given MIMETYPE
				///    should not be used.  There is no guarantee that any sync adapter will
				///    preserve them.  Sync adapters themselves should not use such columns either,
				///    but should instead use SYNC1-SYNC4.
				///    </para> <para></para></entry></row>
				///  <row>
				///  <entry> <para>Any type
				///    </para></entry> <entry> <para>SYNC1 <br></br>
				/// 
				///    SYNC2 <br></br>
				/// 
				///    SYNC3 <br></br>
				/// 
				///    SYNC4
				///    
				///    </para></entry> <entry> <para>read/write
				///    </para></entry> <entry> <para>Generic columns for use by sync adapters. For example, a Photo row
				///    may store the image URL in SYNC1, a status (not loaded, loading, loaded, error)
				///    in SYNC2, server-side version number in SYNC3 and error code in SYNC4.
				///    
				///    </para></entry></row>
				/// </table>
				/// </pre></pre></para> <para> <pre> <pre>   </pre></pre></para> <para> <pre> <pre>
				///    Some columns from the most recent associated status update are also available
				///    through an implicit join.
				///    </pre></pre></para> <para> <pre> <pre>
				///     <table> <row>
				///  <entry> <para>Join with StatusUpdates
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>PRESENCE
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>IM presence status linked to this data row. Compare with
				///    CONTACT_PRESENCE, which contains the contact's presence across
				///    all IM rows. See StatusUpdates for individual status definitions.
				///    The provider may choose not to store this value
				///    in persistent storage. The expectation is that presence status will be
				///    updated on a regular basis.
				///    
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>STATUS
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>Latest status update linked with this data row.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>STATUS_TIMESTAMP
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>The absolute time in milliseconds when the latest status was
				///    inserted/updated for this data row.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>STATUS_RES_PACKAGE
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>The package containing resources for this status: label and icon.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>STATUS_LABEL
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>The resource ID of the label describing the source of status update linked
				///    to this data row. This resource is scoped by the STATUS_RES_PACKAGE.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>STATUS_ICON
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>The resource ID of the icon for the source of the status update linked
				///    to this data row. This resource is scoped by the STATUS_RES_PACKAGE.
				///    
				///    </para></entry></row>
				/// </table>
				/// </pre></pre></para> <para> <pre> <pre>   </pre></pre></para> <para> <pre> <pre>
				///    Some columns from the associated raw contact are also available through an
				///    implicit join.  The other columns are excluded as uninteresting in this
				///    context.
				///    </pre></pre></para> <para> <pre> <pre></pre></pre></para> <para> <pre> <pre>    <table> <row>
				///  <entry> <para>Join with ContactsContract.RawContacts
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>CONTACT_ID
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>The id of the row in the Contacts table that this data belongs
				///    to.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>AGGREGATION_MODE
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See RawContacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>DELETED
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See RawContacts.
				///    
				///    </para></entry></row>
				/// </table>
				/// </pre></pre></para> <para> <pre> <pre>   </pre></pre></para> <para> <pre> <pre>
				///    The ID column for the associated aggregated contact table
				///    ContactsContract.Contacts is available
				///    via the implicit join to the RawContacts table, see above.
				///    The remaining columns from this table are also
				///    available, through an implicit join.  This
				///    facilitates lookup by
				///    the value of a single data element, such as the email address.
				///    </pre></pre></para> <para> <pre> <pre></pre></pre></para> <para> <pre> <pre>    <table> <row>
				///  <entry> <para>Join with ContactsContract.Contacts
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>LOOKUP_KEY
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>DISPLAY_NAME
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>PHOTO_ID
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>IN_VISIBLE_GROUP
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>HAS_PHONE_NUMBER
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>TIMES_CONTACTED
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>LAST_TIME_CONTACTED
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>STARRED
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>CUSTOM_RINGTONE
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>SEND_TO_VOICEMAIL
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>int
				///    </para></entry> <entry> <para>CONTACT_PRESENCE
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>CONTACT_STATUS
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>CONTACT_STATUS_TIMESTAMP
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>String
				///    </para></entry> <entry> <para>CONTACT_STATUS_RES_PACKAGE
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>CONTACT_STATUS_LABEL
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				///  <row>
				///  <entry> <para>long
				///    </para></entry> <entry> <para>CONTACT_STATUS_ICON
				///    </para></entry> <entry> <para>read-only
				///    </para></entry> <entry> <para>See ContactsContract.Contacts.
				///    
				///    </para></entry></row>
				/// </table>
				/// </pre></pre></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$Data
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Data", AccessFlags = 25)]
				public sealed partial class Data : global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table, which requests a directory of data rows matching the selection criteria. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of the results from CONTENT_URI. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/data";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Data() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Build a android.provider.ContactsContract.Contacts#CONTENT_LOOKUP_URI style Uri for the parent android.provider.ContactsContract.Contacts entry of the given ContactsContract.Data entry. </para> <para>Returns the Uri for the contact in the first entry returned by ContentResolver#query(Uri, String[], String, String[], String) for the provided <c>dataUri </c> . If the query returns null or empty results, silently returns null. </para>        
						/// </summary>
						/// <java-name>
						/// getContactLookupUri
						/// </java-name>
						[Dot42.DexImport("getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetContactLookupUri(global::Android.Content.ContentResolver resolver, global::Android.Net.Uri dataUri) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Social status update columns.</para> <para> <para>StatusUpdates </para> <para>ContactsContract.Data </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$StatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StatusColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IStatusColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Contact's latest presence level. </para> <para>Type: INTEGER (one of the values below)</para>        
						/// </summary>
						/// <java-name>
						/// PRESENCE
						/// </java-name>
						[Dot42.DexImport("PRESENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE = "mode";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use PRESENCE </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PRESENCE_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_STATUS = "mode";
						/// <summary>
						///  <para>An allowed value of PRESENCE. </para>        
						/// </summary>
						/// <java-name>
						/// OFFLINE
						/// </java-name>
						[Dot42.DexImport("OFFLINE", "I", AccessFlags = 25)]
						public const int OFFLINE = 0;
						/// <summary>
						///  <para>An allowed value of PRESENCE. </para>        
						/// </summary>
						/// <java-name>
						/// INVISIBLE
						/// </java-name>
						[Dot42.DexImport("INVISIBLE", "I", AccessFlags = 25)]
						public const int INVISIBLE = 1;
						/// <summary>
						///  <para>An allowed value of PRESENCE. </para>        
						/// </summary>
						/// <java-name>
						/// AWAY
						/// </java-name>
						[Dot42.DexImport("AWAY", "I", AccessFlags = 25)]
						public const int AWAY = 2;
						/// <summary>
						///  <para>An allowed value of PRESENCE. </para>        
						/// </summary>
						/// <java-name>
						/// IDLE
						/// </java-name>
						[Dot42.DexImport("IDLE", "I", AccessFlags = 25)]
						public const int IDLE = 3;
						/// <summary>
						///  <para>An allowed value of PRESENCE. </para>        
						/// </summary>
						/// <java-name>
						/// DO_NOT_DISTURB
						/// </java-name>
						[Dot42.DexImport("DO_NOT_DISTURB", "I", AccessFlags = 25)]
						public const int DO_NOT_DISTURB = 4;
						/// <summary>
						///  <para>An allowed value of PRESENCE. </para>        
						/// </summary>
						/// <java-name>
						/// AVAILABLE
						/// </java-name>
						[Dot42.DexImport("AVAILABLE", "I", AccessFlags = 25)]
						public const int AVAILABLE = 5;
						/// <summary>
						///  <para>Contact latest status update. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// STATUS
						/// </java-name>
						[Dot42.DexImport("STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS = "status";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use STATUS </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PRESENCE_CUSTOM_STATUS
						/// </java-name>
						[Dot42.DexImport("PRESENCE_CUSTOM_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PRESENCE_CUSTOM_STATUS = "status";
						/// <summary>
						///  <para>The absolute time in milliseconds when the latest status was inserted/updated. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// STATUS_TIMESTAMP
						/// </java-name>
						[Dot42.DexImport("STATUS_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_TIMESTAMP = "status_ts";
						/// <summary>
						///  <para>The package containing resources for this status: label and icon. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// STATUS_RES_PACKAGE
						/// </java-name>
						[Dot42.DexImport("STATUS_RES_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_RES_PACKAGE = "status_res_package";
						/// <summary>
						///  <para>The resource ID of the label describing the source of the status update, e.g. "GoogleTalk". This resource should be scoped by the STATUS_RES_PACKAGE. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// STATUS_LABEL
						/// </java-name>
						[Dot42.DexImport("STATUS_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_LABEL = "status_label";
						/// <summary>
						///  <para>The resource ID of the icon for the source of the status update. This resource should be scoped by the STATUS_RES_PACKAGE. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// STATUS_ICON
						/// </java-name>
						[Dot42.DexImport("STATUS_ICON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_ICON = "status_icon";
						/// <summary>
						///  <para>Contact's audio/video chat capability level. </para> <para>Type: INTEGER (one of the values below)</para>        
						/// </summary>
						/// <java-name>
						/// CHAT_CAPABILITY
						/// </java-name>
						[Dot42.DexImport("CHAT_CAPABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHAT_CAPABILITY = "chat_capability";
						/// <summary>
						///  <para>An allowed flag of CHAT_CAPABILITY. Indicates audio-chat capability (microphone and speaker) </para>        
						/// </summary>
						/// <java-name>
						/// CAPABILITY_HAS_VOICE
						/// </java-name>
						[Dot42.DexImport("CAPABILITY_HAS_VOICE", "I", AccessFlags = 25)]
						public const int CAPABILITY_HAS_VOICE = 1;
						/// <summary>
						///  <para>An allowed flag of CHAT_CAPABILITY. Indicates that the contact's device can display a video feed. </para>        
						/// </summary>
						/// <java-name>
						/// CAPABILITY_HAS_VIDEO
						/// </java-name>
						[Dot42.DexImport("CAPABILITY_HAS_VIDEO", "I", AccessFlags = 25)]
						public const int CAPABILITY_HAS_VIDEO = 2;
						/// <summary>
						///  <para>An allowed flag of CHAT_CAPABILITY. Indicates that the contact's device has a camera that can be used for video chat (e.g. a front-facing camera on a phone). </para>        
						/// </summary>
						/// <java-name>
						/// CAPABILITY_HAS_CAMERA
						/// </java-name>
						[Dot42.DexImport("CAPABILITY_HAS_CAMERA", "I", AccessFlags = 25)]
						public const int CAPABILITY_HAS_CAMERA = 4;
				}

				/// <summary>
				///  <para>Social status update columns.</para> <para> <para>StatusUpdates </para> <para>ContactsContract.Data </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$StatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$StatusColumns", AccessFlags = 1548)]
				protected internal partial interface IStatusColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Constants for the raw contacts table, which contains one row of contact information for each person in each synced account. Sync adapters and contact management apps are the primary consumers of this API.</para> <para> <h3>Aggregation</h3></para> <para>As soon as a raw contact is inserted or whenever its constituent data changes, the provider will check if the raw contact matches other existing raw contacts and if so will aggregate it with those. The aggregation is reflected in the RawContacts table by the change of the CONTACT_ID field, which is the reference to the aggregate contact. </para> <para>Changes to the structured name, organization, phone number, email address, or nickname trigger a re-aggregation. </para> <para>See also AggregationExceptions for a mechanism to control aggregation programmatically. </para> <para> <h3>Operations</h3></para> <para> <h2>Columns</h2></para> <para> <table> <row> <entry> <para>RawContacts  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Row ID. Sync adapters should try to preserve row IDs during updates. In other words, it is much better for a sync adapter to update a raw contact rather than to delete and re-insert it.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>CONTACT_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The ID of the row in the ContactsContract.Contacts table that this raw contact belongs to. Raw contacts are linked to contacts by the aggregation process, which can be controlled by the AGGREGATION_MODE field and AggregationExceptions.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>AGGREGATION_MODE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>A mechanism that allows programmatic control of the aggregation process. The allowed values are AGGREGATION_MODE_DEFAULT, AGGREGATION_MODE_DISABLED and AGGREGATION_MODE_SUSPENDED. See also AggregationExceptions.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>DELETED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The "deleted" flag: "0" by default, "1" if the row has been marked for deletion. When android.content.ContentResolver#delete is called on a raw contact, it is marked for deletion and removed from its aggregate contact. The sync adaptor deletes the raw contact on the server and then calls ContactResolver.delete once more, this time passing the ContactsContract#CALLER_IS_SYNCADAPTER query parameter to finalize the data removal.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TIMES_CONTACTED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The number of times the contact has been contacted. To have an effect on the corresponding value of the aggregate contact, this field should be set at the time the raw contact is inserted. After that, this value is typically updated via ContactsContract.Contacts#markAsContacted.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>LAST_TIME_CONTACTED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The timestamp of the last time the contact was contacted. To have an effect on the corresponding value of the aggregate contact, this field should be set at the time the raw contact is inserted. After that, this value is typically updated via ContactsContract.Contacts#markAsContacted.   </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>STARRED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>An indicator for favorite contacts: '1' if favorite, '0' otherwise. Changing this field immediately affects the corresponding aggregate contact: if any raw contacts in that aggregate contact are starred, then the contact itself is marked as starred.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CUSTOM_RINGTONE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>A custom ringtone associated with a raw contact. Typically this is the URI returned by an activity launched with the android.media.RingtoneManager#ACTION_RINGTONE_PICKER intent. To have an effect on the corresponding value of the aggregate contact, this field should be set at the time the raw contact is inserted. To set a custom ringtone on a contact, use the field Contacts.CUSTOM_RINGTONE instead.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SEND_TO_VOICEMAIL </para></entry> <entry> <para>read/write </para></entry> <entry> <para>An indicator of whether calls from this raw contact should be forwarded directly to voice mail ('1') or not ('0'). To have an effect on the corresponding value of the aggregate contact, this field should be set at the time the raw contact is inserted.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>ACCOUNT_NAME </para></entry> <entry> <para>read/write-once </para></entry> <entry> <para>The name of the account instance to which this row belongs, which when paired with ACCOUNT_TYPE identifies a specific account. For example, this will be the Gmail address if it is a Google account. It should be set at the time the raw contact is inserted and never changed afterwards.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>ACCOUNT_TYPE </para></entry> <entry> <para>read/write-once </para></entry> <entry> <para></para> <para>The type of account to which this row belongs, which when paired with ACCOUNT_NAME identifies a specific account. It should be set at the time the raw contact is inserted and never changed afterwards. </para> <para></para> <para>To ensure uniqueness, new account types should be chosen according to the Java package naming convention. Thus a Google account is of type "com.google". </para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DATA_SET </para></entry> <entry> <para>read/write-once </para></entry> <entry> <para></para> <para>The data set within the account that this row belongs to. This allows multiple sync adapters for the same account type to distinguish between each others' data. The combination of ACCOUNT_TYPE, ACCOUNT_NAME, and DATA_SET identifies a set of data that is associated with a single sync adapter. </para> <para></para> <para>This is empty by default, and is completely optional. It only needs to be populated if multiple sync adapters are entering distinct data for the same account type and account name. </para> <para></para> <para>It should be set at the time the raw contact is inserted and never changed afterwards. </para> <para></para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SOURCE_ID </para></entry> <entry> <para>read/write </para></entry> <entry> <para>String that uniquely identifies this row to its source account. Typically it is set at the time the raw contact is inserted and never changed afterwards. The one notable exception is a new raw contact: it will have an account name and type (and possibly a data set), but no source id. This indicates to the sync adapter that a new contact needs to be created server-side and its ID stored in the corresponding SOURCE_ID field on the phone.   </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>VERSION </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Version number that is updated whenever this row or its related data changes. This field can be used for optimistic locking of a raw contact.   </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>DIRTY </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Flag indicating that VERSION has changed, and this row needs to be synchronized by its owning account. The value is set to "1" automatically whenever the raw contact changes, unless the URI has the ContactsContract#CALLER_IS_SYNCADAPTER query parameter specified. The sync adapter should always supply this query parameter to prevent unnecessary synchronization: user changes some data on the server, the sync adapter updates the contact on the phone (without the CALLER_IS_SYNCADAPTER flag) flag, which sets the DIRTY flag, which triggers a sync to bring the changes to the server.   </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SYNC1 </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Generic column provided for arbitrary use by sync adapters. The content provider stores this information on behalf of the sync adapter but does not interpret it in any way.   </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SYNC2 </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Generic column for use by sync adapters.   </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SYNC3 </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Generic column for use by sync adapters.   </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>SYNC4 </para></entry> <entry> <para>read/write </para></entry> <entry> <para>Generic column for use by sync adapters.   </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$RawContacts
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContacts", AccessFlags = 25)]
				public sealed partial class RawContacts : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IRawContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.ISyncColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table, which requests a directory of raw contact rows matching the selection criteria. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of the results from CONTENT_URI when a specific ID value is not provided, and multiple raw contacts may be returned. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/raw_contact";
						/// <summary>
						///  <para>The MIME type of the results when a raw contact ID is appended to CONTENT_URI, yielding a subdirectory of a single person. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/raw_contact";
						/// <summary>
						///  <para>Aggregation mode: aggregate immediately after insert or update operation(s) are complete. </para>        
						/// </summary>
						/// <java-name>
						/// AGGREGATION_MODE_DEFAULT
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_DEFAULT", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_DEFAULT = 0;
						/// <summary>
						///  <para>Aggregation mode: aggregate at the time the raw contact is inserted/updated.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Aggregation is synchronous, this historic value is a no-op </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// AGGREGATION_MODE_IMMEDIATE
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_IMMEDIATE", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_IMMEDIATE = 1;
						/// <summary>
						///  <para>Aggregation mode: aggregation suspended temporarily, and is likely to be resumed later. Changes to the raw contact will update the associated aggregate contact but will not result in any change in how the contact is aggregated. Similar to AGGREGATION_MODE_DISABLED, but maintains a link to the corresponding Contacts aggregate. </para> <para>This can be used to postpone aggregation until after a series of updates, for better performance and/or user experience. </para> <para>Note that changing AGGREGATION_MODE from AGGREGATION_MODE_SUSPENDED to AGGREGATION_MODE_DEFAULT does not trigger an aggregation pass, but any subsequent change to the raw contact's data will. </para>        
						/// </summary>
						/// <java-name>
						/// AGGREGATION_MODE_SUSPENDED
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_SUSPENDED", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_SUSPENDED = 2;
						/// <summary>
						///  <para>Aggregation mode: never aggregate this raw contact. The raw contact will not have a corresponding Contacts aggregate and therefore will not be included in Contacts query results. </para> <para>For example, this mode can be used for a raw contact that is marked for deletion while waiting for the deletion to occur on the server side. </para> <para> <para>AGGREGATION_MODE_SUSPENDED </para></para>        
						/// </summary>
						/// <java-name>
						/// AGGREGATION_MODE_DISABLED
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE_DISABLED", "I", AccessFlags = 25)]
						public const int AGGREGATION_MODE_DISABLED = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal RawContacts() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Build a android.provider.ContactsContract.Contacts#CONTENT_LOOKUP_URI style Uri for the parent android.provider.ContactsContract.Contacts entry of the given RawContacts entry. </para>        
						/// </summary>
						/// <java-name>
						/// getContactLookupUri
						/// </java-name>
						[Dot42.DexImport("getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetContactLookupUri(global::Android.Content.ContentResolver resolver, global::Android.Net.Uri rawContactUri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>TODO: javadoc </para>        
						/// </summary>
						/// <returns>
						///  <para></para>
						/// </returns>
						/// <java-name>
						/// newEntityIterator
						/// </java-name>
						[Dot42.DexImport("newEntityIterator", "(Landroid/database/Cursor;)Landroid/content/EntityIterator;", AccessFlags = 9)]
						public static global::Android.Content.IEntityIterator NewEntityIterator(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.IEntityIterator);
						}

						/// <summary>
						///  <para>A sub-directory of a single raw contact that contains all of its ContactsContract.Data rows. To access this directory append RawContacts.Entity#CONTENT_DIRECTORY to the raw contact URI. See RawContactsEntity for a stand-alone table containing the same data. </para> <para>Entity has two ID fields: _ID for the raw contact and DATA_ID for the data rows. Entity always contains at least one row, even if there are no actual data rows. In this case the DATA_ID field will be null. </para> <para>Using Entity should be preferred to using two separate queries: RawContacts followed by Data. The reason is that Entity reads all data for a raw contact in one transaction, so there is no possibility of the data changing between the two queries. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$RawContacts$Entity
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$RawContacts$Entity", AccessFlags = 25)]
						public sealed partial class Entity : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "entity";
								/// <summary>
								///  <para>The ID of the data row. The value will be null if this raw contact has no data rows. </para> <para>Type: INTEGER</para>        
								/// </summary>
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

						/// <summary>
						///  <para>A sub-directory of a single raw contact that contains all of its ContactsContract.Data rows. To access this directory append Data#CONTENT_DIRECTORY to the raw contact URI. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$RawContacts$Data
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$RawContacts$Data", AccessFlags = 25)]
						public sealed partial class Data : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table </para>        
								/// </summary>
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
						/// <summary>
						///  <para>A reference to the ContactsContract.Contacts#_ID that this data belongs to. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_ID
						/// </java-name>
						[Dot42.DexImport("CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_ID = "contact_id";
						/// <summary>
						///  <para>The aggregation mode for this contact. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// AGGREGATION_MODE
						/// </java-name>
						[Dot42.DexImport("AGGREGATION_MODE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AGGREGATION_MODE = "aggregation_mode";
						/// <summary>
						///  <para>The "deleted" flag: "0" by default, "1" if the row has been marked for deletion. When android.content.ContentResolver#delete is called on a raw contact, it is marked for deletion and removed from its aggregate contact. The sync adaptor deletes the raw contact on the server and then calls ContactResolver.delete once more, this time passing the ContactsContract#CALLER_IS_SYNCADAPTER query parameter to finalize the data removal. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// DELETED
						/// </java-name>
						[Dot42.DexImport("DELETED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETED = "deleted";
						/// <summary>
						///  <para>The "read-only" flag: "0" by default, "1" if the row cannot be modified or deleted except by a sync adapter. See ContactsContract#CALLER_IS_SYNCADAPTER. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// RAW_CONTACT_IS_READ_ONLY
						/// </java-name>
						[Dot42.DexImport("RAW_CONTACT_IS_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RAW_CONTACT_IS_READ_ONLY = "raw_contact_is_read_only";
				}

				/// <java-name>
				/// android/provider/ContactsContract$RawContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$RawContactsColumns", AccessFlags = 1548)]
				protected internal partial interface IRawContactsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Constants for the contacts table, which contains a record per aggregate of raw contacts representing the same person.  <h3>Operations</h3></para> <para> <h2>Columns</h2></para> <para> <table> <row> <entry> <para>Contacts  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Row ID. Consider using LOOKUP_KEY instead.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>LOOKUP_KEY </para></entry> <entry> <para>read-only </para></entry> <entry> <para>An opaque value that contains hints on how to find the contact if its row id changed as a result of a sync or aggregation.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>NAME_RAW_CONTACT_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The ID of the raw contact that contributes the display name to the aggregate contact. During aggregation one of the constituent raw contacts is chosen using a heuristic: a longer name or a name with more diacritic marks or more upper case characters is chosen.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>DISPLAY_NAME_PRIMARY </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The display name for the contact. It is the display name contributed by the raw contact referred to by the NAME_RAW_CONTACT_ID column.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>PHOTO_ID </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Reference to the row in the ContactsContract.Data table holding the photo. That row has the mime type CommonDataKinds.Photo#CONTENT_ITEM_TYPE. The value of this field is computed automatically based on the CommonDataKinds.Photo#IS_SUPER_PRIMARY field of the data rows of that mime type.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>PHOTO_URI </para></entry> <entry> <para>read-only </para></entry> <entry> <para>A URI that can be used to retrieve the contact's full-size photo. This column is the preferred method of retrieving the contact photo.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>PHOTO_THUMBNAIL_URI </para></entry> <entry> <para>read-only </para></entry> <entry> <para>A URI that can be used to retrieve the thumbnail of contact's photo. This column is the preferred method of retrieving the contact photo.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>IN_VISIBLE_GROUP </para></entry> <entry> <para>read-only </para></entry> <entry> <para>An indicator of whether this contact is supposed to be visible in the UI. "1" if the contact has at least one raw contact that belongs to a visible group; "0" otherwise.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>HAS_PHONE_NUMBER </para></entry> <entry> <para>read-only </para></entry> <entry> <para>An indicator of whether this contact has at least one phone number. "1" if there is at least one phone number, "0" otherwise.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>TIMES_CONTACTED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The number of times the contact has been contacted. See markAsContacted. When raw contacts are aggregated, this field is computed automatically as the maximum number of times contacted among all constituent raw contacts. Setting this field automatically changes the corresponding field on all constituent raw contacts.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>LAST_TIME_CONTACTED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>The timestamp of the last time the contact was contacted. See markAsContacted. Setting this field also automatically increments TIMES_CONTACTED. When raw contacts are aggregated, this field is computed automatically as the latest time contacted of all constituent raw contacts. Setting this field automatically changes the corresponding field on all constituent raw contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>STARRED </para></entry> <entry> <para>read/write </para></entry> <entry> <para>An indicator for favorite contacts: '1' if favorite, '0' otherwise. When raw contacts are aggregated, this field is automatically computed: if any constituent raw contacts are starred, then this field is set to '1'. Setting this field automatically changes the corresponding field on all constituent raw contacts.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CUSTOM_RINGTONE </para></entry> <entry> <para>read/write </para></entry> <entry> <para>A custom ringtone associated with a contact. Typically this is the URI returned by an activity launched with the android.media.RingtoneManager#ACTION_RINGTONE_PICKER intent.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>SEND_TO_VOICEMAIL </para></entry> <entry> <para>read/write </para></entry> <entry> <para>An indicator of whether calls from this contact should be forwarded directly to voice mail ('1') or not ('0'). When raw contacts are aggregated, this field is automatically computed: if  <b>all</b> constituent raw contacts have SEND_TO_VOICEMAIL=1, then this field is set to '1'. Setting this field automatically changes the corresponding field on all constituent raw contacts.  </para></entry></row> <row> <entry> <para>int </para></entry> <entry> <para>CONTACT_PRESENCE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Contact IM presence status. See StatusUpdates for individual status definitions. Automatically computed as the highest presence of all constituent raw contacts. The provider may choose not to store this value in persistent storage. The expectation is that presence status will be updated on a regular basis.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CONTACT_STATUS </para></entry> <entry> <para>read-only </para></entry> <entry> <para>Contact's latest status update. Automatically computed as the latest of all constituent raw contacts' status updates.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>CONTACT_STATUS_TIMESTAMP </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The absolute time in milliseconds when the latest status was inserted/updated.  </para></entry></row> <row> <entry> <para>String </para></entry> <entry> <para>CONTACT_STATUS_RES_PACKAGE </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The package containing resources for this status: label and icon.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>CONTACT_STATUS_LABEL </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The resource ID of the label describing the source of contact status, e.g. "Google Talk". This resource is scoped by the CONTACT_STATUS_RES_PACKAGE.  </para></entry></row> <row> <entry> <para>long </para></entry> <entry> <para>CONTACT_STATUS_ICON </para></entry> <entry> <para>read-only </para></entry> <entry> <para>The resource ID of the icon for the source of contact status. This resource is scoped by the CONTACT_STATUS_RES_PACKAGE.  </para></entry></row></table></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$Contacts
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Contacts", AccessFlags = 9)]
				public partial class Contacts : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>A content:// style URI for this table that should be used to create shortcuts or otherwise create long-term links to contacts. This URI should always be followed by a "/" and the contact's LOOKUP_KEY. It can optionally also have a "/" and last known contact ID appended after that. This "complete" format is an important optimization and is highly recommended. </para> <para>As long as the contact's row ID remains the same, this URI is equivalent to CONTENT_URI. If the contact's row ID changes as a result of a sync or aggregation, this URI will look up the contact using indirect information (sync IDs or constituent raw contacts). </para> <para>Lookup key should be appended unencoded - it is stored in the encoded form, ready for use in a URI. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_LOOKUP_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_LOOKUP_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_LOOKUP_URI;
						/// <summary>
						///  <para>Base Uri for referencing a single Contacts entry, created by appending LOOKUP_KEY using Uri#withAppendedPath(Uri, String). Provides OpenableColumns columns when queried, or returns the referenced contact formatted as a vCard when opened through ContentResolver#openAssetFileDescriptor(Uri, String). </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_VCARD_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_VCARD_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_VCARD_URI;
						/// <summary>
						///  <para>The content:// style URI used for "type-to-filter" functionality on the CONTENT_URI URI. The filter string will be used to match various parts of the contact name. The filter argument should be passed as an additional path segment after this URI. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_FILTER_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_FILTER_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_FILTER_URI;
						/// <summary>
						///  <para>The content:// style URI for this table joined with useful data from ContactsContract.Data, filtered to include only starred contacts and the most frequently contacted contacts. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_STREQUENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_STREQUENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_STREQUENT_URI;
						/// <summary>
						///  <para>The content:// style URI used for "type-to-filter" functionality on the CONTENT_STREQUENT_URI URI. The filter string will be used to match various parts of the contact name. The filter argument should be passed as an additional path segment after this URI. </para>        
						/// </summary>
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
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of people. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single person. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI subdirectory of a single person. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_VCARD_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_VCARD_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_VCARD_TYPE = "text/x-vcard";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Contacts() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Builds a CONTENT_LOOKUP_URI style Uri describing the requested Contacts entry.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// getLookupUri
						/// </java-name>
						[Dot42.DexImport("getLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetLookupUri(global::Android.Content.ContentResolver resolver, global::Android.Net.Uri contactUri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Builds a CONTENT_LOOKUP_URI style Uri describing the requested Contacts entry.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// getLookupUri
						/// </java-name>
						[Dot42.DexImport("getLookupUri", "(JLjava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetLookupUri(long resolver, string contactUri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Computes a content URI (see CONTENT_URI) given a lookup URI. </para> <para>Returns null if the contact cannot be found. </para>        
						/// </summary>
						/// <java-name>
						/// lookupContact
						/// </java-name>
						[Dot42.DexImport("lookupContact", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri LookupContact(global::Android.Content.ContentResolver resolver, global::Android.Net.Uri lookupUri) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Mark a contact as having been contacted. Updates two fields: TIMES_CONTACTED and LAST_TIME_CONTACTED. The TIMES_CONTACTED field is incremented by 1 and the LAST_TIME_CONTACTED field is populated with the current system time.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The class DataUsageStatUpdater of the Android support library should be used instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// markAsContacted
						/// </java-name>
						[Dot42.DexImport("markAsContacted", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
						public static void MarkAsContacted(global::Android.Content.ContentResolver resolver, long contactId) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Opens an InputStream for the contacts's thumbnail photo and returns the photo as a byte stream.  <para>openContactPhotoInputStream(ContentResolver, Uri, boolean), if instead of the thumbnail the high-res picture is preferred </para></para>        
						/// </summary>
						/// <returns>
						///  <para>an InputStream of the photo, or null if no photo is present </para>
						/// </returns>
						/// <java-name>
						/// openContactPhotoInputStream
						/// </java-name>
						[Dot42.DexImport("openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;", AccessFlags = 9)]
						public static global::Java.IO.InputStream OpenContactPhotoInputStream(global::Android.Content.ContentResolver cr, global::Android.Net.Uri contactUri) /* MethodBuilder.Create */ 
						{
								return default(global::Java.IO.InputStream);
						}

						/// <summary>
						///  <para>A  <b>read-only</b> sub-directory of a single contact that contains the contact's primary photo. The photo may be stored in up to two ways - the default "photo" is a thumbnail-sized image stored directly in the data row, while the "display photo", if present, is a larger version stored as a file. </para> <para>Usage example: </para> <para>You may also consider using the convenience method ContactsContract.Contacts#openContactPhotoInputStream(ContentResolver, Uri, boolean) to retrieve the raw photo contents of either the thumbnail-sized or the full-sized photo. </para> <para>This directory can be used either with a CONTENT_URI or CONTENT_LOOKUP_URI. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$Contacts$Photo
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$Photo", AccessFlags = 25)]
						public sealed partial class Photo : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumnsWithJoins
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "photo";
								/// <summary>
								///  <para>Thumbnail photo of the raw contact. This is the raw bytes of an image that could be inflated using android.graphics.BitmapFactory. </para> <para>Type: BLOB </para>        
								/// </summary>
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

						/// <summary>
						///  <para>A  <b>read-only</b> sub-directory of a single contact aggregate that contains all aggregation suggestions (other contacts). The aggregation suggestions are computed based on approximate data matches with this contact. </para> <para> <b>Note: this query may be expensive! If you need to use it in bulk, make sure the user experience is acceptable when the query runs for a long time.</b> </para> <para>Usage example:</para> <para> <pre>
						/// Uri uri = Contacts.CONTENT_URI.buildUpon()
						///          .appendEncodedPath(String.valueOf(contactId))
						///          .appendPath(Contacts.AggregationSuggestions.CONTENT_DIRECTORY)
						///          .appendQueryParameter("limit", "3")
						///          .build()
						/// Cursor cursor = getContentResolver().query(suggestionsUri,
						///          new String[] {Contacts.DISPLAY_NAME, Contacts._ID, Contacts.LOOKUP_KEY},
						///          null, null, null);
						/// </pre></para> <para>This directory can be used either with a CONTENT_URI or CONTENT_LOOKUP_URI. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$Contacts$AggregationSuggestions
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$AggregationSuggestions", AccessFlags = 25)]
						public sealed partial class AggregationSuggestions : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table. The URI can be followed by an optional type-to-filter, similar to android.provider.ContactsContract.Contacts#CONTENT_FILTER_URI. </para>        
								/// </summary>
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

						/// <summary>
						///  <para>A sub-directory of a contact that contains all of its ContactsContract.RawContacts as well as ContactsContract.Data rows. To access this directory append CONTENT_DIRECTORY to the contact URI. </para> <para>Entity has three ID fields: CONTACT_ID for the contact, RAW_CONTACT_ID for the raw contact and DATA_ID for the data rows. Entity always contains at least one row per constituent raw contact, even if there are no actual data rows. In this case the DATA_ID field will be null. </para> <para>Entity reads all data for the entire contact in one transaction, to guarantee consistency. There is significant data duplication in the Entity (each row repeats all Contact columns and all RawContact columns), so the benefits of transactional consistency should be weighed against the cost of transferring large amounts of denormalized data from the Provider. </para> <para>To reduce the amount of data duplication the contacts provider and directory providers implementing this protocol are allowed to provide common Contacts and RawContacts fields in the first row returned for each raw contact only and leave them as null in subsequent rows. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$Contacts$Entity
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$Entity", AccessFlags = 25)]
						public sealed partial class Entity : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IContactsColumns, global::Android.Provider.ContactsContract.IContactNameColumns, global::Android.Provider.ContactsContract.IRawContactsColumns, global::Android.Provider.ContactsContract.IBaseSyncColumns, global::Android.Provider.ContactsContract.ISyncColumns, global::Android.Provider.ContactsContract.IDataColumns, global::Android.Provider.ContactsContract.IStatusColumns, global::Android.Provider.ContactsContract.IContactOptionsColumns, global::Android.Provider.ContactsContract.IContactStatusColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_DIRECTORY
								/// </java-name>
								[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_DIRECTORY = "entities";
								/// <summary>
								///  <para>The ID of the raw contact row. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// RAW_CONTACT_ID
								/// </java-name>
								[Dot42.DexImport("RAW_CONTACT_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string RAW_CONTACT_ID = "raw_contact_id";
								/// <summary>
								///  <para>The ID of the data row. The value will be null if this raw contact has no data rows. </para> <para>Type: INTEGER</para>        
								/// </summary>
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

						/// <summary>
						///  <para>A sub-directory of a single contact that contains all of the constituent raw contact ContactsContract.Data rows. This directory can be used either with a CONTENT_URI or CONTENT_LOOKUP_URI. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/ContactsContract$Contacts$Data
						/// </java-name>
						[Dot42.DexImport("android/provider/ContactsContract$Contacts$Data", AccessFlags = 25)]
						public sealed partial class Data : global::Android.Provider.IBaseColumns, global::Android.Provider.ContactsContract.IDataColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The directory twig for this sub-table </para>        
								/// </summary>
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

				/// <summary>
				///  <para>Contact name and contact name metadata columns in the RawContacts table.</para> <para> <para>Contacts </para> <para>RawContacts </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactNameColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactNameColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactNameColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The kind of data that is used as the display name for the contact, such as structured name or email address. See DisplayNameSources. </para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME_SOURCE
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME_SOURCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME_SOURCE = "display_name_source";
						/// <summary>
						///  <para>The standard text shown as the contact's display name, based on the best available information for the contact (for example, it might be the email address if the name is not available). The information actually used to compute the name is stored in DISPLAY_NAME_SOURCE. </para> <para>A contacts provider is free to choose whatever representation makes most sense for its target market. For example in the default Android Open Source Project implementation, if the display name is based on the structured name and the structured name follows the Western full-name style, then this field contains the "given name first" version of the full name. </para> <para> <para>ContactsContract.ContactNameColumns::DISPLAY_NAME_ALTERNATIVE </para></para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME_PRIMARY
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME_PRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME_PRIMARY = "display_name";
						/// <summary>
						///  <para>An alternative representation of the display name, such as "family name first" instead of "given name first" for Western names. If an alternative is not available, the values should be the same as DISPLAY_NAME_PRIMARY. </para> <para>A contacts provider is free to provide alternatives as necessary for its target market. For example the default Android Open Source Project contacts provider currently provides an alternative in a single case: if the display name is based on the structured name and the structured name follows the Western full name style, then the field contains the "family name first" version of the full name. Other cases may be added later. </para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME_ALTERNATIVE
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME_ALTERNATIVE = "display_name_alt";
						/// <summary>
						///  <para>The phonetic alphabet used to represent the PHONETIC_NAME. See PhoneticNameStyle. </para>        
						/// </summary>
						/// <java-name>
						/// PHONETIC_NAME_STYLE
						/// </java-name>
						[Dot42.DexImport("PHONETIC_NAME_STYLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONETIC_NAME_STYLE = "phonetic_name_style";
						/// <summary>
						///  <para>Pronunciation of the full name in the phonetic alphabet specified by PHONETIC_NAME_STYLE. </para> <para>The value may be set manually by the user. This capability is of interest only in countries with commonly used phonetic alphabets, such as Japan and Korea. See PhoneticNameStyle. </para>        
						/// </summary>
						/// <java-name>
						/// PHONETIC_NAME
						/// </java-name>
						[Dot42.DexImport("PHONETIC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONETIC_NAME = "phonetic_name";
						/// <summary>
						///  <para>Sort key that takes into account locale-based traditions for sorting names in address books. The default sort key is DISPLAY_NAME_PRIMARY. For Chinese names the sort key is the name's Pinyin spelling, and for Japanese names it is the Hiragana version of the phonetic name. </para>        
						/// </summary>
						/// <java-name>
						/// SORT_KEY_PRIMARY
						/// </java-name>
						[Dot42.DexImport("SORT_KEY_PRIMARY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SORT_KEY_PRIMARY = "sort_key";
						/// <summary>
						///  <para>Sort key based on the alternative representation of the full name, DISPLAY_NAME_ALTERNATIVE. Thus for Western names, it is the one using the "family name first" format. </para>        
						/// </summary>
						/// <java-name>
						/// SORT_KEY_ALTERNATIVE
						/// </java-name>
						[Dot42.DexImport("SORT_KEY_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SORT_KEY_ALTERNATIVE = "sort_key_alt";
				}

				/// <summary>
				///  <para>Contact name and contact name metadata columns in the RawContacts table.</para> <para> <para>Contacts </para> <para>RawContacts </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactNameColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactNameColumns", AccessFlags = 1548)]
				protected internal partial interface IContactNameColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Types of data used to produce the display name for a contact. In the order of increasing priority: EMAIL, PHONE, ORGANIZATION, NICKNAME, STRUCTURED_NAME. </para>    
				/// </summary>
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

				/// <summary>
				///  <para>Types of data used to produce the display name for a contact. In the order of increasing priority: EMAIL, PHONE, ORGANIZATION, NICKNAME, STRUCTURED_NAME. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$DisplayNameSources
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$DisplayNameSources", AccessFlags = 1545)]
				public partial interface IDisplayNameSources
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Constants for various styles of capturing the pronunciation of a person's name. </para>    
				/// </summary>
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
						/// <summary>
						///  <para>Pinyin is a phonetic method of entering Chinese characters. Typically not explicitly shown in UIs, but used for searches and sorting. </para>        
						/// </summary>
						/// <java-name>
						/// PINYIN
						/// </java-name>
						[Dot42.DexImport("PINYIN", "I", AccessFlags = 25)]
						public const int PINYIN = 3;
						/// <summary>
						///  <para>Hiragana and Katakana are two common styles of writing out the pronunciation of a Japanese names. </para>        
						/// </summary>
						/// <java-name>
						/// JAPANESE
						/// </java-name>
						[Dot42.DexImport("JAPANESE", "I", AccessFlags = 25)]
						public const int JAPANESE = 4;
						/// <summary>
						///  <para>Hangul is the Korean phonetic alphabet. </para>        
						/// </summary>
						/// <java-name>
						/// KOREAN
						/// </java-name>
						[Dot42.DexImport("KOREAN", "I", AccessFlags = 25)]
						public const int KOREAN = 5;
				}

				/// <summary>
				///  <para>Constants for various styles of capturing the pronunciation of a person's name. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$PhoneticNameStyle
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$PhoneticNameStyle", AccessFlags = 1545)]
				public partial interface IPhoneticNameStyle
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Constants for various styles of combining given name, family name etc into a full name. For example, the western tradition follows the pattern 'given name' 'middle name' 'family name' with the alternative pattern being 'family name', 'given name' 'middle name'. The CJK tradition is 'family name' 'middle name' 'given name', with Japanese favoring a space between the names and Chinese omitting the space. </para>    
				/// </summary>
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
						/// <summary>
						///  <para>Used if the name is written in Hanzi/Kanji/Hanja and we could not determine which specific language it belongs to: Chinese, Japanese or Korean. </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Constants for various styles of combining given name, family name etc into a full name. For example, the western tradition follows the pattern 'given name' 'middle name' 'family name' with the alternative pattern being 'family name', 'given name' 'middle name'. The CJK tradition is 'family name' 'middle name' 'given name', with Japanese favoring a space between the names and Chinese omitting the space. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$FullNameStyle
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$FullNameStyle", AccessFlags = 1545)]
				public partial interface IFullNameStyle
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para> <para>Contacts </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactStatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactStatusColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactStatusColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Contact presence status. See StatusUpdates for individual status definitions. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_PRESENCE
						/// </java-name>
						[Dot42.DexImport("CONTACT_PRESENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_PRESENCE = "contact_presence";
						/// <summary>
						///  <para>Contact Chat Capabilities. See StatusUpdates for individual definitions. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_CHAT_CAPABILITY
						/// </java-name>
						[Dot42.DexImport("CONTACT_CHAT_CAPABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_CHAT_CAPABILITY = "contact_chat_capability";
						/// <summary>
						///  <para>Contact's latest status update. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_STATUS
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS = "contact_status";
						/// <summary>
						///  <para>The absolute time in milliseconds when the latest status was inserted/updated. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_STATUS_TIMESTAMP
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_TIMESTAMP = "contact_status_ts";
						/// <summary>
						///  <para>The package containing resources for this status: label and icon. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_STATUS_RES_PACKAGE
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_RES_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_RES_PACKAGE = "contact_status_res_package";
						/// <summary>
						///  <para>The resource ID of the label describing the source of contact status, e.g. "Google Talk". This resource is scoped by the CONTACT_STATUS_RES_PACKAGE. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_STATUS_LABEL
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_LABEL = "contact_status_label";
						/// <summary>
						///  <para>The resource ID of the icon for the source of contact status. This resource is scoped by the CONTACT_STATUS_RES_PACKAGE. </para> <para>Type: NUMBER</para>        
						/// </summary>
						/// <java-name>
						/// CONTACT_STATUS_ICON
						/// </java-name>
						[Dot42.DexImport("CONTACT_STATUS_ICON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTACT_STATUS_ICON = "contact_status_icon";
				}

				/// <summary>
				///  <para> <para>Contacts </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactStatusColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactStatusColumns", AccessFlags = 1548)]
				protected internal partial interface IContactStatusColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Columns of ContactsContract.Contacts that refer to intrinsic properties of the contact, as opposed to the user-specified options found in ContactOptionsColumns.</para> <para> <para>Contacts </para> <para>ContactsContract.Data </para> <para>PhoneLookup </para> <para>ContactsContract.Contacts.AggregationSuggestions </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The display name for the contact. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "display_name";
						/// <summary>
						///  <para>Reference to the row in the data table holding the photo. A photo can be referred to either by ID (this field) or by URI (see PHOTO_THUMBNAIL_URI and PHOTO_URI). If PHOTO_ID is null, consult PHOTO_URI or PHOTO_THUMBNAIL_URI, which is a more generic mechanism for referencing the contact photo, especially for contacts returned by non-local directories (see Directory).</para> <para>Type: INTEGER REFERENCES data(_id)</para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_ID
						/// </java-name>
						[Dot42.DexImport("PHOTO_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_ID = "photo_id";
						/// <summary>
						///  <para>A URI that can be used to retrieve the contact's full-size photo. If PHOTO_FILE_ID is not null, this will be populated with a URI based off ContactsContract.DisplayPhoto#CONTENT_URI. Otherwise, this will be populated with the same value as PHOTO_THUMBNAIL_URI. A photo can be referred to either by a URI (this field) or by ID (see PHOTO_ID). If either PHOTO_FILE_ID or PHOTO_ID is not null, PHOTO_URI and PHOTO_THUMBNAIL_URI shall not be null (but not necessarily vice versa). Thus using PHOTO_URI is a more robust method of retrieving contact photos.</para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_URI
						/// </java-name>
						[Dot42.DexImport("PHOTO_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_URI = "photo_uri";
						/// <summary>
						///  <para>A URI that can be used to retrieve a thumbnail of the contact's photo. A photo can be referred to either by a URI (this field or PHOTO_URI) or by ID (see PHOTO_ID). If PHOTO_ID is not null, PHOTO_URI and PHOTO_THUMBNAIL_URI shall not be null (but not necessarily vice versa). If the content provider does not differentiate between full-size photos and thumbnail photos, PHOTO_THUMBNAIL_URI and PHOTO_URI can contain the same value, but either both shall be null or both not null.</para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_THUMBNAIL_URI
						/// </java-name>
						[Dot42.DexImport("PHOTO_THUMBNAIL_URI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_THUMBNAIL_URI = "photo_thumb_uri";
						/// <summary>
						///  <para>Flag that reflects the Groups#GROUP_VISIBLE state of any CommonDataKinds.GroupMembership for this contact. </para>        
						/// </summary>
						/// <java-name>
						/// IN_VISIBLE_GROUP
						/// </java-name>
						[Dot42.DexImport("IN_VISIBLE_GROUP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string IN_VISIBLE_GROUP = "in_visible_group";
						/// <summary>
						///  <para>An indicator of whether this contact has at least one phone number. "1" if there is at least one phone number, "0" otherwise. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// HAS_PHONE_NUMBER
						/// </java-name>
						[Dot42.DexImport("HAS_PHONE_NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAS_PHONE_NUMBER = "has_phone_number";
						/// <summary>
						///  <para>An opaque value that contains hints on how to find the contact if its row id changed as a result of a sync or aggregation. </para>        
						/// </summary>
						/// <java-name>
						/// LOOKUP_KEY
						/// </java-name>
						[Dot42.DexImport("LOOKUP_KEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOOKUP_KEY = "lookup";
				}

				/// <summary>
				///  <para>Columns of ContactsContract.Contacts that refer to intrinsic properties of the contact, as opposed to the user-specified options found in ContactOptionsColumns.</para> <para> <para>Contacts </para> <para>ContactsContract.Data </para> <para>PhoneLookup </para> <para>ContactsContract.Contacts.AggregationSuggestions </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactsColumns", AccessFlags = 1548)]
				protected internal partial interface IContactsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Columns of ContactsContract.Contacts that track the user's preferences for, or interactions with, the contact.</para> <para> <para>Contacts </para> <para>RawContacts </para> <para>ContactsContract.Data </para> <para>PhoneLookup </para> <para>ContactsContract.Contacts.AggregationSuggestions </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactOptionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactOptionsColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IContactOptionsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The number of times a contact has been contacted </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// TIMES_CONTACTED
						/// </java-name>
						[Dot42.DexImport("TIMES_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIMES_CONTACTED = "times_contacted";
						/// <summary>
						///  <para>The last time a contact was contacted. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// LAST_TIME_CONTACTED
						/// </java-name>
						[Dot42.DexImport("LAST_TIME_CONTACTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LAST_TIME_CONTACTED = "last_time_contacted";
						/// <summary>
						///  <para>Is the contact starred? </para> <para>Type: INTEGER (boolean)</para>        
						/// </summary>
						/// <java-name>
						/// STARRED
						/// </java-name>
						[Dot42.DexImport("STARRED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STARRED = "starred";
						/// <summary>
						///  <para>URI for a custom ringtone associated with the contact. If null or missing, the default ringtone is used. </para> <para>Type: TEXT (URI to the ringtone)</para>        
						/// </summary>
						/// <java-name>
						/// CUSTOM_RINGTONE
						/// </java-name>
						[Dot42.DexImport("CUSTOM_RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CUSTOM_RINGTONE = "custom_ringtone";
						/// <summary>
						///  <para>Whether the contact should always be sent to voicemail. If missing, defaults to false. </para> <para>Type: INTEGER (0 for false, 1 for true)</para>        
						/// </summary>
						/// <java-name>
						/// SEND_TO_VOICEMAIL
						/// </java-name>
						[Dot42.DexImport("SEND_TO_VOICEMAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEND_TO_VOICEMAIL = "send_to_voicemail";
				}

				/// <summary>
				///  <para>Columns of ContactsContract.Contacts that track the user's preferences for, or interactions with, the contact.</para> <para> <para>Contacts </para> <para>RawContacts </para> <para>ContactsContract.Data </para> <para>PhoneLookup </para> <para>ContactsContract.Contacts.AggregationSuggestions </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$ContactOptionsColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$ContactOptionsColumns", AccessFlags = 1548)]
				protected internal partial interface IContactOptionsColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Columns that appear when each row of a table belongs to a specific account, including sync information that an account may need.</para> <para> <para>RawContacts </para> <para>Groups </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$SyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SyncColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class ISyncColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The name of the account instance to which this row belongs, which when paired with ACCOUNT_TYPE identifies a specific account. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <summary>
						///  <para>The type of account to which this row belongs, which when paired with ACCOUNT_NAME identifies a specific account. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <summary>
						///  <para>String that uniquely identifies this row to its source account. </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// SOURCE_ID
						/// </java-name>
						[Dot42.DexImport("SOURCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOURCE_ID = "sourceid";
						/// <summary>
						///  <para>Version number that is updated whenever this row or its related data changes. </para> <para>Type: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// VERSION
						/// </java-name>
						[Dot42.DexImport("VERSION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VERSION = "version";
						/// <summary>
						///  <para>Flag indicating that VERSION has changed, and this row needs to be synchronized by its owning account. </para> <para>Type: INTEGER (boolean)</para>        
						/// </summary>
						/// <java-name>
						/// DIRTY
						/// </java-name>
						[Dot42.DexImport("DIRTY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIRTY = "dirty";
				}

				/// <summary>
				///  <para>Columns that appear when each row of a table belongs to a specific account, including sync information that an account may need.</para> <para> <para>RawContacts </para> <para>Groups </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$SyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$SyncColumns", AccessFlags = 1548)]
				protected internal partial interface ISyncColumns : global::Android.Provider.ContactsContract.IBaseSyncColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>Generic columns for use by sync adapters. The specific functions of these columns are private to the sync adapter. Other clients of the API should not attempt to either read or write this column.</para> <para> <para>RawContacts </para> <para>Groups </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$BaseSyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$BaseSyncColumns", AccessFlags = 1548, IgnoreFromJava = true, Priority = 1)]
				public static partial class IBaseSyncColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Generic column for use by sync adapters. </para>        
						/// </summary>
						/// <java-name>
						/// SYNC1
						/// </java-name>
						[Dot42.DexImport("SYNC1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC1 = "sync1";
						/// <summary>
						///  <para>Generic column for use by sync adapters. </para>        
						/// </summary>
						/// <java-name>
						/// SYNC2
						/// </java-name>
						[Dot42.DexImport("SYNC2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC2 = "sync2";
						/// <summary>
						///  <para>Generic column for use by sync adapters. </para>        
						/// </summary>
						/// <java-name>
						/// SYNC3
						/// </java-name>
						[Dot42.DexImport("SYNC3", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC3 = "sync3";
						/// <summary>
						///  <para>Generic column for use by sync adapters. </para>        
						/// </summary>
						/// <java-name>
						/// SYNC4
						/// </java-name>
						[Dot42.DexImport("SYNC4", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYNC4 = "sync4";
				}

				/// <summary>
				///  <para>Generic columns for use by sync adapters. The specific functions of these columns are private to the sync adapter. Other clients of the API should not attempt to either read or write this column.</para> <para> <para>RawContacts </para> <para>Groups </para></para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$BaseSyncColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$BaseSyncColumns", AccessFlags = 1548)]
				protected internal partial interface IBaseSyncColumns
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para>A table provided for sync adapters to use for storing private sync state data for contacts.</para> <para> <para>SyncStateContract </para></para>    
				/// </summary>
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
						/// <summary>
						///  <para>The content:// style URI for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SyncState() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::get </para></para>        
						/// </summary>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B", AccessFlags = 9)]
						public static sbyte[] JavaGet(global::Android.Content.ContentProviderClient provider, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::get </para></para>        
						/// </summary>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B", AccessFlags = 9, IgnoreFromJava = true)]
						public static byte[] Get(global::Android.Content.ContentProviderClient provider, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(byte[]);
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::get </para></para>        
						/// </summary>
						/// <java-name>
						/// getWithUri
						/// </java-name>
						[Dot42.DexImport("getWithUri", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/" +
    "Pair;", AccessFlags = 9, Signature = "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/" +
    "Pair<Landroid/net/Uri;[B>;")]
						public static global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]> GetWithUri(global::Android.Content.ContentProviderClient provider, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]>);
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::set </para></para>        
						/// </summary>
						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V", AccessFlags = 9)]
						public static void Set(global::Android.Content.ContentProviderClient provider, global::Android.Accounts.Account account, sbyte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::set </para></para>        
						/// </summary>
						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Set(global::Android.Content.ContentProviderClient provider, global::Android.Accounts.Account account, byte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::newSetOperation </para></para>        
						/// </summary>
						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Accounts.Account account, sbyte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <summary>
						///  <para> <para>android.provider.SyncStateContract.Helpers::newSetOperation </para></para>        
						/// </summary>
						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Accounts.Account account, byte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

				}

				/// <summary>
				///  <para>A Directory represents a contacts corpus, e.g. Local contacts, Google Apps Global Address List or Corporate Global Address List. </para> <para>A Directory is implemented as a content provider with its unique authority and the same API as the main Contacts Provider. However, there is no expectation that every directory provider will implement this Contract in its entirety. If a directory provider does not have an implementation for a specific request, it should throw an UnsupportedOperationException. </para> <para>The most important use case for Directories is search. A Directory provider is expected to support at least Contacts.CONTENT_FILTER_URI. If a Directory provider wants to participate in email and phone lookup functionalities, it should also implement CommonDataKinds.Email.CONTENT_FILTER_URI and CommonDataKinds.Phone.CONTENT_FILTER_URI. </para> <para>A directory provider should return NULL for every projection field it does not recognize, rather than throwing an exception. This way it will not be broken if ContactsContract is extended with new fields in the future. </para> <para>The client interacts with a directory via Contacts Provider by supplying an optional <c>directory= </c> query parameter. </para> <para>When the Contacts Provider receives the request, it transforms the URI and forwards the request to the corresponding directory content provider. The URI is transformed in the following fashion:  <ul> <li> <para>The URI authority is replaced with the corresponding DIRECTORY_AUTHORITY. </para></li> <li> <para>The <c>accountName= </c> and <c>accountType= </c> parameters are added or replaced using the corresponding ACCOUNT_TYPE and ACCOUNT_NAME values. </para></li></ul></para> <para>Clients should send directory requests to Contacts Provider and let it forward them to the respective providers rather than constructing directory provider URIs by themselves. This level of indirection allows Contacts Provider to implement additional system-level features and optimizations. Access to Contacts Provider is protected by the READ_CONTACTS permission, but access to the directory provider is protected by BIND_DIRECTORY_SEARCH. This permission was introduced at the API level 17, for previous platform versions the provider should perform the following check to make sure the call is coming from the ContactsProvider:  <pre>
				/// private boolean isCallerAllowed() {
				///   PackageManager pm = getContext().getPackageManager();
				///   for (String packageName: pm.getPackagesForUid(Binder.getCallingUid())) {
				///     if (packageName.equals("com.android.providers.contacts")) {
				///       return true;
				///     }
				///   }
				///   return false;
				/// }
				/// </pre> </para> <para>The Directory table is read-only and is maintained by the Contacts Provider automatically. </para> <para>It always has at least these two rows:  <ul> <li> <para>The local directory. It has Directory._ID = Directory.DEFAULT. This directory can be used to access locally stored contacts. The same can be achieved by omitting the <c>directory= </c> parameter altogether.  </para></li> <li> <para>The local invisible contacts. The corresponding directory ID is Directory.LOCAL_INVISIBLE.  </para></li></ul></para> <para>Custom Directories are discovered by the Contacts Provider following this procedure:  <ul> <li> <para>It finds all installed content providers with meta data identifying them as directory providers in AndroidManifest.xml:  <code> &lt;meta-data android:name="android.content.ContactDirectory" android:value="true" /&gt; </code> </para> <para>This tag should be placed inside the corresponding content provider declaration. </para> <para></para></li> <li> <para>Then Contacts Provider sends a Directory.CONTENT_URI query to each of the directory authorities. A directory provider must implement this query and return a list of directories. Each directory returned by the provider must have a unique combination for the ACCOUNT_NAME and ACCOUNT_TYPE columns (nulls are allowed). Since directory IDs are assigned automatically, the _ID field will not be part of the query projection.  </para></li> <li> <para>Contacts Provider compiles directory lists received from all directory providers into one, assigns each individual directory a globally unique ID and stores all directory records in the Directory table.  </para></li></ul></para> <para>Contacts Provider automatically interrogates newly installed or replaced packages. Thus simply installing a package containing a directory provider is sufficient to have that provider registered. A package supplying a directory provider does not have to contain launchable activities. </para> <para>Every row in the Directory table is automatically associated with the corresponding package (apk). If the package is later uninstalled, all corresponding directory rows are automatically removed from the Contacts Provider. </para> <para>When the list of directories handled by a directory provider changes (for instance when the user adds a new Directory account), the directory provider should call notifyDirectoryChange to notify the Contacts Provider of the change. In response, the Contacts Provider will requery the directory provider to obtain the new list of directories. </para> <para>A directory row can be optionally associated with an existing account (see android.accounts.AccountManager). If the account is later removed, the corresponding directory rows are automatically removed from the Contacts Provider. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/ContactsContract$Directory
				/// </java-name>
				[Dot42.DexImport("android/provider/ContactsContract$Directory", AccessFlags = 25)]
				public sealed partial class Directory : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URI for this table. Requests to this URI can be performed on the UI thread because they are always unblocking. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME-type of CONTENT_URI providing a directory of contact directories. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/contact_directories";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI item. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_ITEM_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_ITEM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_ITEM_TYPE = "vnd.android.cursor.item/contact_directory";
						/// <summary>
						///  <para>_ID of the default directory, which represents locally stored contacts. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "J", AccessFlags = 25)]
						public const long DEFAULT = 0;
						/// <summary>
						///  <para>_ID of the directory that represents locally stored invisible contacts. </para>        
						/// </summary>
						/// <java-name>
						/// LOCAL_INVISIBLE
						/// </java-name>
						[Dot42.DexImport("LOCAL_INVISIBLE", "J", AccessFlags = 25)]
						public const long LOCAL_INVISIBLE = 1;
						/// <summary>
						///  <para>The name of the package that owns this directory. Contacts Provider fill it in with the name of the package containing the directory provider. If the package is later uninstalled, the directories it owns are automatically removed from this table.</para> <para>TYPE: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// PACKAGE_NAME
						/// </java-name>
						[Dot42.DexImport("PACKAGE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PACKAGE_NAME = "packageName";
						/// <summary>
						///  <para>The type of directory captured as a resource ID in the context of the package PACKAGE_NAME, e.g. "Corporate Directory"</para> <para>TYPE: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// TYPE_RESOURCE_ID
						/// </java-name>
						[Dot42.DexImport("TYPE_RESOURCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TYPE_RESOURCE_ID = "typeResourceId";
						/// <summary>
						///  <para>An optional name that can be used in the UI to represent this directory, e.g. "Acme Corp" </para> <para>TYPE: text</para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "displayName";
						/// <summary>
						///  <para>The authority of the Directory Provider. Contacts Provider will use this authority to forward requests to the directory provider. A directory provider can leave this column empty - Contacts Provider will fill it in. </para> <para>Clients of this API should not send requests directly to this authority. All directory requests must be routed through Contacts Provider. </para> <para>TYPE: text</para>        
						/// </summary>
						/// <java-name>
						/// DIRECTORY_AUTHORITY
						/// </java-name>
						[Dot42.DexImport("DIRECTORY_AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIRECTORY_AUTHORITY = "authority";
						/// <summary>
						///  <para>The account type which this directory is associated.</para> <para>TYPE: text</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "accountType";
						/// <summary>
						///  <para>The account with which this directory is associated. If the account is later removed, the directories it owns are automatically removed from this table.</para> <para>TYPE: text</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "accountName";
						/// <summary>
						///  <para>One of EXPORT_SUPPORT_NONE, EXPORT_SUPPORT_ANY_ACCOUNT, EXPORT_SUPPORT_SAME_ACCOUNT_ONLY. This is the expectation the directory has for data exported from it. Clients must obey this setting. </para>        
						/// </summary>
						/// <java-name>
						/// EXPORT_SUPPORT
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXPORT_SUPPORT = "exportSupport";
						/// <summary>
						///  <para>An EXPORT_SUPPORT setting that indicates that the directory does not allow any data to be copied out of it. </para>        
						/// </summary>
						/// <java-name>
						/// EXPORT_SUPPORT_NONE
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT_NONE", "I", AccessFlags = 25)]
						public const int EXPORT_SUPPORT_NONE = 0;
						/// <summary>
						///  <para>An EXPORT_SUPPORT setting that indicates that the directory allow its data copied only to the account specified by ACCOUNT_TYPE/ACCOUNT_NAME. </para>        
						/// </summary>
						/// <java-name>
						/// EXPORT_SUPPORT_SAME_ACCOUNT_ONLY
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT_SAME_ACCOUNT_ONLY", "I", AccessFlags = 25)]
						public const int EXPORT_SUPPORT_SAME_ACCOUNT_ONLY = 1;
						/// <summary>
						///  <para>An EXPORT_SUPPORT setting that indicates that the directory allow its data copied to any contacts account. </para>        
						/// </summary>
						/// <java-name>
						/// EXPORT_SUPPORT_ANY_ACCOUNT
						/// </java-name>
						[Dot42.DexImport("EXPORT_SUPPORT_ANY_ACCOUNT", "I", AccessFlags = 25)]
						public const int EXPORT_SUPPORT_ANY_ACCOUNT = 2;
						/// <summary>
						///  <para>One of SHORTCUT_SUPPORT_NONE, SHORTCUT_SUPPORT_DATA_ITEMS_ONLY, SHORTCUT_SUPPORT_FULL. This is the expectation the directory has for shortcuts created for its elements. Clients must obey this setting. </para>        
						/// </summary>
						/// <java-name>
						/// SHORTCUT_SUPPORT
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHORTCUT_SUPPORT = "shortcutSupport";
						/// <summary>
						///  <para>An SHORTCUT_SUPPORT setting that indicates that the directory does not allow any shortcuts created for its contacts. </para>        
						/// </summary>
						/// <java-name>
						/// SHORTCUT_SUPPORT_NONE
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT_NONE", "I", AccessFlags = 25)]
						public const int SHORTCUT_SUPPORT_NONE = 0;
						/// <summary>
						///  <para>An SHORTCUT_SUPPORT setting that indicates that the directory allow creation of shortcuts for data items like email, phone or postal address, but not the entire contact. </para>        
						/// </summary>
						/// <java-name>
						/// SHORTCUT_SUPPORT_DATA_ITEMS_ONLY
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT_DATA_ITEMS_ONLY", "I", AccessFlags = 25)]
						public const int SHORTCUT_SUPPORT_DATA_ITEMS_ONLY = 1;
						/// <summary>
						///  <para>An SHORTCUT_SUPPORT setting that indicates that the directory allow creation of shortcuts for contact as well as their constituent elements. </para>        
						/// </summary>
						/// <java-name>
						/// SHORTCUT_SUPPORT_FULL
						/// </java-name>
						[Dot42.DexImport("SHORTCUT_SUPPORT_FULL", "I", AccessFlags = 25)]
						public const int SHORTCUT_SUPPORT_FULL = 2;
						/// <summary>
						///  <para>One of PHOTO_SUPPORT_NONE, PHOTO_SUPPORT_THUMBNAIL_ONLY, PHOTO_SUPPORT_FULL. This is a feature flag indicating the extent to which the directory supports contact photos. </para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_SUPPORT
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHOTO_SUPPORT = "photoSupport";
						/// <summary>
						///  <para>An PHOTO_SUPPORT setting that indicates that the directory does not provide any photos. </para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_SUPPORT_NONE
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_NONE", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_NONE = 0;
						/// <summary>
						///  <para>An PHOTO_SUPPORT setting that indicates that the directory can only produce small size thumbnails of contact photos. </para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_SUPPORT_THUMBNAIL_ONLY
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_THUMBNAIL_ONLY", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_THUMBNAIL_ONLY = 1;
						/// <summary>
						///  <para>An PHOTO_SUPPORT setting that indicates that the directory has full-size contact photos, but cannot provide scaled thumbnails. </para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_SUPPORT_FULL_SIZE_ONLY
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_FULL_SIZE_ONLY", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_FULL_SIZE_ONLY = 2;
						/// <summary>
						///  <para>An PHOTO_SUPPORT setting that indicates that the directory can produce thumbnails as well as full-size contact photos. </para>        
						/// </summary>
						/// <java-name>
						/// PHOTO_SUPPORT_FULL
						/// </java-name>
						[Dot42.DexImport("PHOTO_SUPPORT_FULL", "I", AccessFlags = 25)]
						public const int PHOTO_SUPPORT_FULL = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Directory() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notifies the system of a change in the list of directories handled by a particular directory provider. The Contacts provider will turn around and send a query to the directory provider for the full list of directories, which will replace the previous list. </para>        
						/// </summary>
						/// <java-name>
						/// notifyDirectoryChange
						/// </java-name>
						[Dot42.DexImport("notifyDirectoryChange", "(Landroid/content/ContentResolver;)V", AccessFlags = 9)]
						public static void NotifyDirectoryChange(global::Android.Content.ContentResolver resolver) /* MethodBuilder.Create */ 
						{
						}

				}

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
		/// android/provider/BaseColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/BaseColumns", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IBaseColumnsConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The unique ID for a row. </para> <para>Type: INTEGER (long)</para>        
				/// </summary>
				/// <java-name>
				/// _ID
				/// </java-name>
				[Dot42.DexImport("_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string _ID = "_id";
				/// <summary>
				///  <para>The count of rows in a directory. </para> <para>Type: INTEGER</para>        
				/// </summary>
				/// <java-name>
				/// _COUNT
				/// </java-name>
				[Dot42.DexImport("_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string _COUNT = "_count";
		}

		/// <summary>
		///  <para>These are standard columns for openable URIs. Providers that serve openable URIs  <b>must</b> support at least these columns when queried. </para> <para>To find the content type of a URI, use ContentResolver#getType(android.net.Uri).</para> <para> <para>Intent::CATEGORY_OPENABLE </para></para>    
		/// </summary>
		/// <java-name>
		/// android/provider/OpenableColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/OpenableColumns", AccessFlags = 1537)]
		public partial interface IOpenableColumns
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>These are standard columns for openable URIs. Providers that serve openable URIs  <b>must</b> support at least these columns when queried. </para> <para>To find the content type of a URI, use ContentResolver#getType(android.net.Uri).</para> <para> <para>Intent::CATEGORY_OPENABLE </para></para>    
		/// </summary>
		/// <java-name>
		/// android/provider/OpenableColumns
		/// </java-name>
		[Dot42.DexImport("android/provider/OpenableColumns", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IOpenableColumnsConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The human-friendly name of file. If this is not provided then the name should default to the the last segment of the file's URI. </para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_NAME
				/// </java-name>
				[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DISPLAY_NAME = "_display_name";
				/// <summary>
				///  <para>The number of bytes in the file identified by the openable URI. Null if unknown. </para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SIZE = "_size";
		}

		/// <summary>
		///  <para>A LiveFolder is a special folder whose content is provided by a android.content.ContentProvider. To create a live folder, two components are required:</para> <para> <ul> <li> <para>An activity that can respond to the intent action ACTION_CREATE_LIVE_FOLDER. The activity is responsible for creating the live folder. </para></li> <li> <para>A android.content.ContentProvider to provide the live folder items. </para></li></ul></para> <para> <h3>Lifecycle</h3></para> <para>When a user wants to create a live folder, the system looks for all activities with the intent filter action ACTION_CREATE_LIVE_FOLDER and presents the list to the user. When the user chooses one of the activities, the activity is invoked with the ACTION_CREATE_LIVE_FOLDER action. The activity then creates the live folder and passes it back to the system by setting it as an activity result. The live folder is described by a content provider URI, a name, an icon and a display mode. Finally, when the user opens the live folder, the system queries the content provider to retrieve the folder's content.</para> <para> <h3>Setting up the live folder activity</h3></para> <para>The following code sample shows how to write an activity that creates a live folder:</para> <para> <pre>
		/// public static class MyLiveFolder extends Activity {
		///     public static final Uri CONTENT_URI = Uri.parse("content://my.app/live");</pre></para> <para> <pre>    protected void onCreate(Bundle savedInstanceState) {
		///         super.onCreate(savedInstanceState);</pre></para> <para> <pre>        final Intent intent = getIntent();
		///         final String action = intent.getAction();</pre></para> <para> <pre>        if (LiveFolders.ACTION_CREATE_LIVE_FOLDER.equals(action)) {
		///             setResult(RESULT_OK, createLiveFolder(this, CONTENT_URI, "My LiveFolder",
		///                     R.drawable.ic_launcher_contacts_phones));
		///         } else {
		///             setResult(RESULT_CANCELED);
		///         }</pre></para> <para> <pre>        finish();
		///     }</pre></para> <para> <pre>    private static Intent createLiveFolder(Context context, Uri uri, String name,
		///             int icon) {</pre></para> <para> <pre>        final Intent intent = new Intent();</pre></para> <para> <pre>        intent.setData(uri);
		///         intent.putExtra(LiveFolders.EXTRA_LIVE_FOLDER_NAME, name);
		///         intent.putExtra(LiveFolders.EXTRA_LIVE_FOLDER_ICON,
		///                 Intent.ShortcutIconResource.fromContext(context, icon));
		///         intent.putExtra(LiveFolders.EXTRA_LIVE_FOLDER_DISPLAY_MODE, LiveFolders.DISPLAY_MODE_LIST);</pre></para> <para> <pre>        return intent;
		///     }
		/// }
		/// </pre> </para> <para>The live folder is described by an android.content.Intent as follows:</para> <para> <table></table></para> <para>Component </para> <para>Type </para> <para>Description </para> <para>Required &lt;/thead&gt;</para> <para>&lt;tbody&gt; </para> <para>URI </para> <para>URI </para> <para>The ContentProvider URI </para> <para>Yes  </para> <para>EXTRA_LIVE_FOLDER_NAME </para> <para>Extra String </para> <para>The name of the live folder </para> <para>Yes  </para> <para>EXTRA_LIVE_FOLDER_ICON </para> <para>Extra android.content.Intent.ShortcutIconResource </para> <para>The icon of the live folder </para> <para>Yes  </para> <para>EXTRA_LIVE_FOLDER_DISPLAY_MODE </para> <para>Extra int </para> <para>The display mode of the live folder. The value must be either DISPLAY_MODE_GRID or DISPLAY_MODE_LIST. </para> <para>Yes  </para> <para>EXTRA_LIVE_FOLDER_BASE_INTENT </para> <para>Extra Intent </para> <para>When the user clicks an item inside a live folder, the system will either fire the intent associated with that item or, if present, the live folder's base intent with the id of the item appended to the base intent's URI. </para> <para>No  &lt;/tbody&gt; </para> <para> <h3>Setting up the content provider</h3></para> <para>The live folder's content provider must, upon query, return a android.database.Cursor whose columns match the following names:</para> <para> <table></table></para> <para>Column </para> <para>Type </para> <para>Description </para> <para>Required &lt;/thead&gt;</para> <para>&lt;tbody&gt; </para> <para>NAME </para> <para>String </para> <para>The name of the item </para> <para>Yes  </para> <para>DESCRIPTION </para> <para>String </para> <para>The description of the item. The description is ignored when the live folder's display mode is DISPLAY_MODE_GRID. </para> <para>No  </para> <para>INTENT </para> <para>android.content.Intent </para> <para>The intent to fire when the item is clicked. Ignored when the live folder defines a base intent. </para> <para>No  </para> <para>ICON_BITMAP </para> <para>Bitmap </para> <para>The icon for the item. When this column value is not null, the values for the columns ICON_PACKAGE and ICON_RESOURCE must be null. </para> <para>No  </para> <para>ICON_PACKAGE </para> <para>String </para> <para>The package of the item's icon. When this value is not null, the value for the column ICON_RESOURCE must be specified and the value for the column ICON_BITMAP must be null. </para> <para>No  </para> <para>ICON_RESOURCE </para> <para>String </para> <para>The resource name of the item's icon. When this value is not null, the value for the column ICON_PACKAGE must be specified and the value for the column ICON_BITMAP must be null. </para> <para>No  &lt;/tbody&gt; </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Live folders are no longer supported by Android. These have been replaced by the new  APIs introduced in android.os.Build.VERSION_CODES#HONEYCOMB. These provide all of the features of live folders plus many more. The use of live folders is greatly discouraged because of security issues they introduce  publishing a live folder requires making all data show for the live folder available to all applications with no permissions protecting it. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/provider/LiveFolders
		/// </java-name>
		[Dot42.DexImport("android/provider/LiveFolders", AccessFlags = 49)]
		public sealed partial class LiveFolders : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Content provider column.</para> <para>Name of the live folder item.</para> <para>Required.</para> <para>Type: String.</para>        
				/// </summary>
				/// <java-name>
				/// NAME
				/// </java-name>
				[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NAME = "name";
				/// <summary>
				///  <para>Content provider column.</para> <para>Description of the live folder item. This value is ignored if the live folder's display mode is LiveFolders#DISPLAY_MODE_GRID.</para> <para>Optional.</para> <para>Type: String.</para> <para> <para>LiveFolders::EXTRA_LIVE_FOLDER_DISPLAY_MODE </para></para>        
				/// </summary>
				/// <java-name>
				/// DESCRIPTION
				/// </java-name>
				[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DESCRIPTION = "description";
				/// <summary>
				///  <para>Content provider column.</para> <para>Intent of the live folder item.</para> <para>Optional if the live folder has a base intent.</para> <para>Type: android.content.Intent.</para> <para> <para>LiveFolders::EXTRA_LIVE_FOLDER_BASE_INTENT </para></para>        
				/// </summary>
				/// <java-name>
				/// INTENT
				/// </java-name>
				[Dot42.DexImport("INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT = "intent";
				/// <summary>
				///  <para>Content provider column.</para> <para>Icon of the live folder item, as a custom bitmap.</para> <para>Optional.</para> <para>Type: android.graphics.Bitmap.</para>        
				/// </summary>
				/// <java-name>
				/// ICON_BITMAP
				/// </java-name>
				[Dot42.DexImport("ICON_BITMAP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ICON_BITMAP = "icon_bitmap";
				/// <summary>
				///  <para>Content provider column.</para> <para>Package where to find the icon of the live folder item. This value can be obtained easily using android.content.Intent.ShortcutIconResource#fromContext(android.content.Context, int).</para> <para>Optional.</para> <para>Type: String.</para> <para> <para>ICON_RESOURCE </para> <para>android.content.Intent.ShortcutIconResource </para></para>        
				/// </summary>
				/// <java-name>
				/// ICON_PACKAGE
				/// </java-name>
				[Dot42.DexImport("ICON_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ICON_PACKAGE = "icon_package";
				/// <summary>
				///  <para>Content provider column.</para> <para>Resource name of the live folder item. This value can be obtained easily using android.content.Intent.ShortcutIconResource#fromContext(android.content.Context, int).</para> <para>Optional.</para> <para>Type: String.</para> <para> <para>ICON_PACKAGE </para> <para>android.content.Intent.ShortcutIconResource </para></para>        
				/// </summary>
				/// <java-name>
				/// ICON_RESOURCE
				/// </java-name>
				[Dot42.DexImport("ICON_RESOURCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ICON_RESOURCE = "icon_resource";
				/// <summary>
				///  <para>Displays a live folder's content in a grid.</para> <para> <para>LiveFolders::EXTRA_LIVE_FOLDER_DISPLAY_MODE </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_MODE_GRID
				/// </java-name>
				[Dot42.DexImport("DISPLAY_MODE_GRID", "I", AccessFlags = 25)]
				public const int DISPLAY_MODE_GRID = 1;
				/// <summary>
				///  <para>Displays a live folder's content in a list.</para> <para> <para>LiveFolders::EXTRA_LIVE_FOLDER_DISPLAY_MODE </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_MODE_LIST
				/// </java-name>
				[Dot42.DexImport("DISPLAY_MODE_LIST", "I", AccessFlags = 25)]
				public const int DISPLAY_MODE_LIST = 2;
				/// <summary>
				///  <para>The name of the extra used to define the name of a live folder.</para> <para> <para>ACTION_CREATE_LIVE_FOLDER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_NAME = "android.intent.extra.livefolder.NAME";
				/// <summary>
				///  <para>The name of the extra used to define the icon of a live folder.</para> <para> <para>ACTION_CREATE_LIVE_FOLDER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_ICON
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_ICON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_ICON = "android.intent.extra.livefolder.ICON";
				/// <summary>
				///  <para>The name of the extra used to define the display mode of a live folder.</para> <para> <para>ACTION_CREATE_LIVE_FOLDER </para> <para>DISPLAY_MODE_GRID </para> <para>DISPLAY_MODE_LIST </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_DISPLAY_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_DISPLAY_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_DISPLAY_MODE = "android.intent.extra.livefolder.DISPLAY_MODE";
				/// <summary>
				///  <para>The name of the extra used to define the base Intent of a live folder.</para> <para> <para>ACTION_CREATE_LIVE_FOLDER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LIVE_FOLDER_BASE_INTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_FOLDER_BASE_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_FOLDER_BASE_INTENT = "android.intent.extra.livefolder.BASE_INTENT";
				/// <summary>
				///  <para>Activity Action: Creates a live folder. </para> <para>Input: Nothing.</para> <para>Output: An Intent representing the live folder. The intent must contain four extras: EXTRA_LIVE_FOLDER_NAME (value: String), EXTRA_LIVE_FOLDER_ICON (value: ShortcutIconResource), EXTRA_LIVE_FOLDER_URI (value: String) and EXTRA_LIVE_FOLDER_DISPLAY_MODE (value: int). The Intent can optionnally contain EXTRA_LIVE_FOLDER_BASE_INTENT (value: Intent).</para> <para> <para>EXTRA_LIVE_FOLDER_NAME </para> <para>EXTRA_LIVE_FOLDER_ICON </para> <para>EXTRA_LIVE_FOLDER_DISPLAY_MODE </para> <para>EXTRA_LIVE_FOLDER_BASE_INTENT </para> <para>android.content.Intent.ShortcutIconResource </para></para>        
				/// </summary>
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

		/// <summary>
		///  <para>The Media provider contains meta data for all available media on both internal and external storage devices. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Activity Action: Launch a music player. The activity should be able to play, browse, or manipulate music files stored on the device.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.content.Intent#CATEGORY_APP_MUSIC instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_MUSIC_PLAYER
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_MUSIC_PLAYER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_MUSIC_PLAYER = "android.intent.action.MUSIC_PLAYER";
				/// <summary>
				///  <para>Activity Action: Perform a search for media. Contains at least the android.app.SearchManager#QUERY extra. May also contain any combination of the following extras: EXTRA_MEDIA_ARTIST, EXTRA_MEDIA_ALBUM, EXTRA_MEDIA_TITLE, EXTRA_MEDIA_FOCUS</para> <para> <para>android.provider.MediaStore::EXTRA_MEDIA_ARTIST </para> <para>android.provider.MediaStore::EXTRA_MEDIA_ALBUM </para> <para>android.provider.MediaStore::EXTRA_MEDIA_TITLE </para> <para>android.provider.MediaStore::EXTRA_MEDIA_FOCUS </para></para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_MEDIA_SEARCH
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_MEDIA_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_MEDIA_SEARCH = "android.intent.action.MEDIA_SEARCH";
				/// <summary>
				///  <para>An intent to perform a search for music media and automatically play content from the result when possible. This can be fired, for example, by the result of a voice recognition command to listen to music. </para> <para>Contains the android.app.SearchManager#QUERY extra, which is a string that can contain any type of unstructured music search, like the name of an artist, an album, a song, a genre, or any combination of these. </para> <para>Because this intent includes an open-ended unstructured search string, it makes the most sense for apps that can support large-scale search of music, such as services connected to an online database of music which can be streamed and played on the device. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_MEDIA_PLAY_FROM_SEARCH
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_MEDIA_PLAY_FROM_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_MEDIA_PLAY_FROM_SEARCH = "android.media.action.MEDIA_PLAY_FROM_SEARCH";
				/// <summary>
				///  <para>The name of the Intent-extra used to define the artist </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MEDIA_ARTIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_ARTIST = "android.intent.extra.artist";
				/// <summary>
				///  <para>The name of the Intent-extra used to define the album </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MEDIA_ALBUM
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_ALBUM = "android.intent.extra.album";
				/// <summary>
				///  <para>The name of the Intent-extra used to define the song title </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MEDIA_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_TITLE = "android.intent.extra.title";
				/// <summary>
				///  <para>The name of the Intent-extra used to define the search focus. The search focus indicates whether the search should be for things related to the artist, album or song that is identified by the other extras. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MEDIA_FOCUS
				/// </java-name>
				[Dot42.DexImport("EXTRA_MEDIA_FOCUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MEDIA_FOCUS = "android.intent.extra.focus";
				/// <summary>
				///  <para>The name of the Intent-extra used to control the orientation of a ViewImage or a MovieView. This is an int property that overrides the activity's requestedOrientation.  <para>android.content.pm.ActivityInfo.SCREEN_ORIENTATION_UNSPECIFIED </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SCREEN_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCREEN_ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCREEN_ORIENTATION = "android.intent.extra.screenOrientation";
				/// <summary>
				///  <para>The name of an Intent-extra used to control the UI of a ViewImage. This is a boolean property that overrides the activity's default fullscreen state. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_FULL_SCREEN
				/// </java-name>
				[Dot42.DexImport("EXTRA_FULL_SCREEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_FULL_SCREEN = "android.intent.extra.fullScreen";
				/// <summary>
				///  <para>The name of an Intent-extra used to control the UI of a ViewImage. This is a boolean property that specifies whether or not to show action icons. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHOW_ACTION_ICONS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_ACTION_ICONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_ACTION_ICONS = "android.intent.extra.showActionIcons";
				/// <summary>
				///  <para>The name of the Intent-extra used to control the onCompletion behavior of a MovieView. This is a boolean property that specifies whether or not to finish the MovieView activity when the movie completes playing. The default value is true, which means to automatically exit the movie player activity when the movie completes playing. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_FINISH_ON_COMPLETION
				/// </java-name>
				[Dot42.DexImport("EXTRA_FINISH_ON_COMPLETION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_FINISH_ON_COMPLETION = "android.intent.extra.finishOnCompletion";
				/// <summary>
				///  <para>The name of the Intent action used to launch a camera in still image mode. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_STILL_IMAGE_CAMERA
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_STILL_IMAGE_CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_STILL_IMAGE_CAMERA = "android.media.action.STILL_IMAGE_CAMERA";
				/// <summary>
				///  <para>The name of the Intent action used to launch a camera in video mode. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_VIDEO_CAMERA
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_VIDEO_CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_VIDEO_CAMERA = "android.media.action.VIDEO_CAMERA";
				/// <summary>
				///  <para>Standard Intent action that can be sent to have the camera application capture an image and return it. </para> <para>The caller may pass an extra EXTRA_OUTPUT to control where this image will be written. If the EXTRA_OUTPUT is not present, then a small sized image is returned as a Bitmap object in the extra field. This is useful for applications that only need a small image. If the EXTRA_OUTPUT is present, then the full-sized image will be written to the Uri value of EXTRA_OUTPUT.  <para>EXTRA_OUTPUT </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_IMAGE_CAPTURE
				/// </java-name>
				[Dot42.DexImport("ACTION_IMAGE_CAPTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_IMAGE_CAPTURE = "android.media.action.IMAGE_CAPTURE";
				/// <summary>
				///  <para>Standard Intent action that can be sent to have the camera application capture a video and return it. </para> <para>The caller may pass in an extra EXTRA_VIDEO_QUALITY to control the video quality. </para> <para>The caller may pass in an extra EXTRA_OUTPUT to control where the video is written. If EXTRA_OUTPUT is not present the video will be written to the standard location for videos, and the Uri of that location will be returned in the data field of the Uri.  <para>EXTRA_OUTPUT </para> <para>EXTRA_VIDEO_QUALITY </para> <para>EXTRA_SIZE_LIMIT </para> <para>EXTRA_DURATION_LIMIT </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_VIDEO_CAPTURE
				/// </java-name>
				[Dot42.DexImport("ACTION_VIDEO_CAPTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VIDEO_CAPTURE = "android.media.action.VIDEO_CAPTURE";
				/// <summary>
				///  <para>The name of the Intent-extra used to control the quality of a recorded video. This is an integer property. Currently value 0 means low quality, suitable for MMS messages, and value 1 means high quality. In the future other quality levels may be added. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VIDEO_QUALITY
				/// </java-name>
				[Dot42.DexImport("EXTRA_VIDEO_QUALITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VIDEO_QUALITY = "android.intent.extra.videoQuality";
				/// <summary>
				///  <para>Specify the maximum allowed size. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SIZE_LIMIT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SIZE_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SIZE_LIMIT = "android.intent.extra.sizeLimit";
				/// <summary>
				///  <para>Specify the maximum allowed recording duration in seconds. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DURATION_LIMIT
				/// </java-name>
				[Dot42.DexImport("EXTRA_DURATION_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DURATION_LIMIT = "android.intent.extra.durationLimit";
				/// <summary>
				///  <para>The name of the Intent-extra used to indicate a content resolver Uri to be used to store the requested image or video. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_OUTPUT
				/// </java-name>
				[Dot42.DexImport("EXTRA_OUTPUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_OUTPUT = "output";
				/// <summary>
				///  <para>The string that is used when a media attribute is not known. For example, if an audio file does not have any meta data, the artist and album columns will be set to this value. </para>        
				/// </summary>
				/// <java-name>
				/// UNKNOWN_STRING
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_STRING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNKNOWN_STRING = "<unknown>";
				/// <summary>
				///  <para>Name of current volume being scanned by the media scanner. </para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_SCANNER_VOLUME
				/// </java-name>
				[Dot42.DexImport("MEDIA_SCANNER_VOLUME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_SCANNER_VOLUME = "volume";
				/// <summary>
				///  <para>Name of the file signaling the media scanner to ignore media in the containing directory and its subdirectories. Developers should use this to avoid application graphics showing up in the Gallery and likewise prevent application sounds and music from showing up in the Music app. </para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_IGNORE_FILENAME
				/// </java-name>
				[Dot42.DexImport("MEDIA_IGNORE_FILENAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_IGNORE_FILENAME = ".nomedia";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaStore() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the media provider's version. Applications that import data from the media provider into their own caches can use this to detect that the media provider changed, and reimport data as needed. No other assumptions should be made about the meaning of the version. </para>        
				/// </summary>
				/// <returns>
				///  <para>A version string, or null if the version could not be determined. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetVersion(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Uri for querying the state of the media scanner. </para>        
				/// </summary>
				/// <java-name>
				/// getMediaScannerUri
				/// </java-name>
				public static global::Android.Net.Uri MediaScannerUri
				{
						[Dot42.DexImport("getMediaScannerUri", "()Landroid/net/Uri;", AccessFlags = 9)]
						get{ return default(global::Android.Net.Uri); }
				}

				/// <java-name>
				/// android/provider/MediaStore$Video
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$Video", AccessFlags = 25)]
				public sealed partial class Video
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The default sort order for this table. </para>        
						/// </summary>
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
						public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri, string[] projection) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Database.ICursor);
						}

						/// <summary>
						///  <para>This class allows developers to query and get two kinds of thumbnails: MINI_KIND: 512 x 384 thumbnail MICRO_KIND: 96 x 96 thumbnail </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Video$Thumbnails
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Video$Thumbnails", AccessFlags = 9)]
						public partial class Thumbnails : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "video_id ASC";
								/// <summary>
								///  <para>The data stream for the thumbnail </para> <para>Type: DATA STREAM</para>        
								/// </summary>
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "_data";
								/// <summary>
								///  <para>The original image for the thumbnal </para> <para>Type: INTEGER (ID from Video table)</para>        
								/// </summary>
								/// <java-name>
								/// VIDEO_ID
								/// </java-name>
								[Dot42.DexImport("VIDEO_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string VIDEO_ID = "video_id";
								/// <summary>
								///  <para>The kind of the thumbnail </para> <para>Type: INTEGER (One of the values below)</para>        
								/// </summary>
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
								/// <summary>
								///  <para>The width of the thumbnal </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// WIDTH
								/// </java-name>
								[Dot42.DexImport("WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
								public const string WIDTH = "width";
								/// <summary>
								///  <para>The height of the thumbnail </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// HEIGHT
								/// </java-name>
								[Dot42.DexImport("HEIGHT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string HEIGHT = "height";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Thumbnails() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>This method cancels the thumbnail request so clients waiting for getThumbnail will be interrupted and return immediately. Only the original process which made the getThumbnail requests can cancel their own requests.</para> <para></para>        
								/// </summary>
								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver cr, long origId) /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>This method checks if the thumbnails of the specified image (origId) has been created. It will be blocked until the thumbnails are generated.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>A Bitmap instance. It could be null if the original image associated with origId doesn't exist or memory is not enough. </para>
								/// </returns>
								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Land" +
    "roid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver cr, long origId, int kind, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <summary>
								///  <para>This method checks if the thumbnails of the specified image (origId) has been created. It will be blocked until the thumbnails are generated.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>A Bitmap instance. It could be null if the original image associated with origId doesn't exist or memory is not enough. </para>
								/// </returns>
								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Lan" +
    "droid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver cr, long origId, long groupId, int kind, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <summary>
								///  <para>This method cancels the thumbnail request so clients waiting for getThumbnail will be interrupted and return immediately. Only the original process which made the getThumbnail requests can cancel their own requests.</para> <para></para>        
								/// </summary>
								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver cr, long origId, long groupId) /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the image media table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the image media table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
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
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type for this table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/video";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "title";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Media() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the video media table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the video media table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
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
								/// <summary>
								///  <para>The duration of the video file, in ms </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// DURATION
								/// </java-name>
								[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DURATION = "duration";
								/// <summary>
								///  <para>The artist who created the video file, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <summary>
								///  <para>The album the video file is from, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM
								/// </java-name>
								[Dot42.DexImport("ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM = "album";
								/// <summary>
								///  <para>The resolution of the video file, formatted as "XxY" </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// RESOLUTION
								/// </java-name>
								[Dot42.DexImport("RESOLUTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string RESOLUTION = "resolution";
								/// <summary>
								///  <para>The description of the video recording </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// DESCRIPTION
								/// </java-name>
								[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DESCRIPTION = "description";
								/// <summary>
								///  <para>Whether the video should be published as public or private </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// IS_PRIVATE
								/// </java-name>
								[Dot42.DexImport("IS_PRIVATE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_PRIVATE = "isprivate";
								/// <summary>
								///  <para>The user-added tags associated with a video </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// TAGS
								/// </java-name>
								[Dot42.DexImport("TAGS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TAGS = "tags";
								/// <summary>
								///  <para>The YouTube category of the video </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// CATEGORY
								/// </java-name>
								[Dot42.DexImport("CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CATEGORY = "category";
								/// <summary>
								///  <para>The language of the video </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// LANGUAGE
								/// </java-name>
								[Dot42.DexImport("LANGUAGE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LANGUAGE = "language";
								/// <summary>
								///  <para>The latitude where the video was captured. </para> <para>Type: DOUBLE</para>        
								/// </summary>
								/// <java-name>
								/// LATITUDE
								/// </java-name>
								[Dot42.DexImport("LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LATITUDE = "latitude";
								/// <summary>
								///  <para>The longitude where the video was captured. </para> <para>Type: DOUBLE</para>        
								/// </summary>
								/// <java-name>
								/// LONGITUDE
								/// </java-name>
								[Dot42.DexImport("LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LONGITUDE = "longitude";
								/// <summary>
								///  <para>The date &amp; time that the video was taken in units of milliseconds since jan 1, 1970. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// DATE_TAKEN
								/// </java-name>
								[Dot42.DexImport("DATE_TAKEN", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_TAKEN = "datetaken";
								/// <summary>
								///  <para>The mini thumb id. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// MINI_THUMB_MAGIC
								/// </java-name>
								[Dot42.DexImport("MINI_THUMB_MAGIC", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MINI_THUMB_MAGIC = "mini_thumb_magic";
								/// <summary>
								///  <para>The bucket id of the video. This is a read-only property that is automatically computed from the DATA column. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// BUCKET_ID
								/// </java-name>
								[Dot42.DexImport("BUCKET_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_ID = "bucket_id";
								/// <summary>
								///  <para>The bucket display name of the video. This is a read-only property that is automatically computed from the DATA column. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// BUCKET_DISPLAY_NAME
								/// </java-name>
								[Dot42.DexImport("BUCKET_DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_DISPLAY_NAME = "bucket_display_name";
								/// <summary>
								///  <para>The bookmark for the video. Time in ms. Represents the location in the video that the video should start playing at the next time it is opened. If the value is null or out of the range 0..DURATION-1 then the video should start playing from the beginning. </para> <para>Type: INTEGER</para>        
								/// </summary>
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

				/// <summary>
				///  <para>Container for all audio content. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Converts a name to a "key" that can be used for grouping, sorting and searching. The rules that govern this conversion are: <ul> <li> <para>remove 'special' characters like ()[]'!?.,</para></li> <li> <para>remove leading/trailing spaces</para></li> <li> <para>convert everything to lowercase</para></li> <li> <para>remove leading "the ", "an " and "a "</para></li> <li> <para>remove trailing ", the|an|a"</para></li> <li> <para>remove accents. This step leaves us with CollationKey data, which is not human readable</para></li></ul></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The "key" for the given name. </para>
						/// </returns>
						/// <java-name>
						/// keyFor
						/// </java-name>
						[Dot42.DexImport("keyFor", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
						public static string KeyFor(string name) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Contains artists for audio files </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$Albums
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Albums", AccessFlags = 25)]
						public sealed partial class Albums : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IAlbumColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type for this table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/albums";
								/// <summary>
								///  <para>The MIME type for entries in this table. </para>        
								/// </summary>
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/album";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "album_key";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Albums() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the albums table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the audio albums table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <summary>
						///  <para>Columns representing an album </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$AlbumColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AlbumColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IAlbumColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The id for the album </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM_ID
								/// </java-name>
								[Dot42.DexImport("ALBUM_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_ID = "album_id";
								/// <summary>
								///  <para>The album on which the audio file appears, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM
								/// </java-name>
								[Dot42.DexImport("ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM = "album";
								/// <summary>
								///  <para>The artist whose songs appear on this album </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <summary>
								///  <para>The number of songs on this album </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// NUMBER_OF_SONGS
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_SONGS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_SONGS = "numsongs";
								/// <summary>
								///  <para>This column is available when getting album info via artist, and indicates the number of songs on the album by the given artist. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// NUMBER_OF_SONGS_FOR_ARTIST
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_SONGS_FOR_ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_SONGS_FOR_ARTIST = "numsongs_by_artist";
								/// <summary>
								///  <para>The year in which the earliest songs on this album were released. This will often be the same as LAST_YEAR, but for compilation albums they might differ. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// FIRST_YEAR
								/// </java-name>
								[Dot42.DexImport("FIRST_YEAR", "Ljava/lang/String;", AccessFlags = 25)]
								public const string FIRST_YEAR = "minyear";
								/// <summary>
								///  <para>The year in which the latest songs on this album were released. This will often be the same as FIRST_YEAR, but for compilation albums they might differ. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// LAST_YEAR
								/// </java-name>
								[Dot42.DexImport("LAST_YEAR", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LAST_YEAR = "maxyear";
								/// <summary>
								///  <para>A non human readable key calculated from the ALBUM, used for searching, sorting and grouping </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM_KEY
								/// </java-name>
								[Dot42.DexImport("ALBUM_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_KEY = "album_key";
								/// <summary>
								///  <para>Cached album art. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM_ART
								/// </java-name>
								[Dot42.DexImport("ALBUM_ART", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_ART = "album_art";
						}

						/// <summary>
						///  <para>Columns representing an album </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$AlbumColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AlbumColumns", AccessFlags = 1545)]
						public partial interface IAlbumColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <summary>
						///  <para>Contains artists for audio files </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$Artists
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Artists", AccessFlags = 25)]
						public sealed partial class Artists : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IArtistColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type for this table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/artists";
								/// <summary>
								///  <para>The MIME type for entries in this table. </para>        
								/// </summary>
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/artist";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "artist_key";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Artists() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the artists table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the audio artists table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <summary>
								///  <para>Sub-directory of each artist containing all albums on which a song by the artist appears. </para>    
								/// </summary>
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
										public static global::Android.Net.Uri GetContentUri(string volumeName, long artistId) /* MethodBuilder.Create */ 
										{
												return default(global::Android.Net.Uri);
										}

								}

						}

						/// <summary>
						///  <para>Columns representing an artist </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$ArtistColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$ArtistColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IArtistColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The artist who created the audio file, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <summary>
								///  <para>A non human readable key calculated from the ARTIST, used for searching, sorting and grouping </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST_KEY
								/// </java-name>
								[Dot42.DexImport("ARTIST_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST_KEY = "artist_key";
								/// <summary>
								///  <para>The number of albums in the database for this artist </para>        
								/// </summary>
								/// <java-name>
								/// NUMBER_OF_ALBUMS
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_ALBUMS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_ALBUMS = "number_of_albums";
								/// <summary>
								///  <para>The number of albums in the database for this artist </para>        
								/// </summary>
								/// <java-name>
								/// NUMBER_OF_TRACKS
								/// </java-name>
								[Dot42.DexImport("NUMBER_OF_TRACKS", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NUMBER_OF_TRACKS = "number_of_tracks";
						}

						/// <summary>
						///  <para>Columns representing an artist </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$ArtistColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$ArtistColumns", AccessFlags = 1545)]
						public partial interface IArtistColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <summary>
						///  <para>Contains playlists for audio files </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$Playlists
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Playlists", AccessFlags = 25)]
						public sealed partial class Playlists : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IPlaylistsColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type for this table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/playlist";
								/// <summary>
								///  <para>The MIME type for entries in this table. </para>        
								/// </summary>
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/playlist";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "name";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Playlists() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the audio playlists table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the audio playlists table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <summary>
								///  <para>Sub-directory of each playlist containing all members. </para>    
								/// </summary>
								/// <java-name>
								/// android/provider/MediaStore$Audio$Playlists$Members
								/// </java-name>
								[Dot42.DexImport("android/provider/MediaStore$Audio$Playlists$Members", AccessFlags = 25)]
								public sealed partial class Members : global::Android.Provider.MediaStore.Audio.IAudioColumns
 /* scope: __dot42__ */ 
								{
										/// <summary>
										///  <para>The ID within the playlist. </para>        
										/// </summary>
										/// <java-name>
										/// _ID
										/// </java-name>
										[Dot42.DexImport("_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string _ID = "_id";
										/// <summary>
										///  <para>A subdirectory of each playlist containing all member audio files. </para>        
										/// </summary>
										/// <java-name>
										/// CONTENT_DIRECTORY
										/// </java-name>
										[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
										public const string CONTENT_DIRECTORY = "members";
										/// <summary>
										///  <para>The ID of the audio file </para> <para>Type: INTEGER (long)</para>        
										/// </summary>
										/// <java-name>
										/// AUDIO_ID
										/// </java-name>
										[Dot42.DexImport("AUDIO_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string AUDIO_ID = "audio_id";
										/// <summary>
										///  <para>The ID of the playlist </para> <para>Type: INTEGER (long)</para>        
										/// </summary>
										/// <java-name>
										/// PLAYLIST_ID
										/// </java-name>
										[Dot42.DexImport("PLAYLIST_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string PLAYLIST_ID = "playlist_id";
										/// <summary>
										///  <para>The order of the songs in the playlist </para> <para>Type: INTEGER (long)&gt;</para>        
										/// </summary>
										/// <java-name>
										/// PLAY_ORDER
										/// </java-name>
										[Dot42.DexImport("PLAY_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
										public const string PLAY_ORDER = "play_order";
										/// <summary>
										///  <para>The default sort order for this table </para>        
										/// </summary>
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
										public static global::Android.Net.Uri GetContentUri(string volumeName, long playlistId) /* MethodBuilder.Create */ 
										{
												return default(global::Android.Net.Uri);
										}

										/// <summary>
										///  <para>Convenience method to move a playlist item to a new location </para>        
										/// </summary>
										/// <returns>
										///  <para>true on success </para>
										/// </returns>
										/// <java-name>
										/// moveItem
										/// </java-name>
										[Dot42.DexImport("moveItem", "(Landroid/content/ContentResolver;JII)Z", AccessFlags = 25)]
										public static bool MoveItem(global::Android.Content.ContentResolver res, long playlistId, int from, int to) /* MethodBuilder.Create */ 
										{
												return default(bool);
										}

								}

						}

						/// <summary>
						///  <para>Columns representing a playlist </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$PlaylistsColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$PlaylistsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IPlaylistsColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The name of the playlist </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
								/// <summary>
								///  <para>The data stream for the playlist file </para> <para>Type: DATA STREAM</para>        
								/// </summary>
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "_data";
								/// <summary>
								///  <para>The time the file was added to the media provider Units are seconds since 1970. </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// DATE_ADDED
								/// </java-name>
								[Dot42.DexImport("DATE_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_ADDED = "date_added";
								/// <summary>
								///  <para>The time the file was last modified Units are seconds since 1970. NOTE: This is for internal use by the media scanner. Do not modify this field. </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// DATE_MODIFIED
								/// </java-name>
								[Dot42.DexImport("DATE_MODIFIED", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_MODIFIED = "date_modified";
						}

						/// <summary>
						///  <para>Columns representing a playlist </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$PlaylistsColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$PlaylistsColumns", AccessFlags = 1545)]
						public partial interface IPlaylistsColumns
 /* scope: __dot42__ */ 
						{
						}

						/// <summary>
						///  <para>Contains all genres for audio files </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$Genres
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$Genres", AccessFlags = 25)]
						public sealed partial class Genres : global::Android.Provider.IBaseColumns, global::Android.Provider.MediaStore.Audio.IGenresColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type for this table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/genre";
								/// <summary>
								///  <para>The MIME type for entries in this table. </para>        
								/// </summary>
								/// <java-name>
								/// ENTRY_CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("ENTRY_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ENTRY_CONTENT_TYPE = "vnd.android.cursor.item/genre";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "name";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Genres() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the audio genres table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the audio genres table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <summary>
								///  <para>Get the content:// style URI for querying the genres of an audio file.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to for querying the genres for the audio file with the given the volume and audioID </para>
								/// </returns>
								/// <java-name>
								/// getContentUriForAudioId
								/// </java-name>
								[Dot42.DexImport("getContentUriForAudioId", "(Ljava/lang/String;I)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUriForAudioId(string volumeName, int audioId) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <summary>
								///  <para>Sub-directory of each genre containing all members. </para>    
								/// </summary>
								/// <java-name>
								/// android/provider/MediaStore$Audio$Genres$Members
								/// </java-name>
								[Dot42.DexImport("android/provider/MediaStore$Audio$Genres$Members", AccessFlags = 25)]
								public sealed partial class Members : global::Android.Provider.MediaStore.Audio.IAudioColumns
 /* scope: __dot42__ */ 
								{
										/// <summary>
										///  <para>A subdirectory of each genre containing all member audio files. </para>        
										/// </summary>
										/// <java-name>
										/// CONTENT_DIRECTORY
										/// </java-name>
										[Dot42.DexImport("CONTENT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
										public const string CONTENT_DIRECTORY = "members";
										/// <summary>
										///  <para>The default sort order for this table </para>        
										/// </summary>
										/// <java-name>
										/// DEFAULT_SORT_ORDER
										/// </java-name>
										[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
										public const string DEFAULT_SORT_ORDER = "title_key";
										/// <summary>
										///  <para>The ID of the audio file </para> <para>Type: INTEGER (long)</para>        
										/// </summary>
										/// <java-name>
										/// AUDIO_ID
										/// </java-name>
										[Dot42.DexImport("AUDIO_ID", "Ljava/lang/String;", AccessFlags = 25)]
										public const string AUDIO_ID = "audio_id";
										/// <summary>
										///  <para>The ID of the genre </para> <para>Type: INTEGER (long)</para>        
										/// </summary>
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
										public static global::Android.Net.Uri GetContentUri(string volumeName, long genreId) /* MethodBuilder.Create */ 
										{
												return default(global::Android.Net.Uri);
										}

								}

						}

						/// <summary>
						///  <para>Columns representing an audio genre </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$GenresColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$GenresColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IGenresColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The name of the genre </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// NAME
								/// </java-name>
								[Dot42.DexImport("NAME", "Ljava/lang/String;", AccessFlags = 25)]
								public const string NAME = "name";
						}

						/// <summary>
						///  <para>Columns representing an audio genre </para>    
						/// </summary>
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
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type for this table. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/audio";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "title_key";
								/// <summary>
								///  <para>Activity Action: Start SoundRecorder application. </para> <para>Input: nothing. </para> <para>Output: An uri to the recorded sound stored in the Media Library if the recording was successful. May also contain the extra EXTRA_MAX_BYTES.  <para>EXTRA_MAX_BYTES </para></para>        
								/// </summary>
								/// <java-name>
								/// RECORD_SOUND_ACTION
								/// </java-name>
								[Dot42.DexImport("RECORD_SOUND_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string RECORD_SOUND_ACTION = "android.provider.MediaStore.RECORD_SOUND";
								/// <summary>
								///  <para>The name of the Intent-extra used to define a maximum file size for a recording made by the SoundRecorder application.</para> <para> <para>RECORD_SOUND_ACTION </para></para>        
								/// </summary>
								/// <java-name>
								/// EXTRA_MAX_BYTES
								/// </java-name>
								[Dot42.DexImport("EXTRA_MAX_BYTES", "Ljava/lang/String;", AccessFlags = 25)]
								public const string EXTRA_MAX_BYTES = "android.provider.MediaStore.extra.MAX_BYTES";
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Media() /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Get the content:// style URI for the audio media table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the audio media table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

								/// <java-name>
								/// getContentUriForPath
								/// </java-name>
								[Dot42.DexImport("getContentUriForPath", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUriForPath(string path) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Net.Uri);
								}

						}

						/// <summary>
						///  <para>Columns for audio file that show up in multiple tables. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$AudioColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AudioColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IAudioColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>A non human readable key calculated from the TITLE, used for searching, sorting and grouping </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// TITLE_KEY
								/// </java-name>
								[Dot42.DexImport("TITLE_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE_KEY = "title_key";
								/// <summary>
								///  <para>The duration of the audio file, in ms </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// DURATION
								/// </java-name>
								[Dot42.DexImport("DURATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DURATION = "duration";
								/// <summary>
								///  <para>The position, in ms, playback was at when playback for this file was last stopped. </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// BOOKMARK
								/// </java-name>
								[Dot42.DexImport("BOOKMARK", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BOOKMARK = "bookmark";
								/// <summary>
								///  <para>The id of the artist who created the audio file, if any </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST_ID
								/// </java-name>
								[Dot42.DexImport("ARTIST_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST_ID = "artist_id";
								/// <summary>
								///  <para>The artist who created the audio file, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST
								/// </java-name>
								[Dot42.DexImport("ARTIST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST = "artist";
								/// <summary>
								///  <para>A non human readable key calculated from the ARTIST, used for searching, sorting and grouping </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ARTIST_KEY
								/// </java-name>
								[Dot42.DexImport("ARTIST_KEY", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ARTIST_KEY = "artist_key";
								/// <summary>
								///  <para>The composer of the audio file, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// COMPOSER
								/// </java-name>
								[Dot42.DexImport("COMPOSER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string COMPOSER = "composer";
								/// <summary>
								///  <para>The id of the album the audio file is from, if any </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM_ID
								/// </java-name>
								[Dot42.DexImport("ALBUM_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM_ID = "album_id";
								/// <summary>
								///  <para>The album the audio file is from, if any </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// ALBUM
								/// </java-name>
								[Dot42.DexImport("ALBUM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ALBUM = "album";
								/// <summary>
								///  <para>A non human readable key calculated from the ALBUM, used for searching, sorting and grouping </para> <para>Type: TEXT</para>        
								/// </summary>
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
								/// <summary>
								///  <para>The track number of this song on the album, if any. This number encodes both the track number and the disc number. For multi-disc sets, this number will be 1xxx for tracks on the first disc, 2xxx for tracks on the second disc, etc. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// TRACK
								/// </java-name>
								[Dot42.DexImport("TRACK", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TRACK = "track";
								/// <summary>
								///  <para>The year the audio file was recorded, if any </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// YEAR
								/// </java-name>
								[Dot42.DexImport("YEAR", "Ljava/lang/String;", AccessFlags = 25)]
								public const string YEAR = "year";
								/// <summary>
								///  <para>Non-zero if the audio file is music </para> <para>Type: INTEGER (boolean)</para>        
								/// </summary>
								/// <java-name>
								/// IS_MUSIC
								/// </java-name>
								[Dot42.DexImport("IS_MUSIC", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_MUSIC = "is_music";
								/// <summary>
								///  <para>Non-zero if the audio file is a podcast </para> <para>Type: INTEGER (boolean)</para>        
								/// </summary>
								/// <java-name>
								/// IS_PODCAST
								/// </java-name>
								[Dot42.DexImport("IS_PODCAST", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_PODCAST = "is_podcast";
								/// <summary>
								///  <para>Non-zero if the audio file may be a ringtone </para> <para>Type: INTEGER (boolean)</para>        
								/// </summary>
								/// <java-name>
								/// IS_RINGTONE
								/// </java-name>
								[Dot42.DexImport("IS_RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_RINGTONE = "is_ringtone";
								/// <summary>
								///  <para>Non-zero if the audio file may be an alarm </para> <para>Type: INTEGER (boolean)</para>        
								/// </summary>
								/// <java-name>
								/// IS_ALARM
								/// </java-name>
								[Dot42.DexImport("IS_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_ALARM = "is_alarm";
								/// <summary>
								///  <para>Non-zero if the audio file may be a notification sound </para> <para>Type: INTEGER (boolean)</para>        
								/// </summary>
								/// <java-name>
								/// IS_NOTIFICATION
								/// </java-name>
								[Dot42.DexImport("IS_NOTIFICATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_NOTIFICATION = "is_notification";
						}

						/// <summary>
						///  <para>Columns for audio file that show up in multiple tables. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Audio$AudioColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Audio$AudioColumns", AccessFlags = 1545)]
						public partial interface IAudioColumns : global::Android.Provider.MediaStore.IMediaColumns
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <summary>
				///  <para>Contains meta data for all available images. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>This class allows developers to query and get two kinds of thumbnails: MINI_KIND: 512 x 384 thumbnail MICRO_KIND: 96 x 96 thumbnail </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Images$Thumbnails
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Images$Thumbnails", AccessFlags = 9)]
						public partial class Thumbnails : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
								/// <java-name>
								/// DEFAULT_SORT_ORDER
								/// </java-name>
								[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DEFAULT_SORT_ORDER = "image_id ASC";
								/// <summary>
								///  <para>The data stream for the thumbnail </para> <para>Type: DATA STREAM</para>        
								/// </summary>
								/// <java-name>
								/// DATA
								/// </java-name>
								[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATA = "_data";
								/// <summary>
								///  <para>The original image for the thumbnal </para> <para>Type: INTEGER (ID from Images table)</para>        
								/// </summary>
								/// <java-name>
								/// IMAGE_ID
								/// </java-name>
								[Dot42.DexImport("IMAGE_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IMAGE_ID = "image_id";
								/// <summary>
								///  <para>The kind of the thumbnail </para> <para>Type: INTEGER (One of the values below)</para>        
								/// </summary>
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
								/// <summary>
								///  <para>The blob raw data of thumbnail </para> <para>Type: DATA STREAM</para>        
								/// </summary>
								/// <java-name>
								/// THUMB_DATA
								/// </java-name>
								[Dot42.DexImport("THUMB_DATA", "Ljava/lang/String;", AccessFlags = 25)]
								public const string THUMB_DATA = "thumb_data";
								/// <summary>
								///  <para>The width of the thumbnal </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
								/// <java-name>
								/// WIDTH
								/// </java-name>
								[Dot42.DexImport("WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
								public const string WIDTH = "width";
								/// <summary>
								///  <para>The height of the thumbnail </para> <para>Type: INTEGER (long)</para>        
								/// </summary>
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
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri, string[] projection) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// queryMiniThumbnails
								/// </java-name>
								[Dot42.DexImport("queryMiniThumbnails", "(Landroid/content/ContentResolver;Landroid/net/Uri;I[Ljava/lang/String;)Landroid/" +
    "database/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor QueryMiniThumbnails(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri, int kind, string[] projection) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// queryMiniThumbnail
								/// </java-name>
								[Dot42.DexImport("queryMiniThumbnail", "(Landroid/content/ContentResolver;JI[Ljava/lang/String;)Landroid/database/Cursor;" +
    "", AccessFlags = 25)]
								public static global::Android.Database.ICursor QueryMiniThumbnail(global::Android.Content.ContentResolver cr, long origId, int kind, string[] projection) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <summary>
								///  <para>This method cancels the thumbnail request so clients waiting for getThumbnail will be interrupted and return immediately. Only the original process which made the getThumbnail requests can cancel their own requests.</para> <para></para>        
								/// </summary>
								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver cr, long origId) /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>This method checks if the thumbnails of the specified image (origId) has been created. It will be blocked until the thumbnails are generated.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>A Bitmap instance. It could be null if the original image associated with origId doesn't exist or memory is not enough. </para>
								/// </returns>
								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Land" +
    "roid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver cr, long origId, int kind, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <summary>
								///  <para>This method cancels the thumbnail request so clients waiting for getThumbnail will be interrupted and return immediately. Only the original process which made the getThumbnail requests can cancel their own requests.</para> <para></para>        
								/// </summary>
								/// <java-name>
								/// cancelThumbnailRequest
								/// </java-name>
								[Dot42.DexImport("cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V", AccessFlags = 9)]
								public static void CancelThumbnailRequest(global::Android.Content.ContentResolver cr, long origId, long groupId) /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>This method checks if the thumbnails of the specified image (origId) has been created. It will be blocked until the thumbnails are generated.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>A Bitmap instance. It could be null if the original image associated with origId doesn't exist or memory is not enough. </para>
								/// </returns>
								/// <java-name>
								/// getThumbnail
								/// </java-name>
								[Dot42.DexImport("getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Lan" +
    "droid/graphics/Bitmap;", AccessFlags = 9)]
								public static global::Android.Graphics.Bitmap GetThumbnail(global::Android.Content.ContentResolver cr, long origId, long groupId, int kind, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Graphics.Bitmap);
								}

								/// <summary>
								///  <para>Get the content:// style URI for the image media table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the image media table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
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
								/// <summary>
								///  <para>The content:// style URI for the internal storage. </para>        
								/// </summary>
								/// <java-name>
								/// INTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("INTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri INTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The content:// style URI for the "primary" external storage volume. </para>        
								/// </summary>
								/// <java-name>
								/// EXTERNAL_CONTENT_URI
								/// </java-name>
								[Dot42.DexImport("EXTERNAL_CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
								public static readonly global::Android.Net.Uri EXTERNAL_CONTENT_URI;
								/// <summary>
								///  <para>The MIME type of of this directory of images. Note that each entry in this directory will have a standard image MIME type as appropriate  for example, image/jpeg. </para>        
								/// </summary>
								/// <java-name>
								/// CONTENT_TYPE
								/// </java-name>
								[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string CONTENT_TYPE = "vnd.android.cursor.dir/image";
								/// <summary>
								///  <para>The default sort order for this table </para>        
								/// </summary>
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
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri, string[] projection) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// query
								/// </java-name>
								[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/" +
    "String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri, string[] projection, string where, string orderBy) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <java-name>
								/// query
								/// </java-name>
								[Dot42.DexImport("query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/" +
    "String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 25)]
								public static global::Android.Database.ICursor Query(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string orderBy) /* MethodBuilder.Create */ 
								{
										return default(global::Android.Database.ICursor);
								}

								/// <summary>
								///  <para>Retrieves an image for the given url as a Bitmap.</para> <para></para>        
								/// </summary>
								/// <java-name>
								/// getBitmap
								/// </java-name>
								[Dot42.DexImport("getBitmap", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/graphics/Bitmap;", AccessFlags = 25)]
								public static global::Android.Graphics.Bitmap GetBitmap(global::Android.Content.ContentResolver cr, global::Android.Net.Uri url) /* MethodBuilder.Create */ 
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

								/// <summary>
								///  <para>Get the content:// style URI for the image media table on the given volume.</para> <para></para>        
								/// </summary>
								/// <returns>
								///  <para>the URI to the image media table on the given volume </para>
								/// </returns>
								/// <java-name>
								/// getContentUri
								/// </java-name>
								[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
								public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
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
								/// <summary>
								///  <para>The description of the image </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// DESCRIPTION
								/// </java-name>
								[Dot42.DexImport("DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DESCRIPTION = "description";
								/// <summary>
								///  <para>The picasa id of the image </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// PICASA_ID
								/// </java-name>
								[Dot42.DexImport("PICASA_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PICASA_ID = "picasa_id";
								/// <summary>
								///  <para>Whether the video should be published as public or private </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// IS_PRIVATE
								/// </java-name>
								[Dot42.DexImport("IS_PRIVATE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string IS_PRIVATE = "isprivate";
								/// <summary>
								///  <para>The latitude where the image was captured. </para> <para>Type: DOUBLE</para>        
								/// </summary>
								/// <java-name>
								/// LATITUDE
								/// </java-name>
								[Dot42.DexImport("LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LATITUDE = "latitude";
								/// <summary>
								///  <para>The longitude where the image was captured. </para> <para>Type: DOUBLE</para>        
								/// </summary>
								/// <java-name>
								/// LONGITUDE
								/// </java-name>
								[Dot42.DexImport("LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string LONGITUDE = "longitude";
								/// <summary>
								///  <para>The date &amp; time that the image was taken in units of milliseconds since jan 1, 1970. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// DATE_TAKEN
								/// </java-name>
								[Dot42.DexImport("DATE_TAKEN", "Ljava/lang/String;", AccessFlags = 25)]
								public const string DATE_TAKEN = "datetaken";
								/// <summary>
								///  <para>The orientation for the image expressed as degrees. Only degrees 0, 90, 180, 270 will work. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// ORIENTATION
								/// </java-name>
								[Dot42.DexImport("ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
								public const string ORIENTATION = "orientation";
								/// <summary>
								///  <para>The mini thumb id. </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// MINI_THUMB_MAGIC
								/// </java-name>
								[Dot42.DexImport("MINI_THUMB_MAGIC", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MINI_THUMB_MAGIC = "mini_thumb_magic";
								/// <summary>
								///  <para>The bucket id of the image. This is a read-only property that is automatically computed from the DATA column. </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// BUCKET_ID
								/// </java-name>
								[Dot42.DexImport("BUCKET_ID", "Ljava/lang/String;", AccessFlags = 25)]
								public const string BUCKET_ID = "bucket_id";
								/// <summary>
								///  <para>The bucket display name of the image. This is a read-only property that is automatically computed from the DATA column. </para> <para>Type: TEXT</para>        
								/// </summary>
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

				/// <summary>
				///  <para>Media provider table containing an index of all files in the media storage, including non-media files. This should be used by applications that work with non-media file types (text, HTML, PDF, etc) as well as applications that need to work with multiple media file types in a single query. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Get the content:// style URI for the files table on the given volume.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the URI to the files table on the given volume </para>
						/// </returns>
						/// <java-name>
						/// getContentUri
						/// </java-name>
						[Dot42.DexImport("getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetContentUri(string volumeName) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Get the content:// style URI for a single row in the files table on the given volume.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the URI to the files table on the given volume </para>
						/// </returns>
						/// <java-name>
						/// getContentUri
						/// </java-name>
						[Dot42.DexImport("getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;", AccessFlags = 25)]
						public static global::Android.Net.Uri GetContentUri(string volumeName, long rowId) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Fields for master table for all media files. Table also contains MediaColumns._ID, DATA, SIZE and DATE_MODIFIED. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Files$FileColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Files$FileColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
						public static partial class IFileColumnsConstants
 /* scope: __dot42__ */ 
						{
								/// <summary>
								///  <para>The index of the parent directory of the file </para> <para>Type: INTEGER</para>        
								/// </summary>
								/// <java-name>
								/// PARENT
								/// </java-name>
								[Dot42.DexImport("PARENT", "Ljava/lang/String;", AccessFlags = 25)]
								public const string PARENT = "parent";
								/// <summary>
								///  <para>The MIME type of the file </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// MIME_TYPE
								/// </java-name>
								[Dot42.DexImport("MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MIME_TYPE = "mime_type";
								/// <summary>
								///  <para>The title of the content </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// TITLE
								/// </java-name>
								[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string TITLE = "title";
								/// <summary>
								///  <para>The media type (audio, video, image or playlist) of the file, or 0 for not a media file </para> <para>Type: TEXT</para>        
								/// </summary>
								/// <java-name>
								/// MEDIA_TYPE
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
								public const string MEDIA_TYPE = "media_type";
								/// <summary>
								///  <para>Constant for the MEDIA_TYPE column indicating that file is not an audio, image, video or playlist file. </para>        
								/// </summary>
								/// <java-name>
								/// MEDIA_TYPE_NONE
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_NONE", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_NONE = 0;
								/// <summary>
								///  <para>Constant for the MEDIA_TYPE column indicating that file is an image file. </para>        
								/// </summary>
								/// <java-name>
								/// MEDIA_TYPE_IMAGE
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_IMAGE", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_IMAGE = 1;
								/// <summary>
								///  <para>Constant for the MEDIA_TYPE column indicating that file is an audio file. </para>        
								/// </summary>
								/// <java-name>
								/// MEDIA_TYPE_AUDIO
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_AUDIO", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_AUDIO = 2;
								/// <summary>
								///  <para>Constant for the MEDIA_TYPE column indicating that file is a video file. </para>        
								/// </summary>
								/// <java-name>
								/// MEDIA_TYPE_VIDEO
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_VIDEO", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_VIDEO = 3;
								/// <summary>
								///  <para>Constant for the MEDIA_TYPE column indicating that file is a playlist file. </para>        
								/// </summary>
								/// <java-name>
								/// MEDIA_TYPE_PLAYLIST
								/// </java-name>
								[Dot42.DexImport("MEDIA_TYPE_PLAYLIST", "I", AccessFlags = 25)]
								public const int MEDIA_TYPE_PLAYLIST = 4;
						}

						/// <summary>
						///  <para>Fields for master table for all media files. Table also contains MediaColumns._ID, DATA, SIZE and DATE_MODIFIED. </para>    
						/// </summary>
						/// <java-name>
						/// android/provider/MediaStore$Files$FileColumns
						/// </java-name>
						[Dot42.DexImport("android/provider/MediaStore$Files$FileColumns", AccessFlags = 1545)]
						public partial interface IFileColumns : global::Android.Provider.MediaStore.IMediaColumns
 /* scope: __dot42__ */ 
						{
						}

				}

				/// <summary>
				///  <para>Common fields for most MediaProvider tables </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/MediaStore$MediaColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$MediaColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IMediaColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The data stream for the file </para> <para>Type: DATA STREAM</para>        
						/// </summary>
						/// <java-name>
						/// DATA
						/// </java-name>
						[Dot42.DexImport("DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA = "_data";
						/// <summary>
						///  <para>The size of the file in bytes </para> <para>Type: INTEGER (long)</para>        
						/// </summary>
						/// <java-name>
						/// SIZE
						/// </java-name>
						[Dot42.DexImport("SIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SIZE = "_size";
						/// <summary>
						///  <para>The display name of the file </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// DISPLAY_NAME
						/// </java-name>
						[Dot42.DexImport("DISPLAY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISPLAY_NAME = "_display_name";
						/// <summary>
						///  <para>The title of the content </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// TITLE
						/// </java-name>
						[Dot42.DexImport("TITLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TITLE = "title";
						/// <summary>
						///  <para>The time the file was added to the media provider Units are seconds since 1970. </para> <para>Type: INTEGER (long)</para>        
						/// </summary>
						/// <java-name>
						/// DATE_ADDED
						/// </java-name>
						[Dot42.DexImport("DATE_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE_ADDED = "date_added";
						/// <summary>
						///  <para>The time the file was last modified Units are seconds since 1970. NOTE: This is for internal use by the media scanner. Do not modify this field. </para> <para>Type: INTEGER (long)</para>        
						/// </summary>
						/// <java-name>
						/// DATE_MODIFIED
						/// </java-name>
						[Dot42.DexImport("DATE_MODIFIED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE_MODIFIED = "date_modified";
						/// <summary>
						///  <para>The MIME type of the file </para> <para>Type: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// MIME_TYPE
						/// </java-name>
						[Dot42.DexImport("MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MIME_TYPE = "mime_type";
				}

				/// <summary>
				///  <para>Common fields for most MediaProvider tables </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/MediaStore$MediaColumns
				/// </java-name>
				[Dot42.DexImport("android/provider/MediaStore$MediaColumns", AccessFlags = 1545)]
				public partial interface IMediaColumns : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <summary>
		///  <para>This is a utility class providing access to android.content.SearchRecentSuggestionsProvider.</para> <para>Unlike some utility classes, this one must be instantiated and properly initialized, so that it can be configured to operate with the search suggestions provider that you have created.</para> <para>Typically, you will do this in your searchable activity, each time you receive an incoming ACTION_SEARCH Intent. The code to record each incoming query is as follows:  <pre>
		///      SearchSuggestions suggestions = new SearchSuggestions(this,
		///              MySuggestionsProvider.AUTHORITY, MySuggestionsProvider.MODE);
		///      suggestions.saveRecentQuery(queryString, null);
		/// </pre></para> <para>For a working example, see SearchSuggestionSampleProvider and SearchQueryResults in samples/ApiDemos/app.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about using search suggestions in your application, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/provider/SearchRecentSuggestions
		/// </java-name>
		[Dot42.DexImport("android/provider/SearchRecentSuggestions", AccessFlags = 33)]
		public partial class SearchRecentSuggestions
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This is the database projection that can be used to view saved queries, when configured for one-line operation. </para>        
				/// </summary>
				/// <java-name>
				/// QUERIES_PROJECTION_1LINE
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_1LINE", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] QUERIES_PROJECTION_1LINE;
				/// <summary>
				///  <para>This is the database projection that can be used to view saved queries, when configured for two-line operation. </para>        
				/// </summary>
				/// <java-name>
				/// QUERIES_PROJECTION_2LINE
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_2LINE", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] QUERIES_PROJECTION_2LINE;
				/// <summary>
				///  <para>Index into the provided query projections. For use with Cursor.update methods. </para>        
				/// </summary>
				/// <java-name>
				/// QUERIES_PROJECTION_DATE_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_DATE_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_DATE_INDEX = 1;
				/// <summary>
				///  <para>Index into the provided query projections. For use with Cursor.update methods. </para>        
				/// </summary>
				/// <java-name>
				/// QUERIES_PROJECTION_QUERY_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_QUERY_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_QUERY_INDEX = 2;
				/// <summary>
				///  <para>Index into the provided query projections. For use with Cursor.update methods. </para>        
				/// </summary>
				/// <java-name>
				/// QUERIES_PROJECTION_DISPLAY1_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_DISPLAY1_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_DISPLAY1_INDEX = 3;
				/// <summary>
				///  <para>Index into the provided query projections. For use with Cursor.update methods. </para>        
				/// </summary>
				/// <java-name>
				/// QUERIES_PROJECTION_DISPLAY2_INDEX
				/// </java-name>
				[Dot42.DexImport("QUERIES_PROJECTION_DISPLAY2_INDEX", "I", AccessFlags = 25)]
				public const int QUERIES_PROJECTION_DISPLAY2_INDEX = 4;
				/// <summary>
				///  <para>Although provider utility classes are typically static, this one must be constructed because it needs to be initialized using the same values that you provided in your android.content.SearchRecentSuggestionsProvider.</para> <para> <para>android.content.SearchRecentSuggestionsProvider </para> <para>android.content.SearchRecentSuggestionsProvider::setupSuggestions </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SearchRecentSuggestions(global::Android.Content.Context context, string authority, int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a query to the recent queries list. Returns immediately, performing the save in the background.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// saveRecentQuery
				/// </java-name>
				[Dot42.DexImport("saveRecentQuery", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SaveRecentQuery(string queryString, string line2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Completely delete the history. Use this call to implement a "clear history" UI.</para> <para>Any application that implements search suggestions based on previous actions (such as recent queries, page/items viewed, etc.) should provide a way for the user to clear the history. This gives the user a measure of privacy, if they do not wish for their recent searches to be replayed by other users of the device (via suggestions). </para>        
				/// </summary>
				/// <java-name>
				/// clearHistory
				/// </java-name>
				[Dot42.DexImport("clearHistory", "()V", AccessFlags = 1)]
				public virtual void ClearHistory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reduces the length of the history table, to prevent it from growing too large.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// truncateHistory
				/// </java-name>
				[Dot42.DexImport("truncateHistory", "(Landroid/content/ContentResolver;I)V", AccessFlags = 4)]
				protected internal virtual void TruncateHistory(global::Android.Content.ContentResolver cr, int maxEntries) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SearchRecentSuggestions() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The Settings provider contains global system-level device preferences. </para>    
		/// </summary>
		/// <java-name>
		/// android/provider/Settings
		/// </java-name>
		[Dot42.DexImport("android/provider/Settings", AccessFlags = 49)]
		public sealed partial class Settings
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Activity Action: Show system settings. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SETTINGS = "android.settings.SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of APNs. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APN_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APN_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APN_SETTINGS = "android.settings.APN_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of current location sources. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_LOCATION_SOURCE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCATION_SOURCE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCATION_SOURCE_SETTINGS = "android.settings.LOCATION_SOURCE_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of wireless controls such as Wi-Fi, Bluetooth and Mobile networks. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_WIRELESS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_WIRELESS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WIRELESS_SETTINGS = "android.settings.WIRELESS_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow entering/exiting airplane mode. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_AIRPLANE_MODE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_AIRPLANE_MODE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AIRPLANE_MODE_SETTINGS = "android.settings.AIRPLANE_MODE_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings for accessibility modules. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ACCESSIBILITY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_ACCESSIBILITY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACCESSIBILITY_SETTINGS = "android.settings.ACCESSIBILITY_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of security and location privacy. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SECURITY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SECURITY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SECURITY_SETTINGS = "android.settings.SECURITY_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of privacy options. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PRIVACY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_PRIVACY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PRIVACY_SETTINGS = "android.settings.PRIVACY_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of Wi-Fi.</para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_WIFI_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_WIFI_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WIFI_SETTINGS = "android.settings.WIFI_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of a static IP address for Wi-Fi. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_WIFI_IP_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_WIFI_IP_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WIFI_IP_SETTINGS = "android.settings.WIFI_IP_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of Bluetooth. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BLUETOOTH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_BLUETOOTH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BLUETOOTH_SETTINGS = "android.settings.BLUETOOTH_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of date and time. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DATE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DATE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DATE_SETTINGS = "android.settings.DATE_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of sound and volume. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SOUND_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SOUND_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SOUND_SETTINGS = "android.settings.SOUND_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of display. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DISPLAY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DISPLAY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISPLAY_SETTINGS = "android.settings.DISPLAY_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of locale. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_LOCALE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCALE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCALE_SETTINGS = "android.settings.LOCALE_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to configure input methods, in particular allowing the user to enable input methods. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INPUT_METHOD_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_INPUT_METHOD_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INPUT_METHOD_SETTINGS = "android.settings.INPUT_METHOD_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to enable/disable input method subtypes. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>To tell which input method's subtypes are displayed in the settings, add EXTRA_INPUT_METHOD_ID extra to this Intent with the input method id. If there is no extra in this Intent, subtypes from all installed input methods will be displayed in the settings.</para> <para> <para>android.view.inputmethod.InputMethodInfo::getId </para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INPUT_METHOD_SUBTYPE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_INPUT_METHOD_SUBTYPE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INPUT_METHOD_SUBTYPE_SETTINGS = "android.settings.INPUT_METHOD_SUBTYPE_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to manage the user input dictionary. </para> <para>Starting with android.os.Build.VERSION_CODES#KITKAT, it is guaranteed there will always be an appropriate implementation for this Intent action. In prior releases of the platform this was optional, so ensure you safeguard against it. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_USER_DICTIONARY_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_USER_DICTIONARY_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USER_DICTIONARY_SETTINGS = "android.settings.USER_DICTIONARY_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of application-related settings. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPLICATION_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APPLICATION_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPLICATION_SETTINGS = "android.settings.APPLICATION_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of application development-related settings. As of android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 this action is a required part of the platform. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPLICATION_DEVELOPMENT_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APPLICATION_DEVELOPMENT_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPLICATION_DEVELOPMENT_SETTINGS = "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of quick launch shortcuts. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_QUICK_LAUNCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_QUICK_LAUNCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_QUICK_LAUNCH_SETTINGS = "android.settings.QUICK_LAUNCH_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to manage installed applications. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MANAGE_APPLICATIONS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_APPLICATIONS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_APPLICATIONS_SETTINGS = "android.settings.MANAGE_APPLICATIONS_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to manage all applications. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS = "android.settings.MANAGE_ALL_APPLICATIONS_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show screen of details about a particular application. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: The Intent's data URI specifies the application package name to be shown, with the "package" scheme. That is "package:com.my.app". </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPLICATION_DETAILS_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_APPLICATION_DETAILS_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPLICATION_DETAILS_SETTINGS = "android.settings.APPLICATION_DETAILS_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings to allow configuration of sync settings. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>The account types available to add via the add account button may be restricted by adding an EXTRA_AUTHORITIES extra to this Intent with one or more syncable content provider's authorities. Only account types which can sync with that content provider will be offered to the user. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SYNC_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SYNC_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SYNC_SETTINGS = "android.settings.SYNC_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show add account screen for creating a new account. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>The account types available to add may be restricted by adding an EXTRA_AUTHORITIES extra to the Intent with one or more syncable content provider's authorities. Only account types which can sync with that content provider will be offered to the user. </para> <para>Account types can also be filtered by adding an EXTRA_ACCOUNT_TYPES extra to the Intent with one or more account types. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ADD_ACCOUNT
				/// </java-name>
				[Dot42.DexImport("ACTION_ADD_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ADD_ACCOUNT = "android.settings.ADD_ACCOUNT_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings for selecting the network operator. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NETWORK_OPERATOR_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_NETWORK_OPERATOR_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NETWORK_OPERATOR_SETTINGS = "android.settings.NETWORK_OPERATOR_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings for selection of 2G/3G. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DATA_ROAMING_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DATA_ROAMING_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DATA_ROAMING_SETTINGS = "android.settings.DATA_ROAMING_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings for internal storage. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INTERNAL_STORAGE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_INTERNAL_STORAGE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INTERNAL_STORAGE_SETTINGS = "android.settings.INTERNAL_STORAGE_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings for memory card storage. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEMORY_CARD_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_MEMORY_CARD_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEMORY_CARD_SETTINGS = "android.settings.MEMORY_CARD_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show settings for global search. </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SEARCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_SEARCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEARCH_SETTINGS = "android.search.action.SEARCH_SETTINGS";
				/// <summary>
				///  <para>Activity Action: Show general device information settings (serial number, software version, phone number, etc.). </para> <para>In some cases, a matching Activity may not exist, so ensure you safeguard against this. </para> <para>Input: Nothing. </para> <para>Output: Nothing </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEVICE_INFO_SETTINGS
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_INFO_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_INFO_SETTINGS = "android.settings.DEVICE_INFO_SETTINGS";
				/// <summary>
				///  <para>Activity Extra: Limit available options in launched activity based on the given authority. </para> <para>This can be passed as an extra field in an Activity Intent with one or more syncable content provider's authorities as a String[]. This field is used by some intents to alter the behavior of the called activity. </para> <para>Example: The ACTION_ADD_ACCOUNT intent restricts the account types available based on the authority given. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Secure system settings, containing system preferences that applications can read but are not allowed to write. These are for preferences that the user must explicitly modify through the system UI or specialized APIs for those values, not modified directly by applications. </para>    
				/// </summary>
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
						/// <summary>
						///  <para>The content:// style URL for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#ADB_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ADB_ENABLED
						/// </java-name>
						[Dot42.DexImport("ADB_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ADB_ENABLED = "adb_enabled";
						/// <summary>
						///  <para>Setting to allow mock locations and location provider status to be injected into the LocationManager service for testing purposes during application development. These locations and status values override actual location and status information generated by network, gps, or other location providers. </para>        
						/// </summary>
						/// <java-name>
						/// ALLOW_MOCK_LOCATION
						/// </java-name>
						[Dot42.DexImport("ALLOW_MOCK_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOW_MOCK_LOCATION = "mock_location";
						/// <summary>
						///  <para>A 64-bit number (as a hex string) that is randomly generated on the device's first boot and should remain constant for the lifetime of the device. (The value may change if a factory reset is performed on the device.) </para>        
						/// </summary>
						/// <java-name>
						/// ANDROID_ID
						/// </java-name>
						[Dot42.DexImport("ANDROID_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANDROID_ID = "android_id";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#BLUETOOTH_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// BLUETOOTH_ON
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_ON = "bluetooth_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#DATA_ROAMING instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DATA_ROAMING
						/// </java-name>
						[Dot42.DexImport("DATA_ROAMING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ROAMING = "data_roaming";
						/// <summary>
						///  <para>Setting to record the input method used by default, holding the ID of the desired method. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_INPUT_METHOD
						/// </java-name>
						[Dot42.DexImport("DEFAULT_INPUT_METHOD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_INPUT_METHOD = "default_input_method";
						/// <summary>
						///  <para>Setting to record the input method subtype used by default, holding the ID of the desired method. </para>        
						/// </summary>
						/// <java-name>
						/// SELECTED_INPUT_METHOD_SUBTYPE
						/// </java-name>
						[Dot42.DexImport("SELECTED_INPUT_METHOD_SUBTYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SELECTED_INPUT_METHOD_SUBTYPE = "selected_input_method_subtype";
						/// <summary>
						///  <para>Setting to record the visibility of input method selector </para>        
						/// </summary>
						/// <java-name>
						/// INPUT_METHOD_SELECTOR_VISIBILITY
						/// </java-name>
						[Dot42.DexImport("INPUT_METHOD_SELECTOR_VISIBILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INPUT_METHOD_SELECTOR_VISIBILITY = "input_method_selector_visibility";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#DEVICE_PROVISIONED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEVICE_PROVISIONED
						/// </java-name>
						[Dot42.DexImport("DEVICE_PROVISIONED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEVICE_PROVISIONED = "device_provisioned";
						/// <summary>
						///  <para>List of input methods that are currently enabled. This is a string containing the IDs of all enabled input methods, each ID separated by ':'. </para>        
						/// </summary>
						/// <java-name>
						/// ENABLED_INPUT_METHODS
						/// </java-name>
						[Dot42.DexImport("ENABLED_INPUT_METHODS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ENABLED_INPUT_METHODS = "enabled_input_methods";
						/// <summary>
						///  <para>Host name and port for global http proxy. Uses ':' seperator for between host and port.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#HTTP_PROXY </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// HTTP_PROXY
						/// </java-name>
						[Dot42.DexImport("HTTP_PROXY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HTTP_PROXY = "http_proxy";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#INSTALL_NON_MARKET_APPS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// INSTALL_NON_MARKET_APPS
						/// </java-name>
						[Dot42.DexImport("INSTALL_NON_MARKET_APPS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INSTALL_NON_MARKET_APPS = "install_non_market_apps";
						/// <summary>
						///  <para>Comma-separated list of location providers that activities may access.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use LOCATION_MODE </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCATION_PROVIDERS_ALLOWED
						/// </java-name>
						[Dot42.DexImport("LOCATION_PROVIDERS_ALLOWED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCATION_PROVIDERS_ALLOWED = "location_providers_allowed";
						/// <summary>
						///  <para>Whether autolock is enabled (0 = false, 1 = true) </para>        
						/// </summary>
						/// <java-name>
						/// LOCK_PATTERN_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_ENABLED = "lock_pattern_autolock";
						/// <summary>
						///  <para>Whether lock pattern is visible as user enters (0 = false, 1 = true) </para>        
						/// </summary>
						/// <java-name>
						/// LOCK_PATTERN_VISIBLE
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_VISIBLE = "lock_pattern_visible_pattern";
						/// <summary>
						///  <para>Whether lock pattern will vibrate as user enters (0 = false, 1 = true)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Starting in VERSION_CODES#JELLY_BEAN_MR1 the lockscreen uses Settings.System#HAPTIC_FEEDBACK_ENABLED. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED = "lock_pattern_tactile_feedback_enabled";
						/// <summary>
						///  <para>The Logging ID (a unique 64-bit value) as a hex string. Used as a pseudonymous identifier for logging.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This identifier is poorly initialized and has many collisions. It should not be used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOGGING_ID
						/// </java-name>
						[Dot42.DexImport("LOGGING_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOGGING_ID = "logging_id";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#NETWORK_PREFERENCE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NETWORK_PREFERENCE
						/// </java-name>
						[Dot42.DexImport("NETWORK_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NETWORK_PREFERENCE = "network_preference";
						/// <summary>
						///  <para>No longer supported. </para>        
						/// </summary>
						/// <java-name>
						/// PARENTAL_CONTROL_ENABLED
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_ENABLED = "parental_control_enabled";
						/// <summary>
						///  <para>No longer supported. </para>        
						/// </summary>
						/// <java-name>
						/// PARENTAL_CONTROL_LAST_UPDATE
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_LAST_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_LAST_UPDATE = "parental_control_last_update";
						/// <summary>
						///  <para>No longer supported. </para>        
						/// </summary>
						/// <java-name>
						/// PARENTAL_CONTROL_REDIRECT_URL
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_REDIRECT_URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_REDIRECT_URL = "parental_control_redirect_url";
						/// <summary>
						///  <para>Settings classname to launch when Settings is clicked from All Applications. Needed because of user testing between the old and new Settings apps. </para>        
						/// </summary>
						/// <java-name>
						/// SETTINGS_CLASSNAME
						/// </java-name>
						[Dot42.DexImport("SETTINGS_CLASSNAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETTINGS_CLASSNAME = "settings_classname";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#USB_MASS_STORAGE_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// USB_MASS_STORAGE_ENABLED
						/// </java-name>
						[Dot42.DexImport("USB_MASS_STORAGE_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USB_MASS_STORAGE_ENABLED = "usb_mass_storage_enabled";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#USE_GOOGLE_MAIL instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// USE_GOOGLE_MAIL
						/// </java-name>
						[Dot42.DexImport("USE_GOOGLE_MAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USE_GOOGLE_MAIL = "use_google_mail";
						/// <summary>
						///  <para>If accessibility is enabled. </para>        
						/// </summary>
						/// <java-name>
						/// ACCESSIBILITY_ENABLED
						/// </java-name>
						[Dot42.DexImport("ACCESSIBILITY_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESSIBILITY_ENABLED = "accessibility_enabled";
						/// <summary>
						///  <para>List of the enabled accessibility providers. </para>        
						/// </summary>
						/// <java-name>
						/// ENABLED_ACCESSIBILITY_SERVICES
						/// </java-name>
						[Dot42.DexImport("ENABLED_ACCESSIBILITY_SERVICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ENABLED_ACCESSIBILITY_SERVICES = "enabled_accessibility_services";
						/// <summary>
						///  <para>Setting to always use the default text-to-speech settings regardless of the application settings. 1 = override application settings, 0 = use application settings (if specified).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The value of this setting is no longer respected by the framework text to speech APIs as of the Ice Cream Sandwich release. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TTS_USE_DEFAULTS
						/// </java-name>
						[Dot42.DexImport("TTS_USE_DEFAULTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_USE_DEFAULTS = "tts_use_defaults";
						/// <summary>
						///  <para>Default text-to-speech engine speech rate. 100 = 1x </para>        
						/// </summary>
						/// <java-name>
						/// TTS_DEFAULT_RATE
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_RATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_RATE = "tts_default_rate";
						/// <summary>
						///  <para>Default text-to-speech engine pitch. 100 = 1x </para>        
						/// </summary>
						/// <java-name>
						/// TTS_DEFAULT_PITCH
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_PITCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_PITCH = "tts_default_pitch";
						/// <summary>
						///  <para>Default text-to-speech engine. </para>        
						/// </summary>
						/// <java-name>
						/// TTS_DEFAULT_SYNTH
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_SYNTH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_SYNTH = "tts_default_synth";
						/// <summary>
						///  <para>Default text-to-speech language.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this setting is no longer in use, as of the Ice Cream Sandwich release. Apps should never need to read this setting directly, instead can query the TextToSpeech framework classes for the default locale. TextToSpeech#getLanguage(). </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TTS_DEFAULT_LANG
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_LANG", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_LANG = "tts_default_lang";
						/// <summary>
						///  <para>Default text-to-speech country.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this setting is no longer in use, as of the Ice Cream Sandwich release. Apps should never need to read this setting directly, instead can query the TextToSpeech framework classes for the default locale. TextToSpeech#getLanguage(). </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TTS_DEFAULT_COUNTRY
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_COUNTRY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_COUNTRY = "tts_default_country";
						/// <summary>
						///  <para>Default text-to-speech locale variant.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this setting is no longer in use, as of the Ice Cream Sandwich release. Apps should never need to read this setting directly, instead can query the TextToSpeech framework classes for the locale that is in use TextToSpeech#getLanguage(). </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TTS_DEFAULT_VARIANT
						/// </java-name>
						[Dot42.DexImport("TTS_DEFAULT_VARIANT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_DEFAULT_VARIANT = "tts_default_variant";
						/// <summary>
						///  <para>Space delimited list of plugin packages that are enabled. </para>        
						/// </summary>
						/// <java-name>
						/// TTS_ENABLED_PLUGINS
						/// </java-name>
						[Dot42.DexImport("TTS_ENABLED_PLUGINS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TTS_ENABLED_PLUGINS = "tts_enabled_plugins";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON = "wifi_networks_available_notification_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY = "wifi_networks_available_repeat_delay";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_NUM_OPEN_NETWORKS_KEPT instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_NUM_OPEN_NETWORKS_KEPT
						/// </java-name>
						[Dot42.DexImport("WIFI_NUM_OPEN_NETWORKS_KEPT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NUM_OPEN_NETWORKS_KEPT = "wifi_num_open_networks_kept";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_ON instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_ON = "wifi_on";
						/// <summary>
						///  <para>The acceptable packet loss percentage (range 0 - 100) before trying another AP on the same network.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE = "wifi_watchdog_acceptable_packet_loss_percentage";
						/// <summary>
						///  <para>The number of access points required for a network in order for the watchdog to monitor it.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_AP_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_AP_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_AP_COUNT = "wifi_watchdog_ap_count";
						/// <summary>
						///  <para>The delay between background checks.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS = "wifi_watchdog_background_check_delay_ms";
						/// <summary>
						///  <para>Whether the Wi-Fi watchdog is enabled for background checking even after it thinks the user has connected to a good access point.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED = "wifi_watchdog_background_check_enabled";
						/// <summary>
						///  <para>The timeout for a background ping  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS = "wifi_watchdog_background_check_timeout_ms";
						/// <summary>
						///  <para>The number of initial pings to perform that *may* be ignored if they fail. Again, if these fail, they will *not* be used in packet loss calculation. For example, one network always seemed to time out for the first couple pings, so this is set to 3 by default.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT = "wifi_watchdog_initial_ignored_ping_count";
						/// <summary>
						///  <para>The maximum number of access points (per network) to attempt to test. If this number is reached, the watchdog will no longer monitor the initial connection state for the network. This is a safeguard for networks containing multiple APs whose DNS does not respond to pings.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_MAX_AP_CHECKS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_MAX_AP_CHECKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_MAX_AP_CHECKS = "wifi_watchdog_max_ap_checks";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_WATCHDOG_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ON = "wifi_watchdog_on";
						/// <summary>
						///  <para>A comma-separated list of SSIDs for which the Wi-Fi watchdog should be enabled.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_WATCH_LIST
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_WATCH_LIST", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_WATCH_LIST = "wifi_watchdog_watch_list";
						/// <summary>
						///  <para>The number of pings to test if an access point is a good connection.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_COUNT = "wifi_watchdog_ping_count";
						/// <summary>
						///  <para>The delay between pings.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_PING_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_DELAY_MS = "wifi_watchdog_ping_delay_ms";
						/// <summary>
						///  <para>The timeout per ping.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is not used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_PING_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_TIMEOUT_MS = "wifi_watchdog_ping_timeout_ms";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_MAX_DHCP_RETRY_COUNT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_MAX_DHCP_RETRY_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_MAX_DHCP_RETRY_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MAX_DHCP_RETRY_COUNT = "wifi_max_dhcp_retry_count";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS = "wifi_mobile_data_transition_wakelock_timeout_ms";
						/// <summary>
						///  <para>Whether background data usage is allowed.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>As of VERSION_CODES#ICE_CREAM_SANDWICH, availability of background data depends on several combined factors. When background data is unavailable, ConnectivityManager#getActiveNetworkInfo() will now appear disconnected. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// BACKGROUND_DATA
						/// </java-name>
						[Dot42.DexImport("BACKGROUND_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BACKGROUND_DATA = "background_data";
						/// <summary>
						///  <para>Origins for which browsers should allow geolocation by default. The value is a space-separated list of origins. </para>        
						/// </summary>
						/// <java-name>
						/// ALLOWED_GEOLOCATION_ORIGINS
						/// </java-name>
						[Dot42.DexImport("ALLOWED_GEOLOCATION_ORIGINS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALLOWED_GEOLOCATION_ORIGINS = "allowed_geolocation_origins";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Secure() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Look up a name in the database. </para>        
						/// </summary>
						/// <returns>
						///  <para>the corresponding value, or null if not present </para>
						/// </returns>
						/// <java-name>
						/// getString
						/// </java-name>
						[Dot42.DexImport("getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 41)]
						public static string GetString(global::Android.Content.ContentResolver resolver, string name) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Store a name/value pair into the database. </para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putString
						/// </java-name>
						[Dot42.DexImport("putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
						public static bool PutString(global::Android.Content.ContentResolver resolver, string name, string value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Construct the content URI for a particular name/value pair, useful for monitoring changes with a ContentObserver. </para>        
						/// </summary>
						/// <returns>
						///  <para>the corresponding content URI, or null if not present </para>
						/// </returns>
						/// <java-name>
						/// getUriFor
						/// </java-name>
						[Dot42.DexImport("getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetUriFor(string name) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single secure settings value as an integer. Note that internally setting values are always stored as strings; this function converts the string to an integer for you. The default value will be returned if the setting is not defined or not an integer.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value, or 'def' if it is not defined or not a valid integer. </para>
						/// </returns>
						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver cr, string name, int def) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single secure settings value as an integer. Note that internally setting values are always stored as strings; this function converts the string to an integer for you. </para> <para>This version does not take a default value. If the setting has not been set, or the string value is not a number, it throws SettingNotFoundException.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value. </para>
						/// </returns>
						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver cr, string name) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Convenience function for updating a single settings value as an integer. This will either create a new entry in the table if the given name does not exist, or modify the value of the existing row with that name. Note that internally setting values are always stored as strings, so this function converts the given value to a string before storing it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putInt
						/// </java-name>
						[Dot42.DexImport("putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z", AccessFlags = 9)]
						public static bool PutInt(global::Android.Content.ContentResolver cr, string name, int value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single secure settings value as a <c>long </c> . Note that internally setting values are always stored as strings; this function converts the string to a <c>long </c> for you. The default value will be returned if the setting is not defined or not a <c>long </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value, or 'def' if it is not defined or not a valid <c>long </c> . </para>
						/// </returns>
						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver cr, string name, long def) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single secure settings value as a <c>long </c> . Note that internally setting values are always stored as strings; this function converts the string to a <c>long </c> for you. </para> <para>This version does not take a default value. If the setting has not been set, or the string value is not a number, it throws SettingNotFoundException.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value. </para>
						/// </returns>
						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver cr, string name) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Convenience function for updating a secure settings value as a long integer. This will either create a new entry in the table if the given name does not exist, or modify the value of the existing row with that name. Note that internally setting values are always stored as strings, so this function converts the given value to a string before storing it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putLong
						/// </java-name>
						[Dot42.DexImport("putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z", AccessFlags = 9)]
						public static bool PutLong(global::Android.Content.ContentResolver cr, string name, long value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single secure settings value as a floating point number. Note that internally setting values are always stored as strings; this function converts the string to an float for you. The default value will be returned if the setting is not defined or not a valid float.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value, or 'def' if it is not defined or not a valid float. </para>
						/// </returns>
						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver cr, string name, float def) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single secure settings value as a float. Note that internally setting values are always stored as strings; this function converts the string to a float for you. </para> <para>This version does not take a default value. If the setting has not been set, or the string value is not a number, it throws SettingNotFoundException.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value. </para>
						/// </returns>
						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver cr, string name) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						///  <para>Convenience function for updating a single settings value as a floating point number. This will either create a new entry in the table if the given name does not exist, or modify the value of the existing row with that name. Note that internally setting values are always stored as strings, so this function converts the given value to a string before storing it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putFloat
						/// </java-name>
						[Dot42.DexImport("putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z", AccessFlags = 9)]
						public static bool PutFloat(global::Android.Content.ContentResolver cr, string name, float value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Helper method for determining if a location provider is enabled.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use LOCATION_MODE or LocationManager#isProviderEnabled(String) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the provider is enabled</para>
						/// </returns>
						/// <java-name>
						/// isLocationProviderEnabled
						/// </java-name>
						[Dot42.DexImport("isLocationProviderEnabled", "(Landroid/content/ContentResolver;Ljava/lang/String;)Z", AccessFlags = 25)]
						public static bool IsLocationProviderEnabled(global::Android.Content.ContentResolver cr, string provider) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Thread-safe method for enabling or disabling a single location provider.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use putInt(ContentResolver, String, int) and LOCATION_MODE </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setLocationProviderEnabled
						/// </java-name>
						[Dot42.DexImport("setLocationProviderEnabled", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V", AccessFlags = 25)]
						public static void SetLocationProviderEnabled(global::Android.Content.ContentResolver cr, string provider, bool enabled) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>System settings, containing miscellaneous system preferences. This table holds simple name/value pairs. There are convenience functions for accessing individual settings entries. </para>    
				/// </summary>
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
						/// <summary>
						///  <para>The content:// style URL for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#STAY_ON_WHILE_PLUGGED_IN instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// STAY_ON_WHILE_PLUGGED_IN
						/// </java-name>
						[Dot42.DexImport("STAY_ON_WHILE_PLUGGED_IN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STAY_ON_WHILE_PLUGGED_IN = "stay_on_while_plugged_in";
						/// <summary>
						///  <para>What happens when the user presses the end call button if they're not on a call. <br></br>  <b>Values:</b> <br></br> 0 - The end button does nothing. <br></br> 1 - The end button goes to the home screen. <br></br> 2 - The end button puts the device to sleep and locks the keyguard. <br></br> 3 - The end button goes to the home screen. If the user is already on the home screen, it puts the device to sleep. </para>        
						/// </summary>
						/// <java-name>
						/// END_BUTTON_BEHAVIOR
						/// </java-name>
						[Dot42.DexImport("END_BUTTON_BEHAVIOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string END_BUTTON_BEHAVIOR = "end_button_behavior";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#AIRPLANE_MODE_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// AIRPLANE_MODE_ON
						/// </java-name>
						[Dot42.DexImport("AIRPLANE_MODE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AIRPLANE_MODE_ON = "airplane_mode_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#RADIO_BLUETOOTH instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// RADIO_BLUETOOTH
						/// </java-name>
						[Dot42.DexImport("RADIO_BLUETOOTH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_BLUETOOTH = "bluetooth";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#RADIO_WIFI instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// RADIO_WIFI
						/// </java-name>
						[Dot42.DexImport("RADIO_WIFI", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_WIFI = "wifi";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#RADIO_CELL instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// RADIO_CELL
						/// </java-name>
						[Dot42.DexImport("RADIO_CELL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RADIO_CELL = "cell";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#AIRPLANE_MODE_RADIOS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// AIRPLANE_MODE_RADIOS
						/// </java-name>
						[Dot42.DexImport("AIRPLANE_MODE_RADIOS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AIRPLANE_MODE_RADIOS = "airplane_mode_radios";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_SLEEP_POLICY instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_SLEEP_POLICY
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_SLEEP_POLICY = "wifi_sleep_policy";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_SLEEP_POLICY_DEFAULT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_SLEEP_POLICY_DEFAULT
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY_DEFAULT", "I", AccessFlags = 25)]
						public const int WIFI_SLEEP_POLICY_DEFAULT = 0;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED", "I", AccessFlags = 25)]
						public const int WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED = 1;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_SLEEP_POLICY_NEVER instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_SLEEP_POLICY_NEVER
						/// </java-name>
						[Dot42.DexImport("WIFI_SLEEP_POLICY_NEVER", "I", AccessFlags = 25)]
						public const int WIFI_SLEEP_POLICY_NEVER = 2;
						/// <summary>
						///  <para>Whether to use static IP and other static network attributes. </para> <para>Set to 1 for true and 0 for false.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WifiManager instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_USE_STATIC_IP
						/// </java-name>
						[Dot42.DexImport("WIFI_USE_STATIC_IP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_USE_STATIC_IP = "wifi_use_static_ip";
						/// <summary>
						///  <para>The static IP address. </para> <para>Example: "192.168.1.51"</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WifiManager instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_STATIC_IP
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_IP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_IP = "wifi_static_ip";
						/// <summary>
						///  <para>If using static IP, the gateway's IP address. </para> <para>Example: "192.168.1.1"</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WifiManager instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_STATIC_GATEWAY
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_GATEWAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_GATEWAY = "wifi_static_gateway";
						/// <summary>
						///  <para>If using static IP, the net mask. </para> <para>Example: "255.255.255.0"</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WifiManager instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_STATIC_NETMASK
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_NETMASK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_NETMASK = "wifi_static_netmask";
						/// <summary>
						///  <para>If using static IP, the primary DNS's IP address. </para> <para>Example: "192.168.1.1"</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WifiManager instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_STATIC_DNS1
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_DNS1", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_DNS1 = "wifi_static_dns1";
						/// <summary>
						///  <para>If using static IP, the secondary DNS's IP address. </para> <para>Example: "192.168.1.2"</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WifiManager instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_STATIC_DNS2
						/// </java-name>
						[Dot42.DexImport("WIFI_STATIC_DNS2", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_STATIC_DNS2 = "wifi_static_dns2";
						/// <summary>
						///  <para>Determines whether remote devices may discover and/or connect to this device. </para> <para>Type: INT</para> <para>2  discoverable and connectable 1  connectable but not discoverable 0  neither connectable nor discoverable </para>        
						/// </summary>
						/// <java-name>
						/// BLUETOOTH_DISCOVERABILITY
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_DISCOVERABILITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_DISCOVERABILITY = "bluetooth_discoverability";
						/// <summary>
						///  <para>Bluetooth discoverability timeout. If this value is nonzero, then Bluetooth becomes discoverable for a certain number of seconds, after which is becomes simply connectable. The value is in seconds. </para>        
						/// </summary>
						/// <java-name>
						/// BLUETOOTH_DISCOVERABILITY_TIMEOUT
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_DISCOVERABILITY_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_DISCOVERABILITY_TIMEOUT = "bluetooth_discoverability_timeout";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#LOCK_PATTERN_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCK_PATTERN_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_ENABLED = "lock_pattern_autolock";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#LOCK_PATTERN_VISIBLE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCK_PATTERN_VISIBLE
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_VISIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_VISIBLE = "lock_pattern_visible_pattern";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
						/// </java-name>
						[Dot42.DexImport("LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED = "lock_pattern_tactile_feedback_enabled";
						/// <summary>
						///  <para>A formatted string of the next alarm that is set, or the empty string if there is no alarm set. </para>        
						/// </summary>
						/// <java-name>
						/// NEXT_ALARM_FORMATTED
						/// </java-name>
						[Dot42.DexImport("NEXT_ALARM_FORMATTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NEXT_ALARM_FORMATTED = "next_alarm_formatted";
						/// <summary>
						///  <para>Scaling factor for fonts, float. </para>        
						/// </summary>
						/// <java-name>
						/// FONT_SCALE
						/// </java-name>
						[Dot42.DexImport("FONT_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FONT_SCALE = "font_scale";
						/// <summary>
						///  <para>Name of an application package to be debugged.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#DEBUG_APP instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEBUG_APP
						/// </java-name>
						[Dot42.DexImport("DEBUG_APP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEBUG_APP = "debug_app";
						/// <summary>
						///  <para>If 1, when launching DEBUG_APP it will wait for the debugger before starting user code. If 0, it will run normally.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#WAIT_FOR_DEBUGGER instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WAIT_FOR_DEBUGGER
						/// </java-name>
						[Dot42.DexImport("WAIT_FOR_DEBUGGER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WAIT_FOR_DEBUGGER = "wait_for_debugger";
						/// <summary>
						///  <para>Whether or not to dim the screen. 0=no 1=yes  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This setting is no longer used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DIM_SCREEN
						/// </java-name>
						[Dot42.DexImport("DIM_SCREEN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIM_SCREEN = "dim_screen";
						/// <summary>
						///  <para>The timeout before the screen turns off. </para>        
						/// </summary>
						/// <java-name>
						/// SCREEN_OFF_TIMEOUT
						/// </java-name>
						[Dot42.DexImport("SCREEN_OFF_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCREEN_OFF_TIMEOUT = "screen_off_timeout";
						/// <summary>
						///  <para>The screen backlight brightness between 0 and 255. </para>        
						/// </summary>
						/// <java-name>
						/// SCREEN_BRIGHTNESS
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCREEN_BRIGHTNESS = "screen_brightness";
						/// <summary>
						///  <para>Control whether to enable automatic brightness mode. </para>        
						/// </summary>
						/// <java-name>
						/// SCREEN_BRIGHTNESS_MODE
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS_MODE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCREEN_BRIGHTNESS_MODE = "screen_brightness_mode";
						/// <summary>
						///  <para>SCREEN_BRIGHTNESS_MODE value for manual mode. </para>        
						/// </summary>
						/// <java-name>
						/// SCREEN_BRIGHTNESS_MODE_MANUAL
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS_MODE_MANUAL", "I", AccessFlags = 25)]
						public const int SCREEN_BRIGHTNESS_MODE_MANUAL = 0;
						/// <summary>
						///  <para>SCREEN_BRIGHTNESS_MODE value for automatic mode. </para>        
						/// </summary>
						/// <java-name>
						/// SCREEN_BRIGHTNESS_MODE_AUTOMATIC
						/// </java-name>
						[Dot42.DexImport("SCREEN_BRIGHTNESS_MODE_AUTOMATIC", "I", AccessFlags = 25)]
						public const int SCREEN_BRIGHTNESS_MODE_AUTOMATIC = 1;
						/// <summary>
						///  <para>Control whether the process CPU usage meter should be shown.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#SHOW_PROCESSES instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SHOW_PROCESSES
						/// </java-name>
						[Dot42.DexImport("SHOW_PROCESSES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_PROCESSES = "show_processes";
						/// <summary>
						///  <para>If 1, the activity manager will aggressively finish activities and processes as soon as they are no longer needed. If 0, the normal extended lifetime is used.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#ALWAYS_FINISH_ACTIVITIES instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ALWAYS_FINISH_ACTIVITIES
						/// </java-name>
						[Dot42.DexImport("ALWAYS_FINISH_ACTIVITIES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALWAYS_FINISH_ACTIVITIES = "always_finish_activities";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#MODE_RINGER instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// MODE_RINGER
						/// </java-name>
						[Dot42.DexImport("MODE_RINGER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODE_RINGER = "mode_ringer";
						/// <summary>
						///  <para>Determines which streams are affected by ringer mode changes. The stream type's bit should be set to 1 if it should be muted when going into an inaudible ringer mode. </para>        
						/// </summary>
						/// <java-name>
						/// MODE_RINGER_STREAMS_AFFECTED
						/// </java-name>
						[Dot42.DexImport("MODE_RINGER_STREAMS_AFFECTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODE_RINGER_STREAMS_AFFECTED = "mode_ringer_streams_affected";
						/// <summary>
						///  <para>Determines which streams are affected by mute. The stream type's bit should be set to 1 if it should be muted when a mute request is received. </para>        
						/// </summary>
						/// <java-name>
						/// MUTE_STREAMS_AFFECTED
						/// </java-name>
						[Dot42.DexImport("MUTE_STREAMS_AFFECTED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MUTE_STREAMS_AFFECTED = "mute_streams_affected";
						/// <summary>
						///  <para>Whether vibrate is on for different events. This is used internally, changing this value will not change the vibrate. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VIBRATE_ON
						/// </java-name>
						[Dot42.DexImport("VIBRATE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VIBRATE_ON = "vibrate_on";
						/// <summary>
						///  <para>Ringer volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_RING
						/// </java-name>
						[Dot42.DexImport("VOLUME_RING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_RING = "volume_ring";
						/// <summary>
						///  <para>System/notifications volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_SYSTEM
						/// </java-name>
						[Dot42.DexImport("VOLUME_SYSTEM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_SYSTEM = "volume_system";
						/// <summary>
						///  <para>Voice call volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_VOICE
						/// </java-name>
						[Dot42.DexImport("VOLUME_VOICE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_VOICE = "volume_voice";
						/// <summary>
						///  <para>Music/media/gaming volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_MUSIC
						/// </java-name>
						[Dot42.DexImport("VOLUME_MUSIC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_MUSIC = "volume_music";
						/// <summary>
						///  <para>Alarm volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_ALARM
						/// </java-name>
						[Dot42.DexImport("VOLUME_ALARM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_ALARM = "volume_alarm";
						/// <summary>
						///  <para>Notification volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_NOTIFICATION
						/// </java-name>
						[Dot42.DexImport("VOLUME_NOTIFICATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_NOTIFICATION = "volume_notification";
						/// <summary>
						///  <para>Bluetooth Headset volume. This is used internally, changing this value will not change the volume. See AudioManager. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_BLUETOOTH_SCO
						/// </java-name>
						[Dot42.DexImport("VOLUME_BLUETOOTH_SCO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VOLUME_BLUETOOTH_SCO = "volume_bluetooth_sco";
						/// <summary>
						///  <para>The mapping of stream type (integer) to its setting. </para>        
						/// </summary>
						/// <java-name>
						/// VOLUME_SETTINGS
						/// </java-name>
						[Dot42.DexImport("VOLUME_SETTINGS", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] VOLUME_SETTINGS;
						/// <summary>
						///  <para>Appended to various volume related settings to record the previous values before they the settings were affected by a silent/vibrate ringer mode change. </para>        
						/// </summary>
						/// <java-name>
						/// APPEND_FOR_LAST_AUDIBLE
						/// </java-name>
						[Dot42.DexImport("APPEND_FOR_LAST_AUDIBLE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string APPEND_FOR_LAST_AUDIBLE = "_last_audible";
						/// <summary>
						///  <para>Persistent store for the system-wide default ringtone URI. </para> <para>If you need to play the default ringtone at any given time, it is recommended you give DEFAULT_RINGTONE_URI to the media player. It will resolve to the set default ringtone at the time of playing.</para> <para> <para>DEFAULT_RINGTONE_URI </para></para>        
						/// </summary>
						/// <java-name>
						/// RINGTONE
						/// </java-name>
						[Dot42.DexImport("RINGTONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RINGTONE = "ringtone";
						/// <summary>
						///  <para>A Uri that will point to the current default ringtone at any given time. </para> <para>If the current default ringtone is in the DRM provider and the caller does not have permission, the exception will be a FileNotFoundException. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_RINGTONE_URI
						/// </java-name>
						[Dot42.DexImport("DEFAULT_RINGTONE_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DEFAULT_RINGTONE_URI;
						/// <summary>
						///  <para>Persistent store for the system-wide default notification sound.</para> <para> <para>RINGTONE </para> <para>DEFAULT_NOTIFICATION_URI </para></para>        
						/// </summary>
						/// <java-name>
						/// NOTIFICATION_SOUND
						/// </java-name>
						[Dot42.DexImport("NOTIFICATION_SOUND", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NOTIFICATION_SOUND = "notification_sound";
						/// <summary>
						///  <para>A Uri that will point to the current default notification sound at any given time.</para> <para> <para>DEFAULT_RINGTONE_URI </para></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_NOTIFICATION_URI
						/// </java-name>
						[Dot42.DexImport("DEFAULT_NOTIFICATION_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DEFAULT_NOTIFICATION_URI;
						/// <summary>
						///  <para>Persistent store for the system-wide default alarm alert.</para> <para> <para>RINGTONE </para> <para>DEFAULT_ALARM_ALERT_URI </para></para>        
						/// </summary>
						/// <java-name>
						/// ALARM_ALERT
						/// </java-name>
						[Dot42.DexImport("ALARM_ALERT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ALARM_ALERT = "alarm_alert";
						/// <summary>
						///  <para>A Uri that will point to the current default alarm alert at any given time.</para> <para> <para>DEFAULT_ALARM_ALERT_URI </para></para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_ALARM_ALERT_URI
						/// </java-name>
						[Dot42.DexImport("DEFAULT_ALARM_ALERT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri DEFAULT_ALARM_ALERT_URI;
						/// <summary>
						///  <para>Setting to enable Auto Replace (AutoText) in text editors. 1 = On, 0 = Off </para>        
						/// </summary>
						/// <java-name>
						/// TEXT_AUTO_REPLACE
						/// </java-name>
						[Dot42.DexImport("TEXT_AUTO_REPLACE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_AUTO_REPLACE = "auto_replace";
						/// <summary>
						///  <para>Setting to enable Auto Caps in text editors. 1 = On, 0 = Off </para>        
						/// </summary>
						/// <java-name>
						/// TEXT_AUTO_CAPS
						/// </java-name>
						[Dot42.DexImport("TEXT_AUTO_CAPS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_AUTO_CAPS = "auto_caps";
						/// <summary>
						///  <para>Setting to enable Auto Punctuate in text editors. 1 = On, 0 = Off. This feature converts two spaces to a "." and space. </para>        
						/// </summary>
						/// <java-name>
						/// TEXT_AUTO_PUNCTUATE
						/// </java-name>
						[Dot42.DexImport("TEXT_AUTO_PUNCTUATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TEXT_AUTO_PUNCTUATE = "auto_punctuate";
						/// <summary>
						///  <para>Setting to showing password characters in text editors. 1 = On, 0 = Off </para>        
						/// </summary>
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
						/// <summary>
						///  <para>Name of activity to use for wallpaper on the home screen.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WALLPAPER_ACTIVITY
						/// </java-name>
						[Dot42.DexImport("WALLPAPER_ACTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WALLPAPER_ACTIVITY = "wallpaper_activity";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#AUTO_TIME instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// AUTO_TIME
						/// </java-name>
						[Dot42.DexImport("AUTO_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTO_TIME = "auto_time";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#AUTO_TIME_ZONE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// AUTO_TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("AUTO_TIME_ZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTO_TIME_ZONE = "auto_time_zone";
						/// <summary>
						///  <para>Display times as 12 or 24 hours 12 24 </para>        
						/// </summary>
						/// <java-name>
						/// TIME_12_24
						/// </java-name>
						[Dot42.DexImport("TIME_12_24", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TIME_12_24 = "time_12_24";
						/// <summary>
						///  <para>Date format string mm/dd/yyyy dd/mm/yyyy yyyy/mm/dd </para>        
						/// </summary>
						/// <java-name>
						/// DATE_FORMAT
						/// </java-name>
						[Dot42.DexImport("DATE_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATE_FORMAT = "date_format";
						/// <summary>
						///  <para>Whether the setup wizard has been run before (on first boot), or if it still needs to be run.</para> <para>nonzero = it has been run in the past 0 = it has not been run in the past </para>        
						/// </summary>
						/// <java-name>
						/// SETUP_WIZARD_HAS_RUN
						/// </java-name>
						[Dot42.DexImport("SETUP_WIZARD_HAS_RUN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETUP_WIZARD_HAS_RUN = "setup_wizard_has_run";
						/// <summary>
						///  <para>Scaling factor for normal window animations. Setting to 0 will disable window animations.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#WINDOW_ANIMATION_SCALE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WINDOW_ANIMATION_SCALE
						/// </java-name>
						[Dot42.DexImport("WINDOW_ANIMATION_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WINDOW_ANIMATION_SCALE = "window_animation_scale";
						/// <summary>
						///  <para>Scaling factor for activity transition animations. Setting to 0 will disable window animations.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Global#TRANSITION_ANIMATION_SCALE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TRANSITION_ANIMATION_SCALE
						/// </java-name>
						[Dot42.DexImport("TRANSITION_ANIMATION_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TRANSITION_ANIMATION_SCALE = "transition_animation_scale";
						/// <summary>
						///  <para>Control whether the accelerometer will be used to change screen orientation. If 0, it will not be used unless explicitly requested by the application; if 1, it will be used by default unless explicitly disabled by the application. </para>        
						/// </summary>
						/// <java-name>
						/// ACCELEROMETER_ROTATION
						/// </java-name>
						[Dot42.DexImport("ACCELEROMETER_ROTATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCELEROMETER_ROTATION = "accelerometer_rotation";
						/// <summary>
						///  <para>Default screen rotation when no other policy applies. When ACCELEROMETER_ROTATION is zero and no on-screen Activity expresses a preference, this rotation value will be used. Must be one of the Surface rotation constants.</para> <para> <para>Display::getRotation </para></para>        
						/// </summary>
						/// <java-name>
						/// USER_ROTATION
						/// </java-name>
						[Dot42.DexImport("USER_ROTATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USER_ROTATION = "user_rotation";
						/// <summary>
						///  <para>Whether the audible DTMF tones are played by the dialer when dialing. The value is boolean (1 or 0). </para>        
						/// </summary>
						/// <java-name>
						/// DTMF_TONE_WHEN_DIALING
						/// </java-name>
						[Dot42.DexImport("DTMF_TONE_WHEN_DIALING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DTMF_TONE_WHEN_DIALING = "dtmf_tone";
						/// <summary>
						///  <para>Whether the sounds effects (key clicks, lid open ...) are enabled. The value is boolean (1 or 0). </para>        
						/// </summary>
						/// <java-name>
						/// SOUND_EFFECTS_ENABLED
						/// </java-name>
						[Dot42.DexImport("SOUND_EFFECTS_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SOUND_EFFECTS_ENABLED = "sound_effects_enabled";
						/// <summary>
						///  <para>Whether the haptic feedback (long presses, ...) are enabled. The value is boolean (1 or 0). </para>        
						/// </summary>
						/// <java-name>
						/// HAPTIC_FEEDBACK_ENABLED
						/// </java-name>
						[Dot42.DexImport("HAPTIC_FEEDBACK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HAPTIC_FEEDBACK_ENABLED = "haptic_feedback_enabled";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Each application that shows web suggestions should have its own setting for this. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SHOW_WEB_SUGGESTIONS
						/// </java-name>
						[Dot42.DexImport("SHOW_WEB_SUGGESTIONS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SHOW_WEB_SUGGESTIONS = "show_web_suggestions";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#ADB_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ADB_ENABLED
						/// </java-name>
						[Dot42.DexImport("ADB_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ADB_ENABLED = "adb_enabled";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#ANDROID_ID instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ANDROID_ID
						/// </java-name>
						[Dot42.DexImport("ANDROID_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANDROID_ID = "android_id";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#BLUETOOTH_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// BLUETOOTH_ON
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_ON = "bluetooth_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#DATA_ROAMING instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DATA_ROAMING
						/// </java-name>
						[Dot42.DexImport("DATA_ROAMING", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DATA_ROAMING = "data_roaming";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#DEVICE_PROVISIONED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// DEVICE_PROVISIONED
						/// </java-name>
						[Dot42.DexImport("DEVICE_PROVISIONED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEVICE_PROVISIONED = "device_provisioned";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#HTTP_PROXY instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// HTTP_PROXY
						/// </java-name>
						[Dot42.DexImport("HTTP_PROXY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HTTP_PROXY = "http_proxy";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#INSTALL_NON_MARKET_APPS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// INSTALL_NON_MARKET_APPS
						/// </java-name>
						[Dot42.DexImport("INSTALL_NON_MARKET_APPS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INSTALL_NON_MARKET_APPS = "install_non_market_apps";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#LOCATION_PROVIDERS_ALLOWED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCATION_PROVIDERS_ALLOWED
						/// </java-name>
						[Dot42.DexImport("LOCATION_PROVIDERS_ALLOWED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCATION_PROVIDERS_ALLOWED = "location_providers_allowed";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#LOGGING_ID instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOGGING_ID
						/// </java-name>
						[Dot42.DexImport("LOGGING_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOGGING_ID = "logging_id";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#NETWORK_PREFERENCE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NETWORK_PREFERENCE
						/// </java-name>
						[Dot42.DexImport("NETWORK_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NETWORK_PREFERENCE = "network_preference";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#PARENTAL_CONTROL_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PARENTAL_CONTROL_ENABLED
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_ENABLED = "parental_control_enabled";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#PARENTAL_CONTROL_LAST_UPDATE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PARENTAL_CONTROL_LAST_UPDATE
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_LAST_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_LAST_UPDATE = "parental_control_last_update";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#PARENTAL_CONTROL_REDIRECT_URL instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// PARENTAL_CONTROL_REDIRECT_URL
						/// </java-name>
						[Dot42.DexImport("PARENTAL_CONTROL_REDIRECT_URL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PARENTAL_CONTROL_REDIRECT_URL = "parental_control_redirect_url";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#SETTINGS_CLASSNAME instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SETTINGS_CLASSNAME
						/// </java-name>
						[Dot42.DexImport("SETTINGS_CLASSNAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SETTINGS_CLASSNAME = "settings_classname";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#USB_MASS_STORAGE_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// USB_MASS_STORAGE_ENABLED
						/// </java-name>
						[Dot42.DexImport("USB_MASS_STORAGE_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USB_MASS_STORAGE_ENABLED = "usb_mass_storage_enabled";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#USE_GOOGLE_MAIL instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// USE_GOOGLE_MAIL
						/// </java-name>
						[Dot42.DexImport("USE_GOOGLE_MAIL", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USE_GOOGLE_MAIL = "use_google_mail";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_MAX_DHCP_RETRY_COUNT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_MAX_DHCP_RETRY_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_MAX_DHCP_RETRY_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MAX_DHCP_RETRY_COUNT = "wifi_max_dhcp_retry_count";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS = "wifi_mobile_data_transition_wakelock_timeout_ms";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON = "wifi_networks_available_notification_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
						/// </java-name>
						[Dot42.DexImport("WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY = "wifi_networks_available_repeat_delay";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_NUM_OPEN_NETWORKS_KEPT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_NUM_OPEN_NETWORKS_KEPT
						/// </java-name>
						[Dot42.DexImport("WIFI_NUM_OPEN_NETWORKS_KEPT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_NUM_OPEN_NETWORKS_KEPT = "wifi_num_open_networks_kept";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_ON = "wifi_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE = "wifi_watchdog_acceptable_packet_loss_percentage";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_AP_COUNT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_AP_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_AP_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_AP_COUNT = "wifi_watchdog_ap_count";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS = "wifi_watchdog_background_check_delay_ms";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED = "wifi_watchdog_background_check_enabled";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS = "wifi_watchdog_background_check_timeout_ms";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT = "wifi_watchdog_initial_ignored_ping_count";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_MAX_AP_CHECKS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_MAX_AP_CHECKS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_MAX_AP_CHECKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_MAX_AP_CHECKS = "wifi_watchdog_max_ap_checks";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Global#WIFI_WATCHDOG_ON instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_ON
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_ON = "wifi_watchdog_on";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_PING_COUNT instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_PING_COUNT
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_COUNT = "wifi_watchdog_ping_count";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_PING_DELAY_MS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_PING_DELAY_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_DELAY_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_DELAY_MS = "wifi_watchdog_ping_delay_ms";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.provider.Settings.Secure#WIFI_WATCHDOG_PING_TIMEOUT_MS instead </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// WIFI_WATCHDOG_PING_TIMEOUT_MS
						/// </java-name>
						[Dot42.DexImport("WIFI_WATCHDOG_PING_TIMEOUT_MS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WIFI_WATCHDOG_PING_TIMEOUT_MS = "wifi_watchdog_ping_timeout_ms";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public System() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Look up a name in the database. </para>        
						/// </summary>
						/// <returns>
						///  <para>the corresponding value, or null if not present </para>
						/// </returns>
						/// <java-name>
						/// getString
						/// </java-name>
						[Dot42.DexImport("getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 41)]
						public static string GetString(global::Android.Content.ContentResolver resolver, string name) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Store a name/value pair into the database. </para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putString
						/// </java-name>
						[Dot42.DexImport("putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
						public static bool PutString(global::Android.Content.ContentResolver resolver, string name, string value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Construct the content URI for a particular name/value pair, useful for monitoring changes with a ContentObserver. </para>        
						/// </summary>
						/// <returns>
						///  <para>the corresponding content URI, or null if not present </para>
						/// </returns>
						/// <java-name>
						/// getUriFor
						/// </java-name>
						[Dot42.DexImport("getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetUriFor(string name) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single system settings value as an integer. Note that internally setting values are always stored as strings; this function converts the string to an integer for you. The default value will be returned if the setting is not defined or not an integer.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value, or 'def' if it is not defined or not a valid integer. </para>
						/// </returns>
						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver cr, string name, int def) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single system settings value as an integer. Note that internally setting values are always stored as strings; this function converts the string to an integer for you. </para> <para>This version does not take a default value. If the setting has not been set, or the string value is not a number, it throws SettingNotFoundException.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value. </para>
						/// </returns>
						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I", AccessFlags = 9)]
						public static int GetInt(global::Android.Content.ContentResolver cr, string name) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Convenience function for updating a single settings value as an integer. This will either create a new entry in the table if the given name does not exist, or modify the value of the existing row with that name. Note that internally setting values are always stored as strings, so this function converts the given value to a string before storing it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putInt
						/// </java-name>
						[Dot42.DexImport("putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z", AccessFlags = 9)]
						public static bool PutInt(global::Android.Content.ContentResolver cr, string name, int value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single system settings value as a <c>long </c> . Note that internally setting values are always stored as strings; this function converts the string to a <c>long </c> for you. The default value will be returned if the setting is not defined or not a <c>long </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value, or 'def' if it is not defined or not a valid <c>long </c> . </para>
						/// </returns>
						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver cr, string name, long def) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single system settings value as a <c>long </c> . Note that internally setting values are always stored as strings; this function converts the string to a <c>long </c> for you. </para> <para>This version does not take a default value. If the setting has not been set, or the string value is not a number, it throws SettingNotFoundException.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value. </para>
						/// </returns>
						/// <java-name>
						/// getLong
						/// </java-name>
						[Dot42.DexImport("getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J", AccessFlags = 9)]
						public static long GetLong(global::Android.Content.ContentResolver cr, string name) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Convenience function for updating a single settings value as a long integer. This will either create a new entry in the table if the given name does not exist, or modify the value of the existing row with that name. Note that internally setting values are always stored as strings, so this function converts the given value to a string before storing it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putLong
						/// </java-name>
						[Dot42.DexImport("putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z", AccessFlags = 9)]
						public static bool PutLong(global::Android.Content.ContentResolver cr, string name, long value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single system settings value as a floating point number. Note that internally setting values are always stored as strings; this function converts the string to an float for you. The default value will be returned if the setting is not defined or not a valid float.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value, or 'def' if it is not defined or not a valid float. </para>
						/// </returns>
						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver cr, string name, float def) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						///  <para>Convenience function for retrieving a single system settings value as a float. Note that internally setting values are always stored as strings; this function converts the string to a float for you. </para> <para>This version does not take a default value. If the setting has not been set, or the string value is not a number, it throws SettingNotFoundException.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The setting's current value. </para>
						/// </returns>
						/// <java-name>
						/// getFloat
						/// </java-name>
						[Dot42.DexImport("getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F", AccessFlags = 9)]
						public static float GetFloat(global::Android.Content.ContentResolver cr, string name) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						///  <para>Convenience function for updating a single settings value as a floating point number. This will either create a new entry in the table if the given name does not exist, or modify the value of the existing row with that name. Note that internally setting values are always stored as strings, so this function converts the given value to a string before storing it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the value was set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putFloat
						/// </java-name>
						[Dot42.DexImport("putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z", AccessFlags = 9)]
						public static bool PutFloat(global::Android.Content.ContentResolver cr, string name, float value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Convenience function to read all of the current configuration-related settings into a Configuration object.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// getConfiguration
						/// </java-name>
						[Dot42.DexImport("getConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)V", AccessFlags = 9)]
						public static void GetConfiguration(global::Android.Content.ContentResolver cr, global::Android.Content.Res.Configuration outConfig) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Convenience function to write a batch of configuration-related settings from a Configuration object.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the values were set, false on database errors </para>
						/// </returns>
						/// <java-name>
						/// putConfiguration
						/// </java-name>
						[Dot42.DexImport("putConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)Z", AccessFlags = 9)]
						public static bool PutConfiguration(global::Android.Content.ContentResolver cr, global::Android.Content.Res.Configuration config) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para> <ul> <li> <para>Do not use </para></li></ul></para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getShowGTalkServiceStatus
						/// </java-name>
						[Dot42.DexImport("getShowGTalkServiceStatus", "(Landroid/content/ContentResolver;)Z", AccessFlags = 9)]
						public static bool GetShowGTalkServiceStatus(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para> <ul> <li> <para>Do not use </para></li></ul></para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setShowGTalkServiceStatus
						/// </java-name>
						[Dot42.DexImport("setShowGTalkServiceStatus", "(Landroid/content/ContentResolver;Z)V", AccessFlags = 9)]
						public static void SetShowGTalkServiceStatus(global::Android.Content.ContentResolver cr, bool flag) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Common base for tables of name/value settings. </para>    
				/// </summary>
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
						protected internal static bool PutString(global::Android.Content.ContentResolver resolver, global::Android.Net.Uri uri, string name, string value) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getUriFor
						/// </java-name>
						[Dot42.DexImport("getUriFor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri GetUriFor(global::Android.Net.Uri uri, string name) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>The ContentProvider contract for associating data with ana data array account. This may be used by providers that want to store this data in a standard way. </para>    
		/// </summary>
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

						/// <summary>
						///  <para>Get the sync state that is associated with the account or null. </para>        
						/// </summary>
						/// <returns>
						///  <para>the sync state or null if there is no sync state associated with the account </para>
						/// </returns>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)[B", AccessFlags = 9)]
						public static sbyte[] JavaGet(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						/// <summary>
						///  <para>Get the sync state that is associated with the account or null. </para>        
						/// </summary>
						/// <returns>
						///  <para>the sync state or null if there is no sync state associated with the account </para>
						/// </returns>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)[B", AccessFlags = 9, IgnoreFromJava = true)]
						public static byte[] Get(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(byte[]);
						}

						/// <summary>
						///  <para>Assigns the data array as the sync state for the given account. </para>        
						/// </summary>
						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)V", AccessFlags = 9)]
						public static void Set(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account, sbyte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Assigns the data array as the sync state for the given account. </para>        
						/// </summary>
						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Set(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account, byte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// insert
						/// </java-name>
						[Dot42.DexImport("insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)Landroid/net/Uri;", AccessFlags = 9)]
						public static global::Android.Net.Uri Insert(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account, sbyte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// insert
						/// </java-name>
						[Dot42.DexImport("insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;[B)Landroid/net/Uri;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Net.Uri Insert(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account, byte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// update
						/// </java-name>
						[Dot42.DexImport("update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V", AccessFlags = 9)]
						public static void Update(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, sbyte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// update
						/// </java-name>
						[Dot42.DexImport("update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V", AccessFlags = 9, IgnoreFromJava = true)]
						public static void Update(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, byte[] data) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getWithUri
						/// </java-name>
						[Dot42.DexImport("getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)Landroid/util/Pair;", AccessFlags = 9, Signature = "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Accoun" +
    "t;)Landroid/util/Pair<Landroid/net/Uri;[B>;")]
						public static global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]> GetWithUri(global::Android.Content.ContentProviderClient provider, global::Android.Net.Uri uri, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Util.Pair<global::Android.Net.Uri, sbyte[]>);
						}

						/// <summary>
						///  <para>Creates and returns a ContentProviderOperation that assigns the data array as the sync state for the given account. </para>        
						/// </summary>
						/// <returns>
						///  <para>the new ContentProviderOperation that assigns the data array as the account's sync state </para>
						/// </returns>
						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOp" +
    "eration;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Net.Uri uri, global::Android.Accounts.Account account, sbyte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <summary>
						///  <para>Creates and returns a ContentProviderOperation that assigns the data array as the sync state for the given account. </para>        
						/// </summary>
						/// <returns>
						///  <para>the new ContentProviderOperation that assigns the data array as the account's sync state </para>
						/// </returns>
						/// <java-name>
						/// newSetOperation
						/// </java-name>
						[Dot42.DexImport("newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOp" +
    "eration;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewSetOperation(global::Android.Net.Uri uri, global::Android.Accounts.Account account, byte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <summary>
						///  <para>Creates and returns a ContentProviderOperation that assigns the data array as the sync state for the given account. </para>        
						/// </summary>
						/// <returns>
						///  <para>the new ContentProviderOperation that assigns the data array as the account's sync state </para>
						/// </returns>
						/// <java-name>
						/// newUpdateOperation
						/// </java-name>
						[Dot42.DexImport("newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9)]
						public static global::Android.Content.ContentProviderOperation NewUpdateOperation(global::Android.Net.Uri uri, sbyte[] data) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <summary>
						///  <para>Creates and returns a ContentProviderOperation that assigns the data array as the sync state for the given account. </para>        
						/// </summary>
						/// <returns>
						///  <para>the new ContentProviderOperation that assigns the data array as the account's sync state </para>
						/// </returns>
						/// <java-name>
						/// newUpdateOperation
						/// </java-name>
						[Dot42.DexImport("newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;", AccessFlags = 9, IgnoreFromJava = true)]
						public static global::Android.Content.ContentProviderOperation NewUpdateOperation(global::Android.Net.Uri uri, byte[] data) /* MethodBuilder.Create */ 
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
						/// <summary>
						///  <para>A reference to the name of the account to which this data belongs </para> <para>Type: STRING</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_NAME
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_NAME = "account_name";
						/// <summary>
						///  <para>A reference to the type of the account to which this data belongs </para> <para>Type: STRING</para>        
						/// </summary>
						/// <java-name>
						/// ACCOUNT_TYPE
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_TYPE = "account_type";
						/// <summary>
						///  <para>The sync data associated with this account. </para> <para>Type: NONE</para>        
						/// </summary>
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

		/// <summary>
		///  <para>A provider of user defined words for input methods to use for predictive text input. Applications and input methods may add words into the dictionary. Words can have associated frequency information and locale information. </para>    
		/// </summary>
		/// <java-name>
		/// android/provider/UserDictionary
		/// </java-name>
		[Dot42.DexImport("android/provider/UserDictionary", AccessFlags = 33)]
		public partial class UserDictionary
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Authority string for this provider. </para>        
				/// </summary>
				/// <java-name>
				/// AUTHORITY
				/// </java-name>
				[Dot42.DexImport("AUTHORITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHORITY = "user_dictionary";
				/// <summary>
				///  <para>The content:// style URL for this provider </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_URI
				/// </java-name>
				[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri CONTENT_URI;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UserDictionary() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Contains the user defined words. </para>    
				/// </summary>
				/// <java-name>
				/// android/provider/UserDictionary$Words
				/// </java-name>
				[Dot42.DexImport("android/provider/UserDictionary$Words", AccessFlags = 9)]
				public partial class Words : global::Android.Provider.IBaseColumns
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The content:// style URL for this table </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_URI
						/// </java-name>
						[Dot42.DexImport("CONTENT_URI", "Landroid/net/Uri;", AccessFlags = 25)]
						public static readonly global::Android.Net.Uri CONTENT_URI;
						/// <summary>
						///  <para>The MIME type of CONTENT_URI providing a directory of words. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTENT_TYPE = "vnd.android.cursor.dir/vnd.google.userword";
						/// <summary>
						///  <para>The MIME type of a CONTENT_URI sub-directory of a single word. </para>        
						/// </summary>
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
						/// <summary>
						///  <para>The word column. </para> <para>TYPE: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// WORD
						/// </java-name>
						[Dot42.DexImport("WORD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WORD = "word";
						/// <summary>
						///  <para>The frequency column. A value between 1 and 255. Higher values imply higher frequency. </para> <para>TYPE: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// FREQUENCY
						/// </java-name>
						[Dot42.DexImport("FREQUENCY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FREQUENCY = "frequency";
						/// <summary>
						///  <para>The locale that this word belongs to. Null if it pertains to all locales. Locale is as defined by the string returned by Locale.toString(). </para> <para>TYPE: TEXT</para>        
						/// </summary>
						/// <java-name>
						/// LOCALE
						/// </java-name>
						[Dot42.DexImport("LOCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCALE = "locale";
						/// <summary>
						///  <para>The uid of the application that inserted the word. </para> <para>TYPE: INTEGER</para>        
						/// </summary>
						/// <java-name>
						/// APP_ID
						/// </java-name>
						[Dot42.DexImport("APP_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string APP_ID = "appid";
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use addWord(Context, String, int, String, Locale). </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCALE_TYPE_ALL
						/// </java-name>
						[Dot42.DexImport("LOCALE_TYPE_ALL", "I", AccessFlags = 25)]
						public const int LOCALE_TYPE_ALL = 0;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use addWord(Context, String, int, String, Locale). </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// LOCALE_TYPE_CURRENT
						/// </java-name>
						[Dot42.DexImport("LOCALE_TYPE_CURRENT", "I", AccessFlags = 25)]
						public const int LOCALE_TYPE_CURRENT = 1;
						/// <summary>
						///  <para>Sort by descending order of frequency. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_SORT_ORDER
						/// </java-name>
						[Dot42.DexImport("DEFAULT_SORT_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFAULT_SORT_ORDER = "frequency DESC";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Words() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Adds a word to the dictionary, with the given frequency and the specified specified locale type.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Please use addWord(Context, String, int, String, Locale) instead.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// addWord
						/// </java-name>
						[Dot42.DexImport("addWord", "(Landroid/content/Context;Ljava/lang/String;II)V", AccessFlags = 9)]
						public static void AddWord(global::Android.Content.Context context, string word, int frequency, int localeType) /* MethodBuilder.Create */ 
						{
						}

				}

		}

}

