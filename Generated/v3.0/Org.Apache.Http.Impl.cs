// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.cs
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
namespace Org.Apache.Http.Impl
{
		/// <summary>
		/// <para>Implementation of the metrics interface. </para>    
		/// </summary>
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
				public HttpConnectionMetricsImpl(global::Org.Apache.Http.Io.IHttpTransportMetrics inTransportMetric, global::Org.Apache.Http.Io.IHttpTransportMetrics outTransportMetric) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of bytes transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getReceivedBytesCount
				/// </java-name>
				[Dot42.DexImport("getReceivedBytesCount", "()J", AccessFlags = 1)]
				public virtual long GetReceivedBytesCount() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the number of bytes transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getSentBytesCount
				/// </java-name>
				[Dot42.DexImport("getSentBytesCount", "()J", AccessFlags = 1)]
				public virtual long GetSentBytesCount() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the number of requests transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getRequestCount
				/// </java-name>
				[Dot42.DexImport("getRequestCount", "()J", AccessFlags = 1)]
				public virtual long GetRequestCount() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// incrementRequestCount
				/// </java-name>
				[Dot42.DexImport("incrementRequestCount", "()V", AccessFlags = 1)]
				public virtual void IncrementRequestCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of responses transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getResponseCount
				/// </java-name>
				[Dot42.DexImport("getResponseCount", "()J", AccessFlags = 1)]
				public virtual long GetResponseCount() /* MethodBuilder.Create */ 
				{
						return default(long);
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
				public virtual object GetMetric(string metricName) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setMetric
				/// </java-name>
				[Dot42.DexImport("setMetric", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetMetric(string metricName, object obj) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resets the counts </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpConnectionMetricsImpl() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of bytes transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getReceivedBytesCount
				/// </java-name>
				public long ReceivedBytesCount
				{
				[Dot42.DexImport("getReceivedBytesCount", "()J", AccessFlags = 1)]
						get{ return GetReceivedBytesCount(); }
				}

				/// <summary>
				/// <para>Returns the number of bytes transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getSentBytesCount
				/// </java-name>
				public long SentBytesCount
				{
				[Dot42.DexImport("getSentBytesCount", "()J", AccessFlags = 1)]
						get{ return GetSentBytesCount(); }
				}

				/// <summary>
				/// <para>Returns the number of requests transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getRequestCount
				/// </java-name>
				public long RequestCount
				{
				[Dot42.DexImport("getRequestCount", "()J", AccessFlags = 1)]
						get{ return GetRequestCount(); }
				}

				/// <summary>
				/// <para>Returns the number of responses transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getResponseCount
				/// </java-name>
				public long ResponseCount
				{
				[Dot42.DexImport("getResponseCount", "()J", AccessFlags = 1)]
						get{ return GetResponseCount(); }
				}

		}

		/// <summary>
		/// <para>Default implementation of a client-side HTTP connection.</para><para><para></para><para></para><title>Revision:</title><para>561083 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public new virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>Implementation of a client-side HTTP connection that can be bound to a network Socket in order to receive and transmit data.</para><para><para></para><para></para><title>Revision:</title><para>561083 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				protected internal virtual global::Org.Apache.Http.Io.ISessionInputBuffer CreateSessionInputBuffer(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionInputBuffer);
				}

				/// <java-name>
				/// createSessionOutputBuffer
				/// </java-name>
				[Dot42.DexImport("createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nOutputBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.ISessionOutputBuffer CreateSessionOutputBuffer(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionOutputBuffer);
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
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
				public override bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.Socket GetSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
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
				/// <para>Sets the socket timeout value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketTimeout
				/// </java-name>
				[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
				public override void SetSocketTimeout(int timeout) /* MethodBuilder.Create */ 
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
				public override int GetSocketTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// <para>Closes this connection gracefully. This method will attempt to flush the transmitter's internal buffer prior to closing the underlying socket. This method MUST NOT be called from a different thread to force shutdown of the connection. Use shutdown instead. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "isStale", "()Z", AccessFlags = 1025)]
				public override bool IsStale() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHttpConnectionMetrics GetMetrics() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHttpConnectionMetrics);
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				protected internal global::Java.Net.Socket Socket
				{
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 4)]
						get{ return GetSocket(); }
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

				public global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
				[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
						get{ return GetMetrics(); }
				}

		}

		/// <summary>
		/// <para>Abstract server-side HTTP connection capable of transmitting and receiving data using arbitrary SessionInputBuffer and SessionOutputBuffer</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageParser CreateRequestParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.IHttpRequestFactory requestFactory, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageParser);
				}

