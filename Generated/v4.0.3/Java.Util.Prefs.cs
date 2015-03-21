#pragma warning disable 1717
namespace Java.Util.Prefs
{
		/// <java-name>
		/// java/util/prefs/AbstractPreferences
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/AbstractPreferences", AccessFlags = 1057)]
		public abstract partial class AbstractPreferences : global::Java.Util.Prefs.Preferences
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "Ljava/lang/Object;", AccessFlags = 20)]
				protected internal readonly object Lock;
				/// <java-name>
				/// newNode
				/// </java-name>
				[Dot42.DexImport("newNode", "Z", AccessFlags = 4)]
				protected internal bool NewNode;
				[Dot42.DexImport("<init>", "(Ljava/util/prefs/AbstractPreferences;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal AbstractPreferences(global::Java.Util.Prefs.AbstractPreferences abstractPreferences, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cachedChildren
				/// </java-name>
				[Dot42.DexImport("cachedChildren", "()[Ljava/util/prefs/AbstractPreferences;", AccessFlags = 20)]
				protected internal global::Java.Util.Prefs.AbstractPreferences[] CachedChildren() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.AbstractPreferences[]);
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", AccessFlags = 4)]
				protected internal virtual global::Java.Util.Prefs.AbstractPreferences GetChild(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.AbstractPreferences);
				}

				/// <java-name>
				/// isRemoved
				/// </java-name>
				[Dot42.DexImport("isRemoved", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsRemoved() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// flushSpi
				/// </java-name>
				[Dot42.DexImport("flushSpi", "()V", AccessFlags = 1028)]
				protected internal abstract void FlushSpi() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// childrenNamesSpi
				/// </java-name>
				[Dot42.DexImport("childrenNamesSpi", "()[Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string[] ChildrenNamesSpi() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// childSpi
				/// </java-name>
				[Dot42.DexImport("childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", AccessFlags = 1028)]
				protected internal abstract global::Java.Util.Prefs.AbstractPreferences ChildSpi(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putSpi
				/// </java-name>
				[Dot42.DexImport("putSpi", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void PutSpi(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSpi
				/// </java-name>
				[Dot42.DexImport("getSpi", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string GetSpi(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keysSpi
				/// </java-name>
				[Dot42.DexImport("keysSpi", "()[Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string[] KeysSpi() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeNodeSpi
				/// </java-name>
				[Dot42.DexImport("removeNodeSpi", "()V", AccessFlags = 1028)]
				protected internal abstract void RemoveNodeSpi() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeSpi
				/// </java-name>
				[Dot42.DexImport("removeSpi", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void RemoveSpi(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// syncSpi
				/// </java-name>
				[Dot42.DexImport("syncSpi", "()V", AccessFlags = 1028)]
				protected internal abstract void SyncSpi() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// absolutePath
				/// </java-name>
				[Dot42.DexImport("absolutePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string AbsolutePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// childrenNames
				/// </java-name>
				[Dot42.DexImport("childrenNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] ChildrenNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// exportNode
				/// </java-name>
				[Dot42.DexImport("exportNode", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void ExportNode(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// exportSubtree
				/// </java-name>
				[Dot42.DexImport("exportSubtree", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void ExportSubtree(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string Get(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public override bool GetBoolean(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1)]
				public override sbyte[] GetByteArray(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetByteArray(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public override double GetDouble(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1)]
				public override float GetFloat(string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public override int GetInt(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public override long GetLong(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// isUserNode
				/// </java-name>
				[Dot42.DexImport("isUserNode", "()Z", AccessFlags = 1)]
				public override bool IsUserNode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] Keys() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string Name() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// node
				/// </java-name>
				[Dot42.DexImport("node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public override global::Java.Util.Prefs.Preferences Node(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <java-name>
				/// nodeExists
				/// </java-name>
				[Dot42.DexImport("nodeExists", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool NodeExists(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parent
				/// </java-name>
				[Dot42.DexImport("parent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public override global::Java.Util.Prefs.Preferences Parent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Put(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public override void PutBoolean(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public override void PutByteArray(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void PutByteArray(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(Ljava/lang/String;D)V", AccessFlags = 1)]
				public override void PutDouble(string @string, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)V", AccessFlags = 1)]
				public override void PutFloat(string @string, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public override void PutInt(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)V", AccessFlags = 1)]
				public override void PutLong(string @string, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Remove(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeNode
				/// </java-name>
				[Dot42.DexImport("removeNode", "()V", AccessFlags = 1)]
				public override void RemoveNode() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1)]
				public override void AddNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener nodeChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1)]
				public override void AddPreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener preferenceChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1)]
				public override void RemoveNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener nodeChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1)]
				public override void RemovePreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener preferenceChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public override void Sync() /* MethodBuilder.Create */ 
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
				internal AbstractPreferences() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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

		/// <java-name>
		/// java/util/prefs/NodeChangeListener
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/NodeChangeListener", AccessFlags = 1537)]
		public partial interface INodeChangeListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// childAdded
				/// </java-name>
				[Dot42.DexImport("childAdded", "(Ljava/util/prefs/NodeChangeEvent;)V", AccessFlags = 1025)]
				void ChildAdded(global::Java.Util.Prefs.NodeChangeEvent nodeChangeEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// childRemoved
				/// </java-name>
				[Dot42.DexImport("childRemoved", "(Ljava/util/prefs/NodeChangeEvent;)V", AccessFlags = 1025)]
				void ChildRemoved(global::Java.Util.Prefs.NodeChangeEvent nodeChangeEvent) /* MethodBuilder.Create */ ;

		}

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

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidPreferencesFormatException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// java/util/prefs/PreferenceChangeListener
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/PreferenceChangeListener", AccessFlags = 1537)]
		public partial interface IPreferenceChangeListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// preferenceChange
				/// </java-name>
				[Dot42.DexImport("preferenceChange", "(Ljava/util/prefs/PreferenceChangeEvent;)V", AccessFlags = 1025)]
				void PreferenceChange(global::Java.Util.Prefs.PreferenceChangeEvent preferenceChangeEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/prefs/PreferencesFactory
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/PreferencesFactory", AccessFlags = 1537)]
		public partial interface IPreferencesFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// userRoot
				/// </java-name>
				[Dot42.DexImport("userRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				global::Java.Util.Prefs.Preferences UserRoot() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// systemRoot
				/// </java-name>
				[Dot42.DexImport("systemRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				global::Java.Util.Prefs.Preferences SystemRoot() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/prefs/NodeChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/NodeChangeEvent", AccessFlags = 33)]
		public partial class NodeChangeEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/prefs/Preferences;Ljava/util/prefs/Preferences;)V", AccessFlags = 1)]
				public NodeChangeEvent(global::Java.Util.Prefs.Preferences preferences, global::Java.Util.Prefs.Preferences preferences1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
				public virtual global::Java.Util.Prefs.Preferences GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

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

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Util.Prefs.Preferences Parent
				{
				[Dot42.DexImport("getParent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				public global::Java.Util.Prefs.Preferences Child
				{
				[Dot42.DexImport("getChild", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
						get{ return GetChild(); }
				}

		}

		/// <java-name>
		/// java/util/prefs/PreferenceChangeEvent
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/PreferenceChangeEvent", AccessFlags = 33)]
		public partial class PreferenceChangeEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/prefs/Preferences;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PreferenceChangeEvent(global::Java.Util.Prefs.Preferences preferences, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getNewValue
				/// </java-name>
				[Dot42.DexImport("getNewValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNewValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

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

				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				}

				/// <java-name>
				/// getNewValue
				/// </java-name>
				public string NewValue
				{
				[Dot42.DexImport("getNewValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNewValue(); }
				}

				/// <java-name>
				/// getNode
				/// </java-name>
				public global::Java.Util.Prefs.Preferences Node
				{
				[Dot42.DexImport("getNode", "()Ljava/util/prefs/Preferences;", AccessFlags = 1)]
						get{ return GetNode(); }
				}

		}

		/// <java-name>
		/// java/util/prefs/Preferences
		/// </java-name>
		[Dot42.DexImport("java/util/prefs/Preferences", AccessFlags = 1057)]
		public abstract partial class Preferences
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_KEY_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_KEY_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_KEY_LENGTH = 80;
				/// <java-name>
				/// MAX_NAME_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_NAME_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_NAME_LENGTH = 80;
				/// <java-name>
				/// MAX_VALUE_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_VALUE_LENGTH = 8192;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Preferences() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// absolutePath
				/// </java-name>
				[Dot42.DexImport("absolutePath", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string AbsolutePath() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// childrenNames
				/// </java-name>
				[Dot42.DexImport("childrenNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] ChildrenNames() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				public abstract void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// exportNode
				/// </java-name>
				[Dot42.DexImport("exportNode", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				public abstract void ExportNode(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// exportSubtree
				/// </java-name>
				[Dot42.DexImport("exportSubtree", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				public abstract void ExportSubtree(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				public abstract void Flush() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string Get(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				public abstract bool GetBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1025)]
				public abstract sbyte[] GetByteArray(string @string, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;[B)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] GetByteArray(string @string, byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;D)D", AccessFlags = 1025)]
				public abstract double GetDouble(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1025)]
				public abstract float GetFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				public abstract int GetInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				public abstract long GetLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// importPreferences
				/// </java-name>
				[Dot42.DexImport("importPreferences", "(Ljava/io/InputStream;)V", AccessFlags = 9)]
				public static void ImportPreferences(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isUserNode
				/// </java-name>
				[Dot42.DexImport("isUserNode", "()Z", AccessFlags = 1025)]
				public abstract bool IsUserNode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] Keys() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string Name() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// node
				/// </java-name>
				[Dot42.DexImport("node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				public abstract global::Java.Util.Prefs.Preferences Node(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nodeExists
				/// </java-name>
				[Dot42.DexImport("nodeExists", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool NodeExists(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parent
				/// </java-name>
				[Dot42.DexImport("parent", "()Ljava/util/prefs/Preferences;", AccessFlags = 1025)]
				public abstract global::Java.Util.Prefs.Preferences Parent() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Put(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void PutBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				public abstract void PutByteArray(string @string, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract void PutByteArray(string @string, byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
				public abstract void PutDouble(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
				public abstract void PutFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				public abstract void PutInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				public abstract void PutLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Remove(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeNode
				/// </java-name>
				[Dot42.DexImport("removeNode", "()V", AccessFlags = 1025)]
				public abstract void RemoveNode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1025)]
				public abstract void AddNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener nodeChangeListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1025)]
				public abstract void AddPreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener preferenceChangeListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeNodeChangeListener
				/// </java-name>
				[Dot42.DexImport("removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", AccessFlags = 1025)]
				public abstract void RemoveNodeChangeListener(global::Java.Util.Prefs.INodeChangeListener nodeChangeListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removePreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", AccessFlags = 1025)]
				public abstract void RemovePreferenceChangeListener(global::Java.Util.Prefs.IPreferenceChangeListener preferenceChangeListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1025)]
				public abstract void Sync() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// systemNodeForPackage
				/// </java-name>
				[Dot42.DexImport("systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/util/prefs/Preferences;")]
				public static global::Java.Util.Prefs.Preferences SystemNodeForPackage(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <java-name>
				/// systemRoot
				/// </java-name>
				[Dot42.DexImport("systemRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 9)]
				public static global::Java.Util.Prefs.Preferences SystemRoot() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <java-name>
				/// userNodeForPackage
				/// </java-name>
				[Dot42.DexImport("userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/util/prefs/Preferences;")]
				public static global::Java.Util.Prefs.Preferences UserNodeForPackage(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <java-name>
				/// userRoot
				/// </java-name>
				[Dot42.DexImport("userRoot", "()Ljava/util/prefs/Preferences;", AccessFlags = 9)]
				public static global::Java.Util.Prefs.Preferences UserRoot() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Prefs.Preferences);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}

