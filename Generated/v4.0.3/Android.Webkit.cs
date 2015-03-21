#pragma warning disable 1717
namespace Android.Webkit
{
		/// <java-name>
		/// android/webkit/CacheManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/CacheManager", AccessFlags = 49)]
		public sealed partial class CacheManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CacheManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCacheFileBaseDir
				/// </java-name>
				[Dot42.DexImport("getCacheFileBaseDir", "()Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.Io.File GetCacheFileBaseDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// cacheDisabled
				/// </java-name>
				[Dot42.DexImport("cacheDisabled", "()Z", AccessFlags = 9)]
				public static bool CacheDisabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startCacheTransaction
				/// </java-name>
				[Dot42.DexImport("startCacheTransaction", "()Z", AccessFlags = 9)]
				public static bool StartCacheTransaction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// endCacheTransaction
				/// </java-name>
				[Dot42.DexImport("endCacheTransaction", "()Z", AccessFlags = 9)]
				public static bool EndCacheTransaction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCacheFile
				/// </java-name>
				[Dot42.DexImport("getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Landroid" +
    "/webkit/CacheManager$CacheResult;")]
				public static global::Android.Webkit.CacheManager.CacheResult GetCacheFile(string @string, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CacheManager.CacheResult);
				}

				/// <java-name>
				/// saveCacheFile
				/// </java-name>
				[Dot42.DexImport("saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V", AccessFlags = 9)]
				public static void SaveCacheFile(string @string, global::Android.Webkit.CacheManager.CacheResult cacheResult) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCacheFileBaseDir
				/// </java-name>
				public static global::Java.Io.File CacheFileBaseDir
				{
				[Dot42.DexImport("getCacheFileBaseDir", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return GetCacheFileBaseDir(); }
				}

				/// <java-name>
				/// android/webkit/CacheManager$CacheResult
				/// </java-name>
				[Dot42.DexImport("android/webkit/CacheManager$CacheResult", AccessFlags = 9)]
				public partial class CacheResult
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CacheResult() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getHttpStatusCode
						/// </java-name>
						[Dot42.DexImport("getHttpStatusCode", "()I", AccessFlags = 1)]
						public virtual int GetHttpStatusCode() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getContentLength
						/// </java-name>
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						public virtual long GetContentLength() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getLocalPath
						/// </java-name>
						[Dot42.DexImport("getLocalPath", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLocalPath() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getExpires
						/// </java-name>
						[Dot42.DexImport("getExpires", "()J", AccessFlags = 1)]
						public virtual long GetExpires() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getExpiresString
						/// </java-name>
						[Dot42.DexImport("getExpiresString", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetExpiresString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getLastModified
						/// </java-name>
						[Dot42.DexImport("getLastModified", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLastModified() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getETag
						/// </java-name>
						[Dot42.DexImport("getETag", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetETag() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getMimeType
						/// </java-name>
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetMimeType() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getLocation
						/// </java-name>
						[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLocation() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getEncoding
						/// </java-name>
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetEncoding() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getContentDisposition
						/// </java-name>
						[Dot42.DexImport("getContentDisposition", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetContentDisposition() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getInputStream
						/// </java-name>
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.InputStream);
						}

						/// <java-name>
						/// getOutputStream
						/// </java-name>
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.OutputStream);
						}

						/// <java-name>
						/// setInputStream
						/// </java-name>
						[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						public virtual void SetInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setEncoding
						/// </java-name>
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetEncoding(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getHttpStatusCode
						/// </java-name>
						public int HttpStatusCode
						{
						[Dot42.DexImport("getHttpStatusCode", "()I", AccessFlags = 1)]
								get{ return GetHttpStatusCode(); }
						}

						/// <java-name>
						/// getContentLength
						/// </java-name>
						public long ContentLength
						{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
								get{ return GetContentLength(); }
						}

						/// <java-name>
						/// getLocalPath
						/// </java-name>
						public string LocalPath
						{
						[Dot42.DexImport("getLocalPath", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLocalPath(); }
						}

						/// <java-name>
						/// getExpires
						/// </java-name>
						public long Expires
						{
						[Dot42.DexImport("getExpires", "()J", AccessFlags = 1)]
								get{ return GetExpires(); }
						}

						/// <java-name>
						/// getExpiresString
						/// </java-name>
						public string ExpiresString
						{
						[Dot42.DexImport("getExpiresString", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetExpiresString(); }
						}

						/// <java-name>
						/// getLastModified
						/// </java-name>
						public string LastModified
						{
						[Dot42.DexImport("getLastModified", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLastModified(); }
						}

						/// <java-name>
						/// getETag
						/// </java-name>
						public string ETag
						{
						[Dot42.DexImport("getETag", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetETag(); }
						}

						/// <java-name>
						/// getMimeType
						/// </java-name>
						public string MimeType
						{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetMimeType(); }
						}

						/// <java-name>
						/// getLocation
						/// </java-name>
						public string Location
						{
						[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLocation(); }
						}

						/// <java-name>
						/// getEncoding
						/// </java-name>
						public string Encoding
						{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetEncoding(); }
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetEncoding(value); }
						}

						/// <java-name>
						/// getContentDisposition
						/// </java-name>
						public string ContentDisposition
						{
						[Dot42.DexImport("getContentDisposition", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetContentDisposition(); }
						}

						/// <java-name>
						/// getInputStream
						/// </java-name>
						public global::Java.Io.InputStream InputStream
						{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
								get{ return GetInputStream(); }
						[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
								set{ SetInputStream(value); }
						}

						/// <java-name>
						/// getOutputStream
						/// </java-name>
						public global::Java.Io.OutputStream OutputStream
						{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
								get{ return GetOutputStream(); }
						}

				}

		}

		/// <java-name>
		/// android/webkit/ConsoleMessage
		/// </java-name>
		[Dot42.DexImport("android/webkit/ConsoleMessage", AccessFlags = 33)]
		public partial class ConsoleMessage
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILandroid/webkit/ConsoleMessage$MessageLevel" +
    ";)V", AccessFlags = 1)]
				public ConsoleMessage(string @string, string string1, int int32, global::Android.Webkit.ConsoleMessage.JavaMessageLevel messageLevel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// messageLevel
				/// </java-name>
				[Dot42.DexImport("messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 1)]
				public virtual global::Android.Webkit.ConsoleMessage.JavaMessageLevel MessageLevel() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.ConsoleMessage.JavaMessageLevel);
				}

				/// <java-name>
				/// message
				/// </java-name>
				[Dot42.DexImport("message", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Message() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// sourceId
				/// </java-name>
				[Dot42.DexImport("sourceId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string SourceId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// lineNumber
				/// </java-name>
				[Dot42.DexImport("lineNumber", "()I", AccessFlags = 1)]
				public virtual int LineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConsoleMessage() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/webkit/ConsoleMessage$MessageLevel
				/// </java-name>
				[Dot42.DexImport("android/webkit/ConsoleMessage$MessageLevel", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/ConsoleMessage$MessageLevel;>;")]
				public sealed class JavaMessageLevel
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEBUG
						/// </java-name>
						[Dot42.DexImport("DEBUG", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel DEBUG;
						/// <java-name>
						/// ERROR
						/// </java-name>
						[Dot42.DexImport("ERROR", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel ERROR;
						/// <java-name>
						/// LOG
						/// </java-name>
						[Dot42.DexImport("LOG", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel LOG;
						/// <java-name>
						/// TIP
						/// </java-name>
						[Dot42.DexImport("TIP", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel TIP;
						/// <java-name>
						/// WARNING
						/// </java-name>
						[Dot42.DexImport("WARNING", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel WARNING;
						private JavaMessageLevel() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 9)]
						public static JavaMessageLevel[] Values() /* MethodBuilder.Create */ 
						{
								return default(JavaMessageLevel[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 9)]
						public static JavaMessageLevel ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(JavaMessageLevel);
						}

				}

		}

		/// <java-name>
		/// android/webkit/CookieManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/CookieManager", AccessFlags = 49)]
		public sealed partial class CookieManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CookieManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				internal object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieManager;", AccessFlags = 41)]
				public static global::Android.Webkit.CookieManager GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CookieManager);
				}

				/// <java-name>
				/// setAcceptCookie
				/// </java-name>
				[Dot42.DexImport("setAcceptCookie", "(Z)V", AccessFlags = 33)]
				public void SetAcceptCookie(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acceptCookie
				/// </java-name>
				[Dot42.DexImport("acceptCookie", "()Z", AccessFlags = 33)]
				public bool AcceptCookie() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setCookie
				/// </java-name>
				[Dot42.DexImport("setCookie", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetCookie(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookie
				/// </java-name>
				[Dot42.DexImport("getCookie", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetCookie(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// removeSessionCookie
				/// </java-name>
				[Dot42.DexImport("removeSessionCookie", "()V", AccessFlags = 1)]
				public void RemoveSessionCookie() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllCookie
				/// </java-name>
				[Dot42.DexImport("removeAllCookie", "()V", AccessFlags = 1)]
				public void RemoveAllCookie() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasCookies
				/// </java-name>
				[Dot42.DexImport("hasCookies", "()Z", AccessFlags = 33)]
				public bool HasCookies() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeExpiredCookie
				/// </java-name>
				[Dot42.DexImport("removeExpiredCookie", "()V", AccessFlags = 1)]
				public void RemoveExpiredCookie() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allowFileSchemeCookies
				/// </java-name>
				[Dot42.DexImport("allowFileSchemeCookies", "()Z", AccessFlags = 9)]
				public static bool AllowFileSchemeCookies() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAcceptFileSchemeCookies
				/// </java-name>
				[Dot42.DexImport("setAcceptFileSchemeCookies", "(Z)V", AccessFlags = 9)]
				public static void SetAcceptFileSchemeCookies(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.CookieManager Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieManager;", AccessFlags = 41)]
						get{ return GetInstance(); }
				}

		}

		/// <java-name>
		/// android/webkit/CookieSyncManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/CookieSyncManager", AccessFlags = 49)]
		public sealed partial class CookieSyncManager : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CookieSyncManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieSyncManager;", AccessFlags = 41)]
				public static global::Android.Webkit.CookieSyncManager GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CookieSyncManager);
				}

				/// <java-name>
				/// createInstance
				/// </java-name>
				[Dot42.DexImport("createInstance", "(Landroid/content/Context;)Landroid/webkit/CookieSyncManager;", AccessFlags = 41)]
				public static global::Android.Webkit.CookieSyncManager CreateInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CookieSyncManager);
				}

				/// <java-name>
				/// syncFromRamToFlash
				/// </java-name>
				[Dot42.DexImport("syncFromRamToFlash", "()V", AccessFlags = 4)]
				internal void SyncFromRamToFlash() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				internal object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public void Sync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetSync
				/// </java-name>
				[Dot42.DexImport("resetSync", "()V", AccessFlags = 1)]
				public void ResetSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startSync
				/// </java-name>
				[Dot42.DexImport("startSync", "()V", AccessFlags = 1)]
				public void StartSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSync
				/// </java-name>
				[Dot42.DexImport("stopSync", "()V", AccessFlags = 1)]
				public void StopSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSyncInit
				/// </java-name>
				[Dot42.DexImport("onSyncInit", "()V", AccessFlags = 4)]
				internal void OnSyncInit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.CookieSyncManager Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieSyncManager;", AccessFlags = 41)]
						get{ return GetInstance(); }
				}

		}

		/// <java-name>
		/// android/webkit/DateSorter
		/// </java-name>
		[Dot42.DexImport("android/webkit/DateSorter", AccessFlags = 33)]
		public partial class DateSorter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DAY_COUNT
				/// </java-name>
				[Dot42.DexImport("DAY_COUNT", "I", AccessFlags = 25)]
				public const int DAY_COUNT = 5;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DateSorter(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(J)I", AccessFlags = 1)]
				public virtual int GetIndex(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLabel
				/// </java-name>
				[Dot42.DexImport("getLabel", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLabel(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getBoundary
				/// </java-name>
				[Dot42.DexImport("getBoundary", "(I)J", AccessFlags = 1)]
				public virtual long GetBoundary(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DateSorter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/GeolocationPermissions
		/// </java-name>
		[Dot42.DexImport("android/webkit/GeolocationPermissions", AccessFlags = 49)]
		public sealed partial class GeolocationPermissions
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeolocationPermissions() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/GeolocationPermissions;", AccessFlags = 9)]
				public static global::Android.Webkit.GeolocationPermissions GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.GeolocationPermissions);
				}

				/// <java-name>
				/// getOrigins
				/// </java-name>
				[Dot42.DexImport("getOrigins", "(Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Landroid/webkit/ValueCallback<Ljava/util/Set<Ljava/lang/String;>;>;)V")]
				public void GetOrigins(global::Android.Webkit.IValueCallback<global::Java.Util.ISet<string>> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllowed
				/// </java-name>
				[Dot42.DexImport("getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/webkit/ValueCallback<Ljava/lang/Boolean;>;)V")]
				public void GetAllowed(string @string, global::Android.Webkit.IValueCallback<bool?> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Clear(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allow
				/// </java-name>
				[Dot42.DexImport("allow", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Allow(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearAll
				/// </java-name>
				[Dot42.DexImport("clearAll", "()V", AccessFlags = 1)]
				public void ClearAll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.GeolocationPermissions Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/GeolocationPermissions;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <java-name>
				/// android/webkit/GeolocationPermissions$Callback
				/// </java-name>
				[Dot42.DexImport("android/webkit/GeolocationPermissions$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// invoke
						/// </java-name>
						[Dot42.DexImport("invoke", "(Ljava/lang/String;ZZ)V", AccessFlags = 1025)]
						void Invoke(string @string, bool boolean, bool boolean1) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/webkit/HttpAuthHandler
		/// </java-name>
		[Dot42.DexImport("android/webkit/HttpAuthHandler", AccessFlags = 33)]
		public partial class HttpAuthHandler : global::Android.Os.Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpAuthHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// useHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("useHttpAuthUsernamePassword", "()Z", AccessFlags = 1)]
				public virtual bool UseHttpAuthUsernamePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// proceed
				/// </java-name>
				[Dot42.DexImport("proceed", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Proceed(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/DownloadListener
		/// </java-name>
		[Dot42.DexImport("android/webkit/DownloadListener", AccessFlags = 1537)]
		public partial interface IDownloadListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onDownloadStart
				/// </java-name>
				[Dot42.DexImport("onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", AccessFlags = 1025)]
				void OnDownloadStart(string @string, string string1, string string2, string string3, long int64) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/webkit/PluginStub
		/// </java-name>
		[Dot42.DexImport("android/webkit/PluginStub", AccessFlags = 1537)]
		public partial interface IPluginStub
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getEmbeddedView
				/// </java-name>
				[Dot42.DexImport("getEmbeddedView", "(ILandroid/content/Context;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.View.View GetEmbeddedView(int int32, global::Android.Content.Context context) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFullScreenView
				/// </java-name>
				[Dot42.DexImport("getFullScreenView", "(ILandroid/content/Context;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.View.View GetFullScreenView(int int32, global::Android.Content.Context context) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/webkit/ValueCallback
		/// </java-name>
		[Dot42.DexImport("android/webkit/ValueCallback", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IValueCallback<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onReceiveValue
				/// </java-name>
				[Dot42.DexImport("onReceiveValue", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TT;)V")]
				void OnReceiveValue(T t) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/webkit/JsPromptResult
		/// </java-name>
		[Dot42.DexImport("android/webkit/JsPromptResult", AccessFlags = 33)]
		public partial class JsPromptResult : global::Android.Webkit.JsResult
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JsPromptResult() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// confirm
				/// </java-name>
				[Dot42.DexImport("confirm", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Confirm(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/JsResult
		/// </java-name>
		[Dot42.DexImport("android/webkit/JsResult", AccessFlags = 33)]
		public partial class JsResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mResult
				/// </java-name>
				[Dot42.DexImport("mResult", "Z", AccessFlags = 4)]
				protected internal bool MResult;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JsResult() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 17)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// confirm
				/// </java-name>
				[Dot42.DexImport("confirm", "()V", AccessFlags = 17)]
				public void Confirm() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wakeUp
				/// </java-name>
				[Dot42.DexImport("wakeUp", "()V", AccessFlags = 20)]
				protected internal void WakeUp() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/MimeTypeMap
		/// </java-name>
		[Dot42.DexImport("android/webkit/MimeTypeMap", AccessFlags = 33)]
		public partial class MimeTypeMap
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MimeTypeMap() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFileExtensionFromUrl
				/// </java-name>
				[Dot42.DexImport("getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetFileExtensionFromUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasMimeType
				/// </java-name>
				[Dot42.DexImport("hasMimeType", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasMimeType(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMimeTypeFromExtension
				/// </java-name>
				[Dot42.DexImport("getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeTypeFromExtension(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasExtension
				/// </java-name>
				[Dot42.DexImport("hasExtension", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasExtension(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getExtensionFromMimeType
				/// </java-name>
				[Dot42.DexImport("getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetExtensionFromMimeType(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSingleton
				/// </java-name>
				[Dot42.DexImport("getSingleton", "()Landroid/webkit/MimeTypeMap;", AccessFlags = 9)]
				public static global::Android.Webkit.MimeTypeMap GetSingleton() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.MimeTypeMap);
				}

				/// <java-name>
				/// getSingleton
				/// </java-name>
				public static global::Android.Webkit.MimeTypeMap Singleton
				{
				[Dot42.DexImport("getSingleton", "()Landroid/webkit/MimeTypeMap;", AccessFlags = 9)]
						get{ return GetSingleton(); }
				}

		}

		/// <java-name>
		/// android/webkit/SslErrorHandler
		/// </java-name>
		[Dot42.DexImport("android/webkit/SslErrorHandler", AccessFlags = 33)]
		public partial class SslErrorHandler : global::Android.Os.Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SslErrorHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// proceed
				/// </java-name>
				[Dot42.DexImport("proceed", "()V", AccessFlags = 1)]
				public virtual void Proceed() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/URLUtil
		/// </java-name>
		[Dot42.DexImport("android/webkit/URLUtil", AccessFlags = 49)]
		public sealed partial class URLUtil
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLUtil() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// guessUrl
				/// </java-name>
				[Dot42.DexImport("guessUrl", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GuessUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// composeSearchUrl
				/// </java-name>
				[Dot42.DexImport("composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ComposeSearchUrl(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([B)[B", AccessFlags = 9)]
				public static sbyte[] Decode(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([B)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// isAssetUrl
				/// </java-name>
				[Dot42.DexImport("isAssetUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsAssetUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCookielessProxyUrl
				/// </java-name>
				[Dot42.DexImport("isCookielessProxyUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsCookielessProxyUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFileUrl
				/// </java-name>
				[Dot42.DexImport("isFileUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsFileUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAboutUrl
				/// </java-name>
				[Dot42.DexImport("isAboutUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsAboutUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDataUrl
				/// </java-name>
				[Dot42.DexImport("isDataUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsDataUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaScriptUrl
				/// </java-name>
				[Dot42.DexImport("isJavaScriptUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsJavaScriptUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHttpUrl
				/// </java-name>
				[Dot42.DexImport("isHttpUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsHttpUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHttpsUrl
				/// </java-name>
				[Dot42.DexImport("isHttpsUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsHttpsUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNetworkUrl
				/// </java-name>
				[Dot42.DexImport("isNetworkUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsNetworkUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isContentUrl
				/// </java-name>
				[Dot42.DexImport("isContentUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsContentUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isValidUrl
				/// </java-name>
				[Dot42.DexImport("isValidUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsValidUrl(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stripAnchor
				/// </java-name>
				[Dot42.DexImport("stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string StripAnchor(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// guessFileName
				/// </java-name>
				[Dot42.DexImport("guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 25)]
				public static string GuessFileName(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/webkit/WebBackForwardList
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebBackForwardList", AccessFlags = 33)]
		public partial class WebBackForwardList : global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebBackForwardList() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentItem
				/// </java-name>
				[Dot42.DexImport("getCurrentItem", "()Landroid/webkit/WebHistoryItem;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebHistoryItem GetCurrentItem() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebHistoryItem);
				}

				/// <java-name>
				/// getCurrentIndex
				/// </java-name>
				[Dot42.DexImport("getCurrentIndex", "()I", AccessFlags = 33)]
				public virtual int GetCurrentIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getItemAtIndex
				/// </java-name>
				[Dot42.DexImport("getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebHistoryItem GetItemAtIndex(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebHistoryItem);
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "()I", AccessFlags = 33)]
				public virtual int GetSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/webkit/WebBackForwardList;", AccessFlags = 36)]
				protected internal virtual global::Android.Webkit.WebBackForwardList Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <java-name>
				/// getCurrentItem
				/// </java-name>
				public global::Android.Webkit.WebHistoryItem CurrentItem
				{
				[Dot42.DexImport("getCurrentItem", "()Landroid/webkit/WebHistoryItem;", AccessFlags = 33)]
						get{ return GetCurrentItem(); }
				}

				/// <java-name>
				/// getCurrentIndex
				/// </java-name>
				public int CurrentIndex
				{
				[Dot42.DexImport("getCurrentIndex", "()I", AccessFlags = 33)]
						get{ return GetCurrentIndex(); }
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				public int Size
				{
				[Dot42.DexImport("getSize", "()I", AccessFlags = 33)]
						get{ return GetSize(); }
				}

		}

		/// <java-name>
		/// android/webkit/WebChromeClient
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebChromeClient", AccessFlags = 33)]
		public partial class WebChromeClient
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebChromeClient() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onProgressChanged
				/// </java-name>
				[Dot42.DexImport("onProgressChanged", "(Landroid/webkit/WebView;I)V", AccessFlags = 1)]
				public virtual void OnProgressChanged(global::Android.Webkit.WebView webView, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedTitle
				/// </java-name>
				[Dot42.DexImport("onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnReceivedTitle(global::Android.Webkit.WebView webView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedIcon
				/// </java-name>
				[Dot42.DexImport("onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void OnReceivedIcon(global::Android.Webkit.WebView webView, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedTouchIconUrl
				/// </java-name>
				[Dot42.DexImport("onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void OnReceivedTouchIconUrl(global::Android.Webkit.WebView webView, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onShowCustomView
				/// </java-name>
				[Dot42.DexImport("onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V", AccessFlags = 1)]
				public virtual void OnShowCustomView(global::Android.View.View view, global::Android.Webkit.WebChromeClient.ICustomViewCallback customViewCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onShowCustomView
				/// </java-name>
				[Dot42.DexImport("onShowCustomView", "(Landroid/view/View;ILandroid/webkit/WebChromeClient$CustomViewCallback;)V", AccessFlags = 1)]
				public virtual void OnShowCustomView(global::Android.View.View view, int int32, global::Android.Webkit.WebChromeClient.ICustomViewCallback customViewCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onHideCustomView
				/// </java-name>
				[Dot42.DexImport("onHideCustomView", "()V", AccessFlags = 1)]
				public virtual void OnHideCustomView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateWindow
				/// </java-name>
				[Dot42.DexImport("onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z", AccessFlags = 1)]
				public virtual bool OnCreateWindow(global::Android.Webkit.WebView webView, bool boolean, bool boolean1, global::Android.Os.Message message) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRequestFocus
				/// </java-name>
				[Dot42.DexImport("onRequestFocus", "(Landroid/webkit/WebView;)V", AccessFlags = 1)]
				public virtual void OnRequestFocus(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCloseWindow
				/// </java-name>
				[Dot42.DexImport("onCloseWindow", "(Landroid/webkit/WebView;)V", AccessFlags = 1)]
				public virtual void OnCloseWindow(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onJsAlert
				/// </java-name>
				[Dot42.DexImport("onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsRe" +
    "sult;)Z", AccessFlags = 1)]
				public virtual bool OnJsAlert(global::Android.Webkit.WebView webView, string @string, string string1, global::Android.Webkit.JsResult jsResult) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onJsConfirm
				/// </java-name>
				[Dot42.DexImport("onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsRe" +
    "sult;)Z", AccessFlags = 1)]
				public virtual bool OnJsConfirm(global::Android.Webkit.WebView webView, string @string, string string1, global::Android.Webkit.JsResult jsResult) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onJsPrompt
				/// </java-name>
				[Dot42.DexImport("onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;La" +
    "ndroid/webkit/JsPromptResult;)Z", AccessFlags = 1)]
				public virtual bool OnJsPrompt(global::Android.Webkit.WebView webView, string @string, string string1, string string2, global::Android.Webkit.JsPromptResult jsPromptResult) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onJsBeforeUnload
				/// </java-name>
				[Dot42.DexImport("onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsRe" +
    "sult;)Z", AccessFlags = 1)]
				public virtual bool OnJsBeforeUnload(global::Android.Webkit.WebView webView, string @string, string string1, global::Android.Webkit.JsResult jsResult) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onExceededDatabaseQuota
				/// </java-name>
				[Dot42.DexImport("onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)" +
    "V", AccessFlags = 1)]
				public virtual void OnExceededDatabaseQuota(string @string, string string1, long int64, long int641, long int642, global::Android.Webkit.WebStorage.IQuotaUpdater quotaUpdater) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReachedMaxAppCacheSize
				/// </java-name>
				[Dot42.DexImport("onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V", AccessFlags = 1)]
				public virtual void OnReachedMaxAppCacheSize(long int64, long int641, global::Android.Webkit.WebStorage.IQuotaUpdater quotaUpdater) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGeolocationPermissionsShowPrompt
				/// </java-name>
				[Dot42.DexImport("onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V", AccessFlags = 1)]
				public virtual void OnGeolocationPermissionsShowPrompt(string @string, global::Android.Webkit.GeolocationPermissions.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGeolocationPermissionsHidePrompt
				/// </java-name>
				[Dot42.DexImport("onGeolocationPermissionsHidePrompt", "()V", AccessFlags = 1)]
				public virtual void OnGeolocationPermissionsHidePrompt() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onJsTimeout
				/// </java-name>
				[Dot42.DexImport("onJsTimeout", "()Z", AccessFlags = 1)]
				public virtual bool OnJsTimeout() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onConsoleMessage
				/// </java-name>
				[Dot42.DexImport("onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnConsoleMessage(string @string, int int32, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConsoleMessage
				/// </java-name>
				[Dot42.DexImport("onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", AccessFlags = 1)]
				public virtual bool OnConsoleMessage(global::Android.Webkit.ConsoleMessage consoleMessage) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultVideoPoster
				/// </java-name>
				[Dot42.DexImport("getDefaultVideoPoster", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetDefaultVideoPoster() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getVideoLoadingProgressView
				/// </java-name>
				[Dot42.DexImport("getVideoLoadingProgressView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View GetVideoLoadingProgressView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <java-name>
				/// getVisitedHistory
				/// </java-name>
				[Dot42.DexImport("getVisitedHistory", "(Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Landroid/webkit/ValueCallback<[Ljava/lang/String;>;)V")]
				public virtual void GetVisitedHistory(global::Android.Webkit.IValueCallback<string[]> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultVideoPoster
				/// </java-name>
				public global::Android.Graphics.Bitmap DefaultVideoPoster
				{
				[Dot42.DexImport("getDefaultVideoPoster", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetDefaultVideoPoster(); }
				}

				/// <java-name>
				/// getVideoLoadingProgressView
				/// </java-name>
				public global::Android.View.View VideoLoadingProgressView
				{
				[Dot42.DexImport("getVideoLoadingProgressView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return GetVideoLoadingProgressView(); }
				}

				/// <java-name>
				/// android/webkit/WebChromeClient$CustomViewCallback
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebChromeClient$CustomViewCallback", AccessFlags = 1545)]
				public partial interface ICustomViewCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCustomViewHidden
						/// </java-name>
						[Dot42.DexImport("onCustomViewHidden", "()V", AccessFlags = 1025)]
						void OnCustomViewHidden() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/webkit/WebHistoryItem
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebHistoryItem", AccessFlags = 33)]
		public partial class WebHistoryItem : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebHistoryItem() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
				public virtual int GetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTitle() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getFavicon
				/// </java-name>
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFavicon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/webkit/WebHistoryItem;", AccessFlags = 36)]
				protected internal virtual global::Android.Webkit.WebHistoryItem Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebHistoryItem);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				public string Url
				{
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUrl(); }
				}

				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				public string OriginalUrl
				{
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetOriginalUrl(); }
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				public string Title
				{
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTitle(); }
				}

				/// <java-name>
				/// getFavicon
				/// </java-name>
				public global::Android.Graphics.Bitmap Favicon
				{
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetFavicon(); }
				}

		}

		/// <java-name>
		/// android/webkit/WebIconDatabase
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebIconDatabase", AccessFlags = 49)]
		public sealed partial class WebIconDatabase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebIconDatabase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Open(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllIcons
				/// </java-name>
				[Dot42.DexImport("removeAllIcons", "()V", AccessFlags = 1)]
				public void RemoveAllIcons() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestIconForPageUrl
				/// </java-name>
				[Dot42.DexImport("requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V", AccessFlags = 1)]
				public void RequestIconForPageUrl(string @string, global::Android.Webkit.WebIconDatabase.IIconListener iconListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// retainIconForPageUrl
				/// </java-name>
				[Dot42.DexImport("retainIconForPageUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void RetainIconForPageUrl(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// releaseIconForPageUrl
				/// </java-name>
				[Dot42.DexImport("releaseIconForPageUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void ReleaseIconForPageUrl(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebIconDatabase;", AccessFlags = 9)]
				public static global::Android.Webkit.WebIconDatabase GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebIconDatabase);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.WebIconDatabase Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebIconDatabase;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <java-name>
				/// android/webkit/WebIconDatabase$IconListener
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebIconDatabase$IconListener", AccessFlags = 1545)]
				public partial interface IIconListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onReceivedIcon
						/// </java-name>
						[Dot42.DexImport("onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", AccessFlags = 1025)]
						void OnReceivedIcon(string @string, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/webkit/WebResourceResponse
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebResourceResponse", AccessFlags = 33)]
		public partial class WebResourceResponse
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1)]
				public WebResourceResponse(string @string, string string1, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMimeType
				/// </java-name>
				[Dot42.DexImport("setMimeType", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetMimeType(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMimeType
				/// </java-name>
				[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEncoding(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetData(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetData() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WebResourceResponse() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMimeType
				/// </java-name>
				public string MimeType
				{
				[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMimeType(); }
				[Dot42.DexImport("setMimeType", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetMimeType(value); }
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				public string Encoding
				{
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEncoding(); }
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetEncoding(value); }
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public global::Java.Io.InputStream Data
				{
				[Dot42.DexImport("getData", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetData(); }
				[Dot42.DexImport("setData", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						set{ SetData(value); }
				}

		}

		/// <java-name>
		/// android/webkit/WebSettings
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebSettings", AccessFlags = 33)]
		public partial class WebSettings
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LOAD_DEFAULT
				/// </java-name>
				[Dot42.DexImport("LOAD_DEFAULT", "I", AccessFlags = 25)]
				public const int LOAD_DEFAULT = -1;
				/// <java-name>
				/// LOAD_NORMAL
				/// </java-name>
				[Dot42.DexImport("LOAD_NORMAL", "I", AccessFlags = 25)]
				public const int LOAD_NORMAL = 0;
				/// <java-name>
				/// LOAD_CACHE_ELSE_NETWORK
				/// </java-name>
				[Dot42.DexImport("LOAD_CACHE_ELSE_NETWORK", "I", AccessFlags = 25)]
				public const int LOAD_CACHE_ELSE_NETWORK = 1;
				/// <java-name>
				/// LOAD_NO_CACHE
				/// </java-name>
				[Dot42.DexImport("LOAD_NO_CACHE", "I", AccessFlags = 25)]
				public const int LOAD_NO_CACHE = 2;
				/// <java-name>
				/// LOAD_CACHE_ONLY
				/// </java-name>
				[Dot42.DexImport("LOAD_CACHE_ONLY", "I", AccessFlags = 25)]
				public const int LOAD_CACHE_ONLY = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebSettings() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNavDump
				/// </java-name>
				[Dot42.DexImport("setNavDump", "(Z)V", AccessFlags = 1)]
				public virtual void SetNavDump(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNavDump
				/// </java-name>
				[Dot42.DexImport("getNavDump", "()Z", AccessFlags = 1)]
				public virtual bool GetNavDump() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSupportZoom
				/// </java-name>
				[Dot42.DexImport("setSupportZoom", "(Z)V", AccessFlags = 1)]
				public virtual void SetSupportZoom(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// supportZoom
				/// </java-name>
				[Dot42.DexImport("supportZoom", "()Z", AccessFlags = 1)]
				public virtual bool SupportZoom() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBuiltInZoomControls
				/// </java-name>
				[Dot42.DexImport("setBuiltInZoomControls", "(Z)V", AccessFlags = 1)]
				public virtual void SetBuiltInZoomControls(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBuiltInZoomControls
				/// </java-name>
				[Dot42.DexImport("getBuiltInZoomControls", "()Z", AccessFlags = 1)]
				public virtual bool GetBuiltInZoomControls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDisplayZoomControls
				/// </java-name>
				[Dot42.DexImport("setDisplayZoomControls", "(Z)V", AccessFlags = 1)]
				public virtual void SetDisplayZoomControls(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDisplayZoomControls
				/// </java-name>
				[Dot42.DexImport("getDisplayZoomControls", "()Z", AccessFlags = 1)]
				public virtual bool GetDisplayZoomControls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAllowFileAccess
				/// </java-name>
				[Dot42.DexImport("setAllowFileAccess", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowFileAccess(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllowFileAccess
				/// </java-name>
				[Dot42.DexImport("getAllowFileAccess", "()Z", AccessFlags = 1)]
				public virtual bool GetAllowFileAccess() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAllowContentAccess
				/// </java-name>
				[Dot42.DexImport("setAllowContentAccess", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowContentAccess(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllowContentAccess
				/// </java-name>
				[Dot42.DexImport("getAllowContentAccess", "()Z", AccessFlags = 1)]
				public virtual bool GetAllowContentAccess() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLoadWithOverviewMode
				/// </java-name>
				[Dot42.DexImport("setLoadWithOverviewMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetLoadWithOverviewMode(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLoadWithOverviewMode
				/// </java-name>
				[Dot42.DexImport("getLoadWithOverviewMode", "()Z", AccessFlags = 1)]
				public virtual bool GetLoadWithOverviewMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEnableSmoothTransition
				/// </java-name>
				[Dot42.DexImport("setEnableSmoothTransition", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnableSmoothTransition(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableSmoothTransition
				/// </java-name>
				[Dot42.DexImport("enableSmoothTransition", "()Z", AccessFlags = 1)]
				public virtual bool EnableSmoothTransition() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setUseWebViewBackgroundForOverscrollBackground
				/// </java-name>
				[Dot42.DexImport("setUseWebViewBackgroundForOverscrollBackground", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseWebViewBackgroundForOverscrollBackground(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUseWebViewBackgroundForOverscrollBackground
				/// </java-name>
				[Dot42.DexImport("getUseWebViewBackgroundForOverscrollBackground", "()Z", AccessFlags = 1)]
				public virtual bool GetUseWebViewBackgroundForOverscrollBackground() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSaveFormData
				/// </java-name>
				[Dot42.DexImport("setSaveFormData", "(Z)V", AccessFlags = 1)]
				public virtual void SetSaveFormData(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSaveFormData
				/// </java-name>
				[Dot42.DexImport("getSaveFormData", "()Z", AccessFlags = 1)]
				public virtual bool GetSaveFormData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSavePassword
				/// </java-name>
				[Dot42.DexImport("setSavePassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetSavePassword(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSavePassword
				/// </java-name>
				[Dot42.DexImport("getSavePassword", "()Z", AccessFlags = 1)]
				public virtual bool GetSavePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTextZoom
				/// </java-name>
				[Dot42.DexImport("setTextZoom", "(I)V", AccessFlags = 33)]
				public virtual void SetTextZoom(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextZoom
				/// </java-name>
				[Dot42.DexImport("getTextZoom", "()I", AccessFlags = 33)]
				public virtual int GetTextZoom() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setTextSize
				/// </java-name>
				[Dot42.DexImport("setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V", AccessFlags = 33)]
				public virtual void SetTextSize(global::Android.Webkit.WebSettings.TextSize textSize) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextSize
				/// </java-name>
				[Dot42.DexImport("getTextSize", "()Landroid/webkit/WebSettings$TextSize;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebSettings.TextSize GetTextSize() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.TextSize);
				}

				/// <java-name>
				/// setDefaultZoom
				/// </java-name>
				[Dot42.DexImport("setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V", AccessFlags = 1)]
				public virtual void SetDefaultZoom(global::Android.Webkit.WebSettings.ZoomDensity zoomDensity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultZoom
				/// </java-name>
				[Dot42.DexImport("getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebSettings.ZoomDensity GetDefaultZoom() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.ZoomDensity);
				}

				/// <java-name>
				/// setLightTouchEnabled
				/// </java-name>
				[Dot42.DexImport("setLightTouchEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetLightTouchEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLightTouchEnabled
				/// </java-name>
				[Dot42.DexImport("getLightTouchEnabled", "()Z", AccessFlags = 1)]
				public virtual bool GetLightTouchEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setUseDoubleTree
				/// </java-name>
				[Dot42.DexImport("setUseDoubleTree", "(Z)V", AccessFlags = 33)]
				public virtual void SetUseDoubleTree(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUseDoubleTree
				/// </java-name>
				[Dot42.DexImport("getUseDoubleTree", "()Z", AccessFlags = 33)]
				public virtual bool GetUseDoubleTree() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setUserAgent
				/// </java-name>
				[Dot42.DexImport("setUserAgent", "(I)V", AccessFlags = 33)]
				public virtual void SetUserAgent(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserAgent
				/// </java-name>
				[Dot42.DexImport("getUserAgent", "()I", AccessFlags = 33)]
				public virtual int GetUserAgent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setUseWideViewPort
				/// </java-name>
				[Dot42.DexImport("setUseWideViewPort", "(Z)V", AccessFlags = 33)]
				public virtual void SetUseWideViewPort(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUseWideViewPort
				/// </java-name>
				[Dot42.DexImport("getUseWideViewPort", "()Z", AccessFlags = 33)]
				public virtual bool GetUseWideViewPort() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSupportMultipleWindows
				/// </java-name>
				[Dot42.DexImport("setSupportMultipleWindows", "(Z)V", AccessFlags = 33)]
				public virtual void SetSupportMultipleWindows(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// supportMultipleWindows
				/// </java-name>
				[Dot42.DexImport("supportMultipleWindows", "()Z", AccessFlags = 33)]
				public virtual bool SupportMultipleWindows() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLayoutAlgorithm
				/// </java-name>
				[Dot42.DexImport("setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V", AccessFlags = 33)]
				public virtual void SetLayoutAlgorithm(global::Android.Webkit.WebSettings.LayoutAlgorithm layoutAlgorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLayoutAlgorithm
				/// </java-name>
				[Dot42.DexImport("getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebSettings.LayoutAlgorithm GetLayoutAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.LayoutAlgorithm);
				}

				/// <java-name>
				/// setStandardFontFamily
				/// </java-name>
				[Dot42.DexImport("setStandardFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetStandardFontFamily(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStandardFontFamily
				/// </java-name>
				[Dot42.DexImport("getStandardFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetStandardFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setFixedFontFamily
				/// </java-name>
				[Dot42.DexImport("setFixedFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetFixedFontFamily(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFixedFontFamily
				/// </java-name>
				[Dot42.DexImport("getFixedFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetFixedFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSansSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("setSansSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetSansSerifFontFamily(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSansSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("getSansSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetSansSerifFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("setSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetSerifFontFamily(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("getSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetSerifFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCursiveFontFamily
				/// </java-name>
				[Dot42.DexImport("setCursiveFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetCursiveFontFamily(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCursiveFontFamily
				/// </java-name>
				[Dot42.DexImport("getCursiveFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetCursiveFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setFantasyFontFamily
				/// </java-name>
				[Dot42.DexImport("setFantasyFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetFantasyFontFamily(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFantasyFontFamily
				/// </java-name>
				[Dot42.DexImport("getFantasyFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetFantasyFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setMinimumFontSize
				/// </java-name>
				[Dot42.DexImport("setMinimumFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetMinimumFontSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMinimumFontSize
				/// </java-name>
				[Dot42.DexImport("getMinimumFontSize", "()I", AccessFlags = 33)]
				public virtual int GetMinimumFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setMinimumLogicalFontSize
				/// </java-name>
				[Dot42.DexImport("setMinimumLogicalFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetMinimumLogicalFontSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMinimumLogicalFontSize
				/// </java-name>
				[Dot42.DexImport("getMinimumLogicalFontSize", "()I", AccessFlags = 33)]
				public virtual int GetMinimumLogicalFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDefaultFontSize
				/// </java-name>
				[Dot42.DexImport("setDefaultFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetDefaultFontSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultFontSize
				/// </java-name>
				[Dot42.DexImport("getDefaultFontSize", "()I", AccessFlags = 33)]
				public virtual int GetDefaultFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDefaultFixedFontSize
				/// </java-name>
				[Dot42.DexImport("setDefaultFixedFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetDefaultFixedFontSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultFixedFontSize
				/// </java-name>
				[Dot42.DexImport("getDefaultFixedFontSize", "()I", AccessFlags = 33)]
				public virtual int GetDefaultFixedFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setLoadsImagesAutomatically
				/// </java-name>
				[Dot42.DexImport("setLoadsImagesAutomatically", "(Z)V", AccessFlags = 33)]
				public virtual void SetLoadsImagesAutomatically(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLoadsImagesAutomatically
				/// </java-name>
				[Dot42.DexImport("getLoadsImagesAutomatically", "()Z", AccessFlags = 33)]
				public virtual bool GetLoadsImagesAutomatically() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBlockNetworkImage
				/// </java-name>
				[Dot42.DexImport("setBlockNetworkImage", "(Z)V", AccessFlags = 33)]
				public virtual void SetBlockNetworkImage(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBlockNetworkImage
				/// </java-name>
				[Dot42.DexImport("getBlockNetworkImage", "()Z", AccessFlags = 33)]
				public virtual bool GetBlockNetworkImage() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBlockNetworkLoads
				/// </java-name>
				[Dot42.DexImport("setBlockNetworkLoads", "(Z)V", AccessFlags = 33)]
				public virtual void SetBlockNetworkLoads(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBlockNetworkLoads
				/// </java-name>
				[Dot42.DexImport("getBlockNetworkLoads", "()Z", AccessFlags = 33)]
				public virtual bool GetBlockNetworkLoads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setJavaScriptEnabled
				/// </java-name>
				[Dot42.DexImport("setJavaScriptEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetJavaScriptEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPluginsEnabled
				/// </java-name>
				[Dot42.DexImport("setPluginsEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetPluginsEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPluginState
				/// </java-name>
				[Dot42.DexImport("setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V", AccessFlags = 33)]
				public virtual void SetPluginState(global::Android.Webkit.WebSettings.PluginState pluginState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPluginsPath
				/// </java-name>
				[Dot42.DexImport("setPluginsPath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetPluginsPath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDatabasePath
				/// </java-name>
				[Dot42.DexImport("setDatabasePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetDatabasePath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGeolocationDatabasePath
				/// </java-name>
				[Dot42.DexImport("setGeolocationDatabasePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetGeolocationDatabasePath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAppCacheEnabled
				/// </java-name>
				[Dot42.DexImport("setAppCacheEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetAppCacheEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAppCachePath
				/// </java-name>
				[Dot42.DexImport("setAppCachePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetAppCachePath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAppCacheMaxSize
				/// </java-name>
				[Dot42.DexImport("setAppCacheMaxSize", "(J)V", AccessFlags = 33)]
				public virtual void SetAppCacheMaxSize(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDatabaseEnabled
				/// </java-name>
				[Dot42.DexImport("setDatabaseEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetDatabaseEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDomStorageEnabled
				/// </java-name>
				[Dot42.DexImport("setDomStorageEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetDomStorageEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDomStorageEnabled
				/// </java-name>
				[Dot42.DexImport("getDomStorageEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetDomStorageEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetDatabasePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDatabaseEnabled
				/// </java-name>
				[Dot42.DexImport("getDatabaseEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetDatabaseEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setGeolocationEnabled
				/// </java-name>
				[Dot42.DexImport("setGeolocationEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetGeolocationEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getJavaScriptEnabled
				/// </java-name>
				[Dot42.DexImport("getJavaScriptEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetJavaScriptEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPluginsEnabled
				/// </java-name>
				[Dot42.DexImport("getPluginsEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetPluginsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPluginState
				/// </java-name>
				[Dot42.DexImport("getPluginState", "()Landroid/webkit/WebSettings$PluginState;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebSettings.PluginState GetPluginState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.PluginState);
				}

				/// <java-name>
				/// getPluginsPath
				/// </java-name>
				[Dot42.DexImport("getPluginsPath", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetPluginsPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setJavaScriptCanOpenWindowsAutomatically
				/// </java-name>
				[Dot42.DexImport("setJavaScriptCanOpenWindowsAutomatically", "(Z)V", AccessFlags = 33)]
				public virtual void SetJavaScriptCanOpenWindowsAutomatically(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getJavaScriptCanOpenWindowsAutomatically
				/// </java-name>
				[Dot42.DexImport("getJavaScriptCanOpenWindowsAutomatically", "()Z", AccessFlags = 33)]
				public virtual bool GetJavaScriptCanOpenWindowsAutomatically() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDefaultTextEncodingName
				/// </java-name>
				[Dot42.DexImport("setDefaultTextEncodingName", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetDefaultTextEncodingName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultTextEncodingName
				/// </java-name>
				[Dot42.DexImport("getDefaultTextEncodingName", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetDefaultTextEncodingName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setUserAgentString
				/// </java-name>
				[Dot42.DexImport("setUserAgentString", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetUserAgentString(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserAgentString
				/// </java-name>
				[Dot42.DexImport("getUserAgentString", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetUserAgentString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setNeedInitialFocus
				/// </java-name>
				[Dot42.DexImport("setNeedInitialFocus", "(Z)V", AccessFlags = 1)]
				public virtual void SetNeedInitialFocus(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRenderPriority
				/// </java-name>
				[Dot42.DexImport("setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V", AccessFlags = 33)]
				public virtual void SetRenderPriority(global::Android.Webkit.WebSettings.RenderPriority renderPriority) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCacheMode
				/// </java-name>
				[Dot42.DexImport("setCacheMode", "(I)V", AccessFlags = 1)]
				public virtual void SetCacheMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCacheMode
				/// </java-name>
				[Dot42.DexImport("getCacheMode", "()I", AccessFlags = 1)]
				public virtual int GetCacheMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNavDump
				/// </java-name>
				public bool IsNavDump
				{
				[Dot42.DexImport("getNavDump", "()Z", AccessFlags = 1)]
						get{ return GetNavDump(); }
				[Dot42.DexImport("setNavDump", "(Z)V", AccessFlags = 1)]
						set{ SetNavDump(value); }
				}

				/// <java-name>
				/// getBuiltInZoomControls
				/// </java-name>
				public bool IsBuiltInZoomControls
				{
				[Dot42.DexImport("getBuiltInZoomControls", "()Z", AccessFlags = 1)]
						get{ return GetBuiltInZoomControls(); }
				[Dot42.DexImport("setBuiltInZoomControls", "(Z)V", AccessFlags = 1)]
						set{ SetBuiltInZoomControls(value); }
				}

				/// <java-name>
				/// getDisplayZoomControls
				/// </java-name>
				public bool IsDisplayZoomControls
				{
				[Dot42.DexImport("getDisplayZoomControls", "()Z", AccessFlags = 1)]
						get{ return GetDisplayZoomControls(); }
				[Dot42.DexImport("setDisplayZoomControls", "(Z)V", AccessFlags = 1)]
						set{ SetDisplayZoomControls(value); }
				}

				/// <java-name>
				/// getAllowFileAccess
				/// </java-name>
				public bool IsAllowFileAccess
				{
				[Dot42.DexImport("getAllowFileAccess", "()Z", AccessFlags = 1)]
						get{ return GetAllowFileAccess(); }
				[Dot42.DexImport("setAllowFileAccess", "(Z)V", AccessFlags = 1)]
						set{ SetAllowFileAccess(value); }
				}

				/// <java-name>
				/// getAllowContentAccess
				/// </java-name>
				public bool IsAllowContentAccess
				{
				[Dot42.DexImport("getAllowContentAccess", "()Z", AccessFlags = 1)]
						get{ return GetAllowContentAccess(); }
				[Dot42.DexImport("setAllowContentAccess", "(Z)V", AccessFlags = 1)]
						set{ SetAllowContentAccess(value); }
				}

				/// <java-name>
				/// getLoadWithOverviewMode
				/// </java-name>
				public bool IsLoadWithOverviewMode
				{
				[Dot42.DexImport("getLoadWithOverviewMode", "()Z", AccessFlags = 1)]
						get{ return GetLoadWithOverviewMode(); }
				[Dot42.DexImport("setLoadWithOverviewMode", "(Z)V", AccessFlags = 1)]
						set{ SetLoadWithOverviewMode(value); }
				}

				/// <java-name>
				/// getUseWebViewBackgroundForOverscrollBackground
				/// </java-name>
				public bool IsUseWebViewBackgroundForOverscrollBackground
				{
				[Dot42.DexImport("getUseWebViewBackgroundForOverscrollBackground", "()Z", AccessFlags = 1)]
						get{ return GetUseWebViewBackgroundForOverscrollBackground(); }
				[Dot42.DexImport("setUseWebViewBackgroundForOverscrollBackground", "(Z)V", AccessFlags = 1)]
						set{ SetUseWebViewBackgroundForOverscrollBackground(value); }
				}

				/// <java-name>
				/// getSaveFormData
				/// </java-name>
				public bool IsSaveFormData
				{
				[Dot42.DexImport("getSaveFormData", "()Z", AccessFlags = 1)]
						get{ return GetSaveFormData(); }
				[Dot42.DexImport("setSaveFormData", "(Z)V", AccessFlags = 1)]
						set{ SetSaveFormData(value); }
				}

				/// <java-name>
				/// getSavePassword
				/// </java-name>
				public bool IsSavePassword
				{
				[Dot42.DexImport("getSavePassword", "()Z", AccessFlags = 1)]
						get{ return GetSavePassword(); }
				[Dot42.DexImport("setSavePassword", "(Z)V", AccessFlags = 1)]
						set{ SetSavePassword(value); }
				}

				/// <java-name>
				/// getTextZoom
				/// </java-name>
				public int TextZoom
				{
				[Dot42.DexImport("getTextZoom", "()I", AccessFlags = 33)]
						get{ return GetTextZoom(); }
				[Dot42.DexImport("setTextZoom", "(I)V", AccessFlags = 33)]
						set{ SetTextZoom(value); }
				}

				/// <java-name>
				/// getDefaultZoom
				/// </java-name>
				public global::Android.Webkit.WebSettings.ZoomDensity DefaultZoom
				{
				[Dot42.DexImport("getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 1)]
						get{ return GetDefaultZoom(); }
				[Dot42.DexImport("setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V", AccessFlags = 1)]
						set{ SetDefaultZoom(value); }
				}

				/// <java-name>
				/// getLightTouchEnabled
				/// </java-name>
				public bool IsLightTouchEnabled
				{
				[Dot42.DexImport("getLightTouchEnabled", "()Z", AccessFlags = 1)]
						get{ return GetLightTouchEnabled(); }
				[Dot42.DexImport("setLightTouchEnabled", "(Z)V", AccessFlags = 1)]
						set{ SetLightTouchEnabled(value); }
				}

				/// <java-name>
				/// getUseDoubleTree
				/// </java-name>
				public bool IsUseDoubleTree
				{
				[Dot42.DexImport("getUseDoubleTree", "()Z", AccessFlags = 33)]
						get{ return GetUseDoubleTree(); }
				[Dot42.DexImport("setUseDoubleTree", "(Z)V", AccessFlags = 33)]
						set{ SetUseDoubleTree(value); }
				}

				/// <java-name>
				/// getUserAgent
				/// </java-name>
				public int UserAgent
				{
				[Dot42.DexImport("getUserAgent", "()I", AccessFlags = 33)]
						get{ return GetUserAgent(); }
				[Dot42.DexImport("setUserAgent", "(I)V", AccessFlags = 33)]
						set{ SetUserAgent(value); }
				}

				/// <java-name>
				/// getUseWideViewPort
				/// </java-name>
				public bool IsUseWideViewPort
				{
				[Dot42.DexImport("getUseWideViewPort", "()Z", AccessFlags = 33)]
						get{ return GetUseWideViewPort(); }
				[Dot42.DexImport("setUseWideViewPort", "(Z)V", AccessFlags = 33)]
						set{ SetUseWideViewPort(value); }
				}

				/// <java-name>
				/// getStandardFontFamily
				/// </java-name>
				public string StandardFontFamily
				{
				[Dot42.DexImport("getStandardFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetStandardFontFamily(); }
				[Dot42.DexImport("setStandardFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetStandardFontFamily(value); }
				}

				/// <java-name>
				/// getFixedFontFamily
				/// </java-name>
				public string FixedFontFamily
				{
				[Dot42.DexImport("getFixedFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetFixedFontFamily(); }
				[Dot42.DexImport("setFixedFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetFixedFontFamily(value); }
				}

				/// <java-name>
				/// getSansSerifFontFamily
				/// </java-name>
				public string SansSerifFontFamily
				{
				[Dot42.DexImport("getSansSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetSansSerifFontFamily(); }
				[Dot42.DexImport("setSansSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetSansSerifFontFamily(value); }
				}

				/// <java-name>
				/// getSerifFontFamily
				/// </java-name>
				public string SerifFontFamily
				{
				[Dot42.DexImport("getSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetSerifFontFamily(); }
				[Dot42.DexImport("setSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetSerifFontFamily(value); }
				}

				/// <java-name>
				/// getCursiveFontFamily
				/// </java-name>
				public string CursiveFontFamily
				{
				[Dot42.DexImport("getCursiveFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetCursiveFontFamily(); }
				[Dot42.DexImport("setCursiveFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetCursiveFontFamily(value); }
				}

				/// <java-name>
				/// getFantasyFontFamily
				/// </java-name>
				public string FantasyFontFamily
				{
				[Dot42.DexImport("getFantasyFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetFantasyFontFamily(); }
				[Dot42.DexImport("setFantasyFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetFantasyFontFamily(value); }
				}

				/// <java-name>
				/// getMinimumFontSize
				/// </java-name>
				public int MinimumFontSize
				{
				[Dot42.DexImport("getMinimumFontSize", "()I", AccessFlags = 33)]
						get{ return GetMinimumFontSize(); }
				[Dot42.DexImport("setMinimumFontSize", "(I)V", AccessFlags = 33)]
						set{ SetMinimumFontSize(value); }
				}

				/// <java-name>
				/// getMinimumLogicalFontSize
				/// </java-name>
				public int MinimumLogicalFontSize
				{
				[Dot42.DexImport("getMinimumLogicalFontSize", "()I", AccessFlags = 33)]
						get{ return GetMinimumLogicalFontSize(); }
				[Dot42.DexImport("setMinimumLogicalFontSize", "(I)V", AccessFlags = 33)]
						set{ SetMinimumLogicalFontSize(value); }
				}

				/// <java-name>
				/// getDefaultFontSize
				/// </java-name>
				public int DefaultFontSize
				{
				[Dot42.DexImport("getDefaultFontSize", "()I", AccessFlags = 33)]
						get{ return GetDefaultFontSize(); }
				[Dot42.DexImport("setDefaultFontSize", "(I)V", AccessFlags = 33)]
						set{ SetDefaultFontSize(value); }
				}

				/// <java-name>
				/// getDefaultFixedFontSize
				/// </java-name>
				public int DefaultFixedFontSize
				{
				[Dot42.DexImport("getDefaultFixedFontSize", "()I", AccessFlags = 33)]
						get{ return GetDefaultFixedFontSize(); }
				[Dot42.DexImport("setDefaultFixedFontSize", "(I)V", AccessFlags = 33)]
						set{ SetDefaultFixedFontSize(value); }
				}

				/// <java-name>
				/// getLoadsImagesAutomatically
				/// </java-name>
				public bool IsLoadsImagesAutomatically
				{
				[Dot42.DexImport("getLoadsImagesAutomatically", "()Z", AccessFlags = 33)]
						get{ return GetLoadsImagesAutomatically(); }
				[Dot42.DexImport("setLoadsImagesAutomatically", "(Z)V", AccessFlags = 33)]
						set{ SetLoadsImagesAutomatically(value); }
				}

				/// <java-name>
				/// getBlockNetworkImage
				/// </java-name>
				public bool IsBlockNetworkImage
				{
				[Dot42.DexImport("getBlockNetworkImage", "()Z", AccessFlags = 33)]
						get{ return GetBlockNetworkImage(); }
				[Dot42.DexImport("setBlockNetworkImage", "(Z)V", AccessFlags = 33)]
						set{ SetBlockNetworkImage(value); }
				}

				/// <java-name>
				/// getBlockNetworkLoads
				/// </java-name>
				public bool IsBlockNetworkLoads
				{
				[Dot42.DexImport("getBlockNetworkLoads", "()Z", AccessFlags = 33)]
						get{ return GetBlockNetworkLoads(); }
				[Dot42.DexImport("setBlockNetworkLoads", "(Z)V", AccessFlags = 33)]
						set{ SetBlockNetworkLoads(value); }
				}

				/// <java-name>
				/// getDomStorageEnabled
				/// </java-name>
				public bool IsDomStorageEnabled
				{
				[Dot42.DexImport("getDomStorageEnabled", "()Z", AccessFlags = 33)]
						get{ return GetDomStorageEnabled(); }
				[Dot42.DexImport("setDomStorageEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetDomStorageEnabled(value); }
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				public string DatabasePath
				{
				[Dot42.DexImport("getDatabasePath", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetDatabasePath(); }
				[Dot42.DexImport("setDatabasePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetDatabasePath(value); }
				}

				/// <java-name>
				/// getDatabaseEnabled
				/// </java-name>
				public bool IsDatabaseEnabled
				{
				[Dot42.DexImport("getDatabaseEnabled", "()Z", AccessFlags = 33)]
						get{ return GetDatabaseEnabled(); }
				[Dot42.DexImport("setDatabaseEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetDatabaseEnabled(value); }
				}

				/// <java-name>
				/// getJavaScriptEnabled
				/// </java-name>
				public bool IsJavaScriptEnabled
				{
				[Dot42.DexImport("getJavaScriptEnabled", "()Z", AccessFlags = 33)]
						get{ return GetJavaScriptEnabled(); }
				[Dot42.DexImport("setJavaScriptEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetJavaScriptEnabled(value); }
				}

				/// <java-name>
				/// getPluginsEnabled
				/// </java-name>
				public bool IsPluginsEnabled
				{
				[Dot42.DexImport("getPluginsEnabled", "()Z", AccessFlags = 33)]
						get{ return GetPluginsEnabled(); }
				[Dot42.DexImport("setPluginsEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetPluginsEnabled(value); }
				}

				/// <java-name>
				/// getPluginsPath
				/// </java-name>
				public string PluginsPath
				{
				[Dot42.DexImport("getPluginsPath", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetPluginsPath(); }
				[Dot42.DexImport("setPluginsPath", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetPluginsPath(value); }
				}

				/// <java-name>
				/// getJavaScriptCanOpenWindowsAutomatically
				/// </java-name>
				public bool IsJavaScriptCanOpenWindowsAutomatically
				{
				[Dot42.DexImport("getJavaScriptCanOpenWindowsAutomatically", "()Z", AccessFlags = 33)]
						get{ return GetJavaScriptCanOpenWindowsAutomatically(); }
				[Dot42.DexImport("setJavaScriptCanOpenWindowsAutomatically", "(Z)V", AccessFlags = 33)]
						set{ SetJavaScriptCanOpenWindowsAutomatically(value); }
				}

				/// <java-name>
				/// getDefaultTextEncodingName
				/// </java-name>
				public string DefaultTextEncodingName
				{
				[Dot42.DexImport("getDefaultTextEncodingName", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetDefaultTextEncodingName(); }
				[Dot42.DexImport("setDefaultTextEncodingName", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetDefaultTextEncodingName(value); }
				}

				/// <java-name>
				/// getUserAgentString
				/// </java-name>
				public string UserAgentString
				{
				[Dot42.DexImport("getUserAgentString", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetUserAgentString(); }
				[Dot42.DexImport("setUserAgentString", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetUserAgentString(value); }
				}

				/// <java-name>
				/// getCacheMode
				/// </java-name>
				public int CacheMode
				{
				[Dot42.DexImport("getCacheMode", "()I", AccessFlags = 1)]
						get{ return GetCacheMode(); }
				[Dot42.DexImport("setCacheMode", "(I)V", AccessFlags = 1)]
						set{ SetCacheMode(value); }
				}

				/// <java-name>
				/// android/webkit/WebSettings$PluginState
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$PluginState", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$PluginState;>;")]
				public sealed class PluginState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// OFF
						/// </java-name>
						[Dot42.DexImport("OFF", "Landroid/webkit/WebSettings$PluginState;", AccessFlags = 16409)]
						public static readonly PluginState OFF;
						/// <java-name>
						/// ON
						/// </java-name>
						[Dot42.DexImport("ON", "Landroid/webkit/WebSettings$PluginState;", AccessFlags = 16409)]
						public static readonly PluginState ON;
						/// <java-name>
						/// ON_DEMAND
						/// </java-name>
						[Dot42.DexImport("ON_DEMAND", "Landroid/webkit/WebSettings$PluginState;", AccessFlags = 16409)]
						public static readonly PluginState ON_DEMAND;
						private PluginState() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/webkit/WebSettings$PluginState;", AccessFlags = 9)]
						public static PluginState[] Values() /* MethodBuilder.Create */ 
						{
								return default(PluginState[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$PluginState;", AccessFlags = 9)]
						public static PluginState ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(PluginState);
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$RenderPriority
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$RenderPriority", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$RenderPriority;>;")]
				public sealed class RenderPriority
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// HIGH
						/// </java-name>
						[Dot42.DexImport("HIGH", "Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 16409)]
						public static readonly RenderPriority HIGH;
						/// <java-name>
						/// LOW
						/// </java-name>
						[Dot42.DexImport("LOW", "Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 16409)]
						public static readonly RenderPriority LOW;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 16409)]
						public static readonly RenderPriority NORMAL;
						private RenderPriority() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 9)]
						public static RenderPriority[] Values() /* MethodBuilder.Create */ 
						{
								return default(RenderPriority[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 9)]
						public static RenderPriority ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(RenderPriority);
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$ZoomDensity
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$ZoomDensity", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$ZoomDensity;>;")]
				public sealed class ZoomDensity
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLOSE
						/// </java-name>
						[Dot42.DexImport("CLOSE", "Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 16409)]
						public static readonly ZoomDensity CLOSE;
						/// <java-name>
						/// FAR
						/// </java-name>
						[Dot42.DexImport("FAR", "Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 16409)]
						public static readonly ZoomDensity FAR;
						/// <java-name>
						/// MEDIUM
						/// </java-name>
						[Dot42.DexImport("MEDIUM", "Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 16409)]
						public static readonly ZoomDensity MEDIUM;
						private ZoomDensity() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 9)]
						public static ZoomDensity[] Values() /* MethodBuilder.Create */ 
						{
								return default(ZoomDensity[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 9)]
						public static ZoomDensity ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(ZoomDensity);
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$TextSize
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$TextSize", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$TextSize;>;")]
				public sealed class TextSize
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LARGER
						/// </java-name>
						[Dot42.DexImport("LARGER", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize LARGER;
						/// <java-name>
						/// LARGEST
						/// </java-name>
						[Dot42.DexImport("LARGEST", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize LARGEST;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize NORMAL;
						/// <java-name>
						/// SMALLER
						/// </java-name>
						[Dot42.DexImport("SMALLER", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize SMALLER;
						/// <java-name>
						/// SMALLEST
						/// </java-name>
						[Dot42.DexImport("SMALLEST", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize SMALLEST;
						private TextSize() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/webkit/WebSettings$TextSize;", AccessFlags = 9)]
						public static TextSize[] Values() /* MethodBuilder.Create */ 
						{
								return default(TextSize[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$TextSize;", AccessFlags = 9)]
						public static TextSize ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(TextSize);
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$LayoutAlgorithm
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$LayoutAlgorithm", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$LayoutAlgorithm;>;")]
				public sealed class LayoutAlgorithm
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NARROW_COLUMNS
						/// </java-name>
						[Dot42.DexImport("NARROW_COLUMNS", "Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 16409)]
						public static readonly LayoutAlgorithm NARROW_COLUMNS;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 16409)]
						public static readonly LayoutAlgorithm NORMAL;
						/// <java-name>
						/// SINGLE_COLUMN
						/// </java-name>
						[Dot42.DexImport("SINGLE_COLUMN", "Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 16409)]
						public static readonly LayoutAlgorithm SINGLE_COLUMN;
						private LayoutAlgorithm() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 9)]
						public static LayoutAlgorithm[] Values() /* MethodBuilder.Create */ 
						{
								return default(LayoutAlgorithm[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 9)]
						public static LayoutAlgorithm ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(LayoutAlgorithm);
						}

				}

		}

		/// <java-name>
		/// android/webkit/WebStorage
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebStorage", AccessFlags = 49)]
		public sealed partial class WebStorage
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebStorage() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOrigins
				/// </java-name>
				[Dot42.DexImport("getOrigins", "(Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Landroid/webkit/ValueCallback<Ljava/util/Map;>;)V")]
				public void GetOrigins(global::Android.Webkit.IValueCallback<global::Java.Util.IMap<object, object>> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUsageForOrigin
				/// </java-name>
				[Dot42.DexImport("getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/webkit/ValueCallback<Ljava/lang/Long;>;)V")]
				public void GetUsageForOrigin(string @string, global::Android.Webkit.IValueCallback<long?> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getQuotaForOrigin
				/// </java-name>
				[Dot42.DexImport("getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/webkit/ValueCallback<Ljava/lang/Long;>;)V")]
				public void GetQuotaForOrigin(string @string, global::Android.Webkit.IValueCallback<long?> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setQuotaForOrigin
				/// </java-name>
				[Dot42.DexImport("setQuotaForOrigin", "(Ljava/lang/String;J)V", AccessFlags = 1)]
				public void SetQuotaForOrigin(string @string, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteOrigin
				/// </java-name>
				[Dot42.DexImport("deleteOrigin", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void DeleteOrigin(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteAllData
				/// </java-name>
				[Dot42.DexImport("deleteAllData", "()V", AccessFlags = 1)]
				public void DeleteAllData() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebStorage;", AccessFlags = 9)]
				public static global::Android.Webkit.WebStorage GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebStorage);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.WebStorage Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebStorage;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <java-name>
				/// android/webkit/WebStorage$Origin
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebStorage$Origin", AccessFlags = 9)]
				public partial class Origin
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Origin() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getOrigin
						/// </java-name>
						[Dot42.DexImport("getOrigin", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetOrigin() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getQuota
						/// </java-name>
						[Dot42.DexImport("getQuota", "()J", AccessFlags = 1)]
						public virtual long GetQuota() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getUsage
						/// </java-name>
						[Dot42.DexImport("getUsage", "()J", AccessFlags = 1)]
						public virtual long GetUsage() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// getQuota
						/// </java-name>
						public long Quota
						{
						[Dot42.DexImport("getQuota", "()J", AccessFlags = 1)]
								get{ return GetQuota(); }
						}

						/// <java-name>
						/// getUsage
						/// </java-name>
						public long Usage
						{
						[Dot42.DexImport("getUsage", "()J", AccessFlags = 1)]
								get{ return GetUsage(); }
						}

				}

				/// <java-name>
				/// android/webkit/WebStorage$QuotaUpdater
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebStorage$QuotaUpdater", AccessFlags = 1545)]
				public partial interface IQuotaUpdater
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// updateQuota
						/// </java-name>
						[Dot42.DexImport("updateQuota", "(J)V", AccessFlags = 1025)]
						void UpdateQuota(long int64) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/webkit/WebSyncManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebSyncManager", AccessFlags = 1056)]
		internal abstract partial class WebSyncManager : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mHandler
				/// </java-name>
				[Dot42.DexImport("mHandler", "Landroid/os/Handler;", AccessFlags = 4)]
				protected internal global::Android.Os.Handler MHandler;
				/// <java-name>
				/// mDataBase
				/// </java-name>
				[Dot42.DexImport("mDataBase", "Landroid/webkit/WebViewDatabase;", AccessFlags = 4)]
				protected internal global::Android.Webkit.WebViewDatabase MDataBase;
				/// <java-name>
				/// LOGTAG
				/// </java-name>
				[Dot42.DexImport("LOGTAG", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string LOGTAG = "websync";
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal WebSyncManager(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public virtual void Sync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetSync
				/// </java-name>
				[Dot42.DexImport("resetSync", "()V", AccessFlags = 1)]
				public virtual void ResetSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startSync
				/// </java-name>
				[Dot42.DexImport("startSync", "()V", AccessFlags = 1)]
				public virtual void StartSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSync
				/// </java-name>
				[Dot42.DexImport("stopSync", "()V", AccessFlags = 1)]
				public virtual void StopSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSyncInit
				/// </java-name>
				[Dot42.DexImport("onSyncInit", "()V", AccessFlags = 4)]
				protected internal virtual void OnSyncInit() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WebSyncManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/WebView
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebView", AccessFlags = 33)]
		public partial class WebView : global::Android.Widget.AbsoluteLayout, global::Android.View.ViewTreeObserver.IOnGlobalFocusChangeListener, global::Android.View.ViewGroup.IOnHierarchyChangeListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SCHEME_TEL
				/// </java-name>
				[Dot42.DexImport("SCHEME_TEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_TEL = "tel:";
				/// <java-name>
				/// SCHEME_MAILTO
				/// </java-name>
				[Dot42.DexImport("SCHEME_MAILTO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_MAILTO = "mailto:";
				/// <java-name>
				/// SCHEME_GEO
				/// </java-name>
				[Dot42.DexImport("SCHEME_GEO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_GEO = "geo:0,0?q=";
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;IZ)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.View.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.View.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
				public override void SetOverScrollMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScrollBarStyle
				/// </java-name>
				[Dot42.DexImport("setScrollBarStyle", "(I)V", AccessFlags = 1)]
				public override void SetScrollBarStyle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalScrollbarOverlay
				/// </java-name>
				[Dot42.DexImport("setHorizontalScrollbarOverlay", "(Z)V", AccessFlags = 1)]
				public virtual void SetHorizontalScrollbarOverlay(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVerticalScrollbarOverlay
				/// </java-name>
				[Dot42.DexImport("setVerticalScrollbarOverlay", "(Z)V", AccessFlags = 1)]
				public virtual void SetVerticalScrollbarOverlay(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// overlayHorizontalScrollbar
				/// </java-name>
				[Dot42.DexImport("overlayHorizontalScrollbar", "()Z", AccessFlags = 1)]
				public virtual bool OverlayHorizontalScrollbar() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// overlayVerticalScrollbar
				/// </java-name>
				[Dot42.DexImport("overlayVerticalScrollbar", "()Z", AccessFlags = 1)]
				public virtual bool OverlayVerticalScrollbar() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getVisibleTitleHeight
				/// </java-name>
				[Dot42.DexImport("getVisibleTitleHeight", "()I", AccessFlags = 1)]
				public virtual int GetVisibleTitleHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCertificate
				/// </java-name>
				[Dot42.DexImport("getCertificate", "()Landroid/net/http/SslCertificate;", AccessFlags = 1)]
				public virtual global::Android.Net.Http.SslCertificate GetCertificate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate);
				}

				/// <java-name>
				/// setCertificate
				/// </java-name>
				[Dot42.DexImport("setCertificate", "(Landroid/net/http/SslCertificate;)V", AccessFlags = 1)]
				public virtual void SetCertificate(global::Android.Net.Http.SslCertificate sslCertificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// savePassword
				/// </java-name>
				[Dot42.DexImport("savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SavePassword(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetHttpAuthUsernamePassword(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetHttpAuthUsernamePassword(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enablePlatformNotifications
				/// </java-name>
				[Dot42.DexImport("enablePlatformNotifications", "()V", AccessFlags = 9)]
				public static void EnablePlatformNotifications() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disablePlatformNotifications
				/// </java-name>
				[Dot42.DexImport("disablePlatformNotifications", "()V", AccessFlags = 9)]
				public static void DisablePlatformNotifications() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNetworkAvailable
				/// </java-name>
				[Dot42.DexImport("setNetworkAvailable", "(Z)V", AccessFlags = 1)]
				public virtual void SetNetworkAvailable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveState
				/// </java-name>
				[Dot42.DexImport("saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebBackForwardList SaveState(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <java-name>
				/// savePicture
				/// </java-name>
				[Dot42.DexImport("savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z", AccessFlags = 1)]
				public virtual bool SavePicture(global::Android.Os.Bundle bundle, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// restorePicture
				/// </java-name>
				[Dot42.DexImport("restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z", AccessFlags = 1)]
				public virtual bool RestorePicture(global::Android.Os.Bundle bundle, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// restoreState
				/// </java-name>
				[Dot42.DexImport("restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebBackForwardList RestoreState(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <java-name>
				/// loadUrl
				/// </java-name>
				[Dot42.DexImport("loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
				public virtual void LoadUrl(string @string, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadUrl
				/// </java-name>
				[Dot42.DexImport("loadUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void LoadUrl(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postUrl
				/// </java-name>
				[Dot42.DexImport("postUrl", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public virtual void PostUrl(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postUrl
				/// </java-name>
				[Dot42.DexImport("postUrl", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void PostUrl(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadData
				/// </java-name>
				[Dot42.DexImport("loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void LoadData(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadDataWithBaseURL
				/// </java-name>
				[Dot42.DexImport("loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public virtual void LoadDataWithBaseURL(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveWebArchive
				/// </java-name>
				[Dot42.DexImport("saveWebArchive", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SaveWebArchive(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveWebArchive
				/// </java-name>
				[Dot42.DexImport("saveWebArchive", "(Ljava/lang/String;ZLandroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;ZLandroid/webkit/ValueCallback<Ljava/lang/String;>;)V")]
				public virtual void SaveWebArchive(string @string, bool boolean, global::Android.Webkit.IValueCallback<string> valueCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopLoading
				/// </java-name>
				[Dot42.DexImport("stopLoading", "()V", AccessFlags = 1)]
				public virtual void StopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reload
				/// </java-name>
				[Dot42.DexImport("reload", "()V", AccessFlags = 1)]
				public virtual void Reload() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// canGoBack
				/// </java-name>
				[Dot42.DexImport("canGoBack", "()Z", AccessFlags = 1)]
				public virtual bool CanGoBack() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// goBack
				/// </java-name>
				[Dot42.DexImport("goBack", "()V", AccessFlags = 1)]
				public virtual void GoBack() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// canGoForward
				/// </java-name>
				[Dot42.DexImport("canGoForward", "()Z", AccessFlags = 1)]
				public virtual bool CanGoForward() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// goForward
				/// </java-name>
				[Dot42.DexImport("goForward", "()V", AccessFlags = 1)]
				public virtual void GoForward() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// canGoBackOrForward
				/// </java-name>
				[Dot42.DexImport("canGoBackOrForward", "(I)Z", AccessFlags = 1)]
				public virtual bool CanGoBackOrForward(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// goBackOrForward
				/// </java-name>
				[Dot42.DexImport("goBackOrForward", "(I)V", AccessFlags = 1)]
				public virtual void GoBackOrForward(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPrivateBrowsingEnabled
				/// </java-name>
				[Dot42.DexImport("isPrivateBrowsingEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsPrivateBrowsingEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageUp
				/// </java-name>
				[Dot42.DexImport("pageUp", "(Z)Z", AccessFlags = 1)]
				public virtual bool PageUp(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageDown
				/// </java-name>
				[Dot42.DexImport("pageDown", "(Z)Z", AccessFlags = 1)]
				public virtual bool PageDown(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearView
				/// </java-name>
				[Dot42.DexImport("clearView", "()V", AccessFlags = 1)]
				public virtual void ClearView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// capturePicture
				/// </java-name>
				[Dot42.DexImport("capturePicture", "()Landroid/graphics/Picture;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Picture CapturePicture() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Picture);
				}

				/// <java-name>
				/// getScale
				/// </java-name>
				[Dot42.DexImport("getScale", "()F", AccessFlags = 1)]
				public virtual float GetScale() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setInitialScale
				/// </java-name>
				[Dot42.DexImport("setInitialScale", "(I)V", AccessFlags = 1)]
				public virtual void SetInitialScale(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invokeZoomPicker
				/// </java-name>
				[Dot42.DexImport("invokeZoomPicker", "()V", AccessFlags = 1)]
				public virtual void InvokeZoomPicker() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHitTestResult
				/// </java-name>
				[Dot42.DexImport("getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebView.HitTestResult GetHitTestResult() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebView.HitTestResult);
				}

				/// <java-name>
				/// requestFocusNodeHref
				/// </java-name>
				[Dot42.DexImport("requestFocusNodeHref", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void RequestFocusNodeHref(global::Android.Os.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestImageRef
				/// </java-name>
				[Dot42.DexImport("requestImageRef", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void RequestImageRef(global::Android.Os.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int int32, int int321, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTitle() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getFavicon
				/// </java-name>
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFavicon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getProgress
				/// </java-name>
				[Dot42.DexImport("getProgress", "()I", AccessFlags = 1)]
				public virtual int GetProgress() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getContentHeight
				/// </java-name>
				[Dot42.DexImport("getContentHeight", "()I", AccessFlags = 1)]
				public virtual int GetContentHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// pauseTimers
				/// </java-name>
				[Dot42.DexImport("pauseTimers", "()V", AccessFlags = 1)]
				public virtual void PauseTimers() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resumeTimers
				/// </java-name>
				[Dot42.DexImport("resumeTimers", "()V", AccessFlags = 1)]
				public virtual void ResumeTimers() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// freeMemory
				/// </java-name>
				[Dot42.DexImport("freeMemory", "()V", AccessFlags = 1)]
				public virtual void FreeMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCache
				/// </java-name>
				[Dot42.DexImport("clearCache", "(Z)V", AccessFlags = 1)]
				public virtual void ClearCache(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearFormData
				/// </java-name>
				[Dot42.DexImport("clearFormData", "()V", AccessFlags = 1)]
				public virtual void ClearFormData() /* MethodBuilder.Create */ 
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
				/// clearSslPreferences
				/// </java-name>
				[Dot42.DexImport("clearSslPreferences", "()V", AccessFlags = 1)]
				public virtual void ClearSslPreferences() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyBackForwardList
				/// </java-name>
				[Dot42.DexImport("copyBackForwardList", "()Landroid/webkit/WebBackForwardList;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebBackForwardList CopyBackForwardList() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(Z)V", AccessFlags = 1)]
				public virtual void FindNext(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findAll
				/// </java-name>
				[Dot42.DexImport("findAll", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int FindAll(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// showFindDialog
				/// </java-name>
				[Dot42.DexImport("showFindDialog", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool ShowFindDialog(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// findAddress
				/// </java-name>
				[Dot42.DexImport("findAddress", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FindAddress(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clearMatches
				/// </java-name>
				[Dot42.DexImport("clearMatches", "()V", AccessFlags = 1)]
				public virtual void ClearMatches() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// documentHasImages
				/// </java-name>
				[Dot42.DexImport("documentHasImages", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void DocumentHasImages(global::Android.Os.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWebViewClient
				/// </java-name>
				[Dot42.DexImport("setWebViewClient", "(Landroid/webkit/WebViewClient;)V", AccessFlags = 1)]
				public virtual void SetWebViewClient(global::Android.Webkit.WebViewClient webViewClient) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDownloadListener
				/// </java-name>
				[Dot42.DexImport("setDownloadListener", "(Landroid/webkit/DownloadListener;)V", AccessFlags = 1)]
				public virtual void SetDownloadListener(global::Android.Webkit.IDownloadListener downloadListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWebChromeClient
				/// </java-name>
				[Dot42.DexImport("setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V", AccessFlags = 1)]
				public virtual void SetWebChromeClient(global::Android.Webkit.WebChromeClient webChromeClient) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPictureListener
				/// </java-name>
				[Dot42.DexImport("setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V", AccessFlags = 1)]
				public virtual void SetPictureListener(global::Android.Webkit.WebView.IPictureListener pictureListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addJavascriptInterface
				/// </java-name>
				[Dot42.DexImport("addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddJavascriptInterface(object @object, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeJavascriptInterface
				/// </java-name>
				[Dot42.DexImport("removeJavascriptInterface", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveJavascriptInterface(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSettings
				/// </java-name>
				[Dot42.DexImport("getSettings", "()Landroid/webkit/WebSettings;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebSettings GetSettings() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~WebView() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal override bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.View.View view, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLayoutParams
				/// </java-name>
				[Dot42.DexImport("setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void SetLayoutParams(global::Android.View.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public override bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public override global::Android.View.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.View.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int int32, int int321, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// emulateShiftHeld
				/// </java-name>
				[Dot42.DexImport("emulateShiftHeld", "()V", AccessFlags = 1)]
				public virtual void EmulateShiftHeld() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.View.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChildViewAdded
				/// </java-name>
				[Dot42.DexImport("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnChildViewAdded(global::Android.View.View view, global::Android.View.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChildViewRemoved
				/// </java-name>
				[Dot42.DexImport("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnChildViewRemoved(global::Android.View.View view, global::Android.View.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGlobalFocusChanged
				/// </java-name>
				[Dot42.DexImport("onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnGlobalFocusChanged(global::Android.View.View view, global::Android.View.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onScrollChanged
				/// </java-name>
				[Dot42.DexImport("onScrollChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnScrollChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onHoverEvent
				/// </java-name>
				[Dot42.DexImport("onHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnHoverEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMapTrackballToArrowKeys
				/// </java-name>
				[Dot42.DexImport("setMapTrackballToArrowKeys", "(Z)V", AccessFlags = 1)]
				public virtual void SetMapTrackballToArrowKeys(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// flingScroll
				/// </java-name>
				[Dot42.DexImport("flingScroll", "(II)V", AccessFlags = 1)]
				public virtual void FlingScroll(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getZoomControls
				/// </java-name>
				[Dot42.DexImport("getZoomControls", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View GetZoomControls() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <java-name>
				/// canZoomIn
				/// </java-name>
				[Dot42.DexImport("canZoomIn", "()Z", AccessFlags = 1)]
				public virtual bool CanZoomIn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canZoomOut
				/// </java-name>
				[Dot42.DexImport("canZoomOut", "()Z", AccessFlags = 1)]
				public virtual bool CanZoomOut() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// zoomIn
				/// </java-name>
				[Dot42.DexImport("zoomIn", "()Z", AccessFlags = 1)]
				public virtual bool ZoomIn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// zoomOut
				/// </java-name>
				[Dot42.DexImport("zoomOut", "()Z", AccessFlags = 1)]
				public virtual bool ZoomOut() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(ILandroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool RequestFocus(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.View.View view, global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBackgroundColor
				/// </java-name>
				[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
				public override void SetBackgroundColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// debugDump
				/// </java-name>
				[Dot42.DexImport("debugDump", "()V", AccessFlags = 1)]
				public virtual void DebugDump() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WebView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getVisibleTitleHeight
				/// </java-name>
				public int VisibleTitleHeight
				{
				[Dot42.DexImport("getVisibleTitleHeight", "()I", AccessFlags = 1)]
						get{ return GetVisibleTitleHeight(); }
				}

				/// <java-name>
				/// getCertificate
				/// </java-name>
				public global::Android.Net.Http.SslCertificate Certificate
				{
				[Dot42.DexImport("getCertificate", "()Landroid/net/http/SslCertificate;", AccessFlags = 1)]
						get{ return GetCertificate(); }
				[Dot42.DexImport("setCertificate", "(Landroid/net/http/SslCertificate;)V", AccessFlags = 1)]
						set{ SetCertificate(value); }
				}

				/// <java-name>
				/// getScale
				/// </java-name>
				public float Scale
				{
				[Dot42.DexImport("getScale", "()F", AccessFlags = 1)]
						get{ return GetScale(); }
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				public string Url
				{
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUrl(); }
				}

				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				public string OriginalUrl
				{
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetOriginalUrl(); }
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				public string Title
				{
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTitle(); }
				}

				/// <java-name>
				/// getFavicon
				/// </java-name>
				public global::Android.Graphics.Bitmap Favicon
				{
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetFavicon(); }
				}

				/// <java-name>
				/// getProgress
				/// </java-name>
				public int Progress
				{
				[Dot42.DexImport("getProgress", "()I", AccessFlags = 1)]
						get{ return GetProgress(); }
				}

				/// <java-name>
				/// getContentHeight
				/// </java-name>
				public int ContentHeight
				{
				[Dot42.DexImport("getContentHeight", "()I", AccessFlags = 1)]
						get{ return GetContentHeight(); }
				}

				/// <java-name>
				/// getSettings
				/// </java-name>
				public global::Android.Webkit.WebSettings Settings
				{
				[Dot42.DexImport("getSettings", "()Landroid/webkit/WebSettings;", AccessFlags = 1)]
						get{ return GetSettings(); }
				}

				/// <java-name>
				/// getZoomControls
				/// </java-name>
				public global::Android.View.View ZoomControls
				{
				[Dot42.DexImport("getZoomControls", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return GetZoomControls(); }
				}

				/// <java-name>
				/// android/webkit/WebView$HitTestResult
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebView$HitTestResult", AccessFlags = 1)]
				public partial class HitTestResult
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNKNOWN_TYPE
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_TYPE", "I", AccessFlags = 25)]
						public const int UNKNOWN_TYPE = 0;
						/// <java-name>
						/// ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int ANCHOR_TYPE = 1;
						/// <java-name>
						/// PHONE_TYPE
						/// </java-name>
						[Dot42.DexImport("PHONE_TYPE", "I", AccessFlags = 25)]
						public const int PHONE_TYPE = 2;
						/// <java-name>
						/// GEO_TYPE
						/// </java-name>
						[Dot42.DexImport("GEO_TYPE", "I", AccessFlags = 25)]
						public const int GEO_TYPE = 3;
						/// <java-name>
						/// EMAIL_TYPE
						/// </java-name>
						[Dot42.DexImport("EMAIL_TYPE", "I", AccessFlags = 25)]
						public const int EMAIL_TYPE = 4;
						/// <java-name>
						/// IMAGE_TYPE
						/// </java-name>
						[Dot42.DexImport("IMAGE_TYPE", "I", AccessFlags = 25)]
						public const int IMAGE_TYPE = 5;
						/// <java-name>
						/// IMAGE_ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("IMAGE_ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int IMAGE_ANCHOR_TYPE = 6;
						/// <java-name>
						/// SRC_ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("SRC_ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int SRC_ANCHOR_TYPE = 7;
						/// <java-name>
						/// SRC_IMAGE_ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("SRC_IMAGE_ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int SRC_IMAGE_ANCHOR_TYPE = 8;
						/// <java-name>
						/// EDIT_TEXT_TYPE
						/// </java-name>
						[Dot42.DexImport("EDIT_TEXT_TYPE", "I", AccessFlags = 25)]
						public const int EDIT_TEXT_TYPE = 9;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/webkit/WebView;", AccessFlags = 4112)]
						internal readonly global::Android.Webkit.WebView This_0;
						[Dot42.DexImport("<init>", "(Landroid/webkit/WebView;)V", AccessFlags = 0)]
						internal HitTestResult(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getType
						/// </java-name>
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						public virtual int GetTypeJava() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getExtra
						/// </java-name>
						[Dot42.DexImport("getExtra", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetExtra() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal HitTestResult() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getType
						/// </java-name>
						public int Type
						{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
								get{ return GetTypeJava(); }
						}

						/// <java-name>
						/// getExtra
						/// </java-name>
						public string Extra
						{
						[Dot42.DexImport("getExtra", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetExtra(); }
						}

				}

				/// <java-name>
				/// android/webkit/WebView$PictureListener
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebView$PictureListener", AccessFlags = 1545)]
				public partial interface IPictureListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onNewPicture
						/// </java-name>
						[Dot42.DexImport("onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V", AccessFlags = 1025)]
						void OnNewPicture(global::Android.Webkit.WebView webView, global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/webkit/WebView$WebViewTransport
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebView$WebViewTransport", AccessFlags = 1)]
				public partial class WebViewTransport
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/webkit/WebView;", AccessFlags = 4112)]
						internal readonly global::Android.Webkit.WebView This_0;
						[Dot42.DexImport("<init>", "(Landroid/webkit/WebView;)V", AccessFlags = 1)]
						public WebViewTransport(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWebView
						/// </java-name>
						[Dot42.DexImport("setWebView", "(Landroid/webkit/WebView;)V", AccessFlags = 33)]
						public virtual void SetWebView(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getWebView
						/// </java-name>
						[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 33)]
						public virtual global::Android.Webkit.WebView GetWebView() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Webkit.WebView);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal WebViewTransport() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getWebView
						/// </java-name>
						public global::Android.Webkit.WebView WebView
						{
						[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 33)]
								get{ return GetWebView(); }
						[Dot42.DexImport("setWebView", "(Landroid/webkit/WebView;)V", AccessFlags = 33)]
								set{ SetWebView(value); }
						}

				}

		}

		/// <java-name>
		/// android/webkit/WebViewClient
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebViewClient", AccessFlags = 33)]
		public partial class WebViewClient
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int ERROR_UNKNOWN = -1;
				/// <java-name>
				/// ERROR_HOST_LOOKUP
				/// </java-name>
				[Dot42.DexImport("ERROR_HOST_LOOKUP", "I", AccessFlags = 25)]
				public const int ERROR_HOST_LOOKUP = -2;
				/// <java-name>
				/// ERROR_UNSUPPORTED_AUTH_SCHEME
				/// </java-name>
				[Dot42.DexImport("ERROR_UNSUPPORTED_AUTH_SCHEME", "I", AccessFlags = 25)]
				public const int ERROR_UNSUPPORTED_AUTH_SCHEME = -3;
				/// <java-name>
				/// ERROR_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("ERROR_AUTHENTICATION", "I", AccessFlags = 25)]
				public const int ERROR_AUTHENTICATION = -4;
				/// <java-name>
				/// ERROR_PROXY_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("ERROR_PROXY_AUTHENTICATION", "I", AccessFlags = 25)]
				public const int ERROR_PROXY_AUTHENTICATION = -5;
				/// <java-name>
				/// ERROR_CONNECT
				/// </java-name>
				[Dot42.DexImport("ERROR_CONNECT", "I", AccessFlags = 25)]
				public const int ERROR_CONNECT = -6;
				/// <java-name>
				/// ERROR_IO
				/// </java-name>
				[Dot42.DexImport("ERROR_IO", "I", AccessFlags = 25)]
				public const int ERROR_IO = -7;
				/// <java-name>
				/// ERROR_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("ERROR_TIMEOUT", "I", AccessFlags = 25)]
				public const int ERROR_TIMEOUT = -8;
				/// <java-name>
				/// ERROR_REDIRECT_LOOP
				/// </java-name>
				[Dot42.DexImport("ERROR_REDIRECT_LOOP", "I", AccessFlags = 25)]
				public const int ERROR_REDIRECT_LOOP = -9;
				/// <java-name>
				/// ERROR_UNSUPPORTED_SCHEME
				/// </java-name>
				[Dot42.DexImport("ERROR_UNSUPPORTED_SCHEME", "I", AccessFlags = 25)]
				public const int ERROR_UNSUPPORTED_SCHEME = -10;
				/// <java-name>
				/// ERROR_FAILED_SSL_HANDSHAKE
				/// </java-name>
				[Dot42.DexImport("ERROR_FAILED_SSL_HANDSHAKE", "I", AccessFlags = 25)]
				public const int ERROR_FAILED_SSL_HANDSHAKE = -11;
				/// <java-name>
				/// ERROR_BAD_URL
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_URL", "I", AccessFlags = 25)]
				public const int ERROR_BAD_URL = -12;
				/// <java-name>
				/// ERROR_FILE
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE", "I", AccessFlags = 25)]
				public const int ERROR_FILE = -13;
				/// <java-name>
				/// ERROR_FILE_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE_NOT_FOUND", "I", AccessFlags = 25)]
				public const int ERROR_FILE_NOT_FOUND = -14;
				/// <java-name>
				/// ERROR_TOO_MANY_REQUESTS
				/// </java-name>
				[Dot42.DexImport("ERROR_TOO_MANY_REQUESTS", "I", AccessFlags = 25)]
				public const int ERROR_TOO_MANY_REQUESTS = -15;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebViewClient() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldOverrideUrlLoading
				/// </java-name>
				[Dot42.DexImport("shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ShouldOverrideUrlLoading(global::Android.Webkit.WebView webView, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPageStarted
				/// </java-name>
				[Dot42.DexImport("onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void OnPageStarted(global::Android.Webkit.WebView webView, string @string, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPageFinished
				/// </java-name>
				[Dot42.DexImport("onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnPageFinished(global::Android.Webkit.WebView webView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLoadResource
				/// </java-name>
				[Dot42.DexImport("onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnLoadResource(global::Android.Webkit.WebView webView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldInterceptRequest
				/// </java-name>
				[Dot42.DexImport("shouldInterceptRequest", "(Landroid/webkit/WebView;Ljava/lang/String;)Landroid/webkit/WebResourceResponse;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebResourceResponse ShouldInterceptRequest(global::Android.Webkit.WebView webView, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebResourceResponse);
				}

				/// <java-name>
				/// onTooManyRedirects
				/// </java-name>
				[Dot42.DexImport("onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void OnTooManyRedirects(global::Android.Webkit.WebView webView, global::Android.Os.Message message, global::Android.Os.Message message1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedError
				/// </java-name>
				[Dot42.DexImport("onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnReceivedError(global::Android.Webkit.WebView webView, int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFormResubmission
				/// </java-name>
				[Dot42.DexImport("onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void OnFormResubmission(global::Android.Webkit.WebView webView, global::Android.Os.Message message, global::Android.Os.Message message1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doUpdateVisitedHistory
				/// </java-name>
				[Dot42.DexImport("doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void DoUpdateVisitedHistory(global::Android.Webkit.WebView webView, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedSslError
				/// </java-name>
				[Dot42.DexImport("onReceivedSslError", "(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslErr" +
    "or;)V", AccessFlags = 1)]
				public virtual void OnReceivedSslError(global::Android.Webkit.WebView webView, global::Android.Webkit.SslErrorHandler sslErrorHandler, global::Android.Net.Http.SslError sslError) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedHttpAuthRequest
				/// </java-name>
				[Dot42.DexImport("onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/" +
    "lang/String;)V", AccessFlags = 1)]
				public virtual void OnReceivedHttpAuthRequest(global::Android.Webkit.WebView webView, global::Android.Webkit.HttpAuthHandler httpAuthHandler, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldOverrideKeyEvent
				/// </java-name>
				[Dot42.DexImport("shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ShouldOverrideKeyEvent(global::Android.Webkit.WebView webView, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onUnhandledKeyEvent
				/// </java-name>
				[Dot42.DexImport("onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V", AccessFlags = 1)]
				public virtual void OnUnhandledKeyEvent(global::Android.Webkit.WebView webView, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onScaleChanged
				/// </java-name>
				[Dot42.DexImport("onScaleChanged", "(Landroid/webkit/WebView;FF)V", AccessFlags = 1)]
				public virtual void OnScaleChanged(global::Android.Webkit.WebView webView, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceivedLoginRequest
				/// </java-name>
				[Dot42.DexImport("onReceivedLoginRequest", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V" +
    "", AccessFlags = 1)]
				public virtual void OnReceivedLoginRequest(global::Android.Webkit.WebView webView, string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/WebViewDatabase
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebViewDatabase", AccessFlags = 33)]
		public partial class WebViewDatabase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LOGTAG
				/// </java-name>
				[Dot42.DexImport("LOGTAG", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string LOGTAG = "webviewdatabase";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebViewDatabase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;", AccessFlags = 41)]
				public static global::Android.Webkit.WebViewDatabase GetInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebViewDatabase);
				}

				/// <java-name>
				/// hasUsernamePassword
				/// </java-name>
				[Dot42.DexImport("hasUsernamePassword", "()Z", AccessFlags = 1)]
				public virtual bool HasUsernamePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearUsernamePassword
				/// </java-name>
				[Dot42.DexImport("clearUsernamePassword", "()V", AccessFlags = 1)]
				public virtual void ClearUsernamePassword() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("hasHttpAuthUsernamePassword", "()Z", AccessFlags = 1)]
				public virtual bool HasHttpAuthUsernamePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("clearHttpAuthUsernamePassword", "()V", AccessFlags = 1)]
				public virtual void ClearHttpAuthUsernamePassword() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasFormData
				/// </java-name>
				[Dot42.DexImport("hasFormData", "()Z", AccessFlags = 1)]
				public virtual bool HasFormData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearFormData
				/// </java-name>
				[Dot42.DexImport("clearFormData", "()V", AccessFlags = 1)]
				public virtual void ClearFormData() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/WebViewFragment
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebViewFragment", AccessFlags = 33)]
		public partial class WebViewFragment : global::Android.App.Fragment
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebViewFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public override global::Android.View.View OnCreateView(global::Android.View.LayoutInflater layoutInflater, global::Android.View.ViewGroup viewGroup, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public override void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public override void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWebView
				/// </java-name>
				[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebView GetWebView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebView);
				}

				/// <java-name>
				/// getWebView
				/// </java-name>
				public global::Android.Webkit.WebView WebView
				{
				[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 1)]
						get{ return GetWebView(); }
				}

		}

}

