#pragma warning disable 1717
namespace Android.Net.Http
{
		/// <summary>
		///  <para>Implementation of the Apache DefaultHttpClient that is configured with reasonable default settings and registered schemes for Android. Don't create this directly, use the newInstance factory method.</para> <para>This client processes cookies but does not retain them by default. To retain cookies, simply add a cookie store to the HttpContext:</para> <para> <pre>context.setAttribute(ClientContext.COOKIE_STORE, cookieStore);</pre> </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Create a new HttpClient with reasonable defaults (which you can update).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>AndroidHttpClient for you to use for all your requests. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Landroid/content/Context;)Landroid/net/http/AndroidHttpClient;" +
    "", AccessFlags = 9)]
				public static global::Android.Net.Http.AndroidHttpClient NewInstance(string userAgent, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.AndroidHttpClient);
				}

				/// <summary>
				///  <para>Create a new HttpClient with reasonable defaults (which you can update). </para>        
				/// </summary>
				/// <returns>
				///  <para>AndroidHttpClient for you to use for all your requests. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Landroid/net/http/AndroidHttpClient;", AccessFlags = 9)]
				public static global::Android.Net.Http.AndroidHttpClient NewInstance(string userAgent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.AndroidHttpClient);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AndroidHttpClient() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Modifies a request to indicate to the server that we would like a gzipped response. (Uses the "Accept-Encoding" HTTP header.)  <para>getUngzippedContent </para></para>        
				/// </summary>
				/// <java-name>
				/// modifyRequestToAcceptGzipResponse
				/// </java-name>
				[Dot42.DexImport("modifyRequestToAcceptGzipResponse", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 9)]
				public static void ModifyRequestToAcceptGzipResponse(global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the input stream from a response entity. If the entity is gzipped then this will get a stream over the uncompressed data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input stream to read from </para>
				/// </returns>
				/// <java-name>
				/// getUngzippedContent
				/// </java-name>
				[Dot42.DexImport("getUngzippedContent", "(Lorg/apache/http/HttpEntity;)Ljava/io/InputStream;", AccessFlags = 9)]
				public static global::Java.IO.InputStream GetUngzippedContent(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Release resources associated with this client. You must call this, or significant resources (sockets and memory) may be leaked. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request) /* MethodBuilder.Create */ 
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
				public T Execute<T>(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Compress data to send to server. Creates a Http Entity holding the gzipped data. The data will not be compressed if it is too short. </para>        
				/// </summary>
				/// <returns>
				///  <para>Entity holding the data </para>
				/// </returns>
				/// <java-name>
				/// getCompressedEntity
				/// </java-name>
				[Dot42.DexImport("getCompressedEntity", "([BLandroid/content/ContentResolver;)Lorg/apache/http/entity/AbstractHttpEntity;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Entity.AbstractHttpEntity GetCompressedEntity(sbyte[] data, global::Android.Content.ContentResolver resolver) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Entity.AbstractHttpEntity);
				}

				/// <summary>
				///  <para>Compress data to send to server. Creates a Http Entity holding the gzipped data. The data will not be compressed if it is too short. </para>        
				/// </summary>
				/// <returns>
				///  <para>Entity holding the data </para>
				/// </returns>
				/// <java-name>
				/// getCompressedEntity
				/// </java-name>
				[Dot42.DexImport("getCompressedEntity", "([BLandroid/content/ContentResolver;)Lorg/apache/http/entity/AbstractHttpEntity;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Org.Apache.Http.Entity.AbstractHttpEntity GetCompressedEntity(byte[] data, global::Android.Content.ContentResolver resolver) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Entity.AbstractHttpEntity);
				}

				/// <summary>
				///  <para>Retrieves the minimum size for compressing data. Shorter data will not be compressed. </para>        
				/// </summary>
				/// <java-name>
				/// getMinGzipSize
				/// </java-name>
				[Dot42.DexImport("getMinGzipSize", "(Landroid/content/ContentResolver;)J", AccessFlags = 9)]
				public static long GetMinGzipSize(global::Android.Content.ContentResolver resolver) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Enables cURL request logging for this client.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// enableCurlLogging
				/// </java-name>
				[Dot42.DexImport("enableCurlLogging", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void EnableCurlLogging(string name, int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Disables cURL logging for this client. </para>        
				/// </summary>
				/// <java-name>
				/// disableCurlLogging
				/// </java-name>
				[Dot42.DexImport("disableCurlLogging", "()V", AccessFlags = 1)]
				public void DisableCurlLogging() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the date of the given HTTP date string. This method can identify and parse the date formats emitted by common HTTP servers, such as , , ,  and .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of milliseconds since Jan. 1, 1970, midnight GMT. </para>
				/// </returns>
				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;)J", AccessFlags = 9)]
				public static long ParseDate(string dateString) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams Params
				{
						[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
				}

				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				public global::Org.Apache.Http.Conn.IClientConnectionManager ConnectionManager
				{
						[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Conn.IClientConnectionManager); }
				}

		}

		/// <summary>
		///  <para>Caches HTTP and HTTPS responses to the filesystem so they may be reused, saving time and bandwidth. This class supports HttpURLConnection and HttpsURLConnection; there is no platform-provided cache for DefaultHttpClient or AndroidHttpClient.</para> <para> <h3>Installing an HTTP response cache</h3></para> <para>Enable caching of all of your application's HTTP requests by installing the cache at application startup. For example, this code installs a 10 MiB cache in the application-specific cache directory of the filesystem}:  <pre>protected void onCreate(Bundle savedInstanceState) {
		/// 
		///     ...
		/// 
		/// 
		/// 
		///     try {
		/// 
		///         File httpCacheDir = new File(context.getCacheDir(), "http");
		/// 
		///         long httpCacheSize = 10 * 1024 * 1024; // 10 MiB
		/// 
		///         HttpResponseCache.install(httpCacheDir, httpCacheSize);
		/// 
		///     } catch (IOException e) {
		/// 
		///         Log.i(TAG, "HTTP response cache installation failed:" + e);
		/// 
		///     }
		/// 
		/// }
		/// 
		/// 
		/// 
		/// protected void onStop() {
		/// 
		///     ...
		/// 
		/// 
		/// 
		///     HttpResponseCache cache = HttpResponseCache.getInstalled();
		/// 
		///     if (cache != null) {
		/// 
		///         cache.flush();
		/// 
		///     }
		/// 
		/// } 
		/// 
		///  </pre> This cache will evict entries as necessary to keep its size from exceeding 10 MiB. The best cache size is application specific and depends on the size and frequency of the files being downloaded. Increasing the limit may improve the hit rate, but it may also just waste filesystem space!</para> <para>For some applications it may be preferable to create the cache in the external storage directory.  <b>There are no access controls on the external storage directory so it should not be used for caches that could contain private data.</b> Although it often has more free space, external storage is optional and&amp;#8212;even if available&amp;#8212;can disappear during use. Retrieve the external cache directory using Context#getExternalCacheDir(). If this method returns null, your application should fall back to either not caching or caching on non-external storage. If the external storage is removed during use, the cache hit rate will drop to zero and ongoing cache reads will fail.</para> <para>Flushing the cache forces its data to the filesystem. This ensures that all responses written to the cache will be readable the next time the activity starts.</para> <para> <h3>Cache Optimization</h3></para> <para>To measure cache effectiveness, this class tracks three statistics:  <ul> <li> <para> <b>Request Count:</b> the number of HTTP requests issued since this cache was created. </para></li> <li> <para> <b>Network Count:</b> the number of those requests that required network use. </para></li> <li> <para> <b>Hit Count:</b> the number of those requests whose responses were served by the cache. </para></li></ul>Sometimes a request will result in a conditional cache hit. If the cache contains a stale copy of the response, the client will issue a conditional  <c>GET </c> . The server will then send either the updated response if it has changed, or a short 'not modified' response if the client's copy is still valid. Such responses increment both the network count and hit count.</para> <para>The best way to improve the cache hit rate is by configuring the web server to return cacheable responses. Although this client honors all  cache headers, it doesn't cache partial responses.</para> <para> <h3>Force a Network Response</h3></para> <para>In some situations, such as after a user clicks a 'refresh' button, it may be necessary to skip the cache, and fetch data directly from the server. To force a full refresh, add the <c>no-cache </c> directive:  <pre>connection.addRequestProperty("Cache-Control", "no-cache");
		/// 
		///  </pre> If it is only necessary to force a cached response to be validated by the server, use the more efficient <c>max-age=0 </c> instead:  <pre>connection.addRequestProperty("Cache-Control", "max-age=0");
		/// 
		///  </pre></para> <para> <h3>Force a Cache Response</h3></para> <para>Sometimes you'll want to show resources if they are available immediately, but not otherwise. This can be used so your application can show  <b>something</b> while waiting for the latest data to be downloaded. To restrict a request to locally-cached resources, add the <c>only-if-cached </c> directive:  <pre>try {
		/// 
		///     connection.addRequestProperty("Cache-Control", "only-if-cached");
		/// 
		///     InputStream cached = connection.getInputStream();
		/// 
		///     // the resource was cached! show it
		/// 
		/// } catch (FileNotFoundException e) {
		/// 
		///     // the resource was not cached
		/// 
		/// }
		/// 
		///  </pre> This technique works even better in situations where a stale response is better than no response. To permit stale cached responses, use the <c>max-stale </c> directive with the maximum staleness in seconds:  <pre>int maxStale = 60 * 60 * 24 * 28; // tolerate 4-weeks stale
		/// 
		/// connection.addRequestProperty("Cache-Control", "max-stale=" + maxStale);
		/// 
		///  </pre></para> <para> <h3>Working With Earlier Releases</h3></para> <para>This class was added in Android 4.0 (Ice Cream Sandwich). Use reflection to enable the response cache without impacting earlier releases:  <pre>try {
		/// 
		///     File httpCacheDir = new File(context.getCacheDir(), "http");
		/// 
		///     long httpCacheSize = 10 * 1024 * 1024; // 10 MiB
		/// 
		///     Class.forName("android.net.http.HttpResponseCache")
		/// 
		///             .getMethod("install", File.class, long.class)
		/// 
		///             .invoke(null, httpCacheDir, httpCacheSize);
		/// 
		/// } catch (Exception httpResponseCacheNotAvailable) {
		/// 
		/// } 
		/// 
		///  </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/net/http/HttpResponseCache
		/// </java-name>
		[Dot42.DexImport("android/net/http/HttpResponseCache", AccessFlags = 49)]
		public sealed partial class HttpResponseCache : global::Java.Net.ResponseCache, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpResponseCache() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new HTTP response cache and sets it as the system default cache.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly-installed cache </para>
				/// </returns>
				/// <java-name>
				/// install
				/// </java-name>
				[Dot42.DexImport("install", "(Ljava/io/File;J)Landroid/net/http/HttpResponseCache;", AccessFlags = 9)]
				public static global::Android.Net.Http.HttpResponseCache Install(global::Java.IO.File directory, long maxSize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.HttpResponseCache);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;", AccessFlags = 1, Signature = "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/util/List" +
    "<Ljava/lang/String;>;>;)Ljava/net/CacheResponse;")]
				public override global::Java.Net.CacheResponse Get(global::System.Uri uri, string requestMethod, global::Java.Util.IMap<string, global::Java.Util.IList<string>> requestHeaders) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.CacheResponse);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;", AccessFlags = 1)]
				public override global::Java.Net.CacheRequest Put(global::System.Uri uri, global::Java.Net.URLConnection urlConnection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.CacheRequest);
				}

				/// <summary>
				///  <para>Returns the number of bytes currently being used to store the values in this cache. This may be greater than the maxSize if a background deletion is pending. </para>        
				/// </summary>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()J", AccessFlags = 1)]
				public long Size() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the maximum number of bytes that this cache should use to store its data. </para>        
				/// </summary>
				/// <java-name>
				/// maxSize
				/// </java-name>
				[Dot42.DexImport("maxSize", "()J", AccessFlags = 1)]
				public long MaxSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Force buffered operations to the filesystem. This ensures that responses written to the cache will be available the next time the cache is opened, even if this process is killed. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Uninstalls the cache and releases any active resources. Stored contents will remain on the filesystem. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Uninstalls the cache and deletes all of its stored contents. </para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "()V", AccessFlags = 1)]
				public void Delete() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the currently-installed <c>HttpResponseCache </c> , or null if there is no cache installed or it is not a <c>HttpResponseCache </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getInstalled
				/// </java-name>
				public static global::Android.Net.Http.HttpResponseCache Installed
				{
						[Dot42.DexImport("getInstalled", "()Landroid/net/http/HttpResponseCache;", AccessFlags = 9)]
						get{ return default(global::Android.Net.Http.HttpResponseCache); }
				}

				/// <summary>
				///  <para>Returns the number of HTTP requests that required the network to either supply a response or validate a locally cached response. </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkCount
				/// </java-name>
				public int NetworkCount
				{
						[Dot42.DexImport("getNetworkCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of HTTP requests whose response was provided by the cache. This may include conditional <c>GET </c> requests that were validated over the network. </para>        
				/// </summary>
				/// <java-name>
				/// getHitCount
				/// </java-name>
				public int HitCount
				{
						[Dot42.DexImport("getHitCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of HTTP requests that were made. This includes both client requests and requests that were made on the client's behalf to handle a redirects and retries. </para>        
				/// </summary>
				/// <java-name>
				/// getRequestCount
				/// </java-name>
				public int RequestCount
				{
						[Dot42.DexImport("getRequestCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>SSL certificate info (certificate details) class </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Creates a new SSL certificate object from an X509 certificate </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
				public SslCertificate(global::Java.Security.Cert.X509Certificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Saves the certificate state to a bundle </para>        
				/// </summary>
				/// <returns>
				///  <para>A bundle with the certificate stored in it or null if fails </para>
				/// </returns>
				/// <java-name>
				/// saveState
				/// </java-name>
				[Dot42.DexImport("saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;", AccessFlags = 9)]
				public static global::Android.OS.Bundle SaveState(global::Android.Net.Http.SslCertificate certificate) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Restores the certificate stored in the bundle </para>        
				/// </summary>
				/// <returns>
				///  <para>The SSL certificate stored in the bundle or null if fails </para>
				/// </returns>
				/// <java-name>
				/// restoreState
				/// </java-name>
				[Dot42.DexImport("restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;", AccessFlags = 9)]
				public static global::Android.Net.Http.SslCertificate RestoreState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string representation of this certificate for debugging </para>
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
				internal SslCertificate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Not-before date from the certificate validity period or "" if none has been set </para>
				/// </returns>
				/// <java-name>
				/// getValidNotBeforeDate
				/// </java-name>
				public virtual global::Java.Util.Date ValidNotBeforeDate
				{
						[Dot42.DexImport("getValidNotBeforeDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getValidNotBeforeDate() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Not-before date from the certificate validity period in ISO 8601 format or "" if none has been set</para>
				/// </returns>
				/// <java-name>
				/// getValidNotBefore
				/// </java-name>
				public virtual string ValidNotBefore
				{
						[Dot42.DexImport("getValidNotBefore", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Not-after date from the certificate validity period or "" if none has been set </para>
				/// </returns>
				/// <java-name>
				/// getValidNotAfterDate
				/// </java-name>
				public virtual global::Java.Util.Date ValidNotAfterDate
				{
						[Dot42.DexImport("getValidNotAfterDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getValidNotAfterDate() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Not-after date from the certificate validity period in ISO 8601 format or "" if none has been set</para>
				/// </returns>
				/// <java-name>
				/// getValidNotAfter
				/// </java-name>
				public virtual string ValidNotAfter
				{
						[Dot42.DexImport("getValidNotAfter", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Issued-to distinguished name or null if none has been set </para>
				/// </returns>
				/// <java-name>
				/// getIssuedTo
				/// </java-name>
				public virtual global::Android.Net.Http.SslCertificate.DName IssuedTo
				{
						[Dot42.DexImport("getIssuedTo", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Http.SslCertificate.DName); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Issued-by distinguished name or null if none has been set </para>
				/// </returns>
				/// <java-name>
				/// getIssuedBy
				/// </java-name>
				public virtual global::Android.Net.Http.SslCertificate.DName IssuedBy
				{
						[Dot42.DexImport("getIssuedBy", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Http.SslCertificate.DName); }
				}

				/// <summary>
				///  <para>A distinguished name helper class: a 3-tuple of:  <ul> <li> <para>the most specific common name (CN) </para></li> <li> <para>the most specific organization (O) </para></li> <li> <para>the most specific organizational unit (OU)  <ul> <li></li></ul></para></li></ul></para>    
				/// </summary>
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

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The distinguished name (normally includes CN, O, and OU names) </para>
						/// </returns>
						/// <java-name>
						/// getDName
						/// </java-name>
						[Dot42.DexImport("getDName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetDName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal DName() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The most specific Common-name (CN) component of this name </para>
						/// </returns>
						/// <java-name>
						/// getCName
						/// </java-name>
						public virtual string CName
						{
								[Dot42.DexImport("getCName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The most specific Organization (O) component of this name </para>
						/// </returns>
						/// <java-name>
						/// getOName
						/// </java-name>
						public virtual string OName
						{
								[Dot42.DexImport("getOName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The most specific Organizational Unit (OU) component of this name </para>
						/// </returns>
						/// <java-name>
						/// getUName
						/// </java-name>
						public virtual string UName
						{
								[Dot42.DexImport("getUName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

				}

		}

		/// <summary>
		///  <para>This class represents a set of one or more SSL errors and the associated SSL certificate. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/http/SslError
		/// </java-name>
		[Dot42.DexImport("android/net/http/SslError", AccessFlags = 33)]
		public partial class SslError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Individual SSL errors (in the order from the least to the most severe): The certificate is not yet valid </para>        
				/// </summary>
				/// <java-name>
				/// SSL_NOTYETVALID
				/// </java-name>
				[Dot42.DexImport("SSL_NOTYETVALID", "I", AccessFlags = 25)]
				public const int SSL_NOTYETVALID = 0;
				/// <summary>
				///  <para>The certificate has expired </para>        
				/// </summary>
				/// <java-name>
				/// SSL_EXPIRED
				/// </java-name>
				[Dot42.DexImport("SSL_EXPIRED", "I", AccessFlags = 25)]
				public const int SSL_EXPIRED = 1;
				/// <summary>
				///  <para>Hostname mismatch </para>        
				/// </summary>
				/// <java-name>
				/// SSL_IDMISMATCH
				/// </java-name>
				[Dot42.DexImport("SSL_IDMISMATCH", "I", AccessFlags = 25)]
				public const int SSL_IDMISMATCH = 2;
				/// <summary>
				///  <para>The certificate authority is not trusted </para>        
				/// </summary>
				/// <java-name>
				/// SSL_UNTRUSTED
				/// </java-name>
				[Dot42.DexImport("SSL_UNTRUSTED", "I", AccessFlags = 25)]
				public const int SSL_UNTRUSTED = 3;
				/// <summary>
				///  <para>The date of the certificate is invalid </para>        
				/// </summary>
				/// <java-name>
				/// SSL_DATE_INVALID
				/// </java-name>
				[Dot42.DexImport("SSL_DATE_INVALID", "I", AccessFlags = 25)]
				public const int SSL_DATE_INVALID = 4;
				/// <summary>
				///  <para>A generic error occurred </para>        
				/// </summary>
				/// <java-name>
				/// SSL_INVALID
				/// </java-name>
				[Dot42.DexImport("SSL_INVALID", "I", AccessFlags = 25)]
				public const int SSL_INVALID = 5;
				/// <summary>
				///  <para>The number of different SSL errors.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This constant is not necessary for using the SslError API and can change from release to release. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SSL_MAX_ERROR
				/// </java-name>
				[Dot42.DexImport("SSL_MAX_ERROR", "I", AccessFlags = 25)]
				public const int SSL_MAX_ERROR = 6;
				/// <summary>
				///  <para>Creates a new SslError object using the supplied error and certificate. The URL will be set to the empty string.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use SslError(int, SslCertificate, String) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILandroid/net/http/SslCertificate;)V", AccessFlags = 1)]
				public SslError(int error, global::Android.Net.Http.SslCertificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new SslError object using the supplied error and certificate. The URL will be set to the empty string.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use SslError(int, SslCertificate, String) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/security/cert/X509Certificate;)V", AccessFlags = 1)]
				public SslError(int error, global::Java.Security.Cert.X509Certificate certificate) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Adds the supplied SSL error to the set. </para>        
				/// </summary>
				/// <returns>
				///  <para>True if the error being added is a known SSL error, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// addError
				/// </java-name>
				[Dot42.DexImport("addError", "(I)Z", AccessFlags = 1)]
				public virtual bool AddError(int error) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Determines whether this object includes the supplied error. </para>        
				/// </summary>
				/// <returns>
				///  <para>True if this object includes the error, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// hasError
				/// </java-name>
				[Dot42.DexImport("hasError", "(I)Z", AccessFlags = 1)]
				public virtual bool HasError(int error) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a string representation of this object. </para>        
				/// </summary>
				/// <returns>
				///  <para>A String representation of this object. </para>
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
				internal SslError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the SSL certificate associated with this object. </para>        
				/// </summary>
				/// <returns>
				///  <para>The SSL certificate, non-null. </para>
				/// </returns>
				/// <java-name>
				/// getCertificate
				/// </java-name>
				public virtual global::Android.Net.Http.SslCertificate Certificate
				{
						[Dot42.DexImport("getCertificate", "()Landroid/net/http/SslCertificate;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Http.SslCertificate); }
				}

				/// <summary>
				///  <para>Gets the URL associated with this object. </para>        
				/// </summary>
				/// <returns>
				///  <para>The URL, non-null. </para>
				/// </returns>
				/// <java-name>
				/// getUrl
				/// </java-name>
				public virtual string Url
				{
						[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the most severe SSL error in this object's set of errors. Returns -1 if the set is empty. </para>        
				/// </summary>
				/// <returns>
				///  <para>The most severe SSL error, or -1 if the set is empty. </para>
				/// </returns>
				/// <java-name>
				/// getPrimaryError
				/// </java-name>
				public virtual int PrimaryError
				{
						[Dot42.DexImport("getPrimaryError", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

