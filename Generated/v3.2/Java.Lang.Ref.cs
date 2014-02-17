// Copyright (C) 2014 dot42
//
// Original filename: Java.Lang.Ref.cs
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
namespace Java.Lang.Ref
{
		/// <summary>
		/// <para>Provides an abstract class which describes behavior common to all reference objects. It is not possible to create immediate subclasses of <c> Reference </c> in addition to the ones provided by this package. It is also not desirable to do so, since references require very close cooperation with the system's garbage collector. The existing, specialized reference classes should be used instead.</para><para>Three different type of references exist, each being weaker than the preceding one: java.lang.ref.SoftReference, java.lang.ref.WeakReference, and java.lang.ref.PhantomReference. "Weakness" here means that less restrictions are being imposed on the garbage collector as to when it is allowed to actually garbage-collect the referenced object.</para><para>In order to use reference objects properly it is important to understand the different types of reachability that trigger their clearing and enqueueing. The following table lists these, from strongest to weakest. For each row, an object is said to have the reachability on the left side if (and only if) it fulfills all of the requirements on the right side. In all rows, consider the <b>root set</b> to be a set of references that are "resistant" to garbage collection (that is, running threads, method parameters, local variables, static fields and the like).</para><para><table><row><entry><para>Strongly reachable </para></entry><entry><para><ul><li><para>There exists at least one path from the root set to the object that does not traverse any instance of a <c> java.lang.ref.Reference </c> subclass.  </para></li></ul></para><para></para></entry></row><row><entry><para>Softly reachable </para></entry><entry><para><ul><li><para>The object is not strongly reachable. </para></li><li><para>There exists at least one path from the root set to the object that does traverse a <c> java.lang.ref.SoftReference </c> instance, but no <c> java.lang.ref.WeakReference </c> or <c> java.lang.ref.PhantomReference </c> instances. </para></li></ul></para><para></para></entry></row><row><entry><para>Weakly reachable </para></entry><entry><para><ul><li><para>The object is neither strongly nor softly reachable. </para></li><li><para>There exists at least one path from the root set to the object that does traverse a <c> java.lang.ref.WeakReference </c> instance, but no <c> java.lang.ref.PhantomReference </c> instances. </para></li></ul></para><para></para></entry></row><row><entry><para>Phantom-reachable </para></entry><entry><para><ul><li><para>The object is neither strongly, softly, nor weakly reachable. </para></li><li><para>The object is referenced by a <c> java.lang.ref.PhantomReference </c> instance. </para></li><li><para>The object has already been finalized. </para></li></ul></para></entry></row></table></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ref/Reference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/Reference", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Reference<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Reference() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Makes the referent <c> null </c> . This does not force the reference object to be enqueued. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Forces the reference object to be enqueued if it has been associated with a queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this call has caused the <c> Reference </c> to become enqueued, or <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// enqueue
				/// </java-name>
				[Dot42.DexImport("enqueue", "()Z", AccessFlags = 1)]
				public virtual bool Enqueue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the referent of the reference object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the referent to which reference refers, or <c> null </c> if the object has been cleared. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public virtual T Get() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Checks whether the reference object has been enqueued.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the <c> Reference </c> has been enqueued, <c>               false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isEnqueued
				/// </java-name>
				[Dot42.DexImport("isEnqueued", "()Z", AccessFlags = 1)]
				public virtual bool IsEnqueued() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>The <c> ReferenceQueue </c> is the container on which reference objects are enqueued when the garbage collector detects the reachability type specified for the referent.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ref/ReferenceQueue
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/ReferenceQueue", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class ReferenceQueue<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReferenceQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the next available reference from the queue, removing it in the process. Does not wait for a reference to become available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next available reference, or <c> null </c> if no reference is immediately available </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/ref/Reference;", AccessFlags = 33, Signature = "()Ljava/lang/ref/Reference<+TT;>;")]
				public virtual global::Java.Lang.Ref.Reference<T> Poll() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Ref.Reference<T>);
				}

				/// <summary>
				/// <para>Returns the next available reference from the queue, removing it in the process. Waits indefinitely for a reference to become available.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/ref/Reference;", AccessFlags = 1, Signature = "()Ljava/lang/ref/Reference<+TT;>;")]
				public virtual global::Java.Lang.Ref.Reference<T> Remove() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Ref.Reference<T>);
				}

				/// <summary>
				/// <para>Returns the next available reference from the queue, removing it in the process. Waits for a reference to become available or the given timeout period to elapse, whichever happens first.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next available reference, or <c> null </c> if no reference becomes available within the timeout period </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(J)Ljava/lang/ref/Reference;", AccessFlags = 33, Signature = "(J)Ljava/lang/ref/Reference<+TT;>;")]
				public virtual global::Java.Lang.Ref.Reference<T> Remove(long timeoutMillis) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Ref.Reference<T>);
				}

		}

		/// <summary>
		/// <para>Implements a phantom reference, which is the weakest of the three types of references. Once the garbage collector decides that an object <c> obj </c> is phantom-reachable, it is being enqueued on the corresponding queue, but its referent is not cleared. That is, the reference queue of the phantom reference must explicitly be processed by some application code. As a consequence, a phantom reference that is not registered with any reference queue does not make any sense. </para><para>Phantom references are useful for implementing cleanup operations that are necessary before an object gets garbage-collected. They are sometimes more flexible than the Object#finalize() method. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ref/PhantomReference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/PhantomReference", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ref/Reference<TT;>;")]
		public partial class PhantomReference<T> : global::Java.Lang.Ref.Reference<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new phantom reference and registers it with the given reference queue. The reference queue may be <c> null </c> , but this case does not make any sense, since the reference will never be enqueued, and the get() method always returns <c> null </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(TT;Ljava/lang/ref/ReferenceQueue<-TT;>;)V")]
				public PhantomReference(T r, global::Java.Lang.Ref.ReferenceQueue<T> q) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns <c> null </c> . The referent of a phantom reference is not accessible.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> null </c> (always) </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public override T Get() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PhantomReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A reference that is cleared when its referent is not strongly reachable and there is memory pressure.</para><para><h3>Avoid Soft References for Caching</h3></para><para>In practice, soft references are inefficient for caching. The runtime doesn't have enough information on which references to clear and which to keep. Most fatally, it doesn't know what to do when given the choice between clearing a soft reference and growing the heap.</para><para>The lack of information on the value to your application of each reference limits the usefulness of soft references. References that are cleared too early cause unnecessary work; those that are cleared too late waste memory.</para><para>Most applications should use an <c> android.util.LruCache </c> instead of soft references. LruCache has an effective eviction policy and lets the user tune how much memory is allotted.</para><para><h3>Garbage Collection of Soft References</h3></para><para>When the garbage collector encounters an object <c> obj </c> that is softly-reachable, the following happens: <ul><li><para>A set <c> refs </c> of references is determined. <c> refs </c> contains the following elements: <ul><li><para>All soft references pointing to <c> obj </c> . </para></li><li><para>All soft references pointing to objects from which <c> obj </c> is strongly reachable. </para></li></ul></para></li><li><para>All references in <c> refs </c> are atomically cleared. </para></li><li><para>At the same time or some time in the future, all references in <c>         refs </c> will be enqueued with their corresponding reference queues, if any. </para></li></ul>The system may delay clearing and enqueueing soft references, yet all <c>   SoftReference </c> s pointing to softly reachable objects will be cleared before the runtime throws an OutOfMemoryError.</para><para>Unlike a <c> WeakReference </c> , a <c> SoftReference </c> will not be cleared and enqueued until the runtime must reclaim memory to satisfy an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ref/SoftReference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/SoftReference", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ref/Reference<TT;>;")]
		public partial class SoftReference<T> : global::Java.Lang.Ref.Reference<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new soft reference to the given referent. The newly created reference is not registered with any reference queue.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public SoftReference(T r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new soft reference to the given referent. The newly created reference is registered with the given reference queue.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(TT;Ljava/lang/ref/ReferenceQueue<-TT;>;)V")]
				public SoftReference(T r, global::Java.Lang.Ref.ReferenceQueue<T> q) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SoftReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Implements a weak reference, which is the middle of the three types of references. Once the garbage collector decides that an object <c> obj </c> is is weakly-reachable, the following happens:</para><para><ul><li><para>A set <c> ref </c> of references is determined. <c> ref </c> contains the following elements: <ul><li><para>All weak references pointing to <c> obj </c> .  </para></li><li><para>All weak references pointing to objects from which <c> obj </c> is either strongly or softly reachable.  </para></li></ul></para></li><li><para>All references in <c> ref </c> are atomically cleared.  </para></li><li><para>All objects formerly being referenced by <c> ref </c> become eligible for finalization.  </para></li><li><para>At some future point, all references in <c> ref </c> will be enqueued with their corresponding reference queues, if any.  </para></li></ul></para><para>Weak references are useful for mappings that should have their entries removed automatically once they are not referenced any more (from outside). The difference between a <c> SoftReference </c> and a <c> WeakReference </c> is the point of time at which the decision is made to clear and enqueue the reference:</para><para><ul><li><para>A <c> SoftReference </c> should be cleared and enqueued <b>as late as possible</b>, that is, in case the VM is in danger of running out of memory.  </para></li><li><para>A <c> WeakReference </c> may be cleared and enqueued as soon as is known to be weakly-referenced.  </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ref/WeakReference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/WeakReference", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ref/Reference<TT;>;")]
		public partial class WeakReference<T> : global::Java.Lang.Ref.Reference<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new weak reference to the given referent. The newly created reference is not registered with any reference queue.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public WeakReference(T r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new weak reference to the given referent. The newly created reference is registered with the given reference queue.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(TT;Ljava/lang/ref/ReferenceQueue<-TT;>;)V")]
				public WeakReference(T r, global::Java.Lang.Ref.ReferenceQueue<T> q) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WeakReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


