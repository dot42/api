#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Conn.Tsccm
{
		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/BasicPoolEntry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/BasicPoolEntry", AccessFlags = 33)]
		public partial class BasicPoolEntry : global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/Htt" +
    "pRoute;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/Htt" +
    "pRoute;Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;)V")]
				public BasicPoolEntry(global::Org.Apache.Http.Conn.IClientConnectionOperator clientConnectionOperator, global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, global::Java.Lang.Ref.ReferenceQueue<object> referenceQueue) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1)]
				public virtual void Abort() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWaitingThread
				/// </java-name>
				[Dot42.DexImport("setWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", AccessFlags = 1)]
				public virtual void SetWaitingThread(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread waitingThread) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/BasicPoolEntryRef
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/BasicPoolEntryRef", AccessFlags = 33, Signature = "Ljava/lang/ref/WeakReference<Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;>;")]
		public partial class BasicPoolEntryRef : global::Java.Lang.Ref.WeakReference<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;Ljava/lang/ref/ReferenceQueue;)V" +
    "", AccessFlags = 1, Signature = "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;Ljava/lang/ref/ReferenceQueue<Lj" +
    "ava/lang/Object;>;)V")]
				public BasicPoolEntryRef(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry, global::Java.Lang.Ref.ReferenceQueue<object> referenceQueue) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getRoute
				/// </java-name>
				public global::Org.Apache.Http.Conn.Routing.HttpRoute Route
				{
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
						get{ return GetRoute(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager", AccessFlags = 33)]
		public partial class ThreadSafeClientConnManager : global::Org.Apache.Http.Conn.IClientConnectionManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// schemeRegistry
				/// </java-name>
				[Dot42.DexImport("schemeRegistry", "Lorg/apache/http/conn/scheme/SchemeRegistry;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.Scheme.SchemeRegistry SchemeRegistry;
				/// <java-name>
				/// connectionPool
				/// </java-name>
				[Dot42.DexImport("connectionPool", "Lorg/apache/http/impl/conn/tsccm/AbstractConnPool;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool ConnectionPool;
				/// <java-name>
				/// connOperator
				/// </java-name>
				[Dot42.DexImport("connOperator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Conn.IClientConnectionOperator ConnOperator;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)" +
    "V", AccessFlags = 1)]
				public ThreadSafeClientConnManager(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ThreadSafeClientConnManager() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createConnectionPool
				/// </java-name>
				[Dot42.DexImport("createConnectionPool", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/impl/conn/tsccm/AbstractCon" +
    "nPool;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool CreateConnectionPool(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool);
				}

				/// <java-name>
				/// createConnectionOperator
				/// </java-name>
				[Dot42.DexImport("createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnect" +
    "ionOperator;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Conn.IClientConnectionOperator CreateConnectionOperator(global::Org.Apache.Http.Conn.Scheme.SchemeRegistry schemeRegistry) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionOperator);
				}

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
				public virtual global::Org.Apache.Http.Conn.IClientConnectionRequest RequestConnection(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.IClientConnectionRequest);
				}

				/// <java-name>
				/// releaseConnection
				/// </java-name>
				[Dot42.DexImport("releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V" +
    "", AccessFlags = 1)]
				public virtual void ReleaseConnection(global::Org.Apache.Http.Conn.IManagedClientConnection managedClientConnection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				[Dot42.DexImport("getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1)]
				public virtual int GetConnectionsInPool(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				[Dot42.DexImport("getConnectionsInPool", "()I", AccessFlags = 1)]
				public virtual int GetConnectionsInPool() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				public int ConnectionsInPool
				{
				[Dot42.DexImport("getConnectionsInPool", "()I", AccessFlags = 1)]
						get{ return GetConnectionsInPool(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/RefQueueWorker
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/RefQueueWorker", AccessFlags = 33)]
		public partial class RefQueueWorker : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// refQueue
				/// </java-name>
				[Dot42.DexImport("refQueue", "Ljava/lang/ref/ReferenceQueue;", AccessFlags = 20)]
				protected internal readonly global::Java.Lang.Ref.ReferenceQueue<object> RefQueue;
				/// <java-name>
				/// refHandler
				/// </java-name>
				[Dot42.DexImport("refHandler", "Lorg/apache/http/impl/conn/tsccm/RefQueueHandler;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Impl.Conn.Tsccm.IRefQueueHandler RefHandler;
				/// <java-name>
				/// workerThread
				/// </java-name>
				[Dot42.DexImport("workerThread", "Ljava/lang/Thread;", AccessFlags = 68)]
				protected internal global::System.Threading.Thread WorkerThread;
				[Dot42.DexImport("<init>", "(Ljava/lang/ref/ReferenceQueue;Lorg/apache/http/impl/conn/tsccm/RefQueueHandler;)" +
    "V", AccessFlags = 1, Signature = "(Ljava/lang/ref/ReferenceQueue<*>;Lorg/apache/http/impl/conn/tsccm/RefQueueHandle" +
    "r;)V")]
				public RefQueueWorker(global::Java.Lang.Ref.ReferenceQueue<object> referenceQueue, global::Org.Apache.Http.Impl.Conn.Tsccm.IRefQueueHandler refQueueHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RefQueueWorker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/RefQueueHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/RefQueueHandler", AccessFlags = 1537)]
		public partial interface IRefQueueHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handleReference
				/// </java-name>
				[Dot42.DexImport("handleReference", "(Ljava/lang/ref/Reference;)V", AccessFlags = 1025, Signature = "(Ljava/lang/ref/Reference<*>;)V")]
				void HandleReference(global::Java.Lang.Ref.Reference<object> reference) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/ConnPoolByRoute
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/ConnPoolByRoute", AccessFlags = 33)]
		public partial class ConnPoolByRoute : global::Org.Apache.Http.Impl.Conn.Tsccm.AbstractConnPool
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// operator
				/// </java-name>
				[Dot42.DexImport("operator", "Lorg/apache/http/conn/ClientConnectionOperator;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.IClientConnectionOperator Operator;
				/// <java-name>
				/// freeConnections
				/// </java-name>
				[Dot42.DexImport("freeConnections", "Ljava/util/Queue;", AccessFlags = 4)]
				protected internal global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry> FreeConnections;
				/// <java-name>
				/// waitingThreads
				/// </java-name>
				[Dot42.DexImport("waitingThreads", "Ljava/util/Queue;", AccessFlags = 4)]
				protected internal global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread> WaitingThreads;
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
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/params/HttpParam" +
    "s;)V", AccessFlags = 1)]
				public ConnPoolByRoute(global::Org.Apache.Http.Conn.IClientConnectionOperator clientConnectionOperator, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createFreeConnQueue
				/// </java-name>
				[Dot42.DexImport("createFreeConnQueue", "()Ljava/util/Queue;", AccessFlags = 4, Signature = "()Ljava/util/Queue<Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;>;")]
				protected internal virtual global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry> CreateFreeConnQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry>);
				}

				/// <java-name>
				/// createWaitingThreadQueue
				/// </java-name>
				[Dot42.DexImport("createWaitingThreadQueue", "()Ljava/util/Queue;", AccessFlags = 4, Signature = "()Ljava/util/Queue<Lorg/apache/http/impl/conn/tsccm/WaitingThread;>;")]
				protected internal virtual global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread> CreateWaitingThreadQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread>);
				}

				/// <java-name>
				/// createRouteToPoolMap
				/// </java-name>
				[Dot42.DexImport("createRouteToPoolMap", "()Ljava/util/Map;", AccessFlags = 4, Signature = "()Ljava/util/Map<Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/impl/co" +
    "nn/tsccm/RouteSpecificPool;>;")]
				protected internal virtual global::Java.Util.IMap<global::Org.Apache.Http.Conn.Routing.HttpRoute, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool> CreateRouteToPoolMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<global::Org.Apache.Http.Conn.Routing.HttpRoute, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool>);
				}

				/// <java-name>
				/// newRouteSpecificPool
				/// </java-name>
				[Dot42.DexImport("newRouteSpecificPool", "(Lorg/apache/http/conn/routing/HttpRoute;)Lorg/apache/http/impl/conn/tsccm/RouteS" +
    "pecificPool;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool NewRouteSpecificPool(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool);
				}

				/// <java-name>
				/// newWaitingThread
				/// </java-name>
				[Dot42.DexImport("newWaitingThread", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpec" +
    "ificPool;)Lorg/apache/http/impl/conn/tsccm/WaitingThread;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread NewWaitingThread(global::Java.Util.Concurrent.Locks.ICondition condition, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool routeSpecificPool) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread);
				}

				/// <java-name>
				/// getRoutePool
				/// </java-name>
				[Dot42.DexImport("getRoutePool", "(Lorg/apache/http/conn/routing/HttpRoute;Z)Lorg/apache/http/impl/conn/tsccm/Route" +
    "SpecificPool;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool GetRoutePool(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool);
				}

				/// <java-name>
				/// getConnectionsInPool
				/// </java-name>
				[Dot42.DexImport("getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I", AccessFlags = 1)]
				public virtual int GetConnectionsInPool(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestPoolEntry
				/// </java-name>
				[Dot42.DexImport("requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl" +
    "/conn/tsccm/PoolEntryRequest;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Impl.Conn.Tsccm.IPoolEntryRequest RequestPoolEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.IPoolEntryRequest);
				}

				/// <java-name>
				/// getEntryBlocking
				/// </java-name>
				[Dot42.DexImport("getEntryBlocking", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent" +
    "/TimeUnit;Lorg/apache/http/impl/conn/tsccm/WaitingThreadAborter;)Lorg/apache/htt" +
    "p/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetEntryBlocking(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit, global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThreadAborter waitingThreadAborter) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <java-name>
				/// freeEntry
				/// </java-name>
				[Dot42.DexImport("freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit" +
    ";)V", AccessFlags = 1)]
				public override void FreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry, bool boolean, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFreeEntry
				/// </java-name>
				[Dot42.DexImport("getFreeEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Ljava/lang/Object;)Lorg/apach" +
    "e/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetFreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool routeSpecificPool, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <java-name>
				/// createEntry
				/// </java-name>
				[Dot42.DexImport("createEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Lorg/apache/http/conn/ClientC" +
    "onnectionOperator;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry CreateEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool routeSpecificPool, global::Org.Apache.Http.Conn.IClientConnectionOperator clientConnectionOperator) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <java-name>
				/// deleteEntry
				/// </java-name>
				[Dot42.DexImport("deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", AccessFlags = 4)]
				protected internal virtual void DeleteEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteLeastUsedEntry
				/// </java-name>
				[Dot42.DexImport("deleteLeastUsedEntry", "()V", AccessFlags = 4)]
				protected internal virtual void DeleteLeastUsedEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleLostEntry
				/// </java-name>
				[Dot42.DexImport("handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 4)]
				protected internal override void HandleLostEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyWaitingThread
				/// </java-name>
				[Dot42.DexImport("notifyWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V", AccessFlags = 4)]
				protected internal virtual void NotifyWaitingThread(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool routeSpecificPool) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteClosedConnections
				/// </java-name>
				[Dot42.DexImport("deleteClosedConnections", "()V", AccessFlags = 1)]
				public override void DeleteClosedConnections() /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/AbstractConnPool
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/AbstractConnPool", AccessFlags = 1057)]
		public abstract partial class AbstractConnPool : global::Org.Apache.Http.Impl.Conn.Tsccm.IRefQueueHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// poolLock
				/// </java-name>
				[Dot42.DexImport("poolLock", "Ljava/util/concurrent/locks/Lock;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.Concurrent.Locks.ILock PoolLock;
				/// <java-name>
				/// issuedConnections
				/// </java-name>
				[Dot42.DexImport("issuedConnections", "Ljava/util/Set;", AccessFlags = 4)]
				protected internal global::Java.Util.ISet<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntryRef> IssuedConnections;
				/// <java-name>
				/// idleConnHandler
				/// </java-name>
				[Dot42.DexImport("idleConnHandler", "Lorg/apache/http/impl/conn/IdleConnectionHandler;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Impl.Conn.IdleConnectionHandler IdleConnHandler;
				/// <java-name>
				/// numConnections
				/// </java-name>
				[Dot42.DexImport("numConnections", "I", AccessFlags = 4)]
				protected internal int NumConnections;
				/// <java-name>
				/// refQueue
				/// </java-name>
				[Dot42.DexImport("refQueue", "Ljava/lang/ref/ReferenceQueue;", AccessFlags = 4)]
				protected internal global::Java.Lang.Ref.ReferenceQueue<object> RefQueue;
				/// <java-name>
				/// isShutDown
				/// </java-name>
				[Dot42.DexImport("isShutDown", "Z", AccessFlags = 68)]
				protected internal bool IsShutDown;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractConnPool() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableConnectionGC
				/// </java-name>
				[Dot42.DexImport("enableConnectionGC", "()V", AccessFlags = 1)]
				public virtual void EnableConnectionGC() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent" +
    "/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 17)]
				public global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <java-name>
				/// requestPoolEntry
				/// </java-name>
				[Dot42.DexImport("requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl" +
    "/conn/tsccm/PoolEntryRequest;", AccessFlags = 1025)]
				public abstract global::Org.Apache.Http.Impl.Conn.Tsccm.IPoolEntryRequest RequestPoolEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// freeEntry
				/// </java-name>
				[Dot42.DexImport("freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit" +
    ";)V", AccessFlags = 1025)]
				public abstract void FreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry, bool boolean, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// handleReference
				/// </java-name>
				[Dot42.DexImport("handleReference", "(Ljava/lang/ref/Reference;)V", AccessFlags = 1)]
				public virtual void HandleReference(global::Java.Lang.Ref.Reference<object> reference) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleLostEntry
				/// </java-name>
				[Dot42.DexImport("handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", AccessFlags = 1028)]
				protected internal abstract void HandleLostEntry(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeIdleConnections
				/// </java-name>
				[Dot42.DexImport("closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void CloseIdleConnections(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeExpiredConnections
				/// </java-name>
				[Dot42.DexImport("closeExpiredConnections", "()V", AccessFlags = 1)]
				public virtual void CloseExpiredConnections() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteClosedConnections
				/// </java-name>
				[Dot42.DexImport("deleteClosedConnections", "()V", AccessFlags = 1025)]
				public abstract void DeleteClosedConnections() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeConnection
				/// </java-name>
				[Dot42.DexImport("closeConnection", "(Lorg/apache/http/conn/OperatedClientConnection;)V", AccessFlags = 4)]
				protected internal virtual void CloseConnection(global::Org.Apache.Http.Conn.IOperatedClientConnection operatedClientConnection) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/PoolEntryRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/PoolEntryRequest", AccessFlags = 1537)]
		public partial interface IPoolEntryRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPoolEntry
				/// </java-name>
				[Dot42.DexImport("getPoolEntry", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry" +
    ";", AccessFlags = 1025)]
				global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry GetPoolEntry(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// abortRequest
				/// </java-name>
				[Dot42.DexImport("abortRequest", "()V", AccessFlags = 1025)]
				void AbortRequest() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/RouteSpecificPool
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/RouteSpecificPool", AccessFlags = 33)]
		public partial class RouteSpecificPool
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// route
				/// </java-name>
				[Dot42.DexImport("route", "Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Conn.Routing.HttpRoute Route;
				/// <java-name>
				/// maxEntries
				/// </java-name>
				[Dot42.DexImport("maxEntries", "I", AccessFlags = 20)]
				protected internal readonly int MaxEntries;
				/// <java-name>
				/// freeEntries
				/// </java-name>
				[Dot42.DexImport("freeEntries", "Ljava/util/LinkedList;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.LinkedList<global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry> FreeEntries;
				/// <java-name>
				/// waitingThreads
				/// </java-name>
				[Dot42.DexImport("waitingThreads", "Ljava/util/Queue;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.IQueue<global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread> WaitingThreads;
				/// <java-name>
				/// numEntries
				/// </java-name>
				[Dot42.DexImport("numEntries", "I", AccessFlags = 4)]
				protected internal int NumEntries;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/conn/routing/HttpRoute;I)V", AccessFlags = 1)]
				public RouteSpecificPool(global::Org.Apache.Http.Conn.Routing.HttpRoute httpRoute, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoute
				/// </java-name>
				[Dot42.DexImport("getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", AccessFlags = 17)]
				public global::Org.Apache.Http.Conn.Routing.HttpRoute GetRoute() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Routing.HttpRoute);
				}

				/// <java-name>
				/// getMaxEntries
				/// </java-name>
				[Dot42.DexImport("getMaxEntries", "()I", AccessFlags = 17)]
				public int GetMaxEntries() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isUnused
				/// </java-name>
				[Dot42.DexImport("isUnused", "()Z", AccessFlags = 1)]
				public virtual bool IsUnused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCapacity
				/// </java-name>
				[Dot42.DexImport("getCapacity", "()I", AccessFlags = 1)]
				public virtual int GetCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEntryCount
				/// </java-name>
				[Dot42.DexImport("getEntryCount", "()I", AccessFlags = 17)]
				public int GetEntryCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// allocEntry
				/// </java-name>
				[Dot42.DexImport("allocEntry", "(Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry AllocEntry(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry);
				}

				/// <java-name>
				/// freeEntry
				/// </java-name>
				[Dot42.DexImport("freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", AccessFlags = 1)]
				public virtual void FreeEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createdEntry
				/// </java-name>
				[Dot42.DexImport("createdEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", AccessFlags = 1)]
				public virtual void CreatedEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteEntry
				/// </java-name>
				[Dot42.DexImport("deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)Z", AccessFlags = 1)]
				public virtual bool DeleteEntry(global::Org.Apache.Http.Impl.Conn.Tsccm.BasicPoolEntry basicPoolEntry) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dropEntry
				/// </java-name>
				[Dot42.DexImport("dropEntry", "()V", AccessFlags = 1)]
				public virtual void DropEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// queueThread
				/// </java-name>
				[Dot42.DexImport("queueThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", AccessFlags = 1)]
				public virtual void QueueThread(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread waitingThread) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasThread
				/// </java-name>
				[Dot42.DexImport("hasThread", "()Z", AccessFlags = 1)]
				public virtual bool HasThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextThread
				/// </java-name>
				[Dot42.DexImport("nextThread", "()Lorg/apache/http/impl/conn/tsccm/WaitingThread;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread NextThread() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread);
				}

				/// <java-name>
				/// removeThread
				/// </java-name>
				[Dot42.DexImport("removeThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", AccessFlags = 1)]
				public virtual void RemoveThread(global::Org.Apache.Http.Impl.Conn.Tsccm.WaitingThread waitingThread) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RouteSpecificPool() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCapacity
				/// </java-name>
				public int Capacity
				{
				[Dot42.DexImport("getCapacity", "()I", AccessFlags = 1)]
						get{ return GetCapacity(); }
				}

				/// <java-name>
				/// getEntryCount
				/// </java-name>
				public int EntryCount
				{
				[Dot42.DexImport("getEntryCount", "()I", AccessFlags = 17)]
						get{ return GetEntryCount(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter", AccessFlags = 33)]
		public partial class BasicPooledConnAdapter : global::Org.Apache.Http.Impl.Conn.AbstractPooledConnAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager;Lorg/apache/http/im" +
    "pl/conn/AbstractPoolEntry;)V", AccessFlags = 4)]
				protected internal BasicPooledConnAdapter(global::Org.Apache.Http.Impl.Conn.Tsccm.ThreadSafeClientConnManager threadSafeClientConnManager, global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry abstractPoolEntry) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getPoolEntry
				/// </java-name>
				[Dot42.DexImport("getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry GetPoolEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry);
				}

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

				/// <java-name>
				/// getPoolEntry
				/// </java-name>
				protected internal global::Org.Apache.Http.Impl.Conn.AbstractPoolEntry PoolEntry
				{
				[Dot42.DexImport("getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;", AccessFlags = 4)]
						get{ return GetPoolEntry(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/conn/tsccm/WaitingThread
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/conn/tsccm/WaitingThread", AccessFlags = 33)]
		public partial class WaitingThread
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpec" +
    "ificPool;)V", AccessFlags = 1)]
				public WaitingThread(global::Java.Util.Concurrent.Locks.ICondition condition, global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool routeSpecificPool) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCondition
				/// </java-name>
				[Dot42.DexImport("getCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 17)]
				public global::Java.Util.Concurrent.Locks.ICondition GetCondition() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Locks.ICondition);
				}

				/// <java-name>
				/// getPool
				/// </java-name>
				[Dot42.DexImport("getPool", "()Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", AccessFlags = 17)]
				public global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool GetPool() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool);
				}

				/// <java-name>
				/// getThread
				/// </java-name>
				[Dot42.DexImport("getThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
				public global::System.Threading.Thread GetThread() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread);
				}

				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool Await(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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

				/// <java-name>
				/// getCondition
				/// </java-name>
				public global::Java.Util.Concurrent.Locks.ICondition Condition
				{
				[Dot42.DexImport("getCondition", "()Ljava/util/concurrent/locks/Condition;", AccessFlags = 17)]
						get{ return GetCondition(); }
				}

				/// <java-name>
				/// getPool
				/// </java-name>
				public global::Org.Apache.Http.Impl.Conn.Tsccm.RouteSpecificPool Pool
				{
				[Dot42.DexImport("getPool", "()Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", AccessFlags = 17)]
						get{ return GetPool(); }
				}

				/// <java-name>
				/// getThread
				/// </java-name>
				public global::System.Threading.Thread Thread
				{
				[Dot42.DexImport("getThread", "()Ljava/lang/Thread;", AccessFlags = 17)]
						get{ return GetThread(); }
				}

		}

}

