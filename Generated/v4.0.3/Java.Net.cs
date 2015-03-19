#pragma warning disable 1717
namespace Java.Net
{
		/// <java-name>
		/// java/net/FileNameMap
		/// </java-name>
		[Dot42.DexImport("java/net/FileNameMap", AccessFlags = 1537)]
		public partial interface IFileNameMap
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getContentTypeFor
				/// </java-name>
				[Dot42.DexImport("getContentTypeFor", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetContentTypeFor(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/CookieStore
		/// </java-name>
		[Dot42.DexImport("java/net/CookieStore", AccessFlags = 1537)]
		public partial interface ICookieStore
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/net/URI;Ljava/net/HttpCookie;)V", AccessFlags = 1025)]
				void Add(global::System.Uri uri, global::Java.Net.HttpCookie httpCookie) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/net/URI;)Ljava/util/List<Ljava/net/HttpCookie;>;")]
				global::Java.Util.IList<global::Java.Net.HttpCookie> Get(global::System.Uri uri) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCookies
				/// </java-name>
				[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/net/HttpCookie;>;")]
				global::Java.Util.IList<global::Java.Net.HttpCookie> GetCookies() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURIs
				/// </java-name>
				[Dot42.DexImport("getURIs", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/net/URI;>;")]
				global::Java.Util.IList<global::System.Uri> GetURIs() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/net/URI;Ljava/net/HttpCookie;)Z", AccessFlags = 1025)]
				bool Remove(global::System.Uri uri, global::Java.Net.HttpCookie httpCookie) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "()Z", AccessFlags = 1025)]
				bool RemoveAll() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/CookieHandler
		/// </java-name>
		[Dot42.DexImport("java/net/CookieHandler", AccessFlags = 1057)]
		public abstract partial class CookieHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/net/CookieHandler;", AccessFlags = 9)]
				public static global::Java.Net.CookieHandler GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.CookieHandler);
				}

				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/CookieHandler;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.CookieHandler cookieHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 1025, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public abstract global::Java.Util.IMap<string, global::Java.Util.IList<string>> Get(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)V")]
				public abstract void Put(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Net.CookieHandler Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/net/CookieHandler;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/net/CookieHandler;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

		}

		/// <java-name>
		/// java/net/NetworkInterface
		/// </java-name>
		[Dot42.DexImport("java/net/NetworkInterface", AccessFlags = 49)]
		public sealed partial class NetworkInterface
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NetworkInterface() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInetAddresses
				/// </java-name>
				[Dot42.DexImport("getInetAddresses", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/InetAddress;>;")]
				public global::Java.Util.IEnumeration<global::Java.Net.InetAddress> GetInetAddresses() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.InetAddress>);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getByName
				/// </java-name>
				[Dot42.DexImport("getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;", AccessFlags = 9)]
				public static global::Java.Net.NetworkInterface GetByName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <java-name>
				/// getByInetAddress
				/// </java-name>
				[Dot42.DexImport("getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;", AccessFlags = 9)]
				public static global::Java.Net.NetworkInterface GetByInetAddress(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <java-name>
				/// getNetworkInterfaces
				/// </java-name>
				[Dot42.DexImport("getNetworkInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
				public static global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> GetNetworkInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface>);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInterfaceAddresses
				/// </java-name>
				[Dot42.DexImport("getInterfaceAddresses", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/net/InterfaceAddress;>;")]
				public global::Java.Util.IList<global::Java.Net.InterfaceAddress> GetInterfaceAddresses() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Net.InterfaceAddress>);
				}

				/// <java-name>
				/// getSubInterfaces
				/// </java-name>
				[Dot42.DexImport("getSubInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
				public global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> GetSubInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface>);
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
				public global::Java.Net.NetworkInterface GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <java-name>
				/// isUp
				/// </java-name>
				[Dot42.DexImport("isUp", "()Z", AccessFlags = 1)]
				public bool IsUp() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLoopback
				/// </java-name>
				[Dot42.DexImport("isLoopback", "()Z", AccessFlags = 1)]
				public bool IsLoopback() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isPointToPoint
				/// </java-name>
				[Dot42.DexImport("isPointToPoint", "()Z", AccessFlags = 1)]
				public bool IsPointToPoint() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// supportsMulticast
				/// </java-name>
				[Dot42.DexImport("supportsMulticast", "()Z", AccessFlags = 1)]
				public bool SupportsMulticast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getHardwareAddress
				/// </java-name>
				[Dot42.DexImport("getHardwareAddress", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetHardwareAddress() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getHardwareAddress
				/// </java-name>
				[Dot42.DexImport("getHardwareAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetHardwareAddress() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getMTU
				/// </java-name>
				[Dot42.DexImport("getMTU", "()I", AccessFlags = 1)]
				public int GetMTU() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isVirtual
				/// </java-name>
				[Dot42.DexImport("isVirtual", "()Z", AccessFlags = 1)]
				public bool IsVirtual() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getInetAddresses
				/// </java-name>
				public global::Java.Util.IEnumeration<global::Java.Net.InetAddress> InetAddresses
				{
				[Dot42.DexImport("getInetAddresses", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/InetAddress;>;")]
						get{ return GetInetAddresses(); }
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDisplayName(); }
				}

				/// <java-name>
				/// getNetworkInterfaces
				/// </java-name>
				public static global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> NetworkInterfaces
				{
				[Dot42.DexImport("getNetworkInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
						get{ return GetNetworkInterfaces(); }
				}

				/// <java-name>
				/// getInterfaceAddresses
				/// </java-name>
				public global::Java.Util.IList<global::Java.Net.InterfaceAddress> InterfaceAddresses
				{
				[Dot42.DexImport("getInterfaceAddresses", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/net/InterfaceAddress;>;")]
						get{ return GetInterfaceAddresses(); }
				}

				/// <java-name>
				/// getSubInterfaces
				/// </java-name>
				public global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> SubInterfaces
				{
				[Dot42.DexImport("getSubInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
						get{ return GetSubInterfaces(); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Net.NetworkInterface Parent
				{
				[Dot42.DexImport("getParent", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

				/// <java-name>
				/// getHardwareAddress
				/// </java-name>
				public byte[] HardwareAddress
				{
				[Dot42.DexImport("getHardwareAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetHardwareAddress(); }
				}

				/// <java-name>
				/// getMTU
				/// </java-name>
				public int MTU
				{
				[Dot42.DexImport("getMTU", "()I", AccessFlags = 1)]
						get{ return GetMTU(); }
				}

		}

		/// <java-name>
		/// java/net/URL
		/// </java-name>
		[Dot42.DexImport("java/net/URL", AccessFlags = 49)]
		public sealed partial class URL : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public URL(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URL;Ljava/lang/String;)V", AccessFlags = 1)]
				public URL(global::Java.Net.URL uRL, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V", AccessFlags = 1)]
				public URL(global::Java.Net.URL uRL, string @string, global::Java.Net.URLStreamHandler uRLStreamHandler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public URL(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public URL(string @string, string string1, int int32, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandle" +
    "r;)V", AccessFlags = 1)]
				public URL(string @string, string string1, int int32, string string2, global::Java.Net.URLStreamHandler uRLStreamHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setURLStreamHandlerFactory
				/// </java-name>
				[Dot42.DexImport("setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V", AccessFlags = 41)]
				public static void SetURLStreamHandlerFactory(global::Java.Net.IURLStreamHandlerFactory uRLStreamHandlerFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				internal void Set(string @string, string string1, int int32, string string2, string string3) /* MethodBuilder.Create */ 
				{
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
				/// sameFile
				/// </java-name>
				[Dot42.DexImport("sameFile", "(Ljava/net/URL;)Z", AccessFlags = 1)]
				public bool SameFile(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
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
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object GetContent() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetContent(global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// openStream
				/// </java-name>
				[Dot42.DexImport("openStream", "()Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.Io.InputStream OpenStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "()Ljava/net/URLConnection;", AccessFlags = 1)]
				public global::Java.Net.URLConnection OpenConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLConnection);
				}

				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;", AccessFlags = 1)]
				public global::Java.Net.URLConnection OpenConnection(global::Java.Net.Proxy proxy) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLConnection);
				}

				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri ToURI() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
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
				/// toExternalForm
				/// </java-name>
				[Dot42.DexImport("toExternalForm", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToExternalForm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAuthority
				/// </java-name>
				[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetAuthority() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUserInfo
				/// </java-name>
				[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUserInfo() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 1)]
				public int GetDefaultPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFile
				/// </java-name>
				[Dot42.DexImport("getFile", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetFile() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuery
				/// </java-name>
				[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetQuery() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRef() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				internal void Set(string @string, string string1, int int32, string string2, string string3, string string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URL() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public object Content
				{
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 17)]
						get{ return GetContent(); }
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				public string Protocol
				{
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProtocol(); }
				}

				/// <java-name>
				/// getAuthority
				/// </java-name>
				public string Authority
				{
				[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAuthority(); }
				}

				/// <java-name>
				/// getUserInfo
				/// </java-name>
				public string UserInfo
				{
				[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserInfo(); }
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public string Host
				{
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHost(); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				public int DefaultPort
				{
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 1)]
						get{ return GetDefaultPort(); }
				}

				/// <java-name>
				/// getFile
				/// </java-name>
				public string File
				{
				[Dot42.DexImport("getFile", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFile(); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				}

				/// <java-name>
				/// getQuery
				/// </java-name>
				public string Query
				{
				[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetQuery(); }
				}

				/// <java-name>
				/// getRef
				/// </java-name>
				public string Ref
				{
				[Dot42.DexImport("getRef", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRef(); }
				}

		}

		/// <java-name>
		/// java/net/ResponseCache
		/// </java-name>
		[Dot42.DexImport("java/net/ResponseCache", AccessFlags = 1057)]
		public abstract partial class ResponseCache
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/net/ResponseCache;", AccessFlags = 9)]
				public static global::Java.Net.ResponseCache GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ResponseCache);
				}

				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/ResponseCache;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.ResponseCache responseCache) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;", AccessFlags = 1025, Signature = "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/util/List" +
    "<Ljava/lang/String;>;>;)Ljava/net/CacheResponse;")]
				public abstract global::Java.Net.CacheResponse Get(global::System.Uri uri, string @string, global::Java.Util.IMap<string, global::Java.Util.IList<string>> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;", AccessFlags = 1025)]
				public abstract global::Java.Net.CacheRequest Put(global::System.Uri uri, global::Java.Net.URLConnection uRLConnection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Net.ResponseCache Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/net/ResponseCache;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/net/ResponseCache;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

		}

		/// <java-name>
		/// java/net/DatagramPacket
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramPacket", AccessFlags = 49)]
		public sealed partial class DatagramPacket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, int int321, global::Java.Net.InetAddress inetAddress, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/net/InetAddress;I)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, int int321, global::Java.Net.InetAddress inetAddress, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/InetAddress;I)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/SocketAddress;)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/SocketAddress;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/net/SocketAddress;)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, int int321, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/net/SocketAddress;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, int int321, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 33)]
				public global::Java.Net.InetAddress GetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 33)]
				public sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 33, IgnoreFromJava = true)]
				public byte[] GetData() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 33)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 33)]
				public int GetOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 33)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAddress
				/// </java-name>
				[Dot42.DexImport("setAddress", "(Ljava/net/InetAddress;)V", AccessFlags = 33)]
				public void SetAddress(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([BII)V", AccessFlags = 33)]
				public void SetData(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public void SetData(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([B)V", AccessFlags = 33)]
				public void SetData(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public void SetData(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 33)]
				public void SetLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPort
				/// </java-name>
				[Dot42.DexImport("setPort", "(I)V", AccessFlags = 33)]
				public void SetPort(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocketAddress
				/// </java-name>
				[Dot42.DexImport("getSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 33)]
				public global::Java.Net.SocketAddress GetSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <java-name>
				/// setSocketAddress
				/// </java-name>
				[Dot42.DexImport("setSocketAddress", "(Ljava/net/SocketAddress;)V", AccessFlags = 33)]
				public void SetSocketAddress(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DatagramPacket() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public global::Java.Net.InetAddress Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 33)]
						get{ return GetAddress(); }
				[Dot42.DexImport("setAddress", "(Ljava/net/InetAddress;)V", AccessFlags = 33)]
						set{ SetAddress(value); }
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public byte[] Data
				{
				[Dot42.DexImport("getData", "()[B", AccessFlags = 33, IgnoreFromJava = true)]
						get{ return GetData(); }
				[Dot42.DexImport("setData", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
						set{ SetData(value); }
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("getLength", "()I", AccessFlags = 33)]
						get{ return GetLength(); }
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 33)]
						set{ SetLength(value); }
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 33)]
						get{ return GetOffset(); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 33)]
						get{ return GetPort(); }
				[Dot42.DexImport("setPort", "(I)V", AccessFlags = 33)]
						set{ SetPort(value); }
				}

				/// <java-name>
				/// getSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress SocketAddress
				{
				[Dot42.DexImport("getSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 33)]
						get{ return GetSocketAddress(); }
				[Dot42.DexImport("setSocketAddress", "(Ljava/net/SocketAddress;)V", AccessFlags = 33)]
						set{ SetSocketAddress(value); }
				}

		}

		/// <java-name>
		/// java/net/ConnectException
		/// </java-name>
		[Dot42.DexImport("java/net/ConnectException", AccessFlags = 33)]
		public partial class ConnectException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/CacheResponse
		/// </java-name>
		[Dot42.DexImport("java/net/CacheResponse", AccessFlags = 1057)]
		public abstract partial class CacheResponse
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CacheResponse() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBody
				/// </java-name>
				[Dot42.DexImport("getBody", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				public abstract global::Java.Io.InputStream GetBody() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public abstract global::Java.Util.IMap<string, global::Java.Util.IList<string>> GetHeaders() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBody
				/// </java-name>
				public global::Java.Io.InputStream Body
				{
				[Dot42.DexImport("getBody", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get{ return GetBody(); }
				}

				/// <java-name>
				/// getHeaders
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.IList<string>> Headers
				{
				[Dot42.DexImport("getHeaders", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
						get{ return GetHeaders(); }
				}

		}

		/// <java-name>
		/// java/net/SocketTimeoutException
		/// </java-name>
		[Dot42.DexImport("java/net/SocketTimeoutException", AccessFlags = 33)]
		public partial class SocketTimeoutException : global::Java.Io.InterruptedIOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SocketTimeoutException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/ProxySelector
		/// </java-name>
		[Dot42.DexImport("java/net/ProxySelector", AccessFlags = 1057)]
		public abstract partial class ProxySelector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProxySelector() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/net/ProxySelector;", AccessFlags = 9)]
				public static global::Java.Net.ProxySelector GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ProxySelector);
				}

				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/ProxySelector;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.ProxySelector proxySelector) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// select
				/// </java-name>
				[Dot42.DexImport("select", "(Ljava/net/URI;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/net/URI;)Ljava/util/List<Ljava/net/Proxy;>;")]
				public abstract global::Java.Util.IList<global::Java.Net.Proxy> Select(global::System.Uri uri) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connectFailed
				/// </java-name>
				[Dot42.DexImport("connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V", AccessFlags = 1025)]
				public abstract void ConnectFailed(global::System.Uri uri, global::Java.Net.SocketAddress socketAddress, global::System.IO.IOException iOException) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Net.ProxySelector Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/net/ProxySelector;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/net/ProxySelector;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

		}

		/// <java-name>
		/// java/net/ContentHandlerFactory
		/// </java-name>
		[Dot42.DexImport("java/net/ContentHandlerFactory", AccessFlags = 1537)]
		public partial interface IContentHandlerFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createContentHandler
				/// </java-name>
				[Dot42.DexImport("createContentHandler", "(Ljava/lang/String;)Ljava/net/ContentHandler;", AccessFlags = 1025)]
				global::Java.Net.ContentHandler CreateContentHandler(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/HttpCookie
		/// </java-name>
		[Dot42.DexImport("java/net/HttpCookie", AccessFlags = 49)]
		public sealed partial class HttpCookie : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpCookie(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// domainMatches
				/// </java-name>
				[Dot42.DexImport("domainMatches", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool DomainMatches(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/util/List<Ljava/net/HttpCookie;>;")]
				public static global::Java.Util.IList<global::Java.Net.HttpCookie> Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Net.HttpCookie>);
				}

				/// <java-name>
				/// getComment
				/// </java-name>
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetComment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCommentURL() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDiscard
				/// </java-name>
				[Dot42.DexImport("getDiscard", "()Z", AccessFlags = 1)]
				public bool GetDiscard() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetDomain() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMaxAge
				/// </java-name>
				[Dot42.DexImport("getMaxAge", "()J", AccessFlags = 1)]
				public long GetMaxAge() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPortlist
				/// </java-name>
				[Dot42.DexImport("getPortlist", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPortlist() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSecure
				/// </java-name>
				[Dot42.DexImport("getSecure", "()Z", AccessFlags = 1)]
				public bool GetSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hasExpired
				/// </java-name>
				[Dot42.DexImport("hasExpired", "()Z", AccessFlags = 1)]
				public bool HasExpired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetComment(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCommentURL
				/// </java-name>
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetCommentURL(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDiscard
				/// </java-name>
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1)]
				public void SetDiscard(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDomain
				/// </java-name>
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetDomain(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxAge
				/// </java-name>
				[Dot42.DexImport("setMaxAge", "(J)V", AccessFlags = 1)]
				public void SetMaxAge(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetPath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPortlist
				/// </java-name>
				[Dot42.DexImport("setPortlist", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetPortlist(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSecure
				/// </java-name>
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1)]
				public void SetSecure(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetValue(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
				public void SetVersion(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpCookie() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getComment
				/// </java-name>
				public string Comment
				{
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetComment(); }
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetComment(value); }
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				public string CommentURL
				{
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCommentURL(); }
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCommentURL(value); }
				}

				/// <java-name>
				/// getDiscard
				/// </java-name>
				public bool IsDiscard
				{
				[Dot42.DexImport("getDiscard", "()Z", AccessFlags = 1)]
						get{ return GetDiscard(); }
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1)]
						set{ SetDiscard(value); }
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				public string Domain
				{
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDomain(); }
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetDomain(value); }
				}

				/// <java-name>
				/// getMaxAge
				/// </java-name>
				public long MaxAge
				{
				[Dot42.DexImport("getMaxAge", "()J", AccessFlags = 1)]
						get{ return GetMaxAge(); }
				[Dot42.DexImport("setMaxAge", "(J)V", AccessFlags = 1)]
						set{ SetMaxAge(value); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPath(value); }
				}

				/// <java-name>
				/// getPortlist
				/// </java-name>
				public string Portlist
				{
				[Dot42.DexImport("getPortlist", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPortlist(); }
				[Dot42.DexImport("setPortlist", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPortlist(value); }
				}

				/// <java-name>
				/// getSecure
				/// </java-name>
				public bool IsSecure
				{
				[Dot42.DexImport("getSecure", "()Z", AccessFlags = 1)]
						get{ return GetSecure(); }
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1)]
						set{ SetSecure(value); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetValue(value); }
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
						set{ SetVersion(value); }
				}

		}

		/// <java-name>
		/// java/net/SecureCacheResponse
		/// </java-name>
		[Dot42.DexImport("java/net/SecureCacheResponse", AccessFlags = 1057)]
		public abstract partial class SecureCacheResponse : global::Java.Net.CacheResponse
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecureCacheResponse() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetCipherSuite() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalCertificateChain
				/// </java-name>
				[Dot42.DexImport("getLocalCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
				public abstract global::Java.Util.IList<global::Java.Security.Cert.Certificate> GetLocalCertificateChain() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getServerCertificateChain
				/// </java-name>
				[Dot42.DexImport("getServerCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
				public abstract global::Java.Util.IList<global::Java.Security.Cert.Certificate> GetServerCertificateChain() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				public string CipherSuite
				{
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetCipherSuite(); }
				}

				/// <java-name>
				/// getLocalCertificateChain
				/// </java-name>
				public global::Java.Util.IList<global::Java.Security.Cert.Certificate> LocalCertificateChain
				{
				[Dot42.DexImport("getLocalCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
						get{ return GetLocalCertificateChain(); }
				}

				/// <java-name>
				/// getServerCertificateChain
				/// </java-name>
				public global::Java.Util.IList<global::Java.Security.Cert.Certificate> ServerCertificateChain
				{
				[Dot42.DexImport("getServerCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
						get{ return GetServerCertificateChain(); }
				}

				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal PeerPrincipal
				{
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get{ return GetPeerPrincipal(); }
				}

				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal LocalPrincipal
				{
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get{ return GetLocalPrincipal(); }
				}

		}

		/// <java-name>
		/// java/net/DatagramSocketImpl
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramSocketImpl", AccessFlags = 1057)]
		public abstract partial class DatagramSocketImpl : global::Java.Net.ISocketOptions
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// fd
				/// </java-name>
				[Dot42.DexImport("fd", "Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal global::Java.Io.FileDescriptor Fd;
				/// <java-name>
				/// localPort
				/// </java-name>
				[Dot42.DexImport("localPort", "I", AccessFlags = 4)]
				protected internal int LocalPort;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatagramSocketImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(ILjava/net/InetAddress;)V", AccessFlags = 1028)]
				protected internal abstract void Bind(int int32, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1028)]
				protected internal abstract void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "()V", AccessFlags = 1028)]
				protected internal abstract void Create() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal virtual global::Java.Io.FileDescriptor GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1028)]
				protected internal abstract sbyte JavaGetTTL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte GetTTL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1028)]
				protected internal abstract int GetTimeToLive() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Ljava/net/InetAddress;)V", AccessFlags = 1028)]
				protected internal abstract void Join(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// joinGroup
				/// </java-name>
				[Dot42.DexImport("joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1028)]
				protected internal abstract void JoinGroup(global::Java.Net.SocketAddress socketAddress, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// leave
				/// </java-name>
				[Dot42.DexImport("leave", "(Ljava/net/InetAddress;)V", AccessFlags = 1028)]
				protected internal abstract void Leave(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// leaveGroup
				/// </java-name>
				[Dot42.DexImport("leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1028)]
				protected internal abstract void LeaveGroup(global::Java.Net.SocketAddress socketAddress, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "(Ljava/net/InetAddress;)I", AccessFlags = 1028)]
				protected internal abstract int Peek(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(Ljava/net/DatagramPacket;)V", AccessFlags = 1028)]
				protected internal abstract void Receive(global::Java.Net.DatagramPacket datagramPacket) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;)V", AccessFlags = 1028)]
				protected internal abstract void Send(global::Java.Net.DatagramPacket datagramPacket) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTimeToLive
				/// </java-name>
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1028)]
				protected internal abstract void SetTimeToLive(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1028)]
				protected internal abstract void SetTTL(sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void SetTTL(byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal virtual void Connect(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 4)]
				protected internal virtual void Disconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// peekData
				/// </java-name>
				[Dot42.DexImport("peekData", "(Ljava/net/DatagramPacket;)I", AccessFlags = 1028)]
				protected internal abstract int PeekData(global::Java.Net.DatagramPacket datagramPacket) /* MethodBuilder.Create */ ;

				[Dot42.DexImport("java/net/SocketOptions", "getOption", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetOption(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("java/net/SocketOptions", "setOption", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				public virtual void SetOption(int int32, object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				protected internal global::Java.Io.FileDescriptor FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
						get{ return GetFileDescriptor(); }
				}

				/// <java-name>
				/// getTTL
				/// </java-name>
				protected internal byte TTL
				{
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1028, IgnoreFromJava = true)]
						get{ return GetTTL(); }
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
						set{ SetTTL(value); }
				}

				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				protected internal int TimeToLive
				{
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1028)]
						get{ return GetTimeToLive(); }
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1028)]
						set{ SetTimeToLive(value); }
				}

		}

		/// <java-name>
		/// java/net/MulticastSocket
		/// </java-name>
		[Dot42.DexImport("java/net/MulticastSocket", AccessFlags = 33)]
		public partial class MulticastSocket : global::Java.Net.DatagramSocket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MulticastSocket() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MulticastSocket(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public MulticastSocket(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterface
				/// </java-name>
				[Dot42.DexImport("getInterface", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getNetworkInterface
				/// </java-name>
				[Dot42.DexImport("getNetworkInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
				public virtual global::Java.Net.NetworkInterface GetNetworkInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1)]
				public virtual int GetTimeToLive() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1)]
				public virtual sbyte JavaGetTTL() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte GetTTL() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// joinGroup
				/// </java-name>
				[Dot42.DexImport("joinGroup", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void JoinGroup(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// joinGroup
				/// </java-name>
				[Dot42.DexImport("joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
				public virtual void JoinGroup(global::Java.Net.SocketAddress socketAddress, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// leaveGroup
				/// </java-name>
				[Dot42.DexImport("leaveGroup", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void LeaveGroup(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// leaveGroup
				/// </java-name>
				[Dot42.DexImport("leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
				public virtual void LeaveGroup(global::Java.Net.SocketAddress socketAddress, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;B)V", AccessFlags = 1)]
				public virtual void Send(global::Java.Net.DatagramPacket datagramPacket, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Send(global::Java.Net.DatagramPacket datagramPacket, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInterface
				/// </java-name>
				[Dot42.DexImport("setInterface", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void SetInterface(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNetworkInterface
				/// </java-name>
				[Dot42.DexImport("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
				public virtual void SetNetworkInterface(global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTimeToLive
				/// </java-name>
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1)]
				public virtual void SetTimeToLive(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1)]
				public virtual void SetTTL(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetTTL(byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLoopbackMode
				/// </java-name>
				[Dot42.DexImport("getLoopbackMode", "()Z", AccessFlags = 1)]
				public virtual bool GetLoopbackMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLoopbackMode
				/// </java-name>
				[Dot42.DexImport("setLoopbackMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetLoopbackMode(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterface
				/// </java-name>
				public global::Java.Net.InetAddress Interface
				{
				[Dot42.DexImport("getInterface", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInterface(); }
				[Dot42.DexImport("setInterface", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
						set{ SetInterface(value); }
				}

				/// <java-name>
				/// getNetworkInterface
				/// </java-name>
				public global::Java.Net.NetworkInterface NetworkInterface
				{
				[Dot42.DexImport("getNetworkInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
						get{ return GetNetworkInterface(); }
				[Dot42.DexImport("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
						set{ SetNetworkInterface(value); }
				}

				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				public int TimeToLive
				{
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1)]
						get{ return GetTimeToLive(); }
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1)]
						set{ SetTimeToLive(value); }
				}

				/// <java-name>
				/// getTTL
				/// </java-name>
				public byte TTL
				{
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetTTL(); }
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
						set{ SetTTL(value); }
				}

				/// <java-name>
				/// getLoopbackMode
				/// </java-name>
				public bool IsLoopbackMode
				{
				[Dot42.DexImport("getLoopbackMode", "()Z", AccessFlags = 1)]
						get{ return GetLoopbackMode(); }
				[Dot42.DexImport("setLoopbackMode", "(Z)V", AccessFlags = 1)]
						set{ SetLoopbackMode(value); }
				}

		}

		/// <java-name>
		/// java/net/URLStreamHandlerFactory
		/// </java-name>
		[Dot42.DexImport("java/net/URLStreamHandlerFactory", AccessFlags = 1537)]
		public partial interface IURLStreamHandlerFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createURLStreamHandler
				/// </java-name>
				[Dot42.DexImport("createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;", AccessFlags = 1025)]
				global::Java.Net.URLStreamHandler CreateURLStreamHandler(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/SocketImplFactory
		/// </java-name>
		[Dot42.DexImport("java/net/SocketImplFactory", AccessFlags = 1537)]
		public partial interface ISocketImplFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createSocketImpl
				/// </java-name>
				[Dot42.DexImport("createSocketImpl", "()Ljava/net/SocketImpl;", AccessFlags = 1025)]
				global::Java.Net.SocketImpl CreateSocketImpl() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/CacheRequest
		/// </java-name>
		[Dot42.DexImport("java/net/CacheRequest", AccessFlags = 1057)]
		public abstract partial class CacheRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CacheRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				public abstract void Abort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBody
				/// </java-name>
				[Dot42.DexImport("getBody", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
				public abstract global::Java.Io.OutputStream GetBody() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBody
				/// </java-name>
				public global::Java.Io.OutputStream Body
				{
				[Dot42.DexImport("getBody", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
						get{ return GetBody(); }
				}

		}

		/// <java-name>
		/// java/net/InetSocketAddress
		/// </java-name>
		[Dot42.DexImport("java/net/InetSocketAddress", AccessFlags = 33)]
		public partial class InetSocketAddress : global::Java.Net.SocketAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public InetSocketAddress(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public InetSocketAddress(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public InetSocketAddress(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createUnresolved
				/// </java-name>
				[Dot42.DexImport("createUnresolved", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetSocketAddress CreateUnresolved(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetSocketAddress);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 17)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
				public global::Java.Net.InetAddress GetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getHostName
				/// </java-name>
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isUnresolved
				/// </java-name>
				[Dot42.DexImport("isUnresolved", "()Z", AccessFlags = 17)]
				public bool IsUnresolved() /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InetSocketAddress() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 17)]
						get{ return GetPort(); }
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public global::Java.Net.InetAddress Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
						get{ return GetAddress(); }
				}

				/// <java-name>
				/// getHostName
				/// </java-name>
				public string HostName
				{
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetHostName(); }
				}

		}

		/// <java-name>
		/// java/net/URLEncoder
		/// </java-name>
		[Dot42.DexImport("java/net/URLEncoder", AccessFlags = 33)]
		public partial class URLEncoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal URLEncoder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/net/PortUnreachableException
		/// </java-name>
		[Dot42.DexImport("java/net/PortUnreachableException", AccessFlags = 33)]
		public partial class PortUnreachableException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PortUnreachableException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PortUnreachableException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/SocketPermission
		/// </java-name>
		[Dot42.DexImport("java/net/SocketPermission", AccessFlags = 49)]
		public sealed partial class SocketPermission : global::Java.Security.Permission, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SocketPermission(string @string, string string1) /* MethodBuilder.Create */ 
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
				internal SocketPermission() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <java-name>
		/// java/net/URLDecoder
		/// </java-name>
		[Dot42.DexImport("java/net/URLDecoder", AccessFlags = 33)]
		public partial class URLDecoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLDecoder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Decode(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/net/BindException
		/// </java-name>
		[Dot42.DexImport("java/net/BindException", AccessFlags = 33)]
		public partial class BindException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BindException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BindException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/Inet4Address
		/// </java-name>
		[Dot42.DexImport("java/net/Inet4Address", AccessFlags = 49)]
		public sealed partial class Inet4Address : global::Java.Net.InetAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Inet4Address() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAnyLocalAddress
				/// </java-name>
				[Dot42.DexImport("isAnyLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsAnyLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLinkLocalAddress
				/// </java-name>
				[Dot42.DexImport("isLinkLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsLinkLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLoopbackAddress
				/// </java-name>
				[Dot42.DexImport("isLoopbackAddress", "()Z", AccessFlags = 1)]
				public override bool IsLoopbackAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCGlobal
				/// </java-name>
				[Dot42.DexImport("isMCGlobal", "()Z", AccessFlags = 1)]
				public override bool IsMCGlobal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCLinkLocal
				/// </java-name>
				[Dot42.DexImport("isMCLinkLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCLinkLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCNodeLocal
				/// </java-name>
				[Dot42.DexImport("isMCNodeLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCNodeLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCOrgLocal
				/// </java-name>
				[Dot42.DexImport("isMCOrgLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCOrgLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCSiteLocal
				/// </java-name>
				[Dot42.DexImport("isMCSiteLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCSiteLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMulticastAddress
				/// </java-name>
				[Dot42.DexImport("isMulticastAddress", "()Z", AccessFlags = 1)]
				public override bool IsMulticastAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSiteLocalAddress
				/// </java-name>
				[Dot42.DexImport("isSiteLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsSiteLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/net/Inet6Address
		/// </java-name>
		[Dot42.DexImport("java/net/Inet6Address", AccessFlags = 49)]
		public sealed partial class Inet6Address : global::Java.Net.InetAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Inet6Address() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;", AccessFlags = 9)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;", AccessFlags = 9)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, sbyte[] sByte, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, byte[] @byte, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// isAnyLocalAddress
				/// </java-name>
				[Dot42.DexImport("isAnyLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsAnyLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isIPv4CompatibleAddress
				/// </java-name>
				[Dot42.DexImport("isIPv4CompatibleAddress", "()Z", AccessFlags = 1)]
				public bool IsIPv4CompatibleAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLinkLocalAddress
				/// </java-name>
				[Dot42.DexImport("isLinkLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsLinkLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLoopbackAddress
				/// </java-name>
				[Dot42.DexImport("isLoopbackAddress", "()Z", AccessFlags = 1)]
				public override bool IsLoopbackAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCGlobal
				/// </java-name>
				[Dot42.DexImport("isMCGlobal", "()Z", AccessFlags = 1)]
				public override bool IsMCGlobal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCLinkLocal
				/// </java-name>
				[Dot42.DexImport("isMCLinkLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCLinkLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCNodeLocal
				/// </java-name>
				[Dot42.DexImport("isMCNodeLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCNodeLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCOrgLocal
				/// </java-name>
				[Dot42.DexImport("isMCOrgLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCOrgLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCSiteLocal
				/// </java-name>
				[Dot42.DexImport("isMCSiteLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCSiteLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMulticastAddress
				/// </java-name>
				[Dot42.DexImport("isMulticastAddress", "()Z", AccessFlags = 1)]
				public override bool IsMulticastAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSiteLocalAddress
				/// </java-name>
				[Dot42.DexImport("isSiteLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsSiteLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getScopeId
				/// </java-name>
				[Dot42.DexImport("getScopeId", "()I", AccessFlags = 1)]
				public int GetScopeId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScopedInterface
				/// </java-name>
				[Dot42.DexImport("getScopedInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
				public global::Java.Net.NetworkInterface GetScopedInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
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
				/// getScopeId
				/// </java-name>
				public int ScopeId
				{
				[Dot42.DexImport("getScopeId", "()I", AccessFlags = 1)]
						get{ return GetScopeId(); }
				}

				/// <java-name>
				/// getScopedInterface
				/// </java-name>
				public global::Java.Net.NetworkInterface ScopedInterface
				{
				[Dot42.DexImport("getScopedInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
						get{ return GetScopedInterface(); }
				}

		}

		/// <java-name>
		/// java/net/HttpRetryException
		/// </java-name>
		[Dot42.DexImport("java/net/HttpRetryException", AccessFlags = 33)]
		public partial class HttpRetryException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public HttpRetryException(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public HttpRetryException(string @string, int int32, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocation
				/// </java-name>
				[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocation() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReason() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// responseCode
				/// </java-name>
				[Dot42.DexImport("responseCode", "()I", AccessFlags = 1)]
				public virtual int ResponseCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpRetryException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLocation
				/// </java-name>
				public string Location
				{
				[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocation(); }
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				public string Reason
				{
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReason(); }
				}

		}

		/// <java-name>
		/// java/net/ProtocolException
		/// </java-name>
		[Dot42.DexImport("java/net/ProtocolException", AccessFlags = 33)]
		public partial class ProtocolException : global::System.IO.IOException
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

		}

		/// <java-name>
		/// java/net/NoRouteToHostException
		/// </java-name>
		[Dot42.DexImport("java/net/NoRouteToHostException", AccessFlags = 33)]
		public partial class NoRouteToHostException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoRouteToHostException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoRouteToHostException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/PasswordAuthentication
		/// </java-name>
		[Dot42.DexImport("java/net/PasswordAuthentication", AccessFlags = 49)]
		public sealed partial class PasswordAuthentication
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;[C)V", AccessFlags = 1)]
				public PasswordAuthentication(string @string, char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
				public char[] GetPassword() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUserName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PasswordAuthentication() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public char[] Password
				{
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
						get{ return GetPassword(); }
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				public string UserName
				{
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserName(); }
				}

		}

		/// <java-name>
		/// java/net/UnknownServiceException
		/// </java-name>
		[Dot42.DexImport("java/net/UnknownServiceException", AccessFlags = 33)]
		public partial class UnknownServiceException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnknownServiceException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownServiceException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/SocketImpl
		/// </java-name>
		[Dot42.DexImport("java/net/SocketImpl", AccessFlags = 1057)]
		public abstract partial class SocketImpl : global::Java.Net.ISocketOptions
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// address
				/// </java-name>
				[Dot42.DexImport("address", "Ljava/net/InetAddress;", AccessFlags = 4)]
				protected internal global::Java.Net.InetAddress Address;
				/// <java-name>
				/// port
				/// </java-name>
				[Dot42.DexImport("port", "I", AccessFlags = 4)]
				protected internal int Port;
				/// <java-name>
				/// fd
				/// </java-name>
				[Dot42.DexImport("fd", "Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal global::Java.Io.FileDescriptor Fd;
				/// <java-name>
				/// localport
				/// </java-name>
				[Dot42.DexImport("localport", "I", AccessFlags = 4)]
				protected internal int Localport;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(Ljava/net/SocketImpl;)V", AccessFlags = 1028)]
				protected internal abstract void Accept(global::Java.Net.SocketImpl socketImpl) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1028)]
				protected internal abstract int Available() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/InetAddress;I)V", AccessFlags = 1028)]
				protected internal abstract void Bind(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1028)]
				protected internal abstract void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/lang/String;I)V", AccessFlags = 1028)]
				protected internal abstract void Connect(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/InetAddress;I)V", AccessFlags = 1028)]
				protected internal abstract void Connect(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Z)V", AccessFlags = 1028)]
				protected internal abstract void Create(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal virtual global::Java.Io.FileDescriptor GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1028)]
				protected internal abstract global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1028)]
				protected internal abstract global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// listen
				/// </java-name>
				[Dot42.DexImport("listen", "(I)V", AccessFlags = 1028)]
				protected internal abstract void Listen(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;I)V", AccessFlags = 1028)]
				protected internal abstract void Connect(global::Java.Net.SocketAddress socketAddress, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsUrgentData
				/// </java-name>
				[Dot42.DexImport("supportsUrgentData", "()Z", AccessFlags = 4)]
				protected internal virtual bool SupportsUrgentData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendUrgentData
				/// </java-name>
				[Dot42.DexImport("sendUrgentData", "(I)V", AccessFlags = 1028)]
				protected internal abstract void SendUrgentData(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setPerformancePreferences
				/// </java-name>
				[Dot42.DexImport("setPerformancePreferences", "(III)V", AccessFlags = 4)]
				protected internal virtual void SetPerformancePreferences(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("java/net/SocketOptions", "getOption", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetOption(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("java/net/SocketOptions", "setOption", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				public virtual void SetOption(int int32, object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				protected internal global::Java.Io.FileDescriptor FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
						get{ return GetFileDescriptor(); }
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				protected internal global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 4)]
						get{ return GetInetAddress(); }
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				protected internal global::Java.Io.InputStream InputStream
				{
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1028)]
						get{ return GetInputStream(); }
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				protected internal int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 4)]
						get{ return GetLocalPort(); }
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				protected internal global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1028)]
						get{ return GetOutputStream(); }
				}

		}

		/// <java-name>
		/// java/net/CookiePolicy
		/// </java-name>
		[Dot42.DexImport("java/net/CookiePolicy", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICookiePolicyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACCEPT_ALL
				/// </java-name>
				[Dot42.DexImport("ACCEPT_ALL", "Ljava/net/CookiePolicy;", AccessFlags = 25)]
				public static readonly global::Java.Net.ICookiePolicy ACCEPT_ALL;
				/// <java-name>
				/// ACCEPT_NONE
				/// </java-name>
				[Dot42.DexImport("ACCEPT_NONE", "Ljava/net/CookiePolicy;", AccessFlags = 25)]
				public static readonly global::Java.Net.ICookiePolicy ACCEPT_NONE;
				/// <java-name>
				/// ACCEPT_ORIGINAL_SERVER
				/// </java-name>
				[Dot42.DexImport("ACCEPT_ORIGINAL_SERVER", "Ljava/net/CookiePolicy;", AccessFlags = 25)]
				public static readonly global::Java.Net.ICookiePolicy ACCEPT_ORIGINAL_SERVER;
		}

		/// <java-name>
		/// java/net/CookiePolicy
		/// </java-name>
		[Dot42.DexImport("java/net/CookiePolicy", AccessFlags = 1537)]
		public partial interface ICookiePolicy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// shouldAccept
				/// </java-name>
				[Dot42.DexImport("shouldAccept", "(Ljava/net/URI;Ljava/net/HttpCookie;)Z", AccessFlags = 1025)]
				bool ShouldAccept(global::System.Uri uri, global::Java.Net.HttpCookie httpCookie) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/URLConnection
		/// </java-name>
		[Dot42.DexImport("java/net/URLConnection", AccessFlags = 1057)]
		public abstract partial class URLConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// url
				/// </java-name>
				[Dot42.DexImport("url", "Ljava/net/URL;", AccessFlags = 4)]
				protected internal global::Java.Net.URL Url;
				/// <java-name>
				/// ifModifiedSince
				/// </java-name>
				[Dot42.DexImport("ifModifiedSince", "J", AccessFlags = 4)]
				protected internal long IfModifiedSince;
				/// <java-name>
				/// useCaches
				/// </java-name>
				[Dot42.DexImport("useCaches", "Z", AccessFlags = 4)]
				protected internal bool UseCaches;
				/// <java-name>
				/// connected
				/// </java-name>
				[Dot42.DexImport("connected", "Z", AccessFlags = 4)]
				protected internal bool Connected;
				/// <java-name>
				/// doOutput
				/// </java-name>
				[Dot42.DexImport("doOutput", "Z", AccessFlags = 4)]
				protected internal bool DoOutput;
				/// <java-name>
				/// doInput
				/// </java-name>
				[Dot42.DexImport("doInput", "Z", AccessFlags = 4)]
				protected internal bool DoInput;
				/// <java-name>
				/// allowUserInteraction
				/// </java-name>
				[Dot42.DexImport("allowUserInteraction", "Z", AccessFlags = 4)]
				protected internal bool AllowUserInteraction;
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal URLConnection(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1025)]
				public abstract void Connect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("getAllowUserInteraction", "()Z", AccessFlags = 1)]
				public virtual bool GetAllowUserInteraction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetContent() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetContent(global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetContentEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()I", AccessFlags = 1)]
				public virtual int GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				[Dot42.DexImport("getContentType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetContentType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "()J", AccessFlags = 1)]
				public virtual long GetDate() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getDefaultAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("getDefaultAllowUserInteraction", "()Z", AccessFlags = 9)]
				public static bool GetDefaultAllowUserInteraction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultRequestProperty
				/// </java-name>
				[Dot42.DexImport("getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetDefaultRequestProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDefaultUseCaches
				/// </java-name>
				[Dot42.DexImport("getDefaultUseCaches", "()Z", AccessFlags = 1)]
				public virtual bool GetDefaultUseCaches() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDoInput
				/// </java-name>
				[Dot42.DexImport("getDoInput", "()Z", AccessFlags = 1)]
				public virtual bool GetDoInput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDoOutput
				/// </java-name>
				[Dot42.DexImport("getDoOutput", "()Z", AccessFlags = 1)]
				public virtual bool GetDoOutput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getExpiration
				/// </java-name>
				[Dot42.DexImport("getExpiration", "()J", AccessFlags = 1)]
				public virtual long GetExpiration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFileNameMap
				/// </java-name>
				[Dot42.DexImport("getFileNameMap", "()Ljava/net/FileNameMap;", AccessFlags = 9)]
				public static global::Java.Net.IFileNameMap GetFileNameMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.IFileNameMap);
				}

				/// <java-name>
				/// getHeaderField
				/// </java-name>
				[Dot42.DexImport("getHeaderField", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHeaderField(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHeaderFields
				/// </java-name>
				[Dot42.DexImport("getHeaderFields", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Util.IList<string>> GetHeaderFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.IList<string>>);
				}

				/// <java-name>
				/// getRequestProperties
				/// </java-name>
				[Dot42.DexImport("getRequestProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Util.IList<string>> GetRequestProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.IList<string>>);
				}

				/// <java-name>
				/// addRequestProperty
				/// </java-name>
				[Dot42.DexImport("addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddRequestProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHeaderField
				/// </java-name>
				[Dot42.DexImport("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHeaderField(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHeaderFieldDate
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldDate", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long GetHeaderFieldDate(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getHeaderFieldInt
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetHeaderFieldInt(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeaderFieldKey
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldKey", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHeaderFieldKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getIfModifiedSince
				/// </java-name>
				[Dot42.DexImport("getIfModifiedSince", "()J", AccessFlags = 1)]
				public virtual long GetIfModifiedSince() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// getLastModified
				/// </java-name>
				[Dot42.DexImport("getLastModified", "()J", AccessFlags = 1)]
				public virtual long GetLastModified() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// getPermission
				/// </java-name>
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
				public virtual global::Java.Security.Permission GetPermission() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Permission);
				}

				/// <java-name>
				/// getRequestProperty
				/// </java-name>
				[Dot42.DexImport("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetRequestProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL GetURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getUseCaches
				/// </java-name>
				[Dot42.DexImport("getUseCaches", "()Z", AccessFlags = 1)]
				public virtual bool GetUseCaches() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// guessContentTypeFromName
				/// </java-name>
				[Dot42.DexImport("guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GuessContentTypeFromName(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// guessContentTypeFromStream
				/// </java-name>
				[Dot42.DexImport("guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GuessContentTypeFromStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("setAllowUserInteraction", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowUserInteraction(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentHandlerFactory
				/// </java-name>
				[Dot42.DexImport("setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V", AccessFlags = 41)]
				public static void SetContentHandlerFactory(global::Java.Net.IContentHandlerFactory contentHandlerFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("setDefaultAllowUserInteraction", "(Z)V", AccessFlags = 9)]
				public static void SetDefaultAllowUserInteraction(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultRequestProperty
				/// </java-name>
				[Dot42.DexImport("setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetDefaultRequestProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultUseCaches
				/// </java-name>
				[Dot42.DexImport("setDefaultUseCaches", "(Z)V", AccessFlags = 1)]
				public virtual void SetDefaultUseCaches(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDoInput
				/// </java-name>
				[Dot42.DexImport("setDoInput", "(Z)V", AccessFlags = 1)]
				public virtual void SetDoInput(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDoOutput
				/// </java-name>
				[Dot42.DexImport("setDoOutput", "(Z)V", AccessFlags = 1)]
				public virtual void SetDoOutput(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFileNameMap
				/// </java-name>
				[Dot42.DexImport("setFileNameMap", "(Ljava/net/FileNameMap;)V", AccessFlags = 9)]
				public static void SetFileNameMap(global::Java.Net.IFileNameMap fileNameMap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIfModifiedSince
				/// </java-name>
				[Dot42.DexImport("setIfModifiedSince", "(J)V", AccessFlags = 1)]
				public virtual void SetIfModifiedSince(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRequestProperty
				/// </java-name>
				[Dot42.DexImport("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetRequestProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUseCaches
				/// </java-name>
				[Dot42.DexImport("setUseCaches", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseCaches(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectTimeout
				/// </java-name>
				[Dot42.DexImport("setConnectTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetConnectTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnectTimeout
				/// </java-name>
				[Dot42.DexImport("getConnectTimeout", "()I", AccessFlags = 1)]
				public virtual int GetConnectTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setReadTimeout
				/// </java-name>
				[Dot42.DexImport("setReadTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetReadTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReadTimeout
				/// </java-name>
				[Dot42.DexImport("getReadTimeout", "()I", AccessFlags = 1)]
				public virtual int GetReadTimeout() /* MethodBuilder.Create */ 
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
				internal URLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAllowUserInteraction
				/// </java-name>
				public bool IsAllowUserInteraction
				{
				[Dot42.DexImport("getAllowUserInteraction", "()Z", AccessFlags = 1)]
						get{ return GetAllowUserInteraction(); }
				[Dot42.DexImport("setAllowUserInteraction", "(Z)V", AccessFlags = 1)]
						set{ SetAllowUserInteraction(value); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public object Content
				{
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public string ContentEncoding
				{
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetContentEncoding(); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public int ContentLength
				{
				[Dot42.DexImport("getContentLength", "()I", AccessFlags = 1)]
						get{ return GetContentLength(); }
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				public string ContentType
				{
				[Dot42.DexImport("getContentType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetContentType(); }
				}

				/// <java-name>
				/// getDate
				/// </java-name>
				public long Date
				{
				[Dot42.DexImport("getDate", "()J", AccessFlags = 1)]
						get{ return GetDate(); }
				}

				/// <java-name>
				/// getDefaultAllowUserInteraction
				/// </java-name>
				public static bool IsDefaultAllowUserInteraction
				{
				[Dot42.DexImport("getDefaultAllowUserInteraction", "()Z", AccessFlags = 9)]
						get{ return GetDefaultAllowUserInteraction(); }
				[Dot42.DexImport("setDefaultAllowUserInteraction", "(Z)V", AccessFlags = 9)]
						set{ SetDefaultAllowUserInteraction(value); }
				}

				/// <java-name>
				/// getDefaultUseCaches
				/// </java-name>
				public bool IsDefaultUseCaches
				{
				[Dot42.DexImport("getDefaultUseCaches", "()Z", AccessFlags = 1)]
						get{ return GetDefaultUseCaches(); }
				[Dot42.DexImport("setDefaultUseCaches", "(Z)V", AccessFlags = 1)]
						set{ SetDefaultUseCaches(value); }
				}

				/// <java-name>
				/// getDoInput
				/// </java-name>
				public bool IsDoInput
				{
				[Dot42.DexImport("getDoInput", "()Z", AccessFlags = 1)]
						get{ return GetDoInput(); }
				[Dot42.DexImport("setDoInput", "(Z)V", AccessFlags = 1)]
						set{ SetDoInput(value); }
				}

				/// <java-name>
				/// getDoOutput
				/// </java-name>
				public bool IsDoOutput
				{
				[Dot42.DexImport("getDoOutput", "()Z", AccessFlags = 1)]
						get{ return GetDoOutput(); }
				[Dot42.DexImport("setDoOutput", "(Z)V", AccessFlags = 1)]
						set{ SetDoOutput(value); }
				}

				/// <java-name>
				/// getExpiration
				/// </java-name>
				public long Expiration
				{
				[Dot42.DexImport("getExpiration", "()J", AccessFlags = 1)]
						get{ return GetExpiration(); }
				}

				/// <java-name>
				/// getFileNameMap
				/// </java-name>
				public static global::Java.Net.IFileNameMap FileNameMap
				{
				[Dot42.DexImport("getFileNameMap", "()Ljava/net/FileNameMap;", AccessFlags = 9)]
						get{ return GetFileNameMap(); }
				[Dot42.DexImport("setFileNameMap", "(Ljava/net/FileNameMap;)V", AccessFlags = 9)]
						set{ SetFileNameMap(value); }
				}

				/// <java-name>
				/// getHeaderFields
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.IList<string>> HeaderFields
				{
				[Dot42.DexImport("getHeaderFields", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
						get{ return GetHeaderFields(); }
				}

				/// <java-name>
				/// getRequestProperties
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.IList<string>> RequestProperties
				{
				[Dot42.DexImport("getRequestProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
						get{ return GetRequestProperties(); }
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public global::Java.Io.InputStream InputStream
				{
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetInputStream(); }
				}

				/// <java-name>
				/// getLastModified
				/// </java-name>
				public long LastModified
				{
				[Dot42.DexImport("getLastModified", "()J", AccessFlags = 1)]
						get{ return GetLastModified(); }
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return GetOutputStream(); }
				}

				/// <java-name>
				/// getPermission
				/// </java-name>
				public global::Java.Security.Permission Permission
				{
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
						get{ return GetPermission(); }
				}

				/// <java-name>
				/// getURL
				/// </java-name>
				public global::Java.Net.URL URL
				{
				[Dot42.DexImport("getURL", "()Ljava/net/URL;", AccessFlags = 1)]
						get{ return GetURL(); }
				}

				/// <java-name>
				/// getUseCaches
				/// </java-name>
				public bool IsUseCaches
				{
				[Dot42.DexImport("getUseCaches", "()Z", AccessFlags = 1)]
						get{ return GetUseCaches(); }
				[Dot42.DexImport("setUseCaches", "(Z)V", AccessFlags = 1)]
						set{ SetUseCaches(value); }
				}

				/// <java-name>
				/// getConnectTimeout
				/// </java-name>
				public int ConnectTimeout
				{
				[Dot42.DexImport("getConnectTimeout", "()I", AccessFlags = 1)]
						get{ return GetConnectTimeout(); }
				[Dot42.DexImport("setConnectTimeout", "(I)V", AccessFlags = 1)]
						set{ SetConnectTimeout(value); }
				}

				/// <java-name>
				/// getReadTimeout
				/// </java-name>
				public int ReadTimeout
				{
				[Dot42.DexImport("getReadTimeout", "()I", AccessFlags = 1)]
						get{ return GetReadTimeout(); }
				[Dot42.DexImport("setReadTimeout", "(I)V", AccessFlags = 1)]
						set{ SetReadTimeout(value); }
				}

		}

		/// <java-name>
		/// java/net/DatagramSocket
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramSocket", AccessFlags = 33)]
		public partial class DatagramSocket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatagramSocket() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public DatagramSocket(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/net/InetAddress;)V", AccessFlags = 1)]
				public DatagramSocket(int int32, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/DatagramSocketImpl;)V", AccessFlags = 4)]
				protected internal DatagramSocket(global::Java.Net.DatagramSocketImpl datagramSocketImpl) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public DatagramSocket(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 1)]
				public virtual void Disconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
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
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetReceiveBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetSendBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
				public virtual int GetSoTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(Ljava/net/DatagramPacket;)V", AccessFlags = 33)]
				public virtual void Receive(global::Java.Net.DatagramPacket datagramPacket) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;)V", AccessFlags = 1)]
				public virtual void Send(global::Java.Net.DatagramPacket datagramPacket) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSendBufferSize
				/// </java-name>
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetSendBufferSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetReceiveBufferSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
				public virtual void SetSoTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDatagramSocketImplFactory
				/// </java-name>
				[Dot42.DexImport("setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V", AccessFlags = 41)]
				public static void SetDatagramSocketImplFactory(global::Java.Net.IDatagramSocketImplFactory datagramSocketImplFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isBound
				/// </java-name>
				[Dot42.DexImport("isBound", "()Z", AccessFlags = 1)]
				public virtual bool IsBound() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
				public virtual bool IsConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetRemoteSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetLocalSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <java-name>
				/// setReuseAddress
				/// </java-name>
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
				public virtual void SetReuseAddress(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
				public virtual bool GetReuseAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBroadcast
				/// </java-name>
				[Dot42.DexImport("setBroadcast", "(Z)V", AccessFlags = 1)]
				public virtual void SetBroadcast(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBroadcast
				/// </java-name>
				[Dot42.DexImport("getBroadcast", "()Z", AccessFlags = 1)]
				public virtual bool GetBroadcast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTrafficClass
				/// </java-name>
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
				public virtual void SetTrafficClass(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
				public virtual int GetTrafficClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.DatagramChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.DatagramChannel);
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				public global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInetAddress(); }
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
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public int ReceiveBufferSize
				{
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
						get{ return GetReceiveBufferSize(); }
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetReceiveBufferSize(value); }
				}

				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				public int SendBufferSize
				{
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
						get{ return GetSendBufferSize(); }
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetSendBufferSize(value); }
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public int SoTimeout
				{
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
						get{ return GetSoTimeout(); }
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
						set{ SetSoTimeout(value); }
				}

				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress RemoteSocketAddress
				{
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetRemoteSocketAddress(); }
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress LocalSocketAddress
				{
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetLocalSocketAddress(); }
				}

				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				public bool IsReuseAddress
				{
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
						get{ return GetReuseAddress(); }
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
						set{ SetReuseAddress(value); }
				}

				/// <java-name>
				/// getBroadcast
				/// </java-name>
				public bool IsBroadcast
				{
				[Dot42.DexImport("getBroadcast", "()Z", AccessFlags = 1)]
						get{ return GetBroadcast(); }
				[Dot42.DexImport("setBroadcast", "(Z)V", AccessFlags = 1)]
						set{ SetBroadcast(value); }
				}

				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				public int TrafficClass
				{
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
						get{ return GetTrafficClass(); }
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
						set{ SetTrafficClass(value); }
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.DatagramChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

		}

		/// <java-name>
		/// java/net/ServerSocket
		/// </java-name>
		[Dot42.DexImport("java/net/ServerSocket", AccessFlags = 33)]
		public partial class ServerSocket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ServerSocket() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ServerSocket(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ServerSocket(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IILjava/net/InetAddress;)V", AccessFlags = 1)]
				public ServerSocket(int int32, int int321, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Ljava/net/Socket;", AccessFlags = 1)]
				public virtual global::Java.Net.Socket Accept() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
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
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
				public virtual int GetSoTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// implAccept
				/// </java-name>
				[Dot42.DexImport("implAccept", "(Ljava/net/Socket;)V", AccessFlags = 20)]
				protected internal void ImplAccept(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSocketFactory
				/// </java-name>
				[Dot42.DexImport("setSocketFactory", "(Ljava/net/SocketImplFactory;)V", AccessFlags = 41)]
				public static void SetSocketFactory(global::Java.Net.ISocketImplFactory socketImplFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
				public virtual void SetSoTimeout(int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;I)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress socketAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetLocalSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <java-name>
				/// isBound
				/// </java-name>
				[Dot42.DexImport("isBound", "()Z", AccessFlags = 1)]
				public virtual bool IsBound() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReuseAddress
				/// </java-name>
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
				public virtual void SetReuseAddress(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
				public virtual bool GetReuseAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 1)]
				public virtual void SetReceiveBufferSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 1)]
				public virtual int GetReceiveBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.ServerSocketChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.ServerSocketChannel);
				}

				/// <java-name>
				/// setPerformancePreferences
				/// </java-name>
				[Dot42.DexImport("setPerformancePreferences", "(III)V", AccessFlags = 1)]
				public virtual void SetPerformancePreferences(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				public global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInetAddress(); }
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
				/// getSoTimeout
				/// </java-name>
				public int SoTimeout
				{
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
						get{ return GetSoTimeout(); }
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
						set{ SetSoTimeout(value); }
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress LocalSocketAddress
				{
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetLocalSocketAddress(); }
				}

				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				public bool IsReuseAddress
				{
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
						get{ return GetReuseAddress(); }
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
						set{ SetReuseAddress(value); }
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public int ReceiveBufferSize
				{
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 1)]
						get{ return GetReceiveBufferSize(); }
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 1)]
						set{ SetReceiveBufferSize(value); }
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.ServerSocketChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

		}

		/// <java-name>
		/// java/net/NetPermission
		/// </java-name>
		[Dot42.DexImport("java/net/NetPermission", AccessFlags = 49)]
		public sealed partial class NetPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NetPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public NetPermission(string @string, string string1) /* MethodBuilder.Create */ 
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
				internal NetPermission() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <java-name>
		/// java/net/SocketException
		/// </java-name>
		[Dot42.DexImport("java/net/SocketException", AccessFlags = 33)]
		public partial class SocketException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SocketException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/InterfaceAddress
		/// </java-name>
		[Dot42.DexImport("java/net/InterfaceAddress", AccessFlags = 33)]
		public partial class InterfaceAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InterfaceAddress() /* MethodBuilder.Create */ 
				{
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getBroadcast
				/// </java-name>
				[Dot42.DexImport("getBroadcast", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetBroadcast() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getNetworkPrefixLength
				/// </java-name>
				[Dot42.DexImport("getNetworkPrefixLength", "()S", AccessFlags = 1)]
				public virtual short GetNetworkPrefixLength() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public global::Java.Net.InetAddress Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetAddress(); }
				}

				/// <java-name>
				/// getBroadcast
				/// </java-name>
				public global::Java.Net.InetAddress Broadcast
				{
				[Dot42.DexImport("getBroadcast", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetBroadcast(); }
				}

				/// <java-name>
				/// getNetworkPrefixLength
				/// </java-name>
				public short NetworkPrefixLength
				{
				[Dot42.DexImport("getNetworkPrefixLength", "()S", AccessFlags = 1)]
						get{ return GetNetworkPrefixLength(); }
				}

		}

		/// <java-name>
		/// java/net/IDN
		/// </java-name>
		[Dot42.DexImport("java/net/IDN", AccessFlags = 49)]
		public sealed partial class IDN
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ALLOW_UNASSIGNED
				/// </java-name>
				[Dot42.DexImport("ALLOW_UNASSIGNED", "I", AccessFlags = 25)]
				public const int ALLOW_UNASSIGNED = 1;
				/// <java-name>
				/// USE_STD3_ASCII_RULES
				/// </java-name>
				[Dot42.DexImport("USE_STD3_ASCII_RULES", "I", AccessFlags = 25)]
				public const int USE_STD3_ASCII_RULES = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IDN() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toASCII
				/// </java-name>
				[Dot42.DexImport("toASCII", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToASCII(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toASCII
				/// </java-name>
				[Dot42.DexImport("toASCII", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToASCII(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toUnicode
				/// </java-name>
				[Dot42.DexImport("toUnicode", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToUnicode(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toUnicode
				/// </java-name>
				[Dot42.DexImport("toUnicode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToUnicode(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/net/URLStreamHandler
		/// </java-name>
		[Dot42.DexImport("java/net/URLStreamHandler", AccessFlags = 1057)]
		public abstract partial class URLStreamHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLStreamHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;", AccessFlags = 1028)]
				protected internal abstract global::Java.Net.URLConnection OpenConnection(global::Java.Net.URL uRL) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.URLConnection OpenConnection(global::Java.Net.URL uRL, global::Java.Net.Proxy proxy) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLConnection);
				}

				/// <java-name>
				/// parseURL
				/// </java-name>
				[Dot42.DexImport("parseURL", "(Ljava/net/URL;Ljava/lang/String;II)V", AccessFlags = 4)]
				protected internal virtual void ParseURL(global::Java.Net.URL uRL, string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/" +
    "String;)V", AccessFlags = 4)]
				protected internal virtual void SetURL(global::Java.Net.URL uRL, string @string, string string1, int int32, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/" +
    "String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void SetURL(global::Java.Net.URL uRL, string @string, string string1, int int32, string string2, string string3, string string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toExternalForm
				/// </java-name>
				[Dot42.DexImport("toExternalForm", "(Ljava/net/URL;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string ToExternalForm(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/net/URL;Ljava/net/URL;)Z", AccessFlags = 4)]
				protected internal virtual bool Equals(global::Java.Net.URL uRL, global::Java.Net.URL uRL1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetDefaultPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHostAddress
				/// </java-name>
				[Dot42.DexImport("getHostAddress", "(Ljava/net/URL;)Ljava/net/InetAddress;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.InetAddress GetHostAddress(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "(Ljava/net/URL;)I", AccessFlags = 4)]
				protected internal virtual int GetHashCode(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hostsEqual
				/// </java-name>
				[Dot42.DexImport("hostsEqual", "(Ljava/net/URL;Ljava/net/URL;)Z", AccessFlags = 4)]
				protected internal virtual bool HostsEqual(global::Java.Net.URL uRL, global::Java.Net.URL uRL1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sameFile
				/// </java-name>
				[Dot42.DexImport("sameFile", "(Ljava/net/URL;Ljava/net/URL;)Z", AccessFlags = 4)]
				protected internal virtual bool SameFile(global::Java.Net.URL uRL, global::Java.Net.URL uRL1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				protected internal int DefaultPort
				{
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 4)]
						get{ return GetDefaultPort(); }
				}

		}

		/// <java-name>
		/// java/net/UnknownHostException
		/// </java-name>
		[Dot42.DexImport("java/net/UnknownHostException", AccessFlags = 33)]
		public partial class UnknownHostException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnknownHostException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownHostException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/Proxy
		/// </java-name>
		[Dot42.DexImport("java/net/Proxy", AccessFlags = 33)]
		public partial class Proxy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_PROXY
				/// </java-name>
				[Dot42.DexImport("NO_PROXY", "Ljava/net/Proxy;", AccessFlags = 25)]
				public static readonly global::Java.Net.Proxy NO_PROXY;
				[Dot42.DexImport("<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public Proxy(global::Java.Net.Proxy.JavaType type, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "()Ljava/net/Proxy$Type;", AccessFlags = 1)]
				public virtual global::Java.Net.Proxy.JavaType Type() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Proxy.JavaType);
				}

				/// <java-name>
				/// address
				/// </java-name>
				[Dot42.DexImport("address", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress Address() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
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
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Proxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// java/net/Proxy$Type
				/// </java-name>
				[Dot42.DexImport("java/net/Proxy$Type", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/net/Proxy$Type;>;")]
				public sealed class JavaType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DIRECT
						/// </java-name>
						[Dot42.DexImport("DIRECT", "Ljava/net/Proxy$Type;", AccessFlags = 16409)]
						public static readonly JavaType DIRECT;
						/// <java-name>
						/// HTTP
						/// </java-name>
						[Dot42.DexImport("HTTP", "Ljava/net/Proxy$Type;", AccessFlags = 16409)]
						public static readonly JavaType HTTP;
						/// <java-name>
						/// SOCKS
						/// </java-name>
						[Dot42.DexImport("SOCKS", "Ljava/net/Proxy$Type;", AccessFlags = 16409)]
						public static readonly JavaType SOCKS;
						private JavaType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljava/net/Proxy$Type;", AccessFlags = 9)]
						public static JavaType[] Values() /* MethodBuilder.Create */ 
						{
								return default(JavaType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;", AccessFlags = 9)]
						public static JavaType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(JavaType);
						}

				}

		}

		/// <java-name>
		/// java/net/Authenticator
		/// </java-name>
		[Dot42.DexImport("java/net/Authenticator", AccessFlags = 1057)]
		public abstract partial class Authenticator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Authenticator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.PasswordAuthentication GetPasswordAuthentication() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <java-name>
				/// getRequestingPort
				/// </java-name>
				[Dot42.DexImport("getRequestingPort", "()I", AccessFlags = 20)]
				protected internal int GetRequestingPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRequestingSite
				/// </java-name>
				[Dot42.DexImport("getRequestingSite", "()Ljava/net/InetAddress;", AccessFlags = 20)]
				protected internal global::Java.Net.InetAddress GetRequestingSite() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getRequestingPrompt
				/// </java-name>
				[Dot42.DexImport("getRequestingPrompt", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingPrompt() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRequestingProtocol
				/// </java-name>
				[Dot42.DexImport("getRequestingProtocol", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRequestingScheme
				/// </java-name>
				[Dot42.DexImport("getRequestingScheme", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingScheme() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// requestPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("requestPasswordAuthentication", "(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lj" +
    "ava/net/PasswordAuthentication;", AccessFlags = 41)]
				public static global::Java.Net.PasswordAuthentication RequestPasswordAuthentication(global::Java.Net.InetAddress inetAddress, int int32, string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/Authenticator;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.Authenticator authenticator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Lja" +
    "va/lang/String;)Ljava/net/PasswordAuthentication;", AccessFlags = 41)]
				public static global::Java.Net.PasswordAuthentication RequestPasswordAuthentication(string @string, global::Java.Net.InetAddress inetAddress, int int32, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <java-name>
				/// getRequestingHost
				/// </java-name>
				[Dot42.DexImport("getRequestingHost", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// requestPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Lja" +
    "va/lang/String;Ljava/net/URL;Ljava/net/Authenticator$RequestorType;)Ljava/net/Pa" +
    "sswordAuthentication;", AccessFlags = 9)]
				public static global::Java.Net.PasswordAuthentication RequestPasswordAuthentication(string @string, global::Java.Net.InetAddress inetAddress, int int32, string string1, string string2, string string3, global::Java.Net.URL uRL, global::Java.Net.Authenticator.RequestorType requestorType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <java-name>
				/// getRequestingURL
				/// </java-name>
				[Dot42.DexImport("getRequestingURL", "()Ljava/net/URL;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.URL GetRequestingURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getRequestorType
				/// </java-name>
				[Dot42.DexImport("getRequestorType", "()Ljava/net/Authenticator$RequestorType;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.Authenticator.RequestorType GetRequestorType() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Authenticator.RequestorType);
				}

				/// <java-name>
				/// getPasswordAuthentication
				/// </java-name>
				protected internal global::Java.Net.PasswordAuthentication PasswordAuthentication
				{
				[Dot42.DexImport("getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", AccessFlags = 4)]
						get{ return GetPasswordAuthentication(); }
				}

				/// <java-name>
				/// getRequestingPort
				/// </java-name>
				protected internal int RequestingPort
				{
				[Dot42.DexImport("getRequestingPort", "()I", AccessFlags = 20)]
						get{ return GetRequestingPort(); }
				}

				/// <java-name>
				/// getRequestingSite
				/// </java-name>
				protected internal global::Java.Net.InetAddress RequestingSite
				{
				[Dot42.DexImport("getRequestingSite", "()Ljava/net/InetAddress;", AccessFlags = 20)]
						get{ return GetRequestingSite(); }
				}

				/// <java-name>
				/// getRequestingPrompt
				/// </java-name>
				protected internal string RequestingPrompt
				{
				[Dot42.DexImport("getRequestingPrompt", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingPrompt(); }
				}

				/// <java-name>
				/// getRequestingProtocol
				/// </java-name>
				protected internal string RequestingProtocol
				{
				[Dot42.DexImport("getRequestingProtocol", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingProtocol(); }
				}

				/// <java-name>
				/// getRequestingScheme
				/// </java-name>
				protected internal string RequestingScheme
				{
				[Dot42.DexImport("getRequestingScheme", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingScheme(); }
				}

				/// <java-name>
				/// getRequestingHost
				/// </java-name>
				protected internal string RequestingHost
				{
				[Dot42.DexImport("getRequestingHost", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingHost(); }
				}

				/// <java-name>
				/// getRequestingURL
				/// </java-name>
				protected internal global::Java.Net.URL RequestingURL
				{
				[Dot42.DexImport("getRequestingURL", "()Ljava/net/URL;", AccessFlags = 4)]
						get{ return GetRequestingURL(); }
				}

				/// <java-name>
				/// java/net/Authenticator$RequestorType
				/// </java-name>
				[Dot42.DexImport("java/net/Authenticator$RequestorType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/net/Authenticator$RequestorType;>;")]
				public sealed class RequestorType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PROXY
						/// </java-name>
						[Dot42.DexImport("PROXY", "Ljava/net/Authenticator$RequestorType;", AccessFlags = 16409)]
						public static readonly RequestorType PROXY;
						/// <java-name>
						/// SERVER
						/// </java-name>
						[Dot42.DexImport("SERVER", "Ljava/net/Authenticator$RequestorType;", AccessFlags = 16409)]
						public static readonly RequestorType SERVER;
						private RequestorType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljava/net/Authenticator$RequestorType;", AccessFlags = 9)]
						public static RequestorType[] Values() /* MethodBuilder.Create */ 
						{
								return default(RequestorType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/net/Authenticator$RequestorType;", AccessFlags = 9)]
						public static RequestorType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(RequestorType);
						}

				}

		}

		/// <java-name>
		/// java/net/MalformedURLException
		/// </java-name>
		[Dot42.DexImport("java/net/MalformedURLException", AccessFlags = 33)]
		public partial class MalformedURLException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedURLException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedURLException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/Socket
		/// </java-name>
		[Dot42.DexImport("java/net/Socket", AccessFlags = 33)]
		public partial class Socket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Socket() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/Proxy;)V", AccessFlags = 1)]
				public Socket(global::Java.Net.Proxy proxy) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public Socket(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public Socket(string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;IZ)V", AccessFlags = 1)]
				public Socket(string @string, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public Socket(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public Socket(global::Java.Net.InetAddress inetAddress, int int32, global::Java.Net.InetAddress inetAddress1, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;IZ)V", AccessFlags = 1)]
				public Socket(global::Java.Net.InetAddress inetAddress, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/SocketImpl;)V", AccessFlags = 4)]
				protected internal Socket(global::Java.Net.SocketImpl socketImpl) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// getKeepAlive
				/// </java-name>
				[Dot42.DexImport("getKeepAlive", "()Z", AccessFlags = 1)]
				public virtual bool GetKeepAlive() /* MethodBuilder.Create */ 
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
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSoLinger
				/// </java-name>
				[Dot42.DexImport("getSoLinger", "()I", AccessFlags = 1)]
				public virtual int GetSoLinger() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetReceiveBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetSendBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
				public virtual int GetSoTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("getTcpNoDelay", "()Z", AccessFlags = 1)]
				public virtual bool GetTcpNoDelay() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setKeepAlive
				/// </java-name>
				[Dot42.DexImport("setKeepAlive", "(Z)V", AccessFlags = 1)]
				public virtual void SetKeepAlive(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSocketImplFactory
				/// </java-name>
				[Dot42.DexImport("setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V", AccessFlags = 41)]
				public static void SetSocketImplFactory(global::Java.Net.ISocketImplFactory socketImplFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSendBufferSize
				/// </java-name>
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetSendBufferSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetReceiveBufferSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoLinger
				/// </java-name>
				[Dot42.DexImport("setSoLinger", "(ZI)V", AccessFlags = 1)]
				public virtual void SetSoLinger(bool boolean, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
				public virtual void SetSoTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("setTcpNoDelay", "(Z)V", AccessFlags = 1)]
				public virtual void SetTcpNoDelay(bool boolean) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 1)]
				public virtual void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 1)]
				public virtual void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetLocalSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetRemoteSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <java-name>
				/// isBound
				/// </java-name>
				[Dot42.DexImport("isBound", "()Z", AccessFlags = 1)]
				public virtual bool IsBound() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
				public virtual bool IsConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;I)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.SocketAddress socketAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isInputShutdown
				/// </java-name>
				[Dot42.DexImport("isInputShutdown", "()Z", AccessFlags = 1)]
				public virtual bool IsInputShutdown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isOutputShutdown
				/// </java-name>
				[Dot42.DexImport("isOutputShutdown", "()Z", AccessFlags = 1)]
				public virtual bool IsOutputShutdown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReuseAddress
				/// </java-name>
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
				public virtual void SetReuseAddress(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
				public virtual bool GetReuseAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOOBInline
				/// </java-name>
				[Dot42.DexImport("setOOBInline", "(Z)V", AccessFlags = 1)]
				public virtual void SetOOBInline(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOOBInline
				/// </java-name>
				[Dot42.DexImport("getOOBInline", "()Z", AccessFlags = 1)]
				public virtual bool GetOOBInline() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTrafficClass
				/// </java-name>
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
				public virtual void SetTrafficClass(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
				public virtual int GetTrafficClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// sendUrgentData
				/// </java-name>
				[Dot42.DexImport("sendUrgentData", "(I)V", AccessFlags = 1)]
				public virtual void SendUrgentData(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.SocketChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SocketChannel);
				}

				/// <java-name>
				/// setPerformancePreferences
				/// </java-name>
				[Dot42.DexImport("setPerformancePreferences", "(III)V", AccessFlags = 1)]
				public virtual void SetPerformancePreferences(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInetAddress
				/// </java-name>
				public global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInetAddress(); }
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public global::Java.Io.InputStream InputStream
				{
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetInputStream(); }
				}

				/// <java-name>
				/// getKeepAlive
				/// </java-name>
				public bool IsKeepAlive
				{
				[Dot42.DexImport("getKeepAlive", "()Z", AccessFlags = 1)]
						get{ return GetKeepAlive(); }
				[Dot42.DexImport("setKeepAlive", "(Z)V", AccessFlags = 1)]
						set{ SetKeepAlive(value); }
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
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return GetOutputStream(); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <java-name>
				/// getSoLinger
				/// </java-name>
				public int SoLinger
				{
				[Dot42.DexImport("getSoLinger", "()I", AccessFlags = 1)]
						get{ return GetSoLinger(); }
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public int ReceiveBufferSize
				{
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
						get{ return GetReceiveBufferSize(); }
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetReceiveBufferSize(value); }
				}

				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				public int SendBufferSize
				{
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
						get{ return GetSendBufferSize(); }
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetSendBufferSize(value); }
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public int SoTimeout
				{
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
						get{ return GetSoTimeout(); }
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
						set{ SetSoTimeout(value); }
				}

				/// <java-name>
				/// getTcpNoDelay
				/// </java-name>
				public bool IsTcpNoDelay
				{
				[Dot42.DexImport("getTcpNoDelay", "()Z", AccessFlags = 1)]
						get{ return GetTcpNoDelay(); }
				[Dot42.DexImport("setTcpNoDelay", "(Z)V", AccessFlags = 1)]
						set{ SetTcpNoDelay(value); }
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress LocalSocketAddress
				{
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetLocalSocketAddress(); }
				}

				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress RemoteSocketAddress
				{
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetRemoteSocketAddress(); }
				}

				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				public bool IsReuseAddress
				{
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
						get{ return GetReuseAddress(); }
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
						set{ SetReuseAddress(value); }
				}

				/// <java-name>
				/// getOOBInline
				/// </java-name>
				public bool IsOOBInline
				{
				[Dot42.DexImport("getOOBInline", "()Z", AccessFlags = 1)]
						get{ return GetOOBInline(); }
				[Dot42.DexImport("setOOBInline", "(Z)V", AccessFlags = 1)]
						set{ SetOOBInline(value); }
				}

				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				public int TrafficClass
				{
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
						get{ return GetTrafficClass(); }
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
						set{ SetTrafficClass(value); }
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.SocketChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

		}

		/// <java-name>
		/// java/net/URLClassLoader
		/// </java-name>
		[Dot42.DexImport("java/net/URLClassLoader", AccessFlags = 33)]
		public partial class URLClassLoader : global::Java.Security.SecureClassLoader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/net/URL;)V", AccessFlags = 1)]
				public URLClassLoader(global::Java.Net.URL[] uRL) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public URLClassLoader(global::Java.Net.URL[] uRL, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V", AccessFlags = 1)]
				public URLClassLoader(global::Java.Net.URL[] uRL, global::Java.Lang.ClassLoader classLoader, global::Java.Net.IURLStreamHandlerFactory uRLStreamHandlerFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addURL
				/// </java-name>
				[Dot42.DexImport("addURL", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal virtual void AddURL(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findResources
				/// </java-name>
				[Dot42.DexImport("findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				public new virtual global::Java.Util.IEnumeration<global::Java.Net.URL> FindResources(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal override global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// getURLs
				/// </java-name>
				[Dot42.DexImport("getURLs", "()[Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL[] GetURLs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL[]);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([Ljava/net/URL;)Ljava/net/URLClassLoader;", AccessFlags = 9)]
				public static global::Java.Net.URLClassLoader NewInstance(global::Java.Net.URL[] uRL) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLClassLoader);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;", AccessFlags = 9)]
				public static global::Java.Net.URLClassLoader NewInstance(global::Java.Net.URL[] uRL, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLClassLoader);
				}

				/// <java-name>
				/// findClass
				/// </java-name>
				[Dot42.DexImport("findClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal override global::System.Type FindClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// findResource
				/// </java-name>
				[Dot42.DexImport("findResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1)]
				public new virtual global::Java.Net.URL FindResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// definePackage
				/// </java-name>
				[Dot42.DexImport("definePackage", "(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.Package DefinePackage(string @string, global::Java.Util.Jar.Manifest manifest, global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URLClassLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getURLs
				/// </java-name>
				public global::Java.Net.URL[] URLs
				{
				[Dot42.DexImport("getURLs", "()[Ljava/net/URL;", AccessFlags = 1)]
						get{ return GetURLs(); }
				}

		}

		/// <java-name>
		/// java/net/CookieManager
		/// </java-name>
		[Dot42.DexImport("java/net/CookieManager", AccessFlags = 33)]
		public partial class CookieManager : global::Java.Net.CookieHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieManager() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/CookieStore;Ljava/net/CookiePolicy;)V", AccessFlags = 1)]
				public CookieManager(global::Java.Net.ICookieStore cookieStore, global::Java.Net.ICookiePolicy cookiePolicy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 1, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public override global::Java.Util.IMap<string, global::Java.Util.IList<string>> Get(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.IList<string>>);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)V")]
				public override void Put(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCookiePolicy
				/// </java-name>
				[Dot42.DexImport("setCookiePolicy", "(Ljava/net/CookiePolicy;)V", AccessFlags = 1)]
				public virtual void SetCookiePolicy(global::Java.Net.ICookiePolicy cookiePolicy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookieStore
				/// </java-name>
				[Dot42.DexImport("getCookieStore", "()Ljava/net/CookieStore;", AccessFlags = 1)]
				public virtual global::Java.Net.ICookieStore GetCookieStore() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ICookieStore);
				}

				/// <java-name>
				/// getCookieStore
				/// </java-name>
				public global::Java.Net.ICookieStore CookieStore
				{
				[Dot42.DexImport("getCookieStore", "()Ljava/net/CookieStore;", AccessFlags = 1)]
						get{ return GetCookieStore(); }
				}

		}

		/// <java-name>
		/// java/net/SocketOptions
		/// </java-name>
		[Dot42.DexImport("java/net/SocketOptions", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISocketOptionsConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SO_LINGER
				/// </java-name>
				[Dot42.DexImport("SO_LINGER", "I", AccessFlags = 25)]
				public const int SO_LINGER = 128;
				/// <java-name>
				/// SO_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SO_TIMEOUT", "I", AccessFlags = 25)]
				public const int SO_TIMEOUT = 4102;
				/// <java-name>
				/// TCP_NODELAY
				/// </java-name>
				[Dot42.DexImport("TCP_NODELAY", "I", AccessFlags = 25)]
				public const int TCP_NODELAY = 1;
				/// <java-name>
				/// IP_MULTICAST_IF
				/// </java-name>
				[Dot42.DexImport("IP_MULTICAST_IF", "I", AccessFlags = 25)]
				public const int IP_MULTICAST_IF = 16;
				/// <java-name>
				/// SO_BINDADDR
				/// </java-name>
				[Dot42.DexImport("SO_BINDADDR", "I", AccessFlags = 25)]
				public const int SO_BINDADDR = 15;
				/// <java-name>
				/// SO_REUSEADDR
				/// </java-name>
				[Dot42.DexImport("SO_REUSEADDR", "I", AccessFlags = 25)]
				public const int SO_REUSEADDR = 4;
				/// <java-name>
				/// SO_SNDBUF
				/// </java-name>
				[Dot42.DexImport("SO_SNDBUF", "I", AccessFlags = 25)]
				public const int SO_SNDBUF = 4097;
				/// <java-name>
				/// SO_RCVBUF
				/// </java-name>
				[Dot42.DexImport("SO_RCVBUF", "I", AccessFlags = 25)]
				public const int SO_RCVBUF = 4098;
				/// <java-name>
				/// SO_KEEPALIVE
				/// </java-name>
				[Dot42.DexImport("SO_KEEPALIVE", "I", AccessFlags = 25)]
				public const int SO_KEEPALIVE = 8;
				/// <java-name>
				/// IP_TOS
				/// </java-name>
				[Dot42.DexImport("IP_TOS", "I", AccessFlags = 25)]
				public const int IP_TOS = 3;
				/// <java-name>
				/// IP_MULTICAST_LOOP
				/// </java-name>
				[Dot42.DexImport("IP_MULTICAST_LOOP", "I", AccessFlags = 25)]
				public const int IP_MULTICAST_LOOP = 18;
				/// <java-name>
				/// SO_BROADCAST
				/// </java-name>
				[Dot42.DexImport("SO_BROADCAST", "I", AccessFlags = 25)]
				public const int SO_BROADCAST = 32;
				/// <java-name>
				/// SO_OOBINLINE
				/// </java-name>
				[Dot42.DexImport("SO_OOBINLINE", "I", AccessFlags = 25)]
				public const int SO_OOBINLINE = 4099;
				/// <java-name>
				/// IP_MULTICAST_IF2
				/// </java-name>
				[Dot42.DexImport("IP_MULTICAST_IF2", "I", AccessFlags = 25)]
				public const int IP_MULTICAST_IF2 = 31;
		}

		/// <java-name>
		/// java/net/SocketOptions
		/// </java-name>
		[Dot42.DexImport("java/net/SocketOptions", AccessFlags = 1537)]
		public partial interface ISocketOptions
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getOption
				/// </java-name>
				[Dot42.DexImport("getOption", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetOption(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOption
				/// </java-name>
				[Dot42.DexImport("setOption", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				void SetOption(int int32, object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/SocketAddress
		/// </java-name>
		[Dot42.DexImport("java/net/SocketAddress", AccessFlags = 1057)]
		public abstract partial class SocketAddress : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketAddress() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/net/JarURLConnection
		/// </java-name>
		[Dot42.DexImport("java/net/JarURLConnection", AccessFlags = 1057)]
		public abstract partial class JarURLConnection : global::Java.Net.URLConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// jarFileURLConnection
				/// </java-name>
				[Dot42.DexImport("jarFileURLConnection", "Ljava/net/URLConnection;", AccessFlags = 4)]
				protected internal global::Java.Net.URLConnection JarFileURLConnection;
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal JarURLConnection(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <java-name>
				/// getEntryName
				/// </java-name>
				[Dot42.DexImport("getEntryName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEntryName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getJarEntry
				/// </java-name>
				[Dot42.DexImport("getJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.JarEntry GetJarEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.JarEntry);
				}

				/// <java-name>
				/// getManifest
				/// </java-name>
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Manifest GetManifest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Manifest);
				}

				/// <java-name>
				/// getJarFile
				/// </java-name>
				[Dot42.DexImport("getJarFile", "()Ljava/util/jar/JarFile;", AccessFlags = 1025)]
				public abstract global::Java.Util.Jar.JarFile GetJarFile() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getJarFileURL
				/// </java-name>
				[Dot42.DexImport("getJarFileURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL GetJarFileURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetMainAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarURLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes Attributes
				{
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] Certificates
				{
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetCertificates(); }
				}

				/// <java-name>
				/// getEntryName
				/// </java-name>
				public string EntryName
				{
				[Dot42.DexImport("getEntryName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEntryName(); }
				}

				/// <java-name>
				/// getJarEntry
				/// </java-name>
				public global::Java.Util.Jar.JarEntry JarEntry
				{
				[Dot42.DexImport("getJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
						get{ return GetJarEntry(); }
				}

				/// <java-name>
				/// getManifest
				/// </java-name>
				public global::Java.Util.Jar.Manifest Manifest
				{
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
						get{ return GetManifest(); }
				}

				/// <java-name>
				/// getJarFile
				/// </java-name>
				public global::Java.Util.Jar.JarFile JarFile
				{
				[Dot42.DexImport("getJarFile", "()Ljava/util/jar/JarFile;", AccessFlags = 1025)]
						get{ return GetJarFile(); }
				}

				/// <java-name>
				/// getJarFileURL
				/// </java-name>
				public global::Java.Net.URL JarFileURL
				{
				[Dot42.DexImport("getJarFileURL", "()Ljava/net/URL;", AccessFlags = 1)]
						get{ return GetJarFileURL(); }
				}

				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes MainAttributes
				{
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetMainAttributes(); }
				}

		}

		/// <java-name>
		/// java/net/ContentHandler
		/// </java-name>
		[Dot42.DexImport("java/net/ContentHandler", AccessFlags = 1057)]
		public abstract partial class ContentHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetContent(global::Java.Net.URLConnection uRLConnection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetContent(global::Java.Net.URLConnection uRLConnection, global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// java/net/URISyntaxException
		/// </java-name>
		[Dot42.DexImport("java/net/URISyntaxException", AccessFlags = 33)]
		public partial class URISyntaxException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public URISyntaxException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public URISyntaxException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public virtual int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReason() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInput
				/// </java-name>
				[Dot42.DexImport("getInput", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInput() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URISyntaxException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				public string Reason
				{
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReason(); }
				}

				/// <java-name>
				/// getInput
				/// </java-name>
				public string Input
				{
				[Dot42.DexImport("getInput", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInput(); }
				}

		}

		/// <java-name>
		/// java/net/HttpURLConnection
		/// </java-name>
		[Dot42.DexImport("java/net/HttpURLConnection", AccessFlags = 1057)]
		public abstract partial class HttpURLConnection : global::Java.Net.URLConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// method
				/// </java-name>
				[Dot42.DexImport("method", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string Method;
				/// <java-name>
				/// responseCode
				/// </java-name>
				[Dot42.DexImport("responseCode", "I", AccessFlags = 4)]
				protected internal int ResponseCode;
				/// <java-name>
				/// responseMessage
				/// </java-name>
				[Dot42.DexImport("responseMessage", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string ResponseMessage;
				/// <java-name>
				/// instanceFollowRedirects
				/// </java-name>
				[Dot42.DexImport("instanceFollowRedirects", "Z", AccessFlags = 4)]
				protected internal bool InstanceFollowRedirects;
				/// <java-name>
				/// chunkLength
				/// </java-name>
				[Dot42.DexImport("chunkLength", "I", AccessFlags = 4)]
				protected internal int ChunkLength;
				/// <java-name>
				/// fixedContentLength
				/// </java-name>
				[Dot42.DexImport("fixedContentLength", "I", AccessFlags = 4)]
				protected internal int FixedContentLength;
				/// <java-name>
				/// HTTP_ACCEPTED
				/// </java-name>
				[Dot42.DexImport("HTTP_ACCEPTED", "I", AccessFlags = 25)]
				public const int HTTP_ACCEPTED = 202;
				/// <java-name>
				/// HTTP_BAD_GATEWAY
				/// </java-name>
				[Dot42.DexImport("HTTP_BAD_GATEWAY", "I", AccessFlags = 25)]
				public const int HTTP_BAD_GATEWAY = 502;
				/// <java-name>
				/// HTTP_BAD_METHOD
				/// </java-name>
				[Dot42.DexImport("HTTP_BAD_METHOD", "I", AccessFlags = 25)]
				public const int HTTP_BAD_METHOD = 405;
				/// <java-name>
				/// HTTP_BAD_REQUEST
				/// </java-name>
				[Dot42.DexImport("HTTP_BAD_REQUEST", "I", AccessFlags = 25)]
				public const int HTTP_BAD_REQUEST = 400;
				/// <java-name>
				/// HTTP_CLIENT_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("HTTP_CLIENT_TIMEOUT", "I", AccessFlags = 25)]
				public const int HTTP_CLIENT_TIMEOUT = 408;
				/// <java-name>
				/// HTTP_CONFLICT
				/// </java-name>
				[Dot42.DexImport("HTTP_CONFLICT", "I", AccessFlags = 25)]
				public const int HTTP_CONFLICT = 409;
				/// <java-name>
				/// HTTP_CREATED
				/// </java-name>
				[Dot42.DexImport("HTTP_CREATED", "I", AccessFlags = 25)]
				public const int HTTP_CREATED = 201;
				/// <java-name>
				/// HTTP_ENTITY_TOO_LARGE
				/// </java-name>
				[Dot42.DexImport("HTTP_ENTITY_TOO_LARGE", "I", AccessFlags = 25)]
				public const int HTTP_ENTITY_TOO_LARGE = 413;
				/// <java-name>
				/// HTTP_FORBIDDEN
				/// </java-name>
				[Dot42.DexImport("HTTP_FORBIDDEN", "I", AccessFlags = 25)]
				public const int HTTP_FORBIDDEN = 403;
				/// <java-name>
				/// HTTP_GATEWAY_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("HTTP_GATEWAY_TIMEOUT", "I", AccessFlags = 25)]
				public const int HTTP_GATEWAY_TIMEOUT = 504;
				/// <java-name>
				/// HTTP_GONE
				/// </java-name>
				[Dot42.DexImport("HTTP_GONE", "I", AccessFlags = 25)]
				public const int HTTP_GONE = 410;
				/// <java-name>
				/// HTTP_INTERNAL_ERROR
				/// </java-name>
				[Dot42.DexImport("HTTP_INTERNAL_ERROR", "I", AccessFlags = 25)]
				public const int HTTP_INTERNAL_ERROR = 500;
				/// <java-name>
				/// HTTP_LENGTH_REQUIRED
				/// </java-name>
				[Dot42.DexImport("HTTP_LENGTH_REQUIRED", "I", AccessFlags = 25)]
				public const int HTTP_LENGTH_REQUIRED = 411;
				/// <java-name>
				/// HTTP_MOVED_PERM
				/// </java-name>
				[Dot42.DexImport("HTTP_MOVED_PERM", "I", AccessFlags = 25)]
				public const int HTTP_MOVED_PERM = 301;
				/// <java-name>
				/// HTTP_MOVED_TEMP
				/// </java-name>
				[Dot42.DexImport("HTTP_MOVED_TEMP", "I", AccessFlags = 25)]
				public const int HTTP_MOVED_TEMP = 302;
				/// <java-name>
				/// HTTP_MULT_CHOICE
				/// </java-name>
				[Dot42.DexImport("HTTP_MULT_CHOICE", "I", AccessFlags = 25)]
				public const int HTTP_MULT_CHOICE = 300;
				/// <java-name>
				/// HTTP_NO_CONTENT
				/// </java-name>
				[Dot42.DexImport("HTTP_NO_CONTENT", "I", AccessFlags = 25)]
				public const int HTTP_NO_CONTENT = 204;
				/// <java-name>
				/// HTTP_NOT_ACCEPTABLE
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_ACCEPTABLE", "I", AccessFlags = 25)]
				public const int HTTP_NOT_ACCEPTABLE = 406;
				/// <java-name>
				/// HTTP_NOT_AUTHORITATIVE
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_AUTHORITATIVE", "I", AccessFlags = 25)]
				public const int HTTP_NOT_AUTHORITATIVE = 203;
				/// <java-name>
				/// HTTP_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_FOUND", "I", AccessFlags = 25)]
				public const int HTTP_NOT_FOUND = 404;
				/// <java-name>
				/// HTTP_NOT_IMPLEMENTED
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_IMPLEMENTED", "I", AccessFlags = 25)]
				public const int HTTP_NOT_IMPLEMENTED = 501;
				/// <java-name>
				/// HTTP_NOT_MODIFIED
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_MODIFIED", "I", AccessFlags = 25)]
				public const int HTTP_NOT_MODIFIED = 304;
				/// <java-name>
				/// HTTP_OK
				/// </java-name>
				[Dot42.DexImport("HTTP_OK", "I", AccessFlags = 25)]
				public const int HTTP_OK = 200;
				/// <java-name>
				/// HTTP_PARTIAL
				/// </java-name>
				[Dot42.DexImport("HTTP_PARTIAL", "I", AccessFlags = 25)]
				public const int HTTP_PARTIAL = 206;
				/// <java-name>
				/// HTTP_PAYMENT_REQUIRED
				/// </java-name>
				[Dot42.DexImport("HTTP_PAYMENT_REQUIRED", "I", AccessFlags = 25)]
				public const int HTTP_PAYMENT_REQUIRED = 402;
				/// <java-name>
				/// HTTP_PRECON_FAILED
				/// </java-name>
				[Dot42.DexImport("HTTP_PRECON_FAILED", "I", AccessFlags = 25)]
				public const int HTTP_PRECON_FAILED = 412;
				/// <java-name>
				/// HTTP_PROXY_AUTH
				/// </java-name>
				[Dot42.DexImport("HTTP_PROXY_AUTH", "I", AccessFlags = 25)]
				public const int HTTP_PROXY_AUTH = 407;
				/// <java-name>
				/// HTTP_REQ_TOO_LONG
				/// </java-name>
				[Dot42.DexImport("HTTP_REQ_TOO_LONG", "I", AccessFlags = 25)]
				public const int HTTP_REQ_TOO_LONG = 414;
				/// <java-name>
				/// HTTP_RESET
				/// </java-name>
				[Dot42.DexImport("HTTP_RESET", "I", AccessFlags = 25)]
				public const int HTTP_RESET = 205;
				/// <java-name>
				/// HTTP_SEE_OTHER
				/// </java-name>
				[Dot42.DexImport("HTTP_SEE_OTHER", "I", AccessFlags = 25)]
				public const int HTTP_SEE_OTHER = 303;
				/// <java-name>
				/// HTTP_SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("HTTP_SERVER_ERROR", "I", AccessFlags = 25)]
				public const int HTTP_SERVER_ERROR = 500;
				/// <java-name>
				/// HTTP_USE_PROXY
				/// </java-name>
				[Dot42.DexImport("HTTP_USE_PROXY", "I", AccessFlags = 25)]
				public const int HTTP_USE_PROXY = 305;
				/// <java-name>
				/// HTTP_UNAUTHORIZED
				/// </java-name>
				[Dot42.DexImport("HTTP_UNAUTHORIZED", "I", AccessFlags = 25)]
				public const int HTTP_UNAUTHORIZED = 401;
				/// <java-name>
				/// HTTP_UNSUPPORTED_TYPE
				/// </java-name>
				[Dot42.DexImport("HTTP_UNSUPPORTED_TYPE", "I", AccessFlags = 25)]
				public const int HTTP_UNSUPPORTED_TYPE = 415;
				/// <java-name>
				/// HTTP_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("HTTP_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int HTTP_UNAVAILABLE = 503;
				/// <java-name>
				/// HTTP_VERSION
				/// </java-name>
				[Dot42.DexImport("HTTP_VERSION", "I", AccessFlags = 25)]
				public const int HTTP_VERSION = 505;
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal HttpURLConnection(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 1025)]
				public abstract void Disconnect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getErrorStream
				/// </java-name>
				[Dot42.DexImport("getErrorStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetErrorStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// getFollowRedirects
				/// </java-name>
				[Dot42.DexImport("getFollowRedirects", "()Z", AccessFlags = 9)]
				public static bool GetFollowRedirects() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPermission
				/// </java-name>
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
				public override global::Java.Security.Permission GetPermission() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Permission);
				}

				/// <java-name>
				/// getRequestMethod
				/// </java-name>
				[Dot42.DexImport("getRequestMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetRequestMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResponseCode
				/// </java-name>
				[Dot42.DexImport("getResponseCode", "()I", AccessFlags = 1)]
				public virtual int GetResponseCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getResponseMessage
				/// </java-name>
				[Dot42.DexImport("getResponseMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResponseMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setFollowRedirects
				/// </java-name>
				[Dot42.DexImport("setFollowRedirects", "(Z)V", AccessFlags = 9)]
				public static void SetFollowRedirects(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRequestMethod
				/// </java-name>
				[Dot42.DexImport("setRequestMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetRequestMethod(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// usingProxy
				/// </java-name>
				[Dot42.DexImport("usingProxy", "()Z", AccessFlags = 1025)]
				public abstract bool UsingProxy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetContentEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstanceFollowRedirects
				/// </java-name>
				[Dot42.DexImport("getInstanceFollowRedirects", "()Z", AccessFlags = 1)]
				public virtual bool GetInstanceFollowRedirects() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setInstanceFollowRedirects
				/// </java-name>
				[Dot42.DexImport("setInstanceFollowRedirects", "(Z)V", AccessFlags = 1)]
				public virtual void SetInstanceFollowRedirects(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHeaderFieldDate
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldDate", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public override long GetHeaderFieldDate(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setFixedLengthStreamingMode
				/// </java-name>
				[Dot42.DexImport("setFixedLengthStreamingMode", "(I)V", AccessFlags = 1)]
				public virtual void SetFixedLengthStreamingMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChunkedStreamingMode
				/// </java-name>
				[Dot42.DexImport("setChunkedStreamingMode", "(I)V", AccessFlags = 1)]
				public virtual void SetChunkedStreamingMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpURLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getErrorStream
				/// </java-name>
				public global::Java.Io.InputStream ErrorStream
				{
				[Dot42.DexImport("getErrorStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetErrorStream(); }
				}

				/// <java-name>
				/// getFollowRedirects
				/// </java-name>
				public static bool IsFollowRedirects
				{
				[Dot42.DexImport("getFollowRedirects", "()Z", AccessFlags = 9)]
						get{ return GetFollowRedirects(); }
				[Dot42.DexImport("setFollowRedirects", "(Z)V", AccessFlags = 9)]
						set{ SetFollowRedirects(value); }
				}

				/// <java-name>
				/// getPermission
				/// </java-name>
				public global::Java.Security.Permission Permission
				{
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
						get{ return GetPermission(); }
				}

				/// <java-name>
				/// getRequestMethod
				/// </java-name>
				public string RequestMethod
				{
				[Dot42.DexImport("getRequestMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRequestMethod(); }
				[Dot42.DexImport("setRequestMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetRequestMethod(value); }
				}

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public string ContentEncoding
				{
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetContentEncoding(); }
				}

				/// <java-name>
				/// getInstanceFollowRedirects
				/// </java-name>
				public bool IsInstanceFollowRedirects
				{
				[Dot42.DexImport("getInstanceFollowRedirects", "()Z", AccessFlags = 1)]
						get{ return GetInstanceFollowRedirects(); }
				[Dot42.DexImport("setInstanceFollowRedirects", "(Z)V", AccessFlags = 1)]
						set{ SetInstanceFollowRedirects(value); }
				}

		}

		/// <java-name>
		/// java/net/DatagramSocketImplFactory
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramSocketImplFactory", AccessFlags = 1537)]
		public partial interface IDatagramSocketImplFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createDatagramSocketImpl
				/// </java-name>
				[Dot42.DexImport("createDatagramSocketImpl", "()Ljava/net/DatagramSocketImpl;", AccessFlags = 1025)]
				global::Java.Net.DatagramSocketImpl CreateDatagramSocketImpl() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/net/InetAddress
		/// </java-name>
		[Dot42.DexImport("java/net/InetAddress", AccessFlags = 33)]
		public partial class InetAddress : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InetAddress() /* MethodBuilder.Create */ 
				{
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
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetAddress() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetAddress() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getAllByName
				/// </java-name>
				[Dot42.DexImport("getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress[] GetAllByName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress[]);
				}

				/// <java-name>
				/// getByName
				/// </java-name>
				[Dot42.DexImport("getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetByName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getHostAddress
				/// </java-name>
				[Dot42.DexImport("getHostAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHostAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHostName
				/// </java-name>
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCanonicalHostName
				/// </java-name>
				[Dot42.DexImport("getCanonicalHostName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCanonicalHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLocalHost
				/// </java-name>
				[Dot42.DexImport("getLocalHost", "()Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetLocalHost() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isAnyLocalAddress
				/// </java-name>
				[Dot42.DexImport("isAnyLocalAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsAnyLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLinkLocalAddress
				/// </java-name>
				[Dot42.DexImport("isLinkLocalAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsLinkLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLoopbackAddress
				/// </java-name>
				[Dot42.DexImport("isLoopbackAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsLoopbackAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCGlobal
				/// </java-name>
				[Dot42.DexImport("isMCGlobal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCGlobal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCLinkLocal
				/// </java-name>
				[Dot42.DexImport("isMCLinkLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCLinkLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCNodeLocal
				/// </java-name>
				[Dot42.DexImport("isMCNodeLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCNodeLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCOrgLocal
				/// </java-name>
				[Dot42.DexImport("isMCOrgLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCOrgLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMCSiteLocal
				/// </java-name>
				[Dot42.DexImport("isMCSiteLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCSiteLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMulticastAddress
				/// </java-name>
				[Dot42.DexImport("isMulticastAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsMulticastAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSiteLocalAddress
				/// </java-name>
				[Dot42.DexImport("isSiteLocalAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsSiteLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReachable
				/// </java-name>
				[Dot42.DexImport("isReachable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsReachable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReachable
				/// </java-name>
				[Dot42.DexImport("isReachable", "(Ljava/net/NetworkInterface;II)Z", AccessFlags = 1)]
				public virtual bool IsReachable(global::Java.Net.NetworkInterface networkInterface, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "([B)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetByAddress(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "([B)Ljava/net/InetAddress;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.InetAddress GetByAddress(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetByAddress(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.InetAddress GetByAddress(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public byte[] Address
				{
				[Dot42.DexImport("getAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetAddress(); }
				}

				/// <java-name>
				/// getHostAddress
				/// </java-name>
				public string HostAddress
				{
				[Dot42.DexImport("getHostAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHostAddress(); }
				}

				/// <java-name>
				/// getHostName
				/// </java-name>
				public string HostName
				{
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHostName(); }
				}

				/// <java-name>
				/// getCanonicalHostName
				/// </java-name>
				public string CanonicalHostName
				{
				[Dot42.DexImport("getCanonicalHostName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCanonicalHostName(); }
				}

				/// <java-name>
				/// getLocalHost
				/// </java-name>
				public static global::Java.Net.InetAddress LocalHost
				{
				[Dot42.DexImport("getLocalHost", "()Ljava/net/InetAddress;", AccessFlags = 9)]
						get{ return GetLocalHost(); }
				}

		}

}

