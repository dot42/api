// Copyright (C) 2014 dot42
//
// Original filename: Java.Util.cs
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
namespace Java.Util
{
		/// <summary>
		/// <para>A <c> FormatterClosedException </c> will be thrown if the formatter has been closed.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/FormatterClosedException
		/// </java-name>
		[Dot42.DexImport("java/util/FormatterClosedException", AccessFlags = 33)]
		public partial class FormatterClosedException : global::Java.Lang.IllegalStateException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> FormatterClosedException </c> with the stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FormatterClosedException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The unchecked exception will be thrown out if there are duplicate flags given out in the format specifier.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/DuplicateFormatFlagsException
		/// </java-name>
		[Dot42.DexImport("java/util/DuplicateFormatFlagsException", AccessFlags = 33)]
		public partial class DuplicateFormatFlagsException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> DuplicateFormatFlagsException </c> with the flags containing duplicates.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DuplicateFormatFlagsException(string f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the format flags that contain a duplicate flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format flags that contain a duplicate flag. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFlags() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Returns the format flags that contain a duplicate flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format flags that contain a duplicate flag. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public string Flags
				{
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFlags(); }
				}

		}

		/// <summary>
		/// <para>An <c> IllegalFormatCodePointException </c> will be thrown if an invalid Unicode code point (defined by Character#isValidCodePoint(int)) is passed as a parameter to a Formatter.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/IllegalFormatCodePointException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatCodePointException", AccessFlags = 33)]
		public partial class IllegalFormatCodePointException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalFormatCodePointException </c> which is specified by the invalid Unicode code point.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IllegalFormatCodePointException(int c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the invalid Unicode code point.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the invalid Unicode code point. </para>
				/// </returns>
				/// <java-name>
				/// getCodePoint
				/// </java-name>
				[Dot42.DexImport("getCodePoint", "()I", AccessFlags = 1)]
				public virtual int GetCodePoint() /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <summary>
				/// <para>Returns the invalid Unicode code point.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the invalid Unicode code point. </para>
				/// </returns>
				/// <java-name>
				/// getCodePoint
				/// </java-name>
				public int CodePoint
				{
				[Dot42.DexImport("getCodePoint", "()I", AccessFlags = 1)]
						get{ return GetCodePoint(); }
				}

		}

		/// <summary>
		/// <para>A <c> List </c> is a collection which maintains an ordering for its elements. Every element in the <c> List </c> has an index. Each element can thus be accessed by its index, with the first index being zero. Normally, <c> List </c> s allow duplicate elements, as compared to Sets, where elements have to be unique. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/List
		/// </java-name>
		[Dot42.DexImport("java/util/List", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public partial interface IList<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Inserts the specified object into this <c> List </c> at the specified location. The object is inserted before the current element at the specified location. If the location is equal to the size of this <c> List </c> , the object is added at the end. If the location is smaller than the size of this <c> List </c> , then all elements beyond the specified location are moved by one position towards the end of the <c> List </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1025, Signature = "(ITE;)V")]
				void Add(int location, E @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds the specified object at the end of this <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>always true. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inserts the objects in the specified collection at the specified location in this <c> List </c> . The objects are added in the order they are returned from the collection's iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this <c> List </c> has been modified through the insertion, false otherwise (i.e. if the passed collection was empty). </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1025, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				bool AddAll(int location, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds the objects in the specified collection to the end of this <c> List </c> . The objects are added in the order in which they are returned from the collection's iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> List </c> is modified, <c> false </c> otherwise (i.e. if the passed collection was empty). </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all elements from this <c> List </c> , leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tests whether this <c> List </c> contains the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is an element of this <c> List </c> , <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tests whether this <c> List </c> contains all objects contained in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if all objects in the specified collection are elements of this <c> List </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the given object with the <c> List </c> , and returns true if they represent the <b>same</b> object using a class specific comparison. For <c> List </c> s, this means that they contain the same elements in exactly the same order.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean <c> true </c> if the object is the same as this object, and <c> false </c> if it is different from this object. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the element at the specified location in this <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified location. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)TE;")]
				E Get(int location) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the hash code for this <c> List </c> . It is calculated by taking each element' hashcode and its position in the <c> List </c> into account.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code of the <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Searches this <c> List </c> for the specified object and returns the index of the first occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first occurrence of the object or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int IndexOf(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this <c> List </c> contains no elements.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> List </c> has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
				bool IsEmpty() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an iterator on the elements of this <c> List </c> . The elements are iterated in the same order as they occur in the <c> List </c> .</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator on the elements of this <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Searches this <c> List </c> for the specified object and returns the index of the last occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last occurrence of the object, or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int LastIndexOf(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> List </c> iterator on the elements of this <c> List </c> . The elements are iterated in the same order that they occur in the <c> List </c> .</para><para><para>ListIterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> List </c> iterator on the elements of this <c> List </c></para>
				/// </returns>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "()Ljava/util/ListIterator<TE;>;")]
				global::Java.Util.IListIterator<E> ListIterator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a list iterator on the elements of this <c> List </c> . The elements are iterated in the same order as they occur in the <c> List </c> . The iteration starts at the specified location.</para><para><para>ListIterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list iterator on the elements of this <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				global::Java.Util.IListIterator<E> ListIterator(int location) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the object at the specified location from this <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)TE;")]
				E Remove(int location) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the object at the specified location from this <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object location) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all occurrences in this <c> List </c> of each object in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> List </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all objects from this <c> List </c> that are not contained in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> List </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Replaces the element at the specified location in this <c> List </c> with the specified object. This operation does not change the size of the <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous element at the index. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(ITE;)TE;")]
				E Set(int location, E @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of elements in this <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> List </c> of the specified portion of this <c> List </c> from the given start index to the end index minus one. The returned <c> List </c> is backed by this <c> List </c> so changes to it are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of a portion of this <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 1025, Signature = "(II)Ljava/util/List<TE;>;")]
				global::Java.Util.IList<E> SubList(int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array containing all elements contained in this <c> List </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] ToArray() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array containing all elements contained in this <c> List </c> . If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this <c> List </c> , the array element following the collection elements is set to null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> List </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				T[] ToArray<T>(T[] array) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/PropertyPermission
		/// </java-name>
		[Dot42.DexImport("java/util/PropertyPermission", AccessFlags = 49)]
		public sealed partial class PropertyPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PropertyPermission(string name, string actions) /* MethodBuilder.Create */ 
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
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newPermissionCollection
				/// </java-name>
				[Dot42.DexImport("newPermissionCollection", "()Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public override global::Java.Security.PermissionCollection NewPermissionCollection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <summary>
		/// <para>A SortedMap extended with navigation methods returning the closest matches for given search targets. Methods <c> lowerEntry </c> , <c> floorEntry </c> , <c> ceilingEntry </c> , and <c> higherEntry </c> return <c> Map.Entry </c> objects associated with keys respectively less than, less than or equal, greater than or equal, and greater than a given key, returning <c> null </c> if there is no such key. Similarly, methods <c> lowerKey </c> , <c> floorKey </c> , <c> ceilingKey </c> , and <c> higherKey </c> return only the associated keys. All of these methods are designed for locating, not traversing entries.</para><para>A <c> NavigableMap </c> may be accessed and traversed in either ascending or descending key order. The <c> descendingMap </c> method returns a view of the map with the senses of all relational and directional methods inverted. The performance of ascending operations and views is likely to be faster than that of descending ones. Methods <c> subMap </c> , <c> headMap </c> , and <c> tailMap </c> differ from the like-named <c>   SortedMap </c> methods in accepting additional arguments describing whether lower and upper bounds are inclusive versus exclusive. Submaps of any <c> NavigableMap </c> must implement the <c>   NavigableMap </c> interface.</para><para>This interface additionally defines methods <c> firstEntry </c> , <c> pollFirstEntry </c> , <c> lastEntry </c> , and <c> pollLastEntry </c> that return and/or remove the least and greatest mappings, if any exist, else returning <c> null </c> .</para><para>Implementations of entry-returning methods are expected to return <c> Map.Entry </c> pairs representing snapshots of mappings at the time they were produced, and thus generally do <b>not</b> support the optional <c> Entry.setValue </c> method. Note however that it is possible to change mappings in the associated map using method <c> put </c> .</para><para>Methods subMap(K, K), headMap(K), and tailMap(K) are specified to return <c> SortedMap </c> to allow existing implementations of <c> SortedMap </c> to be compatibly retrofitted to implement <c> NavigableMap </c> , but extensions and implementations of this interface are encouraged to override these methods to return <c> NavigableMap </c> . Similarly, keySet() can be overriden to return <c> NavigableSet </c> .</para><para><para>Doug Lea </para><simplesectsep></simplesectsep><para>Josh Bloch </para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/NavigableMap
		/// </java-name>
		[Dot42.DexImport("java/util/NavigableMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/SortedMap<" +
    "TK;TV;>;")]
		public partial interface INavigableMap<K, V> : global::Java.Util.ISortedMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns a key-value mapping associated with the least key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the least key, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// firstEntry
				/// </java-name>
				[Dot42.DexImport("firstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> FirstEntry() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a key-value mapping associated with the greatest key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the greatest key, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// lastEntry
				/// </java-name>
				[Dot42.DexImport("lastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> LastEntry() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes and returns a key-value mapping associated with the least key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed first entry of this map, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// pollFirstEntry
				/// </java-name>
				[Dot42.DexImport("pollFirstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> PollFirstEntry() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes and returns a key-value mapping associated with the greatest key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed last entry of this map, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// pollLastEntry
				/// </java-name>
				[Dot42.DexImport("pollLastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> PollLastEntry() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a key-value mapping associated with the least key greater than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the least key greater than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// ceilingEntry
				/// </java-name>
				[Dot42.DexImport("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> CeilingEntry(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the least key greater than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least key greater than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// ceilingKey
				/// </java-name>
				[Dot42.DexImport("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K CeilingKey(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a key-value mapping associated with the least key strictly greater than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the least key greater than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// higherEntry
				/// </java-name>
				[Dot42.DexImport("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> HigherEntry(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the least key strictly greater than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least key greater than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// higherKey
				/// </java-name>
				[Dot42.DexImport("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K HigherKey(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a key-value mapping associated with the greatest key less than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the greatest key less than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// floorEntry
				/// </java-name>
				[Dot42.DexImport("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> FloorEntry(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the greatest key less than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest key less than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// floorKey
				/// </java-name>
				[Dot42.DexImport("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K FloorKey(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a key-value mapping associated with the greatest key strictly less than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the greatest key less than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// lowerEntry
				/// </java-name>
				[Dot42.DexImport("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				global::Java.Util.IMap_IEntry<K, V> LowerEntry(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the greatest key strictly less than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest key less than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// lowerKey
				/// </java-name>
				[Dot42.DexImport("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;)TK;")]
				K LowerKey(K key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a NavigableSet view of the keys contained in this map. The set's iterator returns the keys in ascending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. If the map is modified while an iteration over the set is in progress (except through the iterator's own <c>       remove </c> operation), the results of the iteration are undefined. The set supports element removal, which removes the corresponding mapping from the map, via the <c> Iterator.remove </c> , <c> Set.remove </c> , <c> removeAll </c> , <c> retainAll </c> , and <c> clear </c> operations. It does not support the <c> add </c> or <c> addAll </c> operations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// navigableKeySet
				/// </java-name>
				[Dot42.DexImport("navigableKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> NavigableKeySet() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a reverse order view of the mappings contained in this map. The descending map is backed by this map, so changes to the map are reflected in the descending map, and vice-versa. If either map is modified while an iteration over a collection view of either map is in progress (except through the iterator's own <c> remove </c> operation), the results of the iteration are undefined.</para><para>The returned map has an ordering equivalent to <code>Collections.reverseOrder(comparator())</code>. The expression <c> m.descendingMap().descendingMap() </c> returns a view of <c> m </c> essentially equivalent to <c> m </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a reverse order view of this map </para>
				/// </returns>
				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a reverse order NavigableSet view of the keys contained in this map. The set's iterator returns the keys in descending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. If the map is modified while an iteration over the set is in progress (except through the iterator's own <c>       remove </c> operation), the results of the iteration are undefined. The set supports element removal, which removes the corresponding mapping from the map, via the <c> Iterator.remove </c> , <c> Set.remove </c> , <c> removeAll </c> , <c> retainAll </c> , and <c> clear </c> operations. It does not support the <c> add </c> or <c> addAll </c> operations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a reverse order navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a view of the portion of this map whose keys range from <c> fromKey </c> to <c> toKey </c> . If <c> fromKey </c> and <c> toKey </c> are equal, the returned map is empty unless <c> fromExclusive </c> and <c> toExclusive </c> are both true. The returned map is backed by this map, so changes in the returned map are reflected in this map, and vice-versa. The returned map supports all optional map operations that this map supports.</para><para>The returned map will throw an <c> IllegalArgumentException </c> on an attempt to insert a key outside of its range, or to construct a submap either of whose endpoints lie outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this map whose keys range from <c> fromKey </c> to <c> toKey </c> </para>
				/// </returns>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a view of the portion of this map whose keys are less than (or equal to, if <c> inclusive </c> is true) <c> toKey </c> . The returned map is backed by this map, so changes in the returned map are reflected in this map, and vice-versa. The returned map supports all optional map operations that this map supports.</para><para>The returned map will throw an <c> IllegalArgumentException </c> on an attempt to insert a key outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this map whose keys are less than (or equal to, if <c> inclusive </c> is true) <c> toKey </c> </para>
				/// </returns>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> HeadMap(K toKey, bool inclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a view of the portion of this map whose keys are greater than (or equal to, if <c> inclusive </c> is true) <c> fromKey </c> . The returned map is backed by this map, so changes in the returned map are reflected in this map, and vice-versa. The returned map supports all optional map operations that this map supports.</para><para>The returned map will throw an <c> IllegalArgumentException </c> on an attempt to insert a key outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this map whose keys are greater than (or equal to, if <c> inclusive </c> is true) <c> fromKey </c> </para>
				/// </returns>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1025, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				global::Java.Util.INavigableMap<K, V> TailMap(K fromKey, bool inclusive) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A legacy iteration interface.</para><para>New code should use Iterator instead. <c> Iterator </c> replaces the enumeration interface and adds a way to remove elements from a collection.</para><para>If you <b>have</b> an <c> Enumeration </c> and want a <c> Collection </c> , you can use Collections#list to get a <c> List </c> .</para><para>If you <b>need</b> an <c> Enumeration </c> for a legacy API and have a <c> Collection </c> , you can use Collections#enumeration.</para><para><para>1.0 </para><para>Iterator </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Enumeration
		/// </java-name>
		[Dot42.DexImport("java/util/Enumeration", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IEnumeration<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns whether this <c> Enumeration </c> has more elements.</para><para><para>nextElement </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there are more elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasMoreElements
				/// </java-name>
				[Dot42.DexImport("hasMoreElements", "()Z", AccessFlags = 1025)]
				bool HasMoreElements() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the next element in this <c> Enumeration </c> .</para><para><para>hasMoreElements </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next element.. </para>
				/// </returns>
				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E NextElement() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>EventListener is the superclass of all event listener interfaces.</para><para><para>EventObject </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/EventListener
		/// </java-name>
		[Dot42.DexImport("java/util/EventListener", AccessFlags = 1537)]
		public partial interface IEventListener
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Resizable-array implementation of the Deque interface. Array deques have no capacity restrictions; they grow as necessary to support usage. They are not thread-safe; in the absence of external synchronization, they do not support concurrent access by multiple threads. Null elements are prohibited. This class is likely to be faster than Stack when used as a stack, and faster than LinkedList when used as a queue.</para><para>Most <code>ArrayDeque</code> operations run in amortized constant time. Exceptions include remove, removeFirstOccurrence, removeLastOccurrence, contains, iterator.remove(), and the bulk operations, all of which run in linear time.</para><para>The iterators returned by this class's <code>iterator</code> method are <b>fail-fast</b>: If the deque is modified at any time after the iterator is created, in any way except through the iterator's own <code>remove</code> method, the iterator will generally throw a ConcurrentModificationException. Thus, in the face of concurrent modification, the iterator fails quickly and cleanly, rather than risking arbitrary, non-deterministic behavior at an undetermined time in the future.</para><para>Note that the fail-fast behavior of an iterator cannot be guaranteed as it is, generally speaking, impossible to make any hard guarantees in the presence of unsynchronized concurrent modification. Fail-fast iterators throw <code>ConcurrentModificationException</code> on a best-effort basis. Therefore, it would be wrong to write a program that depended on this exception for its correctness: <b>the fail-fast behavior of iterators should be used only to detect bugs.</b></para><para>This class and its iterator implement all of the <b>optional</b> methods of the Collection and Iterator interfaces.</para><para><para>Josh Bloch and Doug Lea </para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/ArrayDeque
		/// </java-name>
		[Dot42.DexImport("java/util/ArrayDeque", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/Deque<TE;>;Lj" +
    "ava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class ArrayDeque<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.IDeque<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an empty array deque with an initial capacity sufficient to hold 16 elements. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayDeque() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an empty array deque with an initial capacity sufficient to hold the specified number of elements.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayDeque(int numElements) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an empty array deque with an initial capacity sufficient to hold the specified number of elements.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ArrayDeque(global::Java.Util.ICollection<E> numElements) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified element at the front of this deque.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddFirst(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified element at the end of this deque.</para><para>This method is equivalent to add.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddLast(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified element at the front of this deque.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> (as specified by Deque#offerFirst) </para>
				/// </returns>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferFirst(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the specified element at the end of this deque.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> (as specified by Deque#offerLast) </para>
				/// </returns>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferLast(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the specified element at the end of this deque.</para><para>This method is equivalent to offerLast.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> (as specified by Queue#offer) </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the specified element at the end of this deque.</para><para>This method is equivalent to addLast.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> (as specified by Collection#add) </para>
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
				/// <para>Pushes an element onto the stack represented by this deque. In other words, inserts the element at the front of this deque.</para><para>This method is equivalent to addFirst.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Push(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
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
				/// <para>Retrieves and removes the head of the queue represented by this deque.</para><para>This method differs from poll only in that it throws an exception if this deque is empty.</para><para>This method is equivalent to removeFirst.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Pops an element from the stack represented by this deque. In other words, removes and returns the first element of this deque.</para><para>This method is equivalent to removeFirst().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the front of this deque (which is the top of the stack represented by this deque) </para>
				/// </returns>
				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para></para>        
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
				/// <para>Retrieves and removes the first element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque, or <code>null</code> if this deque is empty </para>
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
				/// <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), or returns <code>null</code> if this deque is empty.</para><para>This method is equivalent to pollFirst.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves and removes the last element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque, or <code>null</code> if this deque is empty </para>
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
				/// <para></para>        
				/// </summary>
				/// <java-name>
				/// getFirst
				/// </java-name>
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E GetFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves, but does not remove, the head of the queue represented by this deque. This method differs from peek only in that it throws an exception if this deque is empty.</para><para>This method is equivalent to getFirst.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <java-name>
				/// getLast
				/// </java-name>
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E GetLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves, but does not remove, the first element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque, or <code>null</code> if this deque is empty </para>
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
				/// <para>Retrieves, but does not remove, the head of the queue represented by this deque, or returns <code>null</code> if this deque is empty.</para><para>This method is equivalent to peekFirst.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves, but does not remove, the last element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque, or <code>null</code> if this deque is empty </para>
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
				/// <para>Removes the first occurrence of the specified element in this deque (when traversing the deque from head to tail). If the deque does not contain the element, it is unchanged. More formally, removes the first element <code>e</code> such that <code>o.equals(e)</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the deque contained the specified element </para>
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
				/// <para>Removes a single instance of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <code>e</code> such that <code>o.equals(e)</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para>This method is equivalent to removeFirstOccurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this deque contained the specified element </para>
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
				/// <para>Removes the last occurrence of the specified element in this deque (when traversing the deque from head to tail). If the deque does not contain the element, it is unchanged. More formally, removes the last element <code>e</code> such that <code>o.equals(e)</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the deque contained the specified element </para>
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
				/// <para>Returns the number of elements in this deque.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this deque </para>
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
				/// <para>Returns <code>true</code> if this deque contains no elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this deque contains no elements </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <code>true</code> if this deque contains the specified element. More formally, returns <code>true</code> if and only if this deque contains at least one element <code>e</code> such that <code>o.equals(e)</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this deque contains the specified element </para>
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
				/// <para>Removes all of the elements from this deque. The deque will be empty after this call returns. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of this deque.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of this deque </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/ArrayDeque;", AccessFlags = 1, Signature = "()Ljava/util/ArrayDeque<TE;>;")]
				public virtual global::Java.Util.ArrayDeque<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayDeque<E>);
				}

				/// <summary>
				/// <para>Returns an array containing all of the elements in this deque in proper sequence (from first to last element).</para><para>The returned array will be "safe" in that no references to it are maintained by this deque. (In other words, this method must allocate a new array). The caller is thus free to modify the returned array.</para><para>This method acts as bridge between array-based and collection-based APIs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array containing all of the elements in this deque </para>
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
				/// <para>Returns an array containing all of the elements in this deque in proper sequence (from first to last element); the runtime type of the returned array is that of the specified array. If the deque fits in the specified array, it is returned therein. Otherwise, a new array is allocated with the runtime type of the specified array and the size of this deque.</para><para>If this deque fits in the specified array with room to spare (i.e., the array has more elements than this deque), the element in the array immediately following the end of the deque is set to <code>null</code>.</para><para>Like the toArray() method, this method acts as bridge between array-based and collection-based APIs. Further, this method allows precise control over the runtime type of the output array, and may, under certain circumstances, be used to save allocation costs.</para><para>Suppose <code>x</code> is a deque known to contain only strings. The following code can be used to dump the deque into a newly allocated array of <code>String</code>:</para><para><pre>  String[] y = x.toArray(new String[0]); 
				/// 
				///  </pre></para><para>Note that <code>toArray(new Object[0])</code> is identical in function to <code>toArray()</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array containing all of the elements in this deque </para>
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
				/// <para>Returns an iterator over the elements in this deque. The elements will be ordered from first (head) to last (tail). This is the same order that elements would be dequeued (via successive calls to remove or popped (via successive calls to pop).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator over the elements in this deque </para>
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
				/// <para>Returns an iterator over the elements in this deque in reverse sequential order. The elements will be returned in order from last (tail) to first (head).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator over the elements in this deque in reverse sequence </para>
				/// </returns>
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
				/// <para></para>        
				/// </summary>
				/// <java-name>
				/// getFirst
				/// </java-name>
				public E First
				{
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return GetFirst(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <java-name>
				/// getLast
				/// </java-name>
				public E Last
				{
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return GetLast(); }
				}

		}

		/// <summary>
		/// <para>HashSet is an implementation of a Set. All optional operations (adding and removing) are supported. The elements can be any objects. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/HashSet
		/// </java-name>
		[Dot42.DexImport("java/util/HashSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/util/Set<TE;>;Ljava/lang/" +
    "Cloneable;Ljava/io/Serializable;")]
		public partial class HashSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.ISet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty instance of <c> HashSet </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HashSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> HashSet </c> with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public HashSet(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> HashSet </c> with the specified capacity and load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public HashSet(int capacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> HashSet </c> with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public HashSet(global::Java.Util.ICollection<E> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object to this <c> HashSet </c> if not already present.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> when this <c> HashSet </c> did not already contain the object, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all elements from this <c> HashSet </c> , leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> HashSet </c> with the same elements and size as this <c> HashSet </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> HashSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Searches this <c> HashSet </c> for the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is an element of this <c> HashSet </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this <c> HashSet </c> has no elements, false otherwise.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> HashSet </c> has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an Iterator on the elements of this <c> HashSet </c> .</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an Iterator on the elements of this <c> HashSet </c> . </para>
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
				/// <para>Removes the specified object from this <c> HashSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the object was removed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of elements in this <c> HashSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this <c> HashSet </c> . </para>
				/// </returns>
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>A specific moment in time, with millisecond precision. Values typically come from System#currentTimeMillis, and are always UTC, regardless of the system's time zone. This is often called "Unix time" or "epoch time".</para><para>Instances of this class are suitable for comparison, but little else. Use java.text.DateFormat to format a <c> Date </c> for display to a human. Use Calendar to break down a <c> Date </c> if you need to extract fields such as the current month or day of week, or to construct a <c> Date </c> from a broken-down time. That is: this class' deprecated display-related functionality is now provided by <c> DateFormat </c> , and this class' deprecated computational functionality is now provided by <c> Calendar </c> . Both of these other classes (and their subclasses) allow you to interpret a <c> Date </c> in a given time zone.</para><para>Note that, surprisingly, instances of this class are mutable. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Date
		/// </java-name>
		[Dot42.DexImport("java/util/Date", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Cloneable;Ljava/lang/Comparabl" +
    "e<Ljava/util/Date;>;")]
		public partial class Date : global::Java.Io.ISerializable, global::Java.Lang.ICloneable, global::System.IComparable<global::Java.Util.Date>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Initializes this <c> Date </c> instance to the current time. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Date() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Date </c> initialized to midnight in the default <c> TimeZone </c> on the specified date.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use GregorianCalendar#GregorianCalendar(int, int, int) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Date(int year, int month, int day) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Date </c> initialized to the specified date and time in the default <c> TimeZone </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use GregorianCalendar#GregorianCalendar(int, int, int, int, int) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public Date(int year, int month, int day, int hour, int minute) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Date </c> initialized to the specified date and time in the default <c> TimeZone </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use GregorianCalendar#GregorianCalendar(int, int, int, int, int, int) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIIII)V", AccessFlags = 1)]
				public Date(int year, int month, int day, int hour, int minute, int second) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns if this <c> Date </c> is after the specified Date.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Date </c> is after the specified <c> Date </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool After(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns if this <c> Date </c> is before the specified Date.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Date </c> is before the specified <c> Date </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool Before(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a new <c> Date </c> with the same millisecond value as this <c> Date </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> Date </c> .</para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compare the receiver to the specified <c> Date </c> to determine the relative ordering.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> int &lt; 0 </c> if this <c> Date </c> is less than the specified <c> Date </c> , <c> 0 </c> if they are equal, and an <c> int &gt; 0 </c> if this <c> Date </c> is greater. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/Date;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified object to this <c> Date </c> and returns if they are equal. To be equal, the object must be an instance of <c> Date </c> and have the same millisecond value.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Date </c> , <c> false </c> otherwise.</para>
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
				/// <para>Returns the gregorian calendar day of the month for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.DATE) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the day of the month.</para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "()I", AccessFlags = 1)]
				public virtual int GetDate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar day of the week for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.DAY_OF_WEEK) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the day of the week.</para>
				/// </returns>
				/// <java-name>
				/// getDay
				/// </java-name>
				[Dot42.DexImport("getDay", "()I", AccessFlags = 1)]
				public virtual int GetDay() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar hour of the day for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.HOUR_OF_DAY) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the hour of the day.</para>
				/// </returns>
				/// <java-name>
				/// getHours
				/// </java-name>
				[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
				public virtual int GetHours() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar minute of the hour for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.MINUTE) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the minutes.</para>
				/// </returns>
				/// <java-name>
				/// getMinutes
				/// </java-name>
				[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
				public virtual int GetMinutes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar month for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.MONTH) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the month.</para>
				/// </returns>
				/// <java-name>
				/// getMonth
				/// </java-name>
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
				public virtual int GetMonth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar second of the minute for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.SECOND) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the seconds.</para>
				/// </returns>
				/// <java-name>
				/// getSeconds
				/// </java-name>
				[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
				public virtual int GetSeconds() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this <c> Date </c> as a millisecond value. The value is the number of milliseconds since Jan. 1, 1970, midnight GMT.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds since Jan. 1, 1970, midnight GMT. </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
				public virtual long GetTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the timezone offset in minutes of the default <c> TimeZone </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use </para></xrefdescription></xrefsect><c> (Calendar.get(Calendar.ZONE_OFFSET) + Calendar.get(Calendar.DST_OFFSET)) / 60000 </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the timezone offset in minutes of the default <c> TimeZone </c> .</para>
				/// </returns>
				/// <java-name>
				/// getTimezoneOffset
				/// </java-name>
				[Dot42.DexImport("getTimezoneOffset", "()I", AccessFlags = 1)]
				public virtual int GetTimezoneOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar year since 1900 for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.YEAR) - 1900 </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the year - 1900.</para>
				/// </returns>
				/// <java-name>
				/// getYear
				/// </java-name>
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
				public virtual int GetYear() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. Objects which are equal return the same value for this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Date </c> 's hash.</para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the millisecond value of the date and time parsed from the specified <c> String </c> . Many date/time formats are recognized, including IETF standard syntax, i.e. Tue, 22 Jun 1999 12:16:00 GMT-0500</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use DateFormat </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the millisecond value parsed from the String.</para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)J", AccessFlags = 9)]
				public static long Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the gregorian calendar day of the month for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.set(Calendar.DATE, day) </c> </para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(I)V", AccessFlags = 1)]
				public virtual void SetDate(int day) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the gregorian calendar hour of the day for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.set(Calendar.HOUR_OF_DAY, hour) </c> </para>        
				/// </summary>
				/// <java-name>
				/// setHours
				/// </java-name>
				[Dot42.DexImport("setHours", "(I)V", AccessFlags = 1)]
				public virtual void SetHours(int hour) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the gregorian calendar minute of the hour for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.set(Calendar.MINUTE, minute) </c> </para>        
				/// </summary>
				/// <java-name>
				/// setMinutes
				/// </java-name>
				[Dot42.DexImport("setMinutes", "(I)V", AccessFlags = 1)]
				public virtual void SetMinutes(int minute) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the gregorian calendar month for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.set(Calendar.MONTH, month) </c> </para>        
				/// </summary>
				/// <java-name>
				/// setMonth
				/// </java-name>
				[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1)]
				public virtual void SetMonth(int month) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the gregorian calendar second of the minute for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.set(Calendar.SECOND, second) </c> </para>        
				/// </summary>
				/// <java-name>
				/// setSeconds
				/// </java-name>
				[Dot42.DexImport("setSeconds", "(I)V", AccessFlags = 1)]
				public virtual void SetSeconds(int second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this <c> Date </c> to the specified millisecond value. The value is the number of milliseconds since Jan. 1, 1970 GMT.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public virtual void SetTime(long milliseconds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the gregorian calendar year since 1900 for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.set(Calendar.YEAR, year + 1900) </c> </para>        
				/// </summary>
				/// <java-name>
				/// setYear
				/// </java-name>
				[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1)]
				public virtual void SetYear(int year) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the string representation of this <c> Date </c> in GMT in the format <c> "22 Jun 1999 13:02:00 GMT" </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use DateFormat </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// toGMTString
				/// </java-name>
				[Dot42.DexImport("toGMTString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToGMTString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the string representation of this <c> Date </c> for the default <c> Locale </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use DateFormat </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// toLocaleString
				/// </java-name>
				[Dot42.DexImport("toLocaleString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToLocaleString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string representation of this <c> Date </c> . The formatting is equivalent to using a <c> SimpleDateFormat </c> with the format string "EEE MMM dd HH:mm:ss zzz yyyy", which looks something like "Tue Jun 22 13:07:00 PDT 1999". The current default time zone and locale are used. If you need control over the time zone or locale, use <c> SimpleDateFormat </c> instead. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the millisecond value of the specified date and time in GMT.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use: <code> Calendar cal = new GregorianCalendar(TimeZone.getTimeZone("GMT")); cal.set(year + 1900, month, day, hour, minute, second); cal.getTime().getTime();</code> </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the date and time in GMT in milliseconds.</para>
				/// </returns>
				/// <java-name>
				/// UTC
				/// </java-name>
				[Dot42.DexImport("UTC", "(IIIIII)J", AccessFlags = 9)]
				public static long UTC(int year, int month, int day, int hour, int minute, int second) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the gregorian calendar day of the week for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.DAY_OF_WEEK) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the day of the week.</para>
				/// </returns>
				/// <java-name>
				/// getDay
				/// </java-name>
				public int Day
				{
				[Dot42.DexImport("getDay", "()I", AccessFlags = 1)]
						get{ return GetDay(); }
				}

				/// <summary>
				/// <para>Returns the gregorian calendar hour of the day for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.HOUR_OF_DAY) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the hour of the day.</para>
				/// </returns>
				/// <java-name>
				/// getHours
				/// </java-name>
				public int Hours
				{
				[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
						get{ return GetHours(); }
				[Dot42.DexImport("setHours", "(I)V", AccessFlags = 1)]
						set{ SetHours(value); }
				}

				/// <summary>
				/// <para>Returns the gregorian calendar minute of the hour for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.MINUTE) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the minutes.</para>
				/// </returns>
				/// <java-name>
				/// getMinutes
				/// </java-name>
				public int Minutes
				{
				[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
						get{ return GetMinutes(); }
				[Dot42.DexImport("setMinutes", "(I)V", AccessFlags = 1)]
						set{ SetMinutes(value); }
				}

				/// <summary>
				/// <para>Returns the gregorian calendar month for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.MONTH) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the month.</para>
				/// </returns>
				/// <java-name>
				/// getMonth
				/// </java-name>
				public int Month
				{
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return GetMonth(); }
				[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1)]
						set{ SetMonth(value); }
				}

				/// <summary>
				/// <para>Returns the gregorian calendar second of the minute for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.SECOND) </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the seconds.</para>
				/// </returns>
				/// <java-name>
				/// getSeconds
				/// </java-name>
				public int Seconds
				{
				[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
						get{ return GetSeconds(); }
				[Dot42.DexImport("setSeconds", "(I)V", AccessFlags = 1)]
						set{ SetSeconds(value); }
				}

				/// <summary>
				/// <para>Returns this <c> Date </c> as a millisecond value. The value is the number of milliseconds since Jan. 1, 1970, midnight GMT.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds since Jan. 1, 1970, midnight GMT. </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				public long Time
				{
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return GetTime(); }
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ SetTime(value); }
				}

				/// <summary>
				/// <para>Returns the timezone offset in minutes of the default <c> TimeZone </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use </para></xrefdescription></xrefsect><c> (Calendar.get(Calendar.ZONE_OFFSET) + Calendar.get(Calendar.DST_OFFSET)) / 60000 </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the timezone offset in minutes of the default <c> TimeZone </c> .</para>
				/// </returns>
				/// <java-name>
				/// getTimezoneOffset
				/// </java-name>
				public int TimezoneOffset
				{
				[Dot42.DexImport("getTimezoneOffset", "()I", AccessFlags = 1)]
						get{ return GetTimezoneOffset(); }
				}

				/// <summary>
				/// <para>Returns the gregorian calendar year since 1900 for this <c> Date </c> object.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use</para></xrefdescription></xrefsect><c> Calendar.get(Calendar.YEAR) - 1900 </c> </para>        
				/// </summary>
				/// <returns>
				/// <para>the year - 1900.</para>
				/// </returns>
				/// <java-name>
				/// getYear
				/// </java-name>
				public int Year
				{
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return GetYear(); }
				[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1)]
						set{ SetYear(value); }
				}

		}

		/// <summary>
		/// <para>An <c> UnknownFormatConversionException </c> will be thrown if the format conversion is unknown.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/UnknownFormatConversionException
		/// </java-name>
		[Dot42.DexImport("java/util/UnknownFormatConversionException", AccessFlags = 33)]
		public partial class UnknownFormatConversionException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> UnknownFormatConversionException </c> with the unknown format conversion.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownFormatConversionException(string s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the conversion associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the conversion associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getConversion
				/// </java-name>
				[Dot42.DexImport("getConversion", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetConversion() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Returns the conversion associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the conversion associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getConversion
				/// </java-name>
				public string Conversion
				{
				[Dot42.DexImport("getConversion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetConversion(); }
				}

		}

		/// <summary>
		/// <para>ArrayList is an implementation of List, backed by an array. All optional operations including adding, removing, and replacing elements are supported.</para><para>All elements are permitted, including null.</para><para>This class is a good choice as your default <c> List </c> implementation. Vector synchronizes all operations, but not necessarily in a way that's meaningful to your application: synchronizing each call to <c> get </c> , for example, is not equivalent to synchronizing the list and iterating over it (which is probably what you intended). java.util.concurrent.CopyOnWriteArrayList is intended for the special case of very high concurrency, frequent traversals, and very rare mutations.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/ArrayList
		/// </java-name>
		[Dot42.DexImport("java/util/ArrayList", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;Ljava/lang/Cloneable;Ljava/io/" +
    "Serializable;Ljava/util/RandomAccess;")]
		public partial class ArrayList<E> : global::Java.Util.AbstractList<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable, global::Java.Util.IRandomAccess
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of <c> ArrayList </c> with the specified initial capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayList(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ArrayList </c> instance with zero initial capacity. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> ArrayList </c> with the specified initial capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public ArrayList(global::Java.Util.ICollection<E> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object at the end of this <c> ArrayList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>always true </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the specified object into this <c> ArrayList </c> at the specified location. The object is inserted before any previous element at the specified location. If the location is equal to the size of this <c> ArrayList </c> , the object is added at the end.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int index, E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the objects in the specified collection to this <c> ArrayList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> ArrayList </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the objects in the specified collection at the specified location in this List. The objects are added in the order they are returned from the collection's iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> ArrayList </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int index, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all elements from this <c> ArrayList </c> , leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>#size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> ArrayList </c> with the same elements, the same size and the same capacity as this <c> ArrayList </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> ArrayList </c> </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Ensures that after this operation the <c> ArrayList </c> can hold the specified number of elements without further growing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 1)]
				public virtual void EnsureCapacity(int minimumCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the element at the specified location in this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the number of elements in this <c> ArrayList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this <c> ArrayList </c> . </para>
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
				/// <para>Returns if this <c> Collection </c> contains no elements. This implementation tests, whether <c> size </c> returns 0.</para><para><para>#size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> has no elements, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Searches this <c> ArrayList </c> for the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is an element of this <c> ArrayList </c> , <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Searches this list for the specified object and returns the index of the first occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first occurrence of the object, or -1 if it was not found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches this list for the specified object and returns the index of the last occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last occurrence of the object, or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Remove(int index) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes the objects in the specified range from the start to the end index minus one.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeRange
				/// </java-name>
				[Dot42.DexImport("removeRange", "(II)V", AccessFlags = 4)]
				protected internal override void RemoveRange(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Replaces the element at the specified location in this <c> ArrayList </c> with the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous element at the index. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public override E Set(int index, E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns a new array containing all elements contained in this <c> ArrayList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> ArrayList </c> </para>
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
				/// <para>Returns an array containing all elements contained in this <c> ArrayList </c> . If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this <c> ArrayList </c> , the array element following the collection elements is set to null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> ArrayList </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] contents) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				/// <para>Sets the capacity of this <c> ArrayList </c> to be the same as the current size.</para><para><para>#size </para></para>        
				/// </summary>
				/// <java-name>
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 1)]
				public virtual void TrimToSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an iterator on the elements of this list. The elements are iterated in the same order as they occur in the list.</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator on the elements of this list. </para>
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
				/// <para>Returns the hash code of this list. The hash code is calculated by taking each element's hashcode into account.</para><para><para>equals </para><simplesectsep></simplesectsep><para>List::hashCode() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified object to this list and return true if they are equal. Two lists are equal when they both contain the same objects in the same order.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this list, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>An <c> IllegalFormatConversionException </c> will be thrown when the parameter is incompatible with the corresponding format specifier.</para><para><para>java.lang.RuntimeException</para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/IllegalFormatConversionException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatConversionException", AccessFlags = 33)]
		public partial class IllegalFormatConversionException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalFormatConversionException </c> with the class of the mismatched conversion and corresponding parameter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(CLjava/lang/Class;)V", AccessFlags = 1, Signature = "(CLjava/lang/Class<*>;)V")]
				public IllegalFormatConversionException(char c, global::System.Type arg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the class of the mismatched parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the class of the mismatched parameter. </para>
				/// </returns>
				/// <java-name>
				/// getArgumentClass
				/// </java-name>
				[Dot42.DexImport("getArgumentClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public virtual global::System.Type GetArgumentClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the incompatible conversion.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the incompatible conversion. </para>
				/// </returns>
				/// <java-name>
				/// getConversion
				/// </java-name>
				[Dot42.DexImport("getConversion", "()C", AccessFlags = 1)]
				public virtual char GetConversion() /* MethodBuilder.Create */ 
				{
						return default(char);
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

				/// <summary>
				/// <para>Returns the class of the mismatched parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the class of the mismatched parameter. </para>
				/// </returns>
				/// <java-name>
				/// getArgumentClass
				/// </java-name>
				public global::System.Type ArgumentClass
				{
				[Dot42.DexImport("getArgumentClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetArgumentClass(); }
				}

				/// <summary>
				/// <para>Returns the incompatible conversion.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the incompatible conversion. </para>
				/// </returns>
				/// <java-name>
				/// getConversion
				/// </java-name>
				public char Conversion
				{
				[Dot42.DexImport("getConversion", "()C", AccessFlags = 1)]
						get{ return GetConversion(); }
				}

		}

		/// <summary>
		/// <para>A SortedSet extended with navigation methods reporting closest matches for given search targets. Methods <c> lower </c> , <c> floor </c> , <c> ceiling </c> , and <c> higher </c> return elements respectively less than, less than or equal, greater than or equal, and greater than a given element, returning <c> null </c> if there is no such element. A <c> NavigableSet </c> may be accessed and traversed in either ascending or descending order. The <c>   descendingSet </c> method returns a view of the set with the senses of all relational and directional methods inverted. The performance of ascending operations and views is likely to be faster than that of descending ones. This interface additionally defines methods <c> pollFirst </c> and <c> pollLast </c> that return and remove the lowest and highest element, if one exists, else returning <c>   null </c> . Methods <c> subSet </c> , <c> headSet </c> , and <c> tailSet </c> differ from the like-named <c>   SortedSet </c> methods in accepting additional arguments describing whether lower and upper bounds are inclusive versus exclusive. Subsets of any <c> NavigableSet </c> must implement the <c>   NavigableSet </c> interface.</para><para>The return values of navigation methods may be ambiguous in implementations that permit <c> null </c> elements. However, even in this case the result can be disambiguated by checking <c> contains(null) </c> . To avoid such issues, implementations of this interface are encouraged to <b>not</b> permit insertion of <c> null </c> elements. (Note that sorted sets of Comparable elements intrinsically do not permit <c> null </c> .)</para><para>Methods subSet(E, E), headSet(E), and tailSet(E) are specified to return <c> SortedSet </c> to allow existing implementations of <c> SortedSet </c> to be compatibly retrofitted to implement <c> NavigableSet </c> , but extensions and implementations of this interface are encouraged to override these methods to return <c> NavigableSet </c> .</para><para><para>Doug Lea </para><simplesectsep></simplesectsep><para>Josh Bloch </para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/NavigableSet
		/// </java-name>
		[Dot42.DexImport("java/util/NavigableSet", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/SortedSet<TE;>;")]
		public partial interface INavigableSet<E> : global::Java.Util.ISortedSet<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Retrieves and removes the first (lowest) element, or returns <c> null </c> if this set is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first element, or <c> null </c> if this set is empty </para>
				/// </returns>
				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the last (highest) element, or returns <c> null </c> if this set is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last element, or <c> null </c> if this set is empty </para>
				/// </returns>
				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollLast() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the least element in this set strictly greater than the given element, or <c> null </c> if there is no such element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least element greater than <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// higher
				/// </java-name>
				[Dot42.DexImport("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Higher(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the least element in this set greater than or equal to the given element, or <c> null </c> if there is no such element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least element greater than or equal to <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// ceiling
				/// </java-name>
				[Dot42.DexImport("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Ceiling(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the greatest element in this set strictly less than the given element, or <c> null </c> if there is no such element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest element less than <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// lower
				/// </java-name>
				[Dot42.DexImport("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Lower(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the greatest element in this set less than or equal to the given element, or <c> null </c> if there is no such element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest element less than or equal to <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TE;)TE;")]
				E Floor(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an iterator over the elements in this set, in descending order. Equivalent in effect to <c> descendingSet().iterator() </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator over the elements in this set, in descending order </para>
				/// </returns>
				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a reverse order view of the elements contained in this set. The descending set is backed by this set, so changes to the set are reflected in the descending set, and vice-versa. If either set is modified while an iteration over either set is in progress (except through the iterator's own <c> remove </c> operation), the results of the iteration are undefined.</para><para>The returned set has an ordering equivalent to <code>Collections.reverseOrder(comparator())</code>. The expression <c> s.descendingSet().descendingSet() </c> returns a view of <c> s </c> essentially equivalent to <c> s </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a reverse order view of this set </para>
				/// </returns>
				/// <java-name>
				/// descendingSet
				/// </java-name>
				[Dot42.DexImport("descendingSet", "()Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "()Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> DescendingSet() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a view of the portion of this set whose elements range from <c> fromElement </c> to <c> toElement </c> . If <c> fromElement </c> and <c> toElement </c> are equal, the returned set is empty unless <c>       fromExclusive </c> and <c> toExclusive </c> are both true. The returned set is backed by this set, so changes in the returned set are reflected in this set, and vice-versa. The returned set supports all optional set operations that this set supports.</para><para>The returned set will throw an <c> IllegalArgumentException </c> on an attempt to insert an element outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this set whose elements range from <c> fromElement </c> , inclusive, to <c> toElement </c> , exclusive </para>
				/// </returns>
				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> SubSet(E fromElement, bool fromInclusive, E toElement, bool toInclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a view of the portion of this set whose elements are less than (or equal to, if <c> inclusive </c> is true) <c> toElement </c> . The returned set is backed by this set, so changes in the returned set are reflected in this set, and vice-versa. The returned set supports all optional set operations that this set supports.</para><para>The returned set will throw an <c> IllegalArgumentException </c> on an attempt to insert an element outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this set whose elements are less than (or equal to, if <c> inclusive </c> is true) <c> toElement </c> </para>
				/// </returns>
				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> HeadSet(E toElement, bool inclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a view of the portion of this set whose elements are greater than (or equal to, if <c> inclusive </c> is true) <c> fromElement </c> . The returned set is backed by this set, so changes in the returned set are reflected in this set, and vice-versa. The returned set supports all optional set operations that this set supports.</para><para>The returned set will throw an <c> IllegalArgumentException </c> on an attempt to insert an element outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this set whose elements are greater than or equal to <c> fromElement </c> </para>
				/// </returns>
				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1025, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				global::Java.Util.INavigableSet<E> TailSet(E fromElement, bool inclusive) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The <c> BitSet </c> class implements a . Each element is either true or false. A <c> BitSet </c> is created with a given size and grows automatically if this size is exceeded. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/BitSet
		/// </java-name>
		[Dot42.DexImport("java/util/BitSet", AccessFlags = 33)]
		public partial class BitSet : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> BitSet </c> with size equal to 64 bits. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BitSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> BitSet </c> with size equal to <c> bitCount </c> , rounded up to a multiple of 64.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public BitSet(int bitCount) /* MethodBuilder.Create */ 
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
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the bit at index <c> index </c> . Indexes greater than the current length return false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Z", AccessFlags = 1)]
				public virtual bool Get(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a new <c> BitSet </c> containing the range of bits <c> [fromIndex, toIndex) </c> , shifted down so that the bit at <c> fromIndex </c> is at bit 0 in the new <c> BitSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)Ljava/util/BitSet;", AccessFlags = 1)]
				public virtual global::Java.Util.BitSet Get(int fromIndex, int toIndex) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.BitSet);
				}

				/// <summary>
				/// <para>Sets the bit at index <c> index </c> to true.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(I)V", AccessFlags = 1)]
				public virtual void Set(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the range of bits <c> [fromIndex, toIndex) </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IZ)V", AccessFlags = 1)]
				public virtual void Set(int fromIndex, bool toIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the range of bits <c> [fromIndex, toIndex) </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 1)]
				public virtual void Set(int fromIndex, int toIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the range of bits <c> [fromIndex, toIndex) </c> to <c> state </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIZ)V", AccessFlags = 1)]
				public virtual void Set(int fromIndex, int toIndex, bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears all the bits in this <c> BitSet </c> . This method does not change the capacity. Use <c> clear </c> if you want to reuse this <c> BitSet </c> with the same capacity, but create a new <c> BitSet </c> if you're trying to potentially reclaim memory. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the bit at index <c> index </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(I)V", AccessFlags = 1)]
				public virtual void Clear(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the range of bits <c> [fromIndex, toIndex) </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(II)V", AccessFlags = 1)]
				public virtual void Clear(int fromIndex, int toIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Flips the bit at index <c> index </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flip
				/// </java-name>
				[Dot42.DexImport("flip", "(I)V", AccessFlags = 1)]
				public virtual void Flip(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Flips the range of bits <c> [fromIndex, toIndex) </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flip
				/// </java-name>
				[Dot42.DexImport("flip", "(II)V", AccessFlags = 1)]
				public virtual void Flip(int fromIndex, int toIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if <c> this.and(bs) </c> is non-empty, but may be faster than computing that. </para>        
				/// </summary>
				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(Ljava/util/BitSet;)Z", AccessFlags = 1)]
				public virtual bool Intersects(global::Java.Util.BitSet bs) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Logically ands the bits of this <c> BitSet </c> with <c> bs </c> . </para>        
				/// </summary>
				/// <java-name>
				/// and
				/// </java-name>
				[Dot42.DexImport("and", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void And(global::Java.Util.BitSet bs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears all bits in this <c> BitSet </c> which are also set in <c> bs </c> . </para>        
				/// </summary>
				/// <java-name>
				/// andNot
				/// </java-name>
				[Dot42.DexImport("andNot", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void AndNot(global::Java.Util.BitSet bs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Logically ors the bits of this <c> BitSet </c> with <c> bs </c> . </para>        
				/// </summary>
				/// <java-name>
				/// or
				/// </java-name>
				[Dot42.DexImport("or", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void Or(global::Java.Util.BitSet bs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Logically xors the bits of this <c> BitSet </c> with <c> bs </c> . </para>        
				/// </summary>
				/// <java-name>
				/// xor
				/// </java-name>
				[Dot42.DexImport("xor", "(Ljava/util/BitSet;)V", AccessFlags = 1)]
				public virtual void Xor(global::Java.Util.BitSet bs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the capacity in bits of the array implementing this <c> BitSet </c> . This is unrelated to the length of the <c> BitSet </c> , and not generally useful. Use nextSetBit to iterate, or length to find the highest set bit. </para>        
				/// </summary>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of bits up to and including the highest bit set. This is unrelated to the size of the <c> BitSet </c> . </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the receiver: a comma-delimited list of the indexes of all set bits. For example: <c> "{0,1,8}" </c> . </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the index of the first bit that is set on or after <c> index </c> , or -1 if no higher bits are set. </para>        
				/// </summary>
				/// <java-name>
				/// nextSetBit
				/// </java-name>
				[Dot42.DexImport("nextSetBit", "(I)I", AccessFlags = 1)]
				public virtual int NextSetBit(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the index of the first bit that is clear on or after <c> index </c> . Since all bits past the end are implicitly clear, this never returns -1. </para>        
				/// </summary>
				/// <java-name>
				/// nextClearBit
				/// </java-name>
				[Dot42.DexImport("nextClearBit", "(I)I", AccessFlags = 1)]
				public virtual int NextClearBit(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns true if all the bits in this <c> BitSet </c> are set to false, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of bits that are <c> true </c> in this <c> BitSet </c> . </para>        
				/// </summary>
				/// <java-name>
				/// cardinality
				/// </java-name>
				[Dot42.DexImport("cardinality", "()I", AccessFlags = 1)]
				public virtual int Cardinality() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>An AbstractSet is an abstract implementation of the Set interface. This implementation does not support adding. A subclass must implement the abstract methods iterator() and size().</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/AbstractSet
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractSet", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/Set<TE;>;")]
		public abstract partial class AbstractSet<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.ISet<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this AbstractSet. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the specified object to this Set and returns true if they are equal. The object must be an instance of Set and contain the same objects.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this set, <c> false </c> otherwise </para>
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
				/// <para>Returns the hash code for this set. Two set which are equal must return the same value. This implementation calculates the hash code by adding each element's hash code.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code of this set. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Removes all occurrences in this collection which are contained in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this collection was modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/Set", "add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				[Dot42.DexImport("java/util/Set", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>An EnumSet is a specialized Set to be used with enums as keys. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates an empty enum set. The permitted elements are of type Class&lt;E&gt;.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty enum set, with permitted elements of type <c>               elementType </c> . </para>
				/// </returns>
				/// <java-name>
				/// noneOf
				/// </java-name>
				[Dot42.DexImport("noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> NoneOf<JavaE>(global::System.Type elementType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates an enum set filled with all the enum elements of the specified <c> elementType </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set with elements solely from the specified element type. </para>
				/// </returns>
				/// <java-name>
				/// allOf
				/// </java-name>
				[Dot42.DexImport("allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> AllOf<JavaE>(global::System.Type elementType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates an enum set. The contained elements are the same as those contained in collection <c> c </c> . If c is an enum set, invoking this method is the same as invoking copyOf(EnumSet).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set with all the elements from the specified collection. </para>
				/// </returns>
				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/util/EnumSet<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> CopyOf<JavaE>(global::Java.Util.EnumSet<JavaE> c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates an enum set. The contained elements are the same as those contained in collection <c> c </c> . If c is an enum set, invoking this method is the same as invoking copyOf(EnumSet).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set with all the elements from the specified collection. </para>
				/// </returns>
				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/util/Collection<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> CopyOf<JavaE>(global::Java.Util.ICollection<JavaE> c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates an enum set. All the contained elements complement those from the specified enum set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set with all the elements complementary to those from the specified enum set. </para>
				/// </returns>
				/// <java-name>
				/// complementOf
				/// </java-name>
				[Dot42.DexImport("complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(Ljava/util/EnumSet<TE;>;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> ComplementOf<JavaE>(global::Java.Util.EnumSet<JavaE> s) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates a new enum set, containing only the specified element. There are six overloadings of the method. They accept from one to five elements respectively. The sixth one receives an arbitrary number of elements, and runs slower than those that only receive a fixed number of elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set containing the specified element. </para>
				/// </returns>
				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE e) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Creates a new enum set, containing only the specified elements. There are six overloadings of the method. They accept from one to five elements respectively. The sixth one receives an arbitrary number of elements, and runs slower than those that only receive a fixed number of elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set containing the specified elements. </para>
				/// </returns>
				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE e1, JavaE e2, JavaE e3) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates a new enum set, containing only the specified elements. There are six overloadings of the method. They accept from one to five elements respectively. The sixth one receives an arbitrary number of elements, and runs slower than those that only receive a fixed number of elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set containing the specified elements. </para>
				/// </returns>
				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/Enum" +
    "Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE e1, JavaE e2, JavaE e3, JavaE e4) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates a new enum set, containing only the specified elements. There are six overloadings of the method. They accept from one to five elements respectively. The sixth one receives an arbitrary number of elements, and runs slower than those that only receive a fixed number of elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set containing the specified elements. </para>
				/// </returns>
				/// <java-name>
				/// of
				/// </java-name>
				[Dot42.DexImport("of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;" +
    ")Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;TE;TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Of<JavaE>(JavaE e1, JavaE e2, JavaE e3, JavaE e4, JavaE e5) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Creates an enum set containing all the elements within the range defined by <c> start </c> and <c> end </c> (inclusive). All the elements must be in order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enum set with elements in the range from start to end. </para>
				/// </returns>
				/// <java-name>
				/// range
				/// </java-name>
				[Dot42.DexImport("range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Enum<TE;>;>(TE;TE;)Ljava/util/EnumSet<TE;>;")]
				public static global::Java.Util.EnumSet<JavaE> Range<JavaE>(JavaE start, JavaE end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<JavaE>);
				}

				/// <summary>
				/// <para>Creates a new enum set with the same elements as those contained in this enum set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new enum set with the same elements as those contained in this enum set. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/EnumSet;", AccessFlags = 1, Signature = "()Ljava/util/EnumSet<TE;>;")]
				public virtual global::Java.Util.EnumSet<E> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumSet<E>);
				}

		}

		/// <summary>
		/// <para>An <c> Map </c> specialized for use with <c> Enum </c> types as keys. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Removes all elements from this <c> EnumMap </c> , leaving it empty.</para><para><para>isEmpty() </para><simplesectsep></simplesectsep><para>size() </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a shallow copy of this <c> EnumMap </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> EnumMap </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/util/EnumMap;", AccessFlags = 1, Signature = "()Ljava/util/EnumMap<TK;TV;>;")]
				public new virtual global::Java.Util.EnumMap<K, V> Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.EnumMap<K, V>);
				}

				/// <summary>
				/// <para>Returns whether this <c> EnumMap </c> contains the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> EnumMap </c> contains the specified key, <c> false </c> otherwise. </para>
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
				/// <para>Returns whether this <c> EnumMap </c> contains the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> EnumMap </c> contains the specified value, <c> false </c> otherwise. </para>
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
				/// <para>Returns a <c> Set </c> containing all of the mappings in this <c> EnumMap </c> . Each mapping is an instance of Map.Entry. As the <c> Set </c> is backed by this <c> EnumMap </c> , changes in one will be reflected in the other. </para><para>The order of the entries in the set will be the order that the enum keys were declared in.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Set </c> of the mappings. </para>
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
				/// <para>Compares the argument to the receiver, and returns <c> true </c> if the specified <c> Object </c> is an <c> EnumMap </c> and both <c> EnumMap </c> s contain the same mappings.</para><para><para>hashCode() </para><simplesectsep></simplesectsep><para>entrySet() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean <c> true </c> if <c> object </c> is the same as this <c> EnumMap </c> , <c> false </c> otherwise. </para>
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
				/// <para>Returns the value of the mapping with the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns a set of the keys contained in this <c> EnumMap </c> . The <c> Set </c> is backed by this <c> EnumMap </c> so changes to one are reflected in the other. The <c> Set </c> does not support adding. </para><para>The order of the set will be the order that the enum keys were declared in.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Set </c> of the keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para>Maps the specified key to the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no mapping. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public override V Put(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Copies every mapping in the specified <c> Map </c> to this <c> EnumMap </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes a mapping with the specified key from this <c> EnumMap </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping or <c> null </c> if no mapping for the specified key was found. </para>
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
				/// <para>Returns the number of elements in this <c> EnumMap </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this <c> EnumMap </c> . </para>
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
				/// <para>Returns a <c> Collection </c> of the values contained in this <c> EnumMap </c> . The returned <c> Collection </c> complies with the general rule specified in Map#values(). The <c> Collection </c> 's <c> Iterator </c> will return the values in the their corresponding keys' natural order (the <c> Enum </c> constants are declared in this order). </para><para>The order of the values in the collection will be the order that their corresponding enum keys were declared in.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values contained in this <c> EnumMap </c> . </para>
				/// </returns>
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

				[Dot42.DexImport("java/util/Map", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>A currency corresponding to an  currency code such as "EUR" or "USD". </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the <c> Currency </c> instance for this <c> Locale </c> 's country. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/util/Currency;", AccessFlags = 9)]
				public static global::Java.Util.Currency GetInstance(string locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <summary>
				/// <para>Returns the <c> Currency </c> instance for this <c> Locale </c> 's country. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;", AccessFlags = 9)]
				public static global::Java.Util.Currency GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Currency);
				}

				/// <summary>
				/// <para>Returns this currency's ISO 4217 currency code. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrencyCode
				/// </java-name>
				[Dot42.DexImport("getCurrencyCode", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCurrencyCode() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> getSymbol(Locale.getDefault()) </c> . See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <java-name>
				/// getSymbol
				/// </java-name>
				[Dot42.DexImport("getSymbol", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSymbol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the localized currency symbol for this currency in <c> locale </c> . That is, given "USD" and Locale.US, you'd get "$", but given "USD" and a non-US locale, you'd get "US$".</para><para>If the locale only specifies a language rather than a language and a country (such as <c> Locale.JAPANESE </c> or {new Locale("en", "")} rather than <c> Locale.JAPAN </c> or {new Locale("en", "US")}), the ISO 4217 currency code is returned.</para><para>If there is no locale-specific currency symbol, the ISO 4217 currency code is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getSymbol
				/// </java-name>
				[Dot42.DexImport("getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetSymbol(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the default number of fraction digits for this currency. For instance, the default number of fraction digits for the US dollar is 2 because there are 100 US cents in a US dollar. For the Japanese Yen, the number is 0 because coins smaller than 1 Yen became invalid in 1953. In the case of pseudo-currencies, such as IMF Special Drawing Rights, -1 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultFractionDigits
				/// </java-name>
				[Dot42.DexImport("getDefaultFractionDigits", "()I", AccessFlags = 1)]
				public int GetDefaultFractionDigits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this currency's ISO 4217 currency code. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns this currency's ISO 4217 currency code. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrencyCode
				/// </java-name>
				public string CurrencyCode
				{
				[Dot42.DexImport("getCurrencyCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCurrencyCode(); }
				}

				/// <summary>
				/// <para>Equivalent to <c> getSymbol(Locale.getDefault()) </c> . See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				/// <java-name>
				/// getSymbol
				/// </java-name>
				public string Symbol
				{
				[Dot42.DexImport("getSymbol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSymbol(); }
				}

				/// <summary>
				/// <para>Returns the default number of fraction digits for this currency. For instance, the default number of fraction digits for the US dollar is 2 because there are 100 US cents in a US dollar. For the Japanese Yen, the number is 0 because coins smaller than 1 Yen became invalid in 1953. In the case of pseudo-currencies, such as IMF Special Drawing Rights, -1 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultFractionDigits
				/// </java-name>
				public int DefaultFractionDigits
				{
				[Dot42.DexImport("getDefaultFractionDigits", "()I", AccessFlags = 1)]
						get{ return GetDefaultFractionDigits(); }
				}

		}

		/// <summary>
		/// <para>An ListIterator is used to sequence over a List of objects. ListIterator can move backwards or forwards through the list. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/ListIterator
		/// </java-name>
		[Dot42.DexImport("java/util/ListIterator", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
		public partial interface IListIterator<E> : global::Java.Util.IIterator<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Inserts the specified object into the list between <c> next </c> and <c> previous </c> . The object inserted will be the previous object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Add(E @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether there are more elements to iterate.</para><para><para>next </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there are more elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
				bool HasNext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether there are previous elements to iterate.</para><para><para>previous </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there are previous elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasPrevious
				/// </java-name>
				[Dot42.DexImport("hasPrevious", "()Z", AccessFlags = 1025)]
				bool HasPrevious() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the next object in the iteration.</para><para><para>hasNext </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next object. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Next() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the next object in the iteration.</para><para><para>next </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the next object, or the size of the list if the iterator is at the end. </para>
				/// </returns>
				/// <java-name>
				/// nextIndex
				/// </java-name>
				[Dot42.DexImport("nextIndex", "()I", AccessFlags = 1025)]
				int NextIndex() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the previous object in the iteration.</para><para><para>hasPrevious </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous object. </para>
				/// </returns>
				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Previous() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the index of the previous object in the iteration.</para><para><para>previous </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the previous object, or -1 if the iterator is at the beginning. </para>
				/// </returns>
				/// <java-name>
				/// previousIndex
				/// </java-name>
				[Dot42.DexImport("previousIndex", "()I", AccessFlags = 1025)]
				int PreviousIndex() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the last object returned by <c> next </c> or <c> previous </c> from the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1025)]
				void Remove() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Replaces the last object returned by <c> next </c> or <c> previous </c> with the specified object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Set(E @object) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A PriorityQueue holds elements on a priority heap, which orders the elements according to their natural order or according to the comparator specified at construction time. If the queue uses natural ordering, only elements that are comparable are permitted to be inserted into the queue. </para><para>The least element of the specified ordering is stored at the head of the queue and the greatest element is stored at the tail of the queue. </para><para>A PriorityQueue is not synchronized. If multiple threads will have to access it concurrently, use the java.util.concurrent.PriorityBlockingQueue. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/PriorityQueue
		/// </java-name>
		[Dot42.DexImport("java/util/PriorityQueue", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;Ljava/io/Serializable;")]
		public partial class PriorityQueue<E> : global::Java.Util.AbstractQueue<E>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a priority queue with an initial capacity of 11 and natural ordering. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PriorityQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a priority queue with the specified capacity and natural ordering.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PriorityQueue(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a priority queue with the specified capacity and comparator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/Comparator;)V", AccessFlags = 1, Signature = "(ILjava/util/Comparator<-TE;>;)V")]
				public PriorityQueue(int initialCapacity, global::Java.Util.IComparator<E> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a priority queue with the specified capacity and natural ordering.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public PriorityQueue(global::Java.Util.ICollection<E> initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a priority queue with the specified capacity and natural ordering.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/PriorityQueue;)V", AccessFlags = 1, Signature = "(Ljava/util/PriorityQueue<+TE;>;)V")]
				public PriorityQueue(global::Java.Util.PriorityQueue<E> initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a priority queue with the specified capacity and natural ordering.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/SortedSet;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedSet<+TE;>;)V")]
				public PriorityQueue(global::Java.Util.ISortedSet<E> initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the iterator of the priority queue, which will not return elements in any specified ordering.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iterator of the priority queue. </para>
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
				/// <para>Gets the size of the priority queue. If the size of the queue is greater than the Integer.MAX, then it returns Integer.MAX.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the priority queue. </para>
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
				/// <para>Removes all the elements of the priority queue. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the element to the priority queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>always true </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Offer(E o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets and removes the head of the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue or null if the queue is empty. </para>
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
				/// <para>Gets but does not remove the head of the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue or null if the queue is empty. </para>
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
				/// <para>Gets the comparator of the priority queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the comparator of the priority queue or null if the natural ordering is used. </para>
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
				/// <para>Removes the specified object from the priority queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the object was in the priority queue, false if the object was not in the priority queue. </para>
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
				/// <para>Adds the specified object to the priority queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>always true. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>A map that has its keys ordered. The sorting is according to either the natural ordering of its keys or the ordering given by a specified comparator. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/SortedMap
		/// </java-name>
		[Dot42.DexImport("java/util/SortedMap", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;" +
    ">;")]
		public partial interface ISortedMap<K, V> : global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the comparator used to compare keys in this sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the comparator or <c> null </c> if the natural order is used. </para>
				/// </returns>
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1025, Signature = "()Ljava/util/Comparator<-TK;>;")]
				global::Java.Util.IComparator<K> Comparator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the first key in this sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first key in this sorted map. </para>
				/// </returns>
				/// <java-name>
				/// firstKey
				/// </java-name>
				[Dot42.DexImport("firstKey", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TK;")]
				K FirstKey() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sorted map over a range of this sorted map with all keys that are less than the specified <c> endKey </c> . Changes to the returned sorted map are reflected in this sorted map and vice versa. </para><para>Note: The returned map will not allow an insertion of a key outside the specified range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sorted map where the keys are less than <c> endKey </c> . </para>
				/// </returns>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> HeadMap(K endKey) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the last key in this sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last key in this sorted map. </para>
				/// </returns>
				/// <java-name>
				/// lastKey
				/// </java-name>
				[Dot42.DexImport("lastKey", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TK;")]
				K LastKey() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sorted map over a range of this sorted map with all keys greater than or equal to the specified <c> startKey </c> and less than the specified <c> endKey </c> . Changes to the returned sorted map are reflected in this sorted map and vice versa. </para><para>Note: The returned map will not allow an insertion of a key outside the specified range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sorted map with the key from the specified range. </para>
				/// </returns>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> SubMap(K startKey, K endKey) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sorted map over a range of this sorted map with all keys that are greater than or equal to the specified <c> startKey </c> . Changes to the returned sorted map are reflected in this sorted map and vice versa. </para><para>Note: The returned map will not allow an insertion of a key outside the specified range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sorted map where the keys are greater or equal to <c> startKey </c> . </para>
				/// </returns>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				global::Java.Util.ISortedMap<K, V> TailMap(K startKey) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An iterator over a sequence of objects, such as a collection.</para><para>If a collection has been changed since the iterator was created, methods <c> next </c> and <c> hasNext() </c> may throw a <c> ConcurrentModificationException </c> . It is not possible to guarantee that this mechanism works in all cases of unsynchronized concurrent modification. It should only be used for debugging purposes. Iterators with this behavior are called fail-fast iterators.</para><para>Implementing Iterable and returning an <c> Iterator </c> allows your class to be used as a collection with the enhanced for loop.</para><para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Iterator
		/// </java-name>
		[Dot42.DexImport("java/util/Iterator", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IIterator<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns true if there is at least one more element, false otherwise. <para>next </para></para>        
				/// </summary>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
				bool HasNext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the next object and advances the iterator.</para><para><para>hasNext </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next object. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Next() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the last object returned by <c> next </c> from the collection. This method can only be called once between each call to <c> next </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1025)]
				void Remove() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><c> AbstractList </c> is an abstract implementation of the <c> List </c> interface, optimized for a backing store which supports random access. This implementation does not support adding or replacing. A subclass must implement the abstract methods <c> get() </c> and <c> size() </c> , and to create a modifiable <c> List </c> it's necessary to override the <c> add() </c> method that currently throws an <c> UnsupportedOperationException </c> .</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/AbstractList
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractList", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/List<TE;>;")]
		public abstract partial class AbstractList<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.IList<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A counter for changes to the list. </para>        
				/// </summary>
				/// <java-name>
				/// modCount
				/// </java-name>
				[Dot42.DexImport("modCount", "I", AccessFlags = 132)]
				protected internal int ModCount;
				/// <summary>
				/// <para>Constructs a new instance of this AbstractList. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified object into this List at the specified location. The object is inserted before any previous element at the specified location. If the location is equal to the size of this List, the object is added at the end. </para><para>Concrete implementations that would like to support the add functionality must override this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void Add(int location, E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object at the end of this List.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true</para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the objects in the specified Collection at the specified location in this List. The objects are added in the order they are returned from the collection's iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this List is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(int location, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all elements from this list, leaving it empty.</para><para><para>List::isEmpty </para><simplesectsep></simplesectsep><para>List::size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the specified object to this list and return true if they are equal. Two lists are equal when they both contain the same objects in the same order.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this list, <c> false </c> otherwise. </para>
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
				/// <para>Returns the element at the specified location in this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)TE;")]
				public virtual E Get(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the hash code of this list. The hash code is calculated by taking each element's hashcode into account.</para><para><para>equals </para><simplesectsep></simplesectsep><para>List::hashCode() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches this list for the specified object and returns the index of the first occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first occurrence of the object, or -1 if it was not found. </para>
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
				/// <para>Returns an iterator on the elements of this list. The elements are iterated in the same order as they occur in the list.</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator on the elements of this list. </para>
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
				/// <para>Searches this list for the specified object and returns the index of the last occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last occurrence of the object, or -1 if the object was not found. </para>
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
				/// <para>Returns a ListIterator on the elements of this list. The elements are iterated in the same order that they occur in the list.</para><para><para>ListIterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a ListIterator on the elements of this list </para>
				/// </returns>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "()Ljava/util/ListIterator;", AccessFlags = 1, Signature = "()Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <summary>
				/// <para>Returns a list iterator on the elements of this list. The elements are iterated in the same order as they occur in the list. The iteration starts at the specified location.</para><para><para>ListIterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a ListIterator on the elements of this list. </para>
				/// </returns>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public virtual global::Java.Util.IListIterator<E> ListIterator(int location) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E Remove(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Removes the objects in the specified range from the start to the end index minus one.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeRange
				/// </java-name>
				[Dot42.DexImport("removeRange", "(II)V", AccessFlags = 4)]
				protected internal virtual void RemoveRange(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Replaces the element at the specified location in this list with the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous element at the index. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public virtual E Set(int location, E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns a part of consecutive elements of this list as a view. The returned view will be of zero length if start equals end. Any change that occurs in the returned subList will be reflected to the original list, and vice-versa. All the supported optional operations by the original list will also be supported by this subList. </para><para>This method can be used as a handy method to do some operations on a sub range of the original list, for example <c> list.subList(from, to).clear(); </c> </para><para>If the original list is modified in other ways than through the returned subList, the behavior of the returned subList becomes undefined. </para><para>The returned subList is a subclass of AbstractList. The subclass stores offset, size of itself, and modCount of the original list. If the original list implements RandomAccess interface, the returned subList also implements RandomAccess interface. </para><para>The subList's set(int, Object), get(int), add(int, Object), remove(int), addAll(int, Collection) and removeRange(int, int) methods first check the bounds, adjust offsets and then call the corresponding methods of the original AbstractList. addAll(Collection c) method of the returned subList calls the original addAll(offset + size, c). </para><para>The listIterator(int) method of the subList wraps the original list iterator. The iterator() method of the subList invokes the original listIterator() method, and the size() method merely returns the size of the subList. </para><para>All methods will throw a ConcurrentModificationException if the modCount of the original list is not equal to the expected value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subList view of this list starting from <c> start </c> (inclusive), and ending with <c> end </c> (exclusive) </para>
				/// </returns>
				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 1, Signature = "(II)Ljava/util/List<TE;>;")]
				public virtual global::Java.Util.IList<E> SubList(int start, int end) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("java/util/List", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("java/util/List", "remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Remove(object location) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>WeakHashMap is an implementation of Map with keys which are WeakReferences. A key/value mapping is removed when the key is no longer referenced. All optional operations (adding and removing) are supported. Keys and values can be any objects. Note that the garbage collector acts similar to a second thread on this collection, possibly removing keys.</para><para><para>1.2 </para><para>HashMap </para><simplesectsep></simplesectsep><para>WeakReference </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/WeakHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/WeakHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/Map<TK;TV;>;")]
		public partial class WeakHashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty <c> WeakHashMap </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WeakHashMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> WeakHashMap </c> instance with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public WeakHashMap(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> WeakHashMap </c> instance with the specified capacity and load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public WeakHashMap(int capacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> WeakHashMap </c> instance with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public WeakHashMap(global::Java.Util.IMap<K, V> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all mappings from this map, leaving it empty.</para><para><para>isEmpty() </para><simplesectsep></simplesectsep><para>size() </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this map contains the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified key, <c> false </c> otherwise. </para>
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
				/// <para>Returns a set containing all of the mappings in this map. Each mapping is an instance of Map.Entry. As the set is backed by this map, changes in one will be reflected in the other. It does not support adding operations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings. </para>
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
				/// <para>Returns a set of the keys contained in this map. The set is backed by this map so changes to one are reflected by the other. The set does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para>Returns a collection of the values contained in this map. The collection is backed by this map so changes to one are reflected by the other. The collection supports remove, removeAll, retainAll and clear operations, and it does not support add or addAll operations. </para><para>This method returns a collection which is the subclass of AbstractCollection. The iterator method of this subclass returns a "wrapper object" over the iterator of map's entrySet(). The size method wraps the map's size method and the contains method wraps the map's containsValue method. </para><para>The collection is created when this method is called at first time and returned in response to all subsequent calls. This method may return different Collection when multiple calls to this method, since it has no synchronization performed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values contained in this map. </para>
				/// </returns>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <summary>
				/// <para>Returns the value of the mapping with the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns whether this map contains the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified value, <c> false </c> otherwise. </para>
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
				/// <para>Returns the number of elements in this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this map. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Maps the specified key to the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no mapping. </para>
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
				/// <para>Copies all the mappings in the given map to this map. These mappings will replace all mappings that this map had for any of the keys currently in the given map.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the mapping with the specified key from this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping or <c> null </c> if no mapping for the specified key was found. </para>
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
				/// <para>Returns the number of elements in this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this map. </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para>A linear collection that supports element insertion and removal at both ends. The name <b>deque</b> is short for "double ended queue" and is usually pronounced "deck". Most <code>Deque</code> implementations place no fixed limits on the number of elements they may contain, but this interface supports capacity-restricted deques as well as those with no fixed size limit.</para><para>This interface defines methods to access the elements at both ends of the deque. Methods are provided to insert, remove, and examine the element. Each of these methods exists in two forms: one throws an exception if the operation fails, the other returns a special value (either <code>null</code> or <code>false</code>, depending on the operation). The latter form of the insert operation is designed specifically for use with capacity-restricted <code>Deque</code> implementations; in most implementations, insert operations cannot fail.</para><para>The twelve methods described above are summarized in the following table:</para><para><table><row><entry><para></para></entry><entry><para><b>First Element (Head)</b> </para></entry><entry><para><b>Last Element (Tail)</b>  </para></entry></row><row><entry><para></para></entry><entry><para><b>Throws exception</b> </para></entry><entry><para><b>Special value</b> </para></entry><entry><para><b>Throws exception</b> </para></entry><entry><para><b>Special value</b>  </para></entry></row><row><entry><para><b>Insert</b> </para></entry><entry><para>addFirst(e) </para></entry><entry><para>offerFirst(e) </para></entry><entry><para>addLast(e) </para></entry><entry><para>offerLast(e)  </para></entry></row><row><entry><para><b>Remove</b> </para></entry><entry><para>removeFirst() </para></entry><entry><para>pollFirst() </para></entry><entry><para>removeLast() </para></entry><entry><para>pollLast()  </para></entry></row><row><entry><para><b>Examine</b> </para></entry><entry><para>getFirst() </para></entry><entry><para>peekFirst() </para></entry><entry><para>getLast() </para></entry><entry><para>peekLast()  </para></entry></row></table></para><para>This interface extends the Queue interface. When a deque is used as a queue, FIFO (First-In-First-Out) behavior results. Elements are added at the end of the deque and removed from the beginning. The methods inherited from the <code>Queue</code> interface are precisely equivalent to <code>Deque</code> methods as indicated in the following table:</para><para><table><row><entry><para><b><code>Queue</code> Method</b> </para></entry><entry><para><b>Equivalent <code>Deque</code> Method</b>  </para></entry></row><row><entry><para>add(e) </para></entry><entry><para>addLast(e)  </para></entry></row><row><entry><para>offer(e) </para></entry><entry><para>offerLast(e)  </para></entry></row><row><entry><para>remove() </para></entry><entry><para>removeFirst()  </para></entry></row><row><entry><para>poll() </para></entry><entry><para>pollFirst()  </para></entry></row><row><entry><para>element() </para></entry><entry><para>getFirst()  </para></entry></row><row><entry><para>peek() </para></entry><entry><para>peekFirst()  </para></entry></row></table></para><para>Deques can also be used as LIFO (Last-In-First-Out) stacks. This interface should be used in preference to the legacy Stack class. When a deque is used as a stack, elements are pushed and popped from the beginning of the deque. Stack methods are precisely equivalent to <code>Deque</code> methods as indicated in the table below:</para><para><table><row><entry><para><b>Stack Method</b> </para></entry><entry><para><b>Equivalent <code>Deque</code> Method</b>  </para></entry></row><row><entry><para>push(e) </para></entry><entry><para>addFirst(e)  </para></entry></row><row><entry><para>pop() </para></entry><entry><para>removeFirst()  </para></entry></row><row><entry><para>peek() </para></entry><entry><para>peekFirst()  </para></entry></row></table></para><para>Note that the peek method works equally well when a deque is used as a queue or a stack; in either case, elements are drawn from the beginning of the deque.</para><para>This interface provides two methods to remove interior elements, removeFirstOccurrence and removeLastOccurrence.</para><para>Unlike the List interface, this interface does not provide support for indexed access to elements.</para><para>While <code>Deque</code> implementations are not strictly required to prohibit the insertion of null elements, they are strongly encouraged to do so. Users of any <code>Deque</code> implementations that do allow null elements are strongly encouraged <b>not</b> to take advantage of the ability to insert nulls. This is so because <code>null</code> is used as a special return value by various methods to indicated that the deque is empty.</para><para><code>Deque</code> implementations generally do not define element-based versions of the <code>equals</code> and <code>hashCode</code> methods, but instead inherit the identity-based versions from class <code>Object</code>.</para><para><para>Doug Lea </para><simplesectsep></simplesectsep><para>Josh Bloch </para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Deque
		/// </java-name>
		[Dot42.DexImport("java/util/Deque", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Queue<TE;>;")]
		public partial interface IDeque<E> : global::Java.Util.IQueue<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Inserts the specified element at the front of this deque if it is possible to do so immediately without violating capacity restrictions. When using a capacity-restricted deque, it is generally preferable to use method offerFirst.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void AddFirst(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inserts the specified element at the end of this deque if it is possible to do so immediately without violating capacity restrictions. When using a capacity-restricted deque, it is generally preferable to use method offerLast.</para><para>This method is equivalent to add.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void AddLast(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inserts the specified element at the front of this deque unless it would violate capacity restrictions. When using a capacity-restricted deque, this method is generally preferable to the addFirst method, which can fail to insert an element only by throwing an exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the element was added to this deque, else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool OfferFirst(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Inserts the specified element at the end of this deque unless it would violate capacity restrictions. When using a capacity-restricted deque, this method is generally preferable to the addLast method, which can fail to insert an element only by throwing an exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the element was added to this deque, else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool OfferLast(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the first element of this deque. This method differs from pollFirst only in that it throws an exception if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// removeFirst
				/// </java-name>
				[Dot42.DexImport("removeFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E RemoveFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the last element of this deque. This method differs from pollLast only in that it throws an exception if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque </para>
				/// </returns>
				/// <java-name>
				/// removeLast
				/// </java-name>
				[Dot42.DexImport("removeLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E RemoveLast() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the first element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// pollFirst
				/// </java-name>
				[Dot42.DexImport("pollFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the last element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// pollLast
				/// </java-name>
				[Dot42.DexImport("pollLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PollLast() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves, but does not remove, the first element of this deque.</para><para>This method differs from peekFirst only in that it throws an exception if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque </para>
				/// </returns>
				/// <java-name>
				/// getFirst
				/// </java-name>
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E GetFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves, but does not remove, the last element of this deque. This method differs from peekLast only in that it throws an exception if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque </para>
				/// </returns>
				/// <java-name>
				/// getLast
				/// </java-name>
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E GetLast() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves, but does not remove, the first element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peekFirst
				/// </java-name>
				[Dot42.DexImport("peekFirst", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PeekFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves, but does not remove, the last element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peekLast
				/// </java-name>
				[Dot42.DexImport("peekLast", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E PeekLast() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the first occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <code>e</code> such that <code>(o==null ? e==null : o.equals(e))</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if an element was removed as a result of this call </para>
				/// </returns>
				/// <java-name>
				/// removeFirstOccurrence
				/// </java-name>
				[Dot42.DexImport("removeFirstOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool RemoveFirstOccurrence(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the last occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the last element <code>e</code> such that <code>(o==null ? e==null : o.equals(e))</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if an element was removed as a result of this call </para>
				/// </returns>
				/// <java-name>
				/// removeLastOccurrence
				/// </java-name>
				[Dot42.DexImport("removeLastOccurrence", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool RemoveLastOccurrence(object o) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Pushes an element onto the stack represented by this deque (in other words, at the head of this deque) if it is possible to do so immediately without violating capacity restrictions, returning <code>true</code> upon success and throwing an <code>IllegalStateException</code> if no space is currently available.</para><para>This method is equivalent to addFirst.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TE;)V")]
				void Push(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Pops an element from the stack represented by this deque. In other words, removes and returns the first element of this deque.</para><para>This method is equivalent to removeFirst().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the front of this deque (which is the top of the stack represented by this deque) </para>
				/// </returns>
				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Pop() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an iterator over the elements in this deque in reverse sequential order. The elements will be returned in order from last (tail) to first (head).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator over the elements in this deque in reverse sequence </para>
				/// </returns>
				/// <java-name>
				/// descendingIterator
				/// </java-name>
				[Dot42.DexImport("descendingIterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> DescendingIterator() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> Properties </c> object is a <c> Hashtable </c> where the keys and values must be <c> String </c> s. Each property can have a default <c> Properties </c> list which specifies the default values to be used when a given key is not found in this <c> Properties </c> instance.</para><para><h3>Character Encoding</h3></para><para>Note that in some cases <c> Properties </c> uses ISO-8859-1 instead of UTF-8. ISO-8859-1 is only capable of representing a tiny subset of Unicode. Use either the <c> loadFromXML </c> /<c> storeToXML </c> methods (which use UTF-8 by default) or the <c> load </c> /<c> store </c> overloads that take an <c> OutputStreamWriter </c> (so you can supply a UTF-8 instance) instead.</para><para><para>Hashtable </para><simplesectsep></simplesectsep><para>java.lang.System::getProperties </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Properties
		/// </java-name>
		[Dot42.DexImport("java/util/Properties", AccessFlags = 33, Signature = "Ljava/util/Hashtable<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public partial class Properties : global::Java.Util.Hashtable<global::System.Object, global::System.Object>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default values for keys not found in this <c> Properties </c> instance. </para>        
				/// </summary>
				/// <java-name>
				/// defaults
				/// </java-name>
				[Dot42.DexImport("defaults", "Ljava/util/Properties;", AccessFlags = 4)]
				protected internal global::Java.Util.Properties Defaults;
				/// <summary>
				/// <para>Constructs a new <c> Properties </c> object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Properties() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Properties </c> object using the specified default <c> Properties </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Properties;)V", AccessFlags = 1)]
				public Properties(global::Java.Util.Properties properties) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Searches for the property with the specified name. If the property is not found, the default <c> Properties </c> are checked. If the property is not found in the default <c> Properties </c> , <c> null </c> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the named property value, or <c> null </c> if it can't be found. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProperty(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Searches for the property with the specified name. If the property is not found, it looks in the default <c> Properties </c> . If the property is not found in the default <c> Properties </c> , it returns the specified default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the named property value. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProperty(string name, string defaultValue) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Lists the mappings in this <c> Properties </c> to <c> out </c> in a human-readable form. Note that values are truncated to 37 characters, so this method is rarely useful. </para>        
				/// </summary>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public virtual void List(global::Java.Io.PrintStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Lists the mappings in this <c> Properties </c> to <c> out </c> in a human-readable form. Note that values are truncated to 37 characters, so this method is rarely useful. </para>        
				/// </summary>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public virtual void List(global::Java.Io.PrintWriter @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads properties from the specified <c> InputStream </c> , assumed to be ISO-8859-1. See "&lt;a href="#character_encoding"&gt;Character Encoding&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;)V", AccessFlags = 33)]
				public virtual void Load(global::Java.Io.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads properties from the specified <c> InputStream </c> , assumed to be ISO-8859-1. See "&lt;a href="#character_encoding"&gt;Character Encoding&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/Reader;)V", AccessFlags = 33)]
				public virtual void Load(global::Java.Io.Reader @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns all of the property names (keys) in this <c> Properties </c> object. </para>        
				/// </summary>
				/// <java-name>
				/// propertyNames
				/// </java-name>
				[Dot42.DexImport("propertyNames", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<*>;")]
				public virtual global::Java.Util.IEnumeration<object> PropertyNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<object>);
				}

				/// <summary>
				/// <para>Returns those property names (keys) in this <c> Properties </c> object for which both key and value are strings.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of keys in the property list </para>
				/// </returns>
				/// <java-name>
				/// stringPropertyNames
				/// </java-name>
				[Dot42.DexImport("stringPropertyNames", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> StringPropertyNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				/// <para>Saves the mappings in this <c> Properties </c> to the specified <c>       OutputStream </c> , putting the specified comment at the beginning. The output from this method is suitable for being read by the load(InputStream) method.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method ignores any</para></xrefdescription></xrefsect><c> IOException </c> thrown while writing  use store instead for better exception handling. </para>        
				/// </summary>
				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Save(global::Java.Io.OutputStream @out, string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps the specified key to the specified value. If the key already exists, the old value is replaced. The key and value cannot be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the old value mapped to the key, or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object SetProperty(string name, string value) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Loads the properties from an <c> InputStream </c> containing the properties in XML form. The XML document must begin with (and conform to) following DOCTYPE:</para><para><pre>
				///        &lt;!DOCTYPE properties SYSTEM "
				///        </pre></para><para>Also the content of the XML data must satisfy the DTD but the xml is not validated against it. The DTD is not loaded from the SYSTEM ID. After this method returns the InputStream is not closed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadFromXML
				/// </java-name>
				[Dot42.DexImport("loadFromXML", "(Ljava/io/InputStream;)V", AccessFlags = 33)]
				public virtual void LoadFromXML(global::Java.Io.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes all properties stored in this instance into the <c>       OutputStream </c> in XML representation. The DOCTYPE is</para><para><pre>
				///        &lt;!DOCTYPE properties SYSTEM "
				///        </pre></para><para>If the comment is null, no comment is added to the output. UTF-8 is used as the encoding. The <c> OutputStream </c> is not closed at the end. A call to this method is the same as a call to <c> storeToXML(os,       comment, "UTF-8") </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// storeToXML
				/// </java-name>
				[Dot42.DexImport("storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StoreToXML(global::Java.Io.OutputStream os, string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes all properties stored in this instance into the <c>       OutputStream </c> in XML representation. The DOCTYPE is</para><para><pre>
				///        &lt;!DOCTYPE properties SYSTEM "
				///        </pre></para><para>If the comment is null, no comment is added to the output. The parameter <c> encoding </c> defines which encoding should be used. The <c>       OutputStream </c> is not closed at the end.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// storeToXML
				/// </java-name>
				[Dot42.DexImport("storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void StoreToXML(global::Java.Io.OutputStream os, string comment, string encoding) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Formats arguments according to a format string (like <c> printf </c> in C). </para><para>It's relatively rare to use a <c> Formatter </c> directly. A variety of classes offer convenience methods for accessing formatter functionality. Of these, String#format is generally the most useful. java.io.PrintStream and java.io.PrintWriter both offer <c> format </c> and <c> printf </c> methods. </para><para><b>Format strings</b> consist of plain text interspersed with format specifiers, such as <c> "name: %s weight: %03dkg\n" </c> . Being a Java string, the usual Java string literal backslash escapes are of course available. </para><para><b>Format specifiers</b> (such as <c> "%s" </c> or <c> "%03d" </c> in the example) start with a <c> % </c> and describe how to format their corresponding argument. It includes an optional argument index, optional flags, an optional width, an optional precision, and a mandatory conversion type. In the example, <c> "%s" </c> has no flags, no width, and no precision, while <c> "%03d" </c> has the flag <c> 0 </c> , the width 3, and no precision. </para><para>Not all combinations of argument index, flags, width, precision, and conversion type are valid. </para><para><b>Argument index</b>. Normally, each format specifier consumes the next argument to <c> format </c> . For convenient localization, it's possible to reorder arguments so that they appear in a different order in the output than the order in which they were supplied. For example, <c> "%4$s" </c> formats the fourth argument (<c> 4$ </c> ) as a string (<c> s </c> ). It's also possible to reuse an argument with <c> &lt;</c> . For example, <c> format("%o %&amp;lt;d %&amp;lt;x", 64) </c> results in <c> "100 64 40" </c> . </para><para><b>Flags</b>. The available flags are: </para><para><table><row><entry><para><b>Flags</b>   </para></entry></row><row><entry><para><c> , </c>  </para></entry><entry><para>Use grouping separators for large numbers. (Decimal only.) </para></entry><entry><para><c> format("%,d", 1024); </c>  </para></entry><entry><para><c> 1,234 </c>   </para></entry></row><row><entry><para><c> + </c>  </para></entry><entry><para>Always show sign. (Decimal only.) </para></entry><entry><para><c> format("%+d, %+4d", 5, 5); </c>  </para></entry><entry><para><pre>+5,   +5</pre>  </para></entry></row><row><entry><para><c></c>  </para></entry><entry><para>A space indicates that non-negative numbers should have a leading space. (Decimal only.) </para></entry><entry><para><c> format("x% d% 5d", 4, 4); </c>  </para></entry><entry><para><pre>x 4    4</pre>  </para></entry></row><row><entry><para><c> ( </c>  </para></entry><entry><para>Put parentheses around negative numbers. (Decimal only.) </para></entry><entry><para><c> format("%(d, %(d, %(6d", 12, -12, -12); </c>  </para></entry><entry><para><pre>12, (12),   (12)</pre>  </para></entry></row><row><entry><para><c> - </c>  </para></entry><entry><para>Left-justify. (Requires width.) </para></entry><entry><para><c> format("%-6dx", 5); </c> <br></br><c> format("%-3C, %3C", 'd', 0x65); </c>  </para></entry><entry><para><pre>5      x</pre><br></br><pre>D  ,   E</pre>  </para></entry></row><row><entry><para><c> 0 </c>  </para></entry><entry><para>Pad the number with leading zeros. (Requires width.) </para></entry><entry><para><c> format("%07d, %03d", 4, 5555); </c>  </para></entry><entry><para><c> 0000004, 5555 </c>   </para></entry></row><row><entry><para><c> # </c>  </para></entry><entry><para>Alternate form. (Octal and hex only.)  </para></entry><entry><para><c> format("%o %#o", 010, 010); </c> <br></br><c> format("%x %#x", 0x12, 0x12); </c>  </para></entry><entry><para><c> 10 010 </c> <br></br><c> 12 0x12 </c>   </para></entry></row></table></para><para><b>Width</b>. The width is a decimal integer specifying the minimum number of characters to be used to represent the argument. If the result would otherwise be shorter than the width, padding will be added (the exact details of which depend on the flags). Note that you can't use width to truncate a field, only to make it wider: see precision for control over the maximum width. </para><para><b>Precision</b>. The precision is a <c> . </c> followed by a decimal integer, giving the minimum number of digits for <c> d </c> , <c> o </c> , <c> x </c> , or <c> X </c> ; the minimum number of digits after the decimal point for <c> a </c> , <c> A </c> , <c> e </c> , <c> E </c> , <c> f </c> , or <c> F </c> ; the maximum number of significant digits for <c> g </c> or <c> G </c> ; or the maximum number of characters for <c> s </c> or <c> S </c> . </para><para><b>Conversion type</b>. One or two characters describing how to interpret the argument. Most conversions are a single character, but date/time conversions all start with <c> t </c> and have a single extra character describing the desired output. </para><para>Many conversion types have a corresponding uppercase variant that converts its result to uppercase using the rules of the relevant locale (either the default or the locale set for this formatter). </para><para>This table shows the available single-character (non-date/time) conversion types: <table><row><entry><para><b>String conversions</b> <br></br> All types are acceptable arguments. Values of type Formattable have their <c> formatTo </c> method invoked; all other types use <c> toString </c> .   </para></entry></row><row><entry><para><c> s </c>  </para></entry><entry><para>String. </para></entry><entry><para><c> format("%s %s", "hello", "Hello"); </c>  </para></entry><entry><para><c> hello Hello </c>   </para></entry></row><row><entry><para><c> S </c>  </para></entry><entry><para>Uppercase string. </para></entry><entry><para><c> format("%S %S", "hello", "Hello"); </c>  </para></entry><entry><para><c> HELLO HELLO </c>   </para></entry></row><row><entry><para><b>Character conversions</b> <br></br> Byte, Character, Short, and Integer (and primitives that box to those types) are all acceptable as character arguments. Any other type is an error.   </para></entry></row><row><entry><para><c> c </c>  </para></entry><entry><para>Character. </para></entry><entry><para><c> format("%c %c", 'd', 'E'); </c>  </para></entry><entry><para><c> d E </c>   </para></entry></row><row><entry><para><c> C </c>  </para></entry><entry><para>Uppercase character. </para></entry><entry><para><c> format("%C %C", 'd', 'E'); </c>  </para></entry><entry><para><c> D E </c>   </para></entry></row><row><entry><para><b>Integer conversions</b> <br></br> Byte, Short, Integer, Long, and BigInteger (and primitives that box to those types) are all acceptable as integer arguments. Any other type is an error.   </para></entry></row><row><entry><para><c> d </c>  </para></entry><entry><para>Decimal. </para></entry><entry><para><c> format("%d", 26); </c>  </para></entry><entry><para><c> 26 </c>   </para></entry></row><row><entry><para><c> o </c>  </para></entry><entry><para>Octal. </para></entry><entry><para><c> format("%o", 032); </c>  </para></entry><entry><para><c> 32 </c>   </para></entry></row><row><entry><para><c> x </c> , <c> X </c>  </para></entry><entry><para>Hexadecimal. </para></entry><entry><para><c> format("%x %X", 0x1a, 0x1a); </c>  </para></entry><entry><para><c> 1a 1A </c>   </para></entry></row><row><entry><para><b>Floating-point conversions</b> <br></br> Float, Double, and BigDecimal (and primitives that box to those types) are all acceptable as floating-point arguments. Any other type is an error.   </para></entry></row><row><entry><para><c> f </c>  </para></entry><entry><para>Decimal floating point. </para></entry><entry><para><pre>
		/// format("%f", 123.456f);
		/// format("%.1f", 123.456f);
		/// format("%1.5f", 123.456f);
		/// format("%10f", 123.456f);
		/// format("%6.0f", 123.456f);
		///    </pre></para></entry><entry><para><pre><pre>
		/// 123.456001
		/// 123.5
		/// 123.45600
		/// 123.456001
		///    123</pre>  </pre></para></entry></row><row><entry><para><pre> e 
		/// 
		///  ,  E 
		/// 
		///  
		///    </pre></para></entry><entry><para><pre>Engineering/exponential floating point.
		///    </pre></para></entry><entry><para><pre><pre>
		/// format("%e", 123.456f);
		/// format("%.1e", 123.456f);
		/// format("%1.5E", 123.456f);
		/// format("%10E", 123.456f);
		/// format("%6.0E", 123.456f);
		///    </pre></pre></para></entry><entry><para><pre><pre><pre>
		/// 1.234560e+02
		/// 1.2e+02
		/// 1.23456E+02
		/// 1.234560E+02
		///  1E+02</pre>  </pre></pre></para></entry></row><row><entry><para><pre><pre> g 
		/// 
		///  ,  G 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre>Decimal or engineering, depending on the magnitude of the value.
		///    </pre></pre></para></entry><entry><para><pre><pre> format("%g %g", 0.123, 0.0000123); 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre> 0.123000 1.23000e-05 
		/// 
		///  
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre> a 
		/// 
		///  ,  A 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre>Hexadecimal floating point.
		///    </pre></pre></para></entry><entry><para><pre><pre> format("%a", 123.456f); 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre> 0x1.edd2f2p6 
		/// 
		///  
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre>
		///    <b>Boolean conversion</b>
		///    <br></br>
		/// 
		///    Accepts Boolean values.  null 
		/// 
		///   is considered false, and instances of all other
		///    types are considered true.
		///    
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre> b 
		/// 
		///  ,  B 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre>Boolean.
		///    </pre></pre></para></entry><entry><para><pre><pre> format("%b %b", true, false); 
		/// 
		///  <br></br>
		///  format("%B %B", true, false); 
		/// 
		///  <br></br>
		///  format("%b", null); 
		/// 
		///  <br></br>
		///  format("%b", "hello"); 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre> true false 
		/// 
		///  <br></br>
		///  TRUE FALSE 
		/// 
		///  <br></br>
		///  false 
		/// 
		///  <br></br>
		///  true 
		/// 
		///  
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre>
		///    <b>Hash code conversion</b>
		///    <br></br>
		/// 
		///    Invokes  hashCode 
		/// 
		///   on its argument, which may be of any type.
		///    
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre> h 
		/// 
		///  ,  H 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre>Hexadecimal hash code.
		///    </pre></pre></para></entry><entry><para><pre><pre> format("%h", this); 
		/// 
		///  <br></br>
		///  format("%H", this); 
		/// 
		///  <br></br>
		///  format("%h", null); 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre> 190d11 
		/// 
		///  <br></br>
		///  190D11 
		/// 
		///  <br></br>
		///  null 
		/// 
		///  
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre>
		///    <b>Zero-argument conversions</b>
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre> % 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre>A literal % character.
		///    </pre></pre></para></entry><entry><para><pre><pre> format("%d%%", 50); 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre> 50% 
		/// 
		///  
		///    
		///    </pre></pre></para></entry></row><row><entry><para><pre><pre> n 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre>Newline. (The value of the "line.separator" system property}.)
		///    </pre></pre></para></entry><entry><para><pre><pre> format("first%nsecond"); 
		/// 
		///  
		///    </pre></pre></para></entry><entry><para><pre><pre> first\nsecond 
		/// 
		///  
		///    
		///    </pre></pre></para></entry></row></table></para><para><pre><pre>
		///    It's also possible to format dates and times with  Formatter 
		/// 
		///  , though you should
		///    use java.text.SimpleDateFormat (probably via the factory methods in
		///    java.text.DateFormat) instead.
		///    The facilities offered by  Formatter 
		/// 
		///   are low-level and place the burden of localization
		///    on the developer. Using java.text.DateFormat#getDateInstance,
		///    java.text.DateFormat#getTimeInstance, and
		///    java.text.DateFormat#getDateTimeInstance is preferable for dates and times that will be
		///    presented to a human. Those methods will select the best format strings for the user's locale.
		///    </pre>
		/// 
		/// <pre>
		///    The best non-localized form is ,
		///    which you can get with  "%tF" 
		/// 
		///   (2010-01-22),  "%tF %tR" 
		/// 
		///   (2010-01-22 13:39),
		///     "%tF %tT" 
		/// 
		///   (2010-01-22 13:39:15), or  "%tF %tT%z" 
		/// 
		///   (2010-01-22 13:39:15-0800).
		///    </pre>
		/// 
		/// <pre>
		///    This table shows the date/time conversions, but you should use java.text.SimpleDateFormat
		///    instead:
		///    <table><row>
		/// <entry><para><b>Date/time conversions</b>
		///    <br></br>
		/// 
		///    Calendar, Date, and Long (representing milliseconds past the epoch) are all acceptable
		///    as date/time arguments. Any other type is an error. The epoch is 1970-01-01 00:00:00 UTC.
		///    
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> ta 
		/// 
		///  
		///    </para></entry><entry><para>Localized weekday name (abbreviated).
		///    </para></entry><entry><para> format("%ta", cal, cal); 
		/// 
		///  
		///    </para></entry><entry><para> Tue 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tA 
		/// 
		///  
		///    </para></entry><entry><para>Localized weekday name (full).
		///    </para></entry><entry><para> format("%tA", cal, cal); 
		/// 
		///  
		///    </para></entry><entry><para> Tuesday 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tb 
		/// 
		///  
		///    </para></entry><entry><para>Localized month name (abbreviated).
		///    </para></entry><entry><para> format("%tb", cal); 
		/// 
		///  
		///    </para></entry><entry><para> Apr 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tB 
		/// 
		///  
		///    </para></entry><entry><para>Localized month name (full).
		///    </para></entry><entry><para> format("%tB", cal); 
		/// 
		///  
		///    </para></entry><entry><para> April 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tc 
		/// 
		///  
		///    </para></entry><entry><para>C library <b>asctime(3)</b>-like output. Do not use.
		///    </para></entry><entry><para> format("%tc", cal); 
		/// 
		///  
		///    </para></entry><entry><para> Tue Apr 01 16:19:17 CEST 2008 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tC 
		/// 
		///  
		///    </para></entry><entry><para>2-digit century.
		///    </para></entry><entry><para> format("%tC", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 20 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> td 
		/// 
		///  
		///    </para></entry><entry><para>2-digit day of month (01-31).
		///    </para></entry><entry><para> format("%td", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 01 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tD 
		/// 
		///  
		///    </para></entry><entry><para>Ambiguous US date format (MM/DD/YY). Do not use.
		///    </para></entry><entry><para> format("%tD", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 04/01/08 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> te 
		/// 
		///  
		///    </para></entry><entry><para>Day of month (1-31).
		///    </para></entry><entry><para> format("%te", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 1 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tF 
		/// 
		///  
		///    </para></entry><entry><para>Full date in ISO 8601 format (YYYY-MM-DD).
		///    </para></entry><entry><para> format("%tF", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 2008-04-01 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> th 
		/// 
		///  
		///    </para></entry><entry><para>Synonym for  %tb 
		/// 
		///  .
		///    </para></entry><entry><para></para></entry><entry><para></para></entry></row>
		/// <row>
		/// <entry><para> tH 
		/// 
		///  
		///    </para></entry><entry><para>24-hour hour of day (00-23).
		///    </para></entry><entry><para> format("%tH", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 16 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tI 
		/// 
		///  
		///    </para></entry><entry><para>12-hour hour of day (01-12).
		///    </para></entry><entry><para> format("%tH", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 04 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tj 
		/// 
		///  
		///    </para></entry><entry><para>3-digit day of year (001-366).
		///    </para></entry><entry><para> format("%tj", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 092 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tk 
		/// 
		///  
		///    </para></entry><entry><para>24-hour hour of day (0-23).
		///    </para></entry><entry><para> format("%tH", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 16 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tl 
		/// 
		///  
		///    </para></entry><entry><para>12-hour hour of day (1-12).
		///    </para></entry><entry><para> format("%tH", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 4 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tL 
		/// 
		///  
		///    </para></entry><entry><para>Milliseconds.
		///    </para></entry><entry><para> format("%tL", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 359 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tm 
		/// 
		///  
		///    </para></entry><entry><para>2-digit month of year (01-12).
		///    </para></entry><entry><para> format("%tm", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 04 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tM 
		/// 
		///  
		///    </para></entry><entry><para>2-digit minute.
		///    </para></entry><entry><para> format("%tM", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 08 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tN 
		/// 
		///  
		///    </para></entry><entry><para>Nanoseconds.
		///    </para></entry><entry><para> format("%tN", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 359000000 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tp 
		/// 
		///  
		///    </para></entry><entry><para>a.m. or p.m.
		///    </para></entry><entry><para> format("%tp %Tp", cal, cal); 
		/// 
		///  
		///    </para></entry><entry><para> pm PM 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tQ 
		/// 
		///  
		///    </para></entry><entry><para>Milliseconds since the epoch.
		///    </para></entry><entry><para> format("%tQ", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 1207059412656 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tr 
		/// 
		///  
		///    </para></entry><entry><para>Full 12-hour time ( %tI:%tM:%tS %Tp 
		/// 
		///  ).
		///    </para></entry><entry><para> format("%tr", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 04:15:32 PM 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tR 
		/// 
		///  
		///    </para></entry><entry><para>Short 24-hour time ( %tH:%tM 
		/// 
		///  ).
		///    </para></entry><entry><para> format("%tR", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 16:15 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> ts 
		/// 
		///  
		///    </para></entry><entry><para>Seconds since the epoch.
		///    </para></entry><entry><para> format("%ts", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 1207059412 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tS 
		/// 
		///  
		///    </para></entry><entry><para>2-digit seconds (00-60).
		///    </para></entry><entry><para> format("%tS", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 17 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tT 
		/// 
		///  
		///    </para></entry><entry><para>Full 24-hour time ( %tH:%tM:%tS 
		/// 
		///  ).
		///    </para></entry><entry><para> format("%tT", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 16:15:32 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> ty 
		/// 
		///  
		///    </para></entry><entry><para>2-digit year (00-99).
		///    </para></entry><entry><para> format("%ty", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 08 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tY 
		/// 
		///  
		///    </para></entry><entry><para>4-digit year.
		///    </para></entry><entry><para> format("%tY", cal); 
		/// 
		///  
		///    </para></entry><entry><para> 2008 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tz 
		/// 
		///  
		///    </para></entry><entry><para>Time zone GMT offset.
		///    </para></entry><entry><para> format("%tz", cal); 
		/// 
		///  
		///    </para></entry><entry><para> +0100 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// <row>
		/// <entry><para> tZ 
		/// 
		///  
		///    </para></entry><entry><para>Localized time zone abbreviation.
		///    </para></entry><entry><para> format("%tZ", cal); 
		/// 
		///  
		///    </para></entry><entry><para> CEST 
		/// 
		///  
		///    
		///    </para></entry></row>
		/// </table>
		/// </pre>
		/// 
		/// <pre>
		///    As with the other conversions, date/time conversion has an uppercase format. Replacing
		///     %t 
		/// 
		///   with  %T 
		/// 
		///   will uppercase the field according to the rules of the formatter's
		///    locale.
		///    </pre>
		/// 
		/// <pre><b>Number localization</b>. Some conversions use localized decimal digits rather than the
		///    usual ASCII digits. So formatting  123 
		/// 
		///   with  %d 
		/// 
		///   will give 123 in English locales
		///    but &amp;#x0661;&amp;#x0662;&amp;#x0663; in appropriate Arabic locales, for example. This number localization
		///    occurs for the decimal integer conversion  %d 
		/// 
		///  , the floating point conversions  %e 
		/// 
		///  ,
		///     %f 
		/// 
		///  , and  %g 
		/// 
		///  , and all date/time  %t 
		/// 
		///   or  %T 
		/// 
		///   conversions, but no other
		///    conversions.
		///    </pre>
		/// 
		/// <pre><b>Thread safety</b>. Formatter is not thread-safe.</pre>
		/// 
		/// <pre>   <para>1.5
		///    </para>
		/// <para>java.text.DateFormat
		///    </para><simplesectsep></simplesectsep><para>Formattable
		///    </para><simplesectsep></simplesectsep><para>java.text.SimpleDateFormat
		/// </para>
		/// </pre></pre></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Formatter
		/// </java-name>
		[Dot42.DexImport("java/util/Formatter", AccessFlags = 49)]
		public sealed partial class Formatter : global::Java.Io.ICloseable, global::Java.Io.IFlushable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> Formatter </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para>The <c> Locale </c> used is the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Formatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a <c> Formatter </c> with the specified <c> Locale </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Appendable;)V", AccessFlags = 1)]
				public Formatter(global::Java.Lang.IAppendable l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a <c> Formatter </c> with the specified <c> Locale </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(global::Java.Util.Locale l) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Formatter(global::Java.Lang.IAppendable appendable, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a <c> Formatter </c> with the specified <c> Locale </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Formatter(string l) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Constructs a <c> Formatter </c> with the specified <c> Locale </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.File l) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Constructs a <c> Formatter </c> with the specified <c> Locale </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.OutputStream l) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Constructs a <c> Formatter </c> with the specified <c> Locale </c> .</para><para>The output is written to a <c> StringBuilder </c> which can be acquired by invoking out() and whose content can be obtained by calling <c> toString </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public Formatter(global::Java.Io.PrintStream l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Locale </c> of the <c> Formatter </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Locale </c> for the <c> Formatter </c> or <c> null </c> for no <c> Locale </c> . </para>
				/// </returns>
				/// <java-name>
				/// locale
				/// </java-name>
				[Dot42.DexImport("locale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public global::Java.Util.Locale Locale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <summary>
				/// <para>Returns the output destination of the <c> Formatter </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the output destination of the <c> Formatter </c> . </para>
				/// </returns>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "()Ljava/lang/Appendable;", AccessFlags = 1)]
				public global::Java.Lang.IAppendable Out() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				/// <summary>
				/// <para>Returns the content by calling the <c> toString() </c> method of the output destination.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the content by calling the <c> toString() </c> method of the output destination. </para>
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
				/// <para>Flushes the <c> Formatter </c> . If the output destination is Flushable, then the method <c> flush() </c> will be called on that destination.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the <c> Formatter </c> . If the output destination is Closeable, then the method <c> close() </c> will be called on that destination.</para><para>If the <c> Formatter </c> has been closed, then calling the this method will have no effect.</para><para>Any method but the ioException() that is called after the <c> Formatter </c> has been closed will raise a <c> FormatterClosedException </c> . </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the last <c> IOException </c> thrown by the <c> Formatter </c> 's output destination. If the <c> append() </c> method of the destination does not throw <c> IOException </c> s, the <c> ioException() </c> method will always return <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last <c> IOException </c> thrown by the <c> Formatter </c> 's output destination. </para>
				/// </returns>
				/// <java-name>
				/// ioException
				/// </java-name>
				[Dot42.DexImport("ioException", "()Ljava/io/IOException;", AccessFlags = 1)]
				public global::System.IO.IOException IoException() /* MethodBuilder.Create */ 
				{
						return default(global::System.IO.IOException);
				}

				/// <summary>
				/// <para>Writes a formatted string to the output destination of the <c> Formatter </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Formatter </c> . </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", AccessFlags = 129)]
				public global::Java.Util.Formatter Format(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Formatter);
				}

				/// <summary>
				/// <para>Writes a formatted string to the output destination of the <c> Formatter </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Formatter </c> . </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", AccessFlags = 129)]
				public global::Java.Util.Formatter Format(global::Java.Util.Locale l, string format, params object[] args) /* MethodBuilder.Create */ 
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

				}

		}

		/// <summary>
		/// <para><c> Calendar </c> is an abstract base class for converting between a <c> Date </c> object and a set of integer fields such as <c> YEAR </c> , <c> MONTH </c> , <c> DAY </c> , <c> HOUR </c> , and so on. (A <c> Date </c> object represents a specific instant in time with millisecond precision. See Date for information about the <c> Date </c> class.)</para><para>Subclasses of <c> Calendar </c> interpret a <c> Date </c> according to the rules of a specific calendar system.</para><para>Like other locale-sensitive classes, <c> Calendar </c> provides a class method, <c> getInstance </c> , for getting a default instance of this class for general use. <c> Calendar </c> 's <c> getInstance </c> method returns a calendar whose locale is based on system settings and whose time fields have been initialized with the current date and time: <blockquote><para></para><para><pre>Calendar rightNow = Calendar.getInstance()</pre></para><para></para></blockquote></para><para>A <c> Calendar </c> object can produce all the time field values needed to implement the date-time formatting for a particular language and calendar style (for example, Japanese-Gregorian, Japanese-Traditional). <c> Calendar </c> defines the range of values returned by certain fields, as well as their meaning. For example, the first month of the year has value <c> MONTH </c> == <c> JANUARY </c> for all calendars. Other values are defined by the concrete subclass, such as <c> ERA </c> and <c> YEAR </c> . See individual field documentation and subclass documentation for details.</para><para>When a <c> Calendar </c> is <b>lenient</b>, it accepts a wider range of field values than it produces. For example, a lenient <c> GregorianCalendar </c> interprets <c> MONTH </c> == <c> JANUARY </c> , <c> DAY_OF_MONTH </c> == 32 as February 1. A non-lenient <c> GregorianCalendar </c> throws an exception when given out-of-range field settings. When calendars recompute field values for return by <c> get() </c> , they normalize them. For example, a <c> GregorianCalendar </c> always produces <c> DAY_OF_MONTH </c> values between 1 and the length of the month.</para><para><c> Calendar </c> defines a locale-specific seven day week using two parameters: the first day of the week and the minimal days in first week (from 1 to 7). These numbers are taken from the locale resource data when a <c> Calendar </c> is constructed. They may also be specified explicitly through the API.</para><para>When setting or getting the <c> WEEK_OF_MONTH </c> or <c> WEEK_OF_YEAR </c> fields, <c> Calendar </c> must determine the first week of the month or year as a reference point. The first week of a month or year is defined as the earliest seven day period beginning on <c> getFirstDayOfWeek() </c> and containing at least <c> getMinimalDaysInFirstWeek() </c> days of that month or year. Weeks numbered ..., -1, 0 precede the first week; weeks numbered 2, 3,... follow it. Note that the normalized numbering returned by <c> get() </c> may be different. For example, a specific <c> Calendar </c> subclass may designate the week before week 1 of a year as week <b>n</b> of the previous year.</para><para>When computing a <c> Date </c> from time fields, two special circumstances may arise: there may be insufficient information to compute the <c> Date </c> (such as only year and month but no day in the month), or there may be inconsistent information (such as "Tuesday, July 15, 1996"  July 15, 1996 is actually a Monday).</para><para><b>Insufficient information.</b> The calendar will use default information to specify the missing fields. This may vary by calendar; for the Gregorian calendar, the default for a field is the same as that of the start of the epoch: i.e., YEAR = 1970, MONTH = JANUARY, DATE = 1, etc.</para><para><b>Inconsistent information.</b> If fields conflict, the calendar will give preference to fields set more recently. For example, when determining the day, the calendar will look for one of the following combinations of fields. The most recent combination, as determined by the most recently set single field, will be used.</para><para><blockquote><para></para><para><pre>
		///    MONTH + DAY_OF_MONTH
		///    MONTH + WEEK_OF_MONTH + DAY_OF_WEEK
		///    MONTH + DAY_OF_WEEK_IN_MONTH + DAY_OF_WEEK
		///    DAY_OF_YEAR
		///    DAY_OF_WEEK + WEEK_OF_YEAR</pre></para><para></para></blockquote></para><para>For the time of day:</para><para><blockquote><para></para><para><pre>
		///    HOUR_OF_DAY
		///    AM_PM + HOUR</pre></para><para></para></blockquote></para><para><b>Note:</b> There are certain possible ambiguities in interpretation of certain singular times, which are resolved in the following ways: <ol><li><para>24:00:00 "belongs" to the following day. That is, 23:59 on Dec 31, 1969 &lt; 24:00 on Jan 1, 1970 &lt; 24:01:00 on Jan 1, 1970 form a sequence of three consecutive minutes in time.</para><para></para></li><li><para>Although historically not precise, midnight also belongs to "am", and noon belongs to "pm", so on the same day, we have 12:00 am (midnight) &lt; 12:01 am, and 12:00 pm (noon) &lt; 12:01 pm </para></li></ol></para><para>The date or time format strings are not part of the definition of a calendar, as those must be modifiable or overridable by the user at runtime. Use java.text.DateFormat to format dates.</para><para><b>Field manipulation methods</b></para><para><c> Calendar </c> fields can be changed using three methods: <c> set() </c> , <c> add() </c> , and <c> roll() </c> .</para><para><b><c> set(f, value) </c> </b> changes field <c> f </c> to <c> value </c> . In addition, it sets an internal member variable to indicate that field <c> f </c> has been changed. Although field <c> f </c> is changed immediately, the calendar's milliseconds is not recomputed until the next call to <c> get() </c> , <c> getTime() </c> , or <c> getTimeInMillis() </c> is made. Thus, multiple calls to <c> set() </c> do not trigger multiple, unnecessary computations. As a result of changing a field using <c> set() </c> , other fields may also change, depending on the field, the field value, and the calendar system. In addition, <c> get(f) </c> will not necessarily return <c> value </c> after the fields have been recomputed. The specifics are determined by the concrete calendar class.</para><para><b>Example</b>: Consider a <c> GregorianCalendar </c> originally set to August 31, 1999. Calling <code>set(Calendar.MONTH, Calendar.SEPTEMBER)</code> sets the calendar to September 31, 1999. This is a temporary internal representation that resolves to October 1, 1999 if <c> getTime() </c> is then called. However, a call to <c> set(Calendar.DAY_OF_MONTH, 30) </c> before the call to <c> getTime() </c> sets the calendar to September 30, 1999, since no recomputation occurs after <c> set() </c> itself.</para><para><b><c> add(f, delta) </c> </b> adds <c> delta </c> to field <c> f </c> . This is equivalent to calling <code>set(f, get(f) + delta)</code> with two adjustments:</para><para><blockquote><para></para><para><b>Add rule 1</b>. The value of field <c> f </c> after the call minus the value of field <c> f </c> before the call is <c> delta </c> , modulo any overflow that has occurred in field <c> f </c> . Overflow occurs when a field value exceeds its range and, as a result, the next larger field is incremented or decremented and the field value is adjusted back into its range.</para><para></para><para><b>Add rule 2</b>. If a smaller field is expected to be invariant, but   it is impossible for it to be equal to its prior value because of changes in its minimum or maximum after field <c> f </c> is changed, then its value is adjusted to be as close as possible to its expected value. A smaller field represents a smaller unit of time. <c> HOUR </c> is a smaller field than <c> DAY_OF_MONTH </c> . No adjustment is made to smaller fields that are not expected to be invariant. The calendar system determines what fields are expected to be invariant. </para></blockquote></para><para>In addition, unlike <c> set() </c> , <c> add() </c> forces an immediate recomputation of the calendar's milliseconds and all fields.</para><para><b>Example</b>: Consider a <c> GregorianCalendar </c> originally set to August 31, 1999. Calling <c> add(Calendar.MONTH, 13) </c> sets the calendar to September 30, 2000. <b>Add rule 1</b> sets the <c> MONTH </c> field to September, since adding 13 months to August gives September of the next year. Since <c> DAY_OF_MONTH </c> cannot be 31 in September in a <c> GregorianCalendar </c> , <b>add rule 2</b> sets the <c> DAY_OF_MONTH </c> to 30, the closest possible value. Although it is a smaller field, <c> DAY_OF_WEEK </c> is not adjusted by rule 2, since it is expected to change when the month changes in a <c> GregorianCalendar </c> .</para><para><b><c> roll(f, delta) </c> </b> adds <c> delta </c> to field <c> f </c> without changing larger fields. This is equivalent to calling <c> add(f, delta) </c> with the following adjustment:</para><para><blockquote><para></para><para><b>Roll rule</b>. Larger fields are unchanged after the call. A larger field represents a larger unit of time. <c> DAY_OF_MONTH </c> is a larger field than <c> HOUR </c> . </para></blockquote></para><para><b>Example</b>: Consider a <c> GregorianCalendar </c> originally set to August 31, 1999. Calling <code>roll(Calendar.MONTH, 8)</code> sets the calendar to April 30, <b>1999</b>. Add rule 1 sets the <c> MONTH </c> field to April. Using a <c> GregorianCalendar </c> , the <c> DAY_OF_MONTH </c> cannot be 31 in the month April. Add rule 2 sets it to the closest possible value, 30. Finally, the <b>roll rule</b> maintains the <c> YEAR </c> field value of 1999.</para><para><b>Example</b>: Consider a <c> GregorianCalendar </c> originally set to Sunday June 6, 1999. Calling <c> roll(Calendar.WEEK_OF_MONTH, -1) </c> sets the calendar to Tuesday June 1, 1999, whereas calling <c> add(Calendar.WEEK_OF_MONTH, -1) </c> sets the calendar to Sunday May 30, 1999. This is because the roll rule imposes an additional constraint: The <c> MONTH </c> must not change when the <c> WEEK_OF_MONTH </c> is rolled. Taken together with add rule 1, the resultant date must be between Tuesday June 1 and Saturday June 5. According to add rule 2, the <c> DAY_OF_WEEK </c> , an invariant when changing the <c> WEEK_OF_MONTH </c> , is set to Tuesday, the closest possible value to Sunday (where Sunday is the first day of the week).</para><para><b>Usage model</b>. To motivate the behavior of <c> add() </c> and <c> roll() </c> , consider a user interface component with increment and decrement buttons for the month, day, and year, and an underlying <c> GregorianCalendar </c> . If the interface reads January 31, 1999 and the user presses the month increment button, what should it read? If the underlying implementation uses <c> set() </c> , it might read March 3, 1999. A better result would be February 28, 1999. Furthermore, if the user presses the month increment button again, it should read March 31, 1999, not March 28, 1999. By saving the original date and using either <c> add() </c> or <c> roll() </c> , depending on whether larger fields should be affected, the user interface can behave as most users will intuitively expect.</para><para><b>Note:</b> You should always use <c> roll </c> and <c> add </c> rather than attempting to perform arithmetic operations directly on the fields of a <code>Calendar</code>. It is quite possible for <code>Calendar</code> subclasses to have fields with non-linear behavior, for example missing months or days during non-leap years. The subclasses' <code>add</code> and <code>roll</code> methods will take this into account, while simple arithmetic manipulations may give invalid results.</para><para><para>Date </para><simplesectsep></simplesectsep><para>GregorianCalendar </para><simplesectsep></simplesectsep><para>TimeZone </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Calendar
		/// </java-name>
		[Dot42.DexImport("java/util/Calendar", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Cloneable;Ljava/lang/Comparabl" +
    "e<Ljava/util/Calendar;>;")]
		public abstract partial class Calendar : global::Java.Io.ISerializable, global::Java.Lang.ICloneable, global::System.IComparable<global::Java.Util.Calendar>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>True iff the values in <c> fields[] </c> correspond to <c> time </c> . Despite the name, this is effectively "are the values in fields[] up-to-date?"  <c> fields[] </c> may contain non-zero values and <c> isSet[] </c> may contain <c> true </c> values even when <c> areFieldsSet </c> is false. Accessing the fields via <c> get </c> will ensure the fields are up-to-date. </para>        
				/// </summary>
				/// <java-name>
				/// areFieldsSet
				/// </java-name>
				[Dot42.DexImport("areFieldsSet", "Z", AccessFlags = 4)]
				protected internal bool AreFieldsSet;
				/// <summary>
				/// <para>Contains broken-down field values for the current value of <c> time </c> if <c> areFieldsSet </c> is true, or stale data corresponding to some previous value otherwise. Accessing the fields via <c> get </c> will ensure the fields are up-to-date. The array length is always <c> FIELD_COUNT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// fields
				/// </java-name>
				[Dot42.DexImport("fields", "[I", AccessFlags = 4)]
				protected internal int[] Fields;
				/// <summary>
				/// <para>Whether the corresponding element in <c> field[] </c> has been set. Initially, these are all false. The first time the fields are computed, these are set to true and remain set even if the data becomes stale: you <b>must</b> check <c> areFieldsSet </c> if you want to know whether the value is up-to-date. Note that <c> isSet </c> is <b>not</b> a safe alternative to accessing this array directly, and will likewise return stale data! The array length is always <c> FIELD_COUNT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isSet
				/// </java-name>
				[Dot42.DexImport("isSet", "[Z", AccessFlags = 4)]
				protected internal bool[] IsSet0;
				/// <summary>
				/// <para>Whether <c> time </c> corresponds to the values in <c> fields[] </c> . If false, <c> time </c> is out-of-date with respect to changes <c> fields[] </c> . Accessing the time via <c> getTimeInMillis </c> will always return the correct value. </para>        
				/// </summary>
				/// <java-name>
				/// isTimeSet
				/// </java-name>
				[Dot42.DexImport("isTimeSet", "Z", AccessFlags = 4)]
				protected internal bool IsTimeSet;
				/// <summary>
				/// <para>A time in milliseconds since January 1, 1970. See <c> isTimeSet </c> . Accessing the time via <c> getTimeInMillis </c> will always return the correct value. </para>        
				/// </summary>
				/// <java-name>
				/// time
				/// </java-name>
				[Dot42.DexImport("time", "J", AccessFlags = 4)]
				protected internal long Time;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the first month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// JANUARY
				/// </java-name>
				[Dot42.DexImport("JANUARY", "I", AccessFlags = 25)]
				public const int JANUARY = 0;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the second month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// FEBRUARY
				/// </java-name>
				[Dot42.DexImport("FEBRUARY", "I", AccessFlags = 25)]
				public const int FEBRUARY = 1;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the third month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// MARCH
				/// </java-name>
				[Dot42.DexImport("MARCH", "I", AccessFlags = 25)]
				public const int MARCH = 2;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the fourth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// APRIL
				/// </java-name>
				[Dot42.DexImport("APRIL", "I", AccessFlags = 25)]
				public const int APRIL = 3;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the fifth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// MAY
				/// </java-name>
				[Dot42.DexImport("MAY", "I", AccessFlags = 25)]
				public const int MAY = 4;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the sixth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// JUNE
				/// </java-name>
				[Dot42.DexImport("JUNE", "I", AccessFlags = 25)]
				public const int JUNE = 5;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the seventh month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// JULY
				/// </java-name>
				[Dot42.DexImport("JULY", "I", AccessFlags = 25)]
				public const int JULY = 6;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the eighth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// AUGUST
				/// </java-name>
				[Dot42.DexImport("AUGUST", "I", AccessFlags = 25)]
				public const int AUGUST = 7;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the ninth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// SEPTEMBER
				/// </java-name>
				[Dot42.DexImport("SEPTEMBER", "I", AccessFlags = 25)]
				public const int SEPTEMBER = 8;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the tenth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// OCTOBER
				/// </java-name>
				[Dot42.DexImport("OCTOBER", "I", AccessFlags = 25)]
				public const int OCTOBER = 9;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the eleventh month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// NOVEMBER
				/// </java-name>
				[Dot42.DexImport("NOVEMBER", "I", AccessFlags = 25)]
				public const int NOVEMBER = 10;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the twelfth month of the year. </para>        
				/// </summary>
				/// <java-name>
				/// DECEMBER
				/// </java-name>
				[Dot42.DexImport("DECEMBER", "I", AccessFlags = 25)]
				public const int DECEMBER = 11;
				/// <summary>
				/// <para>Value of the <c> MONTH </c> field indicating the thirteenth month of the year. Although <c> GregorianCalendar </c> does not use this value, lunar calendars do. </para>        
				/// </summary>
				/// <java-name>
				/// UNDECIMBER
				/// </java-name>
				[Dot42.DexImport("UNDECIMBER", "I", AccessFlags = 25)]
				public const int UNDECIMBER = 12;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Sunday. </para>        
				/// </summary>
				/// <java-name>
				/// SUNDAY
				/// </java-name>
				[Dot42.DexImport("SUNDAY", "I", AccessFlags = 25)]
				public const int SUNDAY = 1;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Monday. </para>        
				/// </summary>
				/// <java-name>
				/// MONDAY
				/// </java-name>
				[Dot42.DexImport("MONDAY", "I", AccessFlags = 25)]
				public const int MONDAY = 2;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Tuesday. </para>        
				/// </summary>
				/// <java-name>
				/// TUESDAY
				/// </java-name>
				[Dot42.DexImport("TUESDAY", "I", AccessFlags = 25)]
				public const int TUESDAY = 3;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Wednesday. </para>        
				/// </summary>
				/// <java-name>
				/// WEDNESDAY
				/// </java-name>
				[Dot42.DexImport("WEDNESDAY", "I", AccessFlags = 25)]
				public const int WEDNESDAY = 4;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Thursday. </para>        
				/// </summary>
				/// <java-name>
				/// THURSDAY
				/// </java-name>
				[Dot42.DexImport("THURSDAY", "I", AccessFlags = 25)]
				public const int THURSDAY = 5;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Friday. </para>        
				/// </summary>
				/// <java-name>
				/// FRIDAY
				/// </java-name>
				[Dot42.DexImport("FRIDAY", "I", AccessFlags = 25)]
				public const int FRIDAY = 6;
				/// <summary>
				/// <para>Value of the <c> DAY_OF_WEEK </c> field indicating Saturday. </para>        
				/// </summary>
				/// <java-name>
				/// SATURDAY
				/// </java-name>
				[Dot42.DexImport("SATURDAY", "I", AccessFlags = 25)]
				public const int SATURDAY = 7;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the era, e.g., AD or BC in the Julian calendar. This is a calendar-specific value; see subclass documentation.</para><para><para>GregorianCalendar::AD </para><simplesectsep></simplesectsep><para>GregorianCalendar::BC </para></para>        
				/// </summary>
				/// <java-name>
				/// ERA
				/// </java-name>
				[Dot42.DexImport("ERA", "I", AccessFlags = 25)]
				public const int ERA = 0;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the year. This is a calendar-specific value; see subclass documentation. </para>        
				/// </summary>
				/// <java-name>
				/// YEAR
				/// </java-name>
				[Dot42.DexImport("YEAR", "I", AccessFlags = 25)]
				public const int YEAR = 1;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the month. This is a calendar-specific value. The first month of the year is <c> JANUARY </c> ; the last depends on the number of months in a year.</para><para><para>JANUARY </para><simplesectsep></simplesectsep><para>FEBRUARY </para><simplesectsep></simplesectsep><para>MARCH </para><simplesectsep></simplesectsep><para>APRIL </para><simplesectsep></simplesectsep><para>MAY </para><simplesectsep></simplesectsep><para>JUNE </para><simplesectsep></simplesectsep><para>JULY </para><simplesectsep></simplesectsep><para>AUGUST </para><simplesectsep></simplesectsep><para>SEPTEMBER </para><simplesectsep></simplesectsep><para>OCTOBER </para><simplesectsep></simplesectsep><para>NOVEMBER </para><simplesectsep></simplesectsep><para>DECEMBER </para><simplesectsep></simplesectsep><para>UNDECIMBER </para></para>        
				/// </summary>
				/// <java-name>
				/// MONTH
				/// </java-name>
				[Dot42.DexImport("MONTH", "I", AccessFlags = 25)]
				public const int MONTH = 2;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the week number within the current year. The first week of the year, as defined by <c> getFirstDayOfWeek() </c> and <c> getMinimalDaysInFirstWeek() </c> , has value 1. Subclasses define the value of <c> WEEK_OF_YEAR </c> for days before the first week of the year.</para><para><para>getFirstDayOfWeek </para><simplesectsep></simplesectsep><para>getMinimalDaysInFirstWeek </para></para>        
				/// </summary>
				/// <java-name>
				/// WEEK_OF_YEAR
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_YEAR", "I", AccessFlags = 25)]
				public const int WEEK_OF_YEAR = 3;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the week number within the current month. The first week of the month, as defined by <c> getFirstDayOfWeek() </c> and <c> getMinimalDaysInFirstWeek() </c> , has value 1. Subclasses define the value of <c> WEEK_OF_MONTH </c> for days before the first week of the month.</para><para><para>getFirstDayOfWeek </para><simplesectsep></simplesectsep><para>getMinimalDaysInFirstWeek </para></para>        
				/// </summary>
				/// <java-name>
				/// WEEK_OF_MONTH
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_MONTH", "I", AccessFlags = 25)]
				public const int WEEK_OF_MONTH = 4;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the day of the month. This is a synonym for <c> DAY_OF_MONTH </c> . The first day of the month has value 1.</para><para><para>DAY_OF_MONTH </para></para>        
				/// </summary>
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "I", AccessFlags = 25)]
				public const int DATE = 5;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the day of the month. This is a synonym for <c> DATE </c> . The first day of the month has value 1.</para><para><para>DATE </para></para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_MONTH
				/// </java-name>
				[Dot42.DexImport("DAY_OF_MONTH", "I", AccessFlags = 25)]
				public const int DAY_OF_MONTH = 5;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the day number within the current year. The first day of the year has value 1. </para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_YEAR
				/// </java-name>
				[Dot42.DexImport("DAY_OF_YEAR", "I", AccessFlags = 25)]
				public const int DAY_OF_YEAR = 6;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the day of the week. This field takes values <c> SUNDAY </c> , <c> MONDAY </c> , <c> TUESDAY </c> , <c> WEDNESDAY </c> , <c> THURSDAY </c> , <c> FRIDAY </c> , and <c> SATURDAY </c> .</para><para><para>SUNDAY </para><simplesectsep></simplesectsep><para>MONDAY </para><simplesectsep></simplesectsep><para>TUESDAY </para><simplesectsep></simplesectsep><para>WEDNESDAY </para><simplesectsep></simplesectsep><para>THURSDAY </para><simplesectsep></simplesectsep><para>FRIDAY </para><simplesectsep></simplesectsep><para>SATURDAY </para></para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_WEEK
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK = 7;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the ordinal number of the day of the week within the current month. Together with the <c> DAY_OF_WEEK </c> field, this uniquely specifies a day within a month. Unlike <c> WEEK_OF_MONTH </c> and <c> WEEK_OF_YEAR </c> , this field's value does <b>not</b> depend on <c> getFirstDayOfWeek() </c> or <c> getMinimalDaysInFirstWeek() </c> . <c> DAY_OF_MONTH 1 </c> through <c> 7 </c> always correspond to <code>DAY_OF_WEEK_IN_MONTH 1</code>; <c> 8 </c> through <c> 15 </c> correspond to <c> DAY_OF_WEEK_IN_MONTH 2 </c> , and so on. <c> DAY_OF_WEEK_IN_MONTH 0 </c> indicates the week before <c> DAY_OF_WEEK_IN_MONTH 1 </c> . Negative values count back from the end of the month, so the last Sunday of a month is specified as <c> DAY_OF_WEEK = SUNDAY, DAY_OF_WEEK_IN_MONTH = -1 </c> . Because negative values count backward they will usually be aligned differently within the month than positive values. For example, if a month has 31 days, <c> DAY_OF_WEEK_IN_MONTH -1 </c> will overlap <c> DAY_OF_WEEK_IN_MONTH 5 </c> and the end of <c> 4 </c> .</para><para><para>DAY_OF_WEEK </para><simplesectsep></simplesectsep><para>WEEK_OF_MONTH </para></para>        
				/// </summary>
				/// <java-name>
				/// DAY_OF_WEEK_IN_MONTH
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK_IN_MONTH", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK_IN_MONTH = 8;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating whether the <c> HOUR </c> is before or after noon. E.g., at 10:04:15.250 PM the <c> AM_PM </c> is <c> PM </c> .</para><para><para>AM </para><simplesectsep></simplesectsep><para>PM </para><simplesectsep></simplesectsep><para>HOUR </para></para>        
				/// </summary>
				/// <java-name>
				/// AM_PM
				/// </java-name>
				[Dot42.DexImport("AM_PM", "I", AccessFlags = 25)]
				public const int AM_PM = 9;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the hour of the morning or afternoon. <c> HOUR </c> is used for the 12-hour clock. E.g., at 10:04:15.250 PM the <c> HOUR </c> is 10.</para><para><para>AM_PM </para><simplesectsep></simplesectsep><para>HOUR_OF_DAY </para></para>        
				/// </summary>
				/// <java-name>
				/// HOUR
				/// </java-name>
				[Dot42.DexImport("HOUR", "I", AccessFlags = 25)]
				public const int HOUR = 10;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the hour of the day. <c> HOUR_OF_DAY </c> is used for the 24-hour clock. E.g., at 10:04:15.250 PM the <c> HOUR_OF_DAY </c> is 22.</para><para><para>HOUR </para></para>        
				/// </summary>
				/// <java-name>
				/// HOUR_OF_DAY
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY", "I", AccessFlags = 25)]
				public const int HOUR_OF_DAY = 11;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the minute within the hour. E.g., at 10:04:15.250 PM the <c> MINUTE </c> is 4. </para>        
				/// </summary>
				/// <java-name>
				/// MINUTE
				/// </java-name>
				[Dot42.DexImport("MINUTE", "I", AccessFlags = 25)]
				public const int MINUTE = 12;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the second within the minute. E.g., at 10:04:15.250 PM the <c> SECOND </c> is 15. </para>        
				/// </summary>
				/// <java-name>
				/// SECOND
				/// </java-name>
				[Dot42.DexImport("SECOND", "I", AccessFlags = 25)]
				public const int SECOND = 13;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the millisecond within the second. E.g., at 10:04:15.250 PM the <c> MILLISECOND </c> is 250. </para>        
				/// </summary>
				/// <java-name>
				/// MILLISECOND
				/// </java-name>
				[Dot42.DexImport("MILLISECOND", "I", AccessFlags = 25)]
				public const int MILLISECOND = 14;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the raw offset from GMT in milliseconds. </para>        
				/// </summary>
				/// <java-name>
				/// ZONE_OFFSET
				/// </java-name>
				[Dot42.DexImport("ZONE_OFFSET", "I", AccessFlags = 25)]
				public const int ZONE_OFFSET = 15;
				/// <summary>
				/// <para>Field number for <c> get </c> and <c> set </c> indicating the daylight savings offset in milliseconds. </para>        
				/// </summary>
				/// <java-name>
				/// DST_OFFSET
				/// </java-name>
				[Dot42.DexImport("DST_OFFSET", "I", AccessFlags = 25)]
				public const int DST_OFFSET = 16;
				/// <summary>
				/// <para>This is the total number of fields in this calendar. </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_COUNT
				/// </java-name>
				[Dot42.DexImport("FIELD_COUNT", "I", AccessFlags = 25)]
				public const int FIELD_COUNT = 17;
				/// <summary>
				/// <para>Value of the <c> AM_PM </c> field indicating the period of the day from midnight to just before noon. </para>        
				/// </summary>
				/// <java-name>
				/// AM
				/// </java-name>
				[Dot42.DexImport("AM", "I", AccessFlags = 25)]
				public const int AM = 0;
				/// <summary>
				/// <para>Value of the <c> AM_PM </c> field indicating the period of the day from noon to just before midnight. </para>        
				/// </summary>
				/// <java-name>
				/// PM
				/// </java-name>
				[Dot42.DexImport("PM", "I", AccessFlags = 25)]
				public const int PM = 1;
				/// <summary>
				/// <para>Requests both <c> SHORT </c> and <c> LONG </c> styles in the map returned by getDisplayNames. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// ALL_STYLES
				/// </java-name>
				[Dot42.DexImport("ALL_STYLES", "I", AccessFlags = 25)]
				public const int ALL_STYLES = 0;
				/// <summary>
				/// <para>Requests short names (such as "Jan") from getDisplayName or getDisplayNames. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// SHORT
				/// </java-name>
				[Dot42.DexImport("SHORT", "I", AccessFlags = 25)]
				public const int SHORT = 1;
				/// <summary>
				/// <para>Requests long names (such as "January") from getDisplayName or getDisplayNames. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// LONG
				/// </java-name>
				[Dot42.DexImport("LONG", "I", AccessFlags = 25)]
				public const int LONG = 2;
				/// <summary>
				/// <para>Constructs a <c> Calendar </c> instance using the default <c> TimeZone </c> and <c> Locale </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Calendar() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a <c> Calendar </c> instance using the given <c> TimeZone </c> and <c> Locale </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V", AccessFlags = 4)]
				protected internal Calendar(global::Java.Util.TimeZone timezone, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the given amount to a <c> Calendar </c> field.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(II)V", AccessFlags = 1025)]
				public abstract void Add(int field, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether the <c> Date </c> represented by this <c> Calendar </c> instance is after the <c> Date </c> represented by the parameter. The comparison is not dependent on the time zones of the <c> Calendar </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> when this Calendar is after calendar, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool After(object calendar) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the <c> Date </c> represented by this <c> Calendar </c> instance is before the <c> Date </c> represented by the parameter. The comparison is not dependent on the time zones of the <c> Calendar </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> when this Calendar is before calendar, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Before(object calendar) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clears all of the fields of this <c> Calendar </c> . All fields are initialized to zero. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 17)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the given field to zero and sets the isSet flag to <c> false </c> . </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(I)V", AccessFlags = 17)]
				public void Clear(int field) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a shallow copy of this <c> Calendar </c> with the same properties. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Computes the time from the fields if the time has not already been set. Computes the fields from the time if the fields are not already set.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// complete
				/// </java-name>
				[Dot42.DexImport("complete", "()V", AccessFlags = 4)]
				protected internal virtual void Complete() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes the <c> Calendar </c> fields from <c> time </c> . </para>        
				/// </summary>
				/// <java-name>
				/// computeFields
				/// </java-name>
				[Dot42.DexImport("computeFields", "()V", AccessFlags = 1028)]
				protected internal abstract void ComputeFields() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Computes <c> time </c> from the Calendar fields.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// computeTime
				/// </java-name>
				[Dot42.DexImport("computeTime", "()V", AccessFlags = 1028)]
				protected internal abstract void ComputeTime() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the given object to this <c> Calendar </c> and returns whether they are equal. The object must be an instance of <c> Calendar </c> and have the same properties.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given object is equal to this <c> Calendar </c> , <c> false </c> otherwise. </para>
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
				/// <para>Returns the value of the given field after computing the field values by calling <c> complete() </c> first.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 1)]
				public virtual int Get(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the maximum value of the given field for the current date. For example, the maximum number of days in the current month. </para>        
				/// </summary>
				/// <java-name>
				/// getActualMaximum
				/// </java-name>
				[Dot42.DexImport("getActualMaximum", "(I)I", AccessFlags = 1)]
				public virtual int GetActualMaximum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum value of the given field for the current date. </para>        
				/// </summary>
				/// <java-name>
				/// getActualMinimum
				/// </java-name>
				[Dot42.DexImport("getActualMinimum", "(I)I", AccessFlags = 1)]
				public virtual int GetActualMinimum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> Calendar </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 41)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <summary>
				/// <para>Returns the first day of the week for this <c> Calendar </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getFirstDayOfWeek
				/// </java-name>
				[Dot42.DexImport("getFirstDayOfWeek", "()I", AccessFlags = 1)]
				public virtual int GetFirstDayOfWeek() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the greatest minimum value of the given field. This is the biggest value that <c> getActualMinimum </c> can return for any possible time. </para>        
				/// </summary>
				/// <java-name>
				/// getGreatestMinimum
				/// </java-name>
				[Dot42.DexImport("getGreatestMinimum", "(I)I", AccessFlags = 1025)]
				public abstract int GetGreatestMinimum(int field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Constructs a new instance of the <c> Calendar </c> subclass appropriate for the default <c> Locale </c> and default <c> TimeZone </c> , set to the current date and time. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <summary>
				/// <para>Constructs a new instance of the <c> Calendar </c> subclass appropriate for the given <c> Locale </c> and default <c> TimeZone </c> , set to the current date and time. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <summary>
				/// <para>Constructs a new instance of the <c> Calendar </c> subclass appropriate for the given <c> Locale </c> and default <c> TimeZone </c> , set to the current date and time. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance(global::Java.Util.TimeZone locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <summary>
				/// <para>Constructs a new instance of the <c> Calendar </c> subclass appropriate for the given <c> Locale </c> and given <c> TimeZone </c> , set to the current date and time. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;", AccessFlags = 41)]
				public static global::Java.Util.Calendar GetInstance(global::Java.Util.TimeZone timezone, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Calendar);
				}

				/// <summary>
				/// <para>Returns the smallest maximum value of the given field. This is the smallest value that <c> getActualMaximum() </c> can return for any possible time. </para>        
				/// </summary>
				/// <java-name>
				/// getLeastMaximum
				/// </java-name>
				[Dot42.DexImport("getLeastMaximum", "(I)I", AccessFlags = 1025)]
				public abstract int GetLeastMaximum(int field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the greatest maximum value of the given field. This returns the biggest value that <c> get </c> can return for the given field. </para>        
				/// </summary>
				/// <java-name>
				/// getMaximum
				/// </java-name>
				[Dot42.DexImport("getMaximum", "(I)I", AccessFlags = 1025)]
				public abstract int GetMaximum(int field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the minimal days in the first week of the year. </para>        
				/// </summary>
				/// <java-name>
				/// getMinimalDaysInFirstWeek
				/// </java-name>
				[Dot42.DexImport("getMinimalDaysInFirstWeek", "()I", AccessFlags = 1)]
				public virtual int GetMinimalDaysInFirstWeek() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the smallest minimum value of the given field. this returns the smallest value that <c> get </c> can return for the given field. </para>        
				/// </summary>
				/// <java-name>
				/// getMinimum
				/// </java-name>
				[Dot42.DexImport("getMinimum", "(I)I", AccessFlags = 1025)]
				public abstract int GetMinimum(int field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the time of this <c> Calendar </c> as a <c> Date </c> object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "()Ljava/util/Date;", AccessFlags = 17)]
				public global::Java.Util.Date GetTime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Returns the time represented by this <c> Calendar </c> , recomputing the time from its fields if necessary.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				[Dot42.DexImport("getTimeInMillis", "()J", AccessFlags = 1)]
				public virtual long GetTimeInMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the time zone used by this <c> Calendar </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "()Ljava/util/TimeZone;", AccessFlags = 1)]
				public virtual global::Java.Util.TimeZone GetTimeZone() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value of the given field without recomputing. </para>        
				/// </summary>
				/// <java-name>
				/// internalGet
				/// </java-name>
				[Dot42.DexImport("internalGet", "(I)I", AccessFlags = 20)]
				protected internal int InternalGet(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Tests whether this <c> Calendar </c> accepts field values which are outside the valid range for the field. </para>        
				/// </summary>
				/// <java-name>
				/// isLenient
				/// </java-name>
				[Dot42.DexImport("isLenient", "()Z", AccessFlags = 1)]
				public virtual bool IsLenient() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the given field is set. Note that the interpretation of "is set" is somewhat technical. In particular, it does <b>not</b> mean that the field's value is up to date. If you want to know whether a field contains an up-to-date value, you must also check <c> areFieldsSet </c> , making this method somewhat useless unless you're a subclass, in which case you can access the <c> isSet </c> array directly. </para><para>A field remains "set" from the first time its value is computed until it's cleared by one of the <c> clear </c> methods. Thus "set" does not mean "valid". You probably want to call <c> get </c>  which will update fields as necessary  rather than try to make use of this method. </para>        
				/// </summary>
				/// <java-name>
				/// isSet
				/// </java-name>
				[Dot42.DexImport("isSet", "(I)Z", AccessFlags = 17)]
				public bool IsSet(int field) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the given amount to the given field and wraps the value of the field when it goes beyond the maximum or minimum value for the current date. Other fields will be adjusted as required to maintain a consistent date. </para>        
				/// </summary>
				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(II)V", AccessFlags = 1)]
				public virtual void Roll(int field, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the given amount to the given field and wraps the value of the field when it goes beyond the maximum or minimum value for the current date. Other fields will be adjusted as required to maintain a consistent date. </para>        
				/// </summary>
				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(IZ)V", AccessFlags = 1025)]
				public abstract void Roll(int field, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the given field to the given value. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 1)]
				public virtual void Set(int field, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the year, month, and day of the month fields. Other fields are not changed; call clear first if this is not desired. The month value is 0-based, so it may be clearer to use a constant like <c> JANUARY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(III)V", AccessFlags = 17)]
				public void Set(int year, int month, int day) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the year, month, day of the month, hour of day, and minute fields. Other fields are not changed; call clear first if this is not desired. The month value is 0-based, so it may be clearer to use a constant like <c> JANUARY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIIII)V", AccessFlags = 17)]
				public void Set(int year, int month, int day, int hourOfDay, int minute) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the year, month, day of the month, hour of day, minute, and second fields. Other fields are not changed; call clear first if this is not desired. The month value is 0-based, so it may be clearer to use a constant like <c> JANUARY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIIIII)V", AccessFlags = 17)]
				public void Set(int year, int month, int day, int hourOfDay, int minute, int second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the first day of the week for this <c> Calendar </c> . The value should be a day of the week such as <c> MONDAY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setFirstDayOfWeek
				/// </java-name>
				[Dot42.DexImport("setFirstDayOfWeek", "(I)V", AccessFlags = 1)]
				public virtual void SetFirstDayOfWeek(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether this <c> Calendar </c> accepts field values which are outside the valid range for the field. </para>        
				/// </summary>
				/// <java-name>
				/// setLenient
				/// </java-name>
				[Dot42.DexImport("setLenient", "(Z)V", AccessFlags = 1)]
				public virtual void SetLenient(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the minimal days in the first week of the year. </para>        
				/// </summary>
				/// <java-name>
				/// setMinimalDaysInFirstWeek
				/// </java-name>
				[Dot42.DexImport("setMinimalDaysInFirstWeek", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimalDaysInFirstWeek(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the time of this <c> Calendar </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/util/Date;)V", AccessFlags = 17)]
				public void SetTime(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the time of this <c> Calendar </c> to the given Unix time. See Date for more about what this means. </para>        
				/// </summary>
				/// <java-name>
				/// setTimeInMillis
				/// </java-name>
				[Dot42.DexImport("setTimeInMillis", "(J)V", AccessFlags = 1)]
				public virtual void SetTimeInMillis(long milliseconds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the <c> TimeZone </c> used by this Calendar. </para>        
				/// </summary>
				/// <java-name>
				/// setTimeZone
				/// </java-name>
				[Dot42.DexImport("setTimeZone", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
				public virtual void SetTimeZone(global::Java.Util.TimeZone timezone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a string representation of this <c> Calendar </c> , showing which fields are set. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compares the time represented by this <c> Calendar </c> to that represented by the given <c> Calendar </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>0 if the times of the two <c> Calendar </c> s are equal, -1 if the time of this <c> Calendar </c> is before the other one, 1 if the time of this <c> Calendar </c> is after the other one. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/Calendar;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Util.Calendar anotherCalendar) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a human-readable string for the value of <c> field </c> using the given style and locale. If no string is available, returns null. The value is retrieved by invoking <c> get(field) </c> .</para><para>For example, <c> getDisplayName(MONTH, SHORT, Locale.US) </c> will return "Jan" while <c> getDisplayName(MONTH, LONG, Locale.US) </c> will return "January".</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the display name, or null </para>
				/// </returns>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayName(int field, int style, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a map of human-readable strings to corresponding values, for the given field, style, and locale. Returns null if no strings are available.</para><para>For example, <c> getDisplayNames(MONTH, ALL_STYLES, Locale.US) </c> would contain mappings from "Jan" and "January" to JANUARY, and so on.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the display name, or null </para>
				/// </returns>
				/// <java-name>
				/// getDisplayNames
				/// </java-name>
				[Dot42.DexImport("getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;", AccessFlags = 1, Signature = "(IILjava/util/Locale;)Ljava/util/Map<Ljava/lang/String;Ljava/lang/Integer;>;")]
				public virtual global::Java.Util.IMap<string, int?> GetDisplayNames(int field, int style, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, int?>);
				}

				/// <summary>
				/// <para>Returns an array of locales for which custom <c> Calendar </c> instances are available. </para><para>Note that Android does not support user-supplied locale service providers. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 41)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns the first day of the week for this <c> Calendar </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getFirstDayOfWeek
				/// </java-name>
				public int FirstDayOfWeek
				{
				[Dot42.DexImport("getFirstDayOfWeek", "()I", AccessFlags = 1)]
						get{ return GetFirstDayOfWeek(); }
				[Dot42.DexImport("setFirstDayOfWeek", "(I)V", AccessFlags = 1)]
						set{ SetFirstDayOfWeek(value); }
				}

				/// <summary>
				/// <para>Constructs a new instance of the <c> Calendar </c> subclass appropriate for the default <c> Locale </c> and default <c> TimeZone </c> , set to the current date and time. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Util.Calendar Instance
				{
				[Dot42.DexImport("getInstance", "()Ljava/util/Calendar;", AccessFlags = 41)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Returns the minimal days in the first week of the year. </para>        
				/// </summary>
				/// <java-name>
				/// getMinimalDaysInFirstWeek
				/// </java-name>
				public int MinimalDaysInFirstWeek
				{
				[Dot42.DexImport("getMinimalDaysInFirstWeek", "()I", AccessFlags = 1)]
						get{ return GetMinimalDaysInFirstWeek(); }
				[Dot42.DexImport("setMinimalDaysInFirstWeek", "(I)V", AccessFlags = 1)]
						set{ SetMinimalDaysInFirstWeek(value); }
				}

				/// <summary>
				/// <para>Returns the time represented by this <c> Calendar </c> , recomputing the time from its fields if necessary.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				public long TimeInMillis
				{
				[Dot42.DexImport("getTimeInMillis", "()J", AccessFlags = 1)]
						get{ return GetTimeInMillis(); }
				[Dot42.DexImport("setTimeInMillis", "(J)V", AccessFlags = 1)]
						set{ SetTimeInMillis(value); }
				}

				/// <summary>
				/// <para>Returns the time zone used by this <c> Calendar </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				public global::Java.Util.TimeZone TimeZone
				{
				[Dot42.DexImport("getTimeZone", "()Ljava/util/TimeZone;", AccessFlags = 1)]
						get{ return GetTimeZone(); }
				[Dot42.DexImport("setTimeZone", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
						set{ SetTimeZone(value); }
				}

		}

		/// <summary>
		/// <para>A <c> FormatFlagsConversionMismatchException </c> will be thrown if a conversion and the flags are incompatible.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/FormatFlagsConversionMismatchException
		/// </java-name>
		[Dot42.DexImport("java/util/FormatFlagsConversionMismatchException", AccessFlags = 33)]
		public partial class FormatFlagsConversionMismatchException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> FormatFlagsConversionMismatchException </c> with the flags and conversion specified.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;C)V", AccessFlags = 1)]
				public FormatFlagsConversionMismatchException(string f, char c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the incompatible format flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the incompatible format flag. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFlags() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the incompatible conversion.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the incompatible conversion. </para>
				/// </returns>
				/// <java-name>
				/// getConversion
				/// </java-name>
				[Dot42.DexImport("getConversion", "()C", AccessFlags = 1)]
				public virtual char GetConversion() /* MethodBuilder.Create */ 
				{
						return default(char);
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

				/// <summary>
				/// <para>Returns the incompatible format flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the incompatible format flag. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public string Flags
				{
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFlags(); }
				}

				/// <summary>
				/// <para>Returns the incompatible conversion.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the incompatible conversion. </para>
				/// </returns>
				/// <java-name>
				/// getConversion
				/// </java-name>
				public char Conversion
				{
				[Dot42.DexImport("getConversion", "()C", AccessFlags = 1)]
						get{ return GetConversion(); }
				}

		}

		/// <summary>
		/// <para>A <c> MissingFormatArgumentException </c> will be thrown if there is no corresponding argument with the specified conversion or an argument index that refers to a missing argument.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/MissingFormatArgumentException
		/// </java-name>
		[Dot42.DexImport("java/util/MissingFormatArgumentException", AccessFlags = 33)]
		public partial class MissingFormatArgumentException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> MissingFormatArgumentException </c> with the specified conversion that lacks the argument.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingFormatArgumentException(string s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the conversion associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the conversion associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getFormatSpecifier
				/// </java-name>
				[Dot42.DexImport("getFormatSpecifier", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFormatSpecifier() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Returns the conversion associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the conversion associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getFormatSpecifier
				/// </java-name>
				public string FormatSpecifier
				{
				[Dot42.DexImport("getFormatSpecifier", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFormatSpecifier(); }
				}

		}

		/// <summary>
		/// <para>Breaks a string into tokens; new code should probably use String#split.</para><para><blockquote><para><pre>
		///    // Legacy code:
		///    StringTokenizer st = new StringTokenizer("a:b:c", ":");
		///    while (st.hasMoreTokens()) {
		///        System.err.println(st.nextToken());
		///    }
		/// 
		///    // New code:
		///    for (String token : "a:b:c".split(":")) {
		///        System.err.println(token);
		///    }
		///    </pre> </para></blockquote></para><para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/StringTokenizer
		/// </java-name>
		[Dot42.DexImport("java/util/StringTokenizer", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/util/Enumeration<Ljava/lang/Object;>;")]
		public partial class StringTokenizer : global::Java.Util.IEnumeration<object>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> StringTokenizer </c> for the parameter string using whitespace as the delimiter. The <c> returnDelimiters </c> flag is set to <c> false </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringTokenizer(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> StringTokenizer </c> for the parameter string using the specified delimiters. The <c> returnDelimiters </c> flag is set to <c> false </c> . If <c> delimiters </c> is <c> null </c> , this constructor doesn't throw an <c> Exception </c> , but later calls to some methods might throw a <c> NullPointerException </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public StringTokenizer(string @string, string delimiters) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> StringTokenizer </c> for the parameter string using the specified delimiters, returning the delimiters as tokens if the parameter <c> returnDelimiters </c> is <c> true </c> . If <c> delimiters </c> is null this constructor doesn't throw an <c> Exception </c> , but later calls to some methods might throw a <c> NullPointerException </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public StringTokenizer(string @string, string delimiters, bool returnDelimiters) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of unprocessed tokens remaining in the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>number of tokens that can be retreived before an <c>               Exception </c> will result from a call to <c> nextToken() </c> . </para>
				/// </returns>
				/// <java-name>
				/// countTokens
				/// </java-name>
				[Dot42.DexImport("countTokens", "()I", AccessFlags = 1)]
				public virtual int CountTokens() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if unprocessed tokens remain. This method is implemented in order to satisfy the <c> Enumeration </c> interface.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if unprocessed tokens remain. </para>
				/// </returns>
				/// <java-name>
				/// hasMoreElements
				/// </java-name>
				[Dot42.DexImport("hasMoreElements", "()Z", AccessFlags = 1)]
				public virtual bool HasMoreElements() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if unprocessed tokens remain.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if unprocessed tokens remain. </para>
				/// </returns>
				/// <java-name>
				/// hasMoreTokens
				/// </java-name>
				[Dot42.DexImport("hasMoreTokens", "()Z", AccessFlags = 1)]
				public virtual bool HasMoreTokens() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the next token in the string as an <c> Object </c> . This method is implemented in order to satisfy the <c> Enumeration </c> interface.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>next token in the string as an <c> Object </c> </para>
				/// </returns>
				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object NextElement() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the next token in the string as a <c> String </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>next token in the string as a <c> String </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextToken() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the next token in the string as a <c> String </c> . The delimiters used are changed to the specified delimiters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>next token in the string as a <c> String </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextToken(string delims) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringTokenizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> TooManyListenersException </c> is thrown when an attempt is made to add more than one listener to an event source which only supports a single listener. It is also thrown when the same listener is added more than once. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/TooManyListenersException
		/// </java-name>
		[Dot42.DexImport("java/util/TooManyListenersException", AccessFlags = 33)]
		public partial class TooManyListenersException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> TooManyListenersException </c> with the current stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TooManyListenersException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> TooManyListenersException </c> with the stack trace and message filled in.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TooManyListenersException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><c> Locale </c> represents a language/country/variant combination. Locales are used to alter the presentation of information such as numbers or dates to suit the conventions in the region they describe.</para><para>The language codes are two-letter lowercase ISO language codes (such as "en") as defined by . The country codes are two-letter uppercase ISO country codes (such as "US") as defined by . The variant codes are unspecified.</para><para>Note that Java uses several deprecated two-letter codes. The Hebrew ("he") language code is rewritten as "iw", Indonesian ("id") as "in", and Yiddish ("yi") as "ji". This rewriting happens even if you construct your own <c> Locale </c> object, not just for instances returned by the various lookup methods.</para><para><h3>Available locales</h3></para><para>This class' constructors do no error checking. You can create a <c> Locale </c> for languages and countries that don't exist, and you can create instances for combinations that don't exist (such as "de_US" for "German as spoken in the US").</para><para>Note that locale data is not necessarily available for any of the locales pre-defined as constants in this class except for en_US, which is the only locale Java guarantees is always available.</para><para>It is also a mistake to assume that all devices have the same locales available. A device sold in the US will almost certainly support en_US and es_US, but not necessarily any locales with the same language but different countries (such as en_GB or es_ES), nor any locales for other languages (such as de_DE). The opposite may well be true for a device sold in Europe.</para><para>You can use Locale#getDefault to get an appropriate locale for the <b>user</b> of the device you're running on, or Locale#getAvailableLocales to get a list of all the locales available on the device you're running on.</para><para><h3>Locale data</h3></para><para>Note that locale data comes solely from ICU. User-supplied locale service providers (using the <c> java.text.spi </c> or <c> java.util.spi </c> mechanisms) are not supported.</para><para>Here are the versions of ICU (and the corresponding CLDR and Unicode versions) used in various Android releases: <table><row><entry><para>cupcake/donut/eclair </para></entry><entry><para>ICU 3.8 </para></entry><entry><para> </para></entry><entry><para> </para></entry></row><row><entry><para>froyo </para></entry><entry><para>ICU 4.2 </para></entry><entry><para> </para></entry><entry><para> </para></entry></row><row><entry><para>gingerbread/honeycomb</para></entry><entry><para>ICU 4.4 </para></entry><entry><para> </para></entry><entry><para> </para></entry></row><row><entry><para>ice cream sandwich </para></entry><entry><para>ICU 4.6 </para></entry><entry><para> </para></entry><entry><para> </para></entry></row><row><entry><para>jelly bean </para></entry><entry><para>ICU 4.8 </para></entry><entry><para> </para></entry><entry><para> </para></entry></row><row><entry><para>later </para></entry><entry><para>ICU 49 </para></entry><entry><para> </para></entry><entry><para> </para></entry></row></table></para><para><h3>Be wary of the default locale</h3></para><para>Note that there are many convenience methods that automatically use the default locale, but using them may lead to subtle bugs.</para><para>The default locale is appropriate for tasks that involve presenting data to the user. In this case, you want to use the user's date/time formats, number formats, rules for conversion to lowercase, and so on. In this case, it's safe to use the convenience methods.</para><para>The default locale is <b>not</b> appropriate for machine-readable output. The best choice there is usually <c> Locale.US </c>   this locale is guaranteed to be available on all devices, and the fact that it has no surprising special cases and is frequently used (especially for computer-computer communication) means that it tends to be the most efficient choice too.</para><para>A common mistake is to implicitly use the default locale when producing output meant to be machine-readable. This tends to work on the developer's test devices (especially because so many developers use en_US), but fails when run on a device whose user is in a more complex locale.</para><para>For example, if you're formatting integers some locales will use non-ASCII decimal digits. As another example, if you're formatting floating-point numbers some locales will use <c> ',' </c> as the decimal point and <c> '.' </c> for digit grouping. That's correct for human-readable output, but likely to cause problems if presented to another computer (Double#parseDouble can't parse such a number, for example). You should also be wary of the String#toLowerCase and String#toUpperCase overloads that don't take a <c> Locale </c> : in Turkey, for example, the characters <c> 'i' </c> and <c> 'I' </c> won't be converted to <c> 'I' </c> and <c> 'i' </c> . This is the correct behavior for Turkish text (such as user input), but inappropriate for, say, HTTP headers. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Locale
		/// </java-name>
		[Dot42.DexImport("java/util/Locale", AccessFlags = 49)]
		public sealed partial class Locale : global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Locale constant for en_CA. </para>        
				/// </summary>
				/// <java-name>
				/// CANADA
				/// </java-name>
				[Dot42.DexImport("CANADA", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CANADA;
				/// <summary>
				/// <para>Locale constant for fr_CA. </para>        
				/// </summary>
				/// <java-name>
				/// CANADA_FRENCH
				/// </java-name>
				[Dot42.DexImport("CANADA_FRENCH", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CANADA_FRENCH;
				/// <summary>
				/// <para>Locale constant for zh_CN. </para>        
				/// </summary>
				/// <java-name>
				/// CHINA
				/// </java-name>
				[Dot42.DexImport("CHINA", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CHINA;
				/// <summary>
				/// <para>Locale constant for zh. </para>        
				/// </summary>
				/// <java-name>
				/// CHINESE
				/// </java-name>
				[Dot42.DexImport("CHINESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale CHINESE;
				/// <summary>
				/// <para>Locale constant for en. </para>        
				/// </summary>
				/// <java-name>
				/// ENGLISH
				/// </java-name>
				[Dot42.DexImport("ENGLISH", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ENGLISH;
				/// <summary>
				/// <para>Locale constant for fr_FR. </para>        
				/// </summary>
				/// <java-name>
				/// FRANCE
				/// </java-name>
				[Dot42.DexImport("FRANCE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale FRANCE;
				/// <summary>
				/// <para>Locale constant for fr. </para>        
				/// </summary>
				/// <java-name>
				/// FRENCH
				/// </java-name>
				[Dot42.DexImport("FRENCH", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale FRENCH;
				/// <summary>
				/// <para>Locale constant for de. </para>        
				/// </summary>
				/// <java-name>
				/// GERMAN
				/// </java-name>
				[Dot42.DexImport("GERMAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale GERMAN;
				/// <summary>
				/// <para>Locale constant for de_DE. </para>        
				/// </summary>
				/// <java-name>
				/// GERMANY
				/// </java-name>
				[Dot42.DexImport("GERMANY", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale GERMANY;
				/// <summary>
				/// <para>Locale constant for it. </para>        
				/// </summary>
				/// <java-name>
				/// ITALIAN
				/// </java-name>
				[Dot42.DexImport("ITALIAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ITALIAN;
				/// <summary>
				/// <para>Locale constant for it_IT. </para>        
				/// </summary>
				/// <java-name>
				/// ITALY
				/// </java-name>
				[Dot42.DexImport("ITALY", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ITALY;
				/// <summary>
				/// <para>Locale constant for ja_JP. </para>        
				/// </summary>
				/// <java-name>
				/// JAPAN
				/// </java-name>
				[Dot42.DexImport("JAPAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale JAPAN;
				/// <summary>
				/// <para>Locale constant for ja. </para>        
				/// </summary>
				/// <java-name>
				/// JAPANESE
				/// </java-name>
				[Dot42.DexImport("JAPANESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale JAPANESE;
				/// <summary>
				/// <para>Locale constant for ko_KR. </para>        
				/// </summary>
				/// <java-name>
				/// KOREA
				/// </java-name>
				[Dot42.DexImport("KOREA", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale KOREA;
				/// <summary>
				/// <para>Locale constant for ko. </para>        
				/// </summary>
				/// <java-name>
				/// KOREAN
				/// </java-name>
				[Dot42.DexImport("KOREAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale KOREAN;
				/// <summary>
				/// <para>Locale constant for zh_CN. </para>        
				/// </summary>
				/// <java-name>
				/// PRC
				/// </java-name>
				[Dot42.DexImport("PRC", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale PRC;
				/// <summary>
				/// <para>Locale constant for the root locale. The root locale has an empty language, country, and variant.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// ROOT
				/// </java-name>
				[Dot42.DexImport("ROOT", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale ROOT;
				/// <summary>
				/// <para>Locale constant for zh_CN. </para>        
				/// </summary>
				/// <java-name>
				/// SIMPLIFIED_CHINESE
				/// </java-name>
				[Dot42.DexImport("SIMPLIFIED_CHINESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale SIMPLIFIED_CHINESE;
				/// <summary>
				/// <para>Locale constant for zh_TW. </para>        
				/// </summary>
				/// <java-name>
				/// TAIWAN
				/// </java-name>
				[Dot42.DexImport("TAIWAN", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale TAIWAN;
				/// <summary>
				/// <para>Locale constant for zh_TW. </para>        
				/// </summary>
				/// <java-name>
				/// TRADITIONAL_CHINESE
				/// </java-name>
				[Dot42.DexImport("TRADITIONAL_CHINESE", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale TRADITIONAL_CHINESE;
				/// <summary>
				/// <para>Locale constant for en_GB. </para>        
				/// </summary>
				/// <java-name>
				/// UK
				/// </java-name>
				[Dot42.DexImport("UK", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale UK;
				/// <summary>
				/// <para>Locale constant for en_US. </para>        
				/// </summary>
				/// <java-name>
				/// US
				/// </java-name>
				[Dot42.DexImport("US", "Ljava/util/Locale;", AccessFlags = 25)]
				public static readonly global::Java.Util.Locale US;
				/// <summary>
				/// <para>Constructs a new <c> Locale </c> using the specified language. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Locale(string language) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Locale </c> using the specified language and country codes. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Locale(string language, string country) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns true if <c> object </c> is a locale with the same language, country and variant. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the system's installed locales. This array always includes <c>       Locale.US </c> , and usually several others. Most locale-sensitive classes offer their own <c> getAvailableLocales </c> method, which should be preferred over this general purpose method.</para><para><para>java.text.BreakIterator::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.Collator::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.DateFormat::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.DateFormatSymbols::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.DecimalFormatSymbols::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.NumberFormat::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.util.Calendar::getAvailableLocales() </para></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale[] GetAvailableLocales() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale[]);
				}

				/// <summary>
				/// <para>Returns the country code for this locale, or <c> "" </c> if this locale doesn't correspond to a specific country. </para>        
				/// </summary>
				/// <java-name>
				/// getCountry
				/// </java-name>
				[Dot42.DexImport("getCountry", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCountry() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the user's preferred locale. This may have been overridden for this process with setDefault.</para><para>Since the user's locale changes dynamically, avoid caching this value. Instead, use this method to look it up for each use. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/util/Locale;", AccessFlags = 9)]
				public static global::Java.Util.Locale GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayCountry(Locale.getDefault()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayCountry
				/// </java-name>
				[Dot42.DexImport("getDisplayCountry", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayCountry() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of this locale's country, localized to <c> locale </c> . Returns the empty string if this locale does not correspond to a specific country. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayCountry
				/// </java-name>
				[Dot42.DexImport("getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayCountry(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayLanguage(Locale.getDefault()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayLanguage
				/// </java-name>
				[Dot42.DexImport("getDisplayLanguage", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayLanguage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of this locale's language, localized to <c> locale </c> . If the language name is unknown, the language code is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayLanguage
				/// </java-name>
				[Dot42.DexImport("getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayLanguage(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayName(Locale.getDefault()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns this locale's language name, country name, and variant, localized to <c> locale </c> . The exact output form depends on whether this locale corresponds to a specific language, country and variant.</para><para>For example: <ul><li><para><c> new Locale("en").getDisplayName(Locale.US) </c> -&gt; <c> English </c> </para></li><li><para><c> new Locale("en", "US").getDisplayName(Locale.US) </c> -&gt; <c> English (United States) </c> </para></li><li><para><c> new Locale("en", "US", "POSIX").getDisplayName(Locale.US) </c> -&gt; <c> English (United States,Computer) </c> </para></li><li><para><c> new Locale("en").getDisplayName(Locale.FRANCE) </c> -&gt; <c> anglais </c> </para></li><li><para><c> new Locale("en", "US").getDisplayName(Locale.FRANCE) </c> -&gt; <c> anglais (États-Unis) </c> </para></li><li><para><c> new Locale("en", "US", "POSIX").getDisplayName(Locale.FRANCE) </c> -&gt; <c> anglais (États-Unis,informatique) </c> . </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayName(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the full variant name in the default <c> Locale </c> for the variant code of this <c> Locale </c> . If there is no matching variant name, the variant code is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayVariant
				/// </java-name>
				[Dot42.DexImport("getDisplayVariant", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayVariant() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the full variant name in the specified <c> Locale </c> for the variant code of this <c> Locale </c> . If there is no matching variant name, the variant code is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayVariant
				/// </java-name>
				[Dot42.DexImport("getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayVariant(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the three letter ISO country code which corresponds to the country code for this <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISO3Country
				/// </java-name>
				[Dot42.DexImport("getISO3Country", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetISO3Country() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the three letter ISO language code which corresponds to the language code for this <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISO3Language
				/// </java-name>
				[Dot42.DexImport("getISO3Language", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetISO3Language() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an array of strings containing all the two-letter ISO country codes that can be used as the country code when constructing a <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISOCountries
				/// </java-name>
				[Dot42.DexImport("getISOCountries", "()[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] GetISOCountries() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns an array of strings containing all the two-letter ISO language codes that can be used as the language code when constructing a <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISOLanguages
				/// </java-name>
				[Dot42.DexImport("getISOLanguages", "()[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] GetISOLanguages() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the language code for this <c> Locale </c> or the empty string if no language was set. </para>        
				/// </summary>
				/// <java-name>
				/// getLanguage
				/// </java-name>
				[Dot42.DexImport("getLanguage", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLanguage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the variant code for this <c> Locale </c> or an empty <c> String </c> if no variant was set. </para>        
				/// </summary>
				/// <java-name>
				/// getVariant
				/// </java-name>
				[Dot42.DexImport("getVariant", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetVariant() /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Overrides the default locale. This does not affect system configuration, and attempts to override the system-provided default locale may themselves be overridden by actual changes to the system configuration. Code that calls this method is usually incorrect, and should be fixed by passing the appropriate locale to each locale-sensitive method that's called. </para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/util/Locale;)V", AccessFlags = 41)]
				public static void SetDefault(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the string representation of this <c> Locale </c> . It consists of the language code, country code and variant separated by underscores. If the language is missing the string begins with an underscore. If the country is missing there are 2 underscores between the language and the variant. The variant cannot stand alone without a language and/or country code: in this case this method would return the empty string.</para><para>Examples: "en", "en_US", "_US", "en__POSIX", "en_US_POSIX" </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Returns the system's installed locales. This array always includes <c>       Locale.US </c> , and usually several others. Most locale-sensitive classes offer their own <c> getAvailableLocales </c> method, which should be preferred over this general purpose method.</para><para><para>java.text.BreakIterator::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.Collator::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.DateFormat::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.DateFormatSymbols::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.DecimalFormatSymbols::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.text.NumberFormat::getAvailableLocales() </para><simplesectsep></simplesectsep><para>java.util.Calendar::getAvailableLocales() </para></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
				[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetAvailableLocales(); }
				}

				/// <summary>
				/// <para>Returns the country code for this locale, or <c> "" </c> if this locale doesn't correspond to a specific country. </para>        
				/// </summary>
				/// <java-name>
				/// getCountry
				/// </java-name>
				public string Country
				{
				[Dot42.DexImport("getCountry", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCountry(); }
				}

				/// <summary>
				/// <para>Returns the user's preferred locale. This may have been overridden for this process with setDefault.</para><para>Since the user's locale changes dynamically, avoid caching this value. Instead, use this method to look it up for each use. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Util.Locale Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/util/Locale;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/util/Locale;)V", AccessFlags = 41)]
						set{ SetDefault(value); }
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayCountry(Locale.getDefault()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayCountry
				/// </java-name>
				public string DisplayCountry
				{
				[Dot42.DexImport("getDisplayCountry", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetDisplayCountry(); }
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayLanguage(Locale.getDefault()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayLanguage
				/// </java-name>
				public string DisplayLanguage
				{
				[Dot42.DexImport("getDisplayLanguage", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetDisplayLanguage(); }
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayName(Locale.getDefault()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetDisplayName(); }
				}

				/// <summary>
				/// <para>Returns the full variant name in the default <c> Locale </c> for the variant code of this <c> Locale </c> . If there is no matching variant name, the variant code is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayVariant
				/// </java-name>
				public string DisplayVariant
				{
				[Dot42.DexImport("getDisplayVariant", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetDisplayVariant(); }
				}

				/// <summary>
				/// <para>Returns the three letter ISO country code which corresponds to the country code for this <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISO3Country
				/// </java-name>
				public string ISO3Country
				{
				[Dot42.DexImport("getISO3Country", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetISO3Country(); }
				}

				/// <summary>
				/// <para>Returns the three letter ISO language code which corresponds to the language code for this <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISO3Language
				/// </java-name>
				public string ISO3Language
				{
				[Dot42.DexImport("getISO3Language", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetISO3Language(); }
				}

				/// <summary>
				/// <para>Returns an array of strings containing all the two-letter ISO country codes that can be used as the country code when constructing a <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISOCountries
				/// </java-name>
				public static string[] ISOCountries
				{
				[Dot42.DexImport("getISOCountries", "()[Ljava/lang/String;", AccessFlags = 9)]
						get{ return GetISOCountries(); }
				}

				/// <summary>
				/// <para>Returns an array of strings containing all the two-letter ISO language codes that can be used as the language code when constructing a <c> Locale </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getISOLanguages
				/// </java-name>
				public static string[] ISOLanguages
				{
				[Dot42.DexImport("getISOLanguages", "()[Ljava/lang/String;", AccessFlags = 9)]
						get{ return GetISOLanguages(); }
				}

				/// <summary>
				/// <para>Returns the language code for this <c> Locale </c> or the empty string if no language was set. </para>        
				/// </summary>
				/// <java-name>
				/// getLanguage
				/// </java-name>
				public string Language
				{
				[Dot42.DexImport("getLanguage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLanguage(); }
				}

				/// <summary>
				/// <para>Returns the variant code for this <c> Locale </c> or an empty <c> String </c> if no variant was set. </para>        
				/// </summary>
				/// <java-name>
				/// getVariant
				/// </java-name>
				public string Variant
				{
				[Dot42.DexImport("getVariant", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetVariant(); }
				}

		}

		/// <summary>
		/// <para>AbstractSequentialList is an abstract implementation of the List interface. This implementation does not support adding. A subclass must implement the abstract method listIterator().</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/AbstractSequentialList
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractSequentialList", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;")]
		public abstract partial class AbstractSequentialList<E> : global::Java.Util.AbstractList<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this AbstractSequentialList. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractSequentialList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified object into this List at the specified location. The object is inserted before any previous element at the specified location. If the location is equal to the size of this List, the object is added at the end. </para><para>Concrete implementations that would like to support the add functionality must override this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int location, E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the objects in the specified Collection at the specified location in this List. The objects are added in the order they are returned from the collection's iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this List is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int location, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the element at the specified location in this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns an iterator on the elements of this list. The elements are iterated in the same order as they occur in the list.</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator on the elements of this list. </para>
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
				/// <para>Returns a list iterator on the elements of this list. The elements are iterated in the same order as they occur in the list. The iteration starts at the specified location.</para><para><para>ListIterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a ListIterator on the elements of this list. </para>
				/// </returns>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1025, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator(int location) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Remove(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Replaces the element at the specified location in this list with the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous element at the index. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public override E Set(int location, E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

		}

		/// <summary>
		/// <para><c> Arrays </c> contains static methods which operate on arrays.</para><para><para>1.2 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns a <c> List </c> of the objects in the specified array. The size of the <c> List </c> cannot be modified, i.e. adding and removing are unsupported, but the elements can be set. Setting an element modifies the underlying array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> List </c> of the elements of the specified array. </para>
				/// </returns>
				/// <java-name>
				/// asList
				/// </java-name>
				[Dot42.DexImport("asList", "([Ljava/lang/Object;)Ljava/util/List;", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;>([TT;)Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> AsList<T>(params T[] array) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Performs a binary search for <c> value </c> in the ascending sorted array <c> array </c> , using <c> comparator </c> to compare elements. Searching in an unsorted array has an undefined result. It's also undefined which element is found if there are multiple occurrences of the same element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the non-negative index of the element, or a negative index which is <c> -index - 1 </c> where the element would be inserted. </para>
				/// </returns>
				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;TT;Ljava/util/Comparator<-TT;>;)I")]
				public static int BinarySearch<T>(T[] array, T value, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Performs a binary search for <c> value </c> in the ascending sorted array <c> array </c> , in the range specified by fromIndex (inclusive) and toIndex (exclusive), using <c> comparator </c> to compare elements. Searching in an unsorted array has an undefined result. It's also undefined which element is found if there are multiple occurrences of the same element.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the non-negative index of the element, or a negative index which is <c> -index - 1 </c> where the element would be inserted. </para>
				/// </returns>
				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;IITT;Ljava/util/Comparator<-TT;>;)I")]
				public static int BinarySearch<T>(T[] array, int startIndex, int endIndex, T value, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns a hash code based on the "deep contents" of the given array. If the array contains other arrays as its elements, the hash code is based on their contents not their identities. So it is not acceptable to invoke this method on an array that contains itself as an element, either directly or indirectly. </para><para>For any two arrays <c> a </c> and <c> b </c> , if <c> Arrays.deepEquals(a, b) </c> returns <c> true </c> , it means that the return value of <c> Arrays.deepHashCode(a) </c> equals <c> Arrays.deepHashCode(b) </c> . </para><para>The computation of the value returned by this method is similar to that of the value returned by List#hashCode() invoked on a List containing a sequence of instances representing the elements of array in the same order. The difference is: If an element e of array is itself an array, its hash code is computed by calling the appropriate overloading of <c> Arrays.hashCode(e) </c> if e is an array of a primitive type, or by calling <c> Arrays.deepHashCode(e) </c> recursively if e is an array of a reference type. The value returned by this method is the same value as the method <c> Arrays.asList(array).hashCode() </c> . If the array is <c> null </c> , the return value is 0.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code for <c> array </c> . </para>
				/// </returns>
				/// <java-name>
				/// deepHashCode
				/// </java-name>
				[Dot42.DexImport("deepHashCode", "([Ljava/lang/Object;)I", AccessFlags = 9)]
				public static int DeepHashCode(object[] array) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns <c> true </c> if the two given arrays are deeply equal to one another. Unlike the method <c> equals(Object[] array1, Object[] array2) </c> , this method is appropriate for use for nested arrays of arbitrary depth. </para><para>Two array references are considered deeply equal if they are both <c> null </c> , or if they refer to arrays that have the same length and the elements at each index in the two arrays are equal. </para><para>Two <c> null </c> elements <c> element1 </c> and <c> element2 </c> are possibly deeply equal if any of the following conditions satisfied: </para><para><c> element1 </c> and <c> element2 </c> are both arrays of object reference types, and <c> Arrays.deepEquals(element1, element2) </c> would return <c> true </c> . </para><para><c> element1 </c> and <c> element2 </c> are arrays of the same primitive type, and the appropriate overloading of <c> Arrays.equals(element1, element2) </c> would return <c> true </c> . </para><para><c> element1 == element2 </c> </para><para><c> element1.equals(element2) </c> would return <c> true </c> . </para><para>Note that this definition permits <c> null </c> elements at any depth. </para><para>If either of the given arrays contain themselves as elements, the behavior of this method is uncertain.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if both arrays are <c> null </c> or if the arrays have the same length and the elements at each index in the two arrays are equal according to <c> equals() </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// deepEquals
				/// </java-name>
				[Dot42.DexImport("deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool DeepEquals(object[] array1, object[] array2) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Sorts the specified range in the array using the specified <c> Comparator </c> . All elements must be comparable to each other without a <c> ClassCastException </c> being thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;IILjava/util/Comparator<-TT;>;)V")]
				public static void Sort<T>(T[] array, int start, int end, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sorts the specified array using the specified <c> Comparator </c> . All elements must be comparable to each other without a <c> ClassCastException </c> being thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>([TT;Ljava/util/Comparator<-TT;>;)V")]
				public static void Sort<T>(T[] array, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Creates a <b>"deep"</b> <c> String </c> representation of the <c> Object[] </c> passed, such that if the array contains other arrays, the <c> String </c> representation of those arrays is generated as well. </para><para>If any of the elements are primitive arrays, the generation is delegated to the other <c> toString </c> methods in this class. If any element contains a reference to the original array, then it will be represented as <c> "[...]" </c> . If an element is an <c> Object[] </c> , then its representation is generated by a recursive call to this method. All other elements are converted via the String#valueOf(Object) method.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> String </c> representation of <c> array </c> . </para>
				/// </returns>
				/// <java-name>
				/// deepToString
				/// </java-name>
				[Dot42.DexImport("deepToString", "([Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string DeepToString(object[] array) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Copies <c> newLength </c> elements from <c> original </c> into a new array. If <c> newLength </c> is greater than <c> original.length </c> , the result is padded with the value <c> null </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new array </para>
				/// </returns>
				/// <java-name>
				/// copyOf
				/// </java-name>
				[Dot42.DexImport("copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;U:Ljava/lang/Object;>([TU;ILjava/lang/Class<+[TT;>;)[TT;")]
				public static T[] CopyOf<T, U>(U[] original, int newLength, global::System.Type newType) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Copies elements from <c> original </c> into a new array, from indexes start (inclusive) to end (exclusive). The original order of elements is preserved. If <c> end </c> is greater than <c> original.length </c> , the result is padded with the value <c> null </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new array </para>
				/// </returns>
				/// <java-name>
				/// copyOfRange
				/// </java-name>
				[Dot42.DexImport("copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;U:Ljava/lang/Object;>([TU;IILjava/lang/Class<+[TT;>;)[TT;")]
				public static T[] CopyOfRange<T, U>(U[] original, int start, int end, global::System.Type newType) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>An <c> IllegalFormatFlagsException </c> will be thrown if the combination of the format flags is illegal.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/IllegalFormatFlagsException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatFlagsException", AccessFlags = 33)]
		public partial class IllegalFormatFlagsException : global::Java.Util.IllegalFormatException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalFormatFlagsException </c> with the specified flags.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalFormatFlagsException(string flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the flags that are illegal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the flags that are illegal. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFlags() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Returns the flags that are illegal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the flags that are illegal. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public string Flags
				{
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFlags(); }
				}

		}

		/// <summary>
		/// <para>An <c> IllegalFormatPrecisionException </c> will be thrown if the precision is a negative other than -1 or in other cases where precision is not supported.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/IllegalFormatPrecisionException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatPrecisionException", AccessFlags = 33)]
		public partial class IllegalFormatPrecisionException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalFormatPrecisionException </c> with specified precision.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IllegalFormatPrecisionException(int p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the precision associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the precision. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
				public virtual int GetPrecision() /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <summary>
				/// <para>Returns the precision associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the precision. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				public int Precision
				{
				[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
						get{ return GetPrecision(); }
				}

		}

		/// <summary>
		/// <para>An <c> UnknownFormatFlagsException </c> will be thrown if there is an unknown flag.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/UnknownFormatFlagsException
		/// </java-name>
		[Dot42.DexImport("java/util/UnknownFormatFlagsException", AccessFlags = 33)]
		public partial class UnknownFormatFlagsException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> UnknownFormatFlagsException </c> with the specified flags.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownFormatFlagsException(string f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the flags associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the flags associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFlags() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Returns the flags associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the flags associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public string Flags
				{
				[Dot42.DexImport("getFlags", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFlags(); }
				}

		}

		/// <summary>
		/// <para><c> Stack </c> is a Last-In/First-Out(LIFO) data structure which represents a stack of objects. It enables users to pop to and push from the stack, including null objects. There is no limit to the size of the stack. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Stack
		/// </java-name>
		[Dot42.DexImport("java/util/Stack", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/Vector<TE;>;")]
		public partial class Stack<E> : global::Java.Util.Vector<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a stack with the default size of <c> Vector </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Stack() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the stack is empty or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the stack is empty, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// empty
				/// </java-name>
				[Dot42.DexImport("empty", "()Z", AccessFlags = 1)]
				public virtual bool Empty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the element at the top of the stack without removing it.</para><para><para>pop </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the top of the stack. </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the element at the top of the stack and removes it.</para><para><para>peek </para><simplesectsep></simplesectsep><para>push </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the top of the stack. </para>
				/// </returns>
				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Pushes the specified object onto the top of the stack.</para><para><para>peek </para><simplesectsep></simplesectsep><para>pop </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object argument. </para>
				/// </returns>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Push(E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the index of the first occurrence of the object, starting from the top of the stack.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first occurrence of the object, assuming that the topmost object on the stack has a distance of one. </para>
				/// </returns>
				/// <java-name>
				/// search
				/// </java-name>
				[Dot42.DexImport("search", "(Ljava/lang/Object;)I", AccessFlags = 33)]
				public virtual int Search(object o) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>An <c> IllegalFormatWidthException </c> will be thrown if the width is a negative value other than -1 or in other cases where a width is not supported.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/IllegalFormatWidthException
		/// </java-name>
		[Dot42.DexImport("java/util/IllegalFormatWidthException", AccessFlags = 33)]
		public partial class IllegalFormatWidthException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalFormatWidthException </c> with specified width.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IllegalFormatWidthException(int w) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the width associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the width. </para>
				/// </returns>
				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
				public virtual int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <summary>
				/// <para>Returns the width associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the width. </para>
				/// </returns>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return GetWidth(); }
				}

		}

		/// <summary>
		/// <para><b>Note: Do not use this class since it is obsolete. Please use the Map interface for new implementations.</b> </para><para>Dictionary is an abstract class which is the superclass of all classes that associate keys with values, such as <c> Hashtable </c> .</para><para><para>Hashtable </para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Dictionary
		/// </java-name>
		[Dot42.DexImport("java/util/Dictionary", AccessFlags = 1057, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Dictionary<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Dictionary() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an enumeration on the elements of this dictionary.</para><para><para>keys </para><simplesectsep></simplesectsep><para>size </para><simplesectsep></simplesectsep><para>Enumeration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enumeration of the values of this dictionary. </para>
				/// </returns>
				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<TV;>;")]
				public abstract global::Java.Util.IEnumeration<V> Elements() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the value which is associated with <c> key </c> .</para><para><para>put </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value associated with <c> key </c> , or <c> null </c> if the specified key does not exist. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				public abstract V Get(object key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if this dictionary has no key/value pairs.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this dictionary has no key/value pairs, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
				public abstract bool IsEmpty() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an enumeration on the keys of this dictionary.</para><para><para>elements </para><simplesectsep></simplesectsep><para>size </para><simplesectsep></simplesectsep><para>Enumeration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enumeration of the keys of this dictionary. </para>
				/// </returns>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<TK;>;")]
				public abstract global::Java.Util.IEnumeration<K> Keys() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Associate <c> key </c> with <c> value </c> in this dictionary. If <c>       key </c> exists in the dictionary before this call, the old value in the dictionary is replaced by <c> value </c> .</para><para><para>elements </para><simplesectsep></simplesectsep><para>get </para><simplesectsep></simplesectsep><para>keys </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the old value previously associated with <c> key </c> or <c>               null </c> if <c> key </c> is new to the dictionary. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				public abstract V Put(K key, V value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the key/value pair with the specified <c> key </c> from this dictionary.</para><para><para>get </para><simplesectsep></simplesectsep><para>put </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the associated value before the deletion or <c> null </c> if <c> key </c> was not known to this dictionary. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				public abstract V Remove(object key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of key/value pairs in this dictionary.</para><para><para>elements </para><simplesectsep></simplesectsep><para>keys </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of key/value pairs in this dictionary. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				public abstract int Size() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><c> Observer </c> is the interface to be implemented by objects that receive notification of updates on an <c> Observable </c> object.</para><para><para>Observable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Observer
		/// </java-name>
		[Dot42.DexImport("java/util/Observer", AccessFlags = 1537)]
		public partial interface IObserver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This method is called if the specified <c> Observable </c> object's <c> notifyObservers </c> method is called (because the <c> Observable </c> object has been updated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/util/Observable;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Update(global::Java.Util.Observable observable, object data) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>SortedSet is a Set which iterates over its elements in a sorted order. The order is determined either by the elements natural ordering, or by a Comparator which is passed into a concrete implementation at construction time. All elements in this set must be mutually comparable. The ordering in this set must be consistent with <c> equals </c> of its elements.</para><para><para>Comparator </para><simplesectsep></simplesectsep><para>Comparable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/SortedSet
		/// </java-name>
		[Dot42.DexImport("java/util/SortedSet", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Set<TE;>;")]
		public partial interface ISortedSet<E> : global::Java.Util.ISet<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the comparator used to compare elements in this <c> SortedSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a comparator or null if the natural ordering is used. </para>
				/// </returns>
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1025, Signature = "()Ljava/util/Comparator<-TE;>;")]
				global::Java.Util.IComparator<E> Comparator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the first element in this <c> SortedSet </c> . The first element is the lowest element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first element. </para>
				/// </returns>
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E First() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> SortedSet </c> of the specified portion of this <c> SortedSet </c> which contains elements less than the end element. The returned <c> SortedSet </c> is backed by this <c> SortedSet </c> so changes to one set are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subset where the elements are less than <c> end </c> . </para>
				/// </returns>
				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> HeadSet(E end) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the last element in this <c> SortedSet </c> . The last element is the highest element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last element. </para>
				/// </returns>
				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Last() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> SortedSet </c> of the specified portion of this <c> SortedSet </c> which contains elements greater or equal to the start element but less than the end element. The returned <c> SortedSet </c> is backed by this SortedMap so changes to one set are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subset where the elements are greater or equal to <c> start </c> and less than <c> end </c> . </para>
				/// </returns>
				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> SubSet(E start, E end) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> SortedSet </c> of the specified portion of this <c> SortedSet </c> which contains elements greater or equal to the start element. The returned <c> SortedSet </c> is backed by this <c> SortedSet </c> so changes to one set are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subset where the elements are greater or equal to <c> start </c> . </para>
				/// </returns>
				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1025, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				global::Java.Util.ISortedSet<E> TailSet(E start) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An <c> IllegalFormatException </c> is thrown when a format string that contains either an illegal syntax or format specifier is transferred as a parameter. Only subclasses inheriting explicitly from this exception are allowed to be instantiated.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
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

		/// <summary>
		/// <para>A collection designed for holding elements prior to processing. Besides basic Collection operations, queues provide additional insertion, extraction, and inspection operations. Each of these methods exists in two forms: one throws an exception if the operation fails, the other returns a special value (either <code>null</code> or <code>false</code>, depending on the operation). The latter form of the insert operation is designed specifically for use with capacity-restricted <code>Queue</code> implementations; in most implementations, insert operations cannot fail.</para><para><table><row><entry><para></para></entry><entry><para><b>Throws exception</b> </para></entry><entry><para><b>Returns special value</b>  </para></entry></row><row><entry><para><b>Insert</b> </para></entry><entry><para>add(e) </para></entry><entry><para>offer(e)  </para></entry></row><row><entry><para><b>Remove</b> </para></entry><entry><para>remove() </para></entry><entry><para>poll()  </para></entry></row><row><entry><para><b>Examine</b> </para></entry><entry><para>element() </para></entry><entry><para>peek()  </para></entry></row></table></para><para>Queues typically, but do not necessarily, order elements in a FIFO (first-in-first-out) manner. Among the exceptions are priority queues, which order elements according to a supplied comparator, or the elements' natural ordering, and LIFO queues (or stacks) which order the elements LIFO (last-in-first-out). Whatever the ordering used, the <b>head</b> of the queue is that element which would be removed by a call to remove() or poll(). In a FIFO queue, all new elements are inserted at the <b> tail</b> of the queue. Other kinds of queues may use different placement rules. Every <code>Queue</code> implementation must specify its ordering properties.</para><para>The offer method inserts an element if possible, otherwise returning <code>false</code>. This differs from the Collection.add method, which can fail to add an element only by throwing an unchecked exception. The <code>offer</code> method is designed for use when failure is a normal, rather than exceptional occurrence, for example, in fixed-capacity (or "bounded") queues.</para><para>The remove() and poll() methods remove and return the head of the queue. Exactly which element is removed from the queue is a function of the queue's ordering policy, which differs from implementation to implementation. The <code>remove()</code> and <code>poll()</code> methods differ only in their behavior when the queue is empty: the <code>remove()</code> method throws an exception, while the <code>poll()</code> method returns <code>null</code>.</para><para>The element() and peek() methods return, but do not remove, the head of the queue.</para><para>The <code>Queue</code> interface does not define the <b>blocking queue methods</b>, which are common in concurrent programming. These methods, which wait for elements to appear or for space to become available, are defined in the java.util.concurrent.BlockingQueue interface, which extends this interface.</para><para><code>Queue</code> implementations generally do not allow insertion of <code>null</code> elements, although some implementations, such as LinkedList, do not prohibit insertion of <code>null</code>. Even in the implementations that permit it, <code>null</code> should not be inserted into a <code>Queue</code>, as <code>null</code> is also used as a special return value by the <code>poll</code> method to indicate that the queue contains no elements.</para><para><code>Queue</code> implementations generally do not define element-based versions of methods <code>equals</code> and <code>hashCode</code> but instead inherit the identity based versions from class <code>Object</code>, because element-based equality is not always well-defined for queues with the same elements but different ordering properties.</para><para><para>java.util.Collection </para><simplesectsep></simplesectsep><para>LinkedList </para><simplesectsep></simplesectsep><para>PriorityQueue </para><simplesectsep></simplesectsep><para>java.util.concurrent.LinkedBlockingQueue </para><simplesectsep></simplesectsep><para>java.util.concurrent.BlockingQueue </para><simplesectsep></simplesectsep><para>java.util.concurrent.ArrayBlockingQueue </para><simplesectsep></simplesectsep><para>java.util.concurrent.LinkedBlockingQueue </para><simplesectsep></simplesectsep><para>java.util.concurrent.PriorityBlockingQueue </para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Queue
		/// </java-name>
		[Dot42.DexImport("java/util/Queue", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public partial interface IQueue<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Inserts the specified element into this queue if it is possible to do so immediately without violating capacity restrictions. When using a capacity-restricted queue, this method is generally preferable to add, which can fail to insert an element only by throwing an exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the element was added to this queue, else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Offer(E e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the head of this queue, or returns <code>null</code> if this queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this queue, or <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Poll() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves and removes the head of this queue. This method differs from poll only in that it throws an exception if this queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Remove() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves, but does not remove, the head of this queue, or returns <code>null</code> if this queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this queue, or <code>null</code> if this queue is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Peek() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves, but does not remove, the head of this queue. This method differs from peek only in that it throws an exception if this queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TE;")]
				E Element() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> Set </c> is a data structure which does not allow duplicate elements.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Set
		/// </java-name>
		[Dot42.DexImport("java/util/Set", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public partial interface ISet<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Adds the specified object to this set. The set is not modified if it already contains the object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this set is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds the objects in the specified collection which do not exist yet in this set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this set is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all elements from this set, leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Searches this set for the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is an element of this set, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Searches this set for all objects in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if all objects in the specified collection are elements of this set, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the specified object to this set, and returns true if they represent the <b>same</b> object using a class specific comparison. Equality for a set means that both sets have the same size and the same elements.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean <c> true </c> if the object is the same as this object, and <c> false </c> if it is different from this object. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the hash code for this set. Two set which are equal must return the same value.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code of this set.</para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if this set has no elements.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this set has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
				bool IsEmpty() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an iterator on the elements of this set. The elements are unordered.</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator on the elements of this set. </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the specified object from this set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this set was modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all objects in the specified collection from this set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this set was modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all objects from this set that are not contained in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this set was modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of elements in this set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this set. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array containing all elements contained in this set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this set. </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] ToArray() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array containing all elements contained in this set. If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this set, the array element following the collection elements is set to null.</para><para><para>Collection::toArray(Object[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this set. </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				T[] ToArray<T>(T[] array) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>RandomAccess is implemented by <c> List </c> implementations that support fast (usually constant time) random access. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/RandomAccess
		/// </java-name>
		[Dot42.DexImport("java/util/RandomAccess", AccessFlags = 1537)]
		public partial interface IRandomAccess
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Vector is an implementation of List, backed by an array and synchronized. All optional operations including adding, removing, and replacing elements are supported.</para><para>All elements are permitted, including null.</para><para>This class is equivalent to ArrayList with synchronized operations. This has a performance cost, and the synchronization is not necessarily meaningful to your application: synchronizing each call to <c> get </c> , for example, is not equivalent to synchronizing on the list and iterating over it (which is probably what you intended). If you do need very highly concurrent access, you should also consider java.util.concurrent.CopyOnWriteArrayList.</para><para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Vector
		/// </java-name>
		[Dot42.DexImport("java/util/Vector", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;Ljava/util/List<TE;>;Ljava/uti" +
    "l/RandomAccess;Ljava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class Vector<E> : global::Java.Util.AbstractList<E>, global::Java.Util.IList<E>, global::Java.Util.IRandomAccess, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The number of elements or the size of the vector. </para>        
				/// </summary>
				/// <java-name>
				/// elementCount
				/// </java-name>
				[Dot42.DexImport("elementCount", "I", AccessFlags = 4)]
				protected internal int ElementCount;
				/// <summary>
				/// <para>The elements of the vector. </para>        
				/// </summary>
				/// <java-name>
				/// elementData
				/// </java-name>
				[Dot42.DexImport("elementData", "[Ljava/lang/Object;", AccessFlags = 4)]
				protected internal object[] ElementData;
				/// <summary>
				/// <para>How many elements should be added to the vector when it is detected that it needs to grow to accommodate extra entries. If this value is zero or negative the size will be doubled if an increase is needed. </para>        
				/// </summary>
				/// <java-name>
				/// capacityIncrement
				/// </java-name>
				[Dot42.DexImport("capacityIncrement", "I", AccessFlags = 4)]
				protected internal int CapacityIncrement;
				/// <summary>
				/// <para>Constructs a new vector using the default capacity. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Vector() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new vector using the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Vector(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new vector using the specified capacity and capacity increment.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Vector(int capacity, int capacityIncrement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new vector using the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public Vector(global::Java.Util.ICollection<E> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object into this vector at the specified location. The object is inserted before any element with the same or a higher index increasing their index by 1. If the location is equal to the size of this vector, the object is added at the end.</para><para><para>addElement </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int location, E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object at the end of this vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 33, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the objects in the specified collection at the specified location in this vector. The objects are inserted in the order in which they are returned from the Collection iterator. The elements with an index equal or higher than <c> location </c> have their index increased by the size of the added collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this vector is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 33, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int location, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the objects in the specified collection to the end of this vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this vector is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the specified object at the end of this vector.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addElement
				/// </java-name>
				[Dot42.DexImport("addElement", "(Ljava/lang/Object;)V", AccessFlags = 33, Signature = "(TE;)V")]
				public virtual void AddElement(E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of elements this vector can hold without growing.</para><para><para>ensureCapacity </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the capacity of this vector. </para>
				/// </returns>
				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 33)]
				public virtual int Capacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Removes all elements from this vector, leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new vector with the same elements, size, capacity and capacity increment as this vector.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this vector. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 33)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Searches this vector for the specified object.</para><para><para>indexOf(Object) </para><simplesectsep></simplesectsep><para>indexOf(Object, int) </para><simplesectsep></simplesectsep><para>java.lang.Object::equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is an element of this vector, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Searches this vector for all objects in the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if all objects in the specified collection are elements of this vector, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to copy elements contained by this <c> Vector </c> into the corresponding elements of the supplied <c> Object </c> array.</para><para><para>clone </para></para>        
				/// </summary>
				/// <java-name>
				/// copyInto
				/// </java-name>
				[Dot42.DexImport("copyInto", "([Ljava/lang/Object;)V", AccessFlags = 33)]
				public virtual void CopyInto(object[] elements) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the element at the specified location in this vector.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified location. </para>
				/// </returns>
				/// <java-name>
				/// elementAt
				/// </java-name>
				[Dot42.DexImport("elementAt", "(I)Ljava/lang/Object;", AccessFlags = 33, Signature = "(I)TE;")]
				public virtual E ElementAt(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns an enumeration on the elements of this vector. The results of the enumeration may be affected if the contents of this vector is modified.</para><para><para>elementAt </para><simplesectsep></simplesectsep><para>Enumeration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enumeration of the elements of this vector. </para>
				/// </returns>
				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<TE;>;")]
				public virtual global::Java.Util.IEnumeration<E> Elements() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<E>);
				}

				/// <summary>
				/// <para>Ensures that this vector can hold the specified number of elements without growing.</para><para><para>capacity </para></para>        
				/// </summary>
				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 33)]
				public virtual void EnsureCapacity(int minimumCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the specified object to this vector and returns if they are equal. The object must be a List which contains the same objects in the same order.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this vector, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the first element in this vector.</para><para><para>elementAt </para><simplesectsep></simplesectsep><para>lastElement </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the first position. </para>
				/// </returns>
				/// <java-name>
				/// firstElement
				/// </java-name>
				[Dot42.DexImport("firstElement", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E FirstElement() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the element at the specified location in this vector.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified location. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. Objects which are equal return the same value for this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this vector for the index of the specified object. The search for the object starts at the beginning and moves towards the end of this vector.</para><para><para>contains </para><simplesectsep></simplesectsep><para>lastIndexOf(Object) </para><simplesectsep></simplesectsep><para>lastIndexOf(Object, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this vector of the specified element, -1 if the element isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this vector for the index of the specified object. The search for the object starts at the specified location and moves towards the end of this vector.</para><para><para>contains </para><simplesectsep></simplesectsep><para>lastIndexOf(Object) </para><simplesectsep></simplesectsep><para>lastIndexOf(Object, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this vector of the specified element, -1 if the element isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;I)I", AccessFlags = 33)]
				public virtual int IndexOf(object @object, int location) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Inserts the specified object into this vector at the specified location. This object is inserted before any previous element at the specified location. All elements with an index equal or greater than <c> location </c> have their index increased by 1. If the location is equal to the size of this vector, the object is added at the end.</para><para><para>addElement </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// insertElementAt
				/// </java-name>
				[Dot42.DexImport("insertElementAt", "(Ljava/lang/Object;I)V", AccessFlags = 33, Signature = "(TE;I)V")]
				public virtual void InsertElementAt(E @object, int location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns if this vector has no elements, a size of zero.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this vector has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 33)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the last element in this vector.</para><para><para>elementAt </para><simplesectsep></simplesectsep><para>firstElement </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the last position. </para>
				/// </returns>
				/// <java-name>
				/// lastElement
				/// </java-name>
				[Dot42.DexImport("lastElement", "()Ljava/lang/Object;", AccessFlags = 33, Signature = "()TE;")]
				public virtual E LastElement() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Searches in this vector for the index of the specified object. The search for the object starts at the end and moves towards the start of this vector.</para><para><para>contains </para><simplesectsep></simplesectsep><para>indexOf(Object) </para><simplesectsep></simplesectsep><para>indexOf(Object, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this vector of the specified element, -1 if the element isn't found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 33)]
				public override int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this vector for the index of the specified object. The search for the object starts at the specified location and moves towards the start of this vector.</para><para><para>contains </para><simplesectsep></simplesectsep><para>indexOf(Object) </para><simplesectsep></simplesectsep><para>indexOf(Object, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this vector of the specified element, -1 if the element isn't found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;I)I", AccessFlags = 33)]
				public virtual int LastIndexOf(object @object, int location) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this vector. All elements with an index bigger than <c> location </c> have their index decreased by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 33, Signature = "(I)TE;")]
				public override E Remove(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this vector. All elements with an index bigger than <c> location </c> have their index decreased by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object location) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all occurrences in this vector of each object in the specified Collection.</para><para><para>remove(Object) </para><simplesectsep></simplesectsep><para>contains(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this vector is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all elements from this vector, leaving the size zero and the capacity unchanged.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// removeAllElements
				/// </java-name>
				[Dot42.DexImport("removeAllElements", "()V", AccessFlags = 33)]
				public virtual void RemoveAllElements() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the first occurrence, starting at the beginning and moving towards the end, of the specified object from this vector. All elements with an index bigger than the element that gets removed have their index decreased by 1.</para><para><para>removeAllElements </para><simplesectsep></simplesectsep><para>removeElementAt </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object was found, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeElement
				/// </java-name>
				[Dot42.DexImport("removeElement", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool RemoveElement(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes the element found at index position <c> location </c> from this <c> Vector </c> . All elements with an index bigger than <c> location </c> have their index decreased by 1.</para><para><para>removeElement </para><simplesectsep></simplesectsep><para>removeAllElements </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// removeElementAt
				/// </java-name>
				[Dot42.DexImport("removeElementAt", "(I)V", AccessFlags = 33)]
				public virtual void RemoveElementAt(int location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the objects in the specified range from the start to the, but not including, end index. All elements with an index bigger than or equal to <c> end </c> have their index decreased by <c> end - start </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeRange
				/// </java-name>
				[Dot42.DexImport("removeRange", "(II)V", AccessFlags = 4)]
				protected internal override void RemoveRange(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all objects from this vector that are not contained in the specified collection.</para><para><para>remove(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this vector is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 33, Signature = "(Ljava/util/Collection<*>;)Z")]
				public override bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Replaces the element at the specified location in this vector with the specified object.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous element at the location. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(ITE;)TE;")]
				public override E Set(int location, E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Replaces the element at the specified location in this vector with the specified object.</para><para><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// setElementAt
				/// </java-name>
				[Dot42.DexImport("setElementAt", "(Ljava/lang/Object;I)V", AccessFlags = 33, Signature = "(TE;I)V")]
				public virtual void SetElementAt(E @object, int location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the size of this vector to the specified size. If there are more than length elements in this vector, the elements at end are lost. If there are less than length elements in the vector, the additional elements contain null.</para><para><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// setSize
				/// </java-name>
				[Dot42.DexImport("setSize", "(I)V", AccessFlags = 33)]
				public virtual void SetSize(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of elements in this vector.</para><para><para>elementCount </para><simplesectsep></simplesectsep><para>lastElement </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this vector. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 33)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a List of the specified portion of this vector from the start index to one less than the end index. The returned List is backed by this vector so changes to one are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a List of a portion of this vector. </para>
				/// </returns>
				/// <java-name>
				/// subList
				/// </java-name>
				[Dot42.DexImport("subList", "(II)Ljava/util/List;", AccessFlags = 33, Signature = "(II)Ljava/util/List<TE;>;")]
				public override global::Java.Util.IList<E> SubList(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <summary>
				/// <para>Returns a new array containing all elements contained in this vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this vector. </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 33)]
				public override object[] ToArray() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				/// <para>Returns an array containing all elements contained in this vector. If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this vector, the array element following the collection elements is set to null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this vector. </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] contents) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				/// <para>Returns the string representation of this vector.</para><para><para>elements </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this vector. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 33)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the capacity of this vector to be the same as the size.</para><para><para>capacity </para><simplesectsep></simplesectsep><para>ensureCapacity </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
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
				public override global::Java.Util.IListIterator<E> ListIterator(int location) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

		}

		/// <summary>
		/// <para>A <c> MissingResourceException </c> is thrown by ResourceBundle when a resource bundle cannot be found or a resource is missing from a resource bundle.</para><para><para>ResourceBundle </para><simplesectsep></simplesectsep><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/MissingResourceException
		/// </java-name>
		[Dot42.DexImport("java/util/MissingResourceException", AccessFlags = 33)]
		public partial class MissingResourceException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> MissingResourceException </c> with the stack trace, message, the class name of the resource bundle and the name of the missing resource filled in.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingResourceException(string detailMessage, string className, string resourceName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the class name of the resource bundle from which a resource could not be found, or in the case of a missing resource, the name of the missing resource bundle.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the class name of the resource bundle. </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetClassName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of the missing resource, or an empty string if the resource bundle is missing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the missing resource. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MissingResourceException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the class name of the resource bundle from which a resource could not be found, or in the case of a missing resource, the name of the missing resource bundle.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the class name of the resource bundle. </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				public string ClassName
				{
				[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetClassName(); }
				}

				/// <summary>
				/// <para>Returns the name of the missing resource, or an empty string if the resource bundle is missing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the missing resource. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				}

		}

		/// <summary>
		/// <para><c> ListResourceBundle </c> is the abstract superclass of classes which provide resources by implementing the <c> getContents() </c> method to return the list of resources.</para><para><para>ResourceBundle </para><para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/ListResourceBundle
		/// </java-name>
		[Dot42.DexImport("java/util/ListResourceBundle", AccessFlags = 1057)]
		public abstract partial class ListResourceBundle : global::Java.Util.ResourceBundle
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ListResourceBundle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an <c> Object </c> array containing the resources of this <c> ListResourceBundle </c> . Each element in the array is an array of two elements, the first is the resource key string and the second is the resource.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Object </c> array containing the resources. </para>
				/// </returns>
				/// <java-name>
				/// getContents
				/// </java-name>
				[Dot42.DexImport("getContents", "()[[Ljava/lang/Object;", AccessFlags = 1028)]
				protected internal abstract object[][] GetContents() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of the resources contained in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the resource names. </para>
				/// </returns>
				/// <java-name>
				/// getKeys
				/// </java-name>
				[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public override global::Java.Util.IEnumeration<string> GetKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<string>);
				}

				/// <summary>
				/// <para>Returns the named resource from this <c> ResourceBundle </c> , or null if the resource is not found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource object. </para>
				/// </returns>
				/// <java-name>
				/// handleGetObject
				/// </java-name>
				[Dot42.DexImport("handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				protected internal override object HandleGetObject(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns a set of the keys in this ResourceBundle but not in its parents.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys in this ResourceBundle but not in its parents. </para>
				/// </returns>
				/// <java-name>
				/// handleKeySet
				/// </java-name>
				[Dot42.DexImport("handleKeySet", "()Ljava/util/Set;", AccessFlags = 4, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				protected internal override global::Java.Util.ISet<string> HandleKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				/// <para>Returns an <c> Object </c> array containing the resources of this <c> ListResourceBundle </c> . Each element in the array is an array of two elements, the first is the resource key string and the second is the resource.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Object </c> array containing the resources. </para>
				/// </returns>
				/// <java-name>
				/// getContents
				/// </java-name>
				protected internal object[][] Contents
				{
				[Dot42.DexImport("getContents", "()[[Ljava/lang/Object;", AccessFlags = 1028)]
						get{ return GetContents(); }
				}

				/// <summary>
				/// <para>Returns the names of the resources contained in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the resource names. </para>
				/// </returns>
				/// <java-name>
				/// getKeys
				/// </java-name>
				public global::Java.Util.IEnumeration<string> Keys
				{
				[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return GetKeys(); }
				}

		}

		/// <summary>
		/// <para><c> TimeZone </c> represents a time zone, primarily used for configuring a Calendar or java.text.SimpleDateFormat instance.</para><para>Most applications will use getDefault which returns a <c> TimeZone </c> based on the time zone where the program is running.</para><para>You can also get a specific <c> TimeZone </c> by Olson ID.</para><para>It is highly unlikely you'll ever want to use anything but the factory methods yourself. Let classes like Calendar and java.text.SimpleDateFormat do the date computations for you.</para><para>If you do need to do date computations manually, there are two common cases to take into account: <ul><li><para>Somewhere like California, where daylight time is used. The useDaylightTime method will always return true, and inDaylightTime must be used to determine whether or not daylight time applies to a given <c> Date </c> . The getRawOffset method will return a raw offset of (in this case) -8 hours from UTC, which isn't usually very useful. More usefully, the getOffset methods return the actual offset from UTC <b>for a given point in time</b>; this is the raw offset plus (if the point in time is in daylight time) the applicable DST savings (usually, but not necessarily, 1 hour). </para></li><li><para>Somewhere like Japan, where daylight time is not used. The useDaylightTime and inDaylightTime methods both always return false, and the raw and actual offsets will always be the same. </para></li></ul></para><para>Note the type returned by the factory methods getDefault and getTimeZone is implementation dependent. This may introduce serialization incompatibility issues between different implementations, or different versions of Android.</para><para><para>Calendar </para><simplesectsep></simplesectsep><para>GregorianCalendar </para><simplesectsep></simplesectsep><para>SimpleDateFormat </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/TimeZone
		/// </java-name>
		[Dot42.DexImport("java/util/TimeZone", AccessFlags = 1057)]
		public abstract partial class TimeZone : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The short display name style, such as <c> PDT </c> . Requests for this style may yield GMT offsets like <c> GMT-08:00 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// SHORT
				/// </java-name>
				[Dot42.DexImport("SHORT", "I", AccessFlags = 25)]
				public const int SHORT = 0;
				/// <summary>
				/// <para>The long display name style, such as <c> Pacific Daylight Time </c> . Requests for this style may yield GMT offsets like <c> GMT-08:00 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// LONG
				/// </java-name>
				[Dot42.DexImport("LONG", "I", AccessFlags = 25)]
				public const int LONG = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeZone() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new time zone with the same ID, raw offset, and daylight savings time rules as this time zone. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the system's installed time zone IDs. Any of these IDs can be passed to getTimeZone to lookup the corresponding time zone instance. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableIDs
				/// </java-name>
				[Dot42.DexImport("getAvailableIDs", "()[Ljava/lang/String;", AccessFlags = 41)]
				public static string[] GetAvailableIDs() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the IDs of the time zones whose offset from UTC is <c>       offsetMillis </c> . Any of these IDs can be passed to getTimeZone to lookup the corresponding time zone instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a possibly-empty array. </para>
				/// </returns>
				/// <java-name>
				/// getAvailableIDs
				/// </java-name>
				[Dot42.DexImport("getAvailableIDs", "(I)[Ljava/lang/String;", AccessFlags = 41)]
				public static string[] GetAvailableIDs(int offsetMillis) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the user's preferred time zone. This may have been overridden for this process with setDefault.</para><para>Since the user's time zone changes dynamically, avoid caching this value. Instead, use this method to look it up for each use. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/util/TimeZone;", AccessFlags = 41)]
				public static global::Java.Util.TimeZone GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayName(false, TimeZone.LONG, Locale.getDefault()) </c> . . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayName(false, TimeZone.LONG, locale) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayName(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayName(daylightTime, style, Locale.getDefault()) </c> . . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(ZI)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDisplayName(bool daylightTime, int style) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the short or long name of this time zone with either standard or daylight time, as written in <c> locale </c> . If the name is not available, the result is in the format <c> GMT[+-]hh:mm </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayName(bool daylightTime, int style, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the ID of this <c> TimeZone </c> , such as <c> America/Los_Angeles </c> , <c> GMT-08:00 </c> or <c> UTC </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getID
				/// </java-name>
				[Dot42.DexImport("getID", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetID() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the latest daylight savings in milliseconds for this time zone, relative to this time zone's regular UTC offset (as returned by getRawOffset).</para><para>This class returns <c> 3600000 </c> (1 hour) for time zones that use daylight savings time and <c> 0 </c> for timezones that do not, leaving it to subclasses to override this method for other daylight savings offsets. (There are time zones, such as <c> Australia/Lord_Howe </c> , that use other values.)</para><para>Note that this method doesn't tell you whether or not to <b>apply</b> the offset: you need to call <c> inDaylightTime </c> for the specific time you're interested in. If this method returns a non-zero offset, that only tells you that this <c> TimeZone </c> sometimes observes daylight savings.</para><para>Note also that this method doesn't necessarily return the value you need to apply to the time you're working with. This value can and does change over time for a given time zone.</para><para>It's highly unlikely that you should ever call this method. You probably want getOffset instead, which tells you the offset for a specific point in time, and takes daylight savings into account for you. </para>        
				/// </summary>
				/// <java-name>
				/// getDSTSavings
				/// </java-name>
				[Dot42.DexImport("getDSTSavings", "()I", AccessFlags = 1)]
				public virtual int GetDSTSavings() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the offset in milliseconds from UTC for this time zone at <c>       time </c> . The offset includes daylight savings time if the specified date is within the daylight savings time period.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(J)I", AccessFlags = 1)]
				public virtual int GetOffset(long time) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this time zone's offset in milliseconds from UTC at the specified date and time. The offset includes daylight savings time if the date and time is within the daylight savings time period.</para><para>This method is intended to be used by Calendar to compute Calendar#DST_OFFSET and Calendar#ZONE_OFFSET. Application code should have no reason to call this method directly. Each parameter is interpreted in the same way as the corresponding <c> Calendar </c> field. Refer to Calendar for specific definitions of this method's parameters. </para>        
				/// </summary>
				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(IIIIII)I", AccessFlags = 1025)]
				public abstract int GetOffset(int era, int year, int month, int day, int dayOfWeek, int timeOfDayMillis) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the offset in milliseconds from UTC of this time zone's standard time. </para>        
				/// </summary>
				/// <java-name>
				/// getRawOffset
				/// </java-name>
				[Dot42.DexImport("getRawOffset", "()I", AccessFlags = 1025)]
				public abstract int GetRawOffset() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> TimeZone </c> corresponding to the given <c> id </c> , or <c> GMT </c> for unknown ids.</para><para>An ID can be an Olson name of the form <b>Area</b>/<b>Location</b>, such as <c> America/Los_Angeles </c> . The getAvailableIDs method returns the supported names.</para><para>This method can also create a custom <c> TimeZone </c> given an ID with the following syntax: <c> GMT[+|-]hh[[:]mm] </c> . For example, <c> "GMT+05:00" </c> , <c> "GMT+0500" </c> , <c> "GMT+5:00" </c> , <c> "GMT+500" </c> , <c> "GMT+05" </c> , and <c> "GMT+5" </c> all return an object with a raw offset of +5 hours from UTC, and which does <b>not</b> use daylight savings. These are rarely useful, because they don't correspond to time zones actually in use by humans.</para><para>Other than the special cases "UTC" and "GMT" (which are synonymous in this context, both corresponding to UTC), Android does not support the deprecated three-letter time zone IDs used in Java 1.1. </para>        
				/// </summary>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;", AccessFlags = 41)]
				public static global::Java.Util.TimeZone GetTimeZone(string id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <summary>
				/// <para>Returns true if <c> timeZone </c> has the same rules as this time zone.</para><para>The base implementation returns true if both time zones have the same raw offset. </para>        
				/// </summary>
				/// <java-name>
				/// hasSameRules
				/// </java-name>
				[Dot42.DexImport("hasSameRules", "(Ljava/util/TimeZone;)Z", AccessFlags = 1)]
				public virtual bool HasSameRules(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if <c> time </c> is in a daylight savings time period for this time zone. </para>        
				/// </summary>
				/// <java-name>
				/// inDaylightTime
				/// </java-name>
				[Dot42.DexImport("inDaylightTime", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				public abstract bool InDaylightTime(global::Java.Util.Date time) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Overrides the default time zone for the current process only.</para><para><b>Warning</b>: avoid using this method to use a custom time zone in your process. This value may be cleared or overwritten at any time, which can cause unexpected behavior. Instead, manually supply a custom time zone as needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/util/TimeZone;)V", AccessFlags = 41)]
				public static void SetDefault(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the ID of this <c> TimeZone </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setID
				/// </java-name>
				[Dot42.DexImport("setID", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetID(string id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the offset in milliseconds from UTC of this time zone's standard time. </para>        
				/// </summary>
				/// <java-name>
				/// setRawOffset
				/// </java-name>
				[Dot42.DexImport("setRawOffset", "(I)V", AccessFlags = 1025)]
				public abstract void SetRawOffset(int offsetMillis) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if this time zone has a future transition to or from daylight savings time.</para><para><b>Warning:</b> this returns false for time zones like <c> Asia/Kuala_Lumpur </c> that have previously used DST but do not currently. A hypothetical country that has never observed daylight savings before but plans to start next year would return true.</para><para><b>Warning:</b> this returns true for time zones that use DST, even when it is not active.</para><para>Use inDaylightTime to find out whether daylight savings is in effect at a specific time.</para><para>Most applications should not use this method. </para>        
				/// </summary>
				/// <java-name>
				/// useDaylightTime
				/// </java-name>
				[Dot42.DexImport("useDaylightTime", "()Z", AccessFlags = 1025)]
				public abstract bool UseDaylightTime() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the system's installed time zone IDs. Any of these IDs can be passed to getTimeZone to lookup the corresponding time zone instance. </para>        
				/// </summary>
				/// <java-name>
				/// getAvailableIDs
				/// </java-name>
				public static string[] AvailableIDs
				{
				[Dot42.DexImport("getAvailableIDs", "()[Ljava/lang/String;", AccessFlags = 41)]
						get{ return GetAvailableIDs(); }
				}

				/// <summary>
				/// <para>Returns the user's preferred time zone. This may have been overridden for this process with setDefault.</para><para>Since the user's time zone changes dynamically, avoid caching this value. Instead, use this method to look it up for each use. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Util.TimeZone Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/util/TimeZone;", AccessFlags = 41)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/util/TimeZone;)V", AccessFlags = 41)]
						set{ SetDefault(value); }
				}

				/// <summary>
				/// <para>Equivalent to <c> getDisplayName(false, TimeZone.LONG, Locale.getDefault()) </c> . . </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetDisplayName(); }
				}

				/// <summary>
				/// <para>Returns the ID of this <c> TimeZone </c> , such as <c> America/Los_Angeles </c> , <c> GMT-08:00 </c> or <c> UTC </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getID
				/// </java-name>
				public string ID
				{
				[Dot42.DexImport("getID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetID(); }
				[Dot42.DexImport("setID", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetID(value); }
				}

				/// <summary>
				/// <para>Returns the latest daylight savings in milliseconds for this time zone, relative to this time zone's regular UTC offset (as returned by getRawOffset).</para><para>This class returns <c> 3600000 </c> (1 hour) for time zones that use daylight savings time and <c> 0 </c> for timezones that do not, leaving it to subclasses to override this method for other daylight savings offsets. (There are time zones, such as <c> Australia/Lord_Howe </c> , that use other values.)</para><para>Note that this method doesn't tell you whether or not to <b>apply</b> the offset: you need to call <c> inDaylightTime </c> for the specific time you're interested in. If this method returns a non-zero offset, that only tells you that this <c> TimeZone </c> sometimes observes daylight savings.</para><para>Note also that this method doesn't necessarily return the value you need to apply to the time you're working with. This value can and does change over time for a given time zone.</para><para>It's highly unlikely that you should ever call this method. You probably want getOffset instead, which tells you the offset for a specific point in time, and takes daylight savings into account for you. </para>        
				/// </summary>
				/// <java-name>
				/// getDSTSavings
				/// </java-name>
				public int DSTSavings
				{
				[Dot42.DexImport("getDSTSavings", "()I", AccessFlags = 1)]
						get{ return GetDSTSavings(); }
				}

				/// <summary>
				/// <para>Returns the offset in milliseconds from UTC of this time zone's standard time. </para>        
				/// </summary>
				/// <java-name>
				/// getRawOffset
				/// </java-name>
				public int RawOffset
				{
				[Dot42.DexImport("getRawOffset", "()I", AccessFlags = 1025)]
						get{ return GetRawOffset(); }
				[Dot42.DexImport("setRawOffset", "(I)V", AccessFlags = 1025)]
						set{ SetRawOffset(value); }
				}

		}

		/// <summary>
		/// <para>An <c> InputMismatchException </c> is thrown by a scanner to indicate that the next token does not match or is out of range for the type specified in the pattern.</para><para><para>Scanner </para><simplesectsep></simplesectsep><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/InputMismatchException
		/// </java-name>
		[Dot42.DexImport("java/util/InputMismatchException", AccessFlags = 33)]
		public partial class InputMismatchException : global::Java.Util.NoSuchElementException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> InputMismatchException </c> with the current stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputMismatchException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> InputMismatchException </c> with the stack trace filled in and <c> msg </c> as its error message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InputMismatchException(string msg) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Thrown when trying to retrieve an element past the end of an Enumeration or Iterator. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/NoSuchElementException
		/// </java-name>
		[Dot42.DexImport("java/util/NoSuchElementException", AccessFlags = 33)]
		public partial class NoSuchElementException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> NoSuchElementException </c> with the current stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchElementException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> NoSuchElementException </c> with the current stack trace and message filled in.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchElementException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><c> PropertyResourceBundle </c> loads resources from an <c> InputStream </c> . All resources are Strings. The resources must be of the form <c> key=value </c> , one resource per line (see Properties).</para><para><para>ResourceBundle </para><simplesectsep></simplesectsep><para>Properties </para><para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/PropertyResourceBundle
		/// </java-name>
		[Dot42.DexImport("java/util/PropertyResourceBundle", AccessFlags = 33)]
		public partial class PropertyResourceBundle : global::Java.Util.ResourceBundle
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of <c> PropertyResourceBundle </c> and loads the properties file from the specified <c> InputStream </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public PropertyResourceBundle(global::Java.Io.InputStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> PropertyResourceBundle </c> and loads the properties file from the specified <c> InputStream </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public PropertyResourceBundle(global::Java.Io.Reader stream) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the names of the resources contained in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the resource names. </para>
				/// </returns>
				/// <java-name>
				/// getKeys
				/// </java-name>
				[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public override global::Java.Util.IEnumeration<string> GetKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<string>);
				}

				/// <summary>
				/// <para>Returns the named resource from this <c> ResourceBundle </c> , or null if the resource is not found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource object. </para>
				/// </returns>
				/// <java-name>
				/// handleGetObject
				/// </java-name>
				[Dot42.DexImport("handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				protected internal override object HandleGetObject(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PropertyResourceBundle() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the names of the resources contained in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the resource names. </para>
				/// </returns>
				/// <java-name>
				/// getKeys
				/// </java-name>
				public global::Java.Util.IEnumeration<string> Keys
				{
				[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return GetKeys(); }
				}

		}

		/// <summary>
		/// <para>IdentityHashMap is a variant on HashMap which tests equality by reference instead of equality by value. Basically, keys and values are compared for equality by checking if their references are equal rather than by calling the "equals" function. </para><para><b>Note: This class intentionally violates the general contract of <c>   Map </c> 's on comparing objects by their <c> equals </c> method.</b> </para><para>IdentityHashMap uses open addressing (linear probing in particular) for collision resolution. This is different from HashMap which uses Chaining. </para><para>Like HashMap, IdentityHashMap is not thread safe, so access by multiple threads must be synchronized by an external mechanism such as Collections.synchronizedMap.</para><para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/IdentityHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/IdentityHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/Map<TK;TV;>;Ljava/io/Serializable;Ljava/lang/Cloneable;")]
		public partial class IdentityHashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.IMap<K, V>, global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates an IdentityHashMap with default expected maximum size. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IdentityHashMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an IdentityHashMap with the specified maximum size parameter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IdentityHashMap(int maxSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an IdentityHashMap with the specified maximum size parameter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public IdentityHashMap(global::Java.Util.IMap<K, V> maxSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all elements from this map, leaving it empty.</para><para><para>isEmpty() </para><simplesectsep></simplesectsep><para>size() </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this map contains the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified key, <c> false </c> otherwise. </para>
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
				/// <para>Returns whether this map contains the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified value, <c> false </c> otherwise. </para>
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
				/// <para>Returns the value of the mapping with the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Maps the specified key to the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no such mapping. </para>
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
				/// <para>Copies all the mappings in the specified map to this map. These mappings will replace all mappings that this map had for any of the keys currently in the given map.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the mapping with the specified key from this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping, or <c> null </c> if no mapping for the specified key was found. </para>
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
				/// <para>Returns a set containing all of the mappings in this map. Each mapping is an instance of Map.Entry. As the set is backed by this map, changes in one will be reflected in the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings. </para>
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
				/// <para>Returns a set of the keys contained in this map. The set is backed by this map so changes to one are reflected by the other. The set does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para>Returns a collection of the values contained in this map. The collection is backed by this map so changes to one are reflected by the other. The collection supports remove, removeAll, retainAll and clear operations, and it does not support add or addAll operations. </para><para>This method returns a collection which is the subclass of AbstractCollection. The iterator method of this subclass returns a "wrapper object" over the iterator of map's entrySet(). The <c> size </c> method wraps the map's size method and the <c> contains </c> method wraps the map's containsValue method. </para><para>The collection is created when this method is called for the first time and returned in response to all subsequent calls. This method may return different collections when multiple concurrent calls occur, since no synchronization is performed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values contained in this map. </para>
				/// </returns>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <summary>
				/// <para>Compares this map with other objects. This map is equal to another map is it represents the same set of mappings. With this map, two mappings are the same if both the key and the value are equal by reference. When compared with a map that is not an IdentityHashMap, the equals method is neither necessarily symmetric (a.equals(b) implies b.equals(a)) nor transitive (a.equals(b) and b.equals(c) implies a.equals(c)).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the argument object is equal to this object. </para>
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
				/// <para>Returns a new IdentityHashMap with the same mappings and size as this one.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this IdentityHashMap. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public new virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns whether this IdentityHashMap has no elements.</para><para><para>size() </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this IdentityHashMap has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of mappings in this IdentityHashMap.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of mappings in this IdentityHashMap. </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para><c> ResourceBundle </c> is an abstract class which is the superclass of classes which provide <c> Locale </c> -specific resources. A bundle contains a number of named resources, where the names are <c> Strings </c> . A bundle may have a parent bundle, and when a resource is not found in a bundle, the parent bundle is searched for the resource. If the fallback mechanism reaches the base bundle and still can't find the resource it throws a <c> MissingResourceException </c> .</para><para><ul><li><para>All bundles for the same group of resources share a common base bundle. This base bundle acts as the root and is the last fallback in case none of its children was able to respond to a request. </para></li><li><para>The first level contains changes between different languages. Only the differences between a language and the language of the base bundle need to be handled by a language-specific <c> ResourceBundle </c> . </para></li><li><para>The second level contains changes between different countries that use the same language. Only the differences between a country and the country of the language bundle need to be handled by a country-specific <c> ResourceBundle </c> .  </para></li><li><para>The third level contains changes that don't have a geographic reason (e.g. changes that where made at some point in time like <c> PREEURO </c> where the currency of come countries changed. The country bundle would return the current currency (Euro) and the <c> PREEURO </c> variant bundle would return the old currency (e.g. DM for Germany). </para></li></ul></para><para><b>Examples</b> <ul><li><para>BaseName (base bundle) </para></li><li><para>BaseName_de (german language bundle) </para></li><li><para>BaseName_fr (french language bundle) </para></li><li><para>BaseName_de_DE (bundle with Germany specific resources in german) </para></li><li><para>BaseName_de_CH (bundle with Switzerland specific resources in german) </para></li><li><para>BaseName_fr_CH (bundle with Switzerland specific resources in french) </para></li><li><para>BaseName_de_DE_PREEURO (bundle with Germany specific resources in german of the time before the Euro) </para></li><li><para>BaseName_fr_FR_PREEURO (bundle with France specific resources in french of the time before the Euro) </para></li></ul></para><para>It's also possible to create variants for languages or countries. This can be done by just skipping the country or language abbreviation: BaseName_us__POSIX or BaseName__DE_PREEURO. But it's not allowed to circumvent both language and country: BaseName___VARIANT is illegal.</para><para><para>Properties </para><simplesectsep></simplesectsep><para>PropertyResourceBundle </para><simplesectsep></simplesectsep><para>ListResourceBundle </para><para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/ResourceBundle
		/// </java-name>
		[Dot42.DexImport("java/util/ResourceBundle", AccessFlags = 1057)]
		public abstract partial class ResourceBundle
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The parent of this <c> ResourceBundle </c> that is used if this bundle doesn't include the requested resource. </para>        
				/// </summary>
				/// <java-name>
				/// parent
				/// </java-name>
				[Dot42.DexImport("parent", "Ljava/util/ResourceBundle;", AccessFlags = 4)]
				protected internal global::Java.Util.ResourceBundle Parent;
				/// <summary>
				/// <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResourceBundle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finds the named resource bundle for the default <c> Locale </c> and the caller's <c> ClassLoader </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested <c> ResourceBundle </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;", AccessFlags = 25)]
				public static global::Java.Util.ResourceBundle GetBundle(string bundleName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;", AccessFlags = 25)]
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
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/ResourceBundle$Control;)Ljava/util/ResourceBundle;", AccessFlags = 25)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.ResourceBundle.Control control) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/ResourceBundle$Control;)Ljava/uti" +
    "l/ResourceBundle;", AccessFlags = 25)]
				public static global::Java.Util.ResourceBundle GetBundle(string @string, global::Java.Util.Locale locale, global::Java.Util.ResourceBundle.Control control) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <summary>
				/// <para>Finds the named resource bundle for the specified base name and control.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the named resource bundle</para>
				/// </returns>
				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;Ljava/util/ResourceBu" +
    "ndle$Control;)Ljava/util/ResourceBundle;", AccessFlags = 9)]
				public static global::Java.Util.ResourceBundle GetBundle(string baseName, global::Java.Util.Locale targetLocale, global::Java.Lang.ClassLoader loader, global::Java.Util.ResourceBundle.Control control) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ResourceBundle);
				}

				/// <summary>
				/// <para>Returns the names of the resources contained in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the resource names. </para>
				/// </returns>
				/// <java-name>
				/// getKeys
				/// </java-name>
				[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public abstract global::Java.Util.IEnumeration<string> GetKeys() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> Locale </c> of this <c> ResourceBundle </c> . In case a bundle was not found for the requested <c> Locale </c> , this will return the actual <c> Locale </c> of this resource bundle that was found after doing a fallback.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Locale </c> of this <c> ResourceBundle </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <summary>
				/// <para>Returns the named resource from this <c> ResourceBundle </c> . If the resource cannot be found in this bundle, it falls back to the parent bundle (if it's not null) by calling the handleGetObject method. If the resource still can't be found it throws a <c> MissingResourceException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource object. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the named string resource from this <c> ResourceBundle </c> .</para><para><para>getObject(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource string. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetString(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the named resource from this <c> ResourceBundle </c> .</para><para><para>getObject(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource string array. </para>
				/// </returns>
				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 17)]
				public string[] GetStringArray(string key) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the named resource from this <c> ResourceBundle </c> , or null if the resource is not found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource object. </para>
				/// </returns>
				/// <java-name>
				/// handleGetObject
				/// </java-name>
				[Dot42.DexImport("handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1028)]
				protected internal abstract object HandleGetObject(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the parent resource bundle of this <c> ResourceBundle </c> . The parent is searched for resources which are not found in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Ljava/util/ResourceBundle;)V", AccessFlags = 4)]
				protected internal virtual void SetParent(global::Java.Util.ResourceBundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCache
				/// </java-name>
				[Dot42.DexImport("clearCache", "()V", AccessFlags = 25)]
				public static void ClearCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCache
				/// </java-name>
				[Dot42.DexImport("clearCache", "(Ljava/lang/ClassLoader;)V", AccessFlags = 25)]
				public static void ClearCache(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsKey(string key) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the names of the resources contained in this <c> ResourceBundle </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the resource names. </para>
				/// </returns>
				/// <java-name>
				/// getKeys
				/// </java-name>
				public global::Java.Util.IEnumeration<string> Keys
				{
				[Dot42.DexImport("getKeys", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return GetKeys(); }
				}

				/// <summary>
				/// <para>Gets the <c> Locale </c> of this <c> ResourceBundle </c> . In case a bundle was not found for the requested <c> Locale </c> , this will return the actual <c> Locale </c> of this resource bundle that was found after doing a fallback.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Locale </c> of this <c> ResourceBundle </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLocale(); }
				}

				/// <summary>
				/// <para>ResourceBundle.Control is a static utility class defines ResourceBundle load access methods, its default access order is as the same as before. However users can implement their own control.</para><para><para>1.6 </para></para>    
				/// </summary>
				/// <java-name>
				/// java/util/ResourceBundle$Control
				/// </java-name>
				[Dot42.DexImport("java/util/ResourceBundle$Control", AccessFlags = 9)]
				public partial class Control
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>a list defines default format </para>        
						/// </summary>
						/// <java-name>
						/// FORMAT_DEFAULT
						/// </java-name>
						[Dot42.DexImport("FORMAT_DEFAULT", "Ljava/util/List;", AccessFlags = 25)]
						public static readonly global::Java.Util.IList<string> FORMAT_DEFAULT;
						/// <summary>
						/// <para>a list defines java class format </para>        
						/// </summary>
						/// <java-name>
						/// FORMAT_CLASS
						/// </java-name>
						[Dot42.DexImport("FORMAT_CLASS", "Ljava/util/List;", AccessFlags = 25)]
						public static readonly global::Java.Util.IList<string> FORMAT_CLASS;
						/// <summary>
						/// <para>a list defines property format </para>        
						/// </summary>
						/// <java-name>
						/// FORMAT_PROPERTIES
						/// </java-name>
						[Dot42.DexImport("FORMAT_PROPERTIES", "Ljava/util/List;", AccessFlags = 25)]
						public static readonly global::Java.Util.IList<string> FORMAT_PROPERTIES;
						/// <summary>
						/// <para>a constant that indicates cache will not be used. </para>        
						/// </summary>
						/// <java-name>
						/// TTL_DONT_CACHE
						/// </java-name>
						[Dot42.DexImport("TTL_DONT_CACHE", "J", AccessFlags = 25)]
						public const long TTL_DONT_CACHE = -1;
						/// <summary>
						/// <para>a constant that indicates cache will not be expired. </para>        
						/// </summary>
						/// <java-name>
						/// TTL_NO_EXPIRATION_CONTROL
						/// </java-name>
						[Dot42.DexImport("TTL_NO_EXPIRATION_CONTROL", "J", AccessFlags = 25)]
						public const long TTL_NO_EXPIRATION_CONTROL = -2;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						protected internal Control() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns a control according to <c> formats </c> . </para>        
						/// </summary>
						/// <java-name>
						/// getControl
						/// </java-name>
						[Dot42.DexImport("getControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;", AccessFlags = 25, Signature = "(Ljava/util/List<Ljava/lang/String;>;)Ljava/util/ResourceBundle$Control;")]
						public static Control GetControl(global::Java.Util.IList<string> formats) /* MethodBuilder.Create */ 
						{
								return default(Control);
						}

						/// <summary>
						/// <para>Returns a control according to <c> formats </c> whose fallback locale is null. </para>        
						/// </summary>
						/// <java-name>
						/// getNoFallbackControl
						/// </java-name>
						[Dot42.DexImport("getNoFallbackControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;", AccessFlags = 25, Signature = "(Ljava/util/List<Ljava/lang/String;>;)Ljava/util/ResourceBundle$Control;")]
						public static Control GetNoFallbackControl(global::Java.Util.IList<string> formats) /* MethodBuilder.Create */ 
						{
								return default(Control);
						}

						/// <summary>
						/// <para>Returns a list of candidate locales according to <c> baseName </c> in <c> locale </c> . </para>        
						/// </summary>
						/// <java-name>
						/// getCandidateLocales
						/// </java-name>
						[Dot42.DexImport("getCandidateLocales", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List<Ljava/util/Locale;>;")]
						public virtual global::Java.Util.IList<global::Java.Util.Locale> GetCandidateLocales(string baseName, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Java.Util.Locale>);
						}

						/// <summary>
						/// <para>Returns a list of strings of formats according to <c> baseName </c> . </para>        
						/// </summary>
						/// <java-name>
						/// getFormats
						/// </java-name>
						[Dot42.DexImport("getFormats", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetFormats(string baseName) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Returns the fallback locale for <c> baseName </c> in <c> locale </c> . </para>        
						/// </summary>
						/// <java-name>
						/// getFallbackLocale
						/// </java-name>
						[Dot42.DexImport("getFallbackLocale", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/Locale;", AccessFlags = 1)]
						public virtual global::Java.Util.Locale GetFallbackLocale(string baseName, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.Locale);
						}

						/// <summary>
						/// <para>Returns a new ResourceBundle.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a new ResourceBundle according to the give parameters </para>
						/// </returns>
						/// <java-name>
						/// newBundle
						/// </java-name>
						[Dot42.DexImport("newBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Z)L" +
    "java/util/ResourceBundle;", AccessFlags = 1)]
						public virtual global::Java.Util.ResourceBundle NewBundle(string baseName, global::Java.Util.Locale locale, string format, global::Java.Lang.ClassLoader loader, bool reload) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.ResourceBundle);
						}

						/// <summary>
						/// <para>Returns the time to live of the ResourceBundle <c> baseName </c> in <c> locale </c> , default is TTL_NO_EXPIRATION_CONTROL. </para>        
						/// </summary>
						/// <java-name>
						/// getTimeToLive
						/// </java-name>
						[Dot42.DexImport("getTimeToLive", "(Ljava/lang/String;Ljava/util/Locale;)J", AccessFlags = 1)]
						public virtual long GetTimeToLive(string baseName, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Returns true if the ResourceBundle needs to reload.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>if the ResourceBundle needs to reload </para>
						/// </returns>
						/// <java-name>
						/// needsReload
						/// </java-name>
						[Dot42.DexImport("needsReload", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Lja" +
    "va/util/ResourceBundle;J)Z", AccessFlags = 1)]
						public virtual bool NeedsReload(string baseName, global::Java.Util.Locale locale, string format, global::Java.Lang.ClassLoader loader, global::Java.Util.ResourceBundle bundle, long loadTime) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>a utility method to answer the name of a resource bundle according to the given base name and locale</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the name of a resource bundle according to the given base name and locale </para>
						/// </returns>
						/// <java-name>
						/// toBundleName
						/// </java-name>
						[Dot42.DexImport("toBundleName", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string ToBundleName(string baseName, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>a utility method to answer the name of a resource according to the given bundleName and suffix</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the name of a resource according to the given bundleName and suffix </para>
						/// </returns>
						/// <java-name>
						/// toResourceName
						/// </java-name>
						[Dot42.DexImport("toResourceName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 17)]
						public string ToResourceName(string bundleName, string suffix) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <summary>
		/// <para>HashMap is an implementation of Map. All optional operations are supported.</para><para>All elements are permitted as keys or values, including null.</para><para>Note that the iteration order for HashMap is non-deterministic. If you want deterministic iteration, use LinkedHashMap.</para><para>Note: the implementation of <c> HashMap </c> is not synchronized. If one thread of several threads accessing an instance modifies the map structurally, access to the map needs to be synchronized. A structural modification is an operation that adds or removes an entry. Changes in the value of an entry are not structural changes.</para><para>The <c> Iterator </c> created by calling the <c> iterator </c> method may throw a <c> ConcurrentModificationException </c> if the map is structurally changed while an iterator is used to iterate over the elements. Only the <c> remove </c> method that is provided by the iterator allows for removal of elements during iteration. It is not possible to guarantee that this mechanism works in all cases of unsynchronized concurrent modification. It should only be used for debugging purposes.</para><para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/HashMap
		/// </java-name>
		[Dot42.DexImport("java/util/HashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/la" +
    "ng/Cloneable;Ljava/io/Serializable;")]
		public partial class HashMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty <c> HashMap </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HashMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> HashMap </c> instance with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public HashMap(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> HashMap </c> instance with the specified capacity and load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public HashMap(int capacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> HashMap </c> instance with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public HashMap(global::Java.Util.IMap<K, V> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a shallow copy of this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this map. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public new virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns whether this map is empty.</para><para><para>size() </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of elements in this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this map. </para>
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
				/// <para>Returns the value of the mapping with the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns whether this map contains the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified key, <c> false </c> otherwise. </para>
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
				/// <para>Returns whether this map contains the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified value, <c> false </c> otherwise. </para>
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
				/// <para>Maps the specified key to the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no such mapping. </para>
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
				/// <para>Copies all the mappings in the specified map to this map. These mappings will replace all mappings that this map had for any of the keys currently in the given map.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public override void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the mapping with the specified key from this map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping or <c> null </c> if no mapping for the specified key was found. </para>
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
				/// <para>Removes all mappings from this hash map, leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>#size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a set of the keys contained in this map. The set is backed by this map so changes to one are reflected by the other. The set does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para>Returns a collection of the values contained in this map. The collection is backed by this map so changes to one are reflected by the other. The collection supports remove, removeAll, retainAll and clear operations, and it does not support add or addAll operations. </para><para>This method returns a collection which is the subclass of AbstractCollection. The iterator method of this subclass returns a "wrapper object" over the iterator of map's entrySet(). The <c> size </c> method wraps the map's size method and the <c> contains </c> method wraps the map's containsValue method. </para><para>The collection is created when this method is called for the first time and returned in response to all subsequent calls. This method may return different collections when multiple concurrent calls occur, since no synchronization is performed. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values contained in this map. </para>
				/// </returns>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<TV;>;")]
				public override global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <summary>
				/// <para>Returns a set containing all of the mappings in this map. Each mapping is an instance of Map.Entry. As the set is backed by this map, changes in one will be reflected in the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings. </para>
				/// </returns>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

		}

		/// <summary>
		/// <para>FormattableFlags are used as a parameter to Formattable#formatTo(Formatter, int, int, int) and change the output format in <c> Formattable </c> s. The validation and interpretation of the flags must be done by the implementations.</para><para><para>Formattable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/FormattableFlags
		/// </java-name>
		[Dot42.DexImport("java/util/FormattableFlags", AccessFlags = 33)]
		public partial class FormattableFlags
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Denotes the output is to be left-justified. In order to fill the minimum width requirement, spaces('') will be appended at the end of the specified output element. If no such flag is set, the output is right-justified.</para><para>The flag corresponds to '-' ('') in the format specifier. </para>        
				/// </summary>
				/// <java-name>
				/// LEFT_JUSTIFY
				/// </java-name>
				[Dot42.DexImport("LEFT_JUSTIFY", "I", AccessFlags = 25)]
				public const int LEFT_JUSTIFY = 1;
				/// <summary>
				/// <para>Denotes the output is to be converted to upper case in the way the locale parameter of Formatter.formatTo() requires. The output has the same effect as <c> String.toUpperCase(java.util.Locale) </c> .</para><para>This flag corresponds to <c> '^' ('\u005e') </c> in the format specifier. </para>        
				/// </summary>
				/// <java-name>
				/// UPPERCASE
				/// </java-name>
				[Dot42.DexImport("UPPERCASE", "I", AccessFlags = 25)]
				public const int UPPERCASE = 2;
				/// <summary>
				/// <para>Denotes the output is to be formatted in an alternate form. The definition of the alternate form is determined by the <c> Formattable </c> .</para><para>This flag corresponds to <c> '#' ('\u0023') </c> in the format specifier. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>This abstract class provides a simple wrapper for objects of type <c> EventListener </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/util/EventListenerProxy
		/// </java-name>
		[Dot42.DexImport("java/util/EventListenerProxy", AccessFlags = 1057)]
		public abstract partial class EventListenerProxy : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> EventListener </c> proxy instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/EventListener;)V", AccessFlags = 1)]
				public EventListenerProxy(global::Java.Util.IEventListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the wrapped <c> EventListener </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the wrapped <c> EventListener </c> . </para>
				/// </returns>
				/// <java-name>
				/// getListener
				/// </java-name>
				[Dot42.DexImport("getListener", "()Ljava/util/EventListener;", AccessFlags = 1)]
				public virtual global::Java.Util.IEventListener GetListener() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEventListener);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EventListenerProxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the wrapped <c> EventListener </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the wrapped <c> EventListener </c> . </para>
				/// </returns>
				/// <java-name>
				/// getListener
				/// </java-name>
				public global::Java.Util.IEventListener Listener
				{
				[Dot42.DexImport("getListener", "()Ljava/util/EventListener;", AccessFlags = 1)]
						get{ return GetListener(); }
				}

		}

		/// <summary>
		/// <para><c> Collections </c> contains static methods which operate on <c> Collection </c> classes.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Collections
		/// </java-name>
		[Dot42.DexImport("java/util/Collections", AccessFlags = 33)]
		public partial class Collections
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>An empty immutable instance of List. </para>        
				/// </summary>
				/// <java-name>
				/// EMPTY_LIST
				/// </java-name>
				[Dot42.DexImport("EMPTY_LIST", "Ljava/util/List;", AccessFlags = 25)]
				public static readonly global::Java.Util.IList<object> EMPTY_LIST;
				/// <summary>
				/// <para>An empty immutable instance of Set. </para>        
				/// </summary>
				/// <java-name>
				/// EMPTY_SET
				/// </java-name>
				[Dot42.DexImport("EMPTY_SET", "Ljava/util/Set;", AccessFlags = 25)]
				public static readonly global::Java.Util.ISet<object> EMPTY_SET;
				/// <summary>
				/// <para>An empty immutable instance of Map. </para>        
				/// </summary>
				/// <java-name>
				/// EMPTY_MAP
				/// </java-name>
				[Dot42.DexImport("EMPTY_MAP", "Ljava/util/Map;", AccessFlags = 25)]
				public static readonly global::Java.Util.IMap<object, object> EMPTY_MAP;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Collections() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs a binary search for the specified element in the specified sorted list. The list needs to be already sorted in natural sorting order. Searching in an unsorted array has an undefined result. It's also undefined which element is found if there are multiple occurrences of the same element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the non-negative index of the element, or a negative index which is the <c> -index - 1 </c> where the element would be inserted </para>
				/// </returns>
				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<+Ljava/lang/Comparable<-TT;>;>;TT;)I")]
				public static int BinarySearch<T>(global::Java.Util.IList<global::System.IComparable<T>> list, T @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Performs a binary search for the specified element in the specified sorted list using the specified comparator. The list needs to be already sorted according to the comparator passed. Searching in an unsorted array has an undefined result. It's also undefined which element is found if there are multiple occurrences of the same element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the non-negative index of the element, or a negative index which is the <c> -index - 1 </c> where the element would be inserted. </para>
				/// </returns>
				/// <java-name>
				/// binarySearch
				/// </java-name>
				[Dot42.DexImport("binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<+TT;>;TT;Ljava/util/Comparator<-TT;>;)I")]
				public static int BinarySearch<T>(global::Java.Util.IList<T> list, T @object, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Copies the elements from the source list to the destination list. At the end both lists will have the same objects at the same index. If the destination array is larger than the source list, the elements in the destination list with <c> index &gt;= source.size() </c> will be unchanged.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "(Ljava/util/List;Ljava/util/List;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<-TT;>;Ljava/util/List<+TT;>;)V")]
				public static void Copy<T>(global::Java.Util.IList<T> destination, global::Java.Util.IList<T> source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an <c> Enumeration </c> on the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an Enumeration. </para>
				/// </returns>
				/// <java-name>
				/// enumeration
				/// </java-name>
				[Dot42.DexImport("enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;)Ljava/util/Enumeration<TT;>;")]
				public static global::Java.Util.IEnumeration<T> Enumeration<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<T>);
				}

				/// <summary>
				/// <para>Fills the specified list with the specified element.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "(Ljava/util/List;Ljava/lang/Object;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<-TT;>;TT;)V")]
				public static void Fill<T>(global::Java.Util.IList<T> list, T @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Searches the specified collection for the maximum element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum element in the Collection. </para>
				/// </returns>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;:Ljava/lang/Comparable<-TT;>;>(Ljava/util/Collection<+TT;>;)" +
    "TT;")]
				public static T Max<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Searches the specified collection for the maximum element using the specified comparator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum element in the Collection. </para>
				/// </returns>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+TT;>;Ljava/util/Comparator<-TT;>;)T" +
    "T;")]
				public static T Max<T>(global::Java.Util.ICollection<T> collection, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Searches the specified collection for the minimum element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum element in the collection. </para>
				/// </returns>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/util/Collection;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;:Ljava/lang/Comparable<-TT;>;>(Ljava/util/Collection<+TT;>;)" +
    "TT;")]
				public static T Min<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Searches the specified collection for the minimum element using the specified comparator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum element in the collection. </para>
				/// </returns>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<+TT;>;Ljava/util/Comparator<-TT;>;)T" +
    "T;")]
				public static T Min<T>(global::Java.Util.ICollection<T> collection, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				/// <para>Returns a list containing the specified number of the specified element. The list cannot be modified. The list is serializable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list containing <c> length </c> copies of the element. </para>
				/// </returns>
				/// <java-name>
				/// nCopies
				/// </java-name>
				[Dot42.DexImport("nCopies", "(ILjava/lang/Object;)Ljava/util/List;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(ITT;)Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> NCopies<T>(int length, T @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <summary>
				/// <para>Modifies the specified <c> List </c> by reversing the order of the elements.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "(Ljava/util/List;)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;)V")]
				public static void Reverse(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A comparator which reverses the natural order of the elements. The <c> Comparator </c> that's returned is Serializable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Comparator </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// reverseOrder
				/// </java-name>
				[Dot42.DexImport("reverseOrder", "()Ljava/util/Comparator;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>()Ljava/util/Comparator<TT;>;")]
				public static global::Java.Util.IComparator<T> ReverseOrder<T>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<T>);
				}

				/// <summary>
				/// <para>Returns a Comparator that reverses the order of the <c> Comparator </c> passed. If the <c> Comparator </c> passed is <c> null </c> , then this method is equivalent to reverseOrder(). </para><para>The <c> Comparator </c> that's returned is Serializable if the <c> Comparator </c> passed is serializable or <c> null </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Comparator </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// reverseOrder
				/// </java-name>
				[Dot42.DexImport("reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Comparator<TT;>;)Ljava/util/Comparator<TT;>;")]
				public static global::Java.Util.IComparator<T> ReverseOrder<T>(global::Java.Util.IComparator<T> c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<T>);
				}

				/// <summary>
				/// <para>Moves every element of the list to a random new position in the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shuffle
				/// </java-name>
				[Dot42.DexImport("shuffle", "(Ljava/util/List;)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;)V")]
				public static void Shuffle(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Moves every element of the list to a random new position in the list using the specified random number generator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shuffle
				/// </java-name>
				[Dot42.DexImport("shuffle", "(Ljava/util/List;Ljava/util/Random;)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;Ljava/util/Random;)V")]
				public static void Shuffle(global::Java.Util.IList<object> list, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a set containing the specified element. The set cannot be modified. The set is serializable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set containing the element. </para>
				/// </returns>
				/// <java-name>
				/// singleton
				/// </java-name>
				[Dot42.DexImport("singleton", "(Ljava/lang/Object;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(TE;)Ljava/util/Set<TE;>;")]
				public static global::Java.Util.ISet<E> Singleton<E>(E @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <summary>
				/// <para>Returns a list containing the specified element. The list cannot be modified. The list is serializable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list containing the element. </para>
				/// </returns>
				/// <java-name>
				/// singletonList
				/// </java-name>
				[Dot42.DexImport("singletonList", "(Ljava/lang/Object;)Ljava/util/List;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(TE;)Ljava/util/List<TE;>;")]
				public static global::Java.Util.IList<E> SingletonList<E>(E @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <summary>
				/// <para>Returns a Map containing the specified key and value. The map cannot be modified. The map is serializable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Map containing the key and value. </para>
				/// </returns>
				/// <java-name>
				/// singletonMap
				/// </java-name>
				[Dot42.DexImport("singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Ljava/util/Map<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> SingletonMap<K, V>(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <summary>
				/// <para>Sorts the specified list in ascending natural order. The algorithm is stable which means equal elements don't get reordered.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "(Ljava/util/List;)V", AccessFlags = 9, Signature = "<T::Ljava/lang/Comparable<-TT;>;>(Ljava/util/List<TT;>;)V")]
				public static void Sort<T>(global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sorts the specified list using the specified comparator. The algorithm is stable which means equal elements don't get reordered.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "(Ljava/util/List;Ljava/util/Comparator;)V", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;Ljava/util/Comparator<-TT;>;)V")]
				public static void Sort<T>(global::Java.Util.IList<T> list, global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Swaps the elements of list <c> list </c> at indices <c> index1 </c> and <c> index2 </c> .</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// swap
				/// </java-name>
				[Dot42.DexImport("swap", "(Ljava/util/List;II)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;II)V")]
				public static void Swap(global::Java.Util.IList<object> list, int index1, int index2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Replaces all occurrences of Object <c> obj </c> in <c> list </c> with <c> newObj </c> . If the <c> obj </c> is <c> null </c> , then all occurrences of <c> null </c> are replaced with <c> newObj </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true, if at least one occurrence of <c> obj </c> has been found in <c> list </c> . </para>
				/// </returns>
				/// <java-name>
				/// replaceAll
				/// </java-name>
				[Dot42.DexImport("replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;TT;TT;)Z")]
				public static bool ReplaceAll<T>(global::Java.Util.IList<T> list, T obj, T obj2) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Rotates the elements in <c> list </c> by the distance <c> dist </c> </para><para>e.g. for a given list with elements [1, 2, 3, 4, 5, 6, 7, 8, 9, 0], calling rotate(list, 3) or rotate(list, -7) would modify the list to look like this: [8, 9, 0, 1, 2, 3, 4, 5, 6, 7]</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(Ljava/util/List;I)V", AccessFlags = 9, Signature = "(Ljava/util/List<*>;I)V")]
				public static void Rotate(global::Java.Util.IList<object> lst, int dist) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Searches the <c> list </c> for <c> sublist </c> and returns the beginning index of the first occurrence. </para><para>-1 is returned if the <c> sublist </c> does not exist in <c> list </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the beginning index of the first occurrence of <c> sublist </c> in <c> list </c> , or -1. </para>
				/// </returns>
				/// <java-name>
				/// indexOfSubList
				/// </java-name>
				[Dot42.DexImport("indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I", AccessFlags = 9, Signature = "(Ljava/util/List<*>;Ljava/util/List<*>;)I")]
				public static int IndexOfSubList(global::Java.Util.IList<object> list, global::Java.Util.IList<object> sublist) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches the <c> list </c> for <c> sublist </c> and returns the beginning index of the last occurrence. </para><para>-1 is returned if the <c> sublist </c> does not exist in <c> list </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the beginning index of the last occurrence of <c> sublist </c> in <c> list </c> , or -1. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOfSubList
				/// </java-name>
				[Dot42.DexImport("lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I", AccessFlags = 9, Signature = "(Ljava/util/List<*>;Ljava/util/List<*>;)I")]
				public static int LastIndexOfSubList(global::Java.Util.IList<object> list, global::Java.Util.IList<object> sublist) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an <c> ArrayList </c> with all the elements in the <c>       enumeration </c> . The elements in the returned <c> ArrayList </c> are in the same order as in the <c> enumeration </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> ArrayList </c> from <c> enumeration </c> . </para>
				/// </returns>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Enumeration<TT;>;)Ljava/util/ArrayList<TT;>;")]
				public static global::Java.Util.ArrayList<T> List<T>(global::Java.Util.IEnumeration<T> enumeration) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified collection which synchronizes all access to the collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a synchronized Collection. </para>
				/// </returns>
				/// <java-name>
				/// synchronizedCollection
				/// </java-name>
				[Dot42.DexImport("synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;)Ljava/util/Collection<TT;>;")]
				public static global::Java.Util.ICollection<T> SynchronizedCollection<T>(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<T>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified List which synchronizes all access to the List.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a synchronized List. </para>
				/// </returns>
				/// <java-name>
				/// synchronizedList
				/// </java-name>
				[Dot42.DexImport("synchronizedList", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;)Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> SynchronizedList<T>(global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified map which synchronizes all access to the map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a synchronized Map. </para>
				/// </returns>
				/// <java-name>
				/// synchronizedMap
				/// </java-name>
				[Dot42.DexImport("synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;)Ljava/util/Map" +
    "<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> SynchronizedMap<K, V>(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified set which synchronizes all access to the set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a synchronized set. </para>
				/// </returns>
				/// <java-name>
				/// synchronizedSet
				/// </java-name>
				[Dot42.DexImport("synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;)Ljava/util/Set<TE;>;")]
				public static global::Java.Util.ISet<E> SynchronizedSet<E>(global::Java.Util.ISet<E> set) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified sorted map which synchronizes all access to the sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a synchronized sorted map. </para>
				/// </returns>
				/// <java-name>
				/// synchronizedSortedMap
				/// </java-name>
				[Dot42.DexImport("synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;)Ljava/ut" +
    "il/SortedMap<TK;TV;>;")]
				public static global::Java.Util.ISortedMap<K, V> SynchronizedSortedMap<K, V>(global::Java.Util.ISortedMap<K, V> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified sorted set which synchronizes all access to the sorted set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a synchronized sorted set. </para>
				/// </returns>
				/// <java-name>
				/// synchronizedSortedSet
				/// </java-name>
				[Dot42.DexImport("synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Ljava/util/SortedSet<TE;>;")]
				public static global::Java.Util.ISortedSet<E> SynchronizedSortedSet<E>(global::Java.Util.ISortedSet<E> set) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified collection which throws an <c> UnsupportedOperationException </c> whenever an attempt is made to modify the collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an unmodifiable collection. </para>
				/// </returns>
				/// <java-name>
				/// unmodifiableCollection
				/// </java-name>
				[Dot42.DexImport("unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Ljava/util/Collection<TE;>;")]
				public static global::Java.Util.ICollection<E> UnmodifiableCollection<E>(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<E>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified list which throws an <c> UnsupportedOperationException </c> whenever an attempt is made to modify the list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an unmodifiable List. </para>
				/// </returns>
				/// <java-name>
				/// unmodifiableList
				/// </java-name>
				[Dot42.DexImport("unmodifiableList", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/List<+TE;>;)Ljava/util/List<TE;>;")]
				public static global::Java.Util.IList<E> UnmodifiableList<E>(global::Java.Util.IList<E> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified map which throws an <c> UnsupportedOperationException </c> whenever an attempt is made to modify the map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a unmodifiable map. </para>
				/// </returns>
				/// <java-name>
				/// unmodifiableMap
				/// </java-name>
				[Dot42.DexImport("unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Ljava/util/M" +
    "ap<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> UnmodifiableMap<K, V>(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified set which throws an <c> UnsupportedOperationException </c> whenever an attempt is made to modify the set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a unmodifiable set </para>
				/// </returns>
				/// <java-name>
				/// unmodifiableSet
				/// </java-name>
				[Dot42.DexImport("unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Set<+TE;>;)Ljava/util/Set<TE;>;")]
				public static global::Java.Util.ISet<E> UnmodifiableSet<E>(global::Java.Util.ISet<E> set) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified sorted map which throws an <c> UnsupportedOperationException </c> whenever an attempt is made to modify the sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a unmodifiable sorted map </para>
				/// </returns>
				/// <java-name>
				/// unmodifiableSortedMap
				/// </java-name>
				[Dot42.DexImport("unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;+TV;>;)Ljava/u" +
    "til/SortedMap<TK;TV;>;")]
				public static global::Java.Util.ISortedMap<K, V> UnmodifiableSortedMap<K, V>(global::Java.Util.ISortedMap<K, V> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a wrapper on the specified sorted set which throws an <c> UnsupportedOperationException </c> whenever an attempt is made to modify the sorted set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a unmodifiable sorted set. </para>
				/// </returns>
				/// <java-name>
				/// unmodifiableSortedSet
				/// </java-name>
				[Dot42.DexImport("unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Ljava/util/SortedSet<TE;>;")]
				public static global::Java.Util.ISortedSet<E> UnmodifiableSortedSet<E>(global::Java.Util.ISortedSet<E> set) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <summary>
				/// <para>Returns the number of elements in the <c> Collection </c> that match the <c> Object </c> passed. If the <c> Object </c> is <c> null </c> , then the number of <c> null </c> elements is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of matching elements. </para>
				/// </returns>
				/// <java-name>
				/// frequency
				/// </java-name>
				[Dot42.DexImport("frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I", AccessFlags = 9, Signature = "(Ljava/util/Collection<*>;Ljava/lang/Object;)I")]
				public static int Frequency(global::Java.Util.ICollection<object> c, object o) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a type-safe empty, immutable List.</para><para><para>1.5 </para><para>EMPTY_LIST </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty List. </para>
				/// </returns>
				/// <java-name>
				/// emptyList
				/// </java-name>
				[Dot42.DexImport("emptyList", "()Ljava/util/List;", AccessFlags = 25, Signature = "<T:Ljava/lang/Object;>()Ljava/util/List<TT;>;")]
				public static global::Java.Util.IList<T> EmptyList<T>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<T>);
				}

				/// <summary>
				/// <para>Returns a type-safe empty, immutable Set.</para><para><para>1.5 </para><para>EMPTY_SET </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty Set. </para>
				/// </returns>
				/// <java-name>
				/// emptySet
				/// </java-name>
				[Dot42.DexImport("emptySet", "()Ljava/util/Set;", AccessFlags = 25, Signature = "<T:Ljava/lang/Object;>()Ljava/util/Set<TT;>;")]
				public static global::Java.Util.ISet<T> EmptySet<T>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <summary>
				/// <para>Returns a type-safe empty, immutable Map.</para><para><para>1.5 </para><para>EMPTY_MAP </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty Map. </para>
				/// </returns>
				/// <java-name>
				/// emptyMap
				/// </java-name>
				[Dot42.DexImport("emptyMap", "()Ljava/util/Map;", AccessFlags = 25, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/Map<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> EmptyMap<K, V>() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a dynamically typesafe view of the specified collection. Trying to insert an element of the wrong type into this collection throws a <c> ClassCastException </c> . At creation time the types in <c> c </c> are not checked for correct type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a typesafe collection. </para>
				/// </returns>
				/// <java-name>
				/// checkedCollection
				/// </java-name>
				[Dot42.DexImport("checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;Ljava/lang/Class<TE;>;)Ljava/ut" +
    "il/Collection<TE;>;")]
				public static global::Java.Util.ICollection<E> CheckedCollection<E>(global::Java.Util.ICollection<E> c, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<E>);
				}

				/// <summary>
				/// <para>Returns a dynamically typesafe view of the specified map. Trying to insert an element of the wrong type into this map throws a <c> ClassCastException </c> . At creation time the types in <c> m </c> are not checked for correct type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a typesafe map. </para>
				/// </returns>
				/// <java-name>
				/// checkedMap
				/// </java-name>
				[Dot42.DexImport("checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/lang/Clas" +
    "s<TK;>;Ljava/lang/Class<TV;>;)Ljava/util/Map<TK;TV;>;")]
				public static global::Java.Util.IMap<K, V> CheckedMap<K, V>(global::Java.Util.IMap<K, V> m, global::System.Type keyType, global::System.Type valueType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a dynamically typesafe view of the specified list. Trying to insert an element of the wrong type into this list throws a <c> ClassCastException </c> . At creation time the types in <c> list </c> are not checked for correct type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a typesafe list. </para>
				/// </returns>
				/// <java-name>
				/// checkedList
				/// </java-name>
				[Dot42.DexImport("checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/Lis" +
    "t<TE;>;")]
				public static global::Java.Util.IList<E> CheckedList<E>(global::Java.Util.IList<E> list, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <summary>
				/// <para>Returns a dynamically typesafe view of the specified set. Trying to insert an element of the wrong type into this set throws a <c> ClassCastException </c> . At creation time the types in <c> s </c> are not checked for correct type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a typesafe set. </para>
				/// </returns>
				/// <java-name>
				/// checkedSet
				/// </java-name>
				[Dot42.DexImport("checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/Set<" +
    "TE;>;")]
				public static global::Java.Util.ISet<E> CheckedSet<E>(global::Java.Util.ISet<E> s, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <summary>
				/// <para>Returns a dynamically typesafe view of the specified sorted map. Trying to insert an element of the wrong type into this sorted map throws a <c> ClassCastException </c> . At creation time the types in <c> m </c> are not checked for correct type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a typesafe sorted map. </para>
				/// </returns>
				/// <java-name>
				/// checkedSortedMap
				/// </java-name>
				[Dot42.DexImport("checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;", AccessFlags = 9, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;Ljava/lan" +
    "g/Class<TK;>;Ljava/lang/Class<TV;>;)Ljava/util/SortedMap<TK;TV;>;")]
				public static global::Java.Util.ISortedMap<K, V> CheckedSortedMap<K, V>(global::Java.Util.ISortedMap<K, V> m, global::System.Type keyType, global::System.Type valueType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a dynamically typesafe view of the specified sorted set. Trying to insert an element of the wrong type into this sorted set throws a <c> ClassCastException </c> . At creation time the types in <c> s </c> are not checked for correct type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a typesafe sorted set. </para>
				/// </returns>
				/// <java-name>
				/// checkedSortedSet
				/// </java-name>
				[Dot42.DexImport("checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;Ljava/lang/Class<TE;>;)Ljava/uti" +
    "l/SortedSet<TE;>;")]
				public static global::Java.Util.ISortedSet<E> CheckedSortedSet<E>(global::Java.Util.ISortedSet<E> s, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <summary>
				/// <para>Adds all the specified elements to the specified collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the collection changed during insertion. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Collection<-TT;>;[TT;)Z")]
				public static bool AddAll<T>(global::Java.Util.ICollection<T> c, params T[] a) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the specified collections have no elements in common.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the collections have no elements in common, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// disjoint
				/// </java-name>
				[Dot42.DexImport("disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z", AccessFlags = 9, Signature = "(Ljava/util/Collection<*>;Ljava/util/Collection<*>;)Z")]
				public static bool Disjoint(global::Java.Util.ICollection<object> c1, global::Java.Util.ICollection<object> c2) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a set backed by <c> map </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// newSetFromMap
				/// </java-name>
				[Dot42.DexImport("newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;", AccessFlags = 9, Signature = "<E:Ljava/lang/Object;>(Ljava/util/Map<TE;Ljava/lang/Boolean;>;)Ljava/util/Set<TE;" +
    ">;")]
				public static global::Java.Util.ISet<E> NewSetFromMap<E>(global::Java.Util.IMap<E, bool?> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<E>);
				}

				/// <summary>
				/// <para>Returns a last-in, first-out queue as a view of <c> deque </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// asLifoQueue
				/// </java-name>
				[Dot42.DexImport("asLifoQueue", "(Ljava/util/Deque;)Ljava/util/Queue;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/util/Deque<TT;>;)Ljava/util/Queue<TT;>;")]
				public static global::Java.Util.IQueue<T> AsLifoQueue<T>(global::Java.Util.IDeque<T> deque) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IQueue<T>);
				}

		}

		/// <summary>
		/// <para>An <c> InvalidPropertiesFormatException </c> is thrown if loading the XML document defining the properties does not follow the <c> Properties </c> specification.</para><para>Even though this Exception inherits the <c> Serializable </c> interface, it is not serializable. The methods used for serialization throw <c> NotSerializableException </c> s. </para>    
		/// </summary>
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

		/// <summary>
		/// <para>LinkedHashSet is a variant of HashSet. Its entries are kept in a doubly-linked list. The iteration order is the order in which entries were inserted. </para><para>Null elements are allowed, and all the optional Set operations are supported. </para><para>Like HashSet, LinkedHashSet is not thread safe, so access by multiple threads must be synchronized by an external mechanism such as Collections#synchronizedSet(Set).</para><para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/LinkedHashSet
		/// </java-name>
		[Dot42.DexImport("java/util/LinkedHashSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/HashSet<TE;>;Ljava/util/Set<TE;>;Ljava/lang/Clon" +
    "eable;Ljava/io/Serializable;")]
		public partial class LinkedHashSet<E> : global::Java.Util.HashSet<E>, global::Java.Util.ISet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty instance of <c> LinkedHashSet </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedHashSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> LinkedHashSet </c> with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedHashSet(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> LinkedHashSet </c> with the specified capacity and load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public LinkedHashSet(int capacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> LinkedHashSet </c> with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedHashSet(global::Java.Util.ICollection<E> capacity) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("java/util/Set", "add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				[Dot42.DexImport("java/util/Set", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>A <c> MissingFormatWidthException </c> will be thrown if the format width is missing but is required.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/MissingFormatWidthException
		/// </java-name>
		[Dot42.DexImport("java/util/MissingFormatWidthException", AccessFlags = 33)]
		public partial class MissingFormatWidthException : global::Java.Util.IllegalFormatException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> MissingFormatWidthException </c> with the specified format specifier.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingFormatWidthException(string s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the format specifier associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format specifier associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getFormatSpecifier
				/// </java-name>
				[Dot42.DexImport("getFormatSpecifier", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFormatSpecifier() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Returns the format specifier associated with the exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format specifier associated with the exception. </para>
				/// </returns>
				/// <java-name>
				/// getFormatSpecifier
				/// </java-name>
				public string FormatSpecifier
				{
				[Dot42.DexImport("getFormatSpecifier", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFormatSpecifier(); }
				}

		}

		/// <summary>
		/// <para>Hashtable is a synchronized implementation of Map. All optional operations are supported.</para><para>Neither keys nor values can be null. (Use <c> HashMap </c> or <c> LinkedHashMap </c> if you need null keys or values.)</para><para><para>HashMap </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Hashtable
		/// </java-name>
		[Dot42.DexImport("java/util/Hashtable", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/Dictionary<TK;TV;>;Ljava/uti" +
    "l/Map<TK;TV;>;Ljava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class Hashtable<K, V> : global::Java.Util.Dictionary<K, V>, global::Java.Util.IMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> Hashtable </c> using the default capacity and load factor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Hashtable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Hashtable </c> using the specified capacity and the default load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Hashtable(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Hashtable </c> using the specified capacity and load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public Hashtable(int capacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Hashtable </c> using the specified capacity and the default load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public Hashtable(global::Java.Util.IMap<K, V> capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> Hashtable </c> with the same key/value pairs, capacity and load factor.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> Hashtable </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 33)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns true if this <c> Hashtable </c> has no key/value pairs.</para><para><para>#size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Hashtable </c> has no key/value pairs, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 33)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of key/value pairs in this <c> Hashtable </c> .</para><para><para>elements </para><simplesectsep></simplesectsep><para>keys </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of key/value pairs in this <c> Hashtable </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 33)]
				public override int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value associated with the specified key in this <c> Hashtable </c> .</para><para><para>put </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value associated with the specified key, or <c> null </c> if the specified key does not exist. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Returns true if this <c> Hashtable </c> contains the specified object as a key of one of the key/value pairs.</para><para><para>contains </para><simplesectsep></simplesectsep><para>java.lang.Object::equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is a key in this <c> Hashtable </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool ContainsKey(object key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Searches this <c> Hashtable </c> for the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> value </c> is a value of this <c> Hashtable </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public virtual bool ContainsValue(object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this <c> Hashtable </c> contains the specified object as the value of at least one of the key/value pairs.</para><para><para>containsKey </para><simplesectsep></simplesectsep><para>java.lang.Object::equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is a value in this <c> Hashtable </c> , <c> false </c> otherwise. </para>
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
				/// <para>Associate the specified value with the specified key in this <c> Hashtable </c> . If the key already exists, the old value is replaced. The key and value cannot be null.</para><para><para>elements </para><simplesectsep></simplesectsep><para>get </para><simplesectsep></simplesectsep><para>keys </para><simplesectsep></simplesectsep><para>java.lang.Object::equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the old value associated with the specified key, or <c> null </c> if the key did not exist. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(TK;TV;)TV;")]
				public override V Put(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Copies every mapping to this <c> Hashtable </c> from the specified map.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public virtual void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Increases the capacity of this <c> Hashtable </c> . This method is called when the size of this <c> Hashtable </c> exceeds the load factor. </para>        
				/// </summary>
				/// <java-name>
				/// rehash
				/// </java-name>
				[Dot42.DexImport("rehash", "()V", AccessFlags = 4)]
				protected internal virtual void Rehash() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the key/value pair with the specified key from this <c> Hashtable </c> .</para><para><para>get </para><simplesectsep></simplesectsep><para>put </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value associated with the specified key, or <c> null </c> if the specified key did not exist. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Remove(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>Removes all key/value pairs from this <c> Hashtable </c> , leaving the size zero and the capacity unchanged.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>#size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a set of the keys contained in this <c> Hashtable </c> . The set is backed by this <c> Hashtable </c> so changes to one are reflected by the other. The set does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<TK;>;")]
				public virtual global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para>Returns a collection of the values contained in this <c> Hashtable </c> . The collection is backed by this <c> Hashtable </c> so changes to one are reflected by the other. The collection does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values. </para>
				/// </returns>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 33, Signature = "()Ljava/util/Collection<TV;>;")]
				public virtual global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<V>);
				}

				/// <summary>
				/// <para>Returns a set of the mappings contained in this <c> Hashtable </c> . Each element in the set is a Map.Entry. The set is backed by this <c> Hashtable </c> so changes to one are reflected by the other. The set does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings. </para>
				/// </returns>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public virtual global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <summary>
				/// <para>Returns an enumeration on the keys of this <c> Hashtable </c> instance. The results of the enumeration may be affected if the contents of this <c> Hashtable </c> are modified.</para><para><para>elements </para><simplesectsep></simplesectsep><para>#size </para><simplesectsep></simplesectsep><para>Enumeration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enumeration of the keys of this <c> Hashtable </c> . </para>
				/// </returns>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<TK;>;")]
				public override global::Java.Util.IEnumeration<K> Keys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<K>);
				}

				/// <summary>
				/// <para>Returns an enumeration on the values of this <c> Hashtable </c> . The results of the Enumeration may be affected if the contents of this <c> Hashtable </c> are modified.</para><para><para>keys </para><simplesectsep></simplesectsep><para>#size </para><simplesectsep></simplesectsep><para>Enumeration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enumeration of the values of this <c> Hashtable </c> . </para>
				/// </returns>
				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<TV;>;")]
				public override global::Java.Util.IEnumeration<V> Elements() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<V>);
				}

				/// <summary>
				/// <para>Compares this <c> Hashtable </c> with the specified object and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of Map and contain the same key/value pairs.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this Map, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 33)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. <c> Object </c> s which are equal return the same value for this method.</para><para><para>equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the string representation of this <c> Hashtable </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this <c> Hashtable </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 33)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>A base class for <c> Map </c> implementations.</para><para>Subclasses that permit new mappings to be added must override put.</para><para>The default implementations of many methods are inefficient for large maps. For example in the default implementation, each call to get performs a linear iteration of the entry set. Subclasses should override such methods to improve their performance.</para><para><para>1.2 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para><para>Removes all elements from this <c> Map </c> , leaving it empty.</para><para><para>isEmpty() </para><simplesectsep></simplesectsep><para>size()</para></para></para><para>This implementation calls <c> entrySet().clear() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Returns whether this <c> Map </c> contains the specified key.</para><para></para></para><para>This implementation iterates its key set, looking for a key that <c> key </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified key, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool ContainsKey(object key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Returns whether this <c> Map </c> contains the specified value.</para><para></para></para><para>This implementation iterates its entry set, looking for an entry with a value that <c> value </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified value, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool ContainsValue(object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a <c> Set </c> containing all of the mappings in this <c> Map </c> . Each mapping is an instance of Map.Entry. As the <c> Set </c> is backed by this <c> Map </c> , changes in one will be reflected in the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings </para>
				/// </returns>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				public virtual global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>>);
				}

				/// <summary>
				/// <para><para>Compares the argument to the receiver, and returns <c> true </c> if the specified object is a <c> Map </c> and both <c> Map </c> s contain the same mappings.</para><para><para>hashCode() </para><simplesectsep></simplesectsep><para>entrySet()</para></para></para><para>This implementation first checks the structure of <c> object </c> . If it is not a map or of a different size, this returns false. Otherwise it iterates its own entry set, looking up each entry's key in <c>       object </c> . If any value does not equal the other map's value for the same key, this returns false. Otherwise it returns true. </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean <c> true </c> if the <c> Object </c> is the same as this <c> Object </c> <c> false </c> if it is different from this <c> Object </c> . </para>
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
				/// <para><para>Returns the value of the mapping with the specified key.</para><para></para></para><para>This implementation iterates its entry set, looking for an entry with a key that <c> key </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found.</para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public virtual V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para><para>Returns an integer hash code for the receiver. <c> Object </c> s which are equal return the same value for this method.</para><para><para>equals(Object)</para></para></para><para>This implementation iterates its entry set, summing the hashcodes of its entries. </para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><para>Returns whether this map is empty.</para><para><para>size()</para></para></para><para>This implementation compares <c> size() </c> to 0. </para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Returns a set of the keys contained in this <c> Map </c> . The <c> Set </c> is backed by this <c> Map </c> so changes to one are reflected by the other. The <c> Set </c> does not support adding.</para><para></para></para><para>This implementation returns a view that calls through this to map. Its iterator transforms this map's entry set iterator to return keys. </para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys.</para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public virtual global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para><para>Maps the specified key to the specified value.</para><para></para></para><para>This base implementation throws <c> UnsupportedOperationException </c> . </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no mapping. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;TV;)TV;")]
				public virtual V Put(K key, V value) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para><para>Copies every mapping in the specified <c> Map </c> to this <c> Map </c> .</para><para></para></para><para>This implementation iterates through <c> map </c> 's entry set, calling <c> put() </c> for each. </para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public virtual void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Removes a mapping with the specified key from this <c> Map </c> .</para><para></para></para><para>This implementation iterates its entry set, removing the entry with a key that <c> key </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping or <c> null </c> if no mapping for the specified key was found. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public virtual V Remove(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para><para>Returns the number of mappings in this <c> Map </c> .</para><para></para></para><para>This implementation returns its entry set's size. </para>        
				/// </summary>
				/// <returns>
				/// <para>the number of mappings in this <c> Map </c> .</para>
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
				/// <para>This implementation composes a string by iterating its entry set. If this map contains itself as a key or a value, the string "(this Map)" will appear in its place. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para><para>Returns a <c> Collection </c> of the values contained in this <c> Map </c> . The <c> Collection </c> is backed by this <c> Map </c> so changes to one are reflected by the other. The <c> Collection </c> supports Collection#remove, Collection#removeAll, Collection#retainAll, and Collection#clear operations, and it does not support Collection#add or Collection#addAll operations. </para><para>This method returns a <c> Collection </c> which is the subclass of AbstractCollection. The AbstractCollection#iterator method of this subclass returns a "wrapper object" over the iterator of this <c> Map </c> 's entrySet(). The AbstractCollection#size method wraps this <c> Map </c> 's size method and the AbstractCollection#contains method wraps this <c> Map </c> 's containsValue method. </para><para>The collection is created when this method is called at first time and returned in response to all subsequent calls. This method may return different Collection when multiple calls to this method, since it has no synchronization performed.</para><para></para></para><para>This implementation returns a view that calls through this to map. Its iterator transforms this map's entry set iterator to return values. </para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values contained in this map.</para>
				/// </returns>
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
						/// getKey
						/// </java-name>
						[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
						public virtual K GetKey() /* MethodBuilder.Create */ 
						{
								return default(K);
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
						public virtual V GetValue() /* MethodBuilder.Create */ 
						{
								return default(V);
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
						public K Key
						{
						[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
								get{ return GetKey(); }
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						public V Value
						{
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
								get{ return GetValue(); }
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
						/// getKey
						/// </java-name>
						[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
						public virtual K GetKey() /* MethodBuilder.Create */ 
						{
								return default(K);
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
						public virtual V GetValue() /* MethodBuilder.Create */ 
						{
								return default(V);
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
						public K Key
						{
						[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
								get{ return GetKey(); }
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						public V Value
						{
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TV;")]
								get{ return GetValue(); }
						}

				}

		}

		/// <summary>
		/// <para>LinkedList is an implementation of List, backed by a doubly-linked list. All optional operations including adding, removing, and replacing elements are supported.</para><para>All elements are permitted, including null.</para><para>This class is primarily useful if you need queue-like behavior. It may also be useful as a list if you expect your lists to contain zero or one element, but still require the ability to scale to slightly larger numbers of elements. In general, though, you should probably use ArrayList if you don't need the queue-like behavior.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/LinkedList
		/// </java-name>
		[Dot42.DexImport("java/util/LinkedList", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSequentialList<TE;>;Ljava/util/List<TE;>" +
    ";Ljava/util/Deque<TE;>;Ljava/util/Queue<TE;>;Ljava/lang/Cloneable;Ljava/io/Seria" +
    "lizable;")]
		public partial class LinkedList<E> : global::Java.Util.AbstractSequentialList<E>, global::Java.Util.IList<E>, global::Java.Util.IDeque<E>, global::Java.Util.IQueue<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty instance of <c> LinkedList </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> LinkedList </c> that holds all of the elements contained in the specified <c> collection </c> . The order of the elements in this new <c> LinkedList </c> will be determined by the iteration order of <c> collection </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public LinkedList(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified object into this <c> LinkedList </c> at the specified location. The object is inserted before any previous element at the specified location. If the location is equal to the size of this <c> LinkedList </c> , the object is added at the end.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public override void Add(int location, E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object at the end of this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>always true </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inserts the objects in the specified collection at the specified location in this <c> LinkedList </c> . The objects are added in the order they are returned from the collection's iterator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> LinkedList </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(ILjava/util/Collection;)Z", AccessFlags = 1, Signature = "(ILjava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(int location, global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the objects in the specified Collection to this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> LinkedList </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the specified object at the beginning of this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addFirst
				/// </java-name>
				[Dot42.DexImport("addFirst", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddFirst(E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object at the end of this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addLast
				/// </java-name>
				[Dot42.DexImport("addLast", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void AddLast(E @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all elements from this <c> LinkedList </c> , leaving it empty.</para><para><para>List::isEmpty </para><simplesectsep></simplesectsep><para>#size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> LinkedList </c> with the same elements and size as this <c> LinkedList </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> LinkedList </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Searches this <c> LinkedList </c> for the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is an element of this <c> LinkedList </c> , <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the element at the specified location in this list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Get(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the first element in this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first element. </para>
				/// </returns>
				/// <java-name>
				/// getFirst
				/// </java-name>
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E GetFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the last element in this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last element </para>
				/// </returns>
				/// <java-name>
				/// getLast
				/// </java-name>
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E GetLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Searches this <c> List </c> for the specified object and returns the index of the first occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the first occurrence of the object or -1 if the object was not found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int IndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches this <c> LinkedList </c> for the specified object and returns the index of the last occurrence.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the last occurrence of the object, or -1 if it was not found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public override int LastIndexOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a ListIterator on the elements of this <c> LinkedList </c> . The elements are iterated in the same order that they occur in the <c> LinkedList </c> . The iteration starts at the specified location.</para><para><para>ListIterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a ListIterator on the elements of this <c> LinkedList </c> </para>
				/// </returns>
				/// <java-name>
				/// listIterator
				/// </java-name>
				[Dot42.DexImport("listIterator", "(I)Ljava/util/ListIterator;", AccessFlags = 1, Signature = "(I)Ljava/util/ListIterator<TE;>;")]
				public override global::Java.Util.IListIterator<E> ListIterator(int location) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IListIterator<E>);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public override E Remove(int location) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Removes the object at the specified location from this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object location) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes the first object from this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// removeFirst
				/// </java-name>
				[Dot42.DexImport("removeFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E RemoveFirst() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Removes the last object from this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed object. </para>
				/// </returns>
				/// <java-name>
				/// removeLast
				/// </java-name>
				[Dot42.DexImport("removeLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E RemoveLast() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para><para>Returns an iterator over the elements in this deque in reverse sequential order. The elements will be returned in order from last (tail) to first (head).</para><para></para></para><para><para>java.util.Deque::descendingIterator() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator over the elements in this deque in reverse sequence</para>
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
				/// <para><para>Inserts the specified element at the front of this deque unless it would violate capacity restrictions. When using a capacity-restricted deque, this method is generally preferable to the addFirst method, which can fail to insert an element only by throwing an exception.</para><para></para></para><para><para>java.util.Deque::offerFirst(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the element was added to this deque, else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// offerFirst
				/// </java-name>
				[Dot42.DexImport("offerFirst", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferFirst(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Inserts the specified element at the end of this deque unless it would violate capacity restrictions. When using a capacity-restricted deque, this method is generally preferable to the addLast method, which can fail to insert an element only by throwing an exception.</para><para></para></para><para><para>java.util.Deque::offerLast(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the element was added to this deque, else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// offerLast
				/// </java-name>
				[Dot42.DexImport("offerLast", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool OfferLast(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Retrieves, but does not remove, the first element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para></para><para><para>java.util.Deque::peekFirst() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque, or <code>null</code> if this deque is empty</para>
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
				/// <para><para>Retrieves, but does not remove, the last element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para></para><para><para>java.util.Deque::peekLast() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque, or <code>null</code> if this deque is empty</para>
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
				/// <para><para>Retrieves and removes the first element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para></para><para><para>java.util.Deque::pollFirst() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this deque, or <code>null</code> if this deque is empty</para>
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
				/// <para><para>Retrieves and removes the last element of this deque, or returns <code>null</code> if this deque is empty.</para><para></para></para><para><para>java.util.Deque::pollLast() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tail of this deque, or <code>null</code> if this deque is empty</para>
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
				/// <para><para>Pops an element from the stack represented by this deque. In other words, removes and returns the first element of this deque.</para><para>This method is equivalent to removeFirst().</para><para></para></para><para><para>java.util.Deque::pop() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the element at the front of this deque (which is the top of the stack represented by this deque) </para>
				/// </returns>
				/// <java-name>
				/// pop
				/// </java-name>
				[Dot42.DexImport("pop", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Pop() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para><para>Pushes an element onto the stack represented by this deque (in other words, at the head of this deque) if it is possible to do so immediately without violating capacity restrictions, returning <code>true</code> upon success and throwing an <code>IllegalStateException</code> if no space is currently available.</para><para>This method is equivalent to addFirst.</para><para></para></para><para><para>java.util.Deque::push(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void Push(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Removes the first occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the first element <code>e</code> such that <code>(o==null ? e==null : o.equals(e))</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para></para></para><para><para>java.util.Deque::removeFirstOccurrence(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if an element was removed as a result of this call </para>
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
				/// <para><para>Removes the last occurrence of the specified element from this deque. If the deque does not contain the element, it is unchanged. More formally, removes the last element <code>e</code> such that <code>(o==null ? e==null : o.equals(e))</code> (if such an element exists). Returns <code>true</code> if this deque contained the specified element (or equivalently, if this deque changed as a result of the call).</para><para></para></para><para><para>java.util.Deque::removeLastOccurrence(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if an element was removed as a result of this call </para>
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
				/// <para>Replaces the element at the specified location in this <c> LinkedList </c> with the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous element at the index. </para>
				/// </returns>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public override E Set(int location, E @object) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns the number of elements in this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this <c> LinkedList </c> . </para>
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
				/// <para>Inserts the specified element into the queue represented by this deque (in other words, at the tail of this deque) if it is possible to do so immediately without violating capacity restrictions, returning <code>true</code> upon success and <code>false</code> if no space is currently available. When using a capacity-restricted deque, this method is generally preferable to the add method, which can fail to insert an element only by throwing an exception.</para><para>This method is equivalent to offerLast.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the element was added to this deque, else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// offer
				/// </java-name>
				[Dot42.DexImport("offer", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Offer(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque), or returns <code>null</code> if this deque is empty.</para><para>This method is equivalent to pollFirst().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first element of this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// poll
				/// </java-name>
				[Dot42.DexImport("poll", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Poll() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves and removes the head of the queue represented by this deque (in other words, the first element of this deque). This method differs from poll only in that it throws an exception if this deque is empty.</para><para>This method is equivalent to removeFirst().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves, but does not remove, the head of the queue represented by this deque (in other words, the first element of this deque), or returns <code>null</code> if this deque is empty.</para><para>This method is equivalent to peekFirst().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque, or <code>null</code> if this deque is empty </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Peek() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves, but does not remove, the head of the queue represented by this deque (in other words, the first element of this deque). This method differs from peek only in that it throws an exception if this deque is empty.</para><para>This method is equivalent to getFirst().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of the queue represented by this deque </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Returns a new array containing all elements contained in this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> LinkedList </c> . </para>
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
				/// <para>Returns an array containing all elements contained in this <c> LinkedList </c> . If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this <c> LinkedList </c> , the array element following the collection elements is set to null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> LinkedList </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				public override T[] ToArray<T>(T[] contents) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("java/util/List", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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
				public override global::Java.Util.IList<E> SubList(int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<E>);
				}

				/// <summary>
				/// <para>Returns the first element in this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first element. </para>
				/// </returns>
				/// <java-name>
				/// getFirst
				/// </java-name>
				public E First
				{
				[Dot42.DexImport("getFirst", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return GetFirst(); }
				}

				/// <summary>
				/// <para>Returns the last element in this <c> LinkedList </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last element </para>
				/// </returns>
				/// <java-name>
				/// getLast
				/// </java-name>
				public E Last
				{
				[Dot42.DexImport("getLast", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
						get{ return GetLast(); }
				}

		}

		/// <summary>
		/// <para>An <c> EmptyStackException </c> is thrown if the pop/peek method of a stack is executed on an empty stack.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/EmptyStackException
		/// </java-name>
		[Dot42.DexImport("java/util/EmptyStackException", AccessFlags = 33)]
		public partial class EmptyStackException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> EmptyStackException </c> with the stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EmptyStackException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Class <c> AbstractCollection </c> is an abstract implementation of the <c>   Collection </c> interface. A subclass must implement the abstract methods <c>   iterator() </c> and <c> size() </c> to create an immutable collection. To create a modifiable collection it's necessary to override the <c> add() </c> method that currently throws an <c> UnsupportedOperationException </c> .</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/AbstractCollection
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractCollection", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
		public abstract partial class AbstractCollection<E> : global::Java.Util.ICollection<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of this AbstractCollection. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractCollection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to add <c> object </c> to the contents of this <c> Collection </c> (optional).</para><para>After this method finishes successfully it is guaranteed that the object is contained in the collection.</para><para>If the collection was modified it returns <c> true </c> , <c> false </c> if no changes were made.</para><para>An implementation of <c> Collection </c> may narrow the set of accepted objects, but it has to specify this in the documentation. If the object to be added does not meet this restriction, then an <c> IllegalArgumentException </c> is thrown.</para><para>If a collection does not yet contain an object that is to be added and adding the object fails, this method <b>must</b> throw an appropriate unchecked Exception. Returning false is not permitted in this case because it would violate the postcondition that the element will be part of the collection after this method finishes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to add all of the objects contained in <c> collection </c> to the contents of this <c> Collection </c> (optional). This implementation iterates over the given <c> Collection </c> and calls <c> add </c> for each element. If any of these calls return <c> true </c> , then <c> true </c> is returned as result of this method call, <c> false </c> otherwise. If this <c> Collection </c> does not support adding elements, an <c>       UnsupportedOperationException </c> is thrown. </para><para>If the passed <c> Collection </c> is changed during the process of adding elements to this <c> Collection </c> , the behavior depends on the behavior of the passed <c> Collection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public virtual bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all elements from this <c> Collection </c> , leaving it empty (optional). This implementation iterates over this <c> Collection </c> and calls the <c>       remove </c> method on each element. If the iterator does not support removal of elements, an <c> UnsupportedOperationException </c> is thrown. </para><para>Concrete implementations usually can clear a <c> Collection </c> more efficiently and should therefore overwrite this method.</para><para><para>iterator </para><simplesectsep></simplesectsep><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests whether this <c> Collection </c> contains the specified object. This implementation iterates over this <c> Collection </c> and tests, whether any element is equal to the given object. If <c> object != null </c> then <c> object.equals(e) </c> is called for each element <c> e </c> returned by the iterator until the element is found. If <c> object == null </c> then each element <c> e </c> returned by the iterator is compared with the test <c> e == null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is an element of this <c> Collection </c> , <c>               false </c> otherwise. </para>
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
				/// <para>Tests whether this <c> Collection </c> contains all objects contained in the specified <c> Collection </c> . This implementation iterates over the specified <c> Collection </c> . If one element returned by the iterator is not contained in this <c> Collection </c> , then <c> false </c> is returned; <c> true </c> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if all objects in the specified <c> Collection </c> are elements of this <c> Collection </c> , <c> false </c> otherwise. </para>
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
				/// <para>Returns if this <c> Collection </c> contains no elements. This implementation tests, whether <c> size </c> returns 0.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> has no elements, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an instance of Iterator that may be used to access the objects contained by this <c> Collection </c> . The order in which the elements are returned by the Iterator is not defined unless the instance of the <c> Collection </c> has a defined order. In that case, the elements are returned in that order. </para><para>In this class this method is declared abstract and has to be implemented by concrete <c> Collection </c> implementations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator for accessing the <c> Collection </c> contents. </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				public virtual global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<E>);
				}

				/// <summary>
				/// <para>Removes one instance of the specified object from this <c> Collection </c> if one is contained (optional). This implementation iterates over this <c> Collection </c> and tests for each element <c> e </c> returned by the iterator, whether <c> e </c> is equal to the given object. If <c> object != null </c> then this test is performed using <c> object.equals(e) </c> , otherwise using <c> object == null </c> . If an element equal to the given object is found, then the <c> remove </c> method is called on the iterator and <c> true </c> is returned, <c> false </c> otherwise. If the iterator does not support removing elements, an <c> UnsupportedOperationException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all occurrences in this <c> Collection </c> of each object in the specified <c> Collection </c> (optional). After this method returns none of the elements in the passed <c> Collection </c> can be found in this <c> Collection </c> anymore. </para><para>This implementation iterates over this <c> Collection </c> and tests for each element <c> e </c> returned by the iterator, whether it is contained in the specified <c> Collection </c> . If this test is positive, then the <c>       remove </c> method is called on the iterator. If the iterator does not support removing elements, an <c> UnsupportedOperationException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all objects from this <c> Collection </c> that are not also found in the <c> Collection </c> passed (optional). After this method returns this <c> Collection </c> will only contain elements that also can be found in the <c> Collection </c> passed to this method. </para><para>This implementation iterates over this <c> Collection </c> and tests for each element <c> e </c> returned by the iterator, whether it is contained in the specified <c> Collection </c> . If this test is negative, then the <c>       remove </c> method is called on the iterator. If the iterator does not support removing elements, an <c> UnsupportedOperationException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)Z")]
				public virtual bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a count of how many objects this <c> Collection </c> contains. </para><para>In this class this method is declared abstract and has to be implemented by concrete <c> Collection </c> implementations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>how many objects this <c> Collection </c> contains, or <c> Integer.MAX_VALUE </c> if there are more than <c> Integer.MAX_VALUE </c> elements in this <c> Collection </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a new array containing all elements contained in this <c> Collection </c> .</para><para>If the implementation has ordered elements it will return the element array in the same order as an iterator would return them.</para><para>The array returned does not reflect any changes of the <c> Collection </c> . A new array is created even if the underlying data structure is already an array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> Collection </c> . </para>
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
				/// <para>Returns an array containing all elements contained in this <c> Collection </c> . If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this <c> Collection </c> , the array element following the <c> Collection </c> elements is set to null.</para><para>If the implementation has ordered elements it will return the element array in the same order as an iterator would return them.</para><para><c> toArray(new Object[0]) </c> behaves exactly the same way as <c> toArray() </c> does.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> Collection </c> .</para>
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
				/// <para>Returns the string representation of this <c> Collection </c> . The presentation has a specific format. It is enclosed by square brackets ("[]"). Elements are separated by ', ' (comma and space).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this <c> Collection </c> . </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para><c> EventObject </c> s represent events. Typically applications subclass this class to add event specific information.</para><para><para>EventListener </para></para>    
		/// </summary>
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
				protected internal object Source;
				/// <summary>
				/// <para>Constructs a new instance of this class.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public EventObject(object source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the object which fired the event. </para>        
				/// </summary>
				/// <java-name>
				/// getSource
				/// </java-name>
				[Dot42.DexImport("getSource", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetSource() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the string representation of this <c> EventObject </c> . </para>        
				/// </summary>
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

		}

		/// <summary>
		/// <para>Observable is used to notify a group of Observer objects when a change occurs. On creation, the set of observers is empty. After a change occurred, the application can call the notifyObservers() method. This will cause the invocation of the <c> update() </c> method of all registered Observers. The order of invocation is not specified. This implementation will call the Observers in the order they registered. Subclasses are completely free in what order they call the update methods.</para><para><para>Observer </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Observable
		/// </java-name>
		[Dot42.DexImport("java/util/Observable", AccessFlags = 33)]
		public partial class Observable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> Observable </c> object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Observable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified observer to the list of observers. If it is already registered, it is not added a second time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addObserver
				/// </java-name>
				[Dot42.DexImport("addObserver", "(Ljava/util/Observer;)V", AccessFlags = 1)]
				public virtual void AddObserver(global::Java.Util.IObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the changed flag for this <c> Observable </c> . After calling <c> clearChanged() </c> , <c> hasChanged() </c> will return <c> false </c> . </para>        
				/// </summary>
				/// <java-name>
				/// clearChanged
				/// </java-name>
				[Dot42.DexImport("clearChanged", "()V", AccessFlags = 4)]
				protected internal virtual void ClearChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of observers registered to this <c> Observable </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of observers. </para>
				/// </returns>
				/// <java-name>
				/// countObservers
				/// </java-name>
				[Dot42.DexImport("countObservers", "()I", AccessFlags = 1)]
				public virtual int CountObservers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Removes the specified observer from the list of observers. Passing null won't do anything.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// deleteObserver
				/// </java-name>
				[Dot42.DexImport("deleteObserver", "(Ljava/util/Observer;)V", AccessFlags = 33)]
				public virtual void DeleteObserver(global::Java.Util.IObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all observers from the list of observers. </para>        
				/// </summary>
				/// <java-name>
				/// deleteObservers
				/// </java-name>
				[Dot42.DexImport("deleteObservers", "()V", AccessFlags = 33)]
				public virtual void DeleteObservers() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the changed flag for this <c> Observable </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> when the changed flag for this <c> Observable </c> is set, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasChanged
				/// </java-name>
				[Dot42.DexImport("hasChanged", "()Z", AccessFlags = 1)]
				public virtual bool HasChanged() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If <c> hasChanged() </c> returns <c> true </c> , calls the <c> update() </c> method for every observer in the list of observers using null as the argument. Afterwards, calls <c> clearChanged() </c> . </para><para>Equivalent to calling <c> notifyObservers(null) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// notifyObservers
				/// </java-name>
				[Dot42.DexImport("notifyObservers", "()V", AccessFlags = 1)]
				public virtual void NotifyObservers() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If <c> hasChanged() </c> returns <c> true </c> , calls the <c> update() </c> method for every Observer in the list of observers using the specified argument. Afterwards calls <c> clearChanged() </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// notifyObservers
				/// </java-name>
				[Dot42.DexImport("notifyObservers", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void NotifyObservers(object data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the changed flag for this <c> Observable </c> . After calling <c> setChanged() </c> , <c> hasChanged() </c> will return <c> true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setChanged
				/// </java-name>
				[Dot42.DexImport("setChanged", "()V", AccessFlags = 4)]
				protected internal virtual void SetChanged() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A parser that parses a text string of primitive types and strings with the help of regular expressions. It supports localized numbers and various radixes. The input is broken into tokens by the delimiter pattern, which is whitespace by default. The primitive types can be obtained via corresponding next* methods. If the token is not in a valid format, an <c> InputMismatchException </c> is thrown. </para><para>For example: <pre>
		///    Scanner s = new Scanner("1A true");
		///    System.out.println(s.nextInt(16));
		///    System.out.println(s.nextBoolean());
		///    </pre> </para><para>Yields the result: <c> 26 true </c> </para><para>A <c> Scanner </c> can also find or skip specific patterns without regard for the delimiter. All these methods and the various next* and hasNext* methods may block. </para><para>The <c> Scanner </c> class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Scanner
		/// </java-name>
		[Dot42.DexImport("java/util/Scanner", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/util/Iterator<Ljava/lang/String;>;")]
		public sealed partial class Scanner : global::Java.Util.IIterator<string>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a <c> Scanner </c> with the specified <c> File </c> as input. The default charset is applied when reading the file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.File src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Scanner </c> with the specified <c> File </c> as input. The default charset is applied when reading the file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(string src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Scanner </c> with the specified <c> File </c> as input. The default charset is applied when reading the file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.InputStream src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Scanner </c> with the specified <c> File </c> as input. The default charset is applied when reading the file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Readable;)V", AccessFlags = 1)]
				public Scanner(global::Java.Lang.IReadable src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> Scanner </c> with the specified <c> File </c> as input. The default charset is applied when reading the file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/nio/channels/ReadableByteChannel;)V", AccessFlags = 1)]
				public Scanner(global::Java.Nio.Channels.IReadableByteChannel src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V", AccessFlags = 1)]
				public Scanner(global::Java.Nio.Channels.IReadableByteChannel readableByteChannel, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes this <c> Scanner </c> and the underlying input if the input implements <c> Closeable </c> . If the <c> Scanner </c> has been closed, this method will have no effect. Any scanning operation called after calling this method will throw an <c> IllegalStateException </c> .</para><para><para>Closeable </para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the delimiter <c> Pattern </c> in use by this <c> Scanner </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the delimiter <c> Pattern </c> in use by this <c> Scanner </c> . </para>
				/// </returns>
				/// <java-name>
				/// delimiter
				/// </java-name>
				[Dot42.DexImport("delimiter", "()Ljava/util/regex/Pattern;", AccessFlags = 1)]
				public global::Java.Util.Regex.Pattern Delimiter() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <summary>
				/// <para>Tries to find the pattern in the input. Delimiters are ignored. If the pattern is found before line terminator, the matched string will be returned, and the <c> Scanner </c> will advance to the end of the matched string. Otherwise, <c> null </c> will be returned and the <c> Scanner </c> will not advance. When waiting for input, the <c> Scanner </c> may be blocked. All the input may be cached if no line terminator exists in the buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the matched string or <c> null </c> if the pattern is not found before the next line terminator. </para>
				/// </returns>
				/// <java-name>
				/// findInLine
				/// </java-name>
				[Dot42.DexImport("findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", AccessFlags = 1)]
				public string FindInLine(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tries to find the pattern in the input. Delimiters are ignored. If the pattern is found before line terminator, the matched string will be returned, and the <c> Scanner </c> will advance to the end of the matched string. Otherwise, <c> null </c> will be returned and the <c> Scanner </c> will not advance. When waiting for input, the <c> Scanner </c> may be blocked. All the input may be cached if no line terminator exists in the buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the matched string or <c> null </c> if the pattern is not found before the next line terminator. </para>
				/// </returns>
				/// <java-name>
				/// findInLine
				/// </java-name>
				[Dot42.DexImport("findInLine", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string FindInLine(string pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tries to find the pattern in the input between the current position and the specified horizon. Delimiters are ignored. If the pattern is found, the matched string will be returned, and the <c> Scanner </c> will advance to the end of the matched string. Otherwise, null will be returned and <c> Scanner </c> will not advance. When waiting for input, the <c> Scanner </c> may be blocked. </para><para>The <c> Scanner </c> 's search will never go more than <c> horizon </c> code points from current position. The position of <c> horizon </c> does have an effect on the result of the match. For example, when the input is "123" and current position is at zero, <code>findWithinHorizon(Pattern.compile("\\p{Digit}{3}"), 2)</code> will return <c> null </c> , while <code>findWithinHorizon(Pattern.compile("\\p{Digit}{3}"), 3)</code> will return <c> "123" </c> . <c> horizon </c> is treated as a transparent, non-anchoring bound. (refer to Matcher#useTransparentBounds(boolean) and Matcher#useAnchoringBounds(boolean)) </para><para>A <c> horizon </c> whose value is zero will be ignored and the whole input will be used for search. In this situation, all the input may be cached.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the matched string or <c> null </c> if the pattern is not found within the specified <c> horizon </c> . </para>
				/// </returns>
				/// <java-name>
				/// findWithinHorizon
				/// </java-name>
				[Dot42.DexImport("findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;", AccessFlags = 1)]
				public string FindWithinHorizon(global::Java.Util.Regex.Pattern pattern, int horizon) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tries to find the pattern in the input between the current position and the specified horizon. Delimiters are ignored. If the pattern is found, the matched string will be returned, and the <c> Scanner </c> will advance to the end of the matched string. Otherwise, null will be returned and <c> Scanner </c> will not advance. When waiting for input, the <c> Scanner </c> may be blocked. </para><para>The <c> Scanner </c> 's search will never go more than <c> horizon </c> code points from current position. The position of <c> horizon </c> does have an effect on the result of the match. For example, when the input is "123" and current position is at zero, <code>findWithinHorizon(Pattern.compile("\\p{Digit}{3}"), 2)</code> will return <c> null </c> , while <code>findWithinHorizon(Pattern.compile("\\p{Digit}{3}"), 3)</code> will return <c> "123" </c> . <c> horizon </c> is treated as a transparent, non-anchoring bound. (refer to Matcher#useTransparentBounds(boolean) and Matcher#useAnchoringBounds(boolean)) </para><para>A <c> horizon </c> whose value is zero will be ignored and the whole input will be used for search. In this situation, all the input may be cached.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the matched string or <c> null </c> if the pattern is not found within the specified <c> horizon </c> . </para>
				/// </returns>
				/// <java-name>
				/// findWithinHorizon
				/// </java-name>
				[Dot42.DexImport("findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 1)]
				public string FindWithinHorizon(string pattern, int horizon) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns whether this <c> Scanner </c> has one or more tokens remaining to parse. This method will block if the data is still being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Scanner </c> has one or more tokens remaining, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this <c> Scanner </c> has one or more tokens remaining to parse and the next token matches the given pattern. This method will block if the data is still being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Scanner </c> has more tokens and the next token matches the pattern, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "(Ljava/util/regex/Pattern;)Z", AccessFlags = 1)]
				public bool HasNext(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this <c> Scanner </c> has one or more tokens remaining to parse and the next token matches the given pattern. This method will block if the data is still being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Scanner </c> has more tokens and the next token matches the pattern, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool HasNext(string pattern) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> BigDecimal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> BigDecimal </c> , otherwise <c> false. </c> </para>
				/// </returns>
				/// <java-name>
				/// hasNextBigDecimal
				/// </java-name>
				[Dot42.DexImport("hasNextBigDecimal", "()Z", AccessFlags = 1)]
				public bool HasNextBigDecimal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> BigInteger </c> in the default radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> BigInteger </c> , otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextBigInteger
				/// </java-name>
				[Dot42.DexImport("hasNextBigInteger", "()Z", AccessFlags = 1)]
				public bool HasNextBigInteger() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> BigInteger </c> in the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> BigInteger </c> , otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextBigInteger
				/// </java-name>
				[Dot42.DexImport("hasNextBigInteger", "(I)Z", AccessFlags = 1)]
				public bool HasNextBigInteger(int radix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> boolean </c> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> boolean </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextBoolean
				/// </java-name>
				[Dot42.DexImport("hasNextBoolean", "()Z", AccessFlags = 1)]
				public bool HasNextBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> byte </c> value in the default radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> byte </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextByte
				/// </java-name>
				[Dot42.DexImport("hasNextByte", "()Z", AccessFlags = 1)]
				public bool HasNextByte() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> byte </c> value in the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> byte </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextByte
				/// </java-name>
				[Dot42.DexImport("hasNextByte", "(I)Z", AccessFlags = 1)]
				public bool HasNextByte(int radix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token translated into a valid <c> double </c> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> double </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextDouble
				/// </java-name>
				[Dot42.DexImport("hasNextDouble", "()Z", AccessFlags = 1)]
				public bool HasNextDouble() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> float </c> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> float </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextFloat
				/// </java-name>
				[Dot42.DexImport("hasNextFloat", "()Z", AccessFlags = 1)]
				public bool HasNextFloat() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> int </c> value in the default radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> int </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextInt
				/// </java-name>
				[Dot42.DexImport("hasNextInt", "()Z", AccessFlags = 1)]
				public bool HasNextInt() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> int </c> value in the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token in this <c> Scanner </c> 's input can be translated into a valid <c> int </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextInt
				/// </java-name>
				[Dot42.DexImport("hasNextInt", "(I)Z", AccessFlags = 1)]
				public bool HasNextInt(int radix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether there is a line terminator in the input. This method may block.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there is a line terminator in the input, otherwise, <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextLine
				/// </java-name>
				[Dot42.DexImport("hasNextLine", "()Z", AccessFlags = 1)]
				public bool HasNextLine() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> long </c> value in the default radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> long </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextLong
				/// </java-name>
				[Dot42.DexImport("hasNextLong", "()Z", AccessFlags = 1)]
				public bool HasNextLong() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> long </c> value in the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> long </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextLong
				/// </java-name>
				[Dot42.DexImport("hasNextLong", "(I)Z", AccessFlags = 1)]
				public bool HasNextLong(int radix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> short </c> value in the default radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> short </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextShort
				/// </java-name>
				[Dot42.DexImport("hasNextShort", "()Z", AccessFlags = 1)]
				public bool HasNextShort() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the next token can be translated into a valid <c> short </c> value in the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the next token can be translated into a valid <c> short </c> value, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasNextShort
				/// </java-name>
				[Dot42.DexImport("hasNextShort", "(I)Z", AccessFlags = 1)]
				public bool HasNextShort(int radix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the last <c> IOException </c> that was raised while reading from the underlying input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last thrown <c> IOException </c> , or <c> null </c> if none was thrown. </para>
				/// </returns>
				/// <java-name>
				/// ioException
				/// </java-name>
				[Dot42.DexImport("ioException", "()Ljava/io/IOException;", AccessFlags = 1)]
				public global::System.IO.IOException IoException() /* MethodBuilder.Create */ 
				{
						return default(global::System.IO.IOException);
				}

				/// <summary>
				/// <para>Return the <c> Locale </c> of this <c> Scanner </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Locale </c> of this <c> Scanner </c> . </para>
				/// </returns>
				/// <java-name>
				/// locale
				/// </java-name>
				[Dot42.DexImport("locale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public global::Java.Util.Locale Locale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <summary>
				/// <para>Returns the result of the last matching operation. </para><para>The next* and find* methods return the match result in the case of a successful match.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the match result of the last successful match operation </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "()Ljava/util/regex/MatchResult;", AccessFlags = 1)]
				public global::Java.Util.Regex.IMatchResult Match() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <summary>
				/// <para>Returns the next token. The token will be both prefixed and postfixed by the delimiter that is currently being used (or a string that matches the delimiter pattern). This method will block if input is being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next complete token. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/String;", AccessFlags = 1)]
				public string Next() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the next token if it matches the specified pattern. The token will be both prefixed and postfixed by the delimiter that is currently being used (or a string that matches the delimiter pattern). This method will block if input is being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", AccessFlags = 1)]
				public string Next(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the next token if it matches the specified pattern. The token will be both prefixed and postfixed by the delimiter that is currently being used (or a string that matches the delimiter pattern). This method will block if input is being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string Next(string pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> BigDecimal </c> . This method will block if input is being read. If the next token can be translated into a <c> BigDecimal </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting string is passed to <c> BigDecimal(String)  </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> BigDecimal </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextBigDecimal
				/// </java-name>
				[Dot42.DexImport("nextBigDecimal", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public global::Java.Math.BigDecimal NextBigDecimal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> BigInteger </c> . This method will block if input is being read. Equivalent to <c> nextBigInteger(DEFAULT_RADIX) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as <c> BigInteger </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextBigInteger
				/// </java-name>
				[Dot42.DexImport("nextBigInteger", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public global::Java.Math.BigInteger NextBigInteger() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> BigInteger </c> with the specified radix. This method will block if input is being read. If the next token can be translated into a <c> BigInteger </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to BigInteger#BigInteger(String, int)} with the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> BigInteger </c> </para>
				/// </returns>
				/// <java-name>
				/// nextBigInteger
				/// </java-name>
				[Dot42.DexImport("nextBigInteger", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public global::Java.Math.BigInteger NextBigInteger(int radix) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> boolean </c> . This method will block if input is being read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> boolean </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextBoolean
				/// </java-name>
				[Dot42.DexImport("nextBoolean", "()Z", AccessFlags = 1)]
				public bool NextBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> byte </c> . This method will block if input is being read. Equivalent to <c> nextByte(DEFAULT_RADIX) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> byte </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "()B", AccessFlags = 1)]
				public sbyte JavaNextByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> byte </c> . This method will block if input is being read. Equivalent to <c> nextByte(DEFAULT_RADIX) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> byte </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte NextByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> byte </c> with the specified radix. Will block if input is being read. If the next token can be translated into a <c> byte </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Byte#parseByte(String, int)} with the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> byte </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "(I)B", AccessFlags = 1)]
				public sbyte JavaNextByte(int radix) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> byte </c> with the specified radix. Will block if input is being read. If the next token can be translated into a <c> byte </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Byte#parseByte(String, int)} with the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> byte </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextByte
				/// </java-name>
				[Dot42.DexImport("nextByte", "(I)B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte NextByte(int radix) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> double </c> . This method will block if input is being read. If the next token can be translated into a <c> double </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Double#parseDouble(String)}. If the token matches the localized NaN or infinity strings, it is also passed to Double#parseDouble(String)}.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> double </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "()D", AccessFlags = 1)]
				public double NextDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> float </c> . This method will block if input is being read. If the next token can be translated into a <c> float </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Float#parseFloat(String)}.If the token matches the localized NaN or infinity strings, it is also passed to Float#parseFloat(String)}.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> float </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextFloat
				/// </java-name>
				[Dot42.DexImport("nextFloat", "()F", AccessFlags = 1)]
				public float NextFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the next token as an <c> int </c> . This method will block if input is being read. Equivalent to <c> nextInt(DEFAULT_RADIX) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as an <c> int </c> </para>
				/// </returns>
				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "()I", AccessFlags = 1)]
				public int NextInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the next token as an <c> int </c> with the specified radix. This method will block if input is being read. If the next token can be translated into an <c> int </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Integer#parseInt(String, int) with the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as an <c> int </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "(I)I", AccessFlags = 1)]
				public int NextInt(int radix) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the skipped input and advances the <c> Scanner </c> to the beginning of the next line. The returned result will exclude any line terminator. When searching, if no line terminator is found, then a large amount of input will be cached. If no line at all can be found, a <c> NoSuchElementException </c> will be thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the skipped line. </para>
				/// </returns>
				/// <java-name>
				/// nextLine
				/// </java-name>
				[Dot42.DexImport("nextLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public string NextLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> long </c> . This method will block if input is being read. Equivalent to <c> nextLong(DEFAULT_RADIX) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> long </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "()J", AccessFlags = 1)]
				public long NextLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> long </c> with the specified radix. This method will block if input is being read. If the next token can be translated into a <c> long </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Long#parseLong(String, int)} with the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> long </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "(I)J", AccessFlags = 1)]
				public long NextLong(int radix) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> short </c> . This method will block if input is being read. Equivalent to <c> nextShort(DEFAULT_RADIX) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> short </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextShort
				/// </java-name>
				[Dot42.DexImport("nextShort", "()S", AccessFlags = 1)]
				public short NextShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Returns the next token as a <c> short </c> with the specified radix. This method will block if input is being read. If the next token can be translated into a <c> short </c> the following is done: All <c> Locale </c> -specific prefixes, group separators, and <c> Locale </c> -specific suffixes are removed. Then non-ASCII digits are mapped into ASCII digits via Character#digit(char, int), and a negative sign (-) is added if the <c> Locale </c> -specific negative prefix or suffix was present. Finally the resulting String is passed to Short#parseShort(String, int)} with the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token as a <c> short </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextShort
				/// </java-name>
				[Dot42.DexImport("nextShort", "(I)S", AccessFlags = 1)]
				public short NextShort(int radix) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Return the radix of this <c> Scanner </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the radix of this <c> Scanner </c> </para>
				/// </returns>
				/// <java-name>
				/// radix
				/// </java-name>
				[Dot42.DexImport("radix", "()I", AccessFlags = 1)]
				public int Radix() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Tries to use specified pattern to match input starting from the current position. The delimiter will be ignored. If a match is found, the matched input will be skipped. If an anchored match of the specified pattern succeeds, the corresponding input will also be skipped. Otherwise, a <c> NoSuchElementException </c> will be thrown. Patterns that can match a lot of input may cause the <c> Scanner </c> to read in a large amount of input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Scanner </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner Skip(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <summary>
				/// <para>Tries to use specified pattern to match input starting from the current position. The delimiter will be ignored. If a match is found, the matched input will be skipped. If an anchored match of the specified pattern succeeds, the corresponding input will also be skipped. Otherwise, a <c> NoSuchElementException </c> will be thrown. Patterns that can match a lot of input may cause the <c> Scanner </c> to read in a large amount of input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Scanner </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(Ljava/lang/String;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner Skip(string pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <summary>
				/// <para>Returns a string representation of this <c> Scanner </c> . The information returned may be helpful for debugging. The format of the string is unspecified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representation of this <c> Scanner </c> . </para>
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
				/// <para>Sets the delimiting pattern of this <c> Scanner </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Scanner </c> . </para>
				/// </returns>
				/// <java-name>
				/// useDelimiter
				/// </java-name>
				[Dot42.DexImport("useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseDelimiter(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <summary>
				/// <para>Sets the delimiting pattern of this <c> Scanner </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Scanner </c> . </para>
				/// </returns>
				/// <java-name>
				/// useDelimiter
				/// </java-name>
				[Dot42.DexImport("useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseDelimiter(string pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <summary>
				/// <para>Sets the <c> Locale </c> of this <c> Scanner </c> to a specified <c> Locale </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Scanner </c> . </para>
				/// </returns>
				/// <java-name>
				/// useLocale
				/// </java-name>
				[Dot42.DexImport("useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseLocale(global::Java.Util.Locale l) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <summary>
				/// <para>Sets the radix of this <c> Scanner </c> to the specified radix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Scanner </c> . </para>
				/// </returns>
				/// <java-name>
				/// useRadix
				/// </java-name>
				[Dot42.DexImport("useRadix", "(I)Ljava/util/Scanner;", AccessFlags = 1)]
				public global::Java.Util.Scanner UseRadix(int radix) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Scanner);
				}

				/// <summary>
				/// <para>Remove is not a supported operation on <c> Scanner </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public void Remove() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resets this scanner's delimiter, locale, and radix.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this scanner </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para><c> Collection </c> is the root of the collection hierarchy. It defines operations on data collections and the behavior that they will have in all implementations of <c> Collection </c> s.</para><para>All direct or indirect implementations of <c> Collection </c> should implement at least two constructors. One with no parameters which creates an empty collection and one with a parameter of type <c> Collection </c> . This second constructor can be used to create a collection of different type as the initial collection but with the same elements. Implementations of <c> Collection </c> cannot be forced to implement these two constructors but at least all implementations under <c> java.util </c> do.</para><para>Methods that change the content of a collection throw an <c> UnsupportedOperationException </c> if the underlying collection does not support that operation, though it's not mandatory to throw such an <c> Exception </c> in cases where the requested operation would not change the collection. In these cases it's up to the implementation whether it throws an <c> UnsupportedOperationException </c> or not.</para><para>Methods marked with (optional) can throw an <c> UnsupportedOperationException </c> if the underlying collection doesn't support that method. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Collection
		/// </java-name>
		[Dot42.DexImport("java/util/Collection", AccessFlags = 1537, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Iterable<TE;>;")]
		public partial interface ICollection<E> : global::Java.Lang.IIterable<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Attempts to add <c> object </c> to the contents of this <c> Collection </c> (optional).</para><para>After this method finishes successfully it is guaranteed that the object is contained in the collection.</para><para>If the collection was modified it returns <c> true </c> , <c> false </c> if no changes were made.</para><para>An implementation of <c> Collection </c> may narrow the set of accepted objects, but it has to specify this in the documentation. If the object to be added does not meet this restriction, then an <c> IllegalArgumentException </c> is thrown.</para><para>If a collection does not yet contain an object that is to be added and adding the object fails, this method <b>must</b> throw an appropriate unchecked Exception. Returning false is not permitted in this case because it would violate the postcondition that the element will be part of the collection after this method finishes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TE;)Z")]
				bool Add(E @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Attempts to add all of the objects contained in <c> Collection </c> to the contents of this <c> Collection </c> (optional). If the passed <c> Collection </c> is changed during the process of adding elements to this <c> Collection </c> , the behavior is not defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all elements from this <c> Collection </c> , leaving it empty (optional).</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tests whether this <c> Collection </c> contains the specified object. Returns <c> true </c> if and only if at least one element <c> elem </c> in this <c> Collection </c> meets following requirement: <c> (object==null ? elem==null : object.equals(elem)) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if object is an element of this <c> Collection </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Contains(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tests whether this <c> Collection </c> contains all objects contained in the specified <c> Collection </c> . If an element <c> elem </c> is contained several times in the specified <c> Collection </c> , the method returns <c> true </c> even if <c> elem </c> is contained only once in this <c> Collection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if all objects in the specified <c> Collection </c> are elements of this <c> Collection </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsAll
				/// </java-name>
				[Dot42.DexImport("containsAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool ContainsAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the argument to the receiver, and returns true if they represent the <b>same</b> object using a class specific comparison.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the object is the same as this object and <c> false </c> if it is different from this object. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. Objects which are equal return the same value for this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash.</para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns if this <c> Collection </c> contains no elements.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> has no elements, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
				bool IsEmpty() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an instance of Iterator that may be used to access the objects contained by this <c> Collection </c> . The order in which the elements are returned by the iterator is not defined. Only if the instance of the <c> Collection </c> has a defined order the elements are returned in that order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator for accessing the <c> Collection </c> contents. </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TE;>;")]
				global::Java.Util.IIterator<E> Iterator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes one instance of the specified object from this <c> Collection </c> if one is contained (optional). The element <c> elem </c> that is removed complies with <c> (object==null ? elem==null : object.equals(elem) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Remove(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all occurrences in this <c> Collection </c> of each object in the specified <c> Collection </c> (optional). After this method returns none of the elements in the passed <c> Collection </c> can be found in this <c> Collection </c> anymore.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RemoveAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all objects from this <c> Collection </c> that are not also found in the <c> Collection </c> passed (optional). After this method returns this <c> Collection </c> will only contain elements that also can be found in the <c> Collection </c> passed to this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> Collection </c> is modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// retainAll
				/// </java-name>
				[Dot42.DexImport("retainAll", "(Ljava/util/Collection;)Z", AccessFlags = 1025, Signature = "(Ljava/util/Collection<*>;)Z")]
				bool RetainAll(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a count of how many objects this <c> Collection </c> contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>how many objects this <c> Collection </c> contains, or Integer.MAX_VALUE if there are more than Integer.MAX_VALUE elements in this <c> Collection </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new array containing all elements contained in this <c> Collection </c> .</para><para>If the implementation has ordered elements it will return the element array in the same order as an iterator would return them.</para><para>The array returned does not reflect any changes of the <c> Collection </c> . A new array is created even if the underlying data structure is already an array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> Collection </c> . </para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] ToArray() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array containing all elements contained in this <c> Collection </c> . If the specified array is large enough to hold the elements, the specified array is used, otherwise an array of the same type is created. If the specified array is used and is larger than this <c> Collection </c> , the array element following the <c> Collection </c> elements is set to null.</para><para>If the implementation has ordered elements it will return the element array in the same order as an iterator would return them.</para><para><c> toArray(new Object[0]) </c> behaves exactly the same way as <c> toArray() </c> does.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of the elements from this <c> Collection </c> .</para>
				/// </returns>
				/// <java-name>
				/// toArray
				/// </java-name>
				[Dot42.DexImport("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>([TT;)[TT;")]
				T[] ToArray<T>(T[] array) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>UUID is an immutable representation of a 128-bit universally unique identifier (UUID). </para><para>There are multiple, variant layouts of UUIDs, but this class is based upon variant 2 of , the Leach-Salz variant. This class can be used to model alternate variants, but most of the methods will be unsupported in those cases; see each method for details.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/UUID
		/// </java-name>
		[Dot42.DexImport("java/util/UUID", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/util/UUID;>;")]
		public sealed partial class UUID : global::Java.Io.ISerializable, global::System.IComparable<global::Java.Util.UUID>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an instance with the specified bits.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJ)V", AccessFlags = 1)]
				public UUID(long mostSigBits, long leastSigBits) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Generates a variant 2, version 4 (randomly generated number) UUID as per .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an UUID instance. </para>
				/// </returns>
				/// <java-name>
				/// randomUUID
				/// </java-name>
				[Dot42.DexImport("randomUUID", "()Ljava/util/UUID;", AccessFlags = 9)]
				public static global::Java.Util.UUID RandomUUID() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <summary>
				/// <para>Generates a variant 2, version 3 (name-based, MD5-hashed) UUID as per .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an UUID instance. </para>
				/// </returns>
				/// <java-name>
				/// nameUUIDFromBytes
				/// </java-name>
				[Dot42.DexImport("nameUUIDFromBytes", "([B)Ljava/util/UUID;", AccessFlags = 9)]
				public static global::Java.Util.UUID NameUUIDFromBytes(sbyte[] name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <summary>
				/// <para>Generates a variant 2, version 3 (name-based, MD5-hashed) UUID as per .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an UUID instance. </para>
				/// </returns>
				/// <java-name>
				/// nameUUIDFromBytes
				/// </java-name>
				[Dot42.DexImport("nameUUIDFromBytes", "([B)Ljava/util/UUID;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Util.UUID NameUUIDFromBytes(byte[] name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <summary>
				/// <para>Parses a UUID string with the format defined by toString().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an UUID instance. </para>
				/// </returns>
				/// <java-name>
				/// fromString
				/// </java-name>
				[Dot42.DexImport("fromString", "(Ljava/lang/String;)Ljava/util/UUID;", AccessFlags = 9)]
				public static global::Java.Util.UUID FromString(string uuid) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.UUID);
				}

				/// <summary>
				/// <para>The 64 least significant bits of the UUID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 64 least significant bits. </para>
				/// </returns>
				/// <java-name>
				/// getLeastSignificantBits
				/// </java-name>
				[Dot42.DexImport("getLeastSignificantBits", "()J", AccessFlags = 1)]
				public long GetLeastSignificantBits() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The 64 most significant bits of the UUID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 64 most significant bits. </para>
				/// </returns>
				/// <java-name>
				/// getMostSignificantBits
				/// </java-name>
				[Dot42.DexImport("getMostSignificantBits", "()J", AccessFlags = 1)]
				public long GetMostSignificantBits() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The version of the variant 2 UUID as per . If the variant is not 2, then the version will be 0. <ul><li><para>1 - Time-based UUID </para></li><li><para>2 - DCE Security UUID </para></li><li><para>3 - Name-based with MD5 hashing UUID (nameUUIDFromBytes(byte[])) </para></li><li><para>4 - Randomly generated UUID (randomUUID()) </para></li><li><para>5 - Name-based with SHA-1 hashing UUID </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> int </c> value. </para>
				/// </returns>
				/// <java-name>
				/// version
				/// </java-name>
				[Dot42.DexImport("version", "()I", AccessFlags = 1)]
				public int Version() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>The variant of the UUID as per . <ul><li><para>0 - Reserved for NCS compatibility </para></li><li><para>2 - RFC 4122/Leach-Salz </para></li><li><para>6 - Reserved for Microsoft Corporation compatibility </para></li><li><para>7 - Reserved for future use </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> int </c> value. </para>
				/// </returns>
				/// <java-name>
				/// variant
				/// </java-name>
				[Dot42.DexImport("variant", "()I", AccessFlags = 1)]
				public int Variant() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>The timestamp value of the version 1, variant 2 UUID as per .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> long </c> value. </para>
				/// </returns>
				/// <java-name>
				/// timestamp
				/// </java-name>
				[Dot42.DexImport("timestamp", "()J", AccessFlags = 1)]
				public long Timestamp() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The clock sequence value of the version 1, variant 2 UUID as per .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> long </c> value. </para>
				/// </returns>
				/// <java-name>
				/// clockSequence
				/// </java-name>
				[Dot42.DexImport("clockSequence", "()I", AccessFlags = 1)]
				public int ClockSequence() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>The node value of the version 1, variant 2 UUID as per .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> long </c> value. </para>
				/// </returns>
				/// <java-name>
				/// node
				/// </java-name>
				[Dot42.DexImport("node", "()J", AccessFlags = 1)]
				public long Node() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Compares this UUID to the specified UUID. The natural ordering of UUIDs is based upon the value of the bits from most significant to least significant.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a value of -1, 0 or 1 if this UUID is less than, equal to or greater than <c> uuid </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/UUID;)I", AccessFlags = 1)]
				public int CompareTo(global::Java.Util.UUID uuid) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares this UUID to another object for equality. If <c> object </c> is not <c> null </c> , is a UUID instance, and all bits are equal, then <c> true </c> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this UUID is equal to <c> object </c> or <c> false </c> if not. </para>
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
				/// <para>Returns a hash value for this UUID that is consistent with the equals(Object) method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> int </c> value. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a string representation of this UUID in the following format, as per .</para><para><pre>
				///                   UUID                   = time-low "-" time-mid "-"
				///                                            time-high-and-version "-"
				///                                            clock-seq-and-reserved
				///                                            clock-seq-low "-" node
				///                   time-low               = 4hexOctet
				///                   time-mid               = 2hexOctet
				///                   time-high-and-version  = 2hexOctet
				///                   clock-seq-and-reserved = hexOctet
				///                   clock-seq-low          = hexOctet
				///                   node                   = 6hexOctet
				///                   hexOctet               = hexDigit hexDigit
				///                   hexDigit =
				///                       "0" / "1" / "2" / "3" / "4" / "5" / "6" / "7" / "8" / "9" /
				///                       "a" / "b" / "c" / "d" / "e" / "f" /
				///                       "A" / "B" / "C" / "D" / "E" / "F"
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a String instance. </para>
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
				internal UUID() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>The 64 least significant bits of the UUID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 64 least significant bits. </para>
				/// </returns>
				/// <java-name>
				/// getLeastSignificantBits
				/// </java-name>
				public long LeastSignificantBits
				{
				[Dot42.DexImport("getLeastSignificantBits", "()J", AccessFlags = 1)]
						get{ return GetLeastSignificantBits(); }
				}

				/// <summary>
				/// <para>The 64 most significant bits of the UUID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 64 most significant bits. </para>
				/// </returns>
				/// <java-name>
				/// getMostSignificantBits
				/// </java-name>
				public long MostSignificantBits
				{
				[Dot42.DexImport("getMostSignificantBits", "()J", AccessFlags = 1)]
						get{ return GetMostSignificantBits(); }
				}

		}

		/// <summary>
		/// <para>A service-provider loader.</para><para>A service provider is a factory for creating all known implementations of a particular class or interface <c> S </c> . The known implementations are read from a configuration file in <c> META-INF/services/ </c> . The file's name should match the class' binary name (such as <c> java.util.Outer$Inner </c> ).</para><para>The file format is as follows. The file's character encoding must be UTF-8. Whitespace is ignored, and <c> # </c> is used to begin a comment that continues to the next newline. Lines that are empty after comment removal and whitespace trimming are ignored. Otherwise, each line contains the binary name of one implementation class. Duplicate entries are ignored, but entries are otherwise returned in order (that is, the file is treated as an ordered set).</para><para>Given these classes: <pre>
		///    package a.b.c;
		///    public interface MyService { ... }
		///    public class MyImpl1 implements MyService { ... }
		///    public class MyImpl2 implements MyService { ... }
		///    </pre> And this configuration file (stored as <c> META-INF/services/a.b.c.MyService </c> ): <pre>
		///    # Known MyService providers.
		///    a.b.c.MyImpl1  # The original implementation for handling "bar"s.
		///    a.b.c.MyImpl2  # A later implementation for "foo"s.
		///    </pre> You might use <c> ServiceProvider </c> something like this: <pre>
		///      for (MyService service : ServiceLoader&lt;MyService&gt;.load(MyService.class)) {
		///        if (service.supports(o)) {
		///          return service.handle(o);
		///        }
		///      }
		///    </pre></para><para>Note that each iteration creates new instances of the various service implementations, so any heavily-used code will likely want to cache the known implementations itself and reuse them. Note also that the candidate classes are instantiated lazily as you call <c> next </c> on the iterator: construction of the iterator itself does not instantiate any of the providers.</para><para><para>1.6 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Invalidates the cache of known service provider class names. </para>        
				/// </summary>
				/// <java-name>
				/// reload
				/// </java-name>
				[Dot42.DexImport("reload", "()V", AccessFlags = 1)]
				public void Reload() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an iterator over all the service providers offered by this service loader. Note that <c> hasNext </c> and <c> next </c> may throw if the configuration is invalid.</para><para>Each iterator will return new instances of the classes it iterates over, so callers may want to cache the results of a single call to this method rather than call it repeatedly.</para><para>The returned iterator does not support <c> remove </c> . </para>        
				/// </summary>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<TS;>;")]
				public global::Java.Util.IIterator<S> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<S>);
				}

				/// <summary>
				/// <para>Constructs a service loader. If <c> classLoader </c> is null, the system class loader is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new ServiceLoader </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/util/ServiceLoader;", AccessFlags = 9, Signature = "<S:Ljava/lang/Object;>(Ljava/lang/Class<TS;>;Ljava/lang/ClassLoader;)Ljava/util/S" +
    "erviceLoader<TS;>;")]
				public static global::Java.Util.ServiceLoader<JavaS> Load<JavaS>(global::System.Type service, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ServiceLoader<JavaS>);
				}

				/// <summary>
				/// <para>Constructs a service loader, using the current thread's context class loader.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new ServiceLoader </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;", AccessFlags = 9, Signature = "<S:Ljava/lang/Object;>(Ljava/lang/Class<TS;>;)Ljava/util/ServiceLoader<TS;>;")]
				public static global::Java.Util.ServiceLoader<JavaS> Load<JavaS>(global::System.Type service) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ServiceLoader<JavaS>);
				}

				/// <summary>
				/// <para>Constructs a service loader, using the extension class loader.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new ServiceLoader </para>
				/// </returns>
				/// <java-name>
				/// loadInstalled
				/// </java-name>
				[Dot42.DexImport("loadInstalled", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;", AccessFlags = 9, Signature = "<S:Ljava/lang/Object;>(Ljava/lang/Class<TS;>;)Ljava/util/ServiceLoader<TS;>;")]
				public static global::Java.Util.ServiceLoader<JavaS> LoadInstalled<JavaS>(global::System.Type service) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>A <c> Map </c> is a data structure consisting of a set of keys and values in which each key is mapped to a single value. The class of the objects used as keys is declared when the <c> Map </c> is declared, as is the class of the corresponding values. </para><para>A <c> Map </c> provides helper methods to iterate through all of the keys contained in it, as well as various methods to access and update the key/value pairs. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Map
		/// </java-name>
		[Dot42.DexImport("java/util/Map", AccessFlags = 1537, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Removes all elements from this <c> Map </c> , leaving it empty.</para><para><para>isEmpty() </para><simplesectsep></simplesectsep><para>size() </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this <c> Map </c> contains the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified key, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool ContainsKey(object key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this <c> Map </c> contains the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified value, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool ContainsValue(object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> Set </c> containing all of the mappings in this <c> Map </c> . Each mapping is an instance of Map.Entry. As the <c> Set </c> is backed by this <c> Map </c> , changes in one will be reflected in the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings </para>
				/// </returns>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
				global::Java.Util.ISet<global::Java.Util.IMap_IEntry<K, V>> EntrySet() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the argument to the receiver, and returns <c> true </c> if the specified object is a <c> Map </c> and both <c> Map </c> s contain the same mappings.</para><para><para>hashCode() </para><simplesectsep></simplesectsep><para>entrySet() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean <c> true </c> if the <c> Object </c> is the same as this <c> Object </c> <c> false </c> if it is different from this <c> Object </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the value of the mapping with the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				V Get(object key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. <c> Object </c> s which are equal return the same value for this method.</para><para><para>equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this map is empty.</para><para><para>size() </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
				bool IsEmpty() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a set of the keys contained in this <c> Map </c> . The <c> Set </c> is backed by this <c> Map </c> so changes to one are reflected by the other. The <c> Set </c> does not support adding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<TK;>;")]
				global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Maps the specified key to the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no mapping. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(TK;TV;)TV;")]
				V Put(K key, V value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Copies every mapping in the specified <c> Map </c> to this <c> Map </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				void PutAll(global::Java.Util.IMap<K, V> map) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes a mapping with the specified key from this <c> Map </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping or <c> null </c> if no mapping for the specified key was found. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/Object;)TV;")]
				V Remove(object key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of mappings in this <c> Map </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of mappings in this <c> Map </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> Collection </c> of the values contained in this <c> Map </c> . The <c> Collection </c> is backed by this <c> Map </c> so changes to one are reflected by the other. The <c> Collection </c> supports Collection#remove, Collection#removeAll, Collection#retainAll, and Collection#clear operations, and it does not support Collection#add or Collection#addAll operations. </para><para>This method returns a <c> Collection </c> which is the subclass of AbstractCollection. The AbstractCollection#iterator method of this subclass returns a "wrapper object" over the iterator of this <c> Map </c> 's entrySet(). The AbstractCollection#size method wraps this <c> Map </c> 's size method and the AbstractCollection#contains method wraps this <c> Map </c> 's containsValue method. </para><para>The collection is created when this method is called at first time and returned in response to all subsequent calls. This method may return different Collection when multiple calls to this method, since it has no synchronization performed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of the values contained in this map. </para>
				/// </returns>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1025, Signature = "()Ljava/util/Collection<TV;>;")]
				global::Java.Util.ICollection<V> Values() /* MethodBuilder.Create */ ;

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
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TK;")]
				K GetKey() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V GetValue() /* MethodBuilder.Create */ ;

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

		}

		/// <summary>
		/// <para><c> SimpleTimeZone </c> is a concrete subclass of <c> TimeZone </c> that represents a time zone for use with a Gregorian calendar. This class does not handle historical changes. </para><para>Use a negative value for <c> dayOfWeekInMonth </c> to indicate that <c> SimpleTimeZone </c> should count from the end of the month backwards. For example, Daylight Savings Time ends at the last (dayOfWeekInMonth = -1) Sunday in October, at 2 AM in standard time.</para><para><para>Calendar </para><simplesectsep></simplesectsep><para>GregorianCalendar </para><simplesectsep></simplesectsep><para>TimeZone </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/SimpleTimeZone
		/// </java-name>
		[Dot42.DexImport("java/util/SimpleTimeZone", AccessFlags = 33)]
		public partial class SimpleTimeZone : global::Java.Util.TimeZone
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The constant for representing a start or end time in GMT time mode. </para>        
				/// </summary>
				/// <java-name>
				/// UTC_TIME
				/// </java-name>
				[Dot42.DexImport("UTC_TIME", "I", AccessFlags = 25)]
				public const int UTC_TIME = 2;
				/// <summary>
				/// <para>The constant for representing a start or end time in standard local time mode, based on timezone's raw offset from GMT; does not include Daylight savings. </para>        
				/// </summary>
				/// <java-name>
				/// STANDARD_TIME
				/// </java-name>
				[Dot42.DexImport("STANDARD_TIME", "I", AccessFlags = 25)]
				public const int STANDARD_TIME = 1;
				/// <summary>
				/// <para>The constant for representing a start or end time in local wall clock time mode, based on timezone's adjusted offset from GMT; includes Daylight savings. </para>        
				/// </summary>
				/// <java-name>
				/// WALL_TIME
				/// </java-name>
				[Dot42.DexImport("WALL_TIME", "I", AccessFlags = 25)]
				public const int WALL_TIME = 0;
				/// <summary>
				/// <para>Constructs a <c> SimpleTimeZone </c> with the given base time zone offset from GMT and time zone ID. Timezone IDs can be obtained from <c> TimeZone.getAvailableIDs </c> . Normally you should use <c> TimeZone.getDefault </c> to construct a <c> TimeZone </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public SimpleTimeZone(int offset, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a <c> SimpleTimeZone </c> with the given base time zone offset from GMT, time zone ID, and times to start and end the daylight savings time. Timezone IDs can be obtained from <c> TimeZone.getAvailableIDs </c> . Normally you should use <c> TimeZone.getDefault </c> to create a <c> TimeZone </c> . For a time zone that does not use daylight saving time, do not use this constructor; instead you should use <c> SimpleTimeZone(rawOffset, ID) </c> . </para><para>By default, this constructor specifies day-of-week-in-month rules. That is, if the <c> startDay </c> is 1, and the <c> startDayOfWeek </c> is <c> SUNDAY </c> , then this indicates the first Sunday in the <c> startMonth </c> . A <c> startDay </c> of -1 likewise indicates the last Sunday. However, by using negative or zero values for certain parameters, other types of rules can be specified. </para><para>Day of month: To specify an exact day of the month, such as March 1, set <c> startDayOfWeek </c> to zero. </para><para>Day of week after day of month: To specify the first day of the week occurring on or after an exact day of the month, make the day of the week negative. For example, if <c> startDay </c> is 5 and <c> startDayOfWeek </c> is <c> -MONDAY </c> , this indicates the first Monday on or after the 5th day of the <c> startMonth </c> . </para><para>Day of week before day of month: To specify the last day of the week occurring on or before an exact day of the month, make the day of the week and the day of the month negative. For example, if <c> startDay </c> is <c> -21 </c> and <c> startDayOfWeek </c> is <c> -WEDNESDAY </c> , this indicates the last Wednesday on or before the 21st of the <c> startMonth </c> . </para><para>The above examples refer to the <c> startMonth </c> , <c> startDay </c> , and <c> startDayOfWeek </c> ; the same applies for the <c> endMonth </c> , <c> endDay </c> , and <c> endDayOfWeek </c> . </para><para>The daylight savings time difference is set to the default value: one hour.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;IIIIIIII)V", AccessFlags = 1)]
				public SimpleTimeZone(int offset, string name, int startMonth, int startDay, int startDayOfWeek, int startTime, int endMonth, int endDay, int endDayOfWeek, int endTime) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a <c> SimpleTimeZone </c> with the given base time zone offset from GMT, time zone ID, times to start and end the daylight savings time, and the daylight savings time difference in milliseconds.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;IIIIIIIII)V", AccessFlags = 1)]
				public SimpleTimeZone(int offset, string name, int startMonth, int startDay, int startDayOfWeek, int startTime, int endMonth, int endDay, int endDayOfWeek, int endTime, int daylightSavings) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a <c> SimpleTimeZone </c> with the given base time zone offset from GMT, time zone ID, times to start and end the daylight savings time including a mode specifier, the daylight savings time difference in milliseconds. The mode specifies either WALL_TIME, STANDARD_TIME, or UTC_TIME.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;IIIIIIIIIII)V", AccessFlags = 1)]
				public SimpleTimeZone(int offset, string name, int startMonth, int startDay, int startDayOfWeek, int startTime, int startTimeMode, int endMonth, int endDay, int endDayOfWeek, int endTime, int endTimeMode, int daylightSavings) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> SimpleTimeZone </c> with the same ID, <c> rawOffset </c> and daylight savings time rules as this SimpleTimeZone.</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> SimpleTimeZone </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Compares the specified object to this <c> SimpleTimeZone </c> and returns whether they are equal. The object must be an instance of <c> SimpleTimeZone </c> and have the same internal data.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> SimpleTimeZone </c> , <c> false </c> otherwise. </para>
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
				/// <para>Returns the latest daylight savings in milliseconds for this time zone, relative to this time zone's regular UTC offset (as returned by getRawOffset).</para><para>This class returns <c> 3600000 </c> (1 hour) for time zones that use daylight savings time and <c> 0 </c> for timezones that do not, leaving it to subclasses to override this method for other daylight savings offsets. (There are time zones, such as <c> Australia/Lord_Howe </c> , that use other values.)</para><para>Note that this method doesn't tell you whether or not to <b>apply</b> the offset: you need to call <c> inDaylightTime </c> for the specific time you're interested in. If this method returns a non-zero offset, that only tells you that this <c> TimeZone </c> sometimes observes daylight savings.</para><para>Note also that this method doesn't necessarily return the value you need to apply to the time you're working with. This value can and does change over time for a given time zone.</para><para>It's highly unlikely that you should ever call this method. You probably want getOffset instead, which tells you the offset for a specific point in time, and takes daylight savings into account for you. </para>        
				/// </summary>
				/// <java-name>
				/// getDSTSavings
				/// </java-name>
				[Dot42.DexImport("getDSTSavings", "()I", AccessFlags = 1)]
				public override int GetDSTSavings() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this time zone's offset in milliseconds from UTC at the specified date and time. The offset includes daylight savings time if the date and time is within the daylight savings time period.</para><para>This method is intended to be used by Calendar to compute Calendar#DST_OFFSET and Calendar#ZONE_OFFSET. Application code should have no reason to call this method directly. Each parameter is interpreted in the same way as the corresponding <c> Calendar </c> field. Refer to Calendar for specific definitions of this method's parameters. </para>        
				/// </summary>
				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(IIIIII)I", AccessFlags = 1)]
				public override int GetOffset(int era, int year, int month, int day, int dayOfWeek, int timeOfDayMillis) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the offset in milliseconds from UTC for this time zone at <c>       time </c> . The offset includes daylight savings time if the specified date is within the daylight savings time period.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "(J)I", AccessFlags = 1)]
				public override int GetOffset(long time) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the offset in milliseconds from UTC of this time zone's standard time. </para>        
				/// </summary>
				/// <java-name>
				/// getRawOffset
				/// </java-name>
				[Dot42.DexImport("getRawOffset", "()I", AccessFlags = 1)]
				public override int GetRawOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an integer hash code for the receiver. Objects which are equal return the same value for this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 33)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns true if <c> timeZone </c> has the same rules as this time zone.</para><para>The base implementation returns true if both time zones have the same raw offset. </para>        
				/// </summary>
				/// <java-name>
				/// hasSameRules
				/// </java-name>
				[Dot42.DexImport("hasSameRules", "(Ljava/util/TimeZone;)Z", AccessFlags = 1)]
				public override bool HasSameRules(global::Java.Util.TimeZone timeZone) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if <c> time </c> is in a daylight savings time period for this time zone. </para>        
				/// </summary>
				/// <java-name>
				/// inDaylightTime
				/// </java-name>
				[Dot42.DexImport("inDaylightTime", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public override bool InDaylightTime(global::Java.Util.Date time) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the daylight savings offset in milliseconds for this <c> SimpleTimeZone </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDSTSavings
				/// </java-name>
				[Dot42.DexImport("setDSTSavings", "(I)V", AccessFlags = 1)]
				public virtual void SetDSTSavings(int milliseconds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the rule which specifies the end of daylight savings time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEndRule
				/// </java-name>
				[Dot42.DexImport("setEndRule", "(III)V", AccessFlags = 1)]
				public virtual void SetEndRule(int month, int dayOfMonth, int time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the rule which specifies the end of daylight savings time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEndRule
				/// </java-name>
				[Dot42.DexImport("setEndRule", "(IIII)V", AccessFlags = 1)]
				public virtual void SetEndRule(int month, int day, int dayOfWeek, int time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the rule which specifies the end of daylight savings time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEndRule
				/// </java-name>
				[Dot42.DexImport("setEndRule", "(IIIIZ)V", AccessFlags = 1)]
				public virtual void SetEndRule(int month, int day, int dayOfWeek, int time, bool after) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the offset for standard time from GMT for this <c> SimpleTimeZone </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRawOffset
				/// </java-name>
				[Dot42.DexImport("setRawOffset", "(I)V", AccessFlags = 1)]
				public override void SetRawOffset(int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the rule which specifies the start of daylight savings time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartRule
				/// </java-name>
				[Dot42.DexImport("setStartRule", "(III)V", AccessFlags = 1)]
				public virtual void SetStartRule(int month, int dayOfMonth, int time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the rule which specifies the start of daylight savings time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartRule
				/// </java-name>
				[Dot42.DexImport("setStartRule", "(IIII)V", AccessFlags = 1)]
				public virtual void SetStartRule(int month, int day, int dayOfWeek, int time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the rule which specifies the start of daylight savings time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartRule
				/// </java-name>
				[Dot42.DexImport("setStartRule", "(IIIIZ)V", AccessFlags = 1)]
				public virtual void SetStartRule(int month, int day, int dayOfWeek, int time, bool after) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the starting year for daylight savings time in this <c> SimpleTimeZone </c> . Years before this start year will always be in standard time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartYear
				/// </java-name>
				[Dot42.DexImport("setStartYear", "(I)V", AccessFlags = 1)]
				public virtual void SetStartYear(int year) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the string representation of this <c> SimpleTimeZone </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this <c> SimpleTimeZone </c> . </para>
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
				/// <para>Returns true if this time zone has a future transition to or from daylight savings time.</para><para><b>Warning:</b> this returns false for time zones like <c> Asia/Kuala_Lumpur </c> that have previously used DST but do not currently. A hypothetical country that has never observed daylight savings before but plans to start next year would return true.</para><para><b>Warning:</b> this returns true for time zones that use DST, even when it is not active.</para><para>Use inDaylightTime to find out whether daylight savings is in effect at a specific time.</para><para>Most applications should not use this method. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Returns the latest daylight savings in milliseconds for this time zone, relative to this time zone's regular UTC offset (as returned by getRawOffset).</para><para>This class returns <c> 3600000 </c> (1 hour) for time zones that use daylight savings time and <c> 0 </c> for timezones that do not, leaving it to subclasses to override this method for other daylight savings offsets. (There are time zones, such as <c> Australia/Lord_Howe </c> , that use other values.)</para><para>Note that this method doesn't tell you whether or not to <b>apply</b> the offset: you need to call <c> inDaylightTime </c> for the specific time you're interested in. If this method returns a non-zero offset, that only tells you that this <c> TimeZone </c> sometimes observes daylight savings.</para><para>Note also that this method doesn't necessarily return the value you need to apply to the time you're working with. This value can and does change over time for a given time zone.</para><para>It's highly unlikely that you should ever call this method. You probably want getOffset instead, which tells you the offset for a specific point in time, and takes daylight savings into account for you. </para>        
				/// </summary>
				/// <java-name>
				/// getDSTSavings
				/// </java-name>
				public int DSTSavings
				{
				[Dot42.DexImport("getDSTSavings", "()I", AccessFlags = 1)]
						get{ return GetDSTSavings(); }
				}

				/// <summary>
				/// <para>Returns the offset in milliseconds from UTC of this time zone's standard time. </para>        
				/// </summary>
				/// <java-name>
				/// getRawOffset
				/// </java-name>
				public int RawOffset
				{
				[Dot42.DexImport("getRawOffset", "()I", AccessFlags = 1)]
						get{ return GetRawOffset(); }
				[Dot42.DexImport("setRawOffset", "(I)V", AccessFlags = 1)]
						set{ SetRawOffset(value); }
				}

		}

		/// <summary>
		/// <para>The <c> TimerTask </c> class represents a task to run at a specified time. The task may be run once or repeatedly.</para><para><para>Timer </para><simplesectsep></simplesectsep><para>java.lang.Object::wait(long) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/TimerTask
		/// </java-name>
		[Dot42.DexImport("java/util/TimerTask", AccessFlags = 1057)]
		public abstract partial class TimerTask : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> TimerTask </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TimerTask() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels the <c> TimerTask </c> and removes it from the <c> Timer </c> 's queue. Generally, it returns <c> false </c> if the call did not prevent a <c> TimerTask </c> from running at least once. Subsequent calls have no effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the call prevented a scheduled execution from taking place, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()Z", AccessFlags = 1)]
				public virtual bool Cancel() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the scheduled execution time. If the task execution is in progress it returns the execution time of the ongoing task. Tasks which have not yet run return an undefined value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the most recent execution time. </para>
				/// </returns>
				/// <java-name>
				/// scheduledExecutionTime
				/// </java-name>
				[Dot42.DexImport("scheduledExecutionTime", "()J", AccessFlags = 1)]
				public virtual long ScheduledExecutionTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The task to run should be specified in the implementation of the <c> run() </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1025)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A map whose entries are sorted by their keys. All optional operations such as put and remove are supported.</para><para>This map sorts keys using either a user-supplied comparator or the key's natural order: <ul><li><para>User supplied comparators must be able to compare any pair of keys in this map. If a user-supplied comparator is in use, it will be returned by comparator. </para></li><li><para>If no user-supplied comparator is supplied, keys will be sorted by their natural order. Keys must be <b>mutually comparable</b>: they must implement Comparable and compareTo() must be able to compare each key with any other key in this map. In this case comparator will return null. </para></li></ul>With either a comparator or a natural ordering, comparisons should be <b>consistent with equals</b>. An ordering is consistent with equals if for every pair of keys <c> a </c> and <c> b </c> , <c> a.equals(b) </c> if and only if <c> compare(a, b) == 0 </c> .</para><para>When the ordering is not consistent with equals the behavior of this class is well defined but does not honor the contract specified by Map. Consider a tree map of case-insensitive strings, an ordering that is not consistent with equals: <pre>        TreeMap&lt;String, String&gt; map = new TreeMap&lt;String, String&gt;(String.CASE_INSENSITIVE_ORDER);
		/// 
		///      map.put("a", "android");
		/// 
		///   
		/// 
		///      // The Map API specifies that the next line should print "null" because
		/// 
		///      // "a".equals("A") is false and there is no mapping for upper case "A".
		/// 
		///      // But the case insensitive ordering says compare("a", "A") == 0. TreeMap
		/// 
		///      // uses only comparators/comparable on keys and so this prints "android".
		/// 
		///      System.out.println(map.get("A"));
		/// 
		///  </pre></para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/TreeMap
		/// </java-name>
		[Dot42.DexImport("java/util/TreeMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/ut" +
    "il/SortedMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;Ljava/lang/Cloneable;Ljava/" +
    "io/Serializable;")]
		public partial class TreeMap<K, V> : global::Java.Util.AbstractMap<K, V>, global::Java.Util.ISortedMap<K, V>, global::Java.Util.INavigableMap<K, V>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a natural order, empty tree map whose keys must be mutually comparable and non-null. </para>        
				/// </summary>
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

				/// <summary>
				/// <para><para><para>Returns the number of mappings in this <c> Map </c> .</para><para></para></para><para>This implementation returns its entry set's size.</para></para><para>This implementation returns its entry set's size. </para>        
				/// </summary>
				/// <returns>
				/// <para>the number of mappings in this <c> Map </c> .</para>
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
				/// <para><para><para>Returns whether this map is empty.</para><para><para>size()</para></para></para><para>This implementation compares <c> size() </c> to 0.</para></para><para>This implementation compares <c> size() </c> to 0. </para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map has no elements, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para><para>Returns the value of the mapping with the specified key.</para><para></para></para><para>This implementation iterates its entry set, looking for an entry with a key that <c> key </c> equals.</para></para><para>This implementation iterates its entry set, looking for an entry with a key that <c> key </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found.</para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para><para><para>Returns whether this <c> Map </c> contains the specified key.</para><para></para></para><para>This implementation iterates its key set, looking for a key that <c> key </c> equals.</para></para><para>This implementation iterates its key set, looking for a key that <c> key </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this map contains the specified key, <c> false </c> otherwise.</para>
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
				/// <para><para><para>Maps the specified key to the specified value.</para><para></para></para><para>This base implementation throws <c> UnsupportedOperationException </c> .</para></para><para>This base implementation throws <c> UnsupportedOperationException </c> . </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of any previous mapping with the specified key or <c> null </c> if there was no mapping. </para>
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
				/// <para><para><para>Removes all elements from this <c> Map </c> , leaving it empty.</para><para><para>isEmpty() </para><simplesectsep></simplesectsep><para>size()</para></para></para><para>This implementation calls <c> entrySet().clear() </c> .</para></para><para>This implementation calls <c> entrySet().clear() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para><para>Removes a mapping with the specified key from this <c> Map </c> .</para><para></para></para><para>This implementation iterates its entry set, removing the entry with a key that <c> key </c> equals.</para></para><para>This implementation iterates its entry set, removing the entry with a key that <c> key </c> equals. </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the removed mapping or <c> null </c> if no mapping for the specified key was found. </para>
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
				/// <para>Returns a key-value mapping associated with the least key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the least key, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// firstEntry
				/// </java-name>
				[Dot42.DexImport("firstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> FirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Removes and returns a key-value mapping associated with the least key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed first entry of this map, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// pollFirstEntry
				/// </java-name>
				[Dot42.DexImport("pollFirstEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> PollFirstEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Returns the first key in this sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first key in this sorted map. </para>
				/// </returns>
				/// <java-name>
				/// firstKey
				/// </java-name>
				[Dot42.DexImport("firstKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K FirstKey() /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				/// <para>Returns a key-value mapping associated with the greatest key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the greatest key, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// lastEntry
				/// </java-name>
				[Dot42.DexImport("lastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LastEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Removes and returns a key-value mapping associated with the greatest key in this map, or <c> null </c> if the map is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the removed last entry of this map, or <c> null </c> if this map is empty </para>
				/// </returns>
				/// <java-name>
				/// pollLastEntry
				/// </java-name>
				[Dot42.DexImport("pollLastEntry", "()Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "()Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> PollLastEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Returns the last key in this sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last key in this sorted map. </para>
				/// </returns>
				/// <java-name>
				/// lastKey
				/// </java-name>
				[Dot42.DexImport("lastKey", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TK;")]
				public virtual K LastKey() /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				/// <para>Returns a key-value mapping associated with the greatest key strictly less than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the greatest key less than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// lowerEntry
				/// </java-name>
				[Dot42.DexImport("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> LowerEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Returns the greatest key strictly less than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest key less than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// lowerKey
				/// </java-name>
				[Dot42.DexImport("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K LowerKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				/// <para>Returns a key-value mapping associated with the greatest key less than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the greatest key less than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// floorEntry
				/// </java-name>
				[Dot42.DexImport("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> FloorEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Returns the greatest key less than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest key less than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// floorKey
				/// </java-name>
				[Dot42.DexImport("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K FloorKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				/// <para>Returns a key-value mapping associated with the least key greater than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the least key greater than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// ceilingEntry
				/// </java-name>
				[Dot42.DexImport("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> CeilingEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Returns the least key greater than or equal to the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least key greater than or equal to <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// ceilingKey
				/// </java-name>
				[Dot42.DexImport("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K CeilingKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				/// <para>Returns a key-value mapping associated with the least key strictly greater than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an entry with the least key greater than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// higherEntry
				/// </java-name>
				[Dot42.DexImport("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", AccessFlags = 1, Signature = "(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
				public virtual global::Java.Util.IMap_IEntry<K, V> HigherEntry(K key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap_IEntry<K, V>);
				}

				/// <summary>
				/// <para>Returns the least key strictly greater than the given key, or <c> null </c> if there is no such key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least key greater than <c> key </c> , or <c> null </c> if there is no such key </para>
				/// </returns>
				/// <java-name>
				/// higherKey
				/// </java-name>
				[Dot42.DexImport("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TK;)TK;")]
				public virtual K HigherKey(K key) /* MethodBuilder.Create */ 
				{
						return default(K);
				}

				/// <summary>
				/// <para>Returns the comparator used to compare keys in this sorted map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the comparator or <c> null </c> if the natural order is used. </para>
				/// </returns>
				/// <java-name>
				/// comparator
				/// </java-name>
				[Dot42.DexImport("comparator", "()Ljava/util/Comparator;", AccessFlags = 1, Signature = "()Ljava/util/Comparator<-TK;>;")]
				public virtual global::Java.Util.IComparator<K> Comparator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IComparator<K>);
				}

				/// <summary>
				/// <para>Returns a <c> Set </c> containing all of the mappings in this <c> Map </c> . Each mapping is an instance of Map.Entry. As the <c> Set </c> is backed by this <c> Map </c> , changes in one will be reflected in the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the mappings </para>
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
				/// <para><para><para>Returns a set of the keys contained in this <c> Map </c> . The <c> Set </c> is backed by this <c> Map </c> so changes to one are reflected by the other. The <c> Set </c> does not support adding.</para><para></para></para><para>This implementation returns a view that calls through this to map. Its iterator transforms this map's entry set iterator to return keys.</para></para><para>This implementation returns a view that calls through this to map. Its iterator transforms this map's entry set iterator to return keys. </para>        
				/// </summary>
				/// <returns>
				/// <para>a set of the keys.</para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<TK;>;")]
				public override global::Java.Util.ISet<K> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<K>);
				}

				/// <summary>
				/// <para>Returns a NavigableSet view of the keys contained in this map. The set's iterator returns the keys in ascending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. If the map is modified while an iteration over the set is in progress (except through the iterator's own <c>       remove </c> operation), the results of the iteration are undefined. The set supports element removal, which removes the corresponding mapping from the map, via the <c> Iterator.remove </c> , <c> Set.remove </c> , <c> removeAll </c> , <c> retainAll </c> , and <c> clear </c> operations. It does not support the <c> add </c> or <c> addAll </c> operations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a navigable set view of the keys in this map </para>
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
				/// <para>Returns a view of the portion of this map whose keys range from <c> fromKey </c> to <c> toKey </c> . If <c> fromKey </c> and <c> toKey </c> are equal, the returned map is empty unless <c> fromExclusive </c> and <c> toExclusive </c> are both true. The returned map is backed by this map, so changes in the returned map are reflected in this map, and vice-versa. The returned map supports all optional map operations that this map supports.</para><para>The returned map will throw an <c> IllegalArgumentException </c> on an attempt to insert a key outside of its range, or to construct a submap either of whose endpoints lie outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this map whose keys range from <c> fromKey </c> to <c> toKey </c> </para>
				/// </returns>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> SubMap(K fromKey, bool fromInclusive, K toKey, bool toInclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <summary>
				/// <para><para><para>Returns a sorted map over a range of this sorted map with all keys greater than or equal to the specified <c> startKey </c> and less than the specified <c> endKey </c> . Changes to the returned sorted map are reflected in this sorted map and vice versa. </para><para>Note: The returned map will not allow an insertion of a key outside the specified range.</para><para></para></para><para>Equivalent to <c> subMap(fromKey, true, toKey, false) </c> .</para><para></para></para><para>Equivalent to <c> subMap(fromKey, true, toKey, false) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sorted map with the key from the specified range. </para>
				/// </returns>
				/// <java-name>
				/// subMap
				/// </java-name>
				[Dot42.DexImport("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1, Signature = "(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
				public virtual global::Java.Util.ISortedMap<K, V> SubMap(K fromKey, K toKey) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a view of the portion of this map whose keys are less than (or equal to, if <c> inclusive </c> is true) <c> toKey </c> . The returned map is backed by this map, so changes in the returned map are reflected in this map, and vice-versa. The returned map supports all optional map operations that this map supports.</para><para>The returned map will throw an <c> IllegalArgumentException </c> on an attempt to insert a key outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this map whose keys are less than (or equal to, if <c> inclusive </c> is true) <c> toKey </c> </para>
				/// </returns>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> HeadMap(K toKey, bool inclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <summary>
				/// <para><para><para>Returns a sorted map over a range of this sorted map with all keys that are less than the specified <c> endKey </c> . Changes to the returned sorted map are reflected in this sorted map and vice versa. </para><para>Note: The returned map will not allow an insertion of a key outside the specified range.</para><para></para></para><para>Equivalent to <c> headMap(toKey, false) </c> .</para><para></para></para><para>Equivalent to <c> headMap(toKey, false) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sorted map where the keys are less than <c> endKey </c> . </para>
				/// </returns>
				/// <java-name>
				/// headMap
				/// </java-name>
				[Dot42.DexImport("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				public virtual global::Java.Util.ISortedMap<K, V> HeadMap(K toKey) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a view of the portion of this map whose keys are greater than (or equal to, if <c> inclusive </c> is true) <c> fromKey </c> . The returned map is backed by this map, so changes in the returned map are reflected in this map, and vice-versa. The returned map supports all optional map operations that this map supports.</para><para>The returned map will throw an <c> IllegalArgumentException </c> on an attempt to insert a key outside its range.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this map whose keys are greater than (or equal to, if <c> inclusive </c> is true) <c> fromKey </c> </para>
				/// </returns>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> TailMap(K fromKey, bool inclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <summary>
				/// <para><para><para>Returns a sorted map over a range of this sorted map with all keys that are greater than or equal to the specified <c> startKey </c> . Changes to the returned sorted map are reflected in this sorted map and vice versa. </para><para>Note: The returned map will not allow an insertion of a key outside the specified range.</para><para></para></para><para>Equivalent to <c> tailMap(fromKey, true) </c> .</para><para></para></para><para>Equivalent to <c> tailMap(fromKey, true) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sorted map where the keys are greater or equal to <c> startKey </c> . </para>
				/// </returns>
				/// <java-name>
				/// tailMap
				/// </java-name>
				[Dot42.DexImport("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", AccessFlags = 1, Signature = "(TK;)Ljava/util/SortedMap<TK;TV;>;")]
				public virtual global::Java.Util.ISortedMap<K, V> TailMap(K fromKey) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a reverse order view of the mappings contained in this map. The descending map is backed by this map, so changes to the map are reflected in the descending map, and vice-versa. If either map is modified while an iteration over a collection view of either map is in progress (except through the iterator's own <c> remove </c> operation), the results of the iteration are undefined.</para><para>The returned map has an ordering equivalent to <code>Collections.reverseOrder(comparator())</code>. The expression <c> m.descendingMap().descendingMap() </c> returns a view of <c> m </c> essentially equivalent to <c> m </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a reverse order view of this map </para>
				/// </returns>
				/// <java-name>
				/// descendingMap
				/// </java-name>
				[Dot42.DexImport("descendingMap", "()Ljava/util/NavigableMap;", AccessFlags = 1, Signature = "()Ljava/util/NavigableMap<TK;TV;>;")]
				public virtual global::Java.Util.INavigableMap<K, V> DescendingMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableMap<K, V>);
				}

				/// <summary>
				/// <para>Returns a reverse order NavigableSet view of the keys contained in this map. The set's iterator returns the keys in descending order. The set is backed by the map, so changes to the map are reflected in the set, and vice-versa. If the map is modified while an iteration over the set is in progress (except through the iterator's own <c>       remove </c> operation), the results of the iteration are undefined. The set supports element removal, which removes the corresponding mapping from the map, via the <c> Iterator.remove </c> , <c> Set.remove </c> , <c> removeAll </c> , <c> retainAll </c> , and <c> clear </c> operations. It does not support the <c> add </c> or <c> addAll </c> operations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a reverse order navigable set view of the keys in this map </para>
				/// </returns>
				/// <java-name>
				/// descendingKeySet
				/// </java-name>
				[Dot42.DexImport("descendingKeySet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TK;>;")]
				public virtual global::Java.Util.INavigableSet<K> DescendingKeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<K>);
				}

				[Dot42.DexImport("java/util/Map", "containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool ContainsValue(object value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

		}

		/// <summary>
		/// <para>TreeSet is an implementation of SortedSet. All optional operations (adding and removing) are supported. The elements can be any objects which are comparable to each other either using their natural order or a specified Comparator.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/TreeSet
		/// </java-name>
		[Dot42.DexImport("java/util/TreeSet", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/util/NavigableSet<TE;>;Lj" +
    "ava/lang/Cloneable;Ljava/io/Serializable;")]
		public partial class TreeSet<E> : global::Java.Util.AbstractSet<E>, global::Java.Util.INavigableSet<E>, global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty instance of <c> TreeSet </c> which uses natural ordering. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TreeSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> TreeSet </c> containing the elements of the specified SortedSet and using the same Comparator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)V")]
				public TreeSet(global::Java.Util.ICollection<E> set) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> TreeSet </c> containing the elements of the specified SortedSet and using the same Comparator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TE;>;)V")]
				public TreeSet(global::Java.Util.IComparator<E> set) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance of <c> TreeSet </c> containing the elements of the specified SortedSet and using the same Comparator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/SortedSet;)V", AccessFlags = 1, Signature = "(Ljava/util/SortedSet<TE;>;)V")]
				public TreeSet(global::Java.Util.ISortedSet<E> set) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified object to this <c> TreeSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> when this <c> TreeSet </c> did not already contain the object, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public override bool Add(E @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the objects in the specified collection to this <c> TreeSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> TreeSet </c> was modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)Z", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TE;>;)Z")]
				public override bool AddAll(global::Java.Util.ICollection<E> collection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all elements from this <c> TreeSet </c> , leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>size </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> TreeSet </c> with the same elements, size and comparator as this <c> TreeSet </c> .</para><para><para>java.lang.Cloneable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a shallow copy of this <c> TreeSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the comparator used to compare elements in this <c> TreeSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Comparator or null if the natural ordering is used </para>
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
				/// <para>Searches this <c> TreeSet </c> for the specified object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> is an element of this <c> TreeSet </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Contains(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this <c> TreeSet </c> has no element, otherwise false.</para><para><para>size </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this <c> TreeSet </c> has no element. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public override bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an Iterator on the elements of this <c> TreeSet </c> .</para><para><para>Iterator </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an Iterator on the elements of this <c> TreeSet </c> . </para>
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
				/// <para><para>Returns an iterator over the elements in this set, in descending order. Equivalent in effect to <c> descendingSet().iterator() </c> .</para><para></para></para><para><para>java.util.NavigableSet::descendingIterator() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an iterator over the elements in this set, in descending order</para>
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
				/// <para>Removes an occurrence of the specified object from this <c> TreeSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> TreeSet </c> was modified, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of elements in this <c> TreeSet </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements in this <c> TreeSet </c> . </para>
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
				/// <para>Returns the first element in this set. </para>        
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
				/// <para>Returns the last element in this set. </para>        
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
				/// <para><para>Retrieves and removes the first (lowest) element, or returns <c> null </c> if this set is empty.</para><para></para></para><para><para>java.util.NavigableSet::pollFirst() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first element, or <c> null </c> if this set is empty</para>
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
				/// <para><para>Retrieves and removes the last (highest) element, or returns <c> null </c> if this set is empty.</para><para></para></para><para><para>java.util.NavigableSet::pollLast() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last element, or <c> null </c> if this set is empty</para>
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
				/// <para><para>Returns the least element in this set strictly greater than the given element, or <c> null </c> if there is no such element.</para><para></para></para><para><para>java.util.NavigableSet::higher(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least element greater than <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// higher
				/// </java-name>
				[Dot42.DexImport("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Higher(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para><para>Returns the greatest element in this set strictly less than the given element, or <c> null </c> if there is no such element.</para><para></para></para><para><para>java.util.NavigableSet::lower(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest element less than <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// lower
				/// </java-name>
				[Dot42.DexImport("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Lower(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para><para>Returns the least element in this set greater than or equal to the given element, or <c> null </c> if there is no such element.</para><para></para></para><para><para>java.util.NavigableSet::ceiling(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the least element greater than or equal to <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// ceiling
				/// </java-name>
				[Dot42.DexImport("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Ceiling(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para><para>Returns the greatest element in this set less than or equal to the given element, or <c> null </c> if there is no such element.</para><para></para></para><para><para>java.util.NavigableSet::floor(java.lang.Object) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest element less than or equal to <c> e </c> , or <c> null </c> if there is no such element </para>
				/// </returns>
				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(TE;)TE;")]
				public virtual E Floor(E e) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para><para>Returns a reverse order view of the elements contained in this set. The descending set is backed by this set, so changes to the set are reflected in the descending set, and vice-versa. If either set is modified while an iteration over either set is in progress (except through the iterator's own <c> remove </c> operation), the results of the iteration are undefined.</para><para>The returned set has an ordering equivalent to <code>Collections.reverseOrder(comparator())</code>. The expression <c> s.descendingSet().descendingSet() </c> returns a view of <c> s </c> essentially equivalent to <c> s </c> .</para><para></para></para><para><para>java.util.NavigableSet::descendingSet() </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a reverse order view of this set</para>
				/// </returns>
				/// <java-name>
				/// descendingSet
				/// </java-name>
				[Dot42.DexImport("descendingSet", "()Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "()Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> DescendingSet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				/// <para><para>Returns a view of the portion of this set whose elements range from <c> fromElement </c> to <c> toElement </c> . If <c> fromElement </c> and <c> toElement </c> are equal, the returned set is empty unless <c>       fromExclusive </c> and <c> toExclusive </c> are both true. The returned set is backed by this set, so changes in the returned set are reflected in this set, and vice-versa. The returned set supports all optional set operations that this set supports.</para><para>The returned set will throw an <c> IllegalArgumentException </c> on an attempt to insert an element outside its range.</para><para></para></para><para><para>java.util.NavigableSet::subSet(Object, boolean, Object, boolean) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this set whose elements range from <c> fromElement </c> , inclusive, to <c> toElement </c> , exclusive </para>
				/// </returns>
				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> SubSet(E start, bool startInclusive, E end, bool endInclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				/// <para><para>Returns a view of the portion of this set whose elements are less than (or equal to, if <c> inclusive </c> is true) <c> toElement </c> . The returned set is backed by this set, so changes in the returned set are reflected in this set, and vice-versa. The returned set supports all optional set operations that this set supports.</para><para>The returned set will throw an <c> IllegalArgumentException </c> on an attempt to insert an element outside its range.</para><para></para></para><para><para>java.util.NavigableSet::headSet(Object, boolean) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this set whose elements are less than (or equal to, if <c> inclusive </c> is true) <c> toElement </c> </para>
				/// </returns>
				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> HeadSet(E end, bool endInclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				/// <para><para>Returns a view of the portion of this set whose elements are greater than (or equal to, if <c> inclusive </c> is true) <c> fromElement </c> . The returned set is backed by this set, so changes in the returned set are reflected in this set, and vice-versa. The returned set supports all optional set operations that this set supports.</para><para>The returned set will throw an <c> IllegalArgumentException </c> on an attempt to insert an element outside its range.</para><para></para></para><para><para>java.util.NavigableSet::tailSet(Object, boolean) </para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a view of the portion of this set whose elements are greater than or equal to <c> fromElement </c> </para>
				/// </returns>
				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", AccessFlags = 1, Signature = "(TE;Z)Ljava/util/NavigableSet<TE;>;")]
				public virtual global::Java.Util.INavigableSet<E> TailSet(E start, bool startInclusive) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.INavigableSet<E>);
				}

				/// <summary>
				/// <para>Returns a <c> SortedSet </c> of the specified portion of this <c> TreeSet </c> which contains elements greater or equal to the start element but less than the end element. The returned SortedSet is backed by this TreeSet so changes to one are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subset where the elements are greater or equal to <code>start</code> and less than <code>end</code></para>
				/// </returns>
				/// <java-name>
				/// subSet
				/// </java-name>
				[Dot42.DexImport("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1, Signature = "(TE;TE;)Ljava/util/SortedSet<TE;>;")]
				public virtual global::Java.Util.ISortedSet<E> SubSet(E start, E end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <summary>
				/// <para>Returns a <c> SortedSet </c> of the specified portion of this <c> TreeSet </c> which contains elements less than the end element. The returned SortedSet is backed by this TreeSet so changes to one are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subset where the elements are less than <code>end</code></para>
				/// </returns>
				/// <java-name>
				/// headSet
				/// </java-name>
				[Dot42.DexImport("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				public virtual global::Java.Util.ISortedSet<E> HeadSet(E end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISortedSet<E>);
				}

				/// <summary>
				/// <para>Returns a <c> SortedSet </c> of the specified portion of this <c> TreeSet </c> which contains elements greater or equal to the start element. The returned SortedSet is backed by this TreeSet so changes to one are reflected by the other.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a subset where the elements are greater or equal to <code>start</code></para>
				/// </returns>
				/// <java-name>
				/// tailSet
				/// </java-name>
				[Dot42.DexImport("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", AccessFlags = 1, Signature = "(TE;)Ljava/util/SortedSet<TE;>;")]
				public virtual global::Java.Util.ISortedSet<E> TailSet(E start) /* MethodBuilder.Create */ 
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>This class provides skeletal implementations of some Queue operations. The implementations in this class are appropriate when the base implementation does <b>not</b> allow <code>null</code> elements. Methods add, remove, and element are based on offer, poll, and peek, respectively, but throw exceptions instead of indicating failure via <code>false</code> or <code>null</code> returns.</para><para>A <code>Queue</code> implementation that extends this class must minimally define a method Queue#offer which does not permit insertion of <code>null</code> elements, along with methods Queue#peek, Queue#poll, Collection#size, and Collection#iterator. Typically, additional methods will be overridden as well. If these requirements cannot be met, consider instead subclassing AbstractCollection.</para><para><para>1.5 </para><para>Doug Lea </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/AbstractQueue
		/// </java-name>
		[Dot42.DexImport("java/util/AbstractQueue", AccessFlags = 1057, Signature = "<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/util/Queue<TE;>;")]
		public abstract partial class AbstractQueue<E> : global::Java.Util.AbstractCollection<E>, global::Java.Util.IQueue<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for use by subclasses. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inserts the specified element into this queue if it is possible to do so immediately without violating capacity restrictions, returning <code>true</code> upon success and throwing an <code>IllegalStateException</code> if no space is currently available.</para><para>This implementation returns <code>true</code> if <code>offer</code> succeeds, else throws an <code>IllegalStateException</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> (as specified by Collection#add) </para>
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
				/// <para>Adds all of the elements in the specified collection to this queue. Attempts to addAll of a queue to itself result in <code>IllegalArgumentException</code>. Further, the behavior of this operation is undefined if the specified collection is modified while the operation is in progress.</para><para>This implementation iterates over the specified collection, and adds each element returned by the iterator to this queue, in turn. A runtime exception encountered while trying to add an element (including, in particular, a <code>null</code> element) may result in only some of the elements having been successfully added when the associated exception is thrown.</para><para><para>#add(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this queue changed as a result of the call </para>
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
				/// <para>Retrieves and removes the head of this queue. This method differs from poll only in that it throws an exception if this queue is empty.</para><para>This implementation returns the result of <code>poll</code> unless the queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Remove() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Retrieves, but does not remove, the head of this queue. This method differs from peek only in that it throws an exception if this queue is empty.</para><para>This implementation returns the result of <code>peek</code> unless the queue is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the head of this queue </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TE;")]
				public virtual E Element() /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				/// <para>Removes all of the elements from this queue. The queue will be empty after this call returns.</para><para>This implementation repeatedly invokes poll until it returns <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
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

				[Dot42.DexImport("java/util/Collection", "isEmpty", "()Z", AccessFlags = 1025)]
				public override bool IsEmpty() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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
				public override T[] ToArray<T>(T[] array) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T[]);
				}

		}

		/// <summary>
		/// <para>LinkedHashMap is an implementation of Map that guarantees iteration order. All optional operations are supported.</para><para>All elements are permitted as keys or values, including null.</para><para>Entries are kept in a doubly-linked list. The iteration order is, by default, the order in which keys were inserted. Reinserting an already-present key doesn't change the order. If the three argument constructor is used, and <c> accessOrder </c> is specified as <c> true </c> , the iteration will be in the order that entries were accessed. The access order is affected by <c> put </c> , <c> get </c> , and <c> putAll </c> operations, but not by operations on the collection views.</para><para>Note: the implementation of <c> LinkedHashMap </c> is not synchronized. If one thread of several threads accessing an instance modifies the map structurally, access to the map needs to be synchronized. For insertion-ordered instances a structural modification is an operation that removes or adds an entry. Access-ordered instances also are structurally modified by <c> put </c> , <c> get </c> , and <c> putAll </c> since these methods change the order of the entries. Changes in the value of an entry are not structural changes.</para><para>The <c> Iterator </c> created by calling the <c> iterator </c> method may throw a <c> ConcurrentModificationException </c> if the map is structurally changed while an iterator is used to iterate over the elements. Only the <c> remove </c> method that is provided by the iterator allows for removal of elements during iteration. It is not possible to guarantee that this mechanism works in all cases of unsynchronized concurrent modification. It should only be used for debugging purposes. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/LinkedHashMap
		/// </java-name>
		[Dot42.DexImport("java/util/LinkedHashMap", AccessFlags = 33, Signature = "<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/HashMap<TK;TV;>;")]
		public partial class LinkedHashMap<K, V> : global::Java.Util.HashMap<K, V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new empty <c> LinkedHashMap </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkedHashMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> LinkedHashMap </c> instance with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public LinkedHashMap(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> LinkedHashMap </c> instance with the specified capacity and load factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IF)V", AccessFlags = 1)]
				public LinkedHashMap(int initialCapacity, float loadFactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> LinkedHashMap </c> instance with the specified capacity, load factor and a flag specifying the ordering behavior.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IFZ)V", AccessFlags = 1)]
				public LinkedHashMap(int initialCapacity, float loadFactor, bool accessOrder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> LinkedHashMap </c> instance with the specified capacity.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+TK;+TV;>;)V")]
				public LinkedHashMap(global::Java.Util.IMap<K, V> initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the value of the mapping with the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the mapping with the specified key, or <c> null </c> if no mapping for the specified key is found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TV;")]
				public override V Get(object key) /* MethodBuilder.Create */ 
				{
						return default(V);
				}

				/// <summary>
				/// <para>This override is done for LinkedHashMap performance: iteration is cheaper via LinkedHashMap nxt links. </para>        
				/// </summary>
				/// <java-name>
				/// containsValue
				/// </java-name>
				[Dot42.DexImport("containsValue", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool ContainsValue(object value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all mappings from this hash map, leaving it empty.</para><para><para>isEmpty </para><simplesectsep></simplesectsep><para>#size </para></para>        
				/// </summary>
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
				protected internal virtual bool RemoveEldestEntry(global::Java.Util.IMap_IEntry<K, V> eldest) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para><c> GregorianCalendar </c> is a concrete subclass of Calendar and provides the standard calendar used by most of the world.</para><para>The standard (Gregorian) calendar has 2 eras, BC and AD.</para><para>This implementation handles a single discontinuity, which corresponds by default to the date the Gregorian calendar was instituted (October 15, 1582 in some countries, later in others). The cutover date may be changed by the caller by calling <c> setGregorianChange() </c> .</para><para>Historically, in those countries which adopted the Gregorian calendar first, October 4, 1582 was thus followed by October 15, 1582. This calendar models this correctly. Before the Gregorian cutover, <c> GregorianCalendar </c> implements the Julian calendar. The only difference between the Gregorian and the Julian calendar is the leap year rule. The Julian calendar specifies leap years every four years, whereas the Gregorian calendar omits century years which are not divisible by 400.</para><para><c> GregorianCalendar </c> implements <b>proleptic</b> Gregorian and Julian calendars. That is, dates are computed by extrapolating the current rules indefinitely far backward and forward in time. As a result, <c> GregorianCalendar </c> may be used for all years to generate meaningful and consistent results. However, dates obtained using <c> GregorianCalendar </c> are historically accurate only from March 1, 4 AD onward, when modern Julian calendar rules were adopted. Before this date, leap year rules were applied irregularly, and before 45 BC the Julian calendar did not even exist.</para><para>Prior to the institution of the Gregorian calendar, New Year's Day was March<ol><li><para>To avoid confusion, this calendar always uses January 1. A manual adjustment may be made if desired for dates that are prior to the Gregorian changeover and which fall between January 1 and March 24.</para></li></ol></para><para>Values calculated for the <c> WEEK_OF_YEAR </c> field range from 1 to<ol><li><para>Week 1 for a year is the earliest seven day period starting on <c> getFirstDayOfWeek() </c> that contains at least <c> getMinimalDaysInFirstWeek() </c> days from that year. It thus depends on the values of <c> getMinimalDaysInFirstWeek() </c> , <c> getFirstDayOfWeek() </c> , and the day of the week of January 1. Weeks between week 1 of one year and week 1 of the following year are numbered sequentially from 2 to 52 or 53 (as needed).</para></li></ol></para><para>For example, January 1, 1998 was a Thursday. If <c> getFirstDayOfWeek() </c> is <c> MONDAY </c> and <c> getMinimalDaysInFirstWeek() </c> is 4 (these are the values reflecting ISO 8601 and many national standards), then week 1 of 1998 starts on December 29, 1997, and ends on January 4, 1998. If, however, <c> getFirstDayOfWeek() </c> is <c> SUNDAY </c> , then week 1 of 1998 starts on January 4, 1998, and ends on January 10, 1998; the first three days of 1998 then are part of week 53 of 1997.</para><para>Values calculated for the <c> WEEK_OF_MONTH </c> field range from 0 or 1 to 4 or 5. Week 1 of a month (the days with <code>WEEK_OF_MONTH = 1</code>) is the earliest set of at least <c> getMinimalDaysInFirstWeek() </c> contiguous days in that month, ending on the day before <c> getFirstDayOfWeek() </c> . Unlike week 1 of a year, week 1 of a month may be shorter than 7 days, need not start on <c> getFirstDayOfWeek() </c> , and will not include days of the previous month. Days of a month before week 1 have a <c> WEEK_OF_MONTH </c> of 0.</para><para>For example, if <c> getFirstDayOfWeek() </c> is <c> SUNDAY </c> and <c> getMinimalDaysInFirstWeek() </c> is 4, then the first week of January 1998 is Sunday, January 4 through Saturday, January 10. These days have a <c> WEEK_OF_MONTH </c> of 1. Thursday, January 1 through Saturday, January 3 have a <c> WEEK_OF_MONTH </c> of 0. If <c> getMinimalDaysInFirstWeek() </c> is changed to 3, then January 1 through January 3 have a <c> WEEK_OF_MONTH </c> of 1.</para><para><b>Example:</b> <blockquote><para></para><para><pre>
		///    // get the supported ids for GMT-08:00 (Pacific Standard Time)
		///    String[] ids = TimeZone.getAvailableIDs(-8 * 60 * 60 * 1000);
		///    // if no ids were returned, something is wrong. get out.
		///    if (ids.length == 0)
		///        System.exit(0);
		/// 
		///     // begin output
		///    System.out.println("Current Time");
		/// 
		///    // create a Pacific Standard Time time zone
		///    SimpleTimeZone pdt = new SimpleTimeZone(-8 * 60 * 60 * 1000, ids[0]);
		/// 
		///    // set up rules for daylight savings time
		///    pdt.setStartRule(Calendar.APRIL, 1, Calendar.SUNDAY, 2 * 60 * 60 * 1000);
		///    pdt.setEndRule(Calendar.OCTOBER, -1, Calendar.SUNDAY, 2 * 60 * 60 * 1000);
		/// 
		///    // create a GregorianCalendar with the Pacific Daylight time zone
		///    // and the current date and time
		///    Calendar calendar = new GregorianCalendar(pdt);
		///    Date trialTime = new Date();
		///    calendar.setTime(trialTime);
		/// 
		///    // print out a bunch of interesting things
		///    System.out.println("ERA: " + calendar.get(Calendar.ERA));
		///    System.out.println("YEAR: " + calendar.get(Calendar.YEAR));
		///    System.out.println("MONTH: " + calendar.get(Calendar.MONTH));
		///    System.out.println("WEEK_OF_YEAR: " + calendar.get(Calendar.WEEK_OF_YEAR));
		///    System.out.println("WEEK_OF_MONTH: " + calendar.get(Calendar.WEEK_OF_MONTH));
		///    System.out.println("DATE: " + calendar.get(Calendar.DATE));
		///    System.out.println("DAY_OF_MONTH: " + calendar.get(Calendar.DAY_OF_MONTH));
		///    System.out.println("DAY_OF_YEAR: " + calendar.get(Calendar.DAY_OF_YEAR));
		///    System.out.println("DAY_OF_WEEK: " + calendar.get(Calendar.DAY_OF_WEEK));
		///    System.out.println("DAY_OF_WEEK_IN_MONTH: "<ul>
		/// <li><para>calendar.get(Calendar.DAY_OF_WEEK_IN_MONTH));
		///    System.out.println("AM_PM: " + calendar.get(Calendar.AM_PM));
		///    System.out.println("HOUR: " + calendar.get(Calendar.HOUR));
		///    System.out.println("HOUR_OF_DAY: " + calendar.get(Calendar.HOUR_OF_DAY));
		///    System.out.println("MINUTE: " + calendar.get(Calendar.MINUTE));
		///    System.out.println("SECOND: " + calendar.get(Calendar.SECOND));
		///    System.out.println("MILLISECOND: " + calendar.get(Calendar.MILLISECOND));
		///    System.out.println("ZONE_OFFSET: "</para></li><li><para>(calendar.get(Calendar.ZONE_OFFSET)/(60*60*1000)));
		///    System.out.println("DST_OFFSET: "</para></li><li><para>(calendar.get(Calendar.DST_OFFSET)/(60*60*1000)));</para></li></ul>
		/// 
		/// 
		///    System.out.println("Current Time, with hour reset to 3");
		///    calendar.clear(Calendar.HOUR_OF_DAY); // so doesn't override
		///    calendar.set(Calendar.HOUR, 3);
		///    System.out.println("ERA: " + calendar.get(Calendar.ERA));
		///    System.out.println("YEAR: " + calendar.get(Calendar.YEAR));
		///    System.out.println("MONTH: " + calendar.get(Calendar.MONTH));
		///    System.out.println("WEEK_OF_YEAR: " + calendar.get(Calendar.WEEK_OF_YEAR));
		///    System.out.println("WEEK_OF_MONTH: " + calendar.get(Calendar.WEEK_OF_MONTH));
		///    System.out.println("DATE: " + calendar.get(Calendar.DATE));
		///    System.out.println("DAY_OF_MONTH: " + calendar.get(Calendar.DAY_OF_MONTH));
		///    System.out.println("DAY_OF_YEAR: " + calendar.get(Calendar.DAY_OF_YEAR));
		///    System.out.println("DAY_OF_WEEK: " + calendar.get(Calendar.DAY_OF_WEEK));
		///    System.out.println("DAY_OF_WEEK_IN_MONTH: "<ul>
		/// <li><para>calendar.get(Calendar.DAY_OF_WEEK_IN_MONTH));
		///    System.out.println("AM_PM: " + calendar.get(Calendar.AM_PM));
		///    System.out.println("HOUR: " + calendar.get(Calendar.HOUR));
		///    System.out.println("HOUR_OF_DAY: " + calendar.get(Calendar.HOUR_OF_DAY));
		///    System.out.println("MINUTE: " + calendar.get(Calendar.MINUTE));
		///    System.out.println("SECOND: " + calendar.get(Calendar.SECOND));
		///    System.out.println("MILLISECOND: " + calendar.get(Calendar.MILLISECOND));
		///    System.out.println("ZONE_OFFSET: "</para></li></ul>
		/// </pre></para></blockquote></para><para><pre>(calendar.get(Calendar.ZONE_OFFSET)/(60*60*1000))); // in hours
		///    System.out.println("DST_OFFSET: "<ul>
		/// <li><para>(calendar.get(Calendar.DST_OFFSET)/(60*60*1000))); // in hours
		///    </para></li></ul>
		/// 
		/// 
		///    
		/// 
		/// 
		/// 
		///    <para>Calendar
		///    </para><simplesectsep></simplesectsep><para>TimeZone
		/// </para>
		/// </pre></para>    
		/// </summary>
		/// <java-name>
		/// java/util/GregorianCalendar
		/// </java-name>
		[Dot42.DexImport("java/util/GregorianCalendar", AccessFlags = 33)]
		public partial class GregorianCalendar : global::Java.Util.Calendar
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Value for the BC era. </para>        
				/// </summary>
				/// <java-name>
				/// BC
				/// </java-name>
				[Dot42.DexImport("BC", "I", AccessFlags = 25)]
				public const int BC = 0;
				/// <summary>
				/// <para>Value for the AD era. </para>        
				/// </summary>
				/// <java-name>
				/// AD
				/// </java-name>
				[Dot42.DexImport("AD", "I", AccessFlags = 25)]
				public const int AD = 1;
				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to the current date and time with the default <c> Locale </c> and <c> TimeZone </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GregorianCalendar() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to midnight in the default <c> TimeZone </c> and <c> Locale </c> on the specified date.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public GregorianCalendar(int year, int month, int day) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to the specified date and time in the default <c> TimeZone </c> and <c> Locale </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public GregorianCalendar(int year, int month, int day, int hour, int minute) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to the specified date and time in the default <c> TimeZone </c> and <c> Locale </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIIII)V", AccessFlags = 1)]
				public GregorianCalendar(int year, int month, int day, int hour, int minute, int second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to the current date and time and using the specified <c> Locale </c> and the default <c> TimeZone </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public GregorianCalendar(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to the current date and time and using the specified <c> Locale </c> and the default <c> TimeZone </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
				public GregorianCalendar(global::Java.Util.TimeZone locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> GregorianCalendar </c> initialized to the current date and time and using the specified <c> TimeZone </c> and <c> Locale </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V", AccessFlags = 1)]
				public GregorianCalendar(global::Java.Util.TimeZone timezone, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified amount to a <c> Calendar </c> field.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(II)V", AccessFlags = 1)]
				public override void Add(int field, int value) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Computes the <c> Calendar </c> fields from <c> time </c> . </para>        
				/// </summary>
				/// <java-name>
				/// computeFields
				/// </java-name>
				[Dot42.DexImport("computeFields", "()V", AccessFlags = 4)]
				protected internal override void ComputeFields() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes <c> time </c> from the Calendar fields.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// computeTime
				/// </java-name>
				[Dot42.DexImport("computeTime", "()V", AccessFlags = 4)]
				protected internal override void ComputeTime() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if <c> object </c> is a GregorianCalendar with the same properties. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the maximum value of the given field for the current date. For example, the maximum number of days in the current month. </para>        
				/// </summary>
				/// <java-name>
				/// getActualMaximum
				/// </java-name>
				[Dot42.DexImport("getActualMaximum", "(I)I", AccessFlags = 1)]
				public override int GetActualMaximum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the minimum value of the specified field for the current date. For the gregorian calendar, this value is the same as <c> getMinimum() </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum value of the specified field. </para>
				/// </returns>
				/// <java-name>
				/// getActualMinimum
				/// </java-name>
				[Dot42.DexImport("getActualMinimum", "(I)I", AccessFlags = 1)]
				public override int GetActualMinimum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the greatest minimum value of the specified field. For the gregorian calendar, this value is the same as <c> getMinimum() </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest minimum value of the specified field. </para>
				/// </returns>
				/// <java-name>
				/// getGreatestMinimum
				/// </java-name>
				[Dot42.DexImport("getGreatestMinimum", "(I)I", AccessFlags = 1)]
				public override int GetGreatestMinimum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the gregorian change date of this calendar. This is the date on which the gregorian calendar came into effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Date </c> which represents the gregorian change date. </para>
				/// </returns>
				/// <java-name>
				/// getGregorianChange
				/// </java-name>
				[Dot42.DexImport("getGregorianChange", "()Ljava/util/Date;", AccessFlags = 17)]
				public global::Java.Util.Date GetGregorianChange() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Gets the smallest maximum value of the specified field. For example, 28 for the day of month field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the smallest maximum value of the specified field. </para>
				/// </returns>
				/// <java-name>
				/// getLeastMaximum
				/// </java-name>
				[Dot42.DexImport("getLeastMaximum", "(I)I", AccessFlags = 1)]
				public override int GetLeastMaximum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the greatest maximum value of the specified field. For example, 31 for the day of month field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the greatest maximum value of the specified field. </para>
				/// </returns>
				/// <java-name>
				/// getMaximum
				/// </java-name>
				[Dot42.DexImport("getMaximum", "(I)I", AccessFlags = 1)]
				public override int GetMaximum(int field) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the smallest minimum value of the specified field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the smallest minimum value of the specified field. </para>
				/// </returns>
				/// <java-name>
				/// getMinimum
				/// </java-name>
				[Dot42.DexImport("getMinimum", "(I)I", AccessFlags = 1)]
				public override int GetMinimum(int field) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns true if <c> year </c> is a leap year. </para>        
				/// </summary>
				/// <java-name>
				/// isLeapYear
				/// </java-name>
				[Dot42.DexImport("isLeapYear", "(I)Z", AccessFlags = 1)]
				public virtual bool IsLeapYear(int year) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds the specified amount the specified field and wraps the value of the field when it goes beyond the maximum or minimum value for the current date. Other fields will be adjusted as required to maintain a consistent date.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(II)V", AccessFlags = 1)]
				public override void Roll(int field, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified amount the specified field and wraps the value of the field when it goes beyond the maximum or minimum value for the current date. Other fields will be adjusted as required to maintain a consistent date.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// roll
				/// </java-name>
				[Dot42.DexImport("roll", "(IZ)V", AccessFlags = 1)]
				public override void Roll(int field, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the gregorian change date of this calendar. </para>        
				/// </summary>
				/// <java-name>
				/// setGregorianChange
				/// </java-name>
				[Dot42.DexImport("setGregorianChange", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void SetGregorianChange(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFirstDayOfWeek
				/// </java-name>
				[Dot42.DexImport("setFirstDayOfWeek", "(I)V", AccessFlags = 1)]
				public override void SetFirstDayOfWeek(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinimalDaysInFirstWeek
				/// </java-name>
				[Dot42.DexImport("setMinimalDaysInFirstWeek", "(I)V", AccessFlags = 1)]
				public override void SetMinimalDaysInFirstWeek(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the gregorian change date of this calendar. This is the date on which the gregorian calendar came into effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Date </c> which represents the gregorian change date. </para>
				/// </returns>
				/// <java-name>
				/// getGregorianChange
				/// </java-name>
				public global::Java.Util.Date GregorianChange
				{
				[Dot42.DexImport("getGregorianChange", "()Ljava/util/Date;", AccessFlags = 17)]
						get{ return GetGregorianChange(); }
				[Dot42.DexImport("setGregorianChange", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ SetGregorianChange(value); }
				}

		}

		/// <summary>
		/// <para>An <c> ConcurrentModificationException </c> is thrown when a Collection is modified and an existing iterator on the Collection is used to modify the Collection as well.</para><para><para>java.lang.RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/ConcurrentModificationException
		/// </java-name>
		[Dot42.DexImport("java/util/ConcurrentModificationException", AccessFlags = 33)]
		public partial class ConcurrentModificationException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> ConcurrentModificationException </c> with the current stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConcurrentModificationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConcurrentModificationException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Classes that handle custom formatting for the 's' specifier of <c> Formatter </c> should implement the <c> Formattable </c> interface. It gives basic control over formatting objects.</para><para><para>Formatter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Formattable
		/// </java-name>
		[Dot42.DexImport("java/util/Formattable", AccessFlags = 1537)]
		public partial interface IFormattable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Formats the object using the specified <c> Formatter </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// formatTo
				/// </java-name>
				[Dot42.DexImport("formatTo", "(Ljava/util/Formatter;III)V", AccessFlags = 1025)]
				void FormatTo(global::Java.Util.Formatter formatter, int flags, int width, int precision) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Thrown when a service provider can't be loaded by ServiceLoader. <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/ServiceConfigurationError
		/// </java-name>
		[Dot42.DexImport("java/util/ServiceConfigurationError", AccessFlags = 33)]
		public partial class ServiceConfigurationError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new error with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ServiceConfigurationError(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new error with the given detail message and cause. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ServiceConfigurationError(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ServiceConfigurationError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Timers schedule one-shot or recurring tasks for execution. Prefer ScheduledThreadPoolExecutor for new code.</para><para>Each timer has one thread on which tasks are executed sequentially. When this thread is busy running a task, runnable tasks may be subject to delays.</para><para>One-shot are scheduled to run at an absolute time or after a relative delay.</para><para>Recurring tasks are scheduled with either a fixed period or a fixed rate: <ul><li><para>With the default <b>fixed-period execution</b>, each successive run of a task is scheduled relative to the start time of the previous run, so two runs are never fired closer together in time than the specified <c> period </c> . </para></li><li><para>With <b>fixed-rate execution</b>, the start time of each successive run of a task is scheduled without regard for when the previous run took place. This may result in a series of bunched-up runs (one launched immediately after another) if delays prevent the timer from starting tasks on time. </para></li></ul></para><para>When a timer is no longer needed, users should call cancel, which releases the timer's thread and other resources. Timers not explicitly cancelled may hold resources indefinitely.</para><para>This class does not offer guarantees about the real-time nature of task scheduling. Multiple threads can share a single timer without synchronization. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/Timer
		/// </java-name>
		[Dot42.DexImport("java/util/Timer", AccessFlags = 33)]
		public partial class Timer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new named <c> Timer </c> which may be specified to be run as a daemon thread.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public Timer(string name, bool isDaemon) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Creates a new non-daemon <c> Timer </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Timer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels the <c> Timer </c> and all scheduled tasks. If there is a currently running task it is not affected. No more tasks may be scheduled on this <c> Timer </c> . Subsequent calls do nothing. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all canceled tasks from the task queue. If there are no other references on the tasks, then after this call they are free to be garbage collected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of canceled tasks that were removed from the task queue. </para>
				/// </returns>
				/// <java-name>
				/// purge
				/// </java-name>
				[Dot42.DexImport("purge", "()I", AccessFlags = 1)]
				public virtual int Purge() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Schedule a task for single execution. If <c> when </c> is less than the current time, it will be scheduled to be executed as soon as possible.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void Schedule(global::Java.Util.TimerTask task, global::Java.Util.Date when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Schedule a task for single execution. If <c> when </c> is less than the current time, it will be scheduled to be executed as soon as possible.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// schedule
				/// </java-name>
				[Dot42.DexImport("schedule", "(Ljava/util/TimerTask;J)V", AccessFlags = 1)]
				public virtual void Schedule(global::Java.Util.TimerTask task, long when) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>A <c> Comparator </c> is used to compare two objects to determine their ordering with respect to each other. On a given <c> Collection </c> , a <c> Comparator </c> can be used to obtain a sorted <c> Collection </c> which is <b>totally ordered</b>. For a <c> Comparator </c> to be <b>consistent with equals</b>, its {code #compare(Object, Object)} method has to return zero for each pair of elements (a,b) where a.equals(b) holds true. It is recommended that a <c> Comparator </c> implements java.io.Serializable.</para><para><para>1.2 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Comparator
		/// </java-name>
		[Dot42.DexImport("java/util/Comparator", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IComparator<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Compares the two specified objects to determine their relative ordering. The ordering implied by the return value of this method for all possible pairs of <c> (lhs, rhs) </c> should form an <b>equivalence relation</b>. This means that <ul><li><para><c> compare(a,a) </c> returns zero for all <c> a </c>  </para></li><li><para>the sign of <c> compare(a,b) </c> must be the opposite of the sign of <c>       compare(b,a) </c> for all pairs of (a,b) </para></li><li><para>From <c> compare(a,b) &gt; 0 </c> and <c> compare(b,c) &gt; 0 </c> it must follow <c> compare(a,c) &gt; 0 </c> for all possible combinations of <c>       (a,b,c) </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an integer &lt; 0 if <c> lhs </c> is less than <c> rhs </c> , 0 if they are equal, and &gt; 0 if <c> lhs </c> is greater than <c> rhs </c> . </para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", AccessFlags = 1025, Signature = "(TT;TT;)I")]
				int Compare(T lhs, T rhs) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares this <c> Comparator </c> with the specified <c> Object </c> and indicates whether they are equal. In order to be equal, <c> object </c> must represent the same object as this instance using a class-specific comparison. </para><para>A <c> Comparator </c> never needs to override this method, but may choose so for performance reasons.</para><para><para>Object::hashCode </para><simplesectsep></simplesectsep><para>Object::equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean <c> true </c> if specified <c> Object </c> is the same as this <c> Object </c> , and <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

		}

}


