#pragma warning disable 1717
namespace Org.Apache.Http.Client
{
		/// <java-name>
		/// org/apache/http/client/CircularRedirectException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/CircularRedirectException", AccessFlags = 33)]
		public partial class CircularRedirectException : global::Org.Apache.Http.Client.RedirectException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CircularRedirectException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CircularRedirectException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CircularRedirectException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/ClientProtocolException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/ClientProtocolException", AccessFlags = 33)]
		public partial class ClientProtocolException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClientProtocolException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClientProtocolException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ClientProtocolException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ClientProtocolException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/HttpResponseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/HttpResponseException", AccessFlags = 33)]
		public partial class HttpResponseException : global::Org.Apache.Http.Client.ClientProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public HttpResponseException(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStatusCode
				/// </java-name>
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1)]
				public virtual int GetStatusCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpResponseException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStatusCode
				/// </java-name>
				public int StatusCode
				{
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1)]
						get{ return GetStatusCode(); }
				}

		}

		/// <java-name>
		/// org/apache/http/client/AuthenticationHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/AuthenticationHandler", AccessFlags = 1537)]
		public partial interface IAuthenticationHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isAuthenticationRequested
				/// </java-name>
				[Dot42.DexImport("isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChallenges
				/// </java-name>
				[Dot42.DexImport("getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1025, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// selectScheme
				/// </java-name>
				[Dot42.DexImport("selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpConte" +
    "xt;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/Header;>;Lorg/apache/http/Http" +
    "Response;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme" +
    ";")]
				global::Org.Apache.Http.Auth.IAuthScheme SelectScheme(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> map, global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/CookieStore
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/CookieStore", AccessFlags = 1537)]
		public partial interface ICookieStore
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addCookie
				/// </java-name>
				[Dot42.DexImport("addCookie", "(Lorg/apache/http/cookie/Cookie;)V", AccessFlags = 1025)]
				void AddCookie(global::Org.Apache.Http.Cookie.ICookie cookie) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCookies
				/// </java-name>
				[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;")]
				global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> GetCookies() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearExpired
				/// </java-name>
				[Dot42.DexImport("clearExpired", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				bool ClearExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/CredentialsProvider
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/CredentialsProvider", AccessFlags = 1537)]
		public partial interface ICredentialsProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setCredentials
				/// </java-name>
				[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V", AccessFlags = 1025)]
				void SetCredentials(global::Org.Apache.Http.Auth.AuthScope authScope, global::Org.Apache.Http.Auth.ICredentials credentials) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCredentials
				/// </java-name>
				[Dot42.DexImport("getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;", AccessFlags = 1025)]
				global::Org.Apache.Http.Auth.ICredentials GetCredentials(global::Org.Apache.Http.Auth.AuthScope authScope) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/HttpClient
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/HttpClient", AccessFlags = 1537)]
		public partial interface IHttpClient
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IClientConnectionManager GetConnectionManager() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpCon" +
    "text;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpRes" +
    "ponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;)TT;")]
				T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext;)TT;")]
				T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;)TT;")]
				T Execute<T>(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext" +
    ";)TT;")]
				T Execute<T>(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/HttpRequestRetryHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/HttpRequestRetryHandler", AccessFlags = 1537)]
		public partial interface IHttpRequestRetryHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// retryRequest
				/// </java-name>
				[Dot42.DexImport("retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool RetryRequest(global::System.IO.IOException iOException, int int32, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/RedirectHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/RedirectHandler", AccessFlags = 1537)]
		public partial interface IRedirectHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isRedirectRequested
				/// </java-name>
				[Dot42.DexImport("isRedirectRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool IsRedirectRequested(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocationURI
				/// </java-name>
				[Dot42.DexImport("getLocationURI", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/net/U" +
    "RI;", AccessFlags = 1025)]
				global::System.Uri GetLocationURI(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/RequestDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/RequestDirector", AccessFlags = 1537)]
		public partial interface IRequestDirector
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/ResponseHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/ResponseHandler", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IResponseHandler<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handleResponse
				/// </java-name>
				[Dot42.DexImport("handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Lorg/apache/http/HttpResponse;)TT;")]
				T HandleResponse(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/UserTokenHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/UserTokenHandler", AccessFlags = 1537)]
		public partial interface IUserTokenHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getUserToken
				/// </java-name>
				[Dot42.DexImport("getUserToken", "(Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetUserToken(global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/NonRepeatableRequestException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/NonRepeatableRequestException", AccessFlags = 33)]
		public partial class NonRepeatableRequestException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NonRepeatableRequestException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NonRepeatableRequestException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/RedirectException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/RedirectException", AccessFlags = 33)]
		public partial class RedirectException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RedirectException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RedirectException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public RedirectException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

}

