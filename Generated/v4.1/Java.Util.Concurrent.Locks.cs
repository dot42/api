// Copyright (C) 2014 dot42
//
// Original filename: Java.Util.Concurrent.Locks.cs
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
namespace Java.Util.Concurrent.Locks
{
		/// <summary>
		/// <para>Basic thread blocking primitives for creating locks and other synchronization classes.</para><para>This class associates, with each thread that uses it, a permit (in the sense of the Semaphore class). A call to <c> park </c> will return immediately if the permit is available, consuming it in the process; otherwise it <b>may</b> block. A call to <c> unpark </c> makes the permit available, if it was not already available. (Unlike with Semaphores though, permits do not accumulate. There is at most one.)</para><para>Methods <c> park </c> and <c> unpark </c> provide efficient means of blocking and unblocking threads that do not encounter the problems that cause the deprecated methods <c> Thread.suspend </c> and <c> Thread.resume </c> to be unusable for such purposes: Races between one thread invoking <c> park </c> and another thread trying to <c> unpark </c> it will preserve liveness, due to the permit. Additionally, <c> park </c> will return if the caller's thread was interrupted, and timeout versions are supported. The <c> park </c> method may also return at any other time, for "no   reason", so in general must be invoked within a loop that rechecks conditions upon return. In this sense <c> park </c> serves as an optimization of a "busy wait" that does not waste as much time spinning, but must be paired with an <c> unpark </c> to be effective.</para><para>The three forms of <c> park </c> each also support a <c> blocker </c> object parameter. This object is recorded while the thread is blocked to permit monitoring and diagnostic tools to identify the reasons that threads are blocked. (Such tools may access blockers using method getBlocker.) The use of these forms rather than the original forms without this parameter is strongly encouraged. The normal argument to supply as a <c> blocker </c> within a lock implementation is <c> this </c> .</para><para>These methods are designed to be used as tools for creating higher-level synchronization utilities, and are not in themselves useful for most concurrency control applications. The <c> park </c> method is designed for use only in constructions of the form:</para><para><pre>    while (!canProceed()) { ... LockSupport.park(this); } 
		/// 
		///  </pre></para><para>where neither <c> canProceed </c> nor any other actions prior to the call to <c> park </c> entail locking or blocking. Because only one permit is associated with each thread, any intermediary uses of <c> park </c> could interfere with its intended effects.</para><para><b>Sample Usage.</b> Here is a sketch of a first-in-first-out non-reentrant lock class: <pre>    class FIFOMutex {
		/// 
		///      private final AtomicBoolean locked = new AtomicBoolean(false);
		/// 
		///      private final Queue&lt;Thread&gt; waiters
		/// 
		///        = new ConcurrentLinkedQueue&lt;Thread&gt;();
		/// 
		///   
		/// 
		///      public void lock() {
		/// 
		///        boolean wasInterrupted = false;
		/// 
		///        Thread current = Thread.currentThread();
		/// 
		///        waiters.add(current);
		/// 
		///   
		/// 
		///        // Block while not first in queue or cannot acquire lock
		/// 
		///        while (waiters.peek() != current ||
		/// 
		///               !locked.compareAndSet(false, true)) {
		/// 
		///           LockSupport.park(this);
		/// 
		///           if (Thread.interrupted()) // ignore interrupts while waiting
		/// 
		///             wasInterrupted = true;
		/// 
		///        }
		/// 
		///   
		/// 
		///        waiters.remove();
		/// 
		///        if (wasInterrupted)          // reassert interrupt status on exit
		/// 
		///           current.interrupt();
		/// 
		///      }
		/// 
		///   
		/// 
		///      public void unlock() {
		/// 
		///        locked.set(false);
		/// 
		///        LockSupport.unpark(waiters.peek());
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/LockSupport
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/LockSupport", AccessFlags = 33)]
		public partial class LockSupport
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LockSupport() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Makes available the permit for the given thread, if it was not already available. If the thread was blocked on <c> park </c> then it will unblock. Otherwise, its next call to <c> park </c> is guaranteed not to block. This operation is not guaranteed to have any effect at all if the given thread has not been started.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unpark
				/// </java-name>
				[Dot42.DexImport("unpark", "(Ljava/lang/Thread;)V", AccessFlags = 9)]
				public static void Unpark(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables the current thread for thread scheduling purposes unless the permit is available.</para><para>If the permit is available then it is consumed and the call returns immediately; otherwise the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:</para><para><ul><li><para>Some other thread invokes unpark with the current thread as the target; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The call spuriously (that is, for no reason) returns. </para></li></ul></para><para>This method does <b>not</b> report which of these caused the method to return. Callers should re-check the conditions which caused the thread to park in the first place. Callers may also determine, for example, the interrupt status of the thread upon return.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// park
				/// </java-name>
				[Dot42.DexImport("park", "(Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void Park(object blocker) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables the current thread for thread scheduling purposes, for up to the specified waiting time, unless the permit is available.</para><para>If the permit is available then it is consumed and the call returns immediately; otherwise the current thread becomes disabled for thread scheduling purposes and lies dormant until one of four things happens:</para><para><ul><li><para>Some other thread invokes unpark with the current thread as the target; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified waiting time elapses; or</para><para></para></li><li><para>The call spuriously (that is, for no reason) returns. </para></li></ul></para><para>This method does <b>not</b> report which of these caused the method to return. Callers should re-check the conditions which caused the thread to park in the first place. Callers may also determine, for example, the interrupt status of the thread, or the elapsed time upon return.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// parkNanos
				/// </java-name>
				[Dot42.DexImport("parkNanos", "(Ljava/lang/Object;J)V", AccessFlags = 9)]
				public static void ParkNanos(object blocker, long nanos) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables the current thread for thread scheduling purposes, until the specified deadline, unless the permit is available.</para><para>If the permit is available then it is consumed and the call returns immediately; otherwise the current thread becomes disabled for thread scheduling purposes and lies dormant until one of four things happens:</para><para><ul><li><para>Some other thread invokes unpark with the current thread as the target; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified deadline passes; or</para><para></para></li><li><para>The call spuriously (that is, for no reason) returns. </para></li></ul></para><para>This method does <b>not</b> report which of these caused the method to return. Callers should re-check the conditions which caused the thread to park in the first place. Callers may also determine, for example, the interrupt status of the thread, or the current time upon return.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// parkUntil
				/// </java-name>
				[Dot42.DexImport("parkUntil", "(Ljava/lang/Object;J)V", AccessFlags = 9)]
				public static void ParkUntil(object blocker, long deadline) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the blocker object supplied to the most recent invocation of a park method that has not yet unblocked, or null if not blocked. The value returned is just a momentary snapshot  the thread may have since unblocked or blocked on a different blocker object.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the blocker </para>
				/// </returns>
				/// <java-name>
				/// getBlocker
				/// </java-name>
				[Dot42.DexImport("getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object GetBlocker(global::System.Threading.Thread t) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Disables the current thread for thread scheduling purposes unless the permit is available.</para><para>If the permit is available then it is consumed and the call returns immediately; otherwise the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:</para><para><ul><li><para>Some other thread invokes unpark with the current thread as the target; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The call spuriously (that is, for no reason) returns. </para></li></ul></para><para>This method does <b>not</b> report which of these caused the method to return. Callers should re-check the conditions which caused the thread to park in the first place. Callers may also determine, for example, the interrupt status of the thread upon return. </para>        
				/// </summary>
				/// <java-name>
				/// park
				/// </java-name>
				[Dot42.DexImport("park", "()V", AccessFlags = 9)]
				public static void Park() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables the current thread for thread scheduling purposes, for up to the specified waiting time, unless the permit is available.</para><para>If the permit is available then it is consumed and the call returns immediately; otherwise the current thread becomes disabled for thread scheduling purposes and lies dormant until one of four things happens:</para><para><ul><li><para>Some other thread invokes unpark with the current thread as the target; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified waiting time elapses; or</para><para></para></li><li><para>The call spuriously (that is, for no reason) returns. </para></li></ul></para><para>This method does <b>not</b> report which of these caused the method to return. Callers should re-check the conditions which caused the thread to park in the first place. Callers may also determine, for example, the interrupt status of the thread, or the elapsed time upon return.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parkNanos
				/// </java-name>
				[Dot42.DexImport("parkNanos", "(J)V", AccessFlags = 9)]
				public static void ParkNanos(long nanos) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables the current thread for thread scheduling purposes, until the specified deadline, unless the permit is available.</para><para>If the permit is available then it is consumed and the call returns immediately; otherwise the current thread becomes disabled for thread scheduling purposes and lies dormant until one of four things happens:</para><para><ul><li><para>Some other thread invokes unpark with the current thread as the target; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified deadline passes; or</para><para></para></li><li><para>The call spuriously (that is, for no reason) returns. </para></li></ul></para><para>This method does <b>not</b> report which of these caused the method to return. Callers should re-check the conditions which caused the thread to park in the first place. Callers may also determine, for example, the interrupt status of the thread, or the current time upon return.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parkUntil
				/// </java-name>
				[Dot42.DexImport("parkUntil", "(J)V", AccessFlags = 9)]
				public static void ParkUntil(long deadline) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A version of AbstractQueuedSynchronizer in which synchronization state is maintained as a <code>long</code>. This class has exactly the same structure, properties, and methods as <code>AbstractQueuedSynchronizer</code> with the exception that all state-related parameters and results are defined as <code>long</code> rather than <code>int</code>. This class may be useful when creating synchronizers such as multilevel locks and barriers that require 64 bits of state.</para><para>See AbstractQueuedSynchronizer for usage notes and examples.</para><para><para>1.6 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/AbstractQueuedLongSynchronizer
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/AbstractQueuedLongSynchronizer", AccessFlags = 1057)]
		public abstract partial class AbstractQueuedLongSynchronizer : global::Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>AbstractQueuedLongSynchronizer</code> instance with initial synchronization state of zero. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractQueuedLongSynchronizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of synchronization state. This operation has memory semantics of a <code>volatile</code> read. </para>        
				/// </summary>
				/// <returns>
				/// <para>current state value </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()J", AccessFlags = 20)]
				protected internal long GetState() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the value of synchronization state. This operation has memory semantics of a <code>volatile</code> write. </para>        
				/// </summary>
				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(J)V", AccessFlags = 20)]
				protected internal void SetState(long newState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets synchronization state to the given updated value if the current state value equals the expected value. This operation has memory semantics of a <code>volatile</code> read and write.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSetState
				/// </java-name>
				[Dot42.DexImport("compareAndSetState", "(JJ)Z", AccessFlags = 20)]
				protected internal bool CompareAndSetState(long expect, long update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to acquire in exclusive mode. This method should query if the state of the object permits it to be acquired in the exclusive mode, and if so to acquire it.</para><para>This method is always invoked by the thread performing acquire. If this method reports failure, the acquire method may queue the thread, if it is not already queued, until it is signalled by a release from some other thread. This can be used to implement method Lock#tryLock().</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if successful. Upon success, this object has been acquired. </para>
				/// </returns>
				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool TryAcquire(long arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to set the state to reflect a release in exclusive mode.</para><para>This method is always invoked by the thread performing release.</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this object is now in a fully released state, so that any waiting threads may attempt to acquire; and <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// tryRelease
				/// </java-name>
				[Dot42.DexImport("tryRelease", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool TryRelease(long arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to acquire in shared mode. This method should query if the state of the object permits it to be acquired in the shared mode, and if so to acquire it.</para><para>This method is always invoked by the thread performing acquire. If this method reports failure, the acquire method may queue the thread, if it is not already queued, until it is signalled by a release from some other thread.</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value on failure; zero if acquisition in shared mode succeeded but no subsequent shared-mode acquire can succeed; and a positive value if acquisition in shared mode succeeded and subsequent shared-mode acquires might also succeed, in which case a subsequent waiting thread must check availability. (Support for three different return values enables this method to be used in contexts where acquires only sometimes act exclusively.) Upon success, this object has been acquired. </para>
				/// </returns>
				/// <java-name>
				/// tryAcquireShared
				/// </java-name>
				[Dot42.DexImport("tryAcquireShared", "(J)J", AccessFlags = 4)]
				protected internal virtual long TryAcquireShared(long arg) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Attempts to set the state to reflect a release in shared mode.</para><para>This method is always invoked by the thread performing release.</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this release of shared mode may permit a waiting acquire (shared or exclusive) to succeed; and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// tryReleaseShared
				/// </java-name>
				[Dot42.DexImport("tryReleaseShared", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool TryReleaseShared(long arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if synchronization is held exclusively with respect to the current (calling) thread. This method is invoked upon each call to a non-waiting ConditionObject method. (Waiting methods instead invoke release.)</para><para>The default implementation throws UnsupportedOperationException. This method is invoked internally only within ConditionObject methods, so need not be defined if conditions are not used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if synchronization is held exclusively; <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isHeldExclusively
				/// </java-name>
				[Dot42.DexImport("isHeldExclusively", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsHeldExclusively() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Acquires in exclusive mode, ignoring interrupts. Implemented by invoking at least once tryAcquire, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquire until success. This method can be used to implement method Lock#lock.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(J)V", AccessFlags = 17)]
				public void Acquire(long arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires in exclusive mode, aborting if interrupted. Implemented by first checking interrupt status, then invoking at least once tryAcquire, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquire until success or the thread is interrupted. This method can be used to implement method Lock#lockInterruptibly.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquireInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireInterruptibly", "(J)V", AccessFlags = 17)]
				public void AcquireInterruptibly(long arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to acquire in exclusive mode, aborting if interrupted, and failing if the given timeout elapses. Implemented by first checking interrupt status, then invoking at least once tryAcquire, returning on success. Otherwise, the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquire until success or the thread is interrupted or the timeout elapses. This method can be used to implement method Lock#tryLock(long, TimeUnit).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if acquired; <c> false </c> if timed out </para>
				/// </returns>
				/// <java-name>
				/// tryAcquireNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireNanos", "(JJ)Z", AccessFlags = 17)]
				public bool TryAcquireNanos(long arg, long nanosTimeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases in exclusive mode. Implemented by unblocking one or more threads if tryRelease returns true. This method can be used to implement method Lock#unlock.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value returned from tryRelease </para>
				/// </returns>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(J)Z", AccessFlags = 17)]
				public bool Release(long arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Acquires in shared mode, ignoring interrupts. Implemented by first invoking at least once tryAcquireShared, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquireShared until success.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquireShared
				/// </java-name>
				[Dot42.DexImport("acquireShared", "(J)V", AccessFlags = 17)]
				public void AcquireShared(long arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires in shared mode, aborting if interrupted. Implemented by first checking interrupt status, then invoking at least once tryAcquireShared, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquireShared until success or the thread is interrupted. </para>        
				/// </summary>
				/// <java-name>
				/// acquireSharedInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireSharedInterruptibly", "(J)V", AccessFlags = 17)]
				public void AcquireSharedInterruptibly(long arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to acquire in shared mode, aborting if interrupted, and failing if the given timeout elapses. Implemented by first checking interrupt status, then invoking at least once tryAcquireShared, returning on success. Otherwise, the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquireShared until success or the thread is interrupted or the timeout elapses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if acquired; <c> false </c> if timed out </para>
				/// </returns>
				/// <java-name>
				/// tryAcquireSharedNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireSharedNanos", "(JJ)Z", AccessFlags = 17)]
				public bool TryAcquireSharedNanos(long arg, long nanosTimeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases in shared mode. Implemented by unblocking one or more threads if tryReleaseShared returns true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value returned from tryReleaseShared </para>
				/// </returns>
				/// <java-name>
				/// releaseShared
				/// </java-name>
				[Dot42.DexImport("releaseShared", "(J)Z", AccessFlags = 17)]
				public bool ReleaseShared(long arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting to acquire. Note that because cancellations due to interrupts and timeouts may occur at any time, a <c> true </c> return does not guarantee that any other thread will ever acquire.</para><para>In this implementation, this operation returns in constant time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there may be other threads waiting to acquire </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether any threads have ever contended to acquire this synchronizer; that is if an acquire method has ever blocked.</para><para>In this implementation, this operation returns in constant time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there has ever been contention </para>
				/// </returns>
				/// <java-name>
				/// hasContended
				/// </java-name>
				[Dot42.DexImport("hasContended", "()Z", AccessFlags = 17)]
				public bool HasContended() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued.</para><para>In this implementation, this operation normally returns in constant time, but may iterate upon contention if other threads are concurrently modifying the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued </para>
				/// </returns>
				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
				public global::System.Threading.Thread GetFirstQueuedThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <summary>
				/// <para>Returns true if the given thread is currently queued.</para><para>This implementation traverses the queue to determine presence of the given thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given thread is on the queue </para>
				/// </returns>
				/// <java-name>
				/// isQueued
				/// </java-name>
				[Dot42.DexImport("isQueued", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool IsQueued(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting to acquire </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in exclusive mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to an exclusive acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetExclusiveQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in shared mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to a shared acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetSharedQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a string identifying this synchronizer, as well as its state. The state, in brackets, includes the String <c> "State =" </c> followed by the current value of getState, and either <c> "nonempty" </c> or <c> "empty" </c> depending on whether the queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string identifying this synchronizer, as well as its state </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Queries whether the given ConditionObject uses this synchronizer as its lock.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if owned </para>
				/// </returns>
				/// <java-name>
				/// owns
				/// </java-name>
				[Dot42.DexImport("owns", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool Owns(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting on the given condition associated with this synchronizer. Note that because timeouts and interrupts may occur at any time, a <code>true</code> return does not guarantee that a future <code>signal</code> will awaken any threads. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there are any waiting threads </para>
				/// </returns>
				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool HasWaiters(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting on the given condition associated with this synchronizer. Note that because timeouts and interrupts may occur at any time, the estimate serves only as an upper bound on the actual number of waiters. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of waiting threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)I", AccessFlags = 17)]
				public int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing those threads that may be waiting on the given condition associated with this synchronizer. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Ljav" +
    "a/util/Collection;", AccessFlags = 17, Signature = "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Ljav" +
    "a/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns the current value of synchronization state. This operation has memory semantics of a <code>volatile</code> read. </para>        
				/// </summary>
				/// <returns>
				/// <para>current state value </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				protected internal long State
				{
				[Dot42.DexImport("getState", "()J", AccessFlags = 20)]
						get{ return GetState(); }
				[Dot42.DexImport("setState", "(J)V", AccessFlags = 20)]
						set{ SetState(value); }
				}

				/// <summary>
				/// <para>Returns the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued.</para><para>In this implementation, this operation normally returns in constant time, but may iterate upon contention if other threads are concurrently modifying the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued </para>
				/// </returns>
				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				public global::System.Threading.Thread FirstQueuedThread
				{
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
						get{ return GetFirstQueuedThread(); }
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting to acquire </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in exclusive mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to an exclusive acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> ExclusiveQueuedThreads
				{
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetExclusiveQueuedThreads(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in shared mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to a shared acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> SharedQueuedThreads
				{
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetSharedQueuedThreads(); }
				}

				/// <summary>
				/// <para>Condition implementation for a AbstractQueuedLongSynchronizer serving as the basis of a Lock implementation.</para><para>Method documentation for this class describes mechanics, not behavioral specifications from the point of view of Lock and Condition users. Exported versions of this class will in general need to be accompanied by documentation describing condition semantics that rely on those of the associated <code>AbstractQueuedLongSynchronizer</code>.</para><para>This class is Serializable, but all fields are transient, so deserialized conditions have no waiters.</para><para><para>1.6 </para></para>    
				/// </summary>
				/// <java-name>
				/// java/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject", AccessFlags = 1)]
				public partial class ConditionObject : global::Java.Util.Concurrent.Locks.ICondition, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer;", AccessFlags = 4112)]
						internal readonly global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer This_0;
						[Dot42.DexImport("<init>", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer;)V", AccessFlags = 1)]
						public ConditionObject(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer abstractQueuedLongSynchronizer) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Moves the longest-waiting thread, if one exists, from the wait queue for this condition to the wait queue for the owning lock.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// signal
						/// </java-name>
						[Dot42.DexImport("signal", "()V", AccessFlags = 17)]
						public void Signal() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Moves all threads from the wait queue for this condition to the wait queue for the owning lock.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// signalAll
						/// </java-name>
						[Dot42.DexImport("signalAll", "()V", AccessFlags = 17)]
						public void SignalAll() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Implements uninterruptible condition wait. <ol><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// awaitUninterruptibly
						/// </java-name>
						[Dot42.DexImport("awaitUninterruptibly", "()V", AccessFlags = 17)]
						public void AwaitUninterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Implements interruptible condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled or interrupted. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "()V", AccessFlags = 17)]
						public void Await() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Implements timed condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled, interrupted, or timed out. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// awaitNanos
						/// </java-name>
						[Dot42.DexImport("awaitNanos", "(J)J", AccessFlags = 17)]
						public long AwaitNanos(long nanosTimeout) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Implements absolute timed condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled, interrupted, or timed out. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li><li><para>If timed out while blocked in step 4, return false, else true. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// awaitUntil
						/// </java-name>
						[Dot42.DexImport("awaitUntil", "(Ljava/util/Date;)Z", AccessFlags = 17)]
						public bool AwaitUntil(global::Java.Util.Date deadline) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Implements timed condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled, interrupted, or timed out. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li><li><para>If timed out while blocked in step 4, return false, else true. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 17)]
						public bool Await(long time, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Queries whether any threads are waiting on this condition. Implements AbstractQueuedLongSynchronizer#hasWaiters.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if there are any waiting threads </para>
						/// </returns>
						/// <java-name>
						/// hasWaiters
						/// </java-name>
						[Dot42.DexImport("hasWaiters", "()Z", AccessFlags = 20)]
						protected internal bool HasWaiters() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns an estimate of the number of threads waiting on this condition. Implements AbstractQueuedLongSynchronizer#getWaitQueueLength.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the estimated number of waiting threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
						protected internal int GetWaitQueueLength() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns a collection containing those threads that may be waiting on this Condition. Implements AbstractQueuedLongSynchronizer#getWaitingThreads.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the collection of threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitingThreads
						/// </java-name>
						[Dot42.DexImport("getWaitingThreads", "()Ljava/util/Collection;", AccessFlags = 20, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						protected internal global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ConditionObject() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns an estimate of the number of threads waiting on this condition. Implements AbstractQueuedLongSynchronizer#getWaitQueueLength.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the estimated number of waiting threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						protected internal int WaitQueueLength
						{
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
								get{ return GetWaitQueueLength(); }
						}

						/// <summary>
						/// <para>Returns a collection containing those threads that may be waiting on this Condition. Implements AbstractQueuedLongSynchronizer#getWaitingThreads.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the collection of threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitingThreads
						/// </java-name>
						protected internal global::Java.Util.ICollection<global::System.Threading.Thread> WaitingThreads
						{
						[Dot42.DexImport("getWaitingThreads", "()Ljava/util/Collection;", AccessFlags = 20, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
								get{ return GetWaitingThreads(); }
						}

				}

		}

		/// <summary>
		/// <para>A <code>ReadWriteLock</code> maintains a pair of associated locks, one for read-only operations and one for writing. The read lock may be held simultaneously by multiple reader threads, so long as there are no writers. The write lock is exclusive.</para><para>All <code>ReadWriteLock</code> implementations must guarantee that the memory synchronization effects of <code>writeLock</code> operations (as specified in the Lock interface) also hold with respect to the associated <code>readLock</code>. That is, a thread successfully acquiring the read lock will see all updates made upon previous release of the write lock.</para><para>A read-write lock allows for a greater level of concurrency in accessing shared data than that permitted by a mutual exclusion lock. It exploits the fact that while only a single thread at a time (a <b>writer</b> thread) can modify the shared data, in many cases any number of threads can concurrently read the data (hence <b>reader</b> threads). In theory, the increase in concurrency permitted by the use of a read-write lock will lead to performance improvements over the use of a mutual exclusion lock. In practice this increase in concurrency will only be fully realized on a multi-processor, and then only if the access patterns for the shared data are suitable.</para><para>Whether or not a read-write lock will improve performance over the use of a mutual exclusion lock depends on the frequency that the data is read compared to being modified, the duration of the read and write operations, and the contention for the data - that is, the number of threads that will try to read or write the data at the same time. For example, a collection that is initially populated with data and thereafter infrequently modified, while being frequently searched (such as a directory of some kind) is an ideal candidate for the use of a read-write lock. However, if updates become frequent then the data spends most of its time being exclusively locked and there is little, if any increase in concurrency. Further, if the read operations are too short the overhead of the read-write lock implementation (which is inherently more complex than a mutual exclusion lock) can dominate the execution cost, particularly as many read-write lock implementations still serialize all threads through a small section of code. Ultimately, only profiling and measurement will establish whether the use of a read-write lock is suitable for your application.</para><para>Although the basic operation of a read-write lock is straight-forward, there are many policy decisions that an implementation must make, which may affect the effectiveness of the read-write lock in a given application. Examples of these policies include: <ul><li><para>Determining whether to grant the read lock or the write lock, when both readers and writers are waiting, at the time that a writer releases the write lock. Writer preference is common, as writes are expected to be short and infrequent. Reader preference is less common as it can lead to lengthy delays for a write if the readers are frequent and long-lived as expected. Fair, or "in-order" implementations are also possible.</para><para></para></li><li><para>Determining whether readers that request the read lock while a reader is active and a writer is waiting, are granted the read lock. Preference to the reader can delay the writer indefinitely, while preference to the writer can reduce the potential for concurrency.</para><para></para></li><li><para>Determining whether the locks are reentrant: can a thread with the write lock reacquire it? Can it acquire a read lock while holding the write lock? Is the read lock itself reentrant?</para><para></para></li><li><para>Can the write lock be downgraded to a read lock without allowing an intervening writer? Can a read lock be upgraded to a write lock, in preference to other waiting readers or writers?</para><para></para></li></ul>You should consider all of these things when evaluating the suitability of a given implementation for your application.</para><para><para>ReentrantReadWriteLock </para><simplesectsep></simplesectsep><para>Lock </para><simplesectsep></simplesectsep><para>ReentrantLock</para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/ReadWriteLock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/ReadWriteLock", AccessFlags = 1537)]
		public partial interface IReadWriteLock
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the lock used for reading.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the lock used for reading. </para>
				/// </returns>
				/// <java-name>
				/// readLock
				/// </java-name>
				[Dot42.DexImport("readLock", "()Ljava/util/concurrent/locks/Lock;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ILock ReadLock() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the lock used for writing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the lock used for writing. </para>
				/// </returns>
				/// <java-name>
				/// writeLock
				/// </java-name>
				[Dot42.DexImport("writeLock", "()Ljava/util/concurrent/locks/Lock;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ILock WriteLock() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><c> Lock </c> implementations provide more extensive locking operations than can be obtained using <c> synchronized </c> methods and statements. They allow more flexible structuring, may have quite different properties, and may support multiple associated Condition objects.</para><para>A lock is a tool for controlling access to a shared resource by multiple threads. Commonly, a lock provides exclusive access to a shared resource: only one thread at a time can acquire the lock and all access to the shared resource requires that the lock be acquired first. However, some locks may allow concurrent access to a shared resource, such as the read lock of a ReadWriteLock.</para><para>The use of <c> synchronized </c> methods or statements provides access to the implicit monitor lock associated with every object, but forces all lock acquisition and release to occur in a block-structured way: when multiple locks are acquired they must be released in the opposite order, and all locks must be released in the same lexical scope in which they were acquired.</para><para>While the scoping mechanism for <c> synchronized </c> methods and statements makes it much easier to program with monitor locks, and helps avoid many common programming errors involving locks, there are occasions where you need to work with locks in a more flexible way. For example, some algorithms for traversing concurrently accessed data structures require the use of "hand-over-hand" or "chain locking": you acquire the lock of node A, then node B, then release A and acquire C, then release B and acquire D and so on. Implementations of the <c> Lock </c> interface enable the use of such techniques by allowing a lock to be acquired and released in different scopes, and allowing multiple locks to be acquired and released in any order.</para><para>With this increased flexibility comes additional responsibility. The absence of block-structured locking removes the automatic release of locks that occurs with <c> synchronized </c> methods and statements. In most cases, the following idiom should be used:</para><para><pre>    Lock l = ...;
		/// 
		///    l.lock();
		/// 
		///    try {
		/// 
		///      // access the resource protected by this lock
		/// 
		///    } finally {
		/// 
		///      l.unlock();
		/// 
		///    } 
		/// 
		///  </pre></para><para>When locking and unlocking occur in different scopes, care must be taken to ensure that all code that is executed while the lock is held is protected by try-finally or try-catch to ensure that the lock is released when necessary.</para><para><c> Lock </c> implementations provide additional functionality over the use of <c> synchronized </c> methods and statements by providing a non-blocking attempt to acquire a lock (tryLock()), an attempt to acquire the lock that can be interrupted (lockInterruptibly, and an attempt to acquire the lock that can timeout (tryLock(long, TimeUnit)).</para><para>A <c> Lock </c> class can also provide behavior and semantics that is quite different from that of the implicit monitor lock, such as guaranteed ordering, non-reentrant usage, or deadlock detection. If an implementation provides such specialized semantics then the implementation must document those semantics.</para><para>Note that <c> Lock </c> instances are just normal objects and can themselves be used as the target in a <c> synchronized </c> statement. Acquiring the monitor lock of a <c> Lock </c> instance has no specified relationship with invoking any of the lock methods of that instance. It is recommended that to avoid confusion you never use <c> Lock </c> instances in this way, except within their own implementation.</para><para>Except where noted, passing a <c> null </c> value for any parameter will result in a NullPointerException being thrown.</para><para><h3>Memory Synchronization</h3></para><para>All <c> Lock </c> implementations <b>must</b> enforce the same memory synchronization semantics as provided by the built-in monitor lock, as described in : <ul><li><para>A successful <c> lock </c> operation has the same memory synchronization effects as a successful <b>Lock</b> action. </para></li><li><para>A successful <c> unlock </c> operation has the same memory synchronization effects as a successful <b>Unlock</b> action. </para></li></ul></para><para>Unsuccessful locking and unlocking operations, and reentrant locking/unlocking operations, do not require any memory synchronization effects.</para><para><h3>Implementation Considerations</h3></para><para>The three forms of lock acquisition (interruptible, non-interruptible, and timed) may differ in their performance characteristics, ordering guarantees, or other implementation qualities. Further, the ability to interrupt the <b>ongoing</b> acquisition of a lock may not be available in a given <c> Lock </c> class. Consequently, an implementation is not required to define exactly the same guarantees or semantics for all three forms of lock acquisition, nor is it required to support interruption of an ongoing lock acquisition. An implementation is required to clearly document the semantics and guarantees provided by each of the locking methods. It must also obey the interruption semantics as defined in this interface, to the extent that interruption of lock acquisition is supported: which is either totally, or only on method entry.</para><para>As interruption generally implies cancellation, and checks for interruption are often infrequent, an implementation can favor responding to an interrupt over normal method return. This is true even if it can be shown that the interrupt occurred after another action may have unblocked the thread. An implementation should document this behavior.</para><para><para>ReentrantLock </para><simplesectsep></simplesectsep><para>Condition </para><simplesectsep></simplesectsep><para>ReadWriteLock</para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/Lock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/Lock", AccessFlags = 1537)]
		public partial interface ILock
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Acquires the lock.</para><para>If the lock is not available then the current thread becomes disabled for thread scheduling purposes and lies dormant until the lock has been acquired.</para><para><b>Implementation Considerations</b></para><para>A <c> Lock </c> implementation may be able to detect erroneous use of the lock, such as an invocation that would cause deadlock, and may throw an (unchecked) exception in such circumstances. The circumstances and the exception type must be documented by that <c> Lock </c> implementation. </para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 1025)]
				void Lock() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Acquires the lock unless the current thread is  Thread::interrupt interrupted}.</para><para>Acquires the lock if it is available and returns immediately.</para><para>If the lock is not available then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happens:</para><para><ul><li><para>The lock is acquired by the current thread; or </para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread, and interruption of lock acquisition is supported. </para></li></ul></para><para>If the current thread: <ul><li><para>has its interrupted status set on entry to this method; or </para></li><li><para>is  Thread::interrupt interrupted} while acquiring the lock, and interruption of lock acquisition is supported, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para><b>Implementation Considerations</b></para><para>The ability to interrupt a lock acquisition in some implementations may not be possible, and if possible may be an expensive operation. The programmer should be aware that this may be the case. An implementation should document when this is the case.</para><para>An implementation can favor responding to an interrupt over normal method return.</para><para>A <c> Lock </c> implementation may be able to detect erroneous use of the lock, such as an invocation that would cause deadlock, and may throw an (unchecked) exception in such circumstances. The circumstances and the exception type must be documented by that <c> Lock </c> implementation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// lockInterruptibly
				/// </java-name>
				[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1025)]
				void LockInterruptibly() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Acquires the lock only if it is free at the time of invocation.</para><para>Acquires the lock if it is available and returns immediately with the value <c> true </c> . If the lock is not available then this method will return immediately with the value <c> false </c> .</para><para>A typical usage idiom for this method would be: <pre>        Lock lock = ...;
				/// 
				///        if (lock.tryLock()) {
				/// 
				///          try {
				/// 
				///            // manipulate protected state
				/// 
				///          } finally {
				/// 
				///            lock.unlock();
				/// 
				///          }
				/// 
				///        } else {
				/// 
				///          // perform alternative actions
				/// 
				///        } 
				/// 
				///  </pre></para><para>This usage ensures that the lock is unlocked if it was acquired, and doesn't try to unlock if the lock was not acquired.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the lock was acquired and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1025)]
				bool TryLock() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Acquires the lock if it is free within the given waiting time and the current thread has not been  Thread::interrupt interrupted}.</para><para>If the lock is available this method returns immediately with the value <c> true </c> . If the lock is not available then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens: <ul><li><para>The lock is acquired by the current thread; or </para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread, and interruption of lock acquisition is supported; or </para></li><li><para>The specified waiting time elapses </para></li></ul></para><para>If the lock is acquired then the value <c> true </c> is returned.</para><para>If the current thread: <ul><li><para>has its interrupted status set on entry to this method; or </para></li><li><para>is  Thread::interrupt interrupted} while acquiring the lock, and interruption of lock acquisition is supported, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>If the specified waiting time elapses then the value <c> false </c> is returned. If the time is less than or equal to zero, the method will not wait at all.</para><para><b>Implementation Considerations</b></para><para>The ability to interrupt a lock acquisition in some implementations may not be possible, and if possible may be an expensive operation. The programmer should be aware that this may be the case. An implementation should document when this is the case.</para><para>An implementation can favor responding to an interrupt over normal method return, or reporting a timeout.</para><para>A <c> Lock </c> implementation may be able to detect erroneous use of the lock, such as an invocation that would cause deadlock, and may throw an (unchecked) exception in such circumstances. The circumstances and the exception type must be documented by that <c> Lock </c> implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the lock was acquired and <c> false </c> if the waiting time elapsed before the lock was acquired</para>
				/// </returns>
				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				bool TryLock(long time, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Releases the lock.</para><para><b>Implementation Considerations</b></para><para>A <c> Lock </c> implementation will usually impose restrictions on which thread can release a lock (typically only the holder of the lock can release it) and may throw an (unchecked) exception if the restriction is violated. Any restrictions and the exception type must be documented by that <c> Lock </c> implementation. </para>        
				/// </summary>
				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 1025)]
				void Unlock() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new Condition instance that is bound to this <c> Lock </c> instance.</para><para>Before waiting on the condition the lock must be held by the current thread. A call to Condition#await() will atomically release the lock before waiting and re-acquire the lock before the wait returns.</para><para><b>Implementation Considerations</b></para><para>The exact operation of the Condition instance depends on the <c> Lock </c> implementation and must be documented by that implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new Condition instance for this <c> Lock </c> instance </para>
				/// </returns>
				/// <java-name>
				/// newCondition
				/// </java-name>
				[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A reentrant mutual exclusion Lock with the same basic behavior and semantics as the implicit monitor lock accessed using <c> synchronized </c> methods and statements, but with extended capabilities.</para><para>A <c> ReentrantLock </c> is <b>owned</b> by the thread last successfully locking, but not yet unlocking it. A thread invoking <c> lock </c> will return, successfully acquiring the lock, when the lock is not owned by another thread. The method will return immediately if the current thread already owns the lock. This can be checked using methods isHeldByCurrentThread, and getHoldCount.</para><para>The constructor for this class accepts an optional <b>fairness</b> parameter. When set <c> true </c> , under contention, locks favor granting access to the longest-waiting thread. Otherwise this lock does not guarantee any particular access order. Programs using fair locks accessed by many threads may display lower overall throughput (i.e., are slower; often much slower) than those using the default setting, but have smaller variances in times to obtain locks and guarantee lack of starvation. Note however, that fairness of locks does not guarantee fairness of thread scheduling. Thus, one of many threads using a fair lock may obtain it multiple times in succession while other active threads are not progressing and not currently holding the lock. Also note that the untimed tryLock method does not honor the fairness setting. It will succeed if the lock is available even if other threads are waiting.</para><para>It is recommended practice to <b>always</b> immediately follow a call to <c> lock </c> with a <c> try </c> block, most typically in a before/after construction such as:</para><para><pre>    class X {
		/// 
		///      private final ReentrantLock lock = new ReentrantLock();
		/// 
		///      // ...
		/// 
		///   
		/// 
		///      public void m() {
		/// 
		///        lock.lock();  // block until condition holds
		/// 
		///        try {
		/// 
		///          // ... method body
		/// 
		///        } finally {
		/// 
		///          lock.unlock()
		/// 
		///        }
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre></para><para>In addition to implementing the Lock interface, this class defines methods <c> isLocked </c> and <c> getLockQueueLength </c> , as well as some associated <c> protected </c> access methods that may be useful for instrumentation and monitoring.</para><para>Serialization of this class behaves in the same way as built-in locks: a deserialized lock is in the unlocked state, regardless of its state when serialized.</para><para>This lock supports a maximum of 2147483647 recursive locks by the same thread. Attempts to exceed this limit result in Error throws from locking methods.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/ReentrantLock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/ReentrantLock", AccessFlags = 33)]
		public partial class ReentrantLock : global::Java.Util.Concurrent.Locks.ILock, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates an instance of <c> ReentrantLock </c> . This is equivalent to using <c> ReentrantLock(false) </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReentrantLock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an instance of <c> ReentrantLock </c> with the given fairness policy.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ReentrantLock(bool fair) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires the lock.</para><para>Acquires the lock if it is not held by another thread and returns immediately, setting the lock hold count to one.</para><para>If the current thread already holds the lock then the hold count is incremented by one and the method returns immediately.</para><para>If the lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until the lock has been acquired, at which time the lock hold count is set to one. </para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
				public virtual void Lock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires the lock unless the current thread is  Thread::interrupt interrupted}.</para><para>Acquires the lock if it is not held by another thread and returns immediately, setting the lock hold count to one.</para><para>If the current thread already holds this lock then the hold count is incremented by one and the method returns immediately.</para><para>If the lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happens:</para><para><ul><li><para>The lock is acquired by the current thread; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread.</para><para></para></li></ul></para><para>If the lock is acquired by the current thread then the lock hold count is set to one.</para><para>If the current thread:</para><para><ul><li><para>has its interrupted status set on entry to this method; or</para><para></para></li><li><para>is  Thread::interrupt interrupted} while acquiring the lock,</para><para></para></li></ul></para><para>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>In this implementation, as this method is an explicit interruption point, preference is given to responding to the interrupt over normal or reentrant acquisition of the lock.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// lockInterruptibly
				/// </java-name>
				[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1)]
				public virtual void LockInterruptibly() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires the lock only if it is not held by another thread at the time of invocation.</para><para>Acquires the lock if it is not held by another thread and returns immediately with the value <c> true </c> , setting the lock hold count to one. Even when this lock has been set to use a fair ordering policy, a call to <c> tryLock() </c> <b>will</b> immediately acquire the lock if it is available, whether or not other threads are currently waiting for the lock. This "barging" behavior can be useful in certain circumstances, even though it breaks fairness. If you want to honor the fairness setting for this lock, then use tryLock(0, TimeUnit.SECONDS)  which is almost equivalent (it also detects interruption).</para><para>If the current thread already holds this lock then the hold count is incremented by one and the method returns <c> true </c> .</para><para>If the lock is held by another thread then this method will return immediately with the value <c> false </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the lock was free and was acquired by the current thread, or the lock was already held by the current thread; and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1)]
				public virtual bool TryLock() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Acquires the lock if it is not held by another thread within the given waiting time and the current thread has not been  Thread::interrupt interrupted}.</para><para>Acquires the lock if it is not held by another thread and returns immediately with the value <c> true </c> , setting the lock hold count to one. If this lock has been set to use a fair ordering policy then an available lock <b>will not</b> be acquired if any other threads are waiting for the lock. This is in contrast to the tryLock() method. If you want a timed <c> tryLock </c> that does permit barging on a fair lock then combine the timed and un-timed forms together:</para><para><pre>        if (lock.tryLock() ||
				/// 
				///            lock.tryLock(timeout, unit)) {
				/// 
				///          ...
				/// 
				///        } 
				/// 
				///  </pre></para><para>If the current thread already holds this lock then the hold count is incremented by one and the method returns <c> true </c> .</para><para>If the lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:</para><para><ul><li><para>The lock is acquired by the current thread; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified waiting time elapses</para><para></para></li></ul></para><para>If the lock is acquired then the value <c> true </c> is returned and the lock hold count is set to one.</para><para>If the current thread:</para><para><ul><li><para>has its interrupted status set on entry to this method; or</para><para></para></li><li><para>is  Thread::interrupt interrupted} while acquiring the lock,</para><para></para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>If the specified waiting time elapses then the value <c> false </c> is returned. If the time is less than or equal to zero, the method will not wait at all.</para><para>In this implementation, as this method is an explicit interruption point, preference is given to responding to the interrupt over normal or reentrant acquisition of the lock, and over reporting the elapse of the waiting time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the lock was free and was acquired by the current thread, or the lock was already held by the current thread; and <c> false </c> if the waiting time elapsed before the lock could be acquired </para>
				/// </returns>
				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool TryLock(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to release this lock.</para><para>If the current thread is the holder of this lock then the hold count is decremented. If the hold count is now zero then the lock is released. If the current thread is not the holder of this lock then IllegalMonitorStateException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
				public virtual void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a Condition instance for use with this Lock instance.</para><para>The returned Condition instance supports the same usages as do the Object monitor methods (wait, notify, and notifyAll) when used with the built-in monitor lock.</para><para><ul><li><para>If this lock is not held when any of the Condition  Condition::await() waiting} or  Condition::signal signalling} methods are called, then an IllegalMonitorStateException is thrown.</para><para></para></li><li><para>When the condition  Condition::await() waiting} methods are called the lock is released and, before they return, the lock is reacquired and the lock hold count restored to what it was when the method was called.</para><para></para></li><li><para>If a thread is  Thread::interrupt interrupted} while waiting then the wait will terminate, an InterruptedException will be thrown, and the thread's interrupted status will be cleared.</para><para></para></li><li><para>Waiting threads are signalled in FIFO order.</para><para></para></li><li><para>The ordering of lock reacquisition for threads returning from waiting methods is the same as for threads initially acquiring the lock, which is in the default case not specified, but for <b>fair</b> locks favors those threads that have been waiting the longest.</para><para></para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Condition object </para>
				/// </returns>
				/// <java-name>
				/// newCondition
				/// </java-name>
				[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ICondition);
				}

				/// <summary>
				/// <para>Queries the number of holds on this lock by the current thread.</para><para>A thread has a hold on a lock for each lock action that is not matched by an unlock action.</para><para>The hold count information is typically only used for testing and debugging purposes. For example, if a certain section of code should not be entered with the lock already held then we can assert that fact:</para><para><pre>        class X {
				/// 
				///          ReentrantLock lock = new ReentrantLock();
				/// 
				///          // ...
				/// 
				///          public void m() {
				/// 
				///            assert lock.getHoldCount() == 0;
				/// 
				///            lock.lock();
				/// 
				///            try {
				/// 
				///              // ... method body
				/// 
				///            } finally {
				/// 
				///              lock.unlock();
				/// 
				///            }
				/// 
				///          }
				/// 
				///        } 
				/// 
				///  </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of holds on this lock by the current thread, or zero if this lock is not held by the current thread </para>
				/// </returns>
				/// <java-name>
				/// getHoldCount
				/// </java-name>
				[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
				public virtual int GetHoldCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Queries if this lock is held by the current thread.</para><para>Analogous to the Thread#holdsLock method for built-in monitor locks, this method is typically used for debugging and testing. For example, a method that should only be called while a lock is held can assert that this is the case:</para><para><pre>        class X {
				/// 
				///          ReentrantLock lock = new ReentrantLock();
				/// 
				///          // ...
				/// 
				///       
				/// 
				///          public void m() {
				/// 
				///              assert lock.isHeldByCurrentThread();
				/// 
				///              // ... method body
				/// 
				///          }
				/// 
				///        } 
				/// 
				///  </pre></para><para>It can also be used to ensure that a reentrant lock is used in a non-reentrant manner, for example:</para><para><pre>        class X {
				/// 
				///          ReentrantLock lock = new ReentrantLock();
				/// 
				///          // ...
				/// 
				///       
				/// 
				///          public void m() {
				/// 
				///              assert !lock.isHeldByCurrentThread();
				/// 
				///              lock.lock();
				/// 
				///              try {
				/// 
				///                  // ... method body
				/// 
				///              } finally {
				/// 
				///                  lock.unlock();
				/// 
				///              }
				/// 
				///          }
				/// 
				///        } 
				/// 
				///  </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if current thread holds this lock and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isHeldByCurrentThread
				/// </java-name>
				[Dot42.DexImport("isHeldByCurrentThread", "()Z", AccessFlags = 1)]
				public virtual bool IsHeldByCurrentThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries if this lock is held by any thread. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if any thread holds this lock and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLocked
				/// </java-name>
				[Dot42.DexImport("isLocked", "()Z", AccessFlags = 1)]
				public virtual bool IsLocked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if this lock has fairness set true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this lock has fairness set true </para>
				/// </returns>
				/// <java-name>
				/// isFair
				/// </java-name>
				[Dot42.DexImport("isFair", "()Z", AccessFlags = 17)]
				public bool IsFair() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the thread that currently owns this lock, or <c> null </c> if not owned. When this method is called by a thread that is not the owner, the return value reflects a best-effort approximation of current lock status. For example, the owner may be momentarily <c> null </c> even if there are threads trying to acquire the lock but have not yet done so. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the owner, or <c> null </c> if not owned </para>
				/// </returns>
				/// <java-name>
				/// getOwner
				/// </java-name>
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
				protected internal virtual global::System.Threading.Thread GetOwner() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting to acquire this lock. Note that because cancellations may occur at any time, a <c> true </c> return does not guarantee that any other thread will ever acquire this lock. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there may be other threads waiting to acquire the lock </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether the given thread is waiting to acquire this lock. Note that because cancellations may occur at any time, a <c> true </c> return does not guarantee that this thread will ever acquire this lock. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given thread is queued waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThread
				/// </java-name>
				[Dot42.DexImport("hasQueuedThread", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool HasQueuedThread(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire this lock. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire this lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting on the given condition associated with this lock. Note that because timeouts and interrupts may occur at any time, a <c> true </c> return does not guarantee that a future <c> signal </c> will awaken any threads. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there are any waiting threads </para>
				/// </returns>
				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", AccessFlags = 1)]
				public virtual bool HasWaiters(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting on the given condition associated with this lock. Note that because timeouts and interrupts may occur at any time, the estimate serves only as an upper bound on the actual number of waiters. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of waiting threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", AccessFlags = 1)]
				public virtual int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing those threads that may be waiting on the given condition associated with this lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive condition monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", AccessFlags = 4, Signature = "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection<Ljava/lang/Thread;>" +
    ";")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a string identifying this lock, as well as its lock state. The state, in brackets, includes either the String <c> "Unlocked" </c> or the String <c> "Locked by" </c> followed by the  Thread::getName name} of the owning thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string identifying this lock, as well as its lock state </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Queries the number of holds on this lock by the current thread.</para><para>A thread has a hold on a lock for each lock action that is not matched by an unlock action.</para><para>The hold count information is typically only used for testing and debugging purposes. For example, if a certain section of code should not be entered with the lock already held then we can assert that fact:</para><para><pre>        class X {
				/// 
				///          ReentrantLock lock = new ReentrantLock();
				/// 
				///          // ...
				/// 
				///          public void m() {
				/// 
				///            assert lock.getHoldCount() == 0;
				/// 
				///            lock.lock();
				/// 
				///            try {
				/// 
				///              // ... method body
				/// 
				///            } finally {
				/// 
				///              lock.unlock();
				/// 
				///            }
				/// 
				///          }
				/// 
				///        } 
				/// 
				///  </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of holds on this lock by the current thread, or zero if this lock is not held by the current thread </para>
				/// </returns>
				/// <java-name>
				/// getHoldCount
				/// </java-name>
				public int HoldCount
				{
				[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
						get{ return GetHoldCount(); }
				}

				/// <summary>
				/// <para>Returns the thread that currently owns this lock, or <c> null </c> if not owned. When this method is called by a thread that is not the owner, the return value reflects a best-effort approximation of current lock status. For example, the owner may be momentarily <c> null </c> even if there are threads trying to acquire the lock but have not yet done so. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the owner, or <c> null </c> if not owned </para>
				/// </returns>
				/// <java-name>
				/// getOwner
				/// </java-name>
				protected internal global::System.Threading.Thread Owner
				{
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
						get{ return GetOwner(); }
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire this lock. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire this lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

		}

		/// <summary>
		/// <para>Provides a framework for implementing blocking locks and related synchronizers (semaphores, events, etc) that rely on first-in-first-out (FIFO) wait queues. This class is designed to be a useful basis for most kinds of synchronizers that rely on a single atomic <code>int</code> value to represent state. Subclasses must define the protected methods that change this state, and which define what that state means in terms of this object being acquired or released. Given these, the other methods in this class carry out all queuing and blocking mechanics. Subclasses can maintain other state fields, but only the atomically updated <code>int</code> value manipulated using methods getState, setState and compareAndSetState is tracked with respect to synchronization.</para><para>Subclasses should be defined as non-public internal helper classes that are used to implement the synchronization properties of their enclosing class. Class <code>AbstractQueuedSynchronizer</code> does not implement any synchronization interface. Instead it defines methods such as acquireInterruptibly that can be invoked as appropriate by concrete locks and related synchronizers to implement their public methods.</para><para>This class supports either or both a default <b>exclusive</b> mode and a <b>shared</b> mode. When acquired in exclusive mode, attempted acquires by other threads cannot succeed. Shared mode acquires by multiple threads may (but need not) succeed. This class does not "understand" these differences except in the mechanical sense that when a shared mode acquire succeeds, the next waiting thread (if one exists) must also determine whether it can acquire as well. Threads waiting in the different modes share the same FIFO queue. Usually, implementation subclasses support only one of these modes, but both can come into play for example in a ReadWriteLock. Subclasses that support only exclusive or only shared modes need not define the methods supporting the unused mode.</para><para>This class defines a nested ConditionObject class that can be used as a Condition implementation by subclasses supporting exclusive mode for which method isHeldExclusively reports whether synchronization is exclusively held with respect to the current thread, method release invoked with the current getState value fully releases this object, and acquire, given this saved state value, eventually restores this object to its previous acquired state. No <code>AbstractQueuedSynchronizer</code> method otherwise creates such a condition, so if this constraint cannot be met, do not use it. The behavior of ConditionObject depends of course on the semantics of its synchronizer implementation.</para><para>This class provides inspection, instrumentation, and monitoring methods for the internal queue, as well as similar methods for condition objects. These can be exported as desired into classes using an <code>AbstractQueuedSynchronizer</code> for their synchronization mechanics.</para><para>Serialization of this class stores only the underlying atomic integer maintaining state, so deserialized objects have empty thread queues. Typical subclasses requiring serializability will define a <code>readObject</code> method that restores this to a known initial state upon deserialization.</para><para><h3>Usage</h3></para><para>To use this class as the basis of a synchronizer, redefine the following methods, as applicable, by inspecting and/or modifying the synchronization state using getState, setState and/or compareAndSetState:</para><para><ul><li><para>tryAcquire </para></li><li><para>tryRelease </para></li><li><para>tryAcquireShared </para></li><li><para>tryReleaseShared </para></li><li><para>isHeldExclusively </para></li></ul></para><para>Each of these methods by default throws UnsupportedOperationException. Implementations of these methods must be internally thread-safe, and should in general be short and not block. Defining these methods is the <b>only</b> supported means of using this class. All other methods are declared <code>final</code> because they cannot be independently varied.</para><para>You may also find the inherited methods from AbstractOwnableSynchronizer useful to keep track of the thread owning an exclusive synchronizer. You are encouraged to use them  this enables monitoring and diagnostic tools to assist users in determining which threads hold locks.</para><para>Even though this class is based on an internal FIFO queue, it does not automatically enforce FIFO acquisition policies. The core of exclusive synchronization takes the form:</para><para><pre>
		///    Acquire:
		///        while (!tryAcquire(arg)) {
		///           <b>enqueue thread if it is not already queued</b>;
		///           <b>possibly block current thread</b>;
		///        }
		/// 
		///    Release:
		///        if (tryRelease(arg))
		///           <b>unblock the first queued thread</b>;
		///    </pre></para><para>(Shared mode is similar but may involve cascading signals.)</para><para>Because checks in acquire are invoked before enqueuing, a newly acquiring thread may <b>barge</b> ahead of others that are blocked and queued. However, you can, if desired, define <code>tryAcquire</code> and/or <code>tryAcquireShared</code> to disable barging by internally invoking one or more of the inspection methods. In particular, a strict FIFO lock can define <code>tryAcquire</code> to immediately return <code>false</code> if getFirstQueuedThread does not return the current thread. A normally preferable non-strict fair version can immediately return <code>false</code> only if hasQueuedThreads returns <code>true</code> and <code>getFirstQueuedThread</code> is not the current thread; or equivalently, that <code>getFirstQueuedThread</code> is both non-null and not the current thread. Further variations are possible.</para><para>Throughput and scalability are generally highest for the default barging (also known as <b>greedy</b>, <b>renouncement</b>, and <b>convoy-avoidance</b>) strategy. While this is not guaranteed to be fair or starvation-free, earlier queued threads are allowed to recontend before later queued threads, and each recontention has an unbiased chance to succeed against incoming threads. Also, while acquires do not "spin" in the usual sense, they may perform multiple invocations of <code>tryAcquire</code> interspersed with other computations before blocking. This gives most of the benefits of spins when exclusive synchronization is only briefly held, without most of the liabilities when it isn't. If so desired, you can augment this by preceding calls to acquire methods with "fast-path" checks, possibly prechecking hasContended and/or hasQueuedThreads to only do so if the synchronizer is likely not to be contended.</para><para>This class provides an efficient and scalable basis for synchronization in part by specializing its range of use to synchronizers that can rely on <code>int</code> state, acquire, and release parameters, and an internal FIFO wait queue. When this does not suffice, you can build synchronizers from a lower level using atomic classes, your own custom java.util.Queue classes, and LockSupport blocking support.</para><para><h3>Usage Examples</h3></para><para>Here is a non-reentrant mutual exclusion lock class that uses the value zero to represent the unlocked state, and one to represent the locked state. While a non-reentrant lock does not strictly require recording of the current owner thread, this class does so anyway to make usage easier to monitor. It also supports conditions and exposes one of the instrumentation methods:</para><para><pre>    class Mutex implements Lock, java.io.Serializable {
		/// 
		///   
		/// 
		///      // Our internal helper class
		/// 
		///      private static class Sync extends AbstractQueuedSynchronizer {
		/// 
		///        // Report whether in locked state
		/// 
		///        protected boolean isHeldExclusively() {
		/// 
		///          return getState() == 1;
		/// 
		///        }
		/// 
		///   
		/// 
		///        // Acquire the lock if state is zero
		/// 
		///        public boolean tryAcquire(int acquires) {
		/// 
		///          assert acquires == 1; // Otherwise unused
		/// 
		///          if (compareAndSetState(0, 1)) {
		/// 
		///            setExclusiveOwnerThread(Thread.currentThread());
		/// 
		///            return true;
		/// 
		///          }
		/// 
		///          return false;
		/// 
		///        }
		/// 
		///   
		/// 
		///        // Release the lock by setting state to zero
		/// 
		///        protected boolean tryRelease(int releases) {
		/// 
		///          assert releases == 1; // Otherwise unused
		/// 
		///          if (getState() == 0) throw new IllegalMonitorStateException();
		/// 
		///          setExclusiveOwnerThread(null);
		/// 
		///          setState(0);
		/// 
		///          return true;
		/// 
		///        }
		/// 
		///   
		/// 
		///        // Provide a Condition
		/// 
		///        Condition newCondition() { return new ConditionObject(); }
		/// 
		///   
		/// 
		///        // Deserialize properly
		/// 
		///        private void readObject(ObjectInputStream s)
		/// 
		///            throws IOException, ClassNotFoundException {
		/// 
		///          s.defaultReadObject();
		/// 
		///          setState(0); // reset to unlocked state
		/// 
		///        }
		/// 
		///      }
		/// 
		///   
		/// 
		///      // The sync object does all the hard work. We just forward to it.
		/// 
		///      private final Sync sync = new Sync();
		/// 
		///   
		/// 
		///      public void lock()                { sync.acquire(1); }
		/// 
		///      public boolean tryLock()          { return sync.tryAcquire(1); }
		/// 
		///      public void unlock()              { sync.release(1); }
		/// 
		///      public Condition newCondition()   { return sync.newCondition(); }
		/// 
		///      public boolean isLocked()         { return sync.isHeldExclusively(); }
		/// 
		///      public boolean hasQueuedThreads() { return sync.hasQueuedThreads(); }
		/// 
		///      public void lockInterruptibly() throws InterruptedException {
		/// 
		///        sync.acquireInterruptibly(1);
		/// 
		///      }
		/// 
		///      public boolean tryLock(long timeout, TimeUnit unit)
		/// 
		///          throws InterruptedException {
		/// 
		///        return sync.tryAcquireNanos(1, unit.toNanos(timeout));
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre></para><para>Here is a latch class that is like a CountDownLatch except that it only requires a single <code>signal</code> to fire. Because a latch is non-exclusive, it uses the <code>shared</code> acquire and release methods.</para><para><pre>    class BooleanLatch {
		/// 
		///   
		/// 
		///      private static class Sync extends AbstractQueuedSynchronizer {
		/// 
		///        boolean isSignalled() { return getState() != 0; }
		/// 
		///   
		/// 
		///        protected int tryAcquireShared(int ignore) {
		/// 
		///          return isSignalled() ? 1 : -1;
		/// 
		///        }
		/// 
		///   
		/// 
		///        protected boolean tryReleaseShared(int ignore) {
		/// 
		///          setState(1);
		/// 
		///          return true;
		/// 
		///        }
		/// 
		///      }
		/// 
		///   
		/// 
		///      private final Sync sync = new Sync();
		/// 
		///      public boolean isSignalled() { return sync.isSignalled(); }
		/// 
		///      public void signal()         { sync.releaseShared(1); }
		/// 
		///      public void await() throws InterruptedException {
		/// 
		///        sync.acquireSharedInterruptibly(1);
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre></para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/AbstractQueuedSynchronizer
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/AbstractQueuedSynchronizer", AccessFlags = 1057)]
		public abstract partial class AbstractQueuedSynchronizer : global::Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>AbstractQueuedSynchronizer</code> instance with initial synchronization state of zero. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractQueuedSynchronizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of synchronization state. This operation has memory semantics of a <code>volatile</code> read. </para>        
				/// </summary>
				/// <returns>
				/// <para>current state value </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 20)]
				protected internal int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the value of synchronization state. This operation has memory semantics of a <code>volatile</code> write. </para>        
				/// </summary>
				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(I)V", AccessFlags = 20)]
				protected internal void SetState(int newState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets synchronization state to the given updated value if the current state value equals the expected value. This operation has memory semantics of a <code>volatile</code> read and write.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSetState
				/// </java-name>
				[Dot42.DexImport("compareAndSetState", "(II)Z", AccessFlags = 20)]
				protected internal bool CompareAndSetState(int expect, int update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to acquire in exclusive mode. This method should query if the state of the object permits it to be acquired in the exclusive mode, and if so to acquire it.</para><para>This method is always invoked by the thread performing acquire. If this method reports failure, the acquire method may queue the thread, if it is not already queued, until it is signalled by a release from some other thread. This can be used to implement method Lock#tryLock().</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if successful. Upon success, this object has been acquired. </para>
				/// </returns>
				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool TryAcquire(int arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to set the state to reflect a release in exclusive mode.</para><para>This method is always invoked by the thread performing release.</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this object is now in a fully released state, so that any waiting threads may attempt to acquire; and <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// tryRelease
				/// </java-name>
				[Dot42.DexImport("tryRelease", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool TryRelease(int arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to acquire in shared mode. This method should query if the state of the object permits it to be acquired in the shared mode, and if so to acquire it.</para><para>This method is always invoked by the thread performing acquire. If this method reports failure, the acquire method may queue the thread, if it is not already queued, until it is signalled by a release from some other thread.</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value on failure; zero if acquisition in shared mode succeeded but no subsequent shared-mode acquire can succeed; and a positive value if acquisition in shared mode succeeded and subsequent shared-mode acquires might also succeed, in which case a subsequent waiting thread must check availability. (Support for three different return values enables this method to be used in contexts where acquires only sometimes act exclusively.) Upon success, this object has been acquired. </para>
				/// </returns>
				/// <java-name>
				/// tryAcquireShared
				/// </java-name>
				[Dot42.DexImport("tryAcquireShared", "(I)I", AccessFlags = 4)]
				protected internal virtual int TryAcquireShared(int arg) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Attempts to set the state to reflect a release in shared mode.</para><para>This method is always invoked by the thread performing release.</para><para>The default implementation throws UnsupportedOperationException.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this release of shared mode may permit a waiting acquire (shared or exclusive) to succeed; and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// tryReleaseShared
				/// </java-name>
				[Dot42.DexImport("tryReleaseShared", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool TryReleaseShared(int arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if synchronization is held exclusively with respect to the current (calling) thread. This method is invoked upon each call to a non-waiting ConditionObject method. (Waiting methods instead invoke release.)</para><para>The default implementation throws UnsupportedOperationException. This method is invoked internally only within ConditionObject methods, so need not be defined if conditions are not used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if synchronization is held exclusively; <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isHeldExclusively
				/// </java-name>
				[Dot42.DexImport("isHeldExclusively", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsHeldExclusively() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Acquires in exclusive mode, ignoring interrupts. Implemented by invoking at least once tryAcquire, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquire until success. This method can be used to implement method Lock#lock.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(I)V", AccessFlags = 17)]
				public void Acquire(int arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires in exclusive mode, aborting if interrupted. Implemented by first checking interrupt status, then invoking at least once tryAcquire, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquire until success or the thread is interrupted. This method can be used to implement method Lock#lockInterruptibly.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquireInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireInterruptibly", "(I)V", AccessFlags = 17)]
				public void AcquireInterruptibly(int arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to acquire in exclusive mode, aborting if interrupted, and failing if the given timeout elapses. Implemented by first checking interrupt status, then invoking at least once tryAcquire, returning on success. Otherwise, the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquire until success or the thread is interrupted or the timeout elapses. This method can be used to implement method Lock#tryLock(long, TimeUnit).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if acquired; <c> false </c> if timed out </para>
				/// </returns>
				/// <java-name>
				/// tryAcquireNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireNanos", "(IJ)Z", AccessFlags = 17)]
				public bool TryAcquireNanos(int arg, long nanosTimeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases in exclusive mode. Implemented by unblocking one or more threads if tryRelease returns true. This method can be used to implement method Lock#unlock.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value returned from tryRelease </para>
				/// </returns>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(I)Z", AccessFlags = 17)]
				public bool Release(int arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Acquires in shared mode, ignoring interrupts. Implemented by first invoking at least once tryAcquireShared, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquireShared until success.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquireShared
				/// </java-name>
				[Dot42.DexImport("acquireShared", "(I)V", AccessFlags = 17)]
				public void AcquireShared(int arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires in shared mode, aborting if interrupted. Implemented by first checking interrupt status, then invoking at least once tryAcquireShared, returning on success. Otherwise the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquireShared until success or the thread is interrupted. </para>        
				/// </summary>
				/// <java-name>
				/// acquireSharedInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireSharedInterruptibly", "(I)V", AccessFlags = 17)]
				public void AcquireSharedInterruptibly(int arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to acquire in shared mode, aborting if interrupted, and failing if the given timeout elapses. Implemented by first checking interrupt status, then invoking at least once tryAcquireShared, returning on success. Otherwise, the thread is queued, possibly repeatedly blocking and unblocking, invoking tryAcquireShared until success or the thread is interrupted or the timeout elapses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if acquired; <c> false </c> if timed out </para>
				/// </returns>
				/// <java-name>
				/// tryAcquireSharedNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireSharedNanos", "(IJ)Z", AccessFlags = 17)]
				public bool TryAcquireSharedNanos(int arg, long nanosTimeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases in shared mode. Implemented by unblocking one or more threads if tryReleaseShared returns true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value returned from tryReleaseShared </para>
				/// </returns>
				/// <java-name>
				/// releaseShared
				/// </java-name>
				[Dot42.DexImport("releaseShared", "(I)Z", AccessFlags = 17)]
				public bool ReleaseShared(int arg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting to acquire. Note that because cancellations due to interrupts and timeouts may occur at any time, a <c> true </c> return does not guarantee that any other thread will ever acquire.</para><para>In this implementation, this operation returns in constant time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there may be other threads waiting to acquire </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether any threads have ever contended to acquire this synchronizer; that is if an acquire method has ever blocked.</para><para>In this implementation, this operation returns in constant time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there has ever been contention </para>
				/// </returns>
				/// <java-name>
				/// hasContended
				/// </java-name>
				[Dot42.DexImport("hasContended", "()Z", AccessFlags = 17)]
				public bool HasContended() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued.</para><para>In this implementation, this operation normally returns in constant time, but may iterate upon contention if other threads are concurrently modifying the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued </para>
				/// </returns>
				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
				public global::System.Threading.Thread GetFirstQueuedThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <summary>
				/// <para>Returns true if the given thread is currently queued.</para><para>This implementation traverses the queue to determine presence of the given thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given thread is on the queue </para>
				/// </returns>
				/// <java-name>
				/// isQueued
				/// </java-name>
				[Dot42.DexImport("isQueued", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool IsQueued(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting to acquire </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in exclusive mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to an exclusive acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetExclusiveQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in shared mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to a shared acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetSharedQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a string identifying this synchronizer, as well as its state. The state, in brackets, includes the String <c> "State =" </c> followed by the current value of getState, and either <c> "nonempty" </c> or <c> "empty" </c> depending on whether the queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string identifying this synchronizer, as well as its state </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Queries whether the given ConditionObject uses this synchronizer as its lock.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if owned </para>
				/// </returns>
				/// <java-name>
				/// owns
				/// </java-name>
				[Dot42.DexImport("owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool Owns(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting on the given condition associated with this synchronizer. Note that because timeouts and interrupts may occur at any time, a <code>true</code> return does not guarantee that a future <code>signal</code> will awaken any threads. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there are any waiting threads </para>
				/// </returns>
				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool HasWaiters(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting on the given condition associated with this synchronizer. Note that because timeouts and interrupts may occur at any time, the estimate serves only as an upper bound on the actual number of waiters. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of waiting threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I", AccessFlags = 17)]
				public int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing those threads that may be waiting on the given condition associated with this synchronizer. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/ut" +
    "il/Collection;", AccessFlags = 17, Signature = "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/ut" +
    "il/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject condition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns the current value of synchronization state. This operation has memory semantics of a <code>volatile</code> read. </para>        
				/// </summary>
				/// <returns>
				/// <para>current state value </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				protected internal int State
				{
				[Dot42.DexImport("getState", "()I", AccessFlags = 20)]
						get{ return GetState(); }
				[Dot42.DexImport("setState", "(I)V", AccessFlags = 20)]
						set{ SetState(value); }
				}

				/// <summary>
				/// <para>Returns the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued.</para><para>In this implementation, this operation normally returns in constant time, but may iterate upon contention if other threads are concurrently modifying the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first (longest-waiting) thread in the queue, or <c> null </c> if no threads are currently queued </para>
				/// </returns>
				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				public global::System.Threading.Thread FirstQueuedThread
				{
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
						get{ return GetFirstQueuedThread(); }
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting to acquire </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in exclusive mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to an exclusive acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> ExclusiveQueuedThreads
				{
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetExclusiveQueuedThreads(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire in shared mode. This has the same properties as getQueuedThreads except that it only returns those threads waiting due to a shared acquire.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> SharedQueuedThreads
				{
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetSharedQueuedThreads(); }
				}

				/// <summary>
				/// <para>Condition implementation for a AbstractQueuedSynchronizer serving as the basis of a Lock implementation.</para><para>Method documentation for this class describes mechanics, not behavioral specifications from the point of view of Lock and Condition users. Exported versions of this class will in general need to be accompanied by documentation describing condition semantics that rely on those of the associated <code>AbstractQueuedSynchronizer</code>.</para><para>This class is Serializable, but all fields are transient, so deserialized conditions have no waiters. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject", AccessFlags = 1)]
				public partial class ConditionObject : global::Java.Util.Concurrent.Locks.ICondition, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Ljava/util/concurrent/locks/AbstractQueuedSynchronizer;", AccessFlags = 4112)]
						internal readonly global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer This_0;
						[Dot42.DexImport("<init>", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer;)V", AccessFlags = 1)]
						public ConditionObject(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer abstractQueuedSynchronizer) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Moves the longest-waiting thread, if one exists, from the wait queue for this condition to the wait queue for the owning lock.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// signal
						/// </java-name>
						[Dot42.DexImport("signal", "()V", AccessFlags = 17)]
						public void Signal() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Moves all threads from the wait queue for this condition to the wait queue for the owning lock.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// signalAll
						/// </java-name>
						[Dot42.DexImport("signalAll", "()V", AccessFlags = 17)]
						public void SignalAll() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Implements uninterruptible condition wait. <ol><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// awaitUninterruptibly
						/// </java-name>
						[Dot42.DexImport("awaitUninterruptibly", "()V", AccessFlags = 17)]
						public void AwaitUninterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Implements interruptible condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled or interrupted. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "()V", AccessFlags = 17)]
						public void Await() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Implements timed condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled, interrupted, or timed out. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// awaitNanos
						/// </java-name>
						[Dot42.DexImport("awaitNanos", "(J)J", AccessFlags = 17)]
						public long AwaitNanos(long nanosTimeout) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Implements absolute timed condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled, interrupted, or timed out. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li><li><para>If timed out while blocked in step 4, return false, else true. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// awaitUntil
						/// </java-name>
						[Dot42.DexImport("awaitUntil", "(Ljava/util/Date;)Z", AccessFlags = 17)]
						public bool AwaitUntil(global::Java.Util.Date deadline) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Implements timed condition wait. <ol><li><para>If current thread is interrupted, throw InterruptedException. </para></li><li><para>Save lock state returned by getState. </para></li><li><para>Invoke release with saved state as argument, throwing IllegalMonitorStateException if it fails. </para></li><li><para>Block until signalled, interrupted, or timed out. </para></li><li><para>Reacquire by invoking specialized version of acquire with saved state as argument. </para></li><li><para>If interrupted while blocked in step 4, throw InterruptedException. </para></li><li><para>If timed out while blocked in step 4, return false, else true. </para></li></ol></para>        
						/// </summary>
						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 17)]
						public bool Await(long time, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Queries whether any threads are waiting on this condition. Implements AbstractQueuedSynchronizer#hasWaiters.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if there are any waiting threads </para>
						/// </returns>
						/// <java-name>
						/// hasWaiters
						/// </java-name>
						[Dot42.DexImport("hasWaiters", "()Z", AccessFlags = 20)]
						protected internal bool HasWaiters() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns an estimate of the number of threads waiting on this condition. Implements AbstractQueuedSynchronizer#getWaitQueueLength.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the estimated number of waiting threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
						protected internal int GetWaitQueueLength() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns a collection containing those threads that may be waiting on this Condition. Implements AbstractQueuedSynchronizer#getWaitingThreads.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the collection of threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitingThreads
						/// </java-name>
						[Dot42.DexImport("getWaitingThreads", "()Ljava/util/Collection;", AccessFlags = 20, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						protected internal global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ConditionObject() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns an estimate of the number of threads waiting on this condition. Implements AbstractQueuedSynchronizer#getWaitQueueLength.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the estimated number of waiting threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						protected internal int WaitQueueLength
						{
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
								get{ return GetWaitQueueLength(); }
						}

						/// <summary>
						/// <para>Returns a collection containing those threads that may be waiting on this Condition. Implements AbstractQueuedSynchronizer#getWaitingThreads.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the collection of threads </para>
						/// </returns>
						/// <java-name>
						/// getWaitingThreads
						/// </java-name>
						protected internal global::Java.Util.ICollection<global::System.Threading.Thread> WaitingThreads
						{
						[Dot42.DexImport("getWaitingThreads", "()Ljava/util/Collection;", AccessFlags = 20, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
								get{ return GetWaitingThreads(); }
						}

				}

		}

		/// <summary>
		/// <para>An implementation of ReadWriteLock supporting similar semantics to ReentrantLock. </para><para>This class has the following properties:</para><para><ul><li><para><b>Acquisition order</b></para><para></para><para>This class does not impose a reader or writer preference ordering for lock access. However, it does support an optional <b>fairness</b> policy.</para><para></para><para></para></li><li><para><b>Reentrancy</b></para><para></para><para>This lock allows both readers and writers to reacquire read or write locks in the style of a ReentrantLock. Non-reentrant readers are not allowed until all write locks held by the writing thread have been released.</para><para></para><para>Additionally, a writer can acquire the read lock, but not vice-versa. Among other applications, reentrancy can be useful when write locks are held during calls or callbacks to methods that perform reads under read locks. If a reader tries to acquire the write lock it will never succeed.</para><para></para></li><li><para><b>Lock downgrading</b> </para><para>Reentrancy also allows downgrading from the write lock to a read lock, by acquiring the write lock, then the read lock and then releasing the write lock. However, upgrading from a read lock to the write lock is <b>not</b> possible.</para><para></para></li><li><para><b>Interruption of lock acquisition</b> </para><para>The read lock and write lock both support interruption during lock acquisition.</para><para></para></li><li><para><b>Condition support</b> </para><para>The write lock provides a Condition implementation that behaves in the same way, with respect to the write lock, as the Condition implementation provided by ReentrantLock#newCondition does for ReentrantLock. This Condition can, of course, only be used with the write lock.</para><para></para><para>The read lock does not support a Condition and <c> readLock().newCondition() </c> throws <c> UnsupportedOperationException </c> .</para><para></para></li><li><para><b>Instrumentation</b> </para><para>This class supports methods to determine whether locks are held or contended. These methods are designed for monitoring system state, not for synchronization control. </para></li></ul></para><para>Serialization of this class behaves in the same way as built-in locks: a deserialized lock is in the unlocked state, regardless of its state when serialized.</para><para><b>Sample usages</b>. Here is a code sketch showing how to perform lock downgrading after updating a cache (exception handling is particularly tricky when handling multiple locks in a non-nested fashion):</para><para><pre>    class CachedData {
		/// 
		///      Object data;
		/// 
		///      volatile boolean cacheValid;
		/// 
		///      final ReentrantReadWriteLock rwl = new ReentrantReadWriteLock();
		/// 
		///   
		/// 
		///      void processCachedData() {
		/// 
		///        rwl.readLock().lock();
		/// 
		///        if (!cacheValid) {
		/// 
		///          // Must release read lock before acquiring write lock
		/// 
		///          rwl.readLock().unlock();
		/// 
		///          rwl.writeLock().lock();
		/// 
		///          try {
		/// 
		///            // Recheck state because another thread might have
		/// 
		///            // acquired write lock and changed state before we did.
		/// 
		///            if (!cacheValid) {
		/// 
		///              data = ...
		/// 
		///              cacheValid = true;
		/// 
		///            }
		/// 
		///            // Downgrade by acquiring read lock before releasing write lock
		/// 
		///            rwl.readLock().lock();
		/// 
		///          } finally {
		/// 
		///            rwl.writeLock().unlock(); // Unlock write, still hold read
		/// 
		///          }
		/// 
		///        }
		/// 
		///   
		/// 
		///        try {
		/// 
		///          use(data);
		/// 
		///        } finally {
		/// 
		///          rwl.readLock().unlock();
		/// 
		///        }
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre></para><para>ReentrantReadWriteLocks can be used to improve concurrency in some uses of some kinds of Collections. This is typically worthwhile only when the collections are expected to be large, accessed by more reader threads than writer threads, and entail operations with overhead that outweighs synchronization overhead. For example, here is a class using a TreeMap that is expected to be large and concurrently accessed.</para><para><pre>    class RWDictionary {
		/// 
		///      private final Map&lt;String, Data&gt; m = new TreeMap&lt;String, Data&gt;();
		/// 
		///      private final ReentrantReadWriteLock rwl = new ReentrantReadWriteLock();
		/// 
		///      private final Lock r = rwl.readLock();
		/// 
		///      private final Lock w = rwl.writeLock();
		/// 
		///   
		/// 
		///      public Data get(String key) {
		/// 
		///        r.lock();
		/// 
		///        try { return m.get(key); }
		/// 
		///        finally { r.unlock(); }
		/// 
		///      }
		/// 
		///      public String[] allKeys() {
		/// 
		///        r.lock();
		/// 
		///        try { return m.keySet().toArray(); }
		/// 
		///        finally { r.unlock(); }
		/// 
		///      }
		/// 
		///      public Data put(String key, Data value) {
		/// 
		///        w.lock();
		/// 
		///        try { return m.put(key, value); }
		/// 
		///        finally { w.unlock(); }
		/// 
		///      }
		/// 
		///      public void clear() {
		/// 
		///        w.lock();
		/// 
		///        try { m.clear(); }
		/// 
		///        finally { w.unlock(); }
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre></para><para><h3>Implementation Notes</h3></para><para>This lock supports a maximum of 65535 recursive write locks and 65535 read locks. Attempts to exceed these limits result in Error throws from locking methods.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/ReentrantReadWriteLock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/ReentrantReadWriteLock", AccessFlags = 33)]
		public partial class ReentrantReadWriteLock : global::Java.Util.Concurrent.Locks.IReadWriteLock, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ReentrantReadWriteLock </c> with default (nonfair) ordering properties. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReentrantReadWriteLock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> ReentrantReadWriteLock </c> with the given fairness policy.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ReentrantReadWriteLock(bool fair) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the lock used for writing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the lock used for writing. </para>
				/// </returns>
				/// <java-name>
				/// writeLock
				/// </java-name>
				[Dot42.DexImport("writeLock", "()Ljava/util/concurrent/locks/ReentrantReadWriteLock$WriteLock;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaWriteLock WriteLock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaWriteLock);
				}

				/// <summary>
				/// <para>Returns the lock used for reading.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the lock used for reading. </para>
				/// </returns>
				/// <java-name>
				/// readLock
				/// </java-name>
				[Dot42.DexImport("readLock", "()Ljava/util/concurrent/locks/ReentrantReadWriteLock$ReadLock;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaReadLock ReadLock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaReadLock);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if this lock has fairness set true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this lock has fairness set true </para>
				/// </returns>
				/// <java-name>
				/// isFair
				/// </java-name>
				[Dot42.DexImport("isFair", "()Z", AccessFlags = 17)]
				public bool IsFair() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the thread that currently owns the write lock, or <c> null </c> if not owned. When this method is called by a thread that is not the owner, the return value reflects a best-effort approximation of current lock status. For example, the owner may be momentarily <c> null </c> even if there are threads trying to acquire the lock but have not yet done so. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the owner, or <c> null </c> if not owned </para>
				/// </returns>
				/// <java-name>
				/// getOwner
				/// </java-name>
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
				protected internal virtual global::System.Threading.Thread GetOwner() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <summary>
				/// <para>Queries the number of read locks held for this lock. This method is designed for use in monitoring system state, not for synchronization control. </para>        
				/// </summary>
				/// <returns>
				/// <para>the number of read locks held. </para>
				/// </returns>
				/// <java-name>
				/// getReadLockCount
				/// </java-name>
				[Dot42.DexImport("getReadLockCount", "()I", AccessFlags = 1)]
				public virtual int GetReadLockCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Queries if the write lock is held by any thread. This method is designed for use in monitoring system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if any thread holds the write lock and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isWriteLocked
				/// </java-name>
				[Dot42.DexImport("isWriteLocked", "()Z", AccessFlags = 1)]
				public virtual bool IsWriteLocked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries if the write lock is held by the current thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the current thread holds the write lock and <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isWriteLockedByCurrentThread
				/// </java-name>
				[Dot42.DexImport("isWriteLockedByCurrentThread", "()Z", AccessFlags = 1)]
				public virtual bool IsWriteLockedByCurrentThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries the number of reentrant write holds on this lock by the current thread. A writer thread has a hold on a lock for each lock action that is not matched by an unlock action.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of holds on the write lock by the current thread, or zero if the write lock is not held by the current thread </para>
				/// </returns>
				/// <java-name>
				/// getWriteHoldCount
				/// </java-name>
				[Dot42.DexImport("getWriteHoldCount", "()I", AccessFlags = 1)]
				public virtual int GetWriteHoldCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Queries the number of reentrant read holds on this lock by the current thread. A reader thread has a hold on a lock for each lock action that is not matched by an unlock action.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of holds on the read lock by the current thread, or zero if the read lock is not held by the current thread </para>
				/// </returns>
				/// <java-name>
				/// getReadHoldCount
				/// </java-name>
				[Dot42.DexImport("getReadHoldCount", "()I", AccessFlags = 1)]
				public virtual int GetReadHoldCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire the write lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedWriterThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedWriterThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedWriterThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire the read lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedReaderThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedReaderThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedReaderThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting to acquire the read or write lock. Note that because cancellations may occur at any time, a <c> true </c> return does not guarantee that any other thread will ever acquire a lock. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there may be other threads waiting to acquire the lock </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Queries whether the given thread is waiting to acquire either the read or write lock. Note that because cancellations may occur at any time, a <c> true </c> return does not guarantee that this thread will ever acquire a lock. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given thread is queued waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThread
				/// </java-name>
				[Dot42.DexImport("hasQueuedThread", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool HasQueuedThread(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire either the read or write lock. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire either the read or write lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Queries whether any threads are waiting on the given condition associated with the write lock. Note that because timeouts and interrupts may occur at any time, a <c> true </c> return does not guarantee that a future <c> signal </c> will awaken any threads. This method is designed primarily for use in monitoring of the system state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there are any waiting threads </para>
				/// </returns>
				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", AccessFlags = 1)]
				public virtual bool HasWaiters(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting on the given condition associated with the write lock. Note that because timeouts and interrupts may occur at any time, the estimate serves only as an upper bound on the actual number of waiters. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of waiting threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", AccessFlags = 1)]
				public virtual int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a collection containing those threads that may be waiting on the given condition associated with the write lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive condition monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", AccessFlags = 4, Signature = "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection<Ljava/lang/Thread;>" +
    ";")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <summary>
				/// <para>Returns a string identifying this lock, as well as its lock state. The state, in brackets, includes the String <c> "Write locks =" </c> followed by the number of reentrantly held write locks, and the String <c> "Read locks =" </c> followed by the number of held read locks.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string identifying this lock, as well as its lock state </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[Dot42.DexImport("java/util/concurrent/locks/ReadWriteLock", "readLock", "()Ljava/util/concurrent/locks/Lock;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ILock global::Java.Util.Concurrent.Locks.IReadWriteLock.ReadLock() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ILock);
				}

				[Dot42.DexImport("java/util/concurrent/locks/ReadWriteLock", "writeLock", "()Ljava/util/concurrent/locks/Lock;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ILock global::Java.Util.Concurrent.Locks.IReadWriteLock.WriteLock() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ILock);
				}

				/// <summary>
				/// <para>Returns the thread that currently owns the write lock, or <c> null </c> if not owned. When this method is called by a thread that is not the owner, the return value reflects a best-effort approximation of current lock status. For example, the owner may be momentarily <c> null </c> even if there are threads trying to acquire the lock but have not yet done so. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the owner, or <c> null </c> if not owned </para>
				/// </returns>
				/// <java-name>
				/// getOwner
				/// </java-name>
				protected internal global::System.Threading.Thread Owner
				{
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
						get{ return GetOwner(); }
				}

				/// <summary>
				/// <para>Queries the number of read locks held for this lock. This method is designed for use in monitoring system state, not for synchronization control. </para>        
				/// </summary>
				/// <returns>
				/// <para>the number of read locks held. </para>
				/// </returns>
				/// <java-name>
				/// getReadLockCount
				/// </java-name>
				public int ReadLockCount
				{
				[Dot42.DexImport("getReadLockCount", "()I", AccessFlags = 1)]
						get{ return GetReadLockCount(); }
				}

				/// <summary>
				/// <para>Queries the number of reentrant write holds on this lock by the current thread. A writer thread has a hold on a lock for each lock action that is not matched by an unlock action.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of holds on the write lock by the current thread, or zero if the write lock is not held by the current thread </para>
				/// </returns>
				/// <java-name>
				/// getWriteHoldCount
				/// </java-name>
				public int WriteHoldCount
				{
				[Dot42.DexImport("getWriteHoldCount", "()I", AccessFlags = 1)]
						get{ return GetWriteHoldCount(); }
				}

				/// <summary>
				/// <para>Queries the number of reentrant read holds on this lock by the current thread. A reader thread has a hold on a lock for each lock action that is not matched by an unlock action.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of holds on the read lock by the current thread, or zero if the read lock is not held by the current thread </para>
				/// </returns>
				/// <java-name>
				/// getReadHoldCount
				/// </java-name>
				public int ReadHoldCount
				{
				[Dot42.DexImport("getReadHoldCount", "()I", AccessFlags = 1)]
						get{ return GetReadHoldCount(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire the write lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedWriterThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedWriterThreads
				{
				[Dot42.DexImport("getQueuedWriterThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedWriterThreads(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire the read lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive lock monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedReaderThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedReaderThreads
				{
				[Dot42.DexImport("getQueuedReaderThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedReaderThreads(); }
				}

				/// <summary>
				/// <para>Returns an estimate of the number of threads waiting to acquire either the read or write lock. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring of the system state, not for synchronization control.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of threads waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <summary>
				/// <para>Returns a collection containing threads that may be waiting to acquire either the read or write lock. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

				/// <summary>
				/// <para>The lock returned by method ReentrantReadWriteLock#writeLock. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock", AccessFlags = 9)]
				public partial class JavaWriteLock : global::Java.Util.Concurrent.Locks.ILock, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V", AccessFlags = 4)]
						protected internal JavaWriteLock(global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock reentrantReadWriteLock) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Acquires the write lock.</para><para>Acquires the write lock if neither the read nor write lock are held by another thread and returns immediately, setting the write lock hold count to one.</para><para>If the current thread already holds the write lock then the hold count is incremented by one and the method returns immediately.</para><para>If the lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until the write lock has been acquired, at which time the write lock hold count is set to one. </para>        
						/// </summary>
						/// <java-name>
						/// lock
						/// </java-name>
						[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
						public virtual void Lock() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Acquires the write lock unless the current thread is  Thread::interrupt interrupted}.</para><para>Acquires the write lock if neither the read nor write lock are held by another thread and returns immediately, setting the write lock hold count to one.</para><para>If the current thread already holds this lock then the hold count is incremented by one and the method returns immediately.</para><para>If the lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happens:</para><para><ul><li><para>The write lock is acquired by the current thread; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread.</para><para></para></li></ul></para><para>If the write lock is acquired by the current thread then the lock hold count is set to one.</para><para>If the current thread:</para><para><ul><li><para>has its interrupted status set on entry to this method; or</para><para></para></li><li><para>is  Thread::interrupt interrupted} while acquiring the write lock,</para><para></para></li></ul></para><para>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>In this implementation, as this method is an explicit interruption point, preference is given to responding to the interrupt over normal or reentrant acquisition of the lock.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// lockInterruptibly
						/// </java-name>
						[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1)]
						public virtual void LockInterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Acquires the write lock only if it is not held by another thread at the time of invocation.</para><para>Acquires the write lock if neither the read nor write lock are held by another thread and returns immediately with the value <c> true </c> , setting the write lock hold count to one. Even when this lock has been set to use a fair ordering policy, a call to <c> tryLock() </c> <b>will</b> immediately acquire the lock if it is available, whether or not other threads are currently waiting for the write lock. This "barging" behavior can be useful in certain circumstances, even though it breaks fairness. If you want to honor the fairness setting for this lock, then use tryLock(0, TimeUnit.SECONDS)  which is almost equivalent (it also detects interruption).</para><para>If the current thread already holds this lock then the hold count is incremented by one and the method returns <c> true </c> .</para><para>If the lock is held by another thread then this method will return immediately with the value <c> false </c> .</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the lock was free and was acquired by the current thread, or the write lock was already held by the current thread; and <c> false </c> otherwise. </para>
						/// </returns>
						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1)]
						public virtual bool TryLock() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Acquires the write lock if it is not held by another thread within the given waiting time and the current thread has not been  Thread::interrupt interrupted}.</para><para>Acquires the write lock if neither the read nor write lock are held by another thread and returns immediately with the value <c> true </c> , setting the write lock hold count to one. If this lock has been set to use a fair ordering policy then an available lock <b>will not</b> be acquired if any other threads are waiting for the write lock. This is in contrast to the tryLock() method. If you want a timed <c> tryLock </c> that does permit barging on a fair lock then combine the timed and un-timed forms together:</para><para><pre>            if (lock.tryLock() ||
						/// 
						///                lock.tryLock(timeout, unit)) {
						/// 
						///              ...
						/// 
						///            } 
						/// 
						///  </pre></para><para>If the current thread already holds this lock then the hold count is incremented by one and the method returns <c> true </c> .</para><para>If the lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:</para><para><ul><li><para>The write lock is acquired by the current thread; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified waiting time elapses</para><para></para></li></ul></para><para>If the write lock is acquired then the value <c> true </c> is returned and the write lock hold count is set to one.</para><para>If the current thread:</para><para><ul><li><para>has its interrupted status set on entry to this method; or</para><para></para></li><li><para>is  Thread::interrupt interrupted} while acquiring the write lock,</para><para></para></li></ul></para><para>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>If the specified waiting time elapses then the value <c> false </c> is returned. If the time is less than or equal to zero, the method will not wait at all.</para><para>In this implementation, as this method is an explicit interruption point, preference is given to responding to the interrupt over normal or reentrant acquisition of the lock, and over reporting the elapse of the waiting time.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the lock was free and was acquired by the current thread, or the write lock was already held by the current thread; and <c> false </c> if the waiting time elapsed before the lock could be acquired.</para>
						/// </returns>
						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
						public virtual bool TryLock(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Attempts to release this lock.</para><para>If the current thread is the holder of this lock then the hold count is decremented. If the hold count is now zero then the lock is released. If the current thread is not the holder of this lock then IllegalMonitorStateException is thrown.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// unlock
						/// </java-name>
						[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
						public virtual void Unlock() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns a Condition instance for use with this Lock instance. </para><para>The returned Condition instance supports the same usages as do the Object monitor methods (wait, notify, and notifyAll) when used with the built-in monitor lock.</para><para><ul><li><para>If this write lock is not held when any Condition method is called then an IllegalMonitorStateException is thrown. (Read locks are held independently of write locks, so are not checked or affected. However it is essentially always an error to invoke a condition waiting method when the current thread has also acquired read locks, since other threads that could unblock it will not be able to acquire the write lock.)</para><para></para></li><li><para>When the condition  Condition::await() waiting} methods are called the write lock is released and, before they return, the write lock is reacquired and the lock hold count restored to what it was when the method was called.</para><para></para></li><li><para>If a thread is  Thread::interrupt interrupted} while waiting then the wait will terminate, an InterruptedException will be thrown, and the thread's interrupted status will be cleared.</para><para></para></li><li><para>Waiting threads are signalled in FIFO order.</para><para></para></li><li><para>The ordering of lock reacquisition for threads returning from waiting methods is the same as for threads initially acquiring the lock, which is in the default case not specified, but for <b>fair</b> locks favors those threads that have been waiting the longest.</para><para></para></li></ul></para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the Condition object </para>
						/// </returns>
						/// <java-name>
						/// newCondition
						/// </java-name>
						[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1)]
						public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.Concurrent.Locks.ICondition);
						}

						/// <summary>
						/// <para>Returns a string identifying this lock, as well as its lock state. The state, in brackets includes either the String <c> "Unlocked" </c> or the String <c> "Locked by" </c> followed by the  Thread::getName name} of the owning thread.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a string identifying this lock, as well as its lock state </para>
						/// </returns>
						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Queries if this write lock is held by the current thread. Identical in effect to ReentrantReadWriteLock#isWriteLockedByCurrentThread.</para><para><para>1.6 </para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the current thread holds this lock and <c> false </c> otherwise </para>
						/// </returns>
						/// <java-name>
						/// isHeldByCurrentThread
						/// </java-name>
						[Dot42.DexImport("isHeldByCurrentThread", "()Z", AccessFlags = 1)]
						public virtual bool IsHeldByCurrentThread() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Queries the number of holds on this write lock by the current thread. A thread has a hold on a lock for each lock action that is not matched by an unlock action. Identical in effect to ReentrantReadWriteLock#getWriteHoldCount.</para><para><para>1.6 </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the number of holds on this lock by the current thread, or zero if this lock is not held by the current thread </para>
						/// </returns>
						/// <java-name>
						/// getHoldCount
						/// </java-name>
						[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
						public virtual int GetHoldCount() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal JavaWriteLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Queries the number of holds on this write lock by the current thread. A thread has a hold on a lock for each lock action that is not matched by an unlock action. Identical in effect to ReentrantReadWriteLock#getWriteHoldCount.</para><para><para>1.6 </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the number of holds on this lock by the current thread, or zero if this lock is not held by the current thread </para>
						/// </returns>
						/// <java-name>
						/// getHoldCount
						/// </java-name>
						public int HoldCount
						{
						[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
								get{ return GetHoldCount(); }
						}

				}

				/// <summary>
				/// <para>The lock returned by method ReentrantReadWriteLock#readLock. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock", AccessFlags = 9)]
				public partial class JavaReadLock : global::Java.Util.Concurrent.Locks.ILock, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V", AccessFlags = 4)]
						protected internal JavaReadLock(global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock reentrantReadWriteLock) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Acquires the read lock.</para><para>Acquires the read lock if the write lock is not held by another thread and returns immediately.</para><para>If the write lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until the read lock has been acquired. </para>        
						/// </summary>
						/// <java-name>
						/// lock
						/// </java-name>
						[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
						public virtual void Lock() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Acquires the read lock unless the current thread is  Thread::interrupt interrupted}.</para><para>Acquires the read lock if the write lock is not held by another thread and returns immediately.</para><para>If the write lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happens:</para><para><ul><li><para>The read lock is acquired by the current thread; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread.</para><para></para></li></ul></para><para>If the current thread:</para><para><ul><li><para>has its interrupted status set on entry to this method; or</para><para></para></li><li><para>is  Thread::interrupt interrupted} while acquiring the read lock,</para><para></para></li></ul></para><para>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>In this implementation, as this method is an explicit interruption point, preference is given to responding to the interrupt over normal or reentrant acquisition of the lock.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// lockInterruptibly
						/// </java-name>
						[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1)]
						public virtual void LockInterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Acquires the read lock only if the write lock is not held by another thread at the time of invocation.</para><para>Acquires the read lock if the write lock is not held by another thread and returns immediately with the value <c> true </c> . Even when this lock has been set to use a fair ordering policy, a call to <c> tryLock() </c> <b>will</b> immediately acquire the read lock if it is available, whether or not other threads are currently waiting for the read lock. This "barging" behavior can be useful in certain circumstances, even though it breaks fairness. If you want to honor the fairness setting for this lock, then use tryLock(0, TimeUnit.SECONDS)  which is almost equivalent (it also detects interruption).</para><para>If the write lock is held by another thread then this method will return immediately with the value <c> false </c> .</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the read lock was acquired </para>
						/// </returns>
						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1)]
						public virtual bool TryLock() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Acquires the read lock if the write lock is not held by another thread within the given waiting time and the current thread has not been  Thread::interrupt interrupted}.</para><para>Acquires the read lock if the write lock is not held by another thread and returns immediately with the value <c> true </c> . If this lock has been set to use a fair ordering policy then an available lock <b>will not</b> be acquired if any other threads are waiting for the lock. This is in contrast to the tryLock() method. If you want a timed <c> tryLock </c> that does permit barging on a fair lock then combine the timed and un-timed forms together:</para><para><pre>            if (lock.tryLock() ||
						/// 
						///                lock.tryLock(timeout, unit)) {
						/// 
						///              ...
						/// 
						///            } 
						/// 
						///  </pre></para><para>If the write lock is held by another thread then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:</para><para><ul><li><para>The read lock is acquired by the current thread; or</para><para></para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread; or</para><para></para></li><li><para>The specified waiting time elapses.</para><para></para></li></ul></para><para>If the read lock is acquired then the value <c> true </c> is returned.</para><para>If the current thread:</para><para><ul><li><para>has its interrupted status set on entry to this method; or</para><para></para></li><li><para>is  Thread::interrupt interrupted} while acquiring the read lock,</para><para></para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para><para>If the specified waiting time elapses then the value <c> false </c> is returned. If the time is less than or equal to zero, the method will not wait at all.</para><para>In this implementation, as this method is an explicit interruption point, preference is given to responding to the interrupt over normal or reentrant acquisition of the lock, and over reporting the elapse of the waiting time.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the read lock was acquired </para>
						/// </returns>
						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
						public virtual bool TryLock(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Attempts to release this lock.</para><para>If the number of readers is now zero then the lock is made available for write lock attempts. </para>        
						/// </summary>
						/// <java-name>
						/// unlock
						/// </java-name>
						[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
						public virtual void Unlock() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Throws <c> UnsupportedOperationException </c> because <c> ReadLocks </c> do not support conditions.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// newCondition
						/// </java-name>
						[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1)]
						public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.Concurrent.Locks.ICondition);
						}

						/// <summary>
						/// <para>Returns a string identifying this lock, as well as its lock state. The state, in brackets, includes the String <c> "Read locks =" </c> followed by the number of held read locks.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a string identifying this lock, as well as its lock state </para>
						/// </returns>
						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal JavaReadLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para><c> Condition </c> factors out the <c> Object </c> monitor methods (wait, notify and notifyAll) into distinct objects to give the effect of having multiple wait-sets per object, by combining them with the use of arbitrary Lock implementations. Where a <c> Lock </c> replaces the use of <c> synchronized </c> methods and statements, a <c> Condition </c> replaces the use of the Object monitor methods.</para><para>Conditions (also known as <b>condition queues</b> or <b>condition variables</b>) provide a means for one thread to suspend execution (to "wait") until notified by another thread that some state condition may now be true. Because access to this shared state information occurs in different threads, it must be protected, so a lock of some form is associated with the condition. The key property that waiting for a condition provides is that it <b>atomically</b> releases the associated lock and suspends the current thread, just like <c> Object.wait </c> .</para><para>A <c> Condition </c> instance is intrinsically bound to a lock. To obtain a <c> Condition </c> instance for a particular Lock instance use its newCondition() method.</para><para>As an example, suppose we have a bounded buffer which supports <c> put </c> and <c> take </c> methods. If a <c> take </c> is attempted on an empty buffer, then the thread will block until an item becomes available; if a <c> put </c> is attempted on a full buffer, then the thread will block until a space becomes available. We would like to keep waiting <c> put </c> threads and <c> take </c> threads in separate wait-sets so that we can use the optimization of only notifying a single thread at a time when items or spaces become available in the buffer. This can be achieved using two Condition instances. <pre>
		///    class BoundedBuffer {
		///      <b>final Lock lock = new ReentrantLock();</b>
		///      final Condition notFull  = <b>lock.newCondition(); </b>
		///      final Condition notEmpty = <b>lock.newCondition(); </b>
		/// 
		///      final Object[] items = new Object[100];
		///      int putptr, takeptr, count;
		/// 
		///      public void put(Object x) throws InterruptedException {
		///        <b>lock.lock();
		///        try {</b>
		///          while (count == items.length)
		///            <b>notFull.await();</b>
		///          items[putptr] = x;
		///          if (++putptr == items.length) putptr = 0;
		///          ++count;
		///          <b>notEmpty.signal();</b>
		///        <b>} finally {
		///          lock.unlock();
		///        }</b>
		///      }
		/// 
		///      public Object take() throws InterruptedException {
		///        <b>lock.lock();
		///        try {</b>
		///          while (count == 0)
		///            <b>notEmpty.await();</b>
		///          Object x = items[takeptr];
		///          if (++takeptr == items.length) takeptr = 0;
		///          count;
		///          <b>notFull.signal();</b>
		///          return x;
		///        <b>} finally {
		///          lock.unlock();
		///        }</b>
		///      }
		///    }
		///    </pre></para><para>(The java.util.concurrent.ArrayBlockingQueue class provides this functionality, so there is no reason to implement this sample usage class.)</para><para>A <c> Condition </c> implementation can provide behavior and semantics that is different from that of the <c> Object </c> monitor methods, such as guaranteed ordering for notifications, or not requiring a lock to be held when performing notifications. If an implementation provides such specialized semantics then the implementation must document those semantics.</para><para>Note that <c> Condition </c> instances are just normal objects and can themselves be used as the target in a <c> synchronized </c> statement, and can have their own monitor wait and notification methods invoked. Acquiring the monitor lock of a <c> Condition </c> instance, or using its monitor methods, has no specified relationship with acquiring the Lock associated with that <c> Condition </c> or the use of its  await waiting} and  signal signalling} methods. It is recommended that to avoid confusion you never use <c> Condition </c> instances in this way, except perhaps within their own implementation.</para><para>Except where noted, passing a <c> null </c> value for any parameter will result in a NullPointerException being thrown.</para><para><h3>Implementation Considerations</h3></para><para>When waiting upon a <c> Condition </c> , a "<b>spurious wakeup</b>" is permitted to occur, in general, as a concession to the underlying platform semantics. This has little practical impact on most application programs as a <c> Condition </c> should always be waited upon in a loop, testing the state predicate that is being waited for. An implementation is free to remove the possibility of spurious wakeups but it is recommended that applications programmers always assume that they can occur and so always wait in a loop.</para><para>The three forms of condition waiting (interruptible, non-interruptible, and timed) may differ in their ease of implementation on some platforms and in their performance characteristics. In particular, it may be difficult to provide these features and maintain specific semantics such as ordering guarantees. Further, the ability to interrupt the actual suspension of the thread may not always be feasible to implement on all platforms.</para><para>Consequently, an implementation is not required to define exactly the same guarantees or semantics for all three forms of waiting, nor is it required to support interruption of the actual suspension of the thread.</para><para>An implementation is required to clearly document the semantics and guarantees provided by each of the waiting methods, and when an implementation does support interruption of thread suspension then it must obey the interruption semantics as defined in this interface.</para><para>As interruption generally implies cancellation, and checks for interruption are often infrequent, an implementation can favor responding to an interrupt over normal method return. This is true even if it can be shown that the interrupt occurred after another action that may have unblocked the thread. An implementation should document this behavior.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/Condition
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/Condition", AccessFlags = 1537)]
		public partial interface ICondition
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Causes the current thread to wait until it is signalled or  Thread::interrupt interrupted}.</para><para>The lock associated with this <c> Condition </c> is atomically released and the current thread becomes disabled for thread scheduling purposes and lies dormant until <b>one</b> of four things happens: <ul><li><para>Some other thread invokes the signal method for this <c> Condition </c> and the current thread happens to be chosen as the thread to be awakened; or </para></li><li><para>Some other thread invokes the signalAll method for this <c> Condition </c> ; or </para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread, and interruption of thread suspension is supported; or </para></li><li><para>A "<b>spurious wakeup</b>" occurs. </para></li></ul></para><para>In all cases, before this method can return the current thread must re-acquire the lock associated with this condition. When the thread returns it is <b>guaranteed</b> to hold this lock.</para><para>If the current thread: <ul><li><para>has its interrupted status set on entry to this method; or </para></li><li><para>is  Thread::interrupt interrupted} while waiting and interruption of thread suspension is supported, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared. It is not specified, in the first case, whether or not the test for interruption occurs before the lock is released.</para><para><b>Implementation Considerations</b></para><para>The current thread is assumed to hold the lock associated with this <c> Condition </c> when this method is called. It is up to the implementation to determine if this is the case and if not, how to respond. Typically, an exception will be thrown (such as IllegalMonitorStateException) and the implementation must document that fact.</para><para>An implementation can favor responding to an interrupt over normal method return in response to a signal. In that case the implementation must ensure that the signal is redirected to another waiting thread, if there is one.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "()V", AccessFlags = 1025)]
				void Await() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Causes the current thread to wait until it is signalled.</para><para>The lock associated with this condition is atomically released and the current thread becomes disabled for thread scheduling purposes and lies dormant until <b>one</b> of three things happens: <ul><li><para>Some other thread invokes the signal method for this <c> Condition </c> and the current thread happens to be chosen as the thread to be awakened; or </para></li><li><para>Some other thread invokes the signalAll method for this <c> Condition </c> ; or </para></li><li><para>A "<b>spurious wakeup</b>" occurs. </para></li></ul></para><para>In all cases, before this method can return the current thread must re-acquire the lock associated with this condition. When the thread returns it is <b>guaranteed</b> to hold this lock.</para><para>If the current thread's interrupted status is set when it enters this method, or it is  Thread::interrupt interrupted} while waiting, it will continue to wait until signalled. When it finally returns from this method its interrupted status will still be set.</para><para><b>Implementation Considerations</b></para><para>The current thread is assumed to hold the lock associated with this <c> Condition </c> when this method is called. It is up to the implementation to determine if this is the case and if not, how to respond. Typically, an exception will be thrown (such as IllegalMonitorStateException) and the implementation must document that fact. </para>        
				/// </summary>
				/// <java-name>
				/// awaitUninterruptibly
				/// </java-name>
				[Dot42.DexImport("awaitUninterruptibly", "()V", AccessFlags = 1025)]
				void AwaitUninterruptibly() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Causes the current thread to wait until it is signalled or interrupted, or the specified waiting time elapses.</para><para>The lock associated with this condition is atomically released and the current thread becomes disabled for thread scheduling purposes and lies dormant until <b>one</b> of five things happens: <ul><li><para>Some other thread invokes the signal method for this <c> Condition </c> and the current thread happens to be chosen as the thread to be awakened; or </para></li><li><para>Some other thread invokes the signalAll method for this <c> Condition </c> ; or </para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread, and interruption of thread suspension is supported; or </para></li><li><para>The specified waiting time elapses; or </para></li><li><para>A "<b>spurious wakeup</b>" occurs. </para></li></ul></para><para>In all cases, before this method can return the current thread must re-acquire the lock associated with this condition. When the thread returns it is <b>guaranteed</b> to hold this lock.</para><para>If the current thread: <ul><li><para>has its interrupted status set on entry to this method; or </para></li><li><para>is  Thread::interrupt interrupted} while waiting and interruption of thread suspension is supported, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared. It is not specified, in the first case, whether or not the test for interruption occurs before the lock is released.</para><para>The method returns an estimate of the number of nanoseconds remaining to wait given the supplied <c> nanosTimeout </c> value upon return, or a value less than or equal to zero if it timed out. This value can be used to determine whether and how long to re-wait in cases where the wait returns but an awaited condition still does not hold. Typical uses of this method take the following form:</para><para><pre>        boolean aMethod(long timeout, TimeUnit unit) {
				/// 
				///          long nanos = unit.toNanos(timeout);
				/// 
				///          lock.lock();
				/// 
				///          try {
				/// 
				///            while (!conditionBeingWaitedFor()) {
				/// 
				///              if (nanos &lt;= 0L)
				/// 
				///                return false;
				/// 
				///              nanos = theCondition.awaitNanos(nanos);
				/// 
				///            }
				/// 
				///            // ...
				/// 
				///          } finally {
				/// 
				///            lock.unlock();
				/// 
				///          }
				/// 
				///        } 
				/// 
				///  </pre></para><para>Design note: This method requires a nanosecond argument so as to avoid truncation errors in reporting remaining times. Such precision loss would make it difficult for programmers to ensure that total waiting times are not systematically shorter than specified when re-waits occur.</para><para><b>Implementation Considerations</b></para><para>The current thread is assumed to hold the lock associated with this <c> Condition </c> when this method is called. It is up to the implementation to determine if this is the case and if not, how to respond. Typically, an exception will be thrown (such as IllegalMonitorStateException) and the implementation must document that fact.</para><para>An implementation can favor responding to an interrupt over normal method return in response to a signal, or over indicating the elapse of the specified waiting time. In either case the implementation must ensure that the signal is redirected to another waiting thread, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an estimate of the <c> nanosTimeout </c> value minus the time spent waiting upon return from this method. A positive value may be used as the argument to a subsequent call to this method to finish waiting out the desired time. A value less than or equal to zero indicates that no time remains. </para>
				/// </returns>
				/// <java-name>
				/// awaitNanos
				/// </java-name>
				[Dot42.DexImport("awaitNanos", "(J)J", AccessFlags = 1025)]
				long AwaitNanos(long nanosTimeout) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Causes the current thread to wait until it is signalled or interrupted, or the specified waiting time elapses. This method is behaviorally equivalent to: <pre>  awaitNanos(unit.toNanos(time)) &gt; 0 
				/// 
				///  </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> false </c> if the waiting time detectably elapsed before return from the method, else <c> true </c> </para>
				/// </returns>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				bool Await(long time, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Causes the current thread to wait until it is signalled or interrupted, or the specified deadline elapses.</para><para>The lock associated with this condition is atomically released and the current thread becomes disabled for thread scheduling purposes and lies dormant until <b>one</b> of five things happens: <ul><li><para>Some other thread invokes the signal method for this <c> Condition </c> and the current thread happens to be chosen as the thread to be awakened; or </para></li><li><para>Some other thread invokes the signalAll method for this <c> Condition </c> ; or </para></li><li><para>Some other thread  Thread::interrupt interrupts} the current thread, and interruption of thread suspension is supported; or </para></li><li><para>The specified deadline elapses; or </para></li><li><para>A "<b>spurious wakeup</b>" occurs. </para></li></ul></para><para>In all cases, before this method can return the current thread must re-acquire the lock associated with this condition. When the thread returns it is <b>guaranteed</b> to hold this lock.</para><para>If the current thread: <ul><li><para>has its interrupted status set on entry to this method; or </para></li><li><para>is  Thread::interrupt interrupted} while waiting and interruption of thread suspension is supported, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared. It is not specified, in the first case, whether or not the test for interruption occurs before the lock is released.</para><para>The return value indicates whether the deadline has elapsed, which can be used as follows: <pre>        boolean aMethod(Date deadline) {
				/// 
				///          boolean stillWaiting = true;
				/// 
				///          lock.lock();
				/// 
				///          try {
				/// 
				///            while (!conditionBeingWaitedFor()) {
				/// 
				///              if (!stillWaiting)
				/// 
				///                return false;
				/// 
				///              stillWaiting = theCondition.awaitUntil(deadline);
				/// 
				///            }
				/// 
				///            // ...
				/// 
				///          } finally {
				/// 
				///            lock.unlock();
				/// 
				///          }
				/// 
				///        } 
				/// 
				///  </pre></para><para><b>Implementation Considerations</b></para><para>The current thread is assumed to hold the lock associated with this <c> Condition </c> when this method is called. It is up to the implementation to determine if this is the case and if not, how to respond. Typically, an exception will be thrown (such as IllegalMonitorStateException) and the implementation must document that fact.</para><para>An implementation can favor responding to an interrupt over normal method return in response to a signal, or over indicating the passing of the specified deadline. In either case the implementation must ensure that the signal is redirected to another waiting thread, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> false </c> if the deadline has elapsed upon return, else <c> true </c> </para>
				/// </returns>
				/// <java-name>
				/// awaitUntil
				/// </java-name>
				[Dot42.DexImport("awaitUntil", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				bool AwaitUntil(global::Java.Util.Date deadline) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Wakes up one waiting thread.</para><para>If any threads are waiting on this condition then one is selected for waking up. That thread must then re-acquire the lock before returning from <c> await </c> .</para><para><b>Implementation Considerations</b></para><para>An implementation may (and typically does) require that the current thread hold the lock associated with this <c>       Condition </c> when this method is called. Implementations must document this precondition and any actions taken if the lock is not held. Typically, an exception such as IllegalMonitorStateException will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// signal
				/// </java-name>
				[Dot42.DexImport("signal", "()V", AccessFlags = 1025)]
				void Signal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Wakes up all waiting threads.</para><para>If any threads are waiting on this condition then they are all woken up. Each thread must re-acquire the lock before it can return from <c> await </c> .</para><para><b>Implementation Considerations</b></para><para>An implementation may (and typically does) require that the current thread hold the lock associated with this <c>       Condition </c> when this method is called. Implementations must document this precondition and any actions taken if the lock is not held. Typically, an exception such as IllegalMonitorStateException will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// signalAll
				/// </java-name>
				[Dot42.DexImport("signalAll", "()V", AccessFlags = 1025)]
				void SignalAll() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A synchronizer that may be exclusively owned by a thread. This class provides a basis for creating locks and related synchronizers that may entail a notion of ownership. The <code>AbstractOwnableSynchronizer</code> class itself does not manage or use this information. However, subclasses and tools may use appropriately maintained values to help control and monitor access and provide diagnostics.</para><para><para>1.6 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/locks/AbstractOwnableSynchronizer
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/AbstractOwnableSynchronizer", AccessFlags = 1057)]
		public abstract partial class AbstractOwnableSynchronizer : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Empty constructor for use by subclasses. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractOwnableSynchronizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the thread that currently owns exclusive access. A <code>null</code> argument indicates that no thread owns access. This method does not otherwise impose any synchronization or <code>volatile</code> field accesses. </para>        
				/// </summary>
				/// <java-name>
				/// setExclusiveOwnerThread
				/// </java-name>
				[Dot42.DexImport("setExclusiveOwnerThread", "(Ljava/lang/Thread;)V", AccessFlags = 20)]
				protected internal void SetExclusiveOwnerThread(global::System.Threading.Thread t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the thread last set by <code>setExclusiveOwnerThread</code>, or <code>null</code> if never set. This method does not otherwise impose any synchronization or <code>volatile</code> field accesses. </para>        
				/// </summary>
				/// <returns>
				/// <para>the owner thread </para>
				/// </returns>
				/// <java-name>
				/// getExclusiveOwnerThread
				/// </java-name>
				[Dot42.DexImport("getExclusiveOwnerThread", "()Ljava/lang/Thread;", AccessFlags = 20)]
				protected internal global::System.Threading.Thread GetExclusiveOwnerThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <summary>
				/// <para>Returns the thread last set by <code>setExclusiveOwnerThread</code>, or <code>null</code> if never set. This method does not otherwise impose any synchronization or <code>volatile</code> field accesses. </para>        
				/// </summary>
				/// <returns>
				/// <para>the owner thread </para>
				/// </returns>
				/// <java-name>
				/// getExclusiveOwnerThread
				/// </java-name>
				protected internal global::System.Threading.Thread ExclusiveOwnerThread
				{
				[Dot42.DexImport("getExclusiveOwnerThread", "()Ljava/lang/Thread;", AccessFlags = 20)]
						get{ return GetExclusiveOwnerThread(); }
				[Dot42.DexImport("setExclusiveOwnerThread", "(Ljava/lang/Thread;)V", AccessFlags = 20)]
						set{ SetExclusiveOwnerThread(value); }
				}

		}

}


