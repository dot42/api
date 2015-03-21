#pragma warning disable 1717
namespace Java.Nio.Channels.Spi
{
		/// <java-name>
		/// java/nio/channels/spi/AbstractInterruptibleChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/AbstractInterruptibleChannel", AccessFlags = 1057)]
		public abstract partial class AbstractInterruptibleChannel : global::Java.Nio.Channels.IChannel, global::Java.Nio.Channels.IInterruptibleChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractInterruptibleChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 49)]
				public bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 17)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// begin
				/// </java-name>
				[Dot42.DexImport("begin", "()V", AccessFlags = 20)]
				protected internal void Begin() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Z)V", AccessFlags = 20)]
				protected internal void End(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implCloseChannel
				/// </java-name>
				[Dot42.DexImport("implCloseChannel", "()V", AccessFlags = 1028)]
				protected internal abstract void ImplCloseChannel() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/nio/channels/spi/AbstractSelectableChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/AbstractSelectableChannel", AccessFlags = 1057)]
		public abstract partial class AbstractSelectableChannel : global::Java.Nio.Channels.SelectableChannel
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal AbstractSelectableChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 17)]
				public override global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Spi.SelectorProvider);
				}

				/// <java-name>
				/// isRegistered
				/// </java-name>
				[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 49)]
				public override bool IsRegistered() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// keyFor
				/// </java-name>
				[Dot42.DexImport("keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", AccessFlags = 49)]
				public override global::Java.Nio.Channels.SelectionKey KeyFor(global::Java.Nio.Channels.Selector selector) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectionKey);
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;" +
    "", AccessFlags = 17)]
				public override global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Selector selector, int int32, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectionKey);
				}

				/// <java-name>
				/// implCloseChannel
				/// </java-name>
				[Dot42.DexImport("implCloseChannel", "()V", AccessFlags = 52)]
				protected internal override void ImplCloseChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implCloseSelectableChannel
				/// </java-name>
				[Dot42.DexImport("implCloseSelectableChannel", "()V", AccessFlags = 1028)]
				protected internal abstract void ImplCloseSelectableChannel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isBlocking
				/// </java-name>
				[Dot42.DexImport("isBlocking", "()Z", AccessFlags = 17)]
				public override bool IsBlocking() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// blockingLock
				/// </java-name>
				[Dot42.DexImport("blockingLock", "()Ljava/lang/Object;", AccessFlags = 17)]
				public override object BlockingLock() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// configureBlocking
				/// </java-name>
				[Dot42.DexImport("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", AccessFlags = 17)]
				public override global::Java.Nio.Channels.SelectableChannel ConfigureBlocking(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectableChannel);
				}

				/// <java-name>
				/// implConfigureBlocking
				/// </java-name>
				[Dot42.DexImport("implConfigureBlocking", "(Z)V", AccessFlags = 1028)]
				protected internal abstract void ImplConfigureBlocking(bool boolean) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractSelectableChannel() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/spi/AbstractSelectionKey
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/AbstractSelectionKey", AccessFlags = 1057)]
		public abstract partial class AbstractSelectionKey : global::Java.Nio.Channels.SelectionKey
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractSelectionKey() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 17)]
				public override bool IsValid() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 17)]
				public override void Cancel() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/spi/AbstractSelector
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/AbstractSelector", AccessFlags = 1057)]
		public abstract partial class AbstractSelector : global::Java.Nio.Channels.Selector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal AbstractSelector(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 17)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implCloseSelector
				/// </java-name>
				[Dot42.DexImport("implCloseSelector", "()V", AccessFlags = 1028)]
				protected internal abstract void ImplCloseSelector() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 17)]
				public override bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 17)]
				public override global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Spi.SelectorProvider);
				}

				/// <java-name>
				/// cancelledKeys
				/// </java-name>
				[Dot42.DexImport("cancelledKeys", "()Ljava/util/Set;", AccessFlags = 20, Signature = "()Ljava/util/Set<Ljava/nio/channels/SelectionKey;>;")]
				protected internal global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey> CancelledKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey>);
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/c" +
    "hannels/SelectionKey;", AccessFlags = 1028)]
				protected internal abstract global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Spi.AbstractSelectableChannel abstractSelectableChannel, int int32, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deregister
				/// </java-name>
				[Dot42.DexImport("deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V", AccessFlags = 20)]
				protected internal void Deregister(global::Java.Nio.Channels.Spi.AbstractSelectionKey abstractSelectionKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// begin
				/// </java-name>
				[Dot42.DexImport("begin", "()V", AccessFlags = 20)]
				protected internal void Begin() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 20)]
				protected internal void End() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractSelector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/channels/spi/SelectorProvider
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/SelectorProvider", AccessFlags = 1057)]
		public abstract partial class SelectorProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SelectorProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 41)]
				public static global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Spi.SelectorProvider);
				}

				/// <java-name>
				/// openDatagramChannel
				/// </java-name>
				[Dot42.DexImport("openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.DatagramChannel OpenDatagramChannel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openPipe
				/// </java-name>
				[Dot42.DexImport("openPipe", "()Ljava/nio/channels/Pipe;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Pipe OpenPipe() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openSelector
				/// </java-name>
				[Dot42.DexImport("openSelector", "()Ljava/nio/channels/spi/AbstractSelector;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Spi.AbstractSelector OpenSelector() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openServerSocketChannel
				/// </java-name>
				[Dot42.DexImport("openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.ServerSocketChannel OpenServerSocketChannel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openSocketChannel
				/// </java-name>
				[Dot42.DexImport("openSocketChannel", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SocketChannel OpenSocketChannel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// inheritedChannel
				/// </java-name>
				[Dot42.DexImport("inheritedChannel", "()Ljava/nio/channels/Channel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.IChannel InheritedChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IChannel);
				}

		}

}

