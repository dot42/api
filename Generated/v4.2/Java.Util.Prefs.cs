// Copyright (C) 2014 dot42
//
// Original filename: Java.Util.Prefs.cs
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
namespace Java.Util.Prefs
{
		/// <summary>
		/// <para>This is the event class to indicate that a preference has been added, deleted or updated. </para><para>Please note that although the class is marked as <c> Serializable </c> by inheritance from <c> EventObject </c> , this type is not intended to be serialized so the serialization methods do nothing but throw a <c> NotSerializableException </c> .</para><para><para>java.util.prefs.Preferences </para><simplesectsep></simplesectsep><para>java.util.prefs.PreferenceChangeListener</para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/PreferenceChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/PreferenceChangeEvent", AccessFlags = 33)]
		public partial class PreferenceChangeEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new <c> PreferenceChangeEvent </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/prefs/Preferences;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PreferenceChangeEvent(global::Java.Util.Prefs.Preferences p, string k, string v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the key of the changed preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the changed preference's key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the new value of the changed preference or <c> null </c> if the preference has been removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new value of the changed preference or <c> null </c> if the preference has been removed. </para>
				/// </returns>
				/// <java-name>
				/// getNewValue
				/// </java-name>
				[Dot42.DexImport("getNewValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNewValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the <c> Preferences </c> instance that fired this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Preferences </c> instance that fired this event. </para>
				/// </returns>
				/// <java-name>
				/// getNode
				/// </java-name>
				[Dot42.DexImport("getNode", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public virtual global::Java.Util.Prefs.Preferences GetNode() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PreferenceChangeEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the key of the changed preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the changed preference's key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				}

				/// <summary>
				/// <para>Gets the new value of the changed preference or <c> null </c> if the preference has been removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new value of the changed preference or <c> null </c> if the preference has been removed. </para>
				/// </returns>
				/// <java-name>
				/// getNewValue
				/// </java-name>
				public string NewValue
				{
				[Dot42.DexImport("getNewValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNewValue(); }
				}

				/// <summary>
				/// <para>Gets the <c> Preferences </c> instance that fired this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Preferences </c> instance that fired this event. </para>
				/// </returns>
				/// <java-name>
				/// getNode
				/// </java-name>
				public global::Java.Util.Prefs.Preferences Node
				{
				[Dot42.DexImport("getNode", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
						get{ return GetNode(); }
				}

		}

		/// <summary>
		/// <para>This is the event class to indicate that one child of the preference node has been added or deleted. </para><para>Please note that although the class is marked as <c> Serializable </c> by inheritance from <c> EventObject </c> , this type is not intended to be serialized so the serialization methods do nothing but throw a <c> NotSerializableException </c> .</para><para><para>java.util.prefs.Preferences </para><simplesectsep></simplesectsep><para>java.util.prefs.NodeChangeListener</para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/NodeChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/NodeChangeEvent", AccessFlags = 33)]
		public partial class NodeChangeEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> NodeChangeEvent </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/prefs/Preferences;Ljava/util/prefs/Preferences;)V", AccessFlags = 1)]
				public NodeChangeEvent(global::Java.Util.Prefs.Preferences p, global::Java.Util.Prefs.Preferences c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> Preferences </c> instance that fired this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Preferences </c> instance that fired this event. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public virtual global::Java.Util.Prefs.Preferences GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Gets the child <c> Preferences </c> node that was added or removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the added or removed child <c> Preferences </c> node. </para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public virtual global::Java.Util.Prefs.Preferences GetChild() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NodeChangeEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> Preferences </c> instance that fired this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Preferences </c> instance that fired this event. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Util.Prefs.Preferences Parent
				{
				[Dot42.DexImport("getParent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

				/// <summary>
				/// <para>Gets the child <c> Preferences </c> node that was added or removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the added or removed child <c> Preferences </c> node. </para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				public global::Java.Util.Prefs.Preferences Child
				{
				[Dot42.DexImport("getChild", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
						get{ return GetChild(); }
				}

		}

		/// <summary>
		/// <para>An exception to indicate that an error was encountered while accessing the backing store.</para><para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/BackingStoreException
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/BackingStoreException", AccessFlags = 33)]
		public partial class BackingStoreException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BackingStoreException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public BackingStoreException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BackingStoreException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This abstract class is a partial implementation of the abstract class Preferences, which can be used to simplify <c> Preferences </c> provider's implementation. This class defines nine abstract SPI methods, which must be implemented by a preference provider.</para><para><para>1.4 </para><para>Preferences </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/AbstractPreferences
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/AbstractPreferences", AccessFlags = 1057)]
		public abstract partial class AbstractPreferences : global::Java.Util.Prefs.Preferences
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The object used to lock this node. </para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "Ljava/lang/Object;", AccessFlags = 20)]
				protected internal readonly object Lock;
				/// <summary>
				/// <para>This field is true if this node is created while it doesn't exist in the backing store. This field's default value is false, and it is checked when the node creation is completed, and if it is true, the node change event will be fired for this node's parent. </para>        
				/// </summary>
				/// <java-name>
				/// newNode
				/// </java-name>
				[Dot42.DexImport("newNode", "Z", AccessFlags = 4)]
				protected internal bool NewNode;
				/// <summary>
				/// <para>Constructs a new <c> AbstractPreferences </c> instance using the given parent node and node name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/prefs/AbstractPreferences;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal AbstractPreferences(global::Java.Util.Prefs.AbstractPreferences parent, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an array of all cached child nodes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of cached child nodes. </para>
				/// </returns>
				/// <java-name>
				/// cachedChildren
				/// </java-name>
				[Dot42.DexImport("cachedChildren", "()[Ljava/util/prefs/AbstractPreferences;", AccessFlags = 20)]
				protected internal global::Java.Util.Prefs.AbstractPreferences[] CachedChildren() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.AbstractPreferences[]);
				}

				/// <summary>
				/// <para>Returns the child node with the specified name or <c> null </c> if it doesn't exist. Implementers can assume that the name supplied to this method will be a valid node name string (conforming to the node naming format) and will not correspond to a node that has been cached or removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the child node with the given name or <c> null </c> if it doesn't exist. </para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", AccessFlags = 4)]
				protected internal virtual global::Java.Util.Prefs.AbstractPreferences GetChild(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.AbstractPreferences);
				}

				/// <summary>
				/// <para>Returns whether this node has been removed by invoking the method <c>       removeNode() </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> , if this node has been removed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRemoved
				/// </java-name>
				[Dot42.DexImport("isRemoved", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsRemoved() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Flushes changes of this node to the backing store. This method should only flush this node and should not include the descendant nodes. Any implementation that wants to provide functionality to flush all nodes at once should override the method flush().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flushSpi
				/// </java-name>
				[Dot42.DexImport("flushSpi", "()V", AccessFlags = 1028)]
				protected internal abstract void FlushSpi() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of all of the child nodes of this node or an empty array if this node has no children. The names of cached children are not required to be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of this node's children. </para>
				/// </returns>
				/// <java-name>
				/// childrenNamesSpi
				/// </java-name>
				[Dot42.DexImport("childrenNamesSpi", "()[Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string[] ChildrenNamesSpi() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the child preference node with the given name, creating it if it does not exist. The caller of this method should ensure that the given name is valid and that this node has not been removed or cached. If the named node has just been removed, the implementation of this method must create a new one instead of reactivating the removed one. </para><para>The new creation is not required to be persisted immediately until the flush method will be invoked. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the child preference node. </para>
				/// </returns>
				/// <java-name>
				/// childSpi
				/// </java-name>
				[Dot42.DexImport("childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", AccessFlags = 1028)]
				protected internal abstract global::Java.Util.Prefs.AbstractPreferences ChildSpi(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Puts the given key-value pair into this node. Caller of this method should ensure that both of the given values are valid and that this node has not been removed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putSpi
				/// </java-name>
				[Dot42.DexImport("putSpi", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void PutSpi(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the preference value mapped to the given key. The caller of this method should ensure that the given key is valid and that this node has not been removed. This method should not throw any exceptions but if it does, the caller will ignore the exception, regarding it as a <c>       null </c> return value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the preference value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getSpi
				/// </java-name>
				[Dot42.DexImport("getSpi", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string GetSpi(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an array of all preference keys of this node or an empty array if no preferences have been found. The caller of this method should ensure that this node has not been removed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of all preference keys. </para>
				/// </returns>
				/// <java-name>
				/// keysSpi
				/// </java-name>
				[Dot42.DexImport("keysSpi", "()[Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string[] KeysSpi() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes this node from the preference hierarchy tree. The caller of this method should ensure that this node has no child nodes, which means the method Preferences.removeNode() should invoke this method multiple-times in bottom-up pattern. The removal is not required to be persisted until after it is flushed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeNodeSpi
				/// </java-name>
				[Dot42.DexImport("removeNodeSpi", "()V", AccessFlags = 1028)]
				protected internal abstract void RemoveNodeSpi() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the preference with the specified key. The caller of this method should ensure that the given key is valid and that this node has not been removed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeSpi
				/// </java-name>
				[Dot42.DexImport("removeSpi", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void RemoveSpi(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Synchronizes this node with the backing store. This method should only synchronize this node and should not include the descendant nodes. An implementation that wants to provide functionality to synchronize all nodes at once should override the method sync().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// syncSpi
				/// </java-name>
				[Dot42.DexImport("syncSpi", "()V", AccessFlags = 1028)]
				protected internal abstract void SyncSpi() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the absolute path string of this preference node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the preference node's absolute path string. </para>
				/// </returns>
				/// <java-name>
				/// absolutePath
				/// </java-name>
				[Dot42.DexImport("absolutePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string AbsolutePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the names of all children of this node or an empty array if this node has no children.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of all children of this node. </para>
				/// </returns>
				/// <java-name>
				/// childrenNames
				/// </java-name>
				[Dot42.DexImport("childrenNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] ChildrenNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Removes all preferences of this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Exports all of the preferences of this node to a XML document using the given output stream. </para><para>This XML document uses the UTF-8 encoding and is written according to the DTD in its DOCTYPE declaration, which is the following:</para><para><pre>
				///        &lt;!DOCTYPE preferences SYSTEM "
				///        </pre></para><para><b>Please note that (unlike the methods of this class that don't concern serialization), this call is not thread-safe.</b> </para><para></para>        
				/// </summary>
				/// <java-name>
				/// exportNode
				/// </java-name>
				[Dot42.DexImport("exportNode", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void ExportNode(global::Java.Io.OutputStream ostream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Exports all of the preferences of this node and all its descendants to a XML document using the given output stream. </para><para>This XML document uses the UTF-8 encoding and is written according to the DTD in its DOCTYPE declaration, which is the following:</para><para><pre>
				///        &lt;!DOCTYPE preferences SYSTEM "
				///        </pre></para><para><b>Please note that (unlike the methods of this class that don't concern serialization), this call is not thread-safe.</b> </para><para></para>        
				/// </summary>
				/// <java-name>
				/// exportSubtree
				/// </java-name>
				[Dot42.DexImport("exportSubtree", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void ExportSubtree(global::Java.Io.OutputStream ostream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Forces all pending updates to this node and its descendants to be persisted in the backing store. </para><para>If this node has been removed, the invocation of this method only flushes this node, not its descendants. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> String </c> value mapped to the given key or its default value if no value is mapped or no backing store is available. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the preference value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string Get(string key, string deflt) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the <c> boolean </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is invalid. </para><para>The only valid values are the <c> String </c> "true", which represents <c> true </c> and "false", which represents <c> false </c> , ignoring case. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the boolean value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public override bool GetBoolean(string key, bool deflt) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the <c> byte </c> array value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be Base64-encoded binary data. The Base64 encoding is as defined in , section 6.8. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte array value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1)]
				public override sbyte[] GetByteArray(string key, sbyte[] deflt) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Gets the <c> byte </c> array value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be Base64-encoded binary data. The Base64 encoding is as defined in , section 6.8. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte array value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetByteArray(string key, byte[] deflt) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Gets the <c> double </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to a <c> double </c> by Double.parseDouble(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the double value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public override double GetDouble(string key, double deflt) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Gets the <c> float </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to a <c> float </c> by Float.parseFloat(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the float value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1)]
				public override float GetFloat(string key, float deflt) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Gets the <c> int </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to an <c> int </c> by Integer.parseInt(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the integer value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public override int GetInt(string key, int deflt) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the <c> long </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to a <c> long </c> by Long.parseLong(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public override long GetLong(string key, long deflt) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns whether this is a user preference node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> , if this is a user preference node, <c> false </c> if this is a system preference node. </para>
				/// </returns>
				/// <java-name>
				/// isUserNode
				/// </java-name>
				[Dot42.DexImport("isUserNode", "()Z", AccessFlags = 1)]
				public override bool IsUserNode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns all preference keys stored in this node or an empty array if no key was found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of all preference keys of this node. </para>
				/// </returns>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] Keys() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the name of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this node. </para>
				/// </returns>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string Name() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the preference node with the given path name. The path name can be relative or absolute. The requested node and its ancestors will be created if they do not exist. </para><para>The path is treated as relative to this node if it doesn't start with a slash, otherwise it will be treated as an absolute path. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested preference node. </para>
				/// </returns>
				/// <java-name>
				/// node
				/// </java-name>
				[Dot42.DexImport("node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public override global::Java.Util.Prefs.Preferences Node(string path) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Returns whether the preference node with the given path name exists. The path is treated as relative to this node if it doesn't start with a slash, otherwise it is treated as an absolute path. </para><para>Please note that if this node has been removed, an invocation of this node will throw an <c> IllegalStateException </c> unless the given path is an empty string, which will return <c> false </c> . </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> , if the queried preference node exists, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nodeExists
				/// </java-name>
				[Dot42.DexImport("nodeExists", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool NodeExists(string path) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the parent preference node of this node or <c> null </c> if this node is the root node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parent preference node of this node. </para>
				/// </returns>
				/// <java-name>
				/// parent
				/// </java-name>
				[Dot42.DexImport("parent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public override global::Java.Util.Prefs.Preferences Parent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and value or updates the value if a preference with the given key already exists.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Put(string key, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference with a <c> boolean </c> value to this node using the given key and value or updates the value if a preference with the given key already exists.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public override void PutBoolean(string key, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and the string form of the given value or updates the value if a preference with the given key already exists. </para><para>The string form of the value is the Base64-encoded binary data of the given byte array. The Base64 encoding is as defined in , section 6.8. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public override void PutByteArray(string key, sbyte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and the string form of the given value or updates the value if a preference with the given key already exists. </para><para>The string form of the value is the Base64-encoded binary data of the given byte array. The Base64 encoding is as defined in , section 6.8. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void PutByteArray(string key, byte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> double </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Double.toString(double). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(Ljava/lang/String;D)V", AccessFlags = 1)]
				public override void PutDouble(string key, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> float </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Float.toString(float). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)V", AccessFlags = 1)]
				public override void PutFloat(string key, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> int </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Integer.toString(int). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public override void PutInt(string key, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> long </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Long.toString(long). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)V", AccessFlags = 1)]
				public override void PutLong(string key, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the preference mapped to the given key from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Remove(string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes this preference node with all its descendants. The removal won't necessarily be persisted until the method <c> flush() </c> is invoked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeNode
				/// </java-name>
				[Dot42.DexImport("removeNode", "()V", AccessFlags = 1)]
				public override void RemoveNode() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a <c> NodeChangeListener </c> instance for this node, which will handle <c> NodeChangeEvent </c> s. <c> NodeChangeEvent </c> s will be fired when a child node has been added to or removed from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1)]
				public override void AddNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener ncl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a <c> PreferenceChangeListener </c> instance for this node, which will handle <c> PreferenceChangeEvent </c> s. <c>       PreferenceChangeEvent </c> s will be fired when a preference has been added to, removed from, or updated for this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1)]
				public override void AddPreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener pcl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the given <c> NodeChangeListener </c> instance from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1)]
				public override void RemoveNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener ncl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the given <c> PreferenceChangeListener </c> instance from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removePreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1)]
				public override void RemovePreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener pcl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Synchronizes the data of this preference node and its descendants with the back-end preference store. Any changes found in the back-end data should be reflected in this node and its descendants, and at the same time any local changes to this node and descendants should be persisted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public override void Sync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a string representation of this node. The format is "User/System       Preference Node: " followed by this node's absolute path.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this node. </para>
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
				internal AbstractPreferences() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This interface is used to handle preference node change events. The implementation of this interface can be installed by the <c> Preferences </c> instance.</para><para><para>Preferences </para><simplesectsep></simplesectsep><para>NodeChangeEvent</para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/NodeChangeListener
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/NodeChangeListener", AccessFlags = 1537)]
		public partial interface INodeChangeListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This method gets called whenever a child node is added to another node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// childAdded
				/// </java-name>
				[Dot42.DexImport("childAdded", "(Ljava/util/prefs/NodeChangeEvent;)V", AccessFlags = 1025)]
				void ChildAdded(global::Java.Util.Prefs.NodeChangeEvent e) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method gets called whenever a child node is removed from another node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// childRemoved
				/// </java-name>
				[Dot42.DexImport("childRemoved", "(Ljava/util/prefs/NodeChangeEvent;)V", AccessFlags = 1025)]
				void ChildRemoved(global::Java.Util.Prefs.NodeChangeEvent e) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An instance of the class <c> Preferences </c> represents one node in a preference tree, which provides a mechanism to store and access configuration data in a hierarchical way. Two hierarchy trees are maintained, one for system preferences shared by all users and the other for user preferences specific to the user. <c> Preferences </c> hierarchy trees and data are stored in an implementation-dependent back-end. </para><para>Every node has one name and one unique absolute path following the same notational conventions as directories in a file system. The root node's name is "", and other node name strings cannot contain the slash character and cannot be empty. The root node's absolute path is "/", and all other nodes' absolute paths are constructed in the standard way: &lt;parent's absolute path&gt; + "/" + &lt;node's name&gt;. Since the set of nodes forms a tree with the root node at its base, all absolute paths start with the slash character. Every node has one relative path to each of its ancestors. The relative path doesn't start with slash: it equals the node's absolute path with leading substring removed corresponding to the ancestor's absolute path and a slash. </para><para>Modification to preferences data may be asynchronous, which means that preference update method calls may return immediately instead of blocking. The <c> flush() </c> and <c> sync() </c> methods force the back-end to synchronously perform all pending updates, but the implementation is permitted to perform the modifications on the underlying back-end data at any time between the moment the request is made and the moment the <c> flush() </c> or <c> sync() </c> method returns. Please note that if the JVM exits normally, the implementation must assure all modifications are persisted implicitly. </para><para>When invoking a method that retrieves preferences, the user must provide a default value. The default value is returned when the preferences cannot be found or the back-end is unavailable. Some other methods will throw <c> BackingStoreException </c> when the back-end is unavailable. </para><para>Preferences can be exported to and imported from an XML files. These documents must have an XML DOCTYPE declaration: <pre>   &lt;!DOCTYPE preferences SYSTEM "http://java.sun.com/dtd/preferences.dtd"&gt;
		/// 
		///  </pre> This system URI is not really accessed by network, it is only a identification string. Visit the DTD location to see the actual format permitted. </para><para>There must be a concrete <c> PreferencesFactory </c> type for every concrete <c> Preferences </c> type developed. Every J2SE implementation must provide a default implementation for every supported platform, and must also provide a means of replacing the default implementation. This implementation uses the system property <c> java.util.prefs.PreferencesFactory </c> to determine which preferences implementation to use. </para><para>The methods of this class are thread-safe. If multiple JVMs are using the same back-end concurrently, the back-end won't be corrupted, but no other behavior guarantees are made.</para><para><para>PreferencesFactory</para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/Preferences
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/Preferences", AccessFlags = 1057)]
		public abstract partial class Preferences
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Maximum size in characters allowed for a preferences key. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_KEY_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_KEY_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_KEY_LENGTH = 80;
				/// <summary>
				/// <para>Maximum size in characters allowed for a preferences name. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_NAME_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_NAME_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_NAME_LENGTH = 80;
				/// <summary>
				/// <para>Maximum size in characters allowed for a preferences value. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_VALUE_LENGTH = 8192;
				/// <summary>
				/// <para>Default constructor, for use by subclasses only. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Preferences() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the absolute path string of this preference node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the preference node's absolute path string. </para>
				/// </returns>
				/// <java-name>
				/// absolutePath
				/// </java-name>
				[Dot42.DexImport("absolutePath", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string AbsolutePath() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the names of all children of this node or an empty array if this node has no children.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of all children of this node. </para>
				/// </returns>
				/// <java-name>
				/// childrenNames
				/// </java-name>
				[Dot42.DexImport("childrenNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] ChildrenNames() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all preferences of this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				public abstract void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Exports all of the preferences of this node to a XML document using the given output stream. </para><para>This XML document uses the UTF-8 encoding and is written according to the DTD in its DOCTYPE declaration, which is the following:</para><para><pre>
				///        &lt;!DOCTYPE preferences SYSTEM "
				///        </pre></para><para><b>Please note that (unlike the methods of this class that don't concern serialization), this call is not thread-safe.</b> </para><para></para>        
				/// </summary>
				/// <java-name>
				/// exportNode
				/// </java-name>
				[Dot42.DexImport("exportNode", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				public abstract void ExportNode(global::Java.Io.OutputStream ostream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Exports all of the preferences of this node and all its descendants to a XML document using the given output stream. </para><para>This XML document uses the UTF-8 encoding and is written according to the DTD in its DOCTYPE declaration, which is the following:</para><para><pre>
				///        &lt;!DOCTYPE preferences SYSTEM "
				///        </pre></para><para><b>Please note that (unlike the methods of this class that don't concern serialization), this call is not thread-safe.</b> </para><para></para>        
				/// </summary>
				/// <java-name>
				/// exportSubtree
				/// </java-name>
				[Dot42.DexImport("exportSubtree", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				public abstract void ExportSubtree(global::Java.Io.OutputStream ostream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Forces all pending updates to this node and its descendants to be persisted in the backing store. </para><para>If this node has been removed, the invocation of this method only flushes this node, not its descendants. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				public abstract void Flush() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> String </c> value mapped to the given key or its default value if no value is mapped or no backing store is available. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the preference value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string Get(string key, string deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> boolean </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is invalid. </para><para>The only valid values are the <c> String </c> "true", which represents <c> true </c> and "false", which represents <c> false </c> , ignoring case. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the boolean value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				public abstract bool GetBoolean(string key, bool deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> byte </c> array value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be Base64-encoded binary data. The Base64 encoding is as defined in , section 6.8. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte array value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1025)]
				public abstract sbyte[] GetByteArray(string key, sbyte[] deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> byte </c> array value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be Base64-encoded binary data. The Base64 encoding is as defined in , section 6.8. </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte array value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] GetByteArray(string key, byte[] deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> double </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to a <c> double </c> by Double.parseDouble(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the double value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;D)D", AccessFlags = 1025)]
				public abstract double GetDouble(string key, double deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> float </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to a <c> float </c> by Float.parseFloat(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the float value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1025)]
				public abstract float GetFloat(string key, float deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> int </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to an <c> int </c> by Integer.parseInt(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the integer value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				public abstract int GetInt(string key, int deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> long </c> value mapped to the given key or its default value if no value is mapped, if the backing store is unavailable, or if the value is an invalid string. </para><para>To be valid, the value string must be a string that can be converted to a <c> long </c> by Long.parseLong(String). </para><para>Some implementations may store default values in backing stores. In this case, if there is no value mapped to the given key, the stored default value is returned. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long value mapped to the given key. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				public abstract long GetLong(string key, long deflt) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Imports all the preferences from an XML document using the given input stream. </para><para>This XML document uses the UTF-8 encoding and must be written according to the DTD in its DOCTYPE declaration, which must be the following:</para><para><pre>
				///        &lt;!DOCTYPE preferences SYSTEM "
				///        </pre></para><para><b>Please note that (unlike the methods of this class that don't concern serialization), this call is not thread-safe.</b> </para><para></para>        
				/// </summary>
				/// <java-name>
				/// importPreferences
				/// </java-name>
				[Dot42.DexImport("importPreferences", "(Ljava/io/InputStream;)V", AccessFlags = 9)]
				public static void ImportPreferences(global::Java.Io.InputStream istream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this is a user preference node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> , if this is a user preference node, <c> false </c> if this is a system preference node. </para>
				/// </returns>
				/// <java-name>
				/// isUserNode
				/// </java-name>
				[Dot42.DexImport("isUserNode", "()Z", AccessFlags = 1025)]
				public abstract bool IsUserNode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns all preference keys stored in this node or an empty array if no key was found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of all preference keys of this node. </para>
				/// </returns>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] Keys() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this node. </para>
				/// </returns>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string Name() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the preference node with the given path name. The path name can be relative or absolute. The requested node and its ancestors will be created if they do not exist. </para><para>The path is treated as relative to this node if it doesn't start with a slash, otherwise it will be treated as an absolute path. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested preference node. </para>
				/// </returns>
				/// <java-name>
				/// node
				/// </java-name>
				[Dot42.DexImport("node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				public abstract global::Java.Util.Prefs.Preferences Node(string path) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether the preference node with the given path name exists. The path is treated as relative to this node if it doesn't start with a slash, otherwise it is treated as an absolute path. </para><para>Please note that if this node has been removed, an invocation of this node will throw an <c> IllegalStateException </c> unless the given path is an empty string, which will return <c> false </c> . </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> , if the queried preference node exists, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nodeExists
				/// </java-name>
				[Dot42.DexImport("nodeExists", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool NodeExists(string path) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the parent preference node of this node or <c> null </c> if this node is the root node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parent preference node of this node. </para>
				/// </returns>
				/// <java-name>
				/// parent
				/// </java-name>
				[Dot42.DexImport("parent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				public abstract global::Java.Util.Prefs.Preferences Parent() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and value or updates the value if a preference with the given key already exists.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Put(string key, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference with a <c> boolean </c> value to this node using the given key and value or updates the value if a preference with the given key already exists.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void PutBoolean(string key, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and the string form of the given value or updates the value if a preference with the given key already exists. </para><para>The string form of the value is the Base64-encoded binary data of the given byte array. The Base64 encoding is as defined in , section 6.8. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				public abstract void PutByteArray(string key, sbyte[] value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and the string form of the given value or updates the value if a preference with the given key already exists. </para><para>The string form of the value is the Base64-encoded binary data of the given byte array. The Base64 encoding is as defined in , section 6.8. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract void PutByteArray(string key, byte[] value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> double </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Double.toString(double). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
				public abstract void PutDouble(string key, double value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> float </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Float.toString(float). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
				public abstract void PutFloat(string key, float value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> int </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Integer.toString(int). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				public abstract void PutInt(string key, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a new preference to this node using the given key and <c> long </c> value or updates the value if a preference with the given key already exists. </para><para>The value is stored in its string form, which is the result of invoking Long.toString(long). </para><para></para>        
				/// </summary>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				public abstract void PutLong(string key, long value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the preference mapped to the given key from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Remove(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes this preference node with all its descendants. The removal won't necessarily be persisted until the method <c> flush() </c> is invoked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeNode
				/// </java-name>
				[Dot42.DexImport("removeNode", "()V", AccessFlags = 1025)]
				public abstract void RemoveNode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Registers a <c> NodeChangeListener </c> instance for this node, which will handle <c> NodeChangeEvent </c> s. <c> NodeChangeEvent </c> s will be fired when a child node has been added to or removed from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1025)]
				public abstract void AddNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener ncl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Registers a <c> PreferenceChangeListener </c> instance for this node, which will handle <c> PreferenceChangeEvent </c> s. <c>       PreferenceChangeEvent </c> s will be fired when a preference has been added to, removed from, or updated for this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1025)]
				public abstract void AddPreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener pcl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the given <c> NodeChangeListener </c> instance from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1025)]
				public abstract void RemoveNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener ncl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the given <c> PreferenceChangeListener </c> instance from this node.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removePreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1025)]
				public abstract void RemovePreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener pcl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Synchronizes the data of this preference node and its descendants with the back-end preference store. Any changes found in the back-end data should be reflected in this node and its descendants, and at the same time any local changes to this node and descendants should be persisted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1025)]
				public abstract void Sync() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the system preference node for the package of the given class. The absolute path of the returned node is one slash followed by the given class's full package name, replacing each period character ('.') with a slash. For example, the absolute path of the preference associated with the class Object would be "/java/lang". As a special case, the unnamed package is associated with a preference node "/&amp;lt;unnamed&amp;gt;". This method will create the node and its ancestors as needed. Any nodes created by this method won't necessarily be persisted until the method <c>       flush() </c> is invoked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the system preference node for the package of the given class. </para>
				/// </returns>
				/// <java-name>
				/// systemNodeForPackage
				/// </java-name>
				[Dot42.DexImport("systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/util/prefs/Preferences;")]
				public static global::Java.Util.Prefs.Preferences SystemNodeForPackage(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Returns the root node of the system preference hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the system preference hierarchy root node. </para>
				/// </returns>
				/// <java-name>
				/// systemRoot
				/// </java-name>
				[Dot42.DexImport("systemRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 9)]
				public static global::Java.Util.Prefs.Preferences SystemRoot() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Returns the user preference node for the package of the given class. The absolute path of the returned node is one slash followed by the given class's full package name, replacing each period character ('.') with a slash. For example, the absolute path of the preference associated with the class Object would be "/java/lang". As a special case, the unnamed package is associated with a preference node "/&amp;lt;unnamed&amp;gt;". This method will create the node and its ancestors as needed. Any nodes created by this method won't necessarily be persisted until the method <c>       flush() </c> is invoked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the user preference node for the package of the given class. </para>
				/// </returns>
				/// <java-name>
				/// userNodeForPackage
				/// </java-name>
				[Dot42.DexImport("userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/util/prefs/Preferences;")]
				public static global::Java.Util.Prefs.Preferences UserNodeForPackage(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Returns the root node of the user preference hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the user preference hierarchy root node. </para>
				/// </returns>
				/// <java-name>
				/// userRoot
				/// </java-name>
				[Dot42.DexImport("userRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 9)]
				public static global::Java.Util.Prefs.Preferences UserRoot() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <summary>
				/// <para>Returns a string representation of this node. The format is "User/System       Preference Node: " followed by this node's absolute path.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this node. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>This interface is used by the Preferences class as factory class to create <c> Preferences </c> instances. This interface can be implemented and installed to replace the default preferences implementation.</para><para><para>java.util.prefs.Preferences</para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/PreferencesFactory
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/PreferencesFactory", AccessFlags = 1537)]
		public partial interface IPreferencesFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the root node of the preferences hierarchy for the calling user context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the user preferences hierarchy root node. </para>
				/// </returns>
				/// <java-name>
				/// userRoot
				/// </java-name>
				[Dot42.DexImport("userRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				global::Java.Util.Prefs.Preferences UserRoot() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the root node of the system preferences hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the system preferences hierarchy root node. </para>
				/// </returns>
				/// <java-name>
				/// systemRoot
				/// </java-name>
				[Dot42.DexImport("systemRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				global::Java.Util.Prefs.Preferences SystemRoot() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An exception to indicate that the input XML file is not well-formed or could not be validated against the appropriate document type (specified by in the <c> Preferences </c> ). </para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/InvalidPreferencesFormatException
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/InvalidPreferencesFormatException", AccessFlags = 33)]
		public partial class InvalidPreferencesFormatException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidPreferencesFormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> InvalidPreferencesFormatException </c> instance with a detailed exception message and a nested <c> Throwable </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidPreferencesFormatException(string s, global::System.Exception t) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidPreferencesFormatException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InvalidPreferencesFormatException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This interface is used to handle preferences change events. The implementation of this interface can be installed by the <c> Preferences </c> instance.</para><para><para>Preferences </para><simplesectsep></simplesectsep><para>PreferenceChangeEvent</para><para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/prefs/PreferenceChangeListener
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/PreferenceChangeListener", AccessFlags = 1537)]
		public partial interface IPreferenceChangeListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This method gets invoked whenever a preference is added, deleted or updated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// preferenceChange
				/// </java-name>
				[Dot42.DexImport("preferenceChange", "(Ljava/util/prefs/PreferenceChangeEvent;)V", AccessFlags = 1025)]
				void PreferenceChange(global::Java.Util.Prefs.PreferenceChangeEvent pce) /* MethodBuilder.Create */ ;

		}

}


