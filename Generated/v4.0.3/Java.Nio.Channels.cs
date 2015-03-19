#pragma warning disable 1717
namespace Java.Nio.Channels
{
		/// <java-name>
		/// java/nio/channels/ClosedByInterruptException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ClosedByInterruptException", AccessFlags = 33)]
		public partial class ClosedByInterruptException : global::Java.Nio.Channels.AsynchronousCloseException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClosedByInterruptException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/SocketChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/SocketChannel", AccessFlags = 1057)]
		public abstract partial class SocketChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel, global::Java.Nio.Channels.IByteChannel, global::Java.Nio.Channels.IScatteringByteChannel, global::Java.Nio.Channels.IGatheringByteChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal SocketChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.SocketChannel Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SocketChannel);
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.SocketChannel Open(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SocketChannel);
				}

				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
				public override int ValidOps() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// socket
				/// </java-name>
				[Dot42.DexImport("socket", "()Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket Socket() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1025)]
				public abstract bool IsConnected() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isConnectionPending
				/// </java-name>
				[Dot42.DexImport("isConnectionPending", "()Z", AccessFlags = 1025)]
				public abstract bool IsConnectionPending() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)Z", AccessFlags = 1025)]
				public abstract bool Connect(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// finishConnect
				/// </java-name>
				[Dot42.DexImport("finishConnect", "()Z", AccessFlags = 1025)]
				public abstract bool FinishConnect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Read(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Read(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Read(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Write(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Write(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Write(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SocketChannel() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/nio/channels/Channel", "isOpen", "()Z", AccessFlags = 1025)]
				public override bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/nio/channels/Channel", "close", "()V", AccessFlags = 1025)]
				public override void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/FileLock
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/FileLock", AccessFlags = 1057)]
		public abstract partial class FileLock
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/FileChannel;JJZ)V", AccessFlags = 4)]
				protected internal FileLock(global::Java.Nio.Channels.FileChannel fileChannel, long int64, long int641, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// channel
				/// </java-name>
				[Dot42.DexImport("channel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 17)]
				public global::Java.Nio.Channels.FileChannel Channel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileChannel);
				}

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "()J", AccessFlags = 17)]
				public long Position() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()J", AccessFlags = 17)]
				public long Size() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// isShared
				/// </java-name>
				[Dot42.DexImport("isShared", "()Z", AccessFlags = 17)]
				public bool IsShared() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// overlaps
				/// </java-name>
				[Dot42.DexImport("overlaps", "(JJ)Z", AccessFlags = 17)]
				public bool Overlaps(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				public abstract bool IsValid() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1025)]
				public abstract void Release() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileLock() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/ConnectionPendingException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ConnectionPendingException", AccessFlags = 33)]
		public partial class ConnectionPendingException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectionPendingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/NonWritableChannelException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NonWritableChannelException", AccessFlags = 33)]
		public partial class NonWritableChannelException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NonWritableChannelException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/NotYetConnectedException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NotYetConnectedException", AccessFlags = 33)]
		public partial class NotYetConnectedException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotYetConnectedException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/IllegalSelectorException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/IllegalSelectorException", AccessFlags = 33)]
		public partial class IllegalSelectorException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalSelectorException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/ServerSocketChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ServerSocketChannel", AccessFlags = 1057)]
		public abstract partial class ServerSocketChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal ServerSocketChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.ServerSocketChannel Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.ServerSocketChannel);
				}

				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
				public override int ValidOps() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// socket
				/// </java-name>
				[Dot42.DexImport("socket", "()Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket Socket() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SocketChannel Accept() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ServerSocketChannel() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/ClosedSelectorException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ClosedSelectorException", AccessFlags = 33)]
		public partial class ClosedSelectorException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClosedSelectorException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/Pipe
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Pipe", AccessFlags = 1057)]
		public abstract partial class Pipe
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Pipe() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/Pipe;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.Pipe Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Pipe);
				}

				/// <java-name>
				/// sink
				/// </java-name>
				[Dot42.DexImport("sink", "()Ljava/nio/channels/Pipe$SinkChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Pipe.SinkChannel Sink() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// source
				/// </java-name>
				[Dot42.DexImport("source", "()Ljava/nio/channels/Pipe$SourceChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Pipe.SourceChannel Source() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// java/nio/channels/Pipe$SourceChannel
				/// </java-name>
				[Dot42.DexImport("java/nio/channels/Pipe$SourceChannel", AccessFlags = 1033)]
				public abstract partial class SourceChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel, global::Java.Nio.Channels.IReadableByteChannel, global::Java.Nio.Channels.IScatteringByteChannel
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
						protected internal SourceChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// validOps
						/// </java-name>
						[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
						public override int ValidOps() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SourceChannel() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("java/nio/channels/ReadableByteChannel", "read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
						public virtual int Read(global::Java.Nio.ByteBuffer byteBuffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(int);
						}

						[Dot42.DexImport("java/nio/channels/Channel", "isOpen", "()Z", AccessFlags = 1025)]
						public override bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(bool);
						}

						[Dot42.DexImport("java/nio/channels/Channel", "close", "()V", AccessFlags = 1025)]
						public override void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("java/nio/channels/ScatteringByteChannel", "read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 1025)]
						public virtual long Read(global::Java.Nio.ByteBuffer[] byteBuffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

						[Dot42.DexImport("java/nio/channels/ScatteringByteChannel", "read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
						public virtual long Read(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

				}

				/// <java-name>
				/// java/nio/channels/Pipe$SinkChannel
				/// </java-name>
				[Dot42.DexImport("java/nio/channels/Pipe$SinkChannel", AccessFlags = 1033)]
				public abstract partial class SinkChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel, global::Java.Nio.Channels.IWritableByteChannel, global::Java.Nio.Channels.IGatheringByteChannel
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
						protected internal SinkChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// validOps
						/// </java-name>
						[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
						public override int ValidOps() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SinkChannel() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("java/nio/channels/WritableByteChannel", "write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
						public virtual int Write(global::Java.Nio.ByteBuffer byteBuffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(int);
						}

						[Dot42.DexImport("java/nio/channels/Channel", "isOpen", "()Z", AccessFlags = 1025)]
						public override bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(bool);
						}

						[Dot42.DexImport("java/nio/channels/Channel", "close", "()V", AccessFlags = 1025)]
						public override void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("java/nio/channels/GatheringByteChannel", "write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 1025)]
						public virtual long Write(global::Java.Nio.ByteBuffer[] byteBuffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

						[Dot42.DexImport("java/nio/channels/GatheringByteChannel", "write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
						public virtual long Write(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

				}

		}

		/// <java-name>
		/// java/nio/channels/NonReadableChannelException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NonReadableChannelException", AccessFlags = 33)]
		public partial class NonReadableChannelException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NonReadableChannelException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/Channel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Channel", AccessFlags = 1537)]
		public partial interface IChannel : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1025)]
				bool IsOpen() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/SelectableChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/SelectableChannel", AccessFlags = 1057)]
		public abstract partial class SelectableChannel : global::Java.Nio.Channels.Spi.AbstractInterruptibleChannel, global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SelectableChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// blockingLock
				/// </java-name>
				[Dot42.DexImport("blockingLock", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object BlockingLock() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// configureBlocking
				/// </java-name>
				[Dot42.DexImport("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectableChannel ConfigureBlocking(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isBlocking
				/// </java-name>
				[Dot42.DexImport("isBlocking", "()Z", AccessFlags = 1025)]
				public abstract bool IsBlocking() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isRegistered
				/// </java-name>
				[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 1025)]
				public abstract bool IsRegistered() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keyFor
				/// </java-name>
				[Dot42.DexImport("keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectionKey KeyFor(global::Java.Nio.Channels.Selector selector) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;", AccessFlags = 17)]
				public global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Selector selector, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectionKey);
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;" +
    "", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Selector selector, int int32, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 1025)]
				public abstract int ValidOps() /* MethodBuilder.Create */ ;

				[Dot42.DexImport("java/nio/channels/Channel", "isOpen", "()Z", AccessFlags = 1025)]
				public new virtual bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/nio/channels/Channel", "close", "()V", AccessFlags = 1025)]
				public new virtual void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/IllegalBlockingModeException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/IllegalBlockingModeException", AccessFlags = 33)]
		public partial class IllegalBlockingModeException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalBlockingModeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/WritableByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/WritableByteChannel", AccessFlags = 1537)]
		public partial interface IWritableByteChannel : global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				int Write(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/GatheringByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/GatheringByteChannel", AccessFlags = 1537)]
		public partial interface IGatheringByteChannel : global::Java.Nio.Channels.IWritableByteChannel
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 1025)]
				long Write(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				long Write(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/ReadableByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ReadableByteChannel", AccessFlags = 1537)]
		public partial interface IReadableByteChannel : global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				int Read(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/AsynchronousCloseException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/AsynchronousCloseException", AccessFlags = 33)]
		public partial class AsynchronousCloseException : global::Java.Nio.Channels.ClosedChannelException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AsynchronousCloseException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/FileChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/FileChannel", AccessFlags = 1057)]
		public abstract partial class FileChannel : global::Java.Nio.Channels.Spi.AbstractInterruptibleChannel, global::Java.Nio.Channels.IGatheringByteChannel, global::Java.Nio.Channels.IScatteringByteChannel, global::Java.Nio.Channels.IByteChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal FileChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// force
				/// </java-name>
				[Dot42.DexImport("force", "(Z)V", AccessFlags = 1025)]
				public abstract void Force(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()Ljava/nio/channels/FileLock;", AccessFlags = 17)]
				public global::Java.Nio.Channels.FileLock Lock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileLock);
				}

				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "(JJZ)Ljava/nio/channels/FileLock;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileLock Lock(long int64, long int641, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// map
				/// </java-name>
				[Dot42.DexImport("map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.MappedByteBuffer Map(global::Java.Nio.Channels.FileChannel.MapMode mapMode, long int64, long int641) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "()J", AccessFlags = 1025)]
				public abstract long Position() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(J)Ljava/nio/channels/FileChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileChannel Position(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Read(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;J)I", AccessFlags = 1025)]
				public abstract int Read(global::Java.Nio.ByteBuffer byteBuffer, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 17)]
				public long Read(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Read(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()J", AccessFlags = 1025)]
				public abstract long Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// transferFrom
				/// </java-name>
				[Dot42.DexImport("transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J", AccessFlags = 1025)]
				public abstract long TransferFrom(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel, long int64, long int641) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// transferTo
				/// </java-name>
				[Dot42.DexImport("transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J", AccessFlags = 1025)]
				public abstract long TransferTo(long int64, long int641, global::Java.Nio.Channels.IWritableByteChannel writableByteChannel) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(J)Ljava/nio/channels/FileChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileChannel Truncate(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "()Ljava/nio/channels/FileLock;", AccessFlags = 17)]
				public global::Java.Nio.Channels.FileLock TryLock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileLock);
				}

				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "(JJZ)Ljava/nio/channels/FileLock;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileLock TryLock(long int64, long int641, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Write(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;J)I", AccessFlags = 1025)]
				public abstract int Write(global::Java.Nio.ByteBuffer byteBuffer, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 17)]
				public long Write(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Write(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[Dot42.DexImport("java/nio/channels/Channel", "isOpen", "()Z", AccessFlags = 1025)]
				public new virtual bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/nio/channels/Channel", "close", "()V", AccessFlags = 1025)]
				public new virtual void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// java/nio/channels/FileChannel$MapMode
				/// </java-name>
				[Dot42.DexImport("java/nio/channels/FileChannel$MapMode", AccessFlags = 9)]
				public partial class MapMode
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PRIVATE
						/// </java-name>
						[Dot42.DexImport("PRIVATE", "Ljava/nio/channels/FileChannel$MapMode;", AccessFlags = 25)]
						public static readonly MapMode PRIVATE;
						/// <java-name>
						/// READ_ONLY
						/// </java-name>
						[Dot42.DexImport("READ_ONLY", "Ljava/nio/channels/FileChannel$MapMode;", AccessFlags = 25)]
						public static readonly MapMode READ_ONLY;
						/// <java-name>
						/// READ_WRITE
						/// </java-name>
						[Dot42.DexImport("READ_WRITE", "Ljava/nio/channels/FileChannel$MapMode;", AccessFlags = 25)]
						public static readonly MapMode READ_WRITE;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal MapMode() /* MethodBuilder.Create */ 
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

		}

		/// <java-name>
		/// java/nio/channels/OverlappingFileLockException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/OverlappingFileLockException", AccessFlags = 33)]
		public partial class OverlappingFileLockException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OverlappingFileLockException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/AlreadyConnectedException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/AlreadyConnectedException", AccessFlags = 33)]
		public partial class AlreadyConnectedException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AlreadyConnectedException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/DatagramChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/DatagramChannel", AccessFlags = 1057)]
		public abstract partial class DatagramChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel, global::Java.Nio.Channels.IByteChannel, global::Java.Nio.Channels.IScatteringByteChannel, global::Java.Nio.Channels.IGatheringByteChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal DatagramChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.DatagramChannel Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.DatagramChannel);
				}

				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
				public override int ValidOps() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// socket
				/// </java-name>
				[Dot42.DexImport("socket", "()Ljava/net/DatagramSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.DatagramSocket Socket() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1025)]
				public abstract bool IsConnected() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.DatagramChannel Connect(global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.DatagramChannel Disconnect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", AccessFlags = 1025)]
				public abstract global::Java.Net.SocketAddress Receive(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", AccessFlags = 1025)]
				public abstract int Send(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Read(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Read(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Read(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Write(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Write(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Write(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DatagramChannel() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/nio/channels/Channel", "isOpen", "()Z", AccessFlags = 1025)]
				public override bool IsOpen() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/nio/channels/Channel", "close", "()V", AccessFlags = 1025)]
				public override void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/Channels
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Channels", AccessFlags = 49)]
		public sealed partial class Channels
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Channels() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInputStream
				/// </java-name>
				[Dot42.DexImport("newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;", AccessFlags = 9)]
				public static global::Java.Io.InputStream NewInputStream(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// newOutputStream
				/// </java-name>
				[Dot42.DexImport("newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;", AccessFlags = 9)]
				public static global::Java.Io.OutputStream NewOutputStream(global::Java.Nio.Channels.IWritableByteChannel writableByteChannel) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// newChannel
				/// </java-name>
				[Dot42.DexImport("newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.IReadableByteChannel NewChannel(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IReadableByteChannel);
				}

				/// <java-name>
				/// newChannel
				/// </java-name>
				[Dot42.DexImport("newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.IWritableByteChannel NewChannel(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IWritableByteChannel);
				}

				/// <java-name>
				/// newReader
				/// </java-name>
				[Dot42.DexImport("newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/" +
    "io/Reader;", AccessFlags = 9)]
				public static global::Java.Io.Reader NewReader(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel, global::Java.Nio.Charset.CharsetDecoder charsetDecoder, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <java-name>
				/// newReader
				/// </java-name>
				[Dot42.DexImport("newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 9)]
				public static global::Java.Io.Reader NewReader(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <java-name>
				/// newWriter
				/// </java-name>
				[Dot42.DexImport("newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/" +
    "io/Writer;", AccessFlags = 9)]
				public static global::Java.Io.Writer NewWriter(global::Java.Nio.Channels.IWritableByteChannel writableByteChannel, global::Java.Nio.Charset.CharsetEncoder charsetEncoder, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				/// <java-name>
				/// newWriter
				/// </java-name>
				[Dot42.DexImport("newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;", AccessFlags = 9)]
				public static global::Java.Io.Writer NewWriter(global::Java.Nio.Channels.IWritableByteChannel writableByteChannel, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

		}

		/// <java-name>
		/// java/nio/channels/NotYetBoundException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NotYetBoundException", AccessFlags = 33)]
		public partial class NotYetBoundException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotYetBoundException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/SelectionKey
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/SelectionKey", AccessFlags = 1057)]
		public abstract partial class SelectionKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OP_ACCEPT
				/// </java-name>
				[Dot42.DexImport("OP_ACCEPT", "I", AccessFlags = 25)]
				public const int OP_ACCEPT = 16;
				/// <java-name>
				/// OP_CONNECT
				/// </java-name>
				[Dot42.DexImport("OP_CONNECT", "I", AccessFlags = 25)]
				public const int OP_CONNECT = 8;
				/// <java-name>
				/// OP_READ
				/// </java-name>
				[Dot42.DexImport("OP_READ", "I", AccessFlags = 25)]
				public const int OP_READ = 1;
				/// <java-name>
				/// OP_WRITE
				/// </java-name>
				[Dot42.DexImport("OP_WRITE", "I", AccessFlags = 25)]
				public const int OP_WRITE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SelectionKey() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attach
				/// </java-name>
				[Dot42.DexImport("attach", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17)]
				public object Attach(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// attachment
				/// </java-name>
				[Dot42.DexImport("attachment", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Attachment() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1025)]
				public abstract void Cancel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// channel
				/// </java-name>
				[Dot42.DexImport("channel", "()Ljava/nio/channels/SelectableChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectableChannel Channel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// interestOps
				/// </java-name>
				[Dot42.DexImport("interestOps", "()I", AccessFlags = 1025)]
				public abstract int InterestOps() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// interestOps
				/// </java-name>
				[Dot42.DexImport("interestOps", "(I)Ljava/nio/channels/SelectionKey;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectionKey InterestOps(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isAcceptable
				/// </java-name>
				[Dot42.DexImport("isAcceptable", "()Z", AccessFlags = 17)]
				public bool IsAcceptable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isConnectable
				/// </java-name>
				[Dot42.DexImport("isConnectable", "()Z", AccessFlags = 17)]
				public bool IsConnectable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReadable
				/// </java-name>
				[Dot42.DexImport("isReadable", "()Z", AccessFlags = 17)]
				public bool IsReadable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				public abstract bool IsValid() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isWritable
				/// </java-name>
				[Dot42.DexImport("isWritable", "()Z", AccessFlags = 17)]
				public bool IsWritable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readyOps
				/// </java-name>
				[Dot42.DexImport("readyOps", "()I", AccessFlags = 1025)]
				public abstract int ReadyOps() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// selector
				/// </java-name>
				[Dot42.DexImport("selector", "()Ljava/nio/channels/Selector;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Selector Selector() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/FileLockInterruptionException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/FileLockInterruptionException", AccessFlags = 33)]
		public partial class FileLockInterruptionException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileLockInterruptionException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/InterruptibleChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/InterruptibleChannel", AccessFlags = 1537)]
		public partial interface IInterruptibleChannel : global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/UnsupportedAddressTypeException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/UnsupportedAddressTypeException", AccessFlags = 33)]
		public partial class UnsupportedAddressTypeException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedAddressTypeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/NoConnectionPendingException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NoConnectionPendingException", AccessFlags = 33)]
		public partial class NoConnectionPendingException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoConnectionPendingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/Selector
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Selector", AccessFlags = 1057)]
		public abstract partial class Selector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Selector() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/Selector;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.Selector Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Selector);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public abstract void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1025)]
				public abstract bool IsOpen() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/nio/channels/SelectionKey;>;")]
				public abstract global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey> Keys() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// select
				/// </java-name>
				[Dot42.DexImport("select", "()I", AccessFlags = 1025)]
				public abstract int Select() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// select
				/// </java-name>
				[Dot42.DexImport("select", "(J)I", AccessFlags = 1025)]
				public abstract int Select(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// selectedKeys
				/// </java-name>
				[Dot42.DexImport("selectedKeys", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/nio/channels/SelectionKey;>;")]
				public abstract global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey> SelectedKeys() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// selectNow
				/// </java-name>
				[Dot42.DexImport("selectNow", "()I", AccessFlags = 1025)]
				public abstract int SelectNow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// wakeup
				/// </java-name>
				[Dot42.DexImport("wakeup", "()Ljava/nio/channels/Selector;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Selector Wakeup() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/ByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ByteChannel", AccessFlags = 1537)]
		public partial interface IByteChannel : global::Java.Nio.Channels.IReadableByteChannel, global::Java.Nio.Channels.IWritableByteChannel
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/nio/channels/ClosedChannelException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ClosedChannelException", AccessFlags = 33)]
		public partial class ClosedChannelException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClosedChannelException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/UnresolvedAddressException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/UnresolvedAddressException", AccessFlags = 33)]
		public partial class UnresolvedAddressException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnresolvedAddressException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/ScatteringByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ScatteringByteChannel", AccessFlags = 1537)]
		public partial interface IScatteringByteChannel : global::Java.Nio.Channels.IReadableByteChannel
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 1025)]
				long Read(global::Java.Nio.ByteBuffer[] byteBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				long Read(global::Java.Nio.ByteBuffer[] byteBuffer, int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/CancelledKeyException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/CancelledKeyException", AccessFlags = 33)]
		public partial class CancelledKeyException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CancelledKeyException() /* MethodBuilder.Create */ 
				{
				}

		}

}

