#pragma warning disable 1717
namespace Java.Util.Concurrent
{
		/// <summary>
		///  <para>Provides default implementations of ExecutorService execution methods. This class implements the <c>submit </c> ,  <c>invokeAny </c> and <c>invokeAll </c> methods using a RunnableFuture returned by <c>newTaskFor </c> , which defaults to the FutureTask class provided in this package. For example, the implementation of <c>submit(Runnable) </c> creates an associated <c>RunnableFuture </c> that is executed and returned. Subclasses may override the <c>newTaskFor </c> methods to return <c>RunnableFuture </c> implementations other than  <c>FutureTask </c> .</para> <para> <b>Extension example</b>. Here is a sketch of a class that customizes ThreadPoolExecutor to use a <c>CustomTask </c> class instead of the default <c>FutureTask </c> :  <pre>public class CustomThreadPoolExecutor extends ThreadPoolExecutor {
		/// 
		/// 
		/// 
		///   static class CustomTask&lt;V&gt; implements RunnableFuture&lt;V&gt; {...}
		/// 
		/// 
		/// 
		///   protected &lt;V&gt; RunnableFuture&lt;V&gt; newTaskFor(Callable&lt;V&gt; c) {
		/// 
		///       return new CustomTask&lt;V&gt;(c);
		/// 
		///   }
		/// 
		///   protected &lt;V&gt; RunnableFuture&lt;V&gt; newTaskFor(Runnable r, V v) {
		/// 
		///       return new CustomTask&lt;V&gt;(r, v);
		/// 
		///   }
		/// 
		///   // ... add constructors, etc.
		/// 
		/// } 
		/// 
		///  </pre></para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns a <c>RunnableFuture </c> for the given runnable and default value.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>RunnableFuture </c> which, when run, will run the underlying runnable and which, as a <c>Future </c> , will yield the given value as its result and provide for cancellation of the underlying task </para>
				/// </returns>
				/// <java-name>
				/// newTaskFor
				/// </java-name>
				[Dot42.DexImport("newTaskFor", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/RunnableFuture;", AccessFlags = 4, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/RunnableFutu" +
    "re<TT;>;")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableFuture<T> NewTaskFor<T>(global::Java.Lang.IRunnable runnable, T value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableFuture<T>);
				}

