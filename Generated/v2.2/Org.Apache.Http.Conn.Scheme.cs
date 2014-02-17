// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Conn.Scheme.cs
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
namespace Org.Apache.Http.Conn.Scheme
{
		/// <summary>
		/// <para>A set of supported protocol schemes. Schemes are identified by lowercase names.</para><para><para></para><para></para><title>Revision:</title><para>648356 </para><title>Date:</title><para>2008-04-15 10:57:53 -0700 (Tue, 15 Apr 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/scheme/SchemeRegistry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/SchemeRegistry", AccessFlags = 49)]
		public sealed partial class SchemeRegistry
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new, empty scheme registry. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SchemeRegistry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the scheme for a host. Convenience method for <code>getScheme(host.getSchemeName())</code></para><para><code> </code></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme for the given host, never <code>null</code></para>
				/// </returns>
				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme GetScheme(string host) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <summary>
				/// <para>Obtains the scheme for a host. Convenience method for <code>getScheme(host.getSchemeName())</code></para><para><code> </code></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme for the given host, never <code>null</code></para>
				/// </returns>
				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "(Lorg/apache/http/HttpHost;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme GetScheme(global::Org.Apache.Http.HttpHost host) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <summary>
				/// <para>Obtains a scheme by name, if registered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme, or <code>null</code> if there is none by this name </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme Get(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <summary>
				/// <para>Registers a scheme. The scheme can later be retrieved by its name using getScheme or get.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme previously registered with that name, or <code>null</code> if none was registered </para>
				/// </returns>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Lorg/apache/http/conn/scheme/Scheme;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme Register(global::Org.Apache.Http.Conn.Scheme.Scheme sch) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <summary>
				/// <para>Unregisters a scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unregistered scheme, or <code>null</code> if there was none </para>
				/// </returns>
				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", AccessFlags = 49)]
				public global::Org.Apache.Http.Conn.Scheme.Scheme Unregister(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.Scheme);
				}

				/// <summary>
				/// <para>Obtains the names of the registered schemes in their default order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>List containing registered scheme names. </para>
				/// </returns>
				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 49, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public global::Java.Util.IList<string> GetSchemeNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				/// <para>Populates the internal collection of registered protocol schemes with the content of the map passed as a parameter.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setItems
				/// </java-name>
				[Dot42.DexImport("setItems", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/conn/scheme/Scheme;>;)V")]
				public void SetItems(global::Java.Util.IMap<string, global::Org.Apache.Http.Conn.Scheme.Scheme> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the names of the registered schemes in their default order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>List containing registered scheme names. </para>
				/// </returns>
				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				public global::Java.Util.IList<string> SchemeNames
				{
				[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 49, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetSchemeNames(); }
				}

		}

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
				global::Java.Net.InetAddress Resolve(string hostname) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A factory for creating and connecting sockets. The factory encapsulates the logic for establishing a socket connection. <br></br> Both Object.equals() and Object.hashCode() must be overridden for the correct operation of some connection managers.</para><para><para> </para><simplesectsep></simplesectsep><para>Michael Becke </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/scheme/SocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/SocketFactory", AccessFlags = 1537)]
		public partial interface ISocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new, unconnected socket. The socket should subsequently be passed to connectSocket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new socket</para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Connects a socket to the given host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connected socket. The returned object may be different from the <code>sock</code> argument if this factory supports a layered protocol.</para>
				/// </returns>
				/// <java-name>
				/// connectSocket
				/// </java-name>
				[Dot42.DexImport("connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/para" +
    "ms/HttpParams;)Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket ConnectSocket(global::Java.Net.Socket sock, string host, int port, global::Java.Net.InetAddress localAddress, int localPort, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether a socket provides a secure connection. The socket must be connected by this factory. The factory will <b>not</b> perform I/O operations in this method. <br></br> As a rule of thumb, plain sockets are not secure and TLS/SSL sockets are secure. However, there may be application specific deviations. For example, a plain socket to a host in the same intranet ("trusted zone") could be considered secure. On the other hand, a TLS/SSL socket could be considered insecure based on the cypher suite chosen for the connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the connection of the socket should be considered secure, or <code>false</code> if it should not</para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "(Ljava/net/Socket;)Z", AccessFlags = 1025)]
				bool IsSecure(global::Java.Net.Socket sock) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Encapsulates specifics of a protocol scheme such as "http" or "https". Schemes are identified by lowercase names. Supported schemes are typically collected in a SchemeRegistry.</para><para>For example, to configure support for "https://" URLs, you could write code like the following: </para><para><pre>
		///    Scheme https = new Scheme("https", new MySecureSocketFactory(), 443);
		///    SchemeRegistry.DEFAULT.register(https);
		///    </pre></para><para><para> </para><simplesectsep></simplesectsep><para>Michael Becke </para><simplesectsep></simplesectsep><para>Jeff Dever </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/scheme/Scheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/Scheme", AccessFlags = 49)]
		public sealed partial class Scheme
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new scheme. Whether the created scheme allows for layered connections depends on the class of <code>factory</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/apache/http/conn/scheme/SocketFactory;I)V", AccessFlags = 1)]
				public Scheme(string name, global::Org.Apache.Http.Conn.Scheme.ISocketFactory factory, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the default port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default port for this scheme </para>
				/// </returns>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 17)]
				public int GetDefaultPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the socket factory. If this scheme is layered, the factory implements LayeredSocketFactory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket factory for this scheme </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Scheme.ISocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.ISocketFactory);
				}

				/// <summary>
				/// <para>Obtains the scheme name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this scheme, in lowercase </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Indicates whether this scheme allows for layered connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if layered connections are possible, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLayered
				/// </java-name>
				[Dot42.DexImport("isLayered", "()Z", AccessFlags = 17)]
				public bool IsLayered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Resolves the correct port for this scheme. Returns the given port if it is valid, the default port otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the given port or the defaultPort </para>
				/// </returns>
				/// <java-name>
				/// resolvePort
				/// </java-name>
				[Dot42.DexImport("resolvePort", "(I)I", AccessFlags = 17)]
				public int ResolvePort(int port) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a string representation of this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a human-readable string description of this scheme </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compares this scheme to an object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> iff the argument is equal to this scheme </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains a hash code for this scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code </para>
				/// </returns>
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

				/// <summary>
				/// <para>Obtains the default port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default port for this scheme </para>
				/// </returns>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				public int DefaultPort
				{
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 17)]
						get{ return GetDefaultPort(); }
				}

				/// <summary>
				/// <para>Obtains the socket factory. If this scheme is layered, the factory implements LayeredSocketFactory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket factory for this scheme </para>
				/// </returns>
				/// <java-name>
				/// getSocketFactory
				/// </java-name>
				public global::Org.Apache.Http.Conn.Scheme.ISocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;", AccessFlags = 17)]
						get{ return GetSocketFactory(); }
				}

				/// <summary>
				/// <para>Obtains the scheme name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this scheme, in lowercase </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetName(); }
				}

		}

		/// <summary>
		/// <para>A SocketFactory for layered sockets (SSL/TLS). See there for things to consider when implementing a socket factory.</para><para><para>Michael Becke </para><simplesectsep></simplesectsep><para> </para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/scheme/LayeredSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/LayeredSocketFactory", AccessFlags = 1537)]
		public partial interface ILayeredSocketFactory : global::Org.Apache.Http.Conn.Scheme.ISocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns a socket connected to the given host that is layered over an existing socket. Used primarily for creating secure sockets through proxies.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Socket a new socket</para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1025)]
				global::Java.Net.Socket CreateSocket(global::Java.Net.Socket socket, string host, int port, bool autoClose) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The default class for creating sockets.</para><para><para> </para><simplesectsep></simplesectsep><para>Michael Becke </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/conn/scheme/PlainSocketFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/conn/scheme/PlainSocketFactory", AccessFlags = 49)]
		public sealed partial class PlainSocketFactory : global::Org.Apache.Http.Conn.Scheme.ISocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/scheme/HostNameResolver;)V", AccessFlags = 1)]
				public PlainSocketFactory(global::Org.Apache.Http.Conn.Scheme.IHostNameResolver nameResolver) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PlainSocketFactory() /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/PlainSocketFactory;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Scheme.PlainSocketFactory GetSocketFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.PlainSocketFactory);
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
				/// <para>Connects a socket to the given host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connected socket. The returned object may be different from the <code>sock</code> argument if this factory supports a layered protocol.</para>
				/// </returns>
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
				public static global::Org.Apache.Http.Conn.Scheme.PlainSocketFactory SocketFactory
				{
				[Dot42.DexImport("getSocketFactory", "()Lorg/apache/http/conn/scheme/PlainSocketFactory;", AccessFlags = 9)]
						get{ return GetSocketFactory(); }
				}

		}

}


