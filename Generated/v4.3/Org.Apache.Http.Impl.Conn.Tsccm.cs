// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Conn.Tsccm.cs
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
namespace Org.Apache.Http.Impl.Conn.Tsccm
{
		/// <summary>
		/// <para>A connection wrapper and callback handler. All connections given out by the manager are wrappers which can be detached to prevent further use on release. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter", AccessFlags = 33)]
		public partial class BasicPooledConnAdapter : global::Org.Apache.Http.Impl.Conn.AbstractPooledConnAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new adapter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager;Lorg/apache/http/im" +
    "pl/conn/AbstractPoolEntry;)V", AccessFlags = 4)]
				protected internal BasicPooledConnAdapter(global::Org.Apache.Http.Impl.Conn.Tsccm.ThreadSafeClientConnManager tsccm, global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getManager
				/// </java-name>
				[Dot42.DexImport("getManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.Conn.IClientConnectionManager GetManager() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionManager);
				}

				/// <summary>
				/// <para>Obtains the pool entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pool entry, or <code>null</code> if detached </para>
				/// </returns>
				/// <java-name>
				/// getPoolEntry
				/// </java-name>
				[Dot42.DexImport("getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry GetPoolEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry);
				}

				/// <summary>
				/// <para>Detaches this adapter from the wrapped connection. This adapter becomes useless. </para>        
				/// </summary>
				/// <java-name>
				/// detach
				/// </java-name>
				[Dot42.DexImport("detach", "()V", AccessFlags = 4)]
				protected internal override void Detach() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicPooledConnAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getManager
				/// </java-name>
				protected internal global::Org.Apache.Http.Conn.IClientConnectionManager Manager
				{
				[Dot42.DexImport("getManager", "()Lorg/apache/http/conn/ClientConnectionManager;", AccessFlags = 4)]
						get{ return GetManager(); }
				}

				/// <summary>
				/// <para>Obtains the pool entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pool entry, or <code>null</code> if detached </para>
				/// </returns>
				/// <java-name>
				/// getPoolEntry
				/// </java-name>
				protected internal global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry PoolEntry
				{
				[Dot42.DexImport("getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;", AccessFlags = 4)]
						get{ return GetPoolEntry(); }
				}

		}

		/// <summary>
		/// <para>A weak reference to a BasicPoolEntry. This reference explicitly keeps the planned route, so the connection can be reclaimed if it is lost to garbage collection. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/BasicPoolEntryRef
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/BasicPoolEntryRef", AccessFlags = 33, Signature = "Ljava/lang/ref/WeakReference<Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;>;")]
		public partial class BasicPoolEntryRef : global::Java.Lang.Ref.WeakReference<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new reference to a pool entry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;Ljava/lang/ref/ReferenceQueue;)V" +
    "", AccessFlags = 1, Signature = "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;Ljava/lang/ref/ReferenceQueue<Lj" +
    "ava/lang/Object;>;)V")]
				public BasicPoolEntryRef(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry, global::Java.Lang.Ref.ReferenceQueue<object> queue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtain the planned route for the referenced entry. The planned route is still available, even if the entry is gone.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the planned route </para>
				/// </returns>
				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicPoolEntryRef() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Obtain the planned route for the referenced entry. The planned route is still available, even if the entry is gone.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the planned route </para>
				/// </returns>
				/// <java-name>
				/// getRoute
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
						get{ return GetRoute(); }
				}

		}

		/// <summary>
		/// <para>A worker thread for processing queued references. References can be queued automatically by the garbage collector. If that feature is used, a daemon thread should be executing this worker. It will pick up the queued references and pass them on to a handler for appropriate processing. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/RefQueueWorker
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/RefQueueWorker", AccessFlags = 33)]
		public partial class RefQueueWorker : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The reference queue to monitor. </para>        
				/// </summary>
				/// <java-name>
				/// refQueue
				/// </java-name>
				[Dot42.DexImport("refQueue", "Ljava/lang/ref/ReferenceQueue;", AccessFlags = 20)]
				protected internal readonly global::Java.Lang.Ref.ReferenceQueue<object> RefQueue;
				/// <summary>
				/// <para>The handler for the references found. </para>        
				/// </summary>
				/// <java-name>
				/// refHandler
				/// </java-name>
				[Dot42.DexImport("refHandler", "Lorg/apache/http/impl/conn/tsccm/RefQueueHandler;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Impl.Conn.Tsccm.IRefQueueHandler RefHandler;
				/// <summary>
				/// <para>The thread executing this handler. This attribute is also used as a shutdown indicator. </para>        
				/// </summary>
				/// <java-name>
				/// workerThread
				/// </java-name>
				[Dot42.DexImport("workerThread", "Ljava/lang/Thread;", AccessFlags = 68)]
				protected internal global::System.Threading.Thread WorkerThread;
				/// <summary>
				/// <para>Instantiates a new worker to listen for lost connections.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ref/ReferenceQueue;Lorg/apache/http/impl/conn/tsccm/RefQueueHandler;)" +
    "V", AccessFlags = 1, Signature = "(Ljava/lang/ref/ReferenceQueue<*>;Lorg/apache/http/impl/conn/tsccm/RefQueueHandle" +
    "r;)V")]
				public RefQueueWorker(global::Java.Lang.Ref.ReferenceQueue<object> queue, global::Org.Apache.Http.Impl.Conn.Tsccm.IRefQueueHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The main loop of this worker. If initialization succeeds, this method will only return after shutdown(). Only one thread can execute the main loop at any time. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Shuts down this worker. It can be re-started afterwards by another call to run(). </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a description of this worker.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a descriptive string for this worker </para>
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
				internal RefQueueWorker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Callback handler for RefQueueWorker. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/RefQueueHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/RefQueueHandler", AccessFlags = 1537)]
		public partial interface IRefQueueHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Invoked when a reference is found on the queue.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// handleReference
				/// </java-name>
				[Dot42.DexImport("handleReference", "(Ljava/lang/ref/Reference;)V", AccessFlags = 1025, Signature = "(Ljava/lang/ref/Reference<*>;)V")]
				void HandleReference(global::Java.Lang.Ref.Reference<object> @ref) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An abstract connection pool. It is used by the ThreadSafeClientConnManager. The abstract pool includes a poolLock, which is used to synchronize access to the internal pool datastructures. Don't use <code>synchronized</code> for that purpose! </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/AbstractConnPool
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/AbstractConnPool", AccessFlags = 1057)]
		public abstract partial class AbstractConnPool : global::Org.Apache.Http.Impl.Conn.Tsccm.IRefQueueHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The global lock for this pool. </para>        
				/// </summary>
				/// <java-name>
				/// poolLock
				/// </java-name>
				[Dot42.DexImport("poolLock", "Ljava/util/concurrent/locks/Lock;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.Concurrent.Locks.ILock PoolLock;
				/// <summary>
				/// <para>References to issued connections. Objects in this set are of class BasicPoolEntryRef, and point to the pool entry for the issued connection. GCed connections are detected by the missing pool entries. </para>        
				/// </summary>
				/// <java-name>
				/// issuedConnections
				/// </java-name>
				[Dot42.DexImport("issuedConnections", "Ljava/util/Set;", AccessFlags = 4)]
				protected internal global::Java.Util.ISet<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntryRef> IssuedConnections;
				/// <summary>
				/// <para>The handler for idle connections. </para>        
				/// </summary>
				/// <java-name>
				/// idleConnHandler
				/// </java-name>
				[Dot42.DexImport("idleConnHandler", "Lorg/apache/http/impl/conn/IdleConnectionHandler;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Impl.Conn.IdleConnectionHandler IdleConnHandler;
				/// <summary>
				/// <para>The current total number of connections. </para>        
				/// </summary>
				/// <java-name>
				/// numConnections
				/// </java-name>
				[Dot42.DexImport("numConnections", "I", AccessFlags = 4)]
				protected internal int NumConnections;
				/// <summary>
				/// <para>A reference queue to track loss of pool entries to GC. The same queue is used to track loss of the connection manager, so we cannot specialize the type. </para>        
				/// </summary>
				/// <java-name>
				/// refQueue
				/// </java-name>
				[Dot42.DexImport("refQueue", "Ljava/lang/ref/ReferenceQueue;", AccessFlags = 4)]
				protected internal global::Java.Lang.Ref.ReferenceQueue<object> RefQueue;
				/// <summary>
				/// <para>Indicates whether this pool is shut down. </para>        
				/// </summary>
				/// <java-name>
				/// isShutDown
				/// </java-name>
				[Dot42.DexImport("isShutDown", "Z", AccessFlags = 68)]
				protected internal bool IsShutDown;
				/// <summary>
				/// <para>Creates a new connection pool. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractConnPool() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enables connection garbage collection (GC). This method must be called immediately after creating the connection pool. It is not possible to enable connection GC after pool entries have been created. Neither is it possible to disable connection GC.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// enableConnectionGC
				/// </java-name>
				[Dot42.DexImport("enableConnectionGC", "()V", AccessFlags = 1)]
				public virtual void EnableConnectionGC() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a pool entry with a connection within the given timeout.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>pool entry holding a connection for the route</para>
				/// </returns>
				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent" +
    "/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 17)]
				public global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state, long timeout, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <summary>
				/// <para>Returns a new PoolEntryRequest, from which a BasicPoolEntry can be obtained, or the request can be aborted. </para>        
				/// </summary>
				/// <java-name>
				/// requestPoolEntry
				/// </java-name>
				[Dot42.DexImport("requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl" +
    "/conn/tsccm/PoolEntryRequest;", AccessFlags = 1025)]
				public abstract global::Org.Apache.Http.Impl.Conn.Tsccm.IPoolEntryRequest RequestPoolEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an entry into the pool. The connection of the entry is expected to be in a suitable state, either open and re-usable, or closed. The pool will not make any attempt to determine whether it can be re-used or not.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// freeEntry
				/// </java-name>
				[Dot42.DexImport("freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit" +
    ";)V", AccessFlags = 1025)]
				public abstract void FreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry, bool reusable, long validDuration, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// handleReference
				/// </java-name>
				[Dot42.DexImport("handleReference", "(Ljava/lang/ref/Reference;)V", AccessFlags = 1)]
				public virtual void HandleReference(global::Java.Lang.Ref.Reference<object> @ref) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handles cleaning up for a lost pool entry with the given route. A lost pool entry corresponds to a connection that was garbage collected instead of being properly released.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// handleLostEntry
				/// </java-name>
				[Dot42.DexImport("handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 1028)]
				protected internal abstract void HandleLostEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes idle connections.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long idletime, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1)]
				public virtual void CloseExpiredConnections() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Deletes all entries for closed connections. </para>        
				/// </summary>
				/// <java-name>
				/// deleteClosedConnections
				/// </java-name>
				[Dot42.DexImport("deleteClosedConnections", "()V", AccessFlags = 1025)]
				public abstract void DeleteClosedConnections() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Shuts down this pool and all associated resources. Overriding methods MUST call the implementation here! </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes a connection from this pool.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// closeConnection
				/// </java-name>
				[Dot42.DexImport("closeConnection", "(Lorg/apache/http/conn/OperatedClientConnection;)V", AccessFlags = 4)]
				protected internal virtual void CloseConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection conn) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A simple class that can interrupt a WaitingThread. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/WaitingThreadAborter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/WaitingThreadAborter", AccessFlags = 33)]
		public partial class WaitingThreadAborter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WaitingThreadAborter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If a waiting thread has been set, interrupts it. </para>        
				/// </summary>
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1)]
				public virtual void Abort() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the waiting thread. If this has already been aborted, the waiting thread is immediately interrupted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWaitingThread
				/// </java-name>
				[Dot42.DexImport("setWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", AccessFlags = 1)]
				public virtual void SetWaitingThread(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread waitingThread) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A connection sub-pool for a specific route, used by ConnPoolByRoute. The methods in this class are unsynchronized. It is expected that the containing pool takes care of synchronization. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/RouteSpecificPool
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/RouteSpecificPool", AccessFlags = 33)]
		public partial class RouteSpecificPool
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The route this pool is for. </para>        
				/// </summary>
				/// <java-name>
				/// route
				/// </java-name>
				[Dot42.DexImport("route", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.Routing.HttpRoute Route;
				/// <summary>
				/// <para>the maximum number of entries allowed for this pool </para>        
				/// </summary>
				/// <java-name>
				/// maxEntries
				/// </java-name>
				[Dot42.DexImport("maxEntries", "I", AccessFlags = 20)]
				protected internal readonly int MaxEntries;
				/// <summary>
				/// <para>The list of free entries. This list is managed LIFO, to increase idle times and allow for closing connections that are not really needed. </para>        
				/// </summary>
				/// <java-name>
				/// freeEntries
				/// </java-name>
				[Dot42.DexImport("freeEntries", "Ljava/util/LinkedList;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.LinkedList<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry> FreeEntries;
				/// <summary>
				/// <para>The list of threads waiting for this pool. </para>        
				/// </summary>
				/// <java-name>
				/// waitingThreads
				/// </java-name>
				[Dot42.DexImport("waitingThreads", "Ljava/util/Queue;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread> WaitingThreads;
				/// <summary>
				/// <para>The number of created entries. </para>        
				/// </summary>
				/// <java-name>
				/// numEntries
				/// </java-name>
				[Dot42.DexImport("numEntries", "I", AccessFlags = 4)]
				protected internal int NumEntries;
				/// <summary>
				/// <para>Creates a new route-specific pool.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/routing/HttpRoute;I)V", AccessFlags = 1)]
				public RouteSpecificPool(global::Org.Apache.Http.Conn.Routing.HttpRoute route, int maxEntries) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the route for which this pool is specific.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the route </para>
				/// </returns>
				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <summary>
				/// <para>Obtains the maximum number of entries allowed for this pool.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the max entry number </para>
				/// </returns>
				/// <java-name>
				/// getMaxEntries
				/// </java-name>
				[Dot42.DexImport("getMaxEntries", "()I", AccessFlags = 17)]
				public int GetMaxEntries() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this pool is unused. A pool is unused if there is neither an entry nor a waiting thread. All entries count, not only the free but also the allocated ones.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this pool is unused, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isUnused
				/// </java-name>
				[Dot42.DexImport("isUnused", "()Z", AccessFlags = 1)]
				public virtual bool IsUnused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return remaining capacity of this pool</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>capacity </para>
				/// </returns>
				/// <java-name>
				/// getCapacity
				/// </java-name>
				[Dot42.DexImport("getCapacity", "()I", AccessFlags = 1)]
				public virtual int GetCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the number of entries. This includes not only the free entries, but also those that have been created and are currently issued to an application.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of entries for the route of this pool </para>
				/// </returns>
				/// <java-name>
				/// getEntryCount
				/// </java-name>
				[Dot42.DexImport("getEntryCount", "()I", AccessFlags = 17)]
				public int GetEntryCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains a free entry from this pool, if one is available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an available pool entry, or <code>null</code> if there is none </para>
				/// </returns>
				/// <java-name>
				/// allocEntry
				/// </java-name>
				[Dot42.DexImport("allocEntry", "(Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry AllocEntry(object state) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <summary>
				/// <para>Returns an allocated entry to this pool.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// freeEntry
				/// </java-name>
				[Dot42.DexImport("freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", AccessFlags = 1)]
				public virtual void FreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates creation of an entry for this pool. The entry will <b>not</b> be added to the list of free entries, it is only recognized as belonging to this pool now. It can then be passed to freeEntry.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// createdEntry
				/// </java-name>
				[Dot42.DexImport("createdEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", AccessFlags = 1)]
				public virtual void CreatedEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Deletes an entry from this pool. Only entries that are currently free in this pool can be deleted. Allocated entries can not be deleted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entry was found and deleted, or <code>false</code> if the entry was not found </para>
				/// </returns>
				/// <java-name>
				/// deleteEntry
				/// </java-name>
				[Dot42.DexImport("deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)Z", AccessFlags = 1)]
				public virtual bool DeleteEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Forgets about an entry from this pool. This method is used to indicate that an entry allocated from this pool has been lost and will not be returned. </para>        
				/// </summary>
				/// <java-name>
				/// dropEntry
				/// </java-name>
				[Dot42.DexImport("dropEntry", "()V", AccessFlags = 1)]
				public virtual void DropEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a waiting thread. This pool makes no attempt to match waiting threads with pool entries. It is the caller's responsibility to check that there is no entry before adding a waiting thread.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// queueThread
				/// </java-name>
				[Dot42.DexImport("queueThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", AccessFlags = 1)]
				public virtual void QueueThread(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread wt) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether there is a waiting thread in this pool.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is a waiting thread, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasThread
				/// </java-name>
				[Dot42.DexImport("hasThread", "()Z", AccessFlags = 1)]
				public virtual bool HasThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the next thread in the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a waiting thread, or <code>null</code> if there is none </para>
				/// </returns>
				/// <java-name>
				/// nextThread
				/// </java-name>
				[Dot42.DexImport("nextThread", "()Lorg/apache/http/impl/conn/tsccm/WaitingThread;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread NextThread() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread);
				}

				/// <summary>
				/// <para>Removes a waiting thread, if it is queued.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeThread
				/// </java-name>
				[Dot42.DexImport("removeThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", AccessFlags = 1)]
				public virtual void RemoveThread(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread wt) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RouteSpecificPool() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return remaining capacity of this pool</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>capacity </para>
				/// </returns>
				/// <java-name>
				/// getCapacity
				/// </java-name>
				public int Capacity
				{
				[Dot42.DexImport("getCapacity", "()I", AccessFlags = 1)]
						get{ return GetCapacity(); }
				}

				/// <summary>
				/// <para>Obtains the number of entries. This includes not only the free entries, but also those that have been created and are currently issued to an application.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of entries for the route of this pool </para>
				/// </returns>
				/// <java-name>
				/// getEntryCount
				/// </java-name>
				public int EntryCount
				{
				[Dot42.DexImport("getEntryCount", "()I", AccessFlags = 17)]
						get{ return GetEntryCount(); }
				}

		}

		/// <summary>
		/// <para>Represents a thread waiting for a connection. This class implements throwaway objects. It is instantiated whenever a thread needs to wait. Instances are not re-used, except if the waiting thread experiences a spurious wakeup and continues to wait. <br></br> All methods assume external synchronization on the condition passed to the constructor. Instances of this class do <b>not</b> synchronize access!</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/WaitingThread
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/WaitingThread", AccessFlags = 33)]
		public partial class WaitingThread
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new entry for a waiting thread.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpec" +
    "ificPool;)V", AccessFlags = 1)]
				public WaitingThread(global::Java.Util.Concurrent.Locks.ICondition cond, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool pool) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the condition.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the condition on which to wait, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getCondition
				/// </java-name>
				[Dot42.DexImport("getCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 17)]
				public global::Java.Util.Concurrent.Locks.ICondition GetCondition() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ICondition);
				}

				/// <summary>
				/// <para>Obtains the pool, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pool on which a thread is or was waiting, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getPool
				/// </java-name>
				[Dot42.DexImport("getPool", "()Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", AccessFlags = 17)]
				public global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool GetPool() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool);
				}

				/// <summary>
				/// <para>Obtains the thread, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thread which is waiting, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getThread
				/// </java-name>
				[Dot42.DexImport("getThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
				public global::System.Threading.Thread GetThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <summary>
				/// <para>Blocks the calling thread. This method returns when the thread is notified or interrupted, if a timeout occurrs, or if there is a spurious wakeup. <br></br> This method assumes external synchronization.</para><para><para>wakeup </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the condition was satisfied, <code>false</code> in case of a timeout. Typically, a call to wakeup is used to indicate that the condition was satisfied. Since the condition is accessible outside, this cannot be guaranteed though.</para>
				/// </returns>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool Await(global::Java.Util.Date deadline) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Wakes up the waiting thread. <br></br> This method assumes external synchronization. </para>        
				/// </summary>
				/// <java-name>
				/// wakeup
				/// </java-name>
				[Dot42.DexImport("wakeup", "()V", AccessFlags = 1)]
				public virtual void Wakeup() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 1)]
				public virtual void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WaitingThread() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Obtains the condition.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the condition on which to wait, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getCondition
				/// </java-name>
				public global::Java.Util.Concurrent.Locks.ICondition Condition
				{
				[Dot42.DexImport("getCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 17)]
						get{ return GetCondition(); }
				}

				/// <summary>
				/// <para>Obtains the pool, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pool on which a thread is or was waiting, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getPool
				/// </java-name>
				public global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool Pool
				{
				[Dot42.DexImport("getPool", "()Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", AccessFlags = 17)]
						get{ return GetPool(); }
				}

				/// <summary>
				/// <para>Obtains the thread, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thread which is waiting, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getThread
				/// </java-name>
				public global::System.Threading.Thread Thread
				{
				[Dot42.DexImport("getThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
						get{ return GetThread(); }
				}

		}

		/// <summary>
		/// <para>Manages a pool of client connections. </para><para>This class is derived from <code>MultiThreadedHttpConnectionManager</code> in HttpClient 3. See there for original authors. </para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>673450 </para><title>Date:</title><para>2008-07-02 10:35:05 -0700 (Wed, 02 Jul 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager", AccessFlags = 33)]
		public partial class ThreadSafeClientConnManager : global::Org.Apache.Http.Conn.IClientConnectionManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The schemes supported by this connection manager. </para>        
				/// </summary>
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <summary>
				/// <para>The pool of connections being managed. </para>        
				/// </summary>
				/// <java-name>
				/// connectionPool
				/// </java-name>
				[Dot42.DexImport("connectionPool", "Lorg/apache/http/impl/conn/tsccm/AbstractConnPool;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool ConnectionPool;
				/// <summary>
				/// <para>The operator for opening and updating connections. </para>        
				/// </summary>
				/// <java-name>
				/// connOperator
				/// </java-name>
				[Dot42.DexImport("connOperator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IClientConnectionOperator ConnOperator;
				/// <summary>
				/// <para>Creates a new thread safe connection manager.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)" +
    "V", AccessFlags = 1)]
				public ThreadSafeClientConnManager(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schreg) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ThreadSafeClientConnManager() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Hook for creating the connection pool.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection pool to use </para>
				/// </returns>
				/// <java-name>
				/// createConnectionPool
				/// </java-name>
				[Dot42.DexImport("createConnectionPool", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/impl/conn/tsccm/AbstractCon" +
    "nPool;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool CreateConnectionPool(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool);
				}

				/// <summary>
				/// <para>Hook for creating the connection operator. It is called by the constructor. Derived classes can override this method to change the instantiation of the operator. The default implementation here instantiates DefaultClientConnectionOperator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection operator to use </para>
				/// </returns>
				/// <java-name>
				/// createConnectionOperator
				/// </java-name>
				[Dot42.DexImport("createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnect" +
    "ionOperator;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.IClientConnectionOperator CreateConnectionOperator(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schreg) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionOperator);
				}

				/// <summary>
				/// <para>Obtains the scheme registry used by this manager.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme registry, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.Scheme.SchemeRegistry GetSchemeRegistry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry);
				}

				/// <java-name>
				/// requestConnection
				/// </java-name>
				[Dot42.DexImport("requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn" +
    "/ClientConnectionRequest;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Conn.IClientConnectionRequest RequestConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionRequest);
				}

				/// <summary>
				/// <para>Releases a connection for use by others. You may optionally specify how long the connection is valid to be reused. Values &lt;= 0 are considered to be valid forever. If the connection is not marked as reusable, the connection will not be reused regardless of the valid duration.</para><para>If the connection has been released before, the call will be ignored.</para><para><para>closeExpiredConnections() </para></para>        
				/// </summary>
				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V" +
    "", AccessFlags = 1)]
				public virtual void ReleaseConnection(global::Org.Apache.Http.Conn.IManagedClientConnection conn, long validDuration, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Shuts down this connection manager and releases allocated resources. This includes closing all connections, whether they are currently used or not. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the total number of pooled connections for the given route. This is the total number of connections that have been created and are still in use by this connection manager for the route. This value will not exceed the maximum number of connections per host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the total number of pooled connections for that route </para>
				/// </returns>
				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				[Dot42.DexImport("getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1)]
				public virtual int GetConnectionsInPool(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the total number of pooled connections. This is the total number of connections that have been created and are still in use by this connection manager. This value will not exceed the maximum number of connections in total.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the total number of pooled connections </para>
				/// </returns>
				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				[Dot42.DexImport("getConnectionsInPool", "()I", AccessFlags = 1)]
				public virtual int GetConnectionsInPool() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Closes idle connections in the pool. Open connections in the pool that have not been used for the timespan given by the argument will be closed. Currently allocated connections are not subject to this method. Times will be checked with milliseconds precision</para><para>All expired connections will also be closed.</para><para><para>closeExpiredConnections() </para></para>        
				/// </summary>
				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long idletime, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes all expired connections in the pool. Open connections in the pool that have not been used for the timespan defined when the connection was released will be closed. Currently allocated connections are not subject to this method. Times will be checked with milliseconds precision. </para>        
				/// </summary>
				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1)]
				public virtual void CloseExpiredConnections() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ThreadSafeClientConnManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the total number of pooled connections. This is the total number of connections that have been created and are still in use by this connection manager. This value will not exceed the maximum number of connections in total.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the total number of pooled connections </para>
				/// </returns>
				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				public int ConnectionsInPool
				{
				[Dot42.DexImport("getConnectionsInPool", "()I", AccessFlags = 1)]
						get{ return GetConnectionsInPool(); }
				}

		}

		/// <summary>
		/// <para>Encapsulates a request for a BasicPoolEntry. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/PoolEntryRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/PoolEntryRequest", AccessFlags = 1537)]
		public partial interface IPoolEntryRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains a pool entry with a connection within the given timeout. If abortRequest() is called before this completes an InterruptedException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>pool entry holding a connection for the route</para>
				/// </returns>
				/// <java-name>
				/// getPoolEntry
				/// </java-name>
				[Dot42.DexImport("getPoolEntry", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry" +
    ";", AccessFlags = 1025)]
				global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetPoolEntry(long timeout, global::Java.Util.Concurrent.TimeUnit tunit) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Aborts the active or next call to getPoolEntry(long, TimeUnit). </para>        
				/// </summary>
				/// <java-name>
				/// abortRequest
				/// </java-name>
				[Dot42.DexImport("abortRequest", "()V", AccessFlags = 1025)]
				void AbortRequest() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A connection pool that maintains connections by route. This class is derived from <code>MultiThreadedHttpConnectionManager</code> in HttpClient 3.x, see there for original authors. It implements the same algorithm for connection re-use and connection-per-host enforcement: <ul><li><para>connections are re-used only for the exact same route </para></li><li><para>connection limits are enforced per route rather than per host </para></li></ul>Note that access to the pool datastructures is synchronized via the poolLock in the base class, not via <code>synchronized</code> methods.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>and others </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/ConnPoolByRoute
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/ConnPoolByRoute", AccessFlags = 33)]
		public partial class ConnPoolByRoute : global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Connection operator for this pool </para>        
				/// </summary>
				/// <java-name>
				/// operator
				/// </java-name>
				[Dot42.DexImport("operator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IClientConnectionOperator Operator;
				/// <summary>
				/// <para>The list of free connections </para>        
				/// </summary>
				/// <java-name>
				/// freeConnections
				/// </java-name>
				[Dot42.DexImport("freeConnections", "Ljava/util/Queue;", AccessFlags = 4)]
				protected internal global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry> FreeConnections;
				/// <summary>
				/// <para>The list of WaitingThreads waiting for a connection </para>        
				/// </summary>
				/// <java-name>
				/// waitingThreads
				/// </java-name>
				[Dot42.DexImport("waitingThreads", "Ljava/util/Queue;", AccessFlags = 4)]
				protected internal global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread> WaitingThreads;
				/// <summary>
				/// <para>A map of route-specific pools. Keys are of class HttpRoute, values of class RouteSpecificPool. </para>        
				/// </summary>
				/// <java-name>
				/// routeToPool
				/// </java-name>
				[Dot42.DexImport("routeToPool", "Ljava/util/Map;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.IMap<global::Org.Apache.Http.Conn.Routing.HttpRoute, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool> RouteToPool;
				/// <java-name>
				/// maxTotalConnections
				/// </java-name>
				[Dot42.DexImport("maxTotalConnections", "I", AccessFlags = 20)]
				protected internal readonly int MaxTotalConnections;
				/// <summary>
				/// <para>Creates a new connection pool, managed by route. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/params/HttpParam" +
    "s;)V", AccessFlags = 1)]
				public ConnPoolByRoute(global::Org.Apache.Http.Conn.IClientConnectionOperator @operator, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates the queue for freeConnections. Called once by the constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a queue </para>
				/// </returns>
				/// <java-name>
				/// createFreeConnQueue
				/// </java-name>
				[Dot42.DexImport("createFreeConnQueue", "()Ljava/util/Queue;", AccessFlags = 4, Signature = "()Ljava/util/Queue<Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;>;")]
				protected internal virtual global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry> CreateFreeConnQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry>);
				}

				/// <summary>
				/// <para>Creates the queue for waitingThreads. Called once by the constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a queue </para>
				/// </returns>
				/// <java-name>
				/// createWaitingThreadQueue
				/// </java-name>
				[Dot42.DexImport("createWaitingThreadQueue", "()Ljava/util/Queue;", AccessFlags = 4, Signature = "()Ljava/util/Queue<Lorg/apache/http/impl/conn/tsccm/WaitingThread;>;")]
				protected internal virtual global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread> CreateWaitingThreadQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread>);
				}

				/// <summary>
				/// <para>Creates the map for routeToPool. Called once by the constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a map </para>
				/// </returns>
				/// <java-name>
				/// createRouteToPoolMap
				/// </java-name>
				[Dot42.DexImport("createRouteToPoolMap", "()Ljava/util/Map;", AccessFlags = 4, Signature = "()Ljava/util/Map<Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/impl/co" +
    "nn/tsccm/RouteSpecificPool;>;")]
				protected internal virtual global::Java.Util.IMap<global::Org.Apache.Http.Conn.Routing.HttpRoute, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool> CreateRouteToPoolMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<global::Org.Apache.Http.Conn.Routing.HttpRoute, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool>);
				}

				/// <summary>
				/// <para>Creates a new route-specific pool. Called by getRoutePool when necessary.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new pool </para>
				/// </returns>
				/// <java-name>
				/// newRouteSpecificPool
				/// </java-name>
				[Dot42.DexImport("newRouteSpecificPool", "(Lorg/apache/http/conn/routing/HttpRoute;)Lorg/apache/http/impl/conn/tsccm/RouteS" +
    "pecificPool;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool NewRouteSpecificPool(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool);
				}

				/// <summary>
				/// <para>Creates a new waiting thread. Called by getRoutePool when necessary.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a waiting thread representation </para>
				/// </returns>
				/// <java-name>
				/// newWaitingThread
				/// </java-name>
				[Dot42.DexImport("newWaitingThread", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpec" +
    "ificPool;)Lorg/apache/http/impl/conn/tsccm/WaitingThread;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread NewWaitingThread(global::Java.Util.Concurrent.Locks.ICondition cond, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool rospl) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread);
				}

				/// <summary>
				/// <para>Get a route-specific pool of available connections.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the pool for the argument route, never <code>null</code> if <code>create</code> is <code>true</code> </para>
				/// </returns>
				/// <java-name>
				/// getRoutePool
				/// </java-name>
				[Dot42.DexImport("getRoutePool", "(Lorg/apache/http/conn/routing/HttpRoute;Z)Lorg/apache/http/impl/conn/tsccm/Route" +
    "SpecificPool;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool GetRoutePool(global::Org.Apache.Http.Conn.Routing.HttpRoute route, bool create) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool);
				}

				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				[Dot42.DexImport("getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1)]
				public virtual int GetConnectionsInPool(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestPoolEntry
				/// </java-name>
				[Dot42.DexImport("requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl" +
    "/conn/tsccm/PoolEntryRequest;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Impl.Conn.Tsccm.IPoolEntryRequest RequestPoolEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.IPoolEntryRequest);
				}

				/// <summary>
				/// <para>Obtains a pool entry with a connection within the given timeout. If a WaitingThread is used to block, WaitingThreadAborter#setWaitingThread(WaitingThread) must be called before blocking, to allow the thread to be interrupted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>pool entry holding a connection for the route</para>
				/// </returns>
				/// <java-name>
				/// getEntryBlocking
				/// </java-name>
				[Dot42.DexImport("getEntryBlocking", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent" +
    "/TimeUnit;Lorg/apache/http/impl/conn/tsccm/WaitingThreadAborter;)Lorg/apache/htt" +
    "p/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetEntryBlocking(global::Org.Apache.Http.Conn.Routing.HttpRoute route, object state, long timeout, global::Java.Util.Concurrent.TimeUnit tunit, global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThreadAborter aborter) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <summary>
				/// <para>Returns an entry into the pool. The connection of the entry is expected to be in a suitable state, either open and re-usable, or closed. The pool will not make any attempt to determine whether it can be re-used or not.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// freeEntry
				/// </java-name>
				[Dot42.DexImport("freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit" +
    ";)V", AccessFlags = 1)]
				public override void FreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry, bool reusable, long validDuration, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If available, get a free pool entry for a route.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an available pool entry for the given route, or <code>null</code> if none is available </para>
				/// </returns>
				/// <java-name>
				/// getFreeEntry
				/// </java-name>
				[Dot42.DexImport("getFreeEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Ljava/lang/Object;)Lorg/apach" +
    "e/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetFreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool rospl, object state) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <summary>
				/// <para>Creates a new pool entry. This method assumes that the new connection will be handed out immediately.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new pool entry for a new connection </para>
				/// </returns>
				/// <java-name>
				/// createEntry
				/// </java-name>
				[Dot42.DexImport("createEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Lorg/apache/http/conn/ClientC" +
    "onnectionOperator;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry CreateEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool rospl, global::Org.Apache.Http.Conn.IClientConnectionOperator op) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <summary>
				/// <para>Deletes a given pool entry. This closes the pooled connection and removes all references, so that it can be GCed.</para><para><b>Note:</b> Does not remove the entry from the freeConnections list. It is assumed that the caller has already handled this step.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// deleteEntry
				/// </java-name>
				[Dot42.DexImport("deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", AccessFlags = 4)]
				protected internal virtual void DeleteEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Delete an old, free pool entry to make room for a new one. Used to replace pool entries with ones for a different route. </para>        
				/// </summary>
				/// <java-name>
				/// deleteLeastUsedEntry
				/// </java-name>
				[Dot42.DexImport("deleteLeastUsedEntry", "()V", AccessFlags = 4)]
				protected internal virtual void DeleteLeastUsedEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handles cleaning up for a lost pool entry with the given route. A lost pool entry corresponds to a connection that was garbage collected instead of being properly released.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// handleLostEntry
				/// </java-name>
				[Dot42.DexImport("handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 4)]
				protected internal override void HandleLostEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute route) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies a waiting thread that a connection is available. This will wake a thread waiting in the specific route pool, if there is one. Otherwise, a thread in the connection pool will be notified.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// notifyWaitingThread
				/// </java-name>
				[Dot42.DexImport("notifyWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V", AccessFlags = 4)]
				protected internal virtual void NotifyWaitingThread(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool rospl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Deletes all entries for closed connections. </para>        
				/// </summary>
				/// <java-name>
				/// deleteClosedConnections
				/// </java-name>
				[Dot42.DexImport("deleteClosedConnections", "()V", AccessFlags = 1)]
				public override void DeleteClosedConnections() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Shuts down this pool and all associated resources. Overriding methods MUST call the implementation here! </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnPoolByRoute() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Basic implementation of a connection pool entry. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/BasicPoolEntry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/BasicPoolEntry", AccessFlags = 33)]
		public partial class BasicPoolEntry : global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new pool entry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/Htt" +
    "pRoute;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/Htt" +
    "pRoute;Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;)V")]
				public BasicPoolEntry(global::Org.Apache.Http.Conn.IClientConnectionOperator op, global::Org.Apache.Http.Conn.Routing.HttpRoute route, global::Java.Lang.Ref.ReferenceQueue<object> queue) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 20)]
				protected internal global::Org.Apache.Http.Conn.IOperatedClientConnection GetConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IOperatedClientConnection);
				}

				/// <java-name>
				/// getPlannedRoute
				/// </java-name>
				[Dot42.DexImport("getPlannedRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 20)]
				protected internal global::Org.Apache.Http.Conn.Routing.HttpRoute GetPlannedRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// getWeakRef
				/// </java-name>
				[Dot42.DexImport("getWeakRef", "()Lorg/apache/http/impl/conn/tsccm/BasicPoolEntryRef;", AccessFlags = 20)]
				protected internal global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntryRef GetWeakRef() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntryRef);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicPoolEntry() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				protected internal global::Org.Apache.Http.Conn.IOperatedClientConnection Connection
				{
				[Dot42.DexImport("getConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", AccessFlags = 20)]
						get{ return GetConnection(); }
				}

				/// <java-name>
				/// getPlannedRoute
				/// </java-name>
				protected internal global::Org.Apache.Http.Conn.Routing.HttpRoute PlannedRoute
				{
				[Dot42.DexImport("getPlannedRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 20)]
						get{ return GetPlannedRoute(); }
				}

				/// <java-name>
				/// getWeakRef
				/// </java-name>
				protected internal global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntryRef WeakRef
				{
				[Dot42.DexImport("getWeakRef", "()Lorg/apache/http/impl/conn/tsccm/BasicPoolEntryRef;", AccessFlags = 20)]
						get{ return GetWeakRef(); }
				}

		}

}


