#pragma warning disable 1717
namespace Java.Lang.Ref
{
		/// <java-name>
		/// java/lang/ref/PhantomReference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/PhantomReference", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ref/Reference<TT;>;")]
		public partial class PhantomReference<T> : global::Java.Lang.Ref.Reference<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(TT;Ljava/lang/ref/ReferenceQueue<-TT;>;)V")]
				public PhantomReference(T t, global::Java.Lang.Ref.ReferenceQueue<T> referenceQueue) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// java/lang/ref/Reference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/Reference", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Reference<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Reference() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enqueue
				/// </java-name>
				[Dot42.DexImport("enqueue", "()Z", AccessFlags = 1)]
				public virtual bool Enqueue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public virtual T Get() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// isEnqueued
				/// </java-name>
				[Dot42.DexImport("isEnqueued", "()Z", AccessFlags = 1)]
				public virtual bool IsEnqueued() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/lang/ref/ReferenceQueue
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/ReferenceQueue", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class ReferenceQueue<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReferenceQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/ref/Reference;", AccessFlags = 33, Signature = "()Ljava/lang/ref/Reference<+TT;>;")]
				public virtual global::Java.Lang.Ref.Reference<T> Poll() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Ref.Reference<T>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/ref/Reference;", AccessFlags = 1, Signature = "()Ljava/lang/ref/Reference<+TT;>;")]
				public virtual global::Java.Lang.Ref.Reference<T> Remove() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Ref.Reference<T>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(J)Ljava/lang/ref/Reference;", AccessFlags = 33, Signature = "(J)Ljava/lang/ref/Reference<+TT;>;")]
				public virtual global::Java.Lang.Ref.Reference<T> Remove(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Ref.Reference<T>);
				}

		}

		/// <java-name>
		/// java/lang/ref/SoftReference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/SoftReference", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ref/Reference<TT;>;")]
		public partial class SoftReference<T> : global::Java.Lang.Ref.Reference<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public SoftReference(T t) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(TT;Ljava/lang/ref/ReferenceQueue<-TT;>;)V")]
				public SoftReference(T t, global::Java.Lang.Ref.ReferenceQueue<T> referenceQueue) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SoftReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ref/WeakReference
		/// </java-name>
		[Dot42.DexImport("java/lang/ref/WeakReference", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ref/Reference<TT;>;")]
		public partial class WeakReference<T> : global::Java.Lang.Ref.Reference<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public WeakReference(T t) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", AccessFlags = 1, Signature = "(TT;Ljava/lang/ref/ReferenceQueue<-TT;>;)V")]
				public WeakReference(T t, global::Java.Lang.Ref.ReferenceQueue<T> referenceQueue) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WeakReference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

