// Copyright (C) 2014 dot42
//
// Original filename: Java.Util.Jar.cs
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
namespace Java.Util.Jar
{
		/// <summary>
		/// <para>The <c> Manifest </c> class is used to obtain attribute information for a <c> JarFile </c> and its entries. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/Manifest
		/// </java-name>
		[Dot42.DexImport("java/util/jar/Manifest", AccessFlags = 33)]
		public partial class Manifest : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> Manifest </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Manifest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> Manifest </c> instance using the attributes obtained from the input stream.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public Manifest(global::Java.Io.InputStream @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> Manifest </c> instance using the attributes obtained from the input stream.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/jar/Manifest;)V", AccessFlags = 1)]
				public Manifest(global::Java.Util.Jar.Manifest @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resets the both the main attributes as well as the entry attributes associated with this <c> Manifest </c> . </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Attributes </c> associated with the parameter entry <c> name </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Attributes for the entry or <c> null </c> if the entry does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetAttributes(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <summary>
				/// <para>Returns a map containing the <c> Attributes </c> for each entry in the <c> Manifest </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the map of entry attributes. </para>
				/// </returns>
				/// <java-name>
				/// getEntries
				/// </java-name>
				[Dot42.DexImport("getEntries", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/jar/Attributes;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Util.Jar.Attributes> GetEntries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.Jar.Attributes>);
				}

				/// <summary>
				/// <para>Returns the main <c> Attributes </c> of the <c> JarFile </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>main <c> Attributes </c> associated with the source <c>               JarFile </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetMainAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <summary>
				/// <para>Creates a copy of this <c> Manifest </c> . The returned <c> Manifest </c> will equal the <c> Manifest </c> from which it was cloned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of this instance. </para>
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
				/// <para>Writes out the attribute information of the receiver to the specified <c> OutputStream </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void Write(global::Java.Io.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Merges name/attribute pairs read from the input stream <c> is </c> into this manifest.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void Read(global::Java.Io.InputStream @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the hash code for this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Manifest </c> 's hashCode. </para>
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
				/// <para>Determines if the receiver is equal to the parameter object. Two <c>       Manifest </c> s are equal if they have identical main attributes as well as identical entry attributes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the manifests are equal, <c> false </c> otherwise </para>
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
				/// <para>Returns a map containing the <c> Attributes </c> for each entry in the <c> Manifest </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the map of entry attributes. </para>
				/// </returns>
				/// <java-name>
				/// getEntries
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.Jar.Attributes> Entries
				{
				[Dot42.DexImport("getEntries", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/jar/Attributes;>;")]
						get{ return GetEntries(); }
				}

				/// <summary>
				/// <para>Returns the main <c> Attributes </c> of the <c> JarFile </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>main <c> Attributes </c> associated with the source <c>               JarFile </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes MainAttributes
				{
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetMainAttributes(); }
				}

		}

		/// <summary>
		/// <para>The <c> JarOutputStream </c> is used to write data in the <c> JarFile </c> format to an arbitrary output stream </para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/JarOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarOutputStream", AccessFlags = 33)]
		public partial class JarOutputStream : global::Java.Util.Zip.ZipOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> JarOutputStream </c> using an output stream. The content of the <c> Manifest </c> must match the JAR entry information written subsequently to the stream.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/jar/Manifest;)V", AccessFlags = 1)]
				public JarOutputStream(global::Java.Io.OutputStream os, global::Java.Util.Jar.Manifest manifest) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> JarOutputStream </c> using an arbitrary output stream.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public JarOutputStream(global::Java.Io.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the specified ZIP entry to the underlying stream. The previous entry is closed if it is still open.</para><para><para>ZipEntry </para></para>        
				/// </summary>
				/// <java-name>
				/// putNextEntry
				/// </java-name>
				[Dot42.DexImport("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public override void PutNextEntry(global::Java.Util.Zip.ZipEntry ze) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The <c> Attributes </c> class is used to store values for manifest entries. Attribute keys are generally instances of <c> Attributes.Name </c> . Values associated with attribute keys are of type <c> String </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/Attributes
		/// </java-name>
		[Dot42.DexImport("java/util/jar/Attributes", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/lang/Cloneable;Ljava/util/Map<Ljava/lang/Object;Ljava/lan" +
    "g/Object;>;")]
		public partial class Attributes : global::Java.Lang.ICloneable, global::Java.Util.IMap<object, object>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The <c> Attributes </c> as name/value pairs. Maps the attribute names (as Attributes.Name) of a JAR file manifest to arbitrary values. The attribute names thus are obtained from the Manifest for convenience. </para>        
				/// </summary>
				/// <java-name>
				/// map
				/// </java-name>
				[Dot42.DexImport("map", "Ljava/util/Map;", AccessFlags = 4)]
				protected internal global::Java.Util.IMap<object, object> Map;
				/// <summary>
				/// <para>Constructs an <c> Attributes </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Attributes() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an <c> Attributes </c> instance obtaining keys and values from the parameter <c> attrib </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/jar/Attributes;)V", AccessFlags = 1)]
				public Attributes(global::Java.Util.Jar.Attributes attrib) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an <c> Attributes </c> instance obtaining keys and values from the parameter <c> attrib </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Attributes(int attrib) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all key/value pairs from this <c> Attributes </c> . </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines whether this <c> Attributes </c> contains the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the key is found, <c> false </c> otherwise. </para>
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
				/// <para>Determines whether this <c> Attributes </c> contains the specified value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the value is found, <c> false </c> otherwise. </para>
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
				/// <para>Returns a set containing map entries for each of the key/value pair contained in this <c> Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a set of Map.Entry's </para>
				/// </returns>
				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/Object;Ljava/lang/Object;>;>;")]
				public virtual global::Java.Util.ISet<global::Java.Util.IMap_IEntry<object, object>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<object, object>>);
				}

				/// <summary>
				/// <para>Returns the value associated with the parameter key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Object associated with key, or <c> null </c> if key does not exist. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(object key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Determines whether this <c> Attributes </c> contains any keys.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if one or more keys exist, <c> false </c> otherwise. </para>
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
				/// <para>Returns a <c> Set </c> containing all the keys found in this <c>       Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Set </c> of all keys. </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.ISet<object> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<object>);
				}

				/// <summary>
				/// <para>Stores key/value pairs in this <c> Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value being stored. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Put(object key, object value) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Stores all the key/value pairs in the argument in this <c>       Attributes </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<**>;)V")]
				public virtual void PutAll(global::Java.Util.IMap<object, object> attrib) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Deletes the key/value pair with key <c> key </c> from this <c>       Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the values associated with the removed key, <c> null </c> if not present. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Remove(object key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the number of key/value pairs associated with this <c>       Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of this <c> Attributes </c> . </para>
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
				/// <para>Returns a collection of all the values present in this <c>       Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a collection of all values present. </para>
				/// </returns>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.ICollection<object> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<object>);
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
				/// <para>Returns the hash code of this <c> Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code of this object. </para>
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
				/// <para>Determines if this <c> Attributes </c> and the parameter <c>       Attributes </c> are equal. Two <c> Attributes </c> instances are equal if they contain the same keys and values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the <c> Attributes </c> are equal, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/util/jar/Attributes$Name;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(global::Java.Util.Jar.Attributes.Name name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Stores the value <c> val </c> associated with the key <c> name </c> in this <c> Attributes </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value being stored. </para>
				/// </returns>
				/// <java-name>
				/// putValue
				/// </java-name>
				[Dot42.DexImport("putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string PutValue(string name, string val) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>The name part of the name/value pairs constituting an attribute as defined by the specification of the JAR manifest. May be composed of the following ASCII signs as defined in the EBNF below:</para><para><pre>
				///        name       = alphanum *headerchar
				///        headerchar = alphanum | - | _
				///        alphanum   = {A-Z} | {a-z} | {0-9}
				///        </pre> </para>    
				/// </summary>
				/// <java-name>
				/// java/util/jar/Attributes$Name
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Attributes$Name", AccessFlags = 9)]
				public partial class Name
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The class path (a main attribute). </para>        
						/// </summary>
						/// <java-name>
						/// CLASS_PATH
						/// </java-name>
						[Dot42.DexImport("CLASS_PATH", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name CLASS_PATH;
						/// <summary>
						/// <para>The version of the manifest file (a main attribute). </para>        
						/// </summary>
						/// <java-name>
						/// MANIFEST_VERSION
						/// </java-name>
						[Dot42.DexImport("MANIFEST_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name MANIFEST_VERSION;
						/// <summary>
						/// <para>The main class's name (for stand-alone applications). </para>        
						/// </summary>
						/// <java-name>
						/// MAIN_CLASS
						/// </java-name>
						[Dot42.DexImport("MAIN_CLASS", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name MAIN_CLASS;
						/// <summary>
						/// <para>Defines the signature version of the JAR file. </para>        
						/// </summary>
						/// <java-name>
						/// SIGNATURE_VERSION
						/// </java-name>
						[Dot42.DexImport("SIGNATURE_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SIGNATURE_VERSION;
						/// <summary>
						/// <para>The <c> Content-Type </c> manifest attribute. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name CONTENT_TYPE;
						/// <summary>
						/// <para>The <c> Sealed </c> manifest attribute which may have the value <c> true </c> for sealed archives. </para>        
						/// </summary>
						/// <java-name>
						/// SEALED
						/// </java-name>
						[Dot42.DexImport("SEALED", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SEALED;
						/// <summary>
						/// <para>The <c> Implementation-Title </c> attribute whose value is a string that defines the title of the extension implementation. </para>        
						/// </summary>
						/// <java-name>
						/// IMPLEMENTATION_TITLE
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_TITLE", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_TITLE;
						/// <summary>
						/// <para>The <c> Implementation-Version </c> attribute defining the version of the extension implementation. </para>        
						/// </summary>
						/// <java-name>
						/// IMPLEMENTATION_VERSION
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_VERSION;
						/// <summary>
						/// <para>The <c> Implementation-Vendor </c> attribute defining the organization that maintains the extension implementation. </para>        
						/// </summary>
						/// <java-name>
						/// IMPLEMENTATION_VENDOR
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_VENDOR", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_VENDOR;
						/// <summary>
						/// <para>The <c> Specification-Title </c> attribute defining the title of the extension specification. </para>        
						/// </summary>
						/// <java-name>
						/// SPECIFICATION_TITLE
						/// </java-name>
						[Dot42.DexImport("SPECIFICATION_TITLE", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SPECIFICATION_TITLE;
						/// <summary>
						/// <para>The <c> Specification-Version </c> attribute defining the version of the extension specification. </para>        
						/// </summary>
						/// <java-name>
						/// SPECIFICATION_VERSION
						/// </java-name>
						[Dot42.DexImport("SPECIFICATION_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SPECIFICATION_VERSION;
						/// <summary>
						/// <para>The <c> Specification-Vendor </c> attribute defining the organization that maintains the extension specification. </para>        
						/// </summary>
						/// <java-name>
						/// SPECIFICATION_VENDOR
						/// </java-name>
						[Dot42.DexImport("SPECIFICATION_VENDOR", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SPECIFICATION_VENDOR;
						/// <summary>
						/// <para>The <c> Extension-List </c> attribute defining the extensions that are needed by the applet. </para>        
						/// </summary>
						/// <java-name>
						/// EXTENSION_LIST
						/// </java-name>
						[Dot42.DexImport("EXTENSION_LIST", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name EXTENSION_LIST;
						/// <summary>
						/// <para>The <c> Extension-Name </c> attribute which defines the unique name of the extension. </para>        
						/// </summary>
						/// <java-name>
						/// EXTENSION_NAME
						/// </java-name>
						[Dot42.DexImport("EXTENSION_NAME", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name EXTENSION_NAME;
						/// <summary>
						/// <para>The <c> Extension-Installation </c> attribute. </para>        
						/// </summary>
						/// <java-name>
						/// EXTENSION_INSTALLATION
						/// </java-name>
						[Dot42.DexImport("EXTENSION_INSTALLATION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name EXTENSION_INSTALLATION;
						/// <summary>
						/// <para>The <c> Implementation-Vendor-Id </c> attribute specifies the vendor of an extension implementation if the applet requires an implementation from a specific vendor. </para>        
						/// </summary>
						/// <java-name>
						/// IMPLEMENTATION_VENDOR_ID
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_VENDOR_ID", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_VENDOR_ID;
						/// <summary>
						/// <para>The <c> Implementation-URL </c> attribute specifying a URL that can be used to obtain the most recent version of the extension if the required version is not already installed. </para>        
						/// </summary>
						/// <java-name>
						/// IMPLEMENTATION_URL
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_URL", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_URL;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Name(string @string) /* MethodBuilder.Create */ 
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
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Name() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>This runtime exception is thrown when a problem occurs while reading a JAR file. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/JarException
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarException", AccessFlags = 33)]
		public partial class JarException : global::Java.Util.Zip.ZipException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> JarException </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public JarException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> JarException </c> instance with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JarException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><c> JarFile </c> is used to read jar entries and their associated data from jar files.</para><para><para>JarInputStream </para><simplesectsep></simplesectsep><para>JarEntry </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/JarFile
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarFile", AccessFlags = 33)]
		public partial class JarFile : global::Java.Util.Zip.ZipFile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The MANIFEST file name. </para>        
				/// </summary>
				/// <java-name>
				/// MANIFEST_NAME
				/// </java-name>
				[Dot42.DexImport("MANIFEST_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MANIFEST_NAME = "META-INF/MANIFEST.MF";
				/// <summary>
				/// <para>Create a new <c> JarFile </c> using the contents of the specified file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public JarFile(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Z)V", AccessFlags = 1)]
				public JarFile(global::Java.Io.File file, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new <c> JarFile </c> using the contents of file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;ZI)V", AccessFlags = 1)]
				public JarFile(global::Java.Io.File file, bool verify, int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new <c> JarFile </c> using the contents of the specified file.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JarFile(string file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public JarFile(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return an enumeration containing the <c> JarEntrys </c> contained in this <c> JarFile </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Enumeration </c> containing the JAR entries. </para>
				/// </returns>
				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/util/jar/JarEntry;>;")]
				public new virtual global::Java.Util.IEnumeration<global::Java.Util.Jar.JarEntry> Entries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Util.Jar.JarEntry>);
				}

				/// <summary>
				/// <para>Return the <c> JarEntry </c> specified by its name or <c> null </c> if no such entry exists.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the JAR entry defined by the name. </para>
				/// </returns>
				/// <java-name>
				/// getJarEntry
				/// </java-name>
				[Dot42.DexImport("getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.JarEntry GetJarEntry(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.JarEntry);
				}

				/// <summary>
				/// <para>Returns the <c> Manifest </c> object associated with this <c> JarFile </c> or <c> null </c> if no MANIFEST entry exists.</para><para><para>Manifest </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the MANIFEST. </para>
				/// </returns>
				/// <java-name>
				/// getManifest
				/// </java-name>
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Manifest GetManifest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Manifest);
				}

				/// <summary>
				/// <para>Return an <c> InputStream </c> for reading the decompressed contents of ZIP entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the input stream to read from. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetInputStream(global::Java.Util.Zip.ZipEntry ze) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Return the <c> JarEntry </c> specified by name or <c> null </c> if no such entry exists.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ZIP entry extracted. </para>
				/// </returns>
				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
				public override global::Java.Util.Zip.ZipEntry GetEntry(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				/// <summary>
				/// <para>Closes this <c> JarFile </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Manifest </c> object associated with this <c> JarFile </c> or <c> null </c> if no MANIFEST entry exists.</para><para><para>Manifest </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the MANIFEST. </para>
				/// </returns>
				/// <java-name>
				/// getManifest
				/// </java-name>
				public global::Java.Util.Jar.Manifest Manifest
				{
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
						get{ return GetManifest(); }
				}

		}

		/// <summary>
		/// <para>Class factory for Pack200.Packer and Pack200.Unpacker. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/Pack200
		/// </java-name>
		[Dot42.DexImport("java/util/jar/Pack200", AccessFlags = 1057)]
		public abstract partial class Pack200
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Prevent this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Pack200() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new instance of a packer engine. </para><para>The implementation of the packer engine is defined by the system property <c> 'java.util.jar.Pack200.Packer' </c> . If this system property is defined an instance of the specified class is returned, otherwise the system's default implementation is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of <c> Packer </c> </para>
				/// </returns>
				/// <java-name>
				/// newPacker
				/// </java-name>
				[Dot42.DexImport("newPacker", "()Ljava/util/jar/Pack200$Packer;", AccessFlags = 9)]
				public static global::Java.Util.Jar.Pack200.IPacker NewPacker() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Pack200.IPacker);
				}

				/// <summary>
				/// <para>Returns a new instance of a unpacker engine. </para><para>The implementation of the unpacker engine is defined by the system property <c> 'java.util.jar.Pack200.Unpacker' </c> . If this system property is defined an instance of the specified class is returned, otherwise the system's default implementation is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a instance of <c> Unpacker </c> . </para>
				/// </returns>
				/// <java-name>
				/// newUnpacker
				/// </java-name>
				[Dot42.DexImport("newUnpacker", "()Ljava/util/jar/Pack200$Unpacker;", AccessFlags = 9)]
				public static global::Java.Util.Jar.Pack200.IUnpacker NewUnpacker() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Pack200.IUnpacker);
				}

				/// <summary>
				/// <para>The interface defining the API for converting a packed stream in the Pack200 format to a JAR file. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/jar/Pack200$Unpacker
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Unpacker", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IUnpackerConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The String indicating if the unpacker should ignore all transmitted values,can be replaced by either <c> true </c> or <c> false </c> . </para>        
						/// </summary>
						/// <java-name>
						/// DEFLATE_HINT
						/// </java-name>
						[Dot42.DexImport("DEFLATE_HINT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFLATE_HINT = "unpack.deflate.hint";
						/// <summary>
						/// <para>a String representation of <c> false </c> . </para>        
						/// </summary>
						/// <java-name>
						/// FALSE
						/// </java-name>
						[Dot42.DexImport("FALSE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FALSE = "false";
						/// <summary>
						/// <para>a String representation of <c> keep </c> . </para>        
						/// </summary>
						/// <java-name>
						/// KEEP
						/// </java-name>
						[Dot42.DexImport("KEEP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEEP = "keep";
						/// <summary>
						/// <para>the progress as a <c> percentage </c> . </para>        
						/// </summary>
						/// <java-name>
						/// PROGRESS
						/// </java-name>
						[Dot42.DexImport("PROGRESS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROGRESS = "unpack.progress";
						/// <summary>
						/// <para>a String representation of <c> true </c> . </para>        
						/// </summary>
						/// <java-name>
						/// TRUE
						/// </java-name>
						[Dot42.DexImport("TRUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TRUE = "true";
				}

				/// <summary>
				/// <para>The interface defining the API for converting a packed stream in the Pack200 format to a JAR file. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/jar/Pack200$Unpacker
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Unpacker", AccessFlags = 1545)]
				public partial interface IUnpacker
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Returns a sorted map of the properties of this unpacker.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the properties of unpacker. </para>
						/// </returns>
						/// <java-name>
						/// properties
						/// </java-name>
						[Dot42.DexImport("properties", "()Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "()Ljava/util/SortedMap<Ljava/lang/String;Ljava/lang/String;>;")]
						global::Java.Util.ISortedMap<string, string> Properties() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Unpack the specified stream to the specified JAR output stream.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// unpack
						/// </java-name>
						[Dot42.DexImport("unpack", "(Ljava/io/InputStream;Ljava/util/jar/JarOutputStream;)V", AccessFlags = 1025)]
						void Unpack(global::Java.Io.InputStream @in, global::Java.Util.Jar.JarOutputStream @out) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Unpack the specified stream to the specified JAR output stream.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// unpack
						/// </java-name>
						[Dot42.DexImport("unpack", "(Ljava/io/File;Ljava/util/jar/JarOutputStream;)V", AccessFlags = 1025)]
						void Unpack(global::Java.Io.File @in, global::Java.Util.Jar.JarOutputStream @out) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>add a listener for <c> PropertyChange </c> events.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// addPropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>remove a listener.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// removePropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>The interface defining the API for converting a JAR file to an output stream in the Pack200 format. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/jar/Pack200$Packer
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Packer", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPackerConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>the format of a class attribute name. </para>        
						/// </summary>
						/// <java-name>
						/// CLASS_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("CLASS_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CLASS_ATTRIBUTE_PFX = "pack.class.attribute.";
						/// <summary>
						/// <para>the format of a code attribute name. </para>        
						/// </summary>
						/// <java-name>
						/// CODE_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("CODE_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CODE_ATTRIBUTE_PFX = "pack.code.attribute.";
						/// <summary>
						/// <para>the deflation hint to set in the output archive. </para>        
						/// </summary>
						/// <java-name>
						/// DEFLATE_HINT
						/// </java-name>
						[Dot42.DexImport("DEFLATE_HINT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFLATE_HINT = "pack.deflate.hint";
						/// <summary>
						/// <para>the indicated amount of effort to use in compressing the archive. </para>        
						/// </summary>
						/// <java-name>
						/// EFFORT
						/// </java-name>
						[Dot42.DexImport("EFFORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFORT = "pack.effort";
						/// <summary>
						/// <para>a String representation for <c> error </c> . </para>        
						/// </summary>
						/// <java-name>
						/// ERROR
						/// </java-name>
						[Dot42.DexImport("ERROR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ERROR = "error";
						/// <summary>
						/// <para>a String representation of <c> false </c> . </para>        
						/// </summary>
						/// <java-name>
						/// FALSE
						/// </java-name>
						[Dot42.DexImport("FALSE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FALSE = "false";
						/// <summary>
						/// <para>the format of a field attribute name. </para>        
						/// </summary>
						/// <java-name>
						/// FIELD_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("FIELD_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FIELD_ATTRIBUTE_PFX = "pack.field.attribute.";
						/// <summary>
						/// <para>a String representation for <c> keep </c> . </para>        
						/// </summary>
						/// <java-name>
						/// KEEP
						/// </java-name>
						[Dot42.DexImport("KEEP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEEP = "keep";
						/// <summary>
						/// <para>decide if all elements shall transmit in their original order. </para>        
						/// </summary>
						/// <java-name>
						/// KEEP_FILE_ORDER
						/// </java-name>
						[Dot42.DexImport("KEEP_FILE_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEEP_FILE_ORDER = "pack.keep.file.order";
						/// <summary>
						/// <para>a String representation for <c> latest </c> . </para>        
						/// </summary>
						/// <java-name>
						/// LATEST
						/// </java-name>
						[Dot42.DexImport("LATEST", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LATEST = "latest";
						/// <summary>
						/// <para>the format of a method attribute name. </para>        
						/// </summary>
						/// <java-name>
						/// METHOD_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("METHOD_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string METHOD_ATTRIBUTE_PFX = "pack.method.attribute.";
						/// <summary>
						/// <para>if it shall attempt to determine the latest modification time if this is set to <c> LATEST </c> . </para>        
						/// </summary>
						/// <java-name>
						/// MODIFICATION_TIME
						/// </java-name>
						[Dot42.DexImport("MODIFICATION_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODIFICATION_TIME = "pack.modification.time";
						/// <summary>
						/// <para>a String representation of <c> pass </c> . </para>        
						/// </summary>
						/// <java-name>
						/// PASS
						/// </java-name>
						[Dot42.DexImport("PASS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PASS = "pass";
						/// <summary>
						/// <para>the file that will not be compressed. </para>        
						/// </summary>
						/// <java-name>
						/// PASS_FILE_PFX
						/// </java-name>
						[Dot42.DexImport("PASS_FILE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PASS_FILE_PFX = "pack.pass.file.";
						/// <summary>
						/// <para>packer progress as a percentage. </para>        
						/// </summary>
						/// <java-name>
						/// PROGRESS
						/// </java-name>
						[Dot42.DexImport("PROGRESS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROGRESS = "pack.progress";
						/// <summary>
						/// <para>The number of bytes of each archive segment. </para>        
						/// </summary>
						/// <java-name>
						/// SEGMENT_LIMIT
						/// </java-name>
						[Dot42.DexImport("SEGMENT_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEGMENT_LIMIT = "pack.segment.limit";
						/// <summary>
						/// <para>a String representation of <c> strip </c> . </para>        
						/// </summary>
						/// <java-name>
						/// STRIP
						/// </java-name>
						[Dot42.DexImport("STRIP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STRIP = "strip";
						/// <summary>
						/// <para>a String representation of <c> true </c> . </para>        
						/// </summary>
						/// <java-name>
						/// TRUE
						/// </java-name>
						[Dot42.DexImport("TRUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TRUE = "true";
						/// <summary>
						/// <para>the action to take if an unknown attribute is encountered. </para>        
						/// </summary>
						/// <java-name>
						/// UNKNOWN_ATTRIBUTE
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_ATTRIBUTE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNKNOWN_ATTRIBUTE = "pack.unknown.attribute";
				}

				/// <summary>
				/// <para>The interface defining the API for converting a JAR file to an output stream in the Pack200 format. </para>    
				/// </summary>
				/// <java-name>
				/// java/util/jar/Pack200$Packer
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Packer", AccessFlags = 1545)]
				public partial interface IPacker
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Returns a sorted map of the properties of this packer.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the properties of the packer. </para>
						/// </returns>
						/// <java-name>
						/// properties
						/// </java-name>
						[Dot42.DexImport("properties", "()Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "()Ljava/util/SortedMap<Ljava/lang/String;Ljava/lang/String;>;")]
						global::Java.Util.ISortedMap<string, string> Properties() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Pack the specified JAR file to the specified output stream.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// pack
						/// </java-name>
						[Dot42.DexImport("pack", "(Ljava/util/jar/JarFile;Ljava/io/OutputStream;)V", AccessFlags = 1025)]
						void Pack(global::Java.Util.Jar.JarFile @in, global::Java.Io.OutputStream @out) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Pack the specified JAR file to the specified output stream.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// pack
						/// </java-name>
						[Dot42.DexImport("pack", "(Ljava/util/jar/JarInputStream;Ljava/io/OutputStream;)V", AccessFlags = 1025)]
						void Pack(global::Java.Util.Jar.JarInputStream @in, global::Java.Io.OutputStream @out) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>add a listener for PropertyChange events</para><para></para>        
						/// </summary>
						/// <java-name>
						/// addPropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>remove a listener</para><para></para>        
						/// </summary>
						/// <java-name>
						/// removePropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener listener) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Represents a single file in a JAR archive together with the manifest attributes and digital signatures associated with it.</para><para><para>JarFile </para><simplesectsep></simplesectsep><para>JarInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/JarEntry
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarEntry", AccessFlags = 33)]
		public partial class JarEntry : global::Java.Util.Zip.ZipEntry
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> JarEntry </c> using the values obtained from entry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JarEntry(string entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JarEntry </c> using the values obtained from entry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public JarEntry(global::Java.Util.Zip.ZipEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JarEntry </c> using the values obtained from entry.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/jar/JarEntry;)V", AccessFlags = 1)]
				public JarEntry(global::Java.Util.Jar.JarEntry entry) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Attributes </c> object associated with this entry or <c> null </c> if none exists.</para><para><para>Attributes </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Attributes </c> for this entry. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <summary>
				/// <para>Returns an array of <c> Certificate </c> Objects associated with this entry or <c> null </c> if none exists. Make sure that the everything is read from the input stream before calling this method, or else the method returns <c> null </c> .</para><para><para>java.security.cert.Certificate </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate for this entry. </para>
				/// </returns>
				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <summary>
				/// <para>Returns the code signers for the digital signatures associated with the JAR file. If there is no such code signer, it returns <c> null </c> . Make sure that the everything is read from the input stream before calling this method, or else the method returns <c> null </c> .</para><para><para>CodeSigner </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the code signers for the JAR entry. </para>
				/// </returns>
				/// <java-name>
				/// getCodeSigners
				/// </java-name>
				[Dot42.DexImport("getCodeSigners", "()[Ljava/security/CodeSigner;", AccessFlags = 1)]
				public virtual global::Java.Security.CodeSigner[] GetCodeSigners() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.CodeSigner[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarEntry() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Attributes </c> object associated with this entry or <c> null </c> if none exists.</para><para><para>Attributes </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Attributes </c> for this entry. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes Attributes
				{
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

				/// <summary>
				/// <para>Returns an array of <c> Certificate </c> Objects associated with this entry or <c> null </c> if none exists. Make sure that the everything is read from the input stream before calling this method, or else the method returns <c> null </c> .</para><para><para>java.security.cert.Certificate </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate for this entry. </para>
				/// </returns>
				/// <java-name>
				/// getCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] Certificates
				{
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetCertificates(); }
				}

				/// <summary>
				/// <para>Returns the code signers for the digital signatures associated with the JAR file. If there is no such code signer, it returns <c> null </c> . Make sure that the everything is read from the input stream before calling this method, or else the method returns <c> null </c> .</para><para><para>CodeSigner </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the code signers for the JAR entry. </para>
				/// </returns>
				/// <java-name>
				/// getCodeSigners
				/// </java-name>
				public global::Java.Security.CodeSigner[] CodeSigners
				{
				[Dot42.DexImport("getCodeSigners", "()[Ljava/security/CodeSigner;", AccessFlags = 1)]
						get{ return GetCodeSigners(); }
				}

		}

		/// <summary>
		/// <para>The input stream from which the JAR file to be read may be fetched. It is used like the <c> ZipInputStream </c> .</para><para><para>ZipInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/jar/JarInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarInputStream", AccessFlags = 33)]
		public partial class JarInputStream : global::Java.Util.Zip.ZipInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> JarInputStream </c> from an input stream.</para><para><para>ZipInputStream::ZipInputStream(InputStream) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Z)V", AccessFlags = 1)]
				public JarInputStream(global::Java.Io.InputStream stream, bool verify) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> JarInputStream </c> from an input stream.</para><para><para>ZipInputStream::ZipInputStream(InputStream) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public JarInputStream(global::Java.Io.InputStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Manifest </c> object associated with this <c>       JarInputStream </c> or <c> null </c> if no manifest entry exists.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the MANIFEST specifying the contents of the JAR file. </para>
				/// </returns>
				/// <java-name>
				/// getManifest
				/// </java-name>
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Manifest GetManifest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Manifest);
				}

				/// <summary>
				/// <para>Returns the next <c> JarEntry </c> contained in this stream or <c>       null </c> if no more entries are present.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next JAR entry. </para>
				/// </returns>
				/// <java-name>
				/// getNextJarEntry
				/// </java-name>
				[Dot42.DexImport("getNextJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.JarEntry GetNextJarEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.JarEntry);
				}

				/// <summary>
				/// <para>Reads up to <c> length </c> of decompressed data and stores it in <c> buffer </c> starting at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Number of uncompressed bytes read </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads up to <c> length </c> of decompressed data and stores it in <c> buffer </c> starting at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Number of uncompressed bytes read </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the next <c> ZipEntry </c> contained in this stream or <c>       null </c> if no more entries are present.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next extracted ZIP entry. </para>
				/// </returns>
				/// <java-name>
				/// getNextEntry
				/// </java-name>
				[Dot42.DexImport("getNextEntry", "()Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
				public override global::Java.Util.Zip.ZipEntry GetNextEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				/// <summary>
				/// <para>creates a ZipEntry with the given name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created <c> ZipEntry </c> . </para>
				/// </returns>
				/// <java-name>
				/// createZipEntry
				/// </java-name>
				[Dot42.DexImport("createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 4)]
				protected internal override global::Java.Util.Zip.ZipEntry CreateZipEntry(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Manifest </c> object associated with this <c>       JarInputStream </c> or <c> null </c> if no manifest entry exists.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the MANIFEST specifying the contents of the JAR file. </para>
				/// </returns>
				/// <java-name>
				/// getManifest
				/// </java-name>
				public global::Java.Util.Jar.Manifest Manifest
				{
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
						get{ return GetManifest(); }
				}

				/// <summary>
				/// <para>Returns the next <c> JarEntry </c> contained in this stream or <c>       null </c> if no more entries are present.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next JAR entry. </para>
				/// </returns>
				/// <java-name>
				/// getNextJarEntry
				/// </java-name>
				public global::Java.Util.Jar.JarEntry NextJarEntry
				{
				[Dot42.DexImport("getNextJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
						get{ return GetNextJarEntry(); }
				}

				/// <summary>
				/// <para>Returns the next <c> ZipEntry </c> contained in this stream or <c>       null </c> if no more entries are present.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next extracted ZIP entry. </para>
				/// </returns>
				/// <java-name>
				/// getNextEntry
				/// </java-name>
				public global::Java.Util.Zip.ZipEntry NextEntry
				{
				[Dot42.DexImport("getNextEntry", "()Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
						get{ return GetNextEntry(); }
				}

		}

}


