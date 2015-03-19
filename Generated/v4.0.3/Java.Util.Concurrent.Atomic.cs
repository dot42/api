#pragma warning disable 1717
namespace Java.Util.Concurrent.Atomic
{
		/// <java-name>
		/// java/util/concurrent/atomic/AtomicReferenceFieldUpdater
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicReferenceFieldUpdater", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class AtomicReferenceFieldUpdater<T, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AtomicReferenceFieldUpdater() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newUpdater
				/// </java-name>
				[Dot42.DexImport("newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomi" +
    "c/AtomicReferenceFieldUpdater;", AccessFlags = 9, Signature = "<U:Ljava/lang/Object;W:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;Ljava/lang/Class" +
    "<TW;>;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdate" +
    "r<TU;TW;>;")]
				public static global::Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<U, W> NewUpdater<U, W>(global::System.Type type, global::System.Type type1, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<U, W>);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TT;TV;TV;)Z")]
				public abstract bool CompareAndSet(T t, V v, V v1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TT;TV;TV;)Z")]
				public abstract bool WeakCompareAndSet(T t, V v, V v1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TT;TV;)V")]
				public abstract void Set(T t, V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TT;TV;)V")]
				public abstract void LazySet(T t, V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TT;)TV;")]
				public abstract V Get(T t) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TT;TV;)TV;")]
				public virtual V GetAndSet(T t, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicInteger
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicInteger", AccessFlags = 33)]
		public partial class AtomicInteger : global::Java.Lang.Number, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicInteger(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicInteger() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()I", AccessFlags = 17)]
				public int Get() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(I)V", AccessFlags = 17)]
				public void Set(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(I)V", AccessFlags = 17)]
				public void LazySet(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(I)I", AccessFlags = 17)]
				public int GetAndSet(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(II)Z", AccessFlags = 17)]
				public bool CompareAndSet(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(II)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "()I", AccessFlags = 17)]
				public int GetAndIncrement() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "()I", AccessFlags = 17)]
				public int GetAndDecrement() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(I)I", AccessFlags = 17)]
				public int GetAndAdd(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "()I", AccessFlags = 17)]
				public int IncrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "()I", AccessFlags = 17)]
				public int DecrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(I)I", AccessFlags = 17)]
				public int AddAndGet(int int32) /* MethodBuilder.Create */ 
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
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicIntegerFieldUpdater
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicIntegerFieldUpdater", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class AtomicIntegerFieldUpdater<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AtomicIntegerFieldUpdater() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newUpdater
				/// </java-name>
				[Dot42.DexImport("newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFi" +
    "eldUpdater;", AccessFlags = 9, Signature = "<U:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;Ljava/lang/String;)Ljava/util/concur" +
    "rent/atomic/AtomicIntegerFieldUpdater<TU;>;")]
				public static global::Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<U> NewUpdater<U>(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<U>);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;II)Z", AccessFlags = 1025, Signature = "(TT;II)Z")]
				public abstract bool CompareAndSet(T t, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;II)Z", AccessFlags = 1025, Signature = "(TT;II)Z")]
				public abstract bool WeakCompareAndSet(T t, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;I)V", AccessFlags = 1025, Signature = "(TT;I)V")]
				public abstract void Set(T t, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;I)V", AccessFlags = 1025, Signature = "(TT;I)V")]
				public abstract void LazySet(T t, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)I", AccessFlags = 1025, Signature = "(TT;)I")]
				public abstract int Get(T t) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TT;I)I")]
				public virtual int GetAndSet(T t, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int GetAndIncrement(T t) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int GetAndDecrement(T t) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TT;I)I")]
				public virtual int GetAndAdd(T t, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int IncrementAndGet(T t) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int DecrementAndGet(T t) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(Ljava/lang/Object;I)I", AccessFlags = 1, Signature = "(TT;I)I")]
				public virtual int AddAndGet(T t, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicMarkableReference
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicMarkableReference", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class AtomicMarkableReference<V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Z)V", AccessFlags = 1, Signature = "(TV;Z)V")]
				public AtomicMarkableReference(V v, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReference
				/// </java-name>
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
				public virtual V GetReference() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// isMarked
				/// </java-name>
				[Dot42.DexImport("isMarked", "()Z", AccessFlags = 1)]
				public virtual bool IsMarked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([Z)Ljava/lang/Object;", AccessFlags = 1, Signature = "([Z)TV;")]
				public virtual V Get(bool[] boolean) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", AccessFlags = 1, Signature = "(TV;TV;ZZ)Z")]
				public virtual bool WeakCompareAndSet(V v, V v1, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", AccessFlags = 1, Signature = "(TV;TV;ZZ)Z")]
				public virtual bool CompareAndSet(V v, V v1, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Z)V", AccessFlags = 1, Signature = "(TV;Z)V")]
				public virtual void Set(V v, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attemptMark
				/// </java-name>
				[Dot42.DexImport("attemptMark", "(Ljava/lang/Object;Z)Z", AccessFlags = 1, Signature = "(TV;Z)Z")]
				public virtual bool AttemptMark(V v, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AtomicMarkableReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getReference
				/// </java-name>
				public V Reference
				{
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
						get{ return GetReference(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicIntegerArray
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicIntegerArray", AccessFlags = 33)]
		public partial class AtomicIntegerArray : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicIntegerArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([I)V", AccessFlags = 1)]
				public AtomicIntegerArray(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 17)]
				public int Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 17)]
				public void Set(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(II)V", AccessFlags = 17)]
				public void LazySet(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(II)I", AccessFlags = 17)]
				public int GetAndSet(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(III)Z", AccessFlags = 17)]
				public bool CompareAndSet(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(III)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(I)I", AccessFlags = 17)]
				public int GetAndIncrement(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(I)I", AccessFlags = 17)]
				public int GetAndDecrement(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(II)I", AccessFlags = 17)]
				public int GetAndAdd(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(I)I", AccessFlags = 17)]
				public int IncrementAndGet(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(I)I", AccessFlags = 17)]
				public int DecrementAndGet(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(II)I", AccessFlags = 17)]
				public int AddAndGet(int int32, int int321) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AtomicIntegerArray() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicReference
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicReference", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
		public partial class AtomicReference<V> : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TV;)V")]
				public AtomicReference(V v) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicReference() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 17, Signature = "()TV;")]
				public V Get() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 17, Signature = "(TV;)V")]
				public void Set(V v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;)V", AccessFlags = 17, Signature = "(TV;)V")]
				public void LazySet(V v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(TV;TV;)Z")]
				public bool CompareAndSet(V v, V v1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(TV;TV;)Z")]
				public bool WeakCompareAndSet(V v, V v1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(TV;)TV;")]
				public V GetAndSet(V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicLongFieldUpdater
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicLongFieldUpdater", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class AtomicLongFieldUpdater<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AtomicLongFieldUpdater() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newUpdater
				/// </java-name>
				[Dot42.DexImport("newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongField" +
    "Updater;", AccessFlags = 9, Signature = "<U:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;Ljava/lang/String;)Ljava/util/concur" +
    "rent/atomic/AtomicLongFieldUpdater<TU;>;")]
				public static global::Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<U> NewUpdater<U>(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<U>);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;JJ)Z", AccessFlags = 1025, Signature = "(TT;JJ)Z")]
				public abstract bool CompareAndSet(T t, long int64, long int641) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;JJ)Z", AccessFlags = 1025, Signature = "(TT;JJ)Z")]
				public abstract bool WeakCompareAndSet(T t, long int64, long int641) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;J)V", AccessFlags = 1025, Signature = "(TT;J)V")]
				public abstract void Set(T t, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Ljava/lang/Object;J)V", AccessFlags = 1025, Signature = "(TT;J)V")]
				public abstract void LazySet(T t, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)J", AccessFlags = 1025, Signature = "(TT;)J")]
				public abstract long Get(T t) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Ljava/lang/Object;J)J", AccessFlags = 1, Signature = "(TT;J)J")]
				public virtual long GetAndSet(T t, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long GetAndIncrement(T t) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long GetAndDecrement(T t) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(Ljava/lang/Object;J)J", AccessFlags = 1, Signature = "(TT;J)J")]
				public virtual long GetAndAdd(T t, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long IncrementAndGet(T t) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(Ljava/lang/Object;)J", AccessFlags = 1, Signature = "(TT;)J")]
				public virtual long DecrementAndGet(T t) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(Ljava/lang/Object;J)J", AccessFlags = 1, Signature = "(TT;J)J")]
				public virtual long AddAndGet(T t, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicReferenceArray
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicReferenceArray", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
		public partial class AtomicReferenceArray<E> : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicReferenceArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/Object;)V", AccessFlags = 1, Signature = "([TE;)V")]
				public AtomicReferenceArray(E[] p) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 17, Signature = "(I)TE;")]
				public E Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)V", AccessFlags = 17, Signature = "(ITE;)V")]
				public void Set(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(ILjava/lang/Object;)V", AccessFlags = 17, Signature = "(ITE;)V")]
				public void LazySet(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(ITE;)TE;")]
				public E GetAndSet(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(ITE;TE;)Z")]
				public bool CompareAndSet(int int32, E e, E e1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 17, Signature = "(ITE;TE;)Z")]
				public bool WeakCompareAndSet(int int32, E e, E e1) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				internal AtomicReferenceArray() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicLong
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicLong", AccessFlags = 33)]
		public partial class AtomicLong : global::Java.Lang.Number, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public AtomicLong(long int64) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicLong() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()J", AccessFlags = 17)]
				public long Get() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(J)V", AccessFlags = 17)]
				public void Set(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(J)V", AccessFlags = 17)]
				public void LazySet(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(J)J", AccessFlags = 17)]
				public long GetAndSet(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(JJ)Z", AccessFlags = 17)]
				public bool CompareAndSet(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(JJ)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "()J", AccessFlags = 17)]
				public long GetAndIncrement() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "()J", AccessFlags = 17)]
				public long GetAndDecrement() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(J)J", AccessFlags = 17)]
				public long GetAndAdd(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "()J", AccessFlags = 17)]
				public long IncrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "()J", AccessFlags = 17)]
				public long DecrementAndGet() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(J)J", AccessFlags = 17)]
				public long AddAndGet(long int64) /* MethodBuilder.Create */ 
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
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicStampedReference
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicStampedReference", AccessFlags = 33, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class AtomicStampedReference<V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;I)V", AccessFlags = 1, Signature = "(TV;I)V")]
				public AtomicStampedReference(V v, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReference
				/// </java-name>
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
				public virtual V GetReference() /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// getStamp
				/// </java-name>
				[Dot42.DexImport("getStamp", "()I", AccessFlags = 1)]
				public virtual int GetStamp() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([I)Ljava/lang/Object;", AccessFlags = 1, Signature = "([I)TV;")]
				public virtual V Get(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", AccessFlags = 1, Signature = "(TV;TV;II)Z")]
				public virtual bool WeakCompareAndSet(V v, V v1, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", AccessFlags = 1, Signature = "(TV;TV;II)Z")]
				public virtual bool CompareAndSet(V v, V v1, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;I)V", AccessFlags = 1, Signature = "(TV;I)V")]
				public virtual void Set(V v, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attemptStamp
				/// </java-name>
				[Dot42.DexImport("attemptStamp", "(Ljava/lang/Object;I)Z", AccessFlags = 1, Signature = "(TV;I)Z")]
				public virtual bool AttemptStamp(V v, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AtomicStampedReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getReference
				/// </java-name>
				public V Reference
				{
				[Dot42.DexImport("getReference", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
						get{ return GetReference(); }
				}

				/// <java-name>
				/// getStamp
				/// </java-name>
				public int Stamp
				{
				[Dot42.DexImport("getStamp", "()I", AccessFlags = 1)]
						get{ return GetStamp(); }
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicLongArray
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicLongArray", AccessFlags = 33)]
		public partial class AtomicLongArray : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AtomicLongArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([J)V", AccessFlags = 1)]
				public AtomicLongArray(long[] int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)J", AccessFlags = 17)]
				public long Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IJ)V", AccessFlags = 17)]
				public void Set(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(IJ)V", AccessFlags = 17)]
				public void LazySet(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(IJ)J", AccessFlags = 17)]
				public long GetAndSet(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(IJJ)Z", AccessFlags = 17)]
				public bool CompareAndSet(int int32, long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(IJJ)Z", AccessFlags = 17)]
				public bool WeakCompareAndSet(int int32, long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAndIncrement
				/// </java-name>
				[Dot42.DexImport("getAndIncrement", "(I)J", AccessFlags = 17)]
				public long GetAndIncrement(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndDecrement
				/// </java-name>
				[Dot42.DexImport("getAndDecrement", "(I)J", AccessFlags = 17)]
				public long GetAndDecrement(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getAndAdd
				/// </java-name>
				[Dot42.DexImport("getAndAdd", "(IJ)J", AccessFlags = 17)]
				public long GetAndAdd(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// incrementAndGet
				/// </java-name>
				[Dot42.DexImport("incrementAndGet", "(I)J", AccessFlags = 17)]
				public long IncrementAndGet(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// decrementAndGet
				/// </java-name>
				[Dot42.DexImport("decrementAndGet", "(I)J", AccessFlags = 17)]
				public long DecrementAndGet(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// addAndGet
				/// </java-name>
				[Dot42.DexImport("addAndGet", "(IJ)J", AccessFlags = 1)]
				public virtual long AddAndGet(int int32, long int64) /* MethodBuilder.Create */ 
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
				internal AtomicLongArray() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/concurrent/atomic/AtomicBoolean
		/// </java-name>
		[Dot42.DexImport("java/util/concurrent/atomic/AtomicBoolean", AccessFlags = 33)]
		public partial class AtomicBoolean : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public AtomicBoolean(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AtomicBoolean() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Z", AccessFlags = 17)]
				public bool Get() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareAndSet
				/// </java-name>
				[Dot42.DexImport("compareAndSet", "(ZZ)Z", AccessFlags = 17)]
				public bool CompareAndSet(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// weakCompareAndSet
				/// </java-name>
				[Dot42.DexImport("weakCompareAndSet", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool WeakCompareAndSet(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Z)V", AccessFlags = 17)]
				public void Set(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lazySet
				/// </java-name>
				[Dot42.DexImport("lazySet", "(Z)V", AccessFlags = 17)]
				public void LazySet(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndSet
				/// </java-name>
				[Dot42.DexImport("getAndSet", "(Z)Z", AccessFlags = 17)]
				public bool GetAndSet(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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

