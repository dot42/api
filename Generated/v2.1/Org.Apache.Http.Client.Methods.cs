#pragma warning disable 1717
namespace Org.Apache.Http.Client.Methods
{
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
				public HttpDelete(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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
				public HttpGet(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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
				public HttpHead(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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
				public HttpOptions(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllowedMethods
				/// </java-name>
				[Dot42.DexImport("getAllowedMethods", "(Lorg/apache/http/HttpResponse;)Ljava/util/Set;", AccessFlags = 1, Signature = "(Lorg/apache/http/HttpResponse;)Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetAllowedMethods(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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
				public HttpPost(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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
				public HttpPut(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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
				public virtual void SetConnectionRequest(global::Org.Apache.Http.Conn.IClientConnectionRequest clientConnectionRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReleaseTrigger
				/// </java-name>
				[Dot42.DexImport("setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V", AccessFlags = 1)]
				public virtual void SetReleaseTrigger(global::Org.Apache.Http.Conn.IConnectionReleaseTrigger connectionReleaseTrigger) /* MethodBuilder.Create */ 
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
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
				public HttpTrace(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public override string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/client/methods/AbortableHttpRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/AbortableHttpRequest", AccessFlags = 1537)]
		public partial interface IAbortableHttpRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setConnectionRequest
				/// </java-name>
				[Dot42.DexImport("setConnectionRequest", "(Lorg/apache/http/conn/ClientConnectionRequest;)V", AccessFlags = 1025)]
				void SetConnectionRequest(global::Org.Apache.Http.Conn.IClientConnectionRequest clientConnectionRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setReleaseTrigger
				/// </java-name>
				[Dot42.DexImport("setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V", AccessFlags = 1025)]
				void SetReleaseTrigger(global::Org.Apache.Http.Conn.IConnectionReleaseTrigger connectionReleaseTrigger) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/client/methods/HttpUriRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/methods/HttpUriRequest", AccessFlags = 1537)]
		public partial interface IHttpUriRequest : global::Org.Apache.Http.IHttpRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMethod
				/// </java-name>
				string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getURI
				/// </java-name>
				global::System.Uri URI
				{
						[Dot42.DexImport("getURI", "()Ljava/net/URI;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isAborted
				/// </java-name>
				bool IsAborted
				{
						[Dot42.DexImport("isAborted", "()Z", AccessFlags = 1025)]
						get;
				}

		}

}

