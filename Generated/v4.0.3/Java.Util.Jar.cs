#pragma warning disable 1717
namespace Java.Util.Jar
{
		/// <java-name>
		/// java/util/jar/JarFile
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarFile", AccessFlags = 33)]
		public partial class JarFile : global::Java.Util.Zip.ZipFile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MANIFEST_NAME
				/// </java-name>
				[Dot42.DexImport("MANIFEST_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MANIFEST_NAME = "META-INF/MANIFEST.MF";
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public JarFile(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Z)V", AccessFlags = 1)]
				public JarFile(global::Java.Io.File file, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;ZI)V", AccessFlags = 1)]
				public JarFile(global::Java.Io.File file, bool boolean, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JarFile(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public JarFile(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/util/jar/JarEntry;>;")]
				public new virtual global::Java.Util.IEnumeration<global::Java.Util.Jar.JarEntry> Entries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Util.Jar.JarEntry>);
				}

				/// <java-name>
				/// getJarEntry
				/// </java-name>
				[Dot42.DexImport("getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.JarEntry GetJarEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.JarEntry);
				}

				/// <java-name>
				/// getManifest
				/// </java-name>
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Manifest GetManifest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Manifest);
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetInputStream(global::Java.Util.Zip.ZipEntry zipEntry) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
				public override global::Java.Util.Zip.ZipEntry GetEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

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

				/// <java-name>
				/// getManifest
				/// </java-name>
				public global::Java.Util.Jar.Manifest Manifest
				{
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
						get{ return GetManifest(); }
				}

		}

		/// <java-name>
		/// java/util/jar/Manifest
		/// </java-name>
		[Dot42.DexImport("java/util/jar/Manifest", AccessFlags = 33)]
		public partial class Manifest : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Manifest() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public Manifest(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/jar/Manifest;)V", AccessFlags = 1)]
				public Manifest(global::Java.Util.Jar.Manifest manifest) /* MethodBuilder.Create */ 
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
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetAttributes(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <java-name>
				/// getEntries
				/// </java-name>
				[Dot42.DexImport("getEntries", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/jar/Attributes;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Util.Jar.Attributes> GetEntries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.Jar.Attributes>);
				}

				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetMainAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void Write(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void Read(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
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
				/// getEntries
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.Jar.Attributes> Entries
				{
				[Dot42.DexImport("getEntries", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/jar/Attributes;>;")]
						get{ return GetEntries(); }
				}

				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes MainAttributes
				{
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetMainAttributes(); }
				}

		}

		/// <java-name>
		/// java/util/jar/Pack200
		/// </java-name>
		[Dot42.DexImport("java/util/jar/Pack200", AccessFlags = 1057)]
		public abstract partial class Pack200
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Pack200() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newPacker
				/// </java-name>
				[Dot42.DexImport("newPacker", "()Ljava/util/jar/Pack200$Packer;", AccessFlags = 9)]
				public static global::Java.Util.Jar.Pack200.IPacker NewPacker() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Pack200.IPacker);
				}

				/// <java-name>
				/// newUnpacker
				/// </java-name>
				[Dot42.DexImport("newUnpacker", "()Ljava/util/jar/Pack200$Unpacker;", AccessFlags = 9)]
				public static global::Java.Util.Jar.Pack200.IUnpacker NewUnpacker() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Pack200.IUnpacker);
				}

				/// <java-name>
				/// java/util/jar/Pack200$Unpacker
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Unpacker", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IUnpackerConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFLATE_HINT
						/// </java-name>
						[Dot42.DexImport("DEFLATE_HINT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFLATE_HINT = "unpack.deflate.hint";
						/// <java-name>
						/// FALSE
						/// </java-name>
						[Dot42.DexImport("FALSE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FALSE = "false";
						/// <java-name>
						/// KEEP
						/// </java-name>
						[Dot42.DexImport("KEEP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEEP = "keep";
						/// <java-name>
						/// PROGRESS
						/// </java-name>
						[Dot42.DexImport("PROGRESS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROGRESS = "unpack.progress";
						/// <java-name>
						/// TRUE
						/// </java-name>
						[Dot42.DexImport("TRUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TRUE = "true";
				}

				/// <java-name>
				/// java/util/jar/Pack200$Unpacker
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Unpacker", AccessFlags = 1545)]
				public partial interface IUnpacker
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// properties
						/// </java-name>
						[Dot42.DexImport("properties", "()Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "()Ljava/util/SortedMap<Ljava/lang/String;Ljava/lang/String;>;")]
						global::Java.Util.ISortedMap<string, string> Properties() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// unpack
						/// </java-name>
						[Dot42.DexImport("unpack", "(Ljava/io/InputStream;Ljava/util/jar/JarOutputStream;)V", AccessFlags = 1025)]
						void Unpack(global::Java.Io.InputStream inputStream, global::Java.Util.Jar.JarOutputStream jarOutputStream) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// unpack
						/// </java-name>
						[Dot42.DexImport("unpack", "(Ljava/io/File;Ljava/util/jar/JarOutputStream;)V", AccessFlags = 1025)]
						void Unpack(global::Java.Io.File file, global::Java.Util.Jar.JarOutputStream jarOutputStream) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// addPropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// removePropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// java/util/jar/Pack200$Packer
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Packer", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IPackerConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLASS_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("CLASS_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CLASS_ATTRIBUTE_PFX = "pack.class.attribute.";
						/// <java-name>
						/// CODE_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("CODE_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CODE_ATTRIBUTE_PFX = "pack.code.attribute.";
						/// <java-name>
						/// DEFLATE_HINT
						/// </java-name>
						[Dot42.DexImport("DEFLATE_HINT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEFLATE_HINT = "pack.deflate.hint";
						/// <java-name>
						/// EFFORT
						/// </java-name>
						[Dot42.DexImport("EFFORT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFORT = "pack.effort";
						/// <java-name>
						/// ERROR
						/// </java-name>
						[Dot42.DexImport("ERROR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ERROR = "error";
						/// <java-name>
						/// FALSE
						/// </java-name>
						[Dot42.DexImport("FALSE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FALSE = "false";
						/// <java-name>
						/// FIELD_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("FIELD_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FIELD_ATTRIBUTE_PFX = "pack.field.attribute.";
						/// <java-name>
						/// KEEP
						/// </java-name>
						[Dot42.DexImport("KEEP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEEP = "keep";
						/// <java-name>
						/// KEEP_FILE_ORDER
						/// </java-name>
						[Dot42.DexImport("KEEP_FILE_ORDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEEP_FILE_ORDER = "pack.keep.file.order";
						/// <java-name>
						/// LATEST
						/// </java-name>
						[Dot42.DexImport("LATEST", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LATEST = "latest";
						/// <java-name>
						/// METHOD_ATTRIBUTE_PFX
						/// </java-name>
						[Dot42.DexImport("METHOD_ATTRIBUTE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string METHOD_ATTRIBUTE_PFX = "pack.method.attribute.";
						/// <java-name>
						/// MODIFICATION_TIME
						/// </java-name>
						[Dot42.DexImport("MODIFICATION_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODIFICATION_TIME = "pack.modification.time";
						/// <java-name>
						/// PASS
						/// </java-name>
						[Dot42.DexImport("PASS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PASS = "pass";
						/// <java-name>
						/// PASS_FILE_PFX
						/// </java-name>
						[Dot42.DexImport("PASS_FILE_PFX", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PASS_FILE_PFX = "pack.pass.file.";
						/// <java-name>
						/// PROGRESS
						/// </java-name>
						[Dot42.DexImport("PROGRESS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROGRESS = "pack.progress";
						/// <java-name>
						/// SEGMENT_LIMIT
						/// </java-name>
						[Dot42.DexImport("SEGMENT_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEGMENT_LIMIT = "pack.segment.limit";
						/// <java-name>
						/// STRIP
						/// </java-name>
						[Dot42.DexImport("STRIP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STRIP = "strip";
						/// <java-name>
						/// TRUE
						/// </java-name>
						[Dot42.DexImport("TRUE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string TRUE = "true";
						/// <java-name>
						/// UNKNOWN_ATTRIBUTE
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_ATTRIBUTE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UNKNOWN_ATTRIBUTE = "pack.unknown.attribute";
				}

				/// <java-name>
				/// java/util/jar/Pack200$Packer
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Pack200$Packer", AccessFlags = 1545)]
				public partial interface IPacker
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// properties
						/// </java-name>
						[Dot42.DexImport("properties", "()Ljava/util/SortedMap;", AccessFlags = 1025, Signature = "()Ljava/util/SortedMap<Ljava/lang/String;Ljava/lang/String;>;")]
						global::Java.Util.ISortedMap<string, string> Properties() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// pack
						/// </java-name>
						[Dot42.DexImport("pack", "(Ljava/util/jar/JarFile;Ljava/io/OutputStream;)V", AccessFlags = 1025)]
						void Pack(global::Java.Util.Jar.JarFile jarFile, global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// pack
						/// </java-name>
						[Dot42.DexImport("pack", "(Ljava/util/jar/JarInputStream;Ljava/io/OutputStream;)V", AccessFlags = 1025)]
						void Pack(global::Java.Util.Jar.JarInputStream jarInputStream, global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// addPropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// removePropertyChangeListener
						/// </java-name>
						[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1025)]
						void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// java/util/jar/JarInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarInputStream", AccessFlags = 33)]
		public partial class JarInputStream : global::Java.Util.Zip.ZipInputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Z)V", AccessFlags = 1)]
				public JarInputStream(global::Java.Io.InputStream inputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public JarInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getManifest
				/// </java-name>
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Manifest GetManifest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Manifest);
				}

				/// <java-name>
				/// getNextJarEntry
				/// </java-name>
				[Dot42.DexImport("getNextJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.JarEntry GetNextJarEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.JarEntry);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNextEntry
				/// </java-name>
				[Dot42.DexImport("getNextEntry", "()Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
				public override global::Java.Util.Zip.ZipEntry GetNextEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				/// <java-name>
				/// createZipEntry
				/// </java-name>
				[Dot42.DexImport("createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 4)]
				protected internal override global::Java.Util.Zip.ZipEntry CreateZipEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getManifest
				/// </java-name>
				public global::Java.Util.Jar.Manifest Manifest
				{
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
						get{ return GetManifest(); }
				}

				/// <java-name>
				/// getNextJarEntry
				/// </java-name>
				public global::Java.Util.Jar.JarEntry NextJarEntry
				{
				[Dot42.DexImport("getNextJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
						get{ return GetNextJarEntry(); }
				}

				/// <java-name>
				/// getNextEntry
				/// </java-name>
				public global::Java.Util.Zip.ZipEntry NextEntry
				{
				[Dot42.DexImport("getNextEntry", "()Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
						get{ return GetNextEntry(); }
				}

		}

		/// <java-name>
		/// java/util/jar/Attributes
		/// </java-name>
		[Dot42.DexImport("java/util/jar/Attributes", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/lang/Cloneable;Ljava/util/Map<Ljava/lang/Object;Ljava/lan" +
    "g/Object;>;")]
		public partial class Attributes : global::Java.Lang.ICloneable, global::Java.Util.IMap<object, object>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// map
				/// </java-name>
				[Dot42.DexImport("map", "Ljava/util/Map;", AccessFlags = 4)]
				protected internal global::Java.Util.IMap<object, object> Map;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Attributes() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/jar/Attributes;)V", AccessFlags = 1)]
				public Attributes(global::Java.Util.Jar.Attributes attributes) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Attributes(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/Object;Ljava/lang/Object;>;>;")]
				public virtual global::Java.Util.ISet<global::Java.Util.IMap_IEntry<object, object>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<object, object>>);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.ISet<object> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<object>);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Put(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<**>;)V")]
				public virtual void PutAll(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
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

				/// <java-name>
				/// putValue
				/// </java-name>
				[Dot42.DexImport("putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string PutValue(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// java/util/jar/Attributes$Name
				/// </java-name>
				[Dot42.DexImport("java/util/jar/Attributes$Name", AccessFlags = 9)]
				public partial class Name
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLASS_PATH
						/// </java-name>
						[Dot42.DexImport("CLASS_PATH", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name CLASS_PATH;
						/// <java-name>
						/// MANIFEST_VERSION
						/// </java-name>
						[Dot42.DexImport("MANIFEST_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name MANIFEST_VERSION;
						/// <java-name>
						/// MAIN_CLASS
						/// </java-name>
						[Dot42.DexImport("MAIN_CLASS", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name MAIN_CLASS;
						/// <java-name>
						/// SIGNATURE_VERSION
						/// </java-name>
						[Dot42.DexImport("SIGNATURE_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SIGNATURE_VERSION;
						/// <java-name>
						/// CONTENT_TYPE
						/// </java-name>
						[Dot42.DexImport("CONTENT_TYPE", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name CONTENT_TYPE;
						/// <java-name>
						/// SEALED
						/// </java-name>
						[Dot42.DexImport("SEALED", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SEALED;
						/// <java-name>
						/// IMPLEMENTATION_TITLE
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_TITLE", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_TITLE;
						/// <java-name>
						/// IMPLEMENTATION_VERSION
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_VERSION;
						/// <java-name>
						/// IMPLEMENTATION_VENDOR
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_VENDOR", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_VENDOR;
						/// <java-name>
						/// SPECIFICATION_TITLE
						/// </java-name>
						[Dot42.DexImport("SPECIFICATION_TITLE", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SPECIFICATION_TITLE;
						/// <java-name>
						/// SPECIFICATION_VERSION
						/// </java-name>
						[Dot42.DexImport("SPECIFICATION_VERSION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SPECIFICATION_VERSION;
						/// <java-name>
						/// SPECIFICATION_VENDOR
						/// </java-name>
						[Dot42.DexImport("SPECIFICATION_VENDOR", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name SPECIFICATION_VENDOR;
						/// <java-name>
						/// EXTENSION_LIST
						/// </java-name>
						[Dot42.DexImport("EXTENSION_LIST", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name EXTENSION_LIST;
						/// <java-name>
						/// EXTENSION_NAME
						/// </java-name>
						[Dot42.DexImport("EXTENSION_NAME", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name EXTENSION_NAME;
						/// <java-name>
						/// EXTENSION_INSTALLATION
						/// </java-name>
						[Dot42.DexImport("EXTENSION_INSTALLATION", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name EXTENSION_INSTALLATION;
						/// <java-name>
						/// IMPLEMENTATION_VENDOR_ID
						/// </java-name>
						[Dot42.DexImport("IMPLEMENTATION_VENDOR_ID", "Ljava/util/jar/Attributes$Name;", AccessFlags = 25)]
						public static readonly Name IMPLEMENTATION_VENDOR_ID;
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

		/// <java-name>
		/// java/util/jar/JarException
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarException", AccessFlags = 33)]
		public partial class JarException : global::Java.Util.Zip.ZipException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public JarException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JarException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/jar/JarOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarOutputStream", AccessFlags = 33)]
		public partial class JarOutputStream : global::Java.Util.Zip.ZipOutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/jar/Manifest;)V", AccessFlags = 1)]
				public JarOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Util.Jar.Manifest manifest) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public JarOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putNextEntry
				/// </java-name>
				[Dot42.DexImport("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public override void PutNextEntry(global::Java.Util.Zip.ZipEntry zipEntry) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/jar/JarEntry
		/// </java-name>
		[Dot42.DexImport("java/util/jar/JarEntry", AccessFlags = 33)]
		public partial class JarEntry : global::Java.Util.Zip.ZipEntry
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JarEntry(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public JarEntry(global::Java.Util.Zip.ZipEntry zipEntry) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/jar/JarEntry;)V", AccessFlags = 1)]
				public JarEntry(global::Java.Util.Jar.JarEntry jarEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

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

				/// <java-name>
				/// getAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes Attributes
				{
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] Certificates
				{
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetCertificates(); }
				}

				/// <java-name>
				/// getCodeSigners
				/// </java-name>
				public global::Java.Security.CodeSigner[] CodeSigners
				{
				[Dot42.DexImport("getCodeSigners", "()[Ljava/security/CodeSigner;", AccessFlags = 1)]
						get{ return GetCodeSigners(); }
				}

		}

}

