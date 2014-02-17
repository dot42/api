// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Conn.cs
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
namespace Org.Apache.Http.Conn
{
		/// <summary>
		/// <para>A watcher for EofSensorInputStream. Each stream will notify it's watcher at most once.</para><para><para></para><para></para><title>Revision:</title><para>552264 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/EofSensorWatcher
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/EofSensorWatcher", AccessFlags = 1537)]
		public partial interface IEofSensorWatcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates that EOF is detected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// eofDetected
				/// </java-name>
				[Dot42.DexImport("eofDetected", "(Ljava/io/InputStream;)Z", AccessFlags = 1025)]
				bool EofDetected(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates that the stream is closed. This method will be called only if EOF was <b>not</b> detected before closing. Otherwise, eofDetected is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// streamClosed
				/// </java-name>
				[Dot42.DexImport("streamClosed", "(Ljava/io/InputStream;)Z", AccessFlags = 1025)]
				bool StreamClosed(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates that the stream is aborted. This method will be called only if EOF was <b>not</b> detected before aborting. Otherwise, eofDetected is called. </para><para>This method will also be invoked when an input operation causes an IOException to be thrown to make sure the input stream gets shut down.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// streamAbort
				/// </java-name>
				[Dot42.DexImport("streamAbort", "(Ljava/io/InputStream;)Z", AccessFlags = 1025)]
				bool StreamAbort(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface for opening connections. This interface encapsulates the logic to create sockets and to open or update the connection with the new socket. Implementations will most likely make use of socket factories. <br></br> The methods in this interface allow the creation of plain and layered sockets. Creating a tunnelled connection through a proxy, however, is not within the scope of the operator.</para><para><para></para><para></para><title>Revision:</title><para>645850 </para><title>Date:</title><para>2008-04-08 04:08:52 -0700 (Tue, 08 Apr 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ClientConnectionOperator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionOperator", AccessFlags = 1537)]
		public partial interface IClientConnectionOperator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new connection that can be operated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new, unopened connection for use with this operator </para>
				/// </returns>
				/// <java-name>
				/// createConnection
				/// </java-name>
				[Dot42.DexImport("createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IOperatedClientConnection CreateConnection() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Opens a connection to the given target host.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/n" +
    "et/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/Htt" +
    "pParams;)V", AccessFlags = 1025)]
				void OpenConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection conn, global::Org.Apache.Http.HttpHost target, global::Java.Net.InetAddress local, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates a connection with a layered secure connection. The typical use of this method is to update a tunnelled plain connection (HTTP) to a secure TLS/SSL connection (HTTPS).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateSecureConnection
				/// </java-name>
				[Dot42.DexImport("updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/ap" +
    "ache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void UpdateSecureConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection conn, global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface for releasing a connection. This can be implemented by various "trigger" objects which are associated with a connection, for example a stream or an entity or the connection itself. <br></br> The methods in this interface can safely be called multiple times. The first invocation releases the connection, subsequent calls are ignored.</para><para><para></para><para></para><title>Revision:</title><para>672367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ConnectionReleaseTrigger
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectionReleaseTrigger", AccessFlags = 1537)]
		public partial interface IConnectionReleaseTrigger
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Releases the connection with the option of keep-alive. This is a "graceful" release and may cause IO operations for consuming the remainder of a response entity. Use abortConnection for a hard release. The connection may be reused as specified by the duration.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 1025)]
				void ReleaseConnection() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Releases the connection without the option of keep-alive. This is a "hard" release that implies a shutdown of the connection. Use releaseConnection for a graceful release.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// abortConnection
				/// </java-name>
				[Dot42.DexImport("abortConnection", "()V", AccessFlags = 1025)]
				void AbortConnection() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A factory for creating new ClientConnectionManager instances.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				global::Org.Apache.Http.Conn.IClientConnectionManager NewInstance(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A timeout while connecting to an HTTP server or waiting for an available connection from an HttpConnectionManager.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ConnectTimeoutException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectTimeoutException", AccessFlags = 33)]
		public partial class ConnectTimeoutException : global::Java.Io.InterruptedIOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a ConnectTimeoutException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a ConnectTimeoutException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectTimeoutException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Management interface for client connections.</para><para><para>Michael Becke </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>671717 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ClientConnectionManager
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionManager", AccessFlags = 1537)]
		public partial interface IClientConnectionManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the scheme registry used by this manager.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme registry, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Scheme.SchemeRegistry GetSchemeRegistry() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new ClientConnectionRequest, from which a ManagedClientConnection can be obtained or the request can be aborted. </para>        
				/// </summary>
				/// <java-name>
				/// requestConnection
				/// </java-name>
				[Dot42.DexImport("requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn" +
    "/ClientConnectionRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IClientConnectionRequest RequestConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Releases a connection for use by others. You may optionally specify how long the connection is valid to be reused. Values &lt;= 0 are considered to be valid forever. If the connection is not marked as reusable, the connection will not be reused regardless of the valid duration.</para><para>If the connection has been released before, the call will be ignored.</para><para><para>closeExpiredConnections() </para></para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V" +
    "", AccessFlags = 1025)]
				void ReleaseConnection(global::Org.Apache.Http.Conn.IManagedClientConnection conn, long validDuration, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes idle connections in the pool. Open connections in the pool that have not been used for the timespan given by the argument will be closed. Currently allocated connections are not subject to this method. Times will be checked with milliseconds precision</para><para>All expired connections will also be closed.</para><para><para>closeExpiredConnections() </para></para>        
				/// </summary>
				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1025)]
				void CloseIdleConnections(long idletime, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes all expired connections in the pool. Open connections in the pool that have not been used for the timespan defined when the connection was released will be closed. Currently allocated connections are not subject to this method. Times will be checked with milliseconds precision. </para>        
				/// </summary>
				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1025)]
				void CloseExpiredConnections() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Shuts down this connection manager and releases allocated resources. This includes closing all connections, whether they are currently used or not. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1025)]
				void Shutdown() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A client-side connection with advanced connection logic. Instances are typically obtained from a connection manager.</para><para><para></para><para></para><title>Revision:</title><para>672969 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ManagedClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", AccessFlags = 1537)]
		public partial interface IManagedClientConnection : global::Org.Apache.Http.IHttpClientConnection, global::Org.Apache.Http.IHttpInetConnection, global::Org.Apache.Http.Conn.IConnectionReleaseTrigger
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates whether this connection is secure. The return value is well-defined only while the connection is open. It may change even while the connection is open.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this connection is secure, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
				bool IsSecure() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the current route of this connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route established so far, or <code>null</code> if not connected </para>
				/// </returns>
				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the SSL session of the underlying connection, if any. If this connection is open, and the underlying socket is an SSLSocket, the SSL session of that socket is obtained. This is a potentially blocking operation. <br></br> <b>Note:</b> Whether the underlying socket is an SSL socket can not necessarily be determined via isSecure. Plain sockets may be considered secure, for example if they are connected to a known host in the same network segment. On the other hand, SSL sockets may be considered insecure, for example depending on the chosen cipher suite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the underlying SSL session if available, <code>null</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// getSSLSession
				/// </java-name>
				[Dot42.DexImport("getSSLSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				global::Javax.Net.Ssl.ISSLSession GetSSLSession() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Opens this connection according to the given route.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates that a tunnel to the target has been established. The route is the one previously passed to open. Subsequently, layerProtocol can be called to layer the TLS/SSL protocol on top of the tunnelled connection. <br></br> <b>Note:</b> In HttpClient 3, a call to the corresponding method would automatically trigger the layering of the TLS/SSL protocol. This is not the case anymore, you can establish a tunnel without layering a new protocol over the connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void TunnelTarget(bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates that a tunnel to an intermediate proxy has been established. This is used exclusively for so-called <b>proxy chains</b>, where a request has to pass through multiple proxies before reaching the target. In that case, all proxies but the last need to be tunnelled when establishing the connection. Tunnelling of the last proxy to the target is optional and would be indicated via tunnelTarget.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void TunnelProxy(global::Org.Apache.Http.HttpHost next, bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Layers a new protocol on top of a tunnelled connection. This is typically used to create a TLS/SSL connection through a proxy. The route is the one previously passed to open. It is not guaranteed that the layered connection is secure.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Marks this connection as being in a reusable communication state. The checkpoints for reuseable communication states (in the absence of pipelining) are before sending a request and after receiving the response in it's entirety. The connection will automatically clear the checkpoint when used for communication. A call to this method indicates that the next checkpoint has been reached. <br></br> A reusable communication state is necessary but not sufficient for the connection to be reused. A route mismatch, the connection being closed, or other circumstances might prevent reuse. </para>        
				/// </summary>
				/// <java-name>
				/// markReusable
				/// </java-name>
				[Dot42.DexImport("markReusable", "()V", AccessFlags = 1025)]
				void MarkReusable() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Marks this connection as not being in a reusable state. This can be used immediately before releasing this connection to prevent it's reuse. Reasons for preventing reuse include error conditions and the evaluation of a reuse strategy. <br></br> <b>Note:</b> It is <b>not</b> necessary to call here before writing to or reading from this connection. Communication attempts will automatically unmark the state as non-reusable. It can then be switched back using markReusable. </para>        
				/// </summary>
				/// <java-name>
				/// unmarkReusable
				/// </java-name>
				[Dot42.DexImport("unmarkReusable", "()V", AccessFlags = 1025)]
				void UnmarkReusable() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this connection is in a reusable communication state. See markReusable and unmarkReusable for details.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this connection is marked as being in a reusable communication state, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isMarkedReusable
				/// </java-name>
				[Dot42.DexImport("isMarkedReusable", "()Z", AccessFlags = 1025)]
				bool IsMarkedReusable() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Assigns a state object to this connection. Connection managers may make use of the connection state when allocating persistent connections.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetState(object state) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the state object associated with this connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The state object </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object GetState() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the duration that this connection can remain idle before it is reused. The connection should not be used again if this time elapses. The idle duration must be reset after each request sent over this connection. The elapsed time starts counting when the connection is released, which is typically after the headers (and any response body, if present) is fully consumed. </para>        
				/// </summary>
				/// <java-name>
				/// setIdleDuration
				/// </java-name>
				[Dot42.DexImport("setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1025)]
				void SetIdleDuration(long duration, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A stream wrapper that triggers actions on close() and EOF. Primarily used to auto-release an underlying connection when the response body is consumed or no longer needed.</para><para>This class is based on <code>AutoCloseInputStream</code> in HttpClient 3.1, but has notable differences. It does not allow mark/reset, distinguishes different kinds of event, and does not always close the underlying stream on EOF. That decision is left to the watcher. </para><para><para>EofSensorWatcher EofSensorWatcher</para><para> </para><simplesectsep></simplesectsep><para>Ortwin Glueck </para><simplesectsep></simplesectsep><para>Eric Johnson </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>672367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/EofSensorInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/EofSensorInputStream", AccessFlags = 33)]
		public partial class EofSensorInputStream : global::Java.Io.InputStream, global::Org.Apache.Http.Conn.IConnectionReleaseTrigger
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The wrapped input stream, while accessible. The value changes to <code>null</code> when the wrapped stream becomes inaccessible. </para>        
				/// </summary>
				/// <java-name>
				/// wrappedStream
				/// </java-name>
				[Dot42.DexImport("wrappedStream", "Ljava/io/InputStream;", AccessFlags = 4)]
				protected internal global::Java.Io.InputStream WrappedStream;
				/// <summary>
				/// <para>Creates a new EOF sensor. If no watcher is passed, the underlying stream will simply be closed when EOF is detected or close is called. Otherwise, the watcher decides whether the underlying stream should be closed before detaching from it.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Lorg/apache/http/conn/EofSensorWatcher;)V", AccessFlags = 1)]
				public EofSensorInputStream(global::Java.Io.InputStream @in, global::Org.Apache.Http.Conn.IEofSensorWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether the underlying stream can be read from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the underlying stream is accessible, <code>false</code> if this stream is in EOF mode and detached from the underlying stream</para>
				/// </returns>
				/// <java-name>
				/// isReadAllowed
				/// </java-name>
				[Dot42.DexImport("isReadAllowed", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsReadAllowed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the stream has been reached. Blocks until one byte has been read, the end of the source stream is detected or an exception is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte read or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads at most <c> length </c> bytes from this stream and stores them in the byte array <c> b </c> starting at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read or -1 if the end of the stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads at most <c> length </c> bytes from this stream and stores them in the byte array <c> b </c> starting at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read or -1 if the end of the stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Equivalent to <c> read(buffer, 0, buffer.length) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Equivalent to <c> read(buffer, 0, buffer.length) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an estimated number of bytes that can be read or skipped without blocking for more input.</para><para>Note that this method provides such a weak guarantee that it is not very useful in practice.</para><para>Firstly, the guarantee is "without blocking for more input" rather than "without       blocking": a read may still block waiting for I/O to complete  the guarantee is merely that it won't have to wait indefinitely for data to be written. The result of this method should not be used as a license to do I/O on a thread that shouldn't be blocked.</para><para>Secondly, the result is a conservative estimate and may be significantly smaller than the actual number of bytes available. In particular, an implementation that always returns 0 would be correct. In general, callers should only use this method if they'd be satisfied with treating the result as a boolean yes or no answer to the question "is there definitely       data ready?".</para><para>Thirdly, the fact that a given number of bytes is "available" does not guarantee that a read or skip will actually read or skip that many bytes: they may read or skip fewer.</para><para>It is particularly important to realize that you <b>must not</b> use this method to size a container and assume that you can read the entirety of the stream without needing to resize the container. Such callers should probably write everything they read to a ByteArrayOutputStream and convert that to a byte array. Alternatively, if you're reading from a file, File#length returns the current length of the file (though assuming the file's length can't change may be incorrect, reading a file is inherently racy).</para><para>The default implementation of this method in <c> InputStream </c> always returns 0. Subclasses should override this method if they are able to indicate the number of bytes available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of bytes available </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Closes this stream. Concrete implementations of this class should free any resources during close. This implementation does nothing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Detects EOF and notifies the watcher. This method should only be called while the underlying stream is still accessible. Use isReadAllowed to check that condition. <br></br> If EOF is detected, the watcher will be notified and this stream is detached from the underlying stream. This prevents multiple notifications from this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// checkEOF
				/// </java-name>
				[Dot42.DexImport("checkEOF", "(I)V", AccessFlags = 4)]
				protected internal virtual void CheckEOF(int eof) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Detects stream close and notifies the watcher. There's not much to detect since this is called by close. The watcher will only be notified if this stream is closed for the first time and before EOF has been detected. This stream will be detached from the underlying stream to prevent multiple notifications to the watcher.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// checkClose
				/// </java-name>
				[Dot42.DexImport("checkClose", "()V", AccessFlags = 4)]
				protected internal virtual void CheckClose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Detects stream abort and notifies the watcher. There's not much to detect since this is called by abortConnection. The watcher will only be notified if this stream is aborted for the first time and before EOF has been detected or the stream has been closed gracefully. This stream will be detached from the underlying stream to prevent multiple notifications to the watcher.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// checkAbort
				/// </java-name>
				[Dot42.DexImport("checkAbort", "()V", AccessFlags = 4)]
				protected internal virtual void CheckAbort() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Same as close(). </para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 1)]
				public virtual void ReleaseConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Aborts this stream. This is a special version of close() which prevents re-use of the underlying connection, if any. Calling this method indicates that there should be no attempt to read until the end of the stream. </para>        
				/// </summary>
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

		}

		/// <summary>
		/// <para>A ConnectException that specifies the HttpHost that was being connected to. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/HttpHostConnectException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/HttpHostConnectException", AccessFlags = 33)]
		public partial class HttpHostConnectException : global::Java.Net.ConnectException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;Ljava/net/ConnectException;)V", AccessFlags = 1)]
				public HttpHostConnectException(global::Org.Apache.Http.HttpHost host, global::Java.Net.ConnectException cause) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.HttpHost GetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpHostConnectException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost Host
				{
				[Dot42.DexImport("getHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1)]
						get{ return GetHost(); }
				}

		}

		/// <summary>
		/// <para>A timeout while waiting for an available connection from a connection manager.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ConnectionPoolTimeoutException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectionPoolTimeoutException", AccessFlags = 33)]
		public partial class ConnectionPoolTimeoutException : global::Org.Apache.Http.Conn.ConnectTimeoutException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a ConnectTimeoutException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectionPoolTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a ConnectTimeoutException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectionPoolTimeoutException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A client-side connection that relies on outside logic to connect sockets to the appropriate hosts. It can be operated directly by an application, or through an operator.</para><para><para></para><para></para><title>Revision:</title><para>646087 </para><title>Date:</title><para>2008-04-08 14:36:46 -0700 (Tue, 08 Apr 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/OperatedClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/OperatedClientConnection", AccessFlags = 1537)]
		public partial interface IOperatedClientConnection : global::Org.Apache.Http.IHttpClientConnection, global::Org.Apache.Http.IHttpInetConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the target host for this connection. If the connection is to a proxy but not tunnelled, this is the proxy. If the connection is tunnelled through a proxy, this is the target of the tunnel. <br></br> The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host to which this connection is opened </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 1025)]
				global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this connection is secure. The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this connection is secure, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
				bool IsSecure() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the socket for this connection. The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket for communicating with the target host </para>
				/// </returns>
				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket GetSocket() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Signals that this connection is in the process of being open. <br></br> By calling this method, you can provide the connection with the unconnected socket that will be connected before openCompleted is called. This allows the connection to close that socket if shutdown is called before it is open. Closing the unconnected socket will interrupt a thread that is blocked on the connect. Otherwise, that thread will either time out on the connect, or it returns successfully and then opens this connection which was just shut down. <br></br> You also must call openCompleted in order to complete the process</para><para></para>        
				/// </summary>
				/// <java-name>
				/// opening
				/// </java-name>
				[Dot42.DexImport("opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V", AccessFlags = 1025)]
				void Opening(global::Java.Net.Socket sock, global::Org.Apache.Http.HttpHost target) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Signals that the connection has been successfully open. An attempt to call this method on an open connection will cause an exception.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// openCompleted
				/// </java-name>
				[Dot42.DexImport("openCompleted", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void OpenCompleted(bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates this connection. A connection can be updated only while it is open. Updates are used for example when a tunnel has been established, or when a TLS/SSL connection has been layered on top of a plain socket connection. <br></br> <b>Note:</b> Updating the connection will <b>not</b> close the previously used socket. It is the caller's responsibility to close that socket if it is no longer required.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)" +
    "V", AccessFlags = 1025)]
				void Update(global::Java.Net.Socket sock, global::Org.Apache.Http.HttpHost target, bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An entity that releases a connection. A ManagedClientConnection will typically <b>not</b> return a managed entity, but you can replace the unmanaged entity in the response with a managed one.</para><para><para></para><para></para><title>Revision:</title><para>672367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/BasicManagedEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/BasicManagedEntity", AccessFlags = 33)]
		public partial class BasicManagedEntity : global::Org.Apache.Http.Entity.HttpEntityWrapper, global::Org.Apache.Http.Conn.IConnectionReleaseTrigger, global::Org.Apache.Http.Conn.IEofSensorWatcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The connection to release. </para>        
				/// </summary>
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IManagedClientConnection ManagedConn;
				/// <summary>
				/// <para>Whether to keep the connection alive. </para>        
				/// </summary>
				/// <java-name>
				/// attemptReuse
				/// </java-name>
				[Dot42.DexImport("attemptReuse", "Z", AccessFlags = 20)]
				protected internal readonly bool AttemptReuse;
				/// <summary>
				/// <para>Creates a new managed entity that can release a connection.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntity;Lorg/apache/http/conn/ManagedClientConnection;Z)V", AccessFlags = 1)]
				public BasicManagedEntity(global::Org.Apache.Http.IHttpEntity entity, global::Org.Apache.Http.Conn.IManagedClientConnection conn, bool reuse) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>TODO: The name of this method is misnomer. It will be renamed to #finish() in the next major release. <br></br> This method is called to indicate that the content of this entity is no longer required. All entity implementations are expected to release all allocated resources as a result of this method invocation. Content streaming entities are also expected to dispose of the remaining content, if any. Wrapping entities should delegate this call to the wrapped entity. <br></br> This method is of particular importance for entities being received from a connection. The entity needs to be consumed completely in order to re-use the connection with keep-alive.</para><para></para>        
				/// </summary>
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
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases the connection with the option of keep-alive. This is a "graceful" release and may cause IO operations for consuming the remainder of a response entity. Use abortConnection for a hard release. The connection may be reused as specified by the duration.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "()V", AccessFlags = 1)]
				public virtual void ReleaseConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases the connection without the option of keep-alive. This is a "hard" release that implies a shutdown of the connection. Use releaseConnection for a graceful release.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// abortConnection
				/// </java-name>
				[Dot42.DexImport("abortConnection", "()V", AccessFlags = 1)]
				public virtual void AbortConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates that EOF is detected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// eofDetected
				/// </java-name>
				[Dot42.DexImport("eofDetected", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool EofDetected(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates that the stream is closed. This method will be called only if EOF was <b>not</b> detected before closing. Otherwise, eofDetected is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// streamClosed
				/// </java-name>
				[Dot42.DexImport("streamClosed", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamClosed(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates that the stream is aborted. This method will be called only if EOF was <b>not</b> detected before aborting. Otherwise, eofDetected is called. </para><para>This method will also be invoked when an input operation causes an IOException to be thrown to make sure the input stream gets shut down.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// streamAbort
				/// </java-name>
				[Dot42.DexImport("streamAbort", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamAbort(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases the connection gracefully. The connection attribute will be nullified. Subsequent invocations are no-ops.</para><para></para>        
				/// </summary>
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

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>Interface for deciding how long a connection can remain idle before being reused.</para><para><para></para><para></para><title>Revision:</title></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ConnectionKeepAliveStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ConnectionKeepAliveStrategy", AccessFlags = 1537)]
		public partial interface IConnectionKeepAliveStrategy
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the duration of time which this connection can be safely kept idle. If the connection is left idle for longer than this period of time, it MUST not reused. A value of 0 or less may be returned to indicate that there is no suitable suggestion.</para><para>When coupled with a ConnectionReuseStrategy, if returns true, this allows you to control how long the reuse will last. If keepAlive returns false, this should have no meaningful impact   response The last response received over the connection.  context the context in which the connection is being used.   the duration in ms for which it is safe to keep the connection idle, or &lt;=0 if no suggested duration. </para>        
				/// </summary>
				/// <java-name>
				/// getKeepAliveDuration
				/// </java-name>
				[Dot42.DexImport("getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J", AccessFlags = 1025)]
				long GetKeepAliveDuration(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Socket factory that implements a simple multi-home fail-over on connect failure, provided the same hostname resolves to multiple InetAddresses. Please note the connectSocket(Socket, String, int, InetAddress, int, HttpParams) method cannot be reliably interrupted by closing the socket returned by the createSocket() method. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/MultihomePlainSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/MultihomePlainSocketFactory", AccessFlags = 49)]
		public sealed partial class MultihomePlainSocketFactory : global::Org.Apache.Http.Conn.Scheme.ISocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Restricted default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MultihomePlainSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the singleton instance of this class. </para>        
				/// </summary>
				/// <returns>
				/// <para>the one and only plain socket factory </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/MultihomePlainSocketFactory;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.MultihomePlainSocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.MultihomePlainSocketFactory);
				}

				/// <summary>
				/// <para>Creates a new, unconnected socket. The socket should subsequently be passed to connectSocket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new socket</para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1)]
				public global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				/// <para>Attempts to connects the socket to any of the InetAddresses the given host name resolves to. If connection to all addresses fail, the last I/O exception is propagated to the caller.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connectSocket
				/// </java-name>
				[Dot42.DexImport("connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/para" +
    "ms/HttpParams;)Ljava/net/Socket;", AccessFlags = 1)]
				public global::Java.Net.Socket ConnectSocket(global::Java.Net.Socket sock, string host, int port, global::Java.Net.InetAddress localAddress, int localPort, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				/// <para>Checks whether a socket connection is secure. This factory creates plain socket connections which are not considered secure.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code></para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "(Ljava/net/Socket;)Z", AccessFlags = 17)]
				public bool IsSecure(global::Java.Net.Socket sock) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares this factory with an object. There is only one instance of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>iff the argument is this object </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains a hash code for this object. All instances of this class have the same hash code. There is only one instance of this class. </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the singleton instance of this class. </para>        
				/// </summary>
				/// <returns>
				/// <para>the one and only plain socket factory </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public static global::Org.Apache.Http.Conn.MultihomePlainSocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/MultihomePlainSocketFactory;", AccessFlags = 9)]
						get{ return GetSocketFactory(); }
				}

		}

		/// <summary>
		/// <para>Basic implementation of EofSensorWatcher. The underlying connection is released on close or EOF.</para><para><para></para><para></para><title>Revision:</title><para>672367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/BasicEofSensorWatcher
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/BasicEofSensorWatcher", AccessFlags = 33)]
		public partial class BasicEofSensorWatcher : global::Org.Apache.Http.Conn.IEofSensorWatcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The connection to auto-release. </para>        
				/// </summary>
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IManagedClientConnection ManagedConn;
				/// <summary>
				/// <para>Whether to keep the connection alive. </para>        
				/// </summary>
				/// <java-name>
				/// attemptReuse
				/// </java-name>
				[Dot42.DexImport("attemptReuse", "Z", AccessFlags = 4)]
				protected internal bool AttemptReuse;
				/// <summary>
				/// <para>Creates a new watcher for auto-releasing a connection.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ManagedClientConnection;Z)V", AccessFlags = 1)]
				public BasicEofSensorWatcher(global::Org.Apache.Http.Conn.IManagedClientConnection conn, bool reuse) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates that EOF is detected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// eofDetected
				/// </java-name>
				[Dot42.DexImport("eofDetected", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool EofDetected(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates that the stream is closed. This method will be called only if EOF was <b>not</b> detected before closing. Otherwise, eofDetected is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// streamClosed
				/// </java-name>
				[Dot42.DexImport("streamClosed", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamClosed(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates that the stream is aborted. This method will be called only if EOF was <b>not</b> detected before aborting. Otherwise, eofDetected is called. </para><para>This method will also be invoked when an input operation causes an IOException to be thrown to make sure the input stream gets shut down.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>wrapped</code> should be closed, <code>false</code> if it should be left alone</para>
				/// </returns>
				/// <java-name>
				/// streamAbort
				/// </java-name>
				[Dot42.DexImport("streamAbort", "(Ljava/io/InputStream;)Z", AccessFlags = 1)]
				public virtual bool StreamAbort(global::Java.Io.InputStream wrapped) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicEofSensorWatcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Encapsulates a request for a ManagedClientConnection. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ClientConnectionRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ClientConnectionRequest", AccessFlags = 1537)]
		public partial interface IClientConnectionRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains a connection within a given time. This method will block until a connection becomes available, the timeout expires, or the connection manager is shut down. Timeouts are handled with millisecond precision.</para><para>If abortRequest() is called while this is blocking or before this began, an InterruptedException will be thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a connection that can be used to communicate along the given route</para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/conn/ManagedClientConnection;", AccessFlags = 1025)]
				global::Org.Apache.Http.Conn.IManagedClientConnection GetConnection(long timeout, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Aborts the call to getConnection(long, TimeUnit), causing it to throw an InterruptedException. </para>        
				/// </summary>
				/// <java-name>
				/// abortRequest
				/// </java-name>
				[Dot42.DexImport("abortRequest", "()V", AccessFlags = 1025)]
				void AbortRequest() /* MethodBuilder.Create */ ;

		}

}


