#pragma warning disable 1717
namespace Android.Content.Pm
{
		/// <java-name>
		/// android/content/pm/ActivityInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ActivityInfo", AccessFlags = 33)]
		public partial class ActivityInfo : global::Android.Content.Pm.ComponentInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// theme
				/// </java-name>
				[Dot42.DexImport("theme", "I", AccessFlags = 1)]
				public int Theme;
				/// <java-name>
				/// LAUNCH_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("LAUNCH_MULTIPLE", "I", AccessFlags = 25)]
				public const int LAUNCH_MULTIPLE = 0;
				/// <java-name>
				/// LAUNCH_SINGLE_TOP
				/// </java-name>
				[Dot42.DexImport("LAUNCH_SINGLE_TOP", "I", AccessFlags = 25)]
				public const int LAUNCH_SINGLE_TOP = 1;
				/// <java-name>
				/// LAUNCH_SINGLE_TASK
				/// </java-name>
				[Dot42.DexImport("LAUNCH_SINGLE_TASK", "I", AccessFlags = 25)]
				public const int LAUNCH_SINGLE_TASK = 2;
				/// <java-name>
				/// LAUNCH_SINGLE_INSTANCE
				/// </java-name>
				[Dot42.DexImport("LAUNCH_SINGLE_INSTANCE", "I", AccessFlags = 25)]
				public const int LAUNCH_SINGLE_INSTANCE = 3;
				/// <java-name>
				/// launchMode
				/// </java-name>
				[Dot42.DexImport("launchMode", "I", AccessFlags = 1)]
				public int LaunchMode;
				/// <java-name>
				/// permission
				/// </java-name>
				[Dot42.DexImport("permission", "Ljava/lang/String;", AccessFlags = 1)]
				public string Permission;
				/// <java-name>
				/// taskAffinity
				/// </java-name>
				[Dot42.DexImport("taskAffinity", "Ljava/lang/String;", AccessFlags = 1)]
				public string TaskAffinity;
				/// <java-name>
				/// targetActivity
				/// </java-name>
				[Dot42.DexImport("targetActivity", "Ljava/lang/String;", AccessFlags = 1)]
				public string TargetActivity;
				/// <java-name>
				/// FLAG_MULTIPROCESS
				/// </java-name>
				[Dot42.DexImport("FLAG_MULTIPROCESS", "I", AccessFlags = 25)]
				public const int FLAG_MULTIPROCESS = 1;
				/// <java-name>
				/// FLAG_FINISH_ON_TASK_LAUNCH
				/// </java-name>
				[Dot42.DexImport("FLAG_FINISH_ON_TASK_LAUNCH", "I", AccessFlags = 25)]
				public const int FLAG_FINISH_ON_TASK_LAUNCH = 2;
				/// <java-name>
				/// FLAG_CLEAR_TASK_ON_LAUNCH
				/// </java-name>
				[Dot42.DexImport("FLAG_CLEAR_TASK_ON_LAUNCH", "I", AccessFlags = 25)]
				public const int FLAG_CLEAR_TASK_ON_LAUNCH = 4;
				/// <java-name>
				/// FLAG_ALWAYS_RETAIN_TASK_STATE
				/// </java-name>
				[Dot42.DexImport("FLAG_ALWAYS_RETAIN_TASK_STATE", "I", AccessFlags = 25)]
				public const int FLAG_ALWAYS_RETAIN_TASK_STATE = 8;
				/// <java-name>
				/// FLAG_STATE_NOT_NEEDED
				/// </java-name>
				[Dot42.DexImport("FLAG_STATE_NOT_NEEDED", "I", AccessFlags = 25)]
				public const int FLAG_STATE_NOT_NEEDED = 16;
				/// <java-name>
				/// FLAG_EXCLUDE_FROM_RECENTS
				/// </java-name>
				[Dot42.DexImport("FLAG_EXCLUDE_FROM_RECENTS", "I", AccessFlags = 25)]
				public const int FLAG_EXCLUDE_FROM_RECENTS = 32;
				/// <java-name>
				/// FLAG_ALLOW_TASK_REPARENTING
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_TASK_REPARENTING", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_TASK_REPARENTING = 64;
				/// <java-name>
				/// FLAG_NO_HISTORY
				/// </java-name>
				[Dot42.DexImport("FLAG_NO_HISTORY", "I", AccessFlags = 25)]
				public const int FLAG_NO_HISTORY = 128;
				/// <java-name>
				/// FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS
				/// </java-name>
				[Dot42.DexImport("FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS", "I", AccessFlags = 25)]
				public const int FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS = 256;
				/// <java-name>
				/// FLAG_HARDWARE_ACCELERATED
				/// </java-name>
				[Dot42.DexImport("FLAG_HARDWARE_ACCELERATED", "I", AccessFlags = 25)]
				public const int FLAG_HARDWARE_ACCELERATED = 512;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// SCREEN_ORIENTATION_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_UNSPECIFIED = -1;
				/// <java-name>
				/// SCREEN_ORIENTATION_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_LANDSCAPE", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_LANDSCAPE = 0;
				/// <java-name>
				/// SCREEN_ORIENTATION_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_PORTRAIT", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_PORTRAIT = 1;
				/// <java-name>
				/// SCREEN_ORIENTATION_USER
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_USER", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_USER = 2;
				/// <java-name>
				/// SCREEN_ORIENTATION_BEHIND
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_BEHIND", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_BEHIND = 3;
				/// <java-name>
				/// SCREEN_ORIENTATION_SENSOR
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_SENSOR", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_SENSOR = 4;
				/// <java-name>
				/// SCREEN_ORIENTATION_NOSENSOR
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_NOSENSOR", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_NOSENSOR = 5;
				/// <java-name>
				/// SCREEN_ORIENTATION_SENSOR_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_SENSOR_LANDSCAPE", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_SENSOR_LANDSCAPE = 6;
				/// <java-name>
				/// SCREEN_ORIENTATION_SENSOR_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_SENSOR_PORTRAIT", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_SENSOR_PORTRAIT = 7;
				/// <java-name>
				/// SCREEN_ORIENTATION_REVERSE_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_REVERSE_LANDSCAPE", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_REVERSE_LANDSCAPE = 8;
				/// <java-name>
				/// SCREEN_ORIENTATION_REVERSE_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_REVERSE_PORTRAIT", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_REVERSE_PORTRAIT = 9;
				/// <java-name>
				/// SCREEN_ORIENTATION_FULL_SENSOR
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_FULL_SENSOR", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_FULL_SENSOR = 10;
				/// <java-name>
				/// screenOrientation
				/// </java-name>
				[Dot42.DexImport("screenOrientation", "I", AccessFlags = 1)]
				public int ScreenOrientation;
				/// <java-name>
				/// CONFIG_MCC
				/// </java-name>
				[Dot42.DexImport("CONFIG_MCC", "I", AccessFlags = 25)]
				public const int CONFIG_MCC = 1;
				/// <java-name>
				/// CONFIG_MNC
				/// </java-name>
				[Dot42.DexImport("CONFIG_MNC", "I", AccessFlags = 25)]
				public const int CONFIG_MNC = 2;
				/// <java-name>
				/// CONFIG_LOCALE
				/// </java-name>
				[Dot42.DexImport("CONFIG_LOCALE", "I", AccessFlags = 25)]
				public const int CONFIG_LOCALE = 4;
				/// <java-name>
				/// CONFIG_TOUCHSCREEN
				/// </java-name>
				[Dot42.DexImport("CONFIG_TOUCHSCREEN", "I", AccessFlags = 25)]
				public const int CONFIG_TOUCHSCREEN = 8;
				/// <java-name>
				/// CONFIG_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("CONFIG_KEYBOARD", "I", AccessFlags = 25)]
				public const int CONFIG_KEYBOARD = 16;
				/// <java-name>
				/// CONFIG_KEYBOARD_HIDDEN
				/// </java-name>
				[Dot42.DexImport("CONFIG_KEYBOARD_HIDDEN", "I", AccessFlags = 25)]
				public const int CONFIG_KEYBOARD_HIDDEN = 32;
				/// <java-name>
				/// CONFIG_NAVIGATION
				/// </java-name>
				[Dot42.DexImport("CONFIG_NAVIGATION", "I", AccessFlags = 25)]
				public const int CONFIG_NAVIGATION = 64;
				/// <java-name>
				/// CONFIG_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("CONFIG_ORIENTATION", "I", AccessFlags = 25)]
				public const int CONFIG_ORIENTATION = 128;
				/// <java-name>
				/// CONFIG_SCREEN_LAYOUT
				/// </java-name>
				[Dot42.DexImport("CONFIG_SCREEN_LAYOUT", "I", AccessFlags = 25)]
				public const int CONFIG_SCREEN_LAYOUT = 256;
				/// <java-name>
				/// CONFIG_UI_MODE
				/// </java-name>
				[Dot42.DexImport("CONFIG_UI_MODE", "I", AccessFlags = 25)]
				public const int CONFIG_UI_MODE = 512;
				/// <java-name>
				/// CONFIG_SCREEN_SIZE
				/// </java-name>
				[Dot42.DexImport("CONFIG_SCREEN_SIZE", "I", AccessFlags = 25)]
				public const int CONFIG_SCREEN_SIZE = 1024;
				/// <java-name>
				/// CONFIG_SMALLEST_SCREEN_SIZE
				/// </java-name>
				[Dot42.DexImport("CONFIG_SMALLEST_SCREEN_SIZE", "I", AccessFlags = 25)]
				public const int CONFIG_SMALLEST_SCREEN_SIZE = 2048;
				/// <java-name>
				/// CONFIG_FONT_SCALE
				/// </java-name>
				[Dot42.DexImport("CONFIG_FONT_SCALE", "I", AccessFlags = 25)]
				public const int CONFIG_FONT_SCALE = 1073741824;
				/// <java-name>
				/// configChanges
				/// </java-name>
				[Dot42.DexImport("configChanges", "I", AccessFlags = 1)]
				public int ConfigChanges;
				/// <java-name>
				/// softInputMode
				/// </java-name>
				[Dot42.DexImport("softInputMode", "I", AccessFlags = 1)]
				public int SoftInputMode;
				/// <java-name>
				/// uiOptions
				/// </java-name>
				[Dot42.DexImport("uiOptions", "I", AccessFlags = 1)]
				public int UiOptions;
				/// <java-name>
				/// UIOPTION_SPLIT_ACTION_BAR_WHEN_NARROW
				/// </java-name>
				[Dot42.DexImport("UIOPTION_SPLIT_ACTION_BAR_WHEN_NARROW", "I", AccessFlags = 25)]
				public const int UIOPTION_SPLIT_ACTION_BAR_WHEN_NARROW = 1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.ActivityInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActivityInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ActivityInfo;)V", AccessFlags = 1)]
				public ActivityInfo(global::Android.Content.Pm.ActivityInfo activityInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getThemeResource
				/// </java-name>
				[Dot42.DexImport("getThemeResource", "()I", AccessFlags = 17)]
				public int GetThemeResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getThemeResource
				/// </java-name>
				public int ThemeResource
				{
				[Dot42.DexImport("getThemeResource", "()I", AccessFlags = 17)]
						get{ return GetThemeResource(); }
				}

		}

		/// <java-name>
		/// android/content/pm/ApplicationInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ApplicationInfo", AccessFlags = 33)]
		public partial class ApplicationInfo : global::Android.Content.Pm.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// taskAffinity
				/// </java-name>
				[Dot42.DexImport("taskAffinity", "Ljava/lang/String;", AccessFlags = 1)]
				public string TaskAffinity;
				/// <java-name>
				/// permission
				/// </java-name>
				[Dot42.DexImport("permission", "Ljava/lang/String;", AccessFlags = 1)]
				public string Permission;
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ProcessName;
				/// <java-name>
				/// className
				/// </java-name>
				[Dot42.DexImport("className", "Ljava/lang/String;", AccessFlags = 1)]
				public string ClassName;
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <java-name>
				/// theme
				/// </java-name>
				[Dot42.DexImport("theme", "I", AccessFlags = 1)]
				public int Theme;
				/// <java-name>
				/// manageSpaceActivityName
				/// </java-name>
				[Dot42.DexImport("manageSpaceActivityName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ManageSpaceActivityName;
				/// <java-name>
				/// backupAgentName
				/// </java-name>
				[Dot42.DexImport("backupAgentName", "Ljava/lang/String;", AccessFlags = 1)]
				public string BackupAgentName;
				/// <java-name>
				/// uiOptions
				/// </java-name>
				[Dot42.DexImport("uiOptions", "I", AccessFlags = 1)]
				public int UiOptions;
				/// <java-name>
				/// FLAG_SYSTEM
				/// </java-name>
				[Dot42.DexImport("FLAG_SYSTEM", "I", AccessFlags = 25)]
				public const int FLAG_SYSTEM = 1;
				/// <java-name>
				/// FLAG_DEBUGGABLE
				/// </java-name>
				[Dot42.DexImport("FLAG_DEBUGGABLE", "I", AccessFlags = 25)]
				public const int FLAG_DEBUGGABLE = 2;
				/// <java-name>
				/// FLAG_HAS_CODE
				/// </java-name>
				[Dot42.DexImport("FLAG_HAS_CODE", "I", AccessFlags = 25)]
				public const int FLAG_HAS_CODE = 4;
				/// <java-name>
				/// FLAG_PERSISTENT
				/// </java-name>
				[Dot42.DexImport("FLAG_PERSISTENT", "I", AccessFlags = 25)]
				public const int FLAG_PERSISTENT = 8;
				/// <java-name>
				/// FLAG_FACTORY_TEST
				/// </java-name>
				[Dot42.DexImport("FLAG_FACTORY_TEST", "I", AccessFlags = 25)]
				public const int FLAG_FACTORY_TEST = 16;
				/// <java-name>
				/// FLAG_ALLOW_TASK_REPARENTING
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_TASK_REPARENTING", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_TASK_REPARENTING = 32;
				/// <java-name>
				/// FLAG_ALLOW_CLEAR_USER_DATA
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_CLEAR_USER_DATA", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_CLEAR_USER_DATA = 64;
				/// <java-name>
				/// FLAG_UPDATED_SYSTEM_APP
				/// </java-name>
				[Dot42.DexImport("FLAG_UPDATED_SYSTEM_APP", "I", AccessFlags = 25)]
				public const int FLAG_UPDATED_SYSTEM_APP = 128;
				/// <java-name>
				/// FLAG_TEST_ONLY
				/// </java-name>
				[Dot42.DexImport("FLAG_TEST_ONLY", "I", AccessFlags = 25)]
				public const int FLAG_TEST_ONLY = 256;
				/// <java-name>
				/// FLAG_SUPPORTS_SMALL_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_SMALL_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_SMALL_SCREENS = 512;
				/// <java-name>
				/// FLAG_SUPPORTS_NORMAL_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_NORMAL_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_NORMAL_SCREENS = 1024;
				/// <java-name>
				/// FLAG_SUPPORTS_LARGE_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_LARGE_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_LARGE_SCREENS = 2048;
				/// <java-name>
				/// FLAG_RESIZEABLE_FOR_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_RESIZEABLE_FOR_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_RESIZEABLE_FOR_SCREENS = 4096;
				/// <java-name>
				/// FLAG_SUPPORTS_SCREEN_DENSITIES
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_SCREEN_DENSITIES", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_SCREEN_DENSITIES = 8192;
				/// <java-name>
				/// FLAG_VM_SAFE_MODE
				/// </java-name>
				[Dot42.DexImport("FLAG_VM_SAFE_MODE", "I", AccessFlags = 25)]
				public const int FLAG_VM_SAFE_MODE = 16384;
				/// <java-name>
				/// FLAG_ALLOW_BACKUP
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_BACKUP", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_BACKUP = 32768;
				/// <java-name>
				/// FLAG_KILL_AFTER_RESTORE
				/// </java-name>
				[Dot42.DexImport("FLAG_KILL_AFTER_RESTORE", "I", AccessFlags = 25)]
				public const int FLAG_KILL_AFTER_RESTORE = 65536;
				/// <java-name>
				/// FLAG_RESTORE_ANY_VERSION
				/// </java-name>
				[Dot42.DexImport("FLAG_RESTORE_ANY_VERSION", "I", AccessFlags = 25)]
				public const int FLAG_RESTORE_ANY_VERSION = 131072;
				/// <java-name>
				/// FLAG_EXTERNAL_STORAGE
				/// </java-name>
				[Dot42.DexImport("FLAG_EXTERNAL_STORAGE", "I", AccessFlags = 25)]
				public const int FLAG_EXTERNAL_STORAGE = 262144;
				/// <java-name>
				/// FLAG_SUPPORTS_XLARGE_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_XLARGE_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_XLARGE_SCREENS = 524288;
				/// <java-name>
				/// FLAG_LARGE_HEAP
				/// </java-name>
				[Dot42.DexImport("FLAG_LARGE_HEAP", "I", AccessFlags = 25)]
				public const int FLAG_LARGE_HEAP = 1048576;
				/// <java-name>
				/// FLAG_STOPPED
				/// </java-name>
				[Dot42.DexImport("FLAG_STOPPED", "I", AccessFlags = 25)]
				public const int FLAG_STOPPED = 2097152;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// requiresSmallestWidthDp
				/// </java-name>
				[Dot42.DexImport("requiresSmallestWidthDp", "I", AccessFlags = 1)]
				public int RequiresSmallestWidthDp;
				/// <java-name>
				/// compatibleWidthLimitDp
				/// </java-name>
				[Dot42.DexImport("compatibleWidthLimitDp", "I", AccessFlags = 1)]
				public int CompatibleWidthLimitDp;
				/// <java-name>
				/// largestWidthLimitDp
				/// </java-name>
				[Dot42.DexImport("largestWidthLimitDp", "I", AccessFlags = 1)]
				public int LargestWidthLimitDp;
				/// <java-name>
				/// sourceDir
				/// </java-name>
				[Dot42.DexImport("sourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string SourceDir;
				/// <java-name>
				/// publicSourceDir
				/// </java-name>
				[Dot42.DexImport("publicSourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string PublicSourceDir;
				/// <java-name>
				/// sharedLibraryFiles
				/// </java-name>
				[Dot42.DexImport("sharedLibraryFiles", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] SharedLibraryFiles;
				/// <java-name>
				/// dataDir
				/// </java-name>
				[Dot42.DexImport("dataDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string DataDir;
				/// <java-name>
				/// nativeLibraryDir
				/// </java-name>
				[Dot42.DexImport("nativeLibraryDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string NativeLibraryDir;
				/// <java-name>
				/// uid
				/// </java-name>
				[Dot42.DexImport("uid", "I", AccessFlags = 1)]
				public int Uid;
				/// <java-name>
				/// targetSdkVersion
				/// </java-name>
				[Dot42.DexImport("targetSdkVersion", "I", AccessFlags = 1)]
				public int TargetSdkVersion;
				/// <java-name>
				/// enabled
				/// </java-name>
				[Dot42.DexImport("enabled", "Z", AccessFlags = 1)]
				public bool Enabled;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.ApplicationInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ApplicationInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ApplicationInfo;)V", AccessFlags = 1)]
				public ApplicationInfo(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// android/content/pm/ApplicationInfo$DisplayNameComparator
				/// </java-name>
				[Dot42.DexImport("android/content/pm/ApplicationInfo$DisplayNameComparator", AccessFlags = 9, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Landroid/content/pm/ApplicationInfo;>;")]
				public partial class DisplayNameComparator : global::Java.Util.IComparator<global::Android.Content.Pm.ApplicationInfo>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageManager;)V", AccessFlags = 1)]
						public DisplayNameComparator(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// compare
						/// </java-name>
						[Dot42.DexImport("compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I", AccessFlags = 17)]
						public int Compare(global::Android.Content.Pm.ApplicationInfo applicationInfo, global::Android.Content.Pm.ApplicationInfo applicationInfo1) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal DisplayNameComparator() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
						public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(bool);
						}

				}

		}

		/// <java-name>
		/// android/content/pm/ComponentInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ComponentInfo", AccessFlags = 33)]
		public partial class ComponentInfo : global::Android.Content.Pm.PackageItemInfo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// applicationInfo
				/// </java-name>
				[Dot42.DexImport("applicationInfo", "Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ApplicationInfo ApplicationInfo;
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ProcessName;
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <java-name>
				/// enabled
				/// </java-name>
				[Dot42.DexImport("enabled", "Z", AccessFlags = 1)]
				public bool Enabled;
				/// <java-name>
				/// exported
				/// </java-name>
				[Dot42.DexImport("exported", "Z", AccessFlags = 1)]
				public bool Exported;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ComponentInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ComponentInfo;)V", AccessFlags = 1)]
				public ComponentInfo(global::Android.Content.Pm.ComponentInfo componentInfo) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 4)]
				protected internal ComponentInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getIconResource
				/// </java-name>
				[Dot42.DexImport("getIconResource", "()I", AccessFlags = 17)]
				public int GetIconResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dumpFront
				/// </java-name>
				[Dot42.DexImport("dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void DumpFront(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpBack
				/// </java-name>
				[Dot42.DexImport("dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void DumpBack(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIconResource
				/// </java-name>
				public int IconResource
				{
				[Dot42.DexImport("getIconResource", "()I", AccessFlags = 17)]
						get{ return GetIconResource(); }
				}

		}

		/// <java-name>
		/// android/content/pm/ConfigurationInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ConfigurationInfo", AccessFlags = 33)]
		public partial class ConfigurationInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// reqTouchScreen
				/// </java-name>
				[Dot42.DexImport("reqTouchScreen", "I", AccessFlags = 1)]
				public int ReqTouchScreen;
				/// <java-name>
				/// reqKeyboardType
				/// </java-name>
				[Dot42.DexImport("reqKeyboardType", "I", AccessFlags = 1)]
				public int ReqKeyboardType;
				/// <java-name>
				/// reqNavigation
				/// </java-name>
				[Dot42.DexImport("reqNavigation", "I", AccessFlags = 1)]
				public int ReqNavigation;
				/// <java-name>
				/// INPUT_FEATURE_HARD_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("INPUT_FEATURE_HARD_KEYBOARD", "I", AccessFlags = 25)]
				public const int INPUT_FEATURE_HARD_KEYBOARD = 1;
				/// <java-name>
				/// INPUT_FEATURE_FIVE_WAY_NAV
				/// </java-name>
				[Dot42.DexImport("INPUT_FEATURE_FIVE_WAY_NAV", "I", AccessFlags = 25)]
				public const int INPUT_FEATURE_FIVE_WAY_NAV = 2;
				/// <java-name>
				/// reqInputFeatures
				/// </java-name>
				[Dot42.DexImport("reqInputFeatures", "I", AccessFlags = 1)]
				public int ReqInputFeatures;
				/// <java-name>
				/// GL_ES_VERSION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("GL_ES_VERSION_UNDEFINED", "I", AccessFlags = 25)]
				public const int GL_ES_VERSION_UNDEFINED = 0;
				/// <java-name>
				/// reqGlEsVersion
				/// </java-name>
				[Dot42.DexImport("reqGlEsVersion", "I", AccessFlags = 1)]
				public int ReqGlEsVersion;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.ConfigurationInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConfigurationInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ConfigurationInfo;)V", AccessFlags = 1)]
				public ConfigurationInfo(global::Android.Content.Pm.ConfigurationInfo configurationInfo) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGlEsVersion
				/// </java-name>
				[Dot42.DexImport("getGlEsVersion", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetGlEsVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getGlEsVersion
				/// </java-name>
				public string GlEsVersion
				{
				[Dot42.DexImport("getGlEsVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetGlEsVersion(); }
				}

		}

		/// <java-name>
		/// android/content/pm/FeatureInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/FeatureInfo", AccessFlags = 33)]
		public partial class FeatureInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
				public string Name;
				/// <java-name>
				/// GL_ES_VERSION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("GL_ES_VERSION_UNDEFINED", "I", AccessFlags = 25)]
				public const int GL_ES_VERSION_UNDEFINED = 0;
				/// <java-name>
				/// reqGlEsVersion
				/// </java-name>
				[Dot42.DexImport("reqGlEsVersion", "I", AccessFlags = 1)]
				public int ReqGlEsVersion;
				/// <java-name>
				/// FLAG_REQUIRED
				/// </java-name>
				[Dot42.DexImport("FLAG_REQUIRED", "I", AccessFlags = 25)]
				public const int FLAG_REQUIRED = 1;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.FeatureInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FeatureInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/FeatureInfo;)V", AccessFlags = 1)]
				public FeatureInfo(global::Android.Content.Pm.FeatureInfo featureInfo) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGlEsVersion
				/// </java-name>
				[Dot42.DexImport("getGlEsVersion", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetGlEsVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getGlEsVersion
				/// </java-name>
				public string GlEsVersion
				{
				[Dot42.DexImport("getGlEsVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetGlEsVersion(); }
				}

		}

		/// <java-name>
		/// android/content/pm/InstrumentationInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/InstrumentationInfo", AccessFlags = 33)]
		public partial class InstrumentationInfo : global::Android.Content.Pm.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// targetPackage
				/// </java-name>
				[Dot42.DexImport("targetPackage", "Ljava/lang/String;", AccessFlags = 1)]
				public string TargetPackage;
				/// <java-name>
				/// sourceDir
				/// </java-name>
				[Dot42.DexImport("sourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string SourceDir;
				/// <java-name>
				/// publicSourceDir
				/// </java-name>
				[Dot42.DexImport("publicSourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string PublicSourceDir;
				/// <java-name>
				/// dataDir
				/// </java-name>
				[Dot42.DexImport("dataDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string DataDir;
				/// <java-name>
				/// handleProfiling
				/// </java-name>
				[Dot42.DexImport("handleProfiling", "Z", AccessFlags = 1)]
				public bool HandleProfiling;
				/// <java-name>
				/// functionalTest
				/// </java-name>
				[Dot42.DexImport("functionalTest", "Z", AccessFlags = 1)]
				public bool FunctionalTest;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.InstrumentationInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstrumentationInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/InstrumentationInfo;)V", AccessFlags = 1)]
				public InstrumentationInfo(global::Android.Content.Pm.InstrumentationInfo instrumentationInfo) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/pm/LabeledIntent
		/// </java-name>
		[Dot42.DexImport("android/content/pm/LabeledIntent", AccessFlags = 33)]
		public partial class LabeledIntent : global::Android.Content.Intent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.LabeledIntent> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V", AccessFlags = 1)]
				public LabeledIntent(global::Android.Content.Intent intent, string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V", AccessFlags = 1)]
				public LabeledIntent(global::Android.Content.Intent intent, string @string, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public LabeledIntent(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V", AccessFlags = 1)]
				public LabeledIntent(string @string, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSourcePackage
				/// </java-name>
				[Dot42.DexImport("getSourcePackage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSourcePackage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLabelResource
				/// </java-name>
				[Dot42.DexImport("getLabelResource", "()I", AccessFlags = 1)]
				public virtual int GetLabelResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNonLocalizedLabel
				/// </java-name>
				[Dot42.DexImport("getNonLocalizedLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetNonLocalizedLabel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getIconResource
				/// </java-name>
				[Dot42.DexImport("getIconResource", "()I", AccessFlags = 1)]
				public virtual int GetIconResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable LoadIcon(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public override void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LabeledIntent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSourcePackage
				/// </java-name>
				public string SourcePackage
				{
				[Dot42.DexImport("getSourcePackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSourcePackage(); }
				}

				/// <java-name>
				/// getLabelResource
				/// </java-name>
				public int LabelResource
				{
				[Dot42.DexImport("getLabelResource", "()I", AccessFlags = 1)]
						get{ return GetLabelResource(); }
				}

				/// <java-name>
				/// getNonLocalizedLabel
				/// </java-name>
				public global::Java.Lang.ICharSequence NonLocalizedLabel
				{
				[Dot42.DexImport("getNonLocalizedLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetNonLocalizedLabel(); }
				}

				/// <java-name>
				/// getIconResource
				/// </java-name>
				public int IconResource
				{
				[Dot42.DexImport("getIconResource", "()I", AccessFlags = 1)]
						get{ return GetIconResource(); }
				}

		}

		/// <java-name>
		/// android/content/pm/PackageInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageInfo", AccessFlags = 33)]
		public partial class PackageInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// versionCode
				/// </java-name>
				[Dot42.DexImport("versionCode", "I", AccessFlags = 1)]
				public int VersionCode;
				/// <java-name>
				/// versionName
				/// </java-name>
				[Dot42.DexImport("versionName", "Ljava/lang/String;", AccessFlags = 1)]
				public string VersionName;
				/// <java-name>
				/// sharedUserId
				/// </java-name>
				[Dot42.DexImport("sharedUserId", "Ljava/lang/String;", AccessFlags = 1)]
				public string SharedUserId;
				/// <java-name>
				/// sharedUserLabel
				/// </java-name>
				[Dot42.DexImport("sharedUserLabel", "I", AccessFlags = 1)]
				public int SharedUserLabel;
				/// <java-name>
				/// applicationInfo
				/// </java-name>
				[Dot42.DexImport("applicationInfo", "Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ApplicationInfo ApplicationInfo;
				/// <java-name>
				/// firstInstallTime
				/// </java-name>
				[Dot42.DexImport("firstInstallTime", "J", AccessFlags = 1)]
				public long FirstInstallTime;
				/// <java-name>
				/// lastUpdateTime
				/// </java-name>
				[Dot42.DexImport("lastUpdateTime", "J", AccessFlags = 1)]
				public long LastUpdateTime;
				/// <java-name>
				/// gids
				/// </java-name>
				[Dot42.DexImport("gids", "[I", AccessFlags = 1)]
				public int[] Gids;
				/// <java-name>
				/// activities
				/// </java-name>
				[Dot42.DexImport("activities", "[Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ActivityInfo[] Activities;
				/// <java-name>
				/// receivers
				/// </java-name>
				[Dot42.DexImport("receivers", "[Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ActivityInfo[] Receivers;
				/// <java-name>
				/// services
				/// </java-name>
				[Dot42.DexImport("services", "[Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ServiceInfo[] Services;
				/// <java-name>
				/// providers
				/// </java-name>
				[Dot42.DexImport("providers", "[Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ProviderInfo[] Providers;
				/// <java-name>
				/// instrumentation
				/// </java-name>
				[Dot42.DexImport("instrumentation", "[Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.InstrumentationInfo[] Instrumentation;
				/// <java-name>
				/// permissions
				/// </java-name>
				[Dot42.DexImport("permissions", "[Landroid/content/pm/PermissionInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.PermissionInfo[] Permissions;
				/// <java-name>
				/// requestedPermissions
				/// </java-name>
				[Dot42.DexImport("requestedPermissions", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] RequestedPermissions;
				/// <java-name>
				/// signatures
				/// </java-name>
				[Dot42.DexImport("signatures", "[Landroid/content/pm/Signature;", AccessFlags = 1)]
				public global::Android.Content.Pm.Signature[] Signatures;
				/// <java-name>
				/// configPreferences
				/// </java-name>
				[Dot42.DexImport("configPreferences", "[Landroid/content/pm/ConfigurationInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ConfigurationInfo[] ConfigPreferences;
				/// <java-name>
				/// reqFeatures
				/// </java-name>
				[Dot42.DexImport("reqFeatures", "[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.FeatureInfo[] ReqFeatures;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.PackageInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PackageInfo() /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/pm/PackageItemInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageItemInfo", AccessFlags = 33)]
		public partial class PackageItemInfo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
				public string Name;
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// labelRes
				/// </java-name>
				[Dot42.DexImport("labelRes", "I", AccessFlags = 1)]
				public int LabelRes;
				/// <java-name>
				/// nonLocalizedLabel
				/// </java-name>
				[Dot42.DexImport("nonLocalizedLabel", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedLabel;
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <java-name>
				/// logo
				/// </java-name>
				[Dot42.DexImport("logo", "I", AccessFlags = 1)]
				public int Logo;
				/// <java-name>
				/// metaData
				/// </java-name>
				[Dot42.DexImport("metaData", "Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.OS.Bundle MetaData;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PackageItemInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageItemInfo;)V", AccessFlags = 1)]
				public PackageItemInfo(global::Android.Content.Pm.PackageItemInfo packageItemInfo) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 4)]
				protected internal PackageItemInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable LoadIcon(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// loadLogo
				/// </java-name>
				[Dot42.DexImport("loadLogo", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable LoadLogo(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// loadXmlMetaData
				/// </java-name>
				[Dot42.DexImport("loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlRe" +
    "sourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser LoadXmlMetaData(global::Android.Content.Pm.PackageManager packageManager, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// dumpFront
				/// </java-name>
				[Dot42.DexImport("dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void DumpFront(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpBack
				/// </java-name>
				[Dot42.DexImport("dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void DumpBack(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/content/pm/PackageItemInfo$DisplayNameComparator
				/// </java-name>
				[Dot42.DexImport("android/content/pm/PackageItemInfo$DisplayNameComparator", AccessFlags = 9, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Landroid/content/pm/PackageItemInfo;>;")]
				public partial class DisplayNameComparator : global::Java.Util.IComparator<global::Android.Content.Pm.PackageItemInfo>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageManager;)V", AccessFlags = 1)]
						public DisplayNameComparator(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// compare
						/// </java-name>
						[Dot42.DexImport("compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I", AccessFlags = 17)]
						public int Compare(global::Android.Content.Pm.PackageItemInfo packageItemInfo, global::Android.Content.Pm.PackageItemInfo packageItemInfo1) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal DisplayNameComparator() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
						public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(bool);
						}

				}

		}

		/// <java-name>
		/// android/content/pm/PackageManager
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageManager", AccessFlags = 1057)]
		public abstract partial class PackageManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GET_ACTIVITIES
				/// </java-name>
				[Dot42.DexImport("GET_ACTIVITIES", "I", AccessFlags = 25)]
				public const int GET_ACTIVITIES = 1;
				/// <java-name>
				/// GET_RECEIVERS
				/// </java-name>
				[Dot42.DexImport("GET_RECEIVERS", "I", AccessFlags = 25)]
				public const int GET_RECEIVERS = 2;
				/// <java-name>
				/// GET_SERVICES
				/// </java-name>
				[Dot42.DexImport("GET_SERVICES", "I", AccessFlags = 25)]
				public const int GET_SERVICES = 4;
				/// <java-name>
				/// GET_PROVIDERS
				/// </java-name>
				[Dot42.DexImport("GET_PROVIDERS", "I", AccessFlags = 25)]
				public const int GET_PROVIDERS = 8;
				/// <java-name>
				/// GET_INSTRUMENTATION
				/// </java-name>
				[Dot42.DexImport("GET_INSTRUMENTATION", "I", AccessFlags = 25)]
				public const int GET_INSTRUMENTATION = 16;
				/// <java-name>
				/// GET_INTENT_FILTERS
				/// </java-name>
				[Dot42.DexImport("GET_INTENT_FILTERS", "I", AccessFlags = 25)]
				public const int GET_INTENT_FILTERS = 32;
				/// <java-name>
				/// GET_SIGNATURES
				/// </java-name>
				[Dot42.DexImport("GET_SIGNATURES", "I", AccessFlags = 25)]
				public const int GET_SIGNATURES = 64;
				/// <java-name>
				/// GET_RESOLVED_FILTER
				/// </java-name>
				[Dot42.DexImport("GET_RESOLVED_FILTER", "I", AccessFlags = 25)]
				public const int GET_RESOLVED_FILTER = 64;
				/// <java-name>
				/// GET_META_DATA
				/// </java-name>
				[Dot42.DexImport("GET_META_DATA", "I", AccessFlags = 25)]
				public const int GET_META_DATA = 128;
				/// <java-name>
				/// GET_GIDS
				/// </java-name>
				[Dot42.DexImport("GET_GIDS", "I", AccessFlags = 25)]
				public const int GET_GIDS = 256;
				/// <java-name>
				/// GET_DISABLED_COMPONENTS
				/// </java-name>
				[Dot42.DexImport("GET_DISABLED_COMPONENTS", "I", AccessFlags = 25)]
				public const int GET_DISABLED_COMPONENTS = 512;
				/// <java-name>
				/// GET_SHARED_LIBRARY_FILES
				/// </java-name>
				[Dot42.DexImport("GET_SHARED_LIBRARY_FILES", "I", AccessFlags = 25)]
				public const int GET_SHARED_LIBRARY_FILES = 1024;
				/// <java-name>
				/// GET_URI_PERMISSION_PATTERNS
				/// </java-name>
				[Dot42.DexImport("GET_URI_PERMISSION_PATTERNS", "I", AccessFlags = 25)]
				public const int GET_URI_PERMISSION_PATTERNS = 2048;
				/// <java-name>
				/// GET_PERMISSIONS
				/// </java-name>
				[Dot42.DexImport("GET_PERMISSIONS", "I", AccessFlags = 25)]
				public const int GET_PERMISSIONS = 4096;
				/// <java-name>
				/// GET_UNINSTALLED_PACKAGES
				/// </java-name>
				[Dot42.DexImport("GET_UNINSTALLED_PACKAGES", "I", AccessFlags = 25)]
				public const int GET_UNINSTALLED_PACKAGES = 8192;
				/// <java-name>
				/// GET_CONFIGURATIONS
				/// </java-name>
				[Dot42.DexImport("GET_CONFIGURATIONS", "I", AccessFlags = 25)]
				public const int GET_CONFIGURATIONS = 16384;
				/// <java-name>
				/// MATCH_DEFAULT_ONLY
				/// </java-name>
				[Dot42.DexImport("MATCH_DEFAULT_ONLY", "I", AccessFlags = 25)]
				public const int MATCH_DEFAULT_ONLY = 65536;
				/// <java-name>
				/// PERMISSION_GRANTED
				/// </java-name>
				[Dot42.DexImport("PERMISSION_GRANTED", "I", AccessFlags = 25)]
				public const int PERMISSION_GRANTED = 0;
				/// <java-name>
				/// PERMISSION_DENIED
				/// </java-name>
				[Dot42.DexImport("PERMISSION_DENIED", "I", AccessFlags = 25)]
				public const int PERMISSION_DENIED = -1;
				/// <java-name>
				/// SIGNATURE_MATCH
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_MATCH", "I", AccessFlags = 25)]
				public const int SIGNATURE_MATCH = 0;
				/// <java-name>
				/// SIGNATURE_NEITHER_SIGNED
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_NEITHER_SIGNED", "I", AccessFlags = 25)]
				public const int SIGNATURE_NEITHER_SIGNED = 1;
				/// <java-name>
				/// SIGNATURE_FIRST_NOT_SIGNED
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_FIRST_NOT_SIGNED", "I", AccessFlags = 25)]
				public const int SIGNATURE_FIRST_NOT_SIGNED = -1;
				/// <java-name>
				/// SIGNATURE_SECOND_NOT_SIGNED
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_SECOND_NOT_SIGNED", "I", AccessFlags = 25)]
				public const int SIGNATURE_SECOND_NOT_SIGNED = -2;
				/// <java-name>
				/// SIGNATURE_NO_MATCH
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_NO_MATCH", "I", AccessFlags = 25)]
				public const int SIGNATURE_NO_MATCH = -3;
				/// <java-name>
				/// SIGNATURE_UNKNOWN_PACKAGE
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_UNKNOWN_PACKAGE", "I", AccessFlags = 25)]
				public const int SIGNATURE_UNKNOWN_PACKAGE = -4;
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_DEFAULT
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_DEFAULT", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_DEFAULT = 0;
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_ENABLED = 1;
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_DISABLED = 2;
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_DISABLED_USER
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_DISABLED_USER", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_DISABLED_USER = 3;
				/// <java-name>
				/// DONT_KILL_APP
				/// </java-name>
				[Dot42.DexImport("DONT_KILL_APP", "I", AccessFlags = 25)]
				public const int DONT_KILL_APP = 1;
				/// <java-name>
				/// VERIFICATION_ALLOW
				/// </java-name>
				[Dot42.DexImport("VERIFICATION_ALLOW", "I", AccessFlags = 25)]
				public const int VERIFICATION_ALLOW = 1;
				/// <java-name>
				/// VERIFICATION_REJECT
				/// </java-name>
				[Dot42.DexImport("VERIFICATION_REJECT", "I", AccessFlags = 25)]
				public const int VERIFICATION_REJECT = -1;
				/// <java-name>
				/// FEATURE_AUDIO_LOW_LATENCY
				/// </java-name>
				[Dot42.DexImport("FEATURE_AUDIO_LOW_LATENCY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_AUDIO_LOW_LATENCY = "android.hardware.audio.low_latency";
				/// <java-name>
				/// FEATURE_BLUETOOTH
				/// </java-name>
				[Dot42.DexImport("FEATURE_BLUETOOTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_BLUETOOTH = "android.hardware.bluetooth";
				/// <java-name>
				/// FEATURE_CAMERA
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA = "android.hardware.camera";
				/// <java-name>
				/// FEATURE_CAMERA_AUTOFOCUS
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA_AUTOFOCUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA_AUTOFOCUS = "android.hardware.camera.autofocus";
				/// <java-name>
				/// FEATURE_CAMERA_FLASH
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA_FLASH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA_FLASH = "android.hardware.camera.flash";
				/// <java-name>
				/// FEATURE_CAMERA_FRONT
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA_FRONT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA_FRONT = "android.hardware.camera.front";
				/// <java-name>
				/// FEATURE_LOCATION
				/// </java-name>
				[Dot42.DexImport("FEATURE_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LOCATION = "android.hardware.location";
				/// <java-name>
				/// FEATURE_LOCATION_GPS
				/// </java-name>
				[Dot42.DexImport("FEATURE_LOCATION_GPS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LOCATION_GPS = "android.hardware.location.gps";
				/// <java-name>
				/// FEATURE_LOCATION_NETWORK
				/// </java-name>
				[Dot42.DexImport("FEATURE_LOCATION_NETWORK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LOCATION_NETWORK = "android.hardware.location.network";
				/// <java-name>
				/// FEATURE_MICROPHONE
				/// </java-name>
				[Dot42.DexImport("FEATURE_MICROPHONE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_MICROPHONE = "android.hardware.microphone";
				/// <java-name>
				/// FEATURE_NFC
				/// </java-name>
				[Dot42.DexImport("FEATURE_NFC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_NFC = "android.hardware.nfc";
				/// <java-name>
				/// FEATURE_SENSOR_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_ACCELEROMETER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_ACCELEROMETER = "android.hardware.sensor.accelerometer";
				/// <java-name>
				/// FEATURE_SENSOR_BAROMETER
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_BAROMETER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_BAROMETER = "android.hardware.sensor.barometer";
				/// <java-name>
				/// FEATURE_SENSOR_COMPASS
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_COMPASS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_COMPASS = "android.hardware.sensor.compass";
				/// <java-name>
				/// FEATURE_SENSOR_GYROSCOPE
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_GYROSCOPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_GYROSCOPE = "android.hardware.sensor.gyroscope";
				/// <java-name>
				/// FEATURE_SENSOR_LIGHT
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_LIGHT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_LIGHT = "android.hardware.sensor.light";
				/// <java-name>
				/// FEATURE_SENSOR_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_PROXIMITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_PROXIMITY = "android.hardware.sensor.proximity";
				/// <java-name>
				/// FEATURE_TELEPHONY
				/// </java-name>
				[Dot42.DexImport("FEATURE_TELEPHONY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TELEPHONY = "android.hardware.telephony";
				/// <java-name>
				/// FEATURE_TELEPHONY_CDMA
				/// </java-name>
				[Dot42.DexImport("FEATURE_TELEPHONY_CDMA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TELEPHONY_CDMA = "android.hardware.telephony.cdma";
				/// <java-name>
				/// FEATURE_TELEPHONY_GSM
				/// </java-name>
				[Dot42.DexImport("FEATURE_TELEPHONY_GSM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TELEPHONY_GSM = "android.hardware.telephony.gsm";
				/// <java-name>
				/// FEATURE_USB_HOST
				/// </java-name>
				[Dot42.DexImport("FEATURE_USB_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_USB_HOST = "android.hardware.usb.host";
				/// <java-name>
				/// FEATURE_USB_ACCESSORY
				/// </java-name>
				[Dot42.DexImport("FEATURE_USB_ACCESSORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_USB_ACCESSORY = "android.hardware.usb.accessory";
				/// <java-name>
				/// FEATURE_SIP
				/// </java-name>
				[Dot42.DexImport("FEATURE_SIP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SIP = "android.software.sip";
				/// <java-name>
				/// FEATURE_SIP_VOIP
				/// </java-name>
				[Dot42.DexImport("FEATURE_SIP_VOIP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SIP_VOIP = "android.software.sip.voip";
				/// <java-name>
				/// FEATURE_TOUCHSCREEN
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN = "android.hardware.touchscreen";
				/// <java-name>
				/// FEATURE_TOUCHSCREEN_MULTITOUCH
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN_MULTITOUCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN_MULTITOUCH = "android.hardware.touchscreen.multitouch";
				/// <java-name>
				/// FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT = "android.hardware.touchscreen.multitouch.distinct";
				/// <java-name>
				/// FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND = "android.hardware.touchscreen.multitouch.jazzhand";
				/// <java-name>
				/// FEATURE_FAKETOUCH
				/// </java-name>
				[Dot42.DexImport("FEATURE_FAKETOUCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_FAKETOUCH = "android.hardware.faketouch";
				/// <java-name>
				/// FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT
				/// </java-name>
				[Dot42.DexImport("FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT = "android.hardware.faketouch.multitouch.distinct";
				/// <java-name>
				/// FEATURE_FAKETOUCH_MULTITOUCH_JAZZHAND
				/// </java-name>
				[Dot42.DexImport("FEATURE_FAKETOUCH_MULTITOUCH_JAZZHAND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_FAKETOUCH_MULTITOUCH_JAZZHAND = "android.hardware.faketouch.multitouch.jazzhand";
				/// <java-name>
				/// FEATURE_SCREEN_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("FEATURE_SCREEN_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SCREEN_PORTRAIT = "android.hardware.screen.portrait";
				/// <java-name>
				/// FEATURE_SCREEN_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("FEATURE_SCREEN_LANDSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SCREEN_LANDSCAPE = "android.hardware.screen.landscape";
				/// <java-name>
				/// FEATURE_LIVE_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("FEATURE_LIVE_WALLPAPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LIVE_WALLPAPER = "android.software.live_wallpaper";
				/// <java-name>
				/// FEATURE_WIFI
				/// </java-name>
				[Dot42.DexImport("FEATURE_WIFI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_WIFI = "android.hardware.wifi";
				/// <java-name>
				/// FEATURE_WIFI_DIRECT
				/// </java-name>
				[Dot42.DexImport("FEATURE_WIFI_DIRECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_WIFI_DIRECT = "android.hardware.wifi.direct";
				/// <java-name>
				/// EXTRA_VERIFICATION_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_VERIFICATION_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VERIFICATION_ID = "android.content.pm.extra.VERIFICATION_ID";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PackageManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPackageInfo
				/// </java-name>
				[Dot42.DexImport("getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.PackageInfo GetPackageInfo(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// currentToCanonicalPackageNames
				/// </java-name>
				[Dot42.DexImport("currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] CurrentToCanonicalPackageNames(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// canonicalToCurrentPackageNames
				/// </java-name>
				[Dot42.DexImport("canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] CanonicalToCurrentPackageNames(string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLaunchIntentForPackage
				/// </java-name>
				[Dot42.DexImport("getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1025)]
				public abstract global::Android.Content.Intent GetLaunchIntentForPackage(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackageGids
				/// </java-name>
				[Dot42.DexImport("getPackageGids", "(Ljava/lang/String;)[I", AccessFlags = 1025)]
				public abstract int[] GetPackageGids(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPermissionInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.PermissionInfo GetPermissionInfo(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryPermissionsByGroup
				/// </java-name>
				[Dot42.DexImport("queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/PermissionInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.PermissionInfo> QueryPermissionsByGroup(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPermissionGroupInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.PermissionGroupInfo GetPermissionGroupInfo(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAllPermissionGroups
				/// </java-name>
				[Dot42.DexImport("getAllPermissionGroups", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/PermissionGroupInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.PermissionGroupInfo> GetAllPermissionGroups(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ApplicationInfo GetApplicationInfo(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				[Dot42.DexImport("getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ActivityInfo GetActivityInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getReceiverInfo
				/// </java-name>
				[Dot42.DexImport("getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ActivityInfo GetReceiverInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ServiceInfo GetServiceInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProviderInfo
				/// </java-name>
				[Dot42.DexImport("getProviderInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ProviderInfo GetProviderInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInstalledPackages
				/// </java-name>
				[Dot42.DexImport("getInstalledPackages", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.PackageInfo> GetInstalledPackages(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckPermission(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1025)]
				public abstract bool AddPermission(global::Android.Content.Pm.PermissionInfo permissionInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addPermissionAsync
				/// </java-name>
				[Dot42.DexImport("addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1025)]
				public abstract bool AddPermissionAsync(global::Android.Content.Pm.PermissionInfo permissionInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void RemovePermission(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckSignatures(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(II)I", AccessFlags = 1025)]
				public abstract int CheckSignatures(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackagesForUid
				/// </java-name>
				[Dot42.DexImport("getPackagesForUid", "(I)[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetPackagesForUid(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNameForUid
				/// </java-name>
				[Dot42.DexImport("getNameForUid", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetNameForUid(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInstalledApplications
				/// </java-name>
				[Dot42.DexImport("getInstalledApplications", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/ApplicationInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.ApplicationInfo> GetInstalledApplications(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetSystemSharedLibraryNames() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.FeatureInfo[] GetSystemAvailableFeatures() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasSystemFeature
				/// </java-name>
				[Dot42.DexImport("hasSystemFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool HasSystemFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ResolveInfo ResolveActivity(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryIntentActivities
				/// </java-name>
				[Dot42.DexImport("queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentActivities(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryIntentActivityOptions
				/// </java-name>
				[Dot42.DexImport("queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentActivityOptions(global::Android.Content.ComponentName componentName, global::Android.Content.Intent[] intent, global::Android.Content.Intent intent1, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryBroadcastReceivers
				/// </java-name>
				[Dot42.DexImport("queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryBroadcastReceivers(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// resolveService
				/// </java-name>
				[Dot42.DexImport("resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ResolveInfo ResolveService(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryIntentServices
				/// </java-name>
				[Dot42.DexImport("queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentServices(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// resolveContentProvider
				/// </java-name>
				[Dot42.DexImport("resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ProviderInfo ResolveContentProvider(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryContentProviders
				/// </java-name>
				[Dot42.DexImport("queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/lang/String;II)Ljava/util/List<Landroid/content/pm/ProviderInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.ProviderInfo> QueryContentProviders(string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInstrumentationInfo
				/// </java-name>
				[Dot42.DexImport("getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.InstrumentationInfo GetInstrumentationInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryInstrumentation
				/// </java-name>
				[Dot42.DexImport("queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/InstrumentationInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.InstrumentationInfo> QueryInstrumentation(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetDrawable(string @string, int int32, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetActivityIcon(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetActivityIcon(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetDefaultActivityIcon() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetApplicationIcon(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetApplicationIcon(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetActivityLogo(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetActivityLogo(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetApplicationLogo(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetApplicationLogo(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;" +
    "", AccessFlags = 1025)]
				public abstract global::Java.Lang.ICharSequence GetText(string @string, int int32, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/Xml" +
    "ResourceParser;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.IXmlResourceParser GetXml(string @string, int int32, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationLabel
				/// </java-name>
				[Dot42.DexImport("getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				public abstract global::Java.Lang.ICharSequence GetApplicationLabel(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResourcesForActivity
				/// </java-name>
				[Dot42.DexImport("getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResourcesForActivity(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResourcesForApplication(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResourcesForApplication(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackageArchiveInfo
				/// </java-name>
				[Dot42.DexImport("getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public virtual global::Android.Content.Pm.PackageInfo GetPackageArchiveInfo(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageInfo);
				}

				/// <java-name>
				/// verifyPendingInstall
				/// </java-name>
				[Dot42.DexImport("verifyPendingInstall", "(II)V", AccessFlags = 1025)]
				public abstract void VerifyPendingInstall(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("setInstallerPackageName", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetInstallerPackageName(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetInstallerPackageName(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addPackageToPreferred
				/// </java-name>
				[Dot42.DexImport("addPackageToPreferred", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void AddPackageToPreferred(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removePackageFromPreferred
				/// </java-name>
				[Dot42.DexImport("removePackageFromPreferred", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void RemovePackageFromPreferred(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPreferredPackages
				/// </java-name>
				[Dot42.DexImport("getPreferredPackages", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.Pm.PackageInfo> GetPreferredPackages(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addPreferredActivity
				/// </java-name>
				[Dot42.DexImport("addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/" +
    "ComponentName;)V", AccessFlags = 1025)]
				public abstract void AddPreferredActivity(global::Android.Content.IntentFilter intentFilter, int int32, global::Android.Content.ComponentName[] componentName, global::Android.Content.ComponentName componentName1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearPackagePreferredActivities
				/// </java-name>
				[Dot42.DexImport("clearPackagePreferredActivities", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void ClearPackagePreferredActivities(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPreferredActivities
				/// </java-name>
				[Dot42.DexImport("getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I", AccessFlags = 1025, Signature = "(Ljava/util/List<Landroid/content/IntentFilter;>;Ljava/util/List<Landroid/content" +
    "/ComponentName;>;Ljava/lang/String;)I")]
				public abstract int GetPreferredActivities(global::Java.Util.IList<global::Android.Content.IntentFilter> list, global::Java.Util.IList<global::Android.Content.ComponentName> list1, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V", AccessFlags = 1025)]
				public abstract void SetComponentEnabledSetting(global::Android.Content.ComponentName componentName, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getComponentEnabledSetting", "(Landroid/content/ComponentName;)I", AccessFlags = 1025)]
				public abstract int GetComponentEnabledSetting(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setApplicationEnabledSetting", "(Ljava/lang/String;II)V", AccessFlags = 1025)]
				public abstract void SetApplicationEnabledSetting(string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getApplicationEnabledSetting", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int GetApplicationEnabledSetting(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSafeMode
				/// </java-name>
				[Dot42.DexImport("isSafeMode", "()Z", AccessFlags = 1025)]
				public abstract bool IsSafeMode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				public string[] SystemSharedLibraryNames
				{
				[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSystemSharedLibraryNames(); }
				}

				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				public global::Android.Content.Pm.FeatureInfo[] SystemAvailableFeatures
				{
				[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1025)]
						get{ return GetSystemAvailableFeatures(); }
				}

				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable DefaultActivityIcon
				{
				[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get{ return GetDefaultActivityIcon(); }
				}

				/// <java-name>
				/// android/content/pm/PackageManager$NameNotFoundException
				/// </java-name>
				[Dot42.DexImport("android/content/pm/PackageManager$NameNotFoundException", AccessFlags = 9)]
				public partial class NameNotFoundException : global::Android.Util.AndroidException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public NameNotFoundException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public NameNotFoundException(string @string) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/content/pm/PackageStats
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageStats", AccessFlags = 33)]
		public partial class PackageStats : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// codeSize
				/// </java-name>
				[Dot42.DexImport("codeSize", "J", AccessFlags = 1)]
				public long CodeSize;
				/// <java-name>
				/// dataSize
				/// </java-name>
				[Dot42.DexImport("dataSize", "J", AccessFlags = 1)]
				public long DataSize;
				/// <java-name>
				/// cacheSize
				/// </java-name>
				[Dot42.DexImport("cacheSize", "J", AccessFlags = 1)]
				public long CacheSize;
				/// <java-name>
				/// externalCodeSize
				/// </java-name>
				[Dot42.DexImport("externalCodeSize", "J", AccessFlags = 1)]
				public long ExternalCodeSize;
				/// <java-name>
				/// externalDataSize
				/// </java-name>
				[Dot42.DexImport("externalDataSize", "J", AccessFlags = 1)]
				public long ExternalDataSize;
				/// <java-name>
				/// externalCacheSize
				/// </java-name>
				[Dot42.DexImport("externalCacheSize", "J", AccessFlags = 1)]
				public long ExternalCacheSize;
				/// <java-name>
				/// externalMediaSize
				/// </java-name>
				[Dot42.DexImport("externalMediaSize", "J", AccessFlags = 1)]
				public long ExternalMediaSize;
				/// <java-name>
				/// externalObbSize
				/// </java-name>
				[Dot42.DexImport("externalObbSize", "J", AccessFlags = 1)]
				public long ExternalObbSize;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.PackageStats> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PackageStats(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public PackageStats(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageStats;)V", AccessFlags = 1)]
				public PackageStats(global::Android.Content.Pm.PackageStats packageStats) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PackageStats() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/content/pm/PathPermission
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PathPermission", AccessFlags = 33)]
		public partial class PathPermission : global::Android.OS.PatternMatcher
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.PathPermission> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PathPermission(string @string, int int32, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public PathPermission(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReadPermission
				/// </java-name>
				[Dot42.DexImport("getReadPermission", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReadPermission() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getWritePermission
				/// </java-name>
				[Dot42.DexImport("getWritePermission", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetWritePermission() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PathPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getReadPermission
				/// </java-name>
				public string ReadPermission
				{
				[Dot42.DexImport("getReadPermission", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReadPermission(); }
				}

				/// <java-name>
				/// getWritePermission
				/// </java-name>
				public string WritePermission
				{
				[Dot42.DexImport("getWritePermission", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetWritePermission(); }
				}

		}

		/// <java-name>
		/// android/content/pm/PermissionGroupInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PermissionGroupInfo", AccessFlags = 33)]
		public partial class PermissionGroupInfo : global::Android.Content.Pm.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <java-name>
				/// nonLocalizedDescription
				/// </java-name>
				[Dot42.DexImport("nonLocalizedDescription", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedDescription;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.PermissionGroupInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PermissionGroupInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PermissionGroupInfo;)V", AccessFlags = 1)]
				public PermissionGroupInfo(global::Android.Content.Pm.PermissionGroupInfo permissionGroupInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/pm/PermissionInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PermissionInfo", AccessFlags = 33)]
		public partial class PermissionInfo : global::Android.Content.Pm.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PROTECTION_NORMAL
				/// </java-name>
				[Dot42.DexImport("PROTECTION_NORMAL", "I", AccessFlags = 25)]
				public const int PROTECTION_NORMAL = 0;
				/// <java-name>
				/// PROTECTION_DANGEROUS
				/// </java-name>
				[Dot42.DexImport("PROTECTION_DANGEROUS", "I", AccessFlags = 25)]
				public const int PROTECTION_DANGEROUS = 1;
				/// <java-name>
				/// PROTECTION_SIGNATURE
				/// </java-name>
				[Dot42.DexImport("PROTECTION_SIGNATURE", "I", AccessFlags = 25)]
				public const int PROTECTION_SIGNATURE = 2;
				/// <java-name>
				/// PROTECTION_SIGNATURE_OR_SYSTEM
				/// </java-name>
				[Dot42.DexImport("PROTECTION_SIGNATURE_OR_SYSTEM", "I", AccessFlags = 25)]
				public const int PROTECTION_SIGNATURE_OR_SYSTEM = 3;
				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "Ljava/lang/String;", AccessFlags = 1)]
				public string Group;
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <java-name>
				/// nonLocalizedDescription
				/// </java-name>
				[Dot42.DexImport("nonLocalizedDescription", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedDescription;
				/// <java-name>
				/// protectionLevel
				/// </java-name>
				[Dot42.DexImport("protectionLevel", "I", AccessFlags = 1)]
				public int ProtectionLevel;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.PermissionInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PermissionInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PermissionInfo;)V", AccessFlags = 1)]
				public PermissionInfo(global::Android.Content.Pm.PermissionInfo permissionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/pm/ProviderInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ProviderInfo", AccessFlags = 49)]
		public sealed partial class ProviderInfo : global::Android.Content.Pm.ComponentInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 1)]
				public string Authority;
				/// <java-name>
				/// readPermission
				/// </java-name>
				[Dot42.DexImport("readPermission", "Ljava/lang/String;", AccessFlags = 1)]
				public string ReadPermission;
				/// <java-name>
				/// writePermission
				/// </java-name>
				[Dot42.DexImport("writePermission", "Ljava/lang/String;", AccessFlags = 1)]
				public string WritePermission;
				/// <java-name>
				/// grantUriPermissions
				/// </java-name>
				[Dot42.DexImport("grantUriPermissions", "Z", AccessFlags = 1)]
				public bool GrantUriPermissions;
				/// <java-name>
				/// uriPermissionPatterns
				/// </java-name>
				[Dot42.DexImport("uriPermissionPatterns", "[Landroid/os/PatternMatcher;", AccessFlags = 1)]
				public global::Android.OS.PatternMatcher[] UriPermissionPatterns;
				/// <java-name>
				/// pathPermissions
				/// </java-name>
				[Dot42.DexImport("pathPermissions", "[Landroid/content/pm/PathPermission;", AccessFlags = 1)]
				public global::Android.Content.Pm.PathPermission[] PathPermissions;
				/// <java-name>
				/// multiprocess
				/// </java-name>
				[Dot42.DexImport("multiprocess", "Z", AccessFlags = 1)]
				public bool Multiprocess;
				/// <java-name>
				/// initOrder
				/// </java-name>
				[Dot42.DexImport("initOrder", "I", AccessFlags = 1)]
				public int InitOrder;
				/// <java-name>
				/// isSyncable
				/// </java-name>
				[Dot42.DexImport("isSyncable", "Z", AccessFlags = 1)]
				public bool IsSyncable;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.ProviderInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProviderInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public ProviderInfo(global::Android.Content.Pm.ProviderInfo providerInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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

		}

		/// <java-name>
		/// android/content/pm/ResolveInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ResolveInfo", AccessFlags = 33)]
		public partial class ResolveInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// activityInfo
				/// </java-name>
				[Dot42.DexImport("activityInfo", "Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ActivityInfo ActivityInfo;
				/// <java-name>
				/// serviceInfo
				/// </java-name>
				[Dot42.DexImport("serviceInfo", "Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ServiceInfo ServiceInfo;
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "Landroid/content/IntentFilter;", AccessFlags = 1)]
				public global::Android.Content.IntentFilter Filter;
				/// <java-name>
				/// priority
				/// </java-name>
				[Dot42.DexImport("priority", "I", AccessFlags = 1)]
				public int Priority;
				/// <java-name>
				/// preferredOrder
				/// </java-name>
				[Dot42.DexImport("preferredOrder", "I", AccessFlags = 1)]
				public int PreferredOrder;
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "I", AccessFlags = 1)]
				public int Match;
				/// <java-name>
				/// specificIndex
				/// </java-name>
				[Dot42.DexImport("specificIndex", "I", AccessFlags = 1)]
				public int SpecificIndex;
				/// <java-name>
				/// isDefault
				/// </java-name>
				[Dot42.DexImport("isDefault", "Z", AccessFlags = 1)]
				public bool IsDefault;
				/// <java-name>
				/// labelRes
				/// </java-name>
				[Dot42.DexImport("labelRes", "I", AccessFlags = 1)]
				public int LabelRes;
				/// <java-name>
				/// nonLocalizedLabel
				/// </java-name>
				[Dot42.DexImport("nonLocalizedLabel", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedLabel;
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <java-name>
				/// resolvePackageName
				/// </java-name>
				[Dot42.DexImport("resolvePackageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ResolvePackageName;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.ResolveInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResolveInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable LoadIcon(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getIconResource
				/// </java-name>
				[Dot42.DexImport("getIconResource", "()I", AccessFlags = 17)]
				public int GetIconResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIconResource
				/// </java-name>
				public int IconResource
				{
				[Dot42.DexImport("getIconResource", "()I", AccessFlags = 17)]
						get{ return GetIconResource(); }
				}

				/// <java-name>
				/// android/content/pm/ResolveInfo$DisplayNameComparator
				/// </java-name>
				[Dot42.DexImport("android/content/pm/ResolveInfo$DisplayNameComparator", AccessFlags = 9, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Landroid/content/pm/ResolveInfo;>;")]
				public partial class DisplayNameComparator : global::Java.Util.IComparator<global::Android.Content.Pm.ResolveInfo>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageManager;)V", AccessFlags = 1)]
						public DisplayNameComparator(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// compare
						/// </java-name>
						[Dot42.DexImport("compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I", AccessFlags = 17)]
						public int Compare(global::Android.Content.Pm.ResolveInfo resolveInfo, global::Android.Content.Pm.ResolveInfo resolveInfo1) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal DisplayNameComparator() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
						public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
								return default(bool);
						}

				}

		}

		/// <java-name>
		/// android/content/pm/ServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ServiceInfo", AccessFlags = 33)]
		public partial class ServiceInfo : global::Android.Content.Pm.ComponentInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// permission
				/// </java-name>
				[Dot42.DexImport("permission", "Ljava/lang/String;", AccessFlags = 1)]
				public string Permission;
				/// <java-name>
				/// FLAG_STOP_WITH_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_STOP_WITH_TASK", "I", AccessFlags = 25)]
				public const int FLAG_STOP_WITH_TASK = 1;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.ServiceInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ServiceInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ServiceInfo;)V", AccessFlags = 1)]
				public ServiceInfo(global::Android.Content.Pm.ServiceInfo serviceInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/pm/Signature
		/// </java-name>
		[Dot42.DexImport("android/content/pm/Signature", AccessFlags = 33)]
		public partial class Signature : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Pm.Signature> CREATOR;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public Signature(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Signature(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Signature(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "()[C", AccessFlags = 1)]
				public virtual char[] ToChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "([C[I)[C", AccessFlags = 1)]
				public virtual char[] ToChars(char[] @char, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// toCharsString
				/// </java-name>
				[Dot42.DexImport("toCharsString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToCharsString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Signature() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