				/// <summary>
				///  <para>Returns a <c>RunnableFuture </c> for the given callable task.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>RunnableFuture </c> which, when run, will call the underlying callable and which, as a <c>Future </c> , will yield the callable's result as its result and provide for cancellation of the underlying task </para>
				/// </returns>
				/// <java-name>
				/// newTaskFor
				/// </java-name>
				[Dot42.DexImport("newTaskFor", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/RunnableFuture;", AccessFlags = 4, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/RunnableFuture<TT;>;")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableFuture<T> NewTaskFor<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableFuture<T>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
				public virtual global::Java.Util.Concurrent.IFuture<object> Submit(global::Java.Lang.IRunnable task) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<object>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;" +
    "")]
				public virtual global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Lang.IRunnable task, T result) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Future<TT;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Util.Concurrent.ICallable<T> task) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <summary>
				///  <para>Executes the given tasks, returning the result of one that has completed successfully (i.e., without throwing an exception), if any do. Upon normal or exceptional return, tasks that have not completed are cancelled. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result returned by one of the tasks </para>
				/// </returns>
				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)TT;")]
				public virtual T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Executes the given tasks, returning the result of one that has completed successfully (i.e., without throwing an exception), if any do before the given timeout elapses. Upon normal or exceptional return, tasks that have not completed are cancelled. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result returned by one of the tasks </para>
				/// </returns>
				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)TT;")]
				public virtual T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Executes the given tasks, returning a list of Futures holding their status and results when all complete. Future#isDone is <c>true </c> for each element of the returned list. Note that a  <b>completed</b> task could have terminated either normally or by throwing an exception. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of Futures representing the tasks, in the same sequential order as produced by the iterator for the given task list, each of which has completed </para>
				/// </returns>
				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
				public virtual global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				/// <summary>
				///  <para>Executes the given tasks, returning a list of Futures holding their status and results when all complete or the timeout expires, whichever happens first. Future#isDone is <c>true </c> for each element of the returned list. Upon return, tasks that have not completed are cancelled. Note that a  <b>completed</b> task could have terminated either normally or by throwing an exception. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of Futures representing the tasks, in the same sequential order as produced by the iterator for the given task list. If the operation did not time out, each task will have completed. If it did time out, some of these tasks will not have completed. </para>
				/// </returns>
				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future" +
    "<TT;>;>;")]
				public virtual global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				public virtual bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/Executor", "execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1025)]
				public virtual void Execute(global::Java.Lang.IRunnable command) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				public virtual bool IsShutdown
				{
						[Dot42.DexImport("java/util/concurrent/ExecutorService", "isShutdown", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public virtual bool IsTerminated
				{
						[Dot42.DexImport("java/util/concurrent/ExecutorService", "isTerminated", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A bounded  BlockingQueue blocking queue} backed by an array. This queue orders elements FIFO (first-in-first-out). The  <b>head</b> of the queue is that element that has been on the queue the longest time. The  <b>tail</b> of the queue is that element that has been on the queue the shortest time. New elements are inserted at the tail of the queue, and the queue retrieval operations obtain elements at the head of the queue.</para> <para>This is a classic "bounded buffer", in which a fixed-sized array holds elements inserted by producers and extracted by consumers. Once created, the capacity cannot be changed. Attempts to <c>put </c> an element into a full queue will result in the operation blocking; attempts to <c>take </c> an element from an empty queue will similarly block.</para> <para>This class supports an optional fairness policy for ordering waiting producer and consumer threads. By default, this ordering is not guaranteed. However, a queue constructed with fairness set to <c>true </c> grants threads access in FIFO order. Fairness generally decreases throughput but reduces variability and avoids starvation.</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Collection and Iterator interfaces.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ArrayBlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ArrayBlockingQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class ArrayBlockingQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an <c>ArrayBlockingQueue </c> with the given (fixed) capacity and default access policy.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayBlockingQueue(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an <c>ArrayBlockingQueue </c> with the given (fixed) capacity and the specified access policy.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public ArrayBlockingQueue(int capacity, bool fair) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an <c>ArrayBlockingQueue </c> with the given (fixed) capacity, the specified access policy and initially containing the elements of the given collection, added in traversal order of the collection's iterator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZLjava/util/Collection;)V", AccessFlags = 1, Signature = "(IZLjava/util/Collection<+TE;>;)V")]
				public ArrayBlockingQueue(int capacity, bool fair, global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue if it is possible to do so immediately without exceeding the queue's capacity, returning <c>true </c> upon success and throwing an  <c>IllegalStateException </c> if this queue is full.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Collection#add) </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue if it is possible to do so immediately without exceeding the queue's capacity, returning <c>true </c> upon success and <c>false </c> if this queue is full. This method is generally preferable to method add, which can fail to insert an element only by throwing an exception.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue, waiting for space to become available if the queue is full.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue, waiting up to the specified wait time for space to become available if the queue is full.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns the number of elements in this queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the number of additional elements that this queue can ideally (in the absence of memory or resource constraints) accept without blocking. This is always equal to the initial capacity of this queue less the current <c>size </c> of this queue.</para> <para>Note that you  <b>cannot</b> always tell if an attempt to insert an element will succeed by inspecting <c>remainingCapacity </c> because it may be the case that another thread is about to insert or remove an element. </para>        
				/// </summary>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes a single instance of the specified element from this queue, if it is present. More formally, removes an element <c>e </c> such that <c>o.equals(e) </c> , if this queue contains one or more such elements. Returns <c>true </c> if this queue contained the specified element (or equivalently, if this queue changed as a result of the call).</para> <para>Removal of interior elements in circular array based queues is an intrinsically slow and disruptive operation, so should be undertaken only in exceptional circumstances, ideally only when the queue is known not to be accessible by other threads.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this queue contains the specified element. More formally, returns <c>true </c> if and only if this queue contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue, in proper sequence.</para> <para>The returned array will be "safe" in that no references to it are maintained by this queue. (In other words, this method must allocate a new array). The caller is thus free to modify the returned array.</para> <para>This method acts as bridge between array-based and collection-based APIs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue, in proper sequence; the runtime type of the returned array is that of the specified array. If the queue fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this queue.</para> <para>If this queue fits in the specified array with room to spare (i.e., the array has more elements than this queue), the element in the array immediately following the end of the queue is set to  <c>null </c> .</para> <para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para> <para>Suppose <c>x </c> is a queue known to contain only strings. The following code can be used to dump the queue into a newly allocated array of <c>String </c> :</para> <para> <pre>String[] y = x.toArray(new String[0]); 
				/// 
				///  </pre></para> <para>Note that <c>toArray(new Object[0]) </c> is identical in function to  <c>toArray() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Atomically removes all of the elements from this queue. The queue will be empty after this call returns. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an iterator over the elements in this queue in proper sequence. The elements will be returned in order from first (head) to last (tail).</para> <para>The returned iterator is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this queue in proper sequence </para>
				/// </returns>
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

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Exception thrown when a thread tries to wait upon a barrier that is in a broken state, or which enters the broken state while the thread is waiting.</para> <para> <para>CyclicBarrier</para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/BrokenBarrierException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/BrokenBarrierException", AccessFlags = 33)]
		public partial class BrokenBarrierException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>BrokenBarrierException </c> with no specified detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BrokenBarrierException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>BrokenBarrierException </c> with the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BrokenBarrierException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Exception indicating that the result of a value-producing task, such as a FutureTask, cannot be retrieved because the task was cancelled.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/CancellationException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CancellationException", AccessFlags = 33)]
		public partial class CancellationException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>CancellationException </c> with no detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CancellationException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>CancellationException </c> with the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CancellationException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A hash table supporting full concurrency of retrievals and adjustable expected concurrency for updates. This class obeys the same functional specification as java.util.Hashtable, and includes versions of methods corresponding to each method of  <code>Hashtable</code>. However, even though all operations are thread-safe, retrieval operations do  <b>not</b> entail locking, and there is  <b>not</b> any support for locking the entire table in a way that prevents all access. This class is fully interoperable with  <code>Hashtable</code> in programs that rely on its thread safety but not on its synchronization details.</para> <para>Retrieval operations (including  <code>get</code>) generally do not block, so may overlap with update operations (including  <code>put</code> and  <code>remove</code>). Retrievals reflect the results of the most recently  <b>completed</b> update operations holding upon their onset. For aggregate operations such as  <code>putAll</code> and  <code>clear</code>, concurrent retrievals may reflect insertion or removal of only some entries. Similarly, Iterators and Enumerations return elements reflecting the state of the hash table at some point at or since the creation of the iterator/enumeration. They do  <b>not</b> throw ConcurrentModificationException. However, iterators are designed to be used by only one thread at a time.</para> <para>The allowed concurrency among update operations is guided by the optional  <code>concurrencyLevel</code> constructor argument (default  <code>16</code>), which is used as a hint for internal sizing. The table is internally partitioned to try to permit the indicated number of concurrent updates without contention. Because placement in hash tables is essentially random, the actual concurrency will vary. Ideally, you should choose a value to accommodate as many threads as will ever concurrently modify the table. Using a significantly higher value than you need can waste space and time, and a significantly lower value can lead to thread contention. But overestimates and underestimates within an order of magnitude do not usually have much noticeable impact. A value of one is appropriate when it is known that only one thread will modify and all others will only read. Also, resizing this or any other kind of hash table is a relatively slow operation, so, when possible, it is a good idea to provide estimates of expected table sizes in constructors.</para> <para>This class and its views and iterators implement all of the  <b>optional</b> methods of the Map and Iterator interfaces.</para> <para>Like Hashtable but unlike HashMap, this class does  <b>not</b> allow  <code>null</code> to be used as a key or value.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ConcurrentHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/concurrent/ConcurrentMap<TK;TV;>;Ljava/io/Serializable;")]
		public partial class ConcurrentHashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.Concurrent.IConcurrentMap<K, V>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new, empty map with the specified initial capacity, load factor and concurrency level.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IFI)V", AccessFlags = 1)]
				public ConcurrentHashMap(int initialCapacity, float loadFactor, int concurrencyLevel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new, empty map with the specified initial capacity and load factor and with the default concurrencyLevel (16).</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public ConcurrentHashMap(int initialCapacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new, empty map with the specified initial capacity, and with default load factor (0.75) and concurrencyLevel (16).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ConcurrentHashMap(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new, empty map with a default initial capacity (16), load factor (0.75) and concurrencyLevel (16). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentHashMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new, empty map with the specified initial capacity, and with default load factor (0.75) and concurrencyLevel (16).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public ConcurrentHashMap(global::Java.Util.IMap<K, V> initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of key-value mappings in this map. If the map contains more than  <code>Integer.MAX_VALUE</code> elements, returns  <code>Integer.MAX_VALUE</code>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of key-value mappings in this map </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value to which the specified key is mapped, or <c>null </c> if this map contains no mapping for the key.</para> <para>More formally, if this map contains a mapping from a key  <c>k </c> to a value <c>v </c> such that <c>key.equals(k) </c> , then this method returns <c>v </c> ; otherwise it returns  <c>null </c> . (There can be at most one such mapping.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Tests if the specified object is a key in this table.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if and only if the specified object is a key in this table, as determined by the  <code>equals</code> method;  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsKey(object key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if this map maps one or more keys to the specified value. Note: This method requires a full internal traversal of the hash table, and so is much slower than method  <code>containsKey</code>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if this map maps one or more keys to the specified value </para>
				/// </returns>
				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsValue(object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Legacy method testing if some key maps into the specified value in this table. This method is identical in functionality to containsValue, and exists solely to ensure full compatibility with class java.util.Hashtable, which supported this method prior to introduction of the Java Collections framework.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if and only if some key maps to the  <code>value</code> argument in this table as determined by the  <code>equals</code> method;  <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Contains(object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Maps the specified key to the specified value in this table. Neither the key nor the value can be null.</para> <para>The value can be retrieved by calling the  <code>get</code> method with a key that is equal to the original key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with  <code>key</code>, or  <code>null</code> if there was no mapping for  <code>key</code> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para> <para>If the specified key is not already associated with a value, associate it with the given value. This is equivalent to  <pre>if (!map.containsKey(key))
				/// 
				///   return map.put(key, value);
				/// 
				/// else
				/// 
				///   return map.get(key); 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key. (A <c>null </c> return can also indicate that the map previously associated <c>null </c> with the key, if the implementation supports null values.) </para> <para>the previous value associated with the specified key, or  <code>null</code> if there was no mapping for the key </para>
				/// </returns>
				/// <java-name>
				/// putIfAbsent
				/// </java-name>
				[Dot42.DexImport("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V PutIfAbsent(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Copies all of the mappings from the specified map to this one. These mappings replace any mappings that this map had for any of the keys currently in the specified map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the key (and its corresponding value) from this map. This method does nothing if the key is not in the map.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with  <code>key</code>, or  <code>null</code> if there was no mapping for  <code>key</code> </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para> <para>Removes the entry for a key only if currently mapped to a given value. This is equivalent to  <pre>if (map.containsKey(key) &amp;&amp; map.get(key).equals(value)) {
				/// 
				///   map.remove(key);
				/// 
				///   return true;
				/// 
				/// } else
				/// 
				///   return false; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was removed </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Remove(object key, object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Replaces the entry for a key only if currently mapped to a given value. This is equivalent to  <pre>if (map.containsKey(key) &amp;&amp; map.get(key).equals(oldValue)) {
				/// 
				///   map.put(key, newValue);
				/// 
				///   return true;
				/// 
				/// } else
				/// 
				///   return false; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was replaced </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TK;TV;TV;)Z")]
				public virtual bool Replace(K key, V oldValue, V newValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Replaces the entry for a key only if currently mapped to some value. This is equivalent to  <pre>if (map.containsKey(key)) {
				/// 
				///   return map.put(key, value);
				/// 
				/// } else
				/// 
				///   return null; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key. (A <c>null </c> return can also indicate that the map previously associated <c>null </c> with the key, if the implementation supports null values.) </para> <para>the previous value associated with the specified key, or  <code>null</code> if there was no mapping for the key </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V Replace(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Removes all of the mappings from this map. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a Set view of the keys contained in this map. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from this map, via the  <code>Iterator.remove</code>,  <code>Set.remove</code>,  <code>removeAll</code>,  <code>retainAll</code>, and  <code>clear</code> operations. It does not support the  <code>add</code> or  <code>addAll</code> operations.</para> <para>The view's  <code>iterator</code> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction. </para>        
				/// </summary>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				///  <para>Returns a Collection view of the values contained in this map. The collection is backed by the map, so changes to the map are reflected in the collection, and vice-versa. The collection supports element removal, which removes the corresponding mapping from this map, via the  <code>Iterator.remove</code>,  <code>Collection.remove</code>,  <code>removeAll</code>,  <code>retainAll</code>, and  <code>clear</code> operations. It does not support the  <code>add</code> or  <code>addAll</code> operations.</para> <para>The view's  <code>iterator</code> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction. </para>        
				/// </summary>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <summary>
				///  <para>Returns a Set view of the mappings contained in this map. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the  <code>Iterator.remove</code>,  <code>Set.remove</code>,  <code>removeAll</code>,  <code>retainAll</code>, and  <code>clear</code> operations. It does not support the  <code>add</code> or  <code>addAll</code> operations.</para> <para>The view's  <code>iterator</code> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction. </para>        
				/// </summary>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <summary>
				///  <para>Returns an enumeration of the keys in this table.</para> <para> <para>keySet() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>an enumeration of the keys in this table </para>
				/// </returns>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<TK;>;")]
				public virtual global::Java.Util.IEnumeration<K> Keys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<K>);
				}

				/// <summary>
				///  <para>Returns an enumeration of the values in this table.</para> <para> <para>values() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>an enumeration of the values in this table </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns  <code>true</code> if this map contains no key-value mappings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if this map contains no key-value mappings </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>An unbounded thread-safe  Queue queue} based on linked nodes. This queue orders elements FIFO (first-in-first-out). The  <b>head</b> of the queue is that element that has been on the queue the longest time. The  <b>tail</b> of the queue is that element that has been on the queue the shortest time. New elements are inserted at the tail of the queue, and the queue retrieval operations obtain elements at the head of the queue. A <c>ConcurrentLinkedQueue </c> is an appropriate choice when many threads will share access to a common collection. Like most other concurrent collection implementations, this class does not permit the use of <c>null </c> elements.</para> <para>This implementation employs an efficient "wait-free" algorithm based on one described in  by Maged M. Michael and Michael L. Scott.</para> <para>Iterators are  <b>weakly consistent</b>, returning elements reflecting the state of the queue at some point at or since the creation of the iterator. They do  <b>not</b> throw java.util.ConcurrentModificationException, and may proceed concurrently with other operations. Elements contained in the queue since the creation of the iterator will be returned exactly once.</para> <para>Beware that, unlike in most collections, the <c>size </c> method is  <b>NOT</b> a constant-time operation. Because of the asynchronous nature of these queues, determining the current number of elements requires a traversal of the elements, and so may report inaccurate results if this collection is modified during traversal. Additionally, the bulk operations <c>addAll </c> ,  <c>removeAll </c> , <c>retainAll </c> , <c>containsAll </c> ,  <c>equals </c> , and <c>toArray </c> are  <b>not</b> guaranteed to be performed atomically. For example, an iterator operating concurrently with an <c>addAll </c> operation might view only some of the added elements.</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Queue and Iterator interfaces.</para> <para>Memory consistency effects: As with other concurrent collections, actions in a thread prior to placing an object into a  <c>ConcurrentLinkedQueue </c>  actions subsequent to the access or removal of that element from the <c>ConcurrentLinkedQueue </c> in another thread.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ConcurrentLinkedQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentLinkedQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/Queue<TE;>;Ljava/i" +
    "o/Serializable;")]
		public partial class ConcurrentLinkedQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.IQueue<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a <c>ConcurrentLinkedQueue </c> that is initially empty. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentLinkedQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>ConcurrentLinkedQueue </c> initially containing the elements of the given collection, added in traversal order of the collection's iterator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ConcurrentLinkedQueue(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue. As the queue is unbounded, this method will never throw IllegalStateException or return <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Collection#add) </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue. As the queue is unbounded, this method will never return <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Queue#offer) </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns the number of elements in this queue. If this queue contains more than <c>Integer.MAX_VALUE </c> elements, returns  <c>Integer.MAX_VALUE </c> .</para> <para>Beware that, unlike in most collections, this method is  <b>NOT</b> a constant-time operation. Because of the asynchronous nature of these queues, determining the current number of elements requires an O(n) traversal. Additionally, if elements are added or removed during execution of this method, the returned result may be inaccurate. Thus, this method is typically not very useful in concurrent applications.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this queue contains the specified element. More formally, returns <c>true </c> if and only if this queue contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes a single instance of the specified element from this queue, if it is present. More formally, removes an element <c>e </c> such that <c>o.equals(e) </c> , if this queue contains one or more such elements. Returns <c>true </c> if this queue contained the specified element (or equivalently, if this queue changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Appends all of the elements in the specified collection to the end of this queue, in the order that they are returned by the specified collection's iterator. Attempts to <c>addAll </c> of a queue to itself result in <c>IllegalArgumentException </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue, in proper sequence.</para> <para>The returned array will be "safe" in that no references to it are maintained by this queue. (In other words, this method must allocate a new array). The caller is thus free to modify the returned array.</para> <para>This method acts as bridge between array-based and collection-based APIs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue, in proper sequence; the runtime type of the returned array is that of the specified array. If the queue fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this queue.</para> <para>If this queue fits in the specified array with room to spare (i.e., the array has more elements than this queue), the element in the array immediately following the end of the queue is set to  <c>null </c> .</para> <para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para> <para>Suppose <c>x </c> is a queue known to contain only strings. The following code can be used to dump the queue into a newly allocated array of <c>String </c> :</para> <para> <pre>String[] y = x.toArray(new String[0]); 
				/// 
				///  </pre></para> <para>Note that <c>toArray(new Object[0]) </c> is identical in function to  <c>toArray() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Returns an iterator over the elements in this queue in proper sequence. The elements will be returned in order from first (head) to last (tail).</para> <para>The returned iterator is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this queue in proper sequence </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns <c>true </c> if this queue contains no elements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue contains no elements </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A scalable concurrent ConcurrentNavigableMap implementation. The map is sorted according to the  Comparable natural ordering} of its keys, or by a Comparator provided at map creation time, depending on which constructor is used.</para> <para>This class implements a concurrent variant of  providing expected average  <b>log(n)</b> time cost for the  <c>containsKey </c> , <c>get </c> , <c>put </c> and  <c>remove </c> operations and their variants. Insertion, removal, update, and access operations safely execute concurrently by multiple threads. Iterators are  <b>weakly consistent</b>, returning elements reflecting the state of the map at some point at or since the creation of the iterator. They do  <b>not</b> throw ConcurrentModificationException, and may proceed concurrently with other operations. Ascending key ordered views and their iterators are faster than descending ones.</para> <para>All <c>Map.Entry </c> pairs returned by methods in this class and its views represent snapshots of mappings at the time they were produced. They do  <b>not</b> support the <c>Entry.setValue </c> method. (Note however that it is possible to change mappings in the associated map using <c>put </c> , <c>putIfAbsent </c> , or  <c>replace </c> , depending on exactly which effect you need.)</para> <para>Beware that, unlike in most collections, the <c>size </c> method is  <b>not</b> a constant-time operation. Because of the asynchronous nature of these maps, determining the current number of elements requires a traversal of the elements, and so may report inaccurate results if this collection is modified during traversal. Additionally, the bulk operations <c>putAll </c> , <c>equals </c> ,  <c>toArray </c> , <c>containsValue </c> , and <c>clear </c> are  <b>not</b> guaranteed to be performed atomically. For example, an iterator operating concurrently with a <c>putAll </c> operation might view only some of the added elements.</para> <para>This class and its views and iterators implement all of the  <b>optional</b> methods of the Map and Iterator interfaces. Like most other concurrent collections, this class does  <b>not</b> permit the use of <c>null </c> keys or values because some null return values cannot be reliably distinguished from the absence of elements.</para> <para> <para>Doug Lea </para> <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ConcurrentSkipListMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentSkipListMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/concurrent/ConcurrentNavigableMap<TK;TV;>;Ljava/lang/Cloneable;Ljava/io/Seria" +
    "lizable;")]
		public partial class ConcurrentSkipListMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>, global::Java.Lang.ICloneable, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new, empty map, sorted according to the  Comparable natural ordering} of the keys. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentSkipListMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty map, sorted according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TK;>;)V")]
				public ConcurrentSkipListMap(global::Java.Util.IComparator<K> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty map, sorted according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public ConcurrentSkipListMap(global::Java.Util.IMap<K, V> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty map, sorted according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/SortedMap;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedMap<TK;+TV;>;)V")]
				public ConcurrentSkipListMap(global::Java.Util.ISortedMap<K, V> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a shallow copy of this <c>ConcurrentSkipListMap </c> instance. (The keys and values themselves are not cloned.)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a shallow copy of this map </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/concurrent/ConcurrentSkipListMap;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/ConcurrentSkipListMap<TK;TV;>;")]
				public new virtual global::Java.Util.Concurrent.ConcurrentSkipListMap<K, V> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ConcurrentSkipListMap<K, V>);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this map contains a mapping for the specified key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this map contains a mapping for the specified key </para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsKey(object key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value to which the specified key is mapped, or <c>null </c> if this map contains no mapping for the key.</para> <para>More formally, if this map contains a mapping from a key  <c>k </c> to a value <c>v </c> such that <c>key </c> compares equal to <c>k </c> according to the map's ordering, then this method returns <c>v </c> ; otherwise it returns <c>null </c> . (There can be at most one such mapping.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Associates the specified value with the specified key in this map. If the map previously contained a mapping for the key, the old value is replaced.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Removes the mapping for the specified key from this map if present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this map maps one or more keys to the specified value. This operation requires time linear in the map size. Additionally, it is possible for the map to change during execution of this method, in which case the returned result may be inaccurate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a mapping to <c>value </c> exists;  <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsValue(object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the number of key-value mappings in this map. If this map contains more than <c>Integer.MAX_VALUE </c> elements, it returns <c>Integer.MAX_VALUE </c> .</para> <para>Beware that, unlike in most collections, this method is  <b>NOT</b> a constant-time operation. Because of the asynchronous nature of these maps, determining the current number of elements requires traversing them all to count them. Additionally, it is possible for the size to change during execution of this method, in which case the returned result will be inaccurate. Thus, this method is typically not very useful in concurrent applications.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this map </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes all of the mappings from this map. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a NavigableSet view of the keys contained in this map. The set's iterator returns the keys in ascending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> , and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para>This method is equivalent to method <c>navigableKeySet </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public new virtual global::Java.Util.INavigableSet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				/// <summary>
				///  <para>Returns a NavigableSet view of the keys contained in this map. The set's iterator returns the keys in ascending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> , and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// navigableKeySet
				/// </java-name>
				[Dot42.DexImport("navigableKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public virtual global::Java.Util.INavigableSet<K> NavigableKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				/// <summary>
				///  <para>Returns a Collection view of the values contained in this map. The collection's iterator returns the values in ascending order of the corresponding keys. The collection is backed by the map, so changes to the map are reflected in the collection, and vice-versa. The collection supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> ,  <c>Collection.remove </c> , <c>removeAll </c> ,  <c>retainAll </c> and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction. </para>        
				/// </summary>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <summary>
				///  <para>Returns a Set view of the mappings contained in this map. The set's iterator returns the entries in ascending key order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> and <c>clear </c> operations. It does not support the <c>add </c> or  <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para>The <c>Map.Entry </c> elements returned by  <c>iterator.next() </c> do  <b>not</b> support the  <c>setValue </c> operation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a set view of the mappings contained in this map, sorted in ascending key order </para>
				/// </returns>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <summary>
				///  <para>Returns a reverse order view of the mappings contained in this map. The descending map is backed by this map, so changes to the map are reflected in the descending map, and vice-versa.</para> <para>The returned map has an ordering equivalent to Collections.reverseOrder <c>(comparator()) </c> . The expression <c>m.descendingMap().descendingMap() </c> returns a view of <c>m </c> essentially equivalent to <c>m </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reverse order view of this map </para>
				/// </returns>
				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para>Returns a reverse order NavigableSet view of the keys contained in this map. The set's iterator returns the keys in descending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> , and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reverse order navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public virtual global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				/// <summary>
				///  <para>Compares the specified object with this map for equality. Returns <c>true </c> if the given object is also a map and the two maps represent the same mappings. More formally, two maps  <c>m1 </c> and <c>m2 </c> represent the same mappings if  <c>m1.entrySet().equals(m2.entrySet()) </c> . This operation may return misleading results if either map is concurrently modified during execution of this method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this map </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>If the specified key is not already associated with a value, associate it with the given value. This is equivalent to  <pre>if (!map.containsKey(key))
				/// 
				///   return map.put(key, value);
				/// 
				/// else
				/// 
				///   return map.get(key); 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key. (A <c>null </c> return can also indicate that the map previously associated <c>null </c> with the key, if the implementation supports null values.) </para> <para>the previous value associated with the specified key, or <c>null </c> if there was no mapping for the key </para>
				/// </returns>
				/// <java-name>
				/// putIfAbsent
				/// </java-name>
				[Dot42.DexImport("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V PutIfAbsent(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para> <para>Removes the entry for a key only if currently mapped to a given value. This is equivalent to  <pre>if (map.containsKey(key) &amp;&amp; map.get(key).equals(value)) {
				/// 
				///   map.remove(key);
				/// 
				///   return true;
				/// 
				/// } else
				/// 
				///   return false; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was removed </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Remove(object key, object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Replaces the entry for a key only if currently mapped to a given value. This is equivalent to  <pre>if (map.containsKey(key) &amp;&amp; map.get(key).equals(oldValue)) {
				/// 
				///   map.put(key, newValue);
				/// 
				///   return true;
				/// 
				/// } else
				/// 
				///   return false; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was replaced </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TK;TV;TV;)Z")]
				public virtual bool Replace(K key, V oldValue, V newValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Replaces the entry for a key only if currently mapped to some value. This is equivalent to  <pre>if (map.containsKey(key)) {
				/// 
				///   return map.put(key, value);
				/// 
				/// } else
				/// 
				///   return null; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key. (A <c>null </c> return can also indicate that the map previously associated <c>null </c> with the key, if the implementation supports null values.) </para> <para>the previous value associated with the specified key, or <c>null </c> if there was no mapping for the key </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V Replace(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Returns the comparator used to compare keys in this sorted map, or null if the natural ordering is in use. </para>        
				/// </summary>
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TK;>;")]
				public virtual global::Java.Util.IComparator<K> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<K>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// firstKey
				/// </java-name>
				[Dot42.DexImport("firstKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K FirstKey() /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// lastKey
				/// </java-name>
				[Dot42.DexImport("lastKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K LastKey() /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigable" +
    "Map;", AccessFlags = 1, Signature = "(TK;ZTK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K toKey, bool inclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K fromKey, bool inclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMa" +
    "p;", AccessFlags = 1, Signature = "(TK;TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K fromKey, K toKey) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K toKey) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K fromKey) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V>);
				}

				/// <summary>
				///  <para>Returns a key-value mapping associated with the greatest key strictly less than the given key, or <c>null </c> if there is no such key. The returned entry does  <b>not</b> support the  <c>Entry.setValue </c> method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// lowerEntry
				/// </java-name>
				[Dot42.DexImport("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LowerEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// lowerKey
				/// </java-name>
				[Dot42.DexImport("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K LowerKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				///  <para>Returns a key-value mapping associated with the greatest key less than or equal to the given key, or <c>null </c> if there is no such key. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// floorEntry
				/// </java-name>
				[Dot42.DexImport("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> FloorEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// floorKey
				/// </java-name>
				[Dot42.DexImport("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K FloorKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				///  <para>Returns a key-value mapping associated with the least key greater than or equal to the given key, or <c>null </c> if there is no such entry. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// ceilingEntry
				/// </java-name>
				[Dot42.DexImport("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> CeilingEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// ceilingKey
				/// </java-name>
				[Dot42.DexImport("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K CeilingKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				///  <para>Returns a key-value mapping associated with the least key strictly greater than the given key, or <c>null </c> if there is no such key. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// higherEntry
				/// </java-name>
				[Dot42.DexImport("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> HigherEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// higherKey
				/// </java-name>
				[Dot42.DexImport("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K HigherKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				///  <para>Returns a key-value mapping associated with the least key in this map, or <c>null </c> if the map is empty. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// firstEntry
				/// </java-name>
				[Dot42.DexImport("firstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> FirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para>Returns a key-value mapping associated with the greatest key in this map, or <c>null </c> if the map is empty. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// lastEntry
				/// </java-name>
				[Dot42.DexImport("lastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LastEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para>Removes and returns a key-value mapping associated with the least key in this map, or <c>null </c> if the map is empty. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// pollFirstEntry
				/// </java-name>
				[Dot42.DexImport("pollFirstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> PollFirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				///  <para>Removes and returns a key-value mapping associated with the greatest key in this map, or <c>null </c> if the map is empty. The returned entry does  <b>not</b> support the <c>Entry.setValue </c> method. </para>        
				/// </summary>
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
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.HeadMap(K toKey, bool inclusive) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> global::Java.Util.INavigableMap<K, V>.TailMap(K fromKey, bool inclusive) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> global::Java.Util.INavigableMap<K, V>.SubMap(K fromKey, K toKey) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> global::Java.Util.INavigableMap<K, V>.HeadMap(K toKey) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				[Dot42.DexImport("java/util/NavigableMap", "tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> global::Java.Util.INavigableMap<K, V>.TailMap(K fromKey) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				/// <summary>
				///  <para>Returns <c>true </c> if this map contains no key-value mappings. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this map contains no key-value mappings </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A scalable concurrent NavigableSet implementation based on a ConcurrentSkipListMap. The elements of the set are kept sorted according to their  Comparable natural ordering}, or by a Comparator provided at set creation time, depending on which constructor is used.</para> <para>This implementation provides expected average  <b>log(n)</b> time cost for the <c>contains </c> , <c>add </c> , and <c>remove </c> operations and their variants. Insertion, removal, and access operations safely execute concurrently by multiple threads. Iterators are  <b>weakly consistent</b>, returning elements reflecting the state of the set at some point at or since the creation of the iterator. They do  <b>not</b> throw ConcurrentModificationException, and may proceed concurrently with other operations. Ascending ordered views and their iterators are faster than descending ones.</para> <para>Beware that, unlike in most collections, the <c>size </c> method is  <b>not</b> a constant-time operation. Because of the asynchronous nature of these sets, determining the current number of elements requires a traversal of the elements, and so may report inaccurate results if this collection is modified during traversal. Additionally, the bulk operations <c>addAll </c> ,  <c>removeAll </c> , <c>retainAll </c> , <c>containsAll </c> ,  <c>equals </c> , and <c>toArray </c> are  <b>not</b> guaranteed to be performed atomically. For example, an iterator operating concurrently with an <c>addAll </c> operation might view only some of the added elements.</para> <para>This class and its iterators implement all of the  <b>optional</b> methods of the Set and Iterator interfaces. Like most other concurrent collection implementations, this class does not permit the use of <c>null </c> elements, because <c>null </c> arguments and return values cannot be reliably distinguished from the absence of elements.</para> <para> <para>Doug Lea </para> <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ConcurrentSkipListSet
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentSkipListSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/util/NavigableSet<TE;>;Lj" +
    "ava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class ConcurrentSkipListSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.INavigableSet<E>, global::Java.Lang.ICloneable, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new, empty set that orders its elements according to their  Comparable natural ordering}. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentSkipListSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty set that orders its elements according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TE;>;)V")]
				public ConcurrentSkipListSet(global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty set that orders its elements according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ConcurrentSkipListSet(global::Java.Util.ICollection<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty set that orders its elements according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/SortedSet;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedSet<TE;>;)V")]
				public ConcurrentSkipListSet(global::Java.Util.ISortedSet<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a shallow copy of this <c>ConcurrentSkipListSet </c> instance. (The elements themselves are not cloned.)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a shallow copy of this set </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/concurrent/ConcurrentSkipListSet;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/ConcurrentSkipListSet<TE;>;")]
				public virtual global::Java.Util.Concurrent.ConcurrentSkipListSet<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ConcurrentSkipListSet<E>);
				}

				/// <summary>
				///  <para>Returns the number of elements in this set. If this set contains more than <c>Integer.MAX_VALUE </c> elements, it returns <c>Integer.MAX_VALUE </c> .</para> <para>Beware that, unlike in most collections, this method is  <b>NOT</b> a constant-time operation. Because of the asynchronous nature of these sets, determining the current number of elements requires traversing them all to count them. Additionally, it is possible for the size to change during execution of this method, in which case the returned result will be inaccurate. Thus, this method is typically not very useful in concurrent applications.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this set </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this set contains the specified element. More formally, returns <c>true </c> if and only if this set contains an element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Adds the specified element to this set if it is not already present. More formally, adds the specified element <c>e </c> to this set if the set contains no element <c>e2 </c> such that <c>e.equals(e2) </c> . If this set already contains the element, the call leaves the set unchanged and returns <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set did not already contain the specified element </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes the specified element from this set if it is present. More formally, removes an element <c>e </c> such that  <c>o.equals(e) </c> , if this set contains such an element. Returns <c>true </c> if this set contained the element (or equivalently, if this set changed as a result of the call). (This set will not contain the element once the call returns.)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contained the specified element </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes all of the elements from this set. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an iterator over the elements in this set in ascending order.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this set in ascending order </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <summary>
				///  <para>Returns an iterator over the elements in this set in descending order.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this set in descending order </para>
				/// </returns>
				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <summary>
				///  <para>Compares the specified object with this set for equality. Returns  <c>true </c> if the specified object is also a set, the two sets have the same size, and every member of the specified set is contained in this set (or equivalently, every member of this set is contained in the specified set). This definition ensures that the equals method works properly across different implementations of the set interface.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this set </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes from this set all of its elements that are contained in the specified collection. If the specified collection is also a set, this operation effectively modifies this set so that its value is the  <b>asymmetric set difference</b> of the two sets.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// lower
				/// </java-name>
				[Dot42.DexImport("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Lower(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Floor(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// ceiling
				/// </java-name>
				[Dot42.DexImport("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Ceiling(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// higher
				/// </java-name>
				[Dot42.DexImport("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Higher(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the first (lowest) element, or returns <c>null </c> if this set is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the first element, or <c>null </c> if this set is empty </para>
				/// </returns>
				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the last (highest) element, or returns <c>null </c> if this set is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the last element, or <c>null </c> if this set is empty </para>
				/// </returns>
				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns the comparator used to compare elements in this <c>SortedSet </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a comparator or null if the natural ordering is used. </para>
				/// </returns>
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TE;>;")]
				public virtual global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<E>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E First() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Last() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> SubSet(E fromElement, bool fromInclusive, E toElement, bool toInclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> HeadSet(E toElement, bool inclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> TailSet(E fromElement, bool inclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;TE;)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> SubSet(E fromElement, E toElement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> HeadSet(E toElement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> TailSet(E fromElement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				///  <para>Returns a reverse order view of the elements contained in this set. The descending set is backed by this set, so changes to the set are reflected in the descending set, and vice-versa.</para> <para>The returned set has an ordering equivalent to Collections.reverseOrder <c>(comparator()) </c> . The expression <c>s.descendingSet().descendingSet() </c> returns a view of <c>s </c> essentially equivalent to <c>s </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reverse order view of this set </para>
				/// </returns>
				/// <java-name>
				/// descendingSet
				/// </java-name>
				[Dot42.DexImport("descendingSet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> DescendingSet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				[Dot42.DexImport("java/util/NavigableSet", "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> global::Java.Util.INavigableSet<E>.SubSet(E fromElement, E toElement) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				[Dot42.DexImport("java/util/NavigableSet", "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> global::Java.Util.INavigableSet<E>.HeadSet(E toElement) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				[Dot42.DexImport("java/util/NavigableSet", "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> global::Java.Util.INavigableSet<E>.TailSet(E fromElement) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this set contains no elements. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contains no elements </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A thread-safe random-access list.</para> <para>Read operations (including get) do not block and may overlap with update operations. Reads reflect the results of the most recently completed operations. Aggregate operations like addAll and clear are atomic; they never expose an intermediate state.</para> <para>Iterators of this list never throw ConcurrentModificationException. When an iterator is created, it keeps a copy of the list's contents. It is always safe to iterate this list, but iterations may not reflect the latest state of the list.</para> <para>Iterators returned by this list and its sub lists cannot modify the underlying list. In particular, Iterator#remove, ListIterator#add and ListIterator#set all throw UnsupportedOperationException.</para> <para>This class offers extended API beyond the List interface. It includes additional overloads for indexed search (indexOf and lastIndexOf) and methods for conditional adds (addIfAbsent and addAllAbsent). </para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/CopyOnWriteArrayList
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CopyOnWriteArrayList", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/List<TE;>;Ljava/util/RandomAcc" +
    "ess;Ljava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class CopyOnWriteArrayList<E> : global::Java.Util.IList<E>, global::Java.Util.IRandomAccess, global::Java.Lang.ICloneable, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new empty instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CopyOnWriteArrayList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new instance containing the elements of <c>collection </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public CopyOnWriteArrayList(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new instance containing the elements of <c>collection </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/Object;)V", AccessFlags = 1, Signature = "([TE;)V")]
				public CopyOnWriteArrayList(E[] collection) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the number of elements in this <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this <c>List </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the element at the specified location in this <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the element at the specified location. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E Get(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Tests whether this <c>List </c> contains the specified object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if object is an element of this <c>List </c> , <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Tests whether this <c>List </c> contains all objects contained in the specified collection.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all objects in the specified collection are elements of this <c>List </c> , <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Searches this list for <c>object </c> and returns the index of the first occurrence that is at or after <c>from </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TE;I)I")]
				public virtual int IndexOf(E @object, int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Searches this <c>List </c> for the specified object and returns the index of the first occurrence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the first occurrence of the object or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Searches this list for <c>object </c> and returns the index of the last occurrence that is before <c>to </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TE;I)I")]
				public virtual int LastIndexOf(E @object, int to) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Searches this <c>List </c> for the specified object and returns the index of the last occurrence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the last occurrence of the object, or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an Iterator that iterates over the elements of this list as they were at the time of this method call. Changes to the list made after this method call will not be reflected by the iterator, nor will they trigger a ConcurrentModificationException.</para> <para>The returned iterator does not support Iterator#remove(). </para>        
				/// </summary>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <summary>
				///  <para>Returns a ListIterator that iterates over the elements of this list as they were at the time of this method call. Changes to the list made after this method call will not be reflected by the iterator, nor will they trigger a ConcurrentModificationException.</para> <para>The returned iterator does not support ListIterator#add, ListIterator#set or Iterator#remove(), </para>        
				/// </summary>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <summary>
				///  <para>Equivalent to <c>listIterator(0) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1, Signature = "()Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <summary>
				///  <para>Returns a <c>List </c> of the specified portion of this <c>List </c> from the given start index to the end index minus one. The returned <c>List </c> is backed by this  <c>List </c> so changes to it are reflected by the other.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of a portion of this <c>List </c> . </para>
				/// </returns>
				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 1, Signature = "(II)Ljava/util/List<TE;>;")]
				public virtual global::Java.Util.IList<E> SubList(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <summary>
				///  <para>Returns an array containing all elements contained in this <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of the elements from this <c>List </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Returns an array containing all elements contained in this <c>List </c> . If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this <c>List </c> , the array element following the collection elements is set to null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of the elements from this <c>List </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public virtual T[] ToArray<T>(T[] array) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Compares the given object with the <c>List </c> , and returns true if they represent the  <b>same</b> object using a class specific comparison. For  <c>List </c> s, this means that they contain the same elements in exactly the same order.</para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean <c>true </c> if the object is the same as this object, and <c>false </c> if it is different from this object. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the hash code for this <c>List </c> . It is calculated by taking each element' hashcode and its position in the <c>List </c> into account.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code of the <c>List </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Adds the specified object at the end of this <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>always true. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 33, Signature = "(TE;)Z")]
				public virtual bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified object into this <c>List </c> at the specified location. The object is inserted before the current element at the specified location. If the location is equal to the size of this <c>List </c> , the object is added at the end. If the location is smaller than the size of this  <c>List </c> , then all elements beyond the specified location are moved by one position towards the end of the <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 33, Signature = "(ITE;)V")]
				public virtual void Add(int location, E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds the objects in the specified collection to the end of this <c>List </c> . The objects are added in the order in which they are returned from the collection's iterator.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>List </c> is modified, <c>false </c> otherwise (i.e. if the passed collection was empty). </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the objects in the specified collection at the specified location in this <c>List </c> . The objects are added in the order they are returned from the collection's iterator.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this <c>List </c> has been modified through the insertion, false otherwise (i.e. if the passed collection was empty). </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 33, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(int location, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Adds the elements of <c>collection </c> that are not already present in this list. If <c>collection </c> includes a repeated value, at most one occurrence of that value will be added to this list. Elements are added at the end of this list.</para> <para>Callers of this method may prefer CopyOnWriteArraySet, whose API is more appropriate for set operations. </para>        
				/// </summary>
				/// <java-name>
				/// addAllAbsent
				/// </java-name>
				[Dot42.DexImport("addAllAbsent", "(Ljava/util/Collection;)I", AccessFlags = 33, Signature = "(Ljava/util/Collection<+TE;>;)I")]
				public virtual int AddAllAbsent(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Adds <c>object </c> to the end of this list if it is not already present.</para> <para>Callers of this method may prefer CopyOnWriteArraySet, whose API is more appropriate for set operations. </para>        
				/// </summary>
				/// <java-name>
				/// addIfAbsent
				/// </java-name>
				[Dot42.DexImport("addIfAbsent", "(Ljava/lang/Object;)Z", AccessFlags = 33, Signature = "(TE;)Z")]
				public virtual bool AddIfAbsent(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes all elements from this <c>List </c> , leaving it empty.</para> <para> <para>isEmpty </para> <para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the object at the specified location from this <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 33, Signature = "(I)TE;")]
				public virtual E Remove(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Removes the object at the specified location from this <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool Remove(object location) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes all occurrences in this <c>List </c> of each object in the specified collection.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>List </c> is modified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes all objects from this <c>List </c> that are not contained in the specified collection.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>List </c> is modified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Replaces the element at the specified location in this <c>List </c> with the specified object. This operation does not change the size of the <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous element at the index. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(ITE;)TE;")]
				public virtual E Set(int location, E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns whether this <c>List </c> contains no elements.</para> <para> <para>size </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>List </c> has no elements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A java.util.Set that uses an internal CopyOnWriteArrayList for all of its operations. Thus, it shares the same basic properties:  <ul> <li> <para>It is best suited for applications in which set sizes generally stay small, read-only operations vastly outnumber mutative operations, and you need to prevent interference among threads during traversal. </para></li> <li> <para>It is thread-safe. </para></li> <li> <para>Mutative operations ( <c>add </c> , <c>set </c> , <c>remove </c> , etc.) are expensive since they usually entail copying the entire underlying array. </para></li> <li> <para>Iterators do not support the mutative <c>remove </c> operation. </para></li> <li> <para>Traversal via iterators is fast and cannot encounter interference from other threads. Iterators rely on unchanging snapshots of the array at the time the iterators were constructed. </para></li></ul></para> <para> <b>Sample Usage.</b> The following code sketch uses a copy-on-write set to maintain a set of Handler objects that perform some action upon state updates.</para> <para> <pre>class Handler { void handle(); ... }
		/// 
		/// 
		/// 
		/// class X {
		/// 
		///   private final CopyOnWriteArraySet&lt;Handler&gt; handlers
		/// 
		///     = new CopyOnWriteArraySet&lt;Handler&gt;();
		/// 
		///   public void addHandler(Handler h) { handlers.add(h); }
		/// 
		/// 
		/// 
		///   private long internalState;
		/// 
		///   private synchronized void changeState() { internalState = ...; }
		/// 
		/// 
		/// 
		///   public void update() {
		/// 
		///     changeState();
		/// 
		///     for (Handler handler : handlers)
		/// 
		///       handler.handle();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para> <para>CopyOnWriteArrayList </para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/CopyOnWriteArraySet
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CopyOnWriteArraySet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/io/Serializable;")]
		public partial class CopyOnWriteArraySet<E> : global::Java.Util.AbstractSet<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an empty set. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CopyOnWriteArraySet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a set containing all of the elements of the specified collection.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public CopyOnWriteArraySet(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of elements in this set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this set </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this set contains the specified element. More formally, returns <c>true </c> if and only if this set contains an element <c>e </c> such that  <code>(o==null ? e==null : o.equals(e))</code>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this set. If this set makes any guarantees as to what order its elements are returned by its iterator, this method must return the elements in the same order.</para> <para>The returned array will be "safe" in that no references to it are maintained by this set. (In other words, this method must allocate a new array even if this set is backed by an array). The caller is thus free to modify the returned array.</para> <para>This method acts as bridge between array-based and collection-based APIs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all the elements in this set </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this set; the runtime type of the returned array is that of the specified array. If the set fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this set.</para> <para>If this set fits in the specified array with room to spare (i.e., the array has more elements than this set), the element in the array immediately following the end of the set is set to  <c>null </c> . (This is useful in determining the length of this set  <b>only</b> if the caller knows that this set does not contain any null elements.)</para> <para>If this set makes any guarantees as to what order its elements are returned by its iterator, this method must return the elements in the same order.</para> <para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para> <para>Suppose <c>x </c> is a set known to contain only strings. The following code can be used to dump the set into a newly allocated array of <c>String </c> :</para> <para> <pre>String[] y = x.toArray(new String[0]); 
				/// 
				///  </pre></para> <para>Note that <c>toArray(new Object[0]) </c> is identical in function to  <c>toArray() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all the elements in this set </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Removes all of the elements from this set. The set will be empty after this call returns. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the specified element from this set if it is present. More formally, removes an element <c>e </c> such that  <code>(o==null ? e==null : o.equals(e))</code>, if this set contains such an element. Returns <c>true </c> if this set contained the element (or equivalently, if this set changed as a result of the call). (This set will not contain the element once the call returns.)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contained the specified element </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Adds the specified element to this set if it is not already present. More formally, adds the specified element <c>e </c> to this set if the set contains no element <c>e2 </c> such that  <code>(e==null ? e2==null : e.equals(e2))</code>. If this set already contains the element, the call leaves the set unchanged and returns <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set did not already contain the specified element </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this set contains all of the elements of the specified collection. If the specified collection is also a set, this method returns <c>true </c> if it is a  <b>subset</b> of this set.</para> <para> <para>contains(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contains all of the elements of the specified collection </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Adds all of the elements in the specified collection to this set if they're not already present. If the specified collection is also a set, the <c>addAll </c> operation effectively modifies this set so that its value is the  <b>union</b> of the two sets. The behavior of this operation is undefined if the specified collection is modified while the operation is in progress.</para> <para> <para>#add(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes from this set all of its elements that are contained in the specified collection. If the specified collection is also a set, this operation effectively modifies this set so that its value is the  <b>asymmetric set difference</b> of the two sets.</para> <para> <para>remove(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retains only the elements in this set that are contained in the specified collection. In other words, removes from this set all of its elements that are not contained in the specified collection. If the specified collection is also a set, this operation effectively modifies this set so that its value is the  <b>intersection</b> of the two sets.</para> <para> <para>remove(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an iterator over the elements contained in this set in the order in which these elements were added.</para> <para>The returned iterator provides a snapshot of the state of the set when the iterator was constructed. No synchronization is needed while traversing the iterator. The iterator does  <b>NOT</b> support the  <c>remove </c> method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this set </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <summary>
				///  <para>Compares the specified object with this set for equality. Returns <c>true </c> if the specified object is the same object as this object, or if it is also a Set and the elements returned by an  List::iterator() iterator} over the specified set are the same as the elements returned by an iterator over this set. More formally, the two iterators are considered to return the same elements if they return the same number of elements and for every element <c>e1 </c> returned by the iterator over the specified set, there is an element  <c>e2 </c> returned by the iterator over this set such that  <c>(e1==null ? e2==null : e1.equals(e2)) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this set </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this set contains no elements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this set contains no elements </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A synchronization aid that allows one or more threads to wait until a set of operations being performed in other threads completes.</para> <para>A <c>CountDownLatch </c> is initialized with a given  <b>count</b>. The await methods block until the current count reaches zero due to invocations of the countDown method, after which all waiting threads are released and any subsequent invocations of await return immediately. This is a one-shot phenomenon  the count cannot be reset. If you need a version that resets the count, consider using a CyclicBarrier.</para> <para>A <c>CountDownLatch </c> is a versatile synchronization tool and can be used for a number of purposes. A  <c>CountDownLatch </c> initialized with a count of one serves as a simple on/off latch, or gate: all threads invoking await wait at the gate until it is opened by a thread invoking countDown. A <c>CountDownLatch </c> initialized to  <b>N</b> can be used to make one thread wait until  <b>N</b> threads have completed some action, or some action has been completed N times.</para> <para>A useful property of a <c>CountDownLatch </c> is that it doesn't require that threads calling <c>countDown </c> wait for the count to reach zero before proceeding, it simply prevents any thread from proceeding past an await until all threads could pass.</para> <para> <b>Sample usage:</b> Here is a pair of classes in which a group of worker threads use two countdown latches:  <ul> <li> <para>The first is a start signal that prevents any worker from proceeding until the driver is ready for them to proceed; </para></li> <li> <para>The second is a completion signal that allows the driver to wait until all workers have completed. </para></li></ul></para> <para> <pre>class Driver { // ...
		/// 
		///   void main() throws InterruptedException {
		/// 
		///     CountDownLatch startSignal = new CountDownLatch(1);
		/// 
		///     CountDownLatch doneSignal = new CountDownLatch(N);
		/// 
		/// 
		/// 
		///     for (int i = 0; i &lt; N; ++i) // create and start threads
		/// 
		///       new Thread(new Worker(startSignal, doneSignal)).start();
		/// 
		/// 
		/// 
		///     doSomethingElse();            // don't let run yet
		/// 
		///     startSignal.countDown();      // let all threads proceed
		/// 
		///     doSomethingElse();
		/// 
		///     doneSignal.await();           // wait for all to finish
		/// 
		///   }
		/// 
		/// }
		/// 
		/// 
		/// 
		/// class Worker implements Runnable {
		/// 
		///   private final CountDownLatch startSignal;
		/// 
		///   private final CountDownLatch doneSignal;
		/// 
		///   Worker(CountDownLatch startSignal, CountDownLatch doneSignal) {
		/// 
		///     this.startSignal = startSignal;
		/// 
		///     this.doneSignal = doneSignal;
		/// 
		///   }
		/// 
		///   public void run() {
		/// 
		///     try {
		/// 
		///       startSignal.await();
		/// 
		///       doWork();
		/// 
		///       doneSignal.countDown();
		/// 
		///     } catch (InterruptedException ex) {} // return;
		/// 
		///   }
		/// 
		/// 
		/// 
		///   void doWork() { ... }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Another typical usage would be to divide a problem into N parts, describe each part with a Runnable that executes that portion and counts down on the latch, and queue all the Runnables to an Executor. When all sub-parts are complete, the coordinating thread will be able to pass through await. (When threads must repeatedly count down in this way, instead use a CyclicBarrier.)</para> <para> <pre>class Driver2 { // ...
		/// 
		///   void main() throws InterruptedException {
		/// 
		///     CountDownLatch doneSignal = new CountDownLatch(N);
		/// 
		///     Executor e = ...
		/// 
		/// 
		/// 
		///     for (int i = 0; i &lt; N; ++i) // create and start threads
		/// 
		///       e.execute(new WorkerRunnable(doneSignal, i));
		/// 
		/// 
		/// 
		///     doneSignal.await();           // wait for all to finish
		/// 
		///   }
		/// 
		/// }
		/// 
		/// 
		/// 
		/// class WorkerRunnable implements Runnable {
		/// 
		///   private final CountDownLatch doneSignal;
		/// 
		///   private final int i;
		/// 
		///   WorkerRunnable(CountDownLatch doneSignal, int i) {
		/// 
		///     this.doneSignal = doneSignal;
		/// 
		///     this.i = i;
		/// 
		///   }
		/// 
		///   public void run() {
		/// 
		///     try {
		/// 
		///       doWork(i);
		/// 
		///       doneSignal.countDown();
		/// 
		///     } catch (InterruptedException ex) {} // return;
		/// 
		///   }
		/// 
		/// 
		/// 
		///   void doWork() { ... }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Memory consistency effects: Until the count reaches zero, actions in a thread prior to calling  <c>countDown() </c>  actions following a successful return from a corresponding  <c>await() </c> in another thread.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/CountDownLatch
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CountDownLatch", AccessFlags = 33)]
		public partial class CountDownLatch
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>CountDownLatch </c> initialized with the given count.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CountDownLatch(int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes the current thread to wait until the latch has counted down to zero, unless the thread is  Thread::interrupt interrupted}.</para> <para>If the current count is zero then this method returns immediately.</para> <para>If the current count is greater than zero then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happen:  <ul> <li> <para>The count reaches zero due to invocations of the countDown method; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "()V", AccessFlags = 1)]
				public virtual void Await() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes the current thread to wait until the latch has counted down to zero, unless the thread is  Thread::interrupt interrupted}, or the specified waiting time elapses.</para> <para>If the current count is zero then this method returns immediately with the value <c>true </c> .</para> <para>If the current count is greater than zero then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happen:  <ul> <li> <para>The count reaches zero due to invocations of the countDown method; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread; or </para></li> <li> <para>The specified waiting time elapses. </para></li></ul></para> <para>If the count reaches zero then the method returns with the value <c>true </c> .</para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para>If the specified waiting time elapses then the value <c>false </c> is returned. If the time is less than or equal to zero, the method will not wait at all.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the count reached zero and <c>false </c> if the waiting time elapsed before the count reached zero </para>
				/// </returns>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool Await(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Decrements the count of the latch, releasing all waiting threads if the count reaches zero.</para> <para>If the current count is greater than zero then it is decremented. If the new count is zero then all waiting threads are re-enabled for thread scheduling purposes.</para> <para>If the current count equals zero then nothing happens. </para>        
				/// </summary>
				/// <java-name>
				/// countDown
				/// </java-name>
				[Dot42.DexImport("countDown", "()V", AccessFlags = 1)]
				public virtual void CountDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string identifying this latch, as well as its state. The state, in brackets, includes the String <c>"Count =" </c> followed by the current count.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string identifying this latch, as well as its state </para>
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
				internal CountDownLatch() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the current count.</para> <para>This method is typically used for debugging and testing purposes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current count </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual long Count
				{
						[Dot42.DexImport("getCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>A synchronization aid that allows a set of threads to all wait for each other to reach a common barrier point. CyclicBarriers are useful in programs involving a fixed sized party of threads that must occasionally wait for each other. The barrier is called  <b>cyclic</b> because it can be re-used after the waiting threads are released.</para> <para>A <c>CyclicBarrier </c> supports an optional Runnable command that is run once per barrier point, after the last thread in the party arrives, but before any threads are released. This  <b>barrier action</b> is useful for updating shared-state before any of the parties continue.</para> <para> <b>Sample usage:</b> Here is an example of using a barrier in a parallel decomposition design:</para> <para> <pre>class Solver {
		/// 
		///   final int N;
		/// 
		///   final float[][] data;
		/// 
		///   final CyclicBarrier barrier;
		/// 
		/// 
		/// 
		///   class Worker implements Runnable {
		/// 
		///     int myRow;
		/// 
		///     Worker(int row) { myRow = row; }
		/// 
		///     public void run() {
		/// 
		///       while (!done()) {
		/// 
		///         processRow(myRow);
		/// 
		/// 
		/// 
		///         try {
		/// 
		///           barrier.await();
		/// 
		///         } catch (InterruptedException ex) {
		/// 
		///           return;
		/// 
		///         } catch (BrokenBarrierException ex) {
		/// 
		///           return;
		/// 
		///         }
		/// 
		///       }
		/// 
		///     }
		/// 
		///   }
		/// 
		/// 
		/// 
		///   public Solver(float[][] matrix) {
		/// 
		///     data = matrix;
		/// 
		///     N = matrix.length;
		/// 
		///     barrier = new CyclicBarrier(N,
		/// 
		///                                 new Runnable() {
		/// 
		///                                   public void run() {
		/// 
		///                                     mergeRows(...);
		/// 
		///                                   }
		/// 
		///                                 });
		/// 
		///     for (int i = 0; i &lt; N; ++i)
		/// 
		///       new Thread(new Worker(i)).start();
		/// 
		/// 
		/// 
		///     waitUntilDone();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Here, each worker thread processes a row of the matrix then waits at the barrier until all rows have been processed. When all rows are processed the supplied Runnable barrier action is executed and merges the rows. If the merger determines that a solution has been found then <c>done() </c> will return  <c>true </c> and each worker will terminate.</para> <para>If the barrier action does not rely on the parties being suspended when it is executed, then any of the threads in the party could execute that action when it is released. To facilitate this, each invocation of await returns the arrival index of that thread at the barrier. You can then choose which thread should execute the barrier action, for example:  <pre>if (barrier.await() == 0) {
		/// 
		///   // log the completion of this iteration
		/// 
		/// } 
		/// 
		///  </pre></para> <para>The <c>CyclicBarrier </c> uses an all-or-none breakage model for failed synchronization attempts: If a thread leaves a barrier point prematurely because of interruption, failure, or timeout, all other threads waiting at that barrier point will also leave abnormally via BrokenBarrierException (or InterruptedException if they too were interrupted at about the same time).</para> <para>Memory consistency effects: Actions in a thread prior to calling  <c>await() </c>  actions that are part of the barrier action, which in turn  <b>happen-before</b> actions following a successful return from the corresponding <c>await() </c> in other threads.</para> <para> <para>1.5 </para> <para>CountDownLatch</para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/CyclicBarrier
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CyclicBarrier", AccessFlags = 33)]
		public partial class CyclicBarrier
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CyclicBarrier </c> that will trip when the given number of parties (threads) are waiting upon it, and which will execute the given barrier action when the barrier is tripped, performed by the last thread entering the barrier.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/Runnable;)V", AccessFlags = 1)]
				public CyclicBarrier(int parties, global::Java.Lang.IRunnable barrierAction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CyclicBarrier </c> that will trip when the given number of parties (threads) are waiting upon it, and does not perform a predefined action when the barrier is tripped.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CyclicBarrier(int parties) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Waits until all  getParties parties} have invoked  <c>await </c> on this barrier.</para> <para>If the current thread is not the last to arrive then it is disabled for thread scheduling purposes and lies dormant until one of the following things happens:  <ul> <li> <para>The last thread arrives; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} one of the other waiting threads; or </para></li> <li> <para>Some other thread times out while waiting for barrier; or </para></li> <li> <para>Some other thread invokes reset on this barrier. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para>If the barrier is reset while any thread is waiting, or if the barrier  isBroken is broken} when  <c>await </c> is invoked, or while any thread is waiting, then BrokenBarrierException is thrown.</para> <para>If any thread is  Thread::interrupt interrupted} while waiting, then all other waiting threads will throw BrokenBarrierException and the barrier is placed in the broken state.</para> <para>If the current thread is the last thread to arrive, and a non-null barrier action was supplied in the constructor, then the current thread runs the action before allowing the other threads to continue. If an exception occurs during the barrier action then that exception will be propagated in the current thread and the barrier is placed in the broken state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the arrival index of the current thread, where index  <c>getParties() - 1 </c> indicates the first to arrive and zero indicates the last to arrive </para>
				/// </returns>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "()I", AccessFlags = 1)]
				public virtual int Await() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Waits until all  getParties parties} have invoked  <c>await </c> on this barrier, or the specified waiting time elapses.</para> <para>If the current thread is not the last to arrive then it is disabled for thread scheduling purposes and lies dormant until one of the following things happens:  <ul> <li> <para>The last thread arrives; or </para></li> <li> <para>The specified timeout elapses; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} one of the other waiting threads; or </para></li> <li> <para>Some other thread times out while waiting for barrier; or </para></li> <li> <para>Some other thread invokes reset on this barrier. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para>If the specified waiting time elapses then TimeoutException is thrown. If the time is less than or equal to zero, the method will not wait at all.</para> <para>If the barrier is reset while any thread is waiting, or if the barrier  isBroken is broken} when  <c>await </c> is invoked, or while any thread is waiting, then BrokenBarrierException is thrown.</para> <para>If any thread is  Thread::interrupt interrupted} while waiting, then all other waiting threads will throw BrokenBarrierException and the barrier is placed in the broken state.</para> <para>If the current thread is the last thread to arrive, and a non-null barrier action was supplied in the constructor, then the current thread runs the action before allowing the other threads to continue. If an exception occurs during the barrier action then that exception will be propagated in the current thread and the barrier is placed in the broken state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the arrival index of the current thread, where index  <c>getParties() - 1 </c> indicates the first to arrive and zero indicates the last to arrive </para>
				/// </returns>
				/// <java-name>
				/// await
				/// </java-name>
				[Dot42.DexImport("await", "(JLjava/util/concurrent/TimeUnit;)I", AccessFlags = 1)]
				public virtual int Await(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets the barrier to its initial state. If any parties are currently waiting at the barrier, they will return with a BrokenBarrierException. Note that resets  <b>after</b> a breakage has occurred for other reasons can be complicated to carry out; threads need to re-synchronize in some other way, and choose one to perform the reset. It may be preferable to instead create a new barrier for subsequent use. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CyclicBarrier() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of parties required to trip this barrier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of parties required to trip this barrier </para>
				/// </returns>
				/// <java-name>
				/// getParties
				/// </java-name>
				public virtual int Parties
				{
						[Dot42.DexImport("getParties", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Queries if this barrier is in a broken state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if one or more parties broke out of this barrier due to interruption or timeout since construction or the last reset, or a barrier action failed due to an exception; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isBroken
				/// </java-name>
				public virtual bool IsBroken
				{
						[Dot42.DexImport("isBroken", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the number of parties currently waiting at the barrier. This method is primarily useful for debugging and assertions.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of parties currently blocked in await </para>
				/// </returns>
				/// <java-name>
				/// getNumberWaiting
				/// </java-name>
				public virtual int NumberWaiting
				{
						[Dot42.DexImport("getNumberWaiting", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>An unbounded  BlockingQueue blocking queue} of  <c>Delayed </c> elements, in which an element can only be taken when its delay has expired. The  <b>head</b> of the queue is that  <c>Delayed </c> element whose delay expired furthest in the past. If no delay has expired there is no head and <c>poll </c> will return <c>null </c> . Expiration occurs when an element's  <c>getDelay(TimeUnit.NANOSECONDS) </c> method returns a value less than or equal to zero. Even though unexpired elements cannot be removed using <c>take </c> or <c>poll </c> , they are otherwise treated as normal elements. For example, the <c>size </c> method returns the count of both expired and unexpired elements. This queue does not permit null elements.</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Collection and Iterator interfaces. The Iterator provided in method iterator() is  <b>not</b> guaranteed to traverse the elements of the DelayQueue in any particular order.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/DelayQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/DelayQueue", AccessFlags = 33, Signature = "<E::Ljava/util/concurrent/Delayed;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concu" +
    "rrent/BlockingQueue<TE;>;")]
		public partial class DelayQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>DelayQueue </c> that is initially empty. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DelayQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>DelayQueue </c> initially containing the elements of the given collection of Delayed instances.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public DelayQueue(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element into this delay queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Collection#add) </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/util/concurrent/Delayed;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element into this delay queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/util/concurrent/Delayed;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element into this delay queue. As the queue is unbounded this method will never block.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/util/concurrent/Delayed;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element into this delay queue. As the queue is unbounded this method will never block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, or returns <c>null </c> if this queue has no elements with an expired delay.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if this queue has no elements with an expired delay </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary until an element with an expired delay is available on this queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary until an element with an expired delay is available on this queue, or the specified wait time expires.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if the specified waiting time elapses before an element with an expired delay becomes available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of this queue, or returns <c>null </c> if this queue is empty. Unlike  <c>poll </c> , if no expired elements are available in the queue, this method returns the element that will expire next, if one exists.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/util/concurrent/Delayed;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns a count of how many objects this <c>Collection </c> contains.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>how many objects this <c>Collection </c> contains, or Integer.MAX_VALUE if there are more than Integer.MAX_VALUE elements in this  <c>Collection </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Atomically removes all of the elements from this delay queue. The queue will be empty after this call returns. Elements with an unexpired delay are not waited for; they are simply discarded from the queue. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Always returns <c>Integer.MAX_VALUE </c> because a <c>DelayQueue </c> is not capacity constrained.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>Integer.MAX_VALUE </c> </para>
				/// </returns>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue. The returned array elements are in no particular order.</para> <para>The returned array will be "safe" in that no references to it are maintained by this queue. (In other words, this method must allocate a new array). The caller is thus free to modify the returned array.</para> <para>This method acts as bridge between array-based and collection-based APIs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue; the runtime type of the returned array is that of the specified array. The returned array elements are in no particular order. If the queue fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this queue.</para> <para>If this queue fits in the specified array with room to spare (i.e., the array has more elements than this queue), the element in the array immediately following the end of the queue is set to  <c>null </c> .</para> <para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para> <para>The following code can be used to dump a delay queue into a newly allocated array of <c>Delayed </c> :</para> <para> <pre>Delayed[] a = q.toArray(new Delayed[0]); 
				/// 
				///  </pre></para> <para>Note that <c>toArray(new Object[0]) </c> is identical in function to  <c>toArray() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Removes a single instance of the specified element from this queue, if it is present, whether or not it has expired. </para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an iterator over all the elements (both expired and unexpired) in this queue. The iterator does not return the elements in any particular order.</para> <para>The returned iterator is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/concurrent/BlockingQueue", "contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Contains(object o) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A synchronization point at which threads can pair and swap elements within pairs. Each thread presents some object on entry to the exchange method, matches with a partner thread, and receives its partner's object on return. An Exchanger may be viewed as a bidirectional form of a SynchronousQueue. Exchangers may be useful in applications such as genetic algorithms and pipeline designs.</para> <para> <b>Sample Usage:</b> Here are the highlights of a class that uses an <c>Exchanger </c> to swap buffers between threads so that the thread filling the buffer gets a freshly emptied one when it needs it, handing off the filled one to the thread emptying the buffer.  <pre>class FillAndEmpty {
		/// 
		///   Exchanger&lt;DataBuffer&gt; exchanger = new Exchanger&lt;DataBuffer&gt;();
		/// 
		///   DataBuffer initialEmptyBuffer = ... a made-up type
		/// 
		///   DataBuffer initialFullBuffer = ...
		/// 
		/// 
		/// 
		///   class FillingLoop implements Runnable {
		/// 
		///     public void run() {
		/// 
		///       DataBuffer currentBuffer = initialEmptyBuffer;
		/// 
		///       try {
		/// 
		///         while (currentBuffer != null) {
		/// 
		///           addToBuffer(currentBuffer);
		/// 
		///           if (currentBuffer.isFull())
		/// 
		///             currentBuffer = exchanger.exchange(currentBuffer);
		/// 
		///         }
		/// 
		///       } catch (InterruptedException ex) { ... handle ... }
		/// 
		///     }
		/// 
		///   }
		/// 
		/// 
		/// 
		///   class EmptyingLoop implements Runnable {
		/// 
		///     public void run() {
		/// 
		///       DataBuffer currentBuffer = initialFullBuffer;
		/// 
		///       try {
		/// 
		///         while (currentBuffer != null) {
		/// 
		///           takeFromBuffer(currentBuffer);
		/// 
		///           if (currentBuffer.isEmpty())
		/// 
		///             currentBuffer = exchanger.exchange(currentBuffer);
		/// 
		///         }
		/// 
		///       } catch (InterruptedException ex) { ... handle ...}
		/// 
		///     }
		/// 
		///   }
		/// 
		/// 
		/// 
		///   void start() {
		/// 
		///     new Thread(new FillingLoop()).start();
		/// 
		///     new Thread(new EmptyingLoop()).start();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Memory consistency effects: For each pair of threads that successfully exchange objects via an <c>Exchanger </c> , actions prior to the <c>exchange() </c> in each thread  those subsequent to a return from the corresponding <c>exchange() </c> in the other thread.</para> <para> <para>1.5 </para> <para>Doug Lea and Bill Scherer and Michael Scott </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Exchanger
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Exchanger", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class Exchanger<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new Exchanger. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Exchanger() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Waits for another thread to arrive at this exchange point (unless the current thread is  Thread::interrupt interrupted}), and then transfers the given object to it, receiving its object in return.</para> <para>If another thread is already waiting at the exchange point then it is resumed for thread scheduling purposes and receives the object passed in by the current thread. The current thread returns immediately, receiving the object passed to the exchange by that other thread.</para> <para>If no other thread is already waiting at the exchange then the current thread is disabled for thread scheduling purposes and lies dormant until one of two things happens:  <ul> <li> <para>Some other thread enters the exchange; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting for the exchange, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the object provided by the other thread </para>
				/// </returns>
				/// <java-name>
				/// exchange
				/// </java-name>
				[Dot42.DexImport("exchange", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TV;)TV;")]
				public virtual V Exchange(V x) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Waits for another thread to arrive at this exchange point (unless the current thread is  Thread::interrupt interrupted} or the specified waiting time elapses), and then transfers the given object to it, receiving its object in return.</para> <para>If another thread is already waiting at the exchange point then it is resumed for thread scheduling purposes and receives the object passed in by the current thread. The current thread returns immediately, receiving the object passed to the exchange by that other thread.</para> <para>If no other thread is already waiting at the exchange then the current thread is disabled for thread scheduling purposes and lies dormant until one of three things happens:  <ul> <li> <para>Some other thread enters the exchange; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread; or </para></li> <li> <para>The specified waiting time elapses. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting for the exchange, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para>If the specified waiting time elapses then TimeoutException is thrown. If the time is less than or equal to zero, the method will not wait at all.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the object provided by the other thread </para>
				/// </returns>
				/// <java-name>
				/// exchange
				/// </java-name>
				[Dot42.DexImport("exchange", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TV;JLjava/util/concurrent/TimeUnit;)TV;")]
				public virtual V Exchange(V x, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

		}

		/// <summary>
		///  <para>Exception thrown when attempting to retrieve the result of a task that aborted by throwing an exception. This exception can be inspected using the getCause() method.</para> <para> <para>Future </para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ExecutionException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ExecutionException", AccessFlags = 33)]
		public partial class ExecutionException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs an <c>ExecutionException </c> with no detail message. The cause is not initialized, and may subsequently be initialized by a call to initCause. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ExecutionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal ExecutionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs an <c>ExecutionException </c> with the specified detail message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ExecutionException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ExecutionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A CompletionService that uses a supplied Executor to execute tasks. This class arranges that submitted tasks are, upon completion, placed on a queue accessible using <c>take </c> . The class is lightweight enough to be suitable for transient use when processing groups of tasks.</para> <para> <b>Usage Examples.</b></para> <para>Suppose you have a set of solvers for a certain problem, each returning a value of some type <c>Result </c> , and would like to run them concurrently, processing the results of each of them that return a non-null value, in some method <c>use(Result r) </c> . You could write this as:</para> <para> <pre>void solve(Executor e,
		/// 
		///            Collection&lt;Callable&lt;Result&gt;&gt; solvers)
		/// 
		///     throws InterruptedException, ExecutionException {
		/// 
		///     CompletionService&lt;Result&gt; ecs
		/// 
		///         = new ExecutorCompletionService&lt;Result&gt;(e);
		/// 
		///     for (Callable&lt;Result&gt; s : solvers)
		/// 
		///         ecs.submit(s);
		/// 
		///     int n = solvers.size();
		/// 
		///     for (int i = 0; i &lt; n; ++i) {
		/// 
		///         Result r = ecs.take().get();
		/// 
		///         if (r != null)
		/// 
		///             use(r);
		/// 
		///     }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Suppose instead that you would like to use the first non-null result of the set of tasks, ignoring any that encounter exceptions, and cancelling all other tasks when the first one is ready:</para> <para> <pre>void solve(Executor e,
		/// 
		///            Collection&lt;Callable&lt;Result&gt;&gt; solvers)
		/// 
		///     throws InterruptedException {
		/// 
		///     CompletionService&lt;Result&gt; ecs
		/// 
		///         = new ExecutorCompletionService&lt;Result&gt;(e);
		/// 
		///     int n = solvers.size();
		/// 
		///     List&lt;Future&lt;Result&gt;&gt; futures
		/// 
		///         = new ArrayList&lt;Future&lt;Result&gt;&gt;(n);
		/// 
		///     Result result = null;
		/// 
		///     try {
		/// 
		///         for (Callable&lt;Result&gt; s : solvers)
		/// 
		///             futures.add(ecs.submit(s));
		/// 
		///         for (int i = 0; i &lt; n; ++i) {
		/// 
		///             try {
		/// 
		///                 Result r = ecs.take().get();
		/// 
		///                 if (r != null) {
		/// 
		///                     result = r;
		/// 
		///                     break;
		/// 
		///                 }
		/// 
		///             } catch (ExecutionException ignore) {}
		/// 
		///         }
		/// 
		///     }
		/// 
		///     finally {
		/// 
		///         for (Future&lt;Result&gt; f : futures)
		/// 
		///             f.cancel(true);
		/// 
		///     }
		/// 
		/// 
		/// 
		///     if (result != null)
		/// 
		///         use(result);
		/// 
		/// } 
		/// 
		///  </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ExecutorCompletionService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ExecutorCompletionService", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/CompletionService<T" +
    "V;>;")]
		public partial class ExecutorCompletionService<V> : global::Java.Util.Concurrent.ICompletionService<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an ExecutorCompletionService using the supplied executor for base task execution and a LinkedBlockingQueue as a completion queue.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/Executor;)V", AccessFlags = 1)]
				public ExecutorCompletionService(global::Java.Util.Concurrent.IExecutor executor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an ExecutorCompletionService using the supplied executor for base task execution and the supplied queue as its completion queue.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V", AccessFlags = 1, Signature = "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue<Ljava/util/co" +
    "ncurrent/Future<TV;>;>;)V")]
				public ExecutorCompletionService(global::Java.Util.Concurrent.IExecutor executor, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Util.Concurrent.IFuture<V>> completionQueue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Submits a value-returning task for execution and returns a Future representing the pending results of the task. Upon completion, this task may be taken or polled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/util/concurrent/Callable<TV;>;)Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Util.Concurrent.ICallable<V> task) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <summary>
				///  <para>Submits a Runnable task for execution and returns a Future representing that task. Upon completion, this task may be taken or polled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task, and whose <c>get() </c> method will return the given result value upon completion </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;TV;)Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Lang.IRunnable task, V result) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <summary>
				///  <para>Retrieves and removes the Future representing the next completed task, waiting if none are yet present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Future representing the next completed task </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Take() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <summary>
				///  <para>Retrieves and removes the Future representing the next completed task, or <c>null </c> if none are present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Future representing the next completed task, or  <c>null </c> if none are present </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Poll() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				/// <summary>
				///  <para>Retrieves and removes the Future representing the next completed task, waiting if necessary up to the specified wait time if none are yet present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Future representing the next completed task or  <c>null </c> if the specified waiting time elapses before one is present </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future<TV;>;")]
				public virtual global::Java.Util.Concurrent.IFuture<V> Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<V>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExecutorCompletionService() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Factory and utility methods for Executor, ExecutorService, ScheduledExecutorService, ThreadFactory, and Callable classes defined in this package. This class supports the following kinds of methods:</para> <para> <ul> <li> <para>Methods that create and return an ExecutorService set up with commonly useful configuration settings. </para></li> <li> <para>Methods that create and return a ScheduledExecutorService set up with commonly useful configuration settings. </para></li> <li> <para>Methods that create and return a "wrapped" ExecutorService, that disables reconfiguration by making implementation-specific methods inaccessible. </para></li> <li> <para>Methods that create and return a ThreadFactory that sets newly created threads to a known state. </para></li> <li> <para>Methods that create and return a Callable out of other closure-like forms, so they can be used in execution methods requiring <c>Callable </c> . </para></li></ul></para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Executors
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Executors", AccessFlags = 33)]
		public partial class Executors
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Cannot instantiate. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Executors() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a thread pool that reuses a fixed number of threads operating off a shared unbounded queue. At any point, at most  <c>nThreads </c> threads will be active processing tasks. If additional tasks are submitted when all threads are active, they will wait in the queue until a thread is available. If any thread terminates due to a failure during execution prior to shutdown, a new one will take its place if needed to execute subsequent tasks. The threads in the pool will exist until it is explicitly shutdown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created thread pool </para>
				/// </returns>
				/// <java-name>
				/// newFixedThreadPool
				/// </java-name>
				[Dot42.DexImport("newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewFixedThreadPool(int nThreads) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Creates a thread pool that reuses a fixed number of threads operating off a shared unbounded queue, using the provided ThreadFactory to create new threads when needed. At any point, at most <c>nThreads </c> threads will be active processing tasks. If additional tasks are submitted when all threads are active, they will wait in the queue until a thread is available. If any thread terminates due to a failure during execution prior to shutdown, a new one will take its place if needed to execute subsequent tasks. The threads in the pool will exist until it is explicitly shutdown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created thread pool </para>
				/// </returns>
				/// <java-name>
				/// newFixedThreadPool
				/// </java-name>
				[Dot42.DexImport("newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewFixedThreadPool(int nThreads, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Creates an Executor that uses a single worker thread operating off an unbounded queue. (Note however that if this single thread terminates due to a failure during execution prior to shutdown, a new one will take its place if needed to execute subsequent tasks.) Tasks are guaranteed to execute sequentially, and no more than one task will be active at any given time. Unlike the otherwise equivalent  <c>newFixedThreadPool(1) </c> the returned executor is guaranteed not to be reconfigurable to use additional threads.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created single-threaded Executor </para>
				/// </returns>
				/// <java-name>
				/// newSingleThreadExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Creates an Executor that uses a single worker thread operating off an unbounded queue, and uses the provided ThreadFactory to create a new thread when needed. Unlike the otherwise equivalent <c>newFixedThreadPool(1, threadFactory) </c> the returned executor is guaranteed not to be reconfigurable to use additional threads.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created single-threaded Executor </para>
				/// </returns>
				/// <java-name>
				/// newSingleThreadExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Creates a thread pool that creates new threads as needed, but will reuse previously constructed threads when they are available. These pools will typically improve the performance of programs that execute many short-lived asynchronous tasks. Calls to <c>execute </c> will reuse previously constructed threads if available. If no existing thread is available, a new thread will be created and added to the pool. Threads that have not been used for sixty seconds are terminated and removed from the cache. Thus, a pool that remains idle for long enough will not consume any resources. Note that pools with similar properties but different details (for example, timeout parameters) may be created using ThreadPoolExecutor constructors.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created thread pool </para>
				/// </returns>
				/// <java-name>
				/// newCachedThreadPool
				/// </java-name>
				[Dot42.DexImport("newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Creates a thread pool that creates new threads as needed, but will reuse previously constructed threads when they are available, and uses the provided ThreadFactory to create new threads when needed. </para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created thread pool </para>
				/// </returns>
				/// <java-name>
				/// newCachedThreadPool
				/// </java-name>
				[Dot42.DexImport("newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Creates a single-threaded executor that can schedule commands to run after a given delay, or to execute periodically. (Note however that if this single thread terminates due to a failure during execution prior to shutdown, a new one will take its place if needed to execute subsequent tasks.) Tasks are guaranteed to execute sequentially, and no more than one task will be active at any given time. Unlike the otherwise equivalent  <c>newScheduledThreadPool(1) </c> the returned executor is guaranteed not to be reconfigurable to use additional threads. </para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created scheduled executor </para>
				/// </returns>
				/// <java-name>
				/// newSingleThreadScheduledExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewSingleThreadScheduledExecutor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <summary>
				///  <para>Creates a single-threaded executor that can schedule commands to run after a given delay, or to execute periodically. (Note however that if this single thread terminates due to a failure during execution prior to shutdown, a new one will take its place if needed to execute subsequent tasks.) Tasks are guaranteed to execute sequentially, and no more than one task will be active at any given time. Unlike the otherwise equivalent <c>newScheduledThreadPool(1, threadFactory) </c> the returned executor is guaranteed not to be reconfigurable to use additional threads. </para>        
				/// </summary>
				/// <returns>
				///  <para>a newly created scheduled executor </para>
				/// </returns>
				/// <java-name>
				/// newSingleThreadScheduledExecutor
				/// </java-name>
				[Dot42.DexImport("newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorServ" +
    "ice;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewSingleThreadScheduledExecutor(global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <summary>
				///  <para>Creates a thread pool that can schedule commands to run after a given delay, or to execute periodically. </para>        
				/// </summary>
				/// <returns>
				///  <para>a newly created scheduled thread pool </para>
				/// </returns>
				/// <java-name>
				/// newScheduledThreadPool
				/// </java-name>
				[Dot42.DexImport("newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewScheduledThreadPool(int corePoolSize) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <summary>
				///  <para>Creates a thread pool that can schedule commands to run after a given delay, or to execute periodically. </para>        
				/// </summary>
				/// <returns>
				///  <para>a newly created scheduled thread pool </para>
				/// </returns>
				/// <java-name>
				/// newScheduledThreadPool
				/// </java-name>
				[Dot42.DexImport("newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorSer" +
    "vice;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService NewScheduledThreadPool(int corePoolSize, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <summary>
				///  <para>Returns an object that delegates all defined ExecutorService methods to the given executor, but not any other methods that might otherwise be accessible using casts. This provides a way to safely "freeze" configuration and disallow tuning of a given concrete implementation. </para>        
				/// </summary>
				/// <returns>
				///  <para>an <c>ExecutorService </c> instance </para>
				/// </returns>
				/// <java-name>
				/// unconfigurableExecutorService
				/// </java-name>
				[Dot42.DexImport("unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IExecutorService UnconfigurableExecutorService(global::Java.Util.Concurrent.IExecutorService executor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IExecutorService);
				}

				/// <summary>
				///  <para>Returns an object that delegates all defined ScheduledExecutorService methods to the given executor, but not any other methods that might otherwise be accessible using casts. This provides a way to safely "freeze" configuration and disallow tuning of a given concrete implementation. </para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ScheduledExecutorService </c> instance </para>
				/// </returns>
				/// <java-name>
				/// unconfigurableScheduledExecutorService
				/// </java-name>
				[Dot42.DexImport("unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledE" +
    "xecutorService;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IScheduledExecutorService UnconfigurableScheduledExecutorService(global::Java.Util.Concurrent.IScheduledExecutorService executor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledExecutorService);
				}

				/// <summary>
				///  <para>Returns a default thread factory used to create new threads. This factory creates all new threads used by an Executor in the same ThreadGroup. Each new thread is created as a non-daemon thread with priority set to the smaller of <c>Thread.NORM_PRIORITY </c> and the maximum priority permitted in the thread group. New threads have names accessible via Thread#getName of  <b>pool-N-thread-M</b>, where  <b>N</b> is the sequence number of this factory, and  <b>M</b> is the sequence number of the thread created by this factory. </para>        
				/// </summary>
				/// <returns>
				///  <para>a thread factory </para>
				/// </returns>
				/// <java-name>
				/// defaultThreadFactory
				/// </java-name>
				[Dot42.DexImport("defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IThreadFactory DefaultThreadFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IThreadFactory);
				}

				/// <summary>
				///  <para>Legacy security code; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// privilegedThreadFactory
				/// </java-name>
				[Dot42.DexImport("privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 9)]
				public static global::Java.Util.Concurrent.IThreadFactory PrivilegedThreadFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IThreadFactory);
				}

				/// <summary>
				///  <para>Returns a Callable object that, when called, runs the given task and returns the given result. This can be useful when applying methods requiring a  <c>Callable </c> to an otherwise resultless action. </para>        
				/// </summary>
				/// <returns>
				///  <para>a callable object </para>
				/// </returns>
				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Callable<TT;" +
    ">;")]
				public static global::Java.Util.Concurrent.ICallable<T> Callable<T>(global::Java.Lang.IRunnable task, T result) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<T>);
				}

				/// <summary>
				///  <para>Returns a Callable object that, when called, runs the given privileged action and returns its result. </para>        
				/// </summary>
				/// <returns>
				///  <para>a callable object </para>
				/// </returns>
				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable<Ljava/lang/Object;>;")]
				public static global::Java.Util.Concurrent.ICallable<object> Callable(global::Java.Lang.IRunnable action) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<object>);
				}

				/// <summary>
				///  <para>Returns a Callable object that, when called, runs the given privileged action and returns its result. </para>        
				/// </summary>
				/// <returns>
				///  <para>a callable object </para>
				/// </returns>
				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/security/PrivilegedAction<*>;)Ljava/util/concurrent/Callable<Ljava/lang/Ob" +
    "ject;>;")]
				public static global::Java.Util.Concurrent.ICallable<object> Callable(global::Java.Security.IPrivilegedAction<object> action) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<object>);
				}

				/// <summary>
				///  <para>Returns a Callable object that, when called, runs the given privileged action and returns its result. </para>        
				/// </summary>
				/// <returns>
				///  <para>a callable object </para>
				/// </returns>
				/// <java-name>
				/// callable
				/// </java-name>
				[Dot42.DexImport("callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/security/PrivilegedExceptionAction<*>;)Ljava/util/concurrent/Callable<Ljav" +
    "a/lang/Object;>;")]
				public static global::Java.Util.Concurrent.ICallable<object> Callable(global::Java.Security.IPrivilegedExceptionAction<object> action) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<object>);
				}

				/// <summary>
				///  <para>Legacy security code; do not use. </para>        
				/// </summary>
				/// <java-name>
				/// privilegedCallable
				/// </java-name>
				[Dot42.DexImport("privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Callable<TT;>;")]
				public static global::Java.Util.Concurrent.ICallable<T> PrivilegedCallable<T>(global::Java.Util.Concurrent.ICallable<T> callable) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.ICallable<T>);
				}

				/// <summary>
				///  <para>Legacy security code; do not use. </para>        
				/// </summary>
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

		/// <summary>
		///  <para>A cancellable asynchronous computation. This class provides a base implementation of Future, with methods to start and cancel a computation, query to see if the computation is complete, and retrieve the result of the computation. The result can only be retrieved when the computation has completed; the <c>get </c> methods will block if the computation has not yet completed. Once the computation has completed, the computation cannot be restarted or cancelled (unless the computation is invoked using runAndReset).</para> <para>A <c>FutureTask </c> can be used to wrap a Callable or Runnable object. Because <c>FutureTask </c> implements  <c>Runnable </c> , a <c>FutureTask </c> can be submitted to an Executor for execution.</para> <para>In addition to serving as a standalone class, this class provides  <c>protected </c> functionality that may be useful when creating customized task classes.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/FutureTask
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/FutureTask", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/RunnableFuture<TV;>" +
    ";")]
		public partial class FutureTask<V> : global::Java.Util.Concurrent.IRunnableFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a <c>FutureTask </c> that will, upon running, execute the given <c>Callable </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/concurrent/Callable;)V", AccessFlags = 1, Signature = "(Ljava/util/concurrent/Callable<TV;>;)V")]
				public FutureTask(global::Java.Util.Concurrent.ICallable<V> callable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>FutureTask </c> that will, upon running, execute the given <c>Runnable </c> , and arrange that <c>get </c> will return the given result on successful completion.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;TV;)V")]
				public FutureTask(global::Java.Lang.IRunnable runnable, V result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to cancel execution of this task. This attempt will fail if the task has already completed, has already been cancelled, or could not be cancelled for some other reason. If successful, and this task has not started when <c>cancel </c> is called, this task should never run. If the task has already started, then the <c>mayInterruptIfRunning </c> parameter determines whether the thread executing this task should be interrupted in an attempt to stop the task.</para> <para>After this method returns, subsequent calls to isDone will always return <c>true </c> . Subsequent calls to isCancelled will always return <c>true </c> if this method returned <c>true </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 1)]
				public virtual bool Cancel(bool mayInterruptIfRunning) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
				public virtual V Get() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TV;")]
				public virtual V Get(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				///  <para>Protected method invoked when this task transitions to state  <c>isDone </c> (whether normally or via cancellation). The default implementation does nothing. Subclasses may override this method to invoke completion callbacks or perform bookkeeping. Note that you can query status inside the implementation of this method to determine whether this task has been cancelled. </para>        
				/// </summary>
				/// <java-name>
				/// done
				/// </java-name>
				[Dot42.DexImport("done", "()V", AccessFlags = 4)]
				protected internal virtual void Done() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the result of this future to the given value unless this future has already been set or has been cancelled.</para> <para>This method is invoked internally by the run method upon successful completion of the computation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(TV;)V")]
				protected internal virtual void Set(V v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes this future to report an ExecutionException with the given throwable as its cause, unless this future has already been set or has been cancelled.</para> <para>This method is invoked internally by the run method upon failure of the computation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setException
				/// </java-name>
				[Dot42.DexImport("setException", "(Ljava/lang/Throwable;)V", AccessFlags = 4)]
				protected internal virtual void SetException(global::System.Exception t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets this Future to the result of its computation unless it has been cancelled. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Executes the computation without setting its result, and then resets this future to initial state, failing to do so if the computation encounters an exception or is cancelled. This is designed for use with tasks that intrinsically execute more than once.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if successfully run and reset </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns <c>true </c> if this task was cancelled before it completed normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this task was cancelled before it completed </para>
				/// </returns>
				/// <java-name>
				/// isCancelled
				/// </java-name>
				public virtual bool IsCancelled
				{
						[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this task completed.</para> <para>Completion may be due to normal termination, an exception, or cancellation  in all of these cases, this method will return  <c>true </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this task completed </para>
				/// </returns>
				/// <java-name>
				/// isDone
				/// </java-name>
				public virtual bool IsDone
				{
						[Dot42.DexImport("isDone", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A Deque that additionally supports blocking operations that wait for the deque to become non-empty when retrieving an element, and wait for space to become available in the deque when storing an element.</para> <para> <c>BlockingDeque </c> methods come in four forms, with different ways of handling operations that cannot be satisfied immediately, but may be satisfied at some point in the future: one throws an exception, the second returns a special value (either  <c>null </c> or <c>false </c> , depending on the operation), the third blocks the current thread indefinitely until the operation can succeed, and the fourth blocks for only a given maximum time limit before giving up. These methods are summarized in the following table:</para> <para> <table> <row> <entry> <para> <b>First Element (Head)</b>  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para> <b>Throws exception</b> </para></entry> <entry> <para> <b>Special value</b> </para></entry> <entry> <para> <b>Blocks</b> </para></entry> <entry> <para> <b>Times out</b>  </para></entry></row> <row> <entry> <para> <b>Insert</b> </para></entry> <entry> <para>addFirst(e) </para></entry> <entry> <para>offerFirst(e) </para></entry> <entry> <para>putFirst(e) </para></entry> <entry> <para>offerFirst(e, time, unit)  </para></entry></row> <row> <entry> <para> <b>Remove</b> </para></entry> <entry> <para>removeFirst() </para></entry> <entry> <para>pollFirst() </para></entry> <entry> <para>takeFirst() </para></entry> <entry> <para>pollFirst(time, unit)  </para></entry></row> <row> <entry> <para> <b>Examine</b> </para></entry> <entry> <para>getFirst() </para></entry> <entry> <para>peekFirst() </para></entry> <entry> <para> <b>not applicable</b> </para></entry> <entry> <para> <b>not applicable</b>  </para></entry></row> <row> <entry> <para> <b>Last Element (Tail)</b>  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para> <b>Throws exception</b> </para></entry> <entry> <para> <b>Special value</b> </para></entry> <entry> <para> <b>Blocks</b> </para></entry> <entry> <para> <b>Times out</b>  </para></entry></row> <row> <entry> <para> <b>Insert</b> </para></entry> <entry> <para>addLast(e) </para></entry> <entry> <para>offerLast(e) </para></entry> <entry> <para>putLast(e) </para></entry> <entry> <para>offerLast(e, time, unit)  </para></entry></row> <row> <entry> <para> <b>Remove</b> </para></entry> <entry> <para>removeLast() </para></entry> <entry> <para>pollLast() </para></entry> <entry> <para>takeLast() </para></entry> <entry> <para>pollLast(time, unit)  </para></entry></row> <row> <entry> <para> <b>Examine</b> </para></entry> <entry> <para>getLast() </para></entry> <entry> <para>peekLast() </para></entry> <entry> <para> <b>not applicable</b> </para></entry> <entry> <para> <b>not applicable</b>  </para></entry></row></table></para> <para>Like any BlockingQueue, a <c>BlockingDeque </c> is thread safe, does not permit null elements, and may (or may not) be capacity-constrained.</para> <para>A <c>BlockingDeque </c> implementation may be used directly as a FIFO  <c>BlockingQueue </c> . The methods inherited from the  <c>BlockingQueue </c> interface are precisely equivalent to  <c>BlockingDeque </c> methods as indicated in the following table:</para> <para> <table> <row> <entry> <para> <b> <c>BlockingQueue </c> Method</b> </para></entry> <entry> <para> <b>Equivalent <c>BlockingDeque </c> Method</b>  </para></entry></row> <row> <entry> <para> <b>Insert</b>  </para></entry></row> <row> <entry> <para>add(e) </para></entry> <entry> <para>addLast(e)  </para></entry></row> <row> <entry> <para>offer(e) </para></entry> <entry> <para>offerLast(e)  </para></entry></row> <row> <entry> <para>put(e) </para></entry> <entry> <para>putLast(e)  </para></entry></row> <row> <entry> <para>offer(e, time, unit) </para></entry> <entry> <para>offerLast(e, time, unit)  </para></entry></row> <row> <entry> <para> <b>Remove</b>  </para></entry></row> <row> <entry> <para>remove() </para></entry> <entry> <para>removeFirst()  </para></entry></row> <row> <entry> <para>poll() </para></entry> <entry> <para>pollFirst()  </para></entry></row> <row> <entry> <para>take() </para></entry> <entry> <para>takeFirst()  </para></entry></row> <row> <entry> <para>poll(time, unit) </para></entry> <entry> <para>pollFirst(time, unit)  </para></entry></row> <row> <entry> <para> <b>Examine</b>  </para></entry></row> <row> <entry> <para>element() </para></entry> <entry> <para>getFirst()  </para></entry></row> <row> <entry> <para>peek() </para></entry> <entry> <para>peekFirst()  </para></entry></row></table></para> <para>Memory consistency effects: As with other concurrent collections, actions in a thread prior to placing an object into a  <c>BlockingDeque </c>  actions subsequent to the access or removal of that element from the <c>BlockingDeque </c> in another thread.</para> <para>This interface is a member of the .</para> <para> <para>1.6 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/BlockingDeque
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/BlockingDeque", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/BlockingQueue<TE;>;" +
    "Ljava/util/Deque<TE;>;")]
		public partial interface IBlockingDeque<E> : global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.Util.IDeque<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Inserts the specified element at the front of this deque if it is possible to do so immediately without violating capacity restrictions, throwing an <c>IllegalStateException </c> if no space is currently available. When using a capacity-restricted deque, it is generally preferable to use offerFirst.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void AddFirst(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the end of this deque if it is possible to do so immediately without violating capacity restrictions, throwing an <c>IllegalStateException </c> if no space is currently available. When using a capacity-restricted deque, it is generally preferable to use offerLast.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void AddLast(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the front of this deque if it is possible to do so immediately without violating capacity restrictions, returning <c>true </c> upon success and <c>false </c> if no space is currently available. When using a capacity-restricted deque, this method is generally preferable to the addFirst method, which can fail to insert an element only by throwing an exception.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool OfferFirst(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the end of this deque if it is possible to do so immediately without violating capacity restrictions, returning <c>true </c> upon success and <c>false </c> if no space is currently available. When using a capacity-restricted deque, this method is generally preferable to the addLast method, which can fail to insert an element only by throwing an exception.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool OfferLast(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the front of this deque, waiting if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putFirst
				/// </java-name>
				[Dot42.DexImport("putFirst", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void PutFirst(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the end of this deque, waiting if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putLast
				/// </java-name>
				[Dot42.DexImport("putLast", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void PutLast(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the front of this deque, waiting up to the specified wait time if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if successful, or <c>false </c> if the specified waiting time elapses before space is available </para>
				/// </returns>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool OfferFirst(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element at the end of this deque, waiting up to the specified wait time if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if successful, or <c>false </c> if the specified waiting time elapses before space is available </para>
				/// </returns>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool OfferLast(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the first element of this deque, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// takeFirst
				/// </java-name>
				[Dot42.DexImport("takeFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E TakeFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the last element of this deque, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail of this deque </para>
				/// </returns>
				/// <java-name>
				/// takeLast
				/// </java-name>
				[Dot42.DexImport("takeLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E TakeLast() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the first element of this deque, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E PollFirst(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the last element of this deque, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail of this deque, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E PollLast(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes the first occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <c>e </c> such that  <c>o.equals(e) </c> (if such an element exists). Returns <c>true </c> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if an element was removed as a result of this call </para>
				/// </returns>
				/// <java-name>
				/// removeFirstOccurrence
				/// </java-name>
				[Dot42.DexImport("removeFirstOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool RemoveFirstOccurrence(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes the last occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the last element <c>e </c> such that  <c>o.equals(e) </c> (if such an element exists). Returns <c>true </c> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if an element was removed as a result of this call </para>
				/// </returns>
				/// <java-name>
				/// removeLastOccurrence
				/// </java-name>
				[Dot42.DexImport("removeLastOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool RemoveLastOccurrence(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into the queue represented by this deque (in other words, at the tail of this deque) if it is possible to do so immediately without violating capacity restrictions, returning  <c>true </c> upon success and throwing an  <c>IllegalStateException </c> if no space is currently available. When using a capacity-restricted deque, it is generally preferable to use offer.</para> <para>This method is equivalent to addLast.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into the queue represented by this deque (in other words, at the tail of this deque) if it is possible to do so immediately without violating capacity restrictions, returning  <c>true </c> upon success and <c>false </c> if no space is currently available. When using a capacity-restricted deque, this method is generally preferable to the add method, which can fail to insert an element only by throwing an exception.</para> <para>This method is equivalent to offerLast.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Offer(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into the queue represented by this deque (in other words, at the tail of this deque), waiting if necessary for space to become available.</para> <para>This method is equivalent to putLast.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Put(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into the queue represented by this deque (in other words, at the tail of this deque), waiting up to the specified wait time if necessary for space to become available.</para> <para>This method is equivalent to offerLast.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the element was added to this deque, else  <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque). This method differs from poll only in that it throws an exception if this deque is empty.</para> <para>This method is equivalent to removeFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Remove() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), or returns  <c>null </c> if this deque is empty.</para> <para>This method is equivalent to pollFirst().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Poll() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), waiting if necessary until an element becomes available.</para> <para>This method is equivalent to takeFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Take() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), waiting up to the specified wait time if necessary for an element to become available.</para> <para>This method is equivalent to pollFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of the queue represented by this deque (in other words, the first element of this deque). This method differs from peek only in that it throws an exception if this deque is empty.</para> <para>This method is equivalent to getFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Element() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of the queue represented by this deque (in other words, the first element of this deque), or returns <c>null </c> if this deque is empty.</para> <para>This method is equivalent to peekFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Peek() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes the first occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <c>e </c> such that  <c>o.equals(e) </c> (if such an element exists). Returns <c>true </c> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para> <para>This method is equivalent to removeFirstOccurrence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this deque changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns <c>true </c> if this deque contains the specified element. More formally, returns <c>true </c> if and only if this deque contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this deque contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of elements in this deque.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this deque </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an iterator over the elements in this deque in proper sequence. The elements will be returned in order from first (head) to last (tail).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this deque in proper sequence </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Pushes an element onto the stack represented by this deque. In other words, inserts the element at the front of this deque unless it would violate capacity restrictions.</para> <para>This method is equivalent to addFirst.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Push(E e) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A java.util.Queue that additionally supports operations that wait for the queue to become non-empty when retrieving an element, and wait for space to become available in the queue when storing an element.</para> <para> <c>BlockingQueue </c> methods come in four forms, with different ways of handling operations that cannot be satisfied immediately, but may be satisfied at some point in the future: one throws an exception, the second returns a special value (either  <c>null </c> or <c>false </c> , depending on the operation), the third blocks the current thread indefinitely until the operation can succeed, and the fourth blocks for only a given maximum time limit before giving up. These methods are summarized in the following table:</para> <para> <table> <row> <entry> <para></para></entry> <entry> <para> <b>Throws exception</b> </para></entry> <entry> <para> <b>Special value</b> </para></entry> <entry> <para> <b>Blocks</b> </para></entry> <entry> <para> <b>Times out</b>  </para></entry></row> <row> <entry> <para> <b>Insert</b> </para></entry> <entry> <para>add(e) </para></entry> <entry> <para>offer(e) </para></entry> <entry> <para>put(e) </para></entry> <entry> <para>offer(e, time, unit)  </para></entry></row> <row> <entry> <para> <b>Remove</b> </para></entry> <entry> <para>remove() </para></entry> <entry> <para>poll() </para></entry> <entry> <para>take() </para></entry> <entry> <para>poll(time, unit)  </para></entry></row> <row> <entry> <para> <b>Examine</b> </para></entry> <entry> <para>element() </para></entry> <entry> <para>peek() </para></entry> <entry> <para> <b>not applicable</b> </para></entry> <entry> <para> <b>not applicable</b>  </para></entry></row></table></para> <para>A <c>BlockingQueue </c> does not accept <c>null </c> elements. Implementations throw <c>NullPointerException </c> on attempts to <c>add </c> , <c>put </c> or <c>offer </c> a <c>null </c> . A  <c>null </c> is used as a sentinel value to indicate failure of  <c>poll </c> operations.</para> <para>A <c>BlockingQueue </c> may be capacity bounded. At any given time it may have a <c>remainingCapacity </c> beyond which no additional elements can be <c>put </c> without blocking. A <c>BlockingQueue </c> without any intrinsic capacity constraints always reports a remaining capacity of <c>Integer.MAX_VALUE </c> .</para> <para> <c>BlockingQueue </c> implementations are designed to be used primarily for producer-consumer queues, but additionally support the java.util.Collection interface. So, for example, it is possible to remove an arbitrary element from a queue using  <c>remove(x) </c> . However, such operations are in general  <b>not</b> performed very efficiently, and are intended for only occasional use, such as when a queued message is cancelled.</para> <para> <c>BlockingQueue </c> implementations are thread-safe. All queuing methods achieve their effects atomically using internal locks or other forms of concurrency control. However, the  <b>bulk</b> Collection operations <c>addAll </c> ,  <c>containsAll </c> , <c>retainAll </c> and <c>removeAll </c> are  <b>not</b> necessarily performed atomically unless specified otherwise in an implementation. So it is possible, for example, for  <c>addAll(c) </c> to fail (throwing an exception) after adding only some of the elements in <c>c </c> .</para> <para>A <c>BlockingQueue </c> does  <b>not</b> intrinsically support any kind of "close" or "shutdown" operation to indicate that no more items will be added. The needs and usage of such features tend to be implementation-dependent. For example, a common tactic is for producers to insert special  <b>end-of-stream</b> or  <b>poison</b> objects, that are interpreted accordingly when taken by consumers.</para> <para>Usage example, based on a typical producer-consumer scenario. Note that a <c>BlockingQueue </c> can safely be used with multiple producers and multiple consumers.  <pre>class Producer implements Runnable {
		/// 
		///   private final BlockingQueue queue;
		/// 
		///   Producer(BlockingQueue q) { queue = q; }
		/// 
		///   public void run() {
		/// 
		///     try {
		/// 
		///       while (true) { queue.put(produce()); }
		/// 
		///     } catch (InterruptedException ex) { ... handle ...}
		/// 
		///   }
		/// 
		///   Object produce() { ... }
		/// 
		/// }
		/// 
		/// 
		/// 
		/// class Consumer implements Runnable {
		/// 
		///   private final BlockingQueue queue;
		/// 
		///   Consumer(BlockingQueue q) { queue = q; }
		/// 
		///   public void run() {
		/// 
		///     try {
		/// 
		///       while (true) { consume(queue.take()); }
		/// 
		///     } catch (InterruptedException ex) { ... handle ...}
		/// 
		///   }
		/// 
		///   void consume(Object x) { ... }
		/// 
		/// }
		/// 
		/// 
		/// 
		/// class Setup {
		/// 
		///   void main() {
		/// 
		///     BlockingQueue q = new SomeQueueImplementation();
		/// 
		///     Producer p = new Producer(q);
		/// 
		///     Consumer c1 = new Consumer(q);
		/// 
		///     Consumer c2 = new Consumer(q);
		/// 
		///     new Thread(p).start();
		/// 
		///     new Thread(c1).start();
		/// 
		///     new Thread(c2).start();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Memory consistency effects: As with other concurrent collections, actions in a thread prior to placing an object into a  <c>BlockingQueue </c>  actions subsequent to the access or removal of that element from the <c>BlockingQueue </c> in another thread.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/BlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/BlockingQueue", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Queue<TE;>;")]
		public partial interface IBlockingQueue<E> : global::Java.Util.IQueue<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Inserts the specified element into this queue if it is possible to do so immediately without violating capacity restrictions, returning  <c>true </c> upon success and throwing an  <c>IllegalStateException </c> if no space is currently available. When using a capacity-restricted queue, it is generally preferable to use offer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Collection#add) </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into this queue if it is possible to do so immediately without violating capacity restrictions, returning  <c>true </c> upon success and <c>false </c> if no space is currently available. When using a capacity-restricted queue, this method is generally preferable to add, which can fail to insert an element only by throwing an exception.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the element was added to this queue, else  <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Offer(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into this queue, waiting if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Put(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inserts the specified element into this queue, waiting up to the specified wait time if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if successful, or <c>false </c> if the specified waiting time elapses before space is available </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Take() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of additional elements that this queue can ideally (in the absence of memory or resource constraints) accept without blocking, or <c>Integer.MAX_VALUE </c> if there is no intrinsic limit.</para> <para>Note that you  <b>cannot</b> always tell if an attempt to insert an element will succeed by inspecting <c>remainingCapacity </c> because it may be the case that another thread is about to insert or remove an element.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the remaining capacity </para>
				/// </returns>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1025)]
				int RemainingCapacity() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes a single instance of the specified element from this queue, if it is present. More formally, removes an element <c>e </c> such that <c>o.equals(e) </c> , if this queue contains one or more such elements. Returns <c>true </c> if this queue contained the specified element (or equivalently, if this queue changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns <c>true </c> if this queue contains the specified element. More formally, returns <c>true </c> if and only if this queue contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes all available elements from this queue and adds them to the given collection. This operation may be more efficient than repeatedly polling this queue. A failure encountered while attempting to add elements to collection <c>c </c> may result in elements being in neither, either or both collections when the associated exception is thrown. Attempts to drain a queue to itself result in  <c>IllegalArgumentException </c> . Further, the behavior of this operation is undefined if the specified collection is modified while the operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements transferred </para>
				/// </returns>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1025, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes at most the given number of available elements from this queue and adds them to the given collection. A failure encountered while attempting to add elements to collection <c>c </c> may result in elements being in neither, either or both collections when the associated exception is thrown. Attempts to drain a queue to itself result in  <c>IllegalArgumentException </c> . Further, the behavior of this operation is undefined if the specified collection is modified while the operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements transferred </para>
				/// </returns>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1025, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A task that returns a result and may throw an exception. Implementors define a single method with no arguments called  <c>call </c> .</para> <para>The <c>Callable </c> interface is similar to java.lang.Runnable, in that both are designed for classes whose instances are potentially executed by another thread. A  <c>Runnable </c> , however, does not return a result and cannot throw a checked exception.</para> <para>The Executors class contains utility methods to convert from other common forms to <c>Callable </c> classes.</para> <para> <para>Executor </para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Callable
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Callable", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface ICallable<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Computes a result, or throws an exception if unable to do so.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>computed result </para>
				/// </returns>
				/// <java-name>
				/// call
				/// </java-name>
				[Dot42.DexImport("call", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V Call() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A service that decouples the production of new asynchronous tasks from the consumption of the results of completed tasks. Producers  <c>submit </c> tasks for execution. Consumers <c>take </c> completed tasks and process their results in the order they complete. A <c>CompletionService </c> can for example be used to manage asynchronous I/O, in which tasks that perform reads are submitted in one part of a program or system, and then acted upon in a different part of the program when the reads complete, possibly in a different order than they were requested.</para> <para>Typically, a <c>CompletionService </c> relies on a separate Executor to actually execute the tasks, in which case the  <c>CompletionService </c> only manages an internal completion queue. The ExecutorCompletionService class provides an implementation of this approach.</para> <para>Memory consistency effects: Actions in a thread prior to submitting a task to a <c>CompletionService </c>  actions taken by that task, which in turn  <b>happen-before</b> actions following a successful return from the corresponding <c>take() </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/CompletionService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/CompletionService", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface ICompletionService<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Submits a value-returning task for execution and returns a Future representing the pending results of the task. Upon completion, this task may be taken or polled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(Ljava/util/concurrent/Callable<TV;>;)Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Util.Concurrent.ICallable<V> task) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Submits a Runnable task for execution and returns a Future representing that task. Upon completion, this task may be taken or polled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task, and whose <c>get() </c> method will return the given result value upon completion </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;TV;)Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Submit(global::Java.Lang.IRunnable task, V result) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the Future representing the next completed task, waiting if none are yet present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Future representing the next completed task </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Take() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the Future representing the next completed task, or <c>null </c> if none are present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Future representing the next completed task, or  <c>null </c> if none are present </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "()Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Poll() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves and removes the Future representing the next completed task, waiting if necessary up to the specified wait time if none are yet present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Future representing the next completed task or  <c>null </c> if the specified waiting time elapses before one is present </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future<TV;>;")]
				global::Java.Util.Concurrent.IFuture<V> Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A java.util.Map providing additional atomic  <c>putIfAbsent </c> , <c>remove </c> , and <c>replace </c> methods.</para> <para>Memory consistency effects: As with other concurrent collections, actions in a thread prior to placing an object into a  <c>ConcurrentMap </c> as a key or value  actions subsequent to the access or removal of that object from the <c>ConcurrentMap </c> in another thread.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ConcurrentMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;" +
    ">;")]
		public partial interface IConcurrentMap<K, V> : global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If the specified key is not already associated with a value, associate it with the given value. This is equivalent to  <pre>if (!map.containsKey(key))
				/// 
				///   return map.put(key, value);
				/// 
				/// else
				/// 
				///   return map.get(key); 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key. (A <c>null </c> return can also indicate that the map previously associated <c>null </c> with the key, if the implementation supports null values.) </para>
				/// </returns>
				/// <java-name>
				/// putIfAbsent
				/// </java-name>
				[Dot42.DexImport("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				V PutIfAbsent(K key, V value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes the entry for a key only if currently mapped to a given value. This is equivalent to  <pre>if (map.containsKey(key) &amp;&amp; map.get(key).equals(value)) {
				/// 
				///   map.remove(key);
				/// 
				///   return true;
				/// 
				/// } else
				/// 
				///   return false; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was removed </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object key, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Replaces the entry for a key only if currently mapped to a given value. This is equivalent to  <pre>if (map.containsKey(key) &amp;&amp; map.get(key).equals(oldValue)) {
				/// 
				///   map.put(key, newValue);
				/// 
				///   return true;
				/// 
				/// } else
				/// 
				///   return false; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was replaced </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TK;TV;TV;)Z")]
				bool Replace(K key, V oldValue, V newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Replaces the entry for a key only if currently mapped to some value. This is equivalent to  <pre>if (map.containsKey(key)) {
				/// 
				///   return map.put(key, value);
				/// 
				/// } else
				/// 
				///   return null; 
				/// 
				///  </pre></para> <para>except that the action is performed atomically.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous value associated with the specified key, or  <c>null </c> if there was no mapping for the key. (A <c>null </c> return can also indicate that the map previously associated <c>null </c> with the key, if the implementation supports null values.) </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				V Replace(K key, V value) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A ConcurrentMap supporting NavigableMap operations, and recursively so for its navigable sub-maps.</para> <para> <para>Doug Lea </para> <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ConcurrentNavigableMap
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ConcurrentNavigableMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent" +
    "/ConcurrentMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
		public partial interface IConcurrentNavigableMap<K, V> : global::Java.Util.Concurrent.IConcurrentMap<K, V>, global::Java.Util.INavigableMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigable" +
    "Map;", AccessFlags = 1025, Signature = "(TK;ZTK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K toKey, bool inclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K fromKey, bool inclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMa" +
    "p;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> SubMap(K fromKey, K toKey) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> HeadMap(K toKey) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> TailMap(K fromKey) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a reverse order view of the mappings contained in this map. The descending map is backed by this map, so changes to the map are reflected in the descending map, and vice-versa.</para> <para>The returned map has an ordering equivalent to Collections.reverseOrder <c>(comparator()) </c> . The expression <c>m.descendingMap().descendingMap() </c> returns a view of <c>m </c> essentially equivalent to <c>m </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reverse order view of this map </para>
				/// </returns>
				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;", AccessFlags = 1025, Signature = "()Ljava/util/concurrent/ConcurrentNavigableMap<TK;TV;>;")]
				global::Java.Util.Concurrent.IConcurrentNavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a NavigableSet view of the keys contained in this map. The set's iterator returns the keys in ascending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> , and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// navigableKeySet
				/// </java-name>
				[Dot42.DexImport("navigableKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> NavigableKeySet() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a NavigableSet view of the keys contained in this map. The set's iterator returns the keys in ascending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> , and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para>This method is equivalent to method <c>navigableKeySet </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> KeySet() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a reverse order NavigableSet view of the keys contained in this map. The set's iterator returns the keys in descending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. The set supports element removal, which removes the corresponding mapping from the map, via the <c>Iterator.remove </c> , <c>Set.remove </c> ,  <c>removeAll </c> , <c>retainAll </c> , and <c>clear </c> operations. It does not support the <c>add </c> or <c>addAll </c> operations.</para> <para>The view's <c>iterator </c> is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reverse order navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A mix-in style interface for marking objects that should be acted upon after a given delay.</para> <para>An implementation of this interface must define a  <c>compareTo </c> method that provides an ordering consistent with its <c>getDelay </c> method.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Delayed
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Delayed", AccessFlags = 1537, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/util/concurrent/Delayed;>;")]
		public partial interface IDelayed : global::System.IComparable<global::Java.Util.Concurrent.IDelayed>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the remaining delay associated with this object, in the given time unit.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the remaining delay; zero or negative values indicate that the delay has already elapsed </para>
				/// </returns>
				/// <java-name>
				/// getDelay
				/// </java-name>
				[Dot42.DexImport("getDelay", "(Ljava/util/concurrent/TimeUnit;)J", AccessFlags = 1025)]
				long GetDelay(global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An object that executes submitted Runnable tasks. This interface provides a way of decoupling task submission from the mechanics of how each task will be run, including details of thread use, scheduling, etc. An <c>Executor </c> is normally used instead of explicitly creating threads. For example, rather than invoking <c>new Thread(new(RunnableTask())).start() </c> for each of a set of tasks, you might use:</para> <para> <pre>
		/// Executor executor =  <b>anExecutor</b>;
		/// executor.execute(new RunnableTask1());
		/// executor.execute(new RunnableTask2());
		/// ...
		/// </pre></para> <para>However, the <c>Executor </c> interface does not strictly require that execution be asynchronous. In the simplest case, an executor can run the submitted task immediately in the caller's thread:</para> <para> <pre>class DirectExecutor implements Executor {
		/// 
		///   public void execute(Runnable r) {
		/// 
		///     r.run();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>More typically, tasks are executed in some thread other than the caller's thread. The executor below spawns a new thread for each task.</para> <para> <pre>class ThreadPerTaskExecutor implements Executor {
		/// 
		///   public void execute(Runnable r) {
		/// 
		///     new Thread(r).start();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Many <c>Executor </c> implementations impose some sort of limitation on how and when tasks are scheduled. The executor below serializes the submission of tasks to a second executor, illustrating a composite executor.</para> <para> <pre>class SerialExecutor implements Executor {
		/// 
		///   final Queue&lt;Runnable&gt; tasks = new ArrayDeque&lt;Runnable&gt;();
		/// 
		///   final Executor executor;
		/// 
		///   Runnable active;
		/// 
		/// 
		/// 
		///   SerialExecutor(Executor executor) {
		/// 
		///     this.executor = executor;
		/// 
		///   }
		/// 
		/// 
		/// 
		///   public synchronized void execute(final Runnable r) {
		/// 
		///     tasks.offer(new Runnable() {
		/// 
		///       public void run() {
		/// 
		///         try {
		/// 
		///           r.run();
		/// 
		///         } finally {
		/// 
		///           scheduleNext();
		/// 
		///         }
		/// 
		///       }
		/// 
		///     });
		/// 
		///     if (active == null) {
		/// 
		///       scheduleNext();
		/// 
		///     }
		/// 
		///   }
		/// 
		/// 
		/// 
		///   protected synchronized void scheduleNext() {
		/// 
		///     if ((active = tasks.poll()) != null) {
		/// 
		///       executor.execute(active);
		/// 
		///     }
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>The <c>Executor </c> implementations provided in this package implement ExecutorService, which is a more extensive interface. The ThreadPoolExecutor class provides an extensible thread pool implementation. The Executors class provides convenient factory methods for these Executors.</para> <para>Memory consistency effects: Actions in a thread prior to submitting a <c>Runnable </c> object to an <c>Executor </c>  its execution begins, perhaps in another thread.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Executor
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Executor", AccessFlags = 1537)]
		public partial interface IExecutor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Executes the given command at some time in the future. The command may execute in a new thread, in a pooled thread, or in the calling thread, at the discretion of the <c>Executor </c> implementation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1025)]
				void Execute(global::Java.Lang.IRunnable command) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An Executor that provides methods to manage termination and methods that can produce a Future for tracking progress of one or more asynchronous tasks.</para> <para>An <c>ExecutorService </c> can be shut down, which will cause it to reject new tasks. Two different methods are provided for shutting down an <c>ExecutorService </c> . The shutdown method will allow previously submitted tasks to execute before terminating, while the shutdownNow method prevents waiting tasks from starting and attempts to stop currently executing tasks. Upon termination, an executor has no tasks actively executing, no tasks awaiting execution, and no new tasks can be submitted. An unused <c>ExecutorService </c> should be shut down to allow reclamation of its resources.</para> <para>Method <c>submit </c> extends base method Executor#execute by creating and returning a Future that can be used to cancel execution and/or wait for completion. Methods <c>invokeAny </c> and <c>invokeAll </c> perform the most commonly useful forms of bulk execution, executing a collection of tasks and then waiting for at least one, or all, to complete. (Class ExecutorCompletionService can be used to write customized variants of these methods.)</para> <para>The Executors class provides factory methods for the executor services provided in this package.</para> <para> <h3>Usage Examples</h3></para> <para>Here is a sketch of a network service in which threads in a thread pool service incoming requests. It uses the preconfigured Executors#newFixedThreadPool factory method:</para> <para> <pre>class NetworkService implements Runnable {
		/// 
		///   private final ServerSocket serverSocket;
		/// 
		///   private final ExecutorService pool;
		/// 
		/// 
		/// 
		///   public NetworkService(int port, int poolSize)
		/// 
		///       throws IOException {
		/// 
		///     serverSocket = new ServerSocket(port);
		/// 
		///     pool = Executors.newFixedThreadPool(poolSize);
		/// 
		///   }
		/// 
		/// 
		/// 
		///   public void run() { // run the service
		/// 
		///     try {
		/// 
		///       for (;;) {
		/// 
		///         pool.execute(new Handler(serverSocket.accept()));
		/// 
		///       }
		/// 
		///     } catch (IOException ex) {
		/// 
		///       pool.shutdown();
		/// 
		///     }
		/// 
		///   }
		/// 
		/// }
		/// 
		/// 
		/// 
		/// class Handler implements Runnable {
		/// 
		///   private final Socket socket;
		/// 
		///   Handler(Socket socket) { this.socket = socket; }
		/// 
		///   public void run() {
		/// 
		///     // read and service request on socket
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>The following method shuts down an <c>ExecutorService </c> in two phases, first by calling <c>shutdown </c> to reject incoming tasks, and then calling <c>shutdownNow </c> , if necessary, to cancel any lingering tasks:</para> <para> <pre>void shutdownAndAwaitTermination(ExecutorService pool) {
		/// 
		///   pool.shutdown(); // Disable new tasks from being submitted
		/// 
		///   try {
		/// 
		///     // Wait a while for existing tasks to terminate
		/// 
		///     if (!pool.awaitTermination(60, TimeUnit.SECONDS)) {
		/// 
		///       pool.shutdownNow(); // Cancel currently executing tasks
		/// 
		///       // Wait a while for tasks to respond to being cancelled
		/// 
		///       if (!pool.awaitTermination(60, TimeUnit.SECONDS))
		/// 
		///           System.err.println("Pool did not terminate");
		/// 
		///     }
		/// 
		///   } catch (InterruptedException ie) {
		/// 
		///     // (Re-)Cancel if current thread also interrupted
		/// 
		///     pool.shutdownNow();
		/// 
		///     // Preserve interrupt status
		/// 
		///     Thread.currentThread().interrupt();
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Memory consistency effects: Actions in a thread prior to the submission of a <c>Runnable </c> or <c>Callable </c> task to an  <c>ExecutorService </c>  any actions taken by that task, which in turn  <b>happen-before</b> the result is retrieved via <c>Future.get() </c> .</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ExecutorService
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ExecutorService", AccessFlags = 1537)]
		public partial interface IExecutorService : global::Java.Util.Concurrent.IExecutor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Initiates an orderly shutdown in which previously submitted tasks are executed, but no new tasks will be accepted. Invocation has no additional effect if already shut down.</para> <para>This method does not wait for previously submitted tasks to complete execution. Use awaitTermination to do that. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1025)]
				void Shutdown() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Attempts to stop all actively executing tasks, halts the processing of waiting tasks, and returns a list of the tasks that were awaiting execution.</para> <para>This method does not wait for actively executing tasks to terminate. Use awaitTermination to do that.</para> <para>There are no guarantees beyond best-effort attempts to stop processing actively executing tasks. For example, typical implementations will cancel via Thread#interrupt, so any task that fails to respond to interrupts may never terminate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>list of tasks that never commenced execution </para>
				/// </returns>
				/// <java-name>
				/// shutdownNow
				/// </java-name>
				[Dot42.DexImport("shutdownNow", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Blocks until all tasks have completed execution after a shutdown request, or the timeout occurs, or the current thread is interrupted, whichever happens first.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this executor terminated and  <c>false </c> if the timeout elapsed before termination </para>
				/// </returns>
				/// <java-name>
				/// awaitTermination
				/// </java-name>
				[Dot42.DexImport("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Submits a value-returning task for execution and returns a Future representing the pending results of the task. The Future's <c>get </c> method will return the task's result upon successful completion.</para> <para>If you would like to immediately block waiting for a task, you can use constructions of the form  <c>result = exec.submit(aCallable).get(); </c></para> <para>Note: The Executors class includes a set of methods that can convert some other common closure-like objects, for example, java.security.PrivilegedAction to Callable form so they can be submitted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Future<TT;>;")]
				global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Util.Concurrent.ICallable<T> task) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Submits a Runnable task for execution and returns a Future representing that task. The Future's <c>get </c> method will return the given result upon successful completion.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;" +
    "")]
				global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Lang.IRunnable task, T result) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Submits a value-returning task for execution and returns a Future representing the pending results of the task. The Future's <c>get </c> method will return the task's result upon successful completion.</para> <para>If you would like to immediately block waiting for a task, you can use constructions of the form  <c>result = exec.submit(aCallable).get(); </c></para> <para>Note: The Executors class includes a set of methods that can convert some other common closure-like objects, for example, java.security.PrivilegedAction to Callable form so they can be submitted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Future representing pending completion of the task </para>
				/// </returns>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
				global::Java.Util.Concurrent.IFuture<object> Submit(global::Java.Lang.IRunnable task) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the given tasks, returning a list of Futures holding their status and results when all complete. Future#isDone is <c>true </c> for each element of the returned list. Note that a  <b>completed</b> task could have terminated either normally or by throwing an exception. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of Futures representing the tasks, in the same sequential order as produced by the iterator for the given task list, each of which has completed </para>
				/// </returns>
				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
				global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the given tasks, returning a list of Futures holding their status and results when all complete or the timeout expires, whichever happens first. Future#isDone is <c>true </c> for each element of the returned list. Upon return, tasks that have not completed are cancelled. Note that a  <b>completed</b> task could have terminated either normally or by throwing an exception. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of Futures representing the tasks, in the same sequential order as produced by the iterator for the given task list. If the operation did not time out, each task will have completed. If it did time out, some of these tasks will not have completed. </para>
				/// </returns>
				/// <java-name>
				/// invokeAll
				/// </java-name>
				[Dot42.DexImport("invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future" +
    "<TT;>;>;")]
				global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the given tasks, returning the result of one that has completed successfully (i.e., without throwing an exception), if any do. Upon normal or exceptional return, tasks that have not completed are cancelled. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result returned by one of the tasks </para>
				/// </returns>
				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)TT;")]
				T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the given tasks, returning the result of one that has completed successfully (i.e., without throwing an exception), if any do before the given timeout elapses. Upon normal or exceptional return, tasks that have not completed are cancelled. The results of this method are undefined if the given collection is modified while this operation is in progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result returned by one of the tasks </para>
				/// </returns>
				/// <java-name>
				/// invokeAny
				/// </java-name>
				[Dot42.DexImport("invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)TT;")]
				T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns <c>true </c> if this executor has been shut down.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this executor has been shut down </para>
				/// </returns>
				/// <java-name>
				/// isShutdown
				/// </java-name>
				bool IsShutdown
				{
						[Dot42.DexImport("isShutdown", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns <c>true </c> if all tasks have completed following shut down. Note that <c>isTerminated </c> is never <c>true </c> unless either <c>shutdown </c> or <c>shutdownNow </c> was called first.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all tasks have completed following shut down </para>
				/// </returns>
				/// <java-name>
				/// isTerminated
				/// </java-name>
				bool IsTerminated
				{
						[Dot42.DexImport("isTerminated", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A <c>Future </c> represents the result of an asynchronous computation. Methods are provided to check if the computation is complete, to wait for its completion, and to retrieve the result of the computation. The result can only be retrieved using method  <c>get </c> when the computation has completed, blocking if necessary until it is ready. Cancellation is performed by the  <c>cancel </c> method. Additional methods are provided to determine if the task completed normally or was cancelled. Once a computation has completed, the computation cannot be cancelled. If you would like to use a <c>Future </c> for the sake of cancellability but not provide a usable result, you can declare types of the form <c>Future&lt;?&gt; </c> and return <c>null </c> as a result of the underlying task.</para> <para> <b>Sample Usage</b> (Note that the following classes are all made-up.) </para> <para> <pre>interface ArchiveSearcher { String search(String target); }
		/// 
		/// class App {
		/// 
		///   ExecutorService executor = ...
		/// 
		///   ArchiveSearcher searcher = ...
		/// 
		///   void showSearch(final String target)
		/// 
		///       throws InterruptedException {
		/// 
		///     Future&lt;String&gt; future
		/// 
		///       = executor.submit(new Callable&lt;String&gt;() {
		/// 
		///         public String call() {
		/// 
		///             return searcher.search(target);
		/// 
		///         }});
		/// 
		///     displayOtherThings(); // do other things while searching
		/// 
		///     try {
		/// 
		///       displayText(future.get()); // use future
		/// 
		///     } catch (ExecutionException ex) { cleanup(); return; }
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>The FutureTask class is an implementation of <c>Future </c> that implements <c>Runnable </c> , and so may be executed by an <c>Executor </c> . For example, the above construction with <c>submit </c> could be replaced by:  <pre>FutureTask&lt;String&gt; future =
		/// 
		///   new FutureTask&lt;String&gt;(new Callable&lt;String&gt;() {
		/// 
		///     public String call() {
		/// 
		///       return searcher.search(target);
		/// 
		///   }});
		/// 
		/// executor.execute(future); 
		/// 
		///  </pre></para> <para>Memory consistency effects: Actions taken by the asynchronous computation  actions following the corresponding <c>Future.get() </c> in another thread.</para> <para> <para>FutureTask </para> <para>Executor </para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Future
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Future", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Attempts to cancel execution of this task. This attempt will fail if the task has already completed, has already been cancelled, or could not be cancelled for some other reason. If successful, and this task has not started when <c>cancel </c> is called, this task should never run. If the task has already started, then the <c>mayInterruptIfRunning </c> parameter determines whether the thread executing this task should be interrupted in an attempt to stop the task.</para> <para>After this method returns, subsequent calls to isDone will always return <c>true </c> . Subsequent calls to isCancelled will always return <c>true </c> if this method returned <c>true </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 1025)]
				bool Cancel(bool mayInterruptIfRunning) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Waits if necessary for the computation to complete, and then retrieves its result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed result </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V Get() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Waits if necessary for at most the given time for the computation to complete, and then retrieves its result, if available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed result </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TV;")]
				V Get(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns <c>true </c> if this task was cancelled before it completed normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this task was cancelled before it completed </para>
				/// </returns>
				/// <java-name>
				/// isCancelled
				/// </java-name>
				bool IsCancelled
				{
						[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this task completed.</para> <para>Completion may be due to normal termination, an exception, or cancellation  in all of these cases, this method will return  <c>true </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this task completed </para>
				/// </returns>
				/// <java-name>
				/// isDone
				/// </java-name>
				bool IsDone
				{
						[Dot42.DexImport("isDone", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A handler for tasks that cannot be executed by a ThreadPoolExecutor.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/RejectedExecutionHandler
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RejectedExecutionHandler", AccessFlags = 1537)]
		public partial interface IRejectedExecutionHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Method that may be invoked by a ThreadPoolExecutor when execute cannot accept a task. This may occur when no more threads or queue slots are available because their bounds would be exceeded, or upon shutdown of the Executor.</para> <para>In the absence of other alternatives, the method may throw an unchecked RejectedExecutionException, which will be propagated to the caller of <c>execute </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rejectedExecution
				/// </java-name>
				[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1025)]
				void RejectedExecution(global::Java.Lang.IRunnable r, global::Java.Util.Concurrent.ThreadPoolExecutor executor) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A Future that is Runnable. Successful execution of the <c>run </c> method causes completion of the <c>Future </c> and allows access to its results.  <para>FutureTask </para> <para>Executor </para> <para>1.6 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/RunnableFuture
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RunnableFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Runnable;Ljava/util/concurrent" +
    "/Future<TV;>;")]
		public partial interface IRunnableFuture<V> : global::Java.Lang.IRunnable, global::Java.Util.Concurrent.IFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Sets this Future to the result of its computation unless it has been cancelled. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1025)]
				void Run() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A ScheduledFuture that is Runnable. Successful execution of the <c>run </c> method causes completion of the  <c>Future </c> and allows access to its results.  <para>FutureTask </para> <para>Executor </para> <para>1.6 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/RunnableScheduledFuture
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RunnableScheduledFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/RunnableFuture<TV;>" +
    ";Ljava/util/concurrent/ScheduledFuture<TV;>;")]
		public partial interface IRunnableScheduledFuture<V> : global::Java.Util.Concurrent.IRunnableFuture<V>, global::Java.Util.Concurrent.IScheduledFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns true if this is a periodic task. A periodic task may re-run according to some schedule. A non-periodic task can be run only once.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this task is periodic </para>
				/// </returns>
				/// <java-name>
				/// isPeriodic
				/// </java-name>
				bool IsPeriodic
				{
						[Dot42.DexImport("isPeriodic", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An ExecutorService that can schedule commands to run after a given delay, or to execute periodically.</para> <para>The <c>schedule </c> methods create tasks with various delays and return a task object that can be used to cancel or check execution. The <c>scheduleAtFixedRate </c> and  <c>scheduleWithFixedDelay </c> methods create and execute tasks that run periodically until cancelled.</para> <para>Commands submitted using the Executor#execute and ExecutorService <c>submit </c> methods are scheduled with a requested delay of zero. Zero and negative delays (but not periods) are also allowed in <c>schedule </c> methods, and are treated as requests for immediate execution.</para> <para>All <c>schedule </c> methods accept  <b>relative</b> delays and periods as arguments, not absolute times or dates. It is a simple matter to transform an absolute time represented as a java.util.Date to the required form. For example, to schedule at a certain future <c>date </c> , you can use: <c> schedule(task,date.getTime() - System.currentTimeMillis(),TimeUnit.MILLISECONDS) </c> . Beware however that expiration of a relative delay need not coincide with the current <c>Date </c> at which the task is enabled due to network time synchronization protocols, clock drift, or other factors.</para> <para>The Executors class provides convenient factory methods for the ScheduledExecutorService implementations provided in this package.</para> <para> <h3>Usage Example</h3></para> <para>Here is a class with a method that sets up a ScheduledExecutorService to beep every ten seconds for an hour:</para> <para> <pre>import static java.util.concurrent.TimeUnit.*;
		/// 
		/// class BeeperControl {
		/// 
		///   private final ScheduledExecutorService scheduler =
		/// 
		///     Executors.newScheduledThreadPool(1);
		/// 
		/// 
		/// 
		///   public void beepForAnHour() {
		/// 
		///     final Runnable beeper = new Runnable() {
		/// 
		///       public void run() { System.out.println("beep"); }
		/// 
		///     };
		/// 
		///     final ScheduledFuture&lt;?&gt; beeperHandle =
		/// 
		///       scheduler.scheduleAtFixedRate(beeper, 10, 10, SECONDS);
		/// 
		///     scheduler.schedule(new Runnable() {
		/// 
		///       public void run() { beeperHandle.cancel(true); }
		/// 
		///     }, 60 * 60, SECONDS);
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Creates and executes a periodic action that becomes enabled first after the given initial delay, and subsequently with the given period; that is executions will commence after  <c>initialDelay </c> then <c>initialDelay+period </c> , then  <c>initialDelay + 2 * period </c> , and so on. If any execution of the task encounters an exception, subsequent executions are suppressed. Otherwise, the task will only terminate via cancellation or termination of the executor. If any execution of this task takes longer than its period, then subsequent executions may start late, but will not concurrently execute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ScheduledFuture representing pending completion of the task, and whose <c>get() </c> method will throw an exception upon cancellation </para>
				/// </returns>
				/// <java-name>
				/// scheduleAtFixedRate
				/// </java-name>
				[Dot42.DexImport("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleAtFixedRate(global::Java.Lang.IRunnable command, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates and executes a periodic action that becomes enabled first after the given initial delay, and subsequently with the given delay between the termination of one execution and the commencement of the next. If any execution of the task encounters an exception, subsequent executions are suppressed. Otherwise, the task will only terminate via cancellation or termination of the executor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ScheduledFuture representing pending completion of the task, and whose <c>get() </c> method will throw an exception upon cancellation </para>
				/// </returns>
				/// <java-name>
				/// scheduleWithFixedDelay
				/// </java-name>
				[Dot42.DexImport("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1025, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleWithFixedDelay(global::Java.Lang.IRunnable command, long initialDelay, long delay, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A delayed result-bearing action that can be cancelled. Usually a scheduled future is the result of scheduling a task with a ScheduledExecutorService.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ScheduledFuture
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ScheduledFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/Delayed;Ljava/util/" +
    "concurrent/Future<TV;>;")]
		public partial interface IScheduledFuture<V> : global::Java.Util.Concurrent.IDelayed, global::Java.Util.Concurrent.IFuture<V>
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>An object that creates new threads on demand. Using thread factories removes hardwiring of calls to new Thread, enabling applications to use special thread subclasses, priorities, etc.</para> <para>The simplest implementation of this interface is just:  <pre>class SimpleThreadFactory implements ThreadFactory {
		/// 
		///   public Thread newThread(Runnable r) {
		/// 
		///     return new Thread(r);
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>The Executors#defaultThreadFactory method provides a more useful simple implementation, that sets the created thread context to known values before returning it.  <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ThreadFactory
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ThreadFactory", AccessFlags = 1537)]
		public partial interface IThreadFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>Thread </c> . Implementations may also initialize priority, name, daemon status, <c>ThreadGroup </c> , etc.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>constructed thread, or <c>null </c> if the request to create a thread is rejected </para>
				/// </returns>
				/// <java-name>
				/// newThread
				/// </java-name>
				[Dot42.DexImport("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", AccessFlags = 1025)]
				global::System.Threading.Thread NewThread(global::Java.Lang.IRunnable r) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An optionally-bounded  BlockingDeque blocking deque} based on linked nodes.</para> <para>The optional capacity bound constructor argument serves as a way to prevent excessive expansion. The capacity, if unspecified, is equal to Integer#MAX_VALUE. Linked nodes are dynamically created upon each insertion unless this would bring the deque above capacity.</para> <para>Most operations run in constant time (ignoring time spent blocking). Exceptions include remove, removeFirstOccurrence, removeLastOccurrence, contains, iterator.remove(), and the bulk operations, all of which run in linear time.</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Collection and Iterator interfaces.</para> <para> <para>1.6 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/LinkedBlockingDeque
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/LinkedBlockingDeque", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gDeque<TE;>;Ljava/io/Serializable;")]
		public partial class LinkedBlockingDeque<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingDeque<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a <c>LinkedBlockingDeque </c> with a capacity of Integer#MAX_VALUE. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedBlockingDeque() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>LinkedBlockingDeque </c> with the given (fixed) capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedBlockingDeque(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>LinkedBlockingDeque </c> with the given (fixed) capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedBlockingDeque(global::Java.Util.ICollection<E> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddFirst(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddLast(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferFirst(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferLast(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// putFirst
				/// </java-name>
				[Dot42.DexImport("putFirst", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void PutFirst(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// putLast
				/// </java-name>
				[Dot42.DexImport("putLast", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void PutLast(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool OfferFirst(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool OfferLast(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// removeFirst
				/// </java-name>
				[Dot42.DexImport("removeFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E RemoveFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// removeLast
				/// </java-name>
				[Dot42.DexImport("removeLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E RemoveLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the first element of this deque, or returns  <code>null</code> if this deque is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or  <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the last element of this deque, or returns  <code>null</code> if this deque is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail of this deque, or  <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PollLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the first element of this deque, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// takeFirst
				/// </java-name>
				[Dot42.DexImport("takeFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E TakeFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the last element of this deque, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail of this deque </para>
				/// </returns>
				/// <java-name>
				/// takeLast
				/// </java-name>
				[Dot42.DexImport("takeLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E TakeLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the first element of this deque, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E PollFirst(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the last element of this deque, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail of this deque, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E PollLast(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the first element of this deque, or returns  <code>null</code> if this deque is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or  <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peekFirst
				/// </java-name>
				[Dot42.DexImport("peekFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PeekFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the last element of this deque, or returns  <code>null</code> if this deque is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail of this deque, or  <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peekLast
				/// </java-name>
				[Dot42.DexImport("peekLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E PeekLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Removes the first occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <c>e </c> such that  <c>o.equals(e) </c> (if such an element exists). Returns <c>true </c> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if an element was removed as a result of this call </para>
				/// </returns>
				/// <java-name>
				/// removeFirstOccurrence
				/// </java-name>
				[Dot42.DexImport("removeFirstOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool RemoveFirstOccurrence(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes the last occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the last element <c>e </c> such that  <c>o.equals(e) </c> (if such an element exists). Returns <c>true </c> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if an element was removed as a result of this call </para>
				/// </returns>
				/// <java-name>
				/// removeLastOccurrence
				/// </java-name>
				[Dot42.DexImport("removeLastOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool RemoveLastOccurrence(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element at the end of this deque unless it would violate capacity restrictions. When using a capacity-restricted deque, it is generally preferable to use method offer.</para> <para>This method is equivalent to addLast.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque. This method differs from poll only in that it throws an exception if this deque is empty.</para> <para>This method is equivalent to removeFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), or returns  <c>null </c> if this deque is empty.</para> <para>This method is equivalent to pollFirst().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), waiting if necessary until an element becomes available.</para> <para>This method is equivalent to takeFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), waiting up to the specified wait time if necessary for an element to become available.</para> <para>This method is equivalent to pollFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of the queue represented by this deque. This method differs from peek only in that it throws an exception if this deque is empty.</para> <para>This method is equivalent to getFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of the queue represented by this deque (in other words, the first element of this deque), or returns <c>null </c> if this deque is empty.</para> <para>This method is equivalent to peekFirst.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this deque, or <c>null </c> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns the number of additional elements that this deque can ideally (in the absence of memory or resource constraints) accept without blocking. This is always equal to the initial capacity of this deque less the current <c>size </c> of this deque.</para> <para>Note that you  <b>cannot</b> always tell if an attempt to insert an element will succeed by inspecting <c>remainingCapacity </c> because it may be the case that another thread is about to insert or remove an element. </para>        
				/// </summary>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Push(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Removes the first occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <c>e </c> such that  <c>o.equals(e) </c> (if such an element exists). Returns <c>true </c> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para> <para>This method is equivalent to removeFirstOccurrence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this deque changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the number of elements in this deque.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this deque </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this deque contains the specified element. More formally, returns <c>true </c> if and only if this deque contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this deque contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// getFirst
				/// </java-name>
				public virtual E First
				{
						[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return default(E); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// getLast
				/// </java-name>
				public virtual E Last
				{
						[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return default(E); }
				}

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>An optionally-bounded  BlockingQueue blocking queue} based on linked nodes. This queue orders elements FIFO (first-in-first-out). The  <b>head</b> of the queue is that element that has been on the queue the longest time. The  <b>tail</b> of the queue is that element that has been on the queue the shortest time. New elements are inserted at the tail of the queue, and the queue retrieval operations obtain elements at the head of the queue. Linked queues typically have higher throughput than array-based queues but less predictable performance in most concurrent applications.</para> <para>The optional capacity bound constructor argument serves as a way to prevent excessive queue expansion. The capacity, if unspecified, is equal to Integer#MAX_VALUE. Linked nodes are dynamically created upon each insertion unless this would bring the queue above capacity.</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Collection and Iterator interfaces.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/LinkedBlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/LinkedBlockingQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class LinkedBlockingQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Tells whether both locks are held by current thread. Creates a <c>LinkedBlockingQueue </c> with a capacity of Integer#MAX_VALUE. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedBlockingQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>LinkedBlockingQueue </c> with the given (fixed) capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedBlockingQueue(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>LinkedBlockingQueue </c> with the given (fixed) capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedBlockingQueue(global::Java.Util.ICollection<E> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of elements in this queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the number of additional elements that this queue can ideally (in the absence of memory or resource constraints) accept without blocking. This is always equal to the initial capacity of this queue less the current <c>size </c> of this queue.</para> <para>Note that you  <b>cannot</b> always tell if an attempt to insert an element will succeed by inspecting <c>remainingCapacity </c> because it may be the case that another thread is about to insert or remove an element. </para>        
				/// </summary>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue, waiting if necessary for space to become available.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue, waiting if necessary up to the specified wait time for space to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if successful, or <c>false </c> if the specified waiting time elapses before space is available </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element at the tail of this queue if it is possible to do so immediately without exceeding the queue's capacity, returning <c>true </c> upon success and <c>false </c> if this queue is full. When using a capacity-restricted queue, this method is generally preferable to method add, which can fail to insert an element only by throwing an exception.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Removes a single instance of the specified element from this queue, if it is present. More formally, removes an element <c>e </c> such that <c>o.equals(e) </c> , if this queue contains one or more such elements. Returns <c>true </c> if this queue contained the specified element (or equivalently, if this queue changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this queue contains the specified element. More formally, returns <c>true </c> if and only if this queue contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue, in proper sequence.</para> <para>The returned array will be "safe" in that no references to it are maintained by this queue. (In other words, this method must allocate a new array). The caller is thus free to modify the returned array.</para> <para>This method acts as bridge between array-based and collection-based APIs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue, in proper sequence; the runtime type of the returned array is that of the specified array. If the queue fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this queue.</para> <para>If this queue fits in the specified array with room to spare (i.e., the array has more elements than this queue), the element in the array immediately following the end of the queue is set to  <c>null </c> .</para> <para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para> <para>Suppose <c>x </c> is a queue known to contain only strings. The following code can be used to dump the queue into a newly allocated array of <c>String </c> :</para> <para> <pre>String[] y = x.toArray(new String[0]); 
				/// 
				///  </pre></para> <para>Note that <c>toArray(new Object[0]) </c> is identical in function to  <c>toArray() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Atomically removes all of the elements from this queue. The queue will be empty after this call returns. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an iterator over the elements in this queue in proper sequence. The elements will be returned in order from first (head) to last (tail).</para> <para>The returned iterator is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this queue in proper sequence </para>
				/// </returns>
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

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>An unbounded  BlockingQueue blocking queue} that uses the same ordering rules as class PriorityQueue and supplies blocking retrieval operations. While this queue is logically unbounded, attempted additions may fail due to resource exhaustion (causing <c>OutOfMemoryError </c> ). This class does not permit  <c>null </c> elements. A priority queue relying on  Comparable natural ordering} also does not permit insertion of non-comparable objects (doing so results in  <c>ClassCastException </c> ).</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Collection and Iterator interfaces. The Iterator provided in method iterator() is  <b>not</b> guaranteed to traverse the elements of the PriorityBlockingQueue in any particular order. If you need ordered traversal, consider using  <c>Arrays.sort(pq.toArray()) </c> . Also, method <c>drainTo </c> can be used to  <b>remove</b> some or all elements in priority order and place them in another collection.</para> <para>Operations on this class make no guarantees about the ordering of elements with equal priority. If you need to enforce an ordering, you can define custom classes or comparators that use a secondary key to break ties in primary priority values. For example, here is a class that applies first-in-first-out tie-breaking to comparable elements. To use it, you would insert a  <c>new FIFOEntry(anEntry) </c> instead of a plain entry object.</para> <para> <pre>class FIFOEntry&lt;E extends Comparable&lt;? super E&gt;&gt;
		/// 
		///     implements Comparable&lt;FIFOEntry&lt;E&gt;&gt; {
		/// 
		///   static final AtomicLong seq = new AtomicLong(0);
		/// 
		///   final long seqNum;
		/// 
		///   final E entry;
		/// 
		///   public FIFOEntry(E entry) {
		/// 
		///     seqNum = seq.getAndIncrement();
		/// 
		///     this.entry = entry;
		/// 
		///   }
		/// 
		///   public E getEntry() { return entry; }
		/// 
		///   public int compareTo(FIFOEntry&lt;E&gt; other) {
		/// 
		///     int res = entry.compareTo(other.entry);
		/// 
		///     if (res == 0 &amp;&amp; other.entry != this.entry)
		/// 
		///       res = (seqNum &lt; other.seqNum ? -1 : 1);
		/// 
		///     return res;
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/PriorityBlockingQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/PriorityBlockingQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class PriorityBlockingQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a <c>PriorityBlockingQueue </c> with the default initial capacity (11) that orders its elements according to their  Comparable natural ordering}. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PriorityBlockingQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>PriorityBlockingQueue </c> with the specified initial capacity that orders its elements according to their  Comparable natural ordering}.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PriorityBlockingQueue(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>PriorityBlockingQueue </c> with the specified initial capacity that orders its elements according to the specified comparator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/Comparator;)V", AccessFlags = 1, Signature = "(ILjava/util/Comparator<-TE;>;)V")]
				public PriorityBlockingQueue(int initialCapacity, global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>PriorityBlockingQueue </c> with the specified initial capacity that orders its elements according to their  Comparable natural ordering}.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public PriorityBlockingQueue(global::Java.Util.ICollection<E> initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element into this priority queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Collection#add) </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element into this priority queue. As the queue is unbounded, this method will never return <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by Queue#offer) </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element into this priority queue. As the queue is unbounded, this method will never block.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element into this priority queue. As the queue is unbounded, this method will never block or return <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (as specified by BlockingQueue.offer) </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary until an element becomes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting up to the specified wait time if necessary for an element to become available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if the specified waiting time elapses before an element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves, but does not remove, the head of this queue, or returns  <code>null</code> if this queue is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or  <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns the comparator used to order the elements in this queue, or <c>null </c> if this queue uses the  Comparable natural ordering} of its elements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the comparator used to order the elements in this queue, or <c>null </c> if this queue uses the natural ordering of its elements </para>
				/// </returns>
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TE;>;")]
				public virtual global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<E>);
				}

				/// <summary>
				///  <para>Returns a count of how many objects this <c>Collection </c> contains.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>how many objects this <c>Collection </c> contains, or Integer.MAX_VALUE if there are more than Integer.MAX_VALUE elements in this  <c>Collection </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Always returns <c>Integer.MAX_VALUE </c> because a <c>PriorityBlockingQueue </c> is not capacity constrained. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>Integer.MAX_VALUE </c> always </para>
				/// </returns>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes a single instance of the specified element from this queue, if it is present. More formally, removes an element <c>e </c> such that <c>o.equals(e) </c> , if this queue contains one or more such elements. Returns <c>true </c> if and only if this queue contained the specified element (or equivalently, if this queue changed as a result of the call).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue changed as a result of the call </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this queue contains the specified element. More formally, returns <c>true </c> if and only if this queue contains at least one element <c>e </c> such that <c>o.equals(e) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this queue contains the specified element </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue. The returned array elements are in no particular order.</para> <para>The returned array will be "safe" in that no references to it are maintained by this queue. (In other words, this method must allocate a new array). The caller is thus free to modify the returned array.</para> <para>This method acts as bridge between array-based and collection-based APIs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Atomically removes all of the elements from this queue. The queue will be empty after this call returns. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an array containing all of the elements in this queue; the runtime type of the returned array is that of the specified array. The returned array elements are in no particular order. If the queue fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this queue.</para> <para>If this queue fits in the specified array with room to spare (i.e., the array has more elements than this queue), the element in the array immediately following the end of the queue is set to  <c>null </c> .</para> <para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para> <para>Suppose <c>x </c> is a queue known to contain only strings. The following code can be used to dump the queue into a newly allocated array of <c>String </c> :</para> <para> <pre>String[] y = x.toArray(new String[0]); 
				/// 
				///  </pre></para> <para>Note that <c>toArray(new Object[0]) </c> is identical in function to  <c>toArray() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all of the elements in this queue </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Returns an iterator over the elements in this queue. The iterator does not return the elements in any particular order.</para> <para>The returned iterator is a "weakly consistent" iterator that will never throw ConcurrentModificationException, and guarantees to traverse elements as they existed upon construction of the iterator, and may (but is not guaranteed to) reflect any modifications subsequent to construction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over the elements in this queue </para>
				/// </returns>
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

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Exception thrown by an Executor when a task cannot be accepted for execution.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/RejectedExecutionException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/RejectedExecutionException", AccessFlags = 33)]
		public partial class RejectedExecutionException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>RejectedExecutionException </c> with no detail message. The cause is not initialized, and may subsequently be initialized by a call to initCause. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RejectedExecutionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RejectedExecutionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>RejectedExecutionException </c> with the specified detail message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public RejectedExecutionException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public RejectedExecutionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A ThreadPoolExecutor that can additionally schedule commands to run after a given delay, or to execute periodically. This class is preferable to java.util.Timer when multiple worker threads are needed, or when the additional flexibility or capabilities of ThreadPoolExecutor (which this class extends) are required.</para> <para>Delayed tasks execute no sooner than they are enabled, but without any real-time guarantees about when, after they are enabled, they will commence. Tasks scheduled for exactly the same execution time are enabled in first-in-first-out (FIFO) order of submission.</para> <para>When a submitted task is cancelled before it is run, execution is suppressed. By default, such a cancelled task is not automatically removed from the work queue until its delay elapses. While this enables further inspection and monitoring, it may also cause unbounded retention of cancelled tasks.</para> <para>Successive executions of a task scheduled via  <c>scheduleAtFixedRate </c> or  <c>scheduleWithFixedDelay </c> do not overlap. While different executions may be performed by different threads, the effects of prior executions  those of subsequent ones.</para> <para>While this class inherits from ThreadPoolExecutor, a few of the inherited tuning methods are not useful for it. In particular, because it acts as a fixed-sized pool using  <c>corePoolSize </c> threads and an unbounded queue, adjustments to <c>maximumPoolSize </c> have no useful effect. Additionally, it is almost never a good idea to set <c>corePoolSize </c> to zero or use <c>allowCoreThreadTimeOut </c> because this may leave the pool without threads to handle tasks once they become eligible to run.</para> <para> <b>Extension notes:</b> This class overrides the execute and submit methods to generate internal ScheduledFuture objects to control per-task delays and scheduling. To preserve functionality, any further overrides of these methods in subclasses must invoke superclass versions, which effectively disables additional task customization. However, this class provides alternative protected extension method  <c>decorateTask </c> (one version each for <c>Runnable </c> and  <c>Callable </c> ) that can be used to customize the concrete task types used to execute commands entered via <c>execute </c> ,  <c>submit </c> , <c>schedule </c> , <c>scheduleAtFixedRate </c> , and <c>scheduleWithFixedDelay </c> . By default, a  <c>ScheduledThreadPoolExecutor </c> uses a task type extending FutureTask. However, this may be modified or replaced using subclasses of the form:</para> <para> <pre>public class CustomScheduledExecutor extends ScheduledThreadPoolExecutor {
		/// 
		/// 
		/// 
		///   static class CustomTask&lt;V&gt; implements RunnableScheduledFuture&lt;V&gt; { ... }
		/// 
		/// 
		/// 
		///   protected &lt;V&gt; RunnableScheduledFuture&lt;V&gt; decorateTask(
		/// 
		///                Runnable r, RunnableScheduledFuture&lt;V&gt; task) {
		/// 
		///       return new CustomTask&lt;V&gt;(r, task);
		/// 
		///   }
		/// 
		/// 
		/// 
		///   protected &lt;V&gt; RunnableScheduledFuture&lt;V&gt; decorateTask(
		/// 
		///                Callable&lt;V&gt; c, RunnableScheduledFuture&lt;V&gt; task) {
		/// 
		///       return new CustomTask&lt;V&gt;(c, task);
		/// 
		///   }
		/// 
		///   // ... add constructors, etc.
		/// 
		/// } 
		/// 
		///  </pre></para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ScheduledThreadPoolExecutor
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ScheduledThreadPoolExecutor", AccessFlags = 33)]
		public partial class ScheduledThreadPoolExecutor : global::Java.Util.Concurrent.ThreadPoolExecutor, global::Java.Util.Concurrent.IScheduledExecutorService
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>ScheduledThreadPoolExecutor </c> with the given core pool size.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int corePoolSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>ScheduledThreadPoolExecutor </c> with the given initial parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/concurrent/ThreadFactory;)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int corePoolSize, global::Java.Util.Concurrent.IThreadFactory threadFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>ScheduledThreadPoolExecutor </c> with the given initial parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int corePoolSize, global::Java.Util.Concurrent.IRejectedExecutionHandler threadFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new ScheduledThreadPoolExecutor with the given initial parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHand" +
    "ler;)V", AccessFlags = 1)]
				public ScheduledThreadPoolExecutor(int corePoolSize, global::Java.Util.Concurrent.IThreadFactory threadFactory, global::Java.Util.Concurrent.IRejectedExecutionHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies or replaces the task used to execute a callable. This method can be used to override the concrete class used for managing internal tasks. The default implementation simply returns the given task.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a task that can execute the callable </para>
				/// </returns>
				/// <java-name>
				/// decorateTask
				/// </java-name>
				[Dot42.DexImport("decorateTask", "(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/co" +
    "ncurrent/RunnableScheduledFuture;", AccessFlags = 4, Signature = "<V:Ljava/lang/Object;>(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableSchedule" +
    "dFuture<TV;>;)Ljava/util/concurrent/RunnableScheduledFuture<TV;>;")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableScheduledFuture<V> DecorateTask<V>(global::Java.Lang.IRunnable callable, global::Java.Util.Concurrent.IRunnableScheduledFuture<V> task) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IRunnableScheduledFuture<V>);
				}

				/// <summary>
				///  <para>Modifies or replaces the task used to execute a callable. This method can be used to override the concrete class used for managing internal tasks. The default implementation simply returns the given task.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a task that can execute the callable </para>
				/// </returns>
				/// <java-name>
				/// decorateTask
				/// </java-name>
				[Dot42.DexImport("decorateTask", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/RunnableScheduledFuture;)Lj" +
    "ava/util/concurrent/RunnableScheduledFuture;", AccessFlags = 4, Signature = "<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;Ljava/util/concurrent/" +
    "RunnableScheduledFuture<TV;>;)Ljava/util/concurrent/RunnableScheduledFuture<TV;>" +
    ";")]
				protected internal virtual global::Java.Util.Concurrent.IRunnableScheduledFuture<V> DecorateTask<V>(global::Java.Util.Concurrent.ICallable<V> callable, global::Java.Util.Concurrent.IRunnableScheduledFuture<V> task) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleAtFixedRate
				/// </java-name>
				[Dot42.DexImport("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				public virtual global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleAtFixedRate(global::Java.Lang.IRunnable command, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleWithFixedDelay
				/// </java-name>
				[Dot42.DexImport("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
    "duledFuture<*>;")]
				public virtual global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleWithFixedDelay(global::Java.Lang.IRunnable command, long initialDelay, long delay, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
				}

				/// <summary>
				///  <para>Executes <c>command </c> with zero required delay. This has effect equivalent to schedule(command, 0, anyUnit). Note that inspections of the queue and of the list returned by  <c>shutdownNow </c> will access the zero-delayed ScheduledFuture, not the <c>command </c> itself.</para> <para>A consequence of the use of <c>ScheduledFuture </c> objects is that afterExecute is always called with a null second <c>Throwable </c> argument, even if the  <c>command </c> terminated abruptly. Instead, the <c>Throwable </c> thrown by such a task can be obtained via Future#get.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public override void Execute(global::Java.Lang.IRunnable command) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
				public override global::Java.Util.Concurrent.IFuture<object> Submit(global::Java.Lang.IRunnable task) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<object>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;" +
    "")]
				public override global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Lang.IRunnable task, T result) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// submit
				/// </java-name>
				[Dot42.DexImport("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent" +
    "/Future<TT;>;")]
				public override global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::Java.Util.Concurrent.ICallable<T> task) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.IFuture<T>);
				}

				/// <summary>
				///  <para>Initiates an orderly shutdown in which previously submitted tasks are executed, but no new tasks will be accepted. Invocation has no additional effect if already shut down.</para> <para>This method does not wait for previously submitted tasks to complete execution. Use awaitTermination to do that.</para> <para>If the <c>ExecuteExistingDelayedTasksAfterShutdownPolicy </c> has been set <c>false </c> , existing delayed tasks whose delays have not yet elapsed are cancelled. And unless the <c>ContinueExistingPeriodicTasksAfterShutdownPolicy </c> has been set  <c>true </c> , future executions of existing periodic tasks will be cancelled. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to stop all actively executing tasks, halts the processing of waiting tasks, and returns a list of the tasks that were awaiting execution.</para> <para>This method does not wait for actively executing tasks to terminate. Use awaitTermination to do that.</para> <para>There are no guarantees beyond best-effort attempts to stop processing actively executing tasks. This implementation cancels tasks via Thread#interrupt, so any task that fails to respond to interrupts may never terminate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>list of tasks that never commenced execution. Each element of this list is a ScheduledFuture, including those tasks submitted using <c>execute </c> , which are for scheduling purposes used as the basis of a zero-delay <c>ScheduledFuture </c> . </para>
				/// </returns>
				/// <java-name>
				/// shutdownNow
				/// </java-name>
				[Dot42.DexImport("shutdownNow", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				public override global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.IRunnable>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScheduledThreadPoolExecutor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1025)]
				public override bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
				public override global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future" +
    "<TT;>;>;")]
				public override global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>> InvokeAll<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Java.Util.Concurrent.IFuture<T>>);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;)TT;")]
				public override T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				[Dot42.DexImport("java/util/concurrent/ExecutorService", "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>" +
    ";>;JLjava/util/concurrent/TimeUnit;)TT;")]
				public override T InvokeAny<T>(global::Java.Util.ICollection<global::Java.Util.Concurrent.ICallable<T>> tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Gets the policy on whether to continue executing existing periodic tasks even when this executor has been <c>shutdown </c> . In this case, these tasks will only terminate upon  <c>shutdownNow </c> or after setting the policy to  <c>false </c> when already shutdown. This value is by default <c>false </c> .</para> <para> <para>setContinueExistingPeriodicTasksAfterShutdownPolicy </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if will continue after shutdown </para>
				/// </returns>
				/// <java-name>
				/// getContinueExistingPeriodicTasksAfterShutdownPolicy
				/// </java-name>
				public virtual bool IsContinueExistingPeriodicTasksAfterShutdownPolicy
				{
						[Dot42.DexImport("getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the policy on whether to execute existing delayed tasks even when this executor has been <c>shutdown </c> . In this case, these tasks will only terminate upon  <c>shutdownNow </c> , or after setting the policy to  <c>false </c> when already shutdown. This value is by default <c>true </c> .</para> <para> <para>setExecuteExistingDelayedTasksAfterShutdownPolicy </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if will execute after shutdown </para>
				/// </returns>
				/// <java-name>
				/// getExecuteExistingDelayedTasksAfterShutdownPolicy
				/// </java-name>
				public virtual bool IsExecuteExistingDelayedTasksAfterShutdownPolicy
				{
						[Dot42.DexImport("getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the task queue used by this executor. Each element of this queue is a ScheduledFuture, including those tasks submitted using <c>execute </c> which are for scheduling purposes used as the basis of a zero-delay  <c>ScheduledFuture </c> . Iteration over this queue is  <b>not</b> guaranteed to traverse tasks in the order in which they will execute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the task queue </para>
				/// </returns>
				/// <java-name>
				/// getQueue
				/// </java-name>
				public override global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> Queue
				{
						[Dot42.DexImport("getQueue", "()Ljava/util/concurrent/BlockingQueue;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/BlockingQueue<Ljava/lang/Runnable;>;")]
						get{ return default(global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable>); }
				}

				public override bool IsShutdown
				{
						[Dot42.DexImport("java/util/concurrent/ExecutorService", "isShutdown", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override bool IsTerminated
				{
						[Dot42.DexImport("java/util/concurrent/ExecutorService", "isTerminated", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A counting semaphore. Conceptually, a semaphore maintains a set of permits. Each acquire blocks if necessary until a permit is available, and then takes it. Each release adds a permit, potentially releasing a blocking acquirer. However, no actual permit objects are used; the <c>Semaphore </c> just keeps a count of the number available and acts accordingly.</para> <para>Semaphores are often used to restrict the number of threads than can access some (physical or logical) resource. For example, here is a class that uses a semaphore to control access to a pool of items:  <pre>class Pool {
		/// 
		///   private static final int MAX_AVAILABLE = 100;
		/// 
		///   private final Semaphore available = new Semaphore(MAX_AVAILABLE, true);
		/// 
		/// 
		/// 
		///   public Object getItem() throws InterruptedException {
		/// 
		///     available.acquire();
		/// 
		///     return getNextAvailableItem();
		/// 
		///   }
		/// 
		/// 
		/// 
		///   public void putItem(Object x) {
		/// 
		///     if (markAsUnused(x))
		/// 
		///       available.release();
		/// 
		///   }
		/// 
		/// 
		/// 
		///   // Not a particularly efficient data structure; just for demo
		/// 
		/// 
		/// 
		///   protected Object[] items = ... whatever kinds of items being managed
		/// 
		///   protected boolean[] used = new boolean[MAX_AVAILABLE];
		/// 
		/// 
		/// 
		///   protected synchronized Object getNextAvailableItem() {
		/// 
		///     for (int i = 0; i &lt; MAX_AVAILABLE; ++i) {
		/// 
		///       if (!used[i]) {
		/// 
		///          used[i] = true;
		/// 
		///          return items[i];
		/// 
		///       }
		/// 
		///     }
		/// 
		///     return null; // not reached
		/// 
		///   }
		/// 
		/// 
		/// 
		///   protected synchronized boolean markAsUnused(Object item) {
		/// 
		///     for (int i = 0; i &lt; MAX_AVAILABLE; ++i) {
		/// 
		///       if (item == items[i]) {
		/// 
		///          if (used[i]) {
		/// 
		///            used[i] = false;
		/// 
		///            return true;
		/// 
		///          } else
		/// 
		///            return false;
		/// 
		///       }
		/// 
		///     }
		/// 
		///     return false;
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para>Before obtaining an item each thread must acquire a permit from the semaphore, guaranteeing that an item is available for use. When the thread has finished with the item it is returned back to the pool and a permit is returned to the semaphore, allowing another thread to acquire that item. Note that no synchronization lock is held when acquire is called as that would prevent an item from being returned to the pool. The semaphore encapsulates the synchronization needed to restrict access to the pool, separately from any synchronization needed to maintain the consistency of the pool itself.</para> <para>A semaphore initialized to one, and which is used such that it only has at most one permit available, can serve as a mutual exclusion lock. This is more commonly known as a  <b>binary semaphore</b>, because it only has two states: one permit available, or zero permits available. When used in this way, the binary semaphore has the property (unlike many java.util.concurrent.locks.Lock implementations), that the "lock" can be released by a thread other than the owner (as semaphores have no notion of ownership). This can be useful in some specialized contexts, such as deadlock recovery.</para> <para>The constructor for this class optionally accepts a  <b>fairness</b> parameter. When set false, this class makes no guarantees about the order in which threads acquire permits. In particular,  <b>barging</b> is permitted, that is, a thread invoking acquire can be allocated a permit ahead of a thread that has been waiting - logically the new thread places itself at the head of the queue of waiting threads. When fairness is set true, the semaphore guarantees that threads invoking any of the acquire methods are selected to obtain permits in the order in which their invocation of those methods was processed (first-in-first-out; FIFO). Note that FIFO ordering necessarily applies to specific internal points of execution within these methods. So, it is possible for one thread to invoke  <c>acquire </c> before another, but reach the ordering point after the other, and similarly upon return from the method. Also note that the untimed tryAcquire methods do not honor the fairness setting, but will take any permits that are available.</para> <para>Generally, semaphores used to control resource access should be initialized as fair, to ensure that no thread is starved out from accessing a resource. When using semaphores for other kinds of synchronization control, the throughput advantages of non-fair ordering often outweigh fairness considerations.</para> <para>This class also provides convenience methods to acquire and release multiple permits at a time. Beware of the increased risk of indefinite postponement when these methods are used without fairness set true.</para> <para>Memory consistency effects: Actions in a thread prior to calling a "release" method such as <c>release() </c>  actions following a successful "acquire" method such as <c>acquire() </c> in another thread.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/Semaphore
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/Semaphore", AccessFlags = 33)]
		public partial class Semaphore : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a <c>Semaphore </c> with the given number of permits and nonfair fairness setting.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Semaphore(int permits) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>Semaphore </c> with the given number of permits and the given fairness setting.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public Semaphore(int permits, bool fair) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Acquires a permit from this semaphore, blocking until one is available, or the thread is  Thread::interrupt interrupted}.</para> <para>Acquires a permit, if one is available and returns immediately, reducing the number of available permits by one.</para> <para>If no permit is available then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happens:  <ul> <li> <para>Some other thread invokes the release method for this semaphore and the current thread is next to be assigned a permit; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting for a permit, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
				public virtual void Acquire() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Acquires a permit from this semaphore, blocking until one is available.</para> <para>Acquires a permit, if one is available and returns immediately, reducing the number of available permits by one.</para> <para>If no permit is available then the current thread becomes disabled for thread scheduling purposes and lies dormant until some other thread invokes the release method for this semaphore and the current thread is next to be assigned a permit.</para> <para>If the current thread is  Thread::interrupt interrupted} while waiting for a permit then it will continue to wait, but the time at which the thread is assigned a permit may change compared to the time it would have received the permit had no interruption occurred. When the thread does return from this method its interrupt status will be set. </para>        
				/// </summary>
				/// <java-name>
				/// acquireUninterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireUninterruptibly", "()V", AccessFlags = 1)]
				public virtual void AcquireUninterruptibly() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Acquires a permit from this semaphore, only if one is available at the time of invocation.</para> <para>Acquires a permit, if one is available and returns immediately, with the value <c>true </c> , reducing the number of available permits by one.</para> <para>If no permit is available then this method will return immediately with the value <c>false </c> .</para> <para>Even when this semaphore has been set to use a fair ordering policy, a call to <c>tryAcquire() </c>  <b>will</b> immediately acquire a permit if one is available, whether or not other threads are currently waiting. This "barging" behavior can be useful in certain circumstances, even though it breaks fairness. If you want to honor the fairness setting, then use tryAcquire(0, TimeUnit.SECONDS)  which is almost equivalent (it also detects interruption).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a permit was acquired and <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "()Z", AccessFlags = 1)]
				public virtual bool TryAcquire() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Acquires a permit from this semaphore, if one becomes available within the given waiting time and the current thread has not been  Thread::interrupt interrupted}.</para> <para>Acquires a permit, if one is available and returns immediately, with the value <c>true </c> , reducing the number of available permits by one.</para> <para>If no permit is available then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:  <ul> <li> <para>Some other thread invokes the release method for this semaphore and the current thread is next to be assigned a permit; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread; or </para></li> <li> <para>The specified waiting time elapses. </para></li></ul></para> <para>If a permit is acquired then the value <c>true </c> is returned.</para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting to acquire a permit, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared.</para> <para>If the specified waiting time elapses then the value <c>false </c> is returned. If the time is less than or equal to zero, the method will not wait at all.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a permit was acquired and <c>false </c> if the waiting time elapsed before a permit was acquired </para>
				/// </returns>
				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool TryAcquire(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Releases a permit, returning it to the semaphore.</para> <para>Releases a permit, increasing the number of available permits by one. If any threads are trying to acquire a permit, then one is selected and given the permit that was just released. That thread is (re)enabled for thread scheduling purposes.</para> <para>There is no requirement that a thread that releases a permit must have acquired that permit by calling acquire. Correct usage of a semaphore is established by programming convention in the application. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Acquires the given number of permits from this semaphore, blocking until all are available, or the thread is  Thread::interrupt interrupted}.</para> <para>Acquires the given number of permits, if they are available, and returns immediately, reducing the number of available permits by the given amount.</para> <para>If insufficient permits are available then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of two things happens:  <ul> <li> <para>Some other thread invokes one of the release methods for this semaphore, the current thread is next to be assigned permits and the number of available permits satisfies this request; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread. </para></li></ul></para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting for a permit, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared. Any permits that were to be assigned to this thread are instead assigned to other threads trying to acquire permits, as if permits had been made available by a call to release().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(I)V", AccessFlags = 1)]
				public virtual void Acquire(int permits) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Acquires the given number of permits from this semaphore, blocking until all are available.</para> <para>Acquires the given number of permits, if they are available, and returns immediately, reducing the number of available permits by the given amount.</para> <para>If insufficient permits are available then the current thread becomes disabled for thread scheduling purposes and lies dormant until some other thread invokes one of the release methods for this semaphore, the current thread is next to be assigned permits and the number of available permits satisfies this request.</para> <para>If the current thread is  Thread::interrupt interrupted} while waiting for permits then it will continue to wait and its position in the queue is not affected. When the thread does return from this method its interrupt status will be set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// acquireUninterruptibly
				/// </java-name>
				[Dot42.DexImport("acquireUninterruptibly", "(I)V", AccessFlags = 1)]
				public virtual void AcquireUninterruptibly(int permits) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Acquires the given number of permits from this semaphore, only if all are available at the time of invocation.</para> <para>Acquires the given number of permits, if they are available, and returns immediately, with the value <c>true </c> , reducing the number of available permits by the given amount.</para> <para>If insufficient permits are available then this method will return immediately with the value <c>false </c> and the number of available permits is unchanged.</para> <para>Even when this semaphore has been set to use a fair ordering policy, a call to <c>tryAcquire </c>  <b>will</b> immediately acquire a permit if one is available, whether or not other threads are currently waiting. This "barging" behavior can be useful in certain circumstances, even though it breaks fairness. If you want to honor the fairness setting, then use long, TimeUnit) tryAcquire(permits, 0, TimeUnit.SECONDS)  which is almost equivalent (it also detects interruption).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the permits were acquired and  <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(I)Z", AccessFlags = 1)]
				public virtual bool TryAcquire(int permits) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Acquires the given number of permits from this semaphore, if all become available within the given waiting time and the current thread has not been  Thread::interrupt interrupted}.</para> <para>Acquires the given number of permits, if they are available and returns immediately, with the value <c>true </c> , reducing the number of available permits by the given amount.</para> <para>If insufficient permits are available then the current thread becomes disabled for thread scheduling purposes and lies dormant until one of three things happens:  <ul> <li> <para>Some other thread invokes one of the release methods for this semaphore, the current thread is next to be assigned permits and the number of available permits satisfies this request; or </para></li> <li> <para>Some other thread  Thread::interrupt interrupts} the current thread; or </para></li> <li> <para>The specified waiting time elapses. </para></li></ul></para> <para>If the permits are acquired then the value <c>true </c> is returned.</para> <para>If the current thread:  <ul> <li> <para>has its interrupted status set on entry to this method; or </para></li> <li> <para>is  Thread::interrupt interrupted} while waiting to acquire the permits, </para></li></ul>then InterruptedException is thrown and the current thread's interrupted status is cleared. Any permits that were to be assigned to this thread, are instead assigned to other threads trying to acquire permits, as if the permits had been made available by a call to release().</para> <para>If the specified waiting time elapses then the value <c>false </c> is returned. If the time is less than or equal to zero, the method will not wait at all. Any permits that were to be assigned to this thread, are instead assigned to other threads trying to acquire permits, as if the permits had been made available by a call to release().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all permits were acquired and <c>false </c> if the waiting time elapsed before all permits were acquired </para>
				/// </returns>
				/// <java-name>
				/// tryAcquire
				/// </java-name>
				[Dot42.DexImport("tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public virtual bool TryAcquire(int permits, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Releases the given number of permits, returning them to the semaphore.</para> <para>Releases the given number of permits, increasing the number of available permits by that amount. If any threads are trying to acquire permits, then one is selected and given the permits that were just released. If the number of available permits satisfies that thread's request then that thread is (re)enabled for thread scheduling purposes; otherwise the thread will wait until sufficient permits are available. If there are still permits available after this thread's request has been satisfied, then those permits are assigned in turn to other threads trying to acquire permits.</para> <para>There is no requirement that a thread that releases a permit must have acquired that permit by calling acquire. Correct usage of a semaphore is established by programming convention in the application.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(I)V", AccessFlags = 1)]
				public virtual void Release(int permits) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current number of permits available in this semaphore.</para> <para>This method is typically used for debugging and testing purposes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of permits available in this semaphore </para>
				/// </returns>
				/// <java-name>
				/// availablePermits
				/// </java-name>
				[Dot42.DexImport("availablePermits", "()I", AccessFlags = 1)]
				public virtual int AvailablePermits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Acquires and returns all permits that are immediately available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of permits acquired </para>
				/// </returns>
				/// <java-name>
				/// drainPermits
				/// </java-name>
				[Dot42.DexImport("drainPermits", "()I", AccessFlags = 1)]
				public virtual int DrainPermits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Shrinks the number of available permits by the indicated reduction. This method can be useful in subclasses that use semaphores to track resources that become unavailable. This method differs from <c>acquire </c> in that it does not block waiting for permits to become available.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reducePermits
				/// </java-name>
				[Dot42.DexImport("reducePermits", "(I)V", AccessFlags = 4)]
				protected internal virtual void ReducePermits(int reduction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string identifying this semaphore, as well as its state. The state, in brackets, includes the String <c>"Permits =" </c> followed by the number of permits.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string identifying this semaphore, as well as its state </para>
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
				internal Semaphore() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this semaphore has fairness set true.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this semaphore has fairness set true </para>
				/// </returns>
				/// <java-name>
				/// isFair
				/// </java-name>
				public virtual bool IsFair
				{
						[Dot42.DexImport("isFair", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Queries whether any threads are waiting to acquire. Note that because cancellations may occur at any time, a <c>true </c> return does not guarantee that any other thread will ever acquire. This method is designed primarily for use in monitoring of the system state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if there may be other threads waiting to acquire the lock </para>
				/// </returns>
				/// <java-name>
				/// hasQueuedThreads
				/// </java-name>
				public bool HasQueuedThreads
				{
						[Dot42.DexImport("hasQueuedThreads", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns an estimate of the number of threads waiting to acquire. The value is only an estimate because the number of threads may change dynamically while this method traverses internal data structures. This method is designed for use in monitoring of the system state, not for synchronization control.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the estimated number of threads waiting for this lock </para>
				/// </returns>
				/// <java-name>
				/// getQueueLength
				/// </java-name>
				public int QueueLength
				{
						[Dot42.DexImport("getQueueLength", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a collection containing threads that may be waiting to acquire. Because the actual set of threads may change dynamically while constructing this result, the returned collection is only a best-effort estimate. The elements of the returned collection are in no particular order. This method is designed to facilitate construction of subclasses that provide more extensive monitoring facilities.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the collection of threads </para>
				/// </returns>
				/// <java-name>
				/// getQueuedThreads
				/// </java-name>
				protected internal virtual global::Java.Util.ICollection<global::System.Threading.Thread> QueuedThreads
				{
						[Dot42.DexImport("getQueuedThreads", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Ljava/lang/Thread;>;")]
						get{ return default(global::Java.Util.ICollection<global::System.Threading.Thread>); }
				}

		}

		/// <summary>
		///  <para>A  BlockingQueue blocking queue} in which each insert operation must wait for a corresponding remove operation by another thread, and vice versa. A synchronous queue does not have any internal capacity, not even a capacity of one. You cannot  <c>peek </c> at a synchronous queue because an element is only present when you try to remove it; you cannot insert an element (using any method) unless another thread is trying to remove it; you cannot iterate as there is nothing to iterate. The  <b>head</b> of the queue is the element that the first queued inserting thread is trying to add to the queue; if there is no such queued thread then no element is available for removal and  <c>poll() </c> will return <c>null </c> . For purposes of other  <c>Collection </c> methods (for example <c>contains </c> ), a  <c>SynchronousQueue </c> acts as an empty collection. This queue does not permit <c>null </c> elements.</para> <para>Synchronous queues are similar to rendezvous channels used in CSP and Ada. They are well suited for handoff designs, in which an object running in one thread must sync up with an object running in another thread in order to hand it some information, event, or task.</para> <para>This class supports an optional fairness policy for ordering waiting producer and consumer threads. By default, this ordering is not guaranteed. However, a queue constructed with fairness set to <c>true </c> grants threads access in FIFO order.</para> <para>This class and its iterator implement all of the  <b>optional</b> methods of the Collection and Iterator interfaces.</para> <para> <para>1.5 </para> <para>Doug Lea and Bill Scherer and Michael Scott </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/SynchronousQueue
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/SynchronousQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/util/concurrent/Blockin" +
    "gQueue<TE;>;Ljava/io/Serializable;")]
		public partial class SynchronousQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Util.Concurrent.IBlockingQueue<E>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a <c>SynchronousQueue </c> with nonfair access policy. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SynchronousQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a <c>SynchronousQueue </c> with the specified fairness policy.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public SynchronousQueue(bool fair) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds the specified element to this queue, waiting if necessary for another thread to receive it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Put(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified element into this queue, waiting if necessary up to the specified wait time for another thread to receive it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if successful, or <c>false </c> if the specified waiting time elapses before a consumer appears </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1, Signature = "(TE;JLjava/util/concurrent/TimeUnit;)Z")]
				public virtual bool Offer(E e, long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inserts the specified element into this queue, if another thread is waiting to receive it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the element was added to this queue, else  <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary for another thread to insert it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// take
				/// </java-name>
				[Dot42.DexImport("take", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Take() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, waiting if necessary up to the specified wait time, for another thread to insert it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if the specified waiting time elapses before an element is present </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(JLjava/util/concurrent/TimeUnit;)TE;")]
				public virtual E Poll(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieves and removes the head of this queue, if another thread is currently making an element available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head of this queue, or <c>null </c> if no element is available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Always returns zero. A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>zero </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Always returns zero. A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>zero </para>
				/// </returns>
				/// <java-name>
				/// remainingCapacity
				/// </java-name>
				[Dot42.DexImport("remainingCapacity", "()I", AccessFlags = 1)]
				public virtual int RemainingCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Does nothing. A <c>SynchronousQueue </c> has no internal capacity. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Always returns <c>false </c> . A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Always returns <c>false </c> . A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>false </c> unless the given collection is empty. A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>false </c> unless given collection is empty </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Always returns <c>false </c> . A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Always returns <c>false </c> . A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Always returns <c>null </c> . A <c>SynchronousQueue </c> does not return elements unless actively waited on.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>null </c> </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public override E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Returns an empty iterator in which <c>hasNext </c> always returns  <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an empty iterator </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <summary>
				///  <para>Returns a zero-length array. </para>        
				/// </summary>
				/// <returns>
				///  <para>a zero-length array </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Sets the zeroeth element of the specified array to <c>null </c> (if the array has non-zero length) and returns it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the specified array </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] a) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// drainTo
				/// </java-name>
				[Dot42.DexImport("drainTo", "(Ljava/util/Collection;I)I", AccessFlags = 1, Signature = "(Ljava/util/Collection<-TE;>;I)I")]
				public virtual int DrainTo(global::Java.Util.ICollection<E> c, int maxElements) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Always returns <c>true </c> . A <c>SynchronousQueue </c> has no internal capacity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>An ExecutorService that executes each submitted task using one of possibly several pooled threads, normally configured using Executors factory methods.</para> <para>Thread pools address two different problems: they usually provide improved performance when executing large numbers of asynchronous tasks, due to reduced per-task invocation overhead, and they provide a means of bounding and managing the resources, including threads, consumed when executing a collection of tasks. Each <c>ThreadPoolExecutor </c> also maintains some basic statistics, such as the number of completed tasks.</para> <para>To be useful across a wide range of contexts, this class provides many adjustable parameters and extensibility hooks. However, programmers are urged to use the more convenient Executors factory methods Executors#newCachedThreadPool (unbounded thread pool, with automatic thread reclamation), Executors#newFixedThreadPool (fixed size thread pool) and Executors#newSingleThreadExecutor (single background thread), that preconfigure settings for the most common usage scenarios. Otherwise, use the following guide when manually configuring and tuning this class:</para> <para></para> <para> <b>Extension example</b>. Most extensions of this class override one or more of the protected hook methods. For example, here is a subclass that adds a simple pause/resume feature:</para> <para> <pre>class PausableThreadPoolExecutor extends ThreadPoolExecutor {
		/// 
		///   private boolean isPaused;
		/// 
		///   private ReentrantLock pauseLock = new ReentrantLock();
		/// 
		///   private Condition unpaused = pauseLock.newCondition();
		/// 
		/// 
		/// 
		///   public PausableThreadPoolExecutor(...) { super(...); }
		/// 
		/// 
		/// 
		///   protected void beforeExecute(Thread t, Runnable r) {
		/// 
		///     super.beforeExecute(t, r);
		/// 
		///     pauseLock.lock();
		/// 
		///     try {
		/// 
		///       while (isPaused) unpaused.await();
		/// 
		///     } catch (InterruptedException ie) {
		/// 
		///       t.interrupt();
		/// 
		///     } finally {
		/// 
		///       pauseLock.unlock();
		/// 
		///     }
		/// 
		///   }
		/// 
		/// 
		/// 
		///   public void pause() {
		/// 
		///     pauseLock.lock();
		/// 
		///     try {
		/// 
		///       isPaused = true;
		/// 
		///     } finally {
		/// 
		///       pauseLock.unlock();
		/// 
		///     }
		/// 
		///   }
		/// 
		/// 
		/// 
		///   public void resume() {
		/// 
		///     pauseLock.lock();
		/// 
		///     try {
		/// 
		///       isPaused = false;
		/// 
		///       unpaused.signalAll();
		/// 
		///     } finally {
		/// 
		///       pauseLock.unlock();
		/// 
		///     }
		/// 
		///   }
		/// 
		/// } 
		/// 
		///  </pre></para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/ThreadPoolExecutor
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/ThreadPoolExecutor", AccessFlags = 33)]
		public partial class ThreadPoolExecutor : global::Java.Util.Concurrent.AbstractExecutorService
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>ThreadPoolExecutor </c> with the given initial parameters and default thread factory and rejected execution handler. It may be more convenient to use one of the Executors factory methods instead of this general purpose constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V", AccessFlags = 1, Signature = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue<Ljava/lang" +
    "/Runnable;>;)V")]
				public ThreadPoolExecutor(int corePoolSize, int maximumPoolSize, long keepAliveTime, global::Java.Util.Concurrent.TimeUnit unit, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> workQueue) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Creates a new <c>ThreadPoolExecutor </c> with the given initial parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util" +
    "/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1, Signature = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue<Ljava/lang" +
    "/Runnable;>;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedEx" +
    "ecutionHandler;)V")]
				public ThreadPoolExecutor(int corePoolSize, int maximumPoolSize, long keepAliveTime, global::Java.Util.Concurrent.TimeUnit unit, global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> workQueue, global::Java.Util.Concurrent.IThreadFactory threadFactory, global::Java.Util.Concurrent.IRejectedExecutionHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Executes the given task sometime in the future. The task may execute in a new thread or in an existing pooled thread.</para> <para>If the task cannot be submitted for execution, either because this executor has been shutdown or because its capacity has been reached, the task is handled by the current <c>RejectedExecutionHandler </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public override void Execute(global::Java.Lang.IRunnable command) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initiates an orderly shutdown in which previously submitted tasks are executed, but no new tasks will be accepted. Invocation has no additional effect if already shut down.</para> <para>This method does not wait for previously submitted tasks to complete execution. Use awaitTermination to do that. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public override void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to stop all actively executing tasks, halts the processing of waiting tasks, and returns a list of the tasks that were awaiting execution. These tasks are drained (removed) from the task queue upon return from this method.</para> <para>This method does not wait for actively executing tasks to terminate. Use awaitTermination to do that.</para> <para>There are no guarantees beyond best-effort attempts to stop processing actively executing tasks. This implementation cancels tasks via Thread#interrupt, so any task that fails to respond to interrupts may never terminate. </para>        
				/// </summary>
				/// <java-name>
				/// shutdownNow
				/// </java-name>
				[Dot42.DexImport("shutdownNow", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Runnable;>;")]
				public override global::Java.Util.IList<global::Java.Lang.IRunnable> ShutdownNow() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.IRunnable>);
				}

				/// <summary>
				///  <para>Blocks until all tasks have completed execution after a shutdown request, or the timeout occurs, or the current thread is interrupted, whichever happens first.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this executor terminated and  <c>false </c> if the timeout elapsed before termination </para>
				/// </returns>
				/// <java-name>
				/// awaitTermination
				/// </java-name>
				[Dot42.DexImport("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", AccessFlags = 1)]
				public override bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Invokes <c>shutdown </c> when this executor is no longer referenced and it has no threads. </para>        
				/// </summary>
				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ThreadPoolExecutor() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Starts a core thread, causing it to idly wait for work. This overrides the default policy of starting core threads only when new tasks are executed. This method will return <c>false </c> if all core threads have already been started.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a thread was started </para>
				/// </returns>
				/// <java-name>
				/// prestartCoreThread
				/// </java-name>
				[Dot42.DexImport("prestartCoreThread", "()Z", AccessFlags = 1)]
				public virtual bool PrestartCoreThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Starts all core threads, causing them to idly wait for work. This overrides the default policy of starting core threads only when new tasks are executed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of threads started </para>
				/// </returns>
				/// <java-name>
				/// prestartAllCoreThreads
				/// </java-name>
				[Dot42.DexImport("prestartAllCoreThreads", "()I", AccessFlags = 1)]
				public virtual int PrestartAllCoreThreads() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns true if this pool allows core threads to time out and terminate if no tasks arrive within the keepAlive time, being replaced if needed when new tasks arrive. When true, the same keep-alive policy applying to non-core threads applies also to core threads. When false (the default), core threads are never terminated due to lack of incoming tasks.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if core threads are allowed to time out, else <c>false </c></para>
				/// </returns>
				/// <java-name>
				/// allowsCoreThreadTimeOut
				/// </java-name>
				[Dot42.DexImport("allowsCoreThreadTimeOut", "()Z", AccessFlags = 1)]
				public virtual bool AllowsCoreThreadTimeOut() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the policy governing whether core threads may time out and terminate if no tasks arrive within the keep-alive time, being replaced if needed when new tasks arrive. When false, core threads are never terminated due to lack of incoming tasks. When true, the same keep-alive policy applying to non-core threads applies also to core threads. To avoid continual thread replacement, the keep-alive time must be greater than zero when setting <c>true </c> . This method should in general be called before the pool is actively used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// allowCoreThreadTimeOut
				/// </java-name>
				[Dot42.DexImport("allowCoreThreadTimeOut", "(Z)V", AccessFlags = 1)]
				public virtual void AllowCoreThreadTimeOut(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the time limit for which threads may remain idle before being terminated. If there are more than the core number of threads currently in the pool, after waiting this amount of time without processing a task, excess threads will be terminated. This overrides any value set in the constructor.</para> <para> <para>getKeepAliveTime(TimeUnit) </para></para>        
				/// </summary>
				/// <java-name>
				/// setKeepAliveTime
				/// </java-name>
				[Dot42.DexImport("setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V", AccessFlags = 1)]
				public virtual void SetKeepAliveTime(long time, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the thread keep-alive time, which is the amount of time that threads in excess of the core pool size may remain idle before being terminated.</para> <para> <para>setKeepAliveTime(long, TimeUnit) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time limit </para>
				/// </returns>
				/// <java-name>
				/// getKeepAliveTime
				/// </java-name>
				[Dot42.DexImport("getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J", AccessFlags = 1)]
				public virtual long GetKeepAliveTime(global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Removes this task from the executor's internal queue if it is present, thus causing it not to be run if it has not already started.</para> <para>This method may be useful as one part of a cancellation scheme. It may fail to remove tasks that have been converted into other forms before being placed on the internal queue. For example, a task entered using <c>submit </c> might be converted into a form that maintains <c>Future </c> status. However, in such cases, method purge may be used to remove those Futures that have been cancelled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the task was removed </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Runnable;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::Java.Lang.IRunnable task) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Tries to remove from the work queue all Future tasks that have been cancelled. This method can be useful as a storage reclamation operation, that has no other impact on functionality. Cancelled tasks are never executed, but may accumulate in work queues until worker threads can actively remove them. Invoking this method instead tries to remove them now. However, this method may fail to remove tasks in the presence of interference by other threads. </para>        
				/// </summary>
				/// <java-name>
				/// purge
				/// </java-name>
				[Dot42.DexImport("purge", "()V", AccessFlags = 1)]
				public virtual void Purge() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string identifying this pool, as well as its state, including indications of run state and estimated worker and task counts.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string identifying this pool, as well as its state </para>
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
				///  <para>Method invoked prior to executing the given Runnable in the given thread. This method is invoked by thread <c>t </c> that will execute task <c>r </c> , and may be used to re-initialize ThreadLocals, or to perform logging.</para> <para>This implementation does nothing, but may be customized in subclasses. Note: To properly nest multiple overridings, subclasses should generally invoke <c>super.beforeExecute </c> at the end of this method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// beforeExecute
				/// </java-name>
				[Dot42.DexImport("beforeExecute", "(Ljava/lang/Thread;Ljava/lang/Runnable;)V", AccessFlags = 4)]
				protected internal virtual void BeforeExecute(global::System.Threading.Thread t, global::Java.Lang.IRunnable r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Method invoked upon completion of execution of the given Runnable. This method is invoked by the thread that executed the task. If non-null, the Throwable is the uncaught <c>RuntimeException </c> or <c>Error </c> that caused execution to terminate abruptly.</para> <para>This implementation does nothing, but may be customized in subclasses. Note: To properly nest multiple overridings, subclasses should generally invoke <c>super.afterExecute </c> at the beginning of this method.</para> <para> <b>Note:</b> When actions are enclosed in tasks (such as FutureTask) either explicitly or via methods such as  <c>submit </c> , these task objects catch and maintain computational exceptions, and so they do not cause abrupt termination, and the internal exceptions are  <b>not</b> passed to this method. If you would like to trap both kinds of failures in this method, you can further probe for such cases, as in this sample subclass that prints either the direct cause or the underlying exception if a task has been aborted:</para> <para> <pre>class ExtendedExecutor extends ThreadPoolExecutor {
				/// 
				///   // ...
				/// 
				///   protected void afterExecute(Runnable r, Throwable t) {
				/// 
				///     super.afterExecute(r, t);
				/// 
				///     if (t == null &amp;&amp; r instanceof Future&lt;?&gt;) {
				/// 
				///       try {
				/// 
				///         Object result = ((Future&lt;?&gt;) r).get();
				/// 
				///       } catch (CancellationException ce) {
				/// 
				///           t = ce;
				/// 
				///       } catch (ExecutionException ee) {
				/// 
				///           t = ee.getCause();
				/// 
				///       } catch (InterruptedException ie) {
				/// 
				///           Thread.currentThread().interrupt(); // ignore/reset
				/// 
				///       }
				/// 
				///     }
				/// 
				///     if (t != null)
				/// 
				///       System.out.println(t);
				/// 
				///   }
				/// 
				/// } 
				/// 
				///  </pre></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// afterExecute
				/// </java-name>
				[Dot42.DexImport("afterExecute", "(Ljava/lang/Runnable;Ljava/lang/Throwable;)V", AccessFlags = 4)]
				protected internal virtual void AfterExecute(global::Java.Lang.IRunnable r, global::System.Exception t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Method invoked when the Executor has terminated. Default implementation does nothing. Note: To properly nest multiple overridings, subclasses should generally invoke  <c>super.terminated </c> within this method. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns <c>true </c> if this executor has been shut down.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this executor has been shut down </para>
				/// </returns>
				/// <java-name>
				/// isShutdown
				/// </java-name>
				public override bool IsShutdown
				{
						[Dot42.DexImport("isShutdown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if this executor is in the process of terminating after shutdown or shutdownNow but has not completely terminated. This method may be useful for debugging. A return of <c>true </c> reported a sufficient period after shutdown may indicate that submitted tasks have ignored or suppressed interruption, causing this executor not to properly terminate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if terminating but not yet terminated </para>
				/// </returns>
				/// <java-name>
				/// isTerminating
				/// </java-name>
				public virtual bool IsTerminating
				{
						[Dot42.DexImport("isTerminating", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns <c>true </c> if all tasks have completed following shut down. Note that <c>isTerminated </c> is never <c>true </c> unless either <c>shutdown </c> or <c>shutdownNow </c> was called first.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all tasks have completed following shut down </para>
				/// </returns>
				/// <java-name>
				/// isTerminated
				/// </java-name>
				public override bool IsTerminated
				{
						[Dot42.DexImport("isTerminated", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the thread factory used to create new threads.</para> <para> <para>setThreadFactory(ThreadFactory) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current thread factory </para>
				/// </returns>
				/// <java-name>
				/// getThreadFactory
				/// </java-name>
				public virtual global::Java.Util.Concurrent.IThreadFactory ThreadFactory
				{
						[Dot42.DexImport("getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Concurrent.IThreadFactory); }
						[Dot42.DexImport("setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current handler for unexecutable tasks.</para> <para> <para>setRejectedExecutionHandler(RejectedExecutionHandler) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current handler </para>
				/// </returns>
				/// <java-name>
				/// getRejectedExecutionHandler
				/// </java-name>
				public virtual global::Java.Util.Concurrent.IRejectedExecutionHandler RejectedExecutionHandler
				{
						[Dot42.DexImport("getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Concurrent.IRejectedExecutionHandler); }
						[Dot42.DexImport("setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the core number of threads.</para> <para> <para>setCorePoolSize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the core number of threads </para>
				/// </returns>
				/// <java-name>
				/// getCorePoolSize
				/// </java-name>
				public virtual int CorePoolSize
				{
						[Dot42.DexImport("getCorePoolSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCorePoolSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the maximum allowed number of threads.</para> <para> <para>setMaximumPoolSize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum allowed number of threads </para>
				/// </returns>
				/// <java-name>
				/// getMaximumPoolSize
				/// </java-name>
				public virtual int MaximumPoolSize
				{
						[Dot42.DexImport("getMaximumPoolSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaximumPoolSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the task queue used by this executor. Access to the task queue is intended primarily for debugging and monitoring. This queue may be in active use. Retrieving the task queue does not prevent queued tasks from executing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the task queue </para>
				/// </returns>
				/// <java-name>
				/// getQueue
				/// </java-name>
				public virtual global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable> Queue
				{
						[Dot42.DexImport("getQueue", "()Ljava/util/concurrent/BlockingQueue;", AccessFlags = 1, Signature = "()Ljava/util/concurrent/BlockingQueue<Ljava/lang/Runnable;>;")]
						get{ return default(global::Java.Util.Concurrent.IBlockingQueue<global::Java.Lang.IRunnable>); }
				}

				/// <summary>
				///  <para>Returns the current number of threads in the pool.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of threads </para>
				/// </returns>
				/// <java-name>
				/// getPoolSize
				/// </java-name>
				public virtual int PoolSize
				{
						[Dot42.DexImport("getPoolSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the approximate number of threads that are actively executing tasks.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of threads </para>
				/// </returns>
				/// <java-name>
				/// getActiveCount
				/// </java-name>
				public virtual int ActiveCount
				{
						[Dot42.DexImport("getActiveCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the largest number of threads that have ever simultaneously been in the pool.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of threads </para>
				/// </returns>
				/// <java-name>
				/// getLargestPoolSize
				/// </java-name>
				public virtual int LargestPoolSize
				{
						[Dot42.DexImport("getLargestPoolSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the approximate total number of tasks that have ever been scheduled for execution. Because the states of tasks and threads may change dynamically during computation, the returned value is only an approximation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of tasks </para>
				/// </returns>
				/// <java-name>
				/// getTaskCount
				/// </java-name>
				public virtual long TaskCount
				{
						[Dot42.DexImport("getTaskCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the approximate total number of tasks that have completed execution. Because the states of tasks and threads may change dynamically during computation, the returned value is only an approximation, but one that does not ever decrease across successive calls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of tasks </para>
				/// </returns>
				/// <java-name>
				/// getCompletedTaskCount
				/// </java-name>
				public virtual long CompletedTaskCount
				{
						[Dot42.DexImport("getCompletedTaskCount", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>A handler for rejected tasks that discards the oldest unhandled request and then retries <c>execute </c> , unless the executor is shut down, in which case the task is discarded. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Obtains and ignores the next task that the executor would otherwise execute, if one is immediately available, and then retries execution of task r, unless the executor is shut down, in which case task r is instead discarded.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable r, global::Java.Util.Concurrent.ThreadPoolExecutor e) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>A handler for rejected tasks that silently discards the rejected task. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Does nothing, which has the effect of discarding task r.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable r, global::Java.Util.Concurrent.ThreadPoolExecutor e) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>A handler for rejected tasks that throws a  <c>RejectedExecutionException </c> . </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Always throws RejectedExecutionException.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable r, global::Java.Util.Concurrent.ThreadPoolExecutor e) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>A handler for rejected tasks that runs the rejected task directly in the calling thread of the <c>execute </c> method, unless the executor has been shut down, in which case the task is discarded. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Executes task r in the caller's thread, unless the executor has been shut down, in which case the task is discarded.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// rejectedExecution
						/// </java-name>
						[Dot42.DexImport("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", AccessFlags = 1)]
						public virtual void RejectedExecution(global::Java.Lang.IRunnable r, global::Java.Util.Concurrent.ThreadPoolExecutor e) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Exception thrown when a blocking operation times out. Blocking operations for which a timeout is specified need a means to indicate that the timeout has occurred. For many such operations it is possible to return a value that indicates timeout; when that is not possible or desirable then <c>TimeoutException </c> should be declared and thrown.</para> <para> <para>1.5 </para> <para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/TimeoutException
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/TimeoutException", AccessFlags = 33)]
		public partial class TimeoutException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>TimeoutException </c> with no specified detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeoutException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>TimeoutException </c> with the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TimeoutException(string message) /* MethodBuilder.Create */ 
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

