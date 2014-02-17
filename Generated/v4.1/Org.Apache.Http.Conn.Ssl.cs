// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Conn.Ssl.cs
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
namespace Org.Apache.Http.Conn.Ssl
{
		/// <summary>
		/// <para>The Strict HostnameVerifier works the same way as Sun Java 1.4, Sun Java 5, Sun Java 6-rc. It's also pretty close to IE6. This implementation appears to be compliant with RFC 2818 for dealing with wildcards. </para><para>The hostname must match either the first CN, or any of the subject-alts. A wildcard can occur in the CN, and in any of the subject-alts. The one divergence from IE6 is how we only check the first CN. IE6 allows a match against any of the CNs present. We decided to follow in Sun Java 1.4's footsteps and only check the first CN. (If you need to check all the CN's, feel free to write your own implementation!). </para><para>A wildcard such as "*.foo.com" matches only subdomains in the same level, for example "a.foo.com". It does not match deeper subdomains such as "a.b.foo.com".</para><para><para>Julius Davies </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ssl/StrictHostnameVerifier
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ssl/StrictHostnameVerifier", AccessFlags = 33)]
		public partial class StrictHostnameVerifier : global::Org.Apache.Http.Conn.Ssl.AbstractVerifier
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StrictHostnameVerifier() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 17)]
				public override void Verify(string host, string[] cns, string[] subjectAlts) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Abstract base class for all standard X509HostnameVerifier implementations.</para><para><para>Julius Davies </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ssl/AbstractVerifier
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ssl/AbstractVerifier", AccessFlags = 1057)]
		public abstract partial class AbstractVerifier : global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractVerifier() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V", AccessFlags = 17)]
				public void Verify(string @string, global::Javax.Net.Ssl.SSLSocket sSLSocket) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", AccessFlags = 17)]
				public bool Verify(string @string, global::Javax.Net.Ssl.ISSLSession sSLSession) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V", AccessFlags = 17)]
				public void Verify(string @string, global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Z)V", AccessFlags = 17)]
				public void Verify(string host, string[] cns, string[] subjectAlts, bool strictWithSubDomains) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acceptableCountryWildcard
				/// </java-name>
				[Dot42.DexImport("acceptableCountryWildcard", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool AcceptableCountryWildcard(string cn) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCNs
				/// </java-name>
				[Dot42.DexImport("getCNs", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] GetCNs(global::Java.Security.Cert.X509Certificate cert) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Extracts the array of SubjectAlt DNS names from an X509Certificate. Returns null if there aren't any. </para><para>Note: Java doesn't appear able to extract international characters from the SubjectAlts. It can only extract international characters from the CN field. </para><para>(Or maybe the version of OpenSSL I'm using to test isn't storing the international characters correctly in the SubjectAlts?).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Array of SubjectALT DNS names stored in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getDNSSubjectAlts
				/// </java-name>
				[Dot42.DexImport("getDNSSubjectAlts", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] GetDNSSubjectAlts(global::Java.Security.Cert.X509Certificate cert) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Counts the number of dots "." in a string. </para>        
				/// </summary>
				/// <returns>
				/// <para>number of dots </para>
				/// </returns>
				/// <java-name>
				/// countDots
				/// </java-name>
				[Dot42.DexImport("countDots", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int CountDots(string s) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/conn/ssl/X509HostnameVerifier", "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void Verify(string host, string[] cns, string[] subjectAlts) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <summary>
		/// <para>The ALLOW_ALL HostnameVerifier essentially turns hostname verification off. This implementation is a no-op, and never throws the SSLException.</para><para><para>Julius Davies </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ssl/AllowAllHostnameVerifier
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ssl/AllowAllHostnameVerifier", AccessFlags = 33)]
		public partial class AllowAllHostnameVerifier : global::Org.Apache.Http.Conn.Ssl.AbstractVerifier
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AllowAllHostnameVerifier() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 17)]
				public override void Verify(string host, string[] cns, string[] subjectAlts) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Layered socket factory for TLS/SSL connections, based on JSSE. </para><para>SSLSocketFactory can be used to validate the identity of the HTTPS server against a list of trusted certificates and to authenticate to the HTTPS server using a private key. </para><para>SSLSocketFactory will enable server authentication when supplied with a truststore file containg one or several trusted certificates. The client secure socket will reject the connection during the SSL session handshake if the target HTTPS server attempts to authenticate itself with a non-trusted certificate. </para><para>Use JDK keytool utility to import a trusted certificate and generate a truststore file: <pre>
		///        keytool -import -alias "my server cert" -file server.crt -keystore my.truststore
		///       </pre> </para><para>SSLSocketFactory will enable client authentication when supplied with a keystore file containg a private key/public certificate pair. The client secure socket will use the private key to authenticate itself to the target HTTPS server during the SSL session handshake if requested to do so by the server. The target HTTPS server will in its turn verify the certificate presented by the client in order to establish client's authenticity </para><para>Use the following sequence of actions to generate a keystore file </para><para><ul><li><para></para><para>Use JDK keytool utility to generate a new key <pre>keytool -genkey -v -alias "my client key" -validity 365 -keystore my.keystore</pre> For simplicity use the same password for the key as that of the keystore </para><para></para></li><li><para></para><para>Issue a certificate signing request (CSR) <pre>keytool -certreq -alias "my client key" -file mycertreq.csr -keystore my.keystore</pre> </para><para></para></li><li><para></para><para>Send the certificate request to the trusted Certificate Authority for signature. One may choose to act as her own CA and sign the certificate request using a PKI tool, such as OpenSSL. </para><para></para></li><li><para></para><para>Import the trusted CA root certificate <pre>keytool -import -alias "my trusted ca" -file caroot.crt -keystore my.keystore</pre> </para><para></para></li><li><para></para><para>Import the PKCS#7 file containg the complete certificate chain <pre>keytool -import -alias "my client key" -file mycert.p7 -keystore my.keystore</pre> </para><para></para></li><li><para></para><para>Verify the content the resultant keystore file <pre>keytool -list -v -keystore my.keystore</pre> </para><para></para></li></ul><para> </para><simplesectsep></simplesectsep><para>Julius Davies </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ssl/SSLSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ssl/SSLSocketFactory", AccessFlags = 33)]
		public partial class SSLSocketFactory : global::Org.Apache.Http.Conn.Scheme.ILayeredSocketFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TLS
				/// </java-name>
				[Dot42.DexImport("TLS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TLS = "TLS";
				/// <java-name>
				/// SSL
				/// </java-name>
				[Dot42.DexImport("SSL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SSL = "SSL";
				/// <java-name>
				/// SSLV2
				/// </java-name>
				[Dot42.DexImport("SSLV2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SSLV2 = "SSLv2";
				/// <java-name>
				/// ALLOW_ALL_HOSTNAME_VERIFIER
				/// </java-name>
				[Dot42.DexImport("ALLOW_ALL_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier ALLOW_ALL_HOSTNAME_VERIFIER;
				/// <java-name>
				/// BROWSER_COMPATIBLE_HOSTNAME_VERIFIER
				/// </java-name>
				[Dot42.DexImport("BROWSER_COMPATIBLE_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier BROWSER_COMPATIBLE_HOSTNAME_VERIFIER;
				/// <java-name>
				/// STRICT_HOSTNAME_VERIFIER
				/// </java-name>
				[Dot42.DexImport("STRICT_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier STRICT_HOSTNAME_VERIFIER;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeySt" +
    "ore;Ljava/security/SecureRandom;Lorg/apache/http/conn/scheme/HostNameResolver;)V" +
    "", AccessFlags = 1)]
				public SSLSocketFactory(string algorithm, global::Java.Security.KeyStore keystore, string keystorePassword, global::Java.Security.KeyStore truststore, global::Java.Security.SecureRandom random, global::Org.Apache.Http.Conn.Scheme.IHostNameResolver nameResolver) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;)V", AccessFlags = 1)]
				public SSLSocketFactory(global::Java.Security.KeyStore keystore, string keystorePassword, global::Java.Security.KeyStore truststore) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLSocketFactory(global::Java.Security.KeyStore keystore, string keystorePassword) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;)V", AccessFlags = 1)]
				public SSLSocketFactory(global::Java.Security.KeyStore truststore) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets an singleton instance of the SSLProtocolSocketFactory. </para>        
				/// </summary>
				/// <returns>
				/// <para>a SSLProtocolSocketFactory </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory);
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
				public virtual global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// connectSocket
				/// </java-name>
				[Dot42.DexImport("connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/para" +
    "ms/HttpParams;)Ljava/net/Socket;", AccessFlags = 1)]
				public virtual global::Java.Net.Socket ConnectSocket(global::Java.Net.Socket sock, string host, int port, global::Java.Net.InetAddress localAddress, int localPort, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				/// <para>Checks whether a socket connection is secure. This factory creates TLS/SSL socket connections which, by default, are considered secure. <br></br> Derived classes may override this method to perform runtime checks, for example based on the cypher suite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code></para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "(Ljava/net/Socket;)Z", AccessFlags = 1)]
				public virtual bool IsSecure(global::Java.Net.Socket sock) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1)]
				public virtual global::Java.Net.Socket CreateSocket(global::Java.Net.Socket socket, string host, int port, bool autoClose) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// setHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V", AccessFlags = 1)]
				public virtual void SetHostnameVerifier(global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier hostnameVerifier) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHostnameVerifier
				/// </java-name>
				[Dot42.DexImport("getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier GetHostnameVerifier() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLSocketFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets an singleton instance of the SSLProtocolSocketFactory. </para>        
				/// </summary>
				/// <returns>
				/// <para>a SSLProtocolSocketFactory </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public static global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;", AccessFlags = 9)]
						get{ return GetSocketFactory(); }
				}

				/// <java-name>
				/// getHostnameVerifier
				/// </java-name>
				public global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier HostnameVerifier
				{
				[Dot42.DexImport("getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;", AccessFlags = 1)]
						get{ return GetHostnameVerifier(); }
				[Dot42.DexImport("setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V", AccessFlags = 1)]
						set{ SetHostnameVerifier(value); }
				}

		}

		/// <summary>
		/// <para>The HostnameVerifier that works the same way as Curl and Firefox. </para><para>The hostname must match either the first CN, or any of the subject-alts. A wildcard can occur in the CN, and in any of the subject-alts. </para><para>The only difference between BROWSER_COMPATIBLE and STRICT is that a wildcard (such as "*.foo.com") with BROWSER_COMPATIBLE matches all subdomains, including "a.b.foo.com".</para><para><para>Julius Davies </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ssl/BrowserCompatHostnameVerifier
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ssl/BrowserCompatHostnameVerifier", AccessFlags = 33)]
		public partial class BrowserCompatHostnameVerifier : global::Org.Apache.Http.Conn.Ssl.AbstractVerifier
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BrowserCompatHostnameVerifier() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 17)]
				public override void Verify(string host, string[] cns, string[] subjectAlts) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Interface for checking if a hostname matches the names stored inside the server's X.509 certificate. Implements javax.net.ssl.HostnameVerifier, but we don't actually use that interface. Instead we added some methods that take String parameters (instead of javax.net.ssl.HostnameVerifier's SSLSession). JUnit is a lot easier this way! :-) </para><para>We provide the HostnameVerifier.DEFAULT, HostnameVerifier.STRICT, and HostnameVerifier.ALLOW_ALL implementations. But feel free to define your own implementation! </para><para>Inspired by Sebastian Hauer's original StrictSSLProtocolSocketFactory in the HttpClient "contrib" repository.</para><para><para>Julius Davies </para><simplesectsep></simplesectsep><para></para><para>4.0 (8-Dec-2006) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/ssl/X509HostnameVerifier
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/ssl/X509HostnameVerifier", AccessFlags = 1537)]
		public partial interface IX509HostnameVerifier : global::Javax.Net.Ssl.IHostnameVerifier
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", AccessFlags = 1025)]
				bool Verify(string @string, global::Javax.Net.Ssl.ISSLSession sSLSession) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V", AccessFlags = 1025)]
				void Verify(string @string, global::Javax.Net.Ssl.SSLSocket sSLSocket) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V", AccessFlags = 1025)]
				void Verify(string @string, global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks to see if the supplied hostname matches any of the supplied CNs or "DNS" Subject-Alts. Most implementations only look at the first CN, and ignore any additional CNs. Most implementations do look at all of the "DNS" Subject-Alts. The CNs or Subject-Alts may contain wildcards according to RFC 2818.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1025)]
				void Verify(string host, string[] cns, string[] subjectAlts) /* MethodBuilder.Create */ ;

		}

}


