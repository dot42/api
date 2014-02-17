// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Client.Methods.cs
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
namespace Org.Apache.Http.Client.Methods
{
		/// <summary>
		/// <para>HTTP HEAD method. </para><para>The HTTP HEAD method is defined in section 9.4 of : <blockquote><para>The HEAD method is identical to GET except that the server MUST NOT return a message-body in the response. The metainformation contained in the HTTP headers in response to a HEAD request SHOULD be identical to the information sent in response to a GET request. This method can be used for obtaining metainformation about the entity implied by the request without transferring the entity-body itself. This method is often used for testing hypertext links for validity, accessibility, and recent modification. </para></blockquote></para><para><para></para><title>Revision:</title><para>664505 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpHead
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpHead", AccessFlags = 33)]
		public partial class HttpHead : global::Org.Apache.Http.Client.Methods.HttpRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "HEAD";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpHead() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpHead(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpHead(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				}

		}

		/// <summary>
		/// <para>Basic implementation of an HTTP request that can be modified.</para><para><para></para><para></para><title>Revision:</title><para>674186 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpRequestBase
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpRequestBase", AccessFlags = 1057)]
		public abstract partial class HttpRequestBase : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.Client.Methods.IHttpUriRequest, global::Org.Apache.Http.Client.Methods.IAbortableHttpRequest, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpRequestBase() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <java-name>
				/// setURI
				/// </java-name>
				[Dot42.DexImport("setURI", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public virtual void SetURI(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionRequest
				/// </java-name>
				[Dot42.DexImport("setConnectionRequest", "(Lorg/apache/http/conn/ClientConnectionRequest;)V", AccessFlags = 1)]
				public virtual void SetConnectionRequest(global::Org.Apache.Http.Conn.IClientConnectionRequest connRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReleaseTrigger
				/// </java-name>
				[Dot42.DexImport("setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V", AccessFlags = 1)]
				public virtual void SetReleaseTrigger(global::Org.Apache.Http.Conn.IConnectionReleaseTrigger releaseTrigger) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Aborts this http request. Any active execution of this method should return immediately. If the request has not started, it will abort after the next execution. Aborting this request will cause all subsequent executions with this request to fail.</para><para><para>HttpClient::execute(HttpUriRequest) </para><simplesectsep></simplesectsep><para>HttpClient::execute(org.apache.http.HttpHost, org.apache.http.HttpRequest) </para><simplesectsep></simplesectsep><para>HttpClient::execute(HttpUriRequest, org.apache.http.protocol.HttpContext) </para><simplesectsep></simplesectsep><para>HttpClient::execute(org.apache.http.HttpHost, org.apache.http.HttpRequest, org.apache.http.protocol.HttpContext) </para></para>        
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetMethod(); }
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

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>HTTP OPTIONS method. </para><para>The HTTP OPTIONS method is defined in section 9.2 of : <blockquote><para>The OPTIONS method represents a request for information about the communication options available on the request/response chain identified by the Request-URI. This method allows the client to determine the options and/or requirements associated with a resource, or the capabilities of a server, without implying a resource action or initiating a resource retrieval. </para></blockquote></para><para><para></para><title>Revision:</title><para>664505 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpOptions
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpOptions", AccessFlags = 33)]
		public partial class HttpOptions : global::Org.Apache.Http.Client.Methods.HttpRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "OPTIONS";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpOptions() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpOptions(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpOptions(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAllowedMethods
				/// </java-name>
				[Dot42.DexImport("getAllowedMethods", "(Lorg/apache/http/HttpResponse;)Ljava/util/Set;", AccessFlags = 1, Signature = "(Lorg/apache/http/HttpResponse;)Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetAllowedMethods(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
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
				}

		}

		/// <summary>
		/// <para>HTTP PUT method. </para><para>The HTTP PUT method is defined in section 9.6 of : <blockquote><para>The PUT method requests that the enclosed entity be stored under the supplied Request-URI. If the Request-URI refers to an already existing resource, the enclosed entity SHOULD be considered as a modified version of the one residing on the origin server. </para></blockquote></para><para><para></para><title>Revision:</title><para>664505 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpPut
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpPut", AccessFlags = 33)]
		public partial class HttpPut : global::Org.Apache.Http.Client.Methods.HttpEntityEnclosingRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "PUT";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpPut() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpPut(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpPut(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				}

		}

		/// <summary>
		/// <para>HTTP DELETE method </para><para>The HTTP DELETE method is defined in section 9.7 of : <blockquote><para>The DELETE method requests that the origin server delete the resource identified by the Request-URI. [...] The client cannot be guaranteed that the operation has been carried out, even if the status code returned from the origin server indicates that the action has been completed successfully. </para></blockquote></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpDelete
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpDelete", AccessFlags = 33)]
		public partial class HttpDelete : global::Org.Apache.Http.Client.Methods.HttpRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "DELETE";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpDelete() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpDelete(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpDelete(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				}

		}

		/// <summary>
		/// <para>Basic implementation of an HTTP request that can be modified.</para><para><para></para><para></para><title>Revision:</title><para>674186 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpEntityEnclosingRequestBase
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpEntityEnclosingRequestBase", AccessFlags = 1057)]
		public abstract partial class HttpEntityEnclosingRequestBase : global::Org.Apache.Http.Client.Methods.HttpRequestBase, global::Org.Apache.Http.IHttpEntityEnclosingRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpEntityEnclosingRequestBase() /* MethodBuilder.Create */ 
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
		/// <para>HTTP TRACE method. </para><para>The HTTP TRACE method is defined in section 9.6 of : <blockquote><para>The TRACE method is used to invoke a remote, application-layer loop- back of the request message. The final recipient of the request SHOULD reflect the message received back to the client as the entity-body of a 200 (OK) response. The final recipient is either the origin server or the first proxy or gateway to receive a Max-Forwards value of zero (0) in the request (see section 14.31). A TRACE request MUST NOT include an entity. </para></blockquote></para><para><para></para><title>Revision:</title><para>664505 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpTrace
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpTrace", AccessFlags = 33)]
		public partial class HttpTrace : global::Org.Apache.Http.Client.Methods.HttpRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "TRACE";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpTrace() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpTrace(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpTrace(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				}

		}

		/// <summary>
		/// <para>HTTP POST method. </para><para>The HTTP POST method is defined in section 9.5 of : <blockquote><para>The POST method is used to request that the origin server accept the entity enclosed in the request as a new subordinate of the resource identified by the Request-URI in the Request-Line. POST is designed to allow a uniform method to cover the following functions: <ul><li><para>Annotation of existing resources </para></li><li><para>Posting a message to a bulletin board, newsgroup, mailing list, or similar group of articles </para></li><li><para>Providing a block of data, such as the result of submitting a form, to a data-handling process </para></li><li><para>Extending a database through an append operation </para></li></ul></para></blockquote></para><para><para></para><title>Revision:</title><para>664505 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpPost
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpPost", AccessFlags = 33)]
		public partial class HttpPost : global::Org.Apache.Http.Client.Methods.HttpEntityEnclosingRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "POST";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpPost() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpPost(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpPost(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				}

		}

		/// <summary>
		/// <para>Extended version of the HttpRequest interface that provides convenience methods to access request properties such as request URI and method type.</para><para><para></para><para></para><title>Revision:</title><para>659191 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpUriRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpUriRequest", AccessFlags = 1537)]
		public partial interface IHttpUriRequest : global::Org.Apache.Http.IHttpRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetMethod() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the URI this request uses, such as <code></code>. </para>        
				/// </summary>
				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "()Ljava/net/URI;", AccessFlags = 1025)]
				global::System.Uri GetURI() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Aborts execution of the request.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tests if the request execution has been aborted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the request execution has been aborted, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAborted
				/// </java-name>
				[Dot42.DexImport("isAborted", "()Z", AccessFlags = 1025)]
				bool IsAborted() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface representing an HTTP request that can be aborted by shutting down the underlying HTTP connection.</para><para><para></para><para></para><title>Revision:</title><para>639600 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/AbortableHttpRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/AbortableHttpRequest", AccessFlags = 1537)]
		public partial interface IAbortableHttpRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Sets the ClientConnectionRequest callback that can be used to abort a long-lived request for a connection. If the request is already aborted, throws an IOException.</para><para><para>ClientConnectionManager </para><simplesectsep></simplesectsep><para>ThreadSafeClientConnManager </para></para>        
				/// </summary>
				/// <java-name>
				/// setConnectionRequest
				/// </java-name>
				[Dot42.DexImport("setConnectionRequest", "(Lorg/apache/http/conn/ClientConnectionRequest;)V", AccessFlags = 1025)]
				void SetConnectionRequest(global::Org.Apache.Http.Conn.IClientConnectionRequest connRequest) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the ConnectionReleaseTrigger callback that can be used to abort an active connection. Typically, this will be the ManagedClientConnection itself. If the request is already aborted, throws an IOException. </para>        
				/// </summary>
				/// <java-name>
				/// setReleaseTrigger
				/// </java-name>
				[Dot42.DexImport("setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V", AccessFlags = 1025)]
				void SetReleaseTrigger(global::Org.Apache.Http.Conn.IConnectionReleaseTrigger releaseTrigger) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Aborts this http request. Any active execution of this method should return immediately. If the request has not started, it will abort after the next execution. Aborting this request will cause all subsequent executions with this request to fail.</para><para><para>HttpClient::execute(HttpUriRequest) </para><simplesectsep></simplesectsep><para>HttpClient::execute(org.apache.http.HttpHost, org.apache.http.HttpRequest) </para><simplesectsep></simplesectsep><para>HttpClient::execute(HttpUriRequest, org.apache.http.protocol.HttpContext) </para><simplesectsep></simplesectsep><para>HttpClient::execute(org.apache.http.HttpHost, org.apache.http.HttpRequest, org.apache.http.protocol.HttpContext) </para></para>        
				/// </summary>
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>HTTP GET method. </para><para>The HTTP GET method is defined in section 9.3 of : <blockquote><para>The GET method means retrieve whatever information (in the form of an entity) is identified by the Request-URI. If the Request-URI refers to a data-producing process, it is the produced data which shall be returned as the entity in the response and not the source text of the process, unless that text happens to be the output of the process. </para></blockquote></para><para>GetMethods will follow redirect requests from the http server by default. This behavour can be disabled by calling setFollowRedirects(false).</para><para><para></para><title>Revision:</title><para>664505 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/methods/HttpGet
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpGet", AccessFlags = 33)]
		public partial class HttpGet : global::Org.Apache.Http.Client.Methods.HttpRequestBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD_NAME
				/// </java-name>
				[Dot42.DexImport("METHOD_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD_NAME = "GET";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpGet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public HttpGet(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpGet(string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the HTTP method this request uses, such as <code>GET</code>, <code>PUT</code>, <code>POST</code>, or other. </para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				}

		}

}


