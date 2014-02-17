// Copyright (C) 2014 dot42
//
// Original filename: Java.Util.Concurrent.Atomic.cs
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
namespace Java.Util.Concurrent.Atomic
{
		/// <summary>
		/// <para>A reflection-based utility that enables atomic updates to designated <c> volatile long </c> fields of designated classes. This class is designed for use in atomic data structures in which several fields of the same node are independently subject to atomic updates.</para><para>Note that the guarantees of the <c> compareAndSet </c> method in this class are weaker than in other atomic classes. Because this class cannot ensure that all uses of the field are appropriate for purposes of atomic access, it can guarantee atomicity only with respect to other invocations of <c> compareAndSet </c> and <c> set </c> on the same updater.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicLongFieldUpdater
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicLongFieldUpdater", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class AtomicLongFieldUpdater<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected do-nothing constructor for use by subclasses. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AtomicLongFieldUpdater() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates and returns an updater for objects with the given field. The Class argument is needed to check that reflective types and generic types match.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updater </para>
				/// </returns>
				/// <java-name>
				/// newUpdater
				/// </java-name>
				[Dot42.DexImport("newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongField" +
    "Updater;", AccessFlags = 9, Signature = "<U:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;Ljava/lang/String;)Ljava/util/concur" +
    "rent/atomic/AtomicLongFieldUpdater<TU;>;")]
				public static global::Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<U> NewUpdater<U>(global::System.Type tclass, string fieldName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<U>);
				}

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given updated value if the current value <c> == </c> the expected value. This method is guaranteed to be atomic with respect to other calls to <c> compareAndSet </c> and <c> set </c> , but not necessarily with respect to other changes in the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;JJ)Z", AccessFlags = 1025, Signature = "(TT;JJ)Z")]
				public abstract bool CompareAndSet(T obj, long expect, long update) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given updated value if the current value <c> == </c> the expected value. This method is guaranteed to be atomic with respect to other calls to <c> compareAndSet </c> and <c> set </c> , but not necessarily with respect to other changes in the field.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;JJ)Z", AccessFlags = 1025, Signature = "(TT;JJ)Z")]
				public abstract bool WeakCompareAndSet(T obj, long expect, long update) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the field of the given object managed by this updater to the given updated value. This operation is guaranteed to act as a volatile store with respect to subsequent invocations of <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;J)V", AccessFlags = 1025, Signature = "(TT;J)V")]
				public abstract void Set(T obj, long newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Eventually sets the field of the given object managed by this updater to the given updated value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;J)V", AccessFlags = 1025, Signature = "(TT;J)V")]
				public abstract void LazySet(T obj, long newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current value held in the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)J", AccessFlags = 1025, Signature = "(TT;)J")]
				public abstract long Get(T obj) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;J)J", AccessFlags = 1, Signature = "(TT;J)J")]
				public virtual long GetAndSet(T obj, long newValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long GetAndIncrement(T obj) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long GetAndDecrement(T obj) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(Ljava/lang/Object;J)J", AccessFlags = 1, Signature = "(TT;J)J")]
				public virtual long GetAndAdd(T obj, long delta) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long IncrementAndGet(T obj) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long DecrementAndGet(T obj) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(Ljava/lang/Object;J)J", AccessFlags = 1, Signature = "(TT;J)J")]
				public virtual long AddAndGet(T obj, long delta) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		/// <para>A <c> long </c> array in which elements may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. <para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicLongArray
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicLongArray", AccessFlags = 33)]
		public partial class AtomicLongArray : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AtomicLongArray of the given length, with all elements initially zero.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicLongArray(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AtomicLongArray of the given length, with all elements initially zero.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([J)V", AccessFlags = 1)]
				public AtomicLongArray(long[] length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the array </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the current value at position <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)J", AccessFlags = 17)]
				public long Get(int i) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the element at position <c> i </c> to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IJ)V", AccessFlags = 17)]
				public void Set(int i, long newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets the element at position <c> i </c> to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(IJ)V", AccessFlags = 17)]
				public void LazySet(int i, long newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(IJ)J", AccessFlags = 17)]
				public long GetAndSet(int i, long newValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given updated value if the current value <c> == </c> the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(IJJ)Z", AccessFlags = 17)]
				public bool CompareAndSet(int i, long expect, long update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(IJJ)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(int i, long expect, long update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically increments by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(I)J", AccessFlags = 17)]
				public long GetAndIncrement(int i) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically decrements by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(I)J", AccessFlags = 17)]
				public long GetAndDecrement(int i) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(IJ)J", AccessFlags = 17)]
				public long GetAndAdd(int i, long delta) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically increments by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(I)J", AccessFlags = 17)]
				public long IncrementAndGet(int i) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically decrements by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(I)J", AccessFlags = 17)]
				public long DecrementAndGet(int i) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(IJ)J", AccessFlags = 1)]
				public virtual long AddAndGet(int i, long delta) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the String representation of the current values of array. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current values of array </para>
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
				internal AtomicLongArray() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> AtomicMarkableReference </c> maintains an object reference along with a mark bit, that can be updated atomically.</para><para>Implementation note: This implementation maintains markable references by creating internal objects representing "boxed" [reference, boolean] pairs.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicMarkableReference
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicMarkableReference", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class AtomicMarkableReference<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> AtomicMarkableReference </c> with the given initial values.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Z)V", AccessFlags = 1, Signature = "(TV;Z)V")]
				public AtomicMarkableReference(V initialRef, bool initialMark) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of the reference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the reference </para>
				/// </returns>
				/// <java-name>
				/// getReference
				/// </java-name>
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
				public virtual V GetReference() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns the current value of the mark.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the mark </para>
				/// </returns>
				/// <java-name>
				/// isMarked
				/// </java-name>
				[Dot42.DexImport("isMarked", "()Z", AccessFlags = 1)]
				public virtual bool IsMarked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the current values of both the reference and the mark. Typical usage is <c> boolean[1] holder; ref = v.get(holder);  </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the reference </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([Z)Ljava/lang/Object;", AccessFlags = 1, Signature = "([Z)TV;")]
				public virtual V Get(bool[] markHolder) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Atomically sets the value of both the reference and mark to the given update values if the current reference is <c> == </c> to the expected reference and the current mark is equal to the expected mark.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", AccessFlags = 1, Signature = "(TV;TV;ZZ)Z")]
				public virtual bool WeakCompareAndSet(V expectedReference, V newReference, bool expectedMark, bool newMark) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value of both the reference and mark to the given update values if the current reference is <c> == </c> to the expected reference and the current mark is equal to the expected mark.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", AccessFlags = 1, Signature = "(TV;TV;ZZ)Z")]
				public virtual bool CompareAndSet(V expectedReference, V newReference, bool expectedMark, bool newMark) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unconditionally sets the value of both the reference and mark.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Z)V", AccessFlags = 1, Signature = "(TV;Z)V")]
				public virtual void Set(V newReference, bool newMark) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets the value of the mark to the given update value if the current reference is <c> == </c> to the expected reference. Any given invocation of this operation may fail (return <c> false </c> ) spuriously, but repeated invocation when the current value holds the expected value and no other thread is also attempting to set the value will eventually succeed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// attemptMark
				/// </java-name>
				[Dot42.DexImport("attemptMark", "(Ljava/lang/Object;Z)Z", AccessFlags = 1, Signature = "(TV;Z)Z")]
				public virtual bool AttemptMark(V expectedReference, bool newMark) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AtomicMarkableReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of the reference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the reference </para>
				/// </returns>
				/// <java-name>
				/// getReference
				/// </java-name>
				public V Reference
				{
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
						get{ return GetReference(); }
				}

		}

		/// <summary>
		/// <para>A reflection-based utility that enables atomic updates to designated <c> volatile </c> reference fields of designated classes. This class is designed for use in atomic data structures in which several reference fields of the same node are independently subject to atomic updates. For example, a tree node might be declared as</para><para><pre>    class Node {
		/// 
		///      private volatile Node left, right;
		/// 
		///   
		/// 
		///      private static final AtomicReferenceFieldUpdater&lt;Node, Node&gt; leftUpdater =
		/// 
		///        AtomicReferenceFieldUpdater.newUpdater(Node.class, Node.class, "left");
		/// 
		///      private static AtomicReferenceFieldUpdater&lt;Node, Node&gt; rightUpdater =
		/// 
		///        AtomicReferenceFieldUpdater.newUpdater(Node.class, Node.class, "right");
		/// 
		///   
		/// 
		///      Node getLeft() { return left;  }
		/// 
		///      boolean compareAndSetLeft(Node expect, Node update) {
		/// 
		///        return leftUpdater.compareAndSet(this, expect, update);
		/// 
		///      }
		/// 
		///      // ... and so on
		/// 
		///    } 
		/// 
		///  </pre></para><para>Note that the guarantees of the <c> compareAndSet </c> method in this class are weaker than in other atomic classes. Because this class cannot ensure that all uses of the field are appropriate for purposes of atomic access, it can guarantee atomicity only with respect to other invocations of <c> compareAndSet </c> and <c> set </c> on the same updater.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicReferenceFieldUpdater
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicReferenceFieldUpdater", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class AtomicReferenceFieldUpdater<T, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected do-nothing constructor for use by subclasses. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AtomicReferenceFieldUpdater() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates and returns an updater for objects with the given field. The Class arguments are needed to check that reflective types and generic types match.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updater </para>
				/// </returns>
				/// <java-name>
				/// newUpdater
				/// </java-name>
				[Dot42.DexImport("newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomi" +
    "c/AtomicReferenceFieldUpdater;", AccessFlags = 9, Signature = "<U:Ljava/lang/Object;W:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;Ljava/lang/Class" +
    "<TW;>;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdate" +
    "r<TU;TW;>;")]
				public static global::Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<U, W> NewUpdater<U, W>(global::System.Type tclass, global::System.Type vclass, string fieldName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<U, W>);
				}

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given updated value if the current value <c> == </c> the expected value. This method is guaranteed to be atomic with respect to other calls to <c> compareAndSet </c> and <c> set </c> , but not necessarily with respect to other changes in the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TT;TV;TV;)Z")]
				public abstract bool CompareAndSet(T obj, V expect, V update) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given updated value if the current value <c> == </c> the expected value. This method is guaranteed to be atomic with respect to other calls to <c> compareAndSet </c> and <c> set </c> , but not necessarily with respect to other changes in the field.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TT;TV;TV;)Z")]
				public abstract bool WeakCompareAndSet(T obj, V expect, V update) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the field of the given object managed by this updater to the given updated value. This operation is guaranteed to act as a volatile store with respect to subsequent invocations of <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TT;TV;)V")]
				public abstract void Set(T obj, V newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Eventually sets the field of the given object managed by this updater to the given updated value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TT;TV;)V")]
				public abstract void LazySet(T obj, V newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current value held in the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TT;)TV;")]
				public abstract V Get(T obj) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TT;TV;)TV;")]
				public virtual V GetAndSet(T obj, V newValue) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

		}

		/// <summary>
		/// <para>An array of object references in which elements may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. <para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicReferenceArray
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicReferenceArray", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
		public partial class AtomicReferenceArray<E> : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AtomicReferenceArray of the given length, with all elements initially null.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicReferenceArray(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AtomicReferenceArray of the given length, with all elements initially null.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/Object;)V", AccessFlags = 1, Signature = "([TE;)V")]
				public AtomicReferenceArray(E[] length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the array </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the current value at position <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 17, Signature = "(I)TE;")]
				public E Get(int i) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Sets the element at position <c> i </c> to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)V", AccessFlags = 17, Signature = "(ITE;)V")]
				public void Set(int i, E newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets the element at position <c> i </c> to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(ILjava/lang/Object;)V", AccessFlags = 17, Signature = "(ITE;)V")]
				public void LazySet(int i, E newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(ITE;)TE;")]
				public E GetAndSet(int i, E newValue) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given updated value if the current value <c> == </c> the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(ITE;TE;)Z")]
				public bool CompareAndSet(int i, E expect, E update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(ITE;TE;)Z")]
				public bool WeakCompareAndSet(int i, E expect, E update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the String representation of the current values of array. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current values of array </para>
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
				internal AtomicReferenceArray() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An object reference that may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. <para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicReference
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicReference", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
		public partial class AtomicReference<V> : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AtomicReference with the given initial value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TV;)V")]
				public AtomicReference(V initialValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AtomicReference with null initial value. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicReference() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 17, Signature = "()TV;")]
				public V Get() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Sets to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 17, Signature = "(TV;)V")]
				public void Set(V newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;)V", AccessFlags = 17, Signature = "(TV;)V")]
				public void LazySet(V newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(TV;TV;)Z")]
				public bool CompareAndSet(V expect, V update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(TV;TV;)Z")]
				public bool WeakCompareAndSet(V expect, V update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(TV;)TV;")]
				public V GetAndSet(V newValue) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns the String representation of the current value. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current value. </para>
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

		/// <summary>
		/// <para>A reflection-based utility that enables atomic updates to designated <c> volatile int </c> fields of designated classes. This class is designed for use in atomic data structures in which several fields of the same node are independently subject to atomic updates.</para><para>Note that the guarantees of the <c> compareAndSet </c> method in this class are weaker than in other atomic classes. Because this class cannot ensure that all uses of the field are appropriate for purposes of atomic access, it can guarantee atomicity only with respect to other invocations of <c> compareAndSet </c> and <c> set </c> on the same updater.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicIntegerFieldUpdater
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicIntegerFieldUpdater", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class AtomicIntegerFieldUpdater<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected do-nothing constructor for use by subclasses. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AtomicIntegerFieldUpdater() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates and returns an updater for objects with the given field. The Class argument is needed to check that reflective types and generic types match.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updater </para>
				/// </returns>
				/// <java-name>
				/// newUpdater
				/// </java-name>
				[Dot42.DexImport("newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFi" +
    "eldUpdater;", AccessFlags = 9, Signature = "<U:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;Ljava/lang/String;)Ljava/util/concur" +
    "rent/atomic/AtomicIntegerFieldUpdater<TU;>;")]
				public static global::Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<U> NewUpdater<U>(global::System.Type tclass, string fieldName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<U>);
				}

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given updated value if the current value <c> == </c> the expected value. This method is guaranteed to be atomic with respect to other calls to <c> compareAndSet </c> and <c> set </c> , but not necessarily with respect to other changes in the field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;II)Z", AccessFlags = 1025, Signature = "(TT;II)Z")]
				public abstract bool CompareAndSet(T obj, int expect, int update) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given updated value if the current value <c> == </c> the expected value. This method is guaranteed to be atomic with respect to other calls to <c> compareAndSet </c> and <c> set </c> , but not necessarily with respect to other changes in the field.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;II)Z", AccessFlags = 1025, Signature = "(TT;II)Z")]
				public abstract bool WeakCompareAndSet(T obj, int expect, int update) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the field of the given object managed by this updater to the given updated value. This operation is guaranteed to act as a volatile store with respect to subsequent invocations of <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;I)V", AccessFlags = 1025, Signature = "(TT;I)V")]
				public abstract void Set(T obj, int newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Eventually sets the field of the given object managed by this updater to the given updated value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;I)V", AccessFlags = 1025, Signature = "(TT;I)V")]
				public abstract void LazySet(T obj, int newValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current value held in the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)I", AccessFlags = 1025, Signature = "(TT;)I")]
				public abstract int Get(T obj) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Atomically sets the field of the given object managed by this updater to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TT;I)I")]
				public virtual int GetAndSet(T obj, int newValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int GetAndIncrement(T obj) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int GetAndDecrement(T obj) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TT;I)I")]
				public virtual int GetAndAdd(T obj, int delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int IncrementAndGet(T obj) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int DecrementAndGet(T obj) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value of the field of the given object managed by this updater.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TT;I)I")]
				public virtual int AddAndGet(T obj, int delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>A <c> boolean </c> value that may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. An <c> AtomicBoolean </c> is used in applications such as atomically updated flags, and cannot be used as a replacement for a java.lang.Boolean.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicBoolean
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicBoolean", AccessFlags = 33)]
		public partial class AtomicBoolean : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> AtomicBoolean </c> with the given initial value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public AtomicBoolean(bool initialValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> AtomicBoolean </c> with initial value <c> false </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicBoolean() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Z", AccessFlags = 17)]
				public bool Get() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(ZZ)Z", AccessFlags = 17)]
				public bool CompareAndSet(bool expect, bool update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool WeakCompareAndSet(bool expect, bool update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unconditionally sets to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Z)V", AccessFlags = 17)]
				public void Set(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Z)V", AccessFlags = 17)]
				public void LazySet(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets to the given value and returns the previous value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Z)Z", AccessFlags = 17)]
				public bool GetAndSet(bool newValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the String representation of the current value. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current value. </para>
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

		/// <summary>
		/// <para>An <c> AtomicStampedReference </c> maintains an object reference along with an integer "stamp", that can be updated atomically.</para><para>Implementation note: This implementation maintains stamped references by creating internal objects representing "boxed" [reference, integer] pairs.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicStampedReference
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicStampedReference", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class AtomicStampedReference<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> AtomicStampedReference </c> with the given initial values.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;I)V", AccessFlags = 1, Signature = "(TV;I)V")]
				public AtomicStampedReference(V initialRef, int initialStamp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of the reference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the reference </para>
				/// </returns>
				/// <java-name>
				/// getReference
				/// </java-name>
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
				public virtual V GetReference() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns the current value of the stamp.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the stamp </para>
				/// </returns>
				/// <java-name>
				/// getStamp
				/// </java-name>
				[Dot42.DexImport("getStamp", "()I", AccessFlags = 1)]
				public virtual int GetStamp() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the current values of both the reference and the stamp. Typical usage is <c> int[1] holder; ref = v.get(holder);  </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the reference </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([I)Ljava/lang/Object;", AccessFlags = 1, Signature = "([I)TV;")]
				public virtual V Get(int[] stampHolder) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Atomically sets the value of both the reference and stamp to the given update values if the current reference is <c> == </c> to the expected reference and the current stamp is equal to the expected stamp.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", AccessFlags = 1, Signature = "(TV;TV;II)Z")]
				public virtual bool WeakCompareAndSet(V expectedReference, V newReference, int expectedStamp, int newStamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value of both the reference and stamp to the given update values if the current reference is <c> == </c> to the expected reference and the current stamp is equal to the expected stamp.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", AccessFlags = 1, Signature = "(TV;TV;II)Z")]
				public virtual bool CompareAndSet(V expectedReference, V newReference, int expectedStamp, int newStamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unconditionally sets the value of both the reference and stamp.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;I)V", AccessFlags = 1, Signature = "(TV;I)V")]
				public virtual void Set(V newReference, int newStamp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets the value of the stamp to the given update value if the current reference is <c> == </c> to the expected reference. Any given invocation of this operation may fail (return <c> false </c> ) spuriously, but repeated invocation when the current value holds the expected value and no other thread is also attempting to set the value will eventually succeed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful </para>
				/// </returns>
				/// <java-name>
				/// attemptStamp
				/// </java-name>
				[Dot42.DexImport("attemptStamp", "(Ljava/lang/Object;I)Z", AccessFlags = 1, Signature = "(TV;I)Z")]
				public virtual bool AttemptStamp(V expectedReference, int newStamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AtomicStampedReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of the reference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the reference </para>
				/// </returns>
				/// <java-name>
				/// getReference
				/// </java-name>
				public V Reference
				{
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
						get{ return GetReference(); }
				}

				/// <summary>
				/// <para>Returns the current value of the stamp.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the stamp </para>
				/// </returns>
				/// <java-name>
				/// getStamp
				/// </java-name>
				public int Stamp
				{
				[Dot42.DexImport("getStamp", "()I", AccessFlags = 1)]
						get{ return GetStamp(); }
				}

		}

		/// <summary>
		/// <para>An <c> int </c> value that may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. An <c> AtomicInteger </c> is used in applications such as atomically incremented counters, and cannot be used as a replacement for an java.lang.Integer. However, this class does extend <c> Number </c> to allow uniform access by tools and utilities that deal with numerically-based classes.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicInteger
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicInteger", AccessFlags = 33)]
		public partial class AtomicInteger : global::Java.Lang.Number, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AtomicInteger with the given initial value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicInteger(int initialValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AtomicInteger with initial value <c> 0 </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicInteger() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()I", AccessFlags = 17)]
				public int Get() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(I)V", AccessFlags = 17)]
				public void Set(int newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(I)V", AccessFlags = 17)]
				public void LazySet(int newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(I)I", AccessFlags = 17)]
				public int GetAndSet(int newValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(II)Z", AccessFlags = 17)]
				public bool CompareAndSet(int expect, int update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(II)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(int expect, int update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "()I", AccessFlags = 17)]
				public int GetAndIncrement() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "()I", AccessFlags = 17)]
				public int GetAndDecrement() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(I)I", AccessFlags = 17)]
				public int GetAndAdd(int delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "()I", AccessFlags = 17)]
				public int IncrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "()I", AccessFlags = 17)]
				public int DecrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(I)I", AccessFlags = 17)]
				public int AddAndGet(int delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the String representation of the current value. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current value. </para>
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
				/// <para>Returns the value of this <c> AtomicInteger </c> as an <c> int </c> . </para>        
				/// </summary>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value of this <c> AtomicInteger </c> as a <c> long </c> after a widening primitive conversion. </para>        
				/// </summary>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value of this <c> AtomicInteger </c> as a <c> float </c> after a widening primitive conversion. </para>        
				/// </summary>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the value of this <c> AtomicInteger </c> as a <c> double </c> after a widening primitive conversion. </para>        
				/// </summary>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

		}

		/// <summary>
		/// <para>An <c> int </c> array in which elements may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. <para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicIntegerArray
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicIntegerArray", AccessFlags = 33)]
		public partial class AtomicIntegerArray : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AtomicIntegerArray of the given length, with all elements initially zero.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicIntegerArray(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AtomicIntegerArray of the given length, with all elements initially zero.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([I)V", AccessFlags = 1)]
				public AtomicIntegerArray(int[] length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the array </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the current value at position <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 17)]
				public int Get(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the element at position <c> i </c> to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 17)]
				public void Set(int i, int newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets the element at position <c> i </c> to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(II)V", AccessFlags = 17)]
				public void LazySet(int i, int newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(II)I", AccessFlags = 17)]
				public int GetAndSet(int i, int newValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given updated value if the current value <c> == </c> the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(III)Z", AccessFlags = 17)]
				public bool CompareAndSet(int i, int expect, int update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the element at position <c> i </c> to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(III)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(int i, int expect, int update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically increments by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(I)I", AccessFlags = 17)]
				public int GetAndIncrement(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically decrements by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(I)I", AccessFlags = 17)]
				public int GetAndDecrement(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(II)I", AccessFlags = 17)]
				public int GetAndAdd(int i, int delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically increments by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(I)I", AccessFlags = 17)]
				public int IncrementAndGet(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically decrements by one the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(I)I", AccessFlags = 17)]
				public int DecrementAndGet(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the element at index <c> i </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(II)I", AccessFlags = 17)]
				public int AddAndGet(int i, int delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the String representation of the current values of array. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current values of array </para>
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
				internal AtomicIntegerArray() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> long </c> value that may be updated atomically. See the java.util.concurrent.atomic package specification for description of the properties of atomic variables. An <c> AtomicLong </c> is used in applications such as atomically incremented sequence numbers, and cannot be used as a replacement for a java.lang.Long. However, this class does extend <c> Number </c> to allow uniform access by tools and utilities that deal with numerically-based classes.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicLong
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicLong", AccessFlags = 33)]
		public partial class AtomicLong : global::Java.Lang.Number, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AtomicLong with the given initial value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public AtomicLong(long initialValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AtomicLong with initial value <c> 0 </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicLong() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()J", AccessFlags = 17)]
				public long Get() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets to the given value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(J)V", AccessFlags = 17)]
				public void Set(long newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Eventually sets to the given value.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(J)V", AccessFlags = 17)]
				public void LazySet(long newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Atomically sets to the given value and returns the old value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(J)J", AccessFlags = 17)]
				public long GetAndSet(long newValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. False return indicates that the actual value was not equal to the expected value. </para>
				/// </returns>
				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(JJ)Z", AccessFlags = 17)]
				public bool CompareAndSet(long expect, long update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically sets the value to the given updated value if the current value <c> == </c> the expected value.</para><para>May  and does not provide ordering guarantees, so is only rarely an appropriate alternative to <c> compareAndSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successful. </para>
				/// </returns>
				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(JJ)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(long expect, long update) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "()J", AccessFlags = 17)]
				public long GetAndIncrement() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "()J", AccessFlags = 17)]
				public long GetAndDecrement() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous value </para>
				/// </returns>
				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(J)J", AccessFlags = 17)]
				public long GetAndAdd(long delta) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically increments by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "()J", AccessFlags = 17)]
				public long IncrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically decrements by one the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "()J", AccessFlags = 17)]
				public long DecrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Atomically adds the given value to the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the updated value </para>
				/// </returns>
				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(J)J", AccessFlags = 17)]
				public long AddAndGet(long delta) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the String representation of the current value. </para>        
				/// </summary>
				/// <returns>
				/// <para>the String representation of the current value. </para>
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
				/// <para>Returns the value of this <c> AtomicLong </c> as an <c> int </c> after a narrowing primitive conversion. </para>        
				/// </summary>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value of this <c> AtomicLong </c> as a <c> long </c> . </para>        
				/// </summary>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value of this <c> AtomicLong </c> as a <c> float </c> after a widening primitive conversion. </para>        
				/// </summary>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the value of this <c> AtomicLong </c> as a <c> double </c> after a widening primitive conversion. </para>        
				/// </summary>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

		}

}


