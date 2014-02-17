// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Client.cs
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
namespace Org.Apache.Http.Impl.Client
{
		/// <java-name>
		/// org/apache/http/impl/client/TunnelRefusedException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/TunnelRefusedException", AccessFlags = 33)]
		public partial class TunnelRefusedException : global::Org.Apache.Http.HttpException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public TunnelRefusedException(string message, global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getResponse
				/// </java-name>
				[Dot42.DexImport("getResponse", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse GetResponse() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TunnelRefusedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getResponse
				/// </java-name>
				public global::Org.Apache.Http.IHttpResponse Response
				{
				[Dot42.DexImport("getResponse", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
						get{ return GetResponse(); }
				}

		}

		/// <summary>
		/// <para>Convenience base class for HTTP client implementations.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>677250 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/AbstractHttpClient
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/AbstractHttpClient", AccessFlags = 1057)]
		public abstract partial class AbstractHttpClient : global::Org.Apache.Http.Client.IHttpClient
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new HTTP client.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams" +
    ";)V", AccessFlags = 4)]
				protected internal AbstractHttpClient(global::Org.Apache.Http.Conn.IClientConnectionManager conman, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Obtains the parameters for this client. These parameters will become defaults for all requests being executed with this client, and for the parameters of dependent objects in this client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default parameters </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 49)]
				public global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Replaces the parameters. The implementation here does not update parameters of dependent objects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParams
				/// </java-name>
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 33)]
				public virtual void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the connection manager used by this client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection manager </para>
				/// </returns>
				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.IClientConnectionManager GetConnectionManager() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionManager);
				}

				/// <java-name>
				/// getRequestExecutor
				/// </java-name>
				[Dot42.DexImport("getRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 49)]
				public global::Org.Apache.Http.Protocol.HttpRequestExecutor GetRequestExecutor() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.HttpRequestExecutor);
				}

				/// <java-name>
				/// getAuthSchemes
				/// </java-name>
				[Dot42.DexImport("getAuthSchemes", "()Lorg/apache/http/auth/AuthSchemeRegistry;", AccessFlags = 49)]
				public global::Org.Apache.Http.Auth.AuthSchemeRegistry GetAuthSchemes() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.AuthSchemeRegistry);
				}

				/// <java-name>
				/// setAuthSchemes
				/// </java-name>
				[Dot42.DexImport("setAuthSchemes", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V", AccessFlags = 33)]
				public virtual void SetAuthSchemes(global::Org.Apache.Http.Auth.AuthSchemeRegistry authSchemeRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookieSpecs
				/// </java-name>
				[Dot42.DexImport("getCookieSpecs", "()Lorg/apache/http/cookie/CookieSpecRegistry;", AccessFlags = 49)]
				public global::Org.Apache.Http.Cookie.CookieSpecRegistry GetCookieSpecs() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.CookieSpecRegistry);
				}

				/// <java-name>
				/// setCookieSpecs
				/// </java-name>
				[Dot42.DexImport("setCookieSpecs", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V", AccessFlags = 33)]
				public virtual void SetCookieSpecs(global::Org.Apache.Http.Cookie.CookieSpecRegistry cookieSpecRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnectionReuseStrategy
				/// </java-name>
				[Dot42.DexImport("getConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 49)]
				public global::Org.Apache.Http.IConnectionReuseStrategy GetConnectionReuseStrategy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IConnectionReuseStrategy);
				}

				/// <java-name>
				/// setReuseStrategy
				/// </java-name>
				[Dot42.DexImport("setReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V", AccessFlags = 33)]
				public virtual void SetReuseStrategy(global::Org.Apache.Http.IConnectionReuseStrategy reuseStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnectionKeepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("getConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy GetConnectionKeepAliveStrategy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy);
				}

				/// <java-name>
				/// setKeepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("setKeepAliveStrategy", "(Lorg/apache/http/conn/ConnectionKeepAliveStrategy;)V", AccessFlags = 33)]
				public virtual void SetKeepAliveStrategy(global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy keepAliveStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHttpRequestRetryHandler
				/// </java-name>
				[Dot42.DexImport("getHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.IHttpRequestRetryHandler GetHttpRequestRetryHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IHttpRequestRetryHandler);
				}

				/// <java-name>
				/// setHttpRequestRetryHandler
				/// </java-name>
				[Dot42.DexImport("setHttpRequestRetryHandler", "(Lorg/apache/http/client/HttpRequestRetryHandler;)V", AccessFlags = 33)]
				public virtual void SetHttpRequestRetryHandler(global::Org.Apache.Http.Client.IHttpRequestRetryHandler retryHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRedirectHandler
				/// </java-name>
				[Dot42.DexImport("getRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.IRedirectHandler GetRedirectHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IRedirectHandler);
				}

				/// <java-name>
				/// setRedirectHandler
				/// </java-name>
				[Dot42.DexImport("setRedirectHandler", "(Lorg/apache/http/client/RedirectHandler;)V", AccessFlags = 33)]
				public virtual void SetRedirectHandler(global::Org.Apache.Http.Client.IRedirectHandler redirectHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("getTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.IAuthenticationHandler GetTargetAuthenticationHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IAuthenticationHandler);
				}

				/// <java-name>
				/// setTargetAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("setTargetAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", AccessFlags = 33)]
				public virtual void SetTargetAuthenticationHandler(global::Org.Apache.Http.Client.IAuthenticationHandler targetAuthHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProxyAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("getProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.IAuthenticationHandler GetProxyAuthenticationHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IAuthenticationHandler);
				}

				/// <java-name>
				/// setProxyAuthenticationHandler
				/// </java-name>
				[Dot42.DexImport("setProxyAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", AccessFlags = 33)]
				public virtual void SetProxyAuthenticationHandler(global::Org.Apache.Http.Client.IAuthenticationHandler proxyAuthHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookieStore
				/// </java-name>
				[Dot42.DexImport("getCookieStore", "()Lorg/apache/http/client/CookieStore;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.ICookieStore GetCookieStore() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.ICookieStore);
				}

				/// <java-name>
				/// setCookieStore
				/// </java-name>
				[Dot42.DexImport("setCookieStore", "(Lorg/apache/http/client/CookieStore;)V", AccessFlags = 33)]
				public virtual void SetCookieStore(global::Org.Apache.Http.Client.ICookieStore cookieStore) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCredentialsProvider
				/// </java-name>
				[Dot42.DexImport("getCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.ICredentialsProvider GetCredentialsProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.ICredentialsProvider);
				}

				/// <java-name>
				/// setCredentialsProvider
				/// </java-name>
				[Dot42.DexImport("setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V", AccessFlags = 33)]
				public virtual void SetCredentialsProvider(global::Org.Apache.Http.Client.ICredentialsProvider credsProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoutePlanner
				/// </java-name>
				[Dot42.DexImport("getRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner GetRoutePlanner() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner);
				}

				/// <java-name>
				/// setRoutePlanner
				/// </java-name>
				[Dot42.DexImport("setRoutePlanner", "(Lorg/apache/http/conn/routing/HttpRoutePlanner;)V", AccessFlags = 33)]
				public virtual void SetRoutePlanner(global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner routePlanner) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserTokenHandler
				/// </java-name>
				[Dot42.DexImport("getUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", AccessFlags = 49)]
				public global::Org.Apache.Http.Client.IUserTokenHandler GetUserTokenHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IUserTokenHandler);
				}

				/// <java-name>
				/// setUserTokenHandler
				/// </java-name>
				[Dot42.DexImport("setUserTokenHandler", "(Lorg/apache/http/client/UserTokenHandler;)V", AccessFlags = 33)]
				public virtual void SetUserTokenHandler(global::Org.Apache.Http.Client.IUserTokenHandler userTokenHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHttpProcessor
				/// </java-name>
				[Dot42.DexImport("getHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", AccessFlags = 52)]
				protected internal global::Org.Apache.Http.Protocol.BasicHttpProcessor GetHttpProcessor() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.BasicHttpProcessor);
				}

				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", AccessFlags = 33)]
				public virtual void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor itcp) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", AccessFlags = 33)]
				public virtual void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor itcp, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", AccessFlags = 33)]
				public virtual global::Org.Apache.Http.IHttpResponseInterceptor GetResponseInterceptor(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponseInterceptor);
				}

				/// <java-name>
				/// getResponseInterceptorCount
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptorCount", "()I", AccessFlags = 33)]
				public virtual int GetResponseInterceptorCount() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				public virtual void RemoveResponseInterceptorByClass(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", AccessFlags = 33)]
				public virtual void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor itcp) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", AccessFlags = 33)]
				public virtual void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor itcp, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", AccessFlags = 33)]
				public virtual global::Org.Apache.Http.IHttpRequestInterceptor GetRequestInterceptor(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequestInterceptor);
				}

				/// <java-name>
				/// getRequestInterceptorCount
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptorCount", "()I", AccessFlags = 33)]
				public virtual int GetRequestInterceptorCount() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				public virtual void RemoveRequestInterceptorByClass(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Executes a request using the default context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Maps to execute(target, request, context). The target is determined from the URI of the request.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpCon" +
    "text;)Lorg/apache/http/HttpResponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Maps to execute(target, request, context). The target is determined from the URI of the request.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpRes" +
    "ponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost request, global::Org.Apache.Http.IHttpRequest context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Executes a request to the target using the given context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 17)]
				public global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// createClientRequestDirector
				/// </java-name>
				[Dot42.DexImport("createClientRequestDirector", @"(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/client/RequestDirector;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Client.IRequestDirector CreateClientRequestDirector(global::Org.Apache.Http.Protocol.HttpRequestExecutor requestExec, global::Org.Apache.Http.Conn.IClientConnectionManager conman, global::Org.Apache.Http.IConnectionReuseStrategy reustrat, global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy kastrat, global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner rouplan, global::Org.Apache.Http.Protocol.IHttpProcessor httpProcessor, global::Org.Apache.Http.Client.IHttpRequestRetryHandler retryHandler, global::Org.Apache.Http.Client.IRedirectHandler redirectHandler, global::Org.Apache.Http.Client.IAuthenticationHandler targetAuthHandler, global::Org.Apache.Http.Client.IAuthenticationHandler proxyAuthHandler, global::Org.Apache.Http.Client.IUserTokenHandler stateHandler, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Client.IRequestDirector);
				}

				/// <summary>
				/// <para>Obtains parameters for executing a request. The default implementation in this class creates a new ClientParamsStack from the request parameters and the client parameters. <br></br> This method is called by the default implementation of execute(HttpHost,HttpRequest,HttpContext) to obtain the parameters for the DefaultRequestDirector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters to use </para>
				/// </returns>
				/// <java-name>
				/// determineParams
				/// </java-name>
				[Dot42.DexImport("determineParams", "(Lorg/apache/http/HttpRequest;)Lorg/apache/http/params/HttpParams;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Params.IHttpParams DetermineParams(global::Org.Apache.Http.IHttpRequest req) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Maps to execute(target, request, context). The target is determined from the URI of the request.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;)TT;")]
				public virtual T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> context) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Executes a request to the target using the given context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext;)TT;")]
				public virtual T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest target, global::Org.Apache.Http.Client.IResponseHandler<T> request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Executes a request to the target using the given context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;)TT;")]
				public virtual T Execute<T>(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> context) /* MethodBuilder.Create */ 
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
				public virtual T Execute<T>(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractHttpClient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Obtains the parameters for this client. These parameters will become defaults for all requests being executed with this client, and for the parameters of dependent objects in this client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default parameters </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams Params
				{
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 49)]
						get{ return GetParams(); }
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 33)]
						set{ SetParams(value); }
				}

				/// <summary>
				/// <para>Obtains the connection manager used by this client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection manager </para>
				/// </returns>
				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				public global::Org.Apache.Http.Conn.IClientConnectionManager ConnectionManager
				{
				[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 49)]
						get{ return GetConnectionManager(); }
				}

				/// <java-name>
				/// getRequestExecutor
				/// </java-name>
				public global::Org.Apache.Http.Protocol.HttpRequestExecutor RequestExecutor
				{
				[Dot42.DexImport("getRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 49)]
						get{ return GetRequestExecutor(); }
				}

				/// <java-name>
				/// getAuthSchemes
				/// </java-name>
				public global::Org.Apache.Http.Auth.AuthSchemeRegistry AuthSchemes
				{
				[Dot42.DexImport("getAuthSchemes", "()Lorg/apache/http/auth/AuthSchemeRegistry;", AccessFlags = 49)]
						get{ return GetAuthSchemes(); }
				[Dot42.DexImport("setAuthSchemes", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V", AccessFlags = 33)]
						set{ SetAuthSchemes(value); }
				}

				/// <java-name>
				/// getCookieSpecs
				/// </java-name>
				public global::Org.Apache.Http.Cookie.CookieSpecRegistry CookieSpecs
				{
				[Dot42.DexImport("getCookieSpecs", "()Lorg/apache/http/cookie/CookieSpecRegistry;", AccessFlags = 49)]
						get{ return GetCookieSpecs(); }
				[Dot42.DexImport("setCookieSpecs", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V", AccessFlags = 33)]
						set{ SetCookieSpecs(value); }
				}

				/// <java-name>
				/// getConnectionReuseStrategy
				/// </java-name>
				public global::Org.Apache.Http.IConnectionReuseStrategy ConnectionReuseStrategy
				{
				[Dot42.DexImport("getConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 49)]
						get{ return GetConnectionReuseStrategy(); }
				}

				/// <java-name>
				/// getConnectionKeepAliveStrategy
				/// </java-name>
				public global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy ConnectionKeepAliveStrategy
				{
				[Dot42.DexImport("getConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 49)]
						get{ return GetConnectionKeepAliveStrategy(); }
				}

				/// <java-name>
				/// getHttpRequestRetryHandler
				/// </java-name>
				public global::Org.Apache.Http.Client.IHttpRequestRetryHandler HttpRequestRetryHandler
				{
				[Dot42.DexImport("getHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 49)]
						get{ return GetHttpRequestRetryHandler(); }
				[Dot42.DexImport("setHttpRequestRetryHandler", "(Lorg/apache/http/client/HttpRequestRetryHandler;)V", AccessFlags = 33)]
						set{ SetHttpRequestRetryHandler(value); }
				}

				/// <java-name>
				/// getRedirectHandler
				/// </java-name>
				public global::Org.Apache.Http.Client.IRedirectHandler RedirectHandler
				{
				[Dot42.DexImport("getRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", AccessFlags = 49)]
						get{ return GetRedirectHandler(); }
				[Dot42.DexImport("setRedirectHandler", "(Lorg/apache/http/client/RedirectHandler;)V", AccessFlags = 33)]
						set{ SetRedirectHandler(value); }
				}

				/// <java-name>
				/// getTargetAuthenticationHandler
				/// </java-name>
				public global::Org.Apache.Http.Client.IAuthenticationHandler TargetAuthenticationHandler
				{
				[Dot42.DexImport("getTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 49)]
						get{ return GetTargetAuthenticationHandler(); }
				[Dot42.DexImport("setTargetAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", AccessFlags = 33)]
						set{ SetTargetAuthenticationHandler(value); }
				}

				/// <java-name>
				/// getProxyAuthenticationHandler
				/// </java-name>
				public global::Org.Apache.Http.Client.IAuthenticationHandler ProxyAuthenticationHandler
				{
				[Dot42.DexImport("getProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", AccessFlags = 49)]
						get{ return GetProxyAuthenticationHandler(); }
				[Dot42.DexImport("setProxyAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V", AccessFlags = 33)]
						set{ SetProxyAuthenticationHandler(value); }
				}

				/// <java-name>
				/// getCookieStore
				/// </java-name>
				public global::Org.Apache.Http.Client.ICookieStore CookieStore
				{
				[Dot42.DexImport("getCookieStore", "()Lorg/apache/http/client/CookieStore;", AccessFlags = 49)]
						get{ return GetCookieStore(); }
				[Dot42.DexImport("setCookieStore", "(Lorg/apache/http/client/CookieStore;)V", AccessFlags = 33)]
						set{ SetCookieStore(value); }
				}

				/// <java-name>
				/// getCredentialsProvider
				/// </java-name>
				public global::Org.Apache.Http.Client.ICredentialsProvider CredentialsProvider
				{
				[Dot42.DexImport("getCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", AccessFlags = 49)]
						get{ return GetCredentialsProvider(); }
				[Dot42.DexImport("setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V", AccessFlags = 33)]
						set{ SetCredentialsProvider(value); }
				}

				/// <java-name>
				/// getRoutePlanner
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner RoutePlanner
				{
				[Dot42.DexImport("getRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 49)]
						get{ return GetRoutePlanner(); }
				[Dot42.DexImport("setRoutePlanner", "(Lorg/apache/http/conn/routing/HttpRoutePlanner;)V", AccessFlags = 33)]
						set{ SetRoutePlanner(value); }
				}

				/// <java-name>
				/// getUserTokenHandler
				/// </java-name>
				public global::Org.Apache.Http.Client.IUserTokenHandler UserTokenHandler
				{
				[Dot42.DexImport("getUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", AccessFlags = 49)]
						get{ return GetUserTokenHandler(); }
				[Dot42.DexImport("setUserTokenHandler", "(Lorg/apache/http/client/UserTokenHandler;)V", AccessFlags = 33)]
						set{ SetUserTokenHandler(value); }
				}

				/// <java-name>
				/// getHttpProcessor
				/// </java-name>
				protected internal global::Org.Apache.Http.Protocol.BasicHttpProcessor HttpProcessor
				{
				[Dot42.DexImport("getHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", AccessFlags = 52)]
						get{ return GetHttpProcessor(); }
				}

				/// <java-name>
				/// getResponseInterceptorCount
				/// </java-name>
				public int ResponseInterceptorCount
				{
				[Dot42.DexImport("getResponseInterceptorCount", "()I", AccessFlags = 33)]
						get{ return GetResponseInterceptorCount(); }
				}

				/// <java-name>
				/// getRequestInterceptorCount
				/// </java-name>
				public int RequestInterceptorCount
				{
				[Dot42.DexImport("getRequestInterceptorCount", "()I", AccessFlags = 33)]
						get{ return GetRequestInterceptorCount(); }
				}

		}

		/// <summary>
		/// <para><para> </para></para>    
		/// </summary>
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
				public override bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getChallenges
				/// </java-name>
				[Dot42.DexImport("getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				public override global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

		}

		/// <summary>
		/// <para>A wrapper class for HttpRequests that can be used to change properties of the current request without modifying the original object. </para><para>This class is also capable of resetting the request headers to the state of the original request.</para><para><para></para><para></para><title>Revision:</title><para>674186 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/RequestWrapper
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/RequestWrapper", AccessFlags = 33)]
		public partial class RequestWrapper : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.Client.Methods.IHttpUriRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public RequestWrapper(global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetHeaders
				/// </java-name>
				[Dot42.DexImport("resetHeaders", "()V", AccessFlags = 1)]
				public virtual void ResetHeaders() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setMethod
				/// </java-name>
				[Dot42.DexImport("setMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetMethod(string method) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// setProtocolVersion
				/// </java-name>
				[Dot42.DexImport("setProtocolVersion", "(Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public virtual void SetProtocolVersion(global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the URI this request uses, such as <code></code>. </para>        
				/// </summary>
				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "()Ljava/net/URI;", AccessFlags = 1)]
				public virtual global::System.Uri GetURI() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// setURI
				/// </java-name>
				[Dot42.DexImport("setURI", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public virtual void SetURI(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the request line of this request. </para>        
				/// </summary>
				/// <returns>
				/// <para>the request line. </para>
				/// </returns>
				/// <java-name>
				/// getRequestLine
				/// </java-name>
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IRequestLine GetRequestLine() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <summary>
				/// <para>Aborts execution of the request.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1)]
				public virtual void Abort() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests if the request execution has been aborted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the request execution has been aborted, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAborted
				/// </java-name>
				[Dot42.DexImport("isAborted", "()Z", AccessFlags = 1)]
				public virtual bool IsAborted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpRequest GetOriginal() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public virtual bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getExecCount
				/// </java-name>
				[Dot42.DexImport("getExecCount", "()I", AccessFlags = 1)]
				public virtual int GetExecCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// incrementExecCount
				/// </java-name>
				[Dot42.DexImport("incrementExecCount", "()V", AccessFlags = 1)]
				public virtual void IncrementExecCount() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RequestWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				public string Method
				{
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMethod(); }
				[Dot42.DexImport("setMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetMethod(value); }
				}

				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <summary>
				/// <para>Returns the URI this request uses, such as <code></code>. </para>        
				/// </summary>
				/// <java-name>
				/// getURI
				/// </java-name>
				public global::System.Uri URI
				{
				[Dot42.DexImport("getURI", "()Ljava/net/URI;", AccessFlags = 1)]
						get{ return GetURI(); }
				[Dot42.DexImport("setURI", "(Ljava/net/URI;)V", AccessFlags = 1)]
						set{ SetURI(value); }
				}

				/// <summary>
				/// <para>Returns the request line of this request. </para>        
				/// </summary>
				/// <returns>
				/// <para>the request line. </para>
				/// </returns>
				/// <java-name>
				/// getRequestLine
				/// </java-name>
				public global::Org.Apache.Http.IRequestLine RequestLine
				{
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
						get{ return GetRequestLine(); }
				}

				/// <java-name>
				/// getOriginal
				/// </java-name>
				public global::Org.Apache.Http.IHttpRequest Original
				{
				[Dot42.DexImport("getOriginal", "()Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
						get{ return GetOriginal(); }
				}

				/// <java-name>
				/// getExecCount
				/// </java-name>
				public int ExecCount
				{
				[Dot42.DexImport("getExecCount", "()I", AccessFlags = 1)]
						get{ return GetExecCount(); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>A ResponseHandler that returns the response body as a String for successful (2xx) responses. If the response code was &gt;= 300, the response body is consumed and an HttpResponseException is thrown.</para><para>If this is used with org.apache.http.client.methods.HttpUriRequest, ResponseHandler), HttpClient may handle redirects (3xx responses) internally.   Oleg Kalnichevski</para><para><para></para><title>Revision:</title><para>677240 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the response body as a String if the response was successful (a 2xx status code). If no response body exists, this returns null. If the response was unsuccessful (&gt;= 300 status code), throws an HttpResponseException. </para>        
				/// </summary>
				/// <java-name>
				/// handleResponse
				/// </java-name>
				[Dot42.DexImport("handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string HandleResponse(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Default implementation of CookieStore</para><para><para> </para><simplesectsep></simplesectsep><para>Rodney Waldhoff </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/BasicCookieStore
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/BasicCookieStore", AccessFlags = 33)]
		public partial class BasicCookieStore : global::Org.Apache.Http.Client.ICookieStore
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicCookieStore() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds an HTTP cookie, replacing any existing equivalent cookies. If the given cookie has already expired it will not be added, but existing values will still be removed.</para><para><para>addCookies(Cookie[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// addCookie
				/// </java-name>
				[Dot42.DexImport("addCookie", "(Lorg/apache/http/cookie/Cookie;)V", AccessFlags = 33)]
				public virtual void AddCookie(global::Org.Apache.Http.Cookie.ICookie cookie) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds an array of HTTP cookies. Cookies are added individually and in the given array order. If any of the given cookies has already expired it will not be added, but existing values will still be removed.</para><para><para>addCookie(Cookie) </para></para>        
				/// </summary>
				/// <java-name>
				/// addCookies
				/// </java-name>
				[Dot42.DexImport("addCookies", "([Lorg/apache/http/cookie/Cookie;)V", AccessFlags = 33)]
				public virtual void AddCookies(global::Org.Apache.Http.Cookie.ICookie[] cookies) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an immutable array of cookies that this HTTP state currently contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of cookies. </para>
				/// </returns>
				/// <java-name>
				/// getCookies
				/// </java-name>
				[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> GetCookies() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <summary>
				/// <para>Removes all of cookies in this HTTP state that have expired by the specified date.</para><para><para>Cookie::isExpired(Date) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if any cookies were purged.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Clears all cookies. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an immutable array of cookies that this HTTP state currently contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of cookies. </para>
				/// </returns>
				/// <java-name>
				/// getCookies
				/// </java-name>
				public global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Cookies
				{
				[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;")]
						get{ return GetCookies(); }
				}

		}

		/// <summary>
		/// <para>The default HttpRequestRetryHandler used by request executors.</para><para><para>Michael Becke </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/DefaultHttpRequestRetryHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultHttpRequestRetryHandler", AccessFlags = 33)]
		public partial class DefaultHttpRequestRetryHandler : global::Org.Apache.Http.Client.IHttpRequestRetryHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public DefaultHttpRequestRetryHandler(int retryCount, bool requestSentRetryEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpRequestRetryHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used <code>retryCount</code> and <code>requestSentRetryEnabled</code> to determine if the given method should be retried. </para>        
				/// </summary>
				/// <java-name>
				/// retryRequest
				/// </java-name>
				[Dot42.DexImport("retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public virtual bool RetryRequest(global::System.IO.IOException exception, int executionCount, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this handler will retry methods that have successfully sent their request, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isRequestSentRetryEnabled
				/// </java-name>
				[Dot42.DexImport("isRequestSentRetryEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsRequestSentRetryEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of times a method will be retried </para>
				/// </returns>
				/// <java-name>
				/// getRetryCount
				/// </java-name>
				[Dot42.DexImport("getRetryCount", "()I", AccessFlags = 1)]
				public virtual int GetRetryCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of times a method will be retried </para>
				/// </returns>
				/// <java-name>
				/// getRetryCount
				/// </java-name>
				public int RetryCount
				{
				[Dot42.DexImport("getRetryCount", "()I", AccessFlags = 1)]
						get{ return GetRetryCount(); }
				}

		}

		/// <summary>
		/// <para><para> </para></para>    
		/// </summary>
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
				public override bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getChallenges
				/// </java-name>
				[Dot42.DexImport("getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				public override global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

		}

		/// <summary>
		/// <para>Default implementation of RequestDirector. <br></br> This class replaces the <code>HttpMethodDirector</code> in HttpClient 3.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>676023 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/DefaultRequestDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultRequestDirector", AccessFlags = 33)]
		public partial class DefaultRequestDirector : global::Org.Apache.Http.Client.IRequestDirector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The connection manager. </para>        
				/// </summary>
				/// <java-name>
				/// connManager
				/// </java-name>
				[Dot42.DexImport("connManager", "Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IClientConnectionManager ConnManager;
				/// <summary>
				/// <para>The route planner. </para>        
				/// </summary>
				/// <java-name>
				/// routePlanner
				/// </java-name>
				[Dot42.DexImport("routePlanner", "Lorg/apache/http/conn/routing/HttpRoutePlanner;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner RoutePlanner;
				/// <summary>
				/// <para>The connection re-use strategy. </para>        
				/// </summary>
				/// <java-name>
				/// reuseStrategy
				/// </java-name>
				[Dot42.DexImport("reuseStrategy", "Lorg/apache/http/ConnectionReuseStrategy;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IConnectionReuseStrategy ReuseStrategy;
				/// <summary>
				/// <para>The keep-alive duration strategy. </para>        
				/// </summary>
				/// <java-name>
				/// keepAliveStrategy
				/// </java-name>
				[Dot42.DexImport("keepAliveStrategy", "Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy KeepAliveStrategy;
				/// <summary>
				/// <para>The request executor. </para>        
				/// </summary>
				/// <java-name>
				/// requestExec
				/// </java-name>
				[Dot42.DexImport("requestExec", "Lorg/apache/http/protocol/HttpRequestExecutor;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Protocol.HttpRequestExecutor RequestExec;
				/// <summary>
				/// <para>The HTTP protocol processor. </para>        
				/// </summary>
				/// <java-name>
				/// httpProcessor
				/// </java-name>
				[Dot42.DexImport("httpProcessor", "Lorg/apache/http/protocol/HttpProcessor;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Protocol.IHttpProcessor HttpProcessor;
				/// <summary>
				/// <para>The request retry handler. </para>        
				/// </summary>
				/// <java-name>
				/// retryHandler
				/// </java-name>
				[Dot42.DexImport("retryHandler", "Lorg/apache/http/client/HttpRequestRetryHandler;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Client.IHttpRequestRetryHandler RetryHandler;
				/// <summary>
				/// <para>The redirect handler. </para>        
				/// </summary>
				/// <java-name>
				/// redirectHandler
				/// </java-name>
				[Dot42.DexImport("redirectHandler", "Lorg/apache/http/client/RedirectHandler;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Client.IRedirectHandler RedirectHandler;
				/// <summary>
				/// <para>The HTTP parameters. </para>        
				/// </summary>
				/// <java-name>
				/// params
				/// </java-name>
				[Dot42.DexImport("params", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams Params;
				/// <summary>
				/// <para>The currently allocated connection. </para>        
				/// </summary>
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IManagedClientConnection ManagedConn;
				[Dot42.DexImport("<init>", @"(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultRequestDirector(global::Org.Apache.Http.Protocol.HttpRequestExecutor requestExec, global::Org.Apache.Http.Conn.IClientConnectionManager conman, global::Org.Apache.Http.IConnectionReuseStrategy reustrat, global::Org.Apache.Http.Conn.IConnectionKeepAliveStrategy kastrat, global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner rouplan, global::Org.Apache.Http.Protocol.IHttpProcessor httpProcessor, global::Org.Apache.Http.Client.IHttpRequestRetryHandler retryHandler, global::Org.Apache.Http.Client.IRedirectHandler redirectHandler, global::Org.Apache.Http.Client.IAuthenticationHandler targetAuthHandler, global::Org.Apache.Http.Client.IAuthenticationHandler proxyAuthHandler, global::Org.Apache.Http.Client.IUserTokenHandler userTokenHandler, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rewriteRequestURI
				/// </java-name>
				[Dot42.DexImport("rewriteRequestURI", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRo" +
    "ute;)V", AccessFlags = 4)]
				protected internal virtual void RewriteRequestURI(global::Org.Apache.Http.Impl.Client.RequestWrapper request, global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Executes a request. <br></br><b>Note:</b> For the time being, a new director is instantiated for each request. This is the same behavior as for <code>HttpMethodDirector</code> in HttpClient 3.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final response to the request. This is never an intermediate response with status code 1xx.</para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Returns the connection back to the connection manager and prepares for retrieving a new connection during the next request. </para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 4)]
				protected internal virtual void ReleaseConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines the route for a request. Called by execute to determine the route for either the original or a followup request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route the request should take</para>
				/// </returns>
				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <summary>
				/// <para>Establishes the target route.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// establishRoute
				/// </java-name>
				[Dot42.DexImport("establishRoute", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)V" +
    "", AccessFlags = 4)]
				protected internal virtual void EstablishRoute(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a tunnel to the target server. The connection must be established to the (last) proxy. A CONNECT request for tunnelling through the proxy will be created and sent, the response received and checked. This method does <b>not</b> update the connection with information about the tunnel, that is left to the caller.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the tunnelled route is secure, <code>false</code> otherwise. The implementation here always returns <code>false</code>, but derived classes may override.</para>
				/// </returns>
				/// <java-name>
				/// createTunnelToTarget
				/// </java-name>
				[Dot42.DexImport("createTunnelToTarget", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)Z" +
    "", AccessFlags = 4)]
				protected internal virtual bool CreateTunnelToTarget(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Creates a tunnel to an intermediate proxy. This method is <b>not</b> implemented in this class. It just throws an exception here.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the partially tunnelled connection is secure, <code>false</code> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// createTunnelToProxy
				/// </java-name>
				[Dot42.DexImport("createTunnelToProxy", "(Lorg/apache/http/conn/routing/HttpRoute;ILorg/apache/http/protocol/HttpContext;)" +
    "Z", AccessFlags = 4)]
				protected internal virtual bool CreateTunnelToProxy(global::Org.Apache.Http.Conn.Routing.HttpRoute route, int hop, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Creates the CONNECT request for tunnelling. Called by createTunnelToTarget.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CONNECT request for tunnelling </para>
				/// </returns>
				/// <java-name>
				/// createConnectRequest
				/// </java-name>
				[Dot42.DexImport("createConnectRequest", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)L" +
    "org/apache/http/HttpRequest;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHttpRequest CreateConnectRequest(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

				/// <summary>
				/// <para>Analyzes a response to check need for a followup.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the followup request and route if there is a followup, or <code>null</code> if the response should be returned as is</para>
				/// </returns>
				/// <java-name>
				/// handleResponse
				/// </java-name>
				[Dot42.DexImport("handleResponse", "(Lorg/apache/http/impl/client/RoutedRequest;Lorg/apache/http/HttpResponse;Lorg/ap" +
    "ache/http/protocol/HttpContext;)Lorg/apache/http/impl/client/RoutedRequest;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Client.RoutedRequest HandleResponse(global::Org.Apache.Http.Impl.Client.RoutedRequest roureq, global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Client.RoutedRequest);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultRequestDirector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Default implementation of CredentialsProvider</para><para><para> </para><simplesectsep></simplesectsep><para>Rodney Waldhoff </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/BasicCredentialsProvider
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/BasicCredentialsProvider", AccessFlags = 33)]
		public partial class BasicCredentialsProvider : global::Org.Apache.Http.Client.ICredentialsProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicCredentialsProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the credentials for the given authentication scope. Any previous credentials for the given scope will be overwritten.</para><para><para>getCredentials(AuthScope) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCredentials
				/// </java-name>
				[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V", AccessFlags = 33)]
				public virtual void SetCredentials(global::Org.Apache.Http.Auth.AuthScope authscope, global::Org.Apache.Http.Auth.ICredentials credentials) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the credentials for the given authentication scope.</para><para><para>setCredentials(AuthScope, Credentials) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the credentials</para>
				/// </returns>
				/// <java-name>
				/// getCredentials
				/// </java-name>
				[Dot42.DexImport("getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;", AccessFlags = 33)]
				public virtual global::Org.Apache.Http.Auth.ICredentials GetCredentials(global::Org.Apache.Http.Auth.AuthScope authscope) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Clears all credentials. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Default implementation of an HTTP client.</para><para><h3>Prefer HttpURLConnection for new code</h3></para><para>Android includes two HTTP clients: <c> HttpURLConnection </c> and Apache HTTP Client. Both support HTTPS, streaming uploads and downloads, configurable timeouts, IPv6 and connection pooling. Apache HTTP client has fewer bugs in Android 2.2 (Froyo) and earlier releases. For Android 2.3 (Gingerbread) and later, HttpURLConnection is the best choice. Its simple API and small size makes it great fit for Android. Transparent compression and response caching reduce network use, improve speed and save battery. See the  for a comparison of the two HTTP clients.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>677250 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/DefaultHttpClient
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/DefaultHttpClient", AccessFlags = 33)]
		public partial class DefaultHttpClient : global::Org.Apache.Http.Impl.Client.AbstractHttpClient
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new HTTP client from parameters and a connection manager.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams" +
    ";)V", AccessFlags = 1)]
				public DefaultHttpClient(global::Org.Apache.Http.Conn.IClientConnectionManager conman, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultHttpClient(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>A request with the route along which it should be sent.</para><para><para></para><para></para><title>Revision:</title><para>645846 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				protected internal readonly global::Org.Apache.Http.Impl.Client.RequestWrapper Request;
				/// <java-name>
				/// route
				/// </java-name>
				[Dot42.DexImport("route", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.Routing.HttpRoute Route;
				/// <summary>
				/// <para>Creates a new routed request.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRo" +
    "ute;)V", AccessFlags = 1)]
				public RoutedRequest(global::Org.Apache.Http.Impl.Client.RequestWrapper req, global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRequest
				/// </java-name>
				[Dot42.DexImport("getRequest", "()Lorg/apache/http/impl/client/RequestWrapper;", AccessFlags = 17)]
				public global::Org.Apache.Http.Impl.Client.RequestWrapper GetRequest() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Client.RequestWrapper);
				}

				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RoutedRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A wrapper class for HttpEntityEnclosingRequests that can be used to change properties of the current request without modifying the original object. </para><para>This class is also capable of resetting the request headers to the state of the original request.</para><para><para></para><para></para><title>Revision:</title><para>674186 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/EntityEnclosingRequestWrapper
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/EntityEnclosingRequestWrapper", AccessFlags = 33)]
		public partial class EntityEnclosingRequestWrapper : global::Org.Apache.Http.Impl.Client.RequestWrapper, global::Org.Apache.Http.IHttpEntityEnclosingRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public EntityEnclosingRequestWrapper(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void SetEntity(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if this request should use the expect-continue handshake. The expect continue handshake gives the server a chance to decide whether to accept the entity enclosing request before the possibly lengthy entity is sent across the wire. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the expect continue handshake should be used, false if not. </para>
				/// </returns>
				/// <java-name>
				/// expectContinue
				/// </java-name>
				[Dot42.DexImport("expectContinue", "()Z", AccessFlags = 1)]
				public virtual bool ExpectContinue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EntityEnclosingRequestWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IRequestLine GetRequestLine() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				public global::Org.Apache.Http.IHttpEntity Entity
				{
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
						get{ return GetEntity(); }
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
						set{ SetEntity(value); }
				}

				public global::Org.Apache.Http.IRequestLine RequestLine
				{
				[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
						get{ return GetRequestLine(); }
				}

				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get{ return GetProtocolVersion(); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>Represents a stack of parameter collections. When retrieving a parameter, the stack is searched in a fixed order and the first match returned. Setting parameters via the stack is not supported. To minimize overhead, the stack has a fixed size and does not maintain an internal array. The supported stack entries, sorted by increasing priority, are: <ol><li><para>Application parameters: expected to be the same for all clients used by an application. These provide "global", that is application-wide, defaults.  </para></li><li><para>Client parameters: specific to an instance of HttpClient. These provide client specific defaults.  </para></li><li><para>Request parameters: specific to a single request execution. For overriding client and global defaults.  </para></li><li><para>Override parameters: specific to an instance of HttpClient. These can be used to set parameters that cannot be overridden on a per-request basis.  </para></li></ol>Each stack entry may be <code>null</code>. That is preferable over an empty params collection, since it avoids searching the empty collection when looking up parameters.</para><para><para></para><para></para><title>Revision:</title><para>673450 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/client/ClientParamsStack
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/client/ClientParamsStack", AccessFlags = 33)]
		public partial class ClientParamsStack : global::Org.Apache.Http.Params.AbstractHttpParams
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The application parameter collection, or <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// applicationParams
				/// </java-name>
				[Dot42.DexImport("applicationParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams ApplicationParams;
				/// <summary>
				/// <para>The client parameter collection, or <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// clientParams
				/// </java-name>
				[Dot42.DexImport("clientParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams ClientParams;
				/// <summary>
				/// <para>The request parameter collection, or <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// requestParams
				/// </java-name>
				[Dot42.DexImport("requestParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams RequestParams;
				/// <summary>
				/// <para>The override parameter collection, or <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// overrideParams
				/// </java-name>
				[Dot42.DexImport("overrideParams", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams OverrideParams;
				/// <summary>
				/// <para>Creates a new parameter stack from elements. The arguments will be stored as-is, there is no copying to prevent modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apach" +
    "e/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ClientParamsStack(global::Org.Apache.Http.Params.IHttpParams aparams, global::Org.Apache.Http.Params.IHttpParams cparams, global::Org.Apache.Http.Params.IHttpParams rparams, global::Org.Apache.Http.Params.IHttpParams oparams) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a copy of a parameter stack. The new stack will have the exact same entries as the argument stack. There is no copying of parameters.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;)V", AccessFlags = 1)]
				public ClientParamsStack(global::Org.Apache.Http.Impl.Client.ClientParamsStack stack) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a modified copy of a parameter stack. The new stack will contain the explicitly passed elements. For elements where the explicit argument is <code>null</code>, the corresponding element from the argument stack is used. There is no copying of parameters.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;Lorg/apache/http/params/HttpParam" +
    "s;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apa" +
    "che/http/params/HttpParams;)V", AccessFlags = 1)]
				public ClientParamsStack(global::Org.Apache.Http.Impl.Client.ClientParamsStack stack, global::Org.Apache.Http.Params.IHttpParams aparams, global::Org.Apache.Http.Params.IHttpParams cparams, global::Org.Apache.Http.Params.IHttpParams rparams, global::Org.Apache.Http.Params.IHttpParams oparams) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the application parameters of this stack.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the application parameters, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getApplicationParams
				/// </java-name>
				[Dot42.DexImport("getApplicationParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
				public global::Org.Apache.Http.Params.IHttpParams GetApplicationParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Obtains the client parameters of this stack.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the client parameters, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getClientParams
				/// </java-name>
				[Dot42.DexImport("getClientParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
				public global::Org.Apache.Http.Params.IHttpParams GetClientParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Obtains the request parameters of this stack.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request parameters, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getRequestParams
				/// </java-name>
				[Dot42.DexImport("getRequestParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
				public global::Org.Apache.Http.Params.IHttpParams GetRequestParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Obtains the override parameters of this stack.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the override parameters, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getOverrideParams
				/// </java-name>
				[Dot42.DexImport("getOverrideParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 17)]
				public global::Org.Apache.Http.Params.IHttpParams GetOverrideParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Obtains a parameter from this stack. See class comment for search order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the highest-priority value for that parameter, or <code>null</code> if it is not set anywhere in this stack </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Does <b>not</b> set a parameter. Parameter stacks are read-only. It is possible, though discouraged, to access and modify specific stack entries. Derived classes may change this behavior.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>nothing</para>
				/// </returns>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams SetParameter(string name, object value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Does <b>not</b> remove a parameter. Parameter stacks are read-only. It is possible, though discouraged, to access and modify specific stack entries. Derived classes may change this behavior.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>nothing</para>
				/// </returns>
				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool RemoveParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Does <b>not</b> copy parameters. Parameter stacks are lightweight objects, expected to be instantiated as needed and to be used only in a very specific context. On top of that, they are read-only. The typical copy operation to prevent accidental modification of parameters passed by the application to a framework object is therefore pointless and disabled. Create a new stack if you really need a copy. <br></br> Derived classes may change this behavior.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>this</code> parameter stack </para>
				/// </returns>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClientParamsStack() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A collection of URIs that were used as redirects. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns true if this collection contains the given URI. </para>        
				/// </summary>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/net/URI;)Z", AccessFlags = 1)]
				public virtual bool Contains(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds a new URI to the list of redirects. </para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public virtual void Add(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes a URI from the list of redirects. </para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/net/URI;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para><para> </para></para>    
		/// </summary>
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
				protected internal virtual global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> ParseChallenges(global::Org.Apache.Http.IHeader[] headers) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// getAuthPreferences
				/// </java-name>
				[Dot42.DexImport("getAuthPreferences", "()Ljava/util/List;", AccessFlags = 4, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				protected internal virtual global::Java.Util.IList<string> GetAuthPreferences() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// selectScheme
				/// </java-name>
				[Dot42.DexImport("selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpConte" +
    "xt;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/Header;>;Lorg/apache/http/Http" +
    "Response;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme" +
    ";")]
				public virtual global::Org.Apache.Http.Auth.IAuthScheme SelectScheme(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> challenges, global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

				[Dot42.DexImport("org/apache/http/client/AuthenticationHandler", "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				public virtual bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/client/AuthenticationHandler", "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1025, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				public virtual global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// getAuthPreferences
				/// </java-name>
				protected internal global::Java.Util.IList<string> AuthPreferences
				{
				[Dot42.DexImport("getAuthPreferences", "()Ljava/util/List;", AccessFlags = 4, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetAuthPreferences(); }
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
				public virtual object GetUserToken(global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>Default implementation of a strategy deciding duration that a connection can remain idle.</para><para>The default implementation looks solely at the 'Keep-Alive' header's timeout token.</para><para><para></para><para></para><title>Revision:</title></para><para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the duration of time which this connection can be safely kept idle. If the connection is left idle for longer than this period of time, it MUST not reused. A value of 0 or less may be returned to indicate that there is no suitable suggestion.</para><para>When coupled with a ConnectionReuseStrategy, if returns true, this allows you to control how long the reuse will last. If keepAlive returns false, this should have no meaningful impact   response The last response received over the connection.  context the context in which the connection is being used.   the duration in ms for which it is safe to keep the connection idle, or &lt;=0 if no suggested duration. </para>        
				/// </summary>
				/// <java-name>
				/// getKeepAliveDuration
				/// </java-name>
				[Dot42.DexImport("getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J", AccessFlags = 1)]
				public virtual long GetKeepAliveDuration(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		/// <para>Default implementation of RedirectHandler.</para><para><para></para><para></para><title>Revision:</title><para>673450 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual bool IsRedirectRequested(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLocationURI
				/// </java-name>
				[Dot42.DexImport("getLocationURI", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/net/U" +
    "RI;", AccessFlags = 1)]
				public virtual global::System.Uri GetLocationURI(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

		}

}


