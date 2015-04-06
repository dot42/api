#pragma warning disable 1717
namespace Java.Util
{
		/// <java-name>
		/// java/util/AbstractCollection
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractCollection", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public abstract partial class AbstractCollection<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractCollection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
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
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/AbstractList
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractList", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/List<TE;>;")]
		public abstract partial class AbstractList<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.IList<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// modCount
				/// </java-name>
				[Dot42.DexImport("modCount", "I", AccessFlags = 132)]
				protected internal int ModCount;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractList() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void Add(int int32, E e) /* MethodBuilder.Create */ 
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
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)TE;")]
				public virtual E Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
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
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int IndexOf(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E Remove(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// removeRange
				/// </java-name>
				[Dot42.DexImport("removeRange", "(II)V", AccessFlags = 4)]
				protected internal virtual void RemoveRange(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public virtual E Set(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 1, Signature = "(II)Ljava/util/List<TE;>;")]
				public virtual global::Java.Util.IList<E> SubList(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				[Dot42.DexImport("java/util/List", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Contains(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Remove(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "size", "()I", AccessFlags = 1025)]
				public override int Size() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/List", "toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				public override object[] ToArray() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object[]);
				}

				[Dot42.DexImport("java/util/List", "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/List", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/AbstractMap
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractMap", AccessFlags = 1057, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;" +
    ">;")]
		public abstract partial class AbstractMap<K, V> : global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractMap() /* MethodBuilder.Create */ 
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
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool ContainsKey(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool ContainsValue(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public virtual global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
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
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public virtual V Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
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
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public virtual global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V Put(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public virtual void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public virtual V Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public virtual global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// java/util/AbstractMap$SimpleEntry
				/// </java-name>
				[Dot42.DexImport("java/util/AbstractMap$SimpleEntry", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map$Entry<" +
    "TK;TV;>;Ljava/io/Serializable;")]
				public partial class SimpleEntry<K, V> : global::Java.Util.IMap_IEntry<K, V>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TK;TV;)V")]
						public SimpleEntry(K k, V v) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/util/Map$Entry;)V", AccessFlags = 1, Signature = "(Ljava/util/Map$Entry<+TK;+TV;>;)V")]
						public SimpleEntry(global::Java.Util.IMap_IEntry<K, V> map_IEntry) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setValue
						/// </java-name>
						[Dot42.DexImport("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TV;)TV;")]
						public virtual V SetValue(V v) /* MethodBuilder.Create */ 
						{
								return default(V);
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

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SimpleEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getKey
						/// </java-name>
						public virtual K Key
						{
								[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
								get{ return default(K); }
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						public virtual V Value
						{
								[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
								get{ return default(V); }
						}

				}

				/// <java-name>
				/// java/util/AbstractMap$SimpleImmutableEntry
				/// </java-name>
				[Dot42.DexImport("java/util/AbstractMap$SimpleImmutableEntry", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map$Entry<" +
    "TK;TV;>;Ljava/io/Serializable;")]
				public partial class SimpleImmutableEntry<K, V> : global::Java.Util.IMap_IEntry<K, V>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TK;TV;)V")]
						public SimpleImmutableEntry(K k, V v) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/util/Map$Entry;)V", AccessFlags = 1, Signature = "(Ljava/util/Map$Entry<+TK;+TV;>;)V")]
						public SimpleImmutableEntry(global::Java.Util.IMap_IEntry<K, V> map_IEntry) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setValue
						/// </java-name>
						[Dot42.DexImport("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TV;)TV;")]
						public virtual V SetValue(V v) /* MethodBuilder.Create */ 
						{
								return default(V);
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

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SimpleImmutableEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getKey
						/// </java-name>
						public virtual K Key
						{
								[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
								get{ return default(K); }
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						public virtual V Value
						{
								[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
								get{ return default(V); }
						}

				}

		}

		/// <java-name>
		/// java/util/AbstractQueue
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractQueue", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/Queue<TE;>;")]
		public abstract partial class AbstractQueue<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.IQueue<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractQueue() /* MethodBuilder.Create */ 
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
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Queue", "offer", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public virtual bool Offer(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Queue", "poll", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public virtual E Poll() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Queue", "peek", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				public virtual E Peek() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(E);
				}

				[Dot42.DexImport("java/util/Collection", "contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Contains(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				[Dot42.DexImport("java/util/Collection", "iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/Collection", "remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Remove(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				[Dot42.DexImport("java/util/Collection", "size", "()I", AccessFlags = 1025)]
				public override int Size() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Collection", "toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				public override object[] ToArray() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object[]);
				}

				[Dot42.DexImport("java/util/Collection", "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/AbstractSequentialList
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractSequentialList", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;")]
		public abstract partial class AbstractSequentialList<E> : global::Java.Util.AbstractList<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractSequentialList() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int int32) /* MethodBuilder.Create */ 
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
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Remove(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public override E Set(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

		}

		/// <java-name>
		/// java/util/AbstractSet
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractSet", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/Set<TE;>;")]
		public abstract partial class AbstractSet<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.ISet<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractSet() /* MethodBuilder.Create */ 
				{
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
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public override bool Add(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "clear", "()V", AccessFlags = 1025)]
				public override void Clear() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("java/util/Set", "contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Contains(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/Set", "remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Remove(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "size", "()I", AccessFlags = 1025)]
				public override int Size() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
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

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Set", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/ArrayDeque
		/// </java-name>
		[Dot42.DexImport("java/util/ArrayDeque", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/Deque<TE;>;Lj" +
    "ava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class ArrayDeque<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.IDeque<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayDeque() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayDeque(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ArrayDeque(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				public virtual bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
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
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/ArrayDeque;", AccessFlags = 1, Signature = "()Ljava/util/ArrayDeque<TE;>;")]
				public virtual global::Java.Util.ArrayDeque<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayDeque<E>);
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

				/// <java-name>
				/// getFirst
				/// </java-name>
				public virtual E First
				{
						[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return default(E); }
				}

				/// <java-name>
				/// getLast
				/// </java-name>
				public virtual E Last
				{
						[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return default(E); }
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/ArrayList
		/// </java-name>
		[Dot42.DexImport("java/util/ArrayList", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;Ljava/lang/Cloneable;Ljava/io/" +
    "Serializable;Ljava/util/RandomAccess;")]
		public partial class ArrayList<E> : global::Java.Util.AbstractList<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable, global::Java.Util.IRandomAccess
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayList(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayList() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ArrayList(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int int32, E e) /* MethodBuilder.Create */ 
				{
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
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 1)]
				public virtual void EnsureCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int int32) /* MethodBuilder.Create */ 
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
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Remove(int int32) /* MethodBuilder.Create */ 
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
				/// removeRange
				/// </java-name>
				[Dot42.DexImport("removeRange", "(II)V", AccessFlags = 4)]
				protected internal override void RemoveRange(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public override E Set(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
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
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 1)]
				public virtual void TrimToSize() /* MethodBuilder.Create */ 
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Arrays
		/// </java-name>
		[Dot42.DexImport("java/util/Arrays", AccessFlags = 33)]
		public partial class Arrays
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Arrays() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// asList
				/// </java-name>
				[Dot42.DexImport("asList", "([Ljava/lang/Object;)Ljava/util/List;", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;>([TT;)Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> AsList<T>(params T[] p) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([BB)I", AccessFlags = 9)]
				public static int BinarySearch(sbyte[] sByte, sbyte sByte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([BB)I", AccessFlags = 9, IgnoreFromJava = true)]
				public static int BinarySearch(byte[] @byte, byte byte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([BIIB)I", AccessFlags = 9)]
				public static int BinarySearch(sbyte[] sByte, int int32, int int321, sbyte sByte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([BIIB)I", AccessFlags = 9, IgnoreFromJava = true)]
				public static int BinarySearch(byte[] @byte, int int32, int int321, byte byte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([CC)I", AccessFlags = 9)]
				public static int BinarySearch(char[] @char, char char1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([CIIC)I", AccessFlags = 9)]
				public static int BinarySearch(char[] @char, int int32, int int321, char char1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([DD)I", AccessFlags = 9)]
				public static int BinarySearch(double[] @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([DIID)I", AccessFlags = 9)]
				public static int BinarySearch(double[] @double, int int32, int int321, double double1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([FF)I", AccessFlags = 9)]
				public static int BinarySearch(float[] single, float single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([FIIF)I", AccessFlags = 9)]
				public static int BinarySearch(float[] single, int int32, int int321, float single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([II)I", AccessFlags = 9)]
				public static int BinarySearch(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([IIII)I", AccessFlags = 9)]
				public static int BinarySearch(int[] int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([JJ)I", AccessFlags = 9)]
				public static int BinarySearch(long[] int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([JIIJ)I", AccessFlags = 9)]
				public static int BinarySearch(long[] int64, int int32, int int321, long int641) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I", AccessFlags = 9)]
				public static int BinarySearch(object[] @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I", AccessFlags = 9)]
				public static int BinarySearch(object[] @object, int int32, int int321, object object1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;TT;Ljava/util/Comparator<-TT;>;)I")]
				public static int BinarySearch<T>(T[] p, T t, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;IITT;Ljava/util/Comparator<-TT;>;)I")]
				public static int BinarySearch<T>(T[] p, int int32, int int321, T t, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([SS)I", AccessFlags = 9)]
				public static int BinarySearch(short[] int16, short int161) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([SIIS)I", AccessFlags = 9)]
				public static int BinarySearch(short[] int16, int int32, int int321, short int161) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([BB)V", AccessFlags = 9)]
				public static void Fill(sbyte[] sByte, sbyte sByte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([BB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void Fill(byte[] @byte, byte byte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([BIIB)V", AccessFlags = 9)]
				public static void Fill(sbyte[] sByte, int int32, int int321, sbyte sByte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([BIIB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void Fill(byte[] @byte, int int32, int int321, byte byte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([SS)V", AccessFlags = 9)]
				public static void Fill(short[] int16, short int161) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([SIIS)V", AccessFlags = 9)]
				public static void Fill(short[] int16, int int32, int int321, short int161) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([CC)V", AccessFlags = 9)]
				public static void Fill(char[] @char, char char1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([CIIC)V", AccessFlags = 9)]
				public static void Fill(char[] @char, int int32, int int321, char char1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([II)V", AccessFlags = 9)]
				public static void Fill(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([IIII)V", AccessFlags = 9)]
				public static void Fill(int[] int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([JJ)V", AccessFlags = 9)]
				public static void Fill(long[] int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([JIIJ)V", AccessFlags = 9)]
				public static void Fill(long[] int64, int int32, int int321, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([FF)V", AccessFlags = 9)]
				public static void Fill(float[] single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([FIIF)V", AccessFlags = 9)]
				public static void Fill(float[] single, int int32, int int321, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([DD)V", AccessFlags = 9)]
				public static void Fill(double[] @double, double double1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([DIID)V", AccessFlags = 9)]
				public static void Fill(double[] @double, int int32, int int321, double double1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([ZZ)V", AccessFlags = 9)]
				public static void Fill(bool[] boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([ZIIZ)V", AccessFlags = 9)]
				public static void Fill(bool[] boolean, int int32, int int321, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void Fill(object[] @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "([Ljava/lang/Object;IILjava/lang/Object;)V", AccessFlags = 9)]
				public static void Fill(object[] @object, int int32, int int321, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([Z)I", AccessFlags = 9)]
				public static int GetHashCode(bool[] boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([I)I", AccessFlags = 9)]
				public static int GetHashCode(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([S)I", AccessFlags = 9)]
				public static int GetHashCode(short[] int16) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([C)I", AccessFlags = 9)]
				public static int GetHashCode(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([B)I", AccessFlags = 9)]
				public static int GetHashCode(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([B)I", AccessFlags = 9, IgnoreFromJava = true)]
				public static int GetHashCode(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([J)I", AccessFlags = 9)]
				public static int GetHashCode(long[] int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([F)I", AccessFlags = 9)]
				public static int GetHashCode(float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([D)I", AccessFlags = 9)]
				public static int GetHashCode(double[] @double) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "([Ljava/lang/Object;)I", AccessFlags = 9)]
				public static int GetHashCode(object[] @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deepHashCode
				/// </java-name>
				[Dot42.DexImport("deepHashCode", "([Ljava/lang/Object;)I", AccessFlags = 9)]
				public static int DeepHashCode(object[] @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([B[B)Z", AccessFlags = 9)]
				public static bool Equals(sbyte[] sByte, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([B[B)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool Equals(byte[] @byte, byte[] byte1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([S[S)Z", AccessFlags = 9)]
				public static bool Equals(short[] int16, short[] int161) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([C[C)Z", AccessFlags = 9)]
				public static bool Equals(char[] @char, char[] char1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([I[I)Z", AccessFlags = 9)]
				public static bool Equals(int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([J[J)Z", AccessFlags = 9)]
				public static bool Equals(long[] int64, long[] int641) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([F[F)Z", AccessFlags = 9)]
				public static bool Equals(float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([D[D)Z", AccessFlags = 9)]
				public static bool Equals(double[] @double, double[] double1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([Z[Z)Z", AccessFlags = 9)]
				public static bool Equals(bool[] boolean, bool[] boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool Equals(object[] @object, object[] object1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// deepEquals
				/// </java-name>
				[Dot42.DexImport("deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool DeepEquals(object[] @object, object[] object1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([B)V", AccessFlags = 9)]
				public static void Sort(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([B)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void Sort(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([BII)V", AccessFlags = 9)]
				public static void Sort(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([BII)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void Sort(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([C)V", AccessFlags = 9)]
				public static void Sort(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([CII)V", AccessFlags = 9)]
				public static void Sort(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([D)V", AccessFlags = 9)]
				public static void Sort(double[] @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([DII)V", AccessFlags = 9)]
				public static void Sort(double[] @double, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([F)V", AccessFlags = 9)]
				public static void Sort(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([FII)V", AccessFlags = 9)]
				public static void Sort(float[] single, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([I)V", AccessFlags = 9)]
				public static void Sort(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([III)V", AccessFlags = 9)]
				public static void Sort(int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([J)V", AccessFlags = 9)]
				public static void Sort(long[] int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([JII)V", AccessFlags = 9)]
				public static void Sort(long[] int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([S)V", AccessFlags = 9)]
				public static void Sort(short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([SII)V", AccessFlags = 9)]
				public static void Sort(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void Sort(object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([Ljava/lang/Object;II)V", AccessFlags = 9)]
				public static void Sort(object[] @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;IILjava/util/Comparator<-TT;>;)V")]
				public static void Sort<T>(T[] p, int int32, int int321, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;Ljava/util/Comparator<-TT;>;)V")]
				public static void Sort<T>(T[] p, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([Z)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(bool[] boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([B)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([B)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string ToString(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(double[] @double) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(float[] single) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(long[] int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([S)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(short[] int16) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "([Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// deepToString
				/// </java-name>
				[Dot42.DexImport("deepToString", "([Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string DeepToString(object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([ZI)[Z", AccessFlags = 9)]
				public static bool[] CopyOf(bool[] boolean, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([BI)[B", AccessFlags = 9)]
				public static sbyte[] CopyOf(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([BI)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] CopyOf(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([CI)[C", AccessFlags = 9)]
				public static char[] CopyOf(char[] @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([DI)[D", AccessFlags = 9)]
				public static double[] CopyOf(double[] @double, int int32) /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([FI)[F", AccessFlags = 9)]
				public static float[] CopyOf(float[] single, int int32) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([II)[I", AccessFlags = 9)]
				public static int[] CopyOf(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([JI)[J", AccessFlags = 9)]
				public static long[] CopyOf(long[] int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([SI)[S", AccessFlags = 9)]
				public static short[] CopyOf(short[] int16, int int32) /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;I)[TT;")]
				public static T[] CopyOf<T>(T[] p, int int32) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;U:Ljava/lang/Object;>([TU;ILjava/lang/Class<+[TT;>;)[TT;")]
				public static T[] CopyOf<T, U>(U[] p, int int32, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([ZII)[Z", AccessFlags = 9)]
				public static bool[] CopyOfRange(bool[] boolean, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([BII)[B", AccessFlags = 9)]
				public static sbyte[] CopyOfRange(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([BII)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] CopyOfRange(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([CII)[C", AccessFlags = 9)]
				public static char[] CopyOfRange(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([DII)[D", AccessFlags = 9)]
				public static double[] CopyOfRange(double[] @double, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([FII)[F", AccessFlags = 9)]
				public static float[] CopyOfRange(float[] single, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([III)[I", AccessFlags = 9)]
				public static int[] CopyOfRange(int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([JII)[J", AccessFlags = 9)]
				public static long[] CopyOfRange(long[] int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([SII)[S", AccessFlags = 9)]
				public static short[] CopyOfRange(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;II)[TT;")]
				public static T[] CopyOfRange<T>(T[] p, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;U:Ljava/lang/Object;>([TU;IILjava/lang/Class<+[TT;>;)[TT;")]
				public static T[] CopyOfRange<T, U>(U[] p, int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

		}

		/// <java-name>
		/// java/util/BitSet
		/// </java-name>
		[Dot42.DexImport("java/util/BitSet", AccessFlags = 33)]
		public partial class BitSet : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BitSet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public BitSet(int int32) /* MethodBuilder.Create */ 
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
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Z", AccessFlags = 1)]
				public virtual bool Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(I)V", AccessFlags = 1)]
				public virtual void Set(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(I)V", AccessFlags = 1)]
				public virtual void Clear(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flip
				/// </java-name>
				[Dot42.DexImport("flip", "(I)V", AccessFlags = 1)]
				public virtual void Flip(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)Ljava/util/BitSet;", AccessFlags = 1)]
				public virtual global::Java.Util.BitSet Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.BitSet);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IZ)V", AccessFlags = 1)]
				public virtual void Set(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIZ)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
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
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(II)V", AccessFlags = 1)]
				public virtual void Clear(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flip
				/// </java-name>
				[Dot42.DexImport("flip", "(II)V", AccessFlags = 1)]
				public virtual void Flip(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(Ljava/util/BitSet;)Z", AccessFlags = 1)]
				public virtual bool Intersects(global::Java.Util.BitSet bitSet) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// and
				/// </java-name>
				[Dot42.DexImport("and", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void And(global::Java.Util.BitSet bitSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// andNot
				/// </java-name>
				[Dot42.DexImport("andNot", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void AndNot(global::Java.Util.BitSet bitSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// or
				/// </java-name>
				[Dot42.DexImport("or", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void Or(global::Java.Util.BitSet bitSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// xor
				/// </java-name>
				[Dot42.DexImport("xor", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void Xor(global::Java.Util.BitSet bitSet) /* MethodBuilder.Create */ 
				{
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
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
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
				/// nextSetBit
				/// </java-name>
				[Dot42.DexImport("nextSetBit", "(I)I", AccessFlags = 1)]
				public virtual int NextSetBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextClearBit
				/// </java-name>
				[Dot42.DexImport("nextClearBit", "(I)I", AccessFlags = 1)]
				public virtual int NextClearBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// cardinality
				/// </java-name>
				[Dot42.DexImport("cardinality", "()I", AccessFlags = 1)]
				public virtual int Cardinality() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Calendar
		/// </java-name>
		[Dot42.DexImport("java/util/Calendar", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Cloneable;Ljava/lang/Comparabl" +
    "e<Ljava/util/Calendar;>;")]
		public abstract partial class Calendar : global::Java.Io.ISerializable, global::Java.Lang.ICloneable, global::System.IComparable<global::Java.Util.Calendar>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// areFieldsSet
				/// </java-name>
				[Dot42.DexImport("areFieldsSet", "Z", AccessFlags = 4)]
				protected internal bool AreFieldsSet;
				/// <java-name>
				/// fields
				/// </java-name>
				[Dot42.DexImport("fields", "[I", AccessFlags = 4)]
				protected internal int[] Fields;
				/// <java-name>
				/// isSet
				/// </java-name>
				[Dot42.DexImport("isSet", "[Z", AccessFlags = 4)]
				protected internal bool[] IsSet0;
				/// <java-name>
				/// isTimeSet
				/// </java-name>
				[Dot42.DexImport("isTimeSet", "Z", AccessFlags = 4)]
				protected internal bool IsTimeSet;
				/// <java-name>
				/// time
				/// </java-name>
				[Dot42.DexImport("time", "J", AccessFlags = 4)]
				protected internal long @time;
				/// <java-name>
				/// JANUARY
				/// </java-name>
				[Dot42.DexImport("JANUARY", "I", AccessFlags = 25)]
				public const int JANUARY = 0;
				/// <java-name>
				/// FEBRUARY
				/// </java-name>
				[Dot42.DexImport("FEBRUARY", "I", AccessFlags = 25)]
				public const int FEBRUARY = 1;
				/// <java-name>
				/// MARCH
				/// </java-name>
				[Dot42.DexImport("MARCH", "I", AccessFlags = 25)]
				public const int MARCH = 2;
				/// <java-name>
				/// APRIL
				/// </java-name>
				[Dot42.DexImport("APRIL", "I", AccessFlags = 25)]
				public const int APRIL = 3;
				/// <java-name>
				/// MAY
				/// </java-name>
				[Dot42.DexImport("MAY", "I", AccessFlags = 25)]
				public const int MAY = 4;
				/// <java-name>
				/// JUNE
				/// </java-name>
				[Dot42.DexImport("JUNE", "I", AccessFlags = 25)]
				public const int JUNE = 5;
				/// <java-name>
				/// JULY
				/// </java-name>
				[Dot42.DexImport("JULY", "I", AccessFlags = 25)]
				public const int JULY = 6;
				/// <java-name>
				/// AUGUST
				/// </java-name>
				[Dot42.DexImport("AUGUST", "I", AccessFlags = 25)]
				public const int AUGUST = 7;
				/// <java-name>
				/// SEPTEMBER
				/// </java-name>
				[Dot42.DexImport("SEPTEMBER", "I", AccessFlags = 25)]
				public const int SEPTEMBER = 8;
				/// <java-name>
				/// OCTOBER
				/// </java-name>
				[Dot42.DexImport("OCTOBER", "I", AccessFlags = 25)]
				public const int OCTOBER = 9;
				/// <java-name>
				/// NOVEMBER
				/// </java-name>
				[Dot42.DexImport("NOVEMBER", "I", AccessFlags = 25)]
				public const int NOVEMBER = 10;
				/// <java-name>
				/// DECEMBER
				/// </java-name>
				[Dot42.DexImport("DECEMBER", "I", AccessFlags = 25)]
				public const int DECEMBER = 11;
				/// <java-name>
				/// UNDECIMBER
				/// </java-name>
				[Dot42.DexImport("UNDECIMBER", "I", AccessFlags = 25)]
				public const int UNDECIMBER = 12;
				/// <java-name>
				/// SUNDAY
				/// </java-name>
				[Dot42.DexImport("SUNDAY", "I", AccessFlags = 25)]
				public const int SUNDAY = 1;
				/// <java-name>
				/// MONDAY
				/// </java-name>
				[Dot42.DexImport("MONDAY", "I", AccessFlags = 25)]
				public const int MONDAY = 2;
				/// <java-name>
				/// TUESDAY
				/// </java-name>
				[Dot42.DexImport("TUESDAY", "I", AccessFlags = 25)]
				public const int TUESDAY = 3;
				/// <java-name>
				/// WEDNESDAY
				/// </java-name>
				[Dot42.DexImport("WEDNESDAY", "I", AccessFlags = 25)]
				public const int WEDNESDAY = 4;
				/// <java-name>
				/// THURSDAY
				/// </java-name>
				[Dot42.DexImport("THURSDAY", "I", AccessFlags = 25)]
				public const int THURSDAY = 5;
				/// <java-name>
				/// FRIDAY
				/// </java-name>
				[Dot42.DexImport("FRIDAY", "I", AccessFlags = 25)]
				public const int FRIDAY = 6;
				/// <java-name>
				/// SATURDAY
				/// </java-name>
				[Dot42.DexImport("SATURDAY", "I", AccessFlags = 25)]
				public const int SATURDAY = 7;
				/// <java-name>
				/// ERA
				/// </java-name>
				[Dot42.DexImport("ERA", "I", AccessFlags = 25)]
				public const int ERA = 0;
				/// <java-name>
				/// YEAR
				/// </java-name>
				[Dot42.DexImport("YEAR", "I", AccessFlags = 25)]
				public const int YEAR = 1;
				/// <java-name>
				/// MONTH
				/// </java-name>
				[Dot42.DexImport("MONTH", "I", AccessFlags = 25)]
				public const int MONTH = 2;
				/// <java-name>
				/// WEEK_OF_YEAR
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_YEAR", "I", AccessFlags = 25)]
				public const int WEEK_OF_YEAR = 3;
				/// <java-name>
				/// WEEK_OF_MONTH
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_MONTH", "I", AccessFlags = 25)]
				public const int WEEK_OF_MONTH = 4;
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "I", AccessFlags = 25)]
				public const int DATE = 5;
				/// <java-name>
				/// DAY_OF_MONTH
				/// </java-name>
				[Dot42.DexImport("DAY_OF_MONTH", "I", AccessFlags = 25)]
				public const int DAY_OF_MONTH = 5;
				/// <java-name>
				/// DAY_OF_YEAR
				/// </java-name>
				[Dot42.DexImport("DAY_OF_YEAR", "I", AccessFlags = 25)]
				public const int DAY_OF_YEAR = 6;
				/// <java-name>
				/// DAY_OF_WEEK
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK = 7;
				/// <java-name>
				/// DAY_OF_WEEK_IN_MONTH
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK_IN_MONTH", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK_IN_MONTH = 8;
				/// <java-name>
				/// AM_PM
				/// </java-name>
				[Dot42.DexImport("AM_PM", "I", AccessFlags = 25)]
				public const int AM_PM = 9;
				/// <java-name>
				/// HOUR
				/// </java-name>
				[Dot42.DexImport("HOUR", "I", AccessFlags = 25)]
				public const int HOUR = 10;
				/// <java-name>
				/// HOUR_OF_DAY
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY", "I", AccessFlags = 25)]
				public const int HOUR_OF_DAY = 11;
				/// <java-name>
				/// MINUTE
				/// </java-name>
				[Dot42.DexImport("MINUTE", "I", AccessFlags = 25)]
				public const int MINUTE = 12;
				/// <java-name>
				/// SECOND
				/// </java-name>
				[Dot42.DexImport("SECOND", "I", AccessFlags = 25)]
				public const int SECOND = 13;
				/// <java-name>
				/// MILLISECOND
				/// </java-name>
				[Dot42.DexImport("MILLISECOND", "I", AccessFlags = 25)]
				public const int MILLISECOND = 14;
				/// <java-name>
				/// ZONE_OFFSET
				/// </java-name>
				[Dot42.DexImport("ZONE_OFFSET", "I", AccessFlags = 25)]
				public const int ZONE_OFFSET = 15;
				/// <java-name>
				/// DST_OFFSET
				/// </java-name>
				[Dot42.DexImport("DST_OFFSET", "I", AccessFlags = 25)]
				public const int DST_OFFSET = 16;
				/// <java-name>
				/// FIELD_COUNT
				/// </java-name>
				[Dot42.DexImport("FIELD_COUNT", "I", AccessFlags = 25)]
				public const int FIELD_COUNT = 17;
				/// <java-name>
				/// AM
				/// </java-name>
				[Dot42.DexImport("AM", "I", AccessFlags = 25)]
				public const int AM = 0;
				/// <java-name>
				/// PM
				/// </java-name>
				[Dot42.DexImport("PM", "I", AccessFlags = 25)]
				public const int PM = 1;
				/// <java-name>
				/// ALL_STYLES
				/// </java-name>
				[Dot42.DexImport("ALL_STYLES", "I", AccessFlags = 25)]
				public const int ALL_STYLES = 0;
				/// <java-name>
				/// SHORT
				/// </java-name>
				[Dot42.DexImport("SHORT", "I", AccessFlags = 25)]
				public const int SHORT = 1;
				/// <java-name>
				/// LONG
				/// </java-name>
				[Dot42.DexImport("LONG", "I", AccessFlags = 25)]
				public const int LONG = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Calendar() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V", AccessFlags = 4)]
				protected internal Calendar(global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(II)V", AccessFlags = 1025)]
				public abstract void Add(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool After(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Before(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 17)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(I)V", AccessFlags = 17)]
				public void Clear(int int32) /* MethodBuilder.Create */ 
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
				/// complete
				/// </java-name>
				[Dot42.DexImport("complete", "()V", AccessFlags = 4)]
				protected internal virtual void Complete() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeFields
				/// </java-name>
				[Dot42.DexImport("computeFields", "()V", AccessFlags = 1028)]
				protected internal abstract void ComputeFields() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// computeTime
				/// </java-name>
				[Dot42.DexImport("computeTime", "()V", AccessFlags = 1028)]
				protected internal abstract void ComputeTime() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 1)]
				public virtual int Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getActualMaximum
				/// </java-name>
				[Dot42.DexImport("getActualMaximum", "(I)I", AccessFlags = 1)]
				public virtual int GetActualMaximum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getActualMinimum
				/// </java-name>
				[Dot42.DexImport("getActualMinimum", "(I)I", AccessFlags = 1)]
				public virtual int GetActualMinimum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGreatestMinimum
				/// </java-name>
				[Dot42.DexImport("getGreatestMinimum", "(I)I", AccessFlags = 1025)]
				public abstract int GetGreatestMinimum(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance(global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <java-name>
				/// getLeastMaximum
				/// </java-name>
				[Dot42.DexImport("getLeastMaximum", "(I)I", AccessFlags = 1025)]
				public abstract int GetLeastMaximum(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaximum
				/// </java-name>
				[Dot42.DexImport("getMaximum", "(I)I", AccessFlags = 1025)]
				public abstract int GetMaximum(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMinimum
				/// </java-name>
				[Dot42.DexImport("getMinimum", "(I)I", AccessFlags = 1025)]
				public abstract int GetMinimum(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// internalGet
				/// </java-name>
				[Dot42.DexImport("internalGet", "(I)I", AccessFlags = 20)]
				protected internal int InternalGet(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isSet
				/// </java-name>
				[Dot42.DexImport("isSet", "(I)Z", AccessFlags = 17)]
				public bool IsSet(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(II)V", AccessFlags = 1)]
				public virtual void Roll(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(IZ)V", AccessFlags = 1025)]
				public abstract void Roll(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(III)V", AccessFlags = 17)]
				public void Set(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIIII)V", AccessFlags = 17)]
				public void Set(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIIIII)V", AccessFlags = 17)]
				public void Set(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLenient
				/// </java-name>
				[Dot42.DexImport("setLenient", "(Z)V", AccessFlags = 1)]
				public virtual void SetLenient(bool boolean) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/Calendar;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayName(int int32, int int321, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayNames
				/// </java-name>
				[Dot42.DexImport("getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;", AccessFlags = 1, Signature = "(IILjava/util/Locale;)Ljava/util/Map<Ljava/lang/String;Ljava/lang/Integer;>;")]
				public virtual global::Java.Util.IMap<string, int?> GetDisplayNames(int int32, int int321, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, int?>);
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 41)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getFirstDayOfWeek
				/// </java-name>
				public virtual int FirstDayOfWeek
				{
						[Dot42.DexImport("getFirstDayOfWeek", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setFirstDayOfWeek", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Util.Calendar Instance
				{
						[Dot42.DexImport("getInstance", "()Ljava/util/Calendar;", AccessFlags = 41)]
						get{ return default(global::Java.Util.Calendar); }
				}

				/// <java-name>
				/// getMinimalDaysInFirstWeek
				/// </java-name>
				public virtual int MinimalDaysInFirstWeek
				{
						[Dot42.DexImport("getMinimalDaysInFirstWeek", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMinimalDaysInFirstWeek", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				public global::Java.Util.Date Time
				{
						[Dot42.DexImport("getTime", "()Ljava/util/Date;", AccessFlags = 17)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setTime", "(Ljava/util/Date;)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				public virtual long TimeInMillis
				{
						[Dot42.DexImport("getTimeInMillis", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setTimeInMillis", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTimeZone
				/// </java-name>
				public virtual global::Java.Util.TimeZone TimeZone
				{
						[Dot42.DexImport("getTimeZone", "()Ljava/util/TimeZone;", AccessFlags = 1)]
						get{ return default(global::Java.Util.TimeZone); }
						[Dot42.DexImport("setTimeZone", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isLenient
				/// </java-name>
				public virtual bool IsLenient
				{
						[Dot42.DexImport("isLenient", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Collections
		/// </java-name>
		[Dot42.DexImport("java/util/Collections", AccessFlags = 33)]
		public partial class Collections
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EMPTY_LIST
				/// </java-name>
				[Dot42.DexImport("EMPTY_LIST", "Ljava/util/List;", AccessFlags = 25)]
				public static readonly global::Java.Util.IList<object> EMPTY_LIST;
				/// <java-name>
				/// EMPTY_SET
				/// </java-name>
				[Dot42.DexImport("EMPTY_SET", "Ljava/util/Set;", AccessFlags = 25)]
				public static readonly global::Java.Util.ISet<object> EMPTY_SET;
				/// <java-name>
				/// EMPTY_MAP
				/// </java-name>
				[Dot42.DexImport("EMPTY_MAP", "Ljava/util/Map;", AccessFlags = 25)]
				public static readonly global::Java.Util.IMap<object, object> EMPTY_MAP;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Collections() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<+Ljava/lang/Comparable<-TT;>;>;TT;)I")]
				public static int BinarySearch<T>(global::Java.Util.IList<global::System.IComparable<T>> list, T t) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<+TT;>;TT;Ljava/util/Comparator<-TT;>;)I")]
				public static int BinarySearch<T>(global::Java.Util.IList<T> list, T t, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "(Ljava/util/List;Ljava/util/List;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<-TT;>;Ljava/util/List<+TT;>;)V")]
				public static void Copy<T>(global::Java.Util.IList<T> list, global::Java.Util.IList<T> list1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enumeration
				/// </java-name>
				[Dot42.DexImport("enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;)Ljava/util/Enumeration<TT;>;")]
				public static global::Java.Util.IEnumeration<T> Enumeration<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<T>);
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "(Ljava/util/List;Ljava/lang/Object;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<-TT;>;TT;)V")]
				public static void Fill<T>(global::Java.Util.IList<T> list, T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;:Ljava/lang/Comparable<-TT;>;>(Ljava/util/Collection<+TT;>;)" +
    "TT;")]
				public static T Max<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+TT;>;Ljava/util/Comparator<-TT;>;)T" +
    "T;")]
				public static T Max<T>(global::Java.Util.ICollection<T> collection, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;:Ljava/lang/Comparable<-TT;>;>(Ljava/util/Collection<+TT;>;)" +
    "TT;")]
				public static T Min<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+TT;>;Ljava/util/Comparator<-TT;>;)T" +
    "T;")]
				public static T Min<T>(global::Java.Util.ICollection<T> collection, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// nCopies
				/// </java-name>
				[Dot42.DexImport("nCopies", "(ILjava/lang/Object;)Ljava/util/List;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(ITT;)Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> NCopies<T>(int int32, T t) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "(Ljava/util/List;)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;)V")]
				public static void Reverse(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reverseOrder
				/// </java-name>
				[Dot42.DexImport("reverseOrder", "()Ljava/util/Comparator;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>()Ljava/util/Comparator<TT;>;")]
				public static global::Java.Util.IComparator<T> ReverseOrder<T>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<T>);
				}

				/// <java-name>
				/// reverseOrder
				/// </java-name>
				[Dot42.DexImport("reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Comparator<TT;>;)Ljava/util/Comparator<TT;>;")]
				public static global::Java.Util.IComparator<T> ReverseOrder<T>(global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<T>);
				}

				/// <java-name>
				/// shuffle
				/// </java-name>
				[Dot42.DexImport("shuffle", "(Ljava/util/List;)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;)V")]
				public static void Shuffle(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shuffle
				/// </java-name>
				[Dot42.DexImport("shuffle", "(Ljava/util/List;Ljava/util/Random;)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;Ljava/util/Random;)V")]
				public static void Shuffle(global::Java.Util.IList<object> list, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// singleton
				/// </java-name>
				[Dot42.DexImport("singleton", "(Ljava/lang/Object;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(TE;)Ljava/util/Set<TE;>;")]
				public static global::Java.Util.ISet<E> Singleton<E>(E e) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <java-name>
				/// singletonList
				/// </java-name>
				[Dot42.DexImport("singletonList", "(Ljava/lang/Object;)Ljava/util/List;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(TE;)Ljava/util/List<TE;>;")]
				public static global::Java.Util.IList<E> SingletonList<E>(E e) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <java-name>
				/// singletonMap
				/// </java-name>
				[Dot42.DexImport("singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Ljava/util/Map<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> SingletonMap<K, V>(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "(Ljava/util/List;)V", AccessFlags = 9, Signature = "<T::Ljava/lang/Comparable<-TT;>;>(Ljava/util/List<TT;>;)V")]
				public static void Sort<T>(global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "(Ljava/util/List;Ljava/util/Comparator;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;Ljava/util/Comparator<-TT;>;)V")]
				public static void Sort<T>(global::Java.Util.IList<T> list, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swap
				/// </java-name>
				[Dot42.DexImport("swap", "(Ljava/util/List;II)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;II)V")]
				public static void Swap(global::Java.Util.IList<object> list, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// replaceAll
				/// </java-name>
				[Dot42.DexImport("replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;TT;TT;)Z")]
				public static bool ReplaceAll<T>(global::Java.Util.IList<T> list, T t, T t1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(Ljava/util/List;I)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;I)V")]
				public static void Rotate(global::Java.Util.IList<object> list, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOfSubList
				/// </java-name>
				[Dot42.DexImport("indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I", AccessFlags = 9, Signature = "(Ljava/util/List<*>;Ljava/util/List<*>;)I")]
				public static int IndexOfSubList(global::Java.Util.IList<object> list, global::Java.Util.IList<object> list1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOfSubList
				/// </java-name>
				[Dot42.DexImport("lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I", AccessFlags = 9, Signature = "(Ljava/util/List<*>;Ljava/util/List<*>;)I")]
				public static int LastIndexOfSubList(global::Java.Util.IList<object> list, global::Java.Util.IList<object> list1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Enumeration<TT;>;)Ljava/util/ArrayList<TT;>;")]
				public static global::Java.Util.ArrayList<T> List<T>(global::Java.Util.IEnumeration<T> enumeration) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <java-name>
				/// synchronizedCollection
				/// </java-name>
				[Dot42.DexImport("synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;)Ljava/util/Collection<TT;>;")]
				public static global::Java.Util.ICollection<T> SynchronizedCollection<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<T>);
				}

				/// <java-name>
				/// synchronizedList
				/// </java-name>
				[Dot42.DexImport("synchronizedList", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;)Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> SynchronizedList<T>(global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <java-name>
				/// synchronizedMap
				/// </java-name>
				[Dot42.DexImport("synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;)Ljava/util/Map" +
    "<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> SynchronizedMap<K, V>(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <java-name>
				/// synchronizedSet
				/// </java-name>
				[Dot42.DexImport("synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;)Ljava/util/Set<TE;>;")]
				public static global::Java.Util.ISet<E> SynchronizedSet<E>(global::Java.Util.ISet<E> set) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <java-name>
				/// synchronizedSortedMap
				/// </java-name>
				[Dot42.DexImport("synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;)Ljava/ut" +
    "il/SortedMap<TK;TV;>;")]
				public static global::Java.Util.ISortedMap<K, V> SynchronizedSortedMap<K, V>(global::Java.Util.ISortedMap<K, V> sortedMap) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <java-name>
				/// synchronizedSortedSet
				/// </java-name>
				[Dot42.DexImport("synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Ljava/util/SortedSet<TE;>;")]
				public static global::Java.Util.ISortedSet<E> SynchronizedSortedSet<E>(global::Java.Util.ISortedSet<E> sortedSet) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <java-name>
				/// unmodifiableCollection
				/// </java-name>
				[Dot42.DexImport("unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Ljava/util/Collection<TE;>;")]
				public static global::Java.Util.ICollection<E> UnmodifiableCollection<E>(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<E>);
				}

				/// <java-name>
				/// unmodifiableList
				/// </java-name>
				[Dot42.DexImport("unmodifiableList", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/List<+TE;>;)Ljava/util/List<TE;>;")]
				public static global::Java.Util.IList<E> UnmodifiableList<E>(global::Java.Util.IList<E> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <java-name>
				/// unmodifiableMap
				/// </java-name>
				[Dot42.DexImport("unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Ljava/util/M" +
    "ap<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> UnmodifiableMap<K, V>(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <java-name>
				/// unmodifiableSet
				/// </java-name>
				[Dot42.DexImport("unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Set<+TE;>;)Ljava/util/Set<TE;>;")]
				public static global::Java.Util.ISet<E> UnmodifiableSet<E>(global::Java.Util.ISet<E> set) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <java-name>
				/// unmodifiableSortedMap
				/// </java-name>
				[Dot42.DexImport("unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;+TV;>;)Ljava/u" +
    "til/SortedMap<TK;TV;>;")]
				public static global::Java.Util.ISortedMap<K, V> UnmodifiableSortedMap<K, V>(global::Java.Util.ISortedMap<K, V> sortedMap) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <java-name>
				/// unmodifiableSortedSet
				/// </java-name>
				[Dot42.DexImport("unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Ljava/util/SortedSet<TE;>;")]
				public static global::Java.Util.ISortedSet<E> UnmodifiableSortedSet<E>(global::Java.Util.ISortedSet<E> sortedSet) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <java-name>
				/// frequency
				/// </java-name>
				[Dot42.DexImport("frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I", AccessFlags = 9, Signature = "(Ljava/util/Collection<*>;Ljava/lang/Object;)I")]
				public static int Frequency(global::Java.Util.ICollection<object> collection, object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// emptyList
				/// </java-name>
				[Dot42.DexImport("emptyList", "()Ljava/util/List;", AccessFlags = 25, Signature = "<T:Ljava/lang/Object;>()Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> EmptyList<T>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <java-name>
				/// emptySet
				/// </java-name>
				[Dot42.DexImport("emptySet", "()Ljava/util/Set;", AccessFlags = 25, Signature = "<T:Ljava/lang/Object;>()Ljava/util/Set<TT;>;")]
				public static global::Java.Util.ISet<T> EmptySet<T>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <java-name>
				/// emptyMap
				/// </java-name>
				[Dot42.DexImport("emptyMap", "()Ljava/util/Map;", AccessFlags = 25, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/Map<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> EmptyMap<K, V>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <java-name>
				/// checkedCollection
				/// </java-name>
				[Dot42.DexImport("checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;Ljava/lang/Class<TE;>;)Ljava/ut" +
    "il/Collection<TE;>;")]
				public static global::Java.Util.ICollection<E> CheckedCollection<E>(global::Java.Util.ICollection<E> collection, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<E>);
				}

				/// <java-name>
				/// checkedMap
				/// </java-name>
				[Dot42.DexImport("checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/lang/Clas" +
    "s<TK;>;Ljava/lang/Class<TV;>;)Ljava/util/Map<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> CheckedMap<K, V>(global::Java.Util.IMap<K, V> map, global::System.Type type, global::System.Type type1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <java-name>
				/// checkedList
				/// </java-name>
				[Dot42.DexImport("checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/Lis" +
    "t<TE;>;")]
				public static global::Java.Util.IList<E> CheckedList<E>(global::Java.Util.IList<E> list, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <java-name>
				/// checkedSet
				/// </java-name>
				[Dot42.DexImport("checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/Set<" +
    "TE;>;")]
				public static global::Java.Util.ISet<E> CheckedSet<E>(global::Java.Util.ISet<E> set, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <java-name>
				/// checkedSortedMap
				/// </java-name>
				[Dot42.DexImport("checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;Ljava/lan" +
    "g/Class<TK;>;Ljava/lang/Class<TV;>;)Ljava/util/SortedMap<TK;TV;>;")]
				public static global::Java.Util.ISortedMap<K, V> CheckedSortedMap<K, V>(global::Java.Util.ISortedMap<K, V> sortedMap, global::System.Type type, global::System.Type type1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <java-name>
				/// checkedSortedSet
				/// </java-name>
				[Dot42.DexImport("checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;Ljava/lang/Class<TE;>;)Ljava/uti" +
    "l/SortedSet<TE;>;")]
				public static global::Java.Util.ISortedSet<E> CheckedSortedSet<E>(global::Java.Util.ISortedSet<E> sortedSet, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<-TT;>;[TT;)Z")]
				public static bool AddAll<T>(global::Java.Util.ICollection<T> collection, params T[] p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// disjoint
				/// </java-name>
				[Dot42.DexImport("disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z", AccessFlags = 9, Signature = "(Ljava/util/Collection<*>;Ljava/util/Collection<*>;)Z")]
				public static bool Disjoint(global::Java.Util.ICollection<object> collection, global::Java.Util.ICollection<object> collection1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newSetFromMap
				/// </java-name>
				[Dot42.DexImport("newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Map<TE;Ljava/lang/Boolean;>;)Ljava/util/Set<TE;" +
    ">;")]
				public static global::Java.Util.ISet<E> NewSetFromMap<E>(global::Java.Util.IMap<E, bool?> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <java-name>
				/// asLifoQueue
				/// </java-name>
				[Dot42.DexImport("asLifoQueue", "(Ljava/util/Deque;)Ljava/util/Queue;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Deque<TT;>;)Ljava/util/Queue<TT;>;")]
				public static global::Java.Util.IQueue<T> AsLifoQueue<T>(global::Java.Util.IDeque<T> deque) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IQueue<T>);
				}

		}

		/// <java-name>
		/// java/util/ConcurrentModificationException
		/// </java-name>
		[Dot42.DexImport("java/util/ConcurrentModificationException", AccessFlags = 33)]
		public partial class ConcurrentModificationException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentModificationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConcurrentModificationException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/Currency
		/// </java-name>
		[Dot42.DexImport("java/util/Currency", AccessFlags = 49)]
		public sealed partial class Currency : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Currency() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/util/Currency;", AccessFlags = 9)]
				public static global::Java.Util.Currency GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;", AccessFlags = 9)]
				public static global::Java.Util.Currency GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <java-name>
				/// getSymbol
				/// </java-name>
				[Dot42.DexImport("getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetSymbol(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// getCurrencyCode
				/// </java-name>
				public string CurrencyCode
				{
						[Dot42.DexImport("getCurrencyCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSymbol
				/// </java-name>
				public string Symbol
				{
						[Dot42.DexImport("getSymbol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDefaultFractionDigits
				/// </java-name>
				public int DefaultFractionDigits
				{
						[Dot42.DexImport("getDefaultFractionDigits", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/util/Date
		/// </java-name>
		[Dot42.DexImport("java/util/Date", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Cloneable;Ljava/lang/Comparabl" +
    "e<Ljava/util/Date;>;")]
		public partial class Date : global::Java.Io.ISerializable, global::Java.Lang.ICloneable, global::System.IComparable<global::Java.Util.Date>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Date() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Date(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public Date(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIIII)V", AccessFlags = 1)]
				public Date(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Date(long int64) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Date(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool After(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool Before(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/Date;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "()I", AccessFlags = 1)]
				public virtual int GetDate() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)J", AccessFlags = 9)]
				public static long Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(I)V", AccessFlags = 1)]
				public virtual void SetDate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toGMTString
				/// </java-name>
				[Dot42.DexImport("toGMTString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToGMTString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toLocaleString
				/// </java-name>
				[Dot42.DexImport("toLocaleString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToLocaleString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// UTC
				/// </java-name>
				[Dot42.DexImport("UTC", "(IIIIII)J", AccessFlags = 9)]
				public static long UTC(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getDay
				/// </java-name>
				public virtual int Day
				{
						[Dot42.DexImport("getDay", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHours
				/// </java-name>
				public virtual int Hours
				{
						[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHours", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMinutes
				/// </java-name>
				public virtual int Minutes
				{
						[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMinutes", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				public virtual int Month
				{
						[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSeconds
				/// </java-name>
				public virtual int Seconds
				{
						[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSeconds", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				public virtual long Time
				{
						[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTimezoneOffset
				/// </java-name>
				public virtual int TimezoneOffset
				{
						[Dot42.DexImport("getTimezoneOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				public virtual int Year
				{
						[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/util/Dictionary
		/// </java-name>
		[Dot42.DexImport("java/util/Dictionary", AccessFlags = 1057, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Dictionary<K, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Dictionary() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<TV;>;")]
				public abstract global::Java.Util.IEnumeration<V> Elements() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				public abstract V Get(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<TK;>;")]
				public abstract global::Java.Util.IEnumeration<K> Keys() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				public abstract V Put(K k, V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				public abstract V Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				public abstract int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public abstract bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/DuplicateFormatFlagsException
		/// </java-name>
		[Dot42.DexImport("java/util/DuplicateFormatFlagsException", AccessFlags = 33)]
		public partial class DuplicateFormatFlagsException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DuplicateFormatFlagsException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DuplicateFormatFlagsException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual string Flags
				{
						[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/EmptyStackException
		/// </java-name>
		[Dot42.DexImport("java/util/EmptyStackException", AccessFlags = 33)]
		public partial class EmptyStackException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EmptyStackException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/EnumMap
		/// </java-name>
		[Dot42.DexImport("java/util/EnumMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava" +
    "/io/Serializable;Ljava/lang/Cloneable;Ljava/util/Map<TK;TV;>;")]
		public partial class EnumMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Io.ISerializable, global::Java.Lang.ICloneable, global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TK;>;)V")]
				public EnumMap(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/EnumMap;)V", AccessFlags = 1, Signature = "(Ljava/util/EnumMap<TK;+TV;>;)V")]
				public EnumMap(global::Java.Util.EnumMap<K, V> enumMap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<TK;+TV;>;)V")]
				public EnumMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/EnumMap;", AccessFlags = 1, Signature = "()Ljava/util/EnumMap<TK;TV;>;")]
				public new virtual global::Java.Util.EnumMap<K, V> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumMap<K, V>);
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
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
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
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
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
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
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
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EnumMap() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/util/Map", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Map", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/EnumSet
		/// </java-name>
		[Dot42.DexImport("java/util/EnumSet", AccessFlags = 1057, Signature = "<E:Ljava/lang/Enum<TE;>;>Ljava/util/AbstractSet<TE;>;Ljava/lang/Cloneable;Ljava/i" +
    "o/Serializable;")]
		public abstract partial class EnumSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EnumSet() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// noneOf
				/// </java-name>
				[Dot42.DexImport("noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> NoneOf<JavaE>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// allOf
				/// </java-name>
				[Dot42.DexImport("allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> AllOf<JavaE>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/util/EnumSet<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> CopyOf<JavaE>(global::Java.Util.EnumSet<JavaE> enumSet) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/util/Collection<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> CopyOf<JavaE>(global::Java.Util.ICollection<JavaE> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// complementOf
				/// </java-name>
				[Dot42.DexImport("complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/util/EnumSet<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> ComplementOf<JavaE>(global::Java.Util.EnumSet<JavaE> enumSet) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE javaE) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE javaE, JavaE javaE1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE javaE, JavaE javaE1, JavaE javaE2) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/Enum" +
    "Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE javaE, JavaE javaE1, JavaE javaE2, JavaE javaE3) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;" +
    ")Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;TE;TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE javaE, JavaE javaE1, JavaE javaE2, JavaE javaE3, JavaE javaE4) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 137, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;[TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE javaE, params JavaE[] p) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// range
				/// </java-name>
				[Dot42.DexImport("range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Range<JavaE>(JavaE javaE, JavaE javaE1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/EnumSet;", AccessFlags = 1, Signature = "()Ljava/util/EnumSet<TE;>;")]
				public virtual global::Java.Util.EnumSet<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<E>);
				}

		}

		/// <java-name>
		/// java/util/EventListenerProxy
		/// </java-name>
		[Dot42.DexImport("java/util/EventListenerProxy", AccessFlags = 1057)]
		public abstract partial class EventListenerProxy : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/EventListener;)V", AccessFlags = 1)]
				public EventListenerProxy(global::Java.Util.IEventListener eventListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EventListenerProxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getListener
				/// </java-name>
				public virtual global::Java.Util.IEventListener Listener
				{
						[Dot42.DexImport("getListener", "()Ljava/util/EventListener;", AccessFlags = 1)]
						get{ return default(global::Java.Util.IEventListener); }
				}

		}

		/// <java-name>
		/// java/util/EventObject
		/// </java-name>
		[Dot42.DexImport("java/util/EventObject", AccessFlags = 33)]
		public partial class EventObject : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// source
				/// </java-name>
				[Dot42.DexImport("source", "Ljava/lang/Object;", AccessFlags = 132)]
				protected internal object @source;
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public EventObject(object @object) /* MethodBuilder.Create */ 
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
				internal EventObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSource
				/// </java-name>
				public virtual object Source
				{
						[Dot42.DexImport("getSource", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

		}

		/// <java-name>
		/// java/util/FormatFlagsConversionMismatchException
		/// </java-name>
		[Dot42.DexImport("java/util/FormatFlagsConversionMismatchException", AccessFlags = 33)]
		public partial class FormatFlagsConversionMismatchException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;C)V", AccessFlags = 1)]
				public FormatFlagsConversionMismatchException(string @string, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FormatFlagsConversionMismatchException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual string Flags
				{
						[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getConversion
				/// </java-name>
				public virtual char Conversion
				{
						[Dot42.DexImport("getConversion", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

		}

		/// <java-name>
		/// java/util/FormattableFlags
		/// </java-name>
		[Dot42.DexImport("java/util/FormattableFlags", AccessFlags = 33)]
		public partial class FormattableFlags
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LEFT_JUSTIFY
				/// </java-name>
				[Dot42.DexImport("LEFT_JUSTIFY", "I", AccessFlags = 25)]
				public const int LEFT_JUSTIFY = 1;
				/// <java-name>
				/// UPPERCASE
				/// </java-name>
				[Dot42.DexImport("UPPERCASE", "I", AccessFlags = 25)]
				public const int UPPERCASE = 2;
				/// <java-name>
				/// ALTERNATE
				/// </java-name>
				[Dot42.DexImport("ALTERNATE", "I", AccessFlags = 25)]
				public const int ALTERNATE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FormattableFlags() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/Formatter
		/// </java-name>
		[Dot42.DexImport("java/util/Formatter", AccessFlags = 49)]
		public sealed partial class Formatter : global::Java.Io.ICloseable, global::Java.Io.IFlushable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Formatter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Appendable;)V", AccessFlags = 1)]
				public Formatter(global::Java.Lang.IAppendable appendable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(global::Java.Lang.IAppendable appendable, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Formatter(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Formatter(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(string @string, string string1, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.File file, string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.OutputStream outputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.OutputStream outputStream, string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// locale
				/// </java-name>
				[Dot42.DexImport("locale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public global::Java.Util.Locale Locale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "()Ljava/lang/Appendable;", AccessFlags = 1)]
				public global::Java.Lang.IAppendable Out() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.IAppendable);
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
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ioException
				/// </java-name>
				[Dot42.DexImport("ioException", "()Ljava/io/IOException;", AccessFlags = 1)]
				public global::System.IO.IOException IoException() /* MethodBuilder.Create */ 
				{
						return default(global::System.IO.IOException);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", AccessFlags = 129)]
				public global::Java.Util.Formatter Format(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", AccessFlags = 129)]
				public global::Java.Util.Formatter Format(global::Java.Util.Locale locale, string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <java-name>
				/// java/util/Formatter$BigDecimalLayoutForm
				/// </java-name>
				[Dot42.DexImport("java/util/Formatter$BigDecimalLayoutForm", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/util/Formatter$BigDecimalLayoutForm;>;")]
				public sealed class BigDecimalLayoutForm
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DECIMAL_FLOAT
						/// </java-name>
						[Dot42.DexImport("DECIMAL_FLOAT", "Ljava/util/Formatter$BigDecimalLayoutForm;", AccessFlags = 16409)]
						public static readonly BigDecimalLayoutForm DECIMAL_FLOAT;
						/// <java-name>
						/// SCIENTIFIC
						/// </java-name>
						[Dot42.DexImport("SCIENTIFIC", "Ljava/util/Formatter$BigDecimalLayoutForm;", AccessFlags = 16409)]
						public static readonly BigDecimalLayoutForm SCIENTIFIC;
						private BigDecimalLayoutForm() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljava/util/Formatter$BigDecimalLayoutForm;", AccessFlags = 9)]
						public static BigDecimalLayoutForm[] Values() /* MethodBuilder.Create */ 
						{
								return default(BigDecimalLayoutForm[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;", AccessFlags = 9)]
						public static BigDecimalLayoutForm ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(BigDecimalLayoutForm);
						}

				}

		}

		/// <java-name>
		/// java/util/FormatterClosedException
		/// </java-name>
		[Dot42.DexImport("java/util/FormatterClosedException", AccessFlags = 33)]
		public partial class FormatterClosedException : global::Java.Lang.IllegalStateException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FormatterClosedException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/GregorianCalendar
		/// </java-name>
		[Dot42.DexImport("java/util/GregorianCalendar", AccessFlags = 33)]
		public partial class GregorianCalendar : global::Java.Util.Calendar
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BC
				/// </java-name>
				[Dot42.DexImport("BC", "I", AccessFlags = 25)]
				public const int BC = 0;
				/// <java-name>
				/// AD
				/// </java-name>
				[Dot42.DexImport("AD", "I", AccessFlags = 25)]
				public const int AD = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GregorianCalendar() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public GregorianCalendar(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public GregorianCalendar(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIIII)V", AccessFlags = 1)]
				public GregorianCalendar(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public GregorianCalendar(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
				public GregorianCalendar(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V", AccessFlags = 1)]
				public GregorianCalendar(global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(II)V", AccessFlags = 1)]
				public override void Add(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// computeFields
				/// </java-name>
				[Dot42.DexImport("computeFields", "()V", AccessFlags = 4)]
				protected internal override void ComputeFields() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeTime
				/// </java-name>
				[Dot42.DexImport("computeTime", "()V", AccessFlags = 4)]
				protected internal override void ComputeTime() /* MethodBuilder.Create */ 
				{
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
				/// getActualMaximum
				/// </java-name>
				[Dot42.DexImport("getActualMaximum", "(I)I", AccessFlags = 1)]
				public override int GetActualMaximum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getActualMinimum
				/// </java-name>
				[Dot42.DexImport("getActualMinimum", "(I)I", AccessFlags = 1)]
				public override int GetActualMinimum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGreatestMinimum
				/// </java-name>
				[Dot42.DexImport("getGreatestMinimum", "(I)I", AccessFlags = 1)]
				public override int GetGreatestMinimum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLeastMaximum
				/// </java-name>
				[Dot42.DexImport("getLeastMaximum", "(I)I", AccessFlags = 1)]
				public override int GetLeastMaximum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaximum
				/// </java-name>
				[Dot42.DexImport("getMaximum", "(I)I", AccessFlags = 1)]
				public override int GetMaximum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimum
				/// </java-name>
				[Dot42.DexImport("getMinimum", "(I)I", AccessFlags = 1)]
				public override int GetMinimum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// isLeapYear
				/// </java-name>
				[Dot42.DexImport("isLeapYear", "(I)Z", AccessFlags = 1)]
				public virtual bool IsLeapYear(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(II)V", AccessFlags = 1)]
				public override void Roll(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(IZ)V", AccessFlags = 1)]
				public override void Roll(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGregorianChange
				/// </java-name>
				[Dot42.DexImport("setGregorianChange", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void SetGregorianChange(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGregorianChange
				/// </java-name>
				public global::Java.Util.Date GregorianChange
				{
						[Dot42.DexImport("getGregorianChange", "()Ljava/util/Date;", AccessFlags = 17)]
						get{ return default(global::Java.Util.Date); }
				}

				/// <java-name>
				/// setFirstDayOfWeek
				/// </java-name>
				public override int FirstDayOfWeek
				{
						[Dot42.DexImport("setFirstDayOfWeek", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMinimalDaysInFirstWeek
				/// </java-name>
				public override int MinimalDaysInFirstWeek
				{
						[Dot42.DexImport("setMinimalDaysInFirstWeek", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/util/HashMap
		/// </java-name>
		[Dot42.DexImport("java/util/HashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/la" +
    "ng/Cloneable;Ljava/io/Serializable;")]
		public partial class HashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HashMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public HashMap(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public HashMap(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public HashMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public new virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
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
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/HashSet
		/// </java-name>
		[Dot42.DexImport("java/util/HashSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/util/Set<TE;>;Ljava/lang/" +
    "Cloneable;Ljava/io/Serializable;")]
		public partial class HashSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.ISet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HashSet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public HashSet(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public HashSet(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public HashSet(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
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
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("java/util/Set", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Set", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Hashtable
		/// </java-name>
		[Dot42.DexImport("java/util/Hashtable", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/Dictionary<TK;TV;>;Ljava/uti" +
    "l/Map<TK;TV;>;Ljava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class Hashtable<K, V> : global::Java.Util.Dictionary<K, V>, global::Java.Util.IMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Hashtable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Hashtable(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public Hashtable(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public Hashtable(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 33)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 33)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool ContainsKey(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool ContainsValue(object @object) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public virtual void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rehash
				/// </java-name>
				[Dot42.DexImport("rehash", "()V", AccessFlags = 4)]
				protected internal virtual void Rehash() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<TK;>;")]
				public virtual global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 33, Signature = "()Ljava/util/Collection<TV;>;")]
				public virtual global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public virtual global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<TK;>;")]
				public override global::Java.Util.IEnumeration<K> Keys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<K>);
				}

				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<TV;>;")]
				public override global::Java.Util.IEnumeration<V> Elements() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<V>);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 33)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Collection
		/// </java-name>
		[Dot42.DexImport("java/util/Collection", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Iterable<TE;>;")]
		public partial interface ICollection<E> : global::Java.Lang.IIterable<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] ToArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/Comparator
		/// </java-name>
		[Dot42.DexImport("java/util/Comparator", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IComparator<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", AccessFlags = 1025, Signature = "(TT;TT;)I")]
				int Compare(T t, T t1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/IdentityHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/IdentityHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/Map<TK;TV;>;Ljava/io/Serializable;Ljava/lang/Cloneable;")]
		public partial class IdentityHashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.IMap<K, V>, global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IdentityHashMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IdentityHashMap(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public IdentityHashMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
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
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public new virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Map", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Deque
		/// </java-name>
		[Dot42.DexImport("java/util/Deque", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Queue<TE;>;")]
		public partial interface IDeque<E> : global::Java.Util.IQueue<E>
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
				/// removeFirst
				/// </java-name>
				[Dot42.DexImport("removeFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E RemoveFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeLast
				/// </java-name>
				[Dot42.DexImport("removeLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E RemoveLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peekFirst
				/// </java-name>
				[Dot42.DexImport("peekFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PeekFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peekLast
				/// </java-name>
				[Dot42.DexImport("peekLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PeekLast() /* MethodBuilder.Create */ ;

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
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Push(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Pop() /* MethodBuilder.Create */ ;

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
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFirst
				/// </java-name>
				E First
				{
						[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
						get;
				}

				/// <java-name>
				/// getLast
				/// </java-name>
				E Last
				{
						[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
						get;
				}

		}

		/// <java-name>
		/// java/util/Enumeration
		/// </java-name>
		[Dot42.DexImport("java/util/Enumeration", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IEnumeration<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E NextElement() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasMoreElements
				/// </java-name>
				bool HasMoreElements
				{
						[Dot42.DexImport("hasMoreElements", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/EventListener
		/// </java-name>
		[Dot42.DexImport("java/util/EventListener", AccessFlags = 1537)]
		public partial interface IEventListener
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/util/Formattable
		/// </java-name>
		[Dot42.DexImport("java/util/Formattable", AccessFlags = 1537)]
		public partial interface IFormattable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// formatTo
				/// </java-name>
				[Dot42.DexImport("formatTo", "(Ljava/util/Formatter;III)V", AccessFlags = 1025)]
				void FormatTo(global::Java.Util.Formatter formatter, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/Iterator
		/// </java-name>
		[Dot42.DexImport("java/util/Iterator", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IIterator<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Next() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1025)]
				void Remove() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasNext
				/// </java-name>
				bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/List
		/// </java-name>
		[Dot42.DexImport("java/util/List", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public partial interface IList<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1025, Signature = "(ITE;)V")]
				void Add(int int32, E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1025, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)TE;")]
				E Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int IndexOf(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int LastIndexOf(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "()Ljava/util/ListIterator<TE;>;")]
				global::Java.Util.IListIterator<E> ListIterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				global::Java.Util.IListIterator<E> ListIterator(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)TE;")]
				E Remove(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(ITE;)TE;")]
				E Set(int int32, E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 1025, Signature = "(II)Ljava/util/List<TE;>;")]
				global::Java.Util.IList<E> SubList(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] ToArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/ListIterator
		/// </java-name>
		[Dot42.DexImport("java/util/ListIterator", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
		public partial interface IListIterator<E> : global::Java.Util.IIterator<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Add(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Next() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nextIndex
				/// </java-name>
				[Dot42.DexImport("nextIndex", "()I", AccessFlags = 1025)]
				int NextIndex() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Previous() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// previousIndex
				/// </java-name>
				[Dot42.DexImport("previousIndex", "()I", AccessFlags = 1025)]
				int PreviousIndex() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1025)]
				void Remove() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Set(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasNext
				/// </java-name>
				bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasPrevious
				/// </java-name>
				bool HasPrevious
				{
						[Dot42.DexImport("hasPrevious", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/IllegalFormatCodePointException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatCodePointException", AccessFlags = 33)]
		public partial class IllegalFormatCodePointException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IllegalFormatCodePointException(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalFormatCodePointException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCodePoint
				/// </java-name>
				public virtual int CodePoint
				{
						[Dot42.DexImport("getCodePoint", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/util/IllegalFormatConversionException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatConversionException", AccessFlags = 33)]
		public partial class IllegalFormatConversionException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(CLjava/lang/Class;)V", AccessFlags = 1, Signature = "(CLjava/lang/Class<*>;)V")]
				public IllegalFormatConversionException(char @char, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalFormatConversionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getArgumentClass
				/// </java-name>
				public virtual global::System.Type ArgumentClass
				{
						[Dot42.DexImport("getArgumentClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

				/// <java-name>
				/// getConversion
				/// </java-name>
				public virtual char Conversion
				{
						[Dot42.DexImport("getConversion", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

		}

		/// <java-name>
		/// java/util/IllegalFormatException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatException", AccessFlags = 33)]
		public partial class IllegalFormatException : global::System.ArgumentException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IllegalFormatException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/IllegalFormatFlagsException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatFlagsException", AccessFlags = 33)]
		public partial class IllegalFormatFlagsException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalFormatFlagsException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalFormatFlagsException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual string Flags
				{
						[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/IllegalFormatPrecisionException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatPrecisionException", AccessFlags = 33)]
		public partial class IllegalFormatPrecisionException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IllegalFormatPrecisionException(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalFormatPrecisionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPrecision
				/// </java-name>
				public virtual int Precision
				{
						[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/util/IllegalFormatWidthException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatWidthException", AccessFlags = 33)]
		public partial class IllegalFormatWidthException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IllegalFormatWidthException(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IllegalFormatWidthException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/util/Map
		/// </java-name>
		[Dot42.DexImport("java/util/Map", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool ContainsKey(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool ContainsValue(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				V Get(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<TK;>;")]
				global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				V Put(K k, V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				V Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1025, Signature = "()Ljava/util/Collection<TV;>;")]
				global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/Map$Entry
		/// </java-name>
		[Dot42.DexImport("java/util/Map$Entry", AccessFlags = 1545, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IMap_IEntry<K, V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TV;)TV;")]
				V SetValue(V v) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getKey
				/// </java-name>
				K Key
				{
						[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TK;")]
						get;
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				V Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
						get;
				}

		}

		/// <java-name>
		/// java/util/NavigableMap
		/// </java-name>
		[Dot42.DexImport("java/util/NavigableMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/SortedMap<" +
    "TK;TV;>;")]
		public partial interface INavigableMap<K, V> : global::Java.Util.ISortedMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lowerEntry
				/// </java-name>
				[Dot42.DexImport("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> LowerEntry(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lowerKey
				/// </java-name>
				[Dot42.DexImport("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K LowerKey(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// floorEntry
				/// </java-name>
				[Dot42.DexImport("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> FloorEntry(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// floorKey
				/// </java-name>
				[Dot42.DexImport("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K FloorKey(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ceilingEntry
				/// </java-name>
				[Dot42.DexImport("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> CeilingEntry(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ceilingKey
				/// </java-name>
				[Dot42.DexImport("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K CeilingKey(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// higherEntry
				/// </java-name>
				[Dot42.DexImport("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> HigherEntry(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// higherKey
				/// </java-name>
				[Dot42.DexImport("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K HigherKey(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// firstEntry
				/// </java-name>
				[Dot42.DexImport("firstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> FirstEntry() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lastEntry
				/// </java-name>
				[Dot42.DexImport("lastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> LastEntry() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollFirstEntry
				/// </java-name>
				[Dot42.DexImport("pollFirstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> PollFirstEntry() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollLastEntry
				/// </java-name>
				[Dot42.DexImport("pollLastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> PollLastEntry() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// navigableKeySet
				/// </java-name>
				[Dot42.DexImport("navigableKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> NavigableKeySet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> SubMap(K k, bool boolean, K k1, bool boolean1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> HeadMap(K k, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> TailMap(K k, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> SubMap(K k, K k1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> HeadMap(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> TailMap(K k) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/NavigableSet
		/// </java-name>
		[Dot42.DexImport("java/util/NavigableSet", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/SortedSet<TE;>;")]
		public partial interface INavigableSet<E> : global::Java.Util.ISortedSet<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lower
				/// </java-name>
				[Dot42.DexImport("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Lower(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Floor(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ceiling
				/// </java-name>
				[Dot42.DexImport("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Ceiling(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// higher
				/// </java-name>
				[Dot42.DexImport("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Higher(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// descendingSet
				/// </java-name>
				[Dot42.DexImport("descendingSet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> DescendingSet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> SubSet(E e, bool boolean, E e1, bool boolean1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> HeadSet(E e, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> TailSet(E e, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> SubSet(E e, E e1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> HeadSet(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> TailSet(E e) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/InputMismatchException
		/// </java-name>
		[Dot42.DexImport("java/util/InputMismatchException", AccessFlags = 33)]
		public partial class InputMismatchException : global::Java.Util.NoSuchElementException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputMismatchException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InputMismatchException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/InvalidPropertiesFormatException
		/// </java-name>
		[Dot42.DexImport("java/util/InvalidPropertiesFormatException", AccessFlags = 33)]
		public partial class InvalidPropertiesFormatException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidPropertiesFormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidPropertiesFormatException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InvalidPropertiesFormatException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/Observer
		/// </java-name>
		[Dot42.DexImport("java/util/Observer", AccessFlags = 1537)]
		public partial interface IObserver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/util/Observable;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Update(global::Java.Util.Observable observable, object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/Queue
		/// </java-name>
		[Dot42.DexImport("java/util/Queue", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public partial interface IQueue<E> : global::Java.Util.ICollection<E>
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
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Element() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Peek() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/RandomAccess
		/// </java-name>
		[Dot42.DexImport("java/util/RandomAccess", AccessFlags = 1537)]
		public partial interface IRandomAccess
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/util/Set
		/// </java-name>
		[Dot42.DexImport("java/util/Set", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public partial interface ISet<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] ToArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/SortedMap
		/// </java-name>
		[Dot42.DexImport("java/util/SortedMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;" +
    ">;")]
		public partial interface ISortedMap<K, V> : global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1025, Signature = "()Ljava/util/Comparator<-TK;>;")]
				global::Java.Util.IComparator<K> Comparator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// firstKey
				/// </java-name>
				[Dot42.DexImport("firstKey", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TK;")]
				K FirstKey() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> HeadMap(K k) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lastKey
				/// </java-name>
				[Dot42.DexImport("lastKey", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TK;")]
				K LastKey() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> SubMap(K k, K k1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> TailMap(K k) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/SortedSet
		/// </java-name>
		[Dot42.DexImport("java/util/SortedSet", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Set<TE;>;")]
		public partial interface ISortedSet<E> : global::Java.Util.ISet<E>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1025, Signature = "()Ljava/util/Comparator<-TE;>;")]
				global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E First() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> HeadSet(E e) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Last() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> SubSet(E e, E e1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> TailSet(E e) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/LinkedHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/LinkedHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/HashMap<TK;TV;>;")]
		public partial class LinkedHashMap<K, V> : global::Java.Util.HashMap<K, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedHashMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedHashMap(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public LinkedHashMap(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IFZ)V", AccessFlags = 1)]
				public LinkedHashMap(int int32, float single, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public LinkedHashMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
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
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsValue(object @object) /* MethodBuilder.Create */ 
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
				/// removeEldestEntry
				/// </java-name>
				[Dot42.DexImport("removeEldestEntry", "(Ljava/util/Map$Entry;)Z", AccessFlags = 4, Signature = "(Ljava/util/Map$Entry<TK;TV;>;)Z")]
				protected internal virtual bool RemoveEldestEntry(global::Java.Util.IMap_IEntry<K, V> map_IEntry) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/util/LinkedHashSet
		/// </java-name>
		[Dot42.DexImport("java/util/LinkedHashSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/HashSet<TE;>;Ljava/util/Set<TE;>;Ljava/lang/Clon" +
    "eable;Ljava/io/Serializable;")]
		public partial class LinkedHashSet<E> : global::Java.Util.HashSet<E>, global::Java.Util.ISet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedHashSet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedHashSet(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public LinkedHashSet(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedHashSet(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("java/util/Set", "add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public override bool Add(E e) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "clear", "()V", AccessFlags = 1025)]
				public override void Clear() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("java/util/Set", "contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Contains(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Set", "iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/Set", "remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Remove(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "size", "()I", AccessFlags = 1025)]
				public override int Size() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
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

				public override bool IsEmpty
				{
						[Dot42.DexImport("java/util/Set", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/LinkedList
		/// </java-name>
		[Dot42.DexImport("java/util/LinkedList", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSequentialList<TE;>;Ljava/util/List<TE;>" +
    ";Ljava/util/Deque<TE;>;Ljava/util/Queue<TE;>;Ljava/lang/Cloneable;Ljava/io/Seria" +
    "lizable;")]
		public partial class LinkedList<E> : global::Java.Util.AbstractSequentialList<E>, global::Java.Util.IList<E>, global::Java.Util.IDeque<E>, global::Java.Util.IQueue<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedList() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedList(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int int32, E e) /* MethodBuilder.Create */ 
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
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
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
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Remove(int int32) /* MethodBuilder.Create */ 
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
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
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
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Push(E e) /* MethodBuilder.Create */ 
				{
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
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public override E Set(int int32, E e) /* MethodBuilder.Create */ 
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
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
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

				[Dot42.DexImport("java/util/List", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/List", "iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/List", "listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "()Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				[Dot42.DexImport("java/util/List", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "subList", "(II)Ljava/util/List;", AccessFlags = 1025, Signature = "(II)Ljava/util/List<TE;>;")]
				public override global::Java.Util.IList<E> SubList(int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <java-name>
				/// getFirst
				/// </java-name>
				public virtual E First
				{
						[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return default(E); }
				}

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
						[Dot42.DexImport("java/util/List", "isEmpty", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/ListResourceBundle
		/// </java-name>
		[Dot42.DexImport("java/util/ListResourceBundle", AccessFlags = 1057)]
		public abstract partial class ListResourceBundle : global::Java.Util.ResourceBundle
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ListResourceBundle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleGetObject
				/// </java-name>
				[Dot42.DexImport("handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				protected internal override object HandleGetObject(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// handleKeySet
				/// </java-name>
				[Dot42.DexImport("handleKeySet", "()Ljava/util/Set;", AccessFlags = 4, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				protected internal override global::Java.Util.ISet<string> HandleKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// getContents
				/// </java-name>
				protected internal abstract object[][] Contents
				{
						[Dot42.DexImport("getContents", "()[[Ljava/lang/Object;", AccessFlags = 1028)]
						get;
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				public override global::Java.Util.IEnumeration<string> Keys
				{
						[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IEnumeration<string>); }
				}

		}

		/// <java-name>
		/// java/util/Locale
		/// </java-name>
		[Dot42.DexImport("java/util/Locale", AccessFlags = 49)]
		public sealed partial class Locale : global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CANADA
				/// </java-name>
				[Dot42.DexImport("CANADA", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CANADA;
				/// <java-name>
				/// CANADA_FRENCH
				/// </java-name>
				[Dot42.DexImport("CANADA_FRENCH", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CANADA_FRENCH;
				/// <java-name>
				/// CHINA
				/// </java-name>
				[Dot42.DexImport("CHINA", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CHINA;
				/// <java-name>
				/// CHINESE
				/// </java-name>
				[Dot42.DexImport("CHINESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CHINESE;
				/// <java-name>
				/// ENGLISH
				/// </java-name>
				[Dot42.DexImport("ENGLISH", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ENGLISH;
				/// <java-name>
				/// FRANCE
				/// </java-name>
				[Dot42.DexImport("FRANCE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale FRANCE;
				/// <java-name>
				/// FRENCH
				/// </java-name>
				[Dot42.DexImport("FRENCH", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale FRENCH;
				/// <java-name>
				/// GERMAN
				/// </java-name>
				[Dot42.DexImport("GERMAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale GERMAN;
				/// <java-name>
				/// GERMANY
				/// </java-name>
				[Dot42.DexImport("GERMANY", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale GERMANY;
				/// <java-name>
				/// ITALIAN
				/// </java-name>
				[Dot42.DexImport("ITALIAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ITALIAN;
				/// <java-name>
				/// ITALY
				/// </java-name>
				[Dot42.DexImport("ITALY", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ITALY;
				/// <java-name>
				/// JAPAN
				/// </java-name>
				[Dot42.DexImport("JAPAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale JAPAN;
				/// <java-name>
				/// JAPANESE
				/// </java-name>
				[Dot42.DexImport("JAPANESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale JAPANESE;
				/// <java-name>
				/// KOREA
				/// </java-name>
				[Dot42.DexImport("KOREA", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale KOREA;
				/// <java-name>
				/// KOREAN
				/// </java-name>
				[Dot42.DexImport("KOREAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale KOREAN;
				/// <java-name>
				/// PRC
				/// </java-name>
				[Dot42.DexImport("PRC", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale PRC;
				/// <java-name>
				/// ROOT
				/// </java-name>
				[Dot42.DexImport("ROOT", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ROOT;
				/// <java-name>
				/// SIMPLIFIED_CHINESE
				/// </java-name>
				[Dot42.DexImport("SIMPLIFIED_CHINESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale SIMPLIFIED_CHINESE;
				/// <java-name>
				/// TAIWAN
				/// </java-name>
				[Dot42.DexImport("TAIWAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale TAIWAN;
				/// <java-name>
				/// TRADITIONAL_CHINESE
				/// </java-name>
				[Dot42.DexImport("TRADITIONAL_CHINESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale TRADITIONAL_CHINESE;
				/// <java-name>
				/// UK
				/// </java-name>
				[Dot42.DexImport("UK", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale UK;
				/// <java-name>
				/// US
				/// </java-name>
				[Dot42.DexImport("US", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale US;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Locale(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Locale(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Locale(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// getDisplayCountry
				/// </java-name>
				[Dot42.DexImport("getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayCountry(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayLanguage
				/// </java-name>
				[Dot42.DexImport("getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayLanguage(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayName(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayVariant
				/// </java-name>
				[Dot42.DexImport("getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayVariant(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Locale() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getCountry
				/// </java-name>
				public string Country
				{
						[Dot42.DexImport("getCountry", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Util.Locale Default
				{
						[Dot42.DexImport("getDefault", "()Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale); }
						[Dot42.DexImport("setDefault", "(Ljava/util/Locale;)V", AccessFlags = 41)]
						set{ }
				}

				/// <java-name>
				/// getDisplayCountry
				/// </java-name>
				public string DisplayCountry
				{
						[Dot42.DexImport("getDisplayCountry", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDisplayLanguage
				/// </java-name>
				public string DisplayLanguage
				{
						[Dot42.DexImport("getDisplayLanguage", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
						[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDisplayVariant
				/// </java-name>
				public string DisplayVariant
				{
						[Dot42.DexImport("getDisplayVariant", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getISO3Country
				/// </java-name>
				public string ISO3Country
				{
						[Dot42.DexImport("getISO3Country", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getISO3Language
				/// </java-name>
				public string ISO3Language
				{
						[Dot42.DexImport("getISO3Language", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getISOCountries
				/// </java-name>
				public static string[] ISOCountries
				{
						[Dot42.DexImport("getISOCountries", "()[Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getISOLanguages
				/// </java-name>
				public static string[] ISOLanguages
				{
						[Dot42.DexImport("getISOLanguages", "()[Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getLanguage
				/// </java-name>
				public string Language
				{
						[Dot42.DexImport("getLanguage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getVariant
				/// </java-name>
				public string Variant
				{
						[Dot42.DexImport("getVariant", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/MissingFormatArgumentException
		/// </java-name>
		[Dot42.DexImport("java/util/MissingFormatArgumentException", AccessFlags = 33)]
		public partial class MissingFormatArgumentException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingFormatArgumentException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MissingFormatArgumentException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFormatSpecifier
				/// </java-name>
				public virtual string FormatSpecifier
				{
						[Dot42.DexImport("getFormatSpecifier", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/MissingFormatWidthException
		/// </java-name>
		[Dot42.DexImport("java/util/MissingFormatWidthException", AccessFlags = 33)]
		public partial class MissingFormatWidthException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingFormatWidthException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MissingFormatWidthException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFormatSpecifier
				/// </java-name>
				public virtual string FormatSpecifier
				{
						[Dot42.DexImport("getFormatSpecifier", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/MissingResourceException
		/// </java-name>
		[Dot42.DexImport("java/util/MissingResourceException", AccessFlags = 33)]
		public partial class MissingResourceException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingResourceException(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MissingResourceException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				public virtual string ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual string Key
				{
						[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/NoSuchElementException
		/// </java-name>
		[Dot42.DexImport("java/util/NoSuchElementException", AccessFlags = 33)]
		public partial class NoSuchElementException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchElementException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchElementException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/Observable
		/// </java-name>
		[Dot42.DexImport("java/util/Observable", AccessFlags = 33)]
		public partial class Observable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Observable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addObserver
				/// </java-name>
				[Dot42.DexImport("addObserver", "(Ljava/util/Observer;)V", AccessFlags = 1)]
				public virtual void AddObserver(global::Java.Util.IObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearChanged
				/// </java-name>
				[Dot42.DexImport("clearChanged", "()V", AccessFlags = 4)]
				protected internal virtual void ClearChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countObservers
				/// </java-name>
				[Dot42.DexImport("countObservers", "()I", AccessFlags = 1)]
				public virtual int CountObservers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deleteObserver
				/// </java-name>
				[Dot42.DexImport("deleteObserver", "(Ljava/util/Observer;)V", AccessFlags = 33)]
				public virtual void DeleteObserver(global::Java.Util.IObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteObservers
				/// </java-name>
				[Dot42.DexImport("deleteObservers", "()V", AccessFlags = 33)]
				public virtual void DeleteObservers() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyObservers
				/// </java-name>
				[Dot42.DexImport("notifyObservers", "()V", AccessFlags = 1)]
				public virtual void NotifyObservers() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyObservers
				/// </java-name>
				[Dot42.DexImport("notifyObservers", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void NotifyObservers(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChanged
				/// </java-name>
				[Dot42.DexImport("setChanged", "()V", AccessFlags = 4)]
				protected internal virtual void SetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasChanged
				/// </java-name>
				public virtual bool HasChanged
				{
						[Dot42.DexImport("hasChanged", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/PriorityQueue
		/// </java-name>
		[Dot42.DexImport("java/util/PriorityQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/io/Serializable;")]
		public partial class PriorityQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PriorityQueue() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PriorityQueue(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/util/Comparator;)V", AccessFlags = 1, Signature = "(ILjava/util/Comparator<-TE;>;)V")]
				public PriorityQueue(int int32, global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public PriorityQueue(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/PriorityQueue;)V", AccessFlags = 1, Signature = "(Ljava/util/PriorityQueue<+TE;>;)V")]
				public PriorityQueue(global::Java.Util.PriorityQueue<E> priorityQueue) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/SortedSet;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedSet<+TE;>;)V")]
				public PriorityQueue(global::Java.Util.ISortedSet<E> sortedSet) /* MethodBuilder.Create */ 
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
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
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
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TE;>;")]
				public virtual global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<E>);
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

		}

		/// <java-name>
		/// java/util/Properties
		/// </java-name>
		[Dot42.DexImport("java/util/Properties", AccessFlags = 33, Signature = "Ljava/util/Hashtable<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public partial class Properties : global::Java.Util.Hashtable<global::System.Object, global::System.Object>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// defaults
				/// </java-name>
				[Dot42.DexImport("defaults", "Ljava/util/Properties;", AccessFlags = 4)]
				protected internal global::Java.Util.Properties Defaults;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Properties() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Properties;)V", AccessFlags = 1)]
				public Properties(global::Java.Util.Properties properties) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public virtual void List(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public virtual void List(global::Java.Io.PrintWriter printWriter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;)V", AccessFlags = 33)]
				public virtual void Load(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/Reader;)V", AccessFlags = 33)]
				public virtual void Load(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// propertyNames
				/// </java-name>
				[Dot42.DexImport("propertyNames", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<*>;")]
				public virtual global::Java.Util.IEnumeration<object> PropertyNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<object>);
				}

				/// <java-name>
				/// stringPropertyNames
				/// </java-name>
				[Dot42.DexImport("stringPropertyNames", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> StringPropertyNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Save(global::Java.Io.OutputStream outputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object SetProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// store
				/// </java-name>
				[Dot42.DexImport("store", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void Store(global::Java.Io.OutputStream outputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// store
				/// </java-name>
				[Dot42.DexImport("store", "(Ljava/io/Writer;Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void Store(global::Java.Io.Writer writer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadFromXML
				/// </java-name>
				[Dot42.DexImport("loadFromXML", "(Ljava/io/InputStream;)V", AccessFlags = 33)]
				public virtual void LoadFromXML(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// storeToXML
				/// </java-name>
				[Dot42.DexImport("storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StoreToXML(global::Java.Io.OutputStream outputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// storeToXML
				/// </java-name>
				[Dot42.DexImport("storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void StoreToXML(global::Java.Io.OutputStream outputStream, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/PropertyPermission
		/// </java-name>
		[Dot42.DexImport("java/util/PropertyPermission", AccessFlags = 49)]
		public sealed partial class PropertyPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PropertyPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/PropertyResourceBundle
		/// </java-name>
		[Dot42.DexImport("java/util/PropertyResourceBundle", AccessFlags = 33)]
		public partial class PropertyResourceBundle : global::Java.Util.ResourceBundle
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public PropertyResourceBundle(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public PropertyResourceBundle(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleKeySet
				/// </java-name>
				[Dot42.DexImport("handleKeySet", "()Ljava/util/Set;", AccessFlags = 4, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				protected internal override global::Java.Util.ISet<string> HandleKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// handleGetObject
				/// </java-name>
				[Dot42.DexImport("handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				protected internal override object HandleGetObject(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyResourceBundle() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				public override global::Java.Util.IEnumeration<string> Keys
				{
						[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IEnumeration<string>); }
				}

		}

		/// <java-name>
		/// java/util/ResourceBundle
		/// </java-name>
		[Dot42.DexImport("java/util/ResourceBundle", AccessFlags = 1057)]
		public abstract partial class ResourceBundle
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parent
				/// </java-name>
				[Dot42.DexImport("parent", "Ljava/util/ResourceBundle;", AccessFlags = 4)]
				protected internal global::Java.Util.ResourceBundle Parent;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResourceBundle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceB" +
    "undle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.Locale locale, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/ResourceBundle$Control;)Ljava/util/ResourceBundle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.ResourceBundle.Control control) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/ResourceBundle$Control;)Ljava/uti" +
    "l/ResourceBundle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.Locale locale, global::Java.Util.ResourceBundle.Control control) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;Ljava/util/ResourceBu" +
    "ndle$Control;)Ljava/util/ResourceBundle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.Locale locale, global::Java.Lang.ClassLoader classLoader, global::Java.Util.ResourceBundle.Control control) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetString(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 17)]
				public string[] GetStringArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// handleGetObject
				/// </java-name>
				[Dot42.DexImport("handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1028)]
				protected internal abstract object HandleGetObject(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Ljava/util/ResourceBundle;)V", AccessFlags = 4)]
				protected internal virtual void SetParent(global::Java.Util.ResourceBundle resourceBundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCache
				/// </java-name>
				[Dot42.DexImport("clearCache", "()V", AccessFlags = 9)]
				public static void ClearCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCache
				/// </java-name>
				[Dot42.DexImport("clearCache", "(Ljava/lang/ClassLoader;)V", AccessFlags = 9)]
				public static void ClearCache(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// handleKeySet
				/// </java-name>
				[Dot42.DexImport("handleKeySet", "()Ljava/util/Set;", AccessFlags = 4, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				protected internal virtual global::Java.Util.ISet<string> HandleKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				public abstract global::Java.Util.IEnumeration<string> Keys
				{
						[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get;
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public virtual global::Java.Util.Locale Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Locale); }
				}

				/// <java-name>
				/// java/util/ResourceBundle$Control
				/// </java-name>
				[Dot42.DexImport("java/util/ResourceBundle$Control", AccessFlags = 9)]
				public partial class Control
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FORMAT_DEFAULT
						/// </java-name>
						[Dot42.DexImport("FORMAT_DEFAULT", "Ljava/util/List;", AccessFlags = 25)]
						public static readonly global::Java.Util.IList<string> FORMAT_DEFAULT;
						/// <java-name>
						/// FORMAT_CLASS
						/// </java-name>
						[Dot42.DexImport("FORMAT_CLASS", "Ljava/util/List;", AccessFlags = 25)]
						public static readonly global::Java.Util.IList<string> FORMAT_CLASS;
						/// <java-name>
						/// FORMAT_PROPERTIES
						/// </java-name>
						[Dot42.DexImport("FORMAT_PROPERTIES", "Ljava/util/List;", AccessFlags = 25)]
						public static readonly global::Java.Util.IList<string> FORMAT_PROPERTIES;
						/// <java-name>
						/// TTL_DONT_CACHE
						/// </java-name>
						[Dot42.DexImport("TTL_DONT_CACHE", "J", AccessFlags = 25)]
						public const long TTL_DONT_CACHE = -1;
						/// <java-name>
						/// TTL_NO_EXPIRATION_CONTROL
						/// </java-name>
						[Dot42.DexImport("TTL_NO_EXPIRATION_CONTROL", "J", AccessFlags = 25)]
						public const long TTL_NO_EXPIRATION_CONTROL = -2;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						protected internal Control() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getControl
						/// </java-name>
						[Dot42.DexImport("getControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;", AccessFlags = 9, Signature = "(Ljava/util/List<Ljava/lang/String;>;)Ljava/util/ResourceBundle$Control;")]
						public static Control GetControl(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
						{
								return default(Control);
						}

						/// <java-name>
						/// getNoFallbackControl
						/// </java-name>
						[Dot42.DexImport("getNoFallbackControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;", AccessFlags = 9, Signature = "(Ljava/util/List<Ljava/lang/String;>;)Ljava/util/ResourceBundle$Control;")]
						public static Control GetNoFallbackControl(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
						{
								return default(Control);
						}

						/// <java-name>
						/// getCandidateLocales
						/// </java-name>
						[Dot42.DexImport("getCandidateLocales", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List<Ljava/util/Locale;>;")]
						public virtual global::Java.Util.IList<global::Java.Util.Locale> GetCandidateLocales(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Java.Util.Locale>);
						}

						/// <java-name>
						/// getFormats
						/// </java-name>
						[Dot42.DexImport("getFormats", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetFormats(string @string) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <java-name>
						/// getFallbackLocale
						/// </java-name>
						[Dot42.DexImport("getFallbackLocale", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/Locale;", AccessFlags = 1)]
						public virtual global::Java.Util.Locale GetFallbackLocale(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.Locale);
						}

						/// <java-name>
						/// newBundle
						/// </java-name>
						[Dot42.DexImport("newBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Z)L" +
    "java/util/ResourceBundle;", AccessFlags = 1)]
						public virtual global::Java.Util.ResourceBundle NewBundle(string @string, global::Java.Util.Locale locale, string string1, global::Java.Lang.ClassLoader classLoader, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.ResourceBundle);
						}

						/// <java-name>
						/// getTimeToLive
						/// </java-name>
						[Dot42.DexImport("getTimeToLive", "(Ljava/lang/String;Ljava/util/Locale;)J", AccessFlags = 1)]
						public virtual long GetTimeToLive(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// needsReload
						/// </java-name>
						[Dot42.DexImport("needsReload", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Lja" +
    "va/util/ResourceBundle;J)Z", AccessFlags = 1)]
						public virtual bool NeedsReload(string @string, global::Java.Util.Locale locale, string string1, global::Java.Lang.ClassLoader classLoader, global::Java.Util.ResourceBundle resourceBundle, long int64) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// toBundleName
						/// </java-name>
						[Dot42.DexImport("toBundleName", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string ToBundleName(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// toResourceName
						/// </java-name>
						[Dot42.DexImport("toResourceName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 17)]
						public string ToResourceName(string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <java-name>
		/// java/util/Scanner
		/// </java-name>
		[Dot42.DexImport("java/util/Scanner", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/util/Iterator<Ljava/lang/String;>;")]
		public sealed partial class Scanner : global::Java.Util.IIterator<string>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Readable;)V", AccessFlags = 1)]
				public Scanner(global::Java.Lang.IReadable readable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/nio/channels/ReadableByteChannel;)V", AccessFlags = 1)]
				public Scanner(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// delimiter
				/// </java-name>
				[Dot42.DexImport("delimiter", "()Ljava/util/regex/Pattern;", AccessFlags = 1)]
				public global::Java.Util.Regex.Pattern Delimiter() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <java-name>
				/// findInLine
				/// </java-name>
				[Dot42.DexImport("findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", AccessFlags = 1)]
				public string FindInLine(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// findInLine
				/// </java-name>
				[Dot42.DexImport("findInLine", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string FindInLine(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// findWithinHorizon
				/// </java-name>
				[Dot42.DexImport("findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;", AccessFlags = 1)]
				public string FindWithinHorizon(global::Java.Util.Regex.Pattern pattern, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// findWithinHorizon
				/// </java-name>
				[Dot42.DexImport("findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 1)]
				public string FindWithinHorizon(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "(Ljava/util/regex/Pattern;)Z", AccessFlags = 1)]
				public bool InvokeHasNext(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool InvokeHasNext(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextBigInteger
				/// </java-name>
				[Dot42.DexImport("hasNextBigInteger", "()Z", AccessFlags = 1)]
				public bool HasNextBigInteger() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextBigInteger
				/// </java-name>
				[Dot42.DexImport("hasNextBigInteger", "(I)Z", AccessFlags = 1)]
				public bool HasNextBigInteger(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextByte
				/// </java-name>
				[Dot42.DexImport("hasNextByte", "()Z", AccessFlags = 1)]
				public bool HasNextByte() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextByte
				/// </java-name>
				[Dot42.DexImport("hasNextByte", "(I)Z", AccessFlags = 1)]
				public bool HasNextByte(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextInt
				/// </java-name>
				[Dot42.DexImport("hasNextInt", "()Z", AccessFlags = 1)]
				public bool HasNextInt() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextInt
				/// </java-name>
				[Dot42.DexImport("hasNextInt", "(I)Z", AccessFlags = 1)]
				public bool HasNextInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextLong
				/// </java-name>
				[Dot42.DexImport("hasNextLong", "()Z", AccessFlags = 1)]
				public bool HasNextLong() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextLong
				/// </java-name>
				[Dot42.DexImport("hasNextLong", "(I)Z", AccessFlags = 1)]
				public bool HasNextLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextShort
				/// </java-name>
				[Dot42.DexImport("hasNextShort", "()Z", AccessFlags = 1)]
				public bool HasNextShort() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNextShort
				/// </java-name>
				[Dot42.DexImport("hasNextShort", "(I)Z", AccessFlags = 1)]
				public bool HasNextShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// ioException
				/// </java-name>
				[Dot42.DexImport("ioException", "()Ljava/io/IOException;", AccessFlags = 1)]
				public global::System.IO.IOException IoException() /* MethodBuilder.Create */ 
				{
						return default(global::System.IO.IOException);
				}

				/// <java-name>
				/// locale
				/// </java-name>
				[Dot42.DexImport("locale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public global::Java.Util.Locale Locale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "()Ljava/util/regex/MatchResult;", AccessFlags = 1)]
				public global::Java.Util.Regex.IMatchResult Match() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/String;", AccessFlags = 1)]
				public string Next() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", AccessFlags = 1)]
				public string Next(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string Next(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextBigDecimal
				/// </java-name>
				[Dot42.DexImport("nextBigDecimal", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public global::Java.Math.BigDecimal NextBigDecimal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// nextBigInteger
				/// </java-name>
				[Dot42.DexImport("nextBigInteger", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public global::Java.Math.BigInteger NextBigInteger() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// nextBigInteger
				/// </java-name>
				[Dot42.DexImport("nextBigInteger", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public global::Java.Math.BigInteger NextBigInteger(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// nextBoolean
				/// </java-name>
				[Dot42.DexImport("nextBoolean", "()Z", AccessFlags = 1)]
				public bool NextBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "()B", AccessFlags = 1)]
				public sbyte JavaNextByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte NextByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "(I)B", AccessFlags = 1)]
				public sbyte JavaNextByte(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "(I)B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte NextByte(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "()D", AccessFlags = 1)]
				public double NextDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextFloat
				/// </java-name>
				[Dot42.DexImport("nextFloat", "()F", AccessFlags = 1)]
				public float NextFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "()I", AccessFlags = 1)]
				public int NextInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "(I)I", AccessFlags = 1)]
				public int NextInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextLine
				/// </java-name>
				[Dot42.DexImport("nextLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public string NextLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "()J", AccessFlags = 1)]
				public long NextLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "(I)J", AccessFlags = 1)]
				public long NextLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// nextShort
				/// </java-name>
				[Dot42.DexImport("nextShort", "()S", AccessFlags = 1)]
				public short NextShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// nextShort
				/// </java-name>
				[Dot42.DexImport("nextShort", "(I)S", AccessFlags = 1)]
				public short NextShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// radix
				/// </java-name>
				[Dot42.DexImport("radix", "()I", AccessFlags = 1)]
				public int Radix() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner Skip(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(Ljava/lang/String;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner Skip(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
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
				/// useDelimiter
				/// </java-name>
				[Dot42.DexImport("useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseDelimiter(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <java-name>
				/// useDelimiter
				/// </java-name>
				[Dot42.DexImport("useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseDelimiter(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <java-name>
				/// useLocale
				/// </java-name>
				[Dot42.DexImport("useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <java-name>
				/// useRadix
				/// </java-name>
				[Dot42.DexImport("useRadix", "(I)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseRadix(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public void Remove() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Scanner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				public bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasNextBigDecimal
				/// </java-name>
				public bool HasNextBigDecimal
				{
						[Dot42.DexImport("hasNextBigDecimal", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasNextBoolean
				/// </java-name>
				public bool HasNextBoolean
				{
						[Dot42.DexImport("hasNextBoolean", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasNextDouble
				/// </java-name>
				public bool HasNextDouble
				{
						[Dot42.DexImport("hasNextDouble", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasNextFloat
				/// </java-name>
				public bool HasNextFloat
				{
						[Dot42.DexImport("hasNextFloat", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasNextLine
				/// </java-name>
				public bool HasNextLine
				{
						[Dot42.DexImport("hasNextLine", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/ServiceConfigurationError
		/// </java-name>
		[Dot42.DexImport("java/util/ServiceConfigurationError", AccessFlags = 33)]
		public partial class ServiceConfigurationError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ServiceConfigurationError(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ServiceConfigurationError(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ServiceConfigurationError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/ServiceLoader
		/// </java-name>
		[Dot42.DexImport("java/util/ServiceLoader", AccessFlags = 49, Signature = "<S:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Iterable<TS;>;")]
		public sealed partial class ServiceLoader<S> : global::Java.Lang.IIterable<S>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ServiceLoader() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reload
				/// </java-name>
				[Dot42.DexImport("reload", "()V", AccessFlags = 1)]
				public void Reload() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TS;>;")]
				public global::Java.Util.IIterator<S> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<S>);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/ServiceLoader;", AccessFlags = 9, Signature = "<S:Ljava/lang/Object;>(Ljava/lang/Class<TS;>;Ljava/lang/ClassLoader;)Ljava/util/S" +
    "erviceLoader<TS;>;")]
				public static global::Java.Util.ServiceLoader<JavaS> Load<JavaS>(global::System.Type type, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ServiceLoader<JavaS>);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;", AccessFlags = 9, Signature = "<S:Ljava/lang/Object;>(Ljava/lang/Class<TS;>;)Ljava/util/ServiceLoader<TS;>;")]
				public static global::Java.Util.ServiceLoader<JavaS> Load<JavaS>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ServiceLoader<JavaS>);
				}

				/// <java-name>
				/// loadInstalled
				/// </java-name>
				[Dot42.DexImport("loadInstalled", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;", AccessFlags = 9, Signature = "<S:Ljava/lang/Object;>(Ljava/lang/Class<TS;>;)Ljava/util/ServiceLoader<TS;>;")]
				public static global::Java.Util.ServiceLoader<JavaS> LoadInstalled<JavaS>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ServiceLoader<JavaS>);
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
		/// java/util/SimpleTimeZone
		/// </java-name>
		[Dot42.DexImport("java/util/SimpleTimeZone", AccessFlags = 33)]
		public partial class SimpleTimeZone : global::Java.Util.TimeZone
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UTC_TIME
				/// </java-name>
				[Dot42.DexImport("UTC_TIME", "I", AccessFlags = 25)]
				public const int UTC_TIME = 2;
				/// <java-name>
				/// STANDARD_TIME
				/// </java-name>
				[Dot42.DexImport("STANDARD_TIME", "I", AccessFlags = 25)]
				public const int STANDARD_TIME = 1;
				/// <java-name>
				/// WALL_TIME
				/// </java-name>
				[Dot42.DexImport("WALL_TIME", "I", AccessFlags = 25)]
				public const int WALL_TIME = 0;
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public SimpleTimeZone(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;IIIIIIII)V", AccessFlags = 1)]
				public SimpleTimeZone(int int32, string @string, int int321, int int322, int int323, int int324, int int325, int int326, int int327, int int328) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;IIIIIIIII)V", AccessFlags = 1)]
				public SimpleTimeZone(int int32, string @string, int int321, int int322, int int323, int int324, int int325, int int326, int int327, int int328, int int329) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;IIIIIIIIIII)V", AccessFlags = 1)]
				public SimpleTimeZone(int int32, string @string, int int321, int int322, int int323, int int324, int int325, int int326, int int327, int int328, int int329, int int3210, int int3211) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(IIIIII)I", AccessFlags = 1)]
				public override int GetOffset(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(J)I", AccessFlags = 1)]
				public override int GetOffset(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hasSameRules
				/// </java-name>
				[Dot42.DexImport("hasSameRules", "(Ljava/util/TimeZone;)Z", AccessFlags = 1)]
				public override bool HasSameRules(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inDaylightTime
				/// </java-name>
				[Dot42.DexImport("inDaylightTime", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public override bool InDaylightTime(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDSTSavings
				/// </java-name>
				[Dot42.DexImport("setDSTSavings", "(I)V", AccessFlags = 1)]
				public virtual void SetDSTSavings(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEndRule
				/// </java-name>
				[Dot42.DexImport("setEndRule", "(III)V", AccessFlags = 1)]
				public virtual void SetEndRule(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEndRule
				/// </java-name>
				[Dot42.DexImport("setEndRule", "(IIII)V", AccessFlags = 1)]
				public virtual void SetEndRule(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEndRule
				/// </java-name>
				[Dot42.DexImport("setEndRule", "(IIIIZ)V", AccessFlags = 1)]
				public virtual void SetEndRule(int int32, int int321, int int322, int int323, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStartRule
				/// </java-name>
				[Dot42.DexImport("setStartRule", "(III)V", AccessFlags = 1)]
				public virtual void SetStartRule(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStartRule
				/// </java-name>
				[Dot42.DexImport("setStartRule", "(IIII)V", AccessFlags = 1)]
				public virtual void SetStartRule(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStartRule
				/// </java-name>
				[Dot42.DexImport("setStartRule", "(IIIIZ)V", AccessFlags = 1)]
				public virtual void SetStartRule(int int32, int int321, int int322, int int323, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStartYear
				/// </java-name>
				[Dot42.DexImport("setStartYear", "(I)V", AccessFlags = 1)]
				public virtual void SetStartYear(int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// useDaylightTime
				/// </java-name>
				[Dot42.DexImport("useDaylightTime", "()Z", AccessFlags = 1)]
				public override bool UseDaylightTime() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SimpleTimeZone() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDSTSavings
				/// </java-name>
				public override int DSTSavings
				{
						[Dot42.DexImport("getDSTSavings", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRawOffset
				/// </java-name>
				public override int RawOffset
				{
						[Dot42.DexImport("getRawOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRawOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/util/Stack
		/// </java-name>
		[Dot42.DexImport("java/util/Stack", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/Vector<TE;>;")]
		public partial class Stack<E> : global::Java.Util.Vector<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Stack() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// empty
				/// </java-name>
				[Dot42.DexImport("empty", "()Z", AccessFlags = 1)]
				public virtual bool Empty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Push(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// search
				/// </java-name>
				[Dot42.DexImport("search", "(Ljava/lang/Object;)I", AccessFlags = 33)]
				public virtual int Search(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// java/util/StringTokenizer
		/// </java-name>
		[Dot42.DexImport("java/util/StringTokenizer", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/util/Enumeration<Ljava/lang/Object;>;")]
		public partial class StringTokenizer : global::Java.Util.IEnumeration<object>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringTokenizer(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public StringTokenizer(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public StringTokenizer(string @string, string string1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countTokens
				/// </java-name>
				[Dot42.DexImport("countTokens", "()I", AccessFlags = 1)]
				public virtual int CountTokens() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object NextElement() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextToken() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextToken(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringTokenizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// hasMoreElements
				/// </java-name>
				public virtual bool HasMoreElements
				{
						[Dot42.DexImport("hasMoreElements", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasMoreTokens
				/// </java-name>
				public virtual bool HasMoreTokens
				{
						[Dot42.DexImport("hasMoreTokens", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/Timer
		/// </java-name>
		[Dot42.DexImport("java/util/Timer", AccessFlags = 33)]
		public partial class Timer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public Timer(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Timer(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public Timer(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Timer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// purge
				/// </java-name>
				[Dot42.DexImport("purge", "()I", AccessFlags = 1)]
				public virtual int Purge() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void Schedule(global::Java.Util.TimerTask timerTask, global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/TimerTask;J)V", AccessFlags = 1)]
				public virtual void Schedule(global::Java.Util.TimerTask timerTask, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/TimerTask;JJ)V", AccessFlags = 1)]
				public virtual void Schedule(global::Java.Util.TimerTask timerTask, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/TimerTask;Ljava/util/Date;J)V", AccessFlags = 1)]
				public virtual void Schedule(global::Java.Util.TimerTask timerTask, global::Java.Util.Date date, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleAtFixedRate
				/// </java-name>
				[Dot42.DexImport("scheduleAtFixedRate", "(Ljava/util/TimerTask;JJ)V", AccessFlags = 1)]
				public virtual void ScheduleAtFixedRate(global::Java.Util.TimerTask timerTask, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleAtFixedRate
				/// </java-name>
				[Dot42.DexImport("scheduleAtFixedRate", "(Ljava/util/TimerTask;Ljava/util/Date;J)V", AccessFlags = 1)]
				public virtual void ScheduleAtFixedRate(global::Java.Util.TimerTask timerTask, global::Java.Util.Date date, long int64) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/TimerTask
		/// </java-name>
		[Dot42.DexImport("java/util/TimerTask", AccessFlags = 1057)]
		public abstract partial class TimerTask : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TimerTask() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduledExecutionTime
				/// </java-name>
				[Dot42.DexImport("scheduledExecutionTime", "()J", AccessFlags = 1)]
				public virtual long ScheduledExecutionTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1025)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				public virtual bool Cancel
				{
						[Dot42.DexImport("cancel", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/TimeZone
		/// </java-name>
		[Dot42.DexImport("java/util/TimeZone", AccessFlags = 1057)]
		public abstract partial class TimeZone : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SHORT
				/// </java-name>
				[Dot42.DexImport("SHORT", "I", AccessFlags = 25)]
				public const int SHORT = 0;
				/// <java-name>
				/// LONG
				/// </java-name>
				[Dot42.DexImport("LONG", "I", AccessFlags = 25)]
				public const int LONG = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeZone() /* MethodBuilder.Create */ 
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
				/// getAvailableIDs
				/// </java-name>
				[Dot42.DexImport("getAvailableIDs", "(I)[Ljava/lang/String;", AccessFlags = 41)]
				public static string[] GetAvailableIDs(int int32) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayName(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(ZI)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayName(bool boolean, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayName(bool boolean, int int32, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(J)I", AccessFlags = 1)]
				public virtual int GetOffset(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(IIIIII)I", AccessFlags = 1025)]
				public abstract int GetOffset(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;", AccessFlags = 41)]
				public static global::Java.Util.TimeZone GetTimeZone(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <java-name>
				/// hasSameRules
				/// </java-name>
				[Dot42.DexImport("hasSameRules", "(Ljava/util/TimeZone;)Z", AccessFlags = 1)]
				public virtual bool HasSameRules(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inDaylightTime
				/// </java-name>
				[Dot42.DexImport("inDaylightTime", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				public abstract bool InDaylightTime(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// useDaylightTime
				/// </java-name>
				[Dot42.DexImport("useDaylightTime", "()Z", AccessFlags = 1025)]
				public abstract bool UseDaylightTime() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAvailableIDs
				/// </java-name>
				public static string[] AvailableIDs
				{
						[Dot42.DexImport("getAvailableIDs", "()[Ljava/lang/String;", AccessFlags = 41)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Util.TimeZone Default
				{
						[Dot42.DexImport("getDefault", "()Ljava/util/TimeZone;", AccessFlags = 41)]
						get{ return default(global::Java.Util.TimeZone); }
						[Dot42.DexImport("setDefault", "(Ljava/util/TimeZone;)V", AccessFlags = 41)]
						set{ }
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
						[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getID
				/// </java-name>
				public virtual string ID
				{
						[Dot42.DexImport("getID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setID", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDSTSavings
				/// </java-name>
				public virtual int DSTSavings
				{
						[Dot42.DexImport("getDSTSavings", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRawOffset
				/// </java-name>
				public abstract int RawOffset
				{
						[Dot42.DexImport("getRawOffset", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setRawOffset", "(I)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// java/util/TooManyListenersException
		/// </java-name>
		[Dot42.DexImport("java/util/TooManyListenersException", AccessFlags = 33)]
		public partial class TooManyListenersException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TooManyListenersException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TooManyListenersException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/TreeMap
		/// </java-name>
		[Dot42.DexImport("java/util/TreeMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/SortedMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;Ljava/lang/Cloneable;Ljava/" +
    "io/Serializable;")]
		public partial class TreeMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.ISortedMap<K, V>, global::Java.Util.INavigableMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TreeMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public TreeMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TK;>;)V")]
				public TreeMap(global::Java.Util.IComparator<K> comparator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/SortedMap;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedMap<TK;+TV;>;)V")]
				public TreeMap(global::Java.Util.ISortedMap<K, V> sortedMap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public new virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
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
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(V);
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
				/// pollFirstEntry
				/// </java-name>
				[Dot42.DexImport("pollFirstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> PollFirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
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
				/// lastEntry
				/// </java-name>
				[Dot42.DexImport("lastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LastEntry() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// lastKey
				/// </java-name>
				[Dot42.DexImport("lastKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K LastKey() /* MethodBuilder.Create */ 
				{
						return default(K);
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
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TK;>;")]
				public virtual global::Java.Util.IComparator<K> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<K>);
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
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
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
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> SubMap(K k, bool boolean, K k1, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				public virtual global::Java.Util.ISortedMap<K, V> SubMap(K k, K k1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> HeadMap(K k, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				public virtual global::Java.Util.ISortedMap<K, V> HeadMap(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> TailMap(K k, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				public virtual global::Java.Util.ISortedMap<K, V> TailMap(K k) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "()Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public virtual global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				[Dot42.DexImport("java/util/Map", "containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool ContainsValue(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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

				[Dot42.DexImport("java/util/Map", "putAll", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("java/util/Map", "values", "()Ljava/util/Collection;", AccessFlags = 1025, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/TreeSet
		/// </java-name>
		[Dot42.DexImport("java/util/TreeSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/util/NavigableSet<TE;>;Lj" +
    "ava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class TreeSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.INavigableSet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TreeSet() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public TreeSet(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TE;>;)V")]
				public TreeSet(global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/SortedSet;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedSet<TE;>;)V")]
				public TreeSet(global::Java.Util.ISortedSet<E> sortedSet) /* MethodBuilder.Create */ 
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
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
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
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
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
				/// higher
				/// </java-name>
				[Dot42.DexImport("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Higher(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
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
				/// ceiling
				/// </java-name>
				[Dot42.DexImport("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Ceiling(E e) /* MethodBuilder.Create */ 
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
				/// descendingSet
				/// </java-name>
				[Dot42.DexImport("descendingSet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> DescendingSet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
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
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				public virtual global::Java.Util.ISortedSet<E> SubSet(E e, E e1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				public virtual global::Java.Util.ISortedSet<E> HeadSet(E e) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				public virtual global::Java.Util.ISortedSet<E> TailSet(E e) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				[Dot42.DexImport("java/util/Set", "containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Set", "removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/UnknownFormatConversionException
		/// </java-name>
		[Dot42.DexImport("java/util/UnknownFormatConversionException", AccessFlags = 33)]
		public partial class UnknownFormatConversionException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownFormatConversionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnknownFormatConversionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getConversion
				/// </java-name>
				public virtual string Conversion
				{
						[Dot42.DexImport("getConversion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/UnknownFormatFlagsException
		/// </java-name>
		[Dot42.DexImport("java/util/UnknownFormatFlagsException", AccessFlags = 33)]
		public partial class UnknownFormatFlagsException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownFormatFlagsException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnknownFormatFlagsException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual string Flags
				{
						[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/UUID
		/// </java-name>
		[Dot42.DexImport("java/util/UUID", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/util/UUID;>;")]
		public sealed partial class UUID : global::Java.Io.ISerializable, global::System.IComparable<global::Java.Util.UUID>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(JJ)V", AccessFlags = 1)]
				public UUID(long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// randomUUID
				/// </java-name>
				[Dot42.DexImport("randomUUID", "()Ljava/util/UUID;", AccessFlags = 9)]
				public static global::Java.Util.UUID RandomUUID() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <java-name>
				/// nameUUIDFromBytes
				/// </java-name>
				[Dot42.DexImport("nameUUIDFromBytes", "([B)Ljava/util/UUID;", AccessFlags = 9)]
				public static global::Java.Util.UUID NameUUIDFromBytes(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <java-name>
				/// nameUUIDFromBytes
				/// </java-name>
				[Dot42.DexImport("nameUUIDFromBytes", "([B)Ljava/util/UUID;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Util.UUID NameUUIDFromBytes(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <java-name>
				/// fromString
				/// </java-name>
				[Dot42.DexImport("fromString", "(Ljava/lang/String;)Ljava/util/UUID;", AccessFlags = 9)]
				public static global::Java.Util.UUID FromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <java-name>
				/// version
				/// </java-name>
				[Dot42.DexImport("version", "()I", AccessFlags = 1)]
				public int Version() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// variant
				/// </java-name>
				[Dot42.DexImport("variant", "()I", AccessFlags = 1)]
				public int Variant() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// timestamp
				/// </java-name>
				[Dot42.DexImport("timestamp", "()J", AccessFlags = 1)]
				public long Timestamp() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// clockSequence
				/// </java-name>
				[Dot42.DexImport("clockSequence", "()I", AccessFlags = 1)]
				public int ClockSequence() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// node
				/// </java-name>
				[Dot42.DexImport("node", "()J", AccessFlags = 1)]
				public long Node() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/UUID;)I", AccessFlags = 1)]
				public int CompareTo(global::Java.Util.UUID uUID) /* MethodBuilder.Create */ 
				{
						return default(int);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UUID() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLeastSignificantBits
				/// </java-name>
				public long LeastSignificantBits
				{
						[Dot42.DexImport("getLeastSignificantBits", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getMostSignificantBits
				/// </java-name>
				public long MostSignificantBits
				{
						[Dot42.DexImport("getMostSignificantBits", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// java/util/Vector
		/// </java-name>
		[Dot42.DexImport("java/util/Vector", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;Ljava/util/List<TE;>;Ljava/uti" +
    "l/RandomAccess;Ljava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class Vector<E> : global::Java.Util.AbstractList<E>, global::Java.Util.IList<E>, global::Java.Util.IRandomAccess, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// elementCount
				/// </java-name>
				[Dot42.DexImport("elementCount", "I", AccessFlags = 4)]
				protected internal int ElementCount;
				/// <java-name>
				/// elementData
				/// </java-name>
				[Dot42.DexImport("elementData", "[Ljava/lang/Object;", AccessFlags = 4)]
				protected internal object[] ElementData;
				/// <java-name>
				/// capacityIncrement
				/// </java-name>
				[Dot42.DexImport("capacityIncrement", "I", AccessFlags = 4)]
				protected internal int CapacityIncrement;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Vector() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Vector(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Vector(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public Vector(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int int32, E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 33, Signature = "(TE;)Z")]
				public override bool Add(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 33, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int int32, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addElement
				/// </java-name>
				[Dot42.DexImport("addElement", "(Ljava/lang/Object;)V", AccessFlags = 33, Signature = "(TE;)V")]
				public virtual void AddElement(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 33)]
				public virtual int Capacity() /* MethodBuilder.Create */ 
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 33)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// copyInto
				/// </java-name>
				[Dot42.DexImport("copyInto", "([Ljava/lang/Object;)V", AccessFlags = 33)]
				public virtual void CopyInto(object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// elementAt
				/// </java-name>
				[Dot42.DexImport("elementAt", "(I)Ljava/lang/Object;", AccessFlags = 33, Signature = "(I)TE;")]
				public virtual E ElementAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<TE;>;")]
				public virtual global::Java.Util.IEnumeration<E> Elements() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<E>);
				}

				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 33)]
				public virtual void EnsureCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// firstElement
				/// </java-name>
				[Dot42.DexImport("firstElement", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E FirstElement() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;I)I", AccessFlags = 33)]
				public virtual int IndexOf(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// insertElementAt
				/// </java-name>
				[Dot42.DexImport("insertElementAt", "(Ljava/lang/Object;I)V", AccessFlags = 33, Signature = "(TE;I)V")]
				public virtual void InsertElementAt(E e, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lastElement
				/// </java-name>
				[Dot42.DexImport("lastElement", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E LastElement() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 33)]
				public override int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;I)I", AccessFlags = 33)]
				public virtual int LastIndexOf(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 33, Signature = "(I)TE;")]
				public override E Remove(int int32) /* MethodBuilder.Create */ 
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
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAllElements
				/// </java-name>
				[Dot42.DexImport("removeAllElements", "()V", AccessFlags = 33)]
				public virtual void RemoveAllElements() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeElement
				/// </java-name>
				[Dot42.DexImport("removeElement", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool RemoveElement(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeElementAt
				/// </java-name>
				[Dot42.DexImport("removeElementAt", "(I)V", AccessFlags = 33)]
				public virtual void RemoveElementAt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeRange
				/// </java-name>
				[Dot42.DexImport("removeRange", "(II)V", AccessFlags = 4)]
				protected internal override void RemoveRange(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(ITE;)TE;")]
				public override E Set(int int32, E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// setElementAt
				/// </java-name>
				[Dot42.DexImport("setElementAt", "(Ljava/lang/Object;I)V", AccessFlags = 33, Signature = "(TE;I)V")]
				public virtual void SetElementAt(E e, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSize
				/// </java-name>
				[Dot42.DexImport("setSize", "(I)V", AccessFlags = 33)]
				public virtual void SetSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 33)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 33, Signature = "(II)Ljava/util/List<TE;>;")]
				public override global::Java.Util.IList<E> SubList(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 33)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] p) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 33)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 33)]
				public virtual void TrimToSize() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("java/util/List", "iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public override global::Java.Util.IIterator<E> Iterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				[Dot42.DexImport("java/util/List", "listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "()Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				[Dot42.DexImport("java/util/List", "listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/WeakHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/WeakHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/Map<TK;TV;>;")]
		public partial class WeakHashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WeakHashMap() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public WeakHashMap(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public WeakHashMap(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public WeakHashMap(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
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
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
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
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object @object) /* MethodBuilder.Create */ 
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
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K k, V v) /* MethodBuilder.Create */ 
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
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public override bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

}

