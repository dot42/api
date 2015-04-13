#pragma warning disable 1717
namespace Org.Apache.Http
{
		/// <java-name>
		/// org/apache/http/ConnectionClosedException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ConnectionClosedException", AccessFlags = 33)]
		public partial class ConnectionClosedException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectionClosedException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnectionClosedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/HttpException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpException", AccessFlags = 33)]
		public partial class HttpException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public HttpException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/HttpHost
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpHost", AccessFlags = 49)]
		public sealed partial class HttpHost : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_SCHEME_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_SCHEME_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_SCHEME_NAME = "http";
				/// <java-name>
				/// hostname
				/// </java-name>
				[Dot42.DexImport("hostname", "Ljava/lang/String;", AccessFlags = 20)]
				internal readonly string Hostname;
				/// <java-name>
				/// lcHostname
				/// </java-name>
				[Dot42.DexImport("lcHostname", "Ljava/lang/String;", AccessFlags = 20)]
				internal readonly string LcHostname;
				/// <java-name>
				/// port
				/// </java-name>
				[Dot42.DexImport("port", "I", AccessFlags = 20)]
				internal readonly int @port;
				/// <java-name>
				/// schemeName
				/// </java-name>
				[Dot42.DexImport("schemeName", "Ljava/lang/String;", AccessFlags = 20)]
				internal readonly string @schemename;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public HttpHost(string @string, int int32, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public HttpHost(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpHost(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public HttpHost(global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToURI() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toHostString
				/// </java-name>
				[Dot42.DexImport("toHostString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToHostString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpHost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHostName
				/// </java-name>
				public string HostName
				{
						[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public string SchemeName
				{
						[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/HttpVersion
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpVersion", AccessFlags = 49)]
		public sealed partial class HttpVersion : global::Org.Apache.Http.ProtocolVersion, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HTTP
				/// </java-name>
				[Dot42.DexImport("HTTP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP = "HTTP";
				/// <java-name>
				/// HTTP_0_9
				/// </java-name>
				[Dot42.DexImport("HTTP_0_9", "Lorg/apache/http/HttpVersion;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpVersion HTTP_0_9;
				/// <java-name>
				/// HTTP_1_0
				/// </java-name>
				[Dot42.DexImport("HTTP_1_0", "Lorg/apache/http/HttpVersion;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpVersion HTTP_1_0;
				/// <java-name>
				/// HTTP_1_1
				/// </java-name>
				[Dot42.DexImport("HTTP_1_1", "Lorg/apache/http/HttpVersion;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpVersion HTTP_1_1;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public HttpVersion(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forVersion
				/// </java-name>
				[Dot42.DexImport("forVersion", "(II)Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion ForVersion(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpVersion() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/ConnectionReuseStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ConnectionReuseStrategy", AccessFlags = 1537)]
		public partial interface IConnectionReuseStrategy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// keepAlive
				/// </java-name>
				[Dot42.DexImport("keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool KeepAlive(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/FormattedHeader
		/// </java-name>
		[Dot42.DexImport("org/apache/http/FormattedHeader", AccessFlags = 1537)]
		public partial interface IFormattedHeader : global::Org.Apache.Http.IHeader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getBuffer
				/// </java-name>
				global::Org.Apache.Http.Util.CharArrayBuffer Buffer
				{
						[Dot42.DexImport("getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getValuePos
				/// </java-name>
				int ValuePos
				{
						[Dot42.DexImport("getValuePos", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/Header
		/// </java-name>
		[Dot42.DexImport("org/apache/http/Header", AccessFlags = 1537)]
		public partial interface IHeader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getElements
				/// </java-name>
				global::Org.Apache.Http.IHeaderElement[] Elements
				{
						[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HeaderElement
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HeaderElement", AccessFlags = 1537)]
		public partial interface IHeaderElement
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParameterByName
				/// </java-name>
				[Dot42.DexImport("getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair GetParameterByName(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(I)Lorg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair GetParameter(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				global::Org.Apache.Http.INameValuePair[] Parameters
				{
						[Dot42.DexImport("getParameters", "()[Lorg/apache/http/NameValuePair;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getParameterCount
				/// </java-name>
				int ParameterCount
				{
						[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HeaderElementIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HeaderElementIterator", AccessFlags = 1537)]
		public partial interface IHeaderElementIterator : global::Java.Util.IIterator<object>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Lorg/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement NextElement() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasNext
				/// </java-name>
				bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HeaderIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HeaderIterator", AccessFlags = 1537)]
		public partial interface IHeaderIterator : global::Java.Util.IIterator<object>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nextHeader
				/// </java-name>
				[Dot42.DexImport("nextHeader", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader NextHeader() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasNext
				/// </java-name>
				bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpClientConnection", AccessFlags = 1537)]
		public partial interface IHttpClientConnection : global::Org.Apache.Http.IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isResponseAvailable
				/// </java-name>
				[Dot42.DexImport("isResponseAvailable", "(I)Z", AccessFlags = 1025)]
				bool IsResponseAvailable(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1025)]
				void SendRequestHeader(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendRequestEntity
				/// </java-name>
				[Dot42.DexImport("sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1025)]
				void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// receiveResponseHeader
				/// </java-name>
				[Dot42.DexImport("receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse ReceiveResponseHeader() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// receiveResponseEntity
				/// </java-name>
				[Dot42.DexImport("receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/HttpConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpConnection", AccessFlags = 1537)]
		public partial interface IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1025)]
				void Shutdown() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isOpen
				/// </java-name>
				bool IsOpen
				{
						[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isStale
				/// </java-name>
				bool IsStale
				{
						[Dot42.DexImport("isStale", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				int SocketTimeout
				{
						[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
						[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpConnectionMetrics
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpConnectionMetrics", AccessFlags = 1537)]
		public partial interface IHttpConnectionMetrics
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getMetric
				/// </java-name>
				[Dot42.DexImport("getMetric", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetMetric(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRequestCount
				/// </java-name>
				long RequestCount
				{
						[Dot42.DexImport("getRequestCount", "()J", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getResponseCount
				/// </java-name>
				long ResponseCount
				{
						[Dot42.DexImport("getResponseCount", "()J", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSentBytesCount
				/// </java-name>
				long SentBytesCount
				{
						[Dot42.DexImport("getSentBytesCount", "()J", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getReceivedBytesCount
				/// </java-name>
				long ReceivedBytesCount
				{
						[Dot42.DexImport("getReceivedBytesCount", "()J", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpEntity", AccessFlags = 1537)]
		public partial interface IHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1025)]
				void ConsumeContent() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isChunked
				/// </java-name>
				bool IsChunked
				{
						[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				global::Org.Apache.Http.IHeader ContentType
				{
						[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				global::Org.Apache.Http.IHeader ContentEncoding
				{
						[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpEntityEnclosingRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpEntityEnclosingRequest", AccessFlags = 1537)]
		public partial interface IHttpEntityEnclosingRequest : global::Org.Apache.Http.IHttpRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// expectContinue
				/// </java-name>
				[Dot42.DexImport("expectContinue", "()Z", AccessFlags = 1025)]
				bool ExpectContinue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEntity
				/// </java-name>
				global::Org.Apache.Http.IHttpEntity Entity
				{
						[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpInetConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpInetConnection", AccessFlags = 1537)]
		public partial interface IHttpInetConnection : global::Org.Apache.Http.IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				global::Java.Net.InetAddress LocalAddress
				{
						[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				int LocalPort
				{
						[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				global::Java.Net.InetAddress RemoteAddress
				{
						[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				int RemotePort
				{
						[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpMessage
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpMessage", AccessFlags = 1537)]
		public partial interface IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// containsHeader
				/// </java-name>
				[Dot42.DexImport("containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool ContainsHeader(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFirstHeader
				/// </java-name>
				[Dot42.DexImport("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLastHeader
				/// </java-name>
				[Dot42.DexImport("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void AddHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void AddHeader(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void SetHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetHeader(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaders
				/// </java-name>
				[Dot42.DexImport("setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void RemoveHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeHeaders
				/// </java-name>
				[Dot42.DexImport("removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveHeaders(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
						[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				global::Org.Apache.Http.IHeader[] AllHeaders
				{
						[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				global::Org.Apache.Http.Params.IHttpParams Params
				{
						[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpRequest", AccessFlags = 1537)]
		public partial interface IHttpRequest : global::Org.Apache.Http.IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getRequestLine
				/// </java-name>
				global::Org.Apache.Http.IRequestLine RequestLine
				{
						[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpRequestFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpRequestFactory", AccessFlags = 1537)]
		public partial interface IHttpRequestFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequest NewHttpRequest(global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequest NewHttpRequest(string @string, string string1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/HttpRequestInterceptor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpRequestInterceptor", AccessFlags = 1537)]
		public partial interface IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1025)]
				void Process(global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/HttpResponse
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpResponse", AccessFlags = 1537)]
		public partial interface IHttpResponse : global::Org.Apache.Http.IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V", AccessFlags = 1025)]
				void SetStatusLine(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetStatusLine(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setStatusCode
				/// </java-name>
				[Dot42.DexImport("setStatusCode", "(I)V", AccessFlags = 1025)]
				void SetStatusCode(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setReasonPhrase
				/// </java-name>
				[Dot42.DexImport("setReasonPhrase", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetReasonPhrase(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStatusLine
				/// </java-name>
				global::Org.Apache.Http.IStatusLine StatusLine
				{
						[Dot42.DexImport("getStatusLine", "()Lorg/apache/http/StatusLine;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				global::Org.Apache.Http.IHttpEntity Entity
				{
						[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				global::Java.Util.Locale Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/apache/http/HttpResponseFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpResponseFactory", AccessFlags = 1537)]
		public partial interface IHttpResponseFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/ap" +
    "ache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/h" +
    "ttp/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.IStatusLine statusLine, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/HttpResponseInterceptor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpResponseInterceptor", AccessFlags = 1537)]
		public partial interface IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1025)]
				void Process(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/HttpServerConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpServerConnection", AccessFlags = 1537)]
		public partial interface IHttpServerConnection : global::Org.Apache.Http.IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// receiveRequestHeader
				/// </java-name>
				[Dot42.DexImport("receiveRequestHeader", "()Lorg/apache/http/HttpRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequest ReceiveRequestHeader() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// receiveRequestEntity
				/// </java-name>
				[Dot42.DexImport("receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1025)]
				void ReceiveRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendResponseHeader
				/// </java-name>
				[Dot42.DexImport("sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				void SendResponseHeader(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendResponseEntity
				/// </java-name>
				[Dot42.DexImport("sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				void SendResponseEntity(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/HttpStatus
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpStatus", AccessFlags = 1537)]
		public partial interface IHttpStatus
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/HttpStatus
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpStatus", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IHttpStatusConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SC_CONTINUE
				/// </java-name>
				[Dot42.DexImport("SC_CONTINUE", "I", AccessFlags = 25)]
				public const int SC_CONTINUE = 100;
				/// <java-name>
				/// SC_SWITCHING_PROTOCOLS
				/// </java-name>
				[Dot42.DexImport("SC_SWITCHING_PROTOCOLS", "I", AccessFlags = 25)]
				public const int SC_SWITCHING_PROTOCOLS = 101;
				/// <java-name>
				/// SC_PROCESSING
				/// </java-name>
				[Dot42.DexImport("SC_PROCESSING", "I", AccessFlags = 25)]
				public const int SC_PROCESSING = 102;
				/// <java-name>
				/// SC_OK
				/// </java-name>
				[Dot42.DexImport("SC_OK", "I", AccessFlags = 25)]
				public const int SC_OK = 200;
				/// <java-name>
				/// SC_CREATED
				/// </java-name>
				[Dot42.DexImport("SC_CREATED", "I", AccessFlags = 25)]
				public const int SC_CREATED = 201;
				/// <java-name>
				/// SC_ACCEPTED
				/// </java-name>
				[Dot42.DexImport("SC_ACCEPTED", "I", AccessFlags = 25)]
				public const int SC_ACCEPTED = 202;
				/// <java-name>
				/// SC_NON_AUTHORITATIVE_INFORMATION
				/// </java-name>
				[Dot42.DexImport("SC_NON_AUTHORITATIVE_INFORMATION", "I", AccessFlags = 25)]
				public const int SC_NON_AUTHORITATIVE_INFORMATION = 203;
				/// <java-name>
				/// SC_NO_CONTENT
				/// </java-name>
				[Dot42.DexImport("SC_NO_CONTENT", "I", AccessFlags = 25)]
				public const int SC_NO_CONTENT = 204;
				/// <java-name>
				/// SC_RESET_CONTENT
				/// </java-name>
				[Dot42.DexImport("SC_RESET_CONTENT", "I", AccessFlags = 25)]
				public const int SC_RESET_CONTENT = 205;
				/// <java-name>
				/// SC_PARTIAL_CONTENT
				/// </java-name>
				[Dot42.DexImport("SC_PARTIAL_CONTENT", "I", AccessFlags = 25)]
				public const int SC_PARTIAL_CONTENT = 206;
				/// <java-name>
				/// SC_MULTI_STATUS
				/// </java-name>
				[Dot42.DexImport("SC_MULTI_STATUS", "I", AccessFlags = 25)]
				public const int SC_MULTI_STATUS = 207;
				/// <java-name>
				/// SC_MULTIPLE_CHOICES
				/// </java-name>
				[Dot42.DexImport("SC_MULTIPLE_CHOICES", "I", AccessFlags = 25)]
				public const int SC_MULTIPLE_CHOICES = 300;
				/// <java-name>
				/// SC_MOVED_PERMANENTLY
				/// </java-name>
				[Dot42.DexImport("SC_MOVED_PERMANENTLY", "I", AccessFlags = 25)]
				public const int SC_MOVED_PERMANENTLY = 301;
				/// <java-name>
				/// SC_MOVED_TEMPORARILY
				/// </java-name>
				[Dot42.DexImport("SC_MOVED_TEMPORARILY", "I", AccessFlags = 25)]
				public const int SC_MOVED_TEMPORARILY = 302;
				/// <java-name>
				/// SC_SEE_OTHER
				/// </java-name>
				[Dot42.DexImport("SC_SEE_OTHER", "I", AccessFlags = 25)]
				public const int SC_SEE_OTHER = 303;
				/// <java-name>
				/// SC_NOT_MODIFIED
				/// </java-name>
				[Dot42.DexImport("SC_NOT_MODIFIED", "I", AccessFlags = 25)]
				public const int SC_NOT_MODIFIED = 304;
				/// <java-name>
				/// SC_USE_PROXY
				/// </java-name>
				[Dot42.DexImport("SC_USE_PROXY", "I", AccessFlags = 25)]
				public const int SC_USE_PROXY = 305;
				/// <java-name>
				/// SC_TEMPORARY_REDIRECT
				/// </java-name>
				[Dot42.DexImport("SC_TEMPORARY_REDIRECT", "I", AccessFlags = 25)]
				public const int SC_TEMPORARY_REDIRECT = 307;
				/// <java-name>
				/// SC_BAD_REQUEST
				/// </java-name>
				[Dot42.DexImport("SC_BAD_REQUEST", "I", AccessFlags = 25)]
				public const int SC_BAD_REQUEST = 400;
				/// <java-name>
				/// SC_UNAUTHORIZED
				/// </java-name>
				[Dot42.DexImport("SC_UNAUTHORIZED", "I", AccessFlags = 25)]
				public const int SC_UNAUTHORIZED = 401;
				/// <java-name>
				/// SC_PAYMENT_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SC_PAYMENT_REQUIRED", "I", AccessFlags = 25)]
				public const int SC_PAYMENT_REQUIRED = 402;
				/// <java-name>
				/// SC_FORBIDDEN
				/// </java-name>
				[Dot42.DexImport("SC_FORBIDDEN", "I", AccessFlags = 25)]
				public const int SC_FORBIDDEN = 403;
				/// <java-name>
				/// SC_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("SC_NOT_FOUND", "I", AccessFlags = 25)]
				public const int SC_NOT_FOUND = 404;
				/// <java-name>
				/// SC_METHOD_NOT_ALLOWED
				/// </java-name>
				[Dot42.DexImport("SC_METHOD_NOT_ALLOWED", "I", AccessFlags = 25)]
				public const int SC_METHOD_NOT_ALLOWED = 405;
				/// <java-name>
				/// SC_NOT_ACCEPTABLE
				/// </java-name>
				[Dot42.DexImport("SC_NOT_ACCEPTABLE", "I", AccessFlags = 25)]
				public const int SC_NOT_ACCEPTABLE = 406;
				/// <java-name>
				/// SC_PROXY_AUTHENTICATION_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SC_PROXY_AUTHENTICATION_REQUIRED", "I", AccessFlags = 25)]
				public const int SC_PROXY_AUTHENTICATION_REQUIRED = 407;
				/// <java-name>
				/// SC_REQUEST_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SC_REQUEST_TIMEOUT", "I", AccessFlags = 25)]
				public const int SC_REQUEST_TIMEOUT = 408;
				/// <java-name>
				/// SC_CONFLICT
				/// </java-name>
				[Dot42.DexImport("SC_CONFLICT", "I", AccessFlags = 25)]
				public const int SC_CONFLICT = 409;
				/// <java-name>
				/// SC_GONE
				/// </java-name>
				[Dot42.DexImport("SC_GONE", "I", AccessFlags = 25)]
				public const int SC_GONE = 410;
				/// <java-name>
				/// SC_LENGTH_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SC_LENGTH_REQUIRED", "I", AccessFlags = 25)]
				public const int SC_LENGTH_REQUIRED = 411;
				/// <java-name>
				/// SC_PRECONDITION_FAILED
				/// </java-name>
				[Dot42.DexImport("SC_PRECONDITION_FAILED", "I", AccessFlags = 25)]
				public const int SC_PRECONDITION_FAILED = 412;
				/// <java-name>
				/// SC_REQUEST_TOO_LONG
				/// </java-name>
				[Dot42.DexImport("SC_REQUEST_TOO_LONG", "I", AccessFlags = 25)]
				public const int SC_REQUEST_TOO_LONG = 413;
				/// <java-name>
				/// SC_REQUEST_URI_TOO_LONG
				/// </java-name>
				[Dot42.DexImport("SC_REQUEST_URI_TOO_LONG", "I", AccessFlags = 25)]
				public const int SC_REQUEST_URI_TOO_LONG = 414;
				/// <java-name>
				/// SC_UNSUPPORTED_MEDIA_TYPE
				/// </java-name>
				[Dot42.DexImport("SC_UNSUPPORTED_MEDIA_TYPE", "I", AccessFlags = 25)]
				public const int SC_UNSUPPORTED_MEDIA_TYPE = 415;
				/// <java-name>
				/// SC_REQUESTED_RANGE_NOT_SATISFIABLE
				/// </java-name>
				[Dot42.DexImport("SC_REQUESTED_RANGE_NOT_SATISFIABLE", "I", AccessFlags = 25)]
				public const int SC_REQUESTED_RANGE_NOT_SATISFIABLE = 416;
				/// <java-name>
				/// SC_EXPECTATION_FAILED
				/// </java-name>
				[Dot42.DexImport("SC_EXPECTATION_FAILED", "I", AccessFlags = 25)]
				public const int SC_EXPECTATION_FAILED = 417;
				/// <java-name>
				/// SC_INSUFFICIENT_SPACE_ON_RESOURCE
				/// </java-name>
				[Dot42.DexImport("SC_INSUFFICIENT_SPACE_ON_RESOURCE", "I", AccessFlags = 25)]
				public const int SC_INSUFFICIENT_SPACE_ON_RESOURCE = 419;
				/// <java-name>
				/// SC_METHOD_FAILURE
				/// </java-name>
				[Dot42.DexImport("SC_METHOD_FAILURE", "I", AccessFlags = 25)]
				public const int SC_METHOD_FAILURE = 420;
				/// <java-name>
				/// SC_UNPROCESSABLE_ENTITY
				/// </java-name>
				[Dot42.DexImport("SC_UNPROCESSABLE_ENTITY", "I", AccessFlags = 25)]
				public const int SC_UNPROCESSABLE_ENTITY = 422;
				/// <java-name>
				/// SC_LOCKED
				/// </java-name>
				[Dot42.DexImport("SC_LOCKED", "I", AccessFlags = 25)]
				public const int SC_LOCKED = 423;
				/// <java-name>
				/// SC_FAILED_DEPENDENCY
				/// </java-name>
				[Dot42.DexImport("SC_FAILED_DEPENDENCY", "I", AccessFlags = 25)]
				public const int SC_FAILED_DEPENDENCY = 424;
				/// <java-name>
				/// SC_INTERNAL_SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("SC_INTERNAL_SERVER_ERROR", "I", AccessFlags = 25)]
				public const int SC_INTERNAL_SERVER_ERROR = 500;
				/// <java-name>
				/// SC_NOT_IMPLEMENTED
				/// </java-name>
				[Dot42.DexImport("SC_NOT_IMPLEMENTED", "I", AccessFlags = 25)]
				public const int SC_NOT_IMPLEMENTED = 501;
				/// <java-name>
				/// SC_BAD_GATEWAY
				/// </java-name>
				[Dot42.DexImport("SC_BAD_GATEWAY", "I", AccessFlags = 25)]
				public const int SC_BAD_GATEWAY = 502;
				/// <java-name>
				/// SC_SERVICE_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("SC_SERVICE_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int SC_SERVICE_UNAVAILABLE = 503;
				/// <java-name>
				/// SC_GATEWAY_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SC_GATEWAY_TIMEOUT", "I", AccessFlags = 25)]
				public const int SC_GATEWAY_TIMEOUT = 504;
				/// <java-name>
				/// SC_HTTP_VERSION_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("SC_HTTP_VERSION_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int SC_HTTP_VERSION_NOT_SUPPORTED = 505;
				/// <java-name>
				/// SC_INSUFFICIENT_STORAGE
				/// </java-name>
				[Dot42.DexImport("SC_INSUFFICIENT_STORAGE", "I", AccessFlags = 25)]
				public const int SC_INSUFFICIENT_STORAGE = 507;
		}

		/// <java-name>
		/// org/apache/http/NameValuePair
		/// </java-name>
		[Dot42.DexImport("org/apache/http/NameValuePair", AccessFlags = 1537)]
		public partial interface INameValuePair
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/ReasonPhraseCatalog
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ReasonPhraseCatalog", AccessFlags = 1537)]
		public partial interface IReasonPhraseCatalog
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "(ILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetReason(int int32, global::Java.Util.Locale locale) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/RequestLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/RequestLine", AccessFlags = 1537)]
		public partial interface IRequestLine
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getMethod
				/// </java-name>
				string Method
				{
						[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
						[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				string Uri
				{
						[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/StatusLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/StatusLine", AccessFlags = 1537)]
		public partial interface IStatusLine
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
						[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getStatusCode
				/// </java-name>
				int StatusCode
				{
						[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getReasonPhrase
				/// </java-name>
				string ReasonPhrase
				{
						[Dot42.DexImport("getReasonPhrase", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/TokenIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/TokenIterator", AccessFlags = 1537)]
		public partial interface ITokenIterator : global::Java.Util.IIterator<object>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()Ljava/lang/String;", AccessFlags = 1025)]
				string NextToken() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasNext
				/// </java-name>
				bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/MalformedChunkCodingException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/MalformedChunkCodingException", AccessFlags = 33)]
		public partial class MalformedChunkCodingException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedChunkCodingException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedChunkCodingException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/MethodNotSupportedException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/MethodNotSupportedException", AccessFlags = 33)]
		public partial class MethodNotSupportedException : global::Org.Apache.Http.HttpException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MethodNotSupportedException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public MethodNotSupportedException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MethodNotSupportedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/NoHttpResponseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/NoHttpResponseException", AccessFlags = 33)]
		public partial class NoHttpResponseException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoHttpResponseException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NoHttpResponseException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/ParseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ParseException", AccessFlags = 33)]
		public partial class ParseException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParseException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ParseException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/ProtocolException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ProtocolException", AccessFlags = 33)]
		public partial class ProtocolException : global::Org.Apache.Http.HttpException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProtocolException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ProtocolException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ProtocolException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/ProtocolVersion
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ProtocolVersion", AccessFlags = 33)]
		public partial class ProtocolVersion : global::Java.IO.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// protocol
				/// </java-name>
				[Dot42.DexImport("protocol", "Ljava/lang/String;", AccessFlags = 20)]
				protected internal readonly string @protocol;
				/// <java-name>
				/// major
				/// </java-name>
				[Dot42.DexImport("major", "I", AccessFlags = 20)]
				protected internal readonly int @major;
				/// <java-name>
				/// minor
				/// </java-name>
				[Dot42.DexImport("minor", "I", AccessFlags = 20)]
				protected internal readonly int @minor;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public ProtocolVersion(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forVersion
				/// </java-name>
				[Dot42.DexImport("forVersion", "(II)Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion ForVersion(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isComparable
				/// </java-name>
				[Dot42.DexImport("isComparable", "(Lorg/apache/http/ProtocolVersion;)Z", AccessFlags = 1)]
				public virtual bool IsComparable(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareToVersion
				/// </java-name>
				[Dot42.DexImport("compareToVersion", "(Lorg/apache/http/ProtocolVersion;)I", AccessFlags = 1)]
				public virtual int CompareToVersion(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// greaterEquals
				/// </java-name>
				[Dot42.DexImport("greaterEquals", "(Lorg/apache/http/ProtocolVersion;)Z", AccessFlags = 17)]
				public bool GreaterEquals(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lessEquals
				/// </java-name>
				[Dot42.DexImport("lessEquals", "(Lorg/apache/http/ProtocolVersion;)Z", AccessFlags = 17)]
				public bool LessEquals(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProtocolVersion() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				public string Protocol
				{
						[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getMajor
				/// </java-name>
				public int Major
				{
						[Dot42.DexImport("getMajor", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMinor
				/// </java-name>
				public int Minor
				{
						[Dot42.DexImport("getMinor", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/apache/http/UnsupportedHttpVersionException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/UnsupportedHttpVersionException", AccessFlags = 33)]
		public partial class UnsupportedHttpVersionException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedHttpVersionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedHttpVersionException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

}

