// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Client.cs
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
namespace Org.Apache.Http.Client
{
		/// <summary>
		/// <para>Signals violation of HTTP specification caused by an invalid redirect</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/RedirectException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/RedirectException", AccessFlags = 33)]
		public partial class RedirectException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new RedirectException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RedirectException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new RedirectException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RedirectException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new RedirectException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public RedirectException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Signals an error in the HTTP protocol. </para>    
		/// </summary>
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
				public ClientProtocolException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Interface for an HTTP client. HTTP clients encapsulate a smorgasbord of objects required to execute HTTP requests while handling cookies, authentication, connection management, and other features. Thread safety of HTTP clients depends on the implementation and configuration of the specific client.</para><para><para></para><para></para><title>Revision:</title><para>676020 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/HttpClient
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/HttpClient", AccessFlags = 1537)]
		public partial interface IHttpClient
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the parameters for this client. These parameters will become defaults for all requests being executed with this client, and for the parameters of dependent objects in this client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default parameters </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the connection manager used by this client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection manager </para>
				/// </returns>
				/// <java-name>
				/// getConnectionManager
				/// </java-name>
				[Dot42.DexImport("getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IClientConnectionManager GetConnectionManager() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Executes a request using the default context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Executes a request using the given context. The route to the target will be determined by the HTTP client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpCon" +
    "text;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Executes a request using the given context. The route to the target will be determined by the HTTP client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpRes" +
    "ponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost request, global::Org.Apache.Http.IHttpRequest context) /* MethodBuilder.Create */ ;

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
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Executes a request using the given context. The route to the target will be determined by the HTTP client.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request. This is always a final response, never an intermediate response with an 1xx status code. Whether redirects or authentication challenges will be returned or handled automatically depends on the implementation and configuration of this client. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseH" +
    "andler;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;)TT;")]
				T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> context) /* MethodBuilder.Create */ ;

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
    "andler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache" +
    "/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext;)TT;")]
				T Execute<T>(global::Org.Apache.Http.Client.Methods.IHttpUriRequest target, global::Org.Apache.Http.Client.IResponseHandler<T> request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

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
    "esponseHandler;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;)TT;")]
				T Execute<T>(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> context) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Executes a request to the target using the given context and processes the response using the given response handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response object as generated by the response handler. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/R" +
    "esponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lor" +
    "g/apache/http/client/ResponseHandler<+TT;>;Lorg/apache/http/protocol/HttpContext" +
    ";)TT;")]
				T Execute<T>(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Client.IResponseHandler<T> responseHandler, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A handler for determining if an HTTP request should be redirected to a new location in response to an HTTP response received from the target server.</para><para>Classes implementing this interface must synchronize access to shared data as methods of this interfrace may be executed from multiple threads </para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/RedirectHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/RedirectHandler", AccessFlags = 1537)]
		public partial interface IRedirectHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Determines if a request should be redirected to a new location given the response from the target server.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the request should be redirected, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isRedirectRequested
				/// </java-name>
				[Dot42.DexImport("isRedirectRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool IsRedirectRequested(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Determines the location request is expected to be redirected to given the response from the target server and the current request execution context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>redirect URI </para>
				/// </returns>
				/// <java-name>
				/// getLocationURI
				/// </java-name>
				[Dot42.DexImport("getLocationURI", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/net/U" +
    "RI;", AccessFlags = 1025)]
				global::System.Uri GetLocationURI(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A handler for determining if an HttpRequest should be retried after a recoverable exception during execution.</para><para>Classes implementing this interface must synchronize access to shared data as methods of this interfrace may be executed from multiple threads </para><para><para>Michael Becke </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/HttpRequestRetryHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/HttpRequestRetryHandler", AccessFlags = 1537)]
		public partial interface IHttpRequestRetryHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Determines if a method should be retried after an IOException occurs during execution.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the method should be retried, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// retryRequest
				/// </java-name>
				[Dot42.DexImport("retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool RetryRequest(global::System.IO.IOException exception, int executionCount, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Signals failure to retry the request due to non-repeatable request entity.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/NonRepeatableRequestException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/NonRepeatableRequestException", AccessFlags = 33)]
		public partial class NonRepeatableRequestException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new NonRepeatableEntityException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NonRepeatableRequestException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new NonRepeatableEntityException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NonRepeatableRequestException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><para> </para></para>    
		/// </summary>
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
				bool IsAuthenticationRequested(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChallenges
				/// </java-name>
				[Dot42.DexImport("getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map;", AccessFlags = 1025, Signature = "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/" +
    "Map<Ljava/lang/String;Lorg/apache/http/Header;>;")]
				global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> GetChallenges(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// selectScheme
				/// </java-name>
				[Dot42.DexImport("selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpConte" +
    "xt;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/Header;>;Lorg/apache/http/Http" +
    "Response;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme" +
    ";")]
				global::Org.Apache.Http.Auth.IAuthScheme SelectScheme(global::Java.Util.IMap<string, global::Org.Apache.Http.IHeader> challenges, global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A client-side request director. The director decides which steps are necessary to execute a request. It establishes connections and optionally processes redirects and authentication challenges. The director may therefore generate and send a sequence of requests in order to execute one initial request.</para><para><br></br><b>Note:</b> It is most likely that implementations of this interface will allocate connections, and return responses that depend on those connections for reading the response entity. Such connections MUST be released, but that is out of the scope of a request director.</para><para><para></para><para></para><title>Revision:</title><para>676020 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/RequestDirector
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/RequestDirector", AccessFlags = 1537)]
		public partial interface IRequestDirector
 /* scope: __dot42__ */ 
		{
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
    "/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Abstract cookie store.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/CookieStore
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/CookieStore", AccessFlags = 1537)]
		public partial interface ICookieStore
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Adds an HTTP cookie, replacing any existing equivalent cookies. If the given cookie has already expired it will not be added, but existing values will still be removed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addCookie
				/// </java-name>
				[Dot42.DexImport("addCookie", "(Lorg/apache/http/cookie/Cookie;)V", AccessFlags = 1025)]
				void AddCookie(global::Org.Apache.Http.Cookie.ICookie cookie) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns all cookies contained in this store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>all cookies </para>
				/// </returns>
				/// <java-name>
				/// getCookies
				/// </java-name>
				[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;")]
				global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> GetCookies() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all of cookies in this store that have expired by the specified date.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if any cookies were purged. </para>
				/// </returns>
				/// <java-name>
				/// clearExpired
				/// </java-name>
				[Dot42.DexImport("clearExpired", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				bool ClearExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clears all cookies. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Handler that encapsulates the process of generating a response object from a HttpResponse.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/ResponseHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/ResponseHandler", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IResponseHandler<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Processes an HttpResponse and returns some value corresponding to that response.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A value determined by the response</para>
				/// </returns>
				/// <java-name>
				/// handleResponse
				/// </java-name>
				[Dot42.DexImport("handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Lorg/apache/http/HttpResponse;)TT;")]
				T HandleResponse(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Abstract credentials provider.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/CredentialsProvider
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/CredentialsProvider", AccessFlags = 1537)]
		public partial interface ICredentialsProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Sets the credentials for the given authentication scope. Any previous credentials for the given scope will be overwritten.</para><para><para>getCredentials(AuthScope) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCredentials
				/// </java-name>
				[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V", AccessFlags = 1025)]
				void SetCredentials(global::Org.Apache.Http.Auth.AuthScope authscope, global::Org.Apache.Http.Auth.ICredentials credentials) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the credentials for the given authentication scope.</para><para><para>setCredentials(AuthScope, Credentials) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the credentials</para>
				/// </returns>
				/// <java-name>
				/// getCredentials
				/// </java-name>
				[Dot42.DexImport("getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;", AccessFlags = 1025)]
				global::Org.Apache.Http.Auth.ICredentials GetCredentials(global::Org.Apache.Http.Auth.AuthScope authscope) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clears all credentials. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A handler for determining if the given execution context is user specific or not. The token object returned by this handler is expected to uniquely identify the current user if the context is user specific or to be <code>null</code> if the context does not contain any resources or details specific to the current user. </para><para>The user token will be used to ensure that user specific resouces will not shared with or reused by other users.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/UserTokenHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/UserTokenHandler", AccessFlags = 1537)]
		public partial interface IUserTokenHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The token object returned by this method is expected to uniquely identify the current user if the context is user specific or to be <code>null</code> if it is not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>user token that uniquely identifies the user or <code>null&lt;/null&gt; if the context is not user specific. </code></para>
				/// </returns>
				/// <java-name>
				/// getUserToken
				/// </java-name>
				[Dot42.DexImport("getUserToken", "(Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetUserToken(global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Signals a non 2xx HTTP response. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/HttpResponseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/HttpResponseException", AccessFlags = 33)]
		public partial class HttpResponseException : global::Org.Apache.Http.Client.ClientProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public HttpResponseException(int statusCode, string s) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>Signals a circular redirect</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/CircularRedirectException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/CircularRedirectException", AccessFlags = 33)]
		public partial class CircularRedirectException : global::Org.Apache.Http.Client.RedirectException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new CircularRedirectException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CircularRedirectException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new CircularRedirectException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CircularRedirectException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new CircularRedirectException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CircularRedirectException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

}


