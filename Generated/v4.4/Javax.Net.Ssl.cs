// Copyright (C) 2014 dot42
//
// Original filename: Javax.Net.Ssl.cs
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
namespace Javax.Net.Ssl
{
		/// <summary>
		/// <para>The <b>Service Provider Interface</b> (SPI) for the <c> SSLContext </c> class. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLContextSpi
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLContextSpi", AccessFlags = 1057)]
		public abstract partial class SSLContextSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLContextSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SSLContextSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> SSLContext </c> instance. All of the arguments are optional, and the security providers will be searched for the required implementations of the needed algorithms.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRan" +
    "dom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Javax.Net.Ssl.IKeyManager[] km, global::Javax.Net.Ssl.ITrustManager[] tm, global::Java.Security.SecureRandom sr) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a socket factory for this instance. </para>
				/// </returns>
				/// <java-name>
				/// engineGetSocketFactory
				/// </java-name>
				[Dot42.DexImport("engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLSocketFactory EngineGetSocketFactory() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a server socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a server socket factory for this instance. </para>
				/// </returns>
				/// <java-name>
				/// engineGetServerSocketFactory
				/// </java-name>
				[Dot42.DexImport("engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLServerSocketFactory EngineGetServerSocketFactory() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates an <c> SSLEngine </c> instance from this context with the specified hostname and port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> SSLEngine </c> instance from this context. </para>
				/// </returns>
				/// <java-name>
				/// engineCreateSSLEngine
				/// </java-name>
				[Dot42.DexImport("engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLEngine EngineCreateSSLEngine(string host, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates an <c> SSLEngine </c> instance from this context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> SSLEngine </c> instance from this context. </para>
				/// </returns>
				/// <java-name>
				/// engineCreateSSLEngine
				/// </java-name>
				[Dot42.DexImport("engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.SSLEngine EngineCreateSSLEngine() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the SSL session context that encapsulates the set of SSL sessions that can be used for the server side of the SSL handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL server session context for this context or <c> null </c> if the underlying provider does not provide an implementation of the <c> SSLSessionContext </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// engineGetServerSessionContext
				/// </java-name>
				[Dot42.DexImport("engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.ISSLSessionContext EngineGetServerSessionContext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the SSL session context that encapsulates the set of SSL sessions that can be used for the client side of the SSL handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL client session context for this context or <c> null </c> if the underlying provider does not provide an implementation of the <c> SSLSessionContext </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// engineGetClientSessionContext
				/// </java-name>
				[Dot42.DexImport("engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.ISSLSessionContext EngineGetClientSessionContext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new SSLParameters instance that includes the default SSL handshake parameters values including cipher suites, protocols, and client authentication.</para><para>The default implementation returns an SSLParameters with values based an SSLSocket created from this instances SocketFactory.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// engineGetDefaultSSLParameters
				/// </java-name>
				[Dot42.DexImport("engineGetDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 4)]
				protected internal virtual global::Javax.Net.Ssl.SSLParameters EngineGetDefaultSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <summary>
				/// <para>Returns a new SSLParameters instance that includes all supported cipher suites and protocols.</para><para>The default implementation returns an SSLParameters with values based an SSLSocket created from this instances SocketFactory.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// engineGetSupportedSSLParameters
				/// </java-name>
				[Dot42.DexImport("engineGetSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 4)]
				protected internal virtual global::Javax.Net.Ssl.SSLParameters EngineGetSupportedSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

		}

		/// <summary>
		/// <para>The abstract factory implementation to create <c> SSLSocket </c> s. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLSocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSocketFactory", AccessFlags = 1057)]
		public abstract partial class SSLSocketFactory : global::Javax.Net.SocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLSocketFactory </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SSLSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default <c> SSLSocketFactory </c> instance. The default is defined by the security property <c> 'ssl.SocketFactory.provider' </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default ssl socket factory instance. </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
				public static global::Javax.Net.SocketFactory GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.SocketFactory);
				}

				/// <summary>
				/// <para>Returns the names of the cipher suites that are enabled by default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the cipher suites that are enabled by default. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetDefaultCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the cipher suites that are supported and could be enabled for an SSL connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the cipher suites that are supported. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates an <c> SSLSocket </c> over the specified socket that is connected to the specified host at the specified port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the creates ssl socket. </para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(global::Java.Net.Socket s, string host, int port, bool autoClose) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the default <c> SSLSocketFactory </c> instance. The default is defined by the security property <c> 'ssl.SocketFactory.provider' </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default ssl socket factory instance. </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.SocketFactory Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
						get{ return GetDefault(); }
				}

				/// <summary>
				/// <para>Returns the names of the cipher suites that are enabled by default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the cipher suites that are enabled by default. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				public string[] DefaultCipherSuites
				{
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetDefaultCipherSuites(); }
				}

				/// <summary>
				/// <para>Returns the names of the cipher suites that are supported and could be enabled for an SSL connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the cipher suites that are supported. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when the identity of a peer has not been verified. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLPeerUnverifiedException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLPeerUnverifiedException", AccessFlags = 33)]
		public partial class SSLPeerUnverifiedException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLPeerUnverifiedException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLPeerUnverifiedException(string reason) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLPeerUnverifiedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The event object encapsulating the information about a completed SSL handshake on a SSL connection. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/HandshakeCompletedEvent
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HandshakeCompletedEvent", AccessFlags = 33)]
		public partial class HandshakeCompletedEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> HandshakeCompletedEvent </c> with the specified SSL socket and SSL session.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLSocket;Ljavax/net/ssl/SSLSession;)V", AccessFlags = 1)]
				public HandshakeCompletedEvent(global::Javax.Net.Ssl.SSLSocket sock, global::Javax.Net.Ssl.ISSLSession s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the SSL session associated with this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL session associated with this event. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSession);
				}

				/// <summary>
				/// <para>Returns the name of the cipher suite negotiated during this handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the cipher suite negotiated during this handshake. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCipherSuite() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the list of local certificates used during the handshake. These certificates were sent to the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the list of certificates used during the handshake with the local identity certificate followed by CAs, or <c> null </c> if no certificates were used during the handshake. </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetLocalCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <summary>
				/// <para>Return the list of certificates identifying the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates identifying the peer with the peer's identity certificate followed by CAs. </para>
				/// </returns>
				/// <java-name>
				/// getPeerCertificates
				/// </java-name>
				[Dot42.DexImport("getPeerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetPeerCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <summary>
				/// <para>Returns the list of certificates identifying the peer. The peer's identity certificate is followed by the validated certificate authority certificates. </para><para><b>Replaced by:</b> getPeerCertificates()</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates identifying the peer </para>
				/// </returns>
				/// <java-name>
				/// getPeerCertificateChain
				/// </java-name>
				[Dot42.DexImport("getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", AccessFlags = 1)]
				public virtual global::Javax.Security.Cert.X509Certificate[] GetPeerCertificateChain() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate[]);
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> identifying the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> identifying the peer. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> used to identify during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> used to identify during the handshake. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <summary>
				/// <para>Returns the SSL socket that produced this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL socket that produced this event. </para>
				/// </returns>
				/// <java-name>
				/// getSocket
				/// </java-name>
				[Dot42.DexImport("getSocket", "()Ljavax/net/ssl/SSLSocket;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLSocket GetSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocket);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HandshakeCompletedEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the SSL session associated with this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL session associated with this event. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
						get{ return GetSession(); }
				}

				/// <summary>
				/// <para>Returns the name of the cipher suite negotiated during this handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the cipher suite negotiated during this handshake. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				public string CipherSuite
				{
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCipherSuite(); }
				}

				/// <summary>
				/// <para>Returns the list of local certificates used during the handshake. These certificates were sent to the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the list of certificates used during the handshake with the local identity certificate followed by CAs, or <c> null </c> if no certificates were used during the handshake. </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] LocalCertificates
				{
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetLocalCertificates(); }
				}

				/// <summary>
				/// <para>Return the list of certificates identifying the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates identifying the peer with the peer's identity certificate followed by CAs. </para>
				/// </returns>
				/// <java-name>
				/// getPeerCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] PeerCertificates
				{
				[Dot42.DexImport("getPeerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetPeerCertificates(); }
				}

				/// <summary>
				/// <para>Returns the list of certificates identifying the peer. The peer's identity certificate is followed by the validated certificate authority certificates. </para><para><b>Replaced by:</b> getPeerCertificates()</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates identifying the peer </para>
				/// </returns>
				/// <java-name>
				/// getPeerCertificateChain
				/// </java-name>
				public global::Javax.Security.Cert.X509Certificate[] PeerCertificateChain
				{
				[Dot42.DexImport("getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", AccessFlags = 1)]
						get{ return GetPeerCertificateChain(); }
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> identifying the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> identifying the peer. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal PeerPrincipal
				{
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetPeerPrincipal(); }
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> used to identify during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> used to identify during the handshake. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal LocalPrincipal
				{
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetLocalPrincipal(); }
				}

				/// <summary>
				/// <para>Returns the SSL socket that produced this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL socket that produced this event. </para>
				/// </returns>
				/// <java-name>
				/// getSocket
				/// </java-name>
				public global::Javax.Net.Ssl.SSLSocket Socket
				{
				[Dot42.DexImport("getSocket", "()Ljavax/net/ssl/SSLSocket;", AccessFlags = 1)]
						get{ return GetSocket(); }
				}

		}

		/// <summary>
		/// <para>The abstract implementation of secure communications using SSL, TLS, or other protocols. It includes the setup, handshake, and encrypt/decrypt functionality needed to create a secure connection.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLEngine
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLEngine", AccessFlags = 1057)]
		public abstract partial class SSLEngine
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLEngine </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLEngine() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> SSLEngine </c> instance with the specified host and port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal SSLEngine(string host, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the peer host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the peer host, or <c> null </c> if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPeerHost
				/// </java-name>
				[Dot42.DexImport("getPeerHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPeerHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the port number of the peer host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port number of the peer host, or <c> -1 </c> is none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPort
				/// </java-name>
				[Dot42.DexImport("getPeerPort", "()I", AccessFlags = 1)]
				public virtual int GetPeerPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Initiates a handshake on this engine. </para><para>Calling this method is not needed for the initial handshake: it will be called by <c> wrap </c> or <c> unwrap </c> if the initial handshake has not been started yet.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// beginHandshake
				/// </java-name>
				[Dot42.DexImport("beginHandshake", "()V", AccessFlags = 1025)]
				public abstract void BeginHandshake() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies this engine instance that no more inbound network data will be sent to this engine.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// closeInbound
				/// </java-name>
				[Dot42.DexImport("closeInbound", "()V", AccessFlags = 1025)]
				public abstract void CloseInbound() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies this engine instance that no more outbound application data will be sent to this engine. </para>        
				/// </summary>
				/// <java-name>
				/// closeOutbound
				/// </java-name>
				[Dot42.DexImport("closeOutbound", "()V", AccessFlags = 1025)]
				public abstract void CloseOutbound() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a delegate task for this engine instance. Some engine operations may require the results of blocking or long running operations, and the <c> SSLEngineResult </c> instances returned by this engine may indicate that a delegated task result is needed. In this case the run method of the returned <c> Runnable </c> delegated task must be called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a delegate task, or <c> null </c> if none are available. </para>
				/// </returns>
				/// <java-name>
				/// getDelegatedTask
				/// </java-name>
				[Dot42.DexImport("getDelegatedTask", "()Ljava/lang/Runnable;", AccessFlags = 1025)]
				public abstract global::Java.Lang.IRunnable GetDelegatedTask() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the SSL cipher suite names that are enabled in this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL cipher suite names that are enabled in this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the protocol version names that are enabled in this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol version names that are enabled in this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledProtocols() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether new SSL sessions may be established by this engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new session may be established, <c> false </c> if existing sessions must be reused. </para>
				/// </returns>
				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
				public abstract bool GetEnableSessionCreation() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the status of the handshake of this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the status of the handshake of this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getHandshakeStatus
				/// </java-name>
				[Dot42.DexImport("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this engine instance will require client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this engine will require client authentication, <c> false </c> if no client authentication is needed. </para>
				/// </returns>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetNeedClientAuth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the SSL session for this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL session for this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the SSL cipher suite names that are supported by this engine. These cipher suites can be enabled using setEnabledCipherSuites(String[]).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL cipher suite names that are supported by this engine. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the protocol names that are supported by this engine. These protocols can be enables using setEnabledProtocols(String[]).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol names that are supported by this engine. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedProtocols() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this engine is set to act in client mode when handshaking.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the engine is set to do handshaking in client mode. </para>
				/// </returns>
				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
				public abstract bool GetUseClientMode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this engine will request client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if client authentication will be requested, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetWantClientAuth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether no more inbound data will be accepted by this engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if no more inbound data will be accepted by this engine, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInboundDone
				/// </java-name>
				[Dot42.DexImport("isInboundDone", "()Z", AccessFlags = 1025)]
				public abstract bool IsInboundDone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether no more outbound data will be produced by this engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if no more outbound data will be producted by this engine, <c> otherwise </c> false. </para>
				/// </returns>
				/// <java-name>
				/// isOutboundDone
				/// </java-name>
				[Dot42.DexImport("isOutboundDone", "()Z", AccessFlags = 1025)]
				public abstract bool IsOutboundDone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the SSL cipher suite names that should be enabled in this engine instance. Only cipher suites listed by <c> getSupportedCipherSuites() </c> are allowed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledCipherSuites(string[] suites) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the protocol version names that should be enabled in this engine instance. Only protocols listed by <c> getSupportedProtocols() </c> are allowed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledProtocols(string[] protocols) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether new SSL sessions may be established by this engine instance.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
				public abstract void SetEnableSessionCreation(bool flag) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether this engine must require client authentication. The client authentication is one of: <ul><li><para>authentication required </para></li><li><para>authentication requested </para></li><li><para>no authentication needed </para></li></ul>This method overrides the setting of setWantClientAuth(boolean).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetNeedClientAuth(bool need) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether this engine should act in client (or server) mode when handshaking.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUseClientMode
				/// </java-name>
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
				public abstract void SetUseClientMode(bool mode) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether this engine should request client authentication. The client authentication is one of the following: <ul><li><para>authentication required </para></li><li><para>authentication requested </para></li><li><para>no authentication needed </para></li></ul>This method overrides the setting of setNeedClientAuth(boolean).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetWantClientAuth(bool want) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Decodes the incoming network data buffer into application data buffers. If a handshake has not been started yet, it will automatically be started.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result object of this operation. </para>
				/// </returns>
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.SSLEngineResult Unwrap(global::Java.Nio.ByteBuffer src, global::Java.Nio.ByteBuffer[] dsts, int offset, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Encodes the outgoing application data buffers into the network data buffer. If a handshake has not been started yet, it will automatically be started.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result object of this operation. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.SSLEngineResult Wrap(global::Java.Nio.ByteBuffer[] srcs, int offset, int length, global::Java.Nio.ByteBuffer dst) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Decodes the incoming network data buffer into the application data buffer. If a handshake has not been started yet, it will automatically be started.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result object of this operation. </para>
				/// </returns>
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Unwrap(global::Java.Nio.ByteBuffer src, global::Java.Nio.ByteBuffer dst) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <summary>
				/// <para>Decodes the incoming network data buffer into the application data buffer. If a handshake has not been started yet, it will automatically be started.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result object of this operation. </para>
				/// </returns>
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Unwrap(global::Java.Nio.ByteBuffer src, global::Java.Nio.ByteBuffer[] dst) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <summary>
				/// <para>Encodes the outgoing application data buffers into the network data buffer. If a handshake has not been started yet, it will automatically be started.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result object of this operation. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Wrap(global::Java.Nio.ByteBuffer[] srcs, global::Java.Nio.ByteBuffer dst) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <summary>
				/// <para>Encodes the outgoing application data buffers into the network data buffer. If a handshake has not been started yet, it will automatically be started.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result object of this operation. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLEngineResult Wrap(global::Java.Nio.ByteBuffer srcs, global::Java.Nio.ByteBuffer dst) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult);
				}

				/// <summary>
				/// <para>Returns a new SSLParameters based on this SSLSocket's current cipher suites, protocols, and client authentication settings.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLParameters GetSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <summary>
				/// <para>Sets various SSL handshake parameters based on the SSLParameter argument. Specifically, sets the SSLEngine's enabled cipher suites if the parameter's cipher suites are non-null. Similarly sets the enabled protocols. If the parameters specify the want or need for client authentication, those requirements are set on the SSLEngine, otherwise both are set to false. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setSSLParameters
				/// </java-name>
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
				public virtual void SetSSLParameters(global::Javax.Net.Ssl.SSLParameters p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the peer host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the peer host, or <c> null </c> if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPeerHost
				/// </java-name>
				public string PeerHost
				{
				[Dot42.DexImport("getPeerHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPeerHost(); }
				}

				/// <summary>
				/// <para>Returns the port number of the peer host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port number of the peer host, or <c> -1 </c> is none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPort
				/// </java-name>
				public int PeerPort
				{
				[Dot42.DexImport("getPeerPort", "()I", AccessFlags = 1)]
						get{ return GetPeerPort(); }
				}

				/// <summary>
				/// <para>Returns a delegate task for this engine instance. Some engine operations may require the results of blocking or long running operations, and the <c> SSLEngineResult </c> instances returned by this engine may indicate that a delegated task result is needed. In this case the run method of the returned <c> Runnable </c> delegated task must be called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a delegate task, or <c> null </c> if none are available. </para>
				/// </returns>
				/// <java-name>
				/// getDelegatedTask
				/// </java-name>
				public global::Java.Lang.IRunnable DelegatedTask
				{
				[Dot42.DexImport("getDelegatedTask", "()Ljava/lang/Runnable;", AccessFlags = 1025)]
						get{ return GetDelegatedTask(); }
				}

				/// <summary>
				/// <para>Returns the SSL cipher suite names that are enabled in this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL cipher suite names that are enabled in this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				public string[] EnabledCipherSuites
				{
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledCipherSuites(); }
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledCipherSuites(value); }
				}

				/// <summary>
				/// <para>Returns the protocol version names that are enabled in this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol version names that are enabled in this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				public string[] EnabledProtocols
				{
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledProtocols(); }
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledProtocols(value); }
				}

				/// <summary>
				/// <para>Returns whether new SSL sessions may be established by this engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new session may be established, <c> false </c> if existing sessions must be reused. </para>
				/// </returns>
				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				public bool IsEnableSessionCreation
				{
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
						get{ return GetEnableSessionCreation(); }
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
						set{ SetEnableSessionCreation(value); }
				}

				/// <summary>
				/// <para>Returns the status of the handshake of this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the status of the handshake of this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getHandshakeStatus
				/// </java-name>
				public global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus HandshakeStatus
				{
				[Dot42.DexImport("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 1025)]
						get{ return GetHandshakeStatus(); }
				}

				/// <summary>
				/// <para>Returns whether this engine instance will require client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this engine will require client authentication, <c> false </c> if no client authentication is needed. </para>
				/// </returns>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetNeedClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns the SSL session for this engine instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL session for this engine instance. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
						get{ return GetSession(); }
				}

				/// <summary>
				/// <para>Returns the SSL cipher suite names that are supported by this engine. These cipher suites can be enabled using setEnabledCipherSuites(String[]).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL cipher suite names that are supported by this engine. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

				/// <summary>
				/// <para>Returns the protocol names that are supported by this engine. These protocols can be enables using setEnabledProtocols(String[]).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol names that are supported by this engine. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				public string[] SupportedProtocols
				{
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedProtocols(); }
				}

				/// <summary>
				/// <para>Returns whether this engine is set to act in client mode when handshaking.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the engine is set to do handshaking in client mode. </para>
				/// </returns>
				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				public bool IsUseClientMode
				{
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
						get{ return GetUseClientMode(); }
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
						set{ SetUseClientMode(value); }
				}

				/// <summary>
				/// <para>Returns whether this engine will request client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if client authentication will be requested, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetWantClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns a new SSLParameters based on this SSLSocket's current cipher suites, protocols, and client authentication settings.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters SSLParameters
				{
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
						get{ return GetSSLParameters(); }
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
						set{ SetSSLParameters(value); }
				}

		}

		/// <summary>
		/// <para>Certification path parameters to provide to certification path based TrustManager.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/CertPathTrustManagerParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/CertPathTrustManagerParameters", AccessFlags = 33)]
		public partial class CertPathTrustManagerParameters : global::Javax.Net.Ssl.IManagerFactoryParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CertPathTrustManagerParameters </c> with the specified certification path parameters.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPathParameters;)V", AccessFlags = 1)]
				public CertPathTrustManagerParameters(global::Java.Security.Cert.ICertPathParameters parameters) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the certification path parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the certification path parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/security/cert/CertPathParameters;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.ICertPathParameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.ICertPathParameters);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertPathTrustManagerParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the certification path parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the certification path parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.Cert.ICertPathParameters Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/security/cert/CertPathParameters;", AccessFlags = 1)]
						get{ return GetParameters(); }
				}

		}

		/// <summary>
		/// <para>The interface to be used to provide hostname verification functionality. </para><para>This is an extended verification option that implementers can provide. It is to be used during a handshake if the URL's hostname does not match the peer's identification hostname. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/HostnameVerifier
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HostnameVerifier", AccessFlags = 1537)]
		public partial interface IHostnameVerifier
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Verifies that the specified hostname is allowed within the specified SSL session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified hostname is allowed, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", AccessFlags = 1025)]
				bool Verify(string hostname, global::Javax.Net.Ssl.ISSLSession session) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The extension of <c> Socket </c> providing secure protocols like SSL (Secure Sockets Layer) or TLS (Transport Layer Security). </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLSocket
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSocket", AccessFlags = 1057)]
		public abstract partial class SSLSocket : global::Java.Net.Socket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP socket. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP socket connection to the specified address at the specified port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal SSLSocket(string address, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP socket connection to the specified address at the specified port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal SSLSocket(global::Java.Net.InetAddress address, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP socket connection to the specified address at the specified port with the client side bound to the specified address and port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal SSLSocket(string address, int port, global::Java.Net.InetAddress clientAddress, int clientPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP socket connection to the specified address at the specified port with the client side bound to the specified address and port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal SSLSocket(global::Java.Net.InetAddress address, int port, global::Java.Net.InetAddress clientAddress, int clientPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unsupported for SSL because reading from an SSL socket may require writing to the network. </para>        
				/// </summary>
				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 1)]
				public override void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unsupported for SSL because writing to an SSL socket may require reading from the network. </para>        
				/// </summary>
				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 1)]
				public override void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the names of the supported cipher suites. </para>        
				/// </summary>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the enabled cipher suites. </para>        
				/// </summary>
				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the names of the cipher suites to be enabled. Only cipher suites returned by getSupportedCipherSuites() are allowed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledCipherSuites(string[] suites) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the supported protocols. </para>        
				/// </summary>
				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedProtocols() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the enabled protocols. </para>        
				/// </summary>
				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledProtocols() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the names of the protocols to be enabled. Only protocols returned by getSupportedProtocols() are allowed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledProtocols(string[] protocols) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> SSLSession </c> for this connection. If necessary, a handshake will be initiated, in which case this method will block until the handshake has been established. If the handshake fails, an invalid session object will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the session object. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				public abstract global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Registers the specified listener to receive notification on completion of a handshake on this connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addHandshakeCompletedListener
				/// </java-name>
				[Dot42.DexImport("addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", AccessFlags = 1025)]
				public abstract void AddHandshakeCompletedListener(global::Javax.Net.Ssl.IHandshakeCompletedListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the specified handshake completion listener.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeHandshakeCompletedListener
				/// </java-name>
				[Dot42.DexImport("removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", AccessFlags = 1025)]
				public abstract void RemoveHandshakeCompletedListener(global::Javax.Net.Ssl.IHandshakeCompletedListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Starts a new SSL handshake on this connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startHandshake
				/// </java-name>
				[Dot42.DexImport("startHandshake", "()V", AccessFlags = 1025)]
				public abstract void StartHandshake() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether this connection should act in client mode when handshaking.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUseClientMode
				/// </java-name>
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
				public abstract void SetUseClientMode(bool mode) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if this connection will act in client mode when handshaking. </para>        
				/// </summary>
				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
				public abstract bool GetUseClientMode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether the server should require client authentication. This does not apply to sockets in client mode. Client authentication is one of the following: <ul><li><para>authentication required </para></li><li><para>authentication requested </para></li><li><para>no authentication needed </para></li></ul>This method overrides the setting of setWantClientAuth(boolean). </para>        
				/// </summary>
				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetNeedClientAuth(bool need) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether the server should request client authentication. Unlike setNeedClientAuth this won't stop the negotiation if the client doesn't authenticate. This does not apply to sockets in client mode.The client authentication is one of: <ul><li><para>authentication required </para></li><li><para>authentication requested </para></li><li><para>no authentication needed </para></li></ul>This method overrides the setting of setNeedClientAuth(boolean). </para>        
				/// </summary>
				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetWantClientAuth(bool want) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the server socket should require client authentication. This does not apply to sockets in client mode. </para>        
				/// </summary>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetNeedClientAuth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the server should request client authentication. This does not apply to sockets in client mode. </para>        
				/// </summary>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetWantClientAuth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether new SSL sessions may be created by this socket or if existing sessions must be reused. If <c> flag </c> is false and there are no sessions to resume, handshaking will fail.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
				public abstract void SetEnableSessionCreation(bool flag) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether new SSL sessions may be created by this socket or if existing sessions must be reused.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new sessions may be created, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
				public abstract bool GetEnableSessionCreation() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new SSLParameters based on this SSLSocket's current cipher suites, protocols, and client authentication settings.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLParameters GetSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <summary>
				/// <para>Sets various SSL handshake parameters based on the SSLParameter argument. Specifically, sets the SSLSocket's enabled cipher suites if the parameter's cipher suites are non-null. Similarly sets the enabled protocols. If the parameters specify the want or need for client authentication, those requirements are set on the SSLSocket, otherwise both are set to false. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setSSLParameters
				/// </java-name>
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
				public virtual void SetSSLParameters(global::Javax.Net.Ssl.SSLParameters p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the names of the supported cipher suites. </para>        
				/// </summary>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

				/// <summary>
				/// <para>Returns the names of the enabled cipher suites. </para>        
				/// </summary>
				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				public string[] EnabledCipherSuites
				{
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledCipherSuites(); }
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledCipherSuites(value); }
				}

				/// <summary>
				/// <para>Returns the names of the supported protocols. </para>        
				/// </summary>
				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				public string[] SupportedProtocols
				{
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedProtocols(); }
				}

				/// <summary>
				/// <para>Returns the names of the enabled protocols. </para>        
				/// </summary>
				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				public string[] EnabledProtocols
				{
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledProtocols(); }
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledProtocols(value); }
				}

				/// <summary>
				/// <para>Returns the <c> SSLSession </c> for this connection. If necessary, a handshake will be initiated, in which case this method will block until the handshake has been established. If the handshake fails, an invalid session object will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the session object. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
						get{ return GetSession(); }
				}

				/// <summary>
				/// <para>Returns true if this connection will act in client mode when handshaking. </para>        
				/// </summary>
				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				public bool IsUseClientMode
				{
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
						get{ return GetUseClientMode(); }
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
						set{ SetUseClientMode(value); }
				}

				/// <summary>
				/// <para>Returns true if the server socket should require client authentication. This does not apply to sockets in client mode. </para>        
				/// </summary>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetNeedClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns true if the server should request client authentication. This does not apply to sockets in client mode. </para>        
				/// </summary>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetWantClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns whether new SSL sessions may be created by this socket or if existing sessions must be reused.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new sessions may be created, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				public bool IsEnableSessionCreation
				{
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
						get{ return GetEnableSessionCreation(); }
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
						set{ SetEnableSessionCreation(value); }
				}

				/// <summary>
				/// <para>Returns a new SSLParameters based on this SSLSocket's current cipher suites, protocols, and client authentication settings.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters SSLParameters
				{
				[Dot42.DexImport("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 1)]
						get{ return GetSSLParameters(); }
				[Dot42.DexImport("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", AccessFlags = 1)]
						set{ SetSSLParameters(value); }
				}

		}

		/// <summary>
		/// <para>This is the interface to implement in order to mark a class as a JSSE key managers so that key managers can be easily grouped. The key managers are responsible for handling the keys used to authenticate the local side to its peer, </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/KeyManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyManager", AccessFlags = 1537)]
		public partial interface IKeyManager
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>The exception that is thrown when a handshake could not be completed successfully. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLHandshakeException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLHandshakeException", AccessFlags = 33)]
		public partial class SSLHandshakeException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLHandshakeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLHandshakeException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A Key Manager for X509 certificate-based key pairs. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/X509KeyManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/X509KeyManager", AccessFlags = 1537)]
		public partial interface IX509KeyManager : global::Javax.Net.Ssl.IKeyManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Chooses an alias for the client side of an SSL connection to authenticate it with the specified public key type and certificate issuers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the alias name of a matching key or <c> null </c> if there are no matches. </para>
				/// </returns>
				/// <java-name>
				/// chooseClientAlias
				/// </java-name>
				[Dot42.DexImport("chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String" +
    ";", AccessFlags = 1025)]
				string ChooseClientAlias(string[] keyType, global::Java.Security.IPrincipal[] issuers, global::Java.Net.Socket socket) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Chooses an alias for the server side of an SSL connection to authenticate it with the specified public key type and certificate issuers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the alias name of a matching key or <c> null </c> if there are no matches. </para>
				/// </returns>
				/// <java-name>
				/// chooseServerAlias
				/// </java-name>
				[Dot42.DexImport("chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;" +
    "", AccessFlags = 1025)]
				string ChooseServerAlias(string keyType, global::Java.Security.IPrincipal[] issuers, global::Java.Net.Socket socket) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the certificate chain for the specified alias.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate chain for the specified alias, or <c> null </c> if the alias cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getCertificateChain
				/// </java-name>
				[Dot42.DexImport("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.X509Certificate[] GetCertificateChain(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the client aliases for the specified public key type and list of certificate issuers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the client aliases for the specified public key type, or <c> null </c> if there are no matching aliases. </para>
				/// </returns>
				/// <java-name>
				/// getClientAliases
				/// </java-name>
				[Dot42.DexImport("getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetClientAliases(string keyType, global::Java.Security.IPrincipal[] issuers) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the server aliases for the specified public key type and list of certificate issuers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the client aliases for the specified public key type, or <c> null </c> if there are no matching aliases. </para>
				/// </returns>
				/// <java-name>
				/// getServerAliases
				/// </java-name>
				[Dot42.DexImport("getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetServerAliases(string keyType, global::Java.Security.IPrincipal[] issuers) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the private key for the specified alias.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private key for the specified alias, or <c> null </c> if the alias cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				[Dot42.DexImport("getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", AccessFlags = 1025)]
				global::Java.Security.IPrivateKey GetPrivateKey(string alias) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface to be implemented by any object that requires notification when data objects are bound to (or unbound from) an <c> SSLSession </c> . </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLSessionBindingListener
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSessionBindingListener", AccessFlags = 1537)]
		public partial interface ISSLSessionBindingListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Notifies this listener when a value is bound to an <c> SSLSession </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// valueBound
				/// </java-name>
				[Dot42.DexImport("valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", AccessFlags = 1025)]
				void ValueBound(global::Javax.Net.Ssl.SSLSessionBindingEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies this listener when a value is unbound from an <c> SSLSession </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// valueUnbound
				/// </java-name>
				[Dot42.DexImport("valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", AccessFlags = 1025)]
				void ValueUnbound(global::Javax.Net.Ssl.SSLSessionBindingEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The parameters for <c> KeyManager </c> s. The parameters are a list of <c> KeyStore.Builder </c> s.</para><para><para>1.5 </para><para>KeyStore.Builder </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/KeyStoreBuilderParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyStoreBuilderParameters", AccessFlags = 33)]
		public partial class KeyStoreBuilderParameters : global::Javax.Net.Ssl.IManagerFactoryParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore$Builder;)V", AccessFlags = 1)]
				public KeyStoreBuilderParameters(global::Java.Security.KeyStore.Builder builder) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/security/KeyStore$Builder;>;)V")]
				public KeyStoreBuilderParameters(global::Java.Util.IList<global::Java.Security.KeyStore.Builder> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the unmodifiable list of <c> KeyStore.Builder </c> s associated with this parameters instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unmodifiable list of <c> KeyStore.Builder </c> s. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/KeyStore$Builder;>;")]
				public virtual global::Java.Util.IList<global::Java.Security.KeyStore.Builder> GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Security.KeyStore.Builder>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyStoreBuilderParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the unmodifiable list of <c> KeyStore.Builder </c> s associated with this parameters instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unmodifiable list of <c> KeyStore.Builder </c> s. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Util.IList<global::Java.Security.KeyStore.Builder> Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/KeyStore$Builder;>;")]
						get{ return GetParameters(); }
				}

		}

		/// <summary>
		/// <para>SSL handshake parameters that include protocols, cipher suites, and client authentication requirements. <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLParameters", AccessFlags = 33)]
		public partial class SSLParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default SSLParameters constructor. Cipher suites and protocols are initialized to null and client authentication options are initialized to false. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SSLParameters() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A SSLParameters constructor that allows the values for the initial cipher suites array to be provided. Other values default as specified in SSLParameters().</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLParameters(string[] cipherSuites) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A SSLParameters constructor that allows the values for initial cipher suites and protocols arrays to be provided. Other values default as specified in SSLParameters().</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLParameters(string[] cipherSuites, string[] protocols) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the cipher suites, or null if none have been specified. </para>        
				/// </summary>
				/// <java-name>
				/// getCipherSuites
				/// </java-name>
				[Dot42.DexImport("getCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetCipherSuites() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Sets the cipher suites to a copy of the input, or null </para>        
				/// </summary>
				/// <java-name>
				/// setCipherSuites
				/// </java-name>
				[Dot42.DexImport("setCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCipherSuites(string[] cipherSuites) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the protocols, or null if none have been specified. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocols
				/// </java-name>
				[Dot42.DexImport("getProtocols", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetProtocols() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Sets the protocols to a copy of the input, or null </para>        
				/// </summary>
				/// <java-name>
				/// setProtocols
				/// </java-name>
				[Dot42.DexImport("setProtocols", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProtocols(string[] protocols) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if a server requires authentication from a client during handshaking. If this returns true, getWantClientAuth will return false. </para>        
				/// </summary>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1)]
				public virtual bool GetNeedClientAuth() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether or not to a server needs client authentication. After calling this, getWantClientAuth() will return false. </para>        
				/// </summary>
				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1)]
				public virtual void SetNeedClientAuth(bool needClientAuth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if a server optionally wants to authenticate a client during handshaking. If this returns true, getNeedClientAuth will return false. </para>        
				/// </summary>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1)]
				public virtual bool GetWantClientAuth() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether or not to a server wants client authentication. After calling this, getNeedClientAuth() will return false. </para>        
				/// </summary>
				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1)]
				public virtual void SetWantClientAuth(bool wantClientAuth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the cipher suites, or null if none have been specified. </para>        
				/// </summary>
				/// <java-name>
				/// getCipherSuites
				/// </java-name>
				public string[] CipherSuites
				{
				[Dot42.DexImport("getCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCipherSuites(); }
				[Dot42.DexImport("setCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCipherSuites(value); }
				}

				/// <summary>
				/// <para>Returns a copy of the protocols, or null if none have been specified. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocols
				/// </java-name>
				public string[] Protocols
				{
				[Dot42.DexImport("getProtocols", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProtocols(); }
				[Dot42.DexImport("setProtocols", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetProtocols(value); }
				}

				/// <summary>
				/// <para>Returns true if a server requires authentication from a client during handshaking. If this returns true, getWantClientAuth will return false. </para>        
				/// </summary>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1)]
						set{ SetNeedClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns true if a server optionally wants to authenticate a client during handshaking. If this returns true, getNeedClientAuth will return false. </para>        
				/// </summary>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1)]
						set{ SetWantClientAuth(value); }
				}

		}

		/// <summary>
		/// <para>The <b>Service Provider Interface</b> (SPI) for the <c> TrustManagerFactory </c> class. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/TrustManagerFactorySpi
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/TrustManagerFactorySpi", AccessFlags = 1057)]
		public abstract partial class TrustManagerFactorySpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> TrustManagerFactorySpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TrustManagerFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this factory instance with the specified keystore as source of certificate authorities and trust material.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/KeyStore;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.KeyStore ks) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this factory instance with the specified keystore as source of certificate authorities and trust material.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Javax.Net.Ssl.IManagerFactoryParameters ks) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of <c> TrustManager </c> s with one entry for each type of trust material.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of <c> TrustManager </c> s </para>
				/// </returns>
				/// <java-name>
				/// engineGetTrustManagers
				/// </java-name>
				[Dot42.DexImport("engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.ITrustManager[] EngineGetTrustManagers() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The <b>Service Provider Interface</b> (SPI) for the <c> KeyManagerFactory </c> class. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/KeyManagerFactorySpi
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyManagerFactorySpi", AccessFlags = 1057)]
		public abstract partial class KeyManagerFactorySpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> KeyManagerFactorySpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyManagerFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this instance with the specified key store and password.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/KeyStore;[C)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.KeyStore ks, char[] password) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this instance with the specified factory parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Javax.Net.Ssl.IManagerFactoryParameters spec) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a list of key managers, one instance for each type of key in the key store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of key managers. </para>
				/// </returns>
				/// <java-name>
				/// engineGetKeyManagers
				/// </java-name>
				[Dot42.DexImport("engineGetKeyManagers", "()[Ljavax/net/ssl/KeyManager;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Net.Ssl.IKeyManager[] EngineGetKeyManagers() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A collection of <c> SSLSession </c> s. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLSessionContext
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSessionContext", AccessFlags = 1537)]
		public partial interface ISSLSessionContext
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns an iterable of all session identifiers in this session context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterable of all session identifiers in this session context. </para>
				/// </returns>
				/// <java-name>
				/// getIds
				/// </java-name>
				[Dot42.DexImport("getIds", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<[B>;")]
				global::Java.Util.IEnumeration<sbyte[]> GetIds() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the session for the specified session identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the session for the specified session identifier, or <c> null </c> if the specified session identifier does not refer to a session in this context. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "([B)Ljavax/net/ssl/SSLSession;", AccessFlags = 1025)]
				global::Javax.Net.Ssl.ISSLSession GetSession(sbyte[] sessionId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the size of the session cache for this session context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the session cache for this session context, or <c> zero </c> if unlimited. </para>
				/// </returns>
				/// <java-name>
				/// getSessionCacheSize
				/// </java-name>
				[Dot42.DexImport("getSessionCacheSize", "()I", AccessFlags = 1025)]
				int GetSessionCacheSize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the timeout for sessions in this session context. Sessions exceeding the timeout are invalidated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the timeout in seconds, or <c> zero </c> if unlimited. </para>
				/// </returns>
				/// <java-name>
				/// getSessionTimeout
				/// </java-name>
				[Dot42.DexImport("getSessionTimeout", "()I", AccessFlags = 1025)]
				int GetSessionTimeout() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the size of the session cache for this session context.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSessionCacheSize
				/// </java-name>
				[Dot42.DexImport("setSessionCacheSize", "(I)V", AccessFlags = 1025)]
				void SetSessionCacheSize(int size) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the timeout for sessions in this context. Sessions exceeding the timeout are invalidated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSessionTimeout
				/// </java-name>
				[Dot42.DexImport("setSessionTimeout", "(I)V", AccessFlags = 1025)]
				void SetSessionTimeout(int seconds) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The listener to be implemented to receive event notifications on completion of SSL handshake on an SSL connection. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/HandshakeCompletedListener
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HandshakeCompletedListener", AccessFlags = 1537)]
		public partial interface IHandshakeCompletedListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The callback method that is invoked when a SSL handshake is completed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// handshakeCompleted
				/// </java-name>
				[Dot42.DexImport("handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V", AccessFlags = 1025)]
				void HandshakeCompleted(global::Javax.Net.Ssl.HandshakeCompletedEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The marker interface for key manager factory parameters. Its purpose is to group key manager factory parameters objects.</para><para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/ManagerFactoryParameters
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/ManagerFactoryParameters", AccessFlags = 1537)]
		public partial interface IManagerFactoryParameters
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>The interface representing an SSL session. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLSession
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSession", AccessFlags = 1537)]
		public partial interface ISSLSession
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the maximum size that an application buffer can be for this session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum application buffer size. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationBufferSize
				/// </java-name>
				[Dot42.DexImport("getApplicationBufferSize", "()I", AccessFlags = 1025)]
				int GetApplicationBufferSize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of the cipher suite used in this session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the cipher suite used in this session. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCipherSuite() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the time this session was created, in milliseconds since midnight January 1st 1970 UTC.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time the session was created. </para>
				/// </returns>
				/// <java-name>
				/// getCreationTime
				/// </java-name>
				[Dot42.DexImport("getCreationTime", "()J", AccessFlags = 1025)]
				long GetCreationTime() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns this sessions identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this sessions identifier. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the time this session was last accessed, in milliseconds since midnight January 1st 1970 UTC.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time this session was last accessed. </para>
				/// </returns>
				/// <java-name>
				/// getLastAccessedTime
				/// </java-name>
				[Dot42.DexImport("getLastAccessedTime", "()J", AccessFlags = 1025)]
				long GetLastAccessedTime() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of certificates that were used to identify the local side to the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates, ordered from local certificate to CA's certificates. </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.Certificate[] GetLocalCertificates() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the principal used to identify the local side to the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the principal used to identify the local side. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the maximum size that a network buffer can be for this session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum network buffer size. </para>
				/// </returns>
				/// <java-name>
				/// getPacketBufferSize
				/// </java-name>
				[Dot42.DexImport("getPacketBufferSize", "()I", AccessFlags = 1025)]
				int GetPacketBufferSize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of certificates the peer used to identify itself during the handshake. </para><para>Note: this method exists for compatility reasons, use getPeerCertificates() instead.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates, ordered from the identity certificate to the CA's certificates </para>
				/// </returns>
				/// <java-name>
				/// getPeerCertificateChain
				/// </java-name>
				[Dot42.DexImport("getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", AccessFlags = 1025)]
				global::Javax.Security.Cert.X509Certificate[] GetPeerCertificateChain() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of certificates the peer used to identify itself during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates, ordered from the identity certificate to the CA's certificates. </para>
				/// </returns>
				/// <java-name>
				/// getPeerCertificates
				/// </java-name>
				[Dot42.DexImport("getPeerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.Certificate[] GetPeerCertificates() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the host name of the peer of this session. The host name is not authenticated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host name of the peer of this session, or <c> null </c> if no host name is available. </para>
				/// </returns>
				/// <java-name>
				/// getPeerHost
				/// </java-name>
				[Dot42.DexImport("getPeerHost", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPeerHost() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the port number of the peer of this session. The port number is not authenticated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port number of the peer, of <c> -1 </c> is no port number is available. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPort
				/// </java-name>
				[Dot42.DexImport("getPeerPort", "()I", AccessFlags = 1025)]
				int GetPeerPort() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the principal identifying the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the principal identifying the peer. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the protocol name that is used for all connections in this session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol name that is used for all connections in this session. </para>
				/// </returns>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetProtocol() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the context of this session, or null if no context is available. </para>        
				/// </summary>
				/// <java-name>
				/// getSessionContext
				/// </java-name>
				[Dot42.DexImport("getSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 1025)]
				global::Javax.Net.Ssl.ISSLSessionContext GetSessionContext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the object bound to the specified name in this session's application layer data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value bound to the specified name, or <c> null </c> if the specified name does not exist or is not accessible in the current access control context. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetValue(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of the object names bound to this session's application layer data.. </para><para>Depending on the current access control context, the list of object names may be different.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of the object names bound to this session's application layer data. </para>
				/// </returns>
				/// <java-name>
				/// getValueNames
				/// </java-name>
				[Dot42.DexImport("getValueNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetValueNames() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Invalidates this session. </para><para>No new connections can be created, but any existing connection remains valid until it is closed. </para>        
				/// </summary>
				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1025)]
				void Invalidate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this session is valid.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this session is valid, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				bool IsValid() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Binds the specified object under the specified name in this session's application layer data. </para><para>For bindings (new or existing) implementing the <c> SSLSessionBindingListener </c> interface the object will be notified.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putValue
				/// </java-name>
				[Dot42.DexImport("putValue", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void PutValue(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the binding for the specified name in this session's application layer data. If the existing binding implements the <c> SSLSessionBindingListener </c> interface the object will be notified.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeValue
				/// </java-name>
				[Dot42.DexImport("removeValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveValue(string name) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The factory for SSL server sockets. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLServerSocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLServerSocketFactory", AccessFlags = 1057)]
		public abstract partial class SSLServerSocketFactory : global::Javax.Net.ServerSocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLServerSocketFactory </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLServerSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default <c> SSLServerSocketFactory </c> instance. The default implementation is defined by the security property "ssl.ServerSocketFactory.provider".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default <c> SSLServerSocketFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
				public static global::Javax.Net.ServerSocketFactory GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.ServerSocketFactory);
				}

				/// <summary>
				/// <para>Returns the names of the cipher suites that are enabled by default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the cipher suites that are enabled by default </para>
				/// </returns>
				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetDefaultCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of supported cipher suites that could be enabled for an SSL connection created by this factory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of supported cipher suites </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the default <c> SSLServerSocketFactory </c> instance. The default implementation is defined by the security property "ssl.ServerSocketFactory.provider".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default <c> SSLServerSocketFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.ServerSocketFactory Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
						get{ return GetDefault(); }
				}

				/// <summary>
				/// <para>Returns the names of the cipher suites that are enabled by default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the cipher suites that are enabled by default </para>
				/// </returns>
				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				public string[] DefaultCipherSuites
				{
				[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetDefaultCipherSuites(); }
				}

				/// <summary>
				/// <para>Returns the list of supported cipher suites that could be enabled for an SSL connection created by this factory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of supported cipher suites </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

		}

		/// <summary>
		/// <para>The public API for <c> KeyManagerFactory </c> implementations. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/KeyManagerFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/KeyManagerFactory", AccessFlags = 33)]
		public partial class KeyManagerFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> KeyManagerFactory </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/KeyManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V" +
    "", AccessFlags = 4)]
				protected internal KeyManagerFactory(global::Javax.Net.Ssl.KeyManagerFactorySpi factorySpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default key manager factory algorithm name. </para><para>The default algorithm name is specified by the security property: <c> 'ssl.KeyManagerFactory.algorithm' </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
				public static string GetDefaultAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new <c> KeyManagerFactory </c> instance for the specified key management algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a key manager factory for the requested algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.KeyManagerFactory GetInstance(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.KeyManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.KeyManagerFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.KeyManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/KeyManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.KeyManagerFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.KeyManagerFactory);
				}

				/// <summary>
				/// <para>Returns the name of the key management algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the key management algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider for this <c> KeyManagerFactory </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> KeyManagerFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Initializes this instance with the specified key store and password.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/KeyStore;[C)V", AccessFlags = 17)]
				public void Init(global::Java.Security.KeyStore ks, char[] password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this instance with the specified factory parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 17)]
				public void Init(global::Javax.Net.Ssl.IManagerFactoryParameters spec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a list of key managers, one instance for each type of key in the key store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of key managers. </para>
				/// </returns>
				/// <java-name>
				/// getKeyManagers
				/// </java-name>
				[Dot42.DexImport("getKeyManagers", "()[Ljavax/net/ssl/KeyManager;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.IKeyManager[] GetKeyManagers() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.IKeyManager[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyManagerFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the default key manager factory algorithm name. </para><para>The default algorithm name is specified by the security property: <c> 'ssl.KeyManagerFactory.algorithm' </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				public static string DefaultAlgorithm
				{
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return GetDefaultAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the name of the key management algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the key management algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the provider for this <c> KeyManagerFactory </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> KeyManagerFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <summary>
				/// <para>Returns a list of key managers, one instance for each type of key in the key store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of key managers. </para>
				/// </returns>
				/// <java-name>
				/// getKeyManagers
				/// </java-name>
				public global::Javax.Net.Ssl.IKeyManager[] KeyManagers
				{
				[Dot42.DexImport("getKeyManagers", "()[Ljavax/net/ssl/KeyManager;", AccessFlags = 17)]
						get{ return GetKeyManagers(); }
				}

		}

		/// <summary>
		/// <para>An HttpURLConnection for HTTPS (). A connected <c> HttpsURLConnection </c> allows access to the negotiated cipher suite, the server certificate chain, and the client certificate chain if any.</para><para><h3>Providing an application specific X509TrustManager</h3></para><para>If an application wants to trust Certificate Authority (CA) certificates that are not part of the system, it should specify its own <c> X509TrustManager </c> via a <c> SSLSocketFactory </c> set on the <c> HttpsURLConnection </c> . The <c> X509TrustManager </c> can be created based on a <c> KeyStore </c> using a <c>   TrustManagerFactory </c> to supply trusted CA certificates. Note that self-signed certificates are effectively their own CA and can be trusted by including them in a <c> KeyStore </c> .</para><para>For example, to trust a set of certificates specified by a <c> KeyStore </c> : <pre>        KeyStore keyStore = ...;
		/// 
		///      String algorithm = TrustManagerFactory.getDefaultAlgorithm();
		/// 
		///      TrustManagerFactory tmf = TrustManagerFactory.getInstance(algorithm);
		/// 
		///      tmf.init(keyStore);
		/// 
		///   
		/// 
		///      SSLContext context = SSLContext.getInstance("TLS");
		/// 
		///      context.init(null, tmf.getTrustManagers(), null);
		/// 
		///   
		/// 
		///      URL url = new URL("https://www.example.com/");
		/// 
		///      HttpsURLConnection urlConnection = (HttpsURLConnection) url.openConnection();
		/// 
		///      urlConnection.setSSLSocketFactory(context.getSocketFactory());
		/// 
		///      InputStream in = urlConnection.getInputStream();
		/// 
		///  </pre></para><para>It is possible to implement <c> X509TrustManager </c> directly instead of using one created by a <c>   TrustManagerFactory </c> . While this is straightforward in the insecure case of allowing all certificate chains to pass verification, writing a proper implementation will usually want to take advantage of CertPathValidator. In general, it might be better to write a custom <c> KeyStore </c> implementation to pass to the <c>   TrustManagerFactory </c> than to try and write a custom <c>   X509TrustManager </c> .</para><para><h3>Providing an application specific X509KeyManager</h3></para><para>A custom <c> X509KeyManager </c> can be used to supply a client certificate and its associated private key to authenticate a connection to the server. The <c> X509KeyManager </c> can be created based on a <c> KeyStore </c> using a <c> KeyManagerFactory </c> .</para><para>For example, to supply client certificates from a <c> KeyStore </c> : <pre>        KeyStore keyStore = ...;
		/// 
		///      String algorithm = KeyManagerFactory.getDefaultAlgorithm();
		/// 
		///      KeyManagerFactory kmf = KeyManagerFactory.getInstance(algorithm);
		/// 
		///      kmf.init(keyStore);
		/// 
		///   
		/// 
		///      SSLContext context = SSLContext.getInstance("TLS");
		/// 
		///      context.init(kmf.getKeyManagers(), null, null);
		/// 
		///   
		/// 
		///      URL url = new URL("https://www.example.com/");
		/// 
		///      HttpsURLConnection urlConnection = (HttpsURLConnection) url.openConnection();
		/// 
		///      urlConnection.setSSLSocketFactory(context.getSocketFactory());
		/// 
		///      InputStream in = urlConnection.getInputStream();
		/// 
		///  </pre></para><para>A <c> X509KeyManager </c> can also be implemented directly. This can allow an application to return a certificate and private key from a non-<c> KeyStore </c> source or to specify its own logic for selecting a specific credential to use when many may be present in a single <c> KeyStore </c> .</para><para><h3>TLS Intolerance Support</h3></para><para>This class attempts to create secure connections using common TLS extensions and SSL deflate compression. Should that fail, the connection will be retried with SSLv3 only. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/HttpsURLConnection
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/HttpsURLConnection", AccessFlags = 1057)]
		public abstract partial class HttpsURLConnection : global::Java.Net.HttpURLConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The host name verifier used by this connection. It is initialized from the default hostname verifier setDefaultHostnameVerifier(HostnameVerifier) or getDefaultHostnameVerifier(). </para>        
				/// </summary>
				/// <java-name>
				/// hostnameVerifier
				/// </java-name>
				[Dot42.DexImport("hostnameVerifier", "Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 4)]
				protected internal global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier;
				/// <summary>
				/// <para>Creates a new <c> HttpsURLConnection </c> with the specified <c> URL </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal HttpsURLConnection(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the default hostname verifier to be used by new instances.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", AccessFlags = 9)]
				public static void SetDefaultHostnameVerifier(global::Javax.Net.Ssl.IHostnameVerifier v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default hostname verifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default hostname verifier. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.IHostnameVerifier GetDefaultHostnameVerifier() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.IHostnameVerifier);
				}

				/// <summary>
				/// <para>Sets the default SSL socket factory to be used by new instances.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 9)]
				public static void SetDefaultSSLSocketFactory(global::Javax.Net.Ssl.SSLSocketFactory sf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default SSL socket factory for new instances.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default SSL socket factory for new instances. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLSocketFactory GetDefaultSSLSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <summary>
				/// <para>Returns the name of the cipher suite negotiated during the SSL handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the cipher suite negotiated during the SSL handshake. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetCipherSuite() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of local certificates used during the handshake. These certificates were sent to the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the list of certificates used during the handshake with the local identity certificate followed by CAs, or <c> null </c> if no certificates were used during the handshake. </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate[] GetLocalCertificates() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the list of certificates identifying the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates identifying the peer with the peer's identity certificate followed by CAs. </para>
				/// </returns>
				/// <java-name>
				/// getServerCertificates
				/// </java-name>
				[Dot42.DexImport("getServerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate[] GetServerCertificates() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> Principal </c> identifying the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> identifying the peer. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> used to identify the local host during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> used to identify the local host during the handshake, or <c> null </c> if none was used. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <summary>
				/// <para>Sets the hostname verifier for this instance.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", AccessFlags = 1)]
				public virtual void SetHostnameVerifier(global::Javax.Net.Ssl.IHostnameVerifier v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the hostname verifier used by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hostname verifier used by this instance. </para>
				/// </returns>
				/// <java-name>
				/// getHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.IHostnameVerifier GetHostnameVerifier() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.IHostnameVerifier);
				}

				/// <summary>
				/// <para>Sets the SSL socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 1)]
				public virtual void SetSSLSocketFactory(global::Javax.Net.Ssl.SSLSocketFactory sf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the SSL socket factory used by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL socket factory used by this instance. </para>
				/// </returns>
				/// <java-name>
				/// getSSLSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.SSLSocketFactory GetSSLSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpsURLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the default hostname verifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default hostname verifier. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultHostnameVerifier
				/// </java-name>
				public static global::Javax.Net.Ssl.IHostnameVerifier DefaultHostnameVerifier
				{
				[Dot42.DexImport("getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", AccessFlags = 9)]
						get{ return GetDefaultHostnameVerifier(); }
				[Dot42.DexImport("setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", AccessFlags = 9)]
						set{ SetDefaultHostnameVerifier(value); }
				}

				/// <summary>
				/// <para>Returns the default SSL socket factory for new instances.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default SSL socket factory for new instances. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultSSLSocketFactory
				/// </java-name>
				public static global::Javax.Net.Ssl.SSLSocketFactory DefaultSSLSocketFactory
				{
				[Dot42.DexImport("getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
						get{ return GetDefaultSSLSocketFactory(); }
				[Dot42.DexImport("setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 9)]
						set{ SetDefaultSSLSocketFactory(value); }
				}

				/// <summary>
				/// <para>Returns the name of the cipher suite negotiated during the SSL handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the cipher suite negotiated during the SSL handshake. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				public string CipherSuite
				{
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetCipherSuite(); }
				}

				/// <summary>
				/// <para>Returns the list of local certificates used during the handshake. These certificates were sent to the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the list of certificates used during the handshake with the local identity certificate followed by CAs, or <c> null </c> if no certificates were used during the handshake. </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] LocalCertificates
				{
				[Dot42.DexImport("getLocalCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
						get{ return GetLocalCertificates(); }
				}

				/// <summary>
				/// <para>Return the list of certificates identifying the peer during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificates identifying the peer with the peer's identity certificate followed by CAs. </para>
				/// </returns>
				/// <java-name>
				/// getServerCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] ServerCertificates
				{
				[Dot42.DexImport("getServerCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
						get{ return GetServerCertificates(); }
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> identifying the peer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> identifying the peer. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal PeerPrincipal
				{
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetPeerPrincipal(); }
				}

				/// <summary>
				/// <para>Returns the <c> Principal </c> used to identify the local host during the handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Principal </c> used to identify the local host during the handshake, or <c> null </c> if none was used. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal LocalPrincipal
				{
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetLocalPrincipal(); }
				}

				/// <summary>
				/// <para>Returns the SSL socket factory used by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL socket factory used by this instance. </para>
				/// </returns>
				/// <java-name>
				/// getSSLSocketFactory
				/// </java-name>
				public global::Javax.Net.Ssl.SSLSocketFactory SSLSocketFactory
				{
				[Dot42.DexImport("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 1)]
						get{ return GetSSLSocketFactory(); }
				[Dot42.DexImport("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", AccessFlags = 1)]
						set{ SetSSLSocketFactory(value); }
				}

		}

		/// <summary>
		/// <para>The factory for <c> TrustManager </c> s based on <c> KeyStore </c> or provider specific implementation. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/TrustManagerFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/TrustManagerFactory", AccessFlags = 33)]
		public partial class TrustManagerFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> TrustManagerFactory </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/TrustManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;" +
    ")V", AccessFlags = 4)]
				protected internal TrustManagerFactory(global::Javax.Net.Ssl.TrustManagerFactorySpi factorySpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default algorithm name for the <c> TrustManagerFactory </c> . The default algorithm name is specified by the security property <c> 'ssl.TrustManagerFactory.algorithm' </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
				public static string GetDefaultAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new <c> TrustManagerFactory </c> instance for the specified trust management algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a trust manager factory for the requested algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.TrustManagerFactory GetInstance(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.TrustManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.TrustManagerFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.TrustManagerFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/TrustManagerFactory;", AccessFlags = 25)]
				public static global::Javax.Net.Ssl.TrustManagerFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.TrustManagerFactory);
				}

				/// <summary>
				/// <para>Returns the name of this <c> TrustManagerFactory </c> algorithm implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> TrustManagerFactory </c> algorithm implementation. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider for this <c> TrustManagerFactory </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> TrustManagerFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Initializes this factory instance with the specified keystore as source of certificate authorities and trust material.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/KeyStore;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.KeyStore ks) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this factory instance with the specified keystore as source of certificate authorities and trust material.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", AccessFlags = 17)]
				public void Init(global::Javax.Net.Ssl.IManagerFactoryParameters ks) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the list of <c> TrustManager </c> s with one entry for each type of trust material.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of <c> TrustManager </c> s </para>
				/// </returns>
				/// <java-name>
				/// getTrustManagers
				/// </java-name>
				[Dot42.DexImport("getTrustManagers", "()[Ljavax/net/ssl/TrustManager;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.ITrustManager[] GetTrustManagers() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ITrustManager[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TrustManagerFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the default algorithm name for the <c> TrustManagerFactory </c> . The default algorithm name is specified by the security property <c> 'ssl.TrustManagerFactory.algorithm' </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAlgorithm
				/// </java-name>
				public static string DefaultAlgorithm
				{
				[Dot42.DexImport("getDefaultAlgorithm", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return GetDefaultAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the name of this <c> TrustManagerFactory </c> algorithm implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> TrustManagerFactory </c> algorithm implementation. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the provider for this <c> TrustManagerFactory </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> TrustManagerFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <summary>
				/// <para>Returns the list of <c> TrustManager </c> s with one entry for each type of trust material.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of <c> TrustManager </c> s </para>
				/// </returns>
				/// <java-name>
				/// getTrustManagers
				/// </java-name>
				public global::Javax.Net.Ssl.ITrustManager[] TrustManagers
				{
				[Dot42.DexImport("getTrustManagers", "()[Ljavax/net/ssl/TrustManager;", AccessFlags = 17)]
						get{ return GetTrustManagers(); }
				}

		}

		/// <summary>
		/// <para>The marker interface for JSSE trust managers. The purpose is to group trust managers. The responsibility a trust manager is to handle the trust data used to make trust decisions for deciding whether credentials of a peer should be accepted, <para>TrustManagerFactory </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/TrustManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/TrustManager", AccessFlags = 1537)]
		public partial interface ITrustManager
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>The abstract extension for the <c> X509KeyManager </c> interface. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/X509ExtendedKeyManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/X509ExtendedKeyManager", AccessFlags = 1057)]
		public abstract partial class X509ExtendedKeyManager : global::Javax.Net.Ssl.IX509KeyManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>To be used by subclasses only. </para><para>Creates a new <c> X509ExtendedKeyManager </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal X509ExtendedKeyManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Chooses an alias for the client side of an SSL connection to authenticate it with the specified public key type and certificate issuers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the alias name of a matching key or <c> null </c> if there are no matches. </para>
				/// </returns>
				/// <java-name>
				/// chooseEngineClientAlias
				/// </java-name>
				[Dot42.DexImport("chooseEngineClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lan" +
    "g/String;", AccessFlags = 1)]
				public virtual string ChooseEngineClientAlias(string[] keyType, global::Java.Security.IPrincipal[] issuers, global::Javax.Net.Ssl.SSLEngine engine) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Chooses an alias for the server side of an SSL connection to authenticate it with the specified public key type and certificate issuers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the alias name of a matching key or <c> null </c> if there are no matches. </para>
				/// </returns>
				/// <java-name>
				/// chooseEngineServerAlias
				/// </java-name>
				[Dot42.DexImport("chooseEngineServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang" +
    "/String;", AccessFlags = 1)]
				public virtual string ChooseEngineServerAlias(string keyType, global::Java.Security.IPrincipal[] issuers, global::Javax.Net.Ssl.SSLEngine engine) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String" +
    ";", AccessFlags = 1025)]
				public virtual string ChooseClientAlias(string[] keyType, global::Java.Security.IPrincipal[] issuers, global::Java.Net.Socket socket) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;" +
    "", AccessFlags = 1025)]
				public virtual string ChooseServerAlias(string keyType, global::Java.Security.IPrincipal[] issuers, global::Java.Net.Socket socket) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", AccessFlags = 1025)]
				public virtual global::Java.Security.Cert.X509Certificate[] GetCertificateChain(string alias) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Security.Cert.X509Certificate[]);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string[] GetClientAliases(string keyType, global::Java.Security.IPrincipal[] issuers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string[]);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string[] GetServerAliases(string keyType, global::Java.Security.IPrincipal[] issuers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string[]);
				}

				[Dot42.DexImport("javax/net/ssl/X509KeyManager", "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", AccessFlags = 1025)]
				public virtual global::Java.Security.IPrivateKey GetPrivateKey(string alias) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

		}

		/// <summary>
		/// <para>The event sent to an <c> SSLSessionBindingListener </c> when the listener object is bound (SSLSession#putValue(String, Object)) or unbound (SSLSession#removeValue(String)) to an <c> SSLSession </c> . </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLSessionBindingEvent
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLSessionBindingEvent", AccessFlags = 33)]
		public partial class SSLSessionBindingEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLSessionBindingEvent </c> for the specified session indicating a binding event for the specified name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLSession;Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLSessionBindingEvent(global::Javax.Net.Ssl.ISSLSession session, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the binding being added or removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the binding. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the session to which the binding is added or from which it is removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the session to which the binding is added or from which it is removed. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
				public virtual global::Javax.Net.Ssl.ISSLSession GetSession() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSession);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLSessionBindingEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the binding being added or removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the binding. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns the session to which the binding is added or from which it is removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the session to which the binding is added or from which it is removed. </para>
				/// </returns>
				/// <java-name>
				/// getSession
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSession Session
				{
				[Dot42.DexImport("getSession", "()Ljavax/net/ssl/SSLSession;", AccessFlags = 1)]
						get{ return GetSession(); }
				}

		}

		/// <summary>
		/// <para>The public API for secure socket protocol implementations. It acts as factory for <c> SSLSocketFactory </c> 's and <c> SSLEngine </c> s. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLContext
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLContext", AccessFlags = 33)]
		public partial class SSLContext
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLContext </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLContextSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal SSLContext(global::Javax.Net.Ssl.SSLContextSpi contextSpi, global::Java.Security.Provider provider, string protocol) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default SSLContext.</para><para>The default SSL context can be set with setDefault. If not, one will be created with <c>       SSLContext.getInstance("Default") </c> , which will already be initialized.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <summary>
				/// <para>Sets the default SSLContext instance as returned by getDefault() to a non-null initialized value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljavax/net/ssl/SSLContext;)V", AccessFlags = 9)]
				public static void SetDefault(global::Javax.Net.Ssl.SSLContext sslContext) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> SSLContext </c> instance for the specified protocol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created <c> SSLContext </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetInstance(string protocol) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLContext GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLContext);
				}

				/// <summary>
				/// <para>Returns the name of the secure socket protocol of this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the secure socket protocol of this instance. </para>
				/// </returns>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider of this <c> SSLContext </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> SSLContext </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Initializes this <c> SSLContext </c> instance. All of the arguments are optional, and the security providers will be searched for the required implementations of the needed algorithms.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRan" +
    "dom;)V", AccessFlags = 17)]
				public void Init(global::Javax.Net.Ssl.IKeyManager[] km, global::Javax.Net.Ssl.ITrustManager[] tm, global::Java.Security.SecureRandom sr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a socket factory for this instance. </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLSocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <summary>
				/// <para>Returns a server socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a server socket factory for this instance. </para>
				/// </returns>
				/// <java-name>
				/// getServerSocketFactory
				/// </java-name>
				[Dot42.DexImport("getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLServerSocketFactory GetServerSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLServerSocketFactory);
				}

				/// <summary>
				/// <para>Creates an <c> SSLEngine </c> instance from this context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> SSLEngine </c> instance from this context. </para>
				/// </returns>
				/// <java-name>
				/// createSSLEngine
				/// </java-name>
				[Dot42.DexImport("createSSLEngine", "()Ljavax/net/ssl/SSLEngine;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngine CreateSSLEngine() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngine);
				}

				/// <summary>
				/// <para>Creates an <c> SSLEngine </c> instance from this context with the specified hostname and port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> SSLEngine </c> instance from this context. </para>
				/// </returns>
				/// <java-name>
				/// createSSLEngine
				/// </java-name>
				[Dot42.DexImport("createSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngine CreateSSLEngine(string peerHost, int peerPort) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngine);
				}

				/// <summary>
				/// <para>Returns the SSL session context that encapsulates the set of SSL sessions that can be used for handshake of server-side SSL sockets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL server session context for this context or <c> null </c> if the underlying provider does not provide an implementation of the <c> SSLSessionContext </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// getServerSessionContext
				/// </java-name>
				[Dot42.DexImport("getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.ISSLSessionContext GetServerSessionContext() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSessionContext);
				}

				/// <summary>
				/// <para>Returns the SSL session context that encapsulates the set of SSL sessions that can be used for handshake of client-side SSL sockets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL client session context for this context or <c> null </c> if the underlying provider does not provide an implementation of the <c> SSLSessionContext </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// getClientSessionContext
				/// </java-name>
				[Dot42.DexImport("getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.ISSLSessionContext GetClientSessionContext() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.ISSLSessionContext);
				}

				/// <summary>
				/// <para>Returns the default SSL handshake parameters for SSLSockets created by this SSLContext.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDefaultSSLParameters
				/// </java-name>
				[Dot42.DexImport("getDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLParameters GetDefaultSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				/// <summary>
				/// <para>Returns SSL handshake parameters for SSLSockets that includes all supported cipher suites and protocols.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSupportedSSLParameters
				/// </java-name>
				[Dot42.DexImport("getSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLParameters GetSupportedSSLParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLParameters);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the default SSLContext.</para><para>The default SSL context can be set with setDefault. If not, one will be created with <c>       SSLContext.getInstance("Default") </c> , which will already be initialized.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.Ssl.SSLContext Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/ssl/SSLContext;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljavax/net/ssl/SSLContext;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

				/// <summary>
				/// <para>Returns the name of the secure socket protocol of this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the secure socket protocol of this instance. </para>
				/// </returns>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				public string Protocol
				{
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetProtocol(); }
				}

				/// <summary>
				/// <para>Returns the provider of this <c> SSLContext </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> SSLContext </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <summary>
				/// <para>Returns a socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a socket factory for this instance. </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public global::Javax.Net.Ssl.SSLSocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 17)]
						get{ return GetSocketFactory(); }
				}

				/// <summary>
				/// <para>Returns a server socket factory for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a server socket factory for this instance. </para>
				/// </returns>
				/// <java-name>
				/// getServerSocketFactory
				/// </java-name>
				public global::Javax.Net.Ssl.SSLServerSocketFactory ServerSocketFactory
				{
				[Dot42.DexImport("getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", AccessFlags = 17)]
						get{ return GetServerSocketFactory(); }
				}

				/// <summary>
				/// <para>Returns the SSL session context that encapsulates the set of SSL sessions that can be used for handshake of server-side SSL sockets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL server session context for this context or <c> null </c> if the underlying provider does not provide an implementation of the <c> SSLSessionContext </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// getServerSessionContext
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSessionContext ServerSessionContext
				{
				[Dot42.DexImport("getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
						get{ return GetServerSessionContext(); }
				}

				/// <summary>
				/// <para>Returns the SSL session context that encapsulates the set of SSL sessions that can be used for handshake of client-side SSL sockets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL client session context for this context or <c> null </c> if the underlying provider does not provide an implementation of the <c> SSLSessionContext </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// getClientSessionContext
				/// </java-name>
				public global::Javax.Net.Ssl.ISSLSessionContext ClientSessionContext
				{
				[Dot42.DexImport("getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", AccessFlags = 17)]
						get{ return GetClientSessionContext(); }
				}

				/// <summary>
				/// <para>Returns the default SSL handshake parameters for SSLSockets created by this SSLContext.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDefaultSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters DefaultSSLParameters
				{
				[Dot42.DexImport("getDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
						get{ return GetDefaultSSLParameters(); }
				}

				/// <summary>
				/// <para>Returns SSL handshake parameters for SSLSockets that includes all supported cipher suites and protocols.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSupportedSSLParameters
				/// </java-name>
				public global::Javax.Net.Ssl.SSLParameters SupportedSSLParameters
				{
				[Dot42.DexImport("getSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;", AccessFlags = 17)]
						get{ return GetSupportedSSLParameters(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when an error in the operation of the SSL protocol is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLProtocolException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLProtocolException", AccessFlags = 33)]
		public partial class SSLProtocolException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLProtocolException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLProtocolException(string reason) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLProtocolException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The base class for all SSL related exceptions. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLException", AccessFlags = 33)]
		public partial class SSLException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> SSLException </c> with the specified message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SSLException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SSLException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLPermission
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLPermission", AccessFlags = 49)]
		public sealed partial class SSLPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when an invalid SSL key is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLKeyException
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLKeyException", AccessFlags = 33)]
		public partial class SSLKeyException : global::Javax.Net.Ssl.SSLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLKeyException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLKeyException(string reason) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLKeyException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The result object describing the state of the <c> SSLEngine </c> produced by the <c> wrap() </c> and <c> unwrap() </c> operations. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLEngineResult
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLEngineResult", AccessFlags = 33)]
		public partial class SSLEngineResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SSLEngineResult </c> instance with the specified state values.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeSt" +
    "atus;II)V", AccessFlags = 1)]
				public SSLEngineResult(global::Javax.Net.Ssl.SSLEngineResult.Status status, global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus handshakeStatus, int bytesConsumed, int bytesProduced) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the return value of the <c> SSLEngine </c> operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return value of the <c> SSLEngine </c> operation. </para>
				/// </returns>
				/// <java-name>
				/// getStatus
				/// </java-name>
				[Dot42.DexImport("getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngineResult.Status GetStatus() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult.Status);
				}

				/// <summary>
				/// <para>Returns the status of the current handshake.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the status of the current handshake. </para>
				/// </returns>
				/// <java-name>
				/// getHandshakeStatus
				/// </java-name>
				[Dot42.DexImport("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 17)]
				public global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLEngineResult.HandshakeStatus);
				}

				/// <summary>
				/// <para>Returns the number of bytes retrieved from the source buffer(s).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes retrieved from the source buffer(s). </para>
				/// </returns>
				/// <java-name>
				/// bytesConsumed
				/// </java-name>
				[Dot42.DexImport("bytesConsumed", "()I", AccessFlags = 17)]
				public int BytesConsumed() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of bytes transferred to the destination buffer(s).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes transferred to the destination buffer(s). </para>
				/// </returns>
				/// <java-name>
				/// bytesProduced
				/// </java-name>
				[Dot42.DexImport("bytesProduced", "()I", AccessFlags = 17)]
				public int BytesProduced() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLEngineResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// javax/net/ssl/SSLEngineResult$Status
				/// </java-name>
				[Dot42.DexImport("javax/net/ssl/SSLEngineResult$Status", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljavax/net/ssl/SSLEngineResult$Status;>;")]
				public sealed class Status
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BUFFER_OVERFLOW
						/// </java-name>
						[Dot42.DexImport("BUFFER_OVERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status BUFFER_OVERFLOW;
						/// <java-name>
						/// BUFFER_UNDERFLOW
						/// </java-name>
						[Dot42.DexImport("BUFFER_UNDERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status BUFFER_UNDERFLOW;
						/// <java-name>
						/// CLOSED
						/// </java-name>
						[Dot42.DexImport("CLOSED", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status CLOSED;
						/// <java-name>
						/// OK
						/// </java-name>
						[Dot42.DexImport("OK", "Ljavax/net/ssl/SSLEngineResult$Status;", AccessFlags = 16409)]
						public static readonly Status OK;
						private Status() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

				/// <java-name>
				/// javax/net/ssl/SSLEngineResult$HandshakeStatus
				/// </java-name>
				[Dot42.DexImport("javax/net/ssl/SSLEngineResult$HandshakeStatus", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;>;")]
				public sealed class HandshakeStatus
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FINISHED
						/// </java-name>
						[Dot42.DexImport("FINISHED", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus FINISHED;
						/// <java-name>
						/// NEED_TASK
						/// </java-name>
						[Dot42.DexImport("NEED_TASK", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NEED_TASK;
						/// <java-name>
						/// NEED_UNWRAP
						/// </java-name>
						[Dot42.DexImport("NEED_UNWRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NEED_UNWRAP;
						/// <java-name>
						/// NEED_WRAP
						/// </java-name>
						[Dot42.DexImport("NEED_WRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NEED_WRAP;
						/// <java-name>
						/// NOT_HANDSHAKING
						/// </java-name>
						[Dot42.DexImport("NOT_HANDSHAKING", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", AccessFlags = 16409)]
						public static readonly HandshakeStatus NOT_HANDSHAKING;
						private HandshakeStatus() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>The trust manager for X509 certificates to be used to perform authentication for secure sockets. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/X509TrustManager
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/X509TrustManager", AccessFlags = 1537)]
		public partial interface IX509TrustManager : global::Javax.Net.Ssl.ITrustManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Checks whether the specified certificate chain (partial or complete) can be validated and is trusted for client authentication for the specified authentication type.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// checkClientTrusted
				/// </java-name>
				[Dot42.DexImport("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", AccessFlags = 1025)]
				void CheckClientTrusted(global::Java.Security.Cert.X509Certificate[] chain, string authType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether the specified certificate chain (partial or complete) can be validated and is trusted for server authentication for the specified key exchange algorithm.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// checkServerTrusted
				/// </java-name>
				[Dot42.DexImport("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", AccessFlags = 1025)]
				void CheckServerTrusted(global::Java.Security.Cert.X509Certificate[] chain, string authType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of certificate issuer authorities which are trusted for authentication of peers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of certificate issuer authorities which are trusted for authentication of peers. </para>
				/// </returns>
				/// <java-name>
				/// getAcceptedIssuers
				/// </java-name>
				[Dot42.DexImport("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", AccessFlags = 1025)]
				global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The extension of <c> ServerSocket </c> which provides secure server sockets based on protocols like SSL, TLS, or others. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ssl/SSLServerSocket
		/// </java-name>
		[Dot42.DexImport("javax/net/ssl/SSLServerSocket", AccessFlags = 1057)]
		public abstract partial class SSLServerSocket : global::Java.Net.ServerSocket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP server socket with the default authentication context.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SSLServerSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP server socket on the specified port with the default authentication context. The connection's default backlog size is 50 connections. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 4)]
				protected internal SSLServerSocket(int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP server socket on the specified port using the specified backlog and the default authentication context.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 4)]
				protected internal SSLServerSocket(int port, int backlog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only to be used by subclasses. </para><para>Creates a TCP server socket on the specified port, using the specified backlog, listening on the specified interface, and using the default authentication context.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/net/InetAddress;)V", AccessFlags = 4)]
				protected internal SSLServerSocket(int port, int backlog, global::Java.Net.InetAddress address) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the names of the enabled cipher suites to be used for new connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the enabled cipher suites to be used for new connections. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the names of the cipher suites to be enabled for new connections. Only cipher suites returned by getSupportedCipherSuites() are allowed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabledCipherSuites
				/// </java-name>
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledCipherSuites(string[] suites) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the supported cipher suites.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the supported cipher suites. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedCipherSuites() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the supported protocols.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the supported protocols. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSupportedProtocols() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the enabled protocols to be used for new connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the enabled protocols to be used for new connections. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetEnabledProtocols() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the names of the protocols to be enabled for new connections. Only protocols returned by getSupportedProtocols() are allowed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabledProtocols
				/// </java-name>
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetEnabledProtocols(string[] protocols) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether server-mode connections will be configured to require client authentication. The client authentication is one of the following: <ul><li><para>authentication required </para></li><li><para>authentication requested </para></li><li><para>no authentication needed </para></li></ul>This method overrides the setting of setWantClientAuth(boolean).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetNeedClientAuth(bool need) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether server-mode connections will be configured to require client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if client authentication is required, <c> false </c> if no client authentication is needed. </para>
				/// </returns>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetNeedClientAuth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether server-mode connections will be configured to request client authentication. The client authentication is one of the following: <ul><li><para>authentication required </para></li><li><para>authentication requested </para></li><li><para>no authentication needed </para></li></ul>This method overrides the setting of setNeedClientAuth(boolean).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWantClientAuth
				/// </java-name>
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
				public abstract void SetWantClientAuth(bool want) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether server-mode connections will be configured to request client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> is client authentication will be requested, <c> false </c> if no client authentication is needed. </para>
				/// </returns>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
				public abstract bool GetWantClientAuth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether new connections should act in client mode when handshaking.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUseClientMode
				/// </java-name>
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
				public abstract void SetUseClientMode(bool mode) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether new connection will act in client mode when handshaking.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new connections will act in client mode when handshaking, <c> false </c> if not. </para>
				/// </returns>
				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
				public abstract bool GetUseClientMode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether new SSL sessions may be established for new connections.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
				public abstract void SetEnableSessionCreation(bool flag) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether new SSL sessions may be established for new connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new SSL sessions may be established, <c> false </c> if existing SSL sessions must be reused. </para>
				/// </returns>
				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
				public abstract bool GetEnableSessionCreation() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the enabled cipher suites to be used for new connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the enabled cipher suites to be used for new connections. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledCipherSuites
				/// </java-name>
				public string[] EnabledCipherSuites
				{
				[Dot42.DexImport("getEnabledCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledCipherSuites(); }
				[Dot42.DexImport("setEnabledCipherSuites", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledCipherSuites(value); }
				}

				/// <summary>
				/// <para>Returns the names of the supported cipher suites.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the supported cipher suites. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public string[] SupportedCipherSuites
				{
				[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedCipherSuites(); }
				}

				/// <summary>
				/// <para>Returns the names of the supported protocols.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the supported protocols. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedProtocols
				/// </java-name>
				public string[] SupportedProtocols
				{
				[Dot42.DexImport("getSupportedProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSupportedProtocols(); }
				}

				/// <summary>
				/// <para>Returns the names of the enabled protocols to be used for new connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the enabled protocols to be used for new connections. </para>
				/// </returns>
				/// <java-name>
				/// getEnabledProtocols
				/// </java-name>
				public string[] EnabledProtocols
				{
				[Dot42.DexImport("getEnabledProtocols", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetEnabledProtocols(); }
				[Dot42.DexImport("setEnabledProtocols", "([Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetEnabledProtocols(value); }
				}

				/// <summary>
				/// <para>Returns whether server-mode connections will be configured to require client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if client authentication is required, <c> false </c> if no client authentication is needed. </para>
				/// </returns>
				/// <java-name>
				/// getNeedClientAuth
				/// </java-name>
				public bool IsNeedClientAuth
				{
				[Dot42.DexImport("getNeedClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetNeedClientAuth(); }
				[Dot42.DexImport("setNeedClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetNeedClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns whether server-mode connections will be configured to request client authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> is client authentication will be requested, <c> false </c> if no client authentication is needed. </para>
				/// </returns>
				/// <java-name>
				/// getWantClientAuth
				/// </java-name>
				public bool IsWantClientAuth
				{
				[Dot42.DexImport("getWantClientAuth", "()Z", AccessFlags = 1025)]
						get{ return GetWantClientAuth(); }
				[Dot42.DexImport("setWantClientAuth", "(Z)V", AccessFlags = 1025)]
						set{ SetWantClientAuth(value); }
				}

				/// <summary>
				/// <para>Returns whether new connection will act in client mode when handshaking.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new connections will act in client mode when handshaking, <c> false </c> if not. </para>
				/// </returns>
				/// <java-name>
				/// getUseClientMode
				/// </java-name>
				public bool IsUseClientMode
				{
				[Dot42.DexImport("getUseClientMode", "()Z", AccessFlags = 1025)]
						get{ return GetUseClientMode(); }
				[Dot42.DexImport("setUseClientMode", "(Z)V", AccessFlags = 1025)]
						set{ SetUseClientMode(value); }
				}

				/// <summary>
				/// <para>Returns whether new SSL sessions may be established for new connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if new SSL sessions may be established, <c> false </c> if existing SSL sessions must be reused. </para>
				/// </returns>
				/// <java-name>
				/// getEnableSessionCreation
				/// </java-name>
				public bool IsEnableSessionCreation
				{
				[Dot42.DexImport("getEnableSessionCreation", "()Z", AccessFlags = 1025)]
						get{ return GetEnableSessionCreation(); }
				[Dot42.DexImport("setEnableSessionCreation", "(Z)V", AccessFlags = 1025)]
						set{ SetEnableSessionCreation(value); }
				}

		}

}


