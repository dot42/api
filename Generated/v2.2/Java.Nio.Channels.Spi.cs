#pragma warning disable 1717
namespace Java.Nio.Channels.Spi
{
		/// <summary>
		///  <para> <c>AbstractInterruptibleChannel </c> is the root class for interruptible channels. </para> <para>The basic usage pattern for an interruptible channel is to invoke  <c>begin() </c> before any I/O operation that potentially blocks indefinitely, then <c>end(boolean) </c> after completing the operation. The argument to the <c>end </c> method should indicate if the I/O operation has actually completed so that any change may be visible to the invoker. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Closes an open channel. If the channel is already closed then this method has no effect, otherwise it closes the receiver via the  <c>implCloseChannel </c> method. </para> <para>If an attempt is made to perform an operation on a closed channel then a java.nio.channels.ClosedChannelException is thrown. </para> <para>If multiple threads attempt to simultaneously close a channel, then only one thread will run the closure code and the others will be blocked until the first one completes.</para> <para> <para>java.nio.channels.Channel::close() </para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 17)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates the beginning of a code section that includes an I/O operation that is potentially blocking. After this operation, the application should invoke the corresponding <c>end(boolean) </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// begin
				/// </java-name>
				[Dot42.DexImport("begin", "()V", AccessFlags = 20)]
				protected internal void Begin() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates the end of a code section that has been started with  <c>begin() </c> and that includes a potentially blocking I/O operation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Z)V", AccessFlags = 20)]
				protected internal void End(bool success) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implements the channel closing behavior. </para> <para>Closes the channel with a guarantee that the channel is not currently closed through another invocation of <c>close() </c> and that the method is thread-safe. </para> <para>Any outstanding threads blocked on I/O operations on this channel must be released with either a normal return code, or by throwing an  <c>AsynchronousCloseException </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// implCloseChannel
				/// </java-name>
				[Dot42.DexImport("implCloseChannel", "()V", AccessFlags = 1028)]
				protected internal abstract void ImplCloseChannel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns true if this channel is open. </para>        
				/// </summary>
				/// <java-name>
				/// isOpen
				/// </java-name>
				public bool IsOpen
				{
						[Dot42.DexImport("isOpen", "()Z", AccessFlags = 49)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para> <c>AbstractSelectableChannel </c> is the base implementation class for selectable channels. It declares methods for registering, unregistering and closing selectable channels. It is thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/spi/AbstractSelectableChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/AbstractSelectableChannel", AccessFlags = 1057)]
		public abstract partial class AbstractSelectableChannel : global::Java.Nio.Channels.SelectableChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>AbstractSelectableChannel </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal AbstractSelectableChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the selector provider that has created this channel.</para> <para> <para>java.nio.channels.SelectableChannel::provider() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this channel's selector provider. </para>
				/// </returns>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 17)]
				public override global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Spi.SelectorProvider);
				}

				/// <summary>
				///  <para>Gets this channel's selection key for the specified selector.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the selection key for the channel or <c>null </c> if this channel has not been registered with <c>selector </c> . </para>
				/// </returns>
				/// <java-name>
				/// keyFor
				/// </java-name>
				[Dot42.DexImport("keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", AccessFlags = 49)]
				public override global::Java.Nio.Channels.SelectionKey KeyFor(global::Java.Nio.Channels.Selector selector) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectionKey);
				}

				/// <summary>
				///  <para>Registers this channel with the specified selector for the specified interest set. If the channel is already registered with the selector, the interest set is updated to <c>interestSet </c> and the corresponding selection key is returned. If the channel is not yet registered, this method calls the <c>register </c> method of  <c>selector </c> and adds the selection key to this channel's key set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the selection key for this registration. </para>
				/// </returns>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;" +
    "", AccessFlags = 17)]
				public override global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Selector selector, int interestSet, object attachment) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectionKey);
				}

				/// <summary>
				///  <para>Implements the channel closing behavior. Calls  <c>implCloseSelectableChannel() </c> first, then loops through the list of selection keys and cancels them, which unregisters this channel from all selectors it is registered with.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// implCloseChannel
				/// </java-name>
				[Dot42.DexImport("implCloseChannel", "()V", AccessFlags = 52)]
				protected internal override void ImplCloseChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implements the closing function of the SelectableChannel. This method is called from <c>implCloseChannel() </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// implCloseSelectableChannel
				/// </java-name>
				[Dot42.DexImport("implCloseSelectableChannel", "()V", AccessFlags = 1028)]
				protected internal abstract void ImplCloseSelectableChannel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the object used for the synchronization of <c>register </c> and  <c>configureBlocking </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the synchronization object. </para>
				/// </returns>
				/// <java-name>
				/// blockingLock
				/// </java-name>
				[Dot42.DexImport("blockingLock", "()Ljava/lang/Object;", AccessFlags = 17)]
				public override object BlockingLock() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Sets the blocking mode of this channel. A call to this method blocks if other calls to this method or to <c>register </c> are executing. The actual setting of the mode is done by calling  <c>implConfigureBlocking(boolean) </c> .</para> <para> <para>java.nio.channels.SelectableChannel::configureBlocking(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this channel. </para>
				/// </returns>
				/// <java-name>
				/// configureBlocking
				/// </java-name>
				[Dot42.DexImport("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", AccessFlags = 17)]
				public override global::Java.Nio.Channels.SelectableChannel ConfigureBlocking(bool blockingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectableChannel);
				}

				/// <summary>
				///  <para>Implements the configuration of blocking/non-blocking mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// implConfigureBlocking
				/// </java-name>
				[Dot42.DexImport("implConfigureBlocking", "(Z)V", AccessFlags = 1028)]
				protected internal abstract void ImplConfigureBlocking(bool blocking) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbstractSelectableChannel() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this channel is registered with one or more selectors.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this channel is registered with a selector,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRegistered
				/// </java-name>
				public override bool IsRegistered
				{
						[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 49)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether this channel is in blocking mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this channel is blocking, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isBlocking
				/// </java-name>
				public override bool IsBlocking
				{
						[Dot42.DexImport("isBlocking", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para> <c>AbstractSelectionKey </c> is the base implementation class for selection keys. It implements validation and cancellation methods. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/spi/AbstractSelectionKey
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/AbstractSelectionKey", AccessFlags = 1057)]
		public abstract partial class AbstractSelectionKey : global::Java.Nio.Channels.SelectionKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>AbstractSelectionKey </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractSelectionKey() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancels this key. </para> <para>A key that has been canceled is no longer valid. Calling this method on an already canceled key does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 17)]
				public override void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this key is valid. A key is valid as long as it has not been canceled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this key has not been canceled, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValid
				/// </java-name>
				public override bool IsValid
				{
						[Dot42.DexImport("isValid", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para> <c>AbstractSelector </c> is the base implementation class for selectors. It realizes the interruption of selection by <c>begin </c> and  <c>end </c> . It also holds the cancellation and the deletion of the key set. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Closes this selector. This method does nothing if this selector is already closed. The actual closing must be implemented by subclasses in  <c>implCloseSelector() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 17)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implements the closing of this channel. </para>        
				/// </summary>
				/// <java-name>
				/// implCloseSelector
				/// </java-name>
				[Dot42.DexImport("implCloseSelector", "()V", AccessFlags = 1028)]
				protected internal abstract void ImplCloseSelector() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns this selector's provider. </para>        
				/// </summary>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 17)]
				public override global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Spi.SelectorProvider);
				}

				/// <summary>
				///  <para>Returns this channel's set of canceled selection keys. </para>        
				/// </summary>
				/// <java-name>
				/// cancelledKeys
				/// </java-name>
				[Dot42.DexImport("cancelledKeys", "()Ljava/util/Set;", AccessFlags = 20, Signature = "()Ljava/util/Set<Ljava/nio/channels/SelectionKey;>;")]
				protected internal global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey> CancelledKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey>);
				}

				/// <summary>
				///  <para>Registers <c>channel </c> with this selector.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the key related to the channel and this selector. </para>
				/// </returns>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/spi/AbstractSelectableChannel;ILjava/lang/Object;)Ljava/nio/c" +
    "hannels/SelectionKey;", AccessFlags = 1028)]
				protected internal abstract global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Spi.AbstractSelectableChannel channel, int operations, object attachment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Deletes the key from the channel's key set. </para>        
				/// </summary>
				/// <java-name>
				/// deregister
				/// </java-name>
				[Dot42.DexImport("deregister", "(Ljava/nio/channels/spi/AbstractSelectionKey;)V", AccessFlags = 20)]
				protected internal void Deregister(global::Java.Nio.Channels.Spi.AbstractSelectionKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates the beginning of a code section that includes an I/O operation that is potentially blocking. After this operation, the application should invoke the corresponding <c>end(boolean) </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// begin
				/// </java-name>
				[Dot42.DexImport("begin", "()V", AccessFlags = 20)]
				protected internal void Begin() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates the end of a code section that has been started with  <c>begin() </c> and that includes a potentially blocking I/O operation. </para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 20)]
				protected internal void End() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbstractSelector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns true if this selector is open. </para>        
				/// </summary>
				/// <java-name>
				/// isOpen
				/// </java-name>
				public override bool IsOpen
				{
						[Dot42.DexImport("isOpen", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para> <c>SelectorProvider </c> is an abstract base class that declares methods for providing instances of DatagramChannel, Pipe, java.nio.channels.Selector , ServerSocketChannel, and SocketChannel. All the methods of this class are thread-safe.</para> <para>A provider instance can be retrieved through a system property or the configuration file in a jar file; if no provider is available that way then the system default provider is returned. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/spi/SelectorProvider
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/spi/SelectorProvider", AccessFlags = 1057)]
		public abstract partial class SelectorProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>SelectorProvider </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SelectorProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets a provider instance by executing the following steps when called for the first time:  <ul> <li> <para>if the system property "java.nio.channels.spi.SelectorProvider" is set, the value of this property is the class name of the provider returned;  </para></li> <li> <para>if there is a provider-configuration file named "java.nio.channels.spi.SelectorProvider" in META-INF/services of a jar file valid in the system class loader, the first class name is the provider's class name;  </para></li> <li> <para>otherwise, a system default provider will be returned. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider. </para>
				/// </returns>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 41)]
				public static global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Spi.SelectorProvider);
				}

				/// <summary>
				///  <para>Creates a new open <c>DatagramChannel </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new channel. </para>
				/// </returns>
				/// <java-name>
				/// openDatagramChannel
				/// </java-name>
				[Dot42.DexImport("openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.DatagramChannel OpenDatagramChannel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new <c>Pipe </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new pipe. </para>
				/// </returns>
				/// <java-name>
				/// openPipe
				/// </java-name>
				[Dot42.DexImport("openPipe", "()Ljava/nio/channels/Pipe;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Pipe OpenPipe() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new selector.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new selector. </para>
				/// </returns>
				/// <java-name>
				/// openSelector
				/// </java-name>
				[Dot42.DexImport("openSelector", "()Ljava/nio/channels/spi/AbstractSelector;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Spi.AbstractSelector OpenSelector() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a new open <c>ServerSocketChannel </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new channel. </para>
				/// </returns>
				/// <java-name>
				/// openServerSocketChannel
				/// </java-name>
				[Dot42.DexImport("openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.ServerSocketChannel OpenServerSocketChannel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new open <c>SocketChannel </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new channel. </para>
				/// </returns>
				/// <java-name>
				/// openSocketChannel
				/// </java-name>
				[Dot42.DexImport("openSocketChannel", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SocketChannel OpenSocketChannel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the channel inherited from the process that created this VM. On Android, this method always returns null because stdin and stdout are never connected to a socket.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the channel. </para>
				/// </returns>
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

