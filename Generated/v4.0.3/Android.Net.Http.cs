#pragma warning disable 1717
namespace Android.Net.Http
{
		/// <java-name>
		/// android/net/http/AndroidHttpClient
		/// </java-name>
		[Dot42.DexImport("android/net/http/AndroidHttpClient", AccessFlags = 49)]
		public sealed partial class AndroidHttpClient : global::Org.Apache.Http.Client.IHttpClient
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_SYNC_MIN_GZIP_BYTES
				/// </java-name>
				[Dot42.DexImport("DEFAULT_SYNC_MIN_GZIP_BYTES", "J", AccessFlags = 9)]
				public static long DEFAULT_SYNC_MIN_GZIP_BYTES;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AndroidHttpClient() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Landroid/content/Context;)Landroid/net/http/AndroidHttpClient;" +
    "", AccessFlags = 9)]
				public static global::Android.Net.Http.AndroidHttpClient NewInstance(string @string, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.AndroidHttpClient);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Landroid/net/http/AndroidHttpClient;", AccessFlags = 9)]
				public static global::Android.Net.Http.AndroidHttpClient NewInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.AndroidHttpClient);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AndroidHttpClient() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// modifyRequestToAcceptGzipResponse
				/// </java-name>
				[Dot42.DexImport("modifyRequestToAcceptGzipResponse", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 9)]
				public static void ModifyRequestToAcceptGzipResponse(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUngzippedContent
				/// </java-name>
				[Dot42.DexImport("getUngzippedContent", "(Lorg/apache/http/HttpEntity;)Ljava/io/InputStream;", AccessFlags = 9)]
				public static global::Java.Io.InputStream GetUngzippedContent(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1)]
				public global::Org.Apache.Http.Conn.IClientConnectionManager GetConnectionManager() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionManager);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpCon" +
    "text;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpRes" +
    "ponse;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;)TT;")]
				public T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext;)TT;")]
				public T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;)TT;")]
				public T Execute<T>(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext" +
    ";)TT;")]
				public T Execute<T>(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getCompressedEntity
				/// </java-name>
				[Dot42.DexImport("getCompressedEntity", "([BLandroid/content/ContentResolver;)Lorg/apache/http/entity/AbstractHttpEntity;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Entity.AbstractHttpEntity GetCompressedEntity(sbyte[] sByte, global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Entity.AbstractHttpEntity);
				}

				/// <java-name>
				/// getCompressedEntity
				/// </java-name>
				[Dot42.DexImport("getCompressedEntity", "([BLandroid/content/ContentResolver;)Lorg/apache/http/entity/AbstractHttpEntity;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Org.Apache.Http.Entity.AbstractHttpEntity GetCompressedEntity(byte[] @byte, global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Entity.AbstractHttpEntity);
				}

				/// <java-name>
				/// getMinGzipSize
				/// </java-name>
				[Dot42.DexImport("getMinGzipSize", "(Landroid/content/ContentResolver;)J", AccessFlags = 9)]
				public static long GetMinGzipSize(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// enableCurlLogging
				/// </java-name>
				[Dot42.DexImport("enableCurlLogging", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void EnableCurlLogging(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disableCurlLogging
				/// </java-name>
				[Dot42.DexImport("disableCurlLogging", "()V", AccessFlags = 1)]
				public void DisableCurlLogging() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;)J", AccessFlags = 9)]
				public static long ParseDate(string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams Params
				{
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
						get{ return GetParams(); }
				}

				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				public global::Org.Apache.Http.Conn.IClientConnectionManager ConnectionManager
				{
				[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1)]
						get{ return GetConnectionManager(); }
				}

		}

		/// <java-name>
		/// android/net/http/HttpResponseCache
		/// </java-name>
		[Dot42.DexImport("android/net/http/HttpResponseCache", AccessFlags = 49)]
		public sealed partial class HttpResponseCache : global::Java.Net.ResponseCache, global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpResponseCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstalled
				/// </java-name>
				[Dot42.DexImport("getInstalled", "()Landroid/net/http/HttpResponseCache;", AccessFlags = 9)]
				public static global::Android.Net.Http.HttpResponseCache GetInstalled() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.HttpResponseCache);
				}

				/// <java-name>
				/// install
				/// </java-name>
				[Dot42.DexImport("install", "(Ljava/io/File;J)Landroid/net/http/HttpResponseCache;", AccessFlags = 9)]
				public static global::Android.Net.Http.HttpResponseCache Install(global::Java.Io.File file, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.HttpResponseCache);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;", AccessFlags = 1, Signature = "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/util/List" +
    "<Ljava/lang/String;>;>;)Ljava/net/CacheResponse;")]
				public override global::Java.Net.CacheResponse Get(global::System.Uri uri, string @string, global::Java.Util.IMap<string, global::Java.Util.IList<string>> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.CacheResponse);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;", AccessFlags = 1)]
				public override global::Java.Net.CacheRequest Put(global::System.Uri uri, global::Java.Net.URLConnection uRLConnection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.CacheRequest);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()J", AccessFlags = 1)]
				public long Size() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// maxSize
				/// </java-name>
				[Dot42.DexImport("maxSize", "()J", AccessFlags = 1)]
				public long MaxSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNetworkCount
				/// </java-name>
				[Dot42.DexImport("getNetworkCount", "()I", AccessFlags = 1)]
				public int GetNetworkCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHitCount
				/// </java-name>
				[Dot42.DexImport("getHitCount", "()I", AccessFlags = 1)]
				public int GetHitCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRequestCount
				/// </java-name>
				[Dot42.DexImport("getRequestCount", "()I", AccessFlags = 1)]
				public int GetRequestCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "()V", AccessFlags = 1)]
				public void Delete() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstalled
				/// </java-name>
				public static global::Android.Net.Http.HttpResponseCache Installed
				{
				[Dot42.DexImport("getInstalled", "()Landroid/net/http/HttpResponseCache;", AccessFlags = 9)]
						get{ return GetInstalled(); }
				}

				/// <java-name>
				/// getNetworkCount
				/// </java-name>
				public int NetworkCount
				{
				[Dot42.DexImport("getNetworkCount", "()I", AccessFlags = 1)]
						get{ return GetNetworkCount(); }
				}

				/// <java-name>
				/// getHitCount
				/// </java-name>
				public int HitCount
				{
				[Dot42.DexImport("getHitCount", "()I", AccessFlags = 1)]
						get{ return GetHitCount(); }
				}

				/// <java-name>
				/// getRequestCount
				/// </java-name>
				public int RequestCount
				{
				[Dot42.DexImport("getRequestCount", "()I", AccessFlags = 1)]
						get{ return GetRequestCount(); }
				}

		}

		/// <java-name>
		/// android/net/http/SslCertificate
		/// </java-name>
		[Dot42.DexImport("android/net/http/SslCertificate", AccessFlags = 33)]
		public partial class SslCertificate
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SslCertificate(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;)V", AccessFlags = 1)]
				public SslCertificate(string @string, string string1, global::Java.Util.Date date, global::Java.Util.Date date1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
				public SslCertificate(global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveState
				/// </java-name>
				[Dot42.DexImport("saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;", AccessFlags = 9)]
				public static global::Android.OS.Bundle SaveState(global::Android.Net.Http.SslCertificate sslCertificate) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// restoreState
				/// </java-name>
				[Dot42.DexImport("restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;", AccessFlags = 9)]
				public static global::Android.Net.Http.SslCertificate RestoreState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate);
				}

				/// <java-name>
				/// getValidNotBeforeDate
				/// </java-name>
				[Dot42.DexImport("getValidNotBeforeDate", "()Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date GetValidNotBeforeDate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// getValidNotBefore
				/// </java-name>
				[Dot42.DexImport("getValidNotBefore", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValidNotBefore() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValidNotAfterDate
				/// </java-name>
				[Dot42.DexImport("getValidNotAfterDate", "()Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date GetValidNotAfterDate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// getValidNotAfter
				/// </java-name>
				[Dot42.DexImport("getValidNotAfter", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValidNotAfter() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getIssuedTo
				/// </java-name>
				[Dot42.DexImport("getIssuedTo", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
				public virtual global::Android.Net.Http.SslCertificate.DName GetIssuedTo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate.DName);
				}

				/// <java-name>
				/// getIssuedBy
				/// </java-name>
				[Dot42.DexImport("getIssuedBy", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
				public virtual global::Android.Net.Http.SslCertificate.DName GetIssuedBy() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate.DName);
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
				internal SslCertificate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getValidNotBeforeDate
				/// </java-name>
				public global::Java.Util.Date ValidNotBeforeDate
				{
				[Dot42.DexImport("getValidNotBeforeDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return GetValidNotBeforeDate(); }
				}

				/// <java-name>
				/// getValidNotBefore
				/// </java-name>
				public string ValidNotBefore
				{
				[Dot42.DexImport("getValidNotBefore", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValidNotBefore(); }
				}

				/// <java-name>
				/// getValidNotAfterDate
				/// </java-name>
				public global::Java.Util.Date ValidNotAfterDate
				{
				[Dot42.DexImport("getValidNotAfterDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return GetValidNotAfterDate(); }
				}

				/// <java-name>
				/// getValidNotAfter
				/// </java-name>
				public string ValidNotAfter
				{
				[Dot42.DexImport("getValidNotAfter", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValidNotAfter(); }
				}

				/// <java-name>
				/// getIssuedTo
				/// </java-name>
				public global::Android.Net.Http.SslCertificate.DName IssuedTo
				{
				[Dot42.DexImport("getIssuedTo", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
						get{ return GetIssuedTo(); }
				}

				/// <java-name>
				/// getIssuedBy
				/// </java-name>
				public global::Android.Net.Http.SslCertificate.DName IssuedBy
				{
				[Dot42.DexImport("getIssuedBy", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
						get{ return GetIssuedBy(); }
				}

				/// <java-name>
				/// android/net/http/SslCertificate$DName
				/// </java-name>
				[Dot42.DexImport("android/net/http/SslCertificate$DName", AccessFlags = 1)]
				public partial class DName
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/http/SslCertificate;", AccessFlags = 4112)]
						internal readonly global::Android.Net.Http.SslCertificate This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V", AccessFlags = 1)]
						public DName(global::Android.Net.Http.SslCertificate sslCertificate, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getDName
						/// </java-name>
						[Dot42.DexImport("getDName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetDName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getCName
						/// </java-name>
						[Dot42.DexImport("getCName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetCName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getOName
						/// </java-name>
						[Dot42.DexImport("getOName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetOName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getUName
						/// </java-name>
						[Dot42.DexImport("getUName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetUName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal DName() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCName
						/// </java-name>
						public string CName
						{
						[Dot42.DexImport("getCName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetCName(); }
						}

						/// <java-name>
						/// getOName
						/// </java-name>
						public string OName
						{
						[Dot42.DexImport("getOName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetOName(); }
						}

						/// <java-name>
						/// getUName
						/// </java-name>
						public string UName
						{
						[Dot42.DexImport("getUName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetUName(); }
						}

				}

		}

		/// <java-name>
		/// android/net/http/SslError
		/// </java-name>
		[Dot42.DexImport("android/net/http/SslError", AccessFlags = 33)]
		public partial class SslError
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SSL_NOTYETVALID
				/// </java-name>
				[Dot42.DexImport("SSL_NOTYETVALID", "I", AccessFlags = 25)]
				public const int SSL_NOTYETVALID = 0;
				/// <java-name>
				/// SSL_EXPIRED
				/// </java-name>
				[Dot42.DexImport("SSL_EXPIRED", "I", AccessFlags = 25)]
				public const int SSL_EXPIRED = 1;
				/// <java-name>
				/// SSL_IDMISMATCH
				/// </java-name>
				[Dot42.DexImport("SSL_IDMISMATCH", "I", AccessFlags = 25)]
				public const int SSL_IDMISMATCH = 2;
				/// <java-name>
				/// SSL_UNTRUSTED
				/// </java-name>
				[Dot42.DexImport("SSL_UNTRUSTED", "I", AccessFlags = 25)]
				public const int SSL_UNTRUSTED = 3;
				/// <java-name>
				/// SSL_DATE_INVALID
				/// </java-name>
				[Dot42.DexImport("SSL_DATE_INVALID", "I", AccessFlags = 25)]
				public const int SSL_DATE_INVALID = 4;
				/// <java-name>
				/// SSL_INVALID
				/// </java-name>
				[Dot42.DexImport("SSL_INVALID", "I", AccessFlags = 25)]
				public const int SSL_INVALID = 5;
				/// <java-name>
				/// SSL_MAX_ERROR
				/// </java-name>
				[Dot42.DexImport("SSL_MAX_ERROR", "I", AccessFlags = 25)]
				public const int SSL_MAX_ERROR = 6;
				[Dot42.DexImport("<init>", "(ILandroid/net/http/SslCertificate;)V", AccessFlags = 1)]
				public SslError(int int32, global::Android.Net.Http.SslCertificate sslCertificate) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/security/cert/X509Certificate;)V", AccessFlags = 1)]
				public SslError(int int32, global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILandroid/net/http/SslCertificate;Ljava/lang/String;)V", AccessFlags = 1)]
				public SslError(int int32, global::Android.Net.Http.SslCertificate sslCertificate, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/security/cert/X509Certificate;Ljava/lang/String;)V", AccessFlags = 1)]
				public SslError(int int32, global::Java.Security.Cert.X509Certificate x509Certificate, string @string) /* MethodBuilder.Create */ 
				{
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
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// addError
				/// </java-name>
				[Dot42.DexImport("addError", "(I)Z", AccessFlags = 1)]
				public virtual bool AddError(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasError
				/// </java-name>
				[Dot42.DexImport("hasError", "(I)Z", AccessFlags = 1)]
				public virtual bool HasError(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPrimaryError
				/// </java-name>
				[Dot42.DexImport("getPrimaryError", "()I", AccessFlags = 1)]
				public virtual int GetPrimaryError() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				internal SslError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCertificate
				/// </java-name>
				public global::Android.Net.Http.SslCertificate Certificate
				{
				[Dot42.DexImport("getCertificate", "()Landroid/net/http/SslCertificate;", AccessFlags = 1)]
						get{ return GetCertificate(); }
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
				/// getPrimaryError
				/// </java-name>
				public int PrimaryError
				{
				[Dot42.DexImport("getPrimaryError", "()I", AccessFlags = 1)]
						get{ return GetPrimaryError(); }
				}

		}

}

