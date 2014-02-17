// Copyright (C) 2014 dot42
//
// Original filename: Java.Nio.Channels.cs
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
namespace Java.Nio.Channels
{
		/// <summary>
		/// <para>A <c> NonReadableChannelException </c> is thrown when attempting to read from a channel that is not open for reading. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/NonReadableChannelException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NonReadableChannelException", AccessFlags = 33)]
		public partial class NonReadableChannelException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> NonReadableChannelException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NonReadableChannelException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> OverlappingFileLockException </c> is thrown when attempting to acquire a lock that overlaps an existing or pending lock held by this process. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/OverlappingFileLockException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/OverlappingFileLockException", AccessFlags = 33)]
		public partial class OverlappingFileLockException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> OverlappingFileLockException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OverlappingFileLockException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> CancelledKeyException </c> is thrown when an invalid selection key is used. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/CancelledKeyException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/CancelledKeyException", AccessFlags = 33)]
		public partial class CancelledKeyException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> CancelledKeyException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CancelledKeyException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> NonWritableChannelException </c> is thrown when attempting to write to a channel that is not open for writing. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/NonWritableChannelException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NonWritableChannelException", AccessFlags = 33)]
		public partial class NonWritableChannelException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> NonWritableChannelException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NonWritableChannelException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> FileLockInterruptionException </c> is thrown when a thread is interrupted while waiting to acquire a file lock. </para><para>Note that the thread will also be in the 'interrupted' state. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/FileLockInterruptionException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/FileLockInterruptionException", AccessFlags = 33)]
		public partial class FileLockInterruptionException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> FileLockInterruptionException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileLockInterruptionException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> IllegalSelectorException </c> is thrown when a call is made to register a channel on a selector that has been created by a different provider. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/IllegalSelectorException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/IllegalSelectorException", AccessFlags = 33)]
		public partial class IllegalSelectorException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> IllegalSelectorException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalSelectorException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> AsynchronousCloseException </c> is thrown when the underlying channel for an I/O operation is closed by another thread. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/AsynchronousCloseException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/AsynchronousCloseException", AccessFlags = 33)]
		public partial class AsynchronousCloseException : global::Java.Nio.Channels.ClosedChannelException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> AsynchronousCloseException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AsynchronousCloseException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> ClosedChannelException </c> is thrown when a channel is closed for the type of operation attempted. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ClosedChannelException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ClosedChannelException", AccessFlags = 33)]
		public partial class ClosedChannelException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> ClosedChannelException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClosedChannelException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> NotYetConnectedException </c> is thrown if the socket channel is not connected before an I/O operation is invoked. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/NotYetConnectedException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NotYetConnectedException", AccessFlags = 33)]
		public partial class NotYetConnectedException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> NotYetConnectedException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotYetConnectedException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> WritableByteChannel </c> is a type of Channel that can write bytes. </para><para>Write operations are synchronous on a <c> WritableByteChannel </c> , that is, if a write is already in progress on the channel then subsequent writes will block until the first write completes. It is undefined whether non-write operations will block. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/WritableByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/WritableByteChannel", AccessFlags = 1537)]
		public partial interface IWritableByteChannel : global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Writes bytes from the given buffer to the channel. </para><para>The maximum number of bytes that will be written is the <code>remaining()</code> number of bytes in the buffer when the method invoked. The bytes will be written from the buffer starting at the buffer's <code>position</code>. </para><para>The call may block if other threads are also attempting to write on the same channel. </para><para>Upon completion, the buffer's <code>position()</code> is updated to the end of the bytes that were written. The buffer's <code>limit()</code> is unmodified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				int Write(global::Java.Nio.ByteBuffer buffer) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for channels that can read data into a set of buffers in a single operation. The corresponding interface for writes is GatheringByteChannel. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ScatteringByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ScatteringByteChannel", AccessFlags = 1537)]
		public partial interface IScatteringByteChannel : global::Java.Nio.Channels.IReadableByteChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Reads bytes from this channel into the specified array of buffers. </para><para>This method is equivalent to <c> read(buffers, 0, buffers.length); </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 1025)]
				long Read(global::Java.Nio.ByteBuffer[] buffers) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Attempts to read all <c> remaining() </c> bytes from <c> length </c> byte buffers, in order, starting at <c> buffers[offset] </c> . The number of bytes actually read is returned. </para><para>If a read operation is in progress, subsequent threads will block until the read is completed and will then contend for the ability to read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				long Read(global::Java.Nio.ByteBuffer[] buffers, int offset, int length) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> ClosedByInterruptException </c> is thrown when a thread is interrupted in a blocking I/O operation. </para><para>When the thread is interrupted by a call to <c> interrupt() </c> , it closes the channel, sets the interrupt status of the thread to <c> true </c> and throws a <c> ClosedByInterruptException </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ClosedByInterruptException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ClosedByInterruptException", AccessFlags = 33)]
		public partial class ClosedByInterruptException : global::Java.Nio.Channels.AsynchronousCloseException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> ClosedByInterruptException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClosedByInterruptException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> ClosedSelectorException </c> is thrown when a selector is closed and an I/O operation is attempted. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ClosedSelectorException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ClosedSelectorException", AccessFlags = 33)]
		public partial class ClosedSelectorException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> ClosedSelectorException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClosedSelectorException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> UnresolvedAddressException </c> is thrown when trying to use an unresolved network address in a network operation. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/UnresolvedAddressException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/UnresolvedAddressException", AccessFlags = 33)]
		public partial class UnresolvedAddressException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> UnresolvedAddressException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnresolvedAddressException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> FileLock </c> represents a locked region of a file. </para><para>Locks have certain properties that enable collaborating processes to avoid the lost update problem or reading inconsistent data. Logically, a file lock can be <b>exclusive</b> or <b>shared</b>. Multiple processes can hold shared locks on the same region of a file, but only a single process can hold an exclusive lock on a given region of a file and no other process can simultaneously hold a shared lock overlapping the exclusive lock. An application can determine whether a <c> FileLock </c> is shared or exclusive via the <c> isShared() </c> method. </para><para>Locks held by a particular process cannot overlap one another. Applications can determine whether a proposed lock will overlap by using the <c>   overlaps(long, long) </c> ) method. Locks held in other processes may overlap locks held in this process. Locks are shared amongst all threads in the acquiring process, and are therefore unsuitable for intra-process synchronization. </para><para>Once a lock is acquired, it is immutable in all its state except <c>   isValid() </c> . The lock will initially be valid, but may be rendered invalid by explicit removal of the lock, using <c> release() </c> , or implicitly by closing the channel or exiting the process (terminating the VM). <h3>Platform dependencies</h3></para><para>Locks are intended to be true platform operating system file locks, and therefore locks held by the VM will be visible to other operating system processes. </para><para>The characteristics of the underlying operating system locks will show through in the Java implementation. For example, some platforms' locks are 'mandatory'  meaning the operating system enforces the locks on processes that attempt to access locked regions of files; whereas other platforms' locks are only 'advisory'  meaning that processes are required to collaborate to ensure locks are acquired and there is a potential for processes to not play well. To be on the safe side, it is best to assume that the platform is adopting advisory locks and always acquire shared locks when reading a region of a file. </para><para>On some platforms, the presence of a lock will prevent the file from being memory-mapped. On some platforms, closing a channel on a given file handle will release all the locks held on that file  even if there are other channels open on the same file; their locks will also be released. The safe option here is to ensure that you only acquire locks on a single channel for a particular file and that becomes the synchronization point. </para><para>Further care should be exercised when locking files maintained on network file systems, since they often have further limitations. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/FileLock
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/FileLock", AccessFlags = 1057)]
		public abstract partial class FileLock
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new file lock instance for a given channel. The constructor enforces the starting position, length and sharing mode of the lock.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/FileChannel;JJZ)V", AccessFlags = 4)]
				protected internal FileLock(global::Java.Nio.Channels.FileChannel channel, long position, long size, bool shared) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the lock's FileChannel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the channel. </para>
				/// </returns>
				/// <java-name>
				/// channel
				/// </java-name>
				[Dot42.DexImport("channel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 17)]
				public global::Java.Nio.Channels.FileChannel Channel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileChannel);
				}

				/// <summary>
				/// <para>Returns the lock's starting position in the file.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the lock position. </para>
				/// </returns>
				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "()J", AccessFlags = 17)]
				public long Position() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the length of the file lock in bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the file lock in bytes. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()J", AccessFlags = 17)]
				public long Size() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Indicates if the file lock is shared with other processes or if it is exclusive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the lock is a shared lock, <c> false </c> if it is exclusive. </para>
				/// </returns>
				/// <java-name>
				/// isShared
				/// </java-name>
				[Dot42.DexImport("isShared", "()Z", AccessFlags = 17)]
				public bool IsShared() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates if the receiver's lock region overlaps the region described in the parameter list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there is an overlap, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// overlaps
				/// </java-name>
				[Dot42.DexImport("overlaps", "(JJ)Z", AccessFlags = 17)]
				public bool Overlaps(long start, long length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this lock is a valid file lock. The lock is valid unless the underlying channel has been closed or it has been explicitly released.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the lock is valid, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				public abstract bool IsValid() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Releases this particular lock on the file. If the lock is invalid then this method has no effect. Once released, the lock becomes invalid.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1025)]
				public abstract void Release() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a string that shows the details of the lock suitable for display to an end user.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the display string. </para>
				/// </returns>
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

		/// <summary>
		/// <para>A controller for the selection of SelectableChannel objects. Selectable channels can be registered with a selector and get a SelectionKey that represents the registration. The keys are also added to the selector's key set. Selection keys can be canceled so that the corresponding channel is no longer registered with the selector. </para><para>By invoking the <c> select </c> method, the key set is checked and all keys that have been canceled since last select operation are moved to the set of canceled keys. During the select operation, the channels registered with this selector are checked to see whether they are ready for operation according to their interest set. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/Selector
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Selector", AccessFlags = 1057)]
		public abstract partial class Selector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> Selector </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Selector() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a selector returned by SelectorProvider#provider's SelectorProvider#openSelector method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/Selector;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.Selector Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Selector);
				}

				/// <summary>
				/// <para>Closes this selector. Ongoing calls to the <c> select </c> methods of this selector will get interrupted. This interruption behaves as if the wakeup() method of this selector is called. After this, all keys that are still valid are invalidated and their channels are unregistered. All resources held by this selector are released. </para><para>Any further attempt of using this selector after this method has been called (except calling close() or wakeup()) results in a ClosedSelectorException being thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public abstract void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this selector is open.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this selector is not closed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1025)]
				public abstract bool IsOpen() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the set of registered keys. The set is immutable and is not thread- safe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the set of registered keys. </para>
				/// </returns>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/nio/channels/SelectionKey;>;")]
				public abstract global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey> Keys() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the provider of this selector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this selector. </para>
				/// </returns>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Detects if any of the registered channels is ready for I/O operations according to its interest set. This method does not return until at least one channel is ready, wakeup() is invoked or the calling thread is interrupted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of channels that are ready for operation. </para>
				/// </returns>
				/// <java-name>
				/// select
				/// </java-name>
				[Dot42.DexImport("select", "()I", AccessFlags = 1025)]
				public abstract int Select() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Detects if any of the registered channels is ready for I/O operations according to its interest set. This method does not return until at least one channel is ready, wakeup() is invoked, the calling thread is interrupted or the specified <c> timeout </c> expires.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of channels that are ready for operation. </para>
				/// </returns>
				/// <java-name>
				/// select
				/// </java-name>
				[Dot42.DexImport("select", "(J)I", AccessFlags = 1025)]
				public abstract int Select(long timeout) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the selection keys whose channels are ready for operation. The set is not thread-safe and no keys may be added to it. Removing keys is allowed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the selection keys whose channels are ready for operation. </para>
				/// </returns>
				/// <java-name>
				/// selectedKeys
				/// </java-name>
				[Dot42.DexImport("selectedKeys", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/nio/channels/SelectionKey;>;")]
				public abstract global::Java.Util.ISet<global::Java.Nio.Channels.SelectionKey> SelectedKeys() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Detects if any of the registered channels is ready for I/O operations according to its interest set. This operation will return immediately.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of channels that are ready for operation, 0 if none is ready. </para>
				/// </returns>
				/// <java-name>
				/// selectNow
				/// </java-name>
				[Dot42.DexImport("selectNow", "()I", AccessFlags = 1025)]
				public abstract int SelectNow() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Forces blocked <c> select </c> operations to return immediately. </para><para>If no <c> select </c> operation is blocked when <c> wakeup() </c> is called then the next <c> select </c> operation will return immediately. This can be undone by a call to <c> selectNow() </c> ; after calling <c> selectNow() </c> , a subsequent call of <c> select </c> can block again.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this selector. </para>
				/// </returns>
				/// <java-name>
				/// wakeup
				/// </java-name>
				[Dot42.DexImport("wakeup", "()Ljava/nio/channels/Selector;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Selector Wakeup() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> ServerSocketChannel </c> is a partial abstraction of a selectable, stream-oriented listening socket. Binding and manipulation of socket options can only be done through the associated ServerSocket object, returned by calling <c> socket() </c> . ServerSocketChannels can not be constructed for an already existing server-socket, nor can a java.net.SocketImpl be assigned. </para><para>A server-socket channel is open but not bound when created by the <c>   open() </c> method. Calling <c> accept </c> before bound will cause a NotYetBoundException. It can be bound by calling the bind method of a related <c> ServerSocket </c> instance. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ServerSocketChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ServerSocketChannel", AccessFlags = 1057)]
		public abstract partial class ServerSocketChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new ServerSocketChannel.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal ServerSocketChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an open and unbound server-socket channel. </para><para>This channel is created by calling <c> openServerSocketChannel </c> method of the default <c> SelectorProvider </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new channel which is open but unbound. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.ServerSocketChannel Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.ServerSocketChannel);
				}

				/// <summary>
				/// <para>Gets the valid operations of this channel. Server-socket channels support accepting operation, so this method returns <c>       SelectionKey.OP_ACCEPT </c> .</para><para><para>java.nio.channels.SelectableChannel::validOps() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the operations supported by this channel. </para>
				/// </returns>
				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
				public override int ValidOps() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the server-socket assigned this channel, which does not declare any public methods that are not declared in <c> ServerSocket </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the server-socket assigned to this channel. </para>
				/// </returns>
				/// <java-name>
				/// socket
				/// </java-name>
				[Dot42.DexImport("socket", "()Ljava/net/ServerSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.ServerSocket Socket() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Accepts a connection to this server-socket channel. </para><para>This method returns <c> null </c> when this channel is non-blocking and no connection is available, otherwise it blocks until a new connection is available or an I/O error occurs. The socket channel returned by this method will always be in blocking mode. </para><para>This method just executes the same security checks as the <c>       accept() </c> method of the ServerSocket class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accepted <c> SocketChannel </c> instance, or <c> null </c> if the channel is non-blocking and no connection is available. </para>
				/// </returns>
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

		/// <summary>
		/// <para>An <c> UnsupportedAddressTypeException </c> is thrown when connecting or binding to an unsupported address type. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/UnsupportedAddressTypeException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/UnsupportedAddressTypeException", AccessFlags = 33)]
		public partial class UnsupportedAddressTypeException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> UnsupportedAddressTypeException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedAddressTypeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The interface for channels that can write a set of buffers in a single operation. The corresponding interface for read operations is ScatteringByteChannel. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/GatheringByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/GatheringByteChannel", AccessFlags = 1537)]
		public partial interface IGatheringByteChannel : global::Java.Nio.Channels.IWritableByteChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Writes bytes from all the given buffers to a channel. </para><para>This method is equivalent to: <c> write(buffers, 0, buffers.length); </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 1025)]
				long Write(global::Java.Nio.ByteBuffer[] buffers) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Attempts to write all <code>remaining()</code> bytes from <c> length </c> byte buffers, in order, starting at <c> buffers[offset] </c> . The number of bytes actually written is returned. </para><para>If a write operation is in progress, subsequent threads will block until the write is completed and then contend for the ability to write.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				long Write(global::Java.Nio.ByteBuffer[] buffers, int offset, int length) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A ByteChannel is both readable and writable. </para><para>The methods for the byte channel are precisely those defined by readable and writable byte channels.</para><para><para>ReadableByteChannel </para><simplesectsep></simplesectsep><para>WritableByteChannel </para></para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ByteChannel", AccessFlags = 1537)]
		public partial interface IByteChannel : global::Java.Nio.Channels.IReadableByteChannel, global::Java.Nio.Channels.IWritableByteChannel
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>A <c> NotYetBoundException </c> is thrown if the server socket channel is not bound before an I/O operation is made. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/NotYetBoundException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NotYetBoundException", AccessFlags = 33)]
		public partial class NotYetBoundException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> NotYetBoundException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotYetBoundException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> IllegalBlockingModeException </c> is thrown when an operation that requires a specific blocking mode is invoked on a channel that is in a different blocking mode. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/IllegalBlockingModeException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/IllegalBlockingModeException", AccessFlags = 33)]
		public partial class IllegalBlockingModeException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> IllegalBlockingModeException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalBlockingModeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> DatagramChannel </c> is a selectable channel that represents a partial abstraction of a datagram socket. The <c> socket </c> method of this class can return the related <c> DatagramSocket </c> instance, which can handle the socket. </para><para>A datagram channel is open but not connected when created with the <c> open() </c> method. After it is connected, it will keep the connected status until it is disconnected or closed. The benefit of a connected channel is the reduced effort of security checks during send and receive. When invoking <c> read </c> or <c> write </c> , a connected channel is required. </para><para>Datagram channels are thread-safe; only one thread can read or write at the same time. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/DatagramChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/DatagramChannel", AccessFlags = 1057)]
		public abstract partial class DatagramChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel, global::Java.Nio.Channels.IByteChannel, global::Java.Nio.Channels.IScatteringByteChannel, global::Java.Nio.Channels.IGatheringByteChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> DatagramChannel </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal DatagramChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an opened and not-connected datagram channel. </para><para>This channel is created by calling the <code>openDatagramChannel</code> method of the default SelectorProvider instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new channel which is open but not connected. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.DatagramChannel Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.DatagramChannel);
				}

				/// <summary>
				/// <para>Gets the valid operations of this channel. Datagram channels support read and write operations, so this method returns ( <code>SelectionKey.OP_READ</code> | <code>SelectionKey.OP_WRITE</code> ).</para><para><para>java.nio.channels.SelectableChannel::validOps() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>valid operations in bit-set. </para>
				/// </returns>
				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
				public override int ValidOps() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the related datagram socket of this channel, which does not define additional public methods to those defined by DatagramSocket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the related DatagramSocket instance. </para>
				/// </returns>
				/// <java-name>
				/// socket
				/// </java-name>
				[Dot42.DexImport("socket", "()Ljava/net/DatagramSocket;", AccessFlags = 1025)]
				public abstract global::Java.Net.DatagramSocket Socket() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this channel's socket is connected or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this channel's socket is connected; <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1025)]
				public abstract bool IsConnected() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Connects the socket of this channel to a remote address, which is the only communication peer for getting and sending datagrams after being connected. </para><para>This method can be called at any time without affecting the read and write operations being processed at the time the method is called. The connection status does not change until the channel is disconnected or closed. </para><para>This method executes the same security checks as the connect method of the DatagramSocket class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this channel. </para>
				/// </returns>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.DatagramChannel Connect(global::Java.Net.SocketAddress address) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Disconnects the socket of this channel, which has been connected before in order to send and receive datagrams. </para><para>This method can be called at any time without affecting the read and write operations being underway. It does not have any effect if the socket is not connected or the channel is closed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this channel. </para>
				/// </returns>
				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.DatagramChannel Disconnect() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets a datagram from this channel. </para><para>This method transfers a datagram from the channel into the target byte buffer. If this channel is in blocking mode, it waits for the datagram and returns its address when it is available. If this channel is in non-blocking mode and no datagram is available, it returns <c> null </c> immediately. The transfer starts at the current position of the buffer, and if there is not enough space remaining in the buffer to store the datagram then the part of the datagram that does not fit is discarded. </para><para>This method can be called at any time and it will block if there is another thread that has started a read operation on the channel. </para><para>This method executes the same security checks as the receive method of the DatagramSocket class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address of the datagram if the transfer is performed, or null if the channel is in non-blocking mode and no datagram is available. </para>
				/// </returns>
				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", AccessFlags = 1025)]
				public abstract global::Java.Net.SocketAddress Receive(global::Java.Nio.ByteBuffer target) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends a datagram through this channel. The datagram consists of the remaining bytes in <c> source </c> . </para><para>If this channel is in blocking mode then the datagram is sent as soon as there is enough space in the underlying output buffer. If this channel is in non-blocking mode then the datagram is only sent if there is enough space in the underlying output buffer at that moment. The transfer action is just like a regular write operation. </para><para>This method can be called at any time and it will block if another thread has started a send operation on this channel. </para><para>This method executes the same security checks as the send method of the DatagramSocket class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes sent. This is the number of bytes remaining in <c> source </c> or zero if the channel is in non-blocking mode and there is not enough space for the datagram in the underlying output buffer. </para>
				/// </returns>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", AccessFlags = 1025)]
				public abstract int Send(global::Java.Nio.ByteBuffer source, global::Java.Net.SocketAddress address) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reads a datagram from this channel into the byte buffer. </para><para>The precondition for calling this method is that the channel is connected and the incoming datagram is from the connected address. If the buffer is not big enough to store the datagram, the part of the datagram that does not fit in the buffer is discarded. Otherwise, this method has the same behavior as the <c> read </c> method in the ReadableByteChannel interface.</para><para><para>java.nio.channels.ReadableByteChannel::read(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative number as the number of bytes read, or -1 as the read operation reaches the end of stream. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Read(global::Java.Nio.ByteBuffer target) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads a datagram from this channel into an array of byte buffers. </para><para>The precondition for calling this method is that the channel is connected and the incoming datagram is from the connected address. If the buffers do not have enough remaining space to store the datagram, the part of the datagram that does not fit in the buffers is discarded. Otherwise, this method has the same behavior as the <c> read </c> method in the ScatteringByteChannel interface.</para><para><para>java.nio.channels.ScatteringByteChannel::read(java.nio.ByteBuffer[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative number as the number of bytes read, or -1 if the read operation reaches the end of stream. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Read(global::Java.Nio.ByteBuffer[] targets, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Reads a datagram from this channel into the byte buffer. </para><para>The precondition for calling this method is that the channel is connected and the incoming datagram is from the connected address. If the buffer is not big enough to store the datagram, the part of the datagram that does not fit in the buffer is discarded. Otherwise, this method has the same behavior as the <c> read </c> method in the ReadableByteChannel interface.</para><para><para>java.nio.channels.ReadableByteChannel::read(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative number as the number of bytes read, or -1 as the read operation reaches the end of stream. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Read(global::Java.Nio.ByteBuffer[] target) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Writes a datagram from the byte buffer to this channel. </para><para>The precondition of calling this method is that the channel is connected and the datagram is sent to the connected address. Otherwise, this method has the same behavior as the <c> write </c> method in the WritableByteChannel interface.</para><para><para>java.nio.channels.WritableByteChannel::write(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative number of bytes written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Write(global::Java.Nio.ByteBuffer source) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Writes a datagram from the byte buffers to this channel. </para><para>The precondition of calling this method is that the channel is connected and the datagram is sent to the connected address. Otherwise, this method has the same behavior as the <c> write </c> method in the GatheringByteChannel interface.</para><para><para>java.nio.channels.GatheringByteChannel::write(java.nio.ByteBuffer[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written. If this method is called, it returns the number of bytes that where remaining in the byte buffers. If the channel is in non-blocking mode and there was not enough space for the datagram in the buffer, it may return zero. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Write(global::Java.Nio.ByteBuffer[] sources, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Writes a datagram from the byte buffer to this channel. </para><para>The precondition of calling this method is that the channel is connected and the datagram is sent to the connected address. Otherwise, this method has the same behavior as the <c> write </c> method in the WritableByteChannel interface.</para><para><para>java.nio.channels.WritableByteChannel::write(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative number of bytes written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Write(global::Java.Nio.ByteBuffer[] source) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>A channel is a conduit to I/O services covering such items as files, sockets, hardware devices, I/O ports or some software component. </para><para>Channels are open upon creation, and can be closed explicitly. Once a channel is closed it cannot be re-opened, and any attempts to perform I/O operations on the closed channel result in a <code>ClosedChannelException</code>. </para><para>Particular implementations or sub-interfaces of <c> Channel </c> dictate whether they are thread-safe or not. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/Channel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Channel", AccessFlags = 1537)]
		public partial interface IChannel : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns true if this channel is open. </para>        
				/// </summary>
				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1025)]
				bool IsOpen() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes an open channel. If the channel is already closed then this method has no effect. If there is a problem with closing the channel then the method throws an IOException and the exception contains reasons for the failure. </para><para>If an attempt is made to perform an operation on a closed channel then a ClosedChannelException will be thrown on that attempt. </para><para>If multiple threads attempt to simultaneously close a channel, then only one thread will run the closure code, and others will be blocked until the first returns.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class provides several utilities to get I/O streams from channels. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns an input stream on the given channel. The resulting stream has the following properties: <ul><li><para>If the stream is closed, then the underlying channel is closed as well. </para></li><li><para>It is thread safe. </para></li><li><para>It throws an IllegalBlockingModeException if the channel is in non-blocking mode and <c> read </c> is called. </para></li><li><para>Neither <c> mark </c> nor <c> reset </c> is supported. </para></li><li><para>It is not buffered. </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an InputStream that takes bytes from the given byte channel. </para>
				/// </returns>
				/// <java-name>
				/// newInputStream
				/// </java-name>
				[Dot42.DexImport("newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;", AccessFlags = 9)]
				public static global::Java.Io.InputStream NewInputStream(global::Java.Nio.Channels.IReadableByteChannel channel) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Returns an output stream on the given channel. The resulting stream has the following properties: <ul><li><para>If the stream is closed, then the underlying channel is closed as well. </para></li><li><para>It is thread safe. </para></li><li><para>It throws an IllegalBlockingModeException if the channel is in non-blocking mode and <c> write </c> is called. </para></li><li><para>It is not buffered. </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an OutputStream that puts bytes onto the given byte channel. </para>
				/// </returns>
				/// <java-name>
				/// newOutputStream
				/// </java-name>
				[Dot42.DexImport("newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;", AccessFlags = 9)]
				public static global::Java.Io.OutputStream NewOutputStream(global::Java.Nio.Channels.IWritableByteChannel channel) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <summary>
				/// <para>Returns a readable channel on the given input stream. The resulting channel has the following properties: <ul><li><para>If the channel is closed, then the underlying stream is closed as well. </para></li><li><para>It is not buffered. </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a byte channel that reads bytes from the input stream. </para>
				/// </returns>
				/// <java-name>
				/// newChannel
				/// </java-name>
				[Dot42.DexImport("newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.IReadableByteChannel NewChannel(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IReadableByteChannel);
				}

				/// <summary>
				/// <para>Returns a readable channel on the given input stream. The resulting channel has the following properties: <ul><li><para>If the channel is closed, then the underlying stream is closed as well. </para></li><li><para>It is not buffered. </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a byte channel that reads bytes from the input stream. </para>
				/// </returns>
				/// <java-name>
				/// newChannel
				/// </java-name>
				[Dot42.DexImport("newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.IWritableByteChannel NewChannel(global::Java.Io.OutputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IWritableByteChannel);
				}

				/// <summary>
				/// <para>Returns a reader that decodes bytes from a channel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reader. </para>
				/// </returns>
				/// <java-name>
				/// newReader
				/// </java-name>
				[Dot42.DexImport("newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/" +
    "io/Reader;", AccessFlags = 9)]
				public static global::Java.Io.Reader NewReader(global::Java.Nio.Channels.IReadableByteChannel channel, global::Java.Nio.Charset.CharsetDecoder decoder, int minBufferCapacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <summary>
				/// <para>Returns a reader that decodes bytes from a channel. This method creates a reader with a buffer of default size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reader. </para>
				/// </returns>
				/// <java-name>
				/// newReader
				/// </java-name>
				[Dot42.DexImport("newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 9)]
				public static global::Java.Io.Reader NewReader(global::Java.Nio.Channels.IReadableByteChannel channel, string charsetName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <summary>
				/// <para>Returns a writer that encodes characters with the specified <c> encoder </c> and sends the bytes to the specified channel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the writer. </para>
				/// </returns>
				/// <java-name>
				/// newWriter
				/// </java-name>
				[Dot42.DexImport("newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/" +
    "io/Writer;", AccessFlags = 9)]
				public static global::Java.Io.Writer NewWriter(global::Java.Nio.Channels.IWritableByteChannel channel, global::Java.Nio.Charset.CharsetEncoder encoder, int minBufferCapacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				/// <summary>
				/// <para>Returns a writer that encodes characters with the specified <c> encoder </c> and sends the bytes to the specified channel. This method creates a writer with a buffer of default size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the writer. </para>
				/// </returns>
				/// <java-name>
				/// newWriter
				/// </java-name>
				[Dot42.DexImport("newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;", AccessFlags = 9)]
				public static global::Java.Io.Writer NewWriter(global::Java.Nio.Channels.IWritableByteChannel channel, string charsetName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

		}

		/// <summary>
		/// <para>An <c> AlreadyConnectedException </c> is thrown when an attempt is made to connect a SocketChannel that is already connected. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/AlreadyConnectedException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/AlreadyConnectedException", AccessFlags = 33)]
		public partial class AlreadyConnectedException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> AlreadyConnectedException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AlreadyConnectedException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> NoConnectionPendingException </c> is thrown if <c> SocketChannel </c> 's finishConnect method is called before the <c> SocketChannel </c> 's SocketChannel#connect(java.net.SocketAddress) connect} method completed without error. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/NoConnectionPendingException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/NoConnectionPendingException", AccessFlags = 33)]
		public partial class NoConnectionPendingException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> NoConnectionPendingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoConnectionPendingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> SelectionKey </c> represents the relationship between a channel and a selector for which the channel is registered. <h3>Operation set</h3></para><para>An operation set is represented by an integer value. The bits of an operation set represent categories of operations for a key's channel: Accepting socket connections (<c> OP_ACCEPT </c> ), connecting with a socket (<c> OP_CONNECT </c> ), reading (<c> OP_READ </c> ) and writing (<c> OP_WRITE </c> ). <h4>Interest set</h4></para><para>The interest set is an operation set that defines the operations that a channel is interested in performing. <h4>Ready set</h4></para><para>The ready set is an operation set that shows the operations that a <c> channel </c> is ready to execute. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/SelectionKey
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/SelectionKey", AccessFlags = 1057)]
		public abstract partial class SelectionKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Interest set mask bit for socket-accept operations. </para>        
				/// </summary>
				/// <java-name>
				/// OP_ACCEPT
				/// </java-name>
				[Dot42.DexImport("OP_ACCEPT", "I", AccessFlags = 25)]
				public const int OP_ACCEPT = 16;
				/// <summary>
				/// <para>Interest set mask bit for socket-connect operations. </para>        
				/// </summary>
				/// <java-name>
				/// OP_CONNECT
				/// </java-name>
				[Dot42.DexImport("OP_CONNECT", "I", AccessFlags = 25)]
				public const int OP_CONNECT = 8;
				/// <summary>
				/// <para>Interesting operation mask bit for read operations. </para>        
				/// </summary>
				/// <java-name>
				/// OP_READ
				/// </java-name>
				[Dot42.DexImport("OP_READ", "I", AccessFlags = 25)]
				public const int OP_READ = 1;
				/// <summary>
				/// <para>Interest set mask bit for write operations. </para>        
				/// </summary>
				/// <java-name>
				/// OP_WRITE
				/// </java-name>
				[Dot42.DexImport("OP_WRITE", "I", AccessFlags = 25)]
				public const int OP_WRITE = 4;
				/// <summary>
				/// <para>Constructs a new <c> SelectionKey </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SelectionKey() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attaches an object to this key. It is acceptable to attach <c> null </c> , this discards the old attachment.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last attached object or <c> null </c> if no object has been attached. </para>
				/// </returns>
				/// <java-name>
				/// attach
				/// </java-name>
				[Dot42.DexImport("attach", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17)]
				public object Attach(object anObject) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Gets the attached object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attached object or <c> null </c> if no object has been attached. </para>
				/// </returns>
				/// <java-name>
				/// attachment
				/// </java-name>
				[Dot42.DexImport("attachment", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Attachment() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Cancels this key. </para><para>A key that has been canceled is no longer valid. Calling this method on an already canceled key does nothing. </para><para>Calling this method is safe at any time. The call might block until another ongoing call to a method of this selector has finished. The reason is that it is synchronizing on the key set of the selector. After this call finishes, the key will have been added to the selectors canceled-keys set and will not be included in any future selects of this selector. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1025)]
				public abstract void Cancel() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the channel of this key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the channel of this key. </para>
				/// </returns>
				/// <java-name>
				/// channel
				/// </java-name>
				[Dot42.DexImport("channel", "()Ljava/nio/channels/SelectableChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectableChannel Channel() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets this key's interest set. The returned set has only those bits set that are valid for this key's channel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interest set of this key. </para>
				/// </returns>
				/// <java-name>
				/// interestOps
				/// </java-name>
				[Dot42.DexImport("interestOps", "()I", AccessFlags = 1025)]
				public abstract int InterestOps() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the interest set for this key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this key. </para>
				/// </returns>
				/// <java-name>
				/// interestOps
				/// </java-name>
				[Dot42.DexImport("interestOps", "(I)Ljava/nio/channels/SelectionKey;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectionKey InterestOps(int operations) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this key's channel is interested in the accept operation and is ready to accept new connections. A call to this method is equal to executing <c> (readyOps() &amp; OP_ACCEPT) == OP_ACCEPT </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the channel is interested in the accept operation and is ready to accept new connections, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAcceptable
				/// </java-name>
				[Dot42.DexImport("isAcceptable", "()Z", AccessFlags = 17)]
				public bool IsAcceptable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this key's channel is interested in the connect operation and is ready to connect. A call to this method is equal to executing <c> (readyOps() &amp; OP_CONNECT) == OP_CONNECT </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the channel is interested in the connect operation and is ready to connect, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnectable
				/// </java-name>
				[Dot42.DexImport("isConnectable", "()Z", AccessFlags = 17)]
				public bool IsConnectable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this key's channel is interested in the read operation and is ready to read. A call to this method is equal to executing <c> (readyOps() &amp; OP_READ) == OP_READ </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the channel is interested in the read operation and is ready to read, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isReadable
				/// </java-name>
				[Dot42.DexImport("isReadable", "()Z", AccessFlags = 17)]
				public bool IsReadable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this key is valid. A key is valid as long as it has not been canceled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this key has not been canceled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				public abstract bool IsValid() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this key's channel is interested in the write operation and is ready to write. A call to this method is equal to executing <c> (readyOps() &amp; OP_WRITE) == OP_WRITE </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the channel is interested in the write operation and is ready to write, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isWritable
				/// </java-name>
				[Dot42.DexImport("isWritable", "()Z", AccessFlags = 17)]
				public bool IsWritable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the set of operations that are ready. The returned set has only those bits set that are valid for this key's channel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the operations for which this key's channel is ready. </para>
				/// </returns>
				/// <java-name>
				/// readyOps
				/// </java-name>
				[Dot42.DexImport("readyOps", "()I", AccessFlags = 1025)]
				public abstract int ReadyOps() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the selector for which this key's channel is registered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the related selector. </para>
				/// </returns>
				/// <java-name>
				/// selector
				/// </java-name>
				[Dot42.DexImport("selector", "()Ljava/nio/channels/Selector;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Selector Selector() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A pipe contains two channels, forming a unidirectional pipe. One is the writable sink channel, and the other is the readable source channel. When bytes are written into the writable channel they can be read from the readable channel. Bytes are read in the order in which they were written. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/Pipe
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/Pipe", AccessFlags = 1057)]
		public abstract partial class Pipe
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The protected default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Pipe() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new pipe from the default {<para>java.nio.channels.spi.SelectorProvider}.</para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/Pipe;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.Pipe Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.Pipe);
				}

				/// <summary>
				/// <para>Returns the sink channel of the pipe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a writable sink channel of the pipe. </para>
				/// </returns>
				/// <java-name>
				/// sink
				/// </java-name>
				[Dot42.DexImport("sink", "()Ljava/nio/channels/Pipe$SinkChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Pipe.SinkChannel Sink() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the source channel of the pipe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a readable source channel of the pipe. </para>
				/// </returns>
				/// <java-name>
				/// source
				/// </java-name>
				[Dot42.DexImport("source", "()Ljava/nio/channels/Pipe$SourceChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Pipe.SourceChannel Source() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Readable source channel used to read from a pipe. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Indicates that this channel only supports reading.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a static value of OP_READ. </para>
						/// </returns>
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
						public virtual int Read(global::Java.Nio.ByteBuffer buffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
						public virtual long Read(global::Java.Nio.ByteBuffer[] buffers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

						[Dot42.DexImport("java/nio/channels/ScatteringByteChannel", "read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
						public virtual long Read(global::Java.Nio.ByteBuffer[] buffers, int offset, int length) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

				}

				/// <summary>
				/// <para>Writable sink channel used to write to a pipe. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Indicates that this channel only supports writing.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a static value of OP_WRITE. </para>
						/// </returns>
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
						public virtual int Write(global::Java.Nio.ByteBuffer buffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
						public virtual long Write(global::Java.Nio.ByteBuffer[] buffers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

						[Dot42.DexImport("java/nio/channels/GatheringByteChannel", "write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
						public virtual long Write(global::Java.Nio.ByteBuffer[] buffers, int offset, int length) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(long);
						}

				}

		}

		/// <summary>
		/// <para>A <c> ConnectionPendingException </c> is thrown when an attempt is made to connect a SocketChannel that has a non-blocking connection already underway. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ConnectionPendingException
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ConnectionPendingException", AccessFlags = 33)]
		public partial class ConnectionPendingException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> ConnectionPendingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectionPendingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A channel that can be used with a Selector. The channel must be registered with a selector by calling one of the <c> register </c> methods, which return a SelectionKey object. In order to deregister a channel from a selector, its selection key must be canceled. This can be done explicitly by calling the SelectionKey#cancel() method but it is also done implicitly when the channel or the selector is closed. </para><para>A channel may be registered with several selectors at the same time but only once for any given selector. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/SelectableChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/SelectableChannel", AccessFlags = 1057)]
		public abstract partial class SelectableChannel : global::Java.Nio.Channels.Spi.AbstractInterruptibleChannel, global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> SelectableChannel </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SelectableChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the blocking lock which synchronizes the <c> configureBlocking </c> and <c> register </c> methods.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the blocking object as lock. </para>
				/// </returns>
				/// <java-name>
				/// blockingLock
				/// </java-name>
				[Dot42.DexImport("blockingLock", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object BlockingLock() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the blocking mode of this channel. A call to this method blocks if other calls to this method or to a <c> register </c> method are executing. The new blocking mode is valid for calls to other methods that are invoked after the call to this method. If other methods are already executing when this method is called, they still have the old mode and the call to this method might block depending on the implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this channel. </para>
				/// </returns>
				/// <java-name>
				/// configureBlocking
				/// </java-name>
				[Dot42.DexImport("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectableChannel ConfigureBlocking(bool block) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this channel is in blocking mode.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this channel is blocking, undefined if this channel is closed. </para>
				/// </returns>
				/// <java-name>
				/// isBlocking
				/// </java-name>
				[Dot42.DexImport("isBlocking", "()Z", AccessFlags = 1025)]
				public abstract bool IsBlocking() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this channel is registered with at least one selector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this channel is registered, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRegistered
				/// </java-name>
				[Dot42.DexImport("isRegistered", "()Z", AccessFlags = 1025)]
				public abstract bool IsRegistered() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets this channel's selection key for the specified selector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the selection key for the channel or <c> null </c> if this channel has not been registered with <c> sel </c> . </para>
				/// </returns>
				/// <java-name>
				/// keyFor
				/// </java-name>
				[Dot42.DexImport("keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectionKey KeyFor(global::Java.Nio.Channels.Selector sel) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the provider of this channel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this channel. </para>
				/// </returns>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "()Ljava/nio/channels/spi/SelectorProvider;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.Spi.SelectorProvider Provider() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Registers this channel with the specified selector for the specified interest set. If the channel is already registered with the selector, the corresponding selection key is returned but the interest set is updated to <c> operations </c> . The returned key is canceled if the channel is closed while registering is in progress. </para><para>Calling this method is valid at any time. If another thread executes this method or the <c> configureBlocking(boolean </c> method then this call is blocked until the other call finishes. After that, it will synchronize on the key set of the selector and thus may again block if other threads also hold locks on the key set of the same selector. </para><para>Calling this method is equivalent to calling <c> register(selector, operations, null) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the selection key for this registration. </para>
				/// </returns>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;", AccessFlags = 17)]
				public global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Selector selector, int operations) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SelectionKey);
				}

				/// <summary>
				/// <para>Registers this channel with the specified selector for the specified interest set and an object to attach. If the channel is already registered with the selector, the corresponding selection key is returned but its interest set is updated to <c> ops </c> and the attached object is updated to <c> att </c> . The returned key is canceled if the channel is closed while registering is in progress. </para><para>Calling this method is valid at any time. If another thread executes this method or the <c> configureBlocking(boolean) </c> method then this call is blocked until the other call finishes. After that, it will synchronize on the key set of the selector and thus may again block if other threads also hold locks on the key set of the same selector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the selection key for this registration. </para>
				/// </returns>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;" +
    "", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.SelectionKey Register(global::Java.Nio.Channels.Selector sel, int ops, object att) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the set of valid operations of this channel. Instances of a concrete channel class always return the same value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the set of operations that this channel supports. </para>
				/// </returns>
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

		/// <summary>
		/// <para>A <c> ReadableByteChannel </c> is a type of Channel that can read bytes. </para><para>Read operations are synchronous on a <c> ReadableByteChannel </c> , that is, if a read is already in progress on the channel then subsequent reads will block until the first read completes. It is undefined whether non-read operations will block. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/ReadableByteChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/ReadableByteChannel", AccessFlags = 1537)]
		public partial interface IReadableByteChannel : global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Reads bytes from the channel into the given buffer. </para><para>The maximum number of bytes that will be read is the remaining number of bytes in the buffer when the method is invoked. The bytes will be read into the buffer starting at the buffer's current position. </para><para>The call may block if other threads are also attempting to read from the same channel. </para><para>Upon completion, the buffer's <c> position </c> is updated to the end of the bytes that were read. The buffer's limit is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				int Read(global::Java.Nio.ByteBuffer buffer) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An abstract channel type for interaction with a platform file. </para><para>A <c> FileChannel </c> defines the methods for reading, writing, memory mapping, and manipulating the logical state of a platform file. This type does not have a method for opening files, since this behavior has been delegated to the java.io.FileInputStream, java.io.FileOutputStream and java.io.RandomAccessFile types. </para><para>FileChannels created from a <c> FileInputStream </c> or a <c> RandomAccessFile </c> created in mode "r", are read-only. FileChannels created from a <c> FileOutputStream </c> are write-only. FileChannels created from a <c> RandomAccessFile </c> created in mode "rw" are read/write. FileChannels created from a <c> RandomAccessFile </c> that was opened in append-mode will also be in append-mode  meaning that each write will be proceeded by a seek to the end of file. </para><para>FileChannels have a virtual pointer into the file which is referred to as a file <b>position</b>. The position can be manipulated by moving it within the file, and the current position can be queried. </para><para>FileChannels also have an associated <b>size</b>. The size of the file is the number of bytes that it currently contains. The size can be manipulated by adding more bytes to the end of the file (which increases the size) or truncating the file (which decreases the size). The current size can also be queried. </para><para>FileChannels have operations beyond the simple read, write, and close. They can also: <ul><li><para>request that cached data be forced onto the disk, </para></li><li><para>lock ranges of bytes associated with the file, </para></li><li><para>transfer data directly to another channel in a manner that has the potential to be optimized by the platform, </para></li><li><para>memory-mapping files into NIO buffers to provide efficient manipulation of file data, </para></li><li><para>read and write to the file at absolute byte offsets in a fashion that does not modify the current position. </para></li></ul></para><para>FileChannels are thread-safe. Only one operation involving manipulation of the file position may be executed at the same time. Subsequent calls to such operations will block, and one of those blocked will be freed to continue when the first operation has completed. There is no ordered queue or fairness applied to the blocked threads. </para><para>It is undefined whether operations that do not manipulate the file position will also block when there are any other operations in-flight. </para><para>The logical view of the underlying file is consistent across all FileChannels and I/O streams opened on the same file by the same VM. Therefore, modifications performed via a channel will be visible to the stream and vice versa; this includes modifications to the file position, content, size, etc. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/FileChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/FileChannel", AccessFlags = 1057)]
		public abstract partial class FileChannel : global::Java.Nio.Channels.Spi.AbstractInterruptibleChannel, global::Java.Nio.Channels.IGatheringByteChannel, global::Java.Nio.Channels.IScatteringByteChannel, global::Java.Nio.Channels.IByteChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal FileChannel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Requests that all updates to this channel are committed to the storage device. </para><para>When this method returns, all modifications made to the platform file underlying this channel have been committed if the file resides on a local storage device. If the file is not hosted locally, for example on a networked file system, then applications cannot be certain that the modifications have been committed. </para><para>There are no assurances given that changes made to the file using methods defined elsewhere will be committed. For example, changes made via a mapped byte buffer may not be committed. </para><para>The <code>metadata</code> parameter indicates whether the update should include the file's metadata such as last modification time, last access time, etc. Note that passing <code>true</code> may invoke an underlying write to the operating system (if the platform is maintaining metadata such as last access time), even if the channel is opened read-only.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// force
				/// </java-name>
				[Dot42.DexImport("force", "(Z)V", AccessFlags = 1025)]
				public abstract void Force(bool metadata) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains an exclusive lock on this file. </para><para>This is a convenience method for acquiring a maximum length lock on a file. It is equivalent to: <c> fileChannel.lock(0L, Long.MAX_VALUE, false); </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the lock object representing the locked file area. </para>
				/// </returns>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()Ljava/nio/channels/FileLock;", AccessFlags = 17)]
				public global::Java.Nio.Channels.FileLock Lock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileLock);
				}

				/// <summary>
				/// <para>Obtains a lock on a specified region of the file. </para><para>This is the blocking version of lock acquisition, see also the <code>tryLock()</code> methods. </para><para>Attempts to acquire an overlapping lock region will fail. The attempt will fail if the overlapping lock has already been obtained, or if another thread is currently waiting to acquire the overlapping lock. </para><para>If the request is not for an overlapping lock, the thread calling this method will block until the lock is obtained (likely by no contention or another process releasing a lock), or until this thread is interrupted or the channel is closed. </para><para>If the lock is obtained successfully then the FileLock object returned represents the lock for subsequent operations on the locked region. </para><para>If the thread is interrupted while waiting for the lock, the thread is set to the interrupted state and throws a FileLockInterruptionException. If this channel is closed while the thread is waiting to obtain the lock then the thread throws a AsynchronousCloseException. </para><para>There is no requirement for the position and size to be within the current start and length of the file. </para><para>Some platforms do not support shared locks, and if a request is made for a shared lock on such a platform, this method will attempt to acquire an exclusive lock instead. It is undefined whether the lock obtained is advisory or mandatory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file lock object. </para>
				/// </returns>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "(JJZ)Ljava/nio/channels/FileLock;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileLock Lock(long position, long size, bool shared) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Maps the file into memory. There can be three modes: read-only, read/write and private. After mapping, changes made to memory or the file channel do not affect the other storage place. </para><para>Note: mapping a file into memory is usually expensive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the mapped byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// map
				/// </java-name>
				[Dot42.DexImport("map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.MappedByteBuffer Map(global::Java.Nio.Channels.FileChannel.MapMode mode, long position, long size) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current value of the file position pointer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current position as a positive integer number of bytes from the start of the file. </para>
				/// </returns>
				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "()J", AccessFlags = 1025)]
				public abstract long Position() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the file position pointer to a new value. </para><para>The argument is the number of bytes counted from the start of the file. The position cannot be set to a value that is negative. The new position can be set beyond the current file size. If set beyond the current file size, attempts to read will return end of file. Write operations will succeed but they will fill the bytes between the current end of file and the new position with the required number of (unspecified) byte values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver. </para>
				/// </returns>
				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(J)Ljava/nio/channels/FileChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileChannel Position(long offset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reads bytes from this file channel into the given buffer. </para><para>The maximum number of bytes that will be read is the remaining number of bytes in the buffer when the method is invoked. The bytes will be copied into the buffer starting at the buffer's current position. </para><para>The call may block if other threads are also attempting to read from this channel. </para><para>Upon completion, the buffer's position is set to the end of the bytes that have been read. The buffer's limit is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Read(global::Java.Nio.ByteBuffer buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads bytes from this file channel into the given buffer starting from the specified file position. </para><para>The bytes are read starting at the given file position (up to the remaining number of bytes in the buffer). The number of bytes actually read is returned. </para><para>If <c> position </c> is beyond the current end of file, then no bytes are read. </para><para>Note that the file position is unmodified by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;J)I", AccessFlags = 1025)]
				public abstract int Read(global::Java.Nio.ByteBuffer buffer, long position) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reads bytes from this file channel into the given buffer. </para><para>The maximum number of bytes that will be read is the remaining number of bytes in the buffer when the method is invoked. The bytes will be copied into the buffer starting at the buffer's current position. </para><para>The call may block if other threads are also attempting to read from this channel. </para><para>Upon completion, the buffer's position is set to the end of the bytes that have been read. The buffer's limit is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 17)]
				public long Read(global::Java.Nio.ByteBuffer[] buffer) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Reads bytes from this file channel into a subset of the given buffers. This method attempts to read all <c> remaining() </c> bytes from <c>       length </c> byte buffers, in order, starting at <c> targets[offset] </c> . It increases the file position by the number of bytes actually read. The number of bytes actually read is returned. </para><para>If a read operation is in progress, subsequent threads will block until the read is completed and will then contend for the ability to read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Read(global::Java.Nio.ByteBuffer[] buffers, int start, int number) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the size of the file underlying this channel in bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the file in bytes. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()J", AccessFlags = 1025)]
				public abstract long Size() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reads up to <c> count </c> bytes from <c> src </c> and stores them in this channel's file starting at <c> position </c> . No bytes are transferred if <c> position </c> is larger than the size of this channel's file. Less than <c> count </c> bytes are transferred if there are less bytes remaining in the source channel or if the source channel is non-blocking and has less than <c> count </c> bytes immediately available in its output buffer. </para><para>Note that this channel's position is not modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes that are transferred. </para>
				/// </returns>
				/// <java-name>
				/// transferFrom
				/// </java-name>
				[Dot42.DexImport("transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J", AccessFlags = 1025)]
				public abstract long TransferFrom(global::Java.Nio.Channels.IReadableByteChannel src, long position, long count) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reads up to <c> count </c> bytes from this channel's file starting at <c> position </c> and writes them to <c> target </c> . No bytes are transferred if <c> position </c> is larger than the size of this channel's file. Less than <c> count </c> bytes are transferred if there less bytes available from this channel's file or if the target channel is non-blocking and has less than <c> count </c> bytes free in its input buffer. </para><para>Note that this channel's position is not modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes that were transferred. </para>
				/// </returns>
				/// <java-name>
				/// transferTo
				/// </java-name>
				[Dot42.DexImport("transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J", AccessFlags = 1025)]
				public abstract long TransferTo(long position, long count, global::Java.Nio.Channels.IWritableByteChannel target) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Truncates the file underlying this channel to a given size. Any bytes beyond the given size are removed from the file. If there are no bytes beyond the given size then the file contents are unmodified. </para><para>If the file position is currently greater than the given size, then it is set to the new size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this channel. </para>
				/// </returns>
				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(J)Ljava/nio/channels/FileChannel;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileChannel Truncate(long size) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Attempts to acquire an exclusive lock on this file without blocking. </para><para>This is a convenience method for attempting to acquire a maximum length lock on the file. It is equivalent to: <c> fileChannel.tryLock(0L, Long.MAX_VALUE, false); </c> </para><para>The method returns <c> null </c> if the acquisition would result in an overlapped lock with another OS process.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file lock object, or <c> null </c> if the lock would overlap with an existing exclusive lock in another OS process. </para>
				/// </returns>
				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "()Ljava/nio/channels/FileLock;", AccessFlags = 17)]
				public global::Java.Nio.Channels.FileLock TryLock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileLock);
				}

				/// <summary>
				/// <para>Attempts to acquire an exclusive lock on this file without blocking. The method returns <c> null </c> if the acquisition would result in an overlapped lock with another OS process. </para><para>It is possible to acquire a lock for any region even if it's completely outside of the file's size. The size of the lock is fixed. If the file grows outside of the lock that region of the file won't be locked by this lock.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file lock object, or <c> null </c> if the lock would overlap with an existing exclusive lock in another OS process. </para>
				/// </returns>
				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "(JJZ)Ljava/nio/channels/FileLock;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Channels.FileLock TryLock(long position, long size, bool shared) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes bytes from the given byte buffer to this file channel. </para><para>The bytes are written starting at the current file position, and after some number of bytes are written (up to the remaining number of bytes in the buffer) the file position is increased by the number of bytes actually written.</para><para><para>java.nio.channels.WritableByteChannel::write(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Write(global::Java.Nio.ByteBuffer src) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Writes bytes from the given buffer to this file channel starting at the given file position. </para><para>The bytes are written starting at the given file position (up to the remaining number of bytes in the buffer). The number of bytes actually written is returned. </para><para>If the position is beyond the current end of file, then the file is first extended up to the given position by the required number of unspecified byte values. </para><para>Note that the file position is not modified by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;J)I", AccessFlags = 1025)]
				public abstract int Write(global::Java.Nio.ByteBuffer buffer, long position) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes bytes from the given byte buffer to this file channel. </para><para>The bytes are written starting at the current file position, and after some number of bytes are written (up to the remaining number of bytes in the buffer) the file position is increased by the number of bytes actually written.</para><para><para>java.nio.channels.WritableByteChannel::write(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 17)]
				public long Write(global::Java.Nio.ByteBuffer[] src) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Attempts to write a subset of the given bytes from the buffers to this file channel. This method attempts to write all <c> remaining() </c> bytes from <c> length </c> byte buffers, in order, starting at <c>       sources[offset] </c> . The number of bytes actually written is returned. </para><para>If a write operation is in progress, subsequent threads will block until the write is completed and then contend for the ability to write.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written to this channel. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Write(global::Java.Nio.ByteBuffer[] buffers, int offset, int length) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para><c> MapMode </c> defines file mapping mode constants. </para>    
				/// </summary>
				/// <java-name>
				/// java/nio/channels/FileChannel$MapMode
				/// </java-name>
				[Dot42.DexImport("java/nio/channels/FileChannel$MapMode", AccessFlags = 9)]
				public partial class MapMode
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Private mapping mode (equivalent to copy on write). </para>        
						/// </summary>
						/// <java-name>
						/// PRIVATE
						/// </java-name>
						[Dot42.DexImport("PRIVATE", "Ljava/nio/channels/FileChannel$MapMode;", AccessFlags = 25)]
						public static readonly MapMode PRIVATE;
						/// <summary>
						/// <para>Read-only mapping mode. </para>        
						/// </summary>
						/// <java-name>
						/// READ_ONLY
						/// </java-name>
						[Dot42.DexImport("READ_ONLY", "Ljava/nio/channels/FileChannel$MapMode;", AccessFlags = 25)]
						public static readonly MapMode READ_ONLY;
						/// <summary>
						/// <para>Read-write mapping mode. </para>        
						/// </summary>
						/// <java-name>
						/// READ_WRITE
						/// </java-name>
						[Dot42.DexImport("READ_WRITE", "Ljava/nio/channels/FileChannel$MapMode;", AccessFlags = 25)]
						public static readonly MapMode READ_WRITE;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal MapMode() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns a string version of the mapping mode.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>this map mode as string. </para>
						/// </returns>
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

		/// <summary>
		/// <para>A <c> SocketChannel </c> is a selectable channel that provides a partial abstraction of stream connecting socket. <c> socket() </c> returns the related Socket instance which can handle the socket. </para><para>A socket channel is open but not connected when created by <c> open() </c> . After connecting it by calling <c> connect(SocketAddress) </c> , it will remain connected until it gets closed. If the connection is non-blocking then <c> connect(SocketAddress) </c> is used to initiate the connection, followed by a call of <c> finishConnect() </c> to perform the final steps of connecting. <c> isConnectionPending() </c> indicates if the connection is blocked or not; <c> isConnected() </c> indicates if the socket is finally connected or not. </para><para>The input and output sides of a channel can be shut down independently and asynchronously without closing the channel. The <c> shutdownInput </c> method is used for the input side of a channel and subsequent read operations return -1, which means end of stream. If another thread is blocked in a read operation when the shutdown occurs, the read will end without effect and return end of stream. The <c> shutdownOutput </c> method is used for the output side of the channel; subsequent write operations throw a ClosedChannelException. If the output is shut down and another thread is blocked in a write operation, an AsynchronousCloseException will be thrown to the pending thread. </para><para>Socket channels are thread-safe, no more than one thread can read or write at any given time. The <c> connect(SocketAddress) </c> and <c>   finishConnect() </c> methods are synchronized against each other; when they are processing, calls to <c> read </c> and <c> write </c> will block. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/SocketChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/SocketChannel", AccessFlags = 1057)]
		public abstract partial class SocketChannel : global::Java.Nio.Channels.Spi.AbstractSelectableChannel, global::Java.Nio.Channels.IByteChannel, global::Java.Nio.Channels.IScatteringByteChannel, global::Java.Nio.Channels.IGatheringByteChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> SocketChannel </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V", AccessFlags = 4)]
				protected internal SocketChannel(global::Java.Nio.Channels.Spi.SelectorProvider selectorProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an open and unconnected socket channel. </para><para>This channel is created by calling <c> openSocketChannel() </c> of the default SelectorProvider instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new channel which is open but unconnected. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.SocketChannel Open() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SocketChannel);
				}

				/// <summary>
				/// <para>Creates a socket channel and connects it to a socket address. </para><para>This method performs a call to <c> open() </c> followed by a call to <c> connect(SocketAddress) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new connected channel. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.SocketChannel Open(global::Java.Net.SocketAddress address) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SocketChannel);
				}

				/// <summary>
				/// <para>Gets the valid operations of this channel. Socket channels support connect, read and write operation, so this method returns <c> SelectionKey.OP_CONNECT | SelectionKey.OP_READ | SelectionKey.OP_WRITE </c> .</para><para><para>java.nio.channels.SelectableChannel::validOps() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the operations supported by this channel. </para>
				/// </returns>
				/// <java-name>
				/// validOps
				/// </java-name>
				[Dot42.DexImport("validOps", "()I", AccessFlags = 17)]
				public override int ValidOps() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the socket assigned to this channel, which does not declare any public methods that are not declared in <c> Socket </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket assigned to this channel. </para>
				/// </returns>
				/// <java-name>
				/// socket
				/// </java-name>
				[Dot42.DexImport("socket", "()Ljava/net/Socket;", AccessFlags = 1025)]
				public abstract global::Java.Net.Socket Socket() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this channel's socket is connected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this channel's socket is connected, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1025)]
				public abstract bool IsConnected() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this channel's socket is still trying to connect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the connection is initiated but not finished; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnectionPending
				/// </java-name>
				[Dot42.DexImport("isConnectionPending", "()Z", AccessFlags = 1025)]
				public abstract bool IsConnectionPending() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Connects this channel's socket with a remote address. </para><para>If this channel is blocking, this method will suspend until connecting is finished or an I/O exception occurs. If the channel is non-blocking, this method will return <c> true </c> if the connection is finished at once or return <c> false </c> when the connection must be finished later by calling <c> finishConnect() </c> . </para><para>This method can be called at any moment and can block other read and write operations while connecting. It executes the same security checks as the connect method of the <c> Socket </c> class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the connection is finished, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)Z", AccessFlags = 1025)]
				public abstract bool Connect(global::Java.Net.SocketAddress address) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Completes the connection process initiated by a call of <c>       connect(SocketAddress) </c> . </para><para>This method returns <c> true </c> if the connection is finished already and returns <c> false </c> if the channel is non-blocking and the connection is not finished yet. </para><para>If this channel is in blocking mode, this method will suspend and return <c> true </c> when the connection is finished. It closes this channel and throws an exception if the connection fails. </para><para>This method can be called at any moment and it can block other <c>       read </c> and <c> write </c> operations while connecting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the connection is successfully finished, <c>               false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// finishConnect
				/// </java-name>
				[Dot42.DexImport("finishConnect", "()Z", AccessFlags = 1025)]
				public abstract bool FinishConnect() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reads bytes from this socket channel into the given buffer. </para><para>The maximum number of bytes that will be read is the remaining number of bytes in the buffer when the method is invoked. The bytes will be copied into the buffer starting at the buffer's current position. </para><para>The call may block if other threads are also attempting to read from this channel. </para><para>Upon completion, the buffer's position is set to the end of the bytes that have been read. The buffer's limit is not changed.</para><para><para>java.nio.channels.ReadableByteChannel::read(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Read(global::Java.Nio.ByteBuffer target) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads bytes from this socket channel into a subset of the given buffers. This method attempts to read all <c> remaining() </c> bytes from <c>       length </c> byte buffers, in order, starting at <c> targets[offset] </c> . The number of bytes actually read is returned. </para><para>If a read operation is in progress, subsequent threads will block until the read is completed and will then contend for the ability to read.</para><para><para>java.nio.channels.ScatteringByteChannel::read(java.nio.ByteBuffer[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Read(global::Java.Nio.ByteBuffer[] targets, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Reads bytes from this socket channel into the given buffer. </para><para>The maximum number of bytes that will be read is the remaining number of bytes in the buffer when the method is invoked. The bytes will be copied into the buffer starting at the buffer's current position. </para><para>The call may block if other threads are also attempting to read from this channel. </para><para>Upon completion, the buffer's position is set to the end of the bytes that have been read. The buffer's limit is not changed.</para><para><para>java.nio.channels.ReadableByteChannel::read(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Read(global::Java.Nio.ByteBuffer[] target) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Writes bytes from the given byte buffer to this socket channel. The maximum number of bytes that are written is the remaining number of bytes in the buffer when this method is invoked. The bytes are taken from the buffer starting at the buffer's position. </para><para>The call may block if other threads are also attempting to write to the same channel. </para><para>Upon completion, the buffer's position is updated to the end of the bytes that have been written. The buffer's limit is not changed.</para><para><para>java.nio.channels.WritableByteChannel::write(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1025)]
				public virtual int Write(global::Java.Nio.ByteBuffer source) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Attempts to write a subset of the given bytes from the buffers to this socket channel. This method attempts to write all <c> remaining() </c> bytes from <c> length </c> byte buffers, in order, starting at <c>       sources[offset] </c> . The number of bytes actually written is returned. </para><para>If a write operation is in progress, subsequent threads will block until the write is completed and then contend for the ability to write.</para><para><para>java.nio.channels.GatheringByteChannel::write(java.nio.ByteBuffer[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written to this channel. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;II)J", AccessFlags = 1025)]
				public virtual long Write(global::Java.Nio.ByteBuffer[] sources, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Writes bytes from the given byte buffer to this socket channel. The maximum number of bytes that are written is the remaining number of bytes in the buffer when this method is invoked. The bytes are taken from the buffer starting at the buffer's position. </para><para>The call may block if other threads are also attempting to write to the same channel. </para><para>Upon completion, the buffer's position is updated to the end of the bytes that have been written. The buffer's limit is not changed.</para><para><para>java.nio.channels.WritableByteChannel::write(java.nio.ByteBuffer) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually written. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([Ljava/nio/ByteBuffer;)J", AccessFlags = 49)]
				public long Write(global::Java.Nio.ByteBuffer[] source) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>Channels that implement this interface can be asynchronously closed and interrupted. </para><para>A channel that can be asynchronously closed permits that a thread blocked on an I/O operation (the I/O thread) can be released by another thread calling the channel's close() method. The I/O thread will throw an AsynchronousCloseException and the channel will be closed. </para><para>A channel that is interruptible permits a thread blocked on an I/O operation (the I/O thread) to be interrupted by another thread (by invoking Thread#interrupt() on the I/O thread). When the I/O thread is interrupted it will throw a ClosedByInterruptException, it will have its interrupted status set and the channel will be closed. If the I/O thread attempts to make an I/O call with the interrupt status set the call will immediately fail with a ClosedByInterruptException. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/channels/InterruptibleChannel
		/// </java-name>
		[Dot42.DexImport("java/nio/channels/InterruptibleChannel", AccessFlags = 1537)]
		public partial interface IInterruptibleChannel : global::Java.Nio.Channels.IChannel
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Closes the channel. </para><para>Any threads that are blocked on I/O operations on this channel will be interrupted with an AsynchronousCloseException. Otherwise, this method behaves the same as defined in the <c> Channel </c> interface.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

}