				/// <java-name>
				/// createResponseWriter
				/// </java-name>
				[Dot42.DexImport("createResponseWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg" +
    "/apache/http/io/HttpMessageWriter;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageWriter CreateResponseWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer buffer, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageWriter);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Org.Apache.Http.Io.ISessionInputBuffer inbuffer, global::Org.Apache.Http.Io.ISessionOutputBuffer outbuffer, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receives the request line and all headers available from this connection. The caller should examine the returned request and decide if to receive a request entity as well.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new HttpRequest object whose request line and headers are initialized. </para>
				/// </returns>
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
				public virtual void ReceiveRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFlush
				/// </java-name>
				[Dot42.DexImport("doFlush", "()V", AccessFlags = 4)]
				protected internal virtual void DoFlush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sends all pending buffered data over this connection. </para>        
				/// </summary>
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
				public virtual void SendResponseHeader(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendResponseEntity
				/// </java-name>
				[Dot42.DexImport("sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void SendResponseEntity(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
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

				[Dot42.DexImport("org/apache/http/HttpConnection", "close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "isOpen", "()Z", AccessFlags = 1025)]
				public virtual bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
				public virtual void SetSocketTimeout(int timeout) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
				public virtual int GetSocketTimeout() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "shutdown", "()V", AccessFlags = 1025)]
				public virtual void Shutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
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

				public int SocketTimeout
				{
				[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
						get{ return GetSocketTimeout(); }
				[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
						set{ SetSocketTimeout(value); }
				}

		}

		/// <summary>
		/// <para>A strategy that never re-uses a connection.</para><para><para></para><para></para><title>Revision:</title><para>502684 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual bool KeepAlive(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>English reason phrases for HTTP status codes. All status codes defined in RFC1945 (HTTP/1.0), RFC2616 (HTTP/1.1), and RFC2518 (WebDAV) are supported.</para><para><para>Unascribed </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>505744 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/EnglishReasonPhraseCatalog
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/EnglishReasonPhraseCatalog", AccessFlags = 33)]
		public partial class EnglishReasonPhraseCatalog : global::Org.Apache.Http.IReasonPhraseCatalog
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default instance of this catalog. This catalog is thread safe, so there typically is no need to create other instances. </para>        
				/// </summary>
				/// <java-name>
				/// INSTANCE
				/// </java-name>
				[Dot42.DexImport("INSTANCE", "Lorg/apache/http/impl/EnglishReasonPhraseCatalog;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Impl.EnglishReasonPhraseCatalog INSTANCE;
				/// <summary>
				/// <para>Restricted default constructor, for derived classes. If you need an instance of this class, use INSTANCE. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal EnglishReasonPhraseCatalog() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the reason phrase for a status code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reason phrase, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "(ILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReason(int status, global::Java.Util.Locale loc) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Abstract client-side HTTP connection capable of transmitting and receiving data using arbitrary SessionInputBuffer and SessionOutputBuffer</para><para><para></para><para></para><title>Revision:</title><para>627457 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageParser CreateResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.IHttpResponseFactory responseFactory, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageParser);
				}

				/// <java-name>
				/// createRequestWriter
				/// </java-name>
				[Dot42.DexImport("createRequestWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg" +
    "/apache/http/io/HttpMessageWriter;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.IHttpMessageWriter CreateRequestWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer buffer, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpMessageWriter);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Org.Apache.Http.Io.ISessionInputBuffer inbuffer, global::Org.Apache.Http.Io.ISessionOutputBuffer outbuffer, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestHeader(global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendRequestEntity
				/// </java-name>
				[Dot42.DexImport("sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1)]
				public virtual void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFlush
				/// </java-name>
				[Dot42.DexImport("doFlush", "()V", AccessFlags = 4)]
				protected internal virtual void DoFlush() /* MethodBuilder.Create */ 
				{
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

				/// <java-name>
				/// receiveResponseEntity
				/// </java-name>
				[Dot42.DexImport("receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1)]
				public virtual void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ 
				{
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

				[Dot42.DexImport("org/apache/http/HttpConnection", "close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "isOpen", "()Z", AccessFlags = 1025)]
				public virtual bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
				public virtual void SetSocketTimeout(int timeout) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
				public virtual int GetSocketTimeout() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "shutdown", "()V", AccessFlags = 1025)]
				public virtual void Shutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
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

				public int SocketTimeout
				{
				[Dot42.DexImport("org/apache/http/HttpConnection", "getSocketTimeout", "()I", AccessFlags = 1025)]
						get{ return GetSocketTimeout(); }
				[Dot42.DexImport("org/apache/http/HttpConnection", "setSocketTimeout", "(I)V", AccessFlags = 1025)]
						set{ SetSocketTimeout(value); }
				}

		}

		/// <summary>
		/// <para>Default implementation of a factory for creating request objects.</para><para><para></para><para></para><title>Revision:</title><para>618367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.IHttpRequest NewHttpRequest(global::Org.Apache.Http.IRequestLine requestline) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpRequest NewHttpRequest(string method, string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpRequest);
				}

		}

		/// <summary>
		/// <para>Implementation of a server-side HTTP connection that can be bound to a network Socket in order to receive and transmit data.</para><para><para></para><para></para><title>Revision:</title><para>561083 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				protected internal virtual global::Org.Apache.Http.Io.ISessionInputBuffer CreateHttpDataReceiver(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionInputBuffer);
				}

				/// <java-name>
				/// createHttpDataTransmitter
				/// </java-name>
				[Dot42.DexImport("createHttpDataTransmitter", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/Sessio" +
    "nOutputBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Io.ISessionOutputBuffer CreateHttpDataTransmitter(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.ISessionOutputBuffer);
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.Socket GetSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
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
				public override bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// <para>Sets the socket timeout value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketTimeout
				/// </java-name>
				[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1)]
				public override void SetSocketTimeout(int timeout) /* MethodBuilder.Create */ 
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
				public override int GetSocketTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// <para>Closes this connection gracefully. This method will attempt to flush the transmitter's internal buffer prior to closing the underlying socket. This method MUST NOT be called from a different thread to force shutdown of the connection. Use shutdown instead. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "isStale", "()Z", AccessFlags = 1025)]
				public override bool IsStale() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHttpConnectionMetrics GetMetrics() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHttpConnectionMetrics);
				}

				/// <java-name>
				/// getSocket
				/// </java-name>
				protected internal global::Java.Net.Socket Socket
				{
				[Dot42.DexImport("getSocket", "()Ljava/net/Socket;", AccessFlags = 4)]
						get{ return GetSocket(); }
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

				public global::Org.Apache.Http.IHttpConnectionMetrics Metrics
				{
				[Dot42.DexImport("org/apache/http/HttpConnection", "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
						get{ return GetMetrics(); }
				}

		}

		/// <summary>
		/// <para>Default implementation of a server-side HTTP connection.</para><para><para></para><para></para><title>Revision:</title><para>561083 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public new virtual void Bind(global::Java.Net.Socket socket, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>Default implementation of a strategy deciding about connection re-use. The default implementation first checks some basics, for example whether the connection is still open or whether the end of the request entity can be determined without closing the connection. If these checks pass, the tokens in the "Connection" header will be examined. In the absence of a "Connection" header, the non-standard but commonly used "Proxy-Connection" header takes it's role. A token "close" indicates that the connection cannot be reused. If there is no such token, a token "keep-alive" indicates that the connection should be re-used. If neither token is found, or if there are no "Connection" headers, the default policy for the HTTP version is applied. Since HTTP/1.1, connections are re-used by default. Up until HTTP/1.0, connections are not re-used by default.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>602537 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual bool KeepAlive(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Creates a token iterator from a header iterator. This method can be overridden to replace the implementation of the token iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the token iterator </para>
				/// </returns>
				/// <java-name>
				/// createTokenIterator
				/// </java-name>
				[Dot42.DexImport("createTokenIterator", "(Lorg/apache/http/HeaderIterator;)Lorg/apache/http/TokenIterator;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.ITokenIterator CreateTokenIterator(global::Org.Apache.Http.IHeaderIterator hit) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ITokenIterator);
				}

		}

		/// <summary>
		/// <para>Default implementation of a factory for creating response objects.</para><para><para></para><para></para><title>Revision:</title><para>618367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/DefaultHttpResponseFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/DefaultHttpResponseFactory", AccessFlags = 33)]
		public partial class DefaultHttpResponseFactory : global::Org.Apache.Http.IHttpResponseFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The catalog for looking up reason phrases. </para>        
				/// </summary>
				/// <java-name>
				/// reasonCatalog
				/// </java-name>
				[Dot42.DexImport("reasonCatalog", "Lorg/apache/http/ReasonPhraseCatalog;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IReasonPhraseCatalog ReasonCatalog;
				/// <summary>
				/// <para>Creates a new response factory with the given catalog.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ReasonPhraseCatalog;)V", AccessFlags = 1)]
				public DefaultHttpResponseFactory(global::Org.Apache.Http.IReasonPhraseCatalog catalog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new response factory with the default catalog. The default catalog is EnglishReasonPhraseCatalog. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHttpResponseFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/ap" +
    "ache/http/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.ProtocolVersion ver, int status, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/h" +
    "ttp/HttpResponse;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.IStatusLine statusline, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpResponse);
				}

				/// <summary>
				/// <para>Determines the locale of the response. The implementation in this class always returns the default locale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale for the response, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// determineLocale
				/// </java-name>
				[Dot42.DexImport("determineLocale", "(Lorg/apache/http/protocol/HttpContext;)Ljava/util/Locale;", AccessFlags = 4)]
				protected internal virtual global::Java.Util.Locale DetermineLocale(global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

		}

}


