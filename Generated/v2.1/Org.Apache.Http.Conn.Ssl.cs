#pragma warning disable 1717
namespace Org.Apache.Http.Conn.Ssl
{
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
				public void Verify(string @string, string[] string1, string[] string2, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acceptableCountryWildcard
				/// </java-name>
				[Dot42.DexImport("acceptableCountryWildcard", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool AcceptableCountryWildcard(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCNs
				/// </java-name>
				[Dot42.DexImport("getCNs", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] GetCNs(global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getDNSSubjectAlts
				/// </java-name>
				[Dot42.DexImport("getDNSSubjectAlts", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] GetDNSSubjectAlts(global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// countDots
				/// </java-name>
				[Dot42.DexImport("countDots", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int CountDots(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/conn/ssl/X509HostnameVerifier", "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void Verify(string @string, string[] string1, string[] string2) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

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
				public override void Verify(string @string, string[] string1, string[] string2) /* MethodBuilder.Create */ 
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
				public override void Verify(string @string, string[] string1, string[] string2) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1025)]
				void Verify(string @string, string[] string1, string[] string2) /* MethodBuilder.Create */ ;

		}

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
				public SSLSocketFactory(string @string, global::Java.Security.KeyStore keyStore, string string1, global::Java.Security.KeyStore keyStore1, global::Java.Security.SecureRandom secureRandom, global::Org.Apache.Http.Conn.Scheme.IHostNameResolver hostNameResolver) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;)V", AccessFlags = 1)]
				public SSLSocketFactory(global::Java.Security.KeyStore keyStore, string @string, global::Java.Security.KeyStore keyStore1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;Ljava/lang/String;)V", AccessFlags = 1)]
				public SSLSocketFactory(global::Java.Security.KeyStore keyStore, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;)V", AccessFlags = 1)]
				public SSLSocketFactory(global::Java.Security.KeyStore keyStore) /* MethodBuilder.Create */ 
				{
				}

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
				public virtual global::Java.Net.Socket ConnectSocket(global::Java.Net.Socket socket, string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "(Ljava/net/Socket;)Z", AccessFlags = 1)]
				public virtual bool IsSecure(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1)]
				public virtual global::Java.Net.Socket CreateSocket(global::Java.Net.Socket socket, string @string, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLSocketFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public static global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory SocketFactory
				{
						[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;", AccessFlags = 9)]
						get{ return default(global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory); }
				}

				/// <java-name>
				/// getHostnameVerifier
				/// </java-name>
				public virtual global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier HostnameVerifier
				{
						[Dot42.DexImport("getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier); }
						[Dot42.DexImport("setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V", AccessFlags = 1)]
						set{ }
				}

		}

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
				public override void Verify(string @string, string[] string1, string[] string2) /* MethodBuilder.Create */ 
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

}

