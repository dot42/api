#pragma warning disable 1717
namespace Dalvik.System
{
		/// <java-name>
		/// dalvik/system/DexClassLoader
		/// </java-name>
		[Dot42.DexImport("dalvik/system/DexClassLoader", AccessFlags = 33)]
		public partial class DexClassLoader : global::Java.Lang.ClassLoader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public DexClassLoader(string @string, string string1, string string2, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findClass
				/// </java-name>
				[Dot42.DexImport("findClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal override global::System.Type FindClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// findResource
				/// </java-name>
				[Dot42.DexImport("findResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 4)]
				protected internal override global::Java.Net.URL FindResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// findLibrary
				/// </java-name>
				[Dot42.DexImport("findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal override string FindLibrary(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", AccessFlags = 4)]
				protected internal override global::Java.Lang.Package GetPackage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DexClassLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// dalvik/system/DexFile
		/// </java-name>
		[Dot42.DexImport("dalvik/system/DexFile", AccessFlags = 49)]
		public sealed partial class DexFile
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public DexFile(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DexFile(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadDex
				/// </java-name>
				[Dot42.DexImport("loadDex", "(Ljava/lang/String;Ljava/lang/String;I)Ldalvik/system/DexFile;", AccessFlags = 9)]
				public static global::Dalvik.System.DexFile LoadDex(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Dalvik.System.DexFile);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadClass
				/// </java-name>
				[Dot42.DexImport("loadClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", AccessFlags = 1)]
				public global::System.Type LoadClass(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public global::Java.Util.IEnumeration<string> Entries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<string>);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~DexFile() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDexOptNeeded
				/// </java-name>
				[Dot42.DexImport("isDexOptNeeded", "(Ljava/lang/String;)Z", AccessFlags = 265)]
				public static bool IsDexOptNeeded(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DexFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// dalvik/system/PathClassLoader
		/// </java-name>
		[Dot42.DexImport("dalvik/system/PathClassLoader", AccessFlags = 33)]
		public partial class PathClassLoader : global::Java.Lang.ClassLoader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public PathClassLoader(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public PathClassLoader(string @string, string string1, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findClass
				/// </java-name>
				[Dot42.DexImport("findClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal override global::System.Type FindClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// findResource
				/// </java-name>
				[Dot42.DexImport("findResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 4)]
				protected internal override global::Java.Net.URL FindResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// findResources
				/// </java-name>
				[Dot42.DexImport("findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				protected internal override global::Java.Util.IEnumeration<global::Java.Net.URL> FindResources(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <java-name>
				/// findLibrary
				/// </java-name>
				[Dot42.DexImport("findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public new virtual string FindLibrary(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", AccessFlags = 4)]
				protected internal override global::Java.Lang.Package GetPackage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
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
				internal PathClassLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

