#pragma warning disable 1717
namespace Org.Apache.Http.Impl
{
		/// <java-name>
		/// org/apache/http/impl/AbstractHttpClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/AbstractHttpClientConnection", AccessFlags = 1057)]
		public abstract partial class AbstractHttpClientConnection : global::Org.Apache.Http.IHttpClientConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractHttpClientConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOpen
				/// </java-name>
				[Dot42.DexImport("assertOpen", "()V", AccessFlags = 1028)]
				protected internal abstract void AssertOpen() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createEntityDeserializer
				/// </java-name>
				[Dot42.DexImport("createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Entity.EntityDeserializer CreateEntityDeserializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Entity.EntityDeserializer);
				}

				/// <java-name>
				/// createEntitySerializer
				/// </java-name>
				[Dot42.DexImport("createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Entity.EntitySerializer CreateEntitySerializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Entity.EntitySerializer);
				}

				/// <java-name>
				/// createHttpResponseFactory
				/// </java-name>
				[Dot42.DexImport("createHttpResponseFactory", "()Lorg/apache/http/HttpResponseFactory;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHttpResponseFactory CreateHttpResponseFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponseFactory);
				}

				/// <java-name>
				/// createResponseParser
				/// </java-name>
				[Dot42.DexImport("createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg" +
    "/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageParser CreateResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.IHttpResponseFactory httpResponseFactory, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageParser);
				}

				/// <java-name>
				/// createRequestWriter
				/// </java-name>
				[Dot42.DexImport("createRequestWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg" +
    "/apache/http/io/HttpMessageWriter;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageWriter CreateRequestWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageWriter);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isResponseAvailable
				/// </java-name>
				[Dot42.DexImport("isResponseAvailable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsResponseAvailable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestHeader(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendRequestEntity
				/// </java-name>
				[Dot42.DexImport("sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFlush
				/// </java-name>
				[Dot42.DexImport("doFlush", "()V", AccessFlags = 4)]
				protected internal virtual void DoFlush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// receiveResponseHeader
				/// </java-name>
				[Dot42.DexImport("receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse ReceiveResponseHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// receiveResponseEntity
				/// </java-name>
				[Dot42.DexImport("receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "shutdown", "()V", AccessFlags = 1025)]
				public virtual void Shutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// isStale
				/// </java-name>
				public virtual bool IsStale
				{
						[Dot42.DexImport("isStale", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public virtual global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
						[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHttpConnectionMetrics); }
				}

				public virtual bool IsOpen
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "isOpen", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public virtual int SocketTimeout
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
						get{ return default(int); }
						[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
						set{ }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/AbstractHttpServerConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/AbstractHttpServerConnection", AccessFlags = 1057)]
		public abstract partial class AbstractHttpServerConnection : global::Org.Apache.Http.IHttpServerConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractHttpServerConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOpen
				/// </java-name>
				[Dot42.DexImport("assertOpen", "()V", AccessFlags = 1028)]
				protected internal abstract void AssertOpen() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createEntityDeserializer
				/// </java-name>
				[Dot42.DexImport("createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Entity.EntityDeserializer CreateEntityDeserializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Entity.EntityDeserializer);
				}

				/// <java-name>
				/// createEntitySerializer
				/// </java-name>
				[Dot42.DexImport("createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Entity.EntitySerializer CreateEntitySerializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Entity.EntitySerializer);
				}

				/// <java-name>
				/// createHttpRequestFactory
				/// </java-name>
				[Dot42.DexImport("createHttpRequestFactory", "()Lorg/apache/http/HttpRequestFactory;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHttpRequestFactory CreateHttpRequestFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequestFactory);
				}

				/// <java-name>
				/// createRequestParser
				/// </java-name>
				[Dot42.DexImport("createRequestParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpRequestFactory;Lorg/" +
    "apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageParser CreateRequestParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.IHttpRequestFactory httpRequestFactory, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageParser);
				}

				/// <java-name>
				/// createResponseWriter
				/// </java-name>
				[Dot42.DexImport("createResponseWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg" +
    "/apache/http/io/HttpMessageWriter;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageWriter CreateResponseWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageWriter);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// receiveRequestHeader
				/// </java-name>
				[Dot42.DexImport("receiveRequestHeader", "()Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpRequest ReceiveRequestHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

				/// <java-name>
				/// receiveRequestEntity
				/// </java-name>
				[Dot42.DexImport("receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public virtual void ReceiveRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFlush
				/// </java-name>
				[Dot42.DexImport("doFlush", "()V", AccessFlags = 4)]
				protected internal virtual void DoFlush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendResponseHeader
				/// </java-name>
				[Dot42.DexImport("sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void SendResponseHeader(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendResponseEntity
				/// </java-name>
				[Dot42.DexImport("sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void SendResponseEntity(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "shutdown", "()V", AccessFlags = 1025)]
				public virtual void Shutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// isStale
				/// </java-name>
				public virtual bool IsStale
				{
						[Dot42.DexImport("isStale", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public virtual global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
						[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHttpConnectionMetrics); }
				}

				public virtual bool IsOpen
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "isOpen", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public virtual int SocketTimeout
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
						get{ return default(int); }
						[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
						set{ }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/DefaultConnectionReuseStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/DefaultConnectionReuseStrategy", AccessFlags = 33)]
		public partial class DefaultConnectionReuseStrategy : global::Org.Apache.Http.IConnectionReuseStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultConnectionReuseStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// keepAlive
				/// </java-name>
				[Dot42.DexImport("keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public virtual bool KeepAlive(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createTokenIterator
				/// </java-name>
				[Dot42.DexImport("createTokenIterator", "(Lorg/apache/http/HeaderIterator;)Lorg/apache/http/TokenIterator;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.ITokenIterator CreateTokenIterator(global::Org.Apache.Http.IHeaderIterator headerIterator) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ITokenIterator);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/DefaultHttpClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/DefaultHttpClientConnection", AccessFlags = 33)]
		public partial class DefaultHttpClientConnection : global::Org.Apache.Http.Impl.SocketHttpClientConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpClientConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public new virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/DefaultHttpRequestFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/DefaultHttpRequestFactory", AccessFlags = 33)]
		public partial class DefaultHttpRequestFactory : global::Org.Apache.Http.IHttpRequestFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpRequestFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpRequest NewHttpRequest(global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpRequest NewHttpRequest(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/DefaultHttpResponseFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/DefaultHttpResponseFactory", AccessFlags = 33)]
		public partial class DefaultHttpResponseFactory : global::Org.Apache.Http.IHttpResponseFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// reasonCatalog
				/// </java-name>
				[Dot42.DexImport("reasonCatalog", "Lorg/apache/http/ReasonPhraseCatalog;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IReasonPhraseCatalog ReasonCatalog;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ReasonPhraseCatalog;)V", AccessFlags = 1)]
				public DefaultHttpResponseFactory(global::Org.Apache.Http.IReasonPhraseCatalog reasonPhraseCatalog) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpResponseFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/ap" +
    "ache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/h" +
    "ttp/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.IStatusLine statusLine, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// determineLocale
				/// </java-name>
				[Dot42.DexImport("determineLocale", "(Lorg/apache/http/protocol/HttpContext;)Ljava/util/Locale;", AccessFlags = 4)]
				protected internal virtual global::Java.Util.Locale DetermineLocale(global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/DefaultHttpServerConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/DefaultHttpServerConnection", AccessFlags = 33)]
		public partial class DefaultHttpServerConnection : global::Org.Apache.Http.Impl.SocketHttpServerConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpServerConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public new virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/EnglishReasonPhraseCatalog
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/EnglishReasonPhraseCatalog", AccessFlags = 33)]
		public partial class EnglishReasonPhraseCatalog : global::Org.Apache.Http.IReasonPhraseCatalog
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INSTANCE
				/// </java-name>
				[Dot42.DexImport("INSTANCE", "Lorg/apache/http/impl/EnglishReasonPhraseCatalog;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Impl.EnglishReasonPhraseCatalog INSTANCE;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal EnglishReasonPhraseCatalog() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "(ILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReason(int int32, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/HttpConnectionMetricsImpl
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/HttpConnectionMetricsImpl", AccessFlags = 33)]
		public partial class HttpConnectionMetricsImpl : global::Org.Apache.Http.IHttpConnectionMetrics
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// REQUEST_COUNT
				/// </java-name>
				[Dot42.DexImport("REQUEST_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REQUEST_COUNT = "http.request-count";
				/// <java-name>
				/// RESPONSE_COUNT
				/// </java-name>
				[Dot42.DexImport("RESPONSE_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RESPONSE_COUNT = "http.response-count";
				/// <java-name>
				/// SENT_BYTES_COUNT
				/// </java-name>
				[Dot42.DexImport("SENT_BYTES_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SENT_BYTES_COUNT = "http.sent-bytes-count";
				/// <java-name>
				/// RECEIVED_BYTES_COUNT
				/// </java-name>
				[Dot42.DexImport("RECEIVED_BYTES_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RECEIVED_BYTES_COUNT = "http.received-bytes-count";
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/HttpTransportMetrics;Lorg/apache/http/io/HttpTransportMetric" +
    "s;)V", AccessFlags = 1)]
				public HttpConnectionMetricsImpl(global::Org.Apache.Http.Io.IHttpTransportMetrics httpTransportMetrics, global::Org.Apache.Http.Io.IHttpTransportMetrics httpTransportMetrics1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementRequestCount
				/// </java-name>
				[Dot42.DexImport("incrementRequestCount", "()V", AccessFlags = 1)]
				public virtual void IncrementRequestCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementResponseCount
				/// </java-name>
				[Dot42.DexImport("incrementResponseCount", "()V", AccessFlags = 1)]
				public virtual void IncrementResponseCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMetric
				/// </java-name>
				[Dot42.DexImport("getMetric", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetMetric(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setMetric
				/// </java-name>
				[Dot42.DexImport("setMetric", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetMetric(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HttpConnectionMetricsImpl() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getReceivedBytesCount
				/// </java-name>
				public virtual long ReceivedBytesCount
				{
						[Dot42.DexImport("getReceivedBytesCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getSentBytesCount
				/// </java-name>
				public virtual long SentBytesCount
				{
						[Dot42.DexImport("getSentBytesCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getRequestCount
				/// </java-name>
				public virtual long RequestCount
				{
						[Dot42.DexImport("getRequestCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getResponseCount
				/// </java-name>
				public virtual long ResponseCount
				{
						[Dot42.DexImport("getResponseCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/NoConnectionReuseStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/NoConnectionReuseStrategy", AccessFlags = 33)]
		public partial class NoConnectionReuseStrategy : global::Org.Apache.Http.IConnectionReuseStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoConnectionReuseStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// keepAlive
				/// </java-name>
				[Dot42.DexImport("keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1)]
				public virtual bool KeepAlive(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/SocketHttpClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/SocketHttpClientConnection", AccessFlags = 33)]
		public partial class SocketHttpClientConnection : global::Org.Apache.Http.Impl.AbstractHttpClientConnection, global::Org.Apache.Http.IHttpInetConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketHttpClientConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotOpen
				/// </java-name>
				[Dot42.DexImport("assertNotOpen", "()V", AccessFlags = 4)]
				protected internal virtual void AssertNotOpen() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOpen
				/// </java-name>
				[Dot42.DexImport("assertOpen", "()V", AccessFlags = 4)]
				protected internal override void AssertOpen() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createSessionInputBuffer
				/// </java-name>
				[Dot42.DexImport("createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nInputBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.ISessionInputBuffer CreateSessionInputBuffer(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionInputBuffer);
				}

				/// <java-name>
				/// createSessionOutputBuffer
				/// </java-name>
				[Dot42.DexImport("createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nOutputBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.ISessionOutputBuffer CreateSessionOutputBuffer(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionOutputBuffer);
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isOpen
				/// </java-name>
				public override bool IsOpen
				{
						[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				protected internal virtual global::Java.Net.Socket Socket
				{
						[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 4)]
						get{ return default(global::Java.Net.Socket); }
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public virtual global::Java.Net.InetAddress LocalAddress
				{
						[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public virtual int LocalPort
				{
						[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				public virtual global::Java.Net.InetAddress RemoteAddress
				{
						[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				public virtual int RemotePort
				{
						[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				public override int SocketTimeout
				{
						[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
						set{ }
				}

				public override bool IsStale
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "isStale", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.IHttpConnectionMetrics); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/SocketHttpServerConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/SocketHttpServerConnection", AccessFlags = 33)]
		public partial class SocketHttpServerConnection : global::Org.Apache.Http.Impl.AbstractHttpServerConnection, global::Org.Apache.Http.IHttpInetConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketHttpServerConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotOpen
				/// </java-name>
				[Dot42.DexImport("assertNotOpen", "()V", AccessFlags = 4)]
				protected internal virtual void AssertNotOpen() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOpen
				/// </java-name>
				[Dot42.DexImport("assertOpen", "()V", AccessFlags = 4)]
				protected internal override void AssertOpen() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createHttpDataReceiver
				/// </java-name>
				[Dot42.DexImport("createHttpDataReceiver", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nInputBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.ISessionInputBuffer CreateHttpDataReceiver(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionInputBuffer);
				}

				/// <java-name>
				/// createHttpDataTransmitter
				/// </java-name>
				[Dot42.DexImport("createHttpDataTransmitter", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nOutputBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.ISessionOutputBuffer CreateHttpDataTransmitter(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionOutputBuffer);
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				protected internal virtual global::Java.Net.Socket Socket
				{
						[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 4)]
						get{ return default(global::Java.Net.Socket); }
				}

				/// <java-name>
				/// isOpen
				/// </java-name>
				public override bool IsOpen
				{
						[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public virtual global::Java.Net.InetAddress LocalAddress
				{
						[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public virtual int LocalPort
				{
						[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				public virtual global::Java.Net.InetAddress RemoteAddress
				{
						[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				public virtual int RemotePort
				{
						[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				public override int SocketTimeout
				{
						[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
						set{ }
				}

				public override bool IsStale
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "isStale", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
						[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
						get{ return default(global::Org.Apache.Http.IHttpConnectionMetrics); }
				}

		}

}

