// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Protocol.cs
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
namespace Org.Apache.Http.Protocol
{
		/// <summary>
		/// <para>Generates a date in the format required by the HTTP protocol.</para><para><para></para><para></para><title>Revision:</title><para>548066 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpDateGenerator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpDateGenerator", AccessFlags = 33)]
		public partial class HttpDateGenerator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Date format pattern used to generate the header in RFC 1123 format. </para>        
				/// </summary>
				/// <java-name>
				/// PATTERN_RFC1123
				/// </java-name>
				[Dot42.DexImport("PATTERN_RFC1123", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATTERN_RFC1123 = "EEE, dd MMM yyyy HH:mm:ss zzz";
				/// <summary>
				/// <para>The time zone to use in the date header. </para>        
				/// </summary>
				/// <java-name>
				/// GMT
				/// </java-name>
				[Dot42.DexImport("GMT", "Ljava/util/TimeZone;", AccessFlags = 25)]
				public static readonly global::Java.Util.TimeZone GMT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpDateGenerator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentDate
				/// </java-name>
				[Dot42.DexImport("getCurrentDate", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetCurrentDate() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCurrentDate
				/// </java-name>
				public string CurrentDate
				{
				[Dot42.DexImport("getCurrentDate", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetCurrentDate(); }
				}

		}

		/// <summary>
		/// <para>A request interceptor that sets the Host header for HTTP/1.1 requests.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/RequestTargetHost
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/RequestTargetHost", AccessFlags = 33)]
		public partial class RequestTargetHost : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestTargetHost() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><para></para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpRequestHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpRequestHandler", AccessFlags = 1537)]
		public partial interface IHttpRequestHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handle
				/// </java-name>
				[Dot42.DexImport("handle", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/prot" +
    "ocol/HttpContext;)V", AccessFlags = 1025)]
				void Handle(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface to be implemented by objects that can resolve HttpRequestHandler instances by request URI.</para><para><para></para><para></para><title>Revision:</title><para>613298 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpRequestHandlerResolver
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpRequestHandlerResolver", AccessFlags = 1537)]
		public partial interface IHttpRequestHandlerResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Ljava/lang/String;)Lorg/apache/http/protocol/HttpRequestHandler;", AccessFlags = 1025)]
				global::Org.Apache.Http.Protocol.IHttpRequestHandler Lookup(string requestURI) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Provides access to an ordered list of request interceptors. Lists are expected to be built upfront and used read-only afterwards for processing.</para><para><para></para><para></para><title>Revision:</title><para>554903 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpRequestInterceptorList
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpRequestInterceptorList", AccessFlags = 1537)]
		public partial interface IHttpRequestInterceptorList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Appends a request interceptor to this list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", AccessFlags = 1025)]
				void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor itcp) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inserts a request interceptor at the specified index.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", AccessFlags = 1025)]
				void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor itcp, int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the current size of this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of request interceptors in this list </para>
				/// </returns>
				/// <java-name>
				/// getRequestInterceptorCount
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptorCount", "()I", AccessFlags = 1025)]
				int GetRequestInterceptorCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains a request interceptor from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interceptor at the given index, or <code>null</code> if the index is out of range </para>
				/// </returns>
				/// <java-name>
				/// getRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequestInterceptor GetRequestInterceptor(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all request interceptors from this list. </para>        
				/// </summary>
				/// <java-name>
				/// clearRequestInterceptors
				/// </java-name>
				[Dot42.DexImport("clearRequestInterceptors", "()V", AccessFlags = 1025)]
				void ClearRequestInterceptors() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all request interceptor of the specified class</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeRequestInterceptorByClass
				/// </java-name>
				[Dot42.DexImport("removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", AccessFlags = 1025)]
				void RemoveRequestInterceptorByClass(global::System.Type clazz) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the request interceptors in this list. This list will be cleared and re-initialized to contain all request interceptors from the argument list. If the argument list includes elements that are not request interceptors, the behavior is implementation dependent.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterceptors
				/// </java-name>
				[Dot42.DexImport("setInterceptors", "(Ljava/util/List;)V", AccessFlags = 1025)]
				void SetInterceptors(global::Java.Util.IList<object> itcps) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Maintains a map of HTTP request handlers keyed by a request URI pattern. HttpRequestHandler instances can be looked up by request URI using the HttpRequestHandlerResolver interface.<br></br> Patterns may have three formats: <ul><li><para><code>*</code> </para></li><li><para><code>*&lt;uri&gt;</code> </para></li><li><para><code>&lt;uri&gt;*</code> </para></li></ul></para><para><para></para><para></para><title>Revision:</title><para>630662 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpRequestHandlerRegistry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpRequestHandlerRegistry", AccessFlags = 33)]
		public partial class HttpRequestHandlerRegistry : global::Org.Apache.Http.Protocol.IHttpRequestHandlerResolver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpRequestHandlerRegistry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/lang/String;Lorg/apache/http/protocol/HttpRequestHandler;)V", AccessFlags = 1)]
				public virtual void Register(string pattern, global::Org.Apache.Http.Protocol.IHttpRequestHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Unregister(string pattern) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandlers
				/// </java-name>
				[Dot42.DexImport("setHandlers", "(Ljava/util/Map;)V", AccessFlags = 1)]
				public virtual void SetHandlers(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Ljava/lang/String;)Lorg/apache/http/protocol/HttpRequestHandler;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Protocol.IHttpRequestHandler Lookup(string requestURI) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.IHttpRequestHandler);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use UriPatternMatcher directly </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// matchUriRequestPattern
				/// </java-name>
				[Dot42.DexImport("matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 4)]
				protected internal virtual bool MatchUriRequestPattern(string pattern, string requestUri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Context attribute names for protocol execution.</para><para><para></para><para></para><title>Revision:</title><para>558154 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/ExecutionContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/ExecutionContext", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IExecutionContextConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HTTP_CONNECTION
				/// </java-name>
				[Dot42.DexImport("HTTP_CONNECTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_CONNECTION = "http.connection";
				/// <java-name>
				/// HTTP_REQUEST
				/// </java-name>
				[Dot42.DexImport("HTTP_REQUEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_REQUEST = "http.request";
				/// <java-name>
				/// HTTP_RESPONSE
				/// </java-name>
				[Dot42.DexImport("HTTP_RESPONSE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_RESPONSE = "http.response";
				/// <java-name>
				/// HTTP_TARGET_HOST
				/// </java-name>
				[Dot42.DexImport("HTTP_TARGET_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_TARGET_HOST = "http.target_host";
				/// <java-name>
				/// HTTP_PROXY_HOST
				/// </java-name>
				[Dot42.DexImport("HTTP_PROXY_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_PROXY_HOST = "http.proxy_host";
				/// <java-name>
				/// HTTP_REQ_SENT
				/// </java-name>
				[Dot42.DexImport("HTTP_REQ_SENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_REQ_SENT = "http.request_sent";
		}

		/// <summary>
		/// <para>Context attribute names for protocol execution.</para><para><para></para><para></para><title>Revision:</title><para>558154 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/ExecutionContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/ExecutionContext", AccessFlags = 1537)]
		public partial interface IExecutionContext
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>A response interceptor that adds a Server header. For use on the server side.</para><para><para></para><para></para><title>Revision:</title><para>576073 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/ResponseServer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/ResponseServer", AccessFlags = 33)]
		public partial class ResponseServer : global::Org.Apache.Http.IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseServer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A request interceptor that enables the expect-continue handshake.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/RequestExpectContinue
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/RequestExpectContinue", AccessFlags = 33)]
		public partial class RequestExpectContinue : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestExpectContinue() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides access to an ordered list of response interceptors. Lists are expected to be built upfront and used read-only afterwards for processing.</para><para><para></para><para></para><title>Revision:</title><para>554903 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpResponseInterceptorList
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpResponseInterceptorList", AccessFlags = 1537)]
		public partial interface IHttpResponseInterceptorList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Appends a response interceptor to this list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", AccessFlags = 1025)]
				void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor itcp) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inserts a response interceptor at the specified index.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", AccessFlags = 1025)]
				void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor itcp, int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the current size of this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of response interceptors in this list </para>
				/// </returns>
				/// <java-name>
				/// getResponseInterceptorCount
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptorCount", "()I", AccessFlags = 1025)]
				int GetResponseInterceptorCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains a response interceptor from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interceptor at the given index, or <code>null</code> if the index is out of range </para>
				/// </returns>
				/// <java-name>
				/// getResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponseInterceptor GetResponseInterceptor(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all response interceptors from this list. </para>        
				/// </summary>
				/// <java-name>
				/// clearResponseInterceptors
				/// </java-name>
				[Dot42.DexImport("clearResponseInterceptors", "()V", AccessFlags = 1025)]
				void ClearResponseInterceptors() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all response interceptor of the specified class</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeResponseInterceptorByClass
				/// </java-name>
				[Dot42.DexImport("removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", AccessFlags = 1025)]
				void RemoveResponseInterceptorByClass(global::System.Type clazz) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the response interceptors in this list. This list will be cleared and re-initialized to contain all response interceptors from the argument list. If the argument list includes elements that are not response interceptors, the behavior is implementation dependent.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterceptors
				/// </java-name>
				[Dot42.DexImport("setInterceptors", "(Ljava/util/List;)V", AccessFlags = 1025)]
				void SetInterceptors(global::Java.Util.IList<object> itcps) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A response interceptor that suggests connection keep-alive to the client. For use on the server side.</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/ResponseConnControl
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/ResponseConnControl", AccessFlags = 33)]
		public partial class ResponseConnControl : global::Org.Apache.Http.IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseConnControl() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A context for executing a request. The context is used to tie together the request, the response, and optional application data. It is also used for internal data. Attribute names starting with the prefix "http." are reserved for internal data.</para><para><para></para><para></para><title>Revision:</title><para>558111 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpContext", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IHttpContextConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The prefix reserved for use by HTTP components. "http." </para>        
				/// </summary>
				/// <java-name>
				/// RESERVED_PREFIX
				/// </java-name>
				[Dot42.DexImport("RESERVED_PREFIX", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RESERVED_PREFIX = "http.";
		}

		/// <summary>
		/// <para>A context for executing a request. The context is used to tie together the request, the response, and optional application data. It is also used for internal data. Attribute names starting with the prefix "http." are reserved for internal data.</para><para><para></para><para></para><title>Revision:</title><para>558111 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpContext", AccessFlags = 1537)]
		public partial interface IHttpContext
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetAttribute(string id) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetAttribute(string id, object obj) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object RemoveAttribute(string id) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Default implementation of the HttpContext.</para><para><para></para><para></para><title>Revision:</title><para>654882 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/BasicHttpContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/BasicHttpContext", AccessFlags = 33)]
		public partial class BasicHttpContext : global::Org.Apache.Http.Protocol.IHttpContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHttpContext() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public BasicHttpContext(global::Org.Apache.Http.Protocol.IHttpContext parentContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetAttribute(string id) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetAttribute(string id, object obj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object RemoveAttribute(string id) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>A response interceptor that adds a Date header. For use on the server side.</para><para><para></para><para></para><title>Revision:</title><para>555989 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/ResponseDate
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/ResponseDate", AccessFlags = 33)]
		public partial class ResponseDate : global::Org.Apache.Http.IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseDate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Keeps lists of interceptors for processing requests and responses.</para><para><para> </para><simplesectsep></simplesectsep><para>Andrea Selva</para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/BasicHttpProcessor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/BasicHttpProcessor", AccessFlags = 49)]
		public sealed partial class BasicHttpProcessor : global::Org.Apache.Http.Protocol.IHttpProcessor, global::Org.Apache.Http.Protocol.IHttpRequestInterceptorList, global::Org.Apache.Http.Protocol.IHttpResponseInterceptorList, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// requestInterceptors
				/// </java-name>
				[Dot42.DexImport("requestInterceptors", "Ljava/util/List;", AccessFlags = 4)]
				internal global::Java.Util.IList<object> RequestInterceptors;
				/// <java-name>
				/// responseInterceptors
				/// </java-name>
				[Dot42.DexImport("responseInterceptors", "Ljava/util/List;", AccessFlags = 4)]
				internal global::Java.Util.IList<object> ResponseInterceptors;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHttpProcessor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", AccessFlags = 1)]
				public void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor itcp) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", AccessFlags = 1)]
				public void AddRequestInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor itcp, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts a response interceptor at the specified index.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", AccessFlags = 1)]
				public void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor itcp, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeRequestInterceptorByClass
				/// </java-name>
				[Dot42.DexImport("removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", AccessFlags = 1)]
				public void RemoveRequestInterceptorByClass(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeResponseInterceptorByClass
				/// </java-name>
				[Dot42.DexImport("removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", AccessFlags = 1)]
				public void RemoveResponseInterceptorByClass(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Same as addRequestInterceptor.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addInterceptor
				/// </java-name>
				[Dot42.DexImport("addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", AccessFlags = 17)]
				public void AddInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor interceptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addInterceptor
				/// </java-name>
				[Dot42.DexImport("addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", AccessFlags = 17)]
				public void AddInterceptor(global::Org.Apache.Http.IHttpRequestInterceptor interceptor, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the current size of this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of request interceptors in this list </para>
				/// </returns>
				/// <java-name>
				/// getRequestInterceptorCount
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptorCount", "()I", AccessFlags = 1)]
				public int GetRequestInterceptorCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains a request interceptor from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interceptor at the given index, or <code>null</code> if the index is out of range </para>
				/// </returns>
				/// <java-name>
				/// getRequestInterceptor
				/// </java-name>
				[Dot42.DexImport("getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpRequestInterceptor GetRequestInterceptor(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequestInterceptor);
				}

				/// <summary>
				/// <para>Removes all request interceptors from this list. </para>        
				/// </summary>
				/// <java-name>
				/// clearRequestInterceptors
				/// </java-name>
				[Dot42.DexImport("clearRequestInterceptors", "()V", AccessFlags = 1)]
				public void ClearRequestInterceptors() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", AccessFlags = 1)]
				public void AddResponseInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor itcp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Same as addRequestInterceptor.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addInterceptor
				/// </java-name>
				[Dot42.DexImport("addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", AccessFlags = 17)]
				public void AddInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor interceptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addInterceptor
				/// </java-name>
				[Dot42.DexImport("addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", AccessFlags = 17)]
				public void AddInterceptor(global::Org.Apache.Http.IHttpResponseInterceptor interceptor, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the current size of this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of response interceptors in this list </para>
				/// </returns>
				/// <java-name>
				/// getResponseInterceptorCount
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptorCount", "()I", AccessFlags = 1)]
				public int GetResponseInterceptorCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains a response interceptor from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interceptor at the given index, or <code>null</code> if the index is out of range </para>
				/// </returns>
				/// <java-name>
				/// getResponseInterceptor
				/// </java-name>
				[Dot42.DexImport("getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", AccessFlags = 1)]
				public global::Org.Apache.Http.IHttpResponseInterceptor GetResponseInterceptor(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponseInterceptor);
				}

				/// <summary>
				/// <para>Removes all response interceptors from this list. </para>        
				/// </summary>
				/// <java-name>
				/// clearResponseInterceptors
				/// </java-name>
				[Dot42.DexImport("clearResponseInterceptors", "()V", AccessFlags = 1)]
				public void ClearResponseInterceptors() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the interceptor lists. First, both interceptor lists maintained by this processor will be cleared. Subsequently, elements of the argument list that are request interceptors will be added to the request interceptor list. Elements that are response interceptors will be added to the response interceptor list. Elements that are both request and response interceptor will be added to both lists. Elements that are neither request nor response interceptor will be ignored.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterceptors
				/// </java-name>
				[Dot42.DexImport("setInterceptors", "(Ljava/util/List;)V", AccessFlags = 1)]
				public void SetInterceptors(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears both interceptor lists maintained by this processor. </para>        
				/// </summary>
				/// <java-name>
				/// clearInterceptors
				/// </java-name>
				[Dot42.DexImport("clearInterceptors", "()V", AccessFlags = 1)]
				public void ClearInterceptors() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public void Process(global::Org.Apache.Http.IHttpResponse request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyInterceptors
				/// </java-name>
				[Dot42.DexImport("copyInterceptors", "(Lorg/apache/http/protocol/BasicHttpProcessor;)V", AccessFlags = 4)]
				internal void CopyInterceptors(global::Org.Apache.Http.Protocol.BasicHttpProcessor target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a copy of this instance</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>new instance of the BasicHttpProcessor </para>
				/// </returns>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/protocol/BasicHttpProcessor;", AccessFlags = 1)]
				public global::Org.Apache.Http.Protocol.BasicHttpProcessor Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.BasicHttpProcessor);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Obtains the current size of this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of request interceptors in this list </para>
				/// </returns>
				/// <java-name>
				/// getRequestInterceptorCount
				/// </java-name>
				public int RequestInterceptorCount
				{
				[Dot42.DexImport("getRequestInterceptorCount", "()I", AccessFlags = 1)]
						get{ return GetRequestInterceptorCount(); }
				}

				/// <summary>
				/// <para>Obtains the current size of this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of response interceptors in this list </para>
				/// </returns>
				/// <java-name>
				/// getResponseInterceptorCount
				/// </java-name>
				public int ResponseInterceptorCount
				{
				[Dot42.DexImport("getResponseInterceptorCount", "()I", AccessFlags = 1)]
						get{ return GetResponseInterceptorCount(); }
				}

		}

		/// <summary>
		/// <para>HttpContext implementation that delegates resolution of an attribute to the given default HttpContext instance if the attribute is not present in the local one. The state of the local context can be mutated, whereas the default context is treated as read-only.</para><para><para></para><para></para><title>Revision:</title><para>654882 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/DefaultedHttpContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/DefaultedHttpContext", AccessFlags = 49)]
		public sealed partial class DefaultedHttpContext : global::Org.Apache.Http.Protocol.IHttpContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public DefaultedHttpContext(global::Org.Apache.Http.Protocol.IHttpContext local, global::Org.Apache.Http.Protocol.IHttpContext defaults) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public object GetAttribute(string id) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public object RemoveAttribute(string id) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public void SetAttribute(string id, object obj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaults
				/// </java-name>
				[Dot42.DexImport("getDefaults", "()Lorg/apache/http/protocol/HttpContext;", AccessFlags = 1)]
				public global::Org.Apache.Http.Protocol.IHttpContext GetDefaults() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Protocol.IHttpContext);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultedHttpContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaults
				/// </java-name>
				public global::Org.Apache.Http.Protocol.IHttpContext Defaults
				{
				[Dot42.DexImport("getDefaults", "()Lorg/apache/http/protocol/HttpContext;", AccessFlags = 1)]
						get{ return GetDefaults(); }
				}

		}

		/// <summary>
		/// <para>A response interceptor that sets up entity-related headers. For use on the server side.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/ResponseContent
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/ResponseContent", AccessFlags = 33)]
		public partial class ResponseContent : global::Org.Apache.Http.IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseContent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A request interceptor that suggests connection keep-alive to the server.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/RequestConnControl
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/RequestConnControl", AccessFlags = 33)]
		public partial class RequestConnControl : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestConnControl() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A request interceptor that decides about the transport encoding.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/RequestContent
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/RequestContent", AccessFlags = 33)]
		public partial class RequestContent : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestContent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Sends HTTP requests and receives the responses. Takes care of request preprocessing and response postprocessing by the respective interceptors.</para><para><para></para><para></para><title>Revision:</title><para>576073 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpRequestExecutor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpRequestExecutor", AccessFlags = 33)]
		public partial class HttpRequestExecutor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new request executor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpRequestExecutor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Decide whether a response comes with an entity. The implementation in this class is based on RFC 2616. Unknown methods and response codes are supposed to indicate responses with an entity. <br></br> Derived executors can override this method to handle methods and response codes not specified in RFC 2616.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// canResponseHaveBody
				/// </java-name>
				[Dot42.DexImport("canResponseHaveBody", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;)Z", AccessFlags = 4)]
				protected internal virtual bool CanResponseHaveBody(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Synchronously send a request and obtain the response.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response to the request, postprocessed</para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/h" +
    "ttp/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse Execute(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpClientConnection conn, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Prepare a request for sending.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// preProcess
				/// </java-name>
				[Dot42.DexImport("preProcess", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache" +
    "/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void PreProcess(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpProcessor processor, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Send a request over a connection. This method also handles the expect-continue handshake if necessary. If it does not have to handle an expect-continue handshake, it will not use the connection for reading or anything else that depends on data coming in over the connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a terminal response received as part of an expect-continue handshake, or <code>null</code> if the expect-continue handshake is not used</para>
				/// </returns>
				/// <java-name>
				/// doSendRequest
				/// </java-name>
				[Dot42.DexImport("doSendRequest", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/h" +
    "ttp/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHttpResponse DoSendRequest(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpClientConnection conn, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Wait for and receive a response. This method will automatically ignore intermediate responses with status code 1xx.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final response, not yet post-processed</para>
				/// </returns>
				/// <java-name>
				/// doReceiveResponse
				/// </java-name>
				[Dot42.DexImport("doReceiveResponse", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/h" +
    "ttp/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHttpResponse DoReceiveResponse(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpClientConnection conn, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Finish a response. This includes post-processing of the response object. It does <b>not</b> read the response entity, if any. It does <b>not</b> allow for immediate re-use of the connection over which the response is coming in.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// postProcess
				/// </java-name>
				[Dot42.DexImport("postProcess", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpProcessor;Lorg/apach" +
    "e/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void PostProcess(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpProcessor processor, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A request interceptor that adds a User-Agent header.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/RequestUserAgent
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/RequestUserAgent", AccessFlags = 33)]
		public partial class RequestUserAgent : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestUserAgent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A request interceptor that adds a Date header. For use on the client side.</para><para><para></para><para></para><title>Revision:</title><para>555989 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/RequestDate
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/RequestDate", AccessFlags = 33)]
		public partial class RequestDate : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestDate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Maintains a map of objects keyed by a request URI pattern. Instances can be looked up by request URI.<br></br> Patterns may have three formats: <ul><li><para><code>*</code> </para></li><li><para><code>*&lt;uri&gt;</code> </para></li><li><para><code>&lt;uri&gt;*</code> </para></li></ul></para><para><para></para><para></para><title>Revision:</title><para>630662 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/UriPatternMatcher
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/UriPatternMatcher", AccessFlags = 33)]
		public partial class UriPatternMatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UriPatternMatcher() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Register(string pattern, object handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Unregister(string pattern) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandlers
				/// </java-name>
				[Dot42.DexImport("setHandlers", "(Ljava/util/Map;)V", AccessFlags = 1)]
				public virtual void SetHandlers(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Lookup(string requestURI) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// matchUriRequestPattern
				/// </java-name>
				[Dot42.DexImport("matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 4)]
				protected internal virtual bool MatchUriRequestPattern(string pattern, string requestUri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Thread-safe extension of the BasicHttpContext.</para><para><para></para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/SyncBasicHttpContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/SyncBasicHttpContext", AccessFlags = 33)]
		public partial class SyncBasicHttpContext : global::Org.Apache.Http.Protocol.BasicHttpContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public SyncBasicHttpContext(global::Org.Apache.Http.Protocol.IHttpContext parentContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 33)]
				public override object GetAttribute(string id) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 33)]
				public override void SetAttribute(string id, object obj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 33)]
				public override object RemoveAttribute(string id) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SyncBasicHttpContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines an interface to verify whether an incoming HTTP request meets the target server's expectations. </para><para>The Expect request-header field is used to indicate that particular server behaviors are required by the client. </para><para><pre>
		///       Expect       =  "Expect" ":" 1#expectation
		/// 
		///       expectation  =  "100-continue" | expectation-extension
		///       expectation-extension =  token [ "=" ( token | quoted-string )
		///                                *expect-params ]
		///       expect-params =  ";" token [ "=" ( token | quoted-string ) ]
		///  *</pre> </para><para>A server that does not understand or is unable to comply with any of the expectation values in the Expect field of a request MUST respond with appropriate error status. The server MUST respond with a 417 (Expectation Failed) status if any of the expectations cannot be met or, if there are other problems with the request, some other 4xx status. </para><para><para></para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpExpectationVerifier
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpExpectationVerifier", AccessFlags = 1537)]
		public partial interface IHttpExpectationVerifier
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/prot" +
    "ocol/HttpContext;)V", AccessFlags = 1025)]
				void Verify(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Constants and static helpers related to the HTTP protocol.</para><para><para></para><para></para><title>Revision:</title><para>555989 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HTTP
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HTTP", AccessFlags = 49)]
		public sealed partial class HTTP
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CR
				/// </java-name>
				[Dot42.DexImport("CR", "I", AccessFlags = 25)]
				public const int CR = 13;
				/// <java-name>
				/// LF
				/// </java-name>
				[Dot42.DexImport("LF", "I", AccessFlags = 25)]
				public const int LF = 10;
				/// <java-name>
				/// SP
				/// </java-name>
				[Dot42.DexImport("SP", "I", AccessFlags = 25)]
				public const int SP = 32;
				/// <java-name>
				/// HT
				/// </java-name>
				[Dot42.DexImport("HT", "I", AccessFlags = 25)]
				public const int HT = 9;
				/// <summary>
				/// <para>HTTP header definitions </para>        
				/// </summary>
				/// <java-name>
				/// TRANSFER_ENCODING
				/// </java-name>
				[Dot42.DexImport("TRANSFER_ENCODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TRANSFER_ENCODING = "Transfer-Encoding";
				/// <java-name>
				/// CONTENT_LEN
				/// </java-name>
				[Dot42.DexImport("CONTENT_LEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONTENT_LEN = "Content-Length";
				/// <java-name>
				/// CONTENT_TYPE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONTENT_TYPE = "Content-Type";
				/// <java-name>
				/// CONTENT_ENCODING
				/// </java-name>
				[Dot42.DexImport("CONTENT_ENCODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONTENT_ENCODING = "Content-Encoding";
				/// <java-name>
				/// EXPECT_DIRECTIVE
				/// </java-name>
				[Dot42.DexImport("EXPECT_DIRECTIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXPECT_DIRECTIVE = "Expect";
				/// <java-name>
				/// CONN_DIRECTIVE
				/// </java-name>
				[Dot42.DexImport("CONN_DIRECTIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONN_DIRECTIVE = "Connection";
				/// <java-name>
				/// TARGET_HOST
				/// </java-name>
				[Dot42.DexImport("TARGET_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TARGET_HOST = "Host";
				/// <java-name>
				/// USER_AGENT
				/// </java-name>
				[Dot42.DexImport("USER_AGENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USER_AGENT = "User-Agent";
				/// <java-name>
				/// DATE_HEADER
				/// </java-name>
				[Dot42.DexImport("DATE_HEADER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DATE_HEADER = "Date";
				/// <java-name>
				/// SERVER_HEADER
				/// </java-name>
				[Dot42.DexImport("SERVER_HEADER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVER_HEADER = "Server";
				/// <summary>
				/// <para>HTTP expectations </para>        
				/// </summary>
				/// <java-name>
				/// EXPECT_CONTINUE
				/// </java-name>
				[Dot42.DexImport("EXPECT_CONTINUE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXPECT_CONTINUE = "100-continue";
				/// <summary>
				/// <para>HTTP connection control </para>        
				/// </summary>
				/// <java-name>
				/// CONN_CLOSE
				/// </java-name>
				[Dot42.DexImport("CONN_CLOSE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONN_CLOSE = "Close";
				/// <java-name>
				/// CONN_KEEP_ALIVE
				/// </java-name>
				[Dot42.DexImport("CONN_KEEP_ALIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONN_KEEP_ALIVE = "Keep-Alive";
				/// <summary>
				/// <para>Transfer encoding definitions </para>        
				/// </summary>
				/// <java-name>
				/// CHUNK_CODING
				/// </java-name>
				[Dot42.DexImport("CHUNK_CODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CHUNK_CODING = "chunked";
				/// <java-name>
				/// IDENTITY_CODING
				/// </java-name>
				[Dot42.DexImport("IDENTITY_CODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string IDENTITY_CODING = "identity";
				/// <summary>
				/// <para>Common charset definitions </para>        
				/// </summary>
				/// <java-name>
				/// UTF_8
				/// </java-name>
				[Dot42.DexImport("UTF_8", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UTF_8 = "UTF-8";
				/// <java-name>
				/// UTF_16
				/// </java-name>
				[Dot42.DexImport("UTF_16", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UTF_16 = "UTF-16";
				/// <java-name>
				/// US_ASCII
				/// </java-name>
				[Dot42.DexImport("US_ASCII", "Ljava/lang/String;", AccessFlags = 25)]
				public const string US_ASCII = "US-ASCII";
				/// <java-name>
				/// ASCII
				/// </java-name>
				[Dot42.DexImport("ASCII", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ASCII = "ASCII";
				/// <java-name>
				/// ISO_8859_1
				/// </java-name>
				[Dot42.DexImport("ISO_8859_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ISO_8859_1 = "ISO-8859-1";
				/// <summary>
				/// <para>Default charsets </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_CONTENT_CHARSET
				/// </java-name>
				[Dot42.DexImport("DEFAULT_CONTENT_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_CONTENT_CHARSET = "ISO-8859-1";
				/// <java-name>
				/// DEFAULT_PROTOCOL_CHARSET
				/// </java-name>
				[Dot42.DexImport("DEFAULT_PROTOCOL_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_PROTOCOL_CHARSET = "US-ASCII";
				/// <summary>
				/// <para>Content type definitions </para>        
				/// </summary>
				/// <java-name>
				/// OCTET_STREAM_TYPE
				/// </java-name>
				[Dot42.DexImport("OCTET_STREAM_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OCTET_STREAM_TYPE = "application/octet-stream";
				/// <java-name>
				/// PLAIN_TEXT_TYPE
				/// </java-name>
				[Dot42.DexImport("PLAIN_TEXT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PLAIN_TEXT_TYPE = "text/plain";
				/// <java-name>
				/// CHARSET_PARAM
				/// </java-name>
				[Dot42.DexImport("CHARSET_PARAM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CHARSET_PARAM = "; charset=";
				/// <summary>
				/// <para>Default content type </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_CONTENT_TYPE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_CONTENT_TYPE = "application/octet-stream";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HTTP() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(C)Z", AccessFlags = 9)]
				public static bool IsWhitespace(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Performs interceptor processing of requests and responses. Specific interceptors typically interpret or update message headers, and they may wrap the message entity for example to implement a specific transport or content encoding. A <code>HttpProcessor</code> typically maintains a list of interceptors that will be applied to a request or response.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpProcessor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpProcessor", AccessFlags = 1537)]
		public partial interface IHttpProcessor : global::Org.Apache.Http.IHttpRequestInterceptor, global::Org.Apache.Http.IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Minimalistic server-side implementation of an HTTP processor.</para><para><para></para><para></para><title>Revision:</title><para>610763 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/protocol/HttpService
		/// </java-name>
		[Dot42.DexImport("org/apache/http/protocol/HttpService", AccessFlags = 33)]
		public partial class HttpService
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new HTTP service.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/ConnectionReuseStrategy" +
    ";Lorg/apache/http/HttpResponseFactory;)V", AccessFlags = 1)]
				public HttpService(global::Org.Apache.Http.Protocol.IHttpProcessor proc, global::Org.Apache.Http.IConnectionReuseStrategy connStrategy, global::Org.Apache.Http.IHttpResponseFactory responseFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHttpProcessor
				/// </java-name>
				[Dot42.DexImport("setHttpProcessor", "(Lorg/apache/http/protocol/HttpProcessor;)V", AccessFlags = 1)]
				public virtual void SetHttpProcessor(global::Org.Apache.Http.Protocol.IHttpProcessor processor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnReuseStrategy
				/// </java-name>
				[Dot42.DexImport("setConnReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V", AccessFlags = 1)]
				public virtual void SetConnReuseStrategy(global::Org.Apache.Http.IConnectionReuseStrategy connStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setResponseFactory
				/// </java-name>
				[Dot42.DexImport("setResponseFactory", "(Lorg/apache/http/HttpResponseFactory;)V", AccessFlags = 1)]
				public virtual void SetResponseFactory(global::Org.Apache.Http.IHttpResponseFactory responseFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandlerResolver
				/// </java-name>
				[Dot42.DexImport("setHandlerResolver", "(Lorg/apache/http/protocol/HttpRequestHandlerResolver;)V", AccessFlags = 1)]
				public virtual void SetHandlerResolver(global::Org.Apache.Http.Protocol.IHttpRequestHandlerResolver handlerResolver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExpectationVerifier
				/// </java-name>
				[Dot42.DexImport("setExpectationVerifier", "(Lorg/apache/http/protocol/HttpExpectationVerifier;)V", AccessFlags = 1)]
				public virtual void SetExpectationVerifier(global::Org.Apache.Http.Protocol.IHttpExpectationVerifier expectationVerifier) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// setParams
				/// </java-name>
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleRequest
				/// </java-name>
				[Dot42.DexImport("handleRequest", "(Lorg/apache/http/HttpServerConnection;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void HandleRequest(global::Org.Apache.Http.IHttpServerConnection conn, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleException
				/// </java-name>
				[Dot42.DexImport("handleException", "(Lorg/apache/http/HttpException;Lorg/apache/http/HttpResponse;)V", AccessFlags = 4)]
				protected internal virtual void HandleException(global::Org.Apache.Http.HttpException ex, global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doService
				/// </java-name>
				[Dot42.DexImport("doService", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/prot" +
    "ocol/HttpContext;)V", AccessFlags = 4)]
				protected internal virtual void DoService(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpService() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams Params
				{
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
						get{ return GetParams(); }
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
						set{ SetParams(value); }
				}

		}

}


