#pragma warning disable 1717
namespace Javax.Net
{
		/// <java-name>
		/// javax/net/ServerSocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/ServerSocketFactory", AccessFlags = 1057)]
		public abstract partial class ServerSocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ServerSocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
				public static global::Javax.Net.ServerSocketFactory GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.ServerSocketFactory);
				}

				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "()Ljava/net/ServerSocket;", AccessFlags = 1)]
				public virtual global::Java.Net.ServerSocket CreateServerSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ServerSocket);
				}

				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "(I)Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket CreateServerSocket(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "(II)Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket CreateServerSocket(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createServerSocket
				/// </java-name>
				[Dot42.DexImport("createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket CreateServerSocket(int int32, int int321, global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.ServerSocketFactory Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/ServerSocketFactory;", AccessFlags = 41)]
						get{ return GetDefault(); }
				}

		}

		/// <java-name>
		/// javax/net/SocketFactory
		/// </java-name>
		[Dot42.DexImport("javax/net/SocketFactory", AccessFlags = 1057)]
		public abstract partial class SocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SocketFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
				public static global::Javax.Net.SocketFactory GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.SocketFactory);
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
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress inetAddress, int int32, global::Java.Net.InetAddress inetAddress1, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Javax.Net.SocketFactory Default
				{
				[Dot42.DexImport("getDefault", "()Ljavax/net/SocketFactory;", AccessFlags = 41)]
						get{ return GetDefault(); }
				}

		}

}

