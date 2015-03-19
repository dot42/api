#pragma warning disable 1717
namespace Java.Util.Concurrent.Locks
{
		/// <java-name>
		/// java/util/concurrent/locks/ReadWriteLock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/ReadWriteLock", AccessFlags = 1537)]
		public partial interface IReadWriteLock
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// readLock
				/// </java-name>
				[Dot42.DexImport("readLock", "()Ljava/util/concurrent/locks/Lock;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ILock ReadLock() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLock
				/// </java-name>
				[Dot42.DexImport("writeLock", "()Ljava/util/concurrent/locks/Lock;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ILock WriteLock() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/locks/AbstractOwnableSynchronizer
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/AbstractOwnableSynchronizer", AccessFlags = 1057)]
		public abstract partial class AbstractOwnableSynchronizer : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractOwnableSynchronizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExclusiveOwnerThread
				/// </java-name>
				[Dot42.DexImport("setExclusiveOwnerThread", "(Ljava/lang/Thread;)V", AccessFlags = 20)]
				protected internal void SetExclusiveOwnerThread(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExclusiveOwnerThread
				/// </java-name>
				[Dot42.DexImport("getExclusiveOwnerThread", "()Ljava/lang/Thread;", AccessFlags = 20)]
				protected internal global::System.Threading.Thread GetExclusiveOwnerThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

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

		/// <java-name>
		/// java/util/concurrent/locks/ReentrantLock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/ReentrantLock", AccessFlags = 33)]
		public partial class ReentrantLock : global::Java.Util.Concurrent.Locks.ILock, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReentrantLock() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ReentrantLock(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
				public virtual void Lock() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lockInterruptibly
				/// </java-name>
				[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1)]
				public virtual void LockInterruptibly() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1)]
				public virtual bool TryLock() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool TryLock(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
				public virtual void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newCondition
				/// </java-name>
				[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ICondition);
				}

				/// <java-name>
				/// getHoldCount
				/// </java-name>
				[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
				public virtual int GetHoldCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isHeldByCurrentThread
				/// </java-name>
				[Dot42.DexImport("isHeldByCurrentThread", "()Z", AccessFlags = 1)]
				public virtual bool IsHeldByCurrentThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLocked
				/// </java-name>
				[Dot42.DexImport("isLocked", "()Z", AccessFlags = 1)]
				public virtual bool IsLocked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFair
				/// </java-name>
				[Dot42.DexImport("isFair", "()Z", AccessFlags = 17)]
				public bool IsFair() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOwner
				/// </java-name>
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
				protected internal virtual global::System.Threading.Thread GetOwner() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasQueuedThread
				/// </java-name>
				[Dot42.DexImport("hasQueuedThread", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool HasQueuedThread(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", AccessFlags = 1)]
				public virtual bool HasWaiters(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", AccessFlags = 1)]
				public virtual int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", AccessFlags = 4, Signature = "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection<Ljava/lang/Thread;>" +
    ";")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
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
				/// getHoldCount
				/// </java-name>
				public int HoldCount
				{
				[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
						get{ return GetHoldCount(); }
				}

				/// <java-name>
				/// getOwner
				/// </java-name>
				protected internal global::System.Threading.Thread Owner
				{
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
						get{ return GetOwner(); }
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/locks/AbstractQueuedLongSynchronizer
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/AbstractQueuedLongSynchronizer", AccessFlags = 1057)]
		public abstract partial class AbstractQueuedLongSynchronizer : global::Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractQueuedLongSynchronizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()J", AccessFlags = 20)]
				protected internal long GetState() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(J)V", AccessFlags = 20)]
				protected internal void SetState(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareAndSetState
				/// </java-name>
				[Dot42.DexImport("compareAndSetState", "(JJ)Z", AccessFlags = 20)]
				protected internal bool CompareAndSetState(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool TryAcquire(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryRelease
				/// </java-name>
				[Dot42.DexImport("tryRelease", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool TryRelease(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryAcquireShared
				/// </java-name>
				[Dot42.DexImport("tryAcquireShared", "(J)J", AccessFlags = 4)]
				protected internal virtual long TryAcquireShared(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// tryReleaseShared
				/// </java-name>
				[Dot42.DexImport("tryReleaseShared", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool TryReleaseShared(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHeldExclusively
				/// </java-name>
				[Dot42.DexImport("isHeldExclusively", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsHeldExclusively() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(J)V", AccessFlags = 17)]
				public void Acquire(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireInterruptibly", "(J)V", AccessFlags = 17)]
				public void AcquireInterruptibly(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryAcquireNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireNanos", "(JJ)Z", AccessFlags = 17)]
				public bool TryAcquireNanos(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(J)Z", AccessFlags = 17)]
				public bool Release(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// acquireShared
				/// </java-name>
				[Dot42.DexImport("acquireShared", "(J)V", AccessFlags = 17)]
				public void AcquireShared(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireSharedInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireSharedInterruptibly", "(J)V", AccessFlags = 17)]
				public void AcquireSharedInterruptibly(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryAcquireSharedNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireSharedNanos", "(JJ)Z", AccessFlags = 17)]
				public bool TryAcquireSharedNanos(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// releaseShared
				/// </java-name>
				[Dot42.DexImport("releaseShared", "(J)Z", AccessFlags = 17)]
				public bool ReleaseShared(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasContended
				/// </java-name>
				[Dot42.DexImport("hasContended", "()Z", AccessFlags = 17)]
				public bool HasContended() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
				public global::System.Threading.Thread GetFirstQueuedThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <java-name>
				/// isQueued
				/// </java-name>
				[Dot42.DexImport("isQueued", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool IsQueued(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetExclusiveQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetSharedQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
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
				/// owns
				/// </java-name>
				[Dot42.DexImport("owns", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool Owns(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool HasWaiters(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)I", AccessFlags = 17)]
				public int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Ljav" +
    "a/util/Collection;", AccessFlags = 17, Signature = "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer$ConditionObject;)Ljav" +
    "a/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

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

				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				public global::System.Threading.Thread FirstQueuedThread
				{
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
						get{ return GetFirstQueuedThread(); }
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> ExclusiveQueuedThreads
				{
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetExclusiveQueuedThreads(); }
				}

				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> SharedQueuedThreads
				{
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetSharedQueuedThreads(); }
				}

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

						/// <java-name>
						/// signal
						/// </java-name>
						[Dot42.DexImport("signal", "()V", AccessFlags = 17)]
						public void Signal() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// signalAll
						/// </java-name>
						[Dot42.DexImport("signalAll", "()V", AccessFlags = 17)]
						public void SignalAll() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// awaitUninterruptibly
						/// </java-name>
						[Dot42.DexImport("awaitUninterruptibly", "()V", AccessFlags = 17)]
						public void AwaitUninterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "()V", AccessFlags = 17)]
						public void Await() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// awaitNanos
						/// </java-name>
						[Dot42.DexImport("awaitNanos", "(J)J", AccessFlags = 17)]
						public long AwaitNanos(long int64) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// awaitUntil
						/// </java-name>
						[Dot42.DexImport("awaitUntil", "(Ljava/util/Date;)Z", AccessFlags = 17)]
						public bool AwaitUntil(global::Java.Util.Date date) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 17)]
						public bool Await(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// hasWaiters
						/// </java-name>
						[Dot42.DexImport("hasWaiters", "()Z", AccessFlags = 20)]
						protected internal bool HasWaiters() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
						protected internal int GetWaitQueueLength() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

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

						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						protected internal int WaitQueueLength
						{
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
								get{ return GetWaitQueueLength(); }
						}

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

				/// <java-name>
				/// unpark
				/// </java-name>
				[Dot42.DexImport("unpark", "(Ljava/lang/Thread;)V", AccessFlags = 9)]
				public static void Unpark(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// park
				/// </java-name>
				[Dot42.DexImport("park", "(Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void Park(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parkNanos
				/// </java-name>
				[Dot42.DexImport("parkNanos", "(Ljava/lang/Object;J)V", AccessFlags = 9)]
				public static void ParkNanos(object @object, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parkUntil
				/// </java-name>
				[Dot42.DexImport("parkUntil", "(Ljava/lang/Object;J)V", AccessFlags = 9)]
				public static void ParkUntil(object @object, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBlocker
				/// </java-name>
				[Dot42.DexImport("getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object GetBlocker(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// park
				/// </java-name>
				[Dot42.DexImport("park", "()V", AccessFlags = 9)]
				public static void Park() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parkNanos
				/// </java-name>
				[Dot42.DexImport("parkNanos", "(J)V", AccessFlags = 9)]
				public static void ParkNanos(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parkUntil
				/// </java-name>
				[Dot42.DexImport("parkUntil", "(J)V", AccessFlags = 9)]
				public static void ParkUntil(long int64) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/locks/Condition
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/Condition", AccessFlags = 1537)]
		public partial interface ICondition
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "()V", AccessFlags = 1025)]
				void Await() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// awaitUninterruptibly
				/// </java-name>
				[Dot42.DexImport("awaitUninterruptibly", "()V", AccessFlags = 1025)]
				void AwaitUninterruptibly() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// awaitNanos
				/// </java-name>
				[Dot42.DexImport("awaitNanos", "(J)J", AccessFlags = 1025)]
				long AwaitNanos(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				bool Await(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// awaitUntil
				/// </java-name>
				[Dot42.DexImport("awaitUntil", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				bool AwaitUntil(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// signal
				/// </java-name>
				[Dot42.DexImport("signal", "()V", AccessFlags = 1025)]
				void Signal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// signalAll
				/// </java-name>
				[Dot42.DexImport("signalAll", "()V", AccessFlags = 1025)]
				void SignalAll() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/locks/ReentrantReadWriteLock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/ReentrantReadWriteLock", AccessFlags = 33)]
		public partial class ReentrantReadWriteLock : global::Java.Util.Concurrent.Locks.IReadWriteLock, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReentrantReadWriteLock() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ReentrantReadWriteLock(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLock
				/// </java-name>
				[Dot42.DexImport("writeLock", "()Ljava/util/concurrent/locks/ReentrantReadWriteLock$WriteLock;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaWriteLock WriteLock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaWriteLock);
				}

				/// <java-name>
				/// readLock
				/// </java-name>
				[Dot42.DexImport("readLock", "()Ljava/util/concurrent/locks/ReentrantReadWriteLock$ReadLock;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaReadLock ReadLock() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ReentrantReadWriteLock.JavaReadLock);
				}

				/// <java-name>
				/// isFair
				/// </java-name>
				[Dot42.DexImport("isFair", "()Z", AccessFlags = 17)]
				public bool IsFair() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOwner
				/// </java-name>
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
				protected internal virtual global::System.Threading.Thread GetOwner() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <java-name>
				/// getReadLockCount
				/// </java-name>
				[Dot42.DexImport("getReadLockCount", "()I", AccessFlags = 1)]
				public virtual int GetReadLockCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isWriteLocked
				/// </java-name>
				[Dot42.DexImport("isWriteLocked", "()Z", AccessFlags = 1)]
				public virtual bool IsWriteLocked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWriteLockedByCurrentThread
				/// </java-name>
				[Dot42.DexImport("isWriteLockedByCurrentThread", "()Z", AccessFlags = 1)]
				public virtual bool IsWriteLockedByCurrentThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWriteHoldCount
				/// </java-name>
				[Dot42.DexImport("getWriteHoldCount", "()I", AccessFlags = 1)]
				public virtual int GetWriteHoldCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getReadHoldCount
				/// </java-name>
				[Dot42.DexImport("getReadHoldCount", "()I", AccessFlags = 1)]
				public virtual int GetReadHoldCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getQueuedWriterThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedWriterThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedWriterThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// getQueuedReaderThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedReaderThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedReaderThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasQueuedThread
				/// </java-name>
				[Dot42.DexImport("hasQueuedThread", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool HasQueuedThread(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", AccessFlags = 1)]
				public virtual bool HasWaiters(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", AccessFlags = 1)]
				public virtual int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", AccessFlags = 4, Signature = "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection<Ljava/lang/Thread;>" +
    ";")]
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.ICondition condition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

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

				/// <java-name>
				/// getOwner
				/// </java-name>
				protected internal global::System.Threading.Thread Owner
				{
				[Dot42.DexImport("getOwner", "()Ljava/lang/Thread;", AccessFlags = 4)]
						get{ return GetOwner(); }
				}

				/// <java-name>
				/// getReadLockCount
				/// </java-name>
				public int ReadLockCount
				{
				[Dot42.DexImport("getReadLockCount", "()I", AccessFlags = 1)]
						get{ return GetReadLockCount(); }
				}

				/// <java-name>
				/// getWriteHoldCount
				/// </java-name>
				public int WriteHoldCount
				{
				[Dot42.DexImport("getWriteHoldCount", "()I", AccessFlags = 1)]
						get{ return GetWriteHoldCount(); }
				}

				/// <java-name>
				/// getReadHoldCount
				/// </java-name>
				public int ReadHoldCount
				{
				[Dot42.DexImport("getReadHoldCount", "()I", AccessFlags = 1)]
						get{ return GetReadHoldCount(); }
				}

				/// <java-name>
				/// getQueuedWriterThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedWriterThreads
				{
				[Dot42.DexImport("getQueuedWriterThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedWriterThreads(); }
				}

				/// <java-name>
				/// getQueuedReaderThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedReaderThreads
				{
				[Dot42.DexImport("getQueuedReaderThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedReaderThreads(); }
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

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

						/// <java-name>
						/// lock
						/// </java-name>
						[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
						public virtual void Lock() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// lockInterruptibly
						/// </java-name>
						[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1)]
						public virtual void LockInterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1)]
						public virtual bool TryLock() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
						public virtual bool TryLock(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// unlock
						/// </java-name>
						[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
						public virtual void Unlock() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newCondition
						/// </java-name>
						[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1)]
						public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.Concurrent.Locks.ICondition);
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
						/// isHeldByCurrentThread
						/// </java-name>
						[Dot42.DexImport("isHeldByCurrentThread", "()Z", AccessFlags = 1)]
						public virtual bool IsHeldByCurrentThread() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

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

						/// <java-name>
						/// getHoldCount
						/// </java-name>
						public int HoldCount
						{
						[Dot42.DexImport("getHoldCount", "()I", AccessFlags = 1)]
								get{ return GetHoldCount(); }
						}

				}

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

						/// <java-name>
						/// lock
						/// </java-name>
						[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
						public virtual void Lock() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// lockInterruptibly
						/// </java-name>
						[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1)]
						public virtual void LockInterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1)]
						public virtual bool TryLock() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// tryLock
						/// </java-name>
						[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
						public virtual bool TryLock(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// unlock
						/// </java-name>
						[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
						public virtual void Unlock() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newCondition
						/// </java-name>
						[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1)]
						public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.Concurrent.Locks.ICondition);
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
						internal JavaReadLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/util/concurrent/locks/AbstractQueuedSynchronizer
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/AbstractQueuedSynchronizer", AccessFlags = 1057)]
		public abstract partial class AbstractQueuedSynchronizer : global::Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractQueuedSynchronizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 20)]
				protected internal int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(I)V", AccessFlags = 20)]
				protected internal void SetState(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareAndSetState
				/// </java-name>
				[Dot42.DexImport("compareAndSetState", "(II)Z", AccessFlags = 20)]
				protected internal bool CompareAndSetState(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool TryAcquire(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryRelease
				/// </java-name>
				[Dot42.DexImport("tryRelease", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool TryRelease(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryAcquireShared
				/// </java-name>
				[Dot42.DexImport("tryAcquireShared", "(I)I", AccessFlags = 4)]
				protected internal virtual int TryAcquireShared(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// tryReleaseShared
				/// </java-name>
				[Dot42.DexImport("tryReleaseShared", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool TryReleaseShared(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHeldExclusively
				/// </java-name>
				[Dot42.DexImport("isHeldExclusively", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsHeldExclusively() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(I)V", AccessFlags = 17)]
				public void Acquire(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireInterruptibly", "(I)V", AccessFlags = 17)]
				public void AcquireInterruptibly(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryAcquireNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireNanos", "(IJ)Z", AccessFlags = 17)]
				public bool TryAcquireNanos(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(I)Z", AccessFlags = 17)]
				public bool Release(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// acquireShared
				/// </java-name>
				[Dot42.DexImport("acquireShared", "(I)V", AccessFlags = 17)]
				public void AcquireShared(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireSharedInterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireSharedInterruptibly", "(I)V", AccessFlags = 17)]
				public void AcquireSharedInterruptibly(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryAcquireSharedNanos
				/// </java-name>
				[Dot42.DexImport("tryAcquireSharedNanos", "(IJ)Z", AccessFlags = 17)]
				public bool TryAcquireSharedNanos(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// releaseShared
				/// </java-name>
				[Dot42.DexImport("releaseShared", "(I)Z", AccessFlags = 17)]
				public bool ReleaseShared(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
				public bool HasQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasContended
				/// </java-name>
				[Dot42.DexImport("hasContended", "()Z", AccessFlags = 17)]
				public bool HasContended() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
				public global::System.Threading.Thread GetFirstQueuedThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <java-name>
				/// isQueued
				/// </java-name>
				[Dot42.DexImport("isQueued", "(Ljava/lang/Thread;)Z", AccessFlags = 17)]
				public bool IsQueued(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
				public int GetQueueLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetExclusiveQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetSharedQueuedThreads() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
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
				/// owns
				/// </java-name>
				[Dot42.DexImport("owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool Owns(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasWaiters
				/// </java-name>
				[Dot42.DexImport("hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", AccessFlags = 17)]
				public bool HasWaiters(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWaitQueueLength
				/// </java-name>
				[Dot42.DexImport("getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I", AccessFlags = 17)]
				public int GetWaitQueueLength(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWaitingThreads
				/// </java-name>
				[Dot42.DexImport("getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/ut" +
    "il/Collection;", AccessFlags = 17, Signature = "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/ut" +
    "il/Collection<Ljava/lang/Thread;>;")]
				public global::Java.Util.ICollection<global::System.Threading.Thread> GetWaitingThreads(global::Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject conditionObject) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::System.Threading.Thread>);
				}

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

				/// <java-name>
				/// getFirstQueuedThread
				/// </java-name>
				public global::System.Threading.Thread FirstQueuedThread
				{
				[Dot42.DexImport("getFirstQueuedThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
						get{ return GetFirstQueuedThread(); }
				}

				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
				[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return GetQueueLength(); }
				}

				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
				[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetQueuedThreads(); }
				}

				/// <java-name>
				/// getExclusiveQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> ExclusiveQueuedThreads
				{
				[Dot42.DexImport("getExclusiveQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetExclusiveQueuedThreads(); }
				}

				/// <java-name>
				/// getSharedQueuedThreads
				/// </java-name>
				public global::Java.Util.ICollection<global::System.Threading.Thread> SharedQueuedThreads
				{
				[Dot42.DexImport("getSharedQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 17, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return GetSharedQueuedThreads(); }
				}

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

						/// <java-name>
						/// signal
						/// </java-name>
						[Dot42.DexImport("signal", "()V", AccessFlags = 17)]
						public void Signal() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// signalAll
						/// </java-name>
						[Dot42.DexImport("signalAll", "()V", AccessFlags = 17)]
						public void SignalAll() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// awaitUninterruptibly
						/// </java-name>
						[Dot42.DexImport("awaitUninterruptibly", "()V", AccessFlags = 17)]
						public void AwaitUninterruptibly() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "()V", AccessFlags = 17)]
						public void Await() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// awaitNanos
						/// </java-name>
						[Dot42.DexImport("awaitNanos", "(J)J", AccessFlags = 17)]
						public long AwaitNanos(long int64) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// awaitUntil
						/// </java-name>
						[Dot42.DexImport("awaitUntil", "(Ljava/util/Date;)Z", AccessFlags = 17)]
						public bool AwaitUntil(global::Java.Util.Date date) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// await
						/// </java-name>
						[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 17)]
						public bool Await(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// hasWaiters
						/// </java-name>
						[Dot42.DexImport("hasWaiters", "()Z", AccessFlags = 20)]
						protected internal bool HasWaiters() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
						protected internal int GetWaitQueueLength() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

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

						/// <java-name>
						/// getWaitQueueLength
						/// </java-name>
						protected internal int WaitQueueLength
						{
						[Dot42.DexImport("getWaitQueueLength", "()I", AccessFlags = 20)]
								get{ return GetWaitQueueLength(); }
						}

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

		/// <java-name>
		/// java/util/concurrent/locks/Lock
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/locks/Lock", AccessFlags = 1537)]
		public partial interface ILock
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 1025)]
				void Lock() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lockInterruptibly
				/// </java-name>
				[Dot42.DexImport("lockInterruptibly", "()V", AccessFlags = 1025)]
				void LockInterruptibly() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "()Z", AccessFlags = 1025)]
				bool TryLock() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tryLock
				/// </java-name>
				[Dot42.DexImport("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				bool TryLock(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 1025)]
				void Unlock() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newCondition
				/// </java-name>
				[Dot42.DexImport("newCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 1025)]
				global::Java.Util.Concurrent.Locks.ICondition NewCondition() /* MethodBuilder.Create */ ;

		}

}

