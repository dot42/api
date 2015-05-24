#pragma warning disable 1717
namespace Dalvik.System
{
		/// <java-name>
		/// dalvik/system/AllocationLimitError
		/// </java-name>
		[Dot42.DexImport("dalvik/system/AllocationLimitError", AccessFlags = 33)]
		public partial class AllocationLimitError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AllocationLimitError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AllocationLimitError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				protected internal DexClassLoader() /* TypeBuilder.AddDefaultConstructor */ 
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
				protected internal DexFile() /* TypeBuilder.AddDefaultConstructor */ 
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
				protected internal PathClassLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// dalvik/system/PotentialDeadlockError
		/// </java-name>
		[Dot42.DexImport("dalvik/system/PotentialDeadlockError", AccessFlags = 33)]
		public partial class PotentialDeadlockError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PotentialDeadlockError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PotentialDeadlockError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// dalvik/system/StaleDexCacheError
		/// </java-name>
		[Dot42.DexImport("dalvik/system/StaleDexCacheError", AccessFlags = 33)]
		public partial class StaleDexCacheError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StaleDexCacheError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StaleDexCacheError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// setUpDirectory
				/// </java-name>
				[Dot42.DexImport("setUpDirectory", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetUpDirectory(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUpDirectory
				/// </java-name>
				[Dot42.DexImport("setUpDirectory", "(Ljava/io/File;)V", AccessFlags = 41)]
				public static void SetUpDirectory(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
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

		/// <java-name>
		/// dalvik/system/VMDebug
		/// </java-name>
		[Dot42.DexImport("dalvik/system/VMDebug", AccessFlags = 49)]
		public sealed partial class VMDebug
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_METHOD_TRACE_FILE_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_METHOD_TRACE_FILE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_METHOD_TRACE_FILE_NAME = "/sdcard/dmtrace.trace";
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

				/// <java-name>
				/// lastDebuggerActivity
				/// </java-name>
				[Dot42.DexImport("lastDebuggerActivity", "()J", AccessFlags = 265)]
				public static long LastDebuggerActivity() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "()V", AccessFlags = 9)]
				public static void StartMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;II)V", AccessFlags = 9)]
				public static void StartMethodTracing(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopMethodTracing
				/// </java-name>
				[Dot42.DexImport("stopMethodTracing", "()V", AccessFlags = 265)]
				public static void StopMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startEmulatorTracing
				/// </java-name>
				[Dot42.DexImport("startEmulatorTracing", "()V", AccessFlags = 265)]
				public static void StartEmulatorTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopEmulatorTracing
				/// </java-name>
				[Dot42.DexImport("stopEmulatorTracing", "()V", AccessFlags = 265)]
				public static void StopEmulatorTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// threadCpuTimeNanos
				/// </java-name>
				[Dot42.DexImport("threadCpuTimeNanos", "()J", AccessFlags = 265)]
				public static long ThreadCpuTimeNanos() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

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
				public static int GetAllocCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// resetAllocCount
				/// </java-name>
				[Dot42.DexImport("resetAllocCount", "(I)V", AccessFlags = 265)]
				public static void ResetAllocCount(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setAllocationLimit", "(I)I", AccessFlags = 265)]
				public static int SetAllocationLimit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setGlobalAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setGlobalAllocationLimit", "(I)I", AccessFlags = 265)]
				public static int SetGlobalAllocationLimit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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
				public static void GetInstructionCount(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetInstructionCount
				/// </java-name>
				[Dot42.DexImport("resetInstructionCount", "()V", AccessFlags = 265)]
				public static void ResetInstructionCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printLoadedClasses
				/// </java-name>
				[Dot42.DexImport("printLoadedClasses", "(I)V", AccessFlags = 265)]
				public static void PrintLoadedClasses(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpHprofData
				/// </java-name>
				[Dot42.DexImport("dumpHprofData", "(Ljava/lang/String;)V", AccessFlags = 265)]
				public static void DumpHprofData(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDebuggingEnabled
				/// </java-name>
				public static bool IsDebuggingEnabled
				{
						[Dot42.DexImport("isDebuggingEnabled", "()Z", AccessFlags = 265)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDebuggerConnected
				/// </java-name>
				public static bool IsDebuggerConnected
				{
						[Dot42.DexImport("isDebuggerConnected", "()Z", AccessFlags = 265)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLoadedClassCount
				/// </java-name>
				public static int LoadedClassCount
				{
						[Dot42.DexImport("getLoadedClassCount", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// dalvik/system/VMRuntime
		/// </java-name>
		[Dot42.DexImport("dalvik/system/VMRuntime", AccessFlags = 49)]
		public sealed partial class VMRuntime
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal VMRuntime() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetHeapUtilization
				/// </java-name>
				[Dot42.DexImport("setTargetHeapUtilization", "(F)F", AccessFlags = 1)]
				public float SetTargetHeapUtilization(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setMinimumHeapSize
				/// </java-name>
				[Dot42.DexImport("setMinimumHeapSize", "(J)J", AccessFlags = 33)]
				public long SetMinimumHeapSize(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// gcSoftReferences
				/// </java-name>
				[Dot42.DexImport("gcSoftReferences", "()V", AccessFlags = 257)]
				public void GcSoftReferences() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFinalizationSync
				/// </java-name>
				[Dot42.DexImport("runFinalizationSync", "()V", AccessFlags = 257)]
				public void RunFinalizationSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRuntime
				/// </java-name>
				public static global::Dalvik.System.VMRuntime Runtime
				{
						[Dot42.DexImport("getRuntime", "()Ldalvik/system/VMRuntime;", AccessFlags = 9)]
						get{ return default(global::Dalvik.System.VMRuntime); }
				}

				/// <java-name>
				/// getTargetHeapUtilization
				/// </java-name>
				public float TargetHeapUtilization
				{
						[Dot42.DexImport("getTargetHeapUtilization", "()F", AccessFlags = 257)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getMinimumHeapSize
				/// </java-name>
				public long MinimumHeapSize
				{
						[Dot42.DexImport("getMinimumHeapSize", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getExternalBytesAllocated
				/// </java-name>
				public long ExternalBytesAllocated
				{
						[Dot42.DexImport("getExternalBytesAllocated", "()J", AccessFlags = 257)]
						get{ return default(long); }
				}

		}

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

				/// <java-name>
				/// getClasses
				/// </java-name>
				[Dot42.DexImport("getClasses", "(IZ)[Ljava/lang/Class;", AccessFlags = 265, Signature = "(IZ)[Ljava/lang/Class<*>;")]
				public static global::System.Type[] GetClasses(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getThreadStackTrace
				/// </java-name>
				[Dot42.DexImport("getThreadStackTrace", "(Ljava/lang/Thread;)[Ljava/lang/StackTraceElement;", AccessFlags = 265)]
				public static global::Java.Lang.StackTraceElement[] GetThreadStackTrace(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StackTraceElement[]);
				}

				/// <java-name>
				/// getCallingClassLoader
				/// </java-name>
				public static global::Java.Lang.ClassLoader CallingClassLoader
				{
						[Dot42.DexImport("getCallingClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 265)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <java-name>
				/// getCallingClassLoader2
				/// </java-name>
				public static global::Java.Lang.ClassLoader CallingClassLoader2
				{
						[Dot42.DexImport("getCallingClassLoader2", "()Ljava/lang/ClassLoader;", AccessFlags = 265)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

		}

		/// <java-name>
		/// dalvik/system/Zygote
		/// </java-name>
		[Dot42.DexImport("dalvik/system/Zygote", AccessFlags = 33)]
		public partial class Zygote
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEBUG_ENABLE_DEBUGGER
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_DEBUGGER", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_DEBUGGER = 1;
				/// <java-name>
				/// DEBUG_ENABLE_CHECKJNI
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_CHECKJNI", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_CHECKJNI = 2;
				/// <java-name>
				/// DEBUG_ENABLE_ASSERT
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_ASSERT", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_ASSERT = 4;
				/// <java-name>
				/// DEBUG_ENABLE_SAFEMODE
				/// </java-name>
				[Dot42.DexImport("DEBUG_ENABLE_SAFEMODE", "I", AccessFlags = 25)]
				public const int DEBUG_ENABLE_SAFEMODE = 8;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Zygote() /* MethodBuilder.Create */ 
				{
				}

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

}

