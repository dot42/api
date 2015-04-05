#pragma warning disable 1717
namespace Org.Apache.Http.Conn
{
		/// <java-name>
		/// org/apache/http/conn/BasicEofSensorWatcher
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/BasicEofSensorWatcher", AccessFlags = 33)]
		public partial class BasicEofSensorWatcher : global::Org.Apache.Http.Conn.IEofSensorWatcher
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IManagedClientConnection ManagedConn;
				/// <java-name>
				/// attemptReuse
				/// </java-name>
				[Dot42.DexImport("attemptReuse", "Z", AccessFlags = 4)]
				protected internal bool AttemptReuse;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ManagedClientConnection;Z)V", AccessFlags = 1)]
				public BasicEofSensorWatcher(global::Org.Apache.Http.Conn.IManagedClientConnection managedClientConnection, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// eofDetected
				/// </java-name>
				[Dot42.DexImport("eofDetected", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool EofDetected(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// streamClosed
				/// </java-name>
				[Dot42.DexImport("streamClosed", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamClosed(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// streamAbort
				/// </java-name>
				[Dot42.DexImport("streamAbort", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamAbort(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicEofSensorWatcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/BasicManagedEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/BasicManagedEntity", AccessFlags = 33)]
		public partial class BasicManagedEntity : global::Org.Apache.Http.Entity.HttpEntityWrapper, global::Org.Apache.Http.Conn.IConnectionReleaseTrigger, global::Org.Apache.Http.Conn.IEofSensorWatcher
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IManagedClientConnection ManagedConn;
				/// <java-name>
				/// attemptReuse
				/// </java-name>
				[Dot42.DexImport("attemptReuse", "Z", AccessFlags = 20)]
				protected internal readonly bool AttemptReuse;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntity;Lorg/apache/http/conn/ManagedClientConnection;Z)V", AccessFlags = 1)]
				public BasicManagedEntity(global::Org.Apache.Http.IHttpEntity httpEntity, global::Org.Apache.Http.Conn.IManagedClientConnection managedClientConnection, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// eofDetected
				/// </java-name>
				[Dot42.DexImport("eofDetected", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool EofDetected(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// streamClosed
				/// </java-name>
				[Dot42.DexImport("streamClosed", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamClosed(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// streamAbort
				/// </java-name>
				[Dot42.DexImport("streamAbort", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamAbort(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// releaseManagedConnection
				/// </java-name>
				[Dot42.DexImport("releaseManagedConnection", "()V", AccessFlags = 4)]
				protected internal virtual void ReleaseManagedConnection() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicManagedEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.Io.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.InputStream); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/ConnectionPoolTimeoutException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectionPoolTimeoutException", AccessFlags = 33)]
		public partial class ConnectionPoolTimeoutException : global::Org.Apache.Http.Conn.ConnectTimeoutException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectionPoolTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectionPoolTimeoutException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/ConnectTimeoutException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectTimeoutException", AccessFlags = 33)]
		public partial class ConnectTimeoutException : global::Java.Io.InterruptedIOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectTimeoutException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/conn/EofSensorInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/EofSensorInputStream", AccessFlags = 33)]
		public partial class EofSensorInputStream : global::Java.Io.InputStream, global::Org.Apache.Http.Conn.IConnectionReleaseTrigger
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// wrappedStream
				/// </java-name>
				[Dot42.DexImport("wrappedStream", "Ljava/io/InputStream;", AccessFlags = 4)]
				protected internal global::Java.Io.InputStream WrappedStream;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Lorg/apache/http/conn/EofSensorWatcher;)V", AccessFlags = 1)]
				public EofSensorInputStream(global::Java.Io.InputStream inputStream, global::Org.Apache.Http.Conn.IEofSensorWatcher eofSensorWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkEOF
				/// </java-name>
				[Dot42.DexImport("checkEOF", "(I)V", AccessFlags = 4)]
				protected internal virtual void CheckEOF(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkClose
				/// </java-name>
				[Dot42.DexImport("checkClose", "()V", AccessFlags = 4)]
				protected internal virtual void CheckClose() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAbort
				/// </java-name>
				[Dot42.DexImport("checkAbort", "()V", AccessFlags = 4)]
				protected internal virtual void CheckAbort() /* MethodBuilder.Create */ 
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
				internal EofSensorInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isReadAllowed
				/// </java-name>
				protected internal virtual bool IsReadAllowed
				{
						[Dot42.DexImport("isReadAllowed", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/HttpHostConnectException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/HttpHostConnectException", AccessFlags = 33)]
		public partial class HttpHostConnectException : global::Java.Net.ConnectException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/ConnectException;)V", AccessFlags = 1)]
				public HttpHostConnectException(global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.ConnectException connectException) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpHostConnectException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public virtual global::Org.Apache.Http.HttpHost Host
				{
						[Dot42.DexImport("getHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.HttpHost); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/ClientConnectionManager
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionManager", AccessFlags = 1537)]
		public partial interface IClientConnectionManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// requestConnection
				/// </java-name>
				[Dot42.DexImport("requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn" +
    "/ClientConnectionRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IClientConnectionRequest RequestConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V" +
    "", AccessFlags = 1025)]
				void ReleaseConnection(global::Org.Apache.Http.Conn.IManagedClientConnection managedClientConnection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1025)]
				void CloseIdleConnections(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1025)]
				void CloseExpiredConnections() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1025)]
				void Shutdown() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemeRegistry
				/// </java-name>
				global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry
				{
						[Dot42.DexImport("getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/conn/ClientConnectionManagerFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionManagerFactory", AccessFlags = 1537)]
		public partial interface IClientConnectionManagerFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)" +
    "Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IClientConnectionManager NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/ClientConnectionOperator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionOperator", AccessFlags = 1537)]
		public partial interface IClientConnectionOperator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createConnection
				/// </java-name>
				[Dot42.DexImport("createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IOperatedClientConnection CreateConnection() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/n" +
    "et/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/Htt" +
    "pParams;)V", AccessFlags = 1025)]
				void OpenConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection, global::Org.Apache.Http.HttpHost httpHost, global::Java.Net.InetAddress inetAddress, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateSecureConnection
				/// </java-name>
				[Dot42.DexImport("updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/ap" +
    "ache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void UpdateSecureConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection, global::Org.Apache.Http.HttpHost httpHost, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/ClientConnectionRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionRequest", AccessFlags = 1537)]
		public partial interface IClientConnectionRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IManagedClientConnection GetConnection(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// abortRequest
				/// </java-name>
				[Dot42.DexImport("abortRequest", "()V", AccessFlags = 1025)]
				void AbortRequest() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/ConnectionKeepAliveStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectionKeepAliveStrategy", AccessFlags = 1537)]
		public partial interface IConnectionKeepAliveStrategy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getKeepAliveDuration
				/// </java-name>
				[Dot42.DexImport("getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J", AccessFlags = 1025)]
				long GetKeepAliveDuration(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/ConnectionReleaseTrigger
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectionReleaseTrigger", AccessFlags = 1537)]
		public partial interface IConnectionReleaseTrigger
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 1025)]
				void ReleaseConnection() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// abortConnection
				/// </java-name>
				[Dot42.DexImport("abortConnection", "()V", AccessFlags = 1025)]
				void AbortConnection() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/EofSensorWatcher
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/EofSensorWatcher", AccessFlags = 1537)]
		public partial interface IEofSensorWatcher
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// eofDetected
				/// </java-name>
				[Dot42.DexImport("eofDetected", "(Ljava/io/InputStream;)Z", AccessFlags = 1025)]
				bool EofDetected(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// streamClosed
				/// </java-name>
				[Dot42.DexImport("streamClosed", "(Ljava/io/InputStream;)Z", AccessFlags = 1025)]
				bool StreamClosed(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// streamAbort
				/// </java-name>
				[Dot42.DexImport("streamAbort", "(Ljava/io/InputStream;)Z", AccessFlags = 1025)]
				bool StreamAbort(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/ManagedClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", AccessFlags = 1537)]
		public partial interface IManagedClientConnection : global::Org.Apache.Http.IHttpClientConnection, global::Org.Apache.Http.IHttpInetConnection, global::Org.Apache.Http.Conn.IConnectionReleaseTrigger
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void TunnelTarget(bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void TunnelProxy(global::Org.Apache.Http.HttpHost httpHost, bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext httpContext, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// markReusable
				/// </java-name>
				[Dot42.DexImport("markReusable", "()V", AccessFlags = 1025)]
				void MarkReusable() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unmarkReusable
				/// </java-name>
				[Dot42.DexImport("unmarkReusable", "()V", AccessFlags = 1025)]
				void UnmarkReusable() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIdleDuration
				/// </java-name>
				[Dot42.DexImport("setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1025)]
				void SetIdleDuration(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSecure
				/// </java-name>
				bool IsSecure
				{
						[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRoute
				/// </java-name>
				global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
						[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSSLSession
				/// </java-name>
				global::Javax.Net.Ssl.ISSLSession SSLSession
				{
						[Dot42.DexImport("getSSLSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isMarkedReusable
				/// </java-name>
				bool IsMarkedReusable
				{
						[Dot42.DexImport("isMarkedReusable", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getState
				/// </java-name>
				object State
				{
						[Dot42.DexImport("getState", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setState", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/apache/http/conn/OperatedClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/OperatedClientConnection", AccessFlags = 1537)]
		public partial interface IOperatedClientConnection : global::Org.Apache.Http.IHttpClientConnection, global::Org.Apache.Http.IHttpInetConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// opening
				/// </java-name>
				[Dot42.DexImport("opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V", AccessFlags = 1025)]
				void Opening(global::Java.Net.Socket socket, global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openCompleted
				/// </java-name>
				[Dot42.DexImport("openCompleted", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void OpenCompleted(bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)" +
    "V", AccessFlags = 1025)]
				void Update(global::Java.Net.Socket socket, global::Org.Apache.Http.HttpHost httpHost, bool boolean, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTargetHost
				/// </java-name>
				global::Org.Apache.Http.HttpHost TargetHost
				{
						[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				bool IsSecure
				{
						[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				global::Java.Net.Socket Socket
				{
						[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/conn/MultihomePlainSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/MultihomePlainSocketFactory", AccessFlags = 49)]
		public sealed partial class MultihomePlainSocketFactory : global::Org.Apache.Http.Conn.Scheme.ISocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MultihomePlainSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1)]
				public global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// connectSocket
				/// </java-name>
				[Dot42.DexImport("connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/para" +
    "ms/HttpParams;)Ljava/net/Socket;", AccessFlags = 1)]
				public global::Java.Net.Socket ConnectSocket(global::Java.Net.Socket socket, string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "(Ljava/net/Socket;)Z", AccessFlags = 17)]
				public bool IsSecure(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// getSocketFactory
				/// </java-name>
				public static global::Org.Apache.Http.Conn.MultihomePlainSocketFactory SocketFactory
				{
						[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/MultihomePlainSocketFactory;", AccessFlags = 9)]
						get{ return default(global::Org.Apache.Http.Conn.MultihomePlainSocketFactory); }
				}

		}

}

