// Copyright (C) 2014 dot42
//
// Original filename: Dalvik.System.cs
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
namespace Dalvik.System
{
		/// <summary>
		/// <para>Manipulates DEX files. The class is similar in principle to java.util.zip.ZipFile. It is used primarily by class loaders. </para><para>Note we don't directly open and read the DEX file here. They're memory-mapped read-only by the VM. </para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/DexFile
		/// </java-name>
		[Dot42.DexImport("dalvik/system/DexFile", AccessFlags = 49)]
		public sealed partial class DexFile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Opens a DEX file from a given File object. This will usually be a ZIP/JAR file with a "classes.dex" inside.</para><para>The VM will generate the name of the corresponding file in /data/dalvik-cache and open it, possibly creating or updating it first if system permissions allow. Don't pass in the name of a file in /data/dalvik-cache, as the named file is expected to be in its original (pre-dexopt) state.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public DexFile(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Opens a DEX file from a given File object. This will usually be a ZIP/JAR file with a "classes.dex" inside.</para><para>The VM will generate the name of the corresponding file in /data/dalvik-cache and open it, possibly creating or updating it first if system permissions allow. Don't pass in the name of a file in /data/dalvik-cache, as the named file is expected to be in its original (pre-dexopt) state.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DexFile(string file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Open a DEX file, specifying the file in which the optimized DEX data should be written. If the optimized form exists and appears to be current, it will be used; if not, the VM will attempt to regenerate it.</para><para>This is intended for use by applications that wish to download and execute DEX files outside the usual application installation mechanism. This function should not be called directly by an application; instead, use a class loader such as dalvik.system.DexClassLoader.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new or previously-opened DexFile. </para>
				/// </returns>
				/// <java-name>
				/// loadDex
				/// </java-name>
				[Dot42.DexImport("loadDex", "(Ljava/lang/String;Ljava/lang/String;I)Ldalvik/system/DexFile;", AccessFlags = 9)]
				public static global::Dalvik.System.DexFile LoadDex(string sourcePathName, string outputPathName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Dalvik.System.DexFile);
				}

				/// <summary>
				/// <para>Gets the name of the (already opened) DEX file.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Closes the DEX file. </para><para>This may not be able to release any resources. If classes from this DEX file are still resident, the DEX file can't be unmapped.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads a class. Returns the class on success, or a <c> null </c> reference on failure. </para><para>If you are not calling this from a class loader, this is most likely not going to do what you want. Use Class#forName(String) instead. </para><para>The method does not throw ClassNotFoundException if the class isn't found because it isn't reasonable to throw exceptions wildly every time a class is not found in the first DEX file we look at.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Class object representing the class, or <c> null </c> if the class cannot be loaded </para>
				/// </returns>
				/// <java-name>
				/// loadClass
				/// </java-name>
				[Dot42.DexImport("loadClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", AccessFlags = 1)]
				public global::System.Type LoadClass(string name, global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Enumerate the names of the classes in this DEX file.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an enumeration of names of classes contained in the DEX file, in the usual internal form (like "java/lang/String"). </para>
				/// </returns>
				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public global::Java.Util.IEnumeration<string> Entries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<string>);
				}

				/// <summary>
				/// <para>Called when the class is finalized. Makes sure the DEX file is closed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~DexFile() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the VM believes that the apk/jar file is out of date and should be passed through "dexopt" again.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if dexopt should be called on the file, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDexOptNeeded
				/// </java-name>
				[Dot42.DexImport("isDexOptNeeded", "(Ljava/lang/String;)Z", AccessFlags = 265)]
				public static bool IsDexOptNeeded(string fileName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DexFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the name of the (already opened) DEX file.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

		}

		/// <summary>
		/// <para>Provides a simple ClassLoader implementation that operates on a list of files and directories in the local file system, but does not attempt to load classes from the network. Android uses this class for its system class loader and for its application class loader(s). </para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/PathClassLoader
		/// </java-name>
		[Dot42.DexImport("dalvik/system/PathClassLoader", AccessFlags = 33)]
		public partial class PathClassLoader : global::Java.Lang.ClassLoader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a <c> PathClassLoader </c> that operates on a given list of files and directories. This method is equivalent to calling PathClassLoader(String, String, ClassLoader) with a <c> null </c> value for the second argument (see description there).</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public PathClassLoader(string dexPath, global::Java.Lang.ClassLoader parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> PathClassLoader </c> that operates on two given lists of files and directories. The entries of the first list should be one of the following:</para><para><ul><li><para>JAR/ZIP/APK files, possibly containing a "classes.dex" file as well as arbitrary resources. </para></li><li><para>Raw ".dex" files (not inside a zip file). </para></li></ul></para><para>The entries of the second list should be directories containing native library files.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public PathClassLoader(string dexPath, string libraryPath, global::Java.Lang.ClassLoader parent) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>A class loader that loads classes from <c> .jar </c> and <c> .apk </c> files containing a <c> classes.dex </c> entry. This can be used to execute code not installed as part of an application.</para><para>This class loader requires an application-private, writable directory to cache optimized classes. Use <c> Context.getDir(String, int) </c> to create such a directory: <pre>        File dexOutputDir = context.getDir("dex", 0);
		/// 
		///  </pre></para><para><b>Do not cache optimized classes on external storage.</b> External storage does not provide access controls necessary to protect your application from code injection attacks. </para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/DexClassLoader
		/// </java-name>
		[Dot42.DexImport("dalvik/system/DexClassLoader", AccessFlags = 33)]
		public partial class DexClassLoader : global::Java.Lang.ClassLoader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a <c> DexClassLoader </c> that finds interpreted and native code. Interpreted classes are found in a set of DEX files contained in Jar or APK files.</para><para>The path lists are separated using the character specified by the <c> path.separator </c> system property, which defaults to <c> : </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public DexClassLoader(string dexPath, string optimizedDirectory, string libraryPath, global::Java.Lang.ClassLoader parent) /* MethodBuilder.Create */ 
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

}


