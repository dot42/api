// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Conn.cs
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
namespace Org.Apache.Http.Impl.Conn
{
		/// <summary>
		/// <para>A pool entry for use by connection manager implementations. Pool entries work in conjunction with an adapter. The adapter is handed out to applications that obtain a connection. The pool entry stores the underlying connection and tracks the route established. The adapter delegates methods for establishing the route to it's pool entry. <br></br> If the managed connections is released or revoked, the adapter gets disconnected, but the pool entry still contains the underlying connection and the established route.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>658775 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/AbstractPoolEntry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/AbstractPoolEntry", AccessFlags = 1057)]
		public abstract partial class AbstractPoolEntry
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The connection operator. </para>        
				/// </summary>
				/// <java-name>
				/// connOperator
				/// </java-name>
				[Dot42.DexImport("connOperator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IClientConnectionOperator ConnOperator;
				/// <summary>
				/// <para>The underlying connection being pooled or used. </para>        
				/// </summary>
				/// <java-name>
				/// connection
				/// </java-name>
				[Dot42.DexImport("connection", "Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IOperatedClientConnection Connection;
				/// <summary>
				/// <para>The route for which this entry gets allocated. </para>        
				/// </summary>
				/// <java-name>
				/// route
				/// </java-name>
				[Dot42.DexImport("route", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 68)]
				protected internal global::Org.Apache.Http.Conn.Routing.HttpRoute Route;
				/// <summary>
				/// <para>Connection state object </para>        
				/// </summary>
				/// <java-name>
				/// state
				/// </java-name>
				[Dot42.DexImport("state", "Ljava/lang/Object;", AccessFlags = 68)]
				protected internal object State;
				/// <summary>
				/// <para>The tracked route, or <code>null</code> before tracking starts. </para>        
				/// </summary>
				/// <java-name>
				/// tracker
				/// </java-name>
				[Dot42.DexImport("tracker", "Lorg/apache/http/conn/routing/RouteTracker;", AccessFlags = 68)]
				protected internal global::Org.Apache.Http.Conn.Routing.RouteTracker Tracker;
				/// <summary>
				/// <para>Creates a new pool entry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/Htt" +
    "pRoute;)V", AccessFlags = 4)]
				protected internal AbstractPoolEntry(global::Org.Apache.Http.Conn.IClientConnectionOperator connOperator, global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the state object associated with this pool entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The state object </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetState() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Assigns a state object to this pool entry.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetState(object state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Opens the underlying connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks tunnelling of the connection to the target. The tunnel has to be established outside by sending a CONNECT request to the (last) proxy.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void TunnelTarget(bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tracks tunnelling of the connection to a chained proxy. The tunnel has to be established outside by sending a CONNECT request to the previous proxy.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void TunnelProxy(global::Org.Apache.Http.HttpHost next, bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Layers a protocol on top of an established tunnel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Shuts down the entry.</para><para>If open(HttpRoute, HttpContext, HttpParams) is in progress, this will cause that open to possibly throw an IOException. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Default implementation of an operated client connection.</para><para><para></para><para></para><title>Revision:</title><para>673450 </para><title>Date:</title><para>2008-07-02 10:35:05 -0700 (Wed, 02 Jul 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Obtains the target host for this connection. If the connection is to a proxy but not tunnelled, this is the proxy. If the connection is tunnelled through a proxy, this is the target of the tunnel. <br></br> The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host to which this connection is opened </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
				public global::Org.Apache.Http.HttpHost GetTargetHost() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Indicates whether this connection is secure. The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this connection is secure, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 17)]
				public bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the socket for this connection. The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket for communicating with the target host </para>
				/// </returns>
				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 17)]
				public new global::Java.Net.Socket GetSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				/// <para>Signals that this connection is in the process of being open. <br></br> By calling this method, you can provide the connection with the unconnected socket that will be connected before openCompleted is called. This allows the connection to close that socket if shutdown is called before it is open. Closing the unconnected socket will interrupt a thread that is blocked on the connect. Otherwise, that thread will either time out on the connect, or it returns successfully and then opens this connection which was just shut down. <br></br> You also must call openCompleted in order to complete the process</para><para></para>        
				/// </summary>
				/// <java-name>
				/// opening
				/// </java-name>
				[Dot42.DexImport("opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void Opening(global::Java.Net.Socket sock, global::Org.Apache.Http.HttpHost target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Signals that the connection has been successfully open. An attempt to call this method on an open connection will cause an exception.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// openCompleted
				/// </java-name>
				[Dot42.DexImport("openCompleted", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void OpenCompleted(bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Force-closes this connection. If the connection is still in the process of being open (the method opening was already called but openCompleted was not), the associated socket that is being connected to a remote address will be closed. That will interrupt a thread that is blocked on connecting the socket. If the connection is not yet open, this will prevent the connection from being opened.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes this connection gracefully. This method will attempt to flush the transmitter's internal buffer prior to closing the underlying socket. This method MUST NOT be called from a different thread to force shutdown of the connection. Use shutdown instead. </para>        
				/// </summary>
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
				protected internal override global::Org.Apache.Http.Io.ISessionInputBuffer CreateSessionInputBuffer(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionInputBuffer);
				}

				/// <java-name>
				/// createSessionOutputBuffer
				/// </java-name>
				[Dot42.DexImport("createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nOutputBuffer;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Io.ISessionOutputBuffer CreateSessionOutputBuffer(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionOutputBuffer);
				}

				/// <java-name>
				/// createResponseParser
				/// </java-name>
				[Dot42.DexImport("createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg" +
    "/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Io.IHttpMessageParser CreateResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.IHttpResponseFactory responseFactory, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageParser);
				}

				/// <summary>
				/// <para>Updates this connection. A connection can be updated only while it is open. Updates are used for example when a tunnel has been established, or when a TLS/SSL connection has been layered on top of a plain socket connection. <br></br> <b>Note:</b> Updating the connection will <b>not</b> close the previously used socket. It is the caller's responsibility to close that socket if it is no longer required.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)" +
    "V", AccessFlags = 1)]
				public virtual void Update(global::Java.Net.Socket sock, global::Org.Apache.Http.HttpHost target, bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receives the request line and headers of the next response available from this connection. The caller should examine the HttpResponse object to find out if it should try to receive a response entity as well.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new HttpResponse object with status line and headers initialized. </para>
				/// </returns>
				/// <java-name>
				/// receiveResponseHeader
				/// </java-name>
				[Dot42.DexImport("receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHttpResponse ReceiveResponseHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Sends the request line and all headers over the connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public override void SendRequestHeader(global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "isResponseAvailable", "(I)Z", AccessFlags = 1025)]
				public override bool IsResponseAvailable(int timeout) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1025)]
				public override void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpClientConnection", "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				public override void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse response) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
				public override void SetSocketTimeout(int timeout) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				/// <summary>
				/// <para>Obtains the target host for this connection. If the connection is to a proxy but not tunnelled, this is the proxy. If the connection is tunnelled through a proxy, this is the target of the tunnel. <br></br> The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host to which this connection is opened </para>
				/// </returns>
				/// <java-name>
				/// getTargetHost
				/// </java-name>
				public global::Org.Apache.Http.HttpHost TargetHost
				{
				[Dot42.DexImport("getTargetHost", "()Lorg/apache/http/HttpHost;", AccessFlags = 17)]
						get{ return GetTargetHost(); }
				}

				/// <summary>
				/// <para>Obtains the socket for this connection. The return value is well-defined only while the connection is open. It may change even while the connection is open, because of an update.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket for communicating with the target host </para>
				/// </returns>
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

		/// <summary>
		/// <para>A connection "manager" for a single connection. This manager is good only for single-threaded use. Allocation <b>always</b> returns the connection immediately, even if it has not been released after the previous allocation. In that case, a warning is logged and the previously issued connection is revoked. </para><para>This class is derived from <code>SimpleHttpConnectionManager</code> in HttpClient 3. See there for original authors. </para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>673450 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/SingleClientConnManager
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/SingleClientConnManager", AccessFlags = 33)]
		public partial class SingleClientConnManager : global::Org.Apache.Http.Conn.IClientConnectionManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The message to be logged on multiple allocation. </para>        
				/// </summary>
				/// <java-name>
				/// MISUSE_MESSAGE
				/// </java-name>
				[Dot42.DexImport("MISUSE_MESSAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MISUSE_MESSAGE = "Invalid use of SingleClientConnManager: connection still allocated.\nMake sure to " +
    "release the connection before allocating another one.";
				/// <summary>
				/// <para>The schemes supported by this connection manager. </para>        
				/// </summary>
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <summary>
				/// <para>The operator for opening and updating connections. </para>        
				/// </summary>
				/// <java-name>
				/// connOperator
				/// </java-name>
				[Dot42.DexImport("connOperator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IClientConnectionOperator ConnOperator;
				/// <summary>
				/// <para>The one and only entry in this pool. </para>        
				/// </summary>
				/// <java-name>
				/// uniquePoolEntry
				/// </java-name>
				[Dot42.DexImport("uniquePoolEntry", "Lorg/apache/http/impl/conn/SingleClientConnManager$PoolEntry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Impl.Conn.SingleClientConnManager.PoolEntry UniquePoolEntry;
				/// <summary>
				/// <para>The currently issued managed connection, if any. </para>        
				/// </summary>
				/// <java-name>
				/// managedConn
				/// </java-name>
				[Dot42.DexImport("managedConn", "Lorg/apache/http/impl/conn/SingleClientConnManager$ConnAdapter;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Impl.Conn.SingleClientConnManager.ConnAdapter ManagedConn;
				/// <summary>
				/// <para>The time of the last connection release, or -1. </para>        
				/// </summary>
				/// <java-name>
				/// lastReleaseTime
				/// </java-name>
				[Dot42.DexImport("lastReleaseTime", "J", AccessFlags = 4)]
				protected internal long LastReleaseTime;
				/// <summary>
				/// <para>The time the last released connection expires and shouldn't be reused. </para>        
				/// </summary>
				/// <java-name>
				/// connectionExpiresTime
				/// </java-name>
				[Dot42.DexImport("connectionExpiresTime", "J", AccessFlags = 4)]
				protected internal long ConnectionExpiresTime;
				/// <summary>
				/// <para>Whether the connection should be shut down on release. </para>        
				/// </summary>
				/// <java-name>
				/// alwaysShutDown
				/// </java-name>
				[Dot42.DexImport("alwaysShutDown", "Z", AccessFlags = 4)]
				protected internal bool AlwaysShutDown;
				/// <summary>
				/// <para>Indicates whether this connection manager is shut down. </para>        
				/// </summary>
				/// <java-name>
				/// isShutDown
				/// </java-name>
				[Dot42.DexImport("isShutDown", "Z", AccessFlags = 68)]
				protected internal bool IsShutDown;
				/// <summary>
				/// <para>Creates a new simple connection manager.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)" +
    "V", AccessFlags = 1)]
				public SingleClientConnManager(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schreg) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SingleClientConnManager() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the scheme registry used by this manager.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme registry, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Scheme.SchemeRegistry GetSchemeRegistry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry);
				}

				/// <summary>
				/// <para>Hook for creating the connection operator. It is called by the constructor. Derived classes can override this method to change the instantiation of the operator. The default implementation here instantiates DefaultClientConnectionOperator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection operator to use </para>
				/// </returns>
				/// <java-name>
				/// createConnectionOperator
				/// </java-name>
				[Dot42.DexImport("createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnect" +
    "ionOperator;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.IClientConnectionOperator CreateConnectionOperator(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schreg) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionOperator);
				}

				/// <summary>
				/// <para>Asserts that this manager is not shut down.</para><para></para>        
				/// </summary>
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
				public global::Org.Apache.Http.Conn.IClientConnectionRequest RequestConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionRequest);
				}

				/// <summary>
				/// <para>Obtains a connection. This method does not block.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a connection that can be used to communicate along the given route </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn" +
    "/ManagedClientConnection;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.IManagedClientConnection GetConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IManagedClientConnection);
				}

				/// <summary>
				/// <para>Releases a connection for use by others. You may optionally specify how long the connection is valid to be reused. Values &lt;= 0 are considered to be valid forever. If the connection is not marked as reusable, the connection will not be reused regardless of the valid duration.</para><para>If the connection has been released before, the call will be ignored.</para><para><para>closeExpiredConnections() </para></para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V" +
    "", AccessFlags = 1)]
				public virtual void ReleaseConnection(global::Org.Apache.Http.Conn.IManagedClientConnection conn, long validDuration, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes all expired connections in the pool. Open connections in the pool that have not been used for the timespan defined when the connection was released will be closed. Currently allocated connections are not subject to this method. Times will be checked with milliseconds precision. </para>        
				/// </summary>
				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1)]
				public virtual void CloseExpiredConnections() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes idle connections in the pool. Open connections in the pool that have not been used for the timespan given by the argument will be closed. Currently allocated connections are not subject to this method. Times will be checked with milliseconds precision</para><para>All expired connections will also be closed.</para><para><para>closeExpiredConnections() </para></para>        
				/// </summary>
				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long idletime, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Shuts down this connection manager and releases allocated resources. This includes closing all connections, whether they are currently used or not. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Revokes the currently issued connection. The adapter gets disconnected, the connection will be shut down. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>The connection adapter used by this manager. </para>    
				/// </summary>
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

				/// <summary>
				/// <para>The pool entry for this connection manager. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Closes the connection in this pool entry. </para>        
						/// </summary>
						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 4)]
						protected internal virtual void Close() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Shuts down the connection in this pool entry. </para>        
						/// </summary>
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

		/// <summary>
		/// <para>Default implementation of an HttpRoutePlanner. This implementation is based on java.net.ProxySelector. By default, it will pick up the proxy settings of the JVM, either from system properties or from the browser running the application. Additionally, it interprets some parameters, though not the DEFAULT_PROXY. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/ProxySelectorRoutePlanner
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/ProxySelectorRoutePlanner", AccessFlags = 33)]
		public partial class ProxySelectorRoutePlanner : global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The scheme registry. </para>        
				/// </summary>
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <summary>
				/// <para>The proxy selector to use, or <code>null</code> for system default. </para>        
				/// </summary>
				/// <java-name>
				/// proxySelector
				/// </java-name>
				[Dot42.DexImport("proxySelector", "Ljava/net/ProxySelector;", AccessFlags = 4)]
				protected internal global::Java.Net.ProxySelector ProxySelector;
				/// <summary>
				/// <para>Creates a new proxy selector route planner.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;Ljava/net/ProxySelector;)V", AccessFlags = 1)]
				public ProxySelectorRoutePlanner(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schreg, global::Java.Net.ProxySelector prosel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the proxy selector to use.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the proxy selector, or <code>null</code> for the system default </para>
				/// </returns>
				/// <java-name>
				/// getProxySelector
				/// </java-name>
				[Dot42.DexImport("getProxySelector", "()Ljava/net/ProxySelector;", AccessFlags = 1)]
				public virtual global::Java.Net.ProxySelector GetProxySelector() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ProxySelector);
				}

				/// <summary>
				/// <para>Sets the proxy selector to use.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProxySelector
				/// </java-name>
				[Dot42.DexImport("setProxySelector", "(Ljava/net/ProxySelector;)V", AccessFlags = 1)]
				public virtual void SetProxySelector(global::Java.Net.ProxySelector prosel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines the route for a request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route that the request should take</para>
				/// </returns>
				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <summary>
				/// <para>Determines a proxy for the given target.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the proxy to use, or <code>null</code> for a direct route</para>
				/// </returns>
				/// <java-name>
				/// determineProxy
				/// </java-name>
				[Dot42.DexImport("determineProxy", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/HttpHost;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.HttpHost DetermineProxy(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.HttpHost);
				}

				/// <summary>
				/// <para>Obtains a host from an InetSocketAddress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a host string, either as a symbolic name or as a literal IP address string <br></br> (TODO: determine format for IPv6 addresses, with or without [brackets]) </para>
				/// </returns>
				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "(Ljava/net/InetSocketAddress;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetHost(global::Java.Net.InetSocketAddress isa) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// chooseProxy
				/// </java-name>
				[Dot42.DexImport("chooseProxy", "(Ljava/util/List;Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apac" +
    "he/http/protocol/HttpContext;)Ljava/net/Proxy;", AccessFlags = 4, Signature = "(Ljava/util/List<Ljava/net/Proxy;>;Lorg/apache/http/HttpHost;Lorg/apache/http/Htt" +
    "pRequest;Lorg/apache/http/protocol/HttpContext;)Ljava/net/Proxy;")]
				protected internal virtual global::Java.Net.Proxy ChooseProxy(global::Java.Util.IList<global::Java.Net.Proxy> proxies, global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Proxy);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProxySelectorRoutePlanner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Default implementation of a ClientConnectionOperator. It uses a SchemeRegistry to look up SocketFactory objects.</para><para><para></para><para></para><title>Revision:</title><para>652193 </para><title>Date:</title><para>2008-04-29 17:10:36 -0700 (Tue, 29 Apr 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/DefaultClientConnectionOperator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultClientConnectionOperator", AccessFlags = 33)]
		public partial class DefaultClientConnectionOperator : global::Org.Apache.Http.Conn.IClientConnectionOperator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The scheme registry for looking up socket factories. </para>        
				/// </summary>
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <summary>
				/// <para>Creates a new client connection operator for the given scheme registry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V", AccessFlags = 1)]
				public DefaultClientConnectionOperator(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new connection that can be operated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new, unopened connection for use with this operator </para>
				/// </returns>
				/// <java-name>
				/// createConnection
				/// </java-name>
				[Dot42.DexImport("createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.IOperatedClientConnection CreateConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IOperatedClientConnection);
				}

				/// <summary>
				/// <para>Opens a connection to the given target host.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/n" +
    "et/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/Htt" +
    "pParams;)V", AccessFlags = 1)]
				public virtual void OpenConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection conn, global::Org.Apache.Http.HttpHost target, global::Java.Net.InetAddress local, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates a connection with a layered secure connection. The typical use of this method is to update a tunnelled plain connection (HTTP) to a secure TLS/SSL connection (HTTPS).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateSecureConnection
				/// </java-name>
				[Dot42.DexImport("updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/ap" +
    "ache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void UpdateSecureConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection conn, global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs standard initializations on a newly created socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// prepareSocket
				/// </java-name>
				[Dot42.DexImport("prepareSocket", "(Ljava/net/Socket;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/H" +
    "ttpParams;)V", AccessFlags = 4)]
				protected internal virtual void PrepareSocket(global::Java.Net.Socket sock, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultClientConnectionOperator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Default implementation of an HttpRoutePlanner. This implementation is based on parameters. It will not make use of any Java system properties, nor of system or browser proxy settings. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/DefaultHttpRoutePlanner
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultHttpRoutePlanner", AccessFlags = 33)]
		public partial class DefaultHttpRoutePlanner : global::Org.Apache.Http.Conn.Routing.IHttpRoutePlanner
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The scheme registry. </para>        
				/// </summary>
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <summary>
				/// <para>Creates a new default route planner.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V", AccessFlags = 1)]
				public DefaultHttpRoutePlanner(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schreg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines the route for a request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route that the request should take</para>
				/// </returns>
				/// <java-name>
				/// determineRoute
				/// </java-name>
				[Dot42.DexImport("determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol" +
    "/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Routing.HttpRoute DetermineRoute(global::Org.Apache.Http.HttpHost target, global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultHttpRoutePlanner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Logs data to the wire LOG.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual void Output(global::Java.Io.InputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void Input(global::Java.Io.InputStream instream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([BII)V", AccessFlags = 1)]
				public virtual void Output(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Output(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([BII)V", AccessFlags = 1)]
				public virtual void Input(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Input(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([B)V", AccessFlags = 1)]
				public virtual void Output(sbyte[] outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Output(byte[] outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([B)V", AccessFlags = 1)]
				public virtual void Input(sbyte[] instream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Input(byte[] instream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "(I)V", AccessFlags = 1)]
				public virtual void Output(int outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "(I)V", AccessFlags = 1)]
				public virtual void Input(int instream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// output
				/// </java-name>
				[Dot42.DexImport("output", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Output(string outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// input
				/// </java-name>
				[Dot42.DexImport("input", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Input(string instream) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Wire() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/DefaultResponseParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/DefaultResponseParser", AccessFlags = 33)]
		public partial class DefaultResponseParser : global::Org.Apache.Http.Impl.Io.AbstractMessageParser
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/" +
    "apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.Message.ILineParser parser, global::Org.Apache.Http.IHttpResponseFactory responseFactory, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultResponseParser() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Abstract adapter from pool entries to managed client connections. The connection in the pool entry is used to initialize the base class. In addition, methods to establish a route are delegated to the pool entry. shutdown and close will clear the tracked route in the pool entry and call the respective method of the wrapped connection.</para><para><para></para><para></para><title>Revision:</title><para>658775 </para><title>Date:</title><para>2008-05-21 10:30:45 -0700 (Wed, 21 May 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/AbstractPooledConnAdapter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/AbstractPooledConnAdapter", AccessFlags = 1057)]
		public abstract partial class AbstractPooledConnAdapter : global::Org.Apache.Http.Impl.Conn.AbstractClientConnAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The wrapped pool entry. </para>        
				/// </summary>
				/// <java-name>
				/// poolEntry
				/// </java-name>
				[Dot42.DexImport("poolEntry", "Lorg/apache/http/impl/conn/AbstractPoolEntry;", AccessFlags = 68)]
				protected internal global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry PoolEntry;
				/// <summary>
				/// <para>Creates a new connection adapter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/impl/conn/Abstrac" +
    "tPoolEntry;)V", AccessFlags = 4)]
				protected internal AbstractPooledConnAdapter(global::Org.Apache.Http.Conn.IClientConnectionManager manager, global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that this adapter is still attached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// assertAttached
				/// </java-name>
				[Dot42.DexImport("assertAttached", "()V", AccessFlags = 20)]
				protected internal void AssertAttached() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Detaches this adapter from the wrapped connection. This adapter becomes useless. </para>        
				/// </summary>
				/// <java-name>
				/// detach
				/// </java-name>
				[Dot42.DexImport("detach", "()V", AccessFlags = 4)]
				protected internal override void Detach() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the current route of this connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route established so far, or <code>null</code> if not connected </para>
				/// </returns>
				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <summary>
				/// <para>Opens this connection according to the given route.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lo" +
    "rg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates that a tunnel to the target has been established. The route is the one previously passed to open. Subsequently, layerProtocol can be called to layer the TLS/SSL protocol on top of the tunnelled connection. <br></br> <b>Note:</b> In HttpClient 3, a call to the corresponding method would automatically trigger the layering of the TLS/SSL protocol. This is not the case anymore, you can establish a tunnel without layering a new protocol over the connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelTarget
				/// </java-name>
				[Dot42.DexImport("tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void TunnelTarget(bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates that a tunnel to an intermediate proxy has been established. This is used exclusively for so-called <b>proxy chains</b>, where a request has to pass through multiple proxies before reaching the target. In that case, all proxies but the last need to be tunnelled when establishing the connection. Tunnelling of the last proxy to the target is optional and would be indicated via tunnelTarget.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// tunnelProxy
				/// </java-name>
				[Dot42.DexImport("tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void TunnelProxy(global::Org.Apache.Http.HttpHost next, bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Layers a new protocol on top of a tunnelled connection. This is typically used to create a TLS/SSL connection through a proxy. The route is the one previously passed to open. It is not guaranteed that the layered connection is secure.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// layerProtocol
				/// </java-name>
				[Dot42.DexImport("layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public override void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes this connection gracefully. This method will attempt to flush the transmitter's internal buffer prior to closing the underlying socket. This method MUST NOT be called from a different thread to force shutdown of the connection. Use shutdown instead. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Force-closes this connection. This is the only method of a connection which may be called from a different thread to terminate the connection. This method will not attempt to flush the transmitter's internal buffer prior to closing the underlying socket. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the state object associated with this connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The state object </para>
				/// </returns>
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
				public override void SetState(object state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractPooledConnAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Obtains the current route of this connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route established so far, or <code>null</code> if not connected </para>
				/// </returns>
				/// <java-name>
				/// getRoute
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 1)]
						get{ return GetRoute(); }
				}

				/// <summary>
				/// <para>Returns the state object associated with this connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The state object </para>
				/// </returns>
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

		/// <summary>
		/// <para>A helper class for connection managers to track idle connections.</para><para>This class is not synchronized.</para><para><para>org.apache.http.conn.ClientConnectionManager::closeIdleConnections</para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Registers the given connection with this handler. The connection will be held until remove or closeIdleConnections is called.</para><para><para>remove </para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Lorg/apache/http/HttpConnection;JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void Add(global::Org.Apache.Http.IHttpConnection connection, long validDuration, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the given connection from the list of connections to be closed when idle. This will return true if the connection is still valid, and false if the connection should be considered expired and not used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the connection is still valid. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Lorg/apache/http/HttpConnection;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::Org.Apache.Http.IHttpConnection connection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all connections referenced by this handler. </para>        
				/// </summary>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "()V", AccessFlags = 1)]
				public virtual void RemoveAll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes connections that have been idle for at least the given amount of time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(J)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long idleTime) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>Abstract adapter from operated to managed client connections. Read and write methods are delegated to the wrapped connection. Operations affecting the connection state have to be implemented by derived classes. Operations for querying the connection state are delegated to the wrapped connection if there is one, or return a default value if there is none. <br></br> This adapter tracks the checkpoints for reusable communication states, as indicated by markReusable and queried by isMarkedReusable. All send and receive operations will automatically clear the mark. <br></br> Connection release calls are delegated to the connection manager, if there is one. abortConnection will clear the reusability mark first. The connection manager is expected to tolerate multiple calls to the release method.</para><para><para></para><para></para><title>Revision:</title><para>672969 </para><title>Date:</title><para>2008-06-30 18:09:50 -0700 (Mon, 30 Jun 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/AbstractClientConnAdapter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/AbstractClientConnAdapter", AccessFlags = 1057)]
		public abstract partial class AbstractClientConnAdapter : global::Org.Apache.Http.Conn.IManagedClientConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new connection adapter. The adapter is initially <b>not</b> marked as reusable.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/conn/OperatedClie" +
    "ntConnection;)V", AccessFlags = 4)]
				protected internal AbstractClientConnAdapter(global::Org.Apache.Http.Conn.IClientConnectionManager mgr, global::Org.Apache.Http.Conn.IOperatedClientConnection conn) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Detaches this adapter from the wrapped connection. This adapter becomes useless. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Asserts that the connection has not been aborted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// assertNotAborted
				/// </java-name>
				[Dot42.DexImport("assertNotAborted", "()V", AccessFlags = 20)]
				protected internal void AssertNotAborted() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that there is a wrapped connection to delegate to.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// assertValid
				/// </java-name>
				[Dot42.DexImport("assertValid", "(Lorg/apache/http/conn/OperatedClientConnection;)V", AccessFlags = 20)]
				protected internal void AssertValid(global::Org.Apache.Http.Conn.IOperatedClientConnection wrappedConn) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks if this connection is open. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if it is open, false if it is closed. </para>
				/// </returns>
				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1)]
				public virtual bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this connection has gone down. Network connections may get closed during some time of inactivity for several reasons. The next time a read is attempted on such a connection it will throw an IOException. This method tries to alleviate this inconvenience by trying to find out if a connection is still usable. Implementations may do that by attempting a read with a very small timeout. Thus this method may block for a small amount of time before returning a result. It is therefore an <b>expensive</b> operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if attempts to use this connection are likely to succeed, or <code>false</code> if they are likely to fail and this connection should be closed </para>
				/// </returns>
				/// <java-name>
				/// isStale
				/// </java-name>
				[Dot42.DexImport("isStale", "()Z", AccessFlags = 1)]
				public virtual bool IsStale() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the socket timeout value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketTimeout
				/// </java-name>
				[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetSocketTimeout(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the socket timeout value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>positive value in milliseconds if a timeout is set, <code>0</code> if timeout is disabled or <code>-1</code> if timeout is undefined. </para>
				/// </returns>
				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1)]
				public virtual int GetSocketTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection of connection metrcis </para>        
				/// </summary>
				/// <returns>
				/// <para>HttpConnectionMetrics </para>
				/// </returns>
				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpConnectionMetrics GetMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpConnectionMetrics);
				}

				/// <summary>
				/// <para>Writes out all pending buffered data over the open connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks if response data is available from the connection. May wait for the specified time until some data becomes available. Note that some implementations may completely ignore the timeout parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if data is available; false if there was no data available even after waiting for <code>timeout</code> milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// isResponseAvailable
				/// </java-name>
				[Dot42.DexImport("isResponseAvailable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsResponseAvailable(int timeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Receives the next response entity available from this connection and attaches it to an existing HttpResponse object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// receiveResponseEntity
				/// </java-name>
				[Dot42.DexImport("receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receives the request line and headers of the next response available from this connection. The caller should examine the HttpResponse object to find out if it should try to receive a response entity as well.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new HttpResponse object with status line and headers initialized. </para>
				/// </returns>
				/// <java-name>
				/// receiveResponseHeader
				/// </java-name>
				[Dot42.DexImport("receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse ReceiveResponseHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Sends the request entity over the connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendRequestEntity
				/// </java-name>
				[Dot42.DexImport("sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sends the request line and all headers over the connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestHeader(global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Indicates whether this connection is secure. The return value is well-defined only while the connection is open. It may change even while the connection is open.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this connection is secure, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1)]
				public virtual bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the SSL session of the underlying connection, if any. If this connection is open, and the underlying socket is an SSLSocket, the SSL session of that socket is obtained. This is a potentially blocking operation. <br></br> <b>Note:</b> Whether the underlying socket is an SSL socket can not necessarily be determined via isSecure. Plain sockets may be considered secure, for example if they are connected to a known host in the same network segment. On the other hand, SSL sockets may be considered insecure, for example depending on the chosen cipher suite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the underlying SSL session if available, <code>null</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// getSSLSession
				/// </java-name>
				[Dot42.DexImport("getSSLSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.ISSLSession GetSSLSession() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSession);
				}

				/// <summary>
				/// <para>Marks this connection as being in a reusable communication state. The checkpoints for reuseable communication states (in the absence of pipelining) are before sending a request and after receiving the response in it's entirety. The connection will automatically clear the checkpoint when used for communication. A call to this method indicates that the next checkpoint has been reached. <br></br> A reusable communication state is necessary but not sufficient for the connection to be reused. A route mismatch, the connection being closed, or other circumstances might prevent reuse. </para>        
				/// </summary>
				/// <java-name>
				/// markReusable
				/// </java-name>
				[Dot42.DexImport("markReusable", "()V", AccessFlags = 1)]
				public virtual void MarkReusable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Marks this connection as not being in a reusable state. This can be used immediately before releasing this connection to prevent it's reuse. Reasons for preventing reuse include error conditions and the evaluation of a reuse strategy. <br></br> <b>Note:</b> It is <b>not</b> necessary to call here before writing to or reading from this connection. Communication attempts will automatically unmark the state as non-reusable. It can then be switched back using markReusable. </para>        
				/// </summary>
				/// <java-name>
				/// unmarkReusable
				/// </java-name>
				[Dot42.DexImport("unmarkReusable", "()V", AccessFlags = 1)]
				public virtual void UnmarkReusable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether this connection is in a reusable communication state. See markReusable and unmarkReusable for details.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this connection is marked as being in a reusable communication state, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isMarkedReusable
				/// </java-name>
				[Dot42.DexImport("isMarkedReusable", "()Z", AccessFlags = 1)]
				public virtual bool IsMarkedReusable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the duration that this connection can remain idle before it is reused. The connection should not be used again if this time elapses. The idle duration must be reset after each request sent over this connection. The elapsed time starts counting when the connection is released, which is typically after the headers (and any response body, if present) is fully consumed. </para>        
				/// </summary>
				/// <java-name>
				/// setIdleDuration
				/// </java-name>
				[Dot42.DexImport("setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void SetIdleDuration(long duration, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
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
				public virtual void Open(global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void TunnelTarget(bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void TunnelProxy(global::Org.Apache.Http.HttpHost next, bool secure, global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public virtual void LayerProtocol(global::Org.Apache.Http.Protocol.IHttpContext context, global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/conn/ManagedClientConnection", "setState", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				public virtual void SetState(object state) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				/// <summary>
				/// <para>Returns the socket timeout value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>positive value in milliseconds if a timeout is set, <code>0</code> if timeout is disabled or <code>-1</code> if timeout is undefined. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns a collection of connection metrcis </para>        
				/// </summary>
				/// <returns>
				/// <para>HttpConnectionMetrics </para>
				/// </returns>
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

				/// <summary>
				/// <para>Obtains the SSL session of the underlying connection, if any. If this connection is open, and the underlying socket is an SSLSocket, the SSL session of that socket is obtained. This is a potentially blocking operation. <br></br> <b>Note:</b> Whether the underlying socket is an SSL socket can not necessarily be determined via isSecure. Plain sockets may be considered secure, for example if they are connected to a known host in the same network segment. On the other hand, SSL sockets may be considered insecure, for example depending on the chosen cipher suite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the underlying SSL session if available, <code>null</code> otherwise </para>
				/// </returns>
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

		/// <summary>
		/// <para>Logs all data read to the wire LOG.</para><para><para>Ortwin Glueck </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/LoggingSessionInputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/LoggingSessionInputBuffer", AccessFlags = 33)]
		public partial class LoggingSessionInputBuffer : global::Org.Apache.Http.Io.ISessionInputBuffer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create an instance that wraps the specified session input buffer. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/impl/conn/Wire;)V", AccessFlags = 1)]
				public LoggingSessionInputBuffer(global::Org.Apache.Http.Io.ISessionInputBuffer @in, global::Org.Apache.Http.Impl.Conn.Wire wire) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDataAvailable
				/// </java-name>
				[Dot42.DexImport("isDataAvailable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsDataAvailable(int timeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
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
				public virtual int Read(sbyte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] b) /* MethodBuilder.Create */ 
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
				public virtual int ReadLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>Logs all data written to the wire LOG.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/LoggingSessionOutputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/LoggingSessionOutputBuffer", AccessFlags = 33)]
		public partial class LoggingSessionOutputBuffer : global::Org.Apache.Http.Io.ISessionOutputBuffer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create an instance that wraps the specified session output buffer. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/impl/conn/Wire;)V", AccessFlags = 1)]
				public LoggingSessionOutputBuffer(global::Org.Apache.Http.Io.ISessionOutputBuffer @out, global::Org.Apache.Http.Impl.Conn.Wire wire) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] b) /* MethodBuilder.Create */ 
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
				public virtual void WriteLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteLine(string buffer) /* MethodBuilder.Create */ 
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

}


