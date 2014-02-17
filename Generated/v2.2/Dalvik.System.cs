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
		/// <para>Obsolete, for binary compatibility only.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/TemporaryDirectory
		/// </java-name>
		[Dot42.DexImport("dalvik/system/TemporaryDirectory", AccessFlags = 33)]
		public partial class TemporaryDirectory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TemporaryDirectory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method exists for binary compatibility only. </para>        
				/// </summary>
				/// <java-name>
				/// setUpDirectory
				/// </java-name>
				[Dot42.DexImport("setUpDirectory", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetUpDirectory(string baseDir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method exists for binary compatibility only. </para>        
				/// </summary>
				/// <java-name>
				/// setUpDirectory
				/// </java-name>
				[Dot42.DexImport("setUpDirectory", "(Ljava/io/File;)V", AccessFlags = 41)]
				public static void SetUpDirectory(global::Java.Io.File baseDir) /* MethodBuilder.Create */ 
				{
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
		/// <para>Provides access to some VM-specific debug features. Though this class and many of its members are public, this class is meant to be wrapped in a more friendly way for use by application developers. On the Android platform, the recommended way to access this functionality is through the class <code>android.os.Debug</code>.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/VMDebug
		/// </java-name>
		[Dot42.DexImport("dalvik/system/VMDebug", AccessFlags = 49)]
		public sealed partial class VMDebug
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Specifies the default method trace data file name.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>only used in one place, which is unused and deprecated </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_METHOD_TRACE_FILE_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_METHOD_TRACE_FILE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_METHOD_TRACE_FILE_NAME = "/sdcard/dmtrace.trace";
				/// <summary>
				/// <para>flag for startMethodTracing(), which adds the results from startAllocCounting to the trace key file. </para>        
				/// </summary>
				/// <java-name>
				/// TRACE_COUNT_ALLOCS
				/// </java-name>
				[Dot42.DexImport("TRACE_COUNT_ALLOCS", "I", AccessFlags = 25)]
				public const int TRACE_COUNT_ALLOCS = 1;
				/// <java-name>
				/// KIND_GLOBAL_ALLOCATED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_ALLOCATED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_ALLOCATED_OBJECTS = 1;
				/// <java-name>
				/// KIND_GLOBAL_ALLOCATED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_ALLOCATED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_ALLOCATED_BYTES = 2;
				/// <java-name>
				/// KIND_GLOBAL_FREED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_FREED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_FREED_OBJECTS = 4;
				/// <java-name>
				/// KIND_GLOBAL_FREED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_FREED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_FREED_BYTES = 8;
				/// <java-name>
				/// KIND_GLOBAL_GC_INVOCATIONS
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_GC_INVOCATIONS", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_GC_INVOCATIONS = 16;
				/// <java-name>
				/// KIND_GLOBAL_CLASS_INIT_COUNT
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_CLASS_INIT_COUNT", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_CLASS_INIT_COUNT = 32;
				/// <java-name>
				/// KIND_GLOBAL_CLASS_INIT_TIME
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_CLASS_INIT_TIME", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_CLASS_INIT_TIME = 64;
				/// <java-name>
				/// KIND_GLOBAL_EXT_ALLOCATED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_EXT_ALLOCATED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_EXT_ALLOCATED_OBJECTS = 4096;
				/// <java-name>
				/// KIND_GLOBAL_EXT_ALLOCATED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_EXT_ALLOCATED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_EXT_ALLOCATED_BYTES = 8192;
				/// <java-name>
				/// KIND_GLOBAL_EXT_FREED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_EXT_FREED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_EXT_FREED_OBJECTS = 16384;
				/// <java-name>
				/// KIND_GLOBAL_EXT_FREED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_GLOBAL_EXT_FREED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_GLOBAL_EXT_FREED_BYTES = 32768;
				/// <java-name>
				/// KIND_THREAD_ALLOCATED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_ALLOCATED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_THREAD_ALLOCATED_OBJECTS = 65536;
				/// <java-name>
				/// KIND_THREAD_ALLOCATED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_ALLOCATED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_THREAD_ALLOCATED_BYTES = 131072;
				/// <java-name>
				/// KIND_THREAD_FREED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_FREED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_THREAD_FREED_OBJECTS = 262144;
				/// <java-name>
				/// KIND_THREAD_FREED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_FREED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_THREAD_FREED_BYTES = 524288;
				/// <java-name>
				/// KIND_THREAD_GC_INVOCATIONS
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_GC_INVOCATIONS", "I", AccessFlags = 25)]
				public const int KIND_THREAD_GC_INVOCATIONS = 1048576;
				/// <java-name>
				/// KIND_THREAD_CLASS_INIT_COUNT
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_CLASS_INIT_COUNT", "I", AccessFlags = 25)]
				public const int KIND_THREAD_CLASS_INIT_COUNT = 2097152;
				/// <java-name>
				/// KIND_THREAD_CLASS_INIT_TIME
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_CLASS_INIT_TIME", "I", AccessFlags = 25)]
				public const int KIND_THREAD_CLASS_INIT_TIME = 4194304;
				/// <java-name>
				/// KIND_THREAD_EXT_ALLOCATED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_EXT_ALLOCATED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_THREAD_EXT_ALLOCATED_OBJECTS = 268435456;
				/// <java-name>
				/// KIND_THREAD_EXT_ALLOCATED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_EXT_ALLOCATED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_THREAD_EXT_ALLOCATED_BYTES = 536870912;
				/// <java-name>
				/// KIND_THREAD_EXT_FREED_OBJECTS
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_EXT_FREED_OBJECTS", "I", AccessFlags = 25)]
				public const int KIND_THREAD_EXT_FREED_OBJECTS = 1073741824;
				/// <java-name>
				/// KIND_THREAD_EXT_FREED_BYTES
				/// </java-name>
				[Dot42.DexImport("KIND_THREAD_EXT_FREED_BYTES", "I", AccessFlags = 25)]
				public const int KIND_THREAD_EXT_FREED_BYTES = -2147483648;
				/// <java-name>
				/// KIND_ALL_COUNTS
				/// </java-name>
				[Dot42.DexImport("KIND_ALL_COUNTS", "I", AccessFlags = 25)]
				public const int KIND_ALL_COUNTS = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal VMDebug() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the time since the last known debugger activity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time in milliseconds, or -1 if the debugger is not connected </para>
				/// </returns>
				/// <java-name>
				/// lastDebuggerActivity
				/// </java-name>
				[Dot42.DexImport("lastDebuggerActivity", "()J", AccessFlags = 265)]
				public static long LastDebuggerActivity() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Determines if debugging is enabled in this VM. If debugging is not enabled, a debugger cannot be attached.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if debugging is enabled </para>
				/// </returns>
				/// <java-name>
				/// isDebuggingEnabled
				/// </java-name>
				[Dot42.DexImport("isDebuggingEnabled", "()Z", AccessFlags = 265)]
				public static bool IsDebuggingEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Determines if a debugger is currently attached.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if (and only if) a debugger is connected </para>
				/// </returns>
				/// <java-name>
				/// isDebuggerConnected
				/// </java-name>
				[Dot42.DexImport("isDebuggerConnected", "()Z", AccessFlags = 265)]
				public static bool IsDebuggerConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Start method tracing with default name, size, and with <code>0</code> flags.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>not used, not needed </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "()V", AccessFlags = 9)]
				public static void StartMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start method tracing, specifying a file name as well as a default buffer size. See  for information about reading trace files.</para><para>You can use either a fully qualified path and name, or just a name. If only a name is specified, the file will be created under the /sdcard/ directory. If a name is not given, the default is /sdcard/dmtrace.trace.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;II)V", AccessFlags = 9)]
				public static void StartMethodTracing(string traceFileName, int bufferSize, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops method tracing. </para>        
				/// </summary>
				/// <java-name>
				/// stopMethodTracing
				/// </java-name>
				[Dot42.DexImport("stopMethodTracing", "()V", AccessFlags = 265)]
				public static void StopMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts sending Dalvik method trace info to the emulator. </para>        
				/// </summary>
				/// <java-name>
				/// startEmulatorTracing
				/// </java-name>
				[Dot42.DexImport("startEmulatorTracing", "()V", AccessFlags = 265)]
				public static void StartEmulatorTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops sending Dalvik method trace info to the emulator. </para>        
				/// </summary>
				/// <java-name>
				/// stopEmulatorTracing
				/// </java-name>
				[Dot42.DexImport("stopEmulatorTracing", "()V", AccessFlags = 265)]
				public static void StopEmulatorTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get an indication of thread CPU usage. The value returned indicates the amount of time that the current thread has spent executing code or waiting for certain types of I/O. </para><para>The time is expressed in nanoseconds, and is only meaningful when compared to the result from an earlier call. Note that nanosecond resolution does not imply nanosecond accuracy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CPU usage. A value of -1 means the system does not support this feature. </para>
				/// </returns>
				/// <java-name>
				/// threadCpuTimeNanos
				/// </java-name>
				[Dot42.DexImport("threadCpuTimeNanos", "()J", AccessFlags = 265)]
				public static long ThreadCpuTimeNanos() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Count the number and aggregate size of memory allocations between two points. </para>        
				/// </summary>
				/// <java-name>
				/// startAllocCounting
				/// </java-name>
				[Dot42.DexImport("startAllocCounting", "()V", AccessFlags = 265)]
				public static void StartAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopAllocCounting
				/// </java-name>
				[Dot42.DexImport("stopAllocCounting", "()V", AccessFlags = 265)]
				public static void StopAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllocCount
				/// </java-name>
				[Dot42.DexImport("getAllocCount", "(I)I", AccessFlags = 265)]
				public static int GetAllocCount(int kind) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// resetAllocCount
				/// </java-name>
				[Dot42.DexImport("resetAllocCount", "(I)V", AccessFlags = 265)]
				public static void ResetAllocCount(int kinds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of the allocation limits API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// setAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setAllocationLimit", "(I)I", AccessFlags = 265)]
				public static int SetAllocationLimit(int limit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of the allocation limits API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// setGlobalAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setGlobalAllocationLimit", "(I)I", AccessFlags = 265)]
				public static int SetGlobalAllocationLimit(int limit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Count the number of instructions executed between two points. </para>        
				/// </summary>
				/// <java-name>
				/// startInstructionCounting
				/// </java-name>
				[Dot42.DexImport("startInstructionCounting", "()V", AccessFlags = 265)]
				public static void StartInstructionCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopInstructionCounting
				/// </java-name>
				[Dot42.DexImport("stopInstructionCounting", "()V", AccessFlags = 265)]
				public static void StopInstructionCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstructionCount
				/// </java-name>
				[Dot42.DexImport("getInstructionCount", "([I)V", AccessFlags = 265)]
				public static void GetInstructionCount(int[] counts) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetInstructionCount
				/// </java-name>
				[Dot42.DexImport("resetInstructionCount", "()V", AccessFlags = 265)]
				public static void ResetInstructionCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Dumps a list of loaded class to the log file. </para>        
				/// </summary>
				/// <java-name>
				/// printLoadedClasses
				/// </java-name>
				[Dot42.DexImport("printLoadedClasses", "(I)V", AccessFlags = 265)]
				public static void PrintLoadedClasses(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of loaded classes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of loaded classes </para>
				/// </returns>
				/// <java-name>
				/// getLoadedClassCount
				/// </java-name>
				[Dot42.DexImport("getLoadedClassCount", "()I", AccessFlags = 265)]
				public static int GetLoadedClassCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Dumps "hprof" data to the specified file. This may cause a GC.</para><para>The VM may create a temporary file in the same directory.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// dumpHprofData
				/// </java-name>
				[Dot42.DexImport("dumpHprofData", "(Ljava/lang/String;)V", AccessFlags = 265)]
				public static void DumpHprofData(string filename) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of loaded classes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of loaded classes </para>
				/// </returns>
				/// <java-name>
				/// getLoadedClassCount
				/// </java-name>
				public static int LoadedClassCount
				{
				[Dot42.DexImport("getLoadedClassCount", "()I", AccessFlags = 265)]
						get{ return GetLoadedClassCount(); }
				}

		}

		/// <summary>
		/// <para>Provides an interface to VM-global, Dalvik-specific features. An application cannot create its own Runtime instance, and must obtain one from the getRuntime method.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/VMRuntime
		/// </java-name>
		[Dot42.DexImport("dalvik/system/VMRuntime", AccessFlags = 49)]
		public sealed partial class VMRuntime
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Prevents this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal VMRuntime() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the object that represents the VM instance's Dalvik-specific runtime environment.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the runtime object </para>
				/// </returns>
				/// <java-name>
				/// getRuntime
				/// </java-name>
				[Dot42.DexImport("getRuntime", "()Ldalvik/system/VMRuntime;", AccessFlags = 9)]
				public static global::Dalvik.System.VMRuntime GetRuntime() /* MethodBuilder.Create */ 
				{
						return default(global::Dalvik.System.VMRuntime);
				}

				/// <summary>
				/// <para>Gets the current ideal heap utilization, represented as a number between zero and one. After a GC happens, the Dalvik heap may be resized so that (size of live objects) / (size of heap) is equal to this number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current ideal heap utilization </para>
				/// </returns>
				/// <java-name>
				/// getTargetHeapUtilization
				/// </java-name>
				[Dot42.DexImport("getTargetHeapUtilization", "()F", AccessFlags = 257)]
				public float GetTargetHeapUtilization() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets the current ideal heap utilization, represented as a number between zero and one. After a GC happens, the Dalvik heap may be resized so that (size of live objects) / (size of heap) is equal to this number.</para><para>This is only a hint to the garbage collector and may be ignored.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous ideal heap utilization </para>
				/// </returns>
				/// <java-name>
				/// setTargetHeapUtilization
				/// </java-name>
				[Dot42.DexImport("setTargetHeapUtilization", "(F)F", AccessFlags = 1)]
				public float SetTargetHeapUtilization(float newTarget) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of a heap sizing API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// getMinimumHeapSize
				/// </java-name>
				[Dot42.DexImport("getMinimumHeapSize", "()J", AccessFlags = 1)]
				public long GetMinimumHeapSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of a heap sizing API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// setMinimumHeapSize
				/// </java-name>
				[Dot42.DexImport("setMinimumHeapSize", "(J)J", AccessFlags = 33)]
				public long SetMinimumHeapSize(long size) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It used to perform a garbage collection that cleared SoftReferences. </para>        
				/// </summary>
				/// <java-name>
				/// gcSoftReferences
				/// </java-name>
				[Dot42.DexImport("gcSoftReferences", "()V", AccessFlags = 257)]
				public void GcSoftReferences() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It is equivalent to System#runFinalization. </para>        
				/// </summary>
				/// <java-name>
				/// runFinalizationSync
				/// </java-name>
				[Dot42.DexImport("runFinalizationSync", "()V", AccessFlags = 257)]
				public void RunFinalizationSync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of the external allocation API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// getExternalBytesAllocated
				/// </java-name>
				[Dot42.DexImport("getExternalBytesAllocated", "()J", AccessFlags = 257)]
				public long GetExternalBytesAllocated() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the object that represents the VM instance's Dalvik-specific runtime environment.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the runtime object </para>
				/// </returns>
				/// <java-name>
				/// getRuntime
				/// </java-name>
				public static global::Dalvik.System.VMRuntime Runtime
				{
				[Dot42.DexImport("getRuntime", "()Ldalvik/system/VMRuntime;", AccessFlags = 9)]
						get{ return GetRuntime(); }
				}

				/// <summary>
				/// <para>Gets the current ideal heap utilization, represented as a number between zero and one. After a GC happens, the Dalvik heap may be resized so that (size of live objects) / (size of heap) is equal to this number.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current ideal heap utilization </para>
				/// </returns>
				/// <java-name>
				/// getTargetHeapUtilization
				/// </java-name>
				public float TargetHeapUtilization
				{
				[Dot42.DexImport("getTargetHeapUtilization", "()F", AccessFlags = 257)]
						get{ return GetTargetHeapUtilization(); }
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of a heap sizing API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// getMinimumHeapSize
				/// </java-name>
				public long MinimumHeapSize
				{
				[Dot42.DexImport("getMinimumHeapSize", "()J", AccessFlags = 1)]
						get{ return GetMinimumHeapSize(); }
				}

				/// <summary>
				/// <para>This method exists for binary compatibility. It was part of the external allocation API which was removed in Honeycomb. </para>        
				/// </summary>
				/// <java-name>
				/// getExternalBytesAllocated
				/// </java-name>
				public long ExternalBytesAllocated
				{
				[Dot42.DexImport("getExternalBytesAllocated", "()J", AccessFlags = 257)]
						get{ return GetExternalBytesAllocated(); }
				}

		}

		/// <summary>
		/// <para>Is thrown when the VM determines that a DEX file's cache is out of date, and that there is no way to recreate it.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/StaleDexCacheError
		/// </java-name>
		[Dot42.DexImport("dalvik/system/StaleDexCacheError", AccessFlags = 33)]
		public partial class StaleDexCacheError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new exception instance and initializes it with default values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StaleDexCacheError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new exception instance and initializes it with a given message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StaleDexCacheError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides access to the Dalvik "zygote" feature, which allows a VM instance to be partially initialized and then fork()'d from the partially initialized state.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/Zygote
		/// </java-name>
		[Dot42.DexImport("dalvik/system/Zygote", AccessFlags = 33)]
		public partial class Zygote
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>enable debugging over JDWP </para>        
				/// </summary>
				/// <java-name>
				/// DEBUG_ENABLE_DEBUGGER
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_DEBUGGER", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_DEBUGGER = 1;
				/// <summary>
				/// <para>enable JNI checks </para>        
				/// </summary>
				/// <java-name>
				/// DEBUG_ENABLE_CHECKJNI
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_CHECKJNI", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_CHECKJNI = 2;
				/// <summary>
				/// <para>enable Java programming language "assert" statements </para>        
				/// </summary>
				/// <java-name>
				/// DEBUG_ENABLE_ASSERT
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_ASSERT", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_ASSERT = 4;
				/// <summary>
				/// <para>disable the JIT compiler </para>        
				/// </summary>
				/// <java-name>
				/// DEBUG_ENABLE_SAFEMODE
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_SAFEMODE", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_SAFEMODE = 8;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Zygote() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Forks a new Zygote instance, but does not leave the zygote mode. The current VM must have been started with the -Xzygote flag. The new child is expected to eventually call forkAndSpecialize()</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>0 if this is the child, pid of the child if this is the parent, or -1 on error </para>
				/// </returns>
				/// <java-name>
				/// fork
				/// </java-name>
				[Dot42.DexImport("fork", "()I", AccessFlags = 265)]
				public static int Fork() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// forkAndSpecialize
				/// </java-name>
				[Dot42.DexImport("forkAndSpecialize", "(II[II[[I)I", AccessFlags = 265)]
				public static int ForkAndSpecialize(int int32, int int321, int[] int322, int int323, int[][] int324) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// forkAndSpecialize
				/// </java-name>
				[Dot42.DexImport("forkAndSpecialize", "(II[IZ[[I)I", AccessFlags = 9)]
				public static int ForkAndSpecialize(int int32, int int321, int[] int322, bool boolean, int[][] int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// forkSystemServer
				/// </java-name>
				[Dot42.DexImport("forkSystemServer", "(II[II[[I)I", AccessFlags = 265)]
				public static int ForkSystemServer(int int32, int int321, int[] int322, int int323, int[][] int324) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// forkSystemServer
				/// </java-name>
				[Dot42.DexImport("forkSystemServer", "(II[IZ[[I)I", AccessFlags = 9)]
				public static int ForkSystemServer(int int32, int int321, int[] int322, bool boolean, int[][] int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// dalvik/system/TouchDex
		/// </java-name>
		[Dot42.DexImport("dalvik/system/TouchDex", AccessFlags = 33)]
		public partial class TouchDex
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TouchDex() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int Start(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// main
				/// </java-name>
				[Dot42.DexImport("main", "([Ljava/lang/String;)V", AccessFlags = 9)]
				public static void Main(string[] @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides a limited interface to the Dalvik VM stack. This class is mostly used for implementing security checks.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/VMStack
		/// </java-name>
		[Dot42.DexImport("dalvik/system/VMStack", AccessFlags = 49)]
		public sealed partial class VMStack
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public VMStack() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the defining class loader of the caller's caller.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested class loader, or <c> null </c> if this is the bootstrap class loader. </para>
				/// </returns>
				/// <java-name>
				/// getCallingClassLoader
				/// </java-name>
				[Dot42.DexImport("getCallingClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 265)]
				public static global::Java.Lang.ClassLoader GetCallingClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// getCallingClassLoader2
				/// </java-name>
				[Dot42.DexImport("getCallingClassLoader2", "()Ljava/lang/ClassLoader;", AccessFlags = 265)]
				public static global::Java.Lang.ClassLoader GetCallingClassLoader2() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// getClasses
				/// </java-name>
				[Dot42.DexImport("getClasses", "(IZ)[Ljava/lang/Class;", AccessFlags = 265, Signature = "(IZ)[Ljava/lang/Class<*>;")]
				public static global::System.Type[] GetClasses(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Retrieves the stack trace from the specified thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of stack trace elements, or null if the thread doesn't have a stack trace (e.g. because it exited) </para>
				/// </returns>
				/// <java-name>
				/// getThreadStackTrace
				/// </java-name>
				[Dot42.DexImport("getThreadStackTrace", "(Ljava/lang/Thread;)[Ljava/lang/StackTraceElement;", AccessFlags = 265)]
				public static global::Java.Lang.StackTraceElement[] GetThreadStackTrace(global::System.Threading.Thread t) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StackTraceElement[]);
				}

				/// <summary>
				/// <para>Returns the defining class loader of the caller's caller.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested class loader, or <c> null </c> if this is the bootstrap class loader. </para>
				/// </returns>
				/// <java-name>
				/// getCallingClassLoader
				/// </java-name>
				public static global::Java.Lang.ClassLoader CallingClassLoader
				{
				[Dot42.DexImport("getCallingClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 265)]
						get{ return GetCallingClassLoader(); }
				}

				/// <java-name>
				/// getCallingClassLoader2
				/// </java-name>
				public static global::Java.Lang.ClassLoader CallingClassLoader2
				{
				[Dot42.DexImport("getCallingClassLoader2", "()Ljava/lang/ClassLoader;", AccessFlags = 265)]
						get{ return GetCallingClassLoader2(); }
				}

		}

		/// <summary>
		/// <para>Is thrown when the VM identifies a potential deadlock.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/PotentialDeadlockError
		/// </java-name>
		[Dot42.DexImport("dalvik/system/PotentialDeadlockError", AccessFlags = 33)]
		public partial class PotentialDeadlockError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new exception instance and initializes it with default values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PotentialDeadlockError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new exception instance and initializes it with a given message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PotentialDeadlockError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

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
		/// <para>Is thrown when an allocation limit is exceeded.</para>    
		/// </summary>
		/// <java-name>
		/// dalvik/system/AllocationLimitError
		/// </java-name>
		[Dot42.DexImport("dalvik/system/AllocationLimitError", AccessFlags = 33)]
		public partial class AllocationLimitError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new exception instance and initializes it with default values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AllocationLimitError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new exception instance and initializes it with a given message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AllocationLimitError(string detailMessage) /* MethodBuilder.Create */ 
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


