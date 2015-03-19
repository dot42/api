#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Conn
{
		/// <java-name>
		/// org/apache/http/impl/conn/DefaultResponseParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultResponseParser", AccessFlags = 33)]
		public partial class DefaultResponseParser : global::Org.Apache.Http.Impl.Io.AbstractMessageParser
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/" +
    "apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Message.ILineParser lineParser, global::Org.Apache.Http.IHttpResponseFactory httpResponseFactory, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultResponseParser() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/AbstractPooledConnAdapter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/AbstractPooledConnAdapter", AccessFlags = 1057)]
		public abstract partial class AbstractPooledConnAdapter : global::Org.Apache.Http.Impl.Conn.AbstractClientConnAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// poolEntry
				/// </java-name>
				[Dot42.DexImport("poolEntry", "Lorg/apache/http/impl/conn/AbstractPoolEntry;", AccessFlags = 68)]
				protected internal global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry PoolEntry;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/impl/conn/Abstrac" +
    "tPoolEntry;)V", AccessFlags = 4)]
				protected internal AbstractPooledConnAdapter(global::Org.Apache.Http.Conn.IClientConnectionManager clientConnectionManager, global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry abstractPoolEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertAttached
				/// </java-name>
				[Dot42.DexImport("assertAttached", "()V", AccessFlags = 20)]
				protected internal void AssertAttached() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// detach
				/// </java-name>
				[Dot42.DexImport("detach", "()V", AccessFlags = 4)]
				protected internal override void Detach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void TunnelTarget(bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void TunnelProxy(global::Org.Apache.Http.HttpHost httpHost, bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
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
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetState() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public override void SetState(object @object) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractPooledConnAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRoute
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
						get{ return GetRoute(); }
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public object State
				{
				[Dot42.DexImport("getState", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetState(); }
				[Dot42.DexImport("setState", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ SetState(value); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/LoggingSessionInputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/LoggingSessionInputBuffer", AccessFlags = 33)]
		public partial class LoggingSessionInputBuffer : global::Org.Apache.Http.Io.ISessionInputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/impl/conn/Wire;)V", AccessFlags = 1)]
				public LoggingSessionInputBuffer(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Impl.Conn.Wire wire) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDataAvailable
				/// </java-name>
				[Dot42.DexImport("isDataAvailable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsDataAvailable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public virtual int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", AccessFlags = 1)]
				public virtual int ReadLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpTransportMetrics);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LoggingSessionInputBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public global::Org.Apache.Http.Io.IHttpTransportMetrics Metrics
				{
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
						get{ return GetMetrics(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/DefaultClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultClientConnection", AccessFlags = 33)]
		public partial class DefaultClientConnection : global::Org.Apache.Http.Impl.SocketHttpClientConnection, global::Org.Apache.Http.Conn.IOperatedClientConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultClientConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 17)]
				public bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 17)]
				public new global::Java.Net.Socket GetSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// opening
				/// </java-name>
				[Dot42.DexImport("opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void Opening(global::Java.Net.Socket socket, global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openCompleted
				/// </java-name>
				[Dot42.DexImport("openCompleted", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void OpenCompleted(bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
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
				/// createSessionInputBuffer
				/// </java-name>
				[Dot42.DexImport("createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nInputBuffer;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Io.ISessionInputBuffer CreateSessionInputBuffer(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionInputBuffer);
				}

				/// <java-name>
				/// createSessionOutputBuffer
				/// </java-name>
				[Dot42.DexImport("createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nOutputBuffer;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Io.ISessionOutputBuffer CreateSessionOutputBuffer(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionOutputBuffer);
				}

				/// <java-name>
				/// createResponseParser
				/// </java-name>
				[Dot42.DexImport("createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg" +
    "/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Io.IHttpMessageParser CreateResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.IHttpResponseFactory httpResponseFactory, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageParser);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)" +
    "V", AccessFlags = 1)]
				public virtual void Update(global::Java.Net.Socket socket, global::Org.Apache.Http.HttpHost httpHost, bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// receiveResponseHeader
				/// </java-name>
				[Dot42.DexImport("receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHttpResponse ReceiveResponseHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public override void SendRequestHeader(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "isResponseAvailable", "(I)Z", AccessFlags = 1025)]
				public override bool IsResponseAvailable(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1025)]
				public override void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				public override void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse httpResponse) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "flush", "()V", AccessFlags = 1025)]
				public override void Flush() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
				public override global::Java.Net.InetAddress GetLocalAddress() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getLocalPort", "()I", AccessFlags = 1025)]
				public override int GetLocalPort() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
				public override global::Java.Net.InetAddress GetRemoteAddress() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getRemotePort", "()I", AccessFlags = 1025)]
				public override int GetRemotePort() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "isOpen", "()Z", AccessFlags = 1025)]
				public override bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "isStale", "()Z", AccessFlags = 1025)]
				public override bool IsStale() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
				public override void SetSocketTimeout(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
				public override int GetSocketTimeout() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHttpConnectionMetrics GetMetrics() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHttpConnectionMetrics);
				}

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost TargetHost
				{
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetTargetHost(); }
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				public global::Java.Net.Socket Socket
				{
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 17)]
						get{ return GetSocket(); }
				}

				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
						get{ return GetLocalAddress(); }
				}

				public int LocalPort
				{
				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getLocalPort", "()I", AccessFlags = 1025)]
						get{ return GetLocalPort(); }
				}

				public global::Java.Net.InetAddress RemoteAddress
				{
				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
						get{ return GetRemoteAddress(); }
				}

				public int RemotePort
				{
				[Dot42.DexImport("org/apache/http/HttpInetConnection", "getRemotePort", "()I", AccessFlags = 1025)]
						get{ return GetRemotePort(); }
				}

				public int SocketTimeout
				{
				[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
						get{ return GetSocketTimeout(); }
				[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
						set{ SetSocketTimeout(value); }
				}

				public global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
				[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
						get{ return GetMetrics(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/IdleConnectionHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/IdleConnectionHandler", AccessFlags = 33)]
		public partial class IdleConnectionHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IdleConnectionHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Lorg/apache/http/HttpConnection;JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void Add(global::Org.Apache.Http.IHttpConnection httpConnection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Lorg/apache/http/HttpConnection;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::Org.Apache.Http.IHttpConnection httpConnection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "()V", AccessFlags = 1)]
				public virtual void RemoveAll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(J)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1)]
				public virtual void CloseExpiredConnections() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/SingleClientConnManager
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/SingleClientConnManager", AccessFlags = 33)]
		public partial class SingleClientConnManager : global::Org.Apache.Http.Conn.IClientConnectionManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MISUSE_MESSAGE
				/// </java-name>
				[Dot42.DexImport("MISUSE_MESSAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MISUSE_MESSAGE = "Invalid use of SingleClientConnManager: connection still allocated.\nMake sure to " +
    "release the connection before allocating another one.";
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <java-name>
				/// connOperator
				/// </java-name>
				[Dot42.DexImport("connOperator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IClientConnectionOperator ConnOperator;
				/// <java-name>
				/// uniquePoolEntry
				/// </java-name>
				[Dot42.DexImport("uniquePoolEntry", "Lorg/apache/http/impl/conn/SingleClientConnManager$PoolEntry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Impl.Conn.SingleClientConnManager.PoolEntry UniquePoolEntry;
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/impl/conn/SingleClientConnManager$ConnAdapter;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Impl.Conn.SingleClientConnManager.ConnAdapter ManagedConn;
				/// <java-name>
				/// lastReleaseTime
				/// </java-name>
				[Dot42.DexImport("lastReleaseTime", "J", AccessFlags = 4)]
				protected internal long LastReleaseTime;
				/// <java-name>
				/// connectionExpiresTime
				/// </java-name>
				[Dot42.DexImport("connectionExpiresTime", "J", AccessFlags = 4)]
				protected internal long ConnectionExpiresTime;
				/// <java-name>
				/// alwaysShutDown
				/// </java-name>
				[Dot42.DexImport("alwaysShutDown", "Z", AccessFlags = 4)]
				protected internal bool AlwaysShutDown;
				/// <java-name>
				/// isShutDown
				/// </java-name>
				[Dot42.DexImport("isShutDown", "Z", AccessFlags = 68)]
				protected internal bool IsShutDown;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)" +
    "V", AccessFlags = 1)]
				public SingleClientConnManager(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SingleClientConnManager() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Scheme.SchemeRegistry GetSchemeRegistry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry);
				}

				/// <java-name>
				/// createConnectionOperator
				/// </java-name>
				[Dot42.DexImport("createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnect" +
    "ionOperator;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.IClientConnectionOperator CreateConnectionOperator(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionOperator);
				}

				/// <java-name>
				/// assertStillUp
				/// </java-name>
				[Dot42.DexImport("assertStillUp", "()V", AccessFlags = 20)]
				protected internal void AssertStillUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestConnection
				/// </java-name>
				[Dot42.DexImport("requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn" +
    "/ClientConnectionRequest;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.IClientConnectionRequest RequestConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionRequest);
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn" +
    "/ManagedClientConnection;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.IManagedClientConnection GetConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IManagedClientConnection);
				}

				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V" +
    "", AccessFlags = 1)]
				public virtual void ReleaseConnection(global::Org.Apache.Http.Conn.IManagedClientConnection managedClientConnection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1)]
				public virtual void CloseExpiredConnections() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// revokeConnection
				/// </java-name>
				[Dot42.DexImport("revokeConnection", "()V", AccessFlags = 4)]
				protected internal virtual void RevokeConnection() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SingleClientConnManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// org/apache/http/impl/conn/SingleClientConnManager$ConnAdapter
				/// </java-name>
				[Dot42.DexImport("org/apache/http/impl/conn/SingleClientConnManager$ConnAdapter", AccessFlags = 4)]
				public partial class ConnAdapter : global::Org.Apache.Http.Impl.Conn.AbstractPooledConnAdapter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Lorg/apache/http/impl/conn/SingleClientConnManager;", AccessFlags = 4112)]
						internal readonly global::Org.Apache.Http.Impl.Conn.SingleClientConnManager This_0;
						[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;Lorg/apache/http/impl/conn/Si" +
    "ngleClientConnManager$PoolEntry;Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 4)]
						protected internal ConnAdapter(global::Org.Apache.Http.Impl.Conn.SingleClientConnManager singleClientConnManager, global::Org.Apache.Http.Impl.Conn.SingleClientConnManager.PoolEntry poolEntry, global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ConnAdapter() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// org/apache/http/impl/conn/SingleClientConnManager$PoolEntry
				/// </java-name>
				[Dot42.DexImport("org/apache/http/impl/conn/SingleClientConnManager$PoolEntry", AccessFlags = 4)]
				public partial class PoolEntry : global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Lorg/apache/http/impl/conn/SingleClientConnManager;", AccessFlags = 4112)]
						internal readonly global::Org.Apache.Http.Impl.Conn.SingleClientConnManager This_0;
						[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;)V", AccessFlags = 4)]
						protected internal PoolEntry(global::Org.Apache.Http.Impl.Conn.SingleClientConnManager singleClientConnManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 4)]
						protected internal virtual void Close() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// shutdown
						/// </java-name>
						[Dot42.DexImport("shutdown", "()V", AccessFlags = 4)]
						protected internal virtual void Shutdown() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal PoolEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/DefaultHttpRoutePlanner
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultHttpRoutePlanner", AccessFlags = 33)]
		public partial class DefaultHttpRoutePlanner : global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V", AccessFlags = 1)]
				public DefaultHttpRoutePlanner(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultHttpRoutePlanner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/AbstractClientConnAdapter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/AbstractClientConnAdapter", AccessFlags = 1057)]
		public abstract partial class AbstractClientConnAdapter : global::Org.Apache.Http.Conn.IManagedClientConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/conn/OperatedClie" +
    "ntConnection;)V", AccessFlags = 4)]
				protected internal AbstractClientConnAdapter(global::Org.Apache.Http.Conn.IClientConnectionManager clientConnectionManager, global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// detach
				/// </java-name>
				[Dot42.DexImport("detach", "()V", AccessFlags = 4)]
				protected internal virtual void Detach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWrappedConnection
				/// </java-name>
				[Dot42.DexImport("getWrappedConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.IOperatedClientConnection GetWrappedConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IOperatedClientConnection);
				}

				/// <java-name>
				/// getManager
				/// </java-name>
				[Dot42.DexImport("getManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.IClientConnectionManager GetManager() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionManager);
				}

				/// <java-name>
				/// assertNotAborted
				/// </java-name>
				[Dot42.DexImport("assertNotAborted", "()V", AccessFlags = 20)]
				protected internal void AssertNotAborted() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertValid
				/// </java-name>
				[Dot42.DexImport("assertValid", "(Lorg/apache/http/conn/OperatedClientConnection;)V", AccessFlags = 20)]
				protected internal void AssertValid(global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1)]
				public virtual bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStale
				/// </java-name>
				[Dot42.DexImport("isStale", "()Z", AccessFlags = 1)]
				public virtual bool IsStale() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSocketTimeout
				/// </java-name>
				[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetSocketTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1)]
				public virtual int GetSocketTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpConnectionMetrics GetMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpConnectionMetrics);
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
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
				/// receiveResponseEntity
				/// </java-name>
				[Dot42.DexImport("receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse httpResponse) /* MethodBuilder.Create */ 
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
				/// sendRequestEntity
				/// </java-name>
				[Dot42.DexImport("sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest httpEntityEnclosingRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestHeader(global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
				public virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetRemoteAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
				public virtual int GetRemotePort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1)]
				public virtual bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSSLSession
				/// </java-name>
				[Dot42.DexImport("getSSLSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.ISSLSession GetSSLSession() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSession);
				}

				/// <java-name>
				/// markReusable
				/// </java-name>
				[Dot42.DexImport("markReusable", "()V", AccessFlags = 1)]
				public virtual void MarkReusable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unmarkReusable
				/// </java-name>
				[Dot42.DexImport("unmarkReusable", "()V", AccessFlags = 1)]
				public virtual void UnmarkReusable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isMarkedReusable
				/// </java-name>
				[Dot42.DexImport("isMarkedReusable", "()Z", AccessFlags = 1)]
				public virtual bool IsMarkedReusable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setIdleDuration
				/// </java-name>
				[Dot42.DexImport("setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void SetIdleDuration(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 1)]
				public virtual void ReleaseConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abortConnection
				/// </java-name>
				[Dot42.DexImport("abortConnection", "()V", AccessFlags = 1)]
				public virtual void AbortConnection() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractClientConnAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void TunnelTarget(bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void TunnelProxy(global::Org.Apache.Http.HttpHost httpHost, bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "setState", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				public virtual void SetState(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "getState", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetState() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
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
				/// getWrappedConnection
				/// </java-name>
				protected internal global::Org.Apache.Http.Conn.IOperatedClientConnection WrappedConnection
				{
				[Dot42.DexImport("getWrappedConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 4)]
						get{ return GetWrappedConnection(); }
				}

				/// <java-name>
				/// getManager
				/// </java-name>
				protected internal global::Org.Apache.Http.Conn.IClientConnectionManager Manager
				{
				[Dot42.DexImport("getManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 4)]
						get{ return GetManager(); }
				}

				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				public int SocketTimeout
				{
				[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1)]
						get{ return GetSocketTimeout(); }
				[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
						set{ SetSocketTimeout(value); }
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1)]
						get{ return GetMetrics(); }
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetLocalAddress(); }
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return GetLocalPort(); }
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				public global::Java.Net.InetAddress RemoteAddress
				{
				[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetRemoteAddress(); }
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				public int RemotePort
				{
				[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
						get{ return GetRemotePort(); }
				}

				/// <java-name>
				/// getSSLSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession SSLSession
				{
				[Dot42.DexImport("getSSLSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
						get{ return GetSSLSession(); }
				}

				public global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1025)]
						get{ return GetRoute(); }
				}

				public object State
				{
				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "getState", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get{ return GetState(); }
				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "setState", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
						set{ SetState(value); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/Wire
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/Wire", AccessFlags = 33)]
		public partial class Wire
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/commons/logging/Log;)V", AccessFlags = 1)]
				public Wire(global::Org.Apache.Commons.Logging.ILog log) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enabled
				/// </java-name>
				[Dot42.DexImport("enabled", "()Z", AccessFlags = 1)]
				public virtual bool Enabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void Output(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void Input(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([BII)V", AccessFlags = 1)]
				public virtual void Output(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Output(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([BII)V", AccessFlags = 1)]
				public virtual void Input(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Input(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([B)V", AccessFlags = 1)]
				public virtual void Output(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Output(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([B)V", AccessFlags = 1)]
				public virtual void Input(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Input(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "(I)V", AccessFlags = 1)]
				public virtual void Output(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "(I)V", AccessFlags = 1)]
				public virtual void Input(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Output(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Input(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Wire() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/LoggingSessionOutputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/LoggingSessionOutputBuffer", AccessFlags = 33)]
		public partial class LoggingSessionOutputBuffer : global::Org.Apache.Http.Io.ISessionOutputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/impl/conn/Wire;)V", AccessFlags = 1)]
				public LoggingSessionOutputBuffer(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Impl.Conn.Wire wire) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] @byte) /* MethodBuilder.Create */ 
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
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void WriteLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteLine(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpTransportMetrics);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LoggingSessionOutputBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public global::Org.Apache.Http.Io.IHttpTransportMetrics Metrics
				{
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
						get{ return GetMetrics(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/AbstractPoolEntry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/AbstractPoolEntry", AccessFlags = 1057)]
		public abstract partial class AbstractPoolEntry
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// connOperator
				/// </java-name>
				[Dot42.DexImport("connOperator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IClientConnectionOperator ConnOperator;
				/// <java-name>
				/// connection
				/// </java-name>
				[Dot42.DexImport("connection", "Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IOperatedClientConnection Connection;
				/// <java-name>
				/// route
				/// </java-name>
				[Dot42.DexImport("route", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 68)]
				protected internal global::Org.Apache.Http.Conn.Routing.HttpRoute Route;
				/// <java-name>
				/// state
				/// </java-name>
				[Dot42.DexImport("state", "Ljava/lang/Object;", AccessFlags = 68)]
				protected internal object State;
				/// <java-name>
				/// tracker
				/// </java-name>
				[Dot42.DexImport("tracker", "Lorg/apache/http/conn/routing/RouteTracker;", AccessFlags = 68)]
				protected internal global::Org.Apache.Http.Conn.Routing.RouteTracker Tracker;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/Htt" +
    "pRoute;)V", AccessFlags = 4)]
				protected internal AbstractPoolEntry(global::Org.Apache.Http.Conn.IClientConnectionOperator clientConnectionOperator, global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetState() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetState(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void TunnelTarget(bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void TunnelProxy(global::Org.Apache.Http.HttpHost httpHost, bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownEntry
				/// </java-name>
				[Dot42.DexImport("shutdownEntry", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownEntry() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractPoolEntry() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/DefaultClientConnectionOperator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultClientConnectionOperator", AccessFlags = 33)]
		public partial class DefaultClientConnectionOperator : global::Org.Apache.Http.Conn.IClientConnectionOperator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V", AccessFlags = 1)]
				public DefaultClientConnectionOperator(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createConnection
				/// </java-name>
				[Dot42.DexImport("createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.IOperatedClientConnection CreateConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IOperatedClientConnection);
				}

				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/n" +
    "et/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/Htt" +
    "pParams;)V", AccessFlags = 1)]
				public virtual void OpenConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection, global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateSecureConnection
				/// </java-name>
				[Dot42.DexImport("updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/ap" +
    "ache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void UpdateSecureConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection, global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// prepareSocket
				/// </java-name>
				[Dot42.DexImport("prepareSocket", "(Ljava/net/Socket;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/H" +
    "ttpParams;)V", AccessFlags = 4)]
				protected internal virtual void PrepareSocket(global::Java.Net.Socket socket, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultClientConnectionOperator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/ProxySelectorRoutePlanner
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/ProxySelectorRoutePlanner", AccessFlags = 33)]
		public partial class ProxySelectorRoutePlanner : global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <java-name>
				/// proxySelector
				/// </java-name>
				[Dot42.DexImport("proxySelector", "Ljava/net/ProxySelector;", AccessFlags = 4)]
				protected internal global::Java.Net.ProxySelector ProxySelector;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;Ljava/net/ProxySelector;)V", AccessFlags = 1)]
				public ProxySelectorRoutePlanner(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry, global::Java.Net.ProxySelector proxySelector) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProxySelector
				/// </java-name>
				[Dot42.DexImport("getProxySelector", "()Ljava/net/ProxySelector;", AccessFlags = 1)]
				public virtual global::Java.Net.ProxySelector GetProxySelector() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ProxySelector);
				}

				/// <java-name>
				/// setProxySelector
				/// </java-name>
				[Dot42.DexImport("setProxySelector", "(Ljava/net/ProxySelector;)V", AccessFlags = 1)]
				public virtual void SetProxySelector(global::Java.Net.ProxySelector proxySelector) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// determineProxy
				/// </java-name>
				[Dot42.DexImport("determineProxy", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpHost;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.HttpHost DetermineProxy(global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "(Ljava/net/InetSocketAddress;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetHost(global::Java.Net.InetSocketAddress inetSocketAddress) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// chooseProxy
				/// </java-name>
				[Dot42.DexImport("chooseProxy", "(Ljava/util/List;Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apac" +
    "he/http/protocol/HttpContext;)Ljava/net/Proxy;", AccessFlags = 4, Signature = "(Ljava/util/List<Ljava/net/Proxy;>;Lorg/apache/http/HttpHost;Lorg/apache/http/Htt" +
    "pRequest;Lorg/apache/http/protocol/HttpContext;)Ljava/net/Proxy;")]
				protected internal virtual global::Java.Net.Proxy ChooseProxy(global::Java.Util.IList<global::Java.Net.Proxy> list, global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Proxy);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProxySelectorRoutePlanner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

