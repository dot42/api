#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Client
{
		/// <java-name>
		/// org/apache/http/impl/client/AbstractAuthenticationHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/AbstractAuthenticationHandler", AccessFlags = 1057)]
		public abstract partial class AbstractAuthenticationHandler : global::Org.Apache.Http.Client.IAuthenticationHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractAuthenticationHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseChallenges
				/// </java-name>
				[Dot42.DexImport("parseChallenges", "([Lorg/apache/http/Header;)Ljava/util/Map;", AccessFlags = 4, Signature = "([Lorg/apache/http/Header;)Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/Head" +
    "er;>;")]
				protected internal virtual global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> ParseChallenges(global::Org.Apache.Http.IHeader[] header) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// selectScheme
				/// </java-name>
				[Dot42.DexImport("selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpConte" +
    "xt;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/Header;>;Lorg/apache/http/Http" +
    "Response;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme" +
    ";")]
				public virtual global::Org.Apache.Http.Auth.IAuthScheme SelectScheme(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> map, global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

				[Dot42.DexImport("org/apache/http/client/AuthenticationHandler", "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				public virtual bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/client/AuthenticationHandler", "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1025, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				public virtual global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// getAuthPreferences
				/// </java-name>
				protected internal virtual global::Java.Util.IList<string> AuthPreferences
				{
						[Dot42.DexImport("getAuthPreferences", "()Ljava/util/List;", AccessFlags = 4, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IList<string>); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/AbstractHttpClient
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/AbstractHttpClient", AccessFlags = 1057)]
		public abstract partial class AbstractHttpClient : global::Org.Apache.Http.Client.IHttpClient
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams" +
    ";)V", AccessFlags = 4)]
				protected internal AbstractHttpClient(global::Org.Apache.Http.Conn.IClientConnectionManager clientConnectionManager, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createHttpParams
				/// </java-name>
				[Dot42.DexImport("createHttpParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Params.IHttpParams CreateHttpParams() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createHttpContext
				/// </java-name>
				[Dot42.DexImport("createHttpContext", "()Lorg/apache/http/protocol/HttpContext;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Protocol.IHttpContext CreateHttpContext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createRequestExecutor
				/// </java-name>
				[Dot42.DexImport("createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Protocol.HttpRequestExecutor CreateRequestExecutor() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createClientConnectionManager
				/// </java-name>
				[Dot42.DexImport("createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Conn.IClientConnectionManager CreateClientConnectionManager() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createAuthSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Auth.AuthSchemeRegistry CreateAuthSchemeRegistry() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createCookieSpecRegistry
				/// </java-name>
				[Dot42.DexImport("createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Cookie.CookieSpecRegistry CreateCookieSpecRegistry() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createConnectionReuseStrategy
				/// </java-name>
				[Dot42.DexImport("createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.IConnectionReuseStrategy CreateConnectionReuseStrategy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createConnectionKeepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy CreateConnectionKeepAliveStrategy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createHttpProcessor
				/// </java-name>
				[Dot42.DexImport("createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Protocol.BasicHttpProcessor CreateHttpProcessor() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createHttpRequestRetryHandler
				/// </java-name>
				[Dot42.DexImport("createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.IHttpRequestRetryHandler CreateHttpRequestRetryHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createRedirectHandler
				/// </java-name>
				[Dot42.DexImport("createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.IRedirectHandler CreateRedirectHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createTargetAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.IAuthenticationHandler CreateTargetAuthenticationHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createProxyAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.IAuthenticationHandler CreateProxyAuthenticationHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createCookieStore
				/// </java-name>
				[Dot42.DexImport("createCookieStore", "()Lorg/apache/http/client/CookieStore;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.ICookieStore CreateCookieStore() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createCredentialsProvider
				/// </java-name>
				[Dot42.DexImport("createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.ICredentialsProvider CreateCredentialsProvider() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createHttpRoutePlanner
				/// </java-name>
				[Dot42.DexImport("createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner CreateHttpRoutePlanner() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createUserTokenHandler
				/// </java-name>
				[Dot42.DexImport("createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.Client.IUserTokenHandler CreateUserTokenHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setParams
				/// </java-name>
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 33)]
				public virtual void SetParams(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReuseStrategy
				/// </java-name>
				[Dot42.DexImport("setReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V", AccessFlags = 33)]
				public virtual void SetReuseStrategy(global::Org.Apache.Http.IConnectionReuseStrategy connectionReuseStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("setKeepAliveStrategy", "(Lorg/apache/http/conn/ConnectionKeepAliveStrategy;)V", AccessFlags = 33)]
				public virtual void SetKeepAliveStrategy(global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy connectionKeepAliveStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", AccessFlags = 33)]
				public virtual void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor httpResponseInterceptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", AccessFlags = 33)]
				public virtual void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor httpResponseInterceptor, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", AccessFlags = 33)]
				public virtual global::Org.Apache.Http.IHttpResponseInterceptor GetResponseInterceptor(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponseInterceptor);
				}

				/// <java-name>
				/// clearResponseInterceptors
				/// </java-name>
				[Dot42.DexImport("clearResponseInterceptors", "()V", AccessFlags = 33)]
				public virtual void ClearResponseInterceptors() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeResponseInterceptorByClass
				/// </java-name>
				[Dot42.DexImport("removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Lorg/apache/http/HttpResponseInterceptor;>;)V")]
				public virtual void RemoveResponseInterceptorByClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", AccessFlags = 33)]
				public virtual void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor httpRequestInterceptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", AccessFlags = 33)]
				public virtual void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor httpRequestInterceptor, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", AccessFlags = 33)]
				public virtual global::Org.Apache.Http.IHttpRequestInterceptor GetRequestInterceptor(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequestInterceptor);
				}

				/// <java-name>
				/// clearRequestInterceptors
				/// </java-name>
				[Dot42.DexImport("clearRequestInterceptors", "()V", AccessFlags = 33)]
				public virtual void ClearRequestInterceptors() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeRequestInterceptorByClass
				/// </java-name>
				[Dot42.DexImport("removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Lorg/apache/http/HttpRequestInterceptor;>;)V")]
				public virtual void RemoveRequestInterceptorByClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpCon" +
    "text;)Lorg/apache/http/HttpResponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpRes" +
    "ponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// createClientRequestDirector
				/// </java-name>
				[Dot42.DexImport("createClientRequestDirector", @"(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/client/RequestDirector;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Client.IRequestDirector CreateClientRequestDirector(global::Org.Apache.Http.Protocol.HttpRequestExecutor httpRequestExecutor, global::Org.Apache.Http.Conn.IClientConnectionManager clientConnectionManager, global::Org.Apache.Http.IConnectionReuseStrategy connectionReuseStrategy, global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy connectionKeepAliveStrategy, global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner httpRoutePlanner, global::Org.Apache.Http.Protocol.IHttpProcessor httpProcessor, global::Org.Apache.Http.Client.IHttpRequestRetryHandler httpRequestRetryHandler, global::Org.Apache.Http.Client.IRedirectHandler redirectHandler, global::Org.Apache.Http.Client.IAuthenticationHandler authenticationHandler, global::Org.Apache.Http.Client.IAuthenticationHandler authenticationHandler1, global::Org.Apache.Http.Client.IUserTokenHandler userTokenHandler, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IRequestDirector);
				}

				/// <java-name>
				/// determineParams
				/// </java-name>
				[Dot42.DexImport("determineParams", "(Lorg/apache/http/HttpRequest;)Lorg/apache/http/params/HttpParams;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Params.IHttpParams DetermineParams(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;)TT;")]
				public virtual T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext;)TT;")]
				public virtual T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest httpUriRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;)TT;")]
				public virtual T Execute<T>(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler) /* MethodBuilder.Create */ 
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
				public virtual T Execute<T>(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbstractHttpClient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams Params
				{
						[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
				}

				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				public global::Org.Apache.Http.Conn.IClientConnectionManager ConnectionManager
				{
						[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Conn.IClientConnectionManager); }
				}

				/// <java-name>
				/// getRequestExecutor
				/// </java-name>
				public global::Org.Apache.Http.Protocol.HttpRequestExecutor RequestExecutor
				{
						[Dot42.DexImport("getRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Protocol.HttpRequestExecutor); }
				}

				/// <java-name>
				/// getAuthSchemes
				/// </java-name>
				public virtual global::Org.Apache.Http.Auth.AuthSchemeRegistry AuthSchemes
				{
						[Dot42.DexImport("getAuthSchemes", "()Lorg/apache/http/auth/AuthSchemeRegistry;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Auth.AuthSchemeRegistry); }
						[Dot42.DexImport("setAuthSchemes", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getCookieSpecs
				/// </java-name>
				public virtual global::Org.Apache.Http.Cookie.CookieSpecRegistry CookieSpecs
				{
						[Dot42.DexImport("getCookieSpecs", "()Lorg/apache/http/cookie/CookieSpecRegistry;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Cookie.CookieSpecRegistry); }
						[Dot42.DexImport("setCookieSpecs", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getConnectionReuseStrategy
				/// </java-name>
				public global::Org.Apache.Http.IConnectionReuseStrategy ConnectionReuseStrategy
				{
						[Dot42.DexImport("getConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.IConnectionReuseStrategy); }
				}

				/// <java-name>
				/// getConnectionKeepAliveStrategy
				/// </java-name>
				public global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy ConnectionKeepAliveStrategy
				{
						[Dot42.DexImport("getConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy); }
				}

				/// <java-name>
				/// getHttpRequestRetryHandler
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.IHttpRequestRetryHandler HttpRequestRetryHandler
				{
						[Dot42.DexImport("getHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.IHttpRequestRetryHandler); }
						[Dot42.DexImport("setHttpRequestRetryHandler", "(Lorg/apache/http/client/HttpRequestRetryHandler;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getRedirectHandler
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.IRedirectHandler RedirectHandler
				{
						[Dot42.DexImport("getRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.IRedirectHandler); }
						[Dot42.DexImport("setRedirectHandler", "(Lorg/apache/http/client/RedirectHandler;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getTargetAuthenticationHandler
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.IAuthenticationHandler TargetAuthenticationHandler
				{
						[Dot42.DexImport("getTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.IAuthenticationHandler); }
						[Dot42.DexImport("setTargetAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getProxyAuthenticationHandler
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.IAuthenticationHandler ProxyAuthenticationHandler
				{
						[Dot42.DexImport("getProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.IAuthenticationHandler); }
						[Dot42.DexImport("setProxyAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getCookieStore
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.ICookieStore CookieStore
				{
						[Dot42.DexImport("getCookieStore", "()Lorg/apache/http/client/CookieStore;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.ICookieStore); }
						[Dot42.DexImport("setCookieStore", "(Lorg/apache/http/client/CookieStore;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getCredentialsProvider
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.ICredentialsProvider CredentialsProvider
				{
						[Dot42.DexImport("getCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.ICredentialsProvider); }
						[Dot42.DexImport("setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getRoutePlanner
				/// </java-name>
				public virtual global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner RoutePlanner
				{
						[Dot42.DexImport("getRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner); }
						[Dot42.DexImport("setRoutePlanner", "(Lorg/apache/http/conn/routing/HttpRoutePlanner;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getUserTokenHandler
				/// </java-name>
				public virtual global::Org.Apache.Http.Client.IUserTokenHandler UserTokenHandler
				{
						[Dot42.DexImport("getUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", AccessFlags = 49)]
						get{ return default(global::Org.Apache.Http.Client.IUserTokenHandler); }
						[Dot42.DexImport("setUserTokenHandler", "(Lorg/apache/http/client/UserTokenHandler;)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getHttpProcessor
				/// </java-name>
				protected internal global::Org.Apache.Http.Protocol.BasicHttpProcessor HttpProcessor
				{
						[Dot42.DexImport("getHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", AccessFlags = 52)]
						get{ return default(global::Org.Apache.Http.Protocol.BasicHttpProcessor); }
				}

				/// <java-name>
				/// getResponseInterceptorCount
				/// </java-name>
				public virtual int ResponseInterceptorCount
				{
						[Dot42.DexImport("getResponseInterceptorCount", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRequestInterceptorCount
				/// </java-name>
				public virtual int RequestInterceptorCount
				{
						[Dot42.DexImport("getRequestInterceptorCount", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/BasicCookieStore
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/BasicCookieStore", AccessFlags = 33)]
		public partial class BasicCookieStore : global::Org.Apache.Http.Client.ICookieStore
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicCookieStore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCookie
				/// </java-name>
				[Dot42.DexImport("addCookie", "(Lorg/apache/http/cookie/Cookie;)V", AccessFlags = 33)]
				public virtual void AddCookie(global::Org.Apache.Http.Cookie.ICookie cookie) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCookies
				/// </java-name>
				[Dot42.DexImport("addCookies", "([Lorg/apache/http/cookie/Cookie;)V", AccessFlags = 33)]
				public virtual void AddCookies(global::Org.Apache.Http.Cookie.ICookie[] cookie) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearExpired
				/// </java-name>
				[Dot42.DexImport("clearExpired", "(Ljava/util/Date;)Z", AccessFlags = 33)]
				public virtual bool ClearExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookies
				/// </java-name>
				public virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Cookies
				{
						[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;")]
						get{ return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/BasicCredentialsProvider
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/BasicCredentialsProvider", AccessFlags = 33)]
		public partial class BasicCredentialsProvider : global::Org.Apache.Http.Client.ICredentialsProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicCredentialsProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCredentials
				/// </java-name>
				[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V", AccessFlags = 33)]
				public virtual void SetCredentials(global::Org.Apache.Http.Auth.AuthScope authScope, global::Org.Apache.Http.Auth.ICredentials credentials) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCredentials
				/// </java-name>
				[Dot42.DexImport("getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;", AccessFlags = 33)]
				public virtual global::Org.Apache.Http.Auth.ICredentials GetCredentials(global::Org.Apache.Http.Auth.AuthScope authScope) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.ICredentials);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/BasicResponseHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/BasicResponseHandler", AccessFlags = 33, Signature = "Ljava/lang/Object;Lorg/apache/http/client/ResponseHandler<Ljava/lang/String;>;")]
		public partial class BasicResponseHandler : global::Org.Apache.Http.Client.IResponseHandler<string>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicResponseHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleResponse
				/// </java-name>
				[Dot42.DexImport("handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string HandleResponse(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/ClientParamsStack
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/ClientParamsStack", AccessFlags = 33)]
		public partial class ClientParamsStack : global::Org.Apache.Http.Params.AbstractHttpParams
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// applicationParams
				/// </java-name>
				[Dot42.DexImport("applicationParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams @applicationParams;
				/// <java-name>
				/// clientParams
				/// </java-name>
				[Dot42.DexImport("clientParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams @clientParams;
				/// <java-name>
				/// requestParams
				/// </java-name>
				[Dot42.DexImport("requestParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams @requestParams;
				/// <java-name>
				/// overrideParams
				/// </java-name>
				[Dot42.DexImport("overrideParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams @overrideParams;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apach" +
    "e/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ClientParamsStack(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Params.IHttpParams httpParams1, global::Org.Apache.Http.Params.IHttpParams httpParams2, global::Org.Apache.Http.Params.IHttpParams httpParams3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;)V", AccessFlags = 1)]
				public ClientParamsStack(global::Org.Apache.Http.Impl.Client.ClientParamsStack clientParamsStack) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;Lorg/apache/http/params/HttpParam" +
    "s;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apa" +
    "che/http/params/HttpParams;)V", AccessFlags = 1)]
				public ClientParamsStack(global::Org.Apache.Http.Impl.Client.ClientParamsStack clientParamsStack, global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Params.IHttpParams httpParams1, global::Org.Apache.Http.Params.IHttpParams httpParams2, global::Org.Apache.Http.Params.IHttpParams httpParams3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams SetParameter(string @string, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool RemoveParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ClientParamsStack() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getApplicationParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams ApplicationParams
				{
						[Dot42.DexImport("getApplicationParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
				}

				/// <java-name>
				/// getClientParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams ClientParams
				{
						[Dot42.DexImport("getClientParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
				}

				/// <java-name>
				/// getRequestParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams RequestParams
				{
						[Dot42.DexImport("getRequestParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
				}

				/// <java-name>
				/// getOverrideParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams OverrideParams
				{
						[Dot42.DexImport("getOverrideParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultConnectionKeepAliveStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultConnectionKeepAliveStrategy", AccessFlags = 33)]
		public partial class DefaultConnectionKeepAliveStrategy : global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultConnectionKeepAliveStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeepAliveDuration
				/// </java-name>
				[Dot42.DexImport("getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J", AccessFlags = 1)]
				public virtual long GetKeepAliveDuration(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultHttpClient
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultHttpClient", AccessFlags = 33)]
		public partial class DefaultHttpClient : global::Org.Apache.Http.Impl.Client.AbstractHttpClient
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams" +
    ";)V", AccessFlags = 1)]
				public DefaultHttpClient(global::Org.Apache.Http.Conn.IClientConnectionManager clientConnectionManager, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultHttpClient(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpClient() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createHttpParams
				/// </java-name>
				[Dot42.DexImport("createHttpParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Params.IHttpParams CreateHttpParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// createRequestExecutor
				/// </java-name>
				[Dot42.DexImport("createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Protocol.HttpRequestExecutor CreateRequestExecutor() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.HttpRequestExecutor);
				}

				/// <java-name>
				/// createClientConnectionManager
				/// </java-name>
				[Dot42.DexImport("createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Conn.IClientConnectionManager CreateClientConnectionManager() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionManager);
				}

				/// <java-name>
				/// createHttpContext
				/// </java-name>
				[Dot42.DexImport("createHttpContext", "()Lorg/apache/http/protocol/HttpContext;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Protocol.IHttpContext CreateHttpContext() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.IHttpContext);
				}

				/// <java-name>
				/// createConnectionReuseStrategy
				/// </java-name>
				[Dot42.DexImport("createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IConnectionReuseStrategy CreateConnectionReuseStrategy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IConnectionReuseStrategy);
				}

				/// <java-name>
				/// createConnectionKeepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy CreateConnectionKeepAliveStrategy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy);
				}

				/// <java-name>
				/// createAuthSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Auth.AuthSchemeRegistry CreateAuthSchemeRegistry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.AuthSchemeRegistry);
				}

				/// <java-name>
				/// createCookieSpecRegistry
				/// </java-name>
				[Dot42.DexImport("createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Cookie.CookieSpecRegistry CreateCookieSpecRegistry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.CookieSpecRegistry);
				}

				/// <java-name>
				/// createHttpProcessor
				/// </java-name>
				[Dot42.DexImport("createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Protocol.BasicHttpProcessor CreateHttpProcessor() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.BasicHttpProcessor);
				}

				/// <java-name>
				/// createHttpRequestRetryHandler
				/// </java-name>
				[Dot42.DexImport("createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.IHttpRequestRetryHandler CreateHttpRequestRetryHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IHttpRequestRetryHandler);
				}

				/// <java-name>
				/// createRedirectHandler
				/// </java-name>
				[Dot42.DexImport("createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.IRedirectHandler CreateRedirectHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IRedirectHandler);
				}

				/// <java-name>
				/// createTargetAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.IAuthenticationHandler CreateTargetAuthenticationHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IAuthenticationHandler);
				}

				/// <java-name>
				/// createProxyAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.IAuthenticationHandler CreateProxyAuthenticationHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IAuthenticationHandler);
				}

				/// <java-name>
				/// createCookieStore
				/// </java-name>
				[Dot42.DexImport("createCookieStore", "()Lorg/apache/http/client/CookieStore;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.ICookieStore CreateCookieStore() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.ICookieStore);
				}

				/// <java-name>
				/// createCredentialsProvider
				/// </java-name>
				[Dot42.DexImport("createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.ICredentialsProvider CreateCredentialsProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.ICredentialsProvider);
				}

				/// <java-name>
				/// createHttpRoutePlanner
				/// </java-name>
				[Dot42.DexImport("createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner CreateHttpRoutePlanner() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner);
				}

				/// <java-name>
				/// createUserTokenHandler
				/// </java-name>
				[Dot42.DexImport("createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Client.IUserTokenHandler CreateUserTokenHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IUserTokenHandler);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultHttpRequestRetryHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultHttpRequestRetryHandler", AccessFlags = 33)]
		public partial class DefaultHttpRequestRetryHandler : global::Org.Apache.Http.Client.IHttpRequestRetryHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public DefaultHttpRequestRetryHandler(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpRequestRetryHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// retryRequest
				/// </java-name>
				[Dot42.DexImport("retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public virtual bool RetryRequest(global::System.IO.IOException iOException, int int32, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isRequestSentRetryEnabled
				/// </java-name>
				public virtual bool IsRequestSentRetryEnabled
				{
						[Dot42.DexImport("isRequestSentRetryEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getRetryCount
				/// </java-name>
				public virtual int RetryCount
				{
						[Dot42.DexImport("getRetryCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultProxyAuthenticationHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultProxyAuthenticationHandler", AccessFlags = 33)]
		public partial class DefaultProxyAuthenticationHandler : global::Org.Apache.Http.Impl.Client.AbstractAuthenticationHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultProxyAuthenticationHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAuthenticationRequested
				/// </java-name>
				[Dot42.DexImport("isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public override bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getChallenges
				/// </java-name>
				[Dot42.DexImport("getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				public override global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultRedirectHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultRedirectHandler", AccessFlags = 33)]
		public partial class DefaultRedirectHandler : global::Org.Apache.Http.Client.IRedirectHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultRedirectHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRedirectRequested
				/// </java-name>
				[Dot42.DexImport("isRedirectRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public virtual bool IsRedirectRequested(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLocationURI
				/// </java-name>
				[Dot42.DexImport("getLocationURI", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/net/U" +
    "RI;", AccessFlags = 1)]
				public virtual global::System.Uri GetLocationURI(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultRequestDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultRequestDirector", AccessFlags = 33)]
		public partial class DefaultRequestDirector : global::Org.Apache.Http.Client.IRequestDirector
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// connManager
				/// </java-name>
				[Dot42.DexImport("connManager", "Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IClientConnectionManager ConnManager;
				/// <java-name>
				/// routePlanner
				/// </java-name>
				[Dot42.DexImport("routePlanner", "Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner RoutePlanner;
				/// <java-name>
				/// reuseStrategy
				/// </java-name>
				[Dot42.DexImport("reuseStrategy", "Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IConnectionReuseStrategy ReuseStrategy;
				/// <java-name>
				/// keepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("keepAliveStrategy", "Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy KeepAliveStrategy;
				/// <java-name>
				/// requestExec
				/// </java-name>
				[Dot42.DexImport("requestExec", "Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Protocol.HttpRequestExecutor RequestExec;
				/// <java-name>
				/// httpProcessor
				/// </java-name>
				[Dot42.DexImport("httpProcessor", "Lorg/apache/http/protocol/HttpProcessor;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Protocol.IHttpProcessor HttpProcessor;
				/// <java-name>
				/// retryHandler
				/// </java-name>
				[Dot42.DexImport("retryHandler", "Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Client.IHttpRequestRetryHandler RetryHandler;
				/// <java-name>
				/// redirectHandler
				/// </java-name>
				[Dot42.DexImport("redirectHandler", "Lorg/apache/http/client/RedirectHandler;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Client.IRedirectHandler RedirectHandler;
				/// <java-name>
				/// params
				/// </java-name>
				[Dot42.DexImport("params", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams Params;
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IManagedClientConnection ManagedConn;
				[Dot42.DexImport("<init>", @"(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultRequestDirector(global::Org.Apache.Http.Protocol.HttpRequestExecutor httpRequestExecutor, global::Org.Apache.Http.Conn.IClientConnectionManager clientConnectionManager, global::Org.Apache.Http.IConnectionReuseStrategy connectionReuseStrategy, global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy connectionKeepAliveStrategy, global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner httpRoutePlanner, global::Org.Apache.Http.Protocol.IHttpProcessor httpProcessor, global::Org.Apache.Http.Client.IHttpRequestRetryHandler httpRequestRetryHandler, global::Org.Apache.Http.Client.IRedirectHandler redirectHandler, global::Org.Apache.Http.Client.IAuthenticationHandler authenticationHandler, global::Org.Apache.Http.Client.IAuthenticationHandler authenticationHandler1, global::Org.Apache.Http.Client.IUserTokenHandler userTokenHandler, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rewriteRequestURI
				/// </java-name>
				[Dot42.DexImport("rewriteRequestURI", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRo" +
    "ute;)V", AccessFlags = 4)]
				protected internal virtual void RewriteRequestURI(global::Org.Apache.Http.Impl.Client.RequestWrapper requestWrapper, global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 4)]
				protected internal virtual void ReleaseConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// establishRoute
				/// </java-name>
				[Dot42.DexImport("establishRoute", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)V" +
    "", AccessFlags = 4)]
				protected internal virtual void EstablishRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createTunnelToTarget
				/// </java-name>
				[Dot42.DexImport("createTunnelToTarget", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)Z" +
    "", AccessFlags = 4)]
				protected internal virtual bool CreateTunnelToTarget(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createTunnelToProxy
				/// </java-name>
				[Dot42.DexImport("createTunnelToProxy", "(Lorg/apache/http/conn/routing/HttpRoute;ILorg/apache/http/protocol/HttpContext;)" +
    "Z", AccessFlags = 4)]
				protected internal virtual bool CreateTunnelToProxy(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, int int32, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createConnectRequest
				/// </java-name>
				[Dot42.DexImport("createConnectRequest", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)L" +
    "org/apache/http/HttpRequest;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHttpRequest CreateConnectRequest(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

				/// <java-name>
				/// handleResponse
				/// </java-name>
				[Dot42.DexImport("handleResponse", "(Lorg/apache/http/impl/client/RoutedRequest;Lorg/apache/http/HttpResponse;Lorg/ap" +
    "ache/http/protocol/HttpContext;)Lorg/apache/http/impl/client/RoutedRequest;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Client.RoutedRequest HandleResponse(global::Org.Apache.Http.Impl.Client.RoutedRequest routedRequest, global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Client.RoutedRequest);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DefaultRequestDirector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultTargetAuthenticationHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultTargetAuthenticationHandler", AccessFlags = 33)]
		public partial class DefaultTargetAuthenticationHandler : global::Org.Apache.Http.Impl.Client.AbstractAuthenticationHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultTargetAuthenticationHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAuthenticationRequested
				/// </java-name>
				[Dot42.DexImport("isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public override bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getChallenges
				/// </java-name>
				[Dot42.DexImport("getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				public override global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/DefaultUserTokenHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultUserTokenHandler", AccessFlags = 33)]
		public partial class DefaultUserTokenHandler : global::Org.Apache.Http.Client.IUserTokenHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultUserTokenHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserToken
				/// </java-name>
				[Dot42.DexImport("getUserToken", "(Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetUserToken(global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/EntityEnclosingRequestWrapper
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/EntityEnclosingRequestWrapper", AccessFlags = 33)]
		public partial class EntityEnclosingRequestWrapper : global::Org.Apache.Http.Impl.Client.RequestWrapper, global::Org.Apache.Http.IHttpEntityEnclosingRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public EntityEnclosingRequestWrapper(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// expectContinue
				/// </java-name>
				[Dot42.DexImport("expectContinue", "()Z", AccessFlags = 1)]
				public virtual bool ExpectContinue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal EntityEnclosingRequestWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				public virtual global::Org.Apache.Http.IHttpEntity Entity
				{
						[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHttpEntity); }
						[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				public override global::Org.Apache.Http.IRequestLine RequestLine
				{
						[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.IRequestLine); }
				}

				public override global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
						[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.ProtocolVersion); }
				}

				public override global::Org.Apache.Http.IHeader[] AllHeaders
				{
						[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.IHeader[]); }
				}

				public override global::Org.Apache.Http.Params.IHttpParams Params
				{
						[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
						[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
						set{ }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/RedirectLocations
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/RedirectLocations", AccessFlags = 33)]
		public partial class RedirectLocations
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RedirectLocations() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/net/URI;)Z", AccessFlags = 1)]
				public virtual bool Contains(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public virtual void Add(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/net/URI;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/RequestWrapper
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/RequestWrapper", AccessFlags = 33)]
		public partial class RequestWrapper : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.Client.Methods.IHttpUriRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public RequestWrapper(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetHeaders
				/// </java-name>
				[Dot42.DexImport("resetHeaders", "()V", AccessFlags = 1)]
				public virtual void ResetHeaders() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMethod
				/// </java-name>
				[Dot42.DexImport("setMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetMethod(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProtocolVersion
				/// </java-name>
				[Dot42.DexImport("setProtocolVersion", "(Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public virtual void SetProtocolVersion(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setURI
				/// </java-name>
				[Dot42.DexImport("setURI", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public virtual void SetURI(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1)]
				public virtual void Abort() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementExecCount
				/// </java-name>
				[Dot42.DexImport("incrementExecCount", "()V", AccessFlags = 1)]
				public virtual void IncrementExecCount() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RequestWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public virtual string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public override global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
						[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.ProtocolVersion); }
				}

				/// <java-name>
				/// getURI
				/// </java-name>
				public virtual global::System.Uri URI
				{
						[Dot42.DexImport("getURI", "()Ljava/net/URI;", AccessFlags = 1)]
						get{ return default(global::System.Uri); }
				}

				/// <java-name>
				/// getRequestLine
				/// </java-name>
				public virtual global::Org.Apache.Http.IRequestLine RequestLine
				{
						[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IRequestLine); }
				}

				/// <java-name>
				/// isAborted
				/// </java-name>
				public virtual bool IsAborted
				{
						[Dot42.DexImport("isAborted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getOriginal
				/// </java-name>
				public virtual global::Org.Apache.Http.IHttpRequest Original
				{
						[Dot42.DexImport("getOriginal", "()Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHttpRequest); }
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public virtual bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getExecCount
				/// </java-name>
				public virtual int ExecCount
				{
						[Dot42.DexImport("getExecCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				public override global::Org.Apache.Http.IHeader[] AllHeaders
				{
						[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.IHeader[]); }
				}

				public override global::Org.Apache.Http.Params.IHttpParams Params
				{
						[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.Params.IHttpParams); }
						[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
						set{ }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/RoutedRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/RoutedRequest", AccessFlags = 33)]
		public partial class RoutedRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// request
				/// </java-name>
				[Dot42.DexImport("request", "Lorg/apache/http/impl/client/RequestWrapper;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Impl.Client.RequestWrapper @request;
				/// <java-name>
				/// route
				/// </java-name>
				[Dot42.DexImport("route", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.Routing.HttpRoute @route;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRo" +
    "ute;)V", AccessFlags = 1)]
				public RoutedRequest(global::Org.Apache.Http.Impl.Client.RequestWrapper requestWrapper, global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RoutedRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRequest
				/// </java-name>
				public global::Org.Apache.Http.Impl.Client.RequestWrapper Request
				{
						[Dot42.DexImport("getRequest", "()Lorg/apache/http/impl/client/RequestWrapper;", AccessFlags = 17)]
						get{ return default(global::Org.Apache.Http.Impl.Client.RequestWrapper); }
				}

				/// <java-name>
				/// getRoute
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
						[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
						get{ return default(global::Org.Apache.Http.Conn.Routing.HttpRoute); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/client/TunnelRefusedException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/TunnelRefusedException", AccessFlags = 33)]
		public partial class TunnelRefusedException : global::Org.Apache.Http.HttpException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public TunnelRefusedException(string @string, global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TunnelRefusedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getResponse
				/// </java-name>
				public virtual global::Org.Apache.Http.IHttpResponse Response
				{
						[Dot42.DexImport("getResponse", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHttpResponse); }
				}

		}

}

