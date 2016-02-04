#pragma warning disable 1717
namespace Javax.Net
{
		/// <summary>
		///  <para>This abstract class defines methods to create server sockets. It can be subclassed to create specific server socket types. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/ServerSocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ServerSocketFactory", AccessFlags = 1057)]
		public abstract partial class ServerSocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>ServerSocketFactory </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ServerSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new server socket which is not bound to any local address. This method has to be overridden by a subclass otherwise a <c>SocketException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created unbound server socket. </para>
				/// </returns>
				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "()Ljava/net/ServerSocket;", AccessFlags = 1)]
				public virtual global::Java.Net.ServerSocket CreateServerSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ServerSocket);
				}

				/// <summary>
				///  <para>Creates a new server socket which is bound to the given port with a maximum backlog of 50 unaccepted connections.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created bound server socket. </para>
				/// </returns>
				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "(I)Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket CreateServerSocket(int port) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new server socket which is bound to the given port and configures its maximum of queued connections.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created bound server socket. </para>
				/// </returns>
				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "(II)Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket CreateServerSocket(int port, int backlog) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new server socket which is bound to the given address on the specified port and configures its maximum of queued connections.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created bound server socket. </para>
				/// </returns>
				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket CreateServerSocket(int port, int backlog, global::Java.Net.InetAddress iAddress) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the default server socket factory of the system which can be used to create new server sockets without creating a subclass of this factory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the system default server socket factory. </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.ServerSocketFactory Default
				{
						[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
						get{ return default(global::Javax.Net.ServerSocketFactory); }
				}

		}

		/// <summary>
		///  <para>This abstract class defines methods to create sockets. It can be subclassed to create specific socket types with additional socket-level functionality. </para>    
		/// </summary>
		/// <java-name>
		/// javax/net/SocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/SocketFactory", AccessFlags = 1057)]
		public abstract partial class SocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>SocketFactory </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new socket which is not connected to any remote host. This method has to be overridden by a subclass otherwise a <c>SocketException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created unconnected socket. </para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1)]
				public virtual global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				///  <para>Creates a new socket which is connected to the remote host specified by the InetAddress <c>host </c> . The socket is bound to any available local address and port.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created connected socket. </para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(string host, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new socket which is connected to the remote host specified by the InetAddress <c>address </c> . The socket is bound to the local network interface specified by the InetAddress <c>localHost </c> on port <c>localPort </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created connected socket. </para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(string address, int port, global::Java.Net.InetAddress localAddress, int localPort) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new socket which is connected to the remote host specified by the InetAddress <c>host </c> . The socket is bound to any available local address and port.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created connected socket. </para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress host, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new socket which is connected to the remote host specified by the InetAddress <c>address </c> . The socket is bound to the local network interface specified by the InetAddress <c>localHost </c> on port <c>localPort </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created connected socket. </para>
				/// </returns>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress address, int port, global::Java.Net.InetAddress localAddress, int localPort) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the default socket factory of the system which can be used to create new sockets without creating a subclass of this factory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the system default socket factory. </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.SocketFactory Default
				{
						[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
						get{ return default(global::Javax.Net.SocketFactory); }
				}

		}

}

