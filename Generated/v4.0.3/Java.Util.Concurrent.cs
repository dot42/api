#pragma warning disable 1717
namespace Java.Util.Concurrent
{
		/// <java-name>
		/// java/util/concurrent/AbstractExecutorService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/AbstractExecutorService", AccessFlags = 1057)]
		public abstract partial class AbstractExecutorService : global::Java.Util.Concurrent.IExecutorService
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractExecutorService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newTaskFor
				/// </java-name>
				[Dot42.DexImport("newTaskFor", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/RunnableFuture;", AccessFlags = 4, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/RunnableFutu" +
    "re<TT;>;")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableFuture<T> NewTaskFor<T>(global::Java.Lang.IRunnable runnable, T t) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableFuture<T>);
				}

				/// <java-name>
				/// newTaskFor
				/// </java-name>
				[Dot42.DexImport("newTaskFor", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/RunnableFuture;", AccessFlags = 4, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/RunnableFuture<TT;>;")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableFuture<T> NewTaskFor<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableFuture<T>);
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
				public virtual global::Java.Util.Concurrent.IFuture<object> Submit(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<object>);
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;" +
    "")]
				public virtual global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Lang.IRunnable runnable, T t) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Future<TT;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)TT;")]
				public virtual T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)TT;")]
				public virtual T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
				public virtual global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future" +
    "<TT;>;>;")]
				public virtual global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "shutdown", "()V", AccessFlags = 1025)]
				public virtual void Shutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "shutdownNow", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				public virtual global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.IRunnable>);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "isShutdown", "()Z", AccessFlags = 1025)]
				public virtual bool IsShutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "isTerminated", "()Z", AccessFlags = 1025)]
				public virtual bool IsTerminated() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				public virtual bool AwaitTermination(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/Executor", "execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1025)]
				public virtual void Execute(global::Java.Lang.IRunnable runnable) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/ArrayBlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ArrayBlockingQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class ArrayBlockingQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayBlockingQueue(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public ArrayBlockingQueue(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IZLjava/util/Collection;)V", AccessFlags = 1, Signature = "(IZLjava/util/Collection<+TE;>;)V")]
				public ArrayBlockingQueue(int int32, bool boolean, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ArrayBlockingQueue() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/util/Queue", "remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Remove() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Element() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/concurrent/BrokenBarrierException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/BrokenBarrierException", AccessFlags = 33)]
		public partial class BrokenBarrierException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BrokenBarrierException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BrokenBarrierException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/CancellationException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CancellationException", AccessFlags = 33)]
		public partial class CancellationException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CancellationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CancellationException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/ConcurrentHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/concurrent/ConcurrentMap<TK;TV;>;Ljava/io/Serializable;")]
		public partial class ConcurrentHashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.Concurrent.IConcurrentMap<K, V>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(IFI)V", AccessFlags = 1)]
				public ConcurrentHashMap(int int32, float single, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public ConcurrentHashMap(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ConcurrentHashMap(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentHashMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public ConcurrentHashMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsKey(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsValue(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// putIfAbsent
				/// </java-name>
				[Dot42.DexImport("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V PutIfAbsent(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Remove(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TK;TV;TV;)Z")]
				public virtual bool Replace(K k, V v, V v1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V Replace(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<TK;>;")]
				public virtual global::Java.Util.IEnumeration<K> Keys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<K>);
				}

				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<TV;>;")]
				public virtual global::Java.Util.IEnumeration<V> Elements() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<V>);
				}

				[Dot42.DexImport("java/util/Map", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Map", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// java/util/concurrent/ConcurrentLinkedQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentLinkedQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/Queue<TE;>;Ljava/i" +
    "o/Serializable;")]
		public partial class ConcurrentLinkedQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.IQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentLinkedQueue() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ConcurrentLinkedQueue(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/Queue", "remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Remove() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Element() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "clear", "()V", AccessFlags = 1025)]
				public override void Clear() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("java/util/Collection", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/concurrent/ConcurrentSkipListMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentSkipListMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/concurrent/ConcurrentNavigableMap<TK;TV;>;Ljava/lang/Cloneable;Ljava/io/Seria" +
    "lizable;")]
		public partial class ConcurrentSkipListMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentSkipListMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TK;>;)V")]
				public ConcurrentSkipListMap(global::Java.Util.IComparator<K> comparator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public ConcurrentSkipListMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/SortedMap;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedMap<TK;+TV;>;)V")]
				public ConcurrentSkipListMap(global::Java.Util.ISortedMap<K, V> sortedMap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/concurrent/ConcurrentSkipListMap;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/ConcurrentSkipListMap<TK;TV;>;")]
				public new virtual global::Java.Util.Concurrent.ConcurrentSkipListMap<K, V> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ConcurrentSkipListMap<K, V>);
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsKey(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsValue(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public new virtual global::Java.Util.INavigableSet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				/// <java-name>
				/// navigableKeySet
				/// </java-name>
				[Dot42.DexImport("navigableKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public virtual global::Java.Util.INavigableSet<K> NavigableKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public virtual global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putIfAbsent
				/// </java-name>
				[Dot42.DexImport("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V PutIfAbsent(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Remove(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TK;TV;TV;)Z")]
				public virtual bool Replace(K k, V v, V v1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V Replace(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TK;>;")]
				public virtual global::Java.Util.IComparator<K> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<K>);
				}

				/// <java-name>
				/// firstKey
				/// </java-name>
				[Dot42.DexImport("firstKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K FirstKey() /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <java-name>
				/// lastKey
				/// </java-name>
				[Dot42.DexImport("lastKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K LastKey() /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigable" +
    "Map;", AccessFlags = 1, Signature = "(TK;ZTK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K k, bool boolean, K k1, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K k, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K k, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMa" +
    "p;", AccessFlags = 1, Signature = "(TK;TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K k, K k1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <java-name>
				/// lowerEntry
				/// </java-name>
				[Dot42.DexImport("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LowerEntry(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// lowerKey
				/// </java-name>
				[Dot42.DexImport("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K LowerKey(K k) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <java-name>
				/// floorEntry
				/// </java-name>
				[Dot42.DexImport("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> FloorEntry(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// floorKey
				/// </java-name>
				[Dot42.DexImport("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K FloorKey(K k) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <java-name>
				/// ceilingEntry
				/// </java-name>
				[Dot42.DexImport("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> CeilingEntry(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// ceilingKey
				/// </java-name>
				[Dot42.DexImport("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K CeilingKey(K k) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <java-name>
				/// higherEntry
				/// </java-name>
				[Dot42.DexImport("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> HigherEntry(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// higherKey
				/// </java-name>
				[Dot42.DexImport("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K HigherKey(K k) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <java-name>
				/// firstEntry
				/// </java-name>
				[Dot42.DexImport("firstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> FirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// lastEntry
				/// </java-name>
				[Dot42.DexImport("lastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LastEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// pollFirstEntry
				/// </java-name>
				[Dot42.DexImport("pollFirstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> PollFirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <java-name>
				/// pollLastEntry
				/// </java-name>
				[Dot42.DexImport("pollLastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> PollLastEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "descendingMap", "()Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.DescendingMap() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.SubMap(K k, bool boolean, K k1, bool boolean1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.HeadMap(K k, bool boolean) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.TailMap(K k, bool boolean) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> global::Java.Util.INavigableMap<K, V>.SubMap(K k, K k1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> global::Java.Util.INavigableMap<K, V>.HeadMap(K k) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> global::Java.Util.INavigableMap<K, V>.TailMap(K k) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				[Dot42.DexImport("java/util/Map", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Map", "keySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<TK;>;")]
				global::Java.Util.ISet<K> global::Java.Util.IMap<K, V>.KeySet() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				[Dot42.DexImport("java/util/Map", "putAll", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/ConcurrentSkipListSet
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentSkipListSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/util/NavigableSet<TE;>;Lj" +
    "ava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class ConcurrentSkipListSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.INavigableSet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentSkipListSet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TE;>;)V")]
				public ConcurrentSkipListSet(global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ConcurrentSkipListSet(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/SortedSet;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedSet<TE;>;)V")]
				public ConcurrentSkipListSet(global::Java.Util.ISortedSet<E> sortedSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/concurrent/ConcurrentSkipListSet;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/ConcurrentSkipListSet<TE;>;")]
				public virtual global::Java.Util.Concurrent.ConcurrentSkipListSet<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ConcurrentSkipListSet<E>);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lower
				/// </java-name>
				[Dot42.DexImport("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Lower(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Floor(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// ceiling
				/// </java-name>
				[Dot42.DexImport("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Ceiling(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// higher
				/// </java-name>
				[Dot42.DexImport("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Higher(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TE;>;")]
				public virtual global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<E>);
				}

				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E First() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Last() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> SubSet(E e, bool boolean, E e1, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> HeadSet(E e, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> TailSet(E e, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;TE;)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> SubSet(E e, E e1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> HeadSet(E e) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> TailSet(E e) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <java-name>
				/// descendingSet
				/// </java-name>
				[Dot42.DexImport("descendingSet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> DescendingSet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				[Dot42.DexImport("java/util/NavigableSet", "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> global::Java.Util.INavigableSet<E>.SubSet(E e, E e1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				[Dot42.DexImport("java/util/NavigableSet", "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> global::Java.Util.INavigableSet<E>.HeadSet(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				[Dot42.DexImport("java/util/NavigableSet", "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> global::Java.Util.INavigableSet<E>.TailSet(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				[Dot42.DexImport("java/util/Set", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Set", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				public override object[] ToArray() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object[]);
				}

				[Dot42.DexImport("java/util/Set", "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <java-name>
		/// java/util/concurrent/CopyOnWriteArrayList
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CopyOnWriteArrayList", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/List<TE;>;Ljava/util/RandomAcc" +
    "ess;Ljava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class CopyOnWriteArrayList<E> : global::Java.Util.IList<E>, global::Java.Util.IRandomAccess, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CopyOnWriteArrayList() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public CopyOnWriteArrayList(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/Object;)V", AccessFlags = 1, Signature = "([TE;)V")]
				public CopyOnWriteArrayList(E[] p) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TE;I)I")]
				public virtual int IndexOf(E e, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TE;I)I")]
				public virtual int LastIndexOf(E e, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1, Signature = "()Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 1, Signature = "(II)Ljava/util/List<TE;>;")]
				public virtual global::Java.Util.IList<E> SubList(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public virtual T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 33, Signature = "(TE;)Z")]
				public virtual bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 33, Signature = "(ITE;)V")]
				public virtual void Add(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 33, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAllAbsent
				/// </java-name>
				[Dot42.DexImport("addAllAbsent", "(Ljava/util/Collection;)I", AccessFlags = 33, Signature = "(Ljava/util/Collection<+TE;>;)I")]
				public virtual int AddAllAbsent(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addIfAbsent
				/// </java-name>
				[Dot42.DexImport("addIfAbsent", "(Ljava/lang/Object;)Z", AccessFlags = 33, Signature = "(TE;)Z")]
				public virtual bool AddIfAbsent(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 33, Signature = "(I)TE;")]
				public virtual E Remove(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(ITE;)TE;")]
				public virtual E Set(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

		}

		/// <java-name>
		/// java/util/concurrent/CopyOnWriteArraySet
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CopyOnWriteArraySet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/io/Serializable;")]
		public partial class CopyOnWriteArraySet<E> : global::Java.Util.AbstractSet<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CopyOnWriteArraySet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public CopyOnWriteArraySet(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/concurrent/CountDownLatch
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CountDownLatch", AccessFlags = 33)]
		public partial class CountDownLatch
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CountDownLatch(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "()V", AccessFlags = 1)]
				public virtual void Await() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool Await(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// countDown
				/// </java-name>
				[Dot42.DexImport("countDown", "()V", AccessFlags = 1)]
				public virtual void CountDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()J", AccessFlags = 1)]
				public virtual long GetCount() /* MethodBuilder.Create */ 
				{
						return default(long);
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
				internal CountDownLatch() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public long Count
				{
				[Dot42.DexImport("getCount", "()J", AccessFlags = 1)]
						get{ return GetCount(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/CyclicBarrier
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CyclicBarrier", AccessFlags = 33)]
		public partial class CyclicBarrier
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(ILjava/lang/Runnable;)V", AccessFlags = 1)]
				public CyclicBarrier(int int32, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CyclicBarrier(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParties
				/// </java-name>
				[Dot42.DexImport("getParties", "()I", AccessFlags = 1)]
				public virtual int GetParties() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "()I", AccessFlags = 1)]
				public virtual int Await() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)I", AccessFlags = 1)]
				public virtual int Await(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isBroken
				/// </java-name>
				[Dot42.DexImport("isBroken", "()Z", AccessFlags = 1)]
				public virtual bool IsBroken() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumberWaiting
				/// </java-name>
				[Dot42.DexImport("getNumberWaiting", "()I", AccessFlags = 1)]
				public virtual int GetNumberWaiting() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CyclicBarrier() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getParties
				/// </java-name>
				public int Parties
				{
				[Dot42.DexImport("getParties", "()I", AccessFlags = 1)]
						get{ return GetParties(); }
				}

				/// <java-name>
				/// getNumberWaiting
				/// </java-name>
				public int NumberWaiting
				{
				[Dot42.DexImport("getNumberWaiting", "()I", AccessFlags = 1)]
						get{ return GetNumberWaiting(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/DelayQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/DelayQueue", AccessFlags = 33, Signature = "<E::Ljava/util/concurrent/Delayed;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concu" +
    "rrent/BlockingQueue<TE;>;")]
		public partial class DelayQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DelayQueue() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public DelayQueue(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/util/concurrent/Delayed;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/util/concurrent/Delayed;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/util/concurrent/Delayed;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/concurrent/BlockingQueue", "contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Contains(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Queue", "remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Remove() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Element() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/concurrent/Exchanger
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Exchanger", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class Exchanger<V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Exchanger() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// exchange
				/// </java-name>
				[Dot42.DexImport("exchange", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TV;)TV;")]
				public virtual V Exchange(V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// exchange
				/// </java-name>
				[Dot42.DexImport("exchange", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TV;JLjava/util/concurrent/TimeUnit;)TV;")]
				public virtual V Exchange(V v, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

		}

		/// <java-name>
		/// java/util/concurrent/ExecutionException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ExecutionException", AccessFlags = 33)]
		public partial class ExecutionException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ExecutionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal ExecutionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ExecutionException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ExecutionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/ExecutorCompletionService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ExecutorCompletionService", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/CompletionService<T" +
    "V;>;")]
		public partial class ExecutorCompletionService<V> : global::Java.Util.Concurrent.ICompletionService<V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/Executor;)V", AccessFlags = 1)]
				public ExecutorCompletionService(global::Java.Util.Concurrent.IExecutor executor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V", AccessFlags = 1, Signature = "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue<Ljava/util/co" +
    "ncurrent/Future<TV;>;>;)V")]
				public ExecutorCompletionService(global::Java.Util.Concurrent.IExecutor executor, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Util.Concurrent.IFuture<V>> blockingQueue) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/util/concurrent/Callable<TV;>;)Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Util.Concurrent.ICallable<V> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;TV;)Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Lang.IRunnable runnable, V v) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Take() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Poll() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExecutorCompletionService() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/Executors
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Executors", AccessFlags = 33)]
		public partial class Executors
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Executors() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newFixedThreadPool
				/// </java-name>
				[Dot42.DexImport("newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewFixedThreadPool(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// newFixedThreadPool
				/// </java-name>
				[Dot42.DexImport("newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewFixedThreadPool(int int32, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// newSingleThreadExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// newSingleThreadExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// newCachedThreadPool
				/// </java-name>
				[Dot42.DexImport("newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// newCachedThreadPool
				/// </java-name>
				[Dot42.DexImport("newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// newSingleThreadScheduledExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewSingleThreadScheduledExecutor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <java-name>
				/// newSingleThreadScheduledExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorServ" +
    "ice;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewSingleThreadScheduledExecutor(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <java-name>
				/// newScheduledThreadPool
				/// </java-name>
				[Dot42.DexImport("newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewScheduledThreadPool(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <java-name>
				/// newScheduledThreadPool
				/// </java-name>
				[Dot42.DexImport("newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorSer" +
    "vice;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewScheduledThreadPool(int int32, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <java-name>
				/// unconfigurableExecutorService
				/// </java-name>
				[Dot42.DexImport("unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService UnconfigurableExecutorService(global::Java.Util.Concurrent.IExecutorService executorService) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <java-name>
				/// unconfigurableScheduledExecutorService
				/// </java-name>
				[Dot42.DexImport("unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledE" +
    "xecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService UnconfigurableScheduledExecutorService(global::Java.Util.Concurrent.IScheduledExecutorService scheduledExecutorService) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <java-name>
				/// defaultThreadFactory
				/// </java-name>
				[Dot42.DexImport("defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IThreadFactory DefaultThreadFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IThreadFactory);
				}

				/// <java-name>
				/// privilegedThreadFactory
				/// </java-name>
				[Dot42.DexImport("privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IThreadFactory PrivilegedThreadFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IThreadFactory);
				}

				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Callable<TT;" +
    ">;")]
				public static global::Java.Util.Concurrent.ICallable<T> Callable<T>(global::Java.Lang.IRunnable runnable, T t) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<T>);
				}

				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable<Ljava/lang/Object;>;")]
				public static global::Java.Util.Concurrent.ICallable<object> Callable(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<object>);
				}

				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/security/PrivilegedAction<*>;)Ljava/util/concurrent/Callable<Ljava/lang/Ob" +
    "ject;>;")]
				public static global::Java.Util.Concurrent.ICallable<object> Callable(global::Java.Security.IPrivilegedAction<object> privilegedAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<object>);
				}

				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/security/PrivilegedExceptionAction<*>;)Ljava/util/concurrent/Callable<Ljav" +
    "a/lang/Object;>;")]
				public static global::Java.Util.Concurrent.ICallable<object> Callable(global::Java.Security.IPrivilegedExceptionAction<object> privilegedExceptionAction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<object>);
				}

				/// <java-name>
				/// privilegedCallable
				/// </java-name>
				[Dot42.DexImport("privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Callable<TT;>;")]
				public static global::Java.Util.Concurrent.ICallable<T> PrivilegedCallable<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<T>);
				}

				/// <java-name>
				/// privilegedCallableUsingCurrentClassLoader
				/// </java-name>
				[Dot42.DexImport("privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Callable<TT;>;")]
				public static global::Java.Util.Concurrent.ICallable<T> PrivilegedCallableUsingCurrentClassLoader<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<T>);
				}

		}

		/// <java-name>
		/// java/util/concurrent/FutureTask
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/FutureTask", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/RunnableFuture<TV;>" +
    ";")]
		public partial class FutureTask<V> : global::Java.Util.Concurrent.IRunnableFuture<V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/Callable;)V", AccessFlags = 1, Signature = "(Ljava/util/concurrent/Callable<TV;>;)V")]
				public FutureTask(global::Java.Util.Concurrent.ICallable<V> callable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;TV;)V")]
				public FutureTask(global::Java.Lang.IRunnable runnable, V v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isCancelled
				/// </java-name>
				[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1)]
				public virtual bool IsCancelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDone
				/// </java-name>
				[Dot42.DexImport("isDone", "()Z", AccessFlags = 1)]
				public virtual bool IsDone() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 1)]
				public virtual bool Cancel(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
				public virtual V Get() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TV;")]
				public virtual V Get(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// done
				/// </java-name>
				[Dot42.DexImport("done", "()V", AccessFlags = 4)]
				protected internal virtual void Done() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(TV;)V")]
				protected internal virtual void Set(V v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setException
				/// </java-name>
				[Dot42.DexImport("setException", "(Ljava/lang/Throwable;)V", AccessFlags = 4)]
				protected internal virtual void SetException(global::System.Exception exception) /* MethodBuilder.Create */ 
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
				/// runAndReset
				/// </java-name>
				[Dot42.DexImport("runAndReset", "()Z", AccessFlags = 4)]
				protected internal virtual bool RunAndReset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FutureTask() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/BlockingDeque
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/BlockingDeque", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/BlockingQueue<TE;>;" +
    "Ljava/util/Deque<TE;>;")]
		public partial interface IBlockingDeque<E> : global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.Util.IDeque<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void AddFirst(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void AddLast(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool OfferFirst(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool OfferLast(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putFirst
				/// </java-name>
				[Dot42.DexImport("putFirst", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void PutFirst(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putLast
				/// </java-name>
				[Dot42.DexImport("putLast", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void PutLast(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool OfferFirst(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool OfferLast(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// takeFirst
				/// </java-name>
				[Dot42.DexImport("takeFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E TakeFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// takeLast
				/// </java-name>
				[Dot42.DexImport("takeLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E TakeLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E PollFirst(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E PollLast(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeFirstOccurrence
				/// </java-name>
				[Dot42.DexImport("removeFirstOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool RemoveFirstOccurrence(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeLastOccurrence
				/// </java-name>
				[Dot42.DexImport("removeLastOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool RemoveLastOccurrence(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Offer(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Put(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Remove() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Poll() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Take() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Element() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Peek() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Push(E e) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/BlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/BlockingQueue", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Queue<TE;>;")]
		public partial interface IBlockingQueue<E> : global::Java.Util.IQueue<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Offer(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Put(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Take() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1025)]
				int RemainingCapacity() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1025, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1025, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/Callable
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Callable", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface ICallable<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// call
				/// </java-name>
				[Dot42.DexImport("call", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V Call() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/CompletionService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CompletionService", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface ICompletionService<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(Ljava/util/concurrent/Callable<TV;>;)Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Util.Concurrent.ICallable<V> callable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;TV;)Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Lang.IRunnable runnable, V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Take() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Poll() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/ConcurrentMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;" +
    ">;")]
		public partial interface IConcurrentMap<K, V> : global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// putIfAbsent
				/// </java-name>
				[Dot42.DexImport("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				V PutIfAbsent(K k, V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object, object object1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TK;TV;TV;)Z")]
				bool Replace(K k, V v, V v1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				V Replace(K k, V v) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/ConcurrentNavigableMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentNavigableMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent" +
    "/ConcurrentMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
		public partial interface IConcurrentNavigableMap<K, V> : global::Java.Util.Concurrent.IConcurrentMap<K, V>, global::Java.Util.INavigableMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigable" +
    "Map;", AccessFlags = 1025, Signature = "(TK;ZTK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K k, bool boolean, K k1, bool boolean1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K k, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K k, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMa" +
    "p;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K k, K k1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "()Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// navigableKeySet
				/// </java-name>
				[Dot42.DexImport("navigableKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> NavigableKeySet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> KeySet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/Delayed
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Delayed", AccessFlags = 1537, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/util/concurrent/Delayed;>;")]
		public partial interface IDelayed : global::System.IComparable<global::Java.Util.Concurrent.IDelayed>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDelay
				/// </java-name>
				[Dot42.DexImport("getDelay", "(Ljava/util/concurrent/TimeUnit;)J", AccessFlags = 1025)]
				long GetDelay(global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/Executor
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Executor", AccessFlags = 1537)]
		public partial interface IExecutor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1025)]
				void Execute(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/ExecutorService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ExecutorService", AccessFlags = 1537)]
		public partial interface IExecutorService : global::Java.Util.Concurrent.IExecutor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1025)]
				void Shutdown() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// shutdownNow
				/// </java-name>
				[Dot42.DexImport("shutdownNow", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isShutdown
				/// </java-name>
				[Dot42.DexImport("isShutdown", "()Z", AccessFlags = 1025)]
				bool IsShutdown() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isTerminated
				/// </java-name>
				[Dot42.DexImport("isTerminated", "()Z", AccessFlags = 1025)]
				bool IsTerminated() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// awaitTermination
				/// </java-name>
				[Dot42.DexImport("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				bool AwaitTermination(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Future<TT;>;")]
				global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;" +
    "")]
				global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Lang.IRunnable runnable, T t) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
				global::Java.Util.Concurrent.IFuture<object> Submit(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
				global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future" +
    "<TT;>;>;")]
				global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)TT;")]
				T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)TT;")]
				T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/Future
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Future", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 1025)]
				bool Cancel(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isCancelled
				/// </java-name>
				[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1025)]
				bool IsCancelled() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDone
				/// </java-name>
				[Dot42.DexImport("isDone", "()Z", AccessFlags = 1025)]
				bool IsDone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TV;")]
				V Get(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/RejectedExecutionHandler
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RejectedExecutionHandler", AccessFlags = 1537)]
		public partial interface IRejectedExecutionHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// rejectedExecution
				/// </java-name>
				[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1025)]
				void RejectedExecution(global::Java.Lang.IRunnable runnable, global::Java.Util.Concurrent.ThreadPoolExecutor threadPoolExecutor) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/RunnableFuture
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RunnableFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Runnable;Ljava/util/concurrent" +
    "/Future<TV;>;")]
		public partial interface IRunnableFuture<V> : global::Java.Lang.IRunnable, global::Java.Util.Concurrent.IFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1025)]
				void Run() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/RunnableScheduledFuture
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RunnableScheduledFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/RunnableFuture<TV;>" +
    ";Ljava/util/concurrent/ScheduledFuture<TV;>;")]
		public partial interface IRunnableScheduledFuture<V> : global::Java.Util.Concurrent.IRunnableFuture<V>, global::Java.Util.Concurrent.IScheduledFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isPeriodic
				/// </java-name>
				[Dot42.DexImport("isPeriodic", "()Z", AccessFlags = 1025)]
				bool IsPeriodic() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/ScheduledExecutorService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ScheduledExecutorService", AccessFlags = 1537)]
		public partial interface IScheduledExecutorService : global::Java.Util.Concurrent.IExecutorService
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sched" +
    "uledFuture;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sched" +
    "uledFuture<*>;")]
				global::Java.Util.Concurrent.IScheduledFuture<object> Schedule(global::Java.Lang.IRunnable runnable, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concu" +
    "rrent/ScheduledFuture;", AccessFlags = 1025, Signature = "<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;JLjava/util/concurrent" +
    "/TimeUnit;)Ljava/util/concurrent/ScheduledFuture<TV;>;")]
				global::Java.Util.Concurrent.IScheduledFuture<V> Schedule<V>(global::Java.Util.Concurrent.ICallable<V> callable, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// scheduleAtFixedRate
				/// </java-name>
				[Dot42.DexImport("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleAtFixedRate(global::Java.Lang.IRunnable runnable, long int64, long int641, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// scheduleWithFixedDelay
				/// </java-name>
				[Dot42.DexImport("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleWithFixedDelay(global::Java.Lang.IRunnable runnable, long int64, long int641, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/ScheduledFuture
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ScheduledFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/Delayed;Ljava/util/" +
    "concurrent/Future<TV;>;")]
		public partial interface IScheduledFuture<V> : global::Java.Util.Concurrent.IDelayed, global::Java.Util.Concurrent.IFuture<V>
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/util/concurrent/ThreadFactory
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ThreadFactory", AccessFlags = 1537)]
		public partial interface IThreadFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newThread
				/// </java-name>
				[Dot42.DexImport("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", AccessFlags = 1025)]
				global::System.Threading.Thread NewThread(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/concurrent/LinkedBlockingDeque
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/LinkedBlockingDeque", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gDeque<TE;>;Ljava/io/Serializable;")]
		public partial class LinkedBlockingDeque<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingDeque<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedBlockingDeque() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedBlockingDeque(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedBlockingDeque(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddFirst(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddLast(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferFirst(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferLast(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putFirst
				/// </java-name>
				[Dot42.DexImport("putFirst", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void PutFirst(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putLast
				/// </java-name>
				[Dot42.DexImport("putLast", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void PutLast(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool OfferFirst(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool OfferLast(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeFirst
				/// </java-name>
				[Dot42.DexImport("removeFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E RemoveFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// removeLast
				/// </java-name>
				[Dot42.DexImport("removeLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E RemoveLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// takeFirst
				/// </java-name>
				[Dot42.DexImport("takeFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E TakeFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// takeLast
				/// </java-name>
				[Dot42.DexImport("takeLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E TakeLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E PollFirst(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E PollLast(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// getFirst
				/// </java-name>
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E GetFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// getLast
				/// </java-name>
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E GetLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peekFirst
				/// </java-name>
				[Dot42.DexImport("peekFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PeekFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peekLast
				/// </java-name>
				[Dot42.DexImport("peekLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PeekLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// removeFirstOccurrence
				/// </java-name>
				[Dot42.DexImport("removeFirstOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool RemoveFirstOccurrence(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeLastOccurrence
				/// </java-name>
				[Dot42.DexImport("removeLastOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool RemoveLastOccurrence(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Push(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/Collection", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFirst
				/// </java-name>
				public E First
				{
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return GetFirst(); }
				}

				/// <java-name>
				/// getLast
				/// </java-name>
				public E Last
				{
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return GetLast(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/LinkedBlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/LinkedBlockingQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class LinkedBlockingQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedBlockingQueue() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedBlockingQueue(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedBlockingQueue(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/concurrent/BlockingQueue", "add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public override bool Add(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Queue", "remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Remove() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Element() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/concurrent/PriorityBlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/PriorityBlockingQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class PriorityBlockingQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PriorityBlockingQueue() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PriorityBlockingQueue(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/util/Comparator;)V", AccessFlags = 1, Signature = "(ILjava/util/Comparator<-TE;>;)V")]
				public PriorityBlockingQueue(int int32, global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public PriorityBlockingQueue(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TE;>;")]
				public virtual global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<E>);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
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
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/Queue", "remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Remove() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Element() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/concurrent/RejectedExecutionException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RejectedExecutionException", AccessFlags = 33)]
		public partial class RejectedExecutionException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RejectedExecutionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RejectedExecutionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public RejectedExecutionException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public RejectedExecutionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/ScheduledThreadPoolExecutor
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ScheduledThreadPoolExecutor", AccessFlags = 33)]
		public partial class ScheduledThreadPoolExecutor : global::Java.Util.Concurrent.ThreadPoolExecutor, global::Java.Util.Concurrent.IScheduledExecutorService
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/util/concurrent/ThreadFactory;)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int int32, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int int32, global::Java.Util.Concurrent.IRejectedExecutionHandler rejectedExecutionHandler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHand" +
    "ler;)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int int32, global::Java.Util.Concurrent.IThreadFactory threadFactory, global::Java.Util.Concurrent.IRejectedExecutionHandler rejectedExecutionHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decorateTask
				/// </java-name>
				[Dot42.DexImport("decorateTask", "(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/co" +
    "ncurrent/RunnableScheduledFuture;", AccessFlags = 4, Signature = "<V:Ljava/lang/Object;>(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableSchedule" +
    "dFuture<TV;>;)Ljava/util/concurrent/RunnableScheduledFuture<TV;>;")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableScheduledFuture<V> DecorateTask<V>(global::Java.Lang.IRunnable runnable, global::Java.Util.Concurrent.IRunnableScheduledFuture<V> runnableScheduledFuture) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableScheduledFuture<V>);
				}

				/// <java-name>
				/// decorateTask
				/// </java-name>
				[Dot42.DexImport("decorateTask", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/RunnableScheduledFuture;)Lj" +
    "ava/util/concurrent/RunnableScheduledFuture;", AccessFlags = 4, Signature = "<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;Ljava/util/concurrent/" +
    "RunnableScheduledFuture<TV;>;)Ljava/util/concurrent/RunnableScheduledFuture<TV;>" +
    ";")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableScheduledFuture<V> DecorateTask<V>(global::Java.Util.Concurrent.ICallable<V> callable, global::Java.Util.Concurrent.IRunnableScheduledFuture<V> runnableScheduledFuture) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableScheduledFuture<V>);
				}

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sched" +
    "uledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sched" +
    "uledFuture<*>;")]
				public virtual global::Java.Util.Concurrent.IScheduledFuture<object> Schedule(global::Java.Lang.IRunnable runnable, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
				}

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concu" +
    "rrent/ScheduledFuture;", AccessFlags = 1, Signature = "<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;JLjava/util/concurrent" +
    "/TimeUnit;)Ljava/util/concurrent/ScheduledFuture<TV;>;")]
				public virtual global::Java.Util.Concurrent.IScheduledFuture<V> Schedule<V>(global::Java.Util.Concurrent.ICallable<V> callable, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledFuture<V>);
				}

				/// <java-name>
				/// scheduleAtFixedRate
				/// </java-name>
				[Dot42.DexImport("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				public virtual global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleAtFixedRate(global::Java.Lang.IRunnable runnable, long int64, long int641, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
				}

				/// <java-name>
				/// scheduleWithFixedDelay
				/// </java-name>
				[Dot42.DexImport("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				public virtual global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleWithFixedDelay(global::Java.Lang.IRunnable runnable, long int64, long int641, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public override void Execute(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
				public override global::Java.Util.Concurrent.IFuture<object> Submit(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<object>);
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;" +
    "")]
				public override global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Lang.IRunnable runnable, T t) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Future<TT;>;")]
				public override global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <java-name>
				/// setContinueExistingPeriodicTasksAfterShutdownPolicy
				/// </java-name>
				[Dot42.DexImport("setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V", AccessFlags = 1)]
				public virtual void SetContinueExistingPeriodicTasksAfterShutdownPolicy(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContinueExistingPeriodicTasksAfterShutdownPolicy
				/// </java-name>
				[Dot42.DexImport("getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z", AccessFlags = 1)]
				public virtual bool GetContinueExistingPeriodicTasksAfterShutdownPolicy() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setExecuteExistingDelayedTasksAfterShutdownPolicy
				/// </java-name>
				[Dot42.DexImport("setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V", AccessFlags = 1)]
				public virtual void SetExecuteExistingDelayedTasksAfterShutdownPolicy(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExecuteExistingDelayedTasksAfterShutdownPolicy
				/// </java-name>
				[Dot42.DexImport("getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z", AccessFlags = 1)]
				public virtual bool GetExecuteExistingDelayedTasksAfterShutdownPolicy() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownNow
				/// </java-name>
				[Dot42.DexImport("shutdownNow", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				public override global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.IRunnable>);
				}

				/// <java-name>
				/// getQueue
				/// </java-name>
				[Dot42.DexImport("getQueue", "()Ljava/util/concurrent/BlockingQueue;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/BlockingQueue<Ljava/lang/Runnable;>;")]
				public override global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> GetQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScheduledThreadPoolExecutor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "isShutdown", "()Z", AccessFlags = 1025)]
				public override bool IsShutdown() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "isTerminated", "()Z", AccessFlags = 1025)]
				public override bool IsTerminated() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				public override bool AwaitTermination(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
				public override global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future" +
    "<TT;>;>;")]
				public override global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)TT;")]
				public override T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)TT;")]
				public override T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> collection, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getContinueExistingPeriodicTasksAfterShutdownPolicy
				/// </java-name>
				public bool IsContinueExistingPeriodicTasksAfterShutdownPolicy
				{
				[Dot42.DexImport("getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z", AccessFlags = 1)]
						get{ return GetContinueExistingPeriodicTasksAfterShutdownPolicy(); }
				[Dot42.DexImport("setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V", AccessFlags = 1)]
						set{ SetContinueExistingPeriodicTasksAfterShutdownPolicy(value); }
				}

				/// <java-name>
				/// getExecuteExistingDelayedTasksAfterShutdownPolicy
				/// </java-name>
				public bool IsExecuteExistingDelayedTasksAfterShutdownPolicy
				{
				[Dot42.DexImport("getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z", AccessFlags = 1)]
						get{ return GetExecuteExistingDelayedTasksAfterShutdownPolicy(); }
				[Dot42.DexImport("setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V", AccessFlags = 1)]
						set{ SetExecuteExistingDelayedTasksAfterShutdownPolicy(value); }
				}

				/// <java-name>
				/// getQueue
				/// </java-name>
				public global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> Queue
				{
				[Dot42.DexImport("getQueue", "()Ljava/util/concurrent/BlockingQueue;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/BlockingQueue<Ljava/lang/Runnable;>;")]
						get{ return GetQueue(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/Semaphore
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Semaphore", AccessFlags = 33)]
		public partial class Semaphore : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Semaphore(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public Semaphore(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
				public virtual void Acquire() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireUninterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireUninterruptibly", "()V", AccessFlags = 1)]
				public virtual void AcquireUninterruptibly() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "()Z", AccessFlags = 1)]
				public virtual bool TryAcquire() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool TryAcquire(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(I)V", AccessFlags = 1)]
				public virtual void Acquire(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireUninterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireUninterruptibly", "(I)V", AccessFlags = 1)]
				public virtual void AcquireUninterruptibly(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(I)Z", AccessFlags = 1)]
				public virtual bool TryAcquire(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool TryAcquire(int int32, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(I)V", AccessFlags = 1)]
				public virtual void Release(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// availablePermits
				/// </java-name>
				[Dot42.DexImport("availablePermits", "()I", AccessFlags = 1)]
				public virtual int AvailablePermits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainPermits
				/// </java-name>
				[Dot42.DexImport("drainPermits", "()I", AccessFlags = 1)]
				public virtual int DrainPermits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reducePermits
				/// </java-name>
				[Dot42.DexImport("reducePermits", "(I)V", AccessFlags = 4)]
				protected internal virtual void ReducePermits(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFair
				/// </java-name>
				[Dot42.DexImport("isFair", "()Z", AccessFlags = 1)]
				public virtual bool IsFair() /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Semaphore() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
		/// java/util/concurrent/SynchronousQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/SynchronousQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class SynchronousQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SynchronousQueue() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public SynchronousQueue(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> collection, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/concurrent/BlockingQueue", "add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public override bool Add(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Queue", "remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Remove() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public override E Element() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Collection", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// java/util/concurrent/ThreadPoolExecutor
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ThreadPoolExecutor", AccessFlags = 33)]
		public partial class ThreadPoolExecutor : global::Java.Util.Concurrent.AbstractExecutorService
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V", AccessFlags = 1, Signature = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue<Ljava/lang" +
    "/Runnable;>;)V")]
				public ThreadPoolExecutor(int int32, int int321, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> blockingQueue) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util" +
    "/concurrent/ThreadFactory;)V", AccessFlags = 1, Signature = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue<Ljava/lang" +
    "/Runnable;>;Ljava/util/concurrent/ThreadFactory;)V")]
				public ThreadPoolExecutor(int int32, int int321, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> blockingQueue, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util" +
    "/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1, Signature = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue<Ljava/lang" +
    "/Runnable;>;Ljava/util/concurrent/RejectedExecutionHandler;)V")]
				public ThreadPoolExecutor(int int32, int int321, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> blockingQueue, global::Java.Util.Concurrent.IRejectedExecutionHandler rejectedExecutionHandler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util" +
    "/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1, Signature = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue<Ljava/lang" +
    "/Runnable;>;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedEx" +
    "ecutionHandler;)V")]
				public ThreadPoolExecutor(int int32, int int321, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> blockingQueue, global::Java.Util.Concurrent.IThreadFactory threadFactory, global::Java.Util.Concurrent.IRejectedExecutionHandler rejectedExecutionHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public override void Execute(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownNow
				/// </java-name>
				[Dot42.DexImport("shutdownNow", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				public override global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.IRunnable>);
				}

				/// <java-name>
				/// isShutdown
				/// </java-name>
				[Dot42.DexImport("isShutdown", "()Z", AccessFlags = 1)]
				public override bool IsShutdown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTerminating
				/// </java-name>
				[Dot42.DexImport("isTerminating", "()Z", AccessFlags = 1)]
				public virtual bool IsTerminating() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTerminated
				/// </java-name>
				[Dot42.DexImport("isTerminated", "()Z", AccessFlags = 1)]
				public override bool IsTerminated() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// awaitTermination
				/// </java-name>
				[Dot42.DexImport("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public override bool AwaitTermination(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ThreadPoolExecutor() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setThreadFactory
				/// </java-name>
				[Dot42.DexImport("setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V", AccessFlags = 1)]
				public virtual void SetThreadFactory(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getThreadFactory
				/// </java-name>
				[Dot42.DexImport("getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.IThreadFactory GetThreadFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IThreadFactory);
				}

				/// <java-name>
				/// setRejectedExecutionHandler
				/// </java-name>
				[Dot42.DexImport("setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1)]
				public virtual void SetRejectedExecutionHandler(global::Java.Util.Concurrent.IRejectedExecutionHandler rejectedExecutionHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRejectedExecutionHandler
				/// </java-name>
				[Dot42.DexImport("getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;", AccessFlags = 1)]
				public virtual global::Java.Util.Concurrent.IRejectedExecutionHandler GetRejectedExecutionHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRejectedExecutionHandler);
				}

				/// <java-name>
				/// setCorePoolSize
				/// </java-name>
				[Dot42.DexImport("setCorePoolSize", "(I)V", AccessFlags = 1)]
				public virtual void SetCorePoolSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCorePoolSize
				/// </java-name>
				[Dot42.DexImport("getCorePoolSize", "()I", AccessFlags = 1)]
				public virtual int GetCorePoolSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// prestartCoreThread
				/// </java-name>
				[Dot42.DexImport("prestartCoreThread", "()Z", AccessFlags = 1)]
				public virtual bool PrestartCoreThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// prestartAllCoreThreads
				/// </java-name>
				[Dot42.DexImport("prestartAllCoreThreads", "()I", AccessFlags = 1)]
				public virtual int PrestartAllCoreThreads() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// allowsCoreThreadTimeOut
				/// </java-name>
				[Dot42.DexImport("allowsCoreThreadTimeOut", "()Z", AccessFlags = 1)]
				public virtual bool AllowsCoreThreadTimeOut() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// allowCoreThreadTimeOut
				/// </java-name>
				[Dot42.DexImport("allowCoreThreadTimeOut", "(Z)V", AccessFlags = 1)]
				public virtual void AllowCoreThreadTimeOut(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaximumPoolSize
				/// </java-name>
				[Dot42.DexImport("setMaximumPoolSize", "(I)V", AccessFlags = 1)]
				public virtual void SetMaximumPoolSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaximumPoolSize
				/// </java-name>
				[Dot42.DexImport("getMaximumPoolSize", "()I", AccessFlags = 1)]
				public virtual int GetMaximumPoolSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setKeepAliveTime
				/// </java-name>
				[Dot42.DexImport("setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void SetKeepAliveTime(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeepAliveTime
				/// </java-name>
				[Dot42.DexImport("getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J", AccessFlags = 1)]
				public virtual long GetKeepAliveTime(global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getQueue
				/// </java-name>
				[Dot42.DexImport("getQueue", "()Ljava/util/concurrent/BlockingQueue;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/BlockingQueue<Ljava/lang/Runnable;>;")]
				public virtual global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> GetQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Runnable;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// purge
				/// </java-name>
				[Dot42.DexImport("purge", "()V", AccessFlags = 1)]
				public virtual void Purge() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPoolSize
				/// </java-name>
				[Dot42.DexImport("getPoolSize", "()I", AccessFlags = 1)]
				public virtual int GetPoolSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getActiveCount
				/// </java-name>
				[Dot42.DexImport("getActiveCount", "()I", AccessFlags = 1)]
				public virtual int GetActiveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLargestPoolSize
				/// </java-name>
				[Dot42.DexImport("getLargestPoolSize", "()I", AccessFlags = 1)]
				public virtual int GetLargestPoolSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTaskCount
				/// </java-name>
				[Dot42.DexImport("getTaskCount", "()J", AccessFlags = 1)]
				public virtual long GetTaskCount() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getCompletedTaskCount
				/// </java-name>
				[Dot42.DexImport("getCompletedTaskCount", "()J", AccessFlags = 1)]
				public virtual long GetCompletedTaskCount() /* MethodBuilder.Create */ 
				{
						return default(long);
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
				/// beforeExecute
				/// </java-name>
				[Dot42.DexImport("beforeExecute", "(Ljava/lang/Thread;Ljava/lang/Runnable;)V", AccessFlags = 4)]
				protected internal virtual void BeforeExecute(global::System.Threading.Thread thread, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// afterExecute
				/// </java-name>
				[Dot42.DexImport("afterExecute", "(Ljava/lang/Runnable;Ljava/lang/Throwable;)V", AccessFlags = 4)]
				protected internal virtual void AfterExecute(global::Java.Lang.IRunnable runnable, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// terminated
				/// </java-name>
				[Dot42.DexImport("terminated", "()V", AccessFlags = 4)]
				protected internal virtual void Terminated() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ThreadPoolExecutor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getThreadFactory
				/// </java-name>
				public global::Java.Util.Concurrent.IThreadFactory ThreadFactory
				{
				[Dot42.DexImport("getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 1)]
						get{ return GetThreadFactory(); }
				[Dot42.DexImport("setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V", AccessFlags = 1)]
						set{ SetThreadFactory(value); }
				}

				/// <java-name>
				/// getRejectedExecutionHandler
				/// </java-name>
				public global::Java.Util.Concurrent.IRejectedExecutionHandler RejectedExecutionHandler
				{
				[Dot42.DexImport("getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;", AccessFlags = 1)]
						get{ return GetRejectedExecutionHandler(); }
				[Dot42.DexImport("setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1)]
						set{ SetRejectedExecutionHandler(value); }
				}

				/// <java-name>
				/// getCorePoolSize
				/// </java-name>
				public int CorePoolSize
				{
				[Dot42.DexImport("getCorePoolSize", "()I", AccessFlags = 1)]
						get{ return GetCorePoolSize(); }
				[Dot42.DexImport("setCorePoolSize", "(I)V", AccessFlags = 1)]
						set{ SetCorePoolSize(value); }
				}

				/// <java-name>
				/// getMaximumPoolSize
				/// </java-name>
				public int MaximumPoolSize
				{
				[Dot42.DexImport("getMaximumPoolSize", "()I", AccessFlags = 1)]
						get{ return GetMaximumPoolSize(); }
				[Dot42.DexImport("setMaximumPoolSize", "(I)V", AccessFlags = 1)]
						set{ SetMaximumPoolSize(value); }
				}

				/// <java-name>
				/// getQueue
				/// </java-name>
				public global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> Queue
				{
				[Dot42.DexImport("getQueue", "()Ljava/util/concurrent/BlockingQueue;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/BlockingQueue<Ljava/lang/Runnable;>;")]
						get{ return GetQueue(); }
				}

				/// <java-name>
				/// getPoolSize
				/// </java-name>
				public int PoolSize
				{
				[Dot42.DexImport("getPoolSize", "()I", AccessFlags = 1)]
						get{ return GetPoolSize(); }
				}

				/// <java-name>
				/// getActiveCount
				/// </java-name>
				public int ActiveCount
				{
				[Dot42.DexImport("getActiveCount", "()I", AccessFlags = 1)]
						get{ return GetActiveCount(); }
				}

				/// <java-name>
				/// getLargestPoolSize
				/// </java-name>
				public int LargestPoolSize
				{
				[Dot42.DexImport("getLargestPoolSize", "()I", AccessFlags = 1)]
						get{ return GetLargestPoolSize(); }
				}

				/// <java-name>
				/// getTaskCount
				/// </java-name>
				public long TaskCount
				{
				[Dot42.DexImport("getTaskCount", "()J", AccessFlags = 1)]
						get{ return GetTaskCount(); }
				}

				/// <java-name>
				/// getCompletedTaskCount
				/// </java-name>
				public long CompletedTaskCount
				{
				[Dot42.DexImport("getCompletedTaskCount", "()J", AccessFlags = 1)]
						get{ return GetCompletedTaskCount(); }
				}

				/// <java-name>
				/// java/util/concurrent/ThreadPoolExecutor$DiscardOldestPolicy
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/ThreadPoolExecutor$DiscardOldestPolicy", AccessFlags = 9)]
				public partial class DiscardOldestPolicy : global::Java.Util.Concurrent.IRejectedExecutionHandler
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public DiscardOldestPolicy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable runnable, global::Java.Util.Concurrent.ThreadPoolExecutor threadPoolExecutor) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// java/util/concurrent/ThreadPoolExecutor$DiscardPolicy
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/ThreadPoolExecutor$DiscardPolicy", AccessFlags = 9)]
				public partial class DiscardPolicy : global::Java.Util.Concurrent.IRejectedExecutionHandler
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public DiscardPolicy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable runnable, global::Java.Util.Concurrent.ThreadPoolExecutor threadPoolExecutor) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// java/util/concurrent/ThreadPoolExecutor$AbortPolicy
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/ThreadPoolExecutor$AbortPolicy", AccessFlags = 9)]
				public partial class AbortPolicy : global::Java.Util.Concurrent.IRejectedExecutionHandler
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public AbortPolicy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable runnable, global::Java.Util.Concurrent.ThreadPoolExecutor threadPoolExecutor) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// java/util/concurrent/ThreadPoolExecutor$CallerRunsPolicy
				/// </java-name>
				[Dot42.DexImport("java/util/concurrent/ThreadPoolExecutor$CallerRunsPolicy", AccessFlags = 9)]
				public partial class CallerRunsPolicy : global::Java.Util.Concurrent.IRejectedExecutionHandler
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CallerRunsPolicy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable runnable, global::Java.Util.Concurrent.ThreadPoolExecutor threadPoolExecutor) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/util/concurrent/TimeoutException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/TimeoutException", AccessFlags = 33)]
		public partial class TimeoutException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeoutException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TimeoutException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/TimeUnit
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/TimeUnit", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Ljava/util/concurrent/TimeUnit;>;")]
		public sealed class TimeUnit
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DAYS
				/// </java-name>
				[Dot42.DexImport("DAYS", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit DAYS;
				/// <java-name>
				/// HOURS
				/// </java-name>
				[Dot42.DexImport("HOURS", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit HOURS;
				/// <java-name>
				/// MICROSECONDS
				/// </java-name>
				[Dot42.DexImport("MICROSECONDS", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit MICROSECONDS;
				/// <java-name>
				/// MILLISECONDS
				/// </java-name>
				[Dot42.DexImport("MILLISECONDS", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit MILLISECONDS;
				/// <java-name>
				/// MINUTES
				/// </java-name>
				[Dot42.DexImport("MINUTES", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit MINUTES;
				/// <java-name>
				/// NANOSECONDS
				/// </java-name>
				[Dot42.DexImport("NANOSECONDS", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit NANOSECONDS;
				/// <java-name>
				/// SECONDS
				/// </java-name>
				[Dot42.DexImport("SECONDS", "Ljava/util/concurrent/TimeUnit;", AccessFlags = 16409)]
				public static readonly global::Java.Util.Concurrent.TimeUnit SECONDS;
				private TimeUnit() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Ljava/util/concurrent/TimeUnit;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.TimeUnit[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.TimeUnit[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.TimeUnit ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.TimeUnit);
				}

				/// <java-name>
				/// convert
				/// </java-name>
				[Dot42.DexImport("convert", "(JLjava/util/concurrent/TimeUnit;)J", AccessFlags = 1)]
				public long Convert(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toNanos
				/// </java-name>
				[Dot42.DexImport("toNanos", "(J)J", AccessFlags = 1)]
				public long ToNanos(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toMicros
				/// </java-name>
				[Dot42.DexImport("toMicros", "(J)J", AccessFlags = 1)]
				public long ToMicros(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toMillis
				/// </java-name>
				[Dot42.DexImport("toMillis", "(J)J", AccessFlags = 1)]
				public long ToMillis(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toSeconds
				/// </java-name>
				[Dot42.DexImport("toSeconds", "(J)J", AccessFlags = 1)]
				public long ToSeconds(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toMinutes
				/// </java-name>
				[Dot42.DexImport("toMinutes", "(J)J", AccessFlags = 1)]
				public long ToMinutes(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toHours
				/// </java-name>
				[Dot42.DexImport("toHours", "(J)J", AccessFlags = 1)]
				public long ToHours(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toDays
				/// </java-name>
				[Dot42.DexImport("toDays", "(J)J", AccessFlags = 1)]
				public long ToDays(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// timedWait
				/// </java-name>
				[Dot42.DexImport("timedWait", "(Ljava/lang/Object;J)V", AccessFlags = 1)]
				public void TimedWait(object @object, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// timedJoin
				/// </java-name>
				[Dot42.DexImport("timedJoin", "(Ljava/lang/Thread;J)V", AccessFlags = 1)]
				public void TimedJoin(global::System.Threading.Thread thread, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sleep
				/// </java-name>
				[Dot42.DexImport("sleep", "(J)V", AccessFlags = 1)]
				public void Sleep(long int64) /* MethodBuilder.Create */ 
				{
				}

		}

}

