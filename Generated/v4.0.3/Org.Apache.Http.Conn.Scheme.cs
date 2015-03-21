#pragma warning disable 1717
namespace Org.Apache.Http.Conn.Scheme
{
		/// <java-name>
		/// org/apache/http/conn/scheme/HostNameResolver
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/HostNameResolver", AccessFlags = 1537)]
		public partial interface IHostNameResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/lang/String;)Ljava/net/InetAddress;", AccessFlags = 1025)]
				global::Java.Net.InetAddress Resolve(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/scheme/LayeredSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/LayeredSocketFactory", AccessFlags = 1537)]
		public partial interface ILayeredSocketFactory : global::Org.Apache.Http.Conn.Scheme.ISocketFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket CreateSocket(global::Java.Net.Socket socket, string @string, int int32, bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/scheme/SocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/SocketFactory", AccessFlags = 1537)]
		public partial interface ISocketFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connectSocket
				/// </java-name>
				[Dot42.DexImport("connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/para" +
    "ms/HttpParams;)Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket ConnectSocket(global::Java.Net.Socket socket, string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "(Ljava/net/Socket;)Z", AccessFlags = 1025)]
				bool IsSecure(global::Java.Net.Socket socket) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/conn/scheme/PlainSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/PlainSocketFactory", AccessFlags = 49)]
		public sealed partial class PlainSocketFactory : global::Org.Apache.Http.Conn.Scheme.ISocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/HostNameResolver;)V", AccessFlags = 1)]
				public PlainSocketFactory(global::Org.Apache.Http.Conn.Scheme.IHostNameResolver hostNameResolver) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PlainSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/PlainSocketFactory;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Scheme.PlainSocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.PlainSocketFactory);
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
				public static global::Org.Apache.Http.Conn.Scheme.PlainSocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/PlainSocketFactory;", AccessFlags = 9)]
						get{ return GetSocketFactory(); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/scheme/Scheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/Scheme", AccessFlags = 49)]
		public sealed partial class Scheme
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/apache/http/conn/scheme/SocketFactory;I)V", AccessFlags = 1)]
				public Scheme(string @string, global::Org.Apache.Http.Conn.Scheme.ISocketFactory socketFactory, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 17)]
				public int GetDefaultPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Scheme.ISocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.ISocketFactory);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 17)]
				public bool IsLayered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// resolvePort
				/// </java-name>
				[Dot42.DexImport("resolvePort", "(I)I", AccessFlags = 17)]
				public int ResolvePort(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Scheme() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				public int DefaultPort
				{
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 17)]
						get{ return GetDefaultPort(); }
				}

				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public global::Org.Apache.Http.Conn.Scheme.ISocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;", AccessFlags = 17)]
						get{ return GetSocketFactory(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetName(); }
				}

		}

		/// <java-name>
		/// org/apache/http/conn/scheme/SchemeRegistry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/SchemeRegistry", AccessFlags = 49)]
		public sealed partial class SchemeRegistry
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SchemeRegistry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme GetScheme(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "(Lorg/apache/http/HttpHost;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme GetScheme(global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme Get(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Lorg/apache/http/conn/scheme/Scheme;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme Register(global::Org.Apache.Http.Conn.Scheme.Scheme scheme) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme Unregister(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 49, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public global::Java.Util.IList<string> GetSchemeNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// setItems
				/// </java-name>
				[Dot42.DexImport("setItems", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/conn/scheme/Scheme;>;)V")]
				public void SetItems(global::Java.Util.IMap<string, global::Org.Apache.Http.Conn.Scheme.Scheme> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				public global::Java.Util.IList<string> SchemeNames
				{
				[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 49, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetSchemeNames(); }
				}

		}

}

